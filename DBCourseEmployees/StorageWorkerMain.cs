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
    
    public partial class StorageWorkerMain : Form
    {
        OleDbConnection cn;
        String username;
        public StorageWorkerMain(OleDbConnection cn, String username)
        {
            InitializeComponent();
            this.cn = cn;
            this.username = username;
        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorageManagment storage = new StorageManagment(cn, username);
            storage.MdiParent = this;
            storage.Show();
        }

        private void продукцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopManagment shop = new ShopManagment(cn, username);
            shop.MdiParent = this;
            shop.Show();
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(cn, username);
            profile.MdiParent = this;
            profile.Show();
        }

        private void StorageWorkerMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void StorageWorkerMain_Load(object sender, EventArgs e)
        {

        }
    }
}
