using System.Windows;
using WpfApp1.View;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = UserViewModel.Users;                      
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            CreateUserView createUser = new CreateUserView();
            createUser.ShowDialog();            
        }
    }
}
