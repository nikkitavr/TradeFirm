
namespace DBCourseClients
{
    partial class Catalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dg_catalog = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chb_isTest = new System.Windows.Forms.CheckBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_fPrice = new System.Windows.Forms.TextBox();
            this.txt_deliveryDate = new System.Windows.Forms.TextBox();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.txt_capacity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.updateCatalog = new System.Windows.Forms.Timer(this.components);
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_catalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dg_catalog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1365, 621);
            this.splitContainer1.SplitterDistance = 455;
            this.splitContainer1.TabIndex = 0;
            // 
            // dg_catalog
            // 
            this.dg_catalog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dg_catalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_catalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_catalog.Location = new System.Drawing.Point(0, 0);
            this.dg_catalog.Name = "dg_catalog";
            this.dg_catalog.RowHeadersWidth = 51;
            this.dg_catalog.RowTemplate.Height = 24;
            this.dg_catalog.Size = new System.Drawing.Size(455, 621);
            this.dg_catalog.TabIndex = 0;
            this.dg_catalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_catalog_CellClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer2.Panel1.Controls.Add(this.cb_filter);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txt_search);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.Controls.Add(this.chb_isTest);
            this.splitContainer2.Panel2.Controls.Add(this.btn_confirm);
            this.splitContainer2.Panel2.Controls.Add(this.txt_fPrice);
            this.splitContainer2.Panel2.Controls.Add(this.txt_deliveryDate);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_3);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_2);
            this.splitContainer2.Panel2.Controls.Add(this.txt_num);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_1);
            this.splitContainer2.Panel2.Controls.Add(this.txt_capacity);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.txt_price);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.txt_title);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.txt_category);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.btn_order);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_warning);
            this.splitContainer2.Size = new System.Drawing.Size(906, 621);
            this.splitContainer2.SplitterDistance = 55;
            this.splitContainer2.TabIndex = 0;
            // 
            // chb_isTest
            // 
            this.chb_isTest.BackColor = System.Drawing.Color.RoyalBlue;
            this.chb_isTest.Checked = true;
            this.chb_isTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_isTest.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_isTest.ForeColor = System.Drawing.SystemColors.Control;
            this.chb_isTest.Location = new System.Drawing.Point(599, 475);
            this.chb_isTest.Name = "chb_isTest";
            this.chb_isTest.Size = new System.Drawing.Size(295, 32);
            this.chb_isTest.TabIndex = 107;
            this.chb_isTest.Text = "Режим тестирования";
            this.chb_isTest.UseVisualStyleBackColor = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_confirm.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_confirm.Location = new System.Drawing.Point(464, 162);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(398, 43);
            this.btn_confirm.TabIndex = 105;
            this.btn_confirm.Text = "Подтвердить заказ";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_fPrice
            // 
            this.txt_fPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_fPrice.Location = new System.Drawing.Point(707, 67);
            this.txt_fPrice.Name = "txt_fPrice";
            this.txt_fPrice.ReadOnly = true;
            this.txt_fPrice.Size = new System.Drawing.Size(155, 32);
            this.txt_fPrice.TabIndex = 104;
            // 
            // txt_deliveryDate
            // 
            this.txt_deliveryDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_deliveryDate.Location = new System.Drawing.Point(707, 116);
            this.txt_deliveryDate.Name = "txt_deliveryDate";
            this.txt_deliveryDate.ReadOnly = true;
            this.txt_deliveryDate.Size = new System.Drawing.Size(155, 32);
            this.txt_deliveryDate.TabIndex = 103;
            // 
            // lbl_3
            // 
            this.lbl_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_3.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_3.Location = new System.Drawing.Point(459, 116);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(242, 32);
            this.lbl_3.TabIndex = 102;
            this.lbl_3.Text = "Дата доставки";
            // 
            // lbl_2
            // 
            this.lbl_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_2.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_2.Location = new System.Drawing.Point(459, 67);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(242, 32);
            this.lbl_2.TabIndex = 101;
            this.lbl_2.Text = "Итоговая стоимость";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_num.Location = new System.Drawing.Point(707, 17);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(155, 32);
            this.txt_num.TabIndex = 100;
            this.txt_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_num_KeyDown);
            this.txt_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_KeyPress);
            // 
            // lbl_1
            // 
            this.lbl_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_1.Location = new System.Drawing.Point(459, 17);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(242, 32);
            this.lbl_1.TabIndex = 99;
            this.lbl_1.Text = "Введите количество";
            // 
            // txt_capacity
            // 
            this.txt_capacity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_capacity.Location = new System.Drawing.Point(170, 118);
            this.txt_capacity.Name = "txt_capacity";
            this.txt_capacity.ReadOnly = true;
            this.txt_capacity.Size = new System.Drawing.Size(155, 32);
            this.txt_capacity.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(14, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 32);
            this.label11.TabIndex = 97;
            this.label11.Text = "Количество";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_price.Location = new System.Drawing.Point(170, 67);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(155, 32);
            this.txt_price.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(14, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 32);
            this.label9.TabIndex = 95;
            this.label9.Text = "Цена";
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_title.Location = new System.Drawing.Point(170, 17);
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(239, 32);
            this.txt_title.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(14, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 32);
            this.label7.TabIndex = 93;
            this.label7.Text = "Название";
            // 
            // txt_category
            // 
            this.txt_category.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_category.Location = new System.Drawing.Point(369, -54);
            this.txt_category.Name = "txt_category";
            this.txt_category.ReadOnly = true;
            this.txt_category.Size = new System.Drawing.Size(287, 32);
            this.txt_category.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(190, -54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 32);
            this.label6.TabIndex = 91;
            this.label6.Text = "Категория";
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_order.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_order.Location = new System.Drawing.Point(19, 162);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(390, 43);
            this.btn_order.TabIndex = 90;
            this.btn_order.Text = "Заказать";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lbl_warning
            // 
            this.lbl_warning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_warning.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_warning.ForeColor = System.Drawing.Color.Brown;
            this.lbl_warning.Location = new System.Drawing.Point(460, 67);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(402, 81);
            this.lbl_warning.TabIndex = 106;
            this.lbl_warning.Text = "Настолько большие заказы можно оформить только через управляющего фирмы";
            // 
            // updateCatalog
            // 
            this.updateCatalog.Interval = 1000;
            this.updateCatalog.Tick += new System.EventHandler(this.updateCatalog_Tick);
            // 
            // cb_filter
            // 
            this.cb_filter.AutoCompleteCustomSource.AddRange(new string[] {
            "Имени",
            "Категории",
            "Артикулу",
            "Артикулу фирмы"});
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "Названию",
            "Артикулу фирмы"});
            this.cb_filter.Location = new System.Drawing.Point(443, 12);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(138, 32);
            this.cb_filter.TabIndex = 40;
            this.cb_filter.SelectedValueChanged += new System.EventHandler(this.cb_filter_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(325, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Искать по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Поиск";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_search.Location = new System.Drawing.Point(94, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(222, 32);
            this.txt_search.TabIndex = 37;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 621);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalog";
            this.Text = "Каталог";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_catalog)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dg_catalog;
        private System.Windows.Forms.Timer updateCatalog;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox txt_fPrice;
        private System.Windows.Forms.TextBox txt_deliveryDate;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox txt_capacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.CheckBox chb_isTest;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
    }
}