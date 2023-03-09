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
    public class ClientService : IClientRepository<Client, int>
    {
        //Un BaseService sera créé et la connectionString sera déplacée dans le appsettings.json après la phase de test
        private string ConnectionString { get; set; } = @"Data Source=(Localdb)\MSSQLLocalDB;Initial Catalog=EcoTravel;Integrated Security=True";

        public int? CheckLogin(string email, string password)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = "SP_ClientCheckLogin";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("password", password);
                    connexion.Open();
                    object result = command.ExecuteScalar();
                    return (result is DBNull) ? null : (int?)result;
                }
            }
        }

        public Client Get(int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT [idClient], [nom], [prenom], [email], [isoPays], [telephone], [password]
                                            FROM [Client]
                                            WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToClient();
                        }
                        return null;
                    }
                }
            }
        }

        public int Insert(Client entity)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
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
    }
}
