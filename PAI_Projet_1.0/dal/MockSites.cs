using Microsoft.Extensions.Configuration;
using PAI_Projet_1._0.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PAI_Projet_1._0.dal
{
    public class MockSites : ISiteRepo
    {
        private readonly IConfiguration configuration;
        public static List<Sites> list = new List<Sites>();

        public MockSites(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public MockSites()
        {

        }
        public List<Sites> GetSites()
        {
            Dictionary<string, string> column;
            string connectionstring = configuration.GetConnectionString("DefaultConnectionStrings");
            SqlConnection sqlConnection = new SqlConnection(connectionstring);
            sqlConnection.Open();
            SqlCommand commande = new SqlCommand("select * from Sites", sqlConnection);
            //int num = (int)commande.ExecuteScalar();
            SqlDataReader reader = commande.ExecuteReader();
            list.Clear();

            while (reader.Read())
            {
               
                column = new Dictionary<string, string>();
                column["id_site"] = reader["id_site"].ToString();
                column["nom"] = reader["nom"].ToString();
                column["adresse"] = reader["adresse"].ToString();
                
                list.Add(new Sites(column["nom"], column["adresse"],Convert.ToInt32(reader["id_site"])  ));
            }


            sqlConnection.Close();
            return list;
        }
    }
}
