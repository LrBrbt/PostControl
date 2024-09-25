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

namespace PostControl
{
    /// <summary>
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }
        public User user;
        public bool isLoginSuccessful;
        int logiAttempts = 0;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if(loginTxt.Text.Contains("secretar") && PasswordTxt.Password == "123")
            {
                isLoginSuccessful = true;
                user = new User();
                user.SetLogin("secretar");
                user.ChangePassword("123");
                user.SetRole("секретарь");
                this.Close();

            }
            else
            {
                MessageBox.Show("Неверный пароль!");
                logiAttempts += 1;
                if (logiAttempts == 5)
                {
                    isLoginSuccessful = false;
                    this.Close();
                }
            }
        }
    }
}
