using Microsoft.VisualBasic;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonKeyB_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Введіть кількість елементів:"));
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Введіть елемент {i + 1}:"));
            }
            Array();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                

                listBox1.Items.Clear();
                listBox2.Items.Clear();

                List<int> numbers = new List<int>();

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i].Trim(); 
                    if (line == "") continue;      

                    if (int.TryParse(line, out int num))
                    {
                        numbers.Add(num);
                        listBox1.Items.Add(num);
                    }
                    else
                    {
                        MessageBox.Show($"Error");
                    }
                }

                a = numbers.ToArray();
            }
                Array();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            if (!int.TryParse(textBox1.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Введіть правильну кількість елементів!");
                return;
            }
            a = new int[n];
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-15, 16); 
                listBox1.Items.Add(a[i]);
            }

            Array();
        }
        private void Array()
        {
            if (a == null || a.Length == 0)
            {
                listBox2.Items.Add("Масив порожній!");
                return;
            }

            int firstNegative = 0;
            int lastNegative = 0;
            bool hasNegative = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    if (!hasNegative)
                    firstNegative = a[i];  
                    lastNegative = a[i];       
                    hasNegative = true;
                }
            }

            if (hasNegative)
            {
                int sum = firstNegative + lastNegative;
                listBox2.Items.Add($"Перший від’ємний: {firstNegative}");
                listBox2.Items.Add($"Останній від’ємний: {lastNegative}");
                listBox2.Items.Add($"Сума: {sum}");
            }
            else
            {
                listBox2.Items.Add("Від’ємних елементів немає!");
            }
        }
    }
    
}
