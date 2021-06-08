using System;
using System.Collections.Generic;

#nullable disable

namespace TA_AspAngularProjDemo.Models
{
    public partial class Favorite
    {
        public int FavoriteId { get; set; }
        public int EventId { get; set; }
        public string UserName { get; set; }
    }
}
