using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie
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

        public static void CompteurAnimaux()
        {

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
            int cptdog++;
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
    }
}
