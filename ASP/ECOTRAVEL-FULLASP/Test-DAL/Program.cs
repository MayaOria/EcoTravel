using ECOTRAVEL_DAL.Entities;
using ECOTRAVEL_DAL.Services;
using System;

namespace Test_DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSERTION CLIENT

            ClientService clientService = new ClientService();
            Client client1 = new Client()
            {
                Nom = "Damon",
                Prenom = "Mat",
                Email = "Mat.Damon@skynet.be",
                IsoPays = "BE",
                Telephone = "0498345784",
                Password = "test1234"

            };
            int idInserted = clientService.Insert(client1);

            //INSERTION TYPE DE LOGEMENT

                TypeLogementService type = new TypeLogementService();
            TypeLogement t1 = new TypeLogement()

            {
                Nom = "Hôtel"
            };

            int idInsertedT1 = type.Insert(t1);
            Console.WriteLine(idInsertedT1);

            TypeLogement t2 = new TypeLogement()

            {
                Nom = "Chambre privée"
            };

            int idInsertedT2 = type.Insert(t2);
            Console.WriteLine(idInsertedT2);

            TypeLogement t3 = new TypeLogement()

            {
                Nom = "Logement entier"
            };

            int idInsertedT3 = type.Insert(t3);
            Console.WriteLine(idInsertedT3);

            TypeLogement t4 = new TypeLogement()

            {
                Nom = "Logement insolite"
            };

            int idInsertedT4 = type.Insert(t4);
            Console.WriteLine(idInsertedT4);


            //INSERTION ADRESSES

            //    AdresseService adresseService = new AdresseService();
            //    Adresse adresse1 = new Adresse()
            //    {
            //        Rue = "Rue Gaucheret",
            //        Numero = "88A",
            //        CodePostal = "1030",
            //        IsoPays = "BE",
            //        Latitude = 50.864004,
            //        Longitude = 4.360705

            //    };
            //        int idInsertedA1 = adresseService.Insert(adresse1);
            //        Console.WriteLine(idInsertedA1);

            //    Adresse adresse2 = new Adresse()
            //    {
            //        Rue = "Rue de la Gare",
            //        Numero = "1001",
            //        CodePostal = "1200",
            //        IsoPays = "BE",
            //        Latitude = 50.845331,
            //        Longitude = 4.424305

            //    };
            //    int idInsertedA2 = adresseService.Insert(adresse2);
            //    Console.WriteLine(idInsertedA2);

            //    Adresse adresse3 = new Adresse()
            //    {
            //        Rue = "Rue d'Ecosse",
            //        Numero = "76",
            //        CodePostal = "1060",
            //        IsoPays = "BE",
            //        Latitude = 50.831052,
            //        Longitude = 4.351510

            //    };
            //    int idInsertedA3 = adresseService.Insert(adresse3);
            //    Console.WriteLine(idInsertedA3);
            }
        }
    }
