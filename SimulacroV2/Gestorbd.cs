using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace SimulacroV2
{
    internal class Gestorbd
    {

        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        public Gestorbd()
        {
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "bibliotech";
        }
        public void InsertarLibro(Libro libro)
        {
            using (MySqlConnection connection = new MySqlConnection(builder.ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO libros (titulo, autor, anyoPublicacion, disponible) VALUES (@titulo, @autor, @anyoPublicacion, @disponible)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@titulo", libro.ToString());
                command.Parameters.AddWithValue("@autor", libro.ToString());
                command.Parameters.AddWithValue("@anyoPublicacion", libro.ToString());
                command.Parameters.AddWithValue("@disponible", libro.ToString());
                command.ExecuteNonQuery();
            }

        }
        public void MostrarLibros()
        {
            using (MySqlConnection connection = new MySqlConnection(builder.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM libros";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]}, Título: {reader["titulo"]}, Autor: {reader["autor"]}, Año de Publicación: {reader["anyoPublicacion"]}, Disponible: {reader["disponible"]}");
                }
            }
        }
    }
}
