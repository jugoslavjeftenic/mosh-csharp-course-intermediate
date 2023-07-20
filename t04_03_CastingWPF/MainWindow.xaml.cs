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

namespace t04_03_CastingWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var button = (Button)sender;
            //button.Height = 100;
            //button.Width = 200;

            var button2 = sender as Button;
            if (button2 != null)
            {
                button2.Height = 100;
                button2.Width = 200;
                MessageBox.Show(button2.ActualHeight.ToString());
            }

            MessageBox.Show("Hello World!");
        }
    }
}
