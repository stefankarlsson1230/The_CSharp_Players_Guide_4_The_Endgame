List<Character> heroes = new List<Character>();
List<Character> monsters = new List<Character>();

Console.Write("What is your name? ");
string? name = Console.ReadLine();
name = name ?? "THE UNNAMED";


heroes.Add(new TrueProgrammer(name.ToUpper()));
monsters.Add(new Skeleton());


Battle battle = new Battle(heroes, monsters);
battle.Run();



// Classes
internal abstract class Character
{
    public abstract string Name { get; }
    public string TakeTurn() => $"{Name} did NOTHING.";
    public override string ToString() => Name;
}


internal class Skeleton : Character
{
    public override string Name { get; } = "SKELETON";
}

internal class TrueProgrammer : Character
{
    public override string Name { get; }
    public TrueProgrammer(string name) => Name = name;
}


internal class Battle
{
    // Properties
    public List<Character> Heroes { get; }
    public List<Character> Monsters { get; }


    // Constructor
    public Battle(List<Character> heroes, List<Character> monsters)
    {
        Heroes = heroes;
        Monsters = monsters;
    }

    // Methods
    public void Run()
    {
        while (true)
        {
            // Heroes turn
            foreach (Character hero in Heroes)
            {
                Console.WriteLine($"It is {hero}'s turn...");
                Console.WriteLine(hero.TakeTurn());
                Console.WriteLine();
                Thread.Sleep(500);      // REMOVE LATER!!!
            }

            // Monsters turn
            foreach (Character monster in Monsters)
            {
                Console.WriteLine($"It is {monster}'s turn...");
                Console.WriteLine(monster.TakeTurn());
                Console.WriteLine();
                Thread.Sleep(500);      // REMOVE LATER!!!
            }
        }
    }

}