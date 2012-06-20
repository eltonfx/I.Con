using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace PicasaWebIntegration
{
    public partial class SlideShow : System.Web.UI.Page
    {
        Album m_selectedAlbum;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Get("albumId") != null)
            {
                string albumId = Request.QueryString["albumId"];
                if (PhotoManager.TryGetAlbum(albumId, out m_selectedAlbum))
                    this.Title = m_selectedAlbum.Title;
            }
        }

        protected string GetAlbumFeedUri()
        {
            if (m_selectedAlbum != null)
                return m_selectedAlbum.FeedUri;
            else
                return "";
        }
    }
}