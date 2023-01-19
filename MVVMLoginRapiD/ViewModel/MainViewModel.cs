using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMLoginRapiD.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {

        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IS69AVIT\\SQLEXPRESS;Initial Catalog=Rapid;Integrated Security=True;");

        [ObservableProperty]
        public string userName = "username";

        [ObservableProperty]
        public string passWord = "password";

        [ICommand]
        void Login()
        {
            MessageBox.Show($"{userName} logged in!");



            try
            {


                string querry = $"SELECT * FROM loginrapid WHERE username = {userName} AND password = {passWord}";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {


                    UserView form2 = new UserView();
                    form2.Show();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error");
                }
            }

            catch
            {
                MessageBox.Show("Error");
            }

            finally
            {
                conn.Close();
            }
        }


    }
}

