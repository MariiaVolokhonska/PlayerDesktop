using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerDesktop.ViewModels;

namespace PlayerDesktop
{
    public partial class FavouriteSongs : Form
    {
        RepositorySQL repo = new RepositorySQL();
        private int _userID = UserProfileInformation.USER_ID;
        
        public FavouriteSongs()
        {
            InitializeComponent();
        }
        private void LoadSongs()
        {
            List<SongViewModel> listOfSongs = new List<SongViewModel>();
            repo.OpenConnection();
            string query = $"SELECT f.FavouriteSongId,s.SongID, s.Title, a.ArtistName, al.AlbumName, g.Genre,s.Duration,s.Location FROM Favourites as f INNER JOIN Songs as s ON s.SongID=f.SongId INNER JOIN Artists as a ON a.ArtistID=s.ArtistID INNER JOIN Albums as al ON s.AlbumID=al.AlbumID INNER JOIN Genres as g ON s.GenreID=g.GenreID WHERE f.UserId={_userID}";
            SqlCommand command = new SqlCommand(query, repo.getConnection());
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string songId = reader["SongID"].ToString();
                string songName = reader["Title"].ToString();
                string artistName = reader["ArtistName"].ToString();
                string albumName = reader["AlbumName"].ToString();
                string genre = reader["Genre"].ToString();
                string duration = reader["Duration"].ToString();

                string filePath = reader["Location"].ToString();
                listOfSongs.Add(new SongViewModel { SongId = int.Parse(songId), Title = songName, Artist = artistName, Album = albumName, Genre = genre, Duration = float.Parse(duration), Location = filePath });


            }
            reader.Close();
            foreach (var item in listOfSongs)
            {
                FavouritesControl songsControl = new FavouritesControl(item);
                flowLayoutPanel2.Controls.Add(songsControl);
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSongs();
        }

        private void songRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SongsList songs = new SongsList();
            this.Hide();
            songs.Show();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfile user = new UserProfile();
            this.Hide();
            user.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            UserProfileInformation.USER_ID = -1;
            this.Hide();
            home.Show();
        }
    }
}
