using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string textBoxValue = "";
        private int a = 0, b = 0;
        private char op = ' ';
        public MainWindow()
        {
            InitializeComponent();


        }

        private void fin()
        {
            b = int.Parse(TextBox.Text);
            if (op == '*')
            {
                int sum = a * b;
                TextBox.Text = sum.ToString();
            }
            else if (op == '+')
            {
                int sum = a + b;
                TextBox.Text = sum.ToString();
            }
            else if (op == '/')
            {
                int sum = a / b;
                TextBox.Text = sum.ToString();
            }
            else if (op == '-')
            {
                int sum = a - b;
                TextBox.Text = sum.ToString();
            }
        }

        private void Shumezo(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TextBox.Text);
            if(op == ' ')
            {
                op = '*';
            }
            else
            {
                fin();
                op = '*';
            }
            TextBox.Text = "";
            textBoxValue = "";
        }

        private void Mblidh(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TextBox.Text);
            if (op == ' ')
            {
                op = '+';
            }
            else
            {
                fin();
                op = '+';
            }

            TextBox.Text = "";
            textBoxValue = "";
        }

        private void Pjeseto(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TextBox.Text);
            if (op == ' ')
            {
                op = '/';
            }
            else
            {
                fin();
                op = '/';
            }

            TextBox.Text = "";
            textBoxValue = "";
        }

        private void Zbrit(object sender, RoutedEventArgs e)
        {
            a = int.Parse(TextBox.Text);
            if (op == ' ')
            {
                op = '-';
            }
            else
            {
                fin();
                op = '-';
            }

            TextBox.Text = "";
            textBoxValue = "";
        }

        private void Final(object sender, RoutedEventArgs e)
        {
            fin();

        }

        private void Add(string val)
        {
            textBoxValue += val;
            TextBox.Text = textBoxValue;
        }

        private void Add9(object sender, RoutedEventArgs e)
        {
            Add("9");
        }

        private void Add7(object sender, RoutedEventArgs e)
        {
            Add("7");
        }

        private void Add8(object sender, RoutedEventArgs e)
        {
            Add("8");
        }

        private void Add6(object sender, RoutedEventArgs e)
        {
            Add("6");
        }

        private void Add5(object sender, RoutedEventArgs e)
        {
            Add("5");
        }

        private void Add4(object sender, RoutedEventArgs e)
        {
            Add("4");
        }

        private void Add1(object sender, RoutedEventArgs e)
        {
            Add("1");
        }

        private void Add2(object sender, RoutedEventArgs e)
        {
            Add("2");
        }

        private void Add3(object sender, RoutedEventArgs e)
        {
            Add("3");
        }

        private void Add0(object sender, RoutedEventArgs e)
        {
            Add("0");
        }
    }
}
