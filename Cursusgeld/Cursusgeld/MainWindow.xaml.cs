using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cursusgeld
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

        private void Numeriek_Click(object sender, RoutedEventArgs e)
        {
            int nummeriek;
            if (int.TryParse(yearTextBox.Text, out nummeriek))
            {
                isNummeriekTextBlock.Text = "is nummeriek";
            }
            else
            {
                isNummeriekTextBlock.Text = "geef een correct jaartal";
            }
        }

        private void berekenenButton_Click(object sender, RoutedEventArgs e)
        {
            double hour = double.Parse(HoursTextBox.Text);
            int Year = int.Parse(yearTextBox.Text);
            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
            {
                isSchrikkeljaarTextBlock.Text = "is een schrikkeljaar";
                hour++;
                double money = hour * 1.5;
                RegisterCostTextBox.Text = money.ToString();
            }
            else
            {
                isSchrikkeljaarTextBlock.Text = "is geen schrikkeljaar";
                double money = hour * 1.5;
                RegisterCostTextBox.Text = money.ToString();
            }
        }
    }
}