using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDesktop.Repository
{
    public class Queries:IQueries
    {
        RepositorySQL database = new RepositorySQL();
       

        DataTable IQueries.ShowListOfFavourites()
        {
            string showFavouritesQuery = $"select * from Favourites";
            database.OpenConnection();// we need to open a close connection with database
            SqlDataAdapter adapter = new SqlDataAdapter();//we use adapter to connect DataTable or DataSet and sql data
            DataTable table = new DataTable();//create local table in our programm where we put sql data 
            SqlCommand command = new SqlCommand(showFavouritesQuery, database.getConnection());
            adapter.SelectCommand = command;//here we show adapter a command that is executed 
            database.CloseConnection();

            adapter.Fill(table);// we fill table with sql data
            return table; //we need to r
        }

        void IQueries.ShowListOfAllSongs()
        {
            throw new NotImplementedException();
        }

        void IQueries.RemoveSongFromFavourites()
        {
            throw new NotImplementedException();
        }

        void IQueries.AddSongToFavourites()
        {
            throw new NotImplementedException();
        }

        void IQueries.GetSongById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
