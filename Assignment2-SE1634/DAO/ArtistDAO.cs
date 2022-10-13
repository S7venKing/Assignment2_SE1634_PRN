using Assignment2_SE1634.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SE1634.DAO
{
    internal class ArtistDAO
    {
        public Artist GetArtistByID(int Id)
        {
            Artist artist = new Artist();
            MusicStoreContext musicStoreContext = new MusicStoreContext();
            artist = musicStoreContext.Artists.ToList().Where(p => p.ArtistId == Id).FirstOrDefault();
            return artist;
        }
    }
}
