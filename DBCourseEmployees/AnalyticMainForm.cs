using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBCourseEmployees
{
    public partial class AnalyticMainForm : Form
    {
        OleDbConnection cn;
        String username;
        public AnalyticMainForm(OleDbConnection cn, String username)
        {
            InitializeComponent();
            this.cn = cn;
            this.username = username;
        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics(cn, username);
            analytics.MdiParent = this;
            analytics.Show();

        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(cn, username);
            profile.MdiParent = this;
            profile.Show();
        }

        private void AnalyticMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                cn.Close();
                loginForm loginForm = new loginForm();
                loginForm.Show();
            }
        }

        private void AnalyticMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
