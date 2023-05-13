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

namespace Task4Barinov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> user = new List<User>();
        public MainWindow()
        {
            InitializeComponent();

            user.Add(new User("Каримов", "27.04.2000", "23", "М"));
            user.Add(new User("Шишкин", "25.02.1998", "21", "M"));
            user.Add(new User("Кучукбаева", "18.02.1999", "20", "F"));
            user.Add(new User("Белов", "25.02.1997", "22", "M"));
            user.Add(new User("Хоробрых", "25.02.1996", "23", "M"));

            LoadUser(user);


        }
        public void LoadUser(List<User> _user)
        {
            userList.Items.Clear();
            for (int i = 0; i < _user.Count; i++)
            {
                userList.Items.Add(_user[i]);
            }
        }
        private void ActiveFilter(object sender, RoutedEventArgs e)
        {
            List<User> newUsers = new List<User>();
            newUsers = user;

            if (genderFilter.SelectedIndex == 0)
                newUsers = user.FindAll(x => x.gender == "M");
            else
                newUsers = user.FindAll(x => x.gender == "F");

            LoadUser(newUsers);
            newUsers = newUsers.FindAll(x => x.name.Contains(nameFilter.Text));

        }


        private void RemoveSelectedItem(object sender, RoutedEventArgs e)
        {
            bool noItemSelected = userList.SelectedIndex == -1;
            if (noItemSelected)
                return;

            userList.Items.RemoveAt(userList.SelectedIndex);
        }

    }
    
}
