using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using Models;

namespace KIT_Manager_v2.UI
{
    public partial class MemberManageForm : Form
    {
        #region Variables
        
        private readonly string _windowName = Program.ApplicationName + " - Quản Lí Thành Viên";
        private String _oldId;
        private String _oldName;
        private int _currPageNumber = 1;
        private double _pagesDouble;
        private int _pagesInt;
        private int _totalPages;
        private int _displayedRecordsNumber;
        private int _recordNumber;
        private readonly int _take = 22;
        private List<Student> StudentsList;
        
        #endregion

        public MemberManageForm()
        {
            InitializeComponent();
            this.Text = _windowName;
            comboBoxFilterClass.Enabled = false;
            LoadData(0,_take);
        }

        //My custom methods

        #region MyCustomMethods

        private void LoadDataGridView(int skip, int take)
        {
            var result = 
                StudentsList
                .OrderBy(s=>s.Id)
                .Skip(skip)
                .Take(take)
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Contact.PhoneNumber,
                    s.Class,
                    s.Gender,
                    s.DateOfBirth,
                    s.Contact.Email
                });
                
            dataGridView.DataSource = result.ToList();
            dataGridView.Refresh();
            dataGridView.ClearSelection();
            dataGridView.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        
        private void LoadData(int skip, int take)     //Get data from database
        {
            using (KitDataContext db = new KitDataContext())
            {
                try
                {
                    //Load data from database to local
                    db.Students.Load();
                    StudentsList = db.Students.Local.ToList();
                    
                    //Get number of pages
                    textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                    
                    //Load DataGridView
                    LoadDataGridView(skip, take);

                    //Resize columns
                    ResizeColumn();

                    //Load ComboBox
                    LoadComboBox();

                    //Get today's date
                    dateTimePicker.MaxDate = DateTime.Today;

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
            _recordNumber = StudentsList.Count(); /*db.Database.ExecuteSqlCommand("select count(Id) from Students");*/
            labelQty.Text = "KIT hiện tại có " + _recordNumber + " thành viên";
            _displayedRecordsNumber = _recordNumber < _take ? _recordNumber : _take;
            _pagesDouble = _recordNumber / Convert.ToDouble(_take);
            _pagesInt = _recordNumber / _take;
            _totalPages = _pagesDouble > _pagesInt ? _pagesInt + 1 : _pagesInt;
            textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
        }
        
        private void ResizeColumn(){
            for (int i = 0; i < 6; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            
            dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void LoadComboBox()     //Get data from database to class combobox
        {
            var result =
                    from s in StudentsList
                    group s by s.Class;

            List<string> cl = new List<string>();

            foreach (var data in result)
            {
                cl.Add(data.Key);
            }

            comboBoxFilterClass.DataSource = cl;
            
    }

        private void ClearBoxes()
        {
            textBoxID.Text = String.Empty;
            textBoxName.Text = String.Empty;
            textBoxClass.Text = String.Empty;
            textBoxPhoneNum.Text = String.Empty;
            textBoxEmail.Text = String.Empty;
            radioBtnFemale.Checked = radioBtnMale.Checked = false;
            dateTimePicker.Value = DateTime.Today;
        }

        private Gender? SetGender()      
        {
            if (radioBtnMale.Checked)
                return Gender.Nam;
            else if (radioBtnFemale.Checked)
                return Gender.Nữ;
            else
                return Gender.Chưa_rõ;
        }

        private void GetGender(string gender)
        {
            if (gender != string.Empty)
            {
                if (radioBtnMale.Text.Equals(gender))
                    radioBtnMale.Checked = true;
                else if (radioBtnFemale.Text.Equals(gender))
                    radioBtnFemale.Checked = true;
            }
        }

        private void QueryByClass()
        {
            var result = StudentsList
                .Where(s => String.Compare(s.Class, comboBoxFilterClass.SelectedItem.ToString(), StringComparison.Ordinal)==0)
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Contact.PhoneNumber,
                    s.Class,
                    s.Gender,
                    s.DateOfBirth,
                    s.Contact.Email
                });

            dataGridView.DataSource = result.ToList();
        }

        private void AddData()
        {
            try
            {
                if (textBoxID.Text != String.Empty && textBoxName.Text != string.Empty)
                {
                    using (KitDataContext db = new KitDataContext())
                    {
                        var pepper = "CsUd9KpJVD";
                        var salt = BCrypt.Net.BCrypt.GenerateSalt();
                        Student newMember = new Student()
                        {
                            Id = textBoxID.Text,
                            Name = textBoxName.Text,
                            DateOfBirth = dateTimePicker.Value,
                            Class = textBoxClass.Text,
                            Gender = SetGender(),
                            Contact = new Contact()
                            {
                                PhoneNumber = textBoxPhoneNum.Text,
                                Email = textBoxEmail.Text
                            },
                            User = new User()
                            {
                                Password = BCrypt.Net.BCrypt.HashPassword(pepper + dateTimePicker.Value.Date, salt),
                                Salt = salt,
                                Priority = Priority.User
                            }
                        };

                        db.Students.Add(newMember);
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

        private void Delete(String id)
        {
            try
            {
                using (KitDataContext db = new KitDataContext())
                {
                    var result = db.Students.FirstOrDefault(s => s.Id.Equals(id));
                    var user = db.Users.FirstOrDefault(s => s.Id.Equals(id));

                    db.Users.Remove(user);
                    db.Students.Remove(result);

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
                    var result = db.Students.Find(_oldId);

                    if (!result.Id.Equals(textBoxID.Text))
                    {
                        Delete(result.Id);
                        AddData();
                    }

                    else
                    {
                        result.Name = textBoxName.Text;
                        result.Class = textBoxClass.Text;
                        result.DateOfBirth= DateTime.Parse(dateTimePicker.Value.ToString());
                        result.Contact.PhoneNumber = textBoxPhoneNum.Text;
                        result.Contact.Email = textBoxEmail.Text;
                        result.Gender = SetGender();
                    }

                    db.SaveChanges();
                    //MessageBox.Show("Sửa thành viên thành công!", Program.applicationName);
                    dataGridView.Refresh();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        #endregion

        //Event

        #region Event
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowNo = e.RowIndex;
                ClearBoxes();
                if (rowNo > -1)
                {
                    if (dataGridView.Rows[rowNo].Cells[0].Value != null)
                        _oldId = textBoxID.Text = dataGridView.Rows[rowNo].Cells[0].Value.ToString();

                    if (dataGridView.Rows[rowNo].Cells[1].Value != null)
                        _oldName = textBoxName.Text = dataGridView.Rows[rowNo].Cells[1].Value.ToString();

                    if (dataGridView.Rows[rowNo].Cells[2].Value != null)
                        textBoxPhoneNum.Text = dataGridView.Rows[rowNo].Cells[2].Value.ToString();

                    if (dataGridView.Rows[rowNo].Cells[3].Value != null)
                        textBoxClass.Text = dataGridView.Rows[rowNo].Cells[3].Value.ToString();

                    if (dataGridView.Rows[rowNo].Cells[4].Value != null)
                        GetGender(dataGridView.Rows[rowNo].Cells[4].Value.ToString());
                    else
                        radioBtnMale.Checked = radioBtnFemale.Checked = false;

                    if (dataGridView.Rows[rowNo].Cells[5].Value != null)
                        dateTimePicker.Value = DateTime.Parse(dataGridView.Rows[rowNo].Cells[5].Value.ToString());

                    if (dataGridView.Rows[rowNo].Cells[6].Value != null)
                        textBoxEmail.Text = dataGridView.Rows[rowNo].Cells[6].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = DialogResult.None;
            if (!textBoxID.Text.Equals(string.Empty))
                confirm = MessageBox.Show("Bạn có muốn xoá " + textBoxName.Text + " không?", "Bạn có chắc chắn?",
                    MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    String id = null;
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        id = row.Cells[0].Value.ToString();
                    }
                    Delete(id);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                MessageBox.Show("Xoá thành công!", Program.ApplicationName);
                LoadData(0, _take);
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
                var result = StudentsList
                    .Where(s => s.Name.ToLower().Contains(toolStripTxtBoxSearch.Text.ToLower()))
                    .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Contact.PhoneNumber,
                    s.Class,
                    s.Gender,
                    s.DateOfBirth,
                    s.Contact.Email
                });
                dataGridView.DataSource = result.ToList();
                ResizeColumn();
                dataGridView.ClearSelection();
            }
        }

        private void comboBoxFilterClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (chkBoxFilterClass.Checked)
            {
                dataGridView.ClearSelection();
                QueryByClass();
            }
        }

        private void chkBoxFilterClass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxFilterClass.Checked)
            {
                comboBoxFilterClass.Enabled = true;
                QueryByClass();
            }
            else
            {
                comboBoxFilterClass.Enabled = false;
                LoadDataGridView(0,_take);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            String newInfo = "Thông tin sẽ được sửa thành:"
                             + "\nMã Sinh Viên: " + textBoxID.Text
                             + "\nHọ tên: " + textBoxName.Text
                             + "\nGiới Tính: " + SetGender()
                             + "\nNgày Sinh: " + dateTimePicker.Value.ToString("dd/MM/yyyy")
                             + "\nLớp: " + textBoxClass.Text
                             + "\nSố Điện Thoại: " + textBoxPhoneNum.Text
                             + "\nGhi Chú: " + textBoxEmail.Text;

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
            dataGridView.ClearSelection();
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

        #region HiddenFunction
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (KitDataContext db =new KitDataContext())
            {
                Random rand = new Random();
                int random = rand.Next(1, db.Students.Count()-1);
                var result = db.Students
                    .OrderBy(s => s.Id)
                    .Skip(random)
                    .Take(1)
                    .Select(s => new
                    {
                        s.Id,
                        s.Name,
                        s.Contact.PhoneNumber,
                        s.Class,
                        s.Gender,
                        s.DateOfBirth,
                        s.Contact.Email
                    });

                dataGridView.DataSource = result.ToList();
                dataGridView.ClearSelection();
                dataGridView.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        #endregion
    }
}