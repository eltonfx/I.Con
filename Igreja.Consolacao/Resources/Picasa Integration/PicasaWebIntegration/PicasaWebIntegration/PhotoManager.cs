using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
using Google.GData.Photos;

namespace PicasaWebIntegration
{
    public class PhotoManager
    {
        private static Albums m_albums;
        private static PicasaService m_picasaService;

        public static PicasaService PicasaService
        {
            get
            {
                if (m_picasaService == null)
                    m_picasaService = new PicasaService("PhotoBrowser");
                return m_picasaService;
            }
        }

        public static bool TryGetAlbum(string id, out Album album)
        {
            if (m_albums == null)
                InitializeAlbums();
            return m_albums.TryGetItem(id, out album);
        }

        public static Albums GetAlbums()
        {
            if (m_albums == null)
                InitializeAlbums();
            return m_albums;
        }

        public static void Reset()
        {
            InitializeAlbums();
        }

        private static void InitializeAlbums()
        {
            m_albums = new Albums();

            AlbumQuery albumQuery = new AlbumQuery();
            albumQuery.Uri = new Uri(PicasaQuery.CreatePicasaUri(ConfigurationManager.AppSettings.Get("PicasaWebUserId")));
            albumQuery.Access = PicasaQuery.AccessLevel.AccessPublic;

            PicasaFeed feed = PicasaService.Query(albumQuery);

            if (feed != null && feed.Entries.Count > 0)
            {
                foreach (PicasaEntry entry in feed.Entries)
                {
                    Album album = new Album();
                    album.Title = entry.Title.Text;
                    album.Summary = entry.Summary.Text.Replace("\r\n", "<br/>");
                    album.FeedUri = entry.FeedUri;
                    album.ThumbnailUrl = entry.Media.Thumbnails[0].Attributes["url"].ToString();
                    album.NumberOfPhotos = ((GPhotoNumPhotos)entry.ExtensionElements[5]).IntegerValue;

                    m_albums.Add(album);
                }
            }
        }
    }
}