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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для WindowStud.xaml
    /// </summary>
    public partial class WindowStud : Window
    {
        public WindowStud()
        {
            InitializeComponent();
            
        }

        public class Student
        {
            public string FIO { get; set; }

            public string Group { get; set; }

            public string Phone { get; set; }
        }

        private void WindowStud_Closing()
        {

        }
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           List<MainWindow.Student> items = new List<MainWindow.Student>();
            items.Add(new MainWindow.Student() { FIO = textBoxFIO.Text.ToString(), Group = textBoxGroup.Text.ToString(), Phone = textBoxPhone.Text.ToString() });
            //MainWindow w = new MainWindow();
        }
    }
}
