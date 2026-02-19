using System.Collections;
using static Lab2.StringArray;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class FrmMain : Form
    {
        // Створюємо два масиви для демонстрації операцій злиття та зчеплення
        StringArray array1 = new StringArray();
        StringArray array2 = new StringArray();

        public FrmMain()
        {
            InitializeComponent();
        }

        // Кнопка додавання рядка у перший масив
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                array1.Add(txtInput.Text);
                UpdateDisplay();
                txtInput.Clear();
            }
        }

        // Кнопка додавання рядка у другий масив (для тестів)
        private void btnAddSecond_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                array2.Add(txtInput.Text);
                txtInput.Clear();
                MessageBox.Show("Додано у другий масив для злиття");
            }
        }

        // Виведення (друк) елементів першого масиву на екран
        private void UpdateDisplay()
        {
            lstString.Items.Clear();
            for (int i = 0; i < array1.Count; i++)
            {
                lstString.Items.Add($"[{i}]: {array1.GetAt(i)}");
            }
        }

        // Операція злиття без повторів
        private void btnMerge_Click(object sender, EventArgs e)
        {
            StringArray merged = array1.MergeUnique(array2);

            // Виводимо результат у вікно
            string report = "Результат злиття:\n";
            for (int i = 0; i < merged.Count; i++)
            {
                report += merged.GetAt(i) + "\n";
            }
            MessageBox.Show(report);
        }

        // Перевірка контролю меж (при натисканні на елемент списку)
        private void lstArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstString.SelectedIndex;
            // Виклик методу, де реалізовано контроль if (index >= 0...)
            string value = array1.GetAt(index);
            this.Text = "Вибрано: " + value;
        }
    }
}