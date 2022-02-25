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
    public partial class EmployeesManagment : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataTable dt;
        bool isChooseFreeze;
        OleDbDataAdapter daFull;
        DataTable dtFull;
        String pPost;
        String pSalsry;

        public EmployeesManagment(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;


            //"SELECT Employees.id AS \"Номер сотрудника\", Employees.fio AS \"ФИО\", Posts.title AS \"Должность\" " +
            //"FROM Employees LEFT JOIN POSTS ON Employees.postId = Posts.id"
            da = new OleDbDataAdapter("SELECT Employees.id AS \"Номер сотрудника\", Employees.fio AS \"ФИО\", Posts.title AS \"Должность\" " +
                "FROM Employees LEFT JOIN POSTS ON Employees.postId = Posts.id", cn);
            dt = new DataTable("Employees");
            da.Fill(dt);

            dg_employees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_employees.DataSource = dt;
            dg_employees.ReadOnly = true;
            dg_employees.AllowUserToAddRows = false;

            daFull = new OleDbDataAdapter("SELECT Employees.id AS \"eId\", fio, postId, title, salary, email, hireDate, bonus, phone " +
                "FROM Employees LEFT JOIN Posts ON Employees.postId = Posts.id JOIN EmployeesDetails ON Employees.id = employeeId", cn);
            dtFull = new DataTable("EmployeesFull");
            daFull.Fill(dtFull);

            OleDbCommand sP = new OleDbCommand("SELECT title FROM Posts", cn);
            OleDbDataReader rdr = sP.ExecuteReader();
            while (rdr.Read())
                cb_post2.Items.Add(rdr["title"]);
            rdr.Close();

            cb_filter.SelectedItem = "Имени";
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).ReadOnly = true;
                }
            }
            txt_find.ReadOnly = false;
            disableTxt();
            hideBtns();
        }

        private void dg_update()
        {
            da.Dispose();
            dt.Dispose();
            da = new OleDbDataAdapter("SELECT Employees.id AS \"Номер сотрудника\", Employees.fio AS \"ФИО\", Posts.title AS \"Должность\" " +
                "FROM Employees LEFT JOIN POSTS ON Employees.postId = Posts.id", cn);
            dt = new DataTable("Employees");
            da.Fill(dt);
            dg_employees.DataSource = dt;

            daFull.Dispose();
            dtFull.Dispose();
            daFull = new OleDbDataAdapter("SELECT Employees.id AS \"eId\", fio, postId, title, salary, email, hireDate, bonus, phone " +
                "FROM Employees LEFT JOIN Posts ON Employees.postId = Posts.id JOIN EmployeesDetails ON Employees.id = employeeId", cn);
            dtFull = new DataTable("EmployeesFull");
            daFull.Fill(dtFull);
        }



        

        private void txt_find_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (txt_find.Text == "")
                {
                    dg_employees.DataSource = dt;

                }
                else
                {
                    DataView dv = dt.DefaultView;
                    switch (cb_filter.SelectedItem.ToString())
                    {
                        case "Имени":
                            dv.RowFilter = string.Format("ФИО like '%{0}%'", txt_find.Text);
                            dg_employees.DataSource = dv.ToTable();
                            break;
                        case "Номеру":
                            dv.RowFilter = string.Format("[Номер сотрудника] = '{0}'", txt_find.Text);
                            dg_employees.DataSource = dv.ToTable();
                            break;
                    }
                }
              
            }
        }



        private void disableTxt()
        {
            txt_salary.ReadOnly = true;
            cb_post2.Hide();
            txt_post.Show();
        }
        private void ableTxt()
        {
            txt_post.ReadOnly = false;
            txt_salary.ReadOnly = false;
            cb_post2.SelectedItem = txt_post.Text;
            txt_post.Hide();
            cb_post2.Show();
        }
        private void hideBtns()
        {
            btn_cancel.Hide();
            btn_fire.Hide();
            btn_save.Hide();

            btn_change.Show();
        }
        private void showBtns()
        {
            btn_cancel.Show();
            btn_fire.Show();
            btn_save.Show();

            btn_change.Hide();
        }

        private void dg_employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private String chooseById(int id, String col)
        {
            DataRow row = (dtFull.Select("eId = '" + id + "'"))[0];
            if(col == "salary")
            {
                int salary = int.Parse(row[col].ToString());
                int bonus = int.Parse(row["bonus"].ToString());
                return (salary + bonus).ToString();
            }
            return row[col].ToString();
        }



        private void cb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txt_mail_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_post_TextChanged(object sender, EventArgs e)
        {

        }
        private void EmployeeesManagment_Load(object sender, EventArgs e)
        {

        }

        private void dg_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isChooseFreeze)
            {
                txt_id.Text = dg_employees.SelectedRows[0].Cells["Номер сотрудника"].Value.ToString();
                int id = int.Parse(txt_id.Text);

                txt_fio.Text = chooseById(id, "fio");
                txt_mail2.Text = chooseById(id, "email");
                txt_phone.Text = chooseById(id, "phone");
                txt_hDate.Text = chooseById(id, "hireDate");
                txt_post.Text = chooseById(id, "title");
                txt_salary.Text = chooseById(id, "salary");
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            isChooseFreeze = true;
            ableTxt();
            showBtns();
            pPost = txt_post.Text;
            pSalsry = txt_salary.Text;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_salary.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка");
            } else if (Program.intOverFlow(txt_salary.Text))
            {
                MessageBox.Show("Числовые значения должны быть менше чем " + int.MaxValue, "Внимание!");
            }
            else
            {
                OleDbCommand iP = new OleDbCommand("UPDATE Employees SET postId = ? WHERE id = ?", cn);
                iP.Parameters.Add("@p2", OleDbType.Integer);
                iP.Parameters.Add("@p3", OleDbType.Integer);

                int post_id = int.Parse(getPostId(cb_post2.SelectedItem.ToString()));
                iP.Parameters[0].Value = post_id.ToString();
                iP.Parameters[1].Value = txt_id.Text.ToString();

                try
                {
                    iP.ExecuteNonQuery();
               
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    return;
                }

                OleDbCommand iP2 = new OleDbCommand("UPDATE EmployeesDetails SET bonus = ? WHERE employeeId = ?", cn);
                iP2.Parameters.Add("@p1", OleDbType.Decimal);
                iP2.Parameters.Add("@p2", OleDbType.Integer);
                iP2.Parameters[0].Value = getBonus(post_id, int.Parse(txt_salary.Text)).ToString();
                iP2.Parameters[1].Value = txt_id.Text;
                try
                {
                    iP2.ExecuteNonQuery();
                    MessageBox.Show("Информация была успешно обновлена", "Успех!");
                    setNull();
                    hideBtns();
                    disableTxt();
                    dg_update();
                    pPost = "";
                    pSalsry = "";
                    isChooseFreeze = false;
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                }


            }
        }

        private String getPostId(String title)
        {
            OleDbCommand sPid = new OleDbCommand("SELECT id FROM Posts WHERE title = ?", cn);
            sPid.Parameters.Add("@p1", OleDbType.VarChar, 50);
            sPid.Parameters[0].Value = title;
            return Program.selectFirstFrom(sPid, "id");
        }

        private int getBonus(int postId, int txt)
        {
            DataRow row = (dtFull.Select("postId = '" + postId + "'"))[0];
            int salary = int.Parse(row["salary"].ToString());
            int bonus = txt - salary;
            return bonus;
        }

        private void setNull()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_post.Text = pPost;
            txt_salary.Text = pSalsry;
            hideBtns();
            disableTxt();
            dg_update();
            pPost = "";
            pSalsry = "";
            isChooseFreeze = false;
        }

        private void btn_fire_Click(object sender, EventArgs e)
        {
            if(txt_post.Text == "Управляющий компании")
            {
                MessageBox.Show("Вы не можете уволить себя или другого управляющего", "Ошибка");
                return;
            }

            if (MessageBox.Show("Вы уверены?\n Сотрудник " + txt_fio.Text + " будет уволен, а его данные будут потеряна навсегда", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            
            else
            {
                

                OleDbCommand iP2 = new OleDbCommand("Delete Employees WHERE id = ?", cn);
                iP2.Parameters.Add("@p1", OleDbType.Integer);
                iP2.Parameters[0].Value = txt_id.Text.ToString();
                try
                {
                    iP2.ExecuteNonQuery();
                    
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    return;
                }

                OleDbCommand iP = new OleDbCommand("Delete Users WHERE lgn = ?", cn);
                iP.Parameters.Add("@p1", OleDbType.VarChar, 30);
                iP.Parameters[0].Value = txt_mail2.Text.ToString();


                try
                {
                    iP.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник был успешно уволен", "Успех!");
                    setNull();
                    hideBtns();
                    disableTxt();
                    dg_update();
                    pPost = "";
                    pSalsry = "";
                    isChooseFreeze = false;
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    return;
                }
            }
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && !Char.IsControl(number) || (txt_salary.Text.ToString() == "" && number == '0'))
            {
                e.Handled = true;
            }
        }
    }
}
