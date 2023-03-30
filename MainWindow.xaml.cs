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
        double secondRoot= 0;

        private void SolveEquation_Click(object sender, RoutedEventArgs e)
        {
            string[] odds = EquationTXT.Text.Split(' ',',',';');
            double discriminant;

            double minusSecondOdd = double.Parse(odds[1]) * -1;

            if(discriminant > 0)
            {
                firstRoot = (minusSecondOdd + Math.Sqrt(discriminant)) / 2 * double.Parse(odds[0]);
                secondRoot = (minusSecondOdd - Math.Sqrt(discriminant)) / 2 * double.Parse(odds[0]);

                MessageBox.Show(firstRoot.ToString() + '\n' + secondRoot.ToString());
            }
            else if(discriminant == 0) 
            {
                firstRoot = (minusSecondOdd + Math.Sqrt(discriminant)) / 2 * double.Parse(odds[0]);
                MessageBox.Show(firstRoot.ToString() + '\n' + secondRoot.ToString());
            }
            else
            {
                MessageBox.Show("Корней нет");
            }


        }

        private void ClearFieldBTN_Click(object sender, RoutedEventArgs e)
        {
            EquationTXT.Text = string.Empty;
        }

        private void EquationTXT_GotFocus(object sender, RoutedEventArgs e)
        {
            EquationTXT.Text = string.Empty;
            EquationTXT.Foreground = Brushes.Black;
            EquationTXT.FontStyle = FontStyles.Normal;
            EquationTXT.FontWeight = FontWeights.Thin;

        }
    }
}
