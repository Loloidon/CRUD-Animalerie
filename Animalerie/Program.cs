// See https://aka.ms/new-console-template for more information
using Animalerie;
using System.Text;
using System.Xml.Linq;



List<Animaux> animaux = new List<Animaux>();
animaux.Add(new Chat("blabla","male",1,5,10,"Oui","Non", Animalerie.Caracteristiques.Calin));
animaux.Add(new Chat("michou", "femelle", 1,5, 10, "Oui", "Non", Animalerie.Caracteristiques.Aggressif));
animaux.Add(new Chien("michou","male",2,5,12,"Oui",Race.Bergeraustralien,Couleur.Gris));
animaux.Add(new Oiseaux("michelle","femelle",5,1,5,"oui","non",CouleurOiseaux.Tricolore)) ;
int input;
bool done = false;
string name,dresser,sexe,result="",espece="",voliere,petitecage,poillong,griffecoupe;
int age,hage=0, poids,taille;


do
{
    Console.WriteLine("|| Appuyer sur 0 pour sortir || 1 pour ajouter un animal || 2 pour afficher touts les animaux");
    input = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();

    switch (input)
    {

        case 0:
            done = true;
            Console.WriteLine("Aurevoir");

            break;

        case 1:
            Animaux.Add(animaux);
            break;
        //Console.WriteLine("Entrez son nom,sexe,âge,son poids en kg,sa taille en cm,si il est dressé,sa race et sa couleur de collier");
        //name = Console.ReadLine();
        //sexe = Console.ReadLine();
        //age = int.Parse(Console.ReadLine());
        //poids = int.Parse(Console.ReadLine());
        //taille = int.Parse(Console.ReadLine());
        //dresser = Console.ReadLine();





        //foreach (Race p in Enum.GetValues<Race>())
        //{
        //    sb.AppendLine((int)p < 4 ? $"{(int)p + 1}  : {p}" : $"{(int)p + 1} : {p}");

        //}
        //Console.WriteLine(sb);
        //Console.WriteLine(result);


        //string stringType = Console.ReadLine();

        //int nbType = int.Parse(stringType);

        //Race race = (Race)nbType - 1;


        //foreach (Couleur p in Enum.GetValues<Couleur>())
        //{
        //    sb.AppendLine((int)p < 4 ? $"{(int)p + 1}  : {p}" : $"{(int)p + 1} : {p}");

        //}
        //Console.WriteLine(sb);
        //Console.WriteLine(result);


        //string Type = Console.ReadLine();

        //int nombreType = int.Parse(Type);

        //Couleur couleur = (Couleur)nombreType - 1;



        //animaux.Add(new Chien(name,sexe,age,poids,taille,dresser,race,couleur));


        //    break;
        case 2:
            Animaux.AfficheAnimaux(animaux);

            break;
        case 3:
            Console.WriteLine("Entrez son nom || sexe || âge || son poids en kg || sa taille en cm || Poillong oui/non || Griffecoupée oui/non || et sa caractéristiques ||");
            name = Console.ReadLine();
            sexe = Console.ReadLine();
            age = int.Parse(Console.ReadLine());
            poids = int.Parse(Console.ReadLine());
            taille = int.Parse(Console.ReadLine());
            poillong = Console.ReadLine();
            griffecoupe = Console.ReadLine();

            //animaux.Add(new Chat(name, sexe, age, hage, poids, taille, poillong, griffecoupe, caracteristiques));




            break;
        case 4:
            

            break;
        case 5:

            break;
    }
} while (!done);

