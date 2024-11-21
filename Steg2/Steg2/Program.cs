List<String> Cities = new List<String>();

Console.WriteLine("säg några städer, Säg exit när du är klar");
while (true)
{
string newcity = Console.ReadLine();
if(newcity == "exit")
{
break;
}
Cities.Add(newcity);
}
Console.Clear();
Console.WriteLine("här är alla städer du just nämnde");
for (int i = 0; i < Cities.Count; i++)
{
Console.WriteLine($"{Cities[i]}");
}
Console.ReadLine();
/*
Skapa en tom string-lista som heter "cities". Check
Skapa en loop där du varje gång loopen körs hämtar en string från användaren med Console.ReadLine. Lägg till den string du får från användaren till cities-listan. Avbryt loopen om användaren skriver "exit". Check
Skapa en loop som ligger efter den ovanstående. Den här loopen ska skriva ut alla strings som finns sparade i cities-listan. Check
*/