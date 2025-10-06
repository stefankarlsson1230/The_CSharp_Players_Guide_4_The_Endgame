# The C# Player's Guide - Part 4: The Endgame

## Chapter 52: The Final Battle

### From the Book

Let’s look at what we’re trying to build in some detail. The game works this way:

The game is composed of two collections of characters, formed into one of two parties. Those
parties are the heroes (the good guys) and the monsters (the bad guys). There are many
different types of characters. For example, the core game will include several skeleton
characters and a character type that is The Uncoded One—the final boss. On the heroes’ side,
we will start with a single True Programmer character, whose name will come from the player.
This is the hero of the game. Expansions will add more character types.

Each character will have a certain number of hit points (HP). When a character’s hit points
reach 0, it will be removed from the battle. When a party has no more characters, that party
loses the battle. We will start with just a single battle but will eventually have multiple battles
in a row. With multiple battles, the heroes must defeat each set of monsters in turn. The
monsters win if they can win any battle.

Each battle is a series of rounds in which every remaining character gets a turn to pick one of
several actions. As we go, we will create new action types, each of which can be used by the
character for their turn. In the core challenges, we will start with only two: do nothing, which
skips the character’s turn, and attack, which is the primary action type of the game, driving
the game forward. Characters may eventually have more than one attack option, but we will
keep things simple initially and give each character a single basic attack. Each attack type has
a name and, when used, produces a set of data that represents the attack underway. For
example, we will start the True Programmer with a simple punch attack that will deal a fixed,
reliable, 1 point of damage when used. In contrast, a skeleton has a bone crunch attack that
randomly deals 0 or 1 point of damage. By attacking their enemies, characters will eventually
erode their opponents’ HP down to 0, eliminating them from the battle.

A player controls each party. The player decides which action to use for each character. As we
go, we will build a simple computer player (a basic AI) and then eventually a human controlled
player via the console window. We will be able to run the game with the computer
controlling both parties, humans controlling both parties, and the human in charge of the
heroes against the computer in charge of the monsters (the standard setup).

- [x] Project 1 - Core Game: Building Character
	- This challenge is deceptively complex: it will require building out enough of the game’s foundation to
get two characters taking turns in a loop. (Sure, they’ll be doing nothing, but that’s still a big step
forward!)
	- Objectives:
		- The game needs to be able to represent characters with a name and able to take a turn. (We’ll change
this a little in the challenge Characters, Actions, and Players.)
		- The game should be able to have skeleton characters with the name SKELETON.
		- The game should be able to represent a party with a collection of characters.
		- The game should be able to run a battle composed of two parties—heroes and monsters. A battle
needs to run a series of rounds where each character in each party (heroes first) can take a turn.
		- Before a character takes their turn, the game should report to the user whose turn it is. For example,
“It is SKELETON’s turn….”
		- The only action the game needs to support at this point is the action of doing nothing (skipping a
turn). This action is done by displaying text about doing nothing, resting, or skipping a turn in the
console window. For example, “SKELETON did NOTHING.”
		- The game must run a battle with a single skeleton in both the hero and the monster party. At this
point, the two skeletons should do nothing repeatedly. The game might look like the following:
			```
			It is SKELETON's turn...
			SKELETON did NOTHING.
		
			It is SKELETON's turn...
			SKELETON did NOTHING.
			...
			```
		- Optional: Put a blank line between each character’s turn to differentiate one turn from another.
		- Optional: At this point, the game will run automatically. Consider adding a Thread.Sleep(500);
to slow the game down enough to allow the user to see what is happening over time.

- [X] Project 2 - Core Game: The True Programmer
	- Our skeletons need a hero to fight. We’ll do that by adding in the focal character of the game, the player
character, which represents the player directly, called the True Programmer by in-game role. The player
will choose the True Programmer’s name.
	- Objectives:
		- The game must represent a True Programmer character with a name supplied by the user.
		- Before getting started, ask the user for a name for this character.
		- The game should run a battle with the True Programmer in the hero party vs. a skeleton in the
monster party. The game might look like the following this challenge:
			```
			It is TOG's turn...
			TOG did NOTHING.
			It is SKELETON's turn...
			SKELETON did NOTHING.
			...
			```

- [ ] Project 3 - Core Game: Actions and Players
	- The previous two challenges have had the characters taking turns directly. But instead of characters
deciding actions, the player controlling the character’s team should pick the action for each character.
Eventually, there will be several action types to choose from (do nothing, attack, use item, etc.). There
will also be multiple player types (computer/AI and human input from the console window). A player is
responsible for picking an action for each character in their party. The game should ask the players to
choose the action rather than asking the characters to act for themselves.

	- For now, the only action type will be a do-nothing action, and the only player type will be a computer
player.
	
	- This challenge does not demand that you add new externally visible capabilities but make any needed
changes to allow the game to work as described above, with players choosing actions instead of
characters. If you are confident your design already supports this, claim the XP now and move on.
	- Objectives:
		- The game needs to be able to represent action types. Each action should be able to run when asked.
		- The game needs to include a do-nothing action, which displays the same text as in previous
challenges (for example, “SKELETON did NOTHING.”)
		- The game needs to be able to represent different player types. A player needs the ability to pick an
action for a character they control, given the battle’s current state.
		- The game needs a sole player type: a computer player (a simple AI of sorts). For now, the computer
player will simply pick the one available option: do nothing (and optionally wait a bit first with
Thread.Sleep).
		- The game must know which player controls each party to ask the correct player to pick each
character’s action. Set up the game to ask the player to select an action for each of their characters
and then run the chosen action.
		- Put a simple computer player in charge of each party.
		- Note: To somebody watching, the end result of this challenge may look identical to before this
challenge.




Chapter 53: Into Lands Uncharted


