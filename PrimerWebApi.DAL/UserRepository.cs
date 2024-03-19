using Microsoft.Data.SqlClient;
using PrimerWebApi.Common.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerWebApi.DAL
{
    public class UserRepository:IUserRepository
    {
        public void Add(User user)
        {
            string connectionString = "Data Source=DESKTOP-M2QA1DM\\SQLEXPRESS;Initial Catalog=walbase;User ID=User;Password=;Encrypt=False;Trusted_Connection=True";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO Users (name,lastname) VALUES({user.name},{user.lastname})";
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);

                command.ExecuteNonQuery();
            }
        }


    }
}
