using ECOTRAVEL_COMMON.Repositories;
using ECOTRAVEL_DAL.Entities;
using ECOTRAVEL_DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOTRAVEL_DAL.Services
{
    public class ProprietaireService : IProprietaireRepository<Proprietaire, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(Localdb)\MSSQLLocalDB;Initial Catalog=EcoTravel;Integrated Security=True";
        public int? CheckLogin(string email, string password)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    //Creer une procedure stockée SP_ProprietaireCheckLogin
                    command.CommandText = "SP_ProprietaireCheckLogin";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("password", password);
                    connexion.Open();
                    object result = command.ExecuteScalar();
                    return (result is DBNull) ? null : (int?)result;
                }
            }
        }

        public Proprietaire Get(int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idClient], [nom], [prenom], [email], [isoPays], [telephone], [password]
                                            FROM [Proprietaire]
                                            WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToProprietaire();
                        }
                        return null;
                    }
                }
            }
        }

        public int Insert(Proprietaire entity)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    //Créer SP_ProprietaireAdd
                    command.CommandText = "SP_ClientAdd";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("nom", entity.Nom);
                    command.Parameters.AddWithValue("prenom", entity.Prenom);
                    command.Parameters.AddWithValue("email", entity.Email);
                    command.Parameters.AddWithValue("isoPays", entity.IsoPays);
                    command.Parameters.AddWithValue("telephone", entity.Telephone);
                    command.Parameters.AddWithValue("password", entity.Password);

                    connexion.Open();
                    return (int)command.ExecuteScalar();

                }
            }
        }

        public bool Update(Proprietaire entity, int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Proprietaire]
                                            SET [nom] = @nom
                                                [prenom] = @prenom
                                                [email] = @email
                                                [isoPays] = @isoPays
                                                [telephone] = @telephone
                                            WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("nom", entity.Nom);
                    command.Parameters.AddWithValue("prenom", entity.Prenom);
                    command.Parameters.AddWithValue("email", entity.Email);
                    command.Parameters.AddWithValue("isoPays", entity.IsoPays);
                    command.Parameters.AddWithValue("telephone", entity.Telephone);
                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    return command.ExecuteNonQuery() > 0;

                }
            }
        }


        public IEnumerable<Proprietaire> GetByIdLogement(int idLogement)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idClient], [nom], [prenom], [email], [isoPays], [telephone], [password]
                                            FROM [Proprietaire]
                                            JOIN [Logement]
                                            ON [Logement].[idClient] = [Proprietaire].[idClient]
                                            WHERE [idLogement] = @id";
                    command.Parameters.AddWithValue("id", idLogement);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToProprietaire();
                        }
                       
                    }
                }
            }
        }
    }
}
