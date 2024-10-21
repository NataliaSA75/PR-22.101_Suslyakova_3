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

namespace PR_22._101_Suslyakova_3
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
                int n = Convert.ToInt32(tb_n.Text);
                int min = Convert.ToInt32(tb_min.Text);
                int max = Convert.ToInt32(tb_max.Text);
                int x;
                StringBuilder sb = new StringBuilder("");
                string str = "";
                if (min > max) 
                {
                    x = min;
                    min = max;
                    max = x;
                }
                
                Random rd = new Random();
                List<int> array = new List<int>();

                for (int i = 0; i < array.Count; i++)
                {
                    array.Add(rd.Next(min, max));
                }
                
                array.Sort();
                List<int> list = new List<int>();
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        list.Add(array[i]);
                        array.RemoveAt(i);
                    }
                }
                
                for (int i = 0; i < array.Count; i++)
                {
                    list.Add(array.ElementAt(i));
                }
                for (int i = 0; i < list.Count; i++)
                {
                    sb.Append($"{list.ElementAt(i)}, ");
                }
                tbl_array.Text = sb.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
