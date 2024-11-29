using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klasses_BedrAfd;

namespace Proj_Bedrijfsafdeling
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenu());
        }

        // Tom Adriaens
        // 08/11/2024
        // Bedrijfsafdeling

        // Velden 
        static List<Medewerker> _medewerkers = new List<Medewerker>();
        static List<Afdeling> _afdelingen = new List<Afdeling>();
        static Klasse_Db _mijnDB = new Klasse_Db();

        // Functies
        /// <summary>
        /// Haalt alle gegevens op uit de database.
        /// </summary>
        static public void VulLijsten()
        {
            _medewerkers = _mijnDB.VraagMWop();
            _afdelingen = _mijnDB.VraagAfdOp(); 
        }


        /// <summary>
        /// Stuurt alle namen van de medewerkers door
        /// </summary>
        /// <returns></returns>
        static public List<String> StuurLijstMWDoor()
        {
            // Zorg dat je over de meest recente gegevens beschikt 
            VulLijsten();

            // Maak een variabele om gegevens door te sturen 
            List<String> antwoord = new List<String>();

            // Overloop alle meedewerkes en stuur hun volledige naam door
            foreach(Medewerker m in  _medewerkers)
            {
                antwoord.Add(m.VolledigeNaam());

            }

            // Stuur het antwoord door
            return antwoord;
        }

        /// <summary>
        /// Stuurt alle namen van de afdelingen door
        /// </summary>
        /// <returns></returns>
        static public List<String> StuurLijstAfdDoor()
        {
            // Zorg dat je over de meest recente gegevens beschikt 
            VulLijsten();

            // Maak een variabele om gegevens door te sturen 
            List<String> antwoord = new List<String>();

            // Overloop alle afdelingen en stuur hun naam door
            foreach (Afdeling a in _afdelingen)
            {
                antwoord.Add(a.PropAfdNaam);
            }

            // Stuur het antwoord door
            return antwoord;
        }

        /// <summary>
        /// stuurt de gegevens van een gekozen afdeling door. 
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public Afdeling StuurAfdDoor(int ontvIndex)
        {
            return _afdelingen[ontvIndex];

        }

        /// <summary>
        /// Maakt een afdeling aan in de database met de gegevens die doorgestuurd worden
        /// </summary>
        /// <returns></returns>
        static public void MaakAfdAan(String ontvAfdNaam, string ontvHoofd)
        {
            // Maak een object aan van afdeling met de ontvangen gegevens 
            Afdeling nieuweAfdeling = new Afdeling(ontvAfdNaam, ontvHoofd);

            // Stuur dit door naar de database om daar toe te voegen.
            _mijnDB.ToevoegenAfd(nieuweAfdeling);

            // vul de lijsten met de nieuwe gegevens 
            VulLijsten();

        }


        /// <summary>
        /// Past de gegevens in de gekozen afdeling aan en stuurd deze dan door naar de database om ook daar de gegevens te veranderen
        /// </summary>
        /// <param name="ontvIndexAfd"></param>
        /// <param name="ontvAfdNaam"></param>
        /// <param name="ontvHoofd"></param>
        static public void PasAfdAan(int ontvIndexAfd, string ontvAfdNaam, string ontvHoofd)
        {
            // Haal de juiste afdeling uit de lijst
            Afdeling juisteAfd = _afdelingen[ontvIndexAfd];

            // Pas de gegevens aan naar de juiste gegevens
            juisteAfd.PropAfdNaam = ontvAfdNaam;
            juisteAfd.PropAfdHoofd = ontvHoofd;

            // Stuur dit object door naar de database om te verwijderen
            _mijnDB.AanpassenAfd(juisteAfd);

            // vul de lijsten met de nieuwe gegevens 
            VulLijsten();
        }

        /// <summary>
        /// ontvangt de index van de gekozen afdeling, neemt het juiste object uit de lijst en verwijderd dit uit de database
        /// </summary>
        /// <param name="ontvIndex"></param>

        static public void VerwAfd(int ontvIndex)
        {
            // Haal de juiste afdeling uit de lijst
            Afdeling juisteAfd = _afdelingen[ontvIndex];

            // Stuur dit object door naar de database om te verwijderen
            _mijnDB.VerwijdersnAfd(juisteAfd);

            // vul de lijsten met de nieuwe gegevens 
            VulLijsten();

        }

        /// <summary>
        /// stuurt de gegevens van een gekozen medewerker door. 
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public Medewerker StuurMWDoor(int ontvIndex)
        {
            return _medewerkers[ontvIndex];

        }


        /// <summary>
        /// Krijgt de gegevens van de business, maakt een object aan en stuurt dit door naar de persistent layer
        /// </summary>
        /// <param name="ontvVn"></param>
        /// <param name="ontvAn"></param>
        /// <param name="ontvIndex"></param>
        static public void MaakMwAan (string ontvVn, string ontvAn, int ontvIndex)
        {
            // Maak een object aan van medewerker met de ontvangen gegevens 
            Medewerker nieuweMedewerker = new Medewerker(ontvVn, ontvAn, _afdelingen[ontvIndex]);

            // Stuur het door naar de database 
            _mijnDB.ToevoegenMW(nieuweMedewerker);
        }

        static public void PasMwAan (int ontvIndexMw, string ontvVn, string ontvAn, int ontvIndexAfd)
        {
            // neem het id over van de gekozen medewerker, Maak een object met dit id en met de ontvangen gegevens 
            Medewerker nieuweMedewerker = new Medewerker(_medewerkers[ontvIndexMw].PropId,ontvVn, ontvAn, _afdelingen[ontvIndexAfd]);

            // Stuur het door naar de database 
            _mijnDB.AanpassenMw(nieuweMedewerker);
        }
        static public void VerwMw ( int ontvIndex)
        {
            // Neem de mederwerker uit de lijst en stuur het object door naar de database 
            _mijnDB.VerwijdersnMw(_medewerkers[ontvIndex]);
        }
    }
}
