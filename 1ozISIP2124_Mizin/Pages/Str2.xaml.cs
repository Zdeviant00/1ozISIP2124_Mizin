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

namespace _1ozISIP2124_Mizin.Pages
{
    /// <summary>
    /// Логика взаимодействия для Str2.xaml
    /// </summary>
    public partial class Str2 : Page
    {
        public Str2()
        {
            InitializeComponent();
        }

        private void BtnCncl_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Str1());
        }
    }
}
