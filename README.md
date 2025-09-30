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





Chapter 53: Into Lands Uncharted


