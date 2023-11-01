using Microsoft.EntityFrameworkCore;
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur non-null lors de la fermeture du constructeur. Envisagez de déclarer le champ comme nullable.

namespace ImportMDB.Classes.SQL
{
    public class GrbAchat
    {
        public GrbAchat(int id, string idachat, int indexAchat, string raison, string dateAchat, int acheteur, string prixTotal, string type, bool modification, string par)
        {
            Id = id;
            Idachat = idachat;
            IndexAchat = indexAchat;
            Raison = raison;
            DateAchat = dateAchat;
            Acheteur = acheteur;
            PrixTotal = prixTotal;
            Type = type;
            Modification = modification;
            Par = par;
        }
        public int Id { get; set; }
        public string Idachat { get; set; }
        public int IndexAchat { get; set; }
        public string Raison { get; set; }
        public string DateAchat { get; set; }
        public int Acheteur { get; set; }
        public string PrixTotal { get; set; }
        public string Type { get; set; }
        public bool Modification { get; set; }
        public string Par { get; set; }
    }
    public class TblCategorie
    {
        public TblCategorie(string correspondance, string nom)
        {
            Correspondance = correspondance;
            Nom = nom;
        }

        public TblCategorie(int id, string correspondance, string nom)
        {
            Id = id;
            Correspondance = correspondance;
            Nom = nom;
        }

        public int Id { get; set; }
        public string Correspondance { get; set; }
        public string Nom { get; set; }
    }
    public class GrbSoumProjSectionMec
    {
        public int Id { get; set; }
        public string NomSectionFr { get; set; }
        public string NomSectionEn { get; set; }
        public int Ordre { get; set; }
    }
    public class GrbSoumProjSectionElec
    {
        public int Id { get; set; }
        public string NomSectionFr { get; set; }
        public string NomSectionEn { get; set; }
        public int Ordre { get; set; }
    }
    public class GrbSoumissionPiecesTampon
    {
        public int Id { get; set; }
        public string DateCopie { get; set; }
        public string Initiales { get; set; }
        public string Idsoumission { get; set; }
        public int Idsection { get; set; }
        public string NumItem { get; set; }
        public string Qte { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Manufact { get; set; }
        public string PrixList { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public int Idfrs { get; set; }
        public string Temps { get; set; }
        public string TempsTotal { get; set; }
        public string PrixTotal { get; set; }
        public string ProfitArgent { get; set; }
        public string SousSection { get; set; }
        public string OrdreSection { get; set; }
        public int NumeroLigne { get; set; }
        public string PrixOrigine { get; set; }
        public string Type { get; set; }
        public bool Visible { get; set; }
        public bool Commande { get; set; }
        public bool Quote { get; set; }
        public bool Recu { get; set; }
        public bool Retour { get; set; }
        public bool CommandeAnnulee { get; set; }
        public bool PieceExtra { get; set; }
        public bool MaterielInutile { get; set; }
        public string Commentaire { get; set; }
        public bool PieceExtraNonChargeable { get; set; }
        public bool PieceExtraChargeable { get; set; }
        public string LiaisonChargeable { get; set; }
        public string Pid { get; set; }
        public string Devise { get; set; }
        public string Provenance { get; set; }
    }
    public class GrbSoumissionPiece
    {
        public int Id { get; set; }
        public string Idsoumission { get; set; }
        public int Idsection { get; set; }
        public string NumItem { get; set; }
        public string Qte { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Manufact { get; set; }
        public string PrixList { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public int Idfrs { get; set; }
        public string Temps { get; set; }
        public string TempsTotal { get; set; }
        public string PrixTotal { get; set; }
        public string ProfitArgent { get; set; }
        public string SousSection { get; set; }
        public string OrdreSection { get; set; }
        public int NumeroLigne { get; set; }
        public string PrixOrigine { get; set; }
        public string Type { get; set; }
        public bool Visible { get; set; }
        public bool Commande { get; set; }
        public bool Quote { get; set; }
        public bool Recu { get; set; }
        public bool Retour { get; set; }
        public bool CommandeAnnulee { get; set; }
        public bool PieceExtra { get; set; }
        public bool MaterielInutile { get; set; }
        public string Commentaire { get; set; }
        public bool PieceExtraNonChargeable { get; set; }
        public bool PieceExtraChargeable { get; set; }
        public string LiaisonChargeable { get; set; }
        public string Pid { get; set; }
        public string Devise { get; set; }
        public bool TransfertJob { get; set; }
        public string Provenance { get; set; }
    }
    public class GrbSoumissionModif
    {
        public int Id { get; set; }
        public string Idsoumission { get; set; }
        public int NoEmploye { get; set; }
        public string Date { get; set; }
        public string Heure { get; set; }
        public string Type { get; set; }
        public string TypeModif { get; set; }
    }
    public class GrbSoumissionMec
    {
        public int Id { get; set; }
        public string Idsoumission { get; set; }
        public int Idclient { get; set; }
        public int Idcontact { get; set; }
        public string Description { get; set; }
        public string Manuel { get; set; }
        public string Creer { get; set; }
        public int CreerPar { get; set; }
        public string TotalPiece { get; set; }
        public string Imprevue { get; set; }
        public string TotalImprevue { get; set; }
        public string TotalTemps { get; set; }
        public string TotalManuel { get; set; }
        public string Commission { get; set; }
        public string TotalCommission { get; set; }
        public string PrixTotal { get; set; }
        public string Profit { get; set; }
        public string TotalProfit { get; set; }
        public string TempsMachinage { get; set; }
        public string TempsCoupe { get; set; }
        public string TempsSoudure { get; set; }
        public string TempsAssemblage { get; set; }
        public string TempsPeinture { get; set; }
        public string TempsTest { get; set; }
        public string TempsDessin { get; set; }
        public string TempsFormation { get; set; }
        public string TempsInstallation { get; set; }
        public string TempsGestion { get; set; }
        public string TempsShipping { get; set; }
        public string NbrePersonne { get; set; }
        public string TempsHebergement { get; set; }
        public string TotalHebergement { get; set; }
        public string TempsRepas { get; set; }
        public string TotalRepas { get; set; }
        public string TempsTransport { get; set; }
        public string TempsUniteMobile { get; set; }
        public string PrixEmballage { get; set; }
        public string TauxHebergement1 { get; set; }
        public string TauxHebergement2 { get; set; }
        public string TauxMachinage { get; set; }
        public string TauxCoupe { get; set; }
        public string TauxSoudure { get; set; }
        public string TauxAssemblage { get; set; }
        public string TauxPeinture { get; set; }
        public string TauxTest { get; set; }
        public string TauxDessin { get; set; }
        public string TauxFormation { get; set; }
        public string TauxInstallation { get; set; }
        public string TauxGestion { get; set; }
        public string TauxShipping { get; set; }
        public string TauxRepas { get; set; }
        public string TauxTransport { get; set; }
        public string TauxUniteMobile { get; set; }
        public string CheminPhotos { get; set; }
        public bool Modification { get; set; }
        public string Par { get; set; }
        public string MontantForfait { get; set; }
        public string InitialeForfait { get; set; }
    }
    public class GrbSoumissionElec
{
    public int Id { get; set; }
    public string Idsoumission { get; set; }
    public int Idclient { get; set; }
    public int Idcontact { get; set; }
    public string Description { get; set; }
    public string PanneauAire { get; set; }
    public string PanneauEspace { get; set; }
    public string NbreManuel { get; set; }
    public string Floorstock { get; set; }
    public string Transport { get; set; }
    public string Marqueur { get; set; }
    public bool Csa { get; set; }
    public bool Cul { get; set; }
    public bool Ul { get; set; }
    public bool Cur { get; set; }
    public bool Ur { get; set; }
    public bool Ce { get; set; }
    public string Delais { get; set; }
    public string Creer { get; set; }
    public int CreerPar { get; set; }
    public string TempsDessin { get; set; }
    public string TempsProgInterface { get; set; }
    public string TempsFabrication { get; set; }
    public string TempsAssemblage { get; set; }
    public string TempsTest { get; set; }
    public string TempsVision { get; set; }
    public string TempsProgAutomate { get; set; }
    public string TempsProgRobot { get; set; }
    public string TempsInstallation { get; set; }
    public string TempsMiseService { get; set; }
    public string TempsFormation { get; set; }
    public string TempsGestion { get; set; }
    public string TempsShipping { get; set; }
    public string NbrePersonne { get; set; }
    public string TempsHebergement { get; set; }
    public string TotalHebergement { get; set; }
    public string TempsRepas { get; set; }
    public string TotalRepas { get; set; }
    public string TempsTransport { get; set; }
    public string TempsUniteMobile { get; set; }
    public string PrixEmballage { get; set; }
    public string TauxDessin { get; set; }
    public string TauxProgInterface { get; set; }
    public string TauxFabrication { get; set; }
    public string TauxAssemblage { get; set; }
    public string TauxTest { get; set; }
    public string TauxVision { get; set; }
    public string TauxProgAutomate { get; set; }
    public string TauxProgRobot { get; set; }
    public string TauxInstallation { get; set; }
    public string TauxMiseService { get; set; }
    public string TauxFormation { get; set; }
    public string TauxGestion { get; set; }
    public string TauxShipping { get; set; }
    public string TauxHebergement1 { get; set; }
    public string TauxHebergement2 { get; set; }
    public string TauxRepas { get; set; }
    public string TauxTransport { get; set; }
    public string TauxUniteMobile { get; set; }
    public string TotalPiece { get; set; }
    public string Imprevue { get; set; }
    public string TotalImprevue { get; set; }
    public string TotalTemps { get; set; }
    public string TotalManuel { get; set; }
    public string Commission { get; set; }
    public string TotalCommission { get; set; }
    public string Profit { get; set; }
    public string TotalProfit { get; set; }
    public string PrixTotal { get; set; }
    public bool SansTemps { get; set; }
    public string Type { get; set; }
    public string CheminPhotos { get; set; }
    public bool Modification { get; set; }
    public string Par { get; set; }
    public string MontantForfait { get; set; }
    public string InitialeForfait { get; set; }
}
    public class GrbTempDp
    {
        public int Id { get; set; }
        public string Piece { get; set; }
        public int Ordre { get; set; }
        public string Type { get; set; }
    }
    public class GrbSortieMateriel
    {
        public int Id { get; set; }
        public string Qte { get; set; }
        public string Nom { get; set; }
        public string NoProjet { get; set; }
        public string NoItem { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
    }
    public class GrbPunchExcel
    {
        public int Id { get; set; }
        public int NoEmploye { get; set; }
        public string NoProjet { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
    }
    public class TableDesErreur
{
    public int Id { get; set; }
    public int Idclient { get; set; }
    public string Date { get; set; }
    public string Contact { get; set; }
    public string Commentaire { get; set; }
    public string EnregPar { get; set; }
    public string Etat { get; set; }
}
    public class ProjetTamponBack
    {
        public int Id { get; set; }
        public string Idprojet { get; set; }
        public int Idsection { get; set; }
        public string NumItem { get; set; }
        public string Qte { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Manufact { get; set; }
        public string PrixList { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public int Idfrs { get; set; }
        public string Temps { get; set; }
        public string TempsTotal { get; set; }
        public string PrixTotal { get; set; }
        public string ProfitPourcent { get; set; }
        public string ProfitArgent { get; set; }
        public string SousSection { get; set; }
        public string OrdreSection { get; set; }
        public int NumeroLigne { get; set; }
        public string PrixOrigine { get; set; }
        public string Type { get; set; }
        public bool Visible { get; set; }
        public bool Commande { get; set; }
        public bool Quote { get; set; }
        public bool Recu { get; set; }
        public bool Retour { get; set; }
        public string NoRetour { get; set; }
        public bool CommandeAnnulee { get; set; }
        public string DateReception { get; set; }
        public string QuantiteRecue { get; set; }
        public string Facturation { get; set; }
        public string Pid { get; set; }
        public bool PieceExtra { get; set; }
        public bool PieceExtraChargeable { get; set; }
        public bool PieceExtraNonChargeable { get; set; }
        public string DateCommande { get; set; }
        public string DateRequise { get; set; }
        public string NomCommande { get; set; }
        public string NoSequentiel { get; set; }
        public bool MaterielInutile { get; set; }
        public string Commentaire { get; set; }
        public string DateRetour { get; set; }
        public string Provenance { get; set; }
        public string Devise { get; set; }
    }
    public class ProjetPieceBack
    {
        public int Id { get; set; }
        public string Idprojet { get; set; }
        public int Idsection { get; set; }
        public string NumItem { get; set; }
        public string Qte { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Manufact { get; set; }
        public string PrixList { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public int Idfrs { get; set; }
        public string Temps { get; set; }
        public string TempsTotal { get; set; }
        public string PrixTotal { get; set; }
        public string ProfitPourcent { get; set; }
        public string ProfitArgent { get; set; }
        public string SousSection { get; set; }
        public string OrdreSection { get; set; }
        public int NumeroLigne { get; set; }
        public string PrixOrigine { get; set; }
        public string Type { get; set; }
        public bool Visible { get; set; }
        public bool Commande { get; set; }
        public bool Quote { get; set; }
        public bool Recu { get; set; }
        public bool Retour { get; set; }
        public string NoRetour { get; set; }
        public bool CommandeAnnulee { get; set; }
        public string DateReception { get; set; }
        public string QuantiteRecue { get; set; }
        public string Facturation { get; set; }
        public string Pid { get; set; }
        public bool PieceExtra { get; set; }
        public bool PieceExtraChargeable { get; set; }
        public bool PieceExtraNonChargeable { get; set; }
        public string DateCommande { get; set; }
        public string DateRequise { get; set; }
        public string NomCommande { get; set; }
        public string NoSequentiel { get; set; }
        public bool MaterielInutile { get; set; }
        public string Commentaire { get; set; }
        public string DateRetour { get; set; }
        public string Provenance { get; set; }
        public string Devise { get; set; }
    }
    public class GrbTransport
    {
        public int Id { get; set; }
        public string Transport { get; set; }
    }
    public class TblPunchType
    {
        public int Id { get; set; }
        public string Mode { get; set; }
        public string Name { get; set; }
    }
    public class GrbTempInventaire
    {
        public int Id { get; set; }
        public string NoItem { get; set; }
        public string Description { get; set; }
    }
    public class GrbOutil
{
    public int Id { get; set; }
    public string NoOutils { get; set; }
    public string NomOutils { get; set; }
    public string Departement { get; set; }
    public string Cout { get; set; }
    public string TypeEtiquette { get; set; }
    public string DateAchat { get; set; }
    public string DateHorsFonction { get; set; }
    public string Commentaire { get; set; }
}
    public class GrbPiecesFr
{
    public int Id { get; set; }
    public int Idfrs { get; set; }
    public string Piece { get; set; }
    public string TableElec { get; set; }
    public string PrixSp { get; set; }
    public string PersRess { get; set; }
    public string PrixList { get; set; }
    public string Escompte { get; set; }
    public string PrixNet { get; set; }
    public string Date { get; set; }
    public string EntrerPar { get; set; }
    public string Valide { get; set; }
    public bool Quoter { get; set; }
    public string DeviseMonetaire { get; set; }
    public string PrixReel { get; set; }
    public string Type { get; set; }
}
    public class GrbProjetDessin
{
    public int Id { get; set; }
    public string NoProjet { get; set; }
}
    public class GrbPunch
{
    public int Id { get; set; }
    public int NoEmploye { get; set; }
    public string NoProjet { get; set; }
    public string Date { get; set; }
    public bool ModifDebut { get; set; }
    public string HeureDebut { get; set; }
    public bool ModifFin { get; set; }
    public string HeureFin { get; set; }
    public string Commentaire { get; set; }
    public bool Facture { get; set; }
    public string NoFacture { get; set; }
    public string NoClient { get; set; }
    public bool Km { get; set; }
    public string NbreKm { get; set; }
    public string Type { get; set; }
}
    public class GrbProjetElec
{
    public int Id { get; set; }
    public string Idprojet { get; set; }
    public string Idsoumission { get; set; }
    public int Idclient { get; set; }
    public int Idcontact { get; set; }
    public string Description { get; set; }
    public string PanneauAire { get; set; }
    public string PanneauEspace { get; set; }
    public string NbreManuel { get; set; }
    public string Floorstock { get; set; }
    public string Transport { get; set; }
    public string Marqueur { get; set; }
    public bool Csa { get; set; }
    public bool Cul { get; set; }
    public bool Ul { get; set; }
    public bool Cur { get; set; }
    public bool Ur { get; set; }
    public bool Ce { get; set; }
    public string Delais { get; set; }
    public string Creer { get; set; }
    public int CreerPar { get; set; }
    public string TempsDessin { get; set; }
    public string TempsProgInterface { get; set; }
    public string TempsFabrication { get; set; }
    public string TempsAssemblage { get; set; }
    public string TempsTest { get; set; }
    public string TempsVision { get; set; }
    public string TempsProgAutomate { get; set; }
    public string TempsProgRobot { get; set; }
    public string TempsInstallation { get; set; }
    public string TempsMiseService { get; set; }
    public string TempsFormation { get; set; }
    public string TempsGestion { get; set; }
    public string TempsShipping { get; set; }
    public string NbrePersonne { get; set; }
    public string TempsHebergement { get; set; }
    public string TotalHebergement { get; set; }
    public string TempsRepas { get; set; }
    public string TotalRepas { get; set; }
    public string TempsTransport { get; set; }
    public string TempsUniteMobile { get; set; }
    public string PrixEmballage { get; set; }
    public string TauxDessin { get; set; }
    public string TauxProgInterface { get; set; }
    public string TauxFabrication { get; set; }
    public string TauxAssemblage { get; set; }
    public string TauxTest { get; set; }
    public string TauxVision { get; set; }
    public string TauxProgAutomate { get; set; }
    public string TauxProgRobot { get; set; }
    public string TauxInstallation { get; set; }
    public string TauxMiseService { get; set; }
    public string TauxFormation { get; set; }
    public string TauxGestion { get; set; }
    public string TauxShipping { get; set; }
    public string TauxHebergement1 { get; set; }
    public string TauxHebergement2 { get; set; }
    public string TauxRepas { get; set; }
    public string TauxTransport { get; set; }
    public string TauxUniteMobile { get; set; }
    public string TotalPiece { get; set; }
    public string Imprevue { get; set; }
    public string TotalImprevue { get; set; }
    public string TotalTemps { get; set; }
    public string TotalManuel { get; set; }
    public string Commission { get; set; }
    public string TotalCommission { get; set; }
    public string PrixTotal { get; set; }
    public string Profit { get; set; }
    public string TotalProfit { get; set; }
    public bool SansTemps { get; set; }
    public string CheminPhotos { get; set; }
    public bool Modification { get; set; }
    public string Par { get; set; }
    public string PrixReception { get; set; }
    public string MontantForfait { get; set; }
    public string InitialeForfait { get; set; }
    public string LiaisonChargeable { get; set; }
    public int ProchaineCommande { get; set; }
}
    public class GrbProjetModif
{
    public int Id { get; set; }
    public string Idprojet { get; set; }
    public int NoEmploye { get; set; }
    public string Date { get; set; }
    public string Heure { get; set; }
    public string Type { get; set; }
    public string TypeModif { get; set; }
    public string Valeur { get; set; }
}
    public class GrbProjetPiece
    {
        public int Id { get; set; }
        public string Idprojet { get; set; }
        public int Idsection { get; set; }
        public string NumItem { get; set; }
        public string Qte { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Manufact { get; set; }
        public string PrixList { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public int Idfrs { get; set; }
        public string Temps { get; set; }
        public string TempsTotal { get; set; }
        public string PrixTotal { get; set; }
        public string ProfitPourcent { get; set; }
        public string ProfitArgent { get; set; }
        public string SousSection { get; set; }
        public string OrdreSection { get; set; }
        public int NumeroLigne { get; set; }
        public string PrixOrigine { get; set; }
        public string Type { get; set; }
        public bool Visible { get; set; }
        public bool Commande { get; set; }
        public bool Quote { get; set; }
        public bool Recu { get; set; }
        public bool Retour { get; set; }
        public string NoRetour { get; set; }
        public bool CommandeAnnulee { get; set; }
        public string DateReception { get; set; }
        public string QuantiteRecue { get; set; }
        public string Facturation { get; set; }
        public string Pid { get; set; }
        public bool PieceExtra { get; set; }
        public bool PieceExtraChargeable { get; set; }
        public bool PieceExtraNonChargeable { get; set; }
        public string DateCommande { get; set; }
        public string DateRequise { get; set; }
        public string NomCommande { get; set; }
        public string NoSequentiel { get; set; }
        public bool MaterielInutile { get; set; }
        public string Commentaire { get; set; }
        public string DateRetour { get; set; }
        public string Provenance { get; set; }
        public string Devise { get; set; }
    }
    public class GrbProjetPiecesTampon
    {
        public int Id { get; set; }
        public string DateCopie { get; set; }
        public string Initiales { get; set; }
        public string Idprojet { get; set; }
        public int Idsection { get; set; }
        public string NumItem { get; set; }
        public string Qte { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Manufact { get; set; }
        public string PrixList { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public int Idfrs { get; set; }
        public string Temps { get; set; }
        public string TempsTotal { get; set; }
        public string PrixTotal { get; set; }
        public string ProfitPourcent { get; set; }
        public string ProfitArgent { get; set; }
        public string SousSection { get; set; }
        public string OrdreSection { get; set; }
        public int NumeroLigne { get; set; }
        public string PrixOrigine { get; set; }
        public string Type { get; set; }
        public bool Visible { get; set; }
        public bool Commande { get; set; }
        public bool Quote { get; set; }
        public bool Recu { get; set; }
        public bool Retour { get; set; }
        public string NoRetour { get; set; }
        public bool CommandeAnnulee { get; set; }
        public string DateReception { get; set; }
        public string QuantiteRecue { get; set; }
        public string Facturation { get; set; }
        public string Pid { get; set; }
        public bool PieceExtra { get; set; }
        public bool PieceExtraChargeable { get; set; }
        public bool PieceExtraNonChargeable { get; set; }
        public string DateCommande { get; set; }
        public string DateRequise { get; set; }
        public string NomCommande { get; set; }
        public string NoSequentiel { get; set; }
        public bool MaterielInutile { get; set; }
        public string Commentaire { get; set; }
        public string DateRetour { get; set; }
        public string Provenance { get; set; }
        public string Devise { get; set; }
    }
    public class GrbOutilsInOut
    {
        public int Id { get; set; }
        public int NoOutils { get; set; }
        public int NoEmploye { get; set; }
        public string DepartDateHeure { get; set; }
        public string RetourDateHeure { get; set; }
        public string Commentaire { get; set; }
        public int NoEnreg { get; set; }
    }
    public class GrbNombreMeat
    {
        public int Id { get; set; }
        public string NomContact { get; set; }
        public string NomClient { get; set; }
        public string Email { get; set; }
        public string Email1 { get; set; }
    }
    public class GrbProjetMec
    {
        public int Id { get; set; }
        public string Idprojet { get; set; }
        public string Idsoumission { get; set; }
        public int Idclient { get; set; }
        public int Idcontact { get; set; }
        public string Description { get; set; }
        public string Manuel { get; set; }
        public string Creer { get; set; }
        public int CreerPar { get; set; }
        public string TotalPiece { get; set; }
        public string Imprevue { get; set; }
        public string TotalImprevue { get; set; }
        public string TotalTemps { get; set; }
        public string TotalManuel { get; set; }
        public string Commission { get; set; }
        public string TotalCommission { get; set; }
        public string PrixTotal { get; set; }
        public string Profit { get; set; }
        public string TotalProfit { get; set; }
        public bool TempsProjBarre { get; set; }
        public string TempsMachinageProj { get; set; }
        public string TempsCoupeProj { get; set; }
        public string TempsSoudureProj { get; set; }
        public string TempsAssemblageProj { get; set; }
        public string TempsPeintureProj { get; set; }
        public string TempsTestProj { get; set; }
        public string TempsDessinProj { get; set; }
        public string TempsFormationProj { get; set; }
        public string TempsInstallationProj { get; set; }
        public string TempsGestionProj { get; set; }
        public string TempsShippingProj { get; set; }
        public string TempsMachinageConc { get; set; }
        public string TempsCoupeConc { get; set; }
        public string TempsSoudureConc { get; set; }
        public string TempsAssemblageConc { get; set; }
        public string TempsPeintureConc { get; set; }
        public string TempsTestConc { get; set; }
        public string TempsGestionConc { get; set; }
        public string TempsShippingConc { get; set; }
        public string TempsDessinConc { get; set; }
        public string TempsInstallationConc { get; set; }
        public string TempsFormationConc { get; set; }
        public string NbrePersonne { get; set; }
        public string TempsHebergement { get; set; }
        public string TotalHebergement { get; set; }
        public string TempsRepas { get; set; }
        public string TotalRepas { get; set; }
        public string TempsTransport { get; set; }
        public string TempsUniteMobile { get; set; }
        public string PrixEmballage { get; set; }
        public string TauxHebergement1 { get; set; }
        public string TauxHebergement2 { get; set; }
        public string TauxMachinage { get; set; }
        public string TauxCoupe { get; set; }
        public string TauxSoudure { get; set; }
        public string TauxAssemblage { get; set; }
        public string TauxPeinture { get; set; }
        public string TauxTest { get; set; }
        public string TauxDessin { get; set; }
        public string TauxFormation { get; set; }
        public string TauxInstallation { get; set; }
        public string TauxGestion { get; set; }
        public string TauxShipping { get; set; }
        public string TauxRepas { get; set; }
        public string TauxTransport { get; set; }
        public string TauxUniteMobile { get; set; }
        public string CheminPhotos { get; set; }
        public bool Modification { get; set; }
        public string Par { get; set; }
        public string PrixReception { get; set; }
        public string MontantForfait { get; set; }
        public string InitialeForfait { get; set; }
        public string LiaisonChargeable { get; set; }
        public int ProchaineCommande { get; set; }
    }
    public class GrbInventaireElecModif
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Idprojet { get; set; }
        public string NoItem { get; set; }
        public string Quantite { get; set; }
        public string User { get; set; }
    }
    public class GrbInventaireMec
    {
        public int Id { get; set; }
        public string NoItem { get; set; }
        public string Description { get; set; }
        public string Manufacturier { get; set; }
        public string QteBoite { get; set; }
        public string PrixListe { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public string Commentaires { get; set; }
        public string Localisation { get; set; }
        public string DeviseMonetaire { get; set; }
        public string QuantiteStock { get; set; }
        public string QuantiteCommandee { get; set; }
        public bool Minimum { get; set; }
        public string QuantiteMinimum { get; set; }
        public string Commande { get; set; }
        public string NoProjet { get; set; }
        public bool CommandeParBoite { get; set; }
    }
    public class GrbInventaireMecModif
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Idprojet { get; set; }
        public string NoItem { get; set; }
        public string Quantite { get; set; }
        public string User { get; set; }
    }
    public class GrbProjetsDessin
    {
        public int Id { get; set; }
        public string NoProjet { get; set; }
    }
    public class GrbProjSoum
    {
        public int Id { get; set; }
        public string IdprojSoum { get; set; }
        public int NoClient { get; set; }
        public string DateOuverture { get; set; }
        public string DateFermeture { get; set; }
        public string RaisonFermeture { get; set; }
        public bool Ouvert { get; set; }
        public bool Verrouille { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
    public class GrbInventaireElec
    {
        public int Id { get; set; }
        public string NoItem { get; set; }
        public string Description { get; set; }
        public string Manufacturier { get; set; }
        public string QteBoite { get; set; }
        public string PrixListe { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public string Commentaires { get; set; }
        public string Localisation { get; set; }
        public string DeviseMonetaire { get; set; }
        public string QuantiteStock { get; set; }
        public string QuantiteCommandee { get; set; }
        public bool Minimum { get; set; }
        public string QuantiteMinimum { get; set; }
        public string Commande { get; set; }
        public string NoProjet { get; set; }
        public bool CommandeParBoite { get; set; }
    }
    public class GrbImpressionSoumission
    {
        public int Id { get; set; }
        public string Idsoumission { get; set; }
        public string NomSection { get; set; }
        public string NumItem { get; set; }
        public string Qte { get; set; }
        public string Description { get; set; }
        public string Manufact { get; set; }
        public string PrixList { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public string NomFournisseur { get; set; }
        public string Temps { get; set; }
        public string TempsTotal { get; set; }
        public string PrixTotal { get; set; }
        public string ProfitPourcent { get; set; }
        public string ProfitArgent { get; set; }
        public string SousSection { get; set; }
        public string DateReception { get; set; }
        public string DateCommande { get; set; }
        public string NoSequentiel { get; set; }
    }
    public class GrbImpressionSommairePunchGrb
    {
        public int Id { get; set; }
        public string Employe { get; set; }
        public string NoProjet { get; set; }
        public string Date { get; set; }
        public string Commentaire { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public string NbreKm { get; set; }
        public string Total { get; set; }
    }
    public class GrbImpressionSommairePunchGeneral
    {
        public int Id { get; set; }
        public string NoProjet { get; set; }
        public string Total { get; set; }
    }
    public partial class GrbBavardSuppression
    {
        public int Id { get; set; }
        public int Iduser { get; set; }
        public string NoProjSoum { get; set; }
        public string Type { get; set; }
        public string Qte { get; set; }
        public string NoItem { get; set; }
        public string Date { get; set; }
        public string Heure { get; set; }
    }
    public class GrbImpressionPunch
    {
        public int Id { get; set; }
        public string NoProjet { get; set; }
        public string NomJour { get; set; }
        public string Date { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public string Client { get; set; }
        public string Commentaire { get; set; }
        public string Total { get; set; }
        public string NbreKm { get; set; }
        public string Type { get; set; }
    }
    public partial class GrbVendeur
    {
        public int Id { get; set; }
        public int Idclient { get; set; }
        public string Date { get; set; }
        public string Contact { get; set; }
        public string Commentaire { get; set; }
        public string EnregPar { get; set; }
        public string Etat { get; set; }
        public string Enregistrerpar { get; set; }
        public string Type { get; set; }
    }
    public class GrbBonsCommandesPiece
    {
        public int Id { get; set; }
        public string NoBonCommande { get; set; }
        public int NoFournisseur { get; set; }
        public string Qte { get; set; }
        public string NoItem { get; set; }
        public string Description { get; set; }
        public string Manufact { get; set; }
        public string Prix { get; set; }
        public string Escompte { get; set; }
        public string Total { get; set; }
        public string Type { get; set; }
        public string NumeroLigne { get; set; }
    }
    public partial class GrbBonsCommande
    {
        public int Id { get; set; }
        public string NoBonCommande { get; set; }
        public int NoFournisseur { get; set; }
        public string NoProjet { get; set; }
        public string Attention { get; set; }
        public string Transport { get; set; }
        public string DateRequise { get; set; }
        public string VotreNoSoum { get; set; }
        public string DateCommande { get; set; }
        public string CommandePar { get; set; }
        public string Total { get; set; }
        public string Commentaire { get; set; }
        public bool AffichageInstructions { get; set; }
        public string LangueImpression { get; set; }
        public string Type { get; set; }
    }
    public class GrbImpressionPoste
    {
        public int Id { get; set; }
        public string Attention { get; set; }
        public string Client { get; set; }
        public string AdresseLiv { get; set; }
        public string VilleProv { get; set; }
        public string PaysCode { get; set; }
    }
    public class GrbImpressionListePiece
    {
        public int Id { get; set; }
        public string Idsoumission { get; set; }
        public string NomSection { get; set; }
        public string SousSection { get; set; }
        public string NumItem { get; set; }
        public string Qte { get; set; }
        public string Description { get; set; }
        public string Manufact { get; set; }
        public string Section { get; set; }
        public string NomSousSection { get; set; }
        public string Idsection { get; set; }
        public string Pid { get; set; }
    }
    public class GrbImpressionDetailTemp
    {
        public int Id { get; set; }
        public string Employe { get; set; }
        public string Type { get; set; }
        public string TotalHeures { get; set; }
    }
    public class GrbClient
    {
        public int Id { get; set; }
        public string NomClient { get; set; }
        public string Compagnie { get; set; }
        public string Telephonne { get; set; }
        public string Fax { get; set; }
        public string Pagette { get; set; }
        public string Cellulaire { get; set; }
        public string ContactGrb { get; set; }
        public string Email { get; set; }
        public string AdresseLiv { get; set; }
        public string VilleLiv { get; set; }
        public string ProvEtatLiv { get; set; }
        public string PaysLiv { get; set; }
        public string CodePostalLiv { get; set; }
        public string Noposte { get; set; }
        public string Commentaire { get; set; }
        public string SiteWeb { get; set; }
        public string DateCreation { get; set; }
        public string UserCreation { get; set; }
        public string DateModification { get; set; }
        public string UserModification { get; set; }
        public string EntryIdoutlook { get; set; }
        public bool Beton { get; set; }
        public bool Pave { get; set; }
        public bool Pharmaceutique { get; set; }
        public bool Agroalimentaire { get; set; }
        public bool Meuble { get; set; }
        public bool Meunerie { get; set; }
        public bool Manufacturier { get; set; }
        public bool Autre { get; set; }
        public bool Consultant { get; set; }
        public bool Asphalte { get; set; }
        public bool Icpi { get; set; }
        public bool Potentiel { get; set; }
        public bool ProduitsChimiques { get; set; }
        public bool Supprime { get; set; }
        public string NomContact { get; set; }
    }
    public class GrbImpressionDemandePrixMec
    {
        public int Id { get; set; }
        public string Qte { get; set; }
        public string NoPiece { get; set; }
        public string Description { get; set; }
        public string Manufacturier { get; set; }
    }
    public class GrbImpressionDemandePrixElec
    {
        public int Id { get; set; }
        public string Qte { get; set; }
        public string NoPiece { get; set; }
        public string Description { get; set; }
        public string Manufacturier { get; set; }
    }
    public class GrbImpressionBonlivraison
    {
        public int Id { get; set; }
        public string QteCom { get; set; }
        public string QteLivr { get; set; }
        public string QteBo { get; set; }
        public string Description { get; set; }
        public string Manufacturier { get; set; }
        public string User { get; set; }
    }
    public class GrbFournisseur
    {
        public int Id { get; set; }
        public int Idfrs { get; set; }
        public string NomFournisseur { get; set; }
        public string Abbreviation { get; set; }
        public string Rep { get; set; }
        public string Interne { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string ProvEtat { get; set; }
        public string Pays { get; set; }
        public string CodePostal { get; set; }
        public string Telephonne { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string CondTransport { get; set; }
        public string Noposte { get; set; }
        public string Siteweb { get; set; }
        public string Commentaire { get; set; }
        public string DateCreation { get; set; }
        public string UserCreation { get; set; }
        public string DateModification { get; set; }
        public string UserModification { get; set; }
        public string EntryIdoutlook { get; set; }
        public bool Supprime { get; set; }
        public string Categorie { get; set; }
    }
    public class GrbGroupe
    {
        public int Id { get; set; }
        public string NomGroupe { get; set; }
        public bool Clients { get; set; }
        public bool Fournisseurs { get; set; }
        public bool Contacts { get; set; }
        public bool ContactsVendeurs { get; set; }
        public bool Rapport { get; set; }
        public bool CatalogueMec { get; set; }
        public bool CatalogueElec { get; set; }
        public bool Employes { get; set; }
        public bool Cedule { get; set; }
        public bool Configuration { get; set; }
        public bool Punch { get; set; }
        public bool Outils { get; set; }
        public bool SoumissionMec { get; set; }
        public bool ProjetMec { get; set; }
        public bool SoumissionElec { get; set; }
        public bool ProjetElec { get; set; }
        public bool InventaireMec { get; set; }
        public bool InventaireElec { get; set; }
        public bool Achat { get; set; }
        public bool ModificationFacturation { get; set; }
        public bool ModificationClients { get; set; }
        public bool ModificationFournisseurs { get; set; }
        public bool ModificationContacts { get; set; }
        public bool ModificationGroupes { get; set; }
        public bool ModificationEmployes { get; set; }
        public bool ModificationFeuillesTemps { get; set; }
        public bool ModificationOutils { get; set; }
        public bool ModificationSoumissionsMec { get; set; }
        public bool ModificationProjetsMec { get; set; }
        public bool ModificationSoumissionsElec { get; set; }
        public bool ModificationProjetsElec { get; set; }
        public bool ModificationBonsCommandes { get; set; }
        public bool ModificationCatalogueElec { get; set; }
        public bool ModificationCatalogueMec { get; set; }
        public bool ModificationInventaireMec { get; set; }
        public bool ModificationInventaireElec { get; set; }
        public bool ModificationPunchEmployes { get; set; }
        public bool ModificationReception { get; set; }
        public bool ModificationRetourMarchandise { get; set; }
        public bool SuppressionProjets { get; set; }
        public bool ListeDistribution { get; set; }
        public bool PunchSemaineAnterieure { get; set; }
        public bool VerrouillageTempsProjet { get; set; }
        public bool DeverrouillageTempsProjet { get; set; }
    }
    public class GrbFamille
    {
        public int Id { get; set; }
        public string Famille { get; set; }
    }
    public class GrbExceptionsDl
    {
        public int Id { get; set; }
        public string Exception { get; set; }
    }
    public class GrbErreur
    {
        public int Id { get; set; }
        public string Qui { get; set; }
        public string Date { get; set; }
        public string Heure { get; set; }
        public string Form { get; set; }
        public string Methode { get; set; }
        public int NoLigne { get; set; }
        public int NoErreur { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string Params { get; set; }
    }
    public class GrbAchatPiece
    {
        public GrbAchatPiece(int id, string idachat, int indexAchat, string piece, int numeroLigne, string qte, string descFr, string descEn, string manufact, string prixList, string escompte, string prixNet, int idfrs, string prixTotal, string type, bool commande, bool retour, string noRetour, bool recu, string dateReception, string quantiteRecue, string dateCommande, string dateRequise, bool inutile, bool commandeAnnulee, string dateRetour, string prixOrigine, string devise)
        {
            Id = id;
            Idachat = idachat;
            IndexAchat = indexAchat;
            Piece = piece;
            NumeroLigne = numeroLigne;
            Qte = qte;
            DescFr = descFr;
            DescEn = descEn;
            Manufact = manufact;
            PrixList = prixList;
            Escompte = escompte;
            PrixNet = prixNet;
            Idfrs = idfrs;
            PrixTotal = prixTotal;
            Type = type;
            Commande = commande;
            Retour = retour;
            NoRetour = noRetour;
            Recu = recu;
            DateReception = dateReception;
            QuantiteRecue = quantiteRecue;
            DateCommande = dateCommande;
            DateRequise = dateRequise;
            Inutile = inutile;
            CommandeAnnulee = commandeAnnulee;
            DateRetour = dateRetour;
            PrixOrigine = prixOrigine;
            Devise = devise;
        }
        public int Id { get; set; }
        public string Idachat { get; set; }
        public int IndexAchat { get; set; }
        public string Piece { get; set; }
        public int NumeroLigne { get; set; }
        public string Qte { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Manufact { get; set; }
        public string PrixList { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public int Idfrs { get; set; }
        public string PrixTotal { get; set; }
        public string Type { get; set; }
        public bool Commande { get; set; }
        public bool Retour { get; set; }
        public string NoRetour { get; set; }
        public bool Recu { get; set; }
        public string DateReception { get; set; }
        public string QuantiteRecue { get; set; }
        public string DateCommande { get; set; }
        public string DateRequise { get; set; }
        public bool Inutile { get; set; }
        public bool CommandeAnnulee { get; set; }
        public string DateRetour { get; set; }
        public string PrixOrigine { get; set; }
        public string Devise { get; set; }
    }
    public class GrbEmploye
    {
        public int Id { get; set; }
        public string Loginname { get; set; }
        public string Passwd { get; set; }
        public string Employe { get; set; }
        public string Initiale { get; set; }
        public string Tel { get; set; }
        public string Page { get; set; }
        public string Cell { get; set; }
        public bool Actif { get; set; }
        public int Groupe { get; set; }
        public int Famille { get; set; }
        public bool Supprime { get; set; }
    }
    public class GrbAchatPiecesTampon
    {
        public int Id { get; set; }
        public string DateCopie { get; set; }
        public string Initiales { get; set; }
        public string Idachat { get; set; }
        public int IndexAchat { get; set; }
        public string Piece { get; set; }
        public int NumeroLigne { get; set; }
        public string Qte { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Manufact { get; set; }
        public string PrixList { get; set; }
        public string Escompte { get; set; }
        public string PrixNet { get; set; }
        public int Idfrs { get; set; }
        public string PrixTotal { get; set; }
        public string Type { get; set; }
        public bool Commande { get; set; }
        public bool Retour { get; set; }
        public string NoRetour { get; set; }
        public bool Recu { get; set; }
        public string DateReception { get; set; }
        public string QuantiteRecue { get; set; }
        public string DateCommande { get; set; }
        public string DateRequise { get; set; }
        public bool Inutile { get; set; }
        public bool CommandeAnnulee { get; set; }
        public string DateRetour { get; set; }
        public string PrixOrigine { get; set; }
        public string Devise { get; set; }
    }
    public class GrbAlarme
    {
        public int Id { get; set; }
        public string Initiale { get; set; }
        public int Idcedule { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Heure { get; set; }
        public string Message { get; set; }
        public int JourSemaine { get; set; }
        public int NoEmploye { get; set; }
        public string TypeCedule { get; set; }
    }
    public class GrbAutorisationPunch
    {
        public int Id { get; set; }
        public int NoEmploye { get; set; }
        public int AutoriserPar { get; set; }
    }
    public class GrbDoublon
    {
        public int Id { get; set; }
        public string Piece { get; set; }
        public string Fabricant { get; set; }
        public string DescrFr { get; set; }
        public string DescrEn { get; set; }
        public string Categorie { get; set; }
    }
    public class GrbDessin
    {
        public int Id { get; set; }
        public string NoProjet { get; set; }
        public string NoDessin { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
    public class GrbContactFr
    {
        public int Id { get; set; }
        public int NoFrs { get; set; }
        public int NoContact { get; set; }
    }
    public class GrbContactClient
    {
        public int Id { get; set; }
        public int Noclient { get; set; }
        public int Nocontact { get; set; }
    }
    public class GrbCommentaire
    {
        public int Id { get; set; }
        public string NoProjSoum { get; set; }
        public int Index { get; set; }
        public string Commentaire { get; set; }
        public bool Section { get; set; }
        public bool SousSection { get; set; }
        public string Key { get; set; }
        public string Relative { get; set; }
    }
    public class GrbConfig
    {
        public int Id { get; set; }
        public string ProfitElec { get; set; }
        public string ProfitMec { get; set; }
        public string Commission { get; set; }
        public string Imprevus { get; set; }
        public string PrixPagesManuel { get; set; }
        public string IndiceDessin { get; set; }
        public string TauxAmericain { get; set; }
        public string TauxEspagnol { get; set; }
        public string TauxDessinElec { get; set; }
        public string TauxProgInterface { get; set; }
        public string TauxAssemblageElec { get; set; }
        public string TauxFabrication { get; set; }
        public string TauxTestElec { get; set; }
        public string TauxVision { get; set; }
        public string TauxProgAutomate { get; set; }
        public string TauxProgRobot { get; set; }
        public string TauxGestionProjetsElec { get; set; }
        public string TauxInstallationElec { get; set; }
        public string TauxFormationElec { get; set; }
        public string TauxMiseService { get; set; }
        public string TauxShippingElec { get; set; }
        public string LeGrand { get; set; }
        public string Lamine { get; set; }
        public string Thermo { get; set; }
        public string _4em { get; set; }
        public string FsDixMoins { get; set; }
        public string FsDix { get; set; }
        public string FsQuinze { get; set; }
        public string FsVingt { get; set; }
        public string FsVingtCinq { get; set; }
        public string FsCinquante { get; set; }
        public string FsCent { get; set; }
        public string ParcelLabelLine1 { get; set; }
        public string ParcelLabelLine2 { get; set; }
        public string ParcelLabelLine3 { get; set; }
        public string ParcelAssist { get; set; }
        public string ParcelEtat { get; set; }
        public string Hebergement1 { get; set; }
        public string Hebergement2 { get; set; }
        public string Repas { get; set; }
        public string Standard { get; set; }
        public string UniteMobile { get; set; }
        public string CheminSee4000 { get; set; }
        public string TauxMachinage { get; set; }
        public string TauxCoupe { get; set; }
        public string TauxSoudure { get; set; }
        public string TauxAssemblageMec { get; set; }
        public string TauxPeinture { get; set; }
        public string TauxTestMec { get; set; }
        public string TauxDessinMec { get; set; }
        public string TauxFormationMec { get; set; }
        public string TauxInstallationMec { get; set; }
        public string TauxGestionProjetsMec { get; set; }
        public string TauxShippingMec { get; set; }
        public string DerniereVersion { get; set; }
    }
    public class GrbCedule
    {
        public int Id { get; set; }
        public string Initiale { get; set; }
        public string DateCedule { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public string Client { get; set; }
        public int Joursemaine { get; set; }
        public string Transport { get; set; }
        public int Finprojet { get; set; }
        public bool Alarme { get; set; }
    }
    public class GrbContact
    {
        public int Id { get; set; }
        public string NomContact { get; set; }
        public string Compagnie { get; set; }
        public string Telephonne { get; set; }
        public string Fax { get; set; }
        public string Cellulaire { get; set; }
        public string Pagette { get; set; }
        public string Email { get; set; }
        public string Noposte { get; set; }
        public string Teldomicile { get; set; }
        public string DateCreation { get; set; }
        public string UserCreation { get; set; }
        public string DateModification { get; set; }
        public string UserModification { get; set; }
        public string Commentaire { get; set; }
        public string Titre { get; set; }
        public string EntryIdoutlook { get; set; }
        public bool Supprime { get; set; }
    }
    public class GrbCatalogueMec
    {
        public int Id { get; set; }
        public string PieceGrb { get; set; }
        public string Piece { get; set; }
        public string PieceModif { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Fabricant { get; set; }
        public string Commentaire { get; set; }
        public string Categorie { get; set; }
    }
    public class GrbCatalogueElec
    {
        public int Id { get; set; }
        public string PieceGrb { get; set; }
        public string Piece { get; set; }
        public string PieceModif { get; set; }
        public string DescFr { get; set; }
        public string DescEn { get; set; }
        public string Fabricant { get; set; }
        public string Commentaire { get; set; }
        public string Temps { get; set; }
        public string Categorie { get; set; }
        public string Dessin { get; set; }
    }
}
