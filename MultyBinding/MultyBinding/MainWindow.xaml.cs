using System;
using System.Collections.Generic;
using System.Linq;
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

namespace MultyBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SliderFontSize.ValueChanged += SliderFontSize_ValueChanged;
        }
        

        private void Standart_btn(object sender, RoutedEventArgs e)
        {
            ResultTxt.FontSize = 50;
            ResultTxt.Foreground = Brushes.Black;
            ResultTxt.Text = "Hi Waleed ...";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultTxt.FontSize = 50;
            ResultTxt.Foreground = Brushes.Red;
            ResultTxt.Text = "Hmm Github ...";
        }

        private void SliderFontSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //if (ResultTxt == null) return;
            if ((SliderFontSize.Value >= 1) && (SliderFontSize.Value <= 30))
            {
                ResultTxt.Foreground = Brushes.Red;


            }
            else
                ResultTxt.Foreground = Brushes.Blue;
        }
}
}

