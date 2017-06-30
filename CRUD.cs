using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using MySql.Data.MySqlClient;



namespace Advert
{
    public class CRUD
    {
        MySqlConnection Connection;
        string ConnectionString = "server = localhost; user id = root; persistsecurityinfo=True;database=advert;password=axioma123"; 
        CRUD()
        {
            Connection = new MySqlConnection();
            Connection.Open();
        }
        public List<AdInfo> LoadPersondFromDB()
        {
            List<AdInfo> list = new List<AdInfo>();
            using (Connection)
            {
                MySqlCommand command = new MySqlCommand()
                {
                    CommandText = @"SELECT Person.Name, Person.Surname, ad.Description, ad.PhoneNumber, ad.Price 
                        FROM [person] INNER JOIN [ad] ON Person.ID = ad.ID"
                };
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        string name = reader.GetString(0);
                        string surname = reader.GetString(1);
                        string description = reader.GetString(2);
                        string phone = reader.GetString(3);
                        int price = reader.GetInt32(4);
                        list.Add(new AdInfo(description, name, surname, phone, price));
                    }
                }
            }
            return list;
        }
    }
}
