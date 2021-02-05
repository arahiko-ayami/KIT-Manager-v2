using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using Models;

namespace KIT_Manager_v2.UI
{
    public partial class ProjectManageForm : Form
    {
        #region Variables
        
        private readonly string _windowName = Program.ApplicationName + " - Quản Lí Nhóm Nghiên Cứu";
        private String _oldName;
        private int _currPageNumber = 1;
        private double _pagesDouble;
        private int _pagesInt;
        private int _totalPages;
        private int _displayedRecordsNumber;
        private int _recordNumber;
        private readonly int _take = 22;
        private List<Group> GroupsList;
        
        #endregion

        public ProjectManageForm()
        {
            InitializeComponent();
            this.Text = _windowName;
            LoadData(0,22);
        }

        #region MyCustomMethods

        private void LoadDataGridView(int skip, int take)
        {
            var result = 
                GroupsList
                .OrderBy(s=>s.Id)
                .Skip(skip)
                .Take(take)
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Description
                });
                
            dataGridViewGroup.DataSource = result.ToList();
            dataGridViewGroup.Refresh();
            dataGridViewGroup.ClearSelection();
        }
        
        private void LoadData(int skip, int take)     //Get data from database
        {
            using (KitDataContext db = new KitDataContext())
            {
                try
                {
                    //Load data from database to local
                    db.Groups.Load();
                    GroupsList = db.Groups.Local.ToList();
                    
                    //Get number of pages
                    textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                    
                    //Load DataGridView
                    LoadDataGridView(skip, take);

                    //Resize columns
                    ResizeColumn();

                    //Clear Textboxes
                    ClearBoxes();
                
                    //Split Pages
                    SplitPages();
                    textBoxPageNum.Text = 1 + "/" + _totalPages;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void SplitPages()
        {
            _recordNumber = GroupsList.Count();
            labelQty.Text = "KIT hiện tại có " + _recordNumber + " nhóm";
            _displayedRecordsNumber = _recordNumber < _take ? _recordNumber : _take;
            _pagesDouble = _recordNumber / Convert.ToDouble(_take);
            _pagesInt = _recordNumber / _take;
            _totalPages = _pagesDouble > _pagesInt ? _pagesInt + 1 : _pagesInt;
            textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
        }
        
        private void ResizeColumn(){
            for (int i = 0; i < 2; i++)
            {
                dataGridViewGroup.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            
            dataGridViewGroup.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ClearBoxes()
        {
            textBoxID.Text = String.Empty;
            textBoxGroupName.Text = String.Empty;
            textBoxDescription.Text = String.Empty;
        }

        private void AddData()
        {
            try
            {
                if (textBoxGroupName.Text != String.Empty)
                {
                    using (KitDataContext db = new KitDataContext())
                    {
                        Group newGroup = new Group()
                        {
                            Name = textBoxGroupName.Text,
                            Description = textBoxDescription.Text,
                            Students = new List<Student>()
                        };

                        db.Groups.Add(newGroup);
                        db.SaveChanges();
                    }
                    LoadData(0,_take);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Delete(int id)
        {
            try
            {
                using (KitDataContext db = new KitDataContext())
                {
                    var result =
                        from s in db.Groups
                        where s.Id == id
                        select s;

                    var deleteItems = result.ToList();

                    foreach (var deleteItem in deleteItems)
                    {
                        db.Groups.Remove(deleteItem);
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Modify()
        {
            try
            {
                using (KitDataContext db = new KitDataContext())
                {
                    var result = db.Groups.Find(textBoxID.Text);

                    if (!(result.Name.Equals(textBoxGroupName.Text) ||
                          result.Description.Equals(textBoxDescription.Text)))
                    {
                        result.Name = textBoxGroupName.Text;
                        result.Description = textBoxDescription.Text;
                    }

                    db.SaveChanges(); 
                    dataGridViewGroup.Refresh();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        #endregion

        #region Event
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void dataGridViewGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowNo = e.RowIndex;
                ClearBoxes();
                if (rowNo > -1)
                {
                    textBoxID.Text = dataGridViewGroup.Rows[rowNo].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(textBoxID.Text);
                    using (KitDataContext db = new KitDataContext())
                    {
                        var result = db.Groups
                            .FirstOrDefault(s => s.Id == id);

                        dataGridViewMember.DataSource = result.Students.Select(s => new
                        {
                            s.Id,
                            s.Name,
                            s.DateOfBirth,
                            s.Class
                        }).ToList();
                        
                        dataGridViewMember.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                    
                    if (dataGridViewGroup.Rows[rowNo].Cells[1].Value != null)
                        _oldName = textBoxGroupName.Text = dataGridViewGroup.Rows[rowNo].Cells[1].Value.ToString();

                    if (dataGridViewGroup.Rows[rowNo].Cells[2].Value != null)
                        textBoxDescription.Text = dataGridViewGroup.Rows[rowNo].Cells[2].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddMemberToGroup add = new AddMemberToGroup(Convert.ToInt32(textBoxID.Text));
            add.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = DialogResult.None;
            if (!textBoxID.Text.Equals(string.Empty))
                confirm = MessageBox.Show("Bạn có muốn xoá " + textBoxGroupName.Text + " không?", "Bạn có chắc chắn?",
                    MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int id = 0;
                    foreach (DataGridViewRow row in dataGridViewGroup.SelectedRows)
                    {
                        id = (int) row.Cells[0].Value;
                    }
                    Delete(id);
                    MessageBox.Show("Xoá thành công!", Program.ApplicationName);
                    LoadData(0,_take);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadData(0,_take);
        }

        private void textBoxSearchByName_TextChanged(object sender, EventArgs e)
        {
            using (KitDataContext db = new KitDataContext())
            {
                var result = GroupsList
                    .Where(s => s.Name.Contains(toolStripTxtBoxSearch.Text))
                    .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Description
                });
                dataGridViewGroup.DataSource = result.ToList();
                ResizeColumn();
                dataGridViewGroup.ClearSelection();
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            String newInfo = "Thông tin sẽ được sửa thành:"
                             + "\nMã Nhóm: " + textBoxID.Text
                             + "\nTên Nhóm: " + textBoxGroupName.Text
                             + "\nMô Tả: " + textBoxDescription.Text;

            DialogResult confirm = DialogResult.None;
            if (!textBoxID.Text.Equals(string.Empty))
                confirm = MessageBox.Show("Bạn có muốn thay đổi " + _oldName + " không?" + "\n" + newInfo,
                    "Bạn có chắc chắn?",
                    MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Modify();
            }
        }

        private void MemberManageForm_Shown(object sender, EventArgs e)
        {
            dataGridViewGroup.ClearSelection();
            ClearBoxes();
        }

        private void toolStripTxtBoxSearch_Enter(object sender, System.EventArgs e)
        {
            if (String.CompareOrdinal(toolStripTxtBoxSearch.Text,"Search...") == 0)
            {
                toolStripTxtBoxSearch.Text = "";
                toolStripTxtBoxSearch.ForeColor = Color.Black;
            }
        }

        //Events of Arrow Buttons
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (_currPageNumber < _totalPages)
            {
                //Count number of records on database
                _currPageNumber++;
                textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                //Load DataGridView
                LoadDataGridView(_displayedRecordsNumber,_take);
                _displayedRecordsNumber += _take;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (_currPageNumber > 1 && _currPageNumber < _totalPages)
            {
                _currPageNumber--;
                textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                //Load DataGridView
                LoadDataGridView((_currPageNumber*_take)-_take,_take);
                _displayedRecordsNumber -= _take;
            }
            else if (_currPageNumber == _totalPages)
            {
                _currPageNumber--;
                textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                //Load DataGridView
                int skip = _recordNumber
                           - (_take - _displayedRecordsNumber + _recordNumber) 
                           -  _take;
                LoadDataGridView(skip,_take);
                _displayedRecordsNumber -= _take;
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (_currPageNumber < _totalPages)
            {
                //Count number of records on database
                _currPageNumber = _totalPages;
                textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                //Load DataGridView
                LoadDataGridView(_take*(_totalPages-1),_take);
                _displayedRecordsNumber = _take*_totalPages;
            }
        }
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            LoadDataGridView(0,_take);
            _currPageNumber = 1;
            textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
            _displayedRecordsNumber = _take;
        }

        #endregion
    }
}
