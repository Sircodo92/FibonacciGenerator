using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciGenerator
{
    public partial class Form1 : Form
    {
        List<double > list = new List< double >();
        public Form1()
        {
            InitializeComponent();
        }

        private async void GenerateButton_Click(object sender, EventArgs e)
        {

            if (int.TryParse(InputTextBox.Text, out int count) && count > 0)
            {
                OutputListBox.Items.Clear();
                await Task.Run(() =>
                {
                    CalculateFibonacci(count);
                    
                });
                foreach (var item in list)
                {
                    OutputListBox.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer.");
            }
        }

        private void CalculateFibonacci(int n)
        {
            Thread.Sleep(1000);
            double a = 0;
            double b = 1;
            double c = 0;
            for(int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                list.Add(c);
            }   
        }
    }
}
