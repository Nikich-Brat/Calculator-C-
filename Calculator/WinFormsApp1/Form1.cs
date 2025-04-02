namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const string plus = "+";
        private const string minus = "-";
        private const string multiply = "*";
        private const string divide = "/";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string astring = textBox1.Text;
            string bstring = textBox2.Text;
            string cbstring = comboBox1.Text;
            double a = Convert.ToDouble(astring);
            double b = Convert.ToDouble(bstring);
            double c = 0;
            switch (cbstring)
            {
                case plus:
                    {
                        c = a + b;
                        break;
                    }
                case minus:
                    {
                        c = a - b;
                        break;
                    }
                case multiply:
                    {
                        c = a * b;
                        break;
                    }
                case divide:
                    {
                        _ = b != 0 ? c = a / b : (float)MessageBox.Show("You have mistaken");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("You have mistaken");
                        break;
                    }
            }
            textBox3.Text = Convert.ToString(c);
        }
    }
}
