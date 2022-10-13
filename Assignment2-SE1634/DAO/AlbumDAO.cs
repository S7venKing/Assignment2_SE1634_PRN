using Assignment2_SE1634.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_SE1634.DAO
{
    internal class AlbumDAO
    {
        public List<Album> LoadAllAlbum()
        {
            var list = new List<Album>();
            MusicStoreContext musicStore = new MusicStoreContext();
            list = musicStore.Albums.ToList();
            return list;
        }
        public List<Album> LoadPaginationAlbum(int page,int quantity, List<Album> listA)
        {
            var listPage = listA.Skip((page-1) * quantity).Take(quantity).ToList();
            return listPage;
        }

        public List<Album> LoadAlbumByGenre(int genreID)
        {
            var list = new List<Album>();
            list = LoadAllAlbum();
            var listPage = list.Where(p=>p.GenreId==genreID).ToList();
            return listPage;
        }
    }
}
