using ImportMDB.Classes.SQL;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8604 // Existence possible d'un argument de reference null.
#pragma warning disable CS8602 // Dereferencement d'une eventuelle reference null.

namespace ImportMDB
{
    public partial class ApplicationContext : DbContext
    {
        //preferable d'utiliser ACE.OLEDB.12 plutot que Jet.OLEDB.4  <= seulement sous serveurs 32bits
        public  string PiloteMDB = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =data.mdb";
        //pour gagner des operations j'ai choisi de predefinir le serveur et la base de destination
        public  string PiloteSQL = "Data Source=tour-patrice\\SQLEXPRESS;Initial Catalog=WebGRB2023;Integrated Security=True;";

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected ApplicationContext()
        {
        }

        public string? Connexion { get; set; }
        public List<ListeTablesSQL> ScanneTablesServeurSQL(string ChaineDeConnexion)
        {
            List<ListeTablesSQL> lstSQL = new List<ListeTablesSQL>();
            using (var sqlConnection1 = new SqlConnection(ChaineDeConnexion))
            {
                using (var cmd = new SqlCommand() { CommandText = "SELECT [name],object_id,create_date,max_column_id_used FROM sys.tables where type='u' order by name;", CommandType = CommandType.Text, Connection = sqlConnection1 })
                {
                    sqlConnection1.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //elimine la table de suivi des migrations
                            if (reader[0].ToString().Substring(1, 2) != "__")
                            {
                                ListeTablesSQL listeTables = new(reader[0].ToString(), (int)reader[3], DateTime.Parse(reader[2].ToString()), (int)reader[1]);
                                CreerDossiersSauvegarde(reader[0].ToString());
                                lstSQL.Add(listeTables);
                            }
                        }
                    }
                }
            }
            return lstSQL;
        }
        public void CreerDossiersSauvegarde(string NomTable)
        {
            string newPath = $"{Environment.CurrentDirectory}\\SauvegardeDB\\{NomTable}";
            if (!Directory.Exists(newPath)) { Directory.CreateDirectory(newPath); }
            Console.WriteLine($"{DateTime.Now} {newPath} {Directory.GetCreationTime(newPath).ToString()}");
        }
        public void RechercheTablesSQL(string ChaineDeConnexion)
        {
            List<ListeTablesSQL> listeTablesSQLs = ScanneTablesServeurSQL(ChaineDeConnexion);
            using (StreamWriter dummy = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "Config.ini")))
            {
                dummy.WriteLine("[Serveur]");
                dummy.WriteLine($"Init = 1");
                dummy.WriteLine($"Entrees = {listeTablesSQLs.Count - 1}");
                for (int x = 1; x < listeTablesSQLs.Count; x++)
                {
                    dummy.WriteLine($"{x} = {listeTablesSQLs[x].NomTable}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("ScanneTablesServeurSQL => ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(listeTablesSQLs[x].NomTable);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" creee le ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(listeTablesSQLs[x].DateCreation);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" contient ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(listeTablesSQLs[x].NomColumn);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" colones");
                    CreerDossiersSauvegarde(listeTablesSQLs[x].NomTable);
                }

            }
        }
        // pour le serveur Intranet  utiliser
        //         optionsBuilder.UseSqlServer("Data Source=INTRANET;Initial Catalog=GRB2023;Integrated Security=True;Trust Server Certificate=True");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Data Source=tour-patrice\\SQLEXPRESS;Initial Catalog=WebGRB2023;Integrated Security=True;");
        public virtual DbSet<GrbAchat>? GrbAchats { get; set; }
        public virtual DbSet<GrbAchatPiece>? GrbAchatPieces { get; set; }
        public virtual DbSet<GrbAchatPiecesTampon>? GrbAchatPiecesTampons { get; set; }
        public virtual DbSet<GrbAlarme>? GrbAlarmes { get; set; }
        public virtual DbSet<GrbAutorisationPunch>? GrbAutorisationPunches { get; set; }
        public virtual DbSet<GrbBavardSuppression>? GrbBavardSuppressions { get; set; }
        public virtual DbSet<GrbBonsCommande>? GrbBonsCommandes { get; set; }
        public virtual DbSet<GrbBonsCommandesPiece>? GrbBonsCommandesPieces { get; set; }
        public virtual DbSet<GrbCatalogueElec>? GrbCatalogueElecs { get; set; }
        public virtual DbSet<GrbCatalogueMec>? GrbCatalogueMecs { get; set; }
        public virtual DbSet<GrbCedule>? GrbCedules { get; set; }
        public virtual DbSet<GrbClient>? GrbClients { get; set; }
        public virtual DbSet<GrbCommentaire>? GrbCommentaires { get; set; }
        public virtual DbSet<GrbConfig>? GrbConfigs { get; set; }
        public virtual DbSet<GrbContact>? GrbContacts { get; set; }
        public virtual DbSet<GrbContactClient>? GrbContactClients { get; set; }
        public virtual DbSet<GrbContactFr>? GrbContactFrs { get; set; }
        public virtual DbSet<GrbDessin>? GrbDessins { get; set; }
        public virtual DbSet<GrbDoublon>? GrbDoublons { get; set; }
        public virtual DbSet<GrbEmploye>? GrbEmployes { get; set; }
        public virtual DbSet<GrbErreur>? GrbErreurs { get; set; }
        public virtual DbSet<GrbExceptionsDl>? GrbExceptionsDls { get; set; }
        public virtual DbSet<GrbFamille>? GrbFamilles { get; set; }
        public virtual DbSet<GrbFournisseur>? GrbFournisseurs { get; set; }
        public virtual DbSet<GrbGroupe>? GrbGroupes { get; set; }
        public virtual DbSet<GrbImpressionBonlivraison>? GrbImpressionBonlivraisons { get; set; }
        public virtual DbSet<GrbImpressionDemandePrixElec>? GrbImpressionDemandePrixElecs { get; set; }
        public virtual DbSet<GrbImpressionDemandePrixMec>? GrbImpressionDemandePrixMecs { get; set; }
        public virtual DbSet<GrbImpressionDetailTemp>? GrbImpressionDetailTemps { get; set; }
        public virtual DbSet<GrbImpressionListePiece>? GrbImpressionListePieces { get; set; }
        public virtual DbSet<GrbImpressionPoste>? GrbImpressionPostes { get; set; }
        public virtual DbSet<GrbImpressionPunch>? GrbImpressionPunches { get; set; }
        public virtual DbSet<GrbImpressionSommairePunchGeneral>? GrbImpressionSommairePunchGenerals { get; set; }
        public virtual DbSet<GrbImpressionSommairePunchGrb>? GrbImpressionSommairePunchGrbs { get; set; }
        public virtual DbSet<GrbImpressionSoumission>? GrbImpressionSoumissions { get; set; }
        public virtual DbSet<GrbInventaireElec>? GrbInventaireElecs { get; set; }
        public virtual DbSet<GrbInventaireElecModif>? GrbInventaireElecModifs { get; set; }
        public virtual DbSet<GrbInventaireMec>? GrbInventaireMecs { get; set; }
        public virtual DbSet<GrbInventaireMecModif>? GrbInventaireMecModifs { get; set; }
        public virtual DbSet<GrbNombreMeat>? GrbNombreMeats { get; set; }
        public virtual DbSet<GrbOutil>? GrbOutils { get; set; }
        public virtual DbSet<GrbOutilsInOut>? GrbOutilsInOuts { get; set; }
        public virtual DbSet<GrbPiecesFr>? GrbPiecesFrs { get; set; }
        public virtual DbSet<GrbProjetDessin>? GrbProjetDessins { get; set; }
        public virtual DbSet<GrbProjetElec>? GrbProjetElecs { get; set; }
        public virtual DbSet<GrbProjetMec>? GrbProjetMecs { get; set; }
        public virtual DbSet<GrbProjetModif>? GrbProjetModifs { get; set; }
        public virtual DbSet<GrbProjetPiece>? GrbProjetPieces { get; set; }
        public virtual DbSet<GrbProjetPiecesTampon>? GrbProjetPiecesTampons { get; set; }
        public virtual DbSet<GrbProjetsDessin>? GrbProjetsDessins { get; set; }
        public virtual DbSet<GrbProjSoum>? GrbProjSoums { get; set; }
        public virtual DbSet<GrbPunch>? GrbPunches { get; set; }
        public virtual DbSet<GrbPunchExcel>? GrbPunchExcels { get; set; }
        public virtual DbSet<GrbSortieMateriel>? GrbSortieMateriels { get; set; }
        public virtual DbSet<GrbSoumissionElec>? GrbSoumissionElecs { get; set; }
        public virtual DbSet<GrbSoumissionMec>? GrbSoumissionMecs { get; set; }
        public virtual DbSet<GrbSoumissionModif>? GrbSoumissionModifs { get; set; }
        public virtual DbSet<GrbSoumissionPiece>? GrbSoumissionPieces { get; set; }
        public virtual DbSet<GrbSoumissionPiecesTampon>? GrbSoumissionPiecesTampons { get; set; }
        public virtual DbSet<GrbSoumProjSectionElec>? GrbSoumProjSectionElecs { get; set; }
        public virtual DbSet<GrbSoumProjSectionMec>? GrbSoumProjSectionMecs { get; set; }
        public virtual DbSet<GrbTempDp>? GrbTempDps { get; set; }
        public virtual DbSet<GrbTempInventaire>? GrbTempInventaires { get; set; }
        public virtual DbSet<GrbTransport>? GrbTransports { get; set; }
        public virtual DbSet<GrbVendeur>? GrbVendeurs { get; set; }
        public virtual DbSet<ProjetPieceBack>? ProjetPieceBacks { get; set; }
        public virtual DbSet<ProjetTamponBack>? ProjetTamponBacks { get; set; }
        public virtual DbSet<TableDesErreur>? TableDesErreurs { get; set; }
        public virtual DbSet<TblCategorie>? TblCategories { get; set; }
        public virtual DbSet<TblPunchType>? TblPunchTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<GrbNombreMeat>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__GrbNombreMeat__3213CC2725002DB6");
                entity.ToTable("GrbNombreMeat");
                entity.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
                entity.Property(e => e.NomContact).HasMaxLength(100);
                entity.Property(e => e.NomClient).HasMaxLength(100);
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.Email1).HasMaxLength(50);
            });
            modelBuilder.Entity<GrbAchat>(entity =>{entity.ToTable("GrbAchat");});
            modelBuilder.Entity<GrbAchatPiece>(entity =>{entity.ToTable("GrbAchatPiece");});
            modelBuilder.Entity<GrbAchatPiecesTampon>(entity =>{entity.ToTable("GrbAchatPiecesTampon");});
            modelBuilder.Entity<GrbAlarme>(entity =>{entity.ToTable("GrbAlarme");});
            modelBuilder.Entity<GrbAutorisationPunch>(entity =>{entity.ToTable("GrbAutorisationPunch");});
            modelBuilder.Entity<GrbBavardSuppression>(entity =>{entity.ToTable("GrbBavardSuppression");});
            modelBuilder.Entity<GrbBonsCommande>(entity =>{entity.ToTable("GrbBonsCommande");});
            modelBuilder.Entity<GrbBonsCommandesPiece>(entity =>{entity.ToTable("GrbBonsCommandesPiece");});
            modelBuilder.Entity<GrbCatalogueElec>(entity =>{entity.ToTable("GrbCatalogueElec");});
            modelBuilder.Entity<GrbCatalogueMec>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__GRB_Cata__3214EC077C7C60B1");
                entity.ToTable("GRB_CatalogueMec");
                entity.Property(e => e.Categorie).HasMaxLength(100).HasColumnName("CATEGORIE");
                entity.Property(e => e.Commentaire).HasMaxLength(100).HasColumnName("COMMENTAIRE");
                entity.Property(e => e.DescEn).HasMaxLength(255).HasColumnName("DESC_EN");
                entity.Property(e => e.DescFr).HasMaxLength(255).HasColumnName("DESC_FR");
                entity.Property(e => e.Fabricant).HasMaxLength(100).HasColumnName("FABRICANT");
                entity.Property(e => e.Piece).HasMaxLength(100).HasColumnName("PIECE");
                entity.Property(e => e.PieceGrb).HasMaxLength(255).HasColumnName("PIECE_GRB");
                entity.Property(e => e.PieceModif).HasMaxLength(100).HasColumnName("PIECE_MODIF");
            });
            modelBuilder.Entity<GrbCedule>(entity =>{entity.ToTable("GrbCedule");});
            modelBuilder.Entity<GrbClient>(entity =>{entity.ToTable("GrbClient");});
            modelBuilder.Entity<GrbCommentaire>(entity =>{entity.ToTable("GrbCommentaire");});
            modelBuilder.Entity<GrbConfig>(entity =>{entity.ToTable("GrbConfig");});
            modelBuilder.Entity<GrbContact>(entity =>{entity.ToTable("GrbContact");entity.Property(e => e.Email).HasColumnName("EMail");});
            modelBuilder.Entity<GrbContactClient>(entity =>{entity.ToTable("GrbContactClient");});
            modelBuilder.Entity<GrbContactFr>(entity =>{entity.ToTable("GrbContactFr");});
            modelBuilder.Entity<GrbDessin>(entity =>{entity.ToTable("GrbDessin");});
            modelBuilder.Entity<GrbDoublon>(entity =>{entity.ToTable("GrbDoublon");});
            modelBuilder.Entity<GrbEmploye>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__GrbEmplo__3214EC27DEFC34C3");
                entity.ToTable("GrbEmploye");
                entity.Property(e => e.Id).ValueGeneratedNever().HasColumnName("ID");
                entity.Property(e => e.Cell).HasMaxLength(50).HasColumnName("cell");
                entity.Property(e => e.Employe).HasMaxLength(50).HasColumnName("employe");
                entity.Property(e => e.Groupe).HasColumnName("groupe");
                entity.Property(e => e.Initiale).HasMaxLength(50).HasColumnName("initiale");
                entity.Property(e => e.Loginname).HasMaxLength(50).HasColumnName("loginname");
                entity.Property(e => e.Page).HasMaxLength(50).HasColumnName("page");
                entity.Property(e => e.Passwd).HasMaxLength(50).HasColumnName("passwd");
                entity.Property(e => e.Tel).HasMaxLength(50).HasColumnName("tel");
            });
            modelBuilder.Entity<GrbErreur>(entity =>{entity.ToTable("GrbErreur");});
            modelBuilder.Entity<GrbExceptionsDl>(entity =>{entity.ToTable("GrbExceptionsDl");});
            modelBuilder.Entity<GrbFamille>(entity =>{entity.ToTable("GrbFamille");});
            modelBuilder.Entity<GrbFournisseur>(entity =>{    entity.ToTable("GrbFournisseur");    entity.Property(e => e.Email).HasColumnName("EMail");});
            modelBuilder.Entity<GrbGroupe>(entity =>{entity.ToTable("GrbGroupe");});
            modelBuilder.Entity<GrbImpressionBonlivraison>(entity =>{entity.ToTable("GrbImpressionBonlivraison");});
            modelBuilder.Entity<GrbImpressionDemandePrixElec>(entity =>{entity.ToTable("GrbImpressionDemandePrixElec");});
            modelBuilder.Entity<GrbImpressionDemandePrixMec>(entity =>{entity.ToTable("GrbImpressionDemandePrixMec");});
            modelBuilder.Entity<GrbImpressionDetailTemp>(entity =>{entity.ToTable("GrbImpressionDetailTemp");});
            modelBuilder.Entity<GrbImpressionListePiece>(entity =>{entity.ToTable("GrbImpressionListePiece");entity.Property(e => e.Pid).HasColumnName("PId");});
            modelBuilder.Entity<GrbImpressionPoste>(entity =>{entity.ToTable("GrbImpressionPoste");});
            modelBuilder.Entity<GrbImpressionPunch>(entity =>{entity.ToTable("GrbImpressionPunch");});
            modelBuilder.Entity<GrbImpressionSommairePunchGeneral>(entity =>{entity.ToTable("GrbImpressionSommairePunchGeneral");});
            modelBuilder.Entity<GrbImpressionSommairePunchGrb>(entity =>{entity.ToTable("GrbImpressionSommairePunchGrb");});
            modelBuilder.Entity<GrbImpressionSoumission>(entity =>{entity.ToTable("GrbImpressionSoumission");});
            modelBuilder.Entity<GrbInventaireElec>(entity =>{entity.ToTable("GrbInventaireElec");});
            modelBuilder.Entity<GrbInventaireElecModif>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__GrbInventaireElecModif__3323CC2725002DB6");
                entity.Property(e => e.Date).HasMaxLength(50);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("ID");
                entity.Property(e => e.Idprojet).HasMaxLength(255).HasColumnName("IDProjet");
                entity.Property(e => e.NoItem).HasMaxLength(50);
                entity.Property(e => e.Quantite).HasMaxLength(50);
                entity.Property(e => e.User).HasMaxLength(50);
            });
            modelBuilder.Entity<GrbInventaireMec>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__GrbInventaireMec__3323CC2725002DB6");
                entity.Property(e => e.Commande).HasMaxLength(50);
                entity.Property(e => e.Commentaires).HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(255);
                entity.Property(e => e.DeviseMonetaire).HasMaxLength(50);
                entity.Property(e => e.Escompte).HasMaxLength(50);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("ID");
                entity.Property(e => e.Localisation).HasMaxLength(50);
                entity.Property(e => e.Manufacturier).HasMaxLength(50);
                entity.Property(e => e.NoItem).HasMaxLength(50);
                entity.Property(e => e.NoProjet).HasMaxLength(50);
                entity.Property(e => e.PrixListe).HasMaxLength(50).HasColumnName("Prix Liste");
                entity.Property(e => e.PrixNet).HasMaxLength(50).HasColumnName("Prix net");
                entity.Property(e => e.QteBoite).HasMaxLength(50);
                entity.Property(e => e.QuantiteCommandee).HasMaxLength(50);
                entity.Property(e => e.QuantiteMinimum).HasMaxLength(50);
                entity.Property(e => e.QuantiteStock).HasMaxLength(50);
            });
            modelBuilder.Entity<GrbInventaireMecModif>(entity =>{entity.ToTable("GrbInventaireMecModif");});
            modelBuilder.Entity<GrbOutil>(entity =>{entity.ToTable("GrbOutil");});
            modelBuilder.Entity<GrbOutilsInOut>(entity =>{entity.ToTable("GrbOutilsInOut");});
            modelBuilder.Entity<GrbPiecesFr>(entity =>{entity.ToTable("GrbPiecesFr");});
            modelBuilder.Entity<GrbProjSoum>(entity =>{entity.ToTable("GrbProjSoum");});
            modelBuilder.Entity<GrbProjetElec>(entity =>{entity.ToTable("GrbProjetElec");});
            modelBuilder.Entity<GrbProjetMec>(entity =>{entity.ToTable("GrbProjetMec");});
            modelBuilder.Entity<GrbProjetModif>(entity =>{entity.ToTable("GrbProjetModif");});
            modelBuilder.Entity<GrbProjetPiece>(entity =>{entity.ToTable("GrbProjetPiece"); entity.Property(e => e.Pid).HasColumnName("PId");});
            modelBuilder.Entity<GrbProjetPiecesTampon>(entity =>{entity.ToTable("GrbProjetPiecesTampon");entity.Property(e => e.Pid).HasColumnName("PId");});
            modelBuilder.Entity<GrbProjetsDessin>(entity =>{entity.HasKey(e => e.Id).HasName("PK__GrbProjetsDessin__3323CC2725002DB6");entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("ID");entity.Property(e => e.NoProjet).HasMaxLength(50);});
            modelBuilder.Entity<GrbPunch>(entity =>{entity.ToTable("GrbPunch");});
            modelBuilder.Entity<GrbPunchExcel>(entity =>{entity.ToTable("GrbPunchExcel");});
            modelBuilder.Entity<GrbSortieMateriel>(entity =>{
                entity.HasKey(e => e.Id).HasName("PK__GrbInventaireMec__3323CC2725002DB6");

                entity.ToTable("GrbSortieMateriel");});
            modelBuilder.Entity<GrbSoumProjSectionElec>(entity =>{entity.ToTable("GrbSoumProjSectionElec");});
            modelBuilder.Entity<GrbSoumProjSectionMec>(entity =>{entity.ToTable("GrbSoumProjSectionMec");});
            modelBuilder.Entity<GrbSoumissionElec>(entity =>{entity.ToTable("GrbSoumissionElec");});
            modelBuilder.Entity<GrbSoumissionMec>(entity =>{entity.ToTable("GrbSoumissionMec");});
            modelBuilder.Entity<GrbSoumissionModif>(entity =>{entity.ToTable("GrbSoumissionModif");});
            modelBuilder.Entity<GrbSoumissionPiece>(entity =>{entity.ToTable("GrbSoumissionPiece");entity.Property(e => e.Pid).HasColumnName("PId");});
            modelBuilder.Entity<GrbSoumissionPiecesTampon>(entity =>{entity.ToTable("GrbSoumissionPiecesTampon");entity.Property(e => e.Pid).HasColumnName("PId");});
            modelBuilder.Entity<GrbTempDp>(entity =>{entity.ToTable("GrbTempDp");});
            modelBuilder.Entity<GrbTempInventaire>(entity =>{entity.ToTable("GrbTempInventaire");});
            modelBuilder.Entity<GrbTransport>(entity =>{entity.ToTable("GrbTransport");});
            modelBuilder.Entity<GrbVendeur>(entity =>{entity.ToTable("GrbVendeur");});
            modelBuilder.Entity<ProjetPieceBack>(entity =>{entity.ToTable("ProjetPieceBack");entity.Property(e => e.Pid).HasColumnName("PId");});
            modelBuilder.Entity<ProjetTamponBack>(entity =>{entity.ToTable("ProjetTamponBack");entity.Property(e => e.Pid).HasColumnName("PId");});
            modelBuilder.Entity<TableDesErreur>(entity =>{entity.ToTable("TableDesErreur");});
            modelBuilder.Entity<TblCategorie>(entity =>{entity.ToTable("TblCategorie");});
            modelBuilder.Entity<TblPunchType>(entity =>{entity.ToTable("TblPunchType");});
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}