var ninjas = new[] { "Itachi", "Kisame", "Naruto" };
foreach (var ninja in ninjas)
{
    AddGreeting(ninja);
}
foreach (var ninja in ninjas)
{
    Console.WriteLine(ninja);
}


static void AddGreeting(string ninja)
    => ninja = "Greetings " + ninja;