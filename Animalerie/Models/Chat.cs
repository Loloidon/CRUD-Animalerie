using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie.Models
{
    public class Chat : Animaux
    {

        string Poillong;
        string Griffecoupée;
        public Caracteristiques caracteristiques;

        public Chat(string nom, string sexe, int age, int poids, int taille, string poillong, string griffecoupée, Caracteristiques caracteristiques)
        {
            Espece = "Chat";
            Nom = nom;
            Sexe = sexe;
            Hage = age * 15;
            Age = age;
            Poids = poids;
            Taille = taille;
            Poillong = poillong;
            Griffecoupée = griffecoupée;
            this.caracteristiques = caracteristiques;

        }
        public override void Crier()
        {
            Console.WriteLine("MIAW MIAW suis un chat askip");
        }
        public void MyMansGonnaDie(Animaux probdeces)
        {
            Probdeces *= 0.5;
        }
        public override string ToString()
        {
            return $"_______________________________\n" +
                   $"Espece : {Espece}\n" +
                   $"Name : {Nom}\n" +
                   $"Sexe : {Sexe}\n" +
                   $"Age : {Age}\n" +
                   $"Human age : {Hage}\n" +
                   $"Poids : {Poids}\n" +
                   $"Taille : {Taille}\n" +
                   $"Poil long : {Poillong}\n" +
                   $"Griffe coupée : {Griffecoupée}\n" +
                   $"_______________________________\n";
        }
    }
}
