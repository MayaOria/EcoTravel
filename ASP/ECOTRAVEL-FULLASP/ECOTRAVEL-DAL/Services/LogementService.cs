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
    public class LogementService : ILogementRepository<Logement, int>
    {
        private string ConnectionString { get; set; } = @"Data Source=(Localdb)\MSSQLLocalDB;Initial Catalog=EcoTravel;Integrated Security=True";
        public IEnumerable<Logement> Get()
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT *
                                            FROM [Logement]";

                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public Logement Get(int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT *
                                            FROM [Logement]
                                            WHERE [idLogement] = @id";

                    command.Parameters.AddWithValue("id", id);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToLogement();
                        }
                        return null;
                    }
                }
            }
        }

        public IEnumerable<Logement> GetByIdAdresse(int idAdresse)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT Logement.*
                                            FROM Logement
                                            JOIN Adresse
                                            ON Logement.idAdresse = Adresse.idAdresse
                                            
                                            WHERE Adresse.idAdresse = @id";
                    command.Parameters.AddWithValue("id", idAdresse);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public IEnumerable<Logement> GetByIdProprietaire(int idProprietaire)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT Logement.*
                                            FROM Logement
                                            JOIN Proprietaire
                                            ON Logement.idClient = Proprietaire.idClient
                                            
                                            WHERE Proprietaire.idClient = @id";
                    command.Parameters.AddWithValue("id", idProprietaire);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public IEnumerable<Logement> GetByIdTypeLogement(int idTypeLogement)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"SELECT Logement.*
                                            FROM Logement
                                            JOIN TypeLogement
                                            ON Logement.idTypeLogement = TypeLogemente.idTypeLogement
                                            
                                            WHERE TypeLogement.idTypeLogement = @id";
                    command.Parameters.AddWithValue("id", idTypeLogement);
                    connexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public int Insert(Logement entity)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Logement]([nom], [descriptionCourte], [descriptionLongue], [prixJournalier], [nbChambres], [nbPieces], [capacite], [nbSDB], [nbWC], [balcon], [wifi], [airco], [minibar], [animaux], [piscine], [voiturier], [roomService], [idAdresse], [idClient], [dateAjout], [idTypeLogement])
                                            OUTPUT [inserted].[idLogement]
                                            VALUES (@nom, @descriptionCourte, @descriptionLongue, @prixJournalier, @nbChambres, @nbPieces, @capacite, @nbSDB, @nbWC, @balcon, @wifi, @airco, @minibar, @animaux, @piscine, @voiturier, @roomService, @idAdresse, @idClient, @dateAjout, @idTypeLogement)";

                    command.Parameters.AddWithValue("nom", entity.Nom);
                    command.Parameters.AddWithValue("descriptionCourte", entity.DescriptionCourte);
                    command.Parameters.AddWithValue("descriptionLongue", entity.DescriptionLongue);
                    command.Parameters.AddWithValue("prixJournalier", entity.PrixJournalier);
                    command.Parameters.AddWithValue("nbChambres", entity.NbChambres);
                    command.Parameters.AddWithValue("nbPieces", entity.NbPieces);
                    command.Parameters.AddWithValue("capacite", entity.Capacite);
                    command.Parameters.AddWithValue("nbSDB", entity.NbSDB);
                    command.Parameters.AddWithValue("nbWC", entity.NbWC);
                    command.Parameters.AddWithValue("balcon", entity.Balcon);
                    command.Parameters.AddWithValue("wifi", entity.Wifi);
                    command.Parameters.AddWithValue("airco", entity.Airco);
                    command.Parameters.AddWithValue("minibar", entity.Minibar);
                    command.Parameters.AddWithValue("animaux", entity.Animaux);
                    command.Parameters.AddWithValue("piscine", entity.Piscine);
                    command.Parameters.AddWithValue("voiturier", entity.Voiturier);
                    command.Parameters.AddWithValue("roomService", entity.RoomService);
                    command.Parameters.AddWithValue("idAdresse", entity.IdAdresse);
                    command.Parameters.AddWithValue("idClient", entity.IdClient);
                    command.Parameters.AddWithValue("dateAjout", entity.DateAjout);
                    command.Parameters.AddWithValue("idTypeLogement", entity.IdLogement);

                    connexion.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(Logement entity, int id)
        {
            using (SqlConnection connexion = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = connexion.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Logement]
                                            SET 
                                            [nom] = @nom, 
                                            [descriptionCourte] = @descriptionCourte, 
                                            [descriptionLongue] = @descriptionLongue,
                                            [prixJournalier] = @prixJournalier, 
                                            [nbChambres] = @nbChambres, 
                                            [nbPieces] = @nbPieces, 
                                            [capacite] = @capacite, 
                                            [nbSDB] = @nbSDB, 
                                            [nbWC] = @nbWC, 
                                            [balcon] = @balcon, 
                                            [wifi] = @wifi,
                                            [airco] = @airco, 
                                            [minibar] = @minibar,
                                            [animaux] = @animaux,
                                            [piscine] = @piscine, 
                                            [voiturier] = @voiturier,
                                            [roomService] = @roomService, 
                                            [idAdresse] = @idAdresse,
                                            [idClient] = @idClient, 
                                            [dateAjout] = @dateAjout,
                                            [idTypeLogement] = @idTypeLogement)
                                            WHERE [idLogement] = @id";

                    command.Parameters.AddWithValue("nom", entity.Nom);
                    command.Parameters.AddWithValue("descriptionCourte", entity.DescriptionCourte);
                    command.Parameters.AddWithValue("descriptionLongue", entity.DescriptionLongue);
                    command.Parameters.AddWithValue("prixJournalier", entity.PrixJournalier);
                    command.Parameters.AddWithValue("nbChambres", entity.NbChambres);
                    command.Parameters.AddWithValue("nbPieces", entity.NbPieces);
                    command.Parameters.AddWithValue("capacite", entity.Capacite);
                    command.Parameters.AddWithValue("nbSDB", entity.NbSDB);
                    command.Parameters.AddWithValue("nbWC", entity.NbWC);
                    command.Parameters.AddWithValue("balcon", entity.Balcon);
                    command.Parameters.AddWithValue("wifi", entity.Wifi);
                    command.Parameters.AddWithValue("airco", entity.Airco);
                    command.Parameters.AddWithValue("minibar", entity.Minibar);
                    command.Parameters.AddWithValue("animaux", entity.Animaux);
                    command.Parameters.AddWithValue("piscine", entity.Piscine);
                    command.Parameters.AddWithValue("voiturier", entity.Voiturier);
                    command.Parameters.AddWithValue("roomService", entity.RoomService);
                    command.Parameters.AddWithValue("idAdresse", entity.IdAdresse);
                    command.Parameters.AddWithValue("idClient", entity.IdClient);
                    command.Parameters.AddWithValue("dateAjout", entity.DateAjout);
                    command.Parameters.AddWithValue("idTypeLogement", entity.IdLogement);
                    command.Parameters.AddWithValue("id", id);

                    connexion.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
