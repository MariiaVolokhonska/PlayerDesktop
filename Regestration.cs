using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerDesktop
{
    public partial class Regestration : Form
    {
        
        RepositorySQL repository = new RepositorySQL();
        public Regestration()
        {
            InitializeComponent();
        }

      private void signUp()
        {
            var login = loginRegistrationBox.Text;
            var email =emailBox.Text;
            var phone = phoneNumberBox.Text;
            var password = passwordRegistrationBox.Text;
            var repeatPassword = repeatedPasswordBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();

            string registrQuery = $"INSERT INTO Users(Login, Password, Email,PhoneNumber) VALUES ('{login}','{password}','{email}','{phone}')";
            /*we need getIDQuery to get the last added id (id that was created rigth after created new user) to show user his new login*/
           
            SqlCommand command = new SqlCommand(registrQuery, repository.getConnection());
            if (password.Trim() == repeatPassword.Trim())
            {
               repository.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                   
                    Authorization authorizationPage = new Authorization();
                    this.Hide();
                    authorizationPage.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Account wasn't created");
                }
                repository.CloseConnection();

            }
            else
            {
                MessageBox.Show("Password is incorrect");
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signUp();
        }
    }
}
