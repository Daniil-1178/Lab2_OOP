using System.Collections;
using static Lab2.StringArray;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class FrmMain : Form
    {
        StringArray array1 = new StringArray();
        StringArray array2 = new StringArray();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                array1.Add(txtInput.Text);
                UpdateDisplay();
                txtInput.Clear();
            }
        }

        private void btnAddSecond_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                array2.Add(txtInput.Text);
                txtInput.Clear();
                MessageBox.Show("Додано у другий масив для злиття");
            }
        }

        private void UpdateDisplay()
        {
            lstString.Items.Clear();
            for (int i = 0; i < array1.Count; i++)
            {
                lstString.Items.Add($"[{i}]: {array1.GetAt(i)}");
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            StringArray merged = array1.MergeUnique(array2);

            string report = "Результат злиття:\n";
            for (int i = 0; i < merged.Count; i++)
            {
                report += merged.GetAt(i) + "\n";
            }
            MessageBox.Show(report);
        }

        private void lstString_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstString.SelectedIndex;
            string value = array1.GetAt(index);
            this.Text = "Вибрано: " + value;
        }
    }
}