using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SCHNELZAUER_Lucas_TD4
{
    class Lycée
    {

        //Méthode pour lire le fichier Etudiants
        public static int ReadFile(string fileName)
        {
            //Permet de lire un fichier 
            StreamReader lecteur = new StreamReader(fileName);
            String line = "";
            int numberOfChars = 0;


            while (line != null)
            {
                line = lecteur.ReadLine();

                if (line != null)
                {
                    numberOfChars += line.Length;
                    Console.WriteLine(line);
                }

            }

            lecteur.Close();
            return numberOfChars;
        }


        public static void ReadFileEtudiant(string etudiantFile,string enseignantFile)
        {
            int TotalEtudiants = 0;
            int TotalEnseignants = 0;
            int TotalGlobal = 0;

            // Lire le fichier des étudiants
            using (StreamReader lecteurEtudiant = new StreamReader(etudiantFile))
            {
                string line = "";
                while ((line = lecteurEtudiant.ReadLine()) != null)
                {
                    // Séparer chaque partie en utilisant les tabulations du fichier Etudiant.txt
                    string[] parts = line.Split('\t');
                    if (parts.Length >= 5)
                    {
                        string Section = parts[4].Trim();
                        // Incrémente le nombre total d'étudiants
                        TotalEtudiants++;
                    }
                }
            }

            // Lire le fichier des enseignants
            using (StreamReader lecteurEnseignant = new StreamReader(enseignantFile))
            {
                string line = "";
                while ((line = lecteurEnseignant.ReadLine()) != null)
                {
                    // Séparer chaque partie en utilisant les tabulations du fichier Etudiant.txt
                    string[] parts = line.Split('\t');
                    if (parts.Length <= 3)
                    {
                       
                        // Incrémente le nombre total d'étudiants
                        TotalEnseignants++;
                    }
                }
            }
            TotalGlobal = TotalEnseignants + TotalEtudiants;

            Console.WriteLine($"Il y a {TotalEtudiants} étudiants ce qui représente {((double)TotalEtudiants / TotalGlobal * 100):F2}% des membres total");
            Console.WriteLine($"Il y a {TotalEnseignants} enseignants ce qui représente {((double)TotalEnseignants / TotalGlobal * 100):F2}% des membres total");
            Console.WriteLine($"Il y a  {TotalEtudiants} étudiants + {TotalEnseignants} enseignants ce qui nous fait {TotalGlobal} membres en total");


        }


        public static void ReadFileEnseignant(string fileName)
        {
            //Permet de lire un fichier 
            StreamReader lecteur = new StreamReader(fileName);
            String line = "";
            int TotalEnseignants  = 0;

            while (line != null)
            {
                line = lecteur.ReadLine();

                if (line != null)
                {
                    // Séparer chaque partie en utilisant les tabulations du fichier Etudiant.txt
                    string[] parts = line.Split('\t');

                    // Si les parts ont une longueur supérieur ou égale a 4 alors
                    if (parts.Length >= 5)
                    {
                        string Section = parts[4].Trim();
                        // Incrémente le nombre totale d'étudiants
                        TotalEnseignants++;
                    }
                }
            }

            lecteur.Close();
        }

        public void ListerMembres()
        {
            Console.WriteLine("Liste des étudiants :");
            ReadFile("Etudiants.txt");
            Console.WriteLine("\nListe des professeurs :");
            ReadFile("Enseignants.txt");
        }




    }
}
