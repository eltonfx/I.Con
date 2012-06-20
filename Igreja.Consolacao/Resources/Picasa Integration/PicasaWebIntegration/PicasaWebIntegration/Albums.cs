using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Google.GData.Photos;
using System.Collections.ObjectModel;

namespace PicasaWebIntegration
{
    public class Albums: KeyedCollection<string, Album>
    {
        protected override string GetKeyForItem(Album item)
        {
            return item.FeedUri;
        }

        public bool TryGetItem(string feedUri, out Album matchingAlbum)
        {
            matchingAlbum = null;
            if (Dictionary != null && Dictionary.TryGetValue(feedUri, out matchingAlbum))
                return true;
            else
                return false;
        }
    }
}
