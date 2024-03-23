using Microsoft.Data.SqlClient;
using Npgsql;
using PrimerWebApi.Common.Users;

namespace PrimerWebApi.DAL
{
    public class UserRepository : IUserRepository
    {
        private const string connectionString = "Host=localhost;Port=5432;Database=wallet;Username=postgres;Password=1";

        public void Add(User user)
        {
            // Создание подключения
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string sqlExpression = $"INSERT INTO public.user(first_name,second_name, middle_name, number_phone, age) VALUES('{user.FirstName}','{user.LastName}','{user.MiddleName}','{user.NumberPhone}','{user.Age}')";
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand(sqlExpression, connection);

                command.ExecuteNonQuery();
            }
        }

        public List<User> Get()
        {
            List<User> users = new List<User>();

            // Создание подключения
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string sqlExpression = $"SELECT * FROM public.user";
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(sqlExpression, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object firstName = reader.GetValue(1);
                        object lastName = reader.GetValue(2);
                        object middleName= reader.GetValue(3);
                        object numberPhone= reader.GetValue(4);
                        object age = reader.GetValue(5);
                        //object sex= reader.GetValue(6);

                        int.TryParse(id.ToString(), out int IdInt);
                        int.TryParse(age.ToString(), out int ageInt);
                        users.Add(new User
                        {
                            Id = IdInt,
                            FirstName = firstName.ToString(),
                            LastName = lastName.ToString(),
                            MiddleName = middleName.ToString(),
                            NumberPhone = numberPhone.ToString(),
                            Age= ageInt,
                            
                        });
                    }
                }
            }
            return users;
        }
    }
}
