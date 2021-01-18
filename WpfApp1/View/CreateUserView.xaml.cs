using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using WpfApp1.Model;
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for CreateUserView.xaml
    /// </summary>
    public partial class CreateUserView : Window
    {
        private UserViewModel _user = new UserViewModel();
        public CreateUserView()
        {
            InitializeComponent();
            this.DataContext = _user;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(tbName.Text, tbEmail.Text, tbPhone.Text, (Gender)cbGender.SelectedItem);
            UserViewModel.Users.Add(user);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cbGender.ItemsSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
        }

        private void tbPhone_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
