using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDesktop.Repository
{
    public interface IQueries
    {
         DataTable ShowListOfFavourites();
        void ShowListOfAllSongs();
        void RemoveSongFromFavourites();
        void AddSongToFavourites();
        void GetSongById(int id);


    }
}
