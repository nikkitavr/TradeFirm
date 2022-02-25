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
using System.Collections;

namespace DBCourseEmployees
{
    public partial class Profile : Form
    {
        OleDbConnection cn;
        bool isEmpl;
        bool isChangePsw = false;
        String username;
        Dictionary<String, String> oldValues = new Dictionary<String, String>();

        public Profile(OleDbConnection cn, String username)
        {
            InitializeComponent();
            this.cn = cn;
            this.username = username;

            OleDbDataAdapter daTemp = new OleDbDataAdapter("SELECT id FROM Employees WHERE email = '" + username + "'", cn);
            DataTable dtTemp = new DataTable("Empl");
            daTemp.Fill(dtTemp);
            isEmpl = (dtTemp.Rows.Count > 0);

            txt_phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lbl_psw1.Hide();
            lbl_psw2.Hide();
            lbl_psw3.Hide();
            txt_oldPsw.Hide();
            txt_newPsw.Hide();
            txt_newPsw2.Hide();
            txt_f.ReadOnly = true;
            txt_i.ReadOnly = true;
            txt_o.ReadOnly = true;
            txt_phone.ReadOnly = true;
            btn_save.Hide();
            btn_cancel.Hide();
            if (isEmpl)
            {
                txt_mail.ReadOnly = true;
                txt_post.ReadOnly = true;
                txt_salary.ReadOnly = true;
            } else
            {
                txt_mail.Hide();
                txt_post.Hide();
                txt_salary.Hide();
                label6.Hide();
                label1.Hide();
                label12.Hide();
            }

            loadInfo();

        }

        private void loadInfo()
        {
            String cmnd = "";
            if (isEmpl)
            {
                cmnd = "SELECT fio, phone, title, salary, bonus FROM Employees " +
                    "JOIN EmployeesDetails ON Employees.id = EmployeesDetails.employeeId JOIN Posts ON postId = Posts.id " +
                    "WHERE email = '" + username + "'";
            } else
            {
                cmnd = "SELECT fio FROM Clients WHERE phone = '" + username + "'";
            }
            OleDbDataAdapter daTemp = new OleDbDataAdapter(cmnd, cn);
            DataTable dTemp = new DataTable("UserInfo");
            daTemp.Fill(dTemp);

            String[] fio = (dTemp.Rows[0])["fio"].ToString().Split(' ');
            txt_f.Text = fio[0];
            txt_i.Text = fio[1];
            txt_o.Text = fio[2];

            if (isEmpl)
            {
                txt_phone.Text = (dTemp.Rows[0])["phone"].ToString();
                txt_post.Text = (dTemp.Rows[0])["title"].ToString();
                txt_salary.Text = (int.Parse((dTemp.Rows[0])["salary"].ToString()) + int.Parse((dTemp.Rows[0])["bonus"].ToString())).ToString();
                txt_mail.Text = username;
            } else
            {
                txt_phone.Text = username;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            isChangePsw = false;
            remember();
            txt_phone.ReadOnly = false;
            txt_f.ReadOnly = false;
            txt_i.ReadOnly = false;
            txt_o.ReadOnly = false;
            btn_change.Hide();
            btn_changePsw.Hide();
            btn_cancel.Show();
            btn_save.Show();

        }

        private void remember()
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    oldValues[c.Name] = (c as TextBox).Text;
                } else if (c is MaskedTextBox)
                {
                    oldValues[c.Name] = (c as MaskedTextBox).Text;
                }
            }
        }

        private bool isNulls()
        {
            if(txt_f.Text == "" || txt_i.Text == "" || txt_o.Text == "" || !txt_phone.MaskCompleted)
            {
                return true;
            }
            return false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!isChangePsw)
            {
                if (isNulls())
                {
                    MessageBox.Show("Все поля должны быть заполнены", "Внимание!");
                    return;
                }


                if (!isEmpl)
                {
                    OleDbCommand upd = new OleDbCommand("UPDATE Users SET lgn = ? WHERE lgn = ?", cn);
                    upd.Parameters.Add("@p1", OleDbType.VarChar, 30);
                    upd.Parameters.Add("@p2", OleDbType.VarChar, 30);
                    upd.Parameters[0].Value = txt_phone.Text;
                    upd.Parameters[1].Value = oldValues[txt_phone.Name];
                    OleDbCommand upd2 = new OleDbCommand("UPDATE Clients SET phone = ?, fio = ? WHERE phone = ?", cn);
                    upd2.Parameters.Add("@p11", OleDbType.VarChar, 11);
                    upd2.Parameters.Add("@p21", OleDbType.VarChar, 50);
                    upd2.Parameters.Add("@p31", OleDbType.VarChar, 11);
                    upd2.Parameters[0].Value = txt_phone.Text;
                    upd2.Parameters[1].Value = txt_f.Text + " " + txt_i.Text + " " + txt_o.Text;
                    upd2.Parameters[2].Value = oldValues[txt_phone.Name];

                    try
                    {
                        upd.ExecuteNonQuery();
                        upd2.ExecuteNonQuery();
                        txt_phone.ReadOnly = true;
                        txt_f.ReadOnly = true;
                        txt_i.ReadOnly = true;
                        txt_o.ReadOnly = true;
                        btn_change.Show();
                        btn_changePsw.Show();
                        btn_cancel.Hide();
                        btn_save.Hide();
                        username = txt_phone.Text;
                        MessageBox.Show("Данные успешно обновлены", "Успех");
                        return;

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                        return;
                    }
                }

                OleDbCommand upd3 = new OleDbCommand("UPDATE Employees SET fio = ? WHERE email = ?", cn);
                upd3.Parameters.Add("@p21", OleDbType.VarChar, 50);
                upd3.Parameters.Add("@p31", OleDbType.VarChar, 30);
                upd3.Parameters[0].Value = txt_f.Text + " " + txt_i.Text + " " + txt_o.Text;
                upd3.Parameters[1].Value = username;
                OleDbCommand upd4 = new OleDbCommand("UPDATE EmployeesDetails SET phone = ? WHERE phone = ?", cn);
                upd4.Parameters.Add("@p21", OleDbType.VarChar, 11);
                upd4.Parameters.Add("@p31", OleDbType.VarChar, 11);
                upd4.Parameters[0].Value = txt_phone.Text;
                upd4.Parameters[1].Value = oldValues[txt_phone.Name];
                try
                {
                    upd3.ExecuteNonQuery();
                    upd4.ExecuteNonQuery();
                    txt_phone.ReadOnly = true;
                    txt_f.ReadOnly = true;
                    txt_i.ReadOnly = true;
                    txt_o.ReadOnly = true;
                    btn_change.Show();
                    btn_changePsw.Show();
                    btn_cancel.Hide();
                    btn_save.Hide();
                    MessageBox.Show("Данные успешно обновлены", "Успех");
                    return;

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    return;
                }
            }
            else
            {
                if(txt_oldPsw.Text == "" || txt_newPsw.Text == "")
                {
                    MessageBox.Show("Необходимо заполнить все поля", "Ошибка");
                    return;
                }

                if (Program.sha256_hash(txt_oldPsw.Text) != Program.getValueByValue("Users", "psw", "lgn", username, cn))
                {
                    MessageBox.Show("Введен неправильный старый пароль", "Ошибка");
                    txt_oldPsw.Text = "";
                    return;
                }

                if (txt_newPsw.Text != txt_newPsw2.Text)
                {
                    MessageBox.Show("Введеные пароли не совпадают", "Ошибка");
                    txt_newPsw.Text = "";
                    txt_newPsw2.Text = "";
                    return;
                }

                OleDbCommand nP = new OleDbCommand("UPDATE Users SET psw = ? WHERE lgn = ?", cn);
                nP.Parameters.Add("@p1", OleDbType.VarChar, 64);
                nP.Parameters.Add("@p2", OleDbType.VarChar, 30);
                nP.Parameters[0].Value = Program.sha256_hash(txt_newPsw.Text);
                nP.Parameters[1].Value = username;

                try
                {
                    nP.ExecuteNonQuery();
                    txt_oldPsw.Text = "";
                    txt_newPsw.Text = "";
                    txt_newPsw2.Text = "";
                    txt_oldPsw.Hide();
                    txt_newPsw.Hide();
                    txt_newPsw2.Hide();
                    lbl_psw1.Hide();
                    lbl_psw2.Hide();
                    lbl_psw3.Hide();
                    btn_change.Show();
                    btn_changePsw.Show();
                    btn_cancel.Hide();
                    btn_save.Hide();
                    MessageBox.Show("Данные успешно обновлены", "Успех");
                    return;

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Произошла ошибка базы данных, обратитесь к администратору.\n" + exc.Message, "Ошибка");
                    return;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (!isChangePsw)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).Text = oldValues[c.Name];
                    }
                    else if (c is MaskedTextBox)
                    {
                        (c as MaskedTextBox).Text = oldValues[c.Name];
                    }
                }
            }
            txt_phone.ReadOnly = false;
            txt_f.ReadOnly = false;
            txt_i.ReadOnly = false;
            txt_o.ReadOnly = false;
            btn_change.Show();
            btn_changePsw.Show();
            btn_cancel.Hide();
            btn_save.Hide();
            lbl_psw1.Hide();
            lbl_psw2.Hide();
            lbl_psw3.Hide();
            txt_oldPsw.Hide();
            txt_newPsw.Hide();
            txt_newPsw2.Hide();
            txt_oldPsw.Text = "";
            txt_newPsw.Text = "";
            txt_newPsw2.Text = "";
        }

        private void btn_changePsw_Click(object sender, EventArgs e)
        {
            txt_f.ReadOnly = true;
            txt_i.ReadOnly = true;
            txt_o.ReadOnly = true;
            txt_phone.ReadOnly = true;
            txt_oldPsw.Show();
            txt_newPsw.Show();
            txt_newPsw2.Show();
            lbl_psw1.Show();
            lbl_psw2.Show();
            lbl_psw3.Show();
            btn_change.Hide();
            btn_changePsw.Hide();
            btn_cancel.Show();
            btn_save.Show();
            isChangePsw = true;
        }

        private void txt_f_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_f.TextLength == 15)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_f.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txt_i_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_i.TextLength == 15)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_i.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }
        }

        private void txt_o_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter = e.KeyChar;
            if (!Char.IsLetter(letter) && !Char.IsControl(letter) && !Char.IsWhiteSpace(letter) && txt_o.TextLength == 15)
            {
                e.Handled = true;
            }
            else
            {
                if (txt_o.Text == "")
                {
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
            }
        }
    }
}
