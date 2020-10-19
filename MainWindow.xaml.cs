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
using ClassLibrary1;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Class1 raznost = new Class1(tb1.Text, tb2.Text);

                lbl.Content = raznost.getClass1();
            }
            catch
            {
                lbl.Content = "Vveden ne vernii simvol";
            }

        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter Sing = new StreamWriter("Slog.txt");
                Sing.WriteLine(lbl.Content);
                Sing.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    ("error" + ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
