using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace EKZ
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);

        }

        bool isValidPhone(string phone)
        {
            if (phone.StartsWith("79") && phone.Length == 11)
                return true;
            return false;
        }

        string checkFields()
        {
            if (inputLogin.Text.Length == 0)
                return "Логин не введен";

            if (inputLogin.Text.Length < 5)
                return "Логин слишком короткий";

            if (inputSurname.Text.Length == 0)
                return "Фамилия не введена";

            if (inputName.Text.Length == 0)
                return "Имя не введено";

            if (inputPatronymic.Text.Length == 0)
                return "Отчество не введено";

            if (inputEmail.Text.Length == 0)
                return "Почта не введена";

            if (!IsValidEmail(inputEmail.Text))
                return "Почта введена неверно";

            if (inputPhone.Text.Length == 0)
                return "Телефон не введен";

            if (!isValidPhone(inputPhone.Text))
                return "Телефон введен неверно";

            if (inputPassword.Text.Length == 0)
                return "Пароль не введен";

            if (inputPassword.Text.Length < 8 || !Regex.IsMatch(inputPassword.Text, @"[A-Z]") || !Regex.IsMatch(inputPassword.Text, @"[a-z]") || !Regex.IsMatch(inputPassword.Text, @"[0-9]"))
                return "Пароль слишком простой\nПароль должен содеражать хотя бы одну заглавную букву, строчную букву и цифру";

            if (inputPassword.Text != inputPassword2.Text)
                return "Пароли не совпадают";

            return "";
        }
        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            string check = checkFields();
            if (check != "")
            {
                MessageBox.Show("Ошибка регистрации:\n" + check);
            }
            else
            {
                MessageBox.Show("Успешная регистрация!");
            }
        }

        private void inputLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void inputSurname_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
