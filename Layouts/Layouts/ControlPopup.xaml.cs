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
using System.Windows.Shapes;
using System.Diagnostics;

namespace Layouts
{
    /// <summary>
    /// Interaction logic for ControlPopup.xaml
    /// </summary>
    public partial class ControlPopup : Window
    {
        public ControlPopup()
        {
            InitializeComponent();
        }
        //Open popup when MouseEnter run
        private void run_MouseEnter(object sender, MouseEventArgs e)
        {
            popLink.IsOpen = true;
        }
        //Run link wiki
        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(((Hyperlink)sender).NavigateUri.ToString());
        }
    }
}
