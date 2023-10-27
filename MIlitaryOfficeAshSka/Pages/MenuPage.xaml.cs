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
using MIlitaryOfficeAshSka.Pages;
using MIlitaryOfficeAshSka.ClassHelper;
using MIlitaryOfficeAshSka.Windows;

namespace MIlitaryOfficeAshSka.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void create_btn_Click(object sender, RoutedEventArgs e)
        {
            Navigate.mainFrame.Navigate(new CreatePlatoon());
        }

        private void look_btn_Click(object sender, RoutedEventArgs e)
        {
            Navigate.mainFrame.Navigate(new ViewPlatoon());
        }

        private void add_btn_Click(Object sender, RoutedEventArgs e)
        {
           AddMilitary addMilitary = new AddMilitary();
            addMilitary.Show();
            
        }
    }
}
