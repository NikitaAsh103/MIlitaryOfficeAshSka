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

namespace MIlitaryOfficeAshSka.Windows
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

       
        
        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void TbLog_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbLog.Text == "Введите Логин")
            {
                TbLog.Text = "";
            }    
        }

      

        private void TbPass_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbPass.Text== "Введите пароль")
            {
                TbPass.Text = "";
            }    
        }
    }
}
