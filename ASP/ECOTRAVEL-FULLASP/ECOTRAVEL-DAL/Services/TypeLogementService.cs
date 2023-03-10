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
    public class TypeLogementService : ITypeLogementRepository<TypeLogement, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(Localdb)\MSSQLLocalDB;Initial Catalog=EcoTravel;Integrated Security=True";

        public IEnumerable<TypeLogement> Get()
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = "SELECT [idTypeLogement], [nom] FROM [TypeLogement]";

                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToTypeLogement();
                        }
                    }

                }

            }
        }

        public TypeLogement Get(int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idTypeLogement], [nom]
                                            FROM [TypeLogement]
                                            WHERE [idTypeLogement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToTypeLogement();
                        }
                        return null;
                    }
                }
            }
        }

        public int Insert(TypeLogement entity)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [TypeLogement]([nom])
                                            OUTPUT [inserted].[idTypeLogement]
                                            VALUES (@nom)";

                    command.Parameters.AddWithValue("nom", entity.Nom);
                    connexion.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
