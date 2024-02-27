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

namespace Project
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

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login=textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass2 = passBox2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if(login.Length< 5)
            {
                textBoxLogin.ToolTip = "This field was entered incorrectly";
                textBoxLogin.Background = Brushes.LightPink;
            }
            else if (pass.Length< 5)
            {
                passBox.ToolTip = "This field was entered incorrectly";
                passBox.Background = Brushes.LightPink;
            }
            else if (pass!=pass2)
            {
                passBox2.ToolTip = "This field was entered incorrectly";
                passBox2.Background = Brushes.LightPink;
            }
            else if (email.Length< 5||!email.Contains("@")||!email.Contains("."))
            {
                passBox.ToolTip = "This field was entered incorrectly";
                passBox.Background = Brushes.LightPink;
            }

            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox2.ToolTip = "";
                passBox2.Background= Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background= Brushes.Transparent;

                MessageBox.Show("Everything is Good!");
            }

        }
    }
}