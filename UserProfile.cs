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
    public partial class UserProfile : Form
    {
        RepositorySQL repo = new RepositorySQL();
        public UserProfile()
        {
            InitializeComponent();
            ShowUserData();
        }
        public void ShowUserData()
        {
            repo.OpenConnection();
            string query = $"SELECT * FROM Users";
            SqlCommand command = new SqlCommand(query, repo.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            string login = reader["Login"].ToString();
            string email = reader["Email"].ToString();
            string phone = reader["PhoneNumber"].ToString();


            reader.Close();
            repo.CloseConnection();
            labelLogin.Text = login;
            labelEmail.Text = email;
            labelPhone.Text = phone;

        }


      
    }
}
