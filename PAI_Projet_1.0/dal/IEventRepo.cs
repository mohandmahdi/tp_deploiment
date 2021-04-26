using PAI_Projet_1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAI_Projet_1._0.dal
{
    public interface IEventRepo
    {
        List<Event> GetEvents(int id_site);

        void AddEvent(String title, int site_id);

        void AddNewEvent(String title,String desc, String image,int site_id);

        public List<Event> GetEventsById(int id);
    }
}
