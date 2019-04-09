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

        private void sort_Click(object sender, RoutedEventArgs e)
        {   string[] hold;
            int[] A;
            hold = In.Text.Split(' ');
            A = new int[hold.Length];
            string output ="";DateTime End = new DateTime();
            DateTime Start = new DateTime();
            Start = DateTime.Now;
            for (int i = 0; i < hold.Length; i++)
            {
                bool b = Int32.TryParse(hold[i], out Int32 Result);
                if (b == true)
                {
                    A[i] = Int32.Parse(hold[i]);

                    int x = A[i];
                    int j = i - 1;
                    while (j >= 0 && A[j] > x)
                    {
                        A[j + 1] = A[j];
                        j = j - 1;
                    }
                    A[j + 1] = x;
                }
                else
                {
                }

            }
            for (int i = 0; i<A.Length; i++) { output += A[i]; output += ','; }
               
            lblOut.Content = output;
            End = DateTime.Now;
            TimeSpan dif = End.Subtract(Start);
            MessageBox.Show(dif.TotalMilliseconds.ToString());
        }

        private void In_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
