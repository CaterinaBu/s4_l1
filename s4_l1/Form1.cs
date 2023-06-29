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
            if (listView.SelectedIndices.Count == 0) throw new ErrorNothingSelected("��������������");
            Form2 newForm = new(this, DiaryProducts[selectedIndex/*listView.SelectedIndices[0]*/], /*listView.SelectedIndices[0]*/ selectedIndex);
            newForm.Show();
        }
        private void View(int selectedIndex)
        {
            if (listView.SelectedIndices.Count == 0) throw new ErrorNothingSelected("���������");
            DiaryProduct diary = DiaryProducts[selectedIndex];
            MessageBox.Show("��������: " + diary.Name + "\n�������: " + diary.VendorCode + "\n���������: " + diary.Price +
                "\n���� ������������: " + diary.date[0].ToLongDateString() + "\n���� ����������: " + diary.date[1].ToLongDateString(),"�������� ������",
                MessageBoxButtons.OK);
        }

        private void Del(int selectedIndex)
        {
            if (listView.SelectedIndices.Count == 0) throw new ErrorNothingSelected("��������");

            DialogResult result = MessageBox.Show("�� ������������� ������ ������� ������?", // text
                "����������� ��������", // header
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
            MessageBox.Show("��������� �������� � ������ ������������ ������ �1" +
                "\n���������� �������� �� ����� �# � ����������� ����������� ������������." +
                "\n�����: �������� ���������, ������ ��-160." +
                "\n����, 2023 ���",
                "� ����������");
        }

        private static void Validate(Action action)
        {
            try
            {
                action();
            }

            catch (ErrorNothingSelected ex)
            {
                MessageBox.Show("�� ������� ������ ��� " + ex.Message + "!",
                "������!", // header
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "������!", // header
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