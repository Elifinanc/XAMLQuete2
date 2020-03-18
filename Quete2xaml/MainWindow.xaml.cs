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
using System.IO;

namespace Quete2xaml
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddSomeone_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox1.ToString() == String.Empty && listBox1.Items.Contains(TextBox1.Text))
            {
                MessageBox.Show("You enter an invalid name, or this name is already entered"); 
            }
            else
            {
                listBox1.Items.Add(TextBox1.Text);
            }
        }
    }
}
