using System;
using System.Threading;
using System.Windows.Forms;

namespace KIT_Manager_v2.UI
{
    public partial class WelcomeForm : Form
    {
        private readonly string _windowName = Program.ApplicationName;

        public WelcomeForm()
        {
            InitializeComponent();
            this.Text = _windowName;
        }

        private void quảnLíThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread memManageThread = new Thread(() =>
            {
                using (MemberManageForm memberManageForm = new MemberManageForm())
                {
                    Application.Run(memberManageForm);
                }
            }){IsBackground = true};
            memManageThread.Start();
        }

        private void quảnLíNhómNghiênCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ProjectManageForm projectManageForm = new ProjectManageForm() {Visible = true};
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm() {Visible = true};
        }
    }
}