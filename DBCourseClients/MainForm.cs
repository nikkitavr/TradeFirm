using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCourseClients
{
    public partial class MainForm : Form
    {
        ToolStripDropDown dd;

        public MainForm()
        {
            InitializeComponent();
            try
            {
                cn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Не удается установить соединение с базой. Обратитесь к администратору." +
                    "\nОшибка:" + e.ToString(), "Ошибка!");
                //isSystemExit = true;
                this.Close();
            }
            dd = личныйКабинетToolStripMenuItem.DropDown;


        }

        private void каталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog(cn);
            catalog.MdiParent = this;
            catalog.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void моиЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {   
           
        }

        private void моиЗаказыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Orders orders = new Orders(cn);
            orders.MdiParent = this;
            orders.Show();
        }

        private void профилToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserInfo userInfo = new UserInfo(cn);
            userInfo.MdiParent = this;
            userInfo.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            Program.username = "";
            foreach(Form form in this.MdiChildren)
            {
                form.Close();
            }
            MessageBox.Show("Вы вышли из аккаунта");
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void личныйКабинетToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (Program.username == "")
            {
                личныйКабинетToolStripMenuItem.DropDown = null;
                LoginForm login = new LoginForm(cn);
                login.Show();
                return;
            }
            личныйКабинетToolStripMenuItem.DropDown = dd;
        }

        private void tempToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                cn.Close();
            }
        }
    }
}
