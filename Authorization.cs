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
    public partial class Authorization : Form
    {
        public string loginAut;
        RepositorySQL database = new RepositorySQL();
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public string getAuthorizationLogin()
        {
            return this.loginAut;
        }

        public string searchForLog()
        {
            this.loginAut = loginBox.Text;
            var passwordAut = passwordBox.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string authorizationQuery = $"select UserId, Login, Password from Users where Login='{this.loginAut}' and Password='{passwordAut}'";
            SqlCommand command = new SqlCommand(authorizationQuery, database.getConnection());
          
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                database.OpenConnection();
                SqlDataReader reader =command.ExecuteReader();//there we got ID we wanted from database and put it in 'reader' variable

                //while ()
                //{
                reader.Read();
                UserProfileInformation.USER_ID= int.Parse(reader["UserID"].ToString());//and here we converted that id to string
                                                             

                reader.Close();
                database.CloseConnection();
                MessageBox.Show("Success!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SongsList songs = new SongsList();
               
                this.Hide();
                songs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return this.loginAut;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            searchForLog();

        }


    }
}
