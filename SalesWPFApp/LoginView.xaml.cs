using BusinessObject.Object;
using DataAccess.Repository;
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

namespace SalesWPFApp
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IMemberRepository _memberRepository = new MemberRepositoy();


                string email = txtUsername.Text;
                string password = txtPassword.Password;


                Member loggedInMember = _memberRepository.Login(email, password);

                MainWindow homeWindow = new MainWindow();
                homeWindow.Show();
                Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Login failed: " + ex.Message);
            }

        }
    }
}
