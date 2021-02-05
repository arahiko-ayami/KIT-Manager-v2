using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DataAccess;
using Models;

namespace KIT_Manager_v2.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Text = Program.ApplicationName;
            this.labelWrongInfo.Visible = false;
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            this.panelUsername.BackColor = Color.FromArgb(74, 79, 99);
            this.textBoxUsername.BackColor = Color.FromArgb(74, 79, 99);
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            this.panelPassword.BackColor = Color.FromArgb(74, 79, 99);
            this.textBoxPassword.BackColor = Color.FromArgb(74, 79, 99);
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            this.panelUsername.BackColor = Color.FromArgb(24, 30, 54);
            this.textBoxUsername.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            this.panelPassword.BackColor = Color.FromArgb(24, 30, 54);
            this.textBoxPassword.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (KitDataContext db = new KitDataContext())
                {
                    var salt = BCrypt.Net.BCrypt.GenerateSalt();
                    var pepper = "CsUd9KpJVD";
                    string username = textBoxUsername.Text;
                    string password = textBoxPassword.Text;
                    var resultStudent = db.Students.FirstOrDefault(s => s.Id.Equals(username));
                    var resultUser = db.Users.FirstOrDefault(s => s.Id.Equals(username));
                    if (resultUser == null)
                    {
                        if (resultStudent != null)
                        {
                            db.Users.Add(new User()
                            {
                                Id = resultStudent.Id,
                                Password = BCrypt.Net.BCrypt.HashPassword(pepper + password, salt),
                                Priority = Priority.User,
                                Salt = salt
                            });

                            db.SaveChanges();
                        }
                        else
                            this.labelWrongInfo.Visible = true;
                    }
                    else
                    {
                        var user = db.Users.FirstOrDefault(s => s.Id.Equals(username));
                        if (BCrypt.Net.BCrypt.Verify(pepper + password, user.Password) && user.Priority == Priority.Admin)
                        {
                            Thread thrd = new Thread(() =>
                            {
                                using (WelcomeForm welcomeForm = new WelcomeForm())
                                {
                                    Application.Run(welcomeForm);
                                }
                            });
                            thrd.Start();
                            this.Dispose();
                        }
                        else
                            this.labelWrongInfo.Visible = true;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}