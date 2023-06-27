// See https://aka.ms/new-console-template for more information
using Animalerie;
using System.Text;
using System.Xml.Linq;



List<Animaux> animaux = new List<Animaux>();
animaux.Add(new Chat("blabla", "male", 1, 5, 10, "Oui", "Non", Animalerie.Caracteristiques.Calin));
animaux.Add(new Chat("michou", "femelle", 1, 5, 10, "Oui", "Non", Animalerie.Caracteristiques.Aggressif));
animaux.Add(new Chien("michou", "male", 2, 5, 12, "Oui", Race.Bergeraustralien, Couleur.Gris));
animaux.Add(new Oiseaux("michelle", "femelle", 5, 1, 5, "oui", "non", CouleurOiseaux.Tricolore));

Animaux.Menu(animaux);


