using System;
using System.Collections.Generic;

#nullable disable

namespace TA_AspAngularProjDemo.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime? StartTime { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
    }
}
