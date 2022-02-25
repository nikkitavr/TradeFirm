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
    public partial class CategoriesManagment : Form
    {
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CategoriesManagment_Load(object sender, EventArgs e)
        {

        }



        OleDbConnection cn;
        String pCategory;
        bool isNew;

        public CategoriesManagment(OleDbConnection cn)
        {
            InitializeComponent();
            this.cn = cn;
            txt_category.ReadOnly = false;
            disableTxt();
            hideBtns();
            updateCb();

        }

        private void disableTxt()
        {
            txt_category.Hide();
            cb_category.Show();
        }
        private void ableTxt()
        {
            if (cb_category.SelectedItem != null)
            {
                txt_category.Text = cb_category.SelectedItem.ToString();
            } else
            {
                txt_category.Text = "";
            }
            txt_category.Show();
            cb_category.Hide();
        }
        private void hideBtns()
        {
            btn_cancel.Hide();
            btn_delete.Hide();
            btn_save.Hide();

            btn_change.Show();
            btn_add.Show();
        }
        private void showBtns()
        {
            btn_cancel.Show();
            btn_delete.Show();
            btn_save.Show();

            btn_change.Hide();
            btn_add.Hide();
        }

        private void updateCb()
        {
            cb_category.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("SELECT title FROM Categories", cn);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                cb_category.Items.Add(rdr["title"]);
            rdr.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cb_category.SelectedItem != null)
            {
                pCategory = cb_category.SelectedItem.ToString();
            } else
            {
                pCategory = null;
            }
            showBtns();
            btn_delete.Hide();
            ableTxt();
            txt_category.Text = "";
            isNew = true;
        }

        private void addCategory()
        {
            if (txt_category.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка");
            }
            else
            {
                OleDbCommand iP = new OleDbCommand("INSERT INTO Categories VALUES (?)", cn);
                iP.Parameters.Add("@p1", OleDbType.VarChar, 20);
                iP.Parameters[0].Value = txt_category.Text;
                try
                {
                    iP.ExecuteNonQuery();
                    hideBtns();
                    disableTxt();
                    updateCb();
                    cb_category.SelectedItem = null;
                    cb_category.Text = "";

                    MessageBox.Show("Новая категория товаров была успешно добавлена", "Успех!");

                }
                catch (OleDbException exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                }
            }
        }

        private void txt_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_category.TextLength == 20)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_category.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                addCategory();
            }
            else
            {
                changeCategory();
            }
        }

        private void changeCategory()
        {
            if (txt_category.Text == "")
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка");
            }
            else
            {
                OleDbCommand iP = new OleDbCommand("UPDATE Categories SET title = ? WHERE title = ?", cn);
                iP.Parameters.Add("@p1", OleDbType.VarChar, 20);
                iP.Parameters.Add("@p2", OleDbType.VarChar, 20);

                iP.Parameters[0].Value = txt_category.Text;
                iP.Parameters[1].Value = pCategory;

                try
                {
                    iP.ExecuteNonQuery();
                    hideBtns();
                    disableTxt();
                    updateCb();
                    cb_category.SelectedItem = null;
                    cb_category.Text = "";

                    MessageBox.Show("Название категории было успешно обновлено", "Успех!");

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
        private void deleteCategory()
        {
            if (MessageBox.Show("Вы уверены?\n Категория \"" + pCategory + "\" и ее данные будут потеряна навсегда", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No)
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
                OleDbCommand iP = new OleDbCommand("Delete Categories WHERE title = ?", cn);
                iP.Parameters.Add("@p1", OleDbType.VarChar, 20);
                iP.Parameters[0].Value = pCategory;


                try
                {
                    iP.ExecuteNonQuery();
                    MessageBox.Show("Должность была удалена", "Успех!");
                    hideBtns();
                    disableTxt();
                    updateCb();
                    cb_category.SelectedItem = null;
                    cb_category.Text = "";
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
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cb_category.SelectedItem = pCategory;
            hideBtns();
            disableTxt();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (cb_category.SelectedItem != null)
            {
                pCategory = cb_category.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Выберите категорию", "Внимание!");
                return;
            }
            showBtns();
            ableTxt();
            txt_category.Text = cb_category.SelectedItem.ToString();
            isNew = false;
        }

        private bool isDependencies()
        {
            int num = -1;
            OleDbCommand sP = new OleDbCommand("SELECT COUNT(*) AS \"cnt\" FROM Categories JOIN Products ON Products.categoryId = Categories.id WHERE Categories.title = ?", cn);
            sP.Parameters.Add("@p1", OleDbType.VarChar, 20);
            sP.Parameters[0].Value = pCategory;
            OleDbDataReader rdr = sP.ExecuteReader();
            while (rdr.Read())
            {
                num = int.Parse(rdr["cnt"].ToString());
            }
            rdr.Close();
            if (num > 0)
            {
                return true;
            }
            return false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteCategory();
        }
    } 
}
