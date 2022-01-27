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

namespace UserList
{
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        public CreateUser()
        {
            InitializeComponent();
        }
        private void Button_Add(object sender, RoutedEventArgs e)
        {

            if (!Int32.TryParse(TextBoxPassword.Text, out int password)) { return; }

            User newUser = new User
            {
                FirstName = TextBoxFirstName.Text,
                Lastname = TextBoxLastName.Text,
                Password = password
            };
            MainWindow.AddToList(newUser);
        }
    }
}
