using System.Collections;
using System.ComponentModel.Design;

namespace ConsoleAppClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez le niveau de votre personnage : ");
            int niveau = int.Parse(Console.ReadLine());

            Console.Write("Entrez la classe (G = Guerrier, M = Mage, R = Rogue) : ");
            char classe = char.ToUpper(Console.ReadLine()[0]);

            Console.Write("Entrez le nombre de Quêtes Héroïques accomplies : ");
            int quetes = int.Parse(Console.ReadLine());

            string titre;


            if (niveau < 10)
            {
                titre = "Novice";
            }
            else if (niveau >= 10 && niveau <= 20)
            {
                if (quetes >= 5)
                    titre = "Adepte";
                else
                    titre = "Apprenti assermenté";
            }
            else if (niveau >= 30)
            {
                if (quetes > 20 && (classe == 'G' || classe == 'M'))
                    titre = "Maître de Guilde";
                else
                    titre = "Statut Indéterminé / Hors-la-loi";
            }
            else if ((niveau > 20 && niveau < 30) ||
                     (classe == 'M' && niveau >= 25))
            {
                titre = "Vétéran";
            }
            else
            {
                titre = "Statut Indéterminé / Hors-la-loi";
            }
            Console.WriteLine();
            Console.WriteLine("Titre officiel : " + titre);
        }
    }
}