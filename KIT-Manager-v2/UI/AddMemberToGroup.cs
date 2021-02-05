using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using Models;

namespace KIT_Manager_v2.UI
{
    public partial class AddMemberToGroup : Form
    {
        #region Variables
        
        private readonly string _windowName = Program.ApplicationName;
        private List<Student> StudentsList;
        private List<Student> StudentsInGroupList;
        private int _groupId;
        private int _rowNo;

        #endregion

        public AddMemberToGroup(int groupId)
        {
            InitializeComponent();
            this._groupId = groupId;
            LoadData();
            this.Text= Program.ApplicationName + " - Quản Lí Thành Viên Nhóm";
            //Disable Buttons
            buttonAdd.Enabled = false;
            buttonRemove.Enabled = false;
        }


        #region MyCustomMethods

        private void LoadDataGridView(DataGridView dataGridView, List<Student> Students)
        {
            var result = 
                Students
                .OrderBy(s=>s.Id)
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Class,
                    s.Gender,
                    s.DateOfBirth,
                });
                
            dataGridView.DataSource = result.ToList();
            dataGridView.Refresh();
            dataGridView.ClearSelection();
            dataGridView.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        
        private void LoadData()     //Get data from database
        {
            using (KitDataContext db = new KitDataContext())
            {
                try
                {
                    //Load data from database to local memory
                    db.Students.Load();
                    db.Groups.Load();
                    StudentsList = db.Students.Local.ToList();

                    //Load DataGridView
                    LoadDataGridView(dataGridViewStudentOnDb, StudentsList);
                    var result = db.Groups.Local
                        .Where(s => s.Id == _groupId)
                        .SelectMany(s => s.Students);
                    StudentsInGroupList = result.ToList();
                    LoadDataGridView(dataGridViewStudentInGroup, StudentsInGroupList);

                    //Resize columns
                    ResizeColumn();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void ResizeColumn(){
            for (int i = 0; i < 4; i++)
            {
                dataGridViewStudentOnDb.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewStudentInGroup.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            
            dataGridViewStudentOnDb.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewStudentInGroup.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        #endregion

        private void textBoxSearchFromDb_TextChanged(object sender, EventArgs e)
        {
            var result = StudentsList
                .Where(s => s.Name.Contains(textBoxSearchFromDb.Text));
            LoadDataGridView(dataGridViewStudentOnDb, result.ToList());
        }

        private void textBoxSearchFromGroup_TextChanged(object sender, EventArgs e)
        {
            var result = StudentsInGroupList
                .Where(s => s.Name.Contains(textBoxSearchFromGroup.Text));
            LoadDataGridView(dataGridViewStudentInGroup, result.ToList());

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridViewStudentOnDb.Rows[_rowNo].Cells[0].Value.ToString();

                using (KitDataContext db = new KitDataContext())
                {
                    var result = db.Groups.Find(_groupId);
                    var stu = db.Students.FirstOrDefault(s => s.Id.Equals(id));
                    result.Students.Add(stu);
                    db.SaveChanges();
                }
            
                LoadData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string id = dataGridViewStudentInGroup.Rows[_rowNo].Cells[0].Value.ToString();
            
            var student = StudentsList.FirstOrDefault(s=> s.Id.Equals(id));

            using (KitDataContext db = new KitDataContext())
            {
                var result = db.Groups.Find(_groupId);
                var stu = db.Students.FirstOrDefault(s => s.Id.Equals(student.Id));
                result.Students.Remove(stu);
                db.SaveChanges();
            }

            LoadData();
        }
        
        private void dataGridViewStudentOnDb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonRemove.Enabled = false;
            _rowNo = e.RowIndex;
            buttonAdd.Enabled = true;
        }

        private void dataGridViewStudentInGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Enabled = false;
            _rowNo = e.RowIndex;
            buttonRemove.Enabled = true;
        }
    }
}
