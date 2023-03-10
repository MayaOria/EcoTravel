using ECOTRAVEL_COMMON.Repositories;
using ECOTRAVEL_DAL.Entities;
using ECOTRAVEL_DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_DAL.Services
{
    public class AdresseService : IAdresseRepository<Adresse, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(Localdb)\MSSQLLocalDB;Initial Catalog=EcoTravel;Integrated Security=True";
        public IEnumerable<Adresse> Get()
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idAdresse], [rue], [numero], [codePostal], [isoPays], [latitude], [longitude] 
                                            FROM [Adresse]";

                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToAdresse();
                        }
                    }

                }

            }
        }

        public Adresse Get(int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idAdresse], [rue], [numero], [codePostal], [isoPays], [latitude], [longitude] 
                                            FROM [Adresse]
                                            WHERE [idAdresse] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToAdresse();
                        }
                        return null;
                    }
                }
            }
        }

        public int Insert(Adresse entity)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Adresse]([rue], [numero], [codePostal], [isoPays], [latitude], [longitude])
                                            OUTPUT [inserted].[idAdresse]
                                            VALUES (@rue, @numero, @codePostal, @isoPays, @latitude, @longitude)";

                    command.Parameters.AddWithValue("rue", entity.Rue);
                    command.Parameters.AddWithValue("numero", entity.Numero);
                    command.Parameters.AddWithValue("codePostal", entity.CodePostal);
                    command.Parameters.AddWithValue("isoPays", entity.IsoPays);
                    command.Parameters.AddWithValue("latitude", entity.Latitude);
                    command.Parameters.AddWithValue("longitude", entity.Longitude);
                    connexion.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
