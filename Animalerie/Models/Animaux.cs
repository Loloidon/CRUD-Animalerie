using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie.Models
{
    public class Animaux
    {
        public string Espece { get; set; }
        public string Nom { get; set; }
        public string Sexe { get; set; }
        public int Age { get; set; }
        public int Hage { get; set; }
        public int Poids { get; set; }
        public int Taille { get; set; }

        public DateTime Arrive;

        public virtual void Crier()
        {
            Console.WriteLine("YAAAAAAAAAA");
        }
        public double Probdeces;

        public static void Add(List<Animaux> animaux)
        {
            Console.WriteLine("Quel animal souhaitez vous ajouter ? 0 pour revenir en arrière || 1 Chien || 2 pour Chat || 3 pour Oiseau || 0 pour revenir en arrière");
            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {

                case 1:

                    AddDog(animaux);

                    break;


                case 2:
                    AddChat(animaux);

                    break;


                case 3:
                    AddOiseaux(animaux);

                    break;

            }


        }
        public static Race ChooseRace()
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            foreach (Race p in Enum.GetValues<Race>())
            {
                sb.AppendLine((int)p < 4 ? $"{(int)p + 1}  : {p}" : $"{(int)p + 1} : {p}");

            }
            Console.WriteLine(sb);
            Console.WriteLine(result);


            string stringType = Console.ReadLine();

            int nbType = int.Parse(stringType);

            return (Race)nbType - 1;
        }
        private static Couleur ChooseCouleurCollier()
        {
            StringBuilder sb = new StringBuilder();
            string result = "";
            foreach (Couleur p in Enum.GetValues<Couleur>())
            {
                sb.AppendLine((int)p < 4 ? $"{(int)p + 1}  : {p}" : $"{(int)p + 1} : {p}");

            }
            Console.WriteLine(sb);
            Console.WriteLine(result);


            string Type = Console.ReadLine();

            int nombreType = int.Parse(Type);

            return (Couleur)nombreType - 1;

        }

        private static Caracteristiques ChooseCaracteristiques()
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            foreach (Caracteristiques p in Enum.GetValues<Caracteristiques>())
            {
                sb.AppendLine((int)p < 4 ? $"{(int)p + 1}  : {p}" : $"{(int)p + 1} : {p}");

            }
            Console.WriteLine(sb);
            Console.WriteLine(result);


            string stringTopela = Console.ReadLine();

            int nbTipe = int.Parse(stringTopela);

            return (Caracteristiques)nbTipe - 1;

        }

        private static CouleurOiseaux ChooseCouleurOiseau()
        {
            StringBuilder sb = new StringBuilder();
            string result = "";
            foreach (CouleurOiseaux p in Enum.GetValues<CouleurOiseaux>())
            {
                sb.AppendLine((int)p < 4 ? $"{(int)p + 1}  : {p}" : $"{(int)p + 1} : {p}");

            }
            Console.WriteLine(sb);
            Console.WriteLine(result);


            string stringTope = Console.ReadLine();

            int nbTope = int.Parse(stringTope);

            return (CouleurOiseaux)nbTope - 1;

        }

        public static void AfficheAnimaux(List<Animaux> animaux)
        {
            foreach (Animaux anim in animaux)
            {
                Console.WriteLine(anim);
            }
        }

        public static List<int> CompteurAnimaux(List<Animaux> animaux)
        {
            List<int> cpt = new List<int>();
            int cptchien = 0, cptchat = 0, cptoiseaux = 0;
            foreach (Animaux anim in animaux)
                switch (anim)
                {
                    case Chien:
                        cptchien++;
                        break;

                    case Chat:
                        cptchat++;
                        break;

                    case Oiseaux:
                        cptoiseaux++;
                        break;



                }
            cpt.Add(cptchien);
            cpt.Add(cptchat);
            cpt.Add(cptoiseaux);
            return cpt;

        }

        public static void AfficheCompteurAnimaux(List<Animaux> animaux)
        {

            List<int> cpt = new List<int>();
            cpt = CompteurAnimaux(animaux);
            Console.WriteLine($"Il y a {cpt[0]} Chien,{cpt[1]} chat,{cpt[2]} Oiseaux");

        }
        static void AddDog(List<Animaux> animaux)
        {


            Console.WriteLine("Entrez son nom,sexe,âge,son poids en kg,sa taille en cm,si il est dressé,sa race et sa couleur de collier");
            string name = Console.ReadLine();
            string sexe = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int poids = int.Parse(Console.ReadLine());
            int taille = int.Parse(Console.ReadLine());
            string dresser = Console.ReadLine();
            Race race = ChooseRace();
            Couleur couleur = ChooseCouleurCollier();
            animaux.Add(new Chien(name, sexe, age, poids, taille, dresser, race, couleur));

        }

        static void AddChat(List<Animaux> animaux)
        {

            int age, poids, taille;
            Console.WriteLine("Entrez son nom || sexe || âge || son poids en kg || sa taille en cm || Poillong oui/non || Griffecoupée oui/non || et sa caractéristiques ||");
            string name = Console.ReadLine();
            string sexe = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            poids = int.Parse(Console.ReadLine());
            taille = int.Parse(Console.ReadLine());
            string poillong = Console.ReadLine();
            string griffecoupe = Console.ReadLine();
            Caracteristiques caracteristiques = ChooseCaracteristiques();
            animaux.Add(new Chat(name, sexe, age, poids, taille, poillong, griffecoupe, caracteristiques));

        }

        static void AddOiseaux(List<Animaux> animaux)
        {

            Console.WriteLine("Entrez son nom || sexe || âge || son poids en kg || sa taille en cm || Voliere oui/non || petite cage oui/non || et la couleur de l'oiseau ||");
            string name = Console.ReadLine();
            string sexe = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int poids = int.Parse(Console.ReadLine());
            int taille = int.Parse(Console.ReadLine());
            string voliere = Console.ReadLine();
            string petitecage = Console.ReadLine();
            CouleurOiseaux couleurOiseaux = ChooseCouleurOiseau();
            animaux.Add(new Oiseaux(name, sexe, age, poids, taille, voliere, petitecage, couleurOiseaux));

        }

        public static List<Animaux> Die(List<Animaux> animaux)
        {
            bool Isalive;
            int dé;
            Random r = new Random();

            List<Animaux> AnimauxMorts = new List<Animaux>();
            foreach (Animaux anim in animaux)
            {

                switch (anim)
                {
                    case Chien:
                        if (r.Next(0, 100 / 1 + 1) % (100 / 1) == 0)
                        {
                            AnimauxMorts.Add(anim);
                        }
                        break;
                    case Chat:
                        if (r.Next(0, (int)(100 / 0.5)) == 0)
                        {
                            AnimauxMorts.Add(anim);
                        }
                        break;

                    case Oiseaux:

                        if (r.Next(0, 100 / 3) == 0)
                        {
                            AnimauxMorts.Add(anim);
                        }

                        break;
                }
            }
            return AnimauxMorts;

        }
        public static void AfficherMorts(List<Animaux> AnimauxMorts, List<Animaux> animaux)
        {
            foreach (Animaux morts in AnimauxMorts)
            {
                Console.WriteLine(morts.Nom);
                animaux.Remove(morts);
            }
        }
        public static void Menu(List<Animaux> animaux)
        {
            int input;
            bool done = false;
            string name, dresser, sexe, result = "", espece = "", voliere, petitecage, poillong, griffecoupe;
            int age, hage = 0, poids, taille;


            do
            {
                
                Console.WriteLine("|| Appuyer sur 0 pour sortir || 1 pour ajouter un animal || 2 pour afficher touts les animaux || 3 pour ajouter un animal || 4 pour afficher le nombre d'animal || 5 pour passer la nuit");
                input = int.Parse(Console.ReadLine());
                StringBuilder sb = new StringBuilder();


                switch (input)
                {

                    case 0:
                        Console.Clear();
                        done = true;
                        Console.WriteLine("Aurevoir");

                        break;

                    case 1:
                        Console.Clear();
                        Add(animaux);
                        break;

                    case 2:
                        
                        AfficheAnimaux(animaux);

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Entrez son nom || sexe || âge || son poids en kg || sa taille en cm || Poillong oui/non || Griffecoupée oui/non || et sa caractéristiques ||");
                        name = Console.ReadLine();
                        sexe = Console.ReadLine();
                        age = int.Parse(Console.ReadLine());
                        poids = int.Parse(Console.ReadLine());
                        taille = int.Parse(Console.ReadLine());
                        poillong = Console.ReadLine();
                        griffecoupe = Console.ReadLine();

                        break;
                    case 4:
                        Console.Clear();
                        AfficheCompteurAnimaux(animaux);


                        break;
                    case 5:
                        Console.Clear();
                        AfficherMorts(Die(animaux), animaux);
                        
                        break;
                }

            } while (!done);
        }

    }
}
