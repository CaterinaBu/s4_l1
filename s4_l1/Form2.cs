using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace s4_l1
{
    public partial class Form2 : Form
    {
        Form1 parent;
        int itemIndex = -1;

        public Form2(Form1 f)
        {
            InitializeComponent();
            parent = f;
            this.Text = "Добавить";
        }

        public Form2(Form1 f, DiaryProduct diary, int itemIndex)
        {
            InitializeComponent();
            parent = f;
            this.itemIndex = itemIndex;
            textBox_Name.Text = diary.Name;
            numericUpDown_VendorCode.Value = diary.VendorCode;
            numericUpDown_price.Value = diary.Price;
            dateTimePicker_date0.Value = diary.date[0];
            dateTimePicker_date1.Value = diary.date[1];
            this.Text = "Редактировать";
        }

        private static void Validate(Action action)
        {
            try
            {
                action();
            }
            catch (InputError ex) 
            {
                MessageBox.Show("Вы не вписали значение для поля " 
                    + ex.Message + ".", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Ошибка!", // header
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            Validate(() =>
            {
                if (textBox_Name.Text == "") throw new InputError("«Название»");
                if (numericUpDown_VendorCode.Value == 0) throw new InputError("«Артикул».\nЗначение поля должно быть натуральным числом");
                if (numericUpDown_price.Value == 0) throw new InputError("«Стоимость».\nЦена должна быть больше нуля");
                if (dateTimePicker_date0.Value > dateTimePicker_date1.Value) throw new InputError("«Даты».\nДата изготовления должна быть раньше даты срока реализации");
                if (itemIndex != -1)
                {
                    DialogResult result = MessageBox.Show("Вы действительно хотите изменить запись?", // text
                     "Подтвердите действие", // header
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        parent.EditElement(new DiaryProduct(textBox_Name.Text, numericUpDown_VendorCode.Value, numericUpDown_price.Value, dateTimePicker_date0.Value, dateTimePicker_date1.Value), itemIndex);
                    }

                }
                else
                {
                    DialogResult result = MessageBox.Show("Вы действительно хотите добавить запись?", // text
                    "Подтвердите действие", // header
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        parent.AddElement(new DiaryProduct(textBox_Name.Text, numericUpDown_VendorCode.Value, numericUpDown_price.Value, dateTimePicker_date0.Value, dateTimePicker_date1.Value));
                    }

                }
                this.Close();
            });
        }
    }
}
