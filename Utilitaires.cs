using ImportMDB.Classes.SQL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
#pragma warning disable CS8602 // Déréférencement d'une éventuelle référence null.
#pragma warning disable CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non-nullable.
#pragma warning disable CS8618 // Sortie de controlleur ayant une valeur null en type référence non-nullable.

namespace ImportMDB
{
    public class ImporterTables
    {
        private ApplicationContext context;
        public ImporterTables(ApplicationContext context)
        {
            this.context = context;
        }
        public void ImporterGRBAchat()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Achat", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GrbAchat achat = new ((int)reader[0],reader[1].ToString(),(int)reader[2],reader[3].ToString(),reader[4].ToString(),(int)reader[5],reader[6].ToString(),reader[7].ToString(),(bool)reader[8],reader[9].ToString());
                            context.GrbAchats.Add(achat);
                            context.SaveChanges();
                        }
                    }
                }
            }
        }
        public void ImporterGRBAchatPieces()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Achat_Pieces", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {

                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GrbAchatPiece grbAchat = new(
                                (int)reader[0], reader[1].ToString(),(int)reader[2],reader[3].ToString(),(int) reader[4],reader[5].ToString(),
                                reader[6].ToString(),reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),
                                reader[11].ToString(),(int)reader[13],reader[14].ToString(),reader[15].ToString(),(bool) reader[16],(bool) reader[17],
                                reader[18].ToString(),(bool)reader[19],reader[20].ToString(),reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),
                                (bool)reader[24],(bool)reader[25],reader[26].ToString(),reader[27].ToString(),reader[28].ToString()
                            );                          
                            context.GrbAchatPieces.Add(grbAchat);
                                context.SaveChanges();
                        }
                    }
                }
            }
        }
        public void ImporterGRBAchatPiecesTampon()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Achat_Pieces_Tampon", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBAlarmes()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Alarmes", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBAutorisationPunch()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_AutorisationPunch", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBBavardSuppression()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_BavardSuppression", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBBonsCommandes()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_BonsCommandes ", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBBonsCommandesPieces()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_BonsCommandes_Pieces", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBCatalogueElec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_CatalogueElec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBCatalogueMec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_CatalogueMec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBcédule()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_cédule", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBClient()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Client", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBCommentaires()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Commentaires", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBConfig()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Config", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBcontact()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_contact", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBContactClient()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ContactClient", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBContactFRS()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ContactFRS", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBDessins()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Dessins", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBDoublons()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Doublons", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBErreurs()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Erreurs", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBExceptionsDL()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ExceptionsDL", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBFamille()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Famille", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBFournisseur()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Fournisseur", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBGroupes()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Groupes", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBimpressionbonlivraison()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_impression_bonlivraison", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBimpressionListePiece()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_impression_ListePiece", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBimpressionsoumission()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_impression_soumission", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBImpressionDemandePrixElec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ImpressionDemandePrixElec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBImpressionDemandePrixMec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ImpressionDemandePrixMec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBImpressionDetailTemps()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ImpressionDetailTemps", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBImpressionPoste()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ImpressionPoste", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBImpressionPunch()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ImpressionPunch", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBImpressionSommairePunchGeneral()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ImpressionSommairePunchGeneral", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBImpressionSommairePunchGRB()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ImpressionSommairePunchGRB", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBInventaireElec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_InventaireElec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBInventaireElecModif()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_InventaireElecModif", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBInventaireMec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_InventaireMec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBInventaireMecModif()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_InventaireMecModif", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBOutils()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Outils", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBOutilsInout()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Outils_In_out", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBPiecesFRS()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_PiecesFRS", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBProjetModif()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Projet_Modif", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBProjetPieces()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Projet_Pieces", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBProjetPiecesTampon()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Projet_Pieces_Tampon", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBProjetElec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ProjetElec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBProjetMec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ProjetMec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBProjetsDessins()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ProjetsDessins", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBProjSoum()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_ProjSoum", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBPunch()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Punch", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBPunchExcel()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_PunchExcel", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBSortieMatériel()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_SortieMatériel", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBSoumissionModif()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Soumission_Modif", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBSoumissionPieces()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Soumission_Pieces", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBSoumissionPiecesTampon()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Soumission_Pieces_Tampon", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBSoumissionElec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_SoumissionElec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBSoumissionMec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_SoumissionMec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBSoumProjSectionElec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_SoumProjSectionElec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBSoumProjSectionMec()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_SoumProjSectionMec", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBTempDP()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_TempDP", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBTempInventaire()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_TempInventaire", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBTransport()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_Transport", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGRBvendeur()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_vendeur", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterProjetpieceback()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM Projet_piece_back", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void Importerprojettamponback()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM projet_tampon_back", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterTableDesErreurs()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM [Table des erreurs]", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterGrbEmployes()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM GRB_employés", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterTBLCategorie()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM TBL_Categorie", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }
        public void ImporterTBLPunchType()
        {
            using (var sqlConnection1 = new SqlConnection(context.PiloteSQL))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT * FROM TBL_Punch_Type", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //élimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                            }
                        }
                    }
                }
            }
        }

    }
    public class FichierIni 
    { 
        string Path=Environment.CurrentDirectory;
        string? EXE = Assembly.GetExecutingAssembly().GetName().Name;
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string? Key, string Value, string FilePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string? Key, string Default, StringBuilder RetVal, int Size, string FilePath);
        public FichierIni(string? IniPath = null) => Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
        public string Read(string? Key, string? Section = null){ var RetVal = new StringBuilder(255); GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path); return RetVal.ToString(); }
        public void Write(string? Key, string Value, string? Section = null) => WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        public void DeleteKey(string? Key, string? Section = null) => Write(Key, null, Section ?? EXE);
        public void DeleteSection(string? Section = null) => Write(null, null, Section ?? EXE);
        public bool KeyExists(string? Key, string? Section = null) => Read(Key, Section).Length > 0;
    }
    public class ListeTablesSQL { 
        public string NomTable {  get; set; }
        public int NomColumn { get; set; }
        public DateTime DateCreation {  get; set; }  
        //en C++ long aurait suffit malheuresement en .NET ca suffit pas
        public double IdObjet {  get; set; }
        List<string> TableNames=new List<string>();
        public ListeTablesSQL() => TableNames = new();
        public ListeTablesSQL(string nomTable, int nomColumn, DateTime DateCreation, double idObjet)
        {
            NomTable = nomTable;
            TableNames.Add(nomTable);   
            NomColumn = nomColumn;
            this.DateCreation = DateCreation;
            IdObjet = idObjet;
        }
    }
}
#pragma warning restore CS8604 // Existence possible d'un argument de référence null.
#pragma warning restore CS8602 // Déréférencement d'une éventuelle référence null.
#pragma warning restore CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non-nullable.
