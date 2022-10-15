﻿using Assignment2_SE1634.Models;
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
            MusicStoreContext musicStore = new MusicStoreContext();
            List<Album> list = new List<Album>();
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

        public List<Album> LoadAlbumByTitle(string search)
        {
            var list = new List<Album>();
            list = LoadAllAlbum();
            var listPage = list.Where(p => p.Title.Contains(search)).ToList();
            return listPage;
        }

        public Album LoadAlbumByID(int id)
        {
            var list = new List<Album>();
            list = LoadAllAlbum();
            Album albums = list.Where(p => p.AlbumId == id).FirstOrDefault();

            return albums;
        }

        public void Delete(int id)
        {
            var list = new List<Album>();
            list = LoadAllAlbum();
            Album albums = LoadAlbumByID(id);
            MusicStoreContext musicStore = new MusicStoreContext();
            try
            {   
                musicStore.Remove(albums);
                musicStore.SaveChanges();
                MessageBox.Show("That album is deleted");
            }
            catch
            {
                MessageBox.Show("Album is ordered");
            }


        }


    }
}
