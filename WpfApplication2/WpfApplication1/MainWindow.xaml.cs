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


namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonStudInDel.Content = ">";
            buttonStudFromDel.Content = "<";

            List<Student> items = new List<Student>();
            items.Add(new Student() { FIO = "Жопкин Анатолий Владимирович", Group = "ОрГу-11", Phone = "89012387631" });
            Stud.ItemsSource = items;
        }

        public class Student
        {
            public string FIO { get; set; }

            public string Group { get; set; }

            public string Phone { get; set; }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowStud w = new WindowStud();
            w.ShowDialog();
            
        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowStud w = new WindowStud();
          
            w.ShowDialog();

        }

        private void Stud_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
