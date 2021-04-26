using Microsoft.Extensions.Configuration;
using PAI_Projet_1._0.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PAI_Projet_1._0.dal
{
    public class MockEvent : IEventRepo
    {

        private readonly IConfiguration configuration;
        public static List<Event> list = new List<Event>();
        public MockEvent(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public MockEvent()
        {

        }
        public List<Event> GetEvents(int id_site)
        {
            
            Dictionary<string, string> column;
            string connectionstring = configuration.GetConnectionString("DefaultConnectionStrings");
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            SqlCommand commande = new SqlCommand("select * from Event where site_id = @id_site",sqlConnection);
            commande.Parameters.AddWithValue("@id_site", id_site);
            //int num = (int)commande.ExecuteScalar();
            SqlDataReader reader = commande.ExecuteReader();
            list.Clear();

            while (reader.Read())
            {
                column = new Dictionary<string, string>();
                column["id"] = reader["id"].ToString();
                column["title"] = reader["title"].ToString();
                column["date"] = reader["date"].ToString();
                column["description"] = reader["description"].ToString();
                column["image"] = reader["image"].ToString();
                column["id_site"] = reader["site_id"].ToString();
                list.Add(new Event(column["date"], column["description"], column["title"], column["image"],id_site));
            }


            sqlConnection.Close();
            return list;
        }

        public void AddEvent(String titre, int site_id)
        {
            string connectionstring = configuration.GetConnectionString("DefaultConnectionStrings");
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            SqlCommand commande = new SqlCommand("insert into Event(date,description,title,userId,site_id) values (@date, @description,@title,1,@site_id)", sqlConnection);
            commande.Parameters.AddWithValue("@date", DateTime.Now);
            commande.Parameters.AddWithValue("@description", titre);
            commande.Parameters.AddWithValue("@title", titre);
            commande.Parameters.AddWithValue("@site_id", site_id);
            commande.ExecuteNonQuery();
        }

        public void AddNewEvent(string title, string desc, String image,int site_id )
        {
            string connectionstring = configuration.GetConnectionString("DefaultConnectionStrings");
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            SqlCommand commande = new SqlCommand("insert into Event values (@date, @description,@title,@image,1,@site_id)", sqlConnection);
            commande.Parameters.AddWithValue("@date", DateTime.Now);
            commande.Parameters.AddWithValue("@description", desc);
            commande.Parameters.AddWithValue("@title", title);
            commande.Parameters.AddWithValue("@image", image);
            commande.Parameters.AddWithValue("@site_id", site_id);
            commande.ExecuteNonQuery();
        }


        public List<Event> GetEventsById(int id)
        {
            Dictionary<string, string> column;
            string connectionstring = configuration.GetConnectionString("DefaultConnectionStrings");
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            SqlCommand commande = new SqlCommand("select * from Event where id = @id", sqlConnection);
            commande.Parameters.AddWithValue("@id",id);
            //int num = (int)commande.ExecuteScalar();
            SqlDataReader reader = commande.ExecuteReader();
            list.Clear();

            while (reader.Read())
            {
                column = new Dictionary<string, string>();

                column["title"] = reader["title"].ToString();
                column["date"] = reader["date"].ToString();
                column["description"] = reader["description"].ToString();
                column["image"] = reader["image"].ToString();
              
                list.Add(new Event(column["date"], column["description"], column["title"], column["image"],id));
            }


            sqlConnection.Close();
            return list;
        }
    }
}
