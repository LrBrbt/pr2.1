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

namespace pr2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double firstRoot = 0;
        double secondRoot = 0;

        private void SolveEquation_Click(object sender, RoutedEventArgs e)
        {
            string[] odds = OddsTXT.Text.Split(' ', ',', ';');

            try
            {
                if (!odds[0].Contains("1"))
                {
                    EquationTXT.Text = odds[0] + "x^2 + " + odds[1] + "x" + " + " + odds[2] + " = 0";
                }
                else
                {
                    EquationTXT.Text = "x^2 + " + odds[1] + "x" + " + " + odds[2] + " = 0";
                }

                double firstOdd = double.Parse(odds[0]);
                double secondOdd = double.Parse(odds[1]);
                double thirdOdd = double.Parse(odds[2]);

                double minusSecondOdd = secondOdd * -1;

                double discriminant = Math.Pow(secondOdd, 2) - 4 * firstOdd * thirdOdd;

                if (discriminant > 0)
                {
                    firstRoot = (minusSecondOdd + Math.Sqrt(discriminant)) / 2 * double.Parse(odds[0]);
                    secondRoot = (minusSecondOdd - Math.Sqrt(discriminant)) / 2 * double.Parse(odds[0]);

                    MessageBox.Show("Первый корень: " + firstRoot.ToString() + '\n' + "Второй корень: " + secondRoot.ToString());
                }
                else if (discriminant == 0)
                {
                    firstRoot = (minusSecondOdd + Math.Sqrt(discriminant)) / 2 * double.Parse(odds[0]);
                    MessageBox.Show("Корень: " + firstRoot.ToString());
                }
                else
                {
                    MessageBox.Show("Корней нет");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void ClearFieldBTN_Click(object sender, RoutedEventArgs e)
        {
            EquationTXT.Text = string.Empty;
            OddsTXT.Text = string.Empty;

        }

        private void EquationTXT_GotFocus(object sender, RoutedEventArgs e)
        {
            OddsTXT.Text = string.Empty;
            OddsTXT.Foreground = Brushes.Black;
            OddsTXT.FontStyle = FontStyles.Normal;
            OddsTXT.FontWeight = FontWeights.Thin;

        }
    }
}
