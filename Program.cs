
using Videogames;

using VideogameContext db = new VideogameContext();

Console.WriteLine("Aggiungi una nuova SoftwareHouse!");

Console.WriteLine("Inserisci il nome: ");
var userInputName = Console.ReadLine();

Console.WriteLine("Inserisci la città: ");
var userInputCity = Console.ReadLine();

Console.WriteLine("Inserisci il paese: ");
var userInputCountry = Console.ReadLine();

SoftwareHouse softwareHouse = new SoftwareHouse { Name = userInputName, City = userInputCity, Country = userInputCountry };
db.Add(softwareHouse);
db.SaveChanges();

while (true)
{
    Console.WriteLine("Inserisci il nuovo videogioco!");

    Console.WriteLine("Inserisci il nome del gioco: ");
    var newGameName = Console.ReadLine();

    Console.WriteLine("Inserisci la descrizione del gioco: ");
    var newGameDesc = Console.ReadLine();

    Console.WriteLine("Scegli a quale softwarehouse abbinare il videogioco!");



    Console.WriteLine("Inserisci l'ID della softwarehouse produttrice del gioco: ");
    var newGameSoftHouseId = Convert.ToInt32(Console.ReadLine());

    Videogame newVideoGame = new Videogame { SoftwareHouseId = newGameSoftHouseId , Name = newGameName, Description = newGameDesc };
    db.Add(newVideoGame);
    db.SaveChanges();

    Console.WriteLine("Gioco salvato correttamente!");

    break;
}
