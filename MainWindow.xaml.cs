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

namespace _312576fileReadExample
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

        private void readFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("Birthday List.txt");
                lblOutput.Content = "";
                while (!sr.EndOfStream)
                {
                    lblOutput.Content += sr.ReadLine() +Environment.NewLine;
                }
                sr.Close();

            }//End try
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//End catch
        }

        private void btnReadFile2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("br2.txt");
                lblOutput.Content = "";
                string output = "";
                while (!sr.EndOfStream)
                {
                    string fullName = sr.ReadLine();
                    string[] names =
                    fullName.Split(new char[] { ',' });
                    output += names[1] + Environment.NewLine;
                    //Change in the names[] for 0 for first names and 1 for last name
                }
                lblOutput.Content = output;
                sr.Close();

            }//End try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//End catch
        }
    }
}
