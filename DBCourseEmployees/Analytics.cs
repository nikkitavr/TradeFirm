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
    public partial class Analytics : Form
    {
        OleDbConnection cn;
        String username;

        OleDbDataAdapter daDG;
        DataTable dtDG;
        public Analytics(OleDbConnection cn, String username)
        {
            InitializeComponent();
            this.cn = cn;
            this.username = username;

            OleDbDataAdapter daChooseMinDate = new OleDbDataAdapter("SELECT MIN(initDate) AS initDate FROM " +
                "(SELECT hireDate AS initDate FROM EmployeesDetails " +
                "UNION " +
                "SELECT orderDate AS initDate FROM OperationsArchive) as Dates", cn);
            DataTable dtChooseMinDate = new DataTable("MinDate");
            daChooseMinDate.Fill(dtChooseMinDate);
            dt1.MinDate = dt2.MinDate = DateTime.Parse((dtChooseMinDate.Rows[0])["initDate"].ToString());
            dt1.MaxDate = dt2.MaxDate = DateTime.Today;

            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.ReadOnly = true;
            dg.AllowUserToAddRows = false;
        }

        private void updateDG()
        {
            if (daDG != null) daDG.Dispose();
            if (dtDG != null) dtDG.Dispose();
            String comand = "";

            switch (cb_filter.SelectedItem.ToString())
            {
                case "По сотрудникам":
                    comand = init + emplSalaries + " " + 
                        "SELECT emplId AS 'Номер сотрудника', fio AS 'ФИО', title AS 'Должность', slr AS 'Зарплата' FROM emplSalaries " +
                        "JOIN Employees ON emplId = Employees.id " +
                        "JOIN EmployeesDetails ON emplId = EmployeesDetails.employeeId " +
                        "JOIN Posts ON Employees.postId = Posts.id";
                    break;

                case "По продукции":
                    comand = init + prodOutcomes + ", " + prodIncomes + ", " + prodDiff + " " +
                        "SELECT productArticul AS 'Артикул', profit AS 'Прибыль с продукта' FROM prodDiff";
                    break;
            }

            OleDbCommand cmd = new OleDbCommand(comand, cn);
            cmd.Parameters.Add("@p1", OleDbType.Date);
            cmd.Parameters.Add("@p2", OleDbType.Date);
            cmd.Parameters.Add("@p3", OleDbType.VarChar, 30);
            cmd.Parameters.Add("@p4", OleDbType.VarChar, 30);
            cmd.Parameters[0].Value = dt1.Value.ToString("yyyy-MM-dd");
            cmd.Parameters[1].Value = dt2.Value.ToString("yyyy-MM-dd");
            cmd.Parameters[2].Value = "Расходы";
            cmd.Parameters[3].Value = "Доходы";
            daDG = new OleDbDataAdapter(cmd);
            dtDG = new DataTable("Source");
            daDG.Fill(dtDG);
            dg.DataSource = dtDG;
        }


        private void btn_show_Click(object sender, EventArgs e)
        {
            if (chb_all.Checked)
            {
                dt1.Value = dt1.MinDate;
                dt2.Value = dt2.MaxDate;
            }

            if (DateTime.Compare(dt1.Value, dt2.Value) > 0)
            {
                MessageBox.Show("Выбран недействительный проежуток времени", "Внимание!");
                return;
            }

            OleDbCommand cmd = new OleDbCommand(init + emplSalaries + ", " + emplSalaries_sum + ", " + prodOutcomes + ", " +
                prodIncomes + ", " + prodOutcomes_sum + ", " + prodIncomes_sum + " " +
                "SELECT emplSalaries_sum.slrSum AS slrOutcome, prodOutcomes_sum.outcomeSum AS prodOutcome, prodIncomes_sum.incomeSum AS prodIncome FROM " +
                "emplSalaries_sum, prodOutcomes_sum, prodIncomes_sum", cn);
            cmd.Parameters.Add("@p1", OleDbType.Date);
            cmd.Parameters.Add("@p2", OleDbType.Date);
            cmd.Parameters.Add("@p3", OleDbType.VarChar, 30);
            cmd.Parameters.Add("@p4", OleDbType.VarChar, 30);
            cmd.Parameters[0].Value = dt1.Value.ToString("yyyy-MM-dd");
            cmd.Parameters[1].Value = dt2.Value.ToString("yyyy-MM-dd");
            cmd.Parameters[2].Value = "Расходы";
            cmd.Parameters[3].Value = "Доходы";

            OleDbDataAdapter daTemp = new OleDbDataAdapter(cmd);
            DataTable dtTemp = new DataTable("Info");
            daTemp.Fill(dtTemp);
            double minusSalary = double.Parse((dtTemp.Rows[0])["slrOutcome"].ToString());
            double minusProducts = double.Parse((dtTemp.Rows[0])["prodOutcome"].ToString());
            double plusProducts = double.Parse((dtTemp.Rows[0])["prodIncome"].ToString());

            txt_empCost.Text = minusSalary.ToString();
            txt_prodCost.Text = minusProducts.ToString();
            txt_allCost.Text = (minusSalary + minusProducts).ToString();

            txt_incomes.Text = plusProducts.ToString();
            txt_profit.Text = (plusProducts - (minusSalary + minusProducts)).ToString();

            if (cb_filter.SelectedItem != null)
            {
                updateDG();
            }
            else
            {
                dg.DataSource = null;
            }

        }

        //аля лего конструктор из sql queries 
        String init = "DECLARE @initDate date = ?; " +
                      "DECLARE @endDate date = ?; " +
                      "DECLARE @outcomeTitle VARCHAR(30) = ?; " +
                      "DECLARE @incomeTitle VARCHAR(30) = ?; " +
                      "WITH ";
        String emplSalaries = "emplSalaries AS " +
            "(SELECT Employees.id as emplId, (Posts.salary + EmployeesDetails.bonus) * " +
            "DATEDIFF(month, IIF(@initDate >= EmployeesDetails.hireDate, @initDate, EmployeesDetails.hireDate), @endDate) AS slr " +
            "FROM Employees JOIN EmployeesDetails ON Employees.id = EmployeesDetails.employeeId " +
            "JOIN Posts ON Employees.postId = Posts.id)";
        String emplSalaries_sum = "emplSalaries_sum AS (SELECT SUM(slr) AS slrSum FROM emplSalaries)";
        String prodOutcomes = "prodOutcomes AS (SELECT productArticul, ISNULL(SUM(finalCost), 0) AS outcome FROM OperationsArchive " +
            "WHERE orderDate >= @initDate AND orderDate <= @endDate AND operationType = @outcomeTitle " +
            "GROUP BY productArticul)";
        String prodIncomes = "prodIncomes AS (SELECT productArticul, ISNULL(SUM(finalCost), 0) AS income FROM OperationsArchive " +
            "WHERE orderDate >= @initDate AND orderDate <= @endDate AND operationType = @incomeTitle " +
            "GROUP BY productArticul)";
        String prodDiff = "prodDiff AS (SELECT ISNULL(prodIncomes.productArticul, prodOutcomes.productArticul) AS productArticul, " +
            "ISNULL(income, 0) - ISNULL(outcome, 0) AS profit FROM prodIncomes " +
            "FULL JOIN prodOutcomes ON prodIncomes.productArticul = prodOutcomes.productArticul)";
        String prodOutcomes_sum = "prodOutcomes_sum AS (SELECT ISNULL(SUM(outcome), 0) AS outcomeSum FROM prodOutcomes)";
        String prodIncomes_sum = "prodIncomes_sum AS (SELECT ISNULL(SUM(income), 0) AS incomeSum FROM prodIncomes)";
        String outcomes_sum = "outcomes_sum AS (SELECT (prodOutcomes_sum.outcomeSum + emplSalaries_sum.slrSum) AS allOutcomesSum FROM emplSalaries_sum, prodOutcomes_sum)";
        String profit = "profit AS (SELECT (prodIncomes_sum.incomeSum - outcomes_sum.allOutcomesSum) as finalProfit FROM prodIncomes_sum, outcomes_sum)";

        private void chb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_all.Checked)
            {
                dt1.Value = dt1.MinDate;
                dt2.Value = dt2.MaxDate;

                dt1.Enabled = false;
                dt2.Enabled = false;
            } else
            {
                dt1.Value = DateTime.Today;
                dt2.Value = DateTime.Today;

                dt1.Enabled = true;
                dt2.Enabled = true;
            }
        }

        private void Analytics_Load(object sender, EventArgs e)
        {

        }
    }
}
