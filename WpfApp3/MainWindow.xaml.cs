using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in Panel.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        public void Button_Click(Object sender, RoutedEventArgs e)
        {
            string textButton = ((Button)e.OriginalSource).Content.ToString();
            if (textButton == "CE")
            {
                StrokaVvoda.Clear();
                SText.Clear();
            }

            else if (textButton == "P")
            {
                Window a = new Window1();
                a.Show();
            }
            else if (textButton == "R")
            {
                Window a = new Window1();
                a.Show();
            }

            else if (textButton == "=")
            {
                StrokaVvoda.Text = new DataTable().Compute(StrokaVvoda.Text, null).ToString();
            }

            else
            {
                StrokaVvoda.Text += textButton;
            }
        }

        private void StrokaVvoda_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
