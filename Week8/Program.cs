
//string[] heroes = { "Thor", "Iron Man", "Spider Man", "Antman", "Mihkel" };
//string[] villains = { "Thanos", "Dracula", "Joker", "Peeter" };
string folderPath = @"C:\data\";

string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

string[] weapon = { "Fork", "Gun", "Tomato", "Car", "Sword" };


string hero = GetRandomValue(heroes);
string heroWeapon = GetRandomValue(weapon);
Console.WriteLine($"Your hero is: {hero} using a {heroWeapon}");

string villain = GetRandomValue(villains);
string villainWeapon = GetRandomValue(weapon);
Console.WriteLine($"Todays villain is: {villain} using a {villainWeapon}");

static string GetRandomValue(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomString = someArray[randomIndex];
    return randomString;
}

