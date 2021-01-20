using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using DataAccess;
using Models;

namespace KIT_Manager_v2
{
    public partial class LoadData : Form
    {
        public LoadData()
        {
            InitializeComponent();
            Loading();
        }

        private void Loading()
        {
            using (var db = new KitDataContext())
            {
                var result = (from s in db.Students select new
                {
                    s.Id,
                    s.Name,
                    s.Class,
                    s.Gender,
                    s.Contact.Email,
                    s.Contact.PhoneNumber
                });
                this.dataGridView1.DataSource = result.ToList();
            }
        }
    }
}