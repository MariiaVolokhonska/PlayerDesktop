using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using PlayerDesktop.ViewModels;

namespace PlayerDesktop
{
    public partial class FavouritesControl : UserControl
    {
        public FavouritesControl()
        {
            InitializeComponent();
        }
        RepositorySQL repo = new RepositorySQL();
        private bool isPaused = false;
        private SongViewModel _songViewModel;
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private string _location;
        private int _songId;
        private int _userId = UserProfileInformation.USER_ID;
        public FavouritesControl(SongViewModel songViewModel)
        {
            InitializeComponent();
            _songViewModel = songViewModel;
            label1.Text = songViewModel.ToString();
            button1.Text = "►";
            button2.Text = "❚❚";
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            _location = songViewModel.Location;
            _songId = songViewModel.SongId;
        }
        private void PlayMp3FilePlay(string filePath)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;

            }

           

            audioFileReader = new AudioFileReader(filePath);
            waveOut = new WaveOutEvent();
            waveOut.Init(audioFileReader);
            waveOut.Play();
            isPaused = false;
        }
        private void StopMp3File()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                audioFileReader.Position = 0;
                isPaused = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayMp3FilePlay(_location);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopMp3File();
        }
    }
}
