bool GissadeRätt = false;
int TheNumber = Random.Shared.Next(1, 101);
int Guess;
Console.WriteLine("Gissa vilken siffra jag tänker på från 1 till 100");

while (GissadeRätt == false)
{
    bool Prase = int.TryParse(Console.ReadLine(), out Guess);

    if (Guess == TheNumber)
    {
        GissadeRätt = true;
    }
    else if (Guess != TheNumber)
    {
        Console.Clear();
        Console.WriteLine("Fel, Gissa igen.");
        if (Guess>=TheNumber){
        Console.WriteLine("Btw Gissa Lägre");
        }
        if (Guess<=TheNumber){
        Console.WriteLine("Btw Gissa Högre");
        }
    }
}
Console.Clear();
Console.WriteLine("Du Gissade rätt!");
Console.ReadLine();

/*
Slumpa eller välj ett tal som användaren ska gissa. CHECK
Skapa en loop som körs tills användaren gissat rätt. Du måste alltså skapa variabeln där användarens gissning lagras utanför loopen.
Låt användaren skriva in ett tal. Gör inskrivningen säker, dvs att programmet inte krashar om användaren skriver in något som inte kan konverteras till en int.
Informera användaren om huruvida hens gissning är för hög, för låg eller exakt rätt.
*/
