using Microsoft.Data.SqlClient;
using PrimerWebApi.Common.Users;

namespace PrimerWebApi.DAL
{
    public class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            string connectionString = "Data Source=DESKTOP-M2QA1DM\\SQLEXPRESS;Initial Catalog=walbase;User ID=User;Password=;Encrypt=False;Trusted_Connection=True";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO Users (Firstname,Lastname) VALUES('{user.Firstname}','{user.Lastname}')";
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);

                command.ExecuteNonQuery();
            }
        }

        public List<User> Get()
        {
            List<User> users = new List<User>();
            string connectionString = "Data Source=DESKTOP-M2QA1DM\\SQLEXPRESS;Initial Catalog=walbase;User ID=User;Password=;Encrypt=False;Trusted_Connection=True";

            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlExpression = $"SELECT * FROM Users";
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object firstName = reader.GetValue(1);
                        object lastName = reader.GetValue(2);
                        users.Add(new User
                        {
                            Firstname = firstName.ToString(),
                            Lastname = lastName.ToString()
                        });
                    }
                }
            }
            return users;
        }
    }
}
