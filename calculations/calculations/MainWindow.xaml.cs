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

namespace calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          
        }

        private static void NewMethod()
        {
            InitializeComponent();
        }

        private static void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Text2.Text.Length != 0)
                {
                    double no1 = Convert.ToInt32(Text1.Text);
                    double no2 = Convert.ToInt32(Text2.Text);
                    double Result = no1 + no2;
                    Equal.Content = Result.ToString();
                }
                else if (Text2.Text.Length == 0)
                    Equal.Content = ("Enter the number");

            }
            catch
            { }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Text2.Text.Length != 0)
                {
                    double no1 = Convert.ToInt32(Text1.Text);
                    double no2 = Convert.ToInt32(Text2.Text);
                    double Result = no1 - no2;
                    Equal.Content = Result.ToString();
                }
                else if
                         (Text2.Text.Length == 0)
                {
                    Equal.Content = ("Enter the number");

                }
            }
            catch
            {
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Text2.Text.Length != 0)
                {
                    double no1 = Convert.ToInt32(Text1.Text);
                    double no2 = Convert.ToInt32(Text2.Text);
                    double Result = no1 * no2;
                    Equal.Content = Result.ToString();
                }

                else if (Text2.Text.Length == 0)
                {
                    Equal.Content = ("Enter the number");

                }
            }
            catch
            { }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)

        {
            try
            {
                if (Text2.Text != "0")
                {
                    double no1 = Convert.ToInt32(Text1.Text);
                    double no2 = Convert.ToInt32(Text2.Text);
                    double Result = no1 / no2;
                    Equal.Content = Result.ToString();
                }
                else

                {
                    MessageBox.Show("Please Change the TEXT2 Because the 0 is not acceptable");
                }
            }
            catch
            {
                if (Text2.Text.Length == 0)
                    Equal.Content = ("Enter the number");
            }
        }
    }
}


