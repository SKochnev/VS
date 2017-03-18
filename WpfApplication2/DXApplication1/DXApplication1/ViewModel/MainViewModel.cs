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
using DevExpress.Xpf.Core;

namespace DXApplication1.ViewModel
{
    partial class MainViewModel : DXWindow
    {
        public MainViewModel()
        {
            InitializeComponent();
            
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            // WindowStud w = new WindowStud();
            //w.ShowDialog();

        }

        private void buttonEdit_Click(object sender, RoutedEventArgs e)
        {
            // WindowStud w = new WindowStud();

            //w.ShowDialog();

        }

        private void Stud_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
