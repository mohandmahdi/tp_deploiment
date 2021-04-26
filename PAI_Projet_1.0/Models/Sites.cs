using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAI_Projet_1._0.Models
{
    public class Sites
    {
        public int ID { get; set; }
        public string name { get; set; }

        public string adresse { get; set; }

        public Sites( String name, String adresse, int ID)
        {
            this.ID = ID;
            this.name = name;
            this.adresse = adresse;
        }

        public Sites(String name, String adresse)
        {

            this.name = name;
            this.adresse = adresse;
        }
        public int getID()
        {
            return this.ID;
        }
    }

}
