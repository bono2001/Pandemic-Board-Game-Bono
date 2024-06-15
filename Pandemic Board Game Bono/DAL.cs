using Pandemic_Board_Game_Bono.Pandemic_Board_Game_Bono;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Pandemic_Board_Game_Bono
{
    public class DAL
    {
        string connectionString = "Data Source=.;Initial Catalog=PandemicV2;Integrated Security=True";

        public List<Program.Player> ReadPlayersFromDatabase()
        {
            List<Program.Player> players = new List<Program.Player>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT PlayerId, Name, Description FROM Player", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int playerId = (int)reader["PlayerId"];
                            string name = reader["Name"].ToString();
                            string description = reader["Description"].ToString();
                            players.Add(new Program.Player(playerId, name, description));
                        }
                    }
                }
            }

            return players;
        }

        public void AddPlayerToDatabase(string name, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Player (Name, Description) VALUES (@Name, @Description)", connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdatePlayerInDatabase(int playerId, string name, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE Player SET Name = @Name, Description = @Description WHERE PlayerId = @PlayerId", connection))
                {
                    command.Parameters.AddWithValue("@PlayerId", playerId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void RemovePlayerFromDatabase(int playerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DELETE FROM Player WHERE PlayerId = @PlayerId", connection))
                {
                    command.Parameters.AddWithValue("@PlayerId", playerId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

