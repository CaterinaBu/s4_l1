namespace s4_l1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.numericUpDown_VendorCode = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_date0 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_date1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VendorCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Артикул";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стоимость";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(160, 59);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(418, 31);
            this.textBox_Name.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата изготовления";
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.DecimalPlaces = 2;
            this.numericUpDown_price.Location = new System.Drawing.Point(160, 204);
            this.numericUpDown_price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.Size = new System.Drawing.Size(418, 31);
            this.numericUpDown_price.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Срок реализации";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(52, 422);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(528, 67);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // numericUpDown_VendorCode
            // 
            this.numericUpDown_VendorCode.Location = new System.Drawing.Point(160, 130);
            this.numericUpDown_VendorCode.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_VendorCode.Name = "numericUpDown_VendorCode";
            this.numericUpDown_VendorCode.Size = new System.Drawing.Size(418, 31);
            this.numericUpDown_VendorCode.TabIndex = 13;
            // 
            // dateTimePicker_date0
            // 
            this.dateTimePicker_date0.Location = new System.Drawing.Point(52, 316);
            this.dateTimePicker_date0.Name = "dateTimePicker_date0";
            this.dateTimePicker_date0.Size = new System.Drawing.Size(228, 31);
            this.dateTimePicker_date0.TabIndex = 14;
            // 
            // dateTimePicker_date1
            // 
            this.dateTimePicker_date1.Location = new System.Drawing.Point(350, 316);
            this.dateTimePicker_date1.Name = "dateTimePicker_date1";
            this.dateTimePicker_date1.Size = new System.Drawing.Size(228, 31);
            this.dateTimePicker_date1.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 596);
            this.Controls.Add(this.dateTimePicker_date1);
            this.Controls.Add(this.dateTimePicker_date0);
            this.Controls.Add(this.numericUpDown_VendorCode);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Добавление товара";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_VendorCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox_Name;
        private Label label5;
        private NumericUpDown numericUpDown_price;
        private Label label6;
        private Button button_save;
        private NumericUpDown numericUpDown_VendorCode;
        private DateTimePicker dateTimePicker_date0;
        private DateTimePicker dateTimePicker_date1;
    }
}