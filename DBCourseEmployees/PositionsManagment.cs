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


    public partial class PositionsManagment : Form
    {
        OleDbConnection cn;
        OleDbDataAdapter da;
        DataTable dt;
        bool isNew;
        int post_id;
        String past_title;
        String past_salary;
        bool isChooseFreeze = false;
        public PositionsManagment(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
            btn_delete.Hide();
            btn_save.Hide();
            btn_cancel.Hide();

            da = new OleDbDataAdapter("SELECT title AS \"Название\", salary AS \"Оклад\" FROM Posts", cn);
            dt = new DataTable("Posts");
            da.Fill(dt);

            dg_posts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg_posts.DataSource = dt;
            dg_posts.ReadOnly = true;
            dg_posts.AllowUserToAddRows = false;
        }

        private void dg_update()
        {
            da.Dispose();
            dt.Dispose();

            da = new OleDbDataAdapter("SELECT title AS \"Название\", salary AS \"Оклад\" FROM Posts", cn);
            dt = new DataTable("Posts");
            da.Fill(dt);

            dg_posts.DataSource = dt;
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {

        }

        private void PositionsManagment_Load(object sender, EventArgs e)
        {

        }

        private void txt_find_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txt_find.Text == "")
                {
                    dg_update();
                }
                else
                {
                    DataView dv = dt.DefaultView;
                    dv.RowFilter = string.Format("Название like '%{0}%'", txt_find.Text);
                    dg_posts.DataSource = dv.ToTable();

                }

            }
        }

        private void dg_posts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dg_posts_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dg_posts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_changeSave_Click(object sender, EventArgs e)
        {
            if(txt_title.Text == "")
            {
                MessageBox.Show("Сначала выберите должность из списка", "Внимание");
                return;
            }
            isChooseFreeze = true;
            past_title = txt_title.Text;
            past_salary = txt_salary.Text;
            post_id = getId();
            isNew = false;
            btn_save.Show();
            btn_cancel.Show();
            btn_delete.Show();
            txt_title.ReadOnly = false;
            txt_salary.ReadOnly = false;

            btn_change.Hide();
            btn_addPost.Hide();
        }

        private int getId()
        {
            int id = -1;
            OleDbCommand sP = new OleDbCommand("SELECT id FROM Posts WHERE title = ?", cn);
            sP.Parameters.Add("@p1", OleDbType.VarChar, 50);
            sP.Parameters[0].Value = txt_title.Text;
            OleDbDataReader rdr = sP.ExecuteReader();
            while (rdr.Read())
            {
                id = int.Parse(rdr["id"].ToString());
            }
            rdr.Close();
            return id;
        }

      
        private void txt_title_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_title.TextLength == 50)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_title.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Program.intOverFlow(txt_salary.Text))
            {
                MessageBox.Show("Числовые значения должны быть менше чем " + int.MaxValue, "Внимание!");
                return;
            }

            if (isNew)
            {
                addPost();
            } else
            {
                changePost();
            }
            
        }

        private void changePost()
        {
            if (txt_title.Text == "" || txt_salary.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка");
            } 
            else
            {
                OleDbCommand iP = new OleDbCommand("UPDATE Posts SET title = ?, salary = ? WHERE id = ?", cn);
                iP.Parameters.Add("@p1", OleDbType.VarChar, 50);
                iP.Parameters.Add("@p2", OleDbType.Integer);
                iP.Parameters.Add("@p3", OleDbType.Integer);
                iP.Parameters[0].Value = txt_title.Text;
                iP.Parameters[1].Value = txt_salary.Text;
                iP.Parameters[2].Value = post_id.ToString();

                try
                {
                    iP.ExecuteNonQuery();
                    MessageBox.Show("Информация была успешно обновлена", "Успех!");
                    txt_title.Text = "";
                    txt_salary.Text = "";
                    txt_find.Text = "";
                    dg_update();
                    btn_save.Hide();
                    btn_delete.Hide();
                    txt_title.ReadOnly = true;
                    txt_salary.ReadOnly = true;
                    btn_change.Show();
                    btn_addPost.Show();
                    post_id = -1;
                    past_title = "";
                    isChooseFreeze = false;
                    btn_cancel.Hide();
                }
                catch (OleDbException exc)
                {
                    if (!Program.isErrorIsDuplicate(exc.Message))
                    {
                        MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    }
                }
            }
        }

        private void addPost()
        {

            if (txt_title.Text == "" || txt_salary.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка");
            }
            else
            {
                OleDbCommand iP = new OleDbCommand("INSERT INTO Posts VALUES (?, ?)", cn);
                iP.Parameters.Add("@p1", OleDbType.VarChar, 50);
                iP.Parameters.Add("@p2", OleDbType.Integer);
                iP.Parameters[0].Value = txt_title.Text;
                iP.Parameters[1].Value = txt_salary.Text;
                try
                {
                    iP.ExecuteNonQuery();
                    MessageBox.Show("Новая должность была успешно добавлена", "Успех!");
                    txt_title.Text = "";
                    txt_salary.Text = "";
                    dg_update();
                    txt_find.Text = "";
                    btn_save.Hide();
                    btn_delete.Hide();
                    txt_title.ReadOnly = true;
                    txt_salary.ReadOnly = true;

                    btn_change.Show();
                    btn_addPost.Show();
                    isChooseFreeze = false;
                    btn_cancel.Hide();
                }
                catch (OleDbException exc)
                {
                    if (!Program.isErrorIsDuplicate(exc.Message))
                    {
                        MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?\n Должность \"" + past_title + "\" и ее данные будут потеряна навсегда", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (isDependencies())
            {
                MessageBox.Show("Некоторые данные ссылаются на данный элемент. Прежде необходимо удалить их", "Ошибка");
                return;
            }

            else
            {
                OleDbCommand iP = new OleDbCommand("Delete Posts WHERE id = ?", cn);
                iP.Parameters.Add("@p1", OleDbType.Integer);
                iP.Parameters[0].Value = post_id.ToString();
                

                try
                {
                    iP.ExecuteNonQuery();
                    MessageBox.Show("Должность была удалена", "Успех!");
                    txt_title.Text = "";
                    txt_salary.Text = "";
                    dg_update();
                    txt_find.Text = "";
                    btn_save.Hide();
                    btn_delete.Hide();
                    btn_cancel.Hide();
                    txt_title.ReadOnly = true;
                    txt_salary.ReadOnly = true;
                    isChooseFreeze = false;
                    btn_change.Show();
                    btn_addPost.Show();
                    post_id = -1;
                    past_title = "";
                }
                catch (OleDbException exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                }
            }
        }

        private bool isDependencies()
        {
            int num =-1;
            OleDbCommand sP = new OleDbCommand("SELECT COUNT(*) AS \"cnt\" FROM Employees JOIN Posts ON Employees.postId = Posts.id WHERE postId = ?", cn);
            sP.Parameters.Add("@p1", OleDbType.Integer);
            sP.Parameters[0].Value = post_id.ToString();
            OleDbDataReader rdr = sP.ExecuteReader();
            while (rdr.Read())
            {
                num = int.Parse(rdr["cnt"].ToString());
            }
            rdr.Close();
            if(num > 0) {
                return true;
            }
            return false;
        }

        private void btn_addPost_Click(object sender, EventArgs e)
        {
            isChooseFreeze = true;
            btn_save.Show();
            btn_cancel.Show();
            btn_addPost.Hide();
            btn_change.Hide();
            txt_title.ReadOnly = false;
            txt_salary.ReadOnly = false;
            txt_title.Text = "";
            txt_salary.Text = "";
            isNew = true;


        }

        private void dg_posts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!isChooseFreeze)
            {
                txt_title.Text = dg_posts.SelectedRows[0].Cells["Название"].Value.ToString();
                txt_salary.Text = dg_posts.SelectedRows[0].Cells["Оклад"].Value.ToString();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                txt_title.Text = "";
                txt_salary.Text = "";
                dg_update();
                txt_find.Text = "";
                btn_save.Hide();
                btn_delete.Hide();
                txt_title.ReadOnly = true;
                txt_salary.ReadOnly = true;

                btn_change.Show();
                btn_addPost.Show();
                btn_cancel.Hide();
            }
            else
            {
                txt_title.Text = past_title;
                txt_salary.Text = past_salary;
                dg_update();
                txt_find.Text = "";
                btn_save.Hide();
                btn_delete.Hide();
                txt_title.ReadOnly = true;
                txt_salary.ReadOnly = true;

                btn_change.Show();
                btn_addPost.Show();
                btn_cancel.Hide();
            }
            isChooseFreeze = false;

        }
    }
}
