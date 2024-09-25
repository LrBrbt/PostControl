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

namespace PostControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Autorization autorization = new();
            autorization.ShowDialog();
            if(autorization.isLoginSuccessful == false)
            {
                this.Close();
            }
            string role = autorization.user.GetRole();
            accountNameTxt.Text = role;
       
        }

        private void menuBtn_Click(object sender, RoutedEventArgs e)
        {
            ProgramMenu.Visibility = Visibility.Visible;
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            ProgramMenu.Visibility = Visibility.Hidden; 
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void allLogsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void anotherTypeLogsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            RequestEditOrDelete newRequest = new RequestEditOrDelete();
            newRequest.ShowDialog();
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void ChangeUserBtn_Click(object sender, RoutedEventArgs e)
        {
            Autorization autorization = new Autorization();
            autorization.ShowDialog();
        }
    }
}