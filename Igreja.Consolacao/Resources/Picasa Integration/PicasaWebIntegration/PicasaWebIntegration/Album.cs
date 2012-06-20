using System.Collections.Generic;
using System;

namespace PicasaWebIntegration
{
    public class Album
    {
        private string m_feedUri;
        private string m_title;
        private string m_summary;
        private string m_thumbnailUrl;
        private int m_count;

        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        public string FeedUri
        {
            get { return m_feedUri; }
            set { m_feedUri = value; }
        }

        public string ThumbnailUrl
        {
            get { return m_thumbnailUrl; }
            set { m_thumbnailUrl = value; }
        }

        public string Summary
        {
            get
            {
                return m_summary;
            }
            set
            {
                m_summary = value;
            }
        }

        public int NumberOfPhotos
        {
            get
            {
                return m_count;
            }
            set
            {
                m_count = value;
            }
        }
    }
}