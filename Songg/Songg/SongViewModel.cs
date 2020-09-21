using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songg
{
    public class SongViewModel
    {
        Song _song;

        public Song Song
        {
            get
            {
                return _song;
            }
            set
            {
                _song = value;
            }
        }

        public string ArtistName
        {
            get { return Song.ArtistName; }
            set { Song.ArtistName = value; }
        }
    }
}
