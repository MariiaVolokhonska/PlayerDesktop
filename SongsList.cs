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
using PlayerDesktop.ViewModels;

namespace PlayerDesktop
{
    public partial class SongsList : Form
    {
        RepositorySQL repo = new RepositorySQL();
        public SongsList()
        {
            InitializeComponent();
        }

        
        private void LoadSongs()
        {
            List<SongViewModel> listOfSongs = new List<SongViewModel>();
            repo.OpenConnection();
            string query = "SELECT s.SongID, s.Title, a.ArtistName, al.AlbumName, g.Genre,s.Duration,s.Location FROM Songs as s INNER JOIN Artists as a ON a.ArtistID=s.ArtistID INNER JOIN Albums as al ON s.AlbumID=al.AlbumID INNER JOIN Genres as g ON s.GenreID=g.GenreID";
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
                listOfSongs.Add(new SongViewModel { SongId=int.Parse(songId), Title = songName, Artist= artistName, Album = albumName, Genre=genre, Duration=float.Parse(duration), Location = filePath });
               

                /*
                Button playButton = new Button();
                 playButton.Text = "Play";
                         playButton.Tag = filePath; // Хранение пути к файлу в свойстве Tag кнопки
                         playButton.Click += PlayButton_Click; // Обработчик нажатия для проигрывания песни

                         Button addToPlaylistButton = new Button();
                 addToPlaylistButton.Text = "Add to Playlist";
                         addToPlaylistButton.Tag = songName; // Или может быть songId или что-то еще
                         addToPlaylistButton.Click += AddToPlaylistButton_Click; // Обработчик нажатия для добавления песни в плейлист

                         // Создание панели для размещения кнопок в строку*/


                // listBox1.Items.Clear();


            }
            reader.Close();
            foreach(var item in listOfSongs)
            {
                SongsControl songsControl = new SongsControl(item);
                flowLayoutPanel1.Controls.Add(songsControl);
            }
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            LoadSongs();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void favouritesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FavouriteSongs favourites = new FavouriteSongs();
            this.Hide();
            favourites.Show();
        }

        private void favouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            this.Hide();
            profile.Show();
        }

        private void SongsList_Load(object sender, EventArgs e)
        {

        }
    }
}
