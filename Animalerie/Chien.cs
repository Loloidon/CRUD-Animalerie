using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie
{
    public class Chien : Animaux
    {
        
        string Dresse { get; set; }
        public Race Race;
        public string Espece;


        public Chien()
        {
            
        }

        public Chien(string nom,string sexe, int age, int poids, int taille, string dresse, Race race,Couleur couleur)
        {
            
            Espece = "Chien";
            Nom = nom;
            this.Sexe = sexe;
            Age = age;
            Hage = age*=7;
            Poids = poids;
            Taille = taille;
            Dresse = dresse;
            Race = race;
            
        }
        public override void Crier()
        {
            Console.WriteLine("WAF WAF SUIS UN CHIEN");
        }
        public void MyMansGonnaDie()
        {
            Probdeces *= 1;
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
                   $"Dresse : {Dresse}\n" +
                   $"Race : {Race}\n" +
                   $"_______________________________\n";
        }
    }
}
