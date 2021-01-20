using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using Models;

/*using Models;*/

namespace KIT_Manager_v2.UI
{
    public partial class MemberManageForm : Form
    {
        private readonly string _windowName = Program.ApplicationName + " - Quản Lí Thành Viên";
        private String _oldId;
        private String _oldName;
        private int _currPageNumber = 1;
        private double _pagesDouble;
        private int _pagesInt;
        private int _totalPages;
        private int _displayedRecordsNumber;
        private int recordNumber;

        public MemberManageForm()
        {
            InitializeComponent();
            this.Text = _windowName;
            comboBoxFilterClass.Enabled = false;
            using (KitDataContext db = new KitDataContext())
            {
                recordNumber = db.Students.Count();
                labelQty.Text = "KIT hiện tại có " + recordNumber + " thành viên";
                _displayedRecordsNumber = recordNumber < 22 ? recordNumber : 22;
                _pagesDouble = recordNumber / 22.0;
                _pagesInt = recordNumber / 22;
                _totalPages = _pagesDouble > _pagesInt ? _pagesInt + 1 : _pagesInt;
                LoadData(db);
            }
        }

        //My custom methods

        #region MyCustomMethods

        private void LoadDataGridView(KitDataContext db)
        {
            var result = db.Students.Take(22).Select(s => new
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
        private void LoadData(KitDataContext db)     //Get data from database
        {
            try
            {
                //Count number of records on database
                recordNumber = db.Students.Count();
                labelQty.Text = "KIT hiện tại có " + recordNumber + " thành viên";
                textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                //Load DataGridView
                LoadDataGridView(db);

                //Resize columns
                ResizeColumn();

                //Load ComboBox
                LoadComboBox(db);

                //Get today's date
                dateTimePicker.MaxDate = DateTime.Today;

                //Clear Textboxes
                ClearBoxes();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        private void ReloadData()     //Get data from database
        {
            try
            {
                
                using (KitDataContext db = new KitDataContext())
                {
                    //Count number of records on database
                    recordNumber = db.Students.Count();
                    labelQty.Text = "KIT hiện tại có " + recordNumber + " thành viên";
                    double pagesDouble = db.Students.Count() / 22;
                    int pagesInt = db.Students.Count() / 22;
                    textBoxPageNum.Text = _currPageNumber + "/" + Convert.ToString(pagesDouble > pagesInt ? pagesInt+1 : pagesInt);
                    //Load DataGridView
                    LoadDataGridView(db);
            
                    //Resize columns
                    ResizeColumn();

                    //Load ComboBox
                    LoadComboBox(db);

                    //Get today's date
                    dateTimePicker.MaxDate = DateTime.Today;

                    //Clear Textboxes
                    ClearBoxes();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ResizeColumn(){
            for (int i = 0; i < 6; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            
            dataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void LoadComboBox(KitDataContext db)     //Get data from database to class combobox
        {
            try
            {
                var result =
                    from s in db.Students
                    group s by s.Class;

                List<string> cl = new List<string>();

                foreach (var data in result)
                {
                    cl.Add(data.Key);
                }

                comboBoxFilterClass.DataSource = cl;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
            using (KitDataContext db = new KitDataContext())
            {
                var result = db.Students
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
        }

        private void AddData()
        {
            try
            {
                if (textBoxID.Text != String.Empty && textBoxName.Text != string.Empty)
                {
                    using (KitDataContext db = new KitDataContext())
                    {
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
                            }
                        };

                        db.Students.Add(newMember);
                        db.SaveChanges();
                        ReloadData();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Delete(String id)
        {
            using (KitDataContext db = new KitDataContext())
            {
                var result =
                    from s in db.Students
                    where s.Id == id
                    select s;

                var deleteItems = result.ToList();

                foreach (var deleteItem in deleteItems)
                {
                    db.Students.Remove(deleteItem);
                }

                db.SaveChanges();
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
            try
            {
                AddData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
                    MessageBox.Show("Xoá thành công!", Program.ApplicationName);
                    ReloadData();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void textBoxSearchByName_TextChanged(object sender, EventArgs e)
        {
            using (KitDataContext db = new KitDataContext())
            {
                var result = db.Students
                    .Where(s => s.Name.Contains(toolStripTxtBoxSearch.Text))
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
                ReloadData();
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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
            try
            {
                using (KitDataContext db = new KitDataContext())
                {
                    if (_currPageNumber < _totalPages)
                    {
                        //Count number of records on database
                        _currPageNumber++;
                        textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                        //Load DataGridView
                        var result = db.Students
                            .OrderBy(s => s.Id).Skip(_displayedRecordsNumber)
                            .Take(22)
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
                        _displayedRecordsNumber += 22;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                using (KitDataContext db = new KitDataContext())
                {
                    if (_currPageNumber > 1 && _currPageNumber < _totalPages)
                    {
                        //Count number of records on database
                        _currPageNumber--;
                        textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                        //Load DataGridView
                        var result = db.Students
                            .OrderBy(s => s.Id)
                            .Skip((_currPageNumber*22)-22)
                            .Take(22)
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
                        _displayedRecordsNumber -= 22;
                    }
                    else if (_currPageNumber == _totalPages)
                    {
                        //Count number of records on database
                        _currPageNumber--;
                        textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                        //Load DataGridView
                        var result = db.Students
                            .OrderBy(s => s.Id)
                            .Skip(db.Students.Count() - (22 - _displayedRecordsNumber + db.Students.Count()) - 22)
                            .Take(22)
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
                        _displayedRecordsNumber -= 22;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            try
            {
                using (KitDataContext db = new KitDataContext())
                {
                    if (_currPageNumber < _totalPages)
                    {
                        //Count number of records on database
                        _currPageNumber = _totalPages;
                        textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
                        //Load DataGridView
                        var result = db.Students
                            .OrderBy(s => s.Id)
                            .Skip(22*(_totalPages-1))
                            .Take(22)
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
                        _displayedRecordsNumber = 22*_totalPages;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            using(KitDataContext db = new KitDataContext())
                LoadDataGridView(db);
            _currPageNumber = 1;
            textBoxPageNum.Text = _currPageNumber + "/" + _totalPages;
            _displayedRecordsNumber = 22;
        }
        
        #endregion

        #region hidden function
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