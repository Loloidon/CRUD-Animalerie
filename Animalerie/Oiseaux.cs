using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animalerie
{
    public class Oiseaux : Animaux
    {
       
        int Taille;
        string Voliere;
        string Petitecage;
        CouleurOiseaux CouleurOiseaux;

        public Oiseaux(string nom, string sexe, int age, int poids, int taille, string voliere, string petitecage, CouleurOiseaux couleurOiseaux)
        {
           
            Espece = "Oiseau";
            Nom = nom;
            this.Sexe = sexe;
            Age = age;
            Hage = age*2;
            Poids = poids;
            Taille = taille;
            Voliere = voliere;
            Petitecage = petitecage;
            this.CouleurOiseaux = couleurOiseaux;
        }
        public override void Crier()
        {
            Console.WriteLine("PIAF PIAF PIAF PIAF je Piaf") ;
        }
        public void MyMansGonnaDie()
        {
            Probdeces *= 3;
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
                   $"Voliere : {Voliere}\n" +
                   $"Petitecage : {Petitecage}\n" +
                   $"Couleuroiseaux : {CouleurOiseaux}\n" +
                   $"_______________________________\n";
        }
    }
}
