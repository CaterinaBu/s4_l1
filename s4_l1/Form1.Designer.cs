namespace s4_l1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addToolButton = new System.Windows.Forms.ToolStripButton();
            this.editToolButton = new System.Windows.Forms.ToolStripButton();
            this.viewToolButton = new System.Windows.Forms.ToolStripButton();
            this.delToolButton = new System.Windows.Forms.ToolStripButton();
            this.aboutToolButton = new System.Windows.Forms.ToolStripButton();
            this.listView = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnVendorCode = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.columnDate0 = new System.Windows.Forms.ColumnHeader();
            this.columnDate1 = new System.Windows.Forms.ColumnHeader();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolButton,
            this.editToolButton,
            this.viewToolButton,
            this.delToolButton,
            this.aboutToolButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addToolButton
            // 
            this.addToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolButton.Name = "addToolButton";
            this.addToolButton.Size = new System.Drawing.Size(94, 29);
            this.addToolButton.Text = "Добавить";
            this.addToolButton.Click += new System.EventHandler(this.AddToolButton_Click);
            // 
            // editToolButton
            // 
            this.editToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolButton.Name = "editToolButton";
            this.editToolButton.Size = new System.Drawing.Size(137, 29);
            this.editToolButton.Text = "Редактировать";
            this.editToolButton.Click += new System.EventHandler(this.EditToolButton_Click);
            // 
            // viewToolButton
            // 
            this.viewToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewToolButton.Name = "viewToolButton";
            this.viewToolButton.Size = new System.Drawing.Size(101, 29);
            this.viewToolButton.Text = "Просмотр";
            this.viewToolButton.Click += new System.EventHandler(this.ViewToolButton_Click);
            // 
            // delToolButton
            // 
            this.delToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.delToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delToolButton.Name = "delToolButton";
            this.delToolButton.Size = new System.Drawing.Size(80, 29);
            this.delToolButton.Text = "Удалить";
            this.delToolButton.Click += new System.EventHandler(this.DelToolButton_Click);
            // 
            // aboutToolButton
            // 
            this.aboutToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolButton.Name = "aboutToolButton";
            this.aboutToolButton.Size = new System.Drawing.Size(129, 29);
            this.aboutToolButton.Text = "О программе";
            this.aboutToolButton.Click += new System.EventHandler(this.AboutToolButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnVendorCode,
            this.columnPrice,
            this.columnDate0,
            this.columnDate1});
            this.listView.FullRowSelect = true;
            this.listView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listView.Location = new System.Drawing.Point(0, 79);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(800, 300);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Tag = "Name";
            this.columnName.Text = "Название";
            this.columnName.Width = 140;
            // 
            // columnVendorCode
            // 
            this.columnVendorCode.Tag = "VendorCode";
            this.columnVendorCode.Text = "Артикул";
            this.columnVendorCode.Width = 120;
            // 
            // columnPrice
            // 
            this.columnPrice.Tag = "price";
            this.columnPrice.Text = "Стоимость";
            this.columnPrice.Width = 120;
            // 
            // columnDate0
            // 
            this.columnDate0.Tag = "date0";
            this.columnDate0.Text = "Дата_изготовления";
            this.columnDate0.Width = 200;
            // 
            // columnDate1
            // 
            this.columnDate1.Tag = "date1";
            this.columnDate1.Text = "Срок_реализации";
            this.columnDate1.Width = 200;
            // 
            // addButton
            // 
            this.addButton.Image = global::s4_l1.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(575, 398);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(47, 45);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editButton
            // 
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.Location = new System.Drawing.Point(628, 398);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(47, 45);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "+";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Image = ((System.Drawing.Image)(resources.GetObject("viewButton.Image")));
            this.viewButton.Location = new System.Drawing.Point(681, 398);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(47, 45);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "+";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // delButton
            // 
            this.delButton.Image = ((System.Drawing.Image)(resources.GetObject("delButton.Image")));
            this.delButton.Location = new System.Drawing.Point(734, 398);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(47, 45);
            this.delButton.TabIndex = 5;
            this.delButton.Text = "+";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список товаров";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Склад молочных продуктов";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton addToolButton;
        private ToolStripButton editToolButton;
        private ToolStripButton viewToolButton;
        private ToolStripButton delToolButton;
        private ToolStripButton aboutToolButton;
        private ListView listView;
        private Button addButton;
        private Button editButton;
        private Button viewButton;
        private Button delButton;
        private Label label1;
        private ColumnHeader columnName;
        private ColumnHeader columnVendorCode;
        private ColumnHeader columnPrice;
        private ColumnHeader columnDate0;
        private ColumnHeader columnDate1;
    }
}