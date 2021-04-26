using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PAI_Projet_1._0.Models
{
    public class User
    {

        public int ID { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adress { get; set; }
        public string email { get; set; }
        public string numero { get; set; }
        public Boolean id_sexe { get; set; }
        public Boolean is_admin { get; set; }




        public User(string nom, string prenom, string adress, string email, string numero, Boolean is_sexe,Boolean is_admin)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adress = adress;
            this.email = email;
            this.numero = numero;
            this.is_admin = is_admin;
            this.id_sexe = id_sexe;
        }
    

    }
}
