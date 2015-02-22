using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStoreMVC.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }

        public virtual List<Review> Reviews { get; set; }
    }
}