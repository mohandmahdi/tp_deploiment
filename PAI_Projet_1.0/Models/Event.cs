using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAI_Projet_1._0.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string date { get; set; }
        public string description { get; set; }
        public string  title { get; set; }
        public String image { get; set; }
        public int userid { get; set; }
        public int siteid { get; set; }
        public Event(string date, String description, String title, String image, int siteid)
        {
            this.date = date;
            this.description = description;
            this.title = title;
            this.image = image;
            this.siteid = siteid;
        }
        public Event(string date, String description, String title, int siteid)
        {
            this.date = date;
            this.description = description;
            this.title = title;
            this.siteid = siteid;
        }
        public String GetTitle()
        {
            return this.title;
        }

    }
}
