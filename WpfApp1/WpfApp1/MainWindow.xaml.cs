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

namespace WpfApp1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("We Know where u live \n We r Coming to get you");
            string words = textBox1.Text;

            textBox1.Text = "Good Job!!!";

            label.Content = words;  
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            PopupWindow pop = new PopupWindow();

            pop.ShowDialog();
        }
    }
}
