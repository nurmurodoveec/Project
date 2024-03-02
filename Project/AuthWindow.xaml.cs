using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        private void Button_Auth_Click (object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin1.Text.Trim();
            string pass = passBox1.Password.Trim();
            if (login.Length < 5)
            {
                textBoxLogin1.ToolTip = "This field was entered incorrectly";
                textBoxLogin1.Background = Brushes.LightPink;
            }
            else if (pass.Length < 5)
            {
                passBox1.ToolTip = "This field was entered incorrectly";
                passBox1.Background = Brushes.LightPink;
            }
            else
            {
                textBoxLogin1.ToolTip = "";
                textBoxLogin1.Background = Brushes.Transparent;
                passBox1.ToolTip = "";
                passBox1.Background = Brushes.Transparent;
                Users authUser = null;
                using(ApplicationContext context= new ApplicationContext())
                {
                    authUser=db.Users.Where(x => x.Login == login&& x.Password == pass).FirstOrDefault();
                }
                MessageBox.Show("Everything is Good!");
            }
        }
    }
}
