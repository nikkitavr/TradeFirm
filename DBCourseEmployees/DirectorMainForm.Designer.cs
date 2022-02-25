
namespace DBCourseEmployees
{
    partial class DirectorMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.персоналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.добавитьСотрудникаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.продукцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПоставщиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПоставщикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.управлениеПродукциейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.персоналToolStripMenuItem,
            this.продукцияToolStripMenuItem,
            this.личныйКабинетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(997, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // персоналToolStripMenuItem
            // 
            this.персоналToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem,
            this.toolStripMenuItem1,
            this.добавитьСотрудникаToolStripMenuItem1,
            this.toolStripMenuItem3});
            this.персоналToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.персоналToolStripMenuItem.Name = "персоналToolStripMenuItem";
            this.персоналToolStripMenuItem.Size = new System.Drawing.Size(116, 40);
            this.персоналToolStripMenuItem.Text = "Персонал";
            // 
            // добавитьСотрудникаToolStripMenuItem
            // 
            this.добавитьСотрудникаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСотрудниковToolStripMenuItem,
            this.добавлениеСотрудникаToolStripMenuItem});
            this.добавитьСотрудникаToolStripMenuItem.Name = "добавитьСотрудникаToolStripMenuItem";
            this.добавитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(328, 32);
            this.добавитьСотрудникаToolStripMenuItem.Text = "Управление персоналом";
            this.добавитьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСотрудникаToolStripMenuItem_Click);
            // 
            // списокСотрудниковToolStripMenuItem
            // 
            this.списокСотрудниковToolStripMenuItem.Name = "списокСотрудниковToolStripMenuItem";
            this.списокСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(298, 32);
            this.списокСотрудниковToolStripMenuItem.Text = "Список сотрудников";
            this.списокСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.списокСотрудниковToolStripMenuItem_Click);
            // 
            // добавлениеСотрудникаToolStripMenuItem
            // 
            this.добавлениеСотрудникаToolStripMenuItem.Name = "добавлениеСотрудникаToolStripMenuItem";
            this.добавлениеСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(298, 32);
            this.добавлениеСотрудникаToolStripMenuItem.Text = "Добавить сотрудника";
            this.добавлениеСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.добавлениеСотрудникаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(325, 6);
            // 
            // добавитьСотрудникаToolStripMenuItem1
            // 
            this.добавитьСотрудникаToolStripMenuItem1.Name = "добавитьСотрудникаToolStripMenuItem1";
            this.добавитьСотрудникаToolStripMenuItem1.Size = new System.Drawing.Size(328, 32);
            this.добавитьСотрудникаToolStripMenuItem1.Text = "Должности";
            this.добавитьСотрудникаToolStripMenuItem1.Click += new System.EventHandler(this.добавитьСотрудникаToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(325, 6);
            // 
            // продукцияToolStripMenuItem
            // 
            this.продукцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставщикиToolStripMenuItem,
            this.toolStripMenuItem2,
            this.управлениеПродукциейToolStripMenuItem});
            this.продукцияToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.продукцияToolStripMenuItem.Name = "продукцияToolStripMenuItem";
            this.продукцияToolStripMenuItem.Size = new System.Drawing.Size(129, 40);
            this.продукцияToolStripMenuItem.Text = "Продукция";
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПоставщиковToolStripMenuItem,
            this.добавитьПоставщикаToolStripMenuItem});
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(327, 32);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            // 
            // списокПоставщиковToolStripMenuItem
            // 
            this.списокПоставщиковToolStripMenuItem.Name = "списокПоставщиковToolStripMenuItem";
            this.списокПоставщиковToolStripMenuItem.Size = new System.Drawing.Size(302, 32);
            this.списокПоставщиковToolStripMenuItem.Text = "Список поставщиков";
            this.списокПоставщиковToolStripMenuItem.Click += new System.EventHandler(this.списокПоставщиковToolStripMenuItem_Click);
            // 
            // добавитьПоставщикаToolStripMenuItem
            // 
            this.добавитьПоставщикаToolStripMenuItem.Name = "добавитьПоставщикаToolStripMenuItem";
            this.добавитьПоставщикаToolStripMenuItem.Size = new System.Drawing.Size(302, 32);
            this.добавитьПоставщикаToolStripMenuItem.Text = "Добавить поставщика";
            this.добавитьПоставщикаToolStripMenuItem.Click += new System.EventHandler(this.добавитьПоставщикаToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(324, 6);
            // 
            // управлениеПродукциейToolStripMenuItem
            // 
            this.управлениеПродукциейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорииТоваровToolStripMenuItem,
            this.списокТоваровToolStripMenuItem});
            this.управлениеПродукциейToolStripMenuItem.Name = "управлениеПродукциейToolStripMenuItem";
            this.управлениеПродукциейToolStripMenuItem.Size = new System.Drawing.Size(327, 32);
            this.управлениеПродукциейToolStripMenuItem.Text = "Управление продукцией";
            // 
            // категорииТоваровToolStripMenuItem
            // 
            this.категорииТоваровToolStripMenuItem.Name = "категорииТоваровToolStripMenuItem";
            this.категорииТоваровToolStripMenuItem.Size = new System.Drawing.Size(275, 32);
            this.категорииТоваровToolStripMenuItem.Text = "Категории товаров";
            this.категорииТоваровToolStripMenuItem.Click += new System.EventHandler(this.категорииТоваровToolStripMenuItem_Click);
            // 
            // списокТоваровToolStripMenuItem
            // 
            this.списокТоваровToolStripMenuItem.Name = "списокТоваровToolStripMenuItem";
            this.списокТоваровToolStripMenuItem.Size = new System.Drawing.Size(275, 32);
            this.списокТоваровToolStripMenuItem.Text = "Список товаров";
            this.списокТоваровToolStripMenuItem.Click += new System.EventHandler(this.списокТоваровToolStripMenuItem_Click);
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.личныйКабинетToolStripMenuItem.AutoSize = false;
            this.личныйКабинетToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.личныйКабинетToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.личныйКабинетToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("личныйКабинетToolStripMenuItem.Image")));
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(54, 40);
            this.личныйКабинетToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.личныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.личныйКабинетToolStripMenuItem_Click);
            // 
            // DirectorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(997, 566);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "DirectorMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectorMainForm_FormClosing);
            this.Load += new System.EventHandler(this.DirectorMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem персоналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem продукцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПоставщиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПоставщикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem управлениеПродукциейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem категорииТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТоваровToolStripMenuItem;
    }
}