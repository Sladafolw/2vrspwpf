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

namespace _2vrspwpf
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
            int bn = int.TryParse(bMassiv.Text, out bn)&& bn>0 ? bn : 19;
            int cn = int.TryParse( cMassiv.Text, out cn) && cn> 0 ? cn : 21;
            double[] b = new double[bn];
            double[] c = new double[cn];
            double[] a = new double[20];
            double h = -2;
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                try
                {

                    a[i] = 1 / (h * h - 1);

                    h = h + 0.1;
                    Console1.Text += ($"\n  massiv a ={a[i]}");
                }
                catch (OutOfMemoryException) { Console1.Text += ("\n OutOfMemoryException"); a[i] = 0; Console1.Text += ($"\n  massiv a ={a[i]}"); }
                catch (ArgumentOutOfRangeException) { Console1.Text += ("\n ArgumentOutOfRangeException"); a[i] = 0; Console1.Text += ($"\n  massiv a ={a[i]}"); }
                catch (IndexOutOfRangeException) { Console1.Text += ("\n IndexOutOfRangeException"); a[i] = 0; Console1.Text += ($"\n  massiv a ={a[i]}"); }
                catch (DivideByZeroException) { Console1.Text += ("\n DivideByZeroException"); a[i] = 0; Console1.Text += ($"\n  massiv a ={a[i]}"); }
                catch (Exception) { Console1.Text += ("\n Another Exception"); a[i] = 0; Console1.Text += ($"\n  massiv a ={a[i]}"); }

            }
            for (int i = 0; i < bn; i++)
            {
                try
                {
                   
                    b[i] = random.Next(-10, 10);


                    Console2.Text += ($" \n massiv b ={b[i]}  ");
                }
                catch (OutOfMemoryException) { Console2.Text += ("\n OutOfMemoryException"); b[i] = 0; Console2.Text += ($"\n  massiv a ={b[i]}"); }
                catch (ArgumentOutOfRangeException) { Console2.Text += ("\n ArgumentOutOfRangeException"); b[i] = 0; Console2.Text += ($"\n  massiv a ={b[i]}"); }
                catch (IndexOutOfRangeException) { Console2.Text += ("\n IndexOutOfRangeException"); b[i] = 0; Console2.Text += ($"\n  massiv a ={b[i]}"); }
                catch (DivideByZeroException) { Console2.Text += ("\n DivideByZeroException"); b[i] = 0; Console2.Text += ($"\n  massiv a ={b[i]}"); }
                catch (Exception) { Console2.Text += ("\n Another Exception"); b[i] = 0; Console2.Text += ($"\n  massiv a ={b[i]}"); }

            }
            for (int i = 0; i < cn; i++)
            {
                try
                {

                    c[i] = a[i] + 2 / (b[i] + 1);

               
                    Console3.Text += ($"\n massiv c ={c[i]}");
                }
                catch (OutOfMemoryException) { Console3.Text += ("\n OutOfMemoryException"); c[i] = 0; Console3.Text += ($"\n  massiv a ={c[i]}"); }
                catch (ArgumentOutOfRangeException) { Console3.Text += ("\n ArgumentOutOfRangeException"); c[i] = 0; Console3.Text += ($"\n  massiv a ={c[i]}"); }
                catch (IndexOutOfRangeException) { Console3.Text += ("\n IndexOutOfRangeException"); c[i] = 0; Console3.Text += ($"\n  massiv a ={c[i]}"); }
                catch (DivideByZeroException) { Console3.Text += (" \n DivideByZeroException"); c[i] = 0; Console3.Text += ($"\n  massiv a ={c[i]}"); }
                catch (Exception) { Console3.Text += ("\nAnother Exception"); c[i] = 0; Console3.Text += ($"\n  massiv a ={c[i]}"); }

            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Console1.Text = "";
            Console2.Text = "";
            Console3.Text = "";
        }
    }
}

