using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SCHNELZAUER_Lucas_TD4
{
    class Program
    {
        static void Main(string[] args)
        {
            Lycée lycée = new Lycée();
            
            //Afficher les choix à l'utilisateur 
            ColorBlue();
            Console.WriteLine("Veuillez sélectionner votre choix : ");
            resetColor();
            Console.WriteLine("(1) Lister les renseignements du fichier");
            Console.WriteLine("(2) Lister les renseignements du fichier professeurs ");
            Console.WriteLine("(3) Lister les renseignements de l’ensemble des membres du lycée ");
            Console.WriteLine("(4) Calcul des statistiques ");
            resetColor();
            //Attribution de la valeur de l'utilisateur à la variable choix de type chaine
            string choix = Console.ReadLine();
            //Convertir la chaine en entier
            Int32 choixutilisateur = Convert.ToInt32(choix);



            switch (choixutilisateur)
            {
                case 1:
                    ColorBlue();
                    Console.WriteLine("Voici la liste du fichier Etudiants :");
                    resetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    //Déclaration du fichier Etudiant en utilisation la Méthode ReadFile  
                    Lycée.ReadFile("Etudiants.txt");
                    break; // Le "break" est utilisé pour sortir du switch une fois l'option traitée


                case 2:
                    ColorBlue();
                    Console.WriteLine("Voici la liste du fichier professeurs :");
                    resetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    //Déclaration du fichier Etudiant en utilisation la Méthode ReadFile
                    Lycée.ReadFile("Enseignants.txt");

                    break;


                case 3:
                    Console.WriteLine("Lister les renseignements de l’ensemble des membres du lycée :");
                    lycée.ListerMembres();
                    break;

                case 4:
                    Console.WriteLine("Calcul des statistiques :");
                    Lycée.ReadFileEtudiant("Etudiants.txt","Enseignants.txt");
                    break;


                    
                default:
                    Console.WriteLine("Choix non reconnu.");
                    // Code  exécuter si aucune des options ne correspond à la valeur de choix
                    break;

            }


            Console.ReadLine();



        }
       

       


        //Méthode qui va réinitialiser la couleur d'origine du texte (blanc)
        private static void resetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }


        //Méthode qui va attribuer la couleur bleu au texte
        private static void ColorBlue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
