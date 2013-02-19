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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using Microsoft.Win32;

namespace WpfApplication2
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

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 +rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
         }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

           if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                    
                }
                
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

            ArrayList myAL = new ArrayList();
            int index;
            int itemCount = Convert.ToInt32(tbN.Text);
            Random rnd1 = new Random();
            int number;
            lbMain.Items.Clear();
            lbMain.Items.Add("Исходный массив");
            for (index = 1; index <= itemCount; index++)
            {
                number = -100 + rnd1.Next(200);
                myAL.Add(number);
                lbMain.Items.Add(number);
            }
            myAL.Sort();
            lbMain.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                lbMain.Items.Add(elem);
            }


                   
        }
    }
}
