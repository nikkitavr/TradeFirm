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

    public partial class DirectorMainForm : Form
    {
        String username;
        public DirectorMainForm(OleDbConnection cn, String username)
        {
            InitializeComponent();
            this.cn = cn;
            this.username = username;
            
        }

        OleDbConnection cn;

        private void DirectorMainForm_FormClosing(object sender, FormClosingEventArgs e)
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


        private void DirectorMainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lk_button_Click(object sender, EventArgs e)
        {

        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьСотрудникаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PositionsManagment positionsManament = new PositionsManagment(cn);
            positionsManament.MdiParent = this;
            positionsManament.Show();
        }

       

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(cn, username);
            profile.MdiParent = this;
            profile.Show();
        }

        private void добавлениеСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker(cn);
            addWorker.MdiParent = this;
            addWorker.Show();

        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesManagment employeesManagment = new EmployeesManagment(cn);
            employeesManagment.MdiParent = this;
            employeesManagment.Show();
        }

        private void данныеОПозицияхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void добавитьПоставщикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplier add = new AddSupplier(cn);
            add.MdiParent = this;
            add.Show();
        }

        private void категорииТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesManagment categories = new CategoriesManagment(cn);
            categories.MdiParent = this;
            categories.Show();
        }

        private void списокТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductionManagment productionManagment = new ProductionManagment(cn);
            productionManagment.MdiParent = this;
            productionManagment.Show();
        }

        private void списокПоставщиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSuppliers manageSuppliers = new ManageSuppliers(cn);
            manageSuppliers.MdiParent = this;
            manageSuppliers.Show();
        }
    }

    
}
