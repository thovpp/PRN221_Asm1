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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            LoginView mainWindow = new LoginView();
            mainWindow.Show();
            Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                string content = radioButton.Content.ToString();
                List<object> data = GetDataForRadioButton(content);

                if (data.Any())
                {
                    DataGrid dataGrid = new DataGrid();
                    dataGrid.AutoGenerateColumns = true;
                    dataGrid.ItemTemplate = FindResource("DataGridTemplate") as DataTemplate;
                    dataGrid.ItemsSource = data;

                    // Clear existing tabs before adding a new one
                    mainTabControl.Items.Clear();

                    // Create a new TabItem and add the DataGrid to its content
                    TabItem tabItem = new TabItem();
                    tabItem.Header = content;
                    tabItem.Content = dataGrid;

                    // Add the TabItem to the TabControl
                    mainTabControl.Items.Add(tabItem);
                }
            }
        }
        private List<object> GetDataForRadioButton(string radioButtonContent)
        {
            IMemberRepository memberRepository = new MemberRepositoy();

            List<object> data = new List<object>();
            if (radioButtonContent == "Member management")
            {
                data.AddRange(memberRepository.GetMembers());
            }
            else if (radioButtonContent == "Product management")
            {
                // Retrieve data for Product management
            }
            // and so on...
            return data;
        }
    }
}
