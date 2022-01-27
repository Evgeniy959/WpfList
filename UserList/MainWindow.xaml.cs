using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UserList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static ObservableCollection<User> userList;
        private static int? selectedIdex;
        public MainWindow()
        {
            InitializeComponent();
            userList = new ObservableCollection<User>();
            usersGrid.ItemsSource = userList;
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            CreateUser form2 = new CreateUser();
            form2.Show();
        }

        public static void AddToList(User user)
        {
            userList.Add(user);
        }

        private void usersGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedIdex = (sender as DataGrid).SelectedIndex;
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (selectedIdex != null && userList.Count != 0)
            {
                userList.RemoveAt(selectedIdex.Value);
            }
        }
    }
    public class User
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Password { get; set; }
    }
}
