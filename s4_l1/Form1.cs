using System;

namespace s4_l1
{
    public partial class Form1 : Form
    {
        private List<DiaryProduct> DiaryProducts { get; set; }

        public Form1()
        {
            DiaryProducts = new List<DiaryProduct>();
            InitializeComponent();
        }
        private void Add()
        {
            Form2 newForm = new(this);
            newForm.Show();
        }

        private void Edit(int selectedIndex)
        {
            if (listView.SelectedIndices.Count == 0) throw new ErrorNothingSelected("редактирования");
            Form2 newForm = new(this, DiaryProducts[selectedIndex/*listView.SelectedIndices[0]*/], /*listView.SelectedIndices[0]*/ selectedIndex);
            newForm.Show();
        }
        private void View(int selectedIndex)
        {
            if (listView.SelectedIndices.Count == 0) throw new ErrorNothingSelected("просмотра");
            DiaryProduct diary = DiaryProducts[selectedIndex];
            MessageBox.Show("Название: " + diary.Name + "\nАртикул: " + diary.VendorCode + "\nСтоимость: " + diary.Price +
                "\nДата изготовления: " + diary.date[0].ToLongDateString() + "\nСрок реализации: " + diary.date[1].ToLongDateString(),"Просмотр товара",
                MessageBoxButtons.OK);
        }

        private void Del(int selectedIndex)
        {
            if (listView.SelectedIndices.Count == 0) throw new ErrorNothingSelected("удаления");

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить запись?", // text
                "Подтвердите действие", // header
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DiaryProducts.RemoveAt(selectedIndex);
                listView.Items.RemoveAt(selectedIndex);
            }
        }
        private static void Info()
        {
            MessageBox.Show("Программа написана в рамках лабораторной работы №1" +
                "\nРазработка программ на языке С# с графическим интерфейсом пользователя." +
                "\nАвтор: Никулина Екатерина, группа ДТ-160." +
                "\nНГТУ, 2023 год",
                "О приложении");
        }

        private static void Validate(Action action)
        {
            try
            {
                action();
            }

            catch (ErrorNothingSelected ex)
            {
                MessageBox.Show("Не выбрана запись для " + ex.Message + "!",
                "Ошибка!", // header
                MessageBoxButtons.OK,
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
        public void AddElement(DiaryProduct diary)
        {
            DiaryProducts.Add(diary);
            ListViewItem lvi = new(new string[] 
            { 
                diary.Name, 
                diary.VendorCode.ToString(), 
                diary.Price.ToString(), 
                diary.date[0].ToLongDateString(), 
                diary.date[1].ToLongDateString() 
            });
            listView.Items.Add(lvi);
        }
        public void EditElement(DiaryProduct diary, int selectedIndex)
        {
            DiaryProducts[selectedIndex] = diary;
            listView.Items.RemoveAt(selectedIndex);
            ListViewItem lvi = new(new string[]
            {
                diary.Name,
                diary.VendorCode.ToString(),
                diary.Price.ToString(),
                diary.date[0].ToLongDateString(),
                diary.date[1].ToLongDateString()
            });
            listView.Items.Insert(selectedIndex, lvi);
  }

        private void AddToolButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void EditToolButton_Click(object sender, EventArgs e)
        {
            Validate(() => { Edit(listView.FocusedItem.Index); });
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Validate(() => { Edit(listView.FocusedItem.Index); });
        }

        private void ViewToolButton_Click(object sender, EventArgs e)
        {
            Validate(() => { View(listView.FocusedItem.Index); });
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Validate(() => { View(listView.FocusedItem.Index); });
        }

        private void DelToolButton_Click(object sender, EventArgs e)
        {
            Validate(() => { Del(listView.FocusedItem.Index); });
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            Validate(() => { Del(listView.FocusedItem.Index); });
        }

        private void AboutToolButton_Click(object sender, EventArgs e)
        {
            Info();
        }
    }
}