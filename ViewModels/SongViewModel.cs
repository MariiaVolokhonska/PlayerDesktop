using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDesktop.ViewModels
{
    public class SongViewModel
    {
        public int SongId { get; set; }
        public string Title{ get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public float Duration { get; set; }
        public string Location { get; set; }
        public override string ToString()
        {
            return $"{Title} {Artist} {Album} {Genre} {Duration} ";
        }
    }
}
