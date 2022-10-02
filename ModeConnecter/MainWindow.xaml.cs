using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Data.SqlClient;

namespace ModeConnecter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string connection = ConfigurationManager.ConnectionStrings["NorthwindEntities"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                string query = "select cu.ContactName from Customers as cu";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader sqlReader = command.ExecuteReader();

                while(sqlReader.Read())
                {
                    lstBox.Items.Add(sqlReader.GetString(0));   
                }


            }
        }
    }
}
