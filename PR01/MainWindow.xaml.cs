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

using System.Text.RegularExpressions;
using System.IO;


namespace PR01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbPassport1.MaxLength = 4;
            tbPassport2.MaxLength = 6;
            tbNumber.MaxLength = 12;
        }

        Regex inputNumber = new Regex(@"[0-9]");
        Regex inputChar = new Regex(@"^[а-яА-Я]+$");
        Regex inputEmail = new Regex(@"[a-zA-Z0-9_\-\.]");

        private void TbID_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputNumber.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }

        private void TbNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputNumber.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }

        private void TbSurName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputChar.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }

        private void TbName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputChar.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }

        private void TbPatro_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputChar.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }

        private void TbPassport1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputNumber.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }

        private void TbPassport2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputNumber.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }

        private void TbEmail_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Match match = inputEmail.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\danil\Desktop\employee.txt";
            List<string> employeeList = new List<string>();
            employeeList.Add(tbID.Text);
            employeeList.Add($"{tbSurName.Text} {tbName.Text} {tbPatro.Text}");
            employeeList.Add($"{tbPassport1.Text} {tbPassport2.Text}");
            employeeList.Add(tbNumber.Text);
            employeeList.Add($"{tbEmail.Text}@firma.ru");
            using (StreamWriter sw = new StreamWriter(path,true))
            {
                foreach (var akk in employeeList)
                {
                    sw.WriteLineAsync(akk.ToString());
                }
                sw.WriteLine("\n");
                sw.Close();
            }
        }
    }
}

