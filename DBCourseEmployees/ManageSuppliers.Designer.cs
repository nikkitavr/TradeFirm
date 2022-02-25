
namespace DBCourseEmployees
{
    partial class ManageSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSuppliers));
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.MaskedTextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.cb_companyName = new System.Windows.Forms.ComboBox();
            this.btn_cancelProduct = new System.Windows.Forms.Button();
            this.btn_saveProduct = new System.Windows.Forms.Button();
            this.btn_delProduct = new System.Windows.Forms.Button();
            this.btn_changeProduct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_regDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_companyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.dg_catalog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_catalog)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.dg_catalog);
            this.splitContainerRight.Size = new System.Drawing.Size(1806, 855);
            this.splitContainerRight.SplitterDistance = 1101;
            this.splitContainerRight.SplitterWidth = 6;
            this.splitContainerRight.TabIndex = 0;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainerLeft.Panel1.Controls.Add(this.cb_filter);
            this.splitContainerLeft.Panel1.Controls.Add(this.label11);
            this.splitContainerLeft.Panel1.Controls.Add(this.label1);
            this.splitContainerLeft.Panel1.Controls.Add(this.txt_search);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.splitContainerLeft.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainerLeft.Panel2.BackgroundImage")));
            this.splitContainerLeft.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainerLeft.Panel2.Controls.Add(this.txt_phone);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_addProduct);
            this.splitContainerLeft.Panel2.Controls.Add(this.cb_companyName);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_cancelProduct);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_saveProduct);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_delProduct);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_changeProduct);
            this.splitContainerLeft.Panel2.Controls.Add(this.label10);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_change);
            this.splitContainerLeft.Panel2.Controls.Add(this.label3);
            this.splitContainerLeft.Panel2.Controls.Add(this.txt_dTime);
            this.splitContainerLeft.Panel2.Controls.Add(this.label6);
            this.splitContainerLeft.Panel2.Controls.Add(this.txt_pPrice);
            this.splitContainerLeft.Panel2.Controls.Add(this.label7);
            this.splitContainerLeft.Panel2.Controls.Add(this.txt_dPrice);
            this.splitContainerLeft.Panel2.Controls.Add(this.label8);
            this.splitContainerLeft.Panel2.Controls.Add(this.txt_product);
            this.splitContainerLeft.Panel2.Controls.Add(this.label9);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_cancel);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_save);
            this.splitContainerLeft.Panel2.Controls.Add(this.btn_delete);
            this.splitContainerLeft.Panel2.Controls.Add(this.label5);
            this.splitContainerLeft.Panel2.Controls.Add(this.txt_regDate);
            this.splitContainerLeft.Panel2.Controls.Add(this.label4);
            this.splitContainerLeft.Panel2.Controls.Add(this.txt_companyName);
            this.splitContainerLeft.Panel2.Controls.Add(this.label2);
            this.splitContainerLeft.Panel2.Controls.Add(this.cb_product);
            this.splitContainerLeft.Size = new System.Drawing.Size(1101, 855);
            this.splitContainerLeft.SplitterDistance = 48;
            this.splitContainerLeft.SplitterWidth = 6;
            this.splitContainerLeft.TabIndex = 0;
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
            "Категории",
            "Артикулу",
            "Артикулу фирмы"});
            this.cb_filter.Location = new System.Drawing.Point(803, 9);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(138, 32);
            this.cb_filter.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(685, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 29);
            this.label11.TabIndex = 37;
            this.label11.Text = "Искать по";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Поиск";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_search.Location = new System.Drawing.Point(106, 9);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(564, 32);
            this.txt_search.TabIndex = 32;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_find_KeyPress);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_phone.Location = new System.Drawing.Point(243, 151);
            this.txt_phone.Mask = "0 (000) 000-00-00";
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(217, 32);
            this.txt_phone.TabIndex = 72;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_addProduct.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addProduct.Location = new System.Drawing.Point(676, 7);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(135, 43);
            this.btn_addProduct.TabIndex = 71;
            this.btn_addProduct.Text = "Добавить";
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // cb_companyName
            // 
            this.cb_companyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_companyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_companyName.FormattingEnabled = true;
            this.cb_companyName.Location = new System.Drawing.Point(243, 66);
            this.cb_companyName.Name = "cb_companyName";
            this.cb_companyName.Size = new System.Drawing.Size(217, 32);
            this.cb_companyName.TabIndex = 70;
            this.cb_companyName.SelectedValueChanged += new System.EventHandler(this.cb_companyName_SelectedValueChanged);
            // 
            // btn_cancelProduct
            // 
            this.btn_cancelProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelProduct.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancelProduct.Location = new System.Drawing.Point(535, 292);
            this.btn_cancelProduct.Name = "btn_cancelProduct";
            this.btn_cancelProduct.Size = new System.Drawing.Size(135, 43);
            this.btn_cancelProduct.TabIndex = 69;
            this.btn_cancelProduct.Text = "Отменить";
            this.btn_cancelProduct.UseVisualStyleBackColor = false;
            this.btn_cancelProduct.Click += new System.EventHandler(this.btn_cancelProduct_Click);
            // 
            // btn_saveProduct
            // 
            this.btn_saveProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_saveProduct.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_saveProduct.Location = new System.Drawing.Point(535, 243);
            this.btn_saveProduct.Name = "btn_saveProduct";
            this.btn_saveProduct.Size = new System.Drawing.Size(135, 43);
            this.btn_saveProduct.TabIndex = 68;
            this.btn_saveProduct.Text = "Сохранить";
            this.btn_saveProduct.UseVisualStyleBackColor = false;
            this.btn_saveProduct.Click += new System.EventHandler(this.btn_saveProduct_Click);
            // 
            // btn_delProduct
            // 
            this.btn_delProduct.BackColor = System.Drawing.Color.DarkRed;
            this.btn_delProduct.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delProduct.Location = new System.Drawing.Point(907, 243);
            this.btn_delProduct.Name = "btn_delProduct";
            this.btn_delProduct.Size = new System.Drawing.Size(135, 43);
            this.btn_delProduct.TabIndex = 67;
            this.btn_delProduct.Text = "Удалить";
            this.btn_delProduct.UseVisualStyleBackColor = false;
            this.btn_delProduct.Click += new System.EventHandler(this.btn_delProduct_Click);
            // 
            // btn_changeProduct
            // 
            this.btn_changeProduct.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_changeProduct.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_changeProduct.Location = new System.Drawing.Point(535, 7);
            this.btn_changeProduct.Name = "btn_changeProduct";
            this.btn_changeProduct.Size = new System.Drawing.Size(135, 43);
            this.btn_changeProduct.TabIndex = 66;
            this.btn_changeProduct.Text = "Изменить";
            this.btn_changeProduct.UseVisualStyleBackColor = false;
            this.btn_changeProduct.Click += new System.EventHandler(this.btn_changeProduct_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(497, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(2, 400);
            this.label10.TabIndex = 65;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_change.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_change.Location = new System.Drawing.Point(12, 7);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(135, 43);
            this.btn_change.TabIndex = 52;
            this.btn_change.Text = "Изменить";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(993, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 64;
            this.label3.Text = "(дн.)";
            // 
            // txt_dTime
            // 
            this.txt_dTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_dTime.Location = new System.Drawing.Point(785, 195);
            this.txt_dTime.Name = "txt_dTime";
            this.txt_dTime.Size = new System.Drawing.Size(202, 32);
            this.txt_dTime.TabIndex = 63;
            this.txt_dTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dTime_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(535, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 32);
            this.label6.TabIndex = 62;
            this.label6.Text = "Срок доcтавки";
            // 
            // txt_pPrice
            // 
            this.txt_pPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_pPrice.Location = new System.Drawing.Point(785, 108);
            this.txt_pPrice.Name = "txt_pPrice";
            this.txt_pPrice.Size = new System.Drawing.Size(257, 32);
            this.txt_pPrice.TabIndex = 61;
            this.txt_pPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(535, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 32);
            this.label7.TabIndex = 60;
            this.label7.Text = "Стоимость доставки";
            // 
            // txt_dPrice
            // 
            this.txt_dPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txt_dPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_dPrice.Location = new System.Drawing.Point(785, 151);
            this.txt_dPrice.Name = "txt_dPrice";
            this.txt_dPrice.ReadOnly = true;
            this.txt_dPrice.Size = new System.Drawing.Size(257, 32);
            this.txt_dPrice.TabIndex = 59;
            this.txt_dPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dPrice_KeyPress);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(535, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 32);
            this.label8.TabIndex = 58;
            this.label8.Text = "Цена за единицу";
            // 
            // txt_product
            // 
            this.txt_product.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_product.Location = new System.Drawing.Point(785, 63);
            this.txt_product.Name = "txt_product";
            this.txt_product.ReadOnly = true;
            this.txt_product.Size = new System.Drawing.Size(257, 32);
            this.txt_product.TabIndex = 57;
            this.txt_product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_product_KeyPress);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(535, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 32);
            this.label9.TabIndex = 56;
            this.label9.Text = "Продукт";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.Location = new System.Drawing.Point(12, 253);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(135, 43);
            this.btn_cancel.TabIndex = 55;
            this.btn_cancel.Text = "Отменить";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.Location = new System.Drawing.Point(12, 204);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(135, 43);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkRed;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(325, 204);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(135, 43);
            this.btn_delete.TabIndex = 53;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Телефон";
            // 
            // txt_regDate
            // 
            this.txt_regDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_regDate.Location = new System.Drawing.Point(243, 108);
            this.txt_regDate.Name = "txt_regDate";
            this.txt_regDate.ReadOnly = true;
            this.txt_regDate.Size = new System.Drawing.Size(217, 32);
            this.txt_regDate.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Дата регистрации";
            // 
            // txt_companyName
            // 
            this.txt_companyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_companyName.Location = new System.Drawing.Point(243, 66);
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.Size = new System.Drawing.Size(217, 32);
            this.txt_companyName.TabIndex = 14;
            this.txt_companyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_companyName_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Компания";
            // 
            // cb_product
            // 
            this.cb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_product.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Location = new System.Drawing.Point(785, 63);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(257, 32);
            this.cb_product.TabIndex = 73;
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
            this.dg_catalog.Size = new System.Drawing.Size(699, 855);
            this.dg_catalog.TabIndex = 0;
            this.dg_catalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_catalog_CellClick);
            // 
            // ManageSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 855);
            this.Controls.Add(this.splitContainerRight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageSuppliers";
            this.Text = "Каталог поставщиков";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageSuppliers_Load);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel1.PerformLayout();
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            this.splitContainerLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_catalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_regDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_companyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dg_catalog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_cancelProduct;
        private System.Windows.Forms.Button btn_saveProduct;
        private System.Windows.Forms.Button btn_delProduct;
        private System.Windows.Forms.Button btn_changeProduct;
        private System.Windows.Forms.ComboBox cb_companyName;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.MaskedTextBox txt_phone;
        private System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Label label11;
    }
}