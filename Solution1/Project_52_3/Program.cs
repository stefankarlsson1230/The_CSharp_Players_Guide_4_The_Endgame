//  The previous two challenges have had the characters taking turns directly. But instead of characters
//  deciding actions, the player controlling the character’s team should pick the action for each character.
//  Eventually, there will be several action types to choose from (do nothing, attack, use item, etc.). There
//  will also be multiple player types (computer/AI and human input from the console window). A player is
//  responsible for picking an action for each character in their party. The game should ask the players to
//  choose the action rather than asking the characters to act for themselves.

//	For now, the only action type will be a do-nothing action, and the only player type will be a computer player.

//	This challenge does not demand that you add new externally visible capabilities but make any needed changes to
//	allow the game to work as described above, with players choosing actions instead of characters. If you are
//	confident your design already supports this, claim the XP now and move on.

//  - The game needs to be able to represent action types. Each action should be able to run when asked.

//	- The game needs to include a do-nothing action, which displays the same text as in previous challenges
//	    (for example, “SKELETON did NOTHING.”)

//	- The game needs to be able to represent different player types. A player needs the ability to pick an
//	    action for a character they control, given the battle’s current state.

//	- The game needs a sole player type: a computer player (a simple AI of sorts). For now, the computer player will
//	    simply pick the one available option: do nothing(and optionally wait a bit first with Thread.Sleep).

//  - The game must know which player controls each party to ask the correct player to pick each character’s action.
//      Set up the game to ask the player to select an action for each of their characters and then run the chosen action.

//	- Put a simple computer player in charge of each party.

//	- Note: To somebody watching, the end result of this challenge may look identical to before this challenge.


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