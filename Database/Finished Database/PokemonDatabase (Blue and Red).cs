//Original Scripts by IIColour (IIColour_Spectrum)

using UnityEngine;
using System.Collections;

//Important to note:
//You need to change the PokemonData.cs to make this work
//Replace the egg group enum with this:
/*public enum EggGroup
{
  MONSTER,
  WATER1,
  BUG,
  FLYING,
  GROUND,
  FAIRY,
  PLANT,
  HUMANSHAPE,
  WATER3,
  MINERAL,
  INDETERMINATE,
  WATER2,
  DITTO,
  DRAGON,
  UNDISCOVERED,
  NONE
};
*/
//Then it should work fine. If it doesn't, then that means that the moves that are in the database are not in the movedatabase yet.
//If you don't want this to happen, download the csvdatabasepu and the veekun database (csvdatabasepu is located in PokemonSprites/PokemonDatabase/CSVDatabasePU/ and veekun database is located in https://github.com/Velorexe/PokemonSprites/tree/PokemonUnity/PokemonDatabase/Veekun%20Database)
//Run csvdatabasepu, give it the source folder of the veekun database and select a lower gen

public static class PokemonDatabase
{
    private static PokemonData[] pokedex = new PokemonData[]
    {
        null,
        new PokemonData(1, "Bulbasaur", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Overgrow", null, "Chlorophyll",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.7f, 6.9f,
	64, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Seed", "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.",
	45, 49, 49, 65, 65, 45, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 20, 27, 34, 41, 48},
	new string[]
	{
		 "Tackle", "Growl", "Leech Seed", "Vine Whip", "Poison Powder", "Razor Leaf", "Growth", "Sleep Powder", "Solar Beam",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {2}, new string[] {"Level,16"}),


new PokemonData(2, "Ivysaur", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Overgrow", null, "Chlorophyll",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 13f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 1, 0, PokemonData.PokedexColor.GREEN, 70,
	"Seed", "There is a plant bulb on its back. When it absorbs nutrients, the bulb is said toblossom into a large flower.",
	60, 62, 63, 80, 80, 60, 0, Color.clear,
	new int[] { 1, 1, 1, 13, 22, 30, 46, 54},
	new string[]
	{
		 "Tackle", "Growl", "Leech Seed", "Vine Whip", "Poison Powder", "Razor Leaf", "Sleep Powder", "Solar Beam",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {3}, new string[] {"Level,32"}),


new PokemonData(3, "Venusaur", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Overgrow", null, "Chlorophyll",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 2f, 100f,
	236, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 1, 0, PokemonData.PokedexColor.GREEN, 70,
	"Seed", "By spreading the broad petals of its flowerand catching the sun’s rays, it fills its bodywith power.",
	80, 82, 83, 100, 100, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 22, 30, 55, 65},
	new string[]
	{
		 "Vine Whip", "Growl", "Leech Seed", "Poison Powder", "Razor Leaf", "Sleep Powder", "Solar Beam",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(4, "Charmander", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Solar-power",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 8.5f,
	62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Lizard", "The flame on its tail indicates Charmander’s lifeforce. If it is healthy, the flame burns brightly.",
	39, 52, 43, 60, 50, 65, 0, Color.clear,
	new int[] { 1, 1, 9, 15, 22, 30, 38, 46},
	new string[]
	{
		 "Scratch", "Growl", "Ember", "Leer", "Rage", "Slash", "Flamethrower", "Fire Spin",
	},
	new string[]
	{
		 "Mega_Punch", "Swords_Dance", "Cut", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Strength", "Dragon_Rage", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {5}, new string[] {"Level,16"}),


new PokemonData(5, "Charmeleon", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Solar-power",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.1f, 19f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Flame", "It lashes about with its tail to knock down its foe. It then tears up the fallen opponent withsharp claws.",
	58, 64, 58, 80, 65, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 15, 24, 33, 56},
	new string[]
	{
		 "Scratch", "Growl", "Ember", "Leer", "Rage", "Slash", "Fire Spin",
	},
	new string[]
	{
		 "Mega_Punch", "Swords_Dance", "Cut", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Strength", "Dragon_Rage", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {6}, new string[] {"Level,36"}),


new PokemonData(6, "Charizard", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Blaze", null, "Solar-power",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.7f, 90.5f,
	240, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Flame", "When expelling a blast of superhot fire,the red flame at the tip of its tail burnsmore intensely.",
	78, 84, 78, 109, 85, 100, 0, Color.clear,
	new int[] { 1, 1, 1, 24, 36, 55},
	new string[]
	{
		 "Scratch", "Leer", "Ember", "Rage", "Slash", "Fire Spin",
	},
	new string[]
	{
		 "Mega_Punch", "Swords_Dance", "Cut", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Dragon_Rage", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(7, "Squirtle", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Rain-dish",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 9f,
	63, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Tiny Turtle", "It shelters itself in its shell, then strikes backwith spouts of water at every opportunity.",
	44, 48, 65, 50, 64, 43, 0, Color.clear,
	new int[] { 1, 1, 8, 15, 22, 28, 35, 42},
	new string[]
	{
		 "Tackle", "Tail Whip", "Bubble", "Water Gun", "Bite", "Withdraw", "Skull Bash", "Hydro Pump",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {8}, new string[] {"Level,16"}),


new PokemonData(8, "Wartortle", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Rain-dish",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 22.5f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.BLUE, 70,
	"Turtle", "When tapped, this Pokémon will pull in its head,but its tail will still stick out a little bit.",
	59, 63, 80, 65, 80, 58, 0, Color.clear,
	new int[] { 1, 1, 1, 15, 24, 31, 39, 47},
	new string[]
	{
		 "Tackle", "Tail Whip", "Bubble", "Water Gun", "Bite", "Withdraw", "Skull Bash", "Hydro Pump",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {9}, new string[] {"Level,36"}),


new PokemonData(9, "Blastoise", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Rain-dish",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.6f, 85.5f,
	239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.BLUE, 70,
	"Shellfish", "It crushes its foe under its heavy body to causefainting. In a pinch, it will withdraw inside its shell.",
	79, 83, 100, 85, 105, 78, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 24, 31, 42},
	new string[]
	{
		 "Tackle", "Tail Whip", "Water Gun", "Bubble", "Bite", "Withdraw", "Skull Bash",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(10, "Caterpie", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shield-dust", null, "Run-away",
	50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 2.9f,
	39, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Worm", "For protection, it releases a horrible stench fromthe antennae on its head to drive away enemies.",
	45, 30, 35, 20, 20, 45, 0, Color.clear,
	new int[] { 1, 1},
	new string[]
	{
		 "Tackle", "String Shot",
	},
	new string[]
	{
		
	},
	new int[] {11}, new string[] {"Level,7"}),


new PokemonData(11, "Metapod", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shed-skin", null, null,
	50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.7f, 9.9f,
	72, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Cocoon", "A steel-hard shell protects its tender body. It quietly endures hardships whileawaiting evolution.",
	50, 20, 55, 25, 25, 30, 0, Color.clear,
	new int[] { 1},
	new string[]
	{
		 "Harden",
	},
	new string[]
	{
		
	},
	new int[] {12}, new string[] {"Level,10"}),


new PokemonData(12, "Butterfree", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Compound-eyes", null, "Tinted-lens",
	50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.1f, 32f,
	178, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 1, 0, PokemonData.PokedexColor.WHITE, 70,
	"Butterfly", "It loves the honey of flowers and can locateflower patches that have even tiny amountsof pollen.",
	60, 45, 50, 90, 80, 70, 0, Color.clear,
	new int[] { 1, 15, 16, 17, 21, 26, 32},
	new string[]
	{
		 "Confusion", "Poison Powder", "Stun Spore", "Sleep Powder", "Supersonic", "Whirlwind", "Psybeam",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Take_Down", "Double_Edge", "Hyper_Beam", "Mega_Drain", "Solar_Beam", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Psywave", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(13, "Weedle", PokemonData.Type.BUG, PokemonData.Type.POISON, "Shield-dust", null, "Run-away",
	50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 3.2f,
	39, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Hairy Bug", "Often found in forests and grasslands. It has a sharp, toxic barb of around two incheson top of its head.",
	40, 35, 30, 20, 20, 50, 0, Color.clear,
	new int[] { 1, 1},
	new string[]
	{
		 "Poison Sting", "String Shot",
	},
	new string[]
	{
		
	},
	new int[] {14}, new string[] {"Level,7"}),


new PokemonData(14, "Kakuna", PokemonData.Type.BUG, PokemonData.Type.POISON, "Shed-skin", null, null,
	50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.6f, 10f,
	72, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Cocoon", "Almost incapable of moving, this Pokémon can onlyharden its shell to protect itself when it isin danger.",
	45, 25, 50, 25, 25, 35, 0, Color.clear,
	new int[] { 1},
	new string[]
	{
		 "Harden",
	},
	new string[]
	{
		
	},
	new int[] {15}, new string[] {"Level,10"}),


new PokemonData(15, "Beedrill", PokemonData.Type.BUG, PokemonData.Type.POISON, "Swarm", null, "Sniper",
	50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1f, 29.5f,
	178, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 1, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Poison Bee", "It has three poisonous stingers on its forelegs andits tail. They are used to jab its enemy repeatedly.",
	65, 90, 40, 45, 80, 75, 0, Color.clear,
	new int[] { 1, 16, 25, 30, 35},
	new string[]
	{
		 "Fury Attack", "Focus Energy", "Rage", "Pin Missile", "Agility",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Take_Down", "Double_Edge", "Hyper_Beam", "Mega_Drain", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(16, "Pidgey", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
	50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 1.8f,
	50, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Tiny Bird", "A common sight in forests and woods. It flapsits wings at ground level to kick up blinding sand.",
	40, 45, 40, 35, 35, 56, 0, Color.clear,
	new int[] { 1, 5, 12, 19, 28, 36, 44},
	new string[]
	{
		 "Gust", "Sand Attack", "Quick Attack", "Whirlwind", "Wing Attack", "Agility", "Mirror Move",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Fly", "Take_Down", "Double_Edge", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Sky_Attack", "Rest", "Substitute"
	},
	new int[] {17}, new string[] {"Level,18"}),


new PokemonData(17, "Pidgeotto", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
	50f, 120, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.1f, 30f,
	122, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
	"Bird", "The claws on its feet are well developed. It can carry prey such as an Exeggcuteto its nest over 60 miles away.",
	63, 60, 55, 50, 50, 71, 0, Color.clear,
	new int[] { 1, 1, 12, 21, 31, 49},
	new string[]
	{
		 "Gust", "Sand Attack", "Quick Attack", "Whirlwind", "Wing Attack", "Mirror Move",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Fly", "Take_Down", "Double_Edge", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Sky_Attack", "Rest", "Substitute"
	},
	new int[] {18}, new string[] {"Level,36"}),


new PokemonData(18, "Pidgeot", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
	50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.5f, 39.5f,
	216, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.BROWN, 70,
	"Bird", "When hunting, it skims the surface of waterat high speed to pick off unwary prey suchas Magikarp.",
	83, 80, 75, 70, 70, 101, 0, Color.clear,
	new int[] { 1, 1, 1, 21, 31},
	new string[]
	{
		 "Gust", "Sand Attack", "Quick Attack", "Whirlwind", "Wing Attack",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Fly", "Take_Down", "Double_Edge", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Sky_Attack", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(19, "Rattata", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Guts", "Hustle",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.3f, 3.5f,
	51, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
	"Mouse", "Living wherever there is food available,it ceaselessly scavenges for ediblesthe entire day.",
	30, 56, 35, 25, 35, 72, 0, Color.clear,
	new int[] { 1, 1, 7, 14, 23, 34},
	new string[]
	{
		 "Tackle", "Tail Whip", "Quick Attack", "Hyper Fang", "Focus Energy", "Super Fang",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Blizzard", "Bubble_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {20}, new string[] {"Level,20"}),


new PokemonData(20, "Raticate", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Guts", "Hustle",
	50f, 127, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.7f, 18.5f,
	145, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
	"Mouse", "It whittles its constantly growing fangs by gnawingon hard things. It can chew apart cinder walls.",
	55, 81, 60, 50, 70, 97, 0, Color.clear,
	new int[] { 1, 1, 1, 14, 41},
	new string[]
	{
		 "Tackle", "Tail Whip", "Quick Attack", "Hyper Fang", "Super Fang",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(21, "Spearow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", null, "Sniper",
	50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 2f,
	52, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Tiny Bird", "Very protective of its territory, it flaps its shortwings busily to dart around at high speed.",
	40, 60, 30, 31, 31, 70, 0, Color.clear,
	new int[] { 1, 1, 9, 15, 22, 29, 36},
	new string[]
	{
		 "Growl", "Peck", "Leer", "Fury Attack", "Mirror Move", "Drill Peck", "Agility",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Fly", "Take_Down", "Double_Edge", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Sky_Attack", "Rest", "Substitute"
	},
	new int[] {22}, new string[] {"Level,20"}),


new PokemonData(22, "Fearow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", null, "Sniper",
	50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.2f, 38f,
	155, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
	"Beak", "With its huge and magnificent wings, it can keepaloft without ever having to land for rest.",
	65, 90, 65, 61, 61, 100, 0, Color.clear,
	new int[] { 1, 1, 15, 25, 34, 43},
	new string[]
	{
		 "Leer", "Peck", "Fury Attack", "Mirror Move", "Drill Peck", "Agility",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Fly", "Take_Down", "Double_Edge", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Sky_Attack", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(23, "Ekans", PokemonData.Type.POISON, PokemonData.Type.NONE, "Intimidate", "Shed-skin", "Unnerve",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2f, 6.9f,
	58, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Snake", "The older it gets, the longer it grows. At night, it wraps its long body aroundtree branches to rest.",
	35, 60, 44, 40, 54, 55, 0, Color.clear,
	new int[] { 1, 1, 10, 17, 24, 31, 38},
	new string[]
	{
		 "Wrap", "Leer", "Poison Sting", "Bite", "Glare", "Screech", "Acid",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Strength", "Mega_Drain", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {24}, new string[] {"Level,22"}),


new PokemonData(24, "Arbok", PokemonData.Type.POISON, PokemonData.Type.NONE, "Intimidate", "Shed-skin", "Unnerve",
	50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 3.5f, 65f,
	157, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Cobra", "The pattern on its belly appears to be a frighteningface. Weak foes will flee just at the sight ofthe pattern.",
	60, 95, 69, 65, 79, 80, 0, Color.clear,
	new int[] { 1, 1, 17, 27, 36, 47},
	new string[]
	{
		 "Wrap", "Poison Sting", "Bite", "Glare", "Screech", "Acid",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Strength", "Mega_Drain", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(25, "Pikachu", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Lightning-rod",
	50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.4f, 6f,
	112, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Mouse", "It raises its tail to check its surroundings. The tail is sometimes struck by lightningin this pose.",
	35, 55, 40, 50, 50, 90, 0, Color.clear,
	new int[] { 1, 1, 9, 16, 26, 33, 43},
	new string[]
	{
		 "Growl", "Thunder Shock", "Thunder Wave", "Quick Attack", "Swift", "Agility", "Thunder",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Seismic_Toss", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Flash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(26, "Raichu", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Lightning-rod",
	50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.8f, 30f,
	218, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.YELLOW, 70,
	"Mouse", "When its electricity builds, its muscles are stimulated,and it becomes more aggressive than usual.",
	60, 90, 55, 90, 80, 110, 0, Color.clear,
	new int[] { 1, 1, 1},
	new string[]
	{
		 "Growl", "Thunder Shock", "Thunder Wave",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Seismic_Toss", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Flash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(27, "Sandshrew", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", null, "Sand-rush",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 12f,
	60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Mouse", "It burrows and lives underground. If threatened,it curls itself up into a ball for protection.",
	50, 75, 85, 20, 30, 40, 0, Color.clear,
	new int[] { 1, 10, 17, 24, 31, 38},
	new string[]
	{
		 "Scratch", "Sand Attack", "Slash", "Poison Sting", "Swift", "Fury Swipes",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {28}, new string[] {"Level,22"}),


new PokemonData(28, "Sandslash", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", null, "Sand-rush",
	50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 29.5f,
	158, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Mouse", "If it digs at an incredible pace, it may snap offits spikes and claws. They grow back in a day.",
	75, 100, 110, 45, 55, 65, 0, Color.clear,
	new int[] { 1, 1, 17, 36, 47},
	new string[]
	{
		 "Scratch", "Sand Attack", "Slash", "Swift", "Fury Swipes",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(29, "Nidoran-f", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
	0f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 7f,
	55, PokemonData.LevelingRate.MEDIUMSLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Poison Pin", "Although small, its venomous barbs renderthis Pokémon dangerous. The female hassmaller horns.",
	55, 47, 52, 40, 40, 41, 0, Color.clear,
	new int[] { 1, 1, 8, 14, 21, 29, 36, 43},
	new string[]
	{
		 "Tackle", "Growl", "Scratch", "Poison Sting", "Tail Whip", "Bite", "Fury Swipes", "Double Kick",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Blizzard", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {30}, new string[] {"Level,16"}),


new PokemonData(30, "Nidorina", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
	0f, 120, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.8f, 20f,
	128, PokemonData.LevelingRate.MEDIUMSLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Poison Pin", "The female has a gentle temperament. It emits ultrasonic cries that have the powerto befuddle foes.",
	70, 62, 67, 55, 55, 56, 0, Color.clear,
	new int[] { 1, 1, 1, 14, 23, 32, 41},
	new string[]
	{
		 "Scratch", "Tackle", "Growl", "Poison Sting", "Tail Whip", "Bite", "Fury Swipes",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(31, "Nidoqueen", PokemonData.Type.POISON, PokemonData.Type.GROUND, "Poison-point", "Rivalry", "Sheer-force",
	0f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.3f, 60f,
	227, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Drill", "It uses its scaly, rugged body to seal the entranceof its nest and protect its young from predators.",
	90, 92, 87, 75, 85, 76, 0, Color.clear,
	new int[] { 1, 1, 14},
	new string[]
	{
		 "Scratch", "Body Slam", "Poison Sting",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Fissure", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(32, "Nidoran-m", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
	100f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 9f,
	55, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Pin", "It scans its surroundings by raising its ears out ofthe grass. Its toxic horn is for protection.",
	46, 57, 40, 40, 40, 50, 0, Color.clear,
	new int[] { 1, 1, 8, 14, 21, 29, 36, 43},
	new string[]
	{
		 "Tackle", "Leer", "Horn Attack", "Poison Sting", "Focus Energy", "Fury Attack", "Horn Drill", "Double Kick",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Blizzard", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {33}, new string[] {"Level,16"}),


new PokemonData(33, "Nidorino", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
	100f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 19.5f,
	128, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Pin", "It raises its big ears to check its surroundings. If it senses anything, it attacks immediately.",
	61, 72, 57, 55, 55, 65, 0, Color.clear,
	new int[] { 1, 1, 1, 14, 23, 41, 50},
	new string[]
	{
		 "Horn Attack", "Tackle", "Leer", "Poison Sting", "Focus Energy", "Horn Drill", "Double Kick",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(34, "Nidoking", PokemonData.Type.POISON, PokemonData.Type.GROUND, "Poison-point", "Rivalry", "Sheer-force",
	100f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.4f, 62f,
	227, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Drill", "It is recognized by its rock-hard hide andits extended horn. Be careful with the horn,as it contains venom.",
	81, 102, 77, 85, 75, 85, 0, Color.clear,
	new int[] { 1, 1, 14},
	new string[]
	{
		 "Horn Attack", "Thrash", "Poison Sting",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Fissure", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(35, "Clefairy", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Cute-charm", "Magic-guard", "Friend-guard",
	25f, 150, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.6f, 7.5f,
	113, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
	"Fairy", "It is said that happiness will come to those who seea gathering of Clefairy dancing under a full moon.",
	70, 45, 48, 60, 65, 35, 0, Color.clear,
	new int[] { 1, 1, 13, 18, 24, 31, 39, 48},
	new string[]
	{
		 "Pound", "Growl", "Sing", "Double Slap", "Minimize", "Metronome", "Defense Curl", "Light Screen",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Fire_Blast", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(36, "Clefable", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Cute-charm", "Magic-guard", "Unaware",
	25f, 25, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.3f, 40f,
	217, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
	"Fairy", "Its hearing is so acute it can hear a pin drop overhalf a mile away. It lives on quiet mountains.",
	95, 70, 73, 95, 90, 60, 0, Color.clear,
	new int[] { 1, 1, 1, 1},
	new string[]
	{
		 "Double Slap", "Sing", "Minimize", "Metronome",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Fire_Blast", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(37, "Vulpix", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Drought",
	25f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 9.9f,
	60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Fox", "When it is born, it has just one snow-white tail. The tail splits from its tip as it grows older.",
	38, 41, 40, 50, 65, 65, 0, Color.clear,
	new int[] { 1, 1, 16, 21, 28, 35, 42},
	new string[]
	{
		 "Tail Whip", "Ember", "Quick Attack", "Roar", "Confuse Ray", "Flamethrower", "Fire Spin",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(38, "Ninetales", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Drought",
	25f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 19.9f,
	177, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Fox", "It has nine long tails and fur that gleams gold. It is said to live for 1,000 years.",
	73, 76, 75, 81, 100, 100, 0, Color.clear,
	new int[] { 1, 1, 1, 1},
	new string[]
	{
		 "Tail Whip", "Roar", "Ember", "Quick Attack",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(39, "Jigglypuff", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Cute-charm", "Competitive", "Friend-guard",
	25f, 170, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.5f, 5.5f,
	95, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Balloon", "It captivates foes with its huge, round eyes,then lulls them to sleep by singing asoothing melody.",
	115, 45, 20, 45, 25, 20, 0, Color.clear,
	new int[] { 1, 9, 14, 19, 24, 29, 34, 39},
	new string[]
	{
		 "Sing", "Pound", "Disable", "Defense Curl", "Double Slap", "Rest", "Body Slam", "Double-Edge",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(40, "Wigglytuff", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Cute-charm", "Competitive", "Frisk",
	25f, 50, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1f, 12f,
	196, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Balloon", "Their fur feels so good that if two of them snuggletogether, they won’t want to be separated.",
	140, 70, 45, 85, 50, 45, 0, Color.clear,
	new int[] { 1, 1, 1, 1},
	new string[]
	{
		 "Double Slap", "Sing", "Disable", "Defense Curl",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(41, "Zubat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
	50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 0.8f, 7.5f,
	49, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
	"Bat", "Even though it has no eyes, it can sense obstaclesusing ultrasonic waves it emits from its mouth.",
	40, 45, 35, 30, 40, 55, 0, Color.clear,
	new int[] { 1, 10, 15, 21, 28, 36},
	new string[]
	{
		 "Leech Life", "Supersonic", "Bite", "Confuse Ray", "Wing Attack", "Haze",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Take_Down", "Double_Edge", "Mega_Drain", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Rest", "Substitute"
	},
	new int[] {42}, new string[] {"Level,22"}),


new PokemonData(42, "Golbat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
	50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.6f, 55f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
	"Bat", "Once it bites, it will not stop draining energyfrom the victim even if it gets too heavy to fly.",
	75, 80, 70, 65, 75, 90, 0, Color.clear,
	new int[] { 1, 1, 1, 21, 32, 43},
	new string[]
	{
		 "Bite", "Screech", "Leech Life", "Confuse Ray", "Wing Attack", "Haze",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Take_Down", "Double_Edge", "Hyper_Beam", "Mega_Drain", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(43, "Oddish", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Run-away",
	50f, 255, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.5f, 5.4f,
	64, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Weed", "During the day, it stays in the cold undergroundto avoid the sun. It grows by bathing in moonlight.",
	45, 50, 55, 75, 65, 30, 0, Color.clear,
	new int[] { 1, 15, 17, 19, 24, 33, 46},
	new string[]
	{
		 "Absorb", "Poison Powder", "Stun Spore", "Sleep Powder", "Acid", "Petal Dance", "Solar Beam",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Take_Down", "Double_Edge", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {44}, new string[] {"Level,21"}),


new PokemonData(44, "Gloom", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Stench",
	50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 0.8f, 8.6f,
	138, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Weed", "Smells incredibly foul! However, around one outof a thousand people enjoy sniffing itsnose-bending stink.",
	60, 65, 70, 85, 75, 40, 0, Color.clear,
	new int[] { 1, 1, 17, 19, 28, 38, 52},
	new string[]
	{
		 "Absorb", "Poison Powder", "Stun Spore", "Sleep Powder", "Acid", "Petal Dance", "Solar Beam",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Take_Down", "Double_Edge", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(45, "Vileplume", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Effect-spore",
	50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 1.2f, 18.6f,
	221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Flower", "The larger its petals, the more toxic pollen itcontains. Its big head is heavy and hard to hold up.",
	75, 80, 85, 110, 90, 50, 0, Color.clear,
	new int[] { 1, 1, 1, 15, 19},
	new string[]
	{
		 "Acid", "Stun Spore", "Petal Dance", "Poison Powder", "Sleep Powder",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(46, "Paras", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Effect-spore", "Dry-skin", "Damp",
	50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 5.4f,
	57, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Mushroom", "Growing out of the bug’s back are mushroomscalled tochukaso. The mushrooms growwith the bug host.",
	35, 70, 55, 45, 55, 25, 0, Color.clear,
	new int[] { 1, 13, 20, 27, 34, 41},
	new string[]
	{
		 "Scratch", "Stun Spore", "Leech Life", "Spore", "Slash", "Growth",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Mega_Drain", "Solar_Beam", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {47}, new string[] {"Level,24"}),


new PokemonData(47, "Parasect", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Effect-spore", "Dry-skin", "Damp",
	50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1f, 29.5f,
	142, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 1, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Mushroom", "A mushroom grown larger than the host’s bodycontrols Parasect. It scatters poisonous spores.",
	60, 95, 80, 60, 80, 30, 0, Color.clear,
	new int[] { 1, 1, 20, 30, 39, 48},
	new string[]
	{
		 "Scratch", "Stun Spore", "Leech Life", "Spore", "Slash", "Growth",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Mega_Drain", "Solar_Beam", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(48, "Venonat", PokemonData.Type.BUG, PokemonData.Type.POISON, "Compound-eyes", "Tinted-lens", "Run-away",
	50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1f, 30f,
	61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Insect", "Its big eyes are actually clusters of tiny eyes. At night, its kind is drawn by light.",
	60, 55, 50, 40, 55, 45, 0, Color.clear,
	new int[] { 1, 1, 24, 27, 30, 35, 38, 43},
	new string[]
	{
		 "Tackle", "Disable", "Poison Powder", "Leech Life", "Stun Spore", "Psybeam", "Sleep Powder", "Psychic",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Mega_Drain", "Solar_Beam", "Toxic", "Psychic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Psywave", "Rest", "Substitute"
	},
	new int[] {49}, new string[] {"Level,31"}),


new PokemonData(49, "Venomoth", PokemonData.Type.BUG, PokemonData.Type.POISON, "Shield-dust", "Tinted-lens", "Wonder-skin",
	50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.5f, 12.5f,
	158, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Moth", "The scales it scatters will paralyze anyone whotouches them, making that person unable to stand.",
	70, 65, 60, 90, 75, 90, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 38, 43, 50},
	new string[]
	{
		 "Tackle", "Disable", "Poison Powder", "Leech Life", "Psybeam", "Sleep Powder", "Psychic",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Take_Down", "Double_Edge", "Hyper_Beam", "Mega_Drain", "Solar_Beam", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Psywave", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(50, "Diglett", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", "Arena-trap", "Sand-force",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.2f, 0.8f,
	53, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Mole", "Lives about one yard underground where it feedson plant roots. It sometimes appears aboveground.",
	10, 55, 25, 35, 45, 95, 0, Color.clear,
	new int[] { 1, 15, 19, 24, 31, 40},
	new string[]
	{
		 "Scratch", "Growl", "Dig", "Sand Attack", "Slash", "Earthquake",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {51}, new string[] {"Level,26"}),


new PokemonData(51, "Dugtrio", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", "Arena-trap", "Sand-force",
	50f, 50, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 33.3f,
	149, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
	"Mole", "In battle, it digs through the ground and strikesthe unsuspecting foe from an unexpected direction.",
	35, 100, 50, 50, 70, 120, 0, Color.clear,
	new int[] { 1, 1, 1, 24},
	new string[]
	{
		 "Scratch", "Growl", "Dig", "Sand Attack",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(52, "Meowth", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Technician", "Unnerve",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 4.2f,
	58, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Scratch Cat", "It is nocturnal in nature. If it spots something shiny,its eyes glitter brightly.",
	40, 45, 35, 40, 40, 90, 0, Color.clear,
	new int[] { 1, 1, 12, 17, 24, 33, 44},
	new string[]
	{
		 "Scratch", "Growl", "Bite", "Pay Day", "Screech", "Fury Swipes", "Slash",
	},
	new string[]
	{
		 "Pay_Day", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Bubble_Beam", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {53}, new string[] {"Level,28"}),


new PokemonData(53, "Persian", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Limber", "Technician", "Unnerve",
	50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 32f,
	154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Classy Cat", "Although its fur has many admirers, it is toughto raise as a pet because of its fickle meanness.",
	65, 70, 60, 65, 65, 115, 0, Color.clear,
	new int[] { 1, 1, 1, 17, 51},
	new string[]
	{
		 "Scratch", "Bite", "Screech", "Pay Day", "Slash",
	},
	new string[]
	{
		 "Pay_Day", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Bubble_Beam", "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(54, "Psyduck", PokemonData.Type.WATER, PokemonData.Type.NONE, "Damp", "Cloud-nine", "Swift-swim",
	50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 19.6f,
	64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Duck", "It is constantly wracked by a headache. When the headache turns intense,it begins using mysterious powers.",
	50, 52, 48, 65, 50, 55, 0, Color.clear,
	new int[] { 1, 28, 31, 36, 43, 52},
	new string[]
	{
		 "Scratch", "Tail Whip", "Disable", "Confusion", "Fury Swipes", "Hydro Pump",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {55}, new string[] {"Level,33"}),


new PokemonData(55, "Golduck", PokemonData.Type.WATER, PokemonData.Type.NONE, "Damp", "Cloud-nine", "Swift-swim",
	50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 76.6f,
	175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Duck", "It appears by waterways at dusk. It may use telekinetic powersif its forehead glows mysteriously.",
	80, 82, 78, 95, 80, 85, 0, Color.clear,
	new int[] { 1, 1, 31, 39, 48, 59},
	new string[]
	{
		 "Scratch", "Tail Whip", "Disable", "Confusion", "Fury Swipes", "Hydro Pump",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(56, "Mankey", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Vital-spirit", "Anger-point", "Defiant",
	50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 28f,
	61, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Pig Monkey", "It’s unsafe to approach if it gets violently enragedfor no reason and can’t distinguish friendsfrom foes.",
	40, 80, 35, 35, 45, 70, 0, Color.clear,
	new int[] { 1, 1, 15, 21, 27, 33, 39},
	new string[]
	{
		 "Scratch", "Leer", "Karate Chop", "Fury Swipes", "Focus Energy", "Seismic Toss", "Thrash",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Swift", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {57}, new string[] {"Level,28"}),


new PokemonData(57, "Primeape", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Vital-spirit", "Anger-point", "Defiant",
	50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 32f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Pig Monkey", "It stops being angry only when nobody else isaround. To view this moment is very difficult.",
	65, 105, 60, 60, 70, 95, 0, Color.clear,
	new int[] { 1, 1, 1, 27, 37, 46},
	new string[]
	{
		 "Karate Chop", "Leer", "Fury Swipes", "Focus Energy", "Seismic Toss", "Thrash",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Swift", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(58, "Growlithe", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Intimidate", "Flash-fire", "Justified",
	75f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 19f,
	70, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Puppy", "Very friendly and faithful to people. It will try torepel enemies by barking and biting.",
	55, 70, 45, 70, 50, 60, 0, Color.clear,
	new int[] { 1, 1, 18, 23, 30, 39, 50},
	new string[]
	{
		 "Bite", "Roar", "Ember", "Leer", "Take Down", "Agility", "Flamethrower",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Dragon_Rage", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(59, "Arcanine", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Intimidate", "Flash-fire", "Justified",
	75f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.9f, 155f,
	194, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Legendary", "A Pokémon that has long been admired for itsbeauty. It runs agilely as if on wings.",
	90, 110, 80, 100, 80, 95, 0, Color.clear,
	new int[] { 1, 1, 1, 1},
	new string[]
	{
		 "Take Down", "Leer", "Roar", "Ember",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Dragon_Rage", "Dig", "Toxic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(60, "Poliwag", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", "Damp", "Swift-swim",
	50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 12.4f,
	60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
	"Tadpole", "Its slick black skin is thin and damp. A part of itsinternal organs can be seen through the skin as aspiral pattern.",
	40, 50, 40, 40, 40, 90, 0, Color.clear,
	new int[] { 1, 16, 19, 25, 31, 38, 45},
	new string[]
	{
		 "Bubble", "Hypnosis", "Water Gun", "Double Slap", "Body Slam", "Amnesia", "Hydro Pump",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Toxic", "Psychic", "Rage", "Mimic", "Double_Team", "Bide", "Skull_Bash", "Psywave", "Rest", "Substitute"
	},
	new int[] {61}, new string[] {"Level,25"}),


new PokemonData(61, "Poliwhirl", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", "Damp", "Swift-swim",
	50f, 120, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1f, 20f,
	135, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
	"Tadpole", "It can live in or out of water. When out of water,it constantly sweats to keep its body slimy.",
	65, 65, 65, 50, 50, 90, 0, Color.clear,
	new int[] { 1, 1, 1, 26, 33},
	new string[]
	{
		 "Water Gun", "Hypnosis", "Bubble", "Double Slap", "Body Slam",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Toxic", "Psychic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Skull_Bash", "Psywave", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(62, "Poliwrath", PokemonData.Type.WATER, PokemonData.Type.FIGHTING, "Water-absorb", "Damp", "Swift-swim",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.3f, 54f,
	230, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Tadpole", "With its extremely tough muscles, it can keepswimming in the Pacific Ocean without resting.",
	90, 95, 95, 70, 90, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 16},
	new string[]
	{
		 "Double Slap", "Body Slam", "Water Gun", "Hypnosis",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Toxic", "Psychic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Skull_Bash", "Psywave", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(63, "Abra", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", "Inner-focus", "Magic-guard",
	75f, 200, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.9f, 19.5f,
	62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Psi", "It sleeps for 18 hours a day. It uses a variety ofextrasensory powers even while asleep.",
	25, 20, 15, 105, 55, 90, 0, Color.clear,
	new int[] { 1},
	new string[]
	{
		 "Teleport",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Thunder_Wave", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {64}, new string[] {"Level,16"}),


new PokemonData(64, "Kadabra", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", "Inner-focus", "Magic-guard",
	75f, 100, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.3f, 56.5f,
	140, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Psi", "When it uses its psychic power, it emits strongalpha waves that can ruin precision devices.",
	40, 35, 30, 120, 70, 105, 0, Color.clear,
	new int[] { 1, 1, 1, 31, 42},
	new string[]
	{
		 "Disable", "Confusion", "Teleport", "Recover", "Reflect",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Thunder_Wave", "Dig", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(65, "Alakazam", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", "Inner-focus", "Magic-guard",
	75f, 50, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.5f, 48f,
	225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Psi", "Its brain cells multiply continually until it dies. As a result, it remembers everything.",
	55, 50, 45, 135, 95, 120, 0, Color.clear,
	new int[] { 1, 1, 1, 31, 42},
	new string[]
	{
		 "Disable", "Confusion", "Teleport", "Recover", "Reflect",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Thunder_Wave", "Dig", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(66, "Machop", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
	75f, 180, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.8f, 19.5f,
	61, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Superpower", "It hefts a Graveler repeatedly to strengthenits entire body. It uses every type of martial arts.",
	70, 80, 50, 35, 35, 35, 0, Color.clear,
	new int[] { 1, 20, 25, 32, 39, 46},
	new string[]
	{
		 "Karate Chop", "Low Kick", "Leer", "Focus Energy", "Seismic Toss", "Submission",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Fire_Blast", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {67}, new string[] {"Level,28"}),


new PokemonData(67, "Machoke", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
	75f, 90, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.5f, 70.5f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Superpower", "Its muscular body is so powerful, it must wear apower-save belt to be able to regulate its motions.",
	80, 100, 70, 50, 60, 45, 0, Color.clear,
	new int[] { 1, 1, 1, 36},
	new string[]
	{
		 "Karate Chop", "Leer", "Low Kick", "Focus Energy",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Fire_Blast", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(68, "Machamp", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
	75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.6f, 130f,
	227, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Superpower", "Its four ruggedly developed arms can launcha flurry of 1,000 punches in just two seconds.",
	90, 130, 80, 65, 85, 55, 0, Color.clear,
	new int[] { 1, 1, 1, 36},
	new string[]
	{
		 "Karate Chop", "Leer", "Low Kick", "Focus Energy",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Fire_Blast", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(69, "Bellsprout", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Gluttony",
	50f, 255, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.7f, 4f,
	60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Flower", "Even though its body is extremely skinny, it isblindingly fast when catching its prey.",
	50, 75, 35, 70, 30, 40, 0, Color.clear,
	new int[] { 1, 1, 13, 15, 18, 21, 26, 33, 42},
	new string[]
	{
		 "Vine Whip", "Growth", "Wrap", "Poison Powder", "Sleep Powder", "Stun Spore", "Acid", "Razor Leaf", "Slam",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Take_Down", "Double_Edge", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {70}, new string[] {"Level,21"}),


new PokemonData(70, "Weepinbell", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Gluttony",
	50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1f, 6.4f,
	137, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Flycatcher", "The leafy parts act as cutters for slashing foes. It spits a fluid that dissolves everything.",
	65, 90, 50, 85, 45, 55, 0, Color.clear,
	new int[] { 1, 1, 1, 15, 18, 23, 38, 49},
	new string[]
	{
		 "Vine Whip", "Wrap", "Growth", "Poison Powder", "Sleep Powder", "Stun Spore", "Razor Leaf", "Slam",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Take_Down", "Double_Edge", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(71, "Victreebel", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Gluttony",
	50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1.7f, 15.5f,
	221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Flycatcher", "Said to live in huge colonies deep in jungles,although no one has ever returned from there.",
	80, 105, 65, 100, 70, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 13, 15},
	new string[]
	{
		 "Acid", "Razor Leaf", "Stun Spore", "Sleep Powder", "Wrap", "Poison Powder",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(72, "Tentacool", PokemonData.Type.WATER, PokemonData.Type.POISON, "Clear-body", "Liquid-ooze", "Rain-dish",
	50f, 190, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.9f, 45.5f,
	67, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLUE, 70,
	"Jellyfish", "Its body is virtually composed of water. It shootsstrange beams from its crystal-like eyes.",
	40, 40, 35, 50, 100, 70, 0, Color.clear,
	new int[] { 1, 7, 13, 18, 22, 27, 33, 40, 48},
	new string[]
	{
		 "Acid", "Supersonic", "Wrap", "Poison Sting", "Water Gun", "Constrict", "Barrier", "Screech", "Hydro Pump",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Mega_Drain", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {73}, new string[] {"Level,30"}),


new PokemonData(73, "Tentacruel", PokemonData.Type.WATER, PokemonData.Type.POISON, "Clear-body", "Liquid-ooze", "Rain-dish",
	50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.6f, 55f,
	180, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLUE, 70,
	"Jellyfish", "The tentacles are normally kept short. On hunts,they are extended to ensnare and immobilize prey.",
	80, 70, 65, 80, 120, 100, 0, Color.clear,
	new int[] { 1, 1, 22, 27, 35, 43, 50},
	new string[]
	{
		 "Wrap", "Supersonic", "Water Gun", "Constrict", "Barrier", "Screech", "Hydro Pump",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Mega_Drain", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(74, "Geodude", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
	50f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.4f, 20f,
	60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Rock", "Found in fields and mountains. Mistaking them forboulders, people often step or trip on them.",
	40, 80, 100, 30, 30, 20, 0, Color.clear,
	new int[] { 1, 11, 16, 21, 26, 31, 36},
	new string[]
	{
		 "Tackle", "Defense Curl", "Rock Throw", "Self-Destruct", "Harden", "Earthquake", "Explosion",
	},
	new string[]
	{
		 "Mega_Punch", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Self_Destruct", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {75}, new string[] {"Level,25"}),


new PokemonData(75, "Graveler", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
	50f, 120, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 105f,
	137, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Rock", "With a free and uncaring nature, it doesn’t mindif pieces break off while it rolls down mountains.",
	55, 95, 115, 45, 45, 35, 0, Color.clear,
	new int[] { 1, 1, 16, 29, 36, 43},
	new string[]
	{
		 "Tackle", "Defense Curl", "Rock Throw", "Harden", "Earthquake", "Explosion",
	},
	new string[]
	{
		 "Mega_Punch", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Self_Destruct", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(76, "Golem", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
	50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.4f, 300f,
	223, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Megaton", "It tumbles down mountains, leaving groovesfrom peak to base. Stay clear of these grooves.",
	80, 120, 130, 55, 65, 45, 0, Color.clear,
	new int[] { 1, 1, 16, 29, 36, 43},
	new string[]
	{
		 "Tackle", "Defense Curl", "Rock Throw", "Harden", "Earthquake", "Explosion",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Self_Destruct", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(77, "Ponyta", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Run-away", "Flash-fire", "Flame-body",
	50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 30f,
	82, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Fire Horse", "As a newborn, it can barely stand. However, through galloping, itslegs are made tougher and faster.",
	50, 85, 55, 65, 65, 90, 0, Color.clear,
	new int[] { 1, 30, 32, 35, 39, 43, 48},
	new string[]
	{
		 "Ember", "Tail Whip", "Stomp", "Growl", "Fire Spin", "Take Down", "Agility",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {78}, new string[] {"Level,40"}),


new PokemonData(78, "Rapidash", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Run-away", "Flash-fire", "Flame-body",
	50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.7f, 95f,
	175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Fire Horse", "Very competitive, this Pokémon will chase anythingthat moves fast in the hopes of racing it.",
	65, 100, 70, 80, 80, 105, 0, Color.clear,
	new int[] { 1, 1, 1, 35, 39, 55},
	new string[]
	{
		 "Stomp", "Tail Whip", "Ember", "Growl", "Fire Spin", "Agility",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(79, "Slowpoke", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
	50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 36f,
	63, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Dopey", "It is always vacantly lost in thought, but no oneknows what it is thinking about. It is good at fishingwith its tail.",
	90, 65, 65, 40, 40, 15, 0, Color.clear,
	new int[] { 1, 18, 22, 27, 33, 40, 48},
	new string[]
	{
		 "Confusion", "Disable", "Headbutt", "Growl", "Water Gun", "Amnesia", "Psychic",
	},
	new string[]
	{
		 "Pay_Day", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Strength", "Thunder_Wave", "Earthquake", "Fissure", "Dig", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {80}, new string[] {"Level,37"}),


new PokemonData(80, "Slowbro", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
	50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.6f, 78.5f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Hermit Crab", "An attached Shellder won’t let go because ofthe tasty flavor that oozes out of its tail.",
	95, 75, 110, 100, 80, 30, 0, Color.clear,
	new int[] { 1, 1, 1, 37, 44, 55},
	new string[]
	{
		 "Headbutt", "Disable", "Confusion", "Withdraw", "Amnesia", "Psychic",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Thunder_Wave", "Earthquake", "Fissure", "Dig", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(81, "Magnemite", PokemonData.Type.ELECTRIC, PokemonData.Type.STEEL, "Magnet-pull", "Sturdy", "Analytic",
	112.5f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.3f, 6f,
	65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Magnet", "The units at the sides of its body generateantigravity energy to keep it aloft in the air.",
	25, 35, 70, 95, 55, 45, 0, Color.clear,
	new int[] { 1, 21, 25, 29, 35, 41, 47},
	new string[]
	{
		 "Tackle", "Sonic Boom", "Thunder Shock", "Supersonic", "Thunder Wave", "Swift", "Screech",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Flash", "Rest", "Substitute"
	},
	new int[] {82}, new string[] {"Level,30"}),


new PokemonData(82, "Magneton", PokemonData.Type.ELECTRIC, PokemonData.Type.STEEL, "Magnet-pull", "Sturdy", "Analytic",
	112.5f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 60f,
	163, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Magnet", "A linked cluster formed of several Magnemite. It discharges powerful magnetic waves athigh voltage.",
	50, 60, 95, 120, 70, 70, 0, Color.clear,
	new int[] { 1, 1, 25, 29, 38, 46, 54},
	new string[]
	{
		 "Tackle", "Sonic Boom", "Thunder Shock", "Supersonic", "Thunder Wave", "Swift", "Screech",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Flash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(83, "Farfetchd", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Inner-focus", "Defiant",
	50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.8f, 15f,
	132, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Wild Duck", "The plant stalk it holds is its weapon. The stalk isused like a sword to cut all sorts of things.",
	52, 90, 55, 58, 62, 60, 0, Color.clear,
	new int[] { 1, 1, 7, 15, 23, 31, 39},
	new string[]
	{
		 "Sand Attack", "Peck", "Leer", "Fury Attack", "Swords Dance", "Agility", "Slash",
	},
	new string[]
	{
		 "Razor_Wind", "Swords_Dance", "Cut", "Whirlwind", "Fly", "Body_Slam", "Take_Down", "Double_Edge", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(84, "Doduo", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Run-away", "Early-bird", "Tangled-feet",
	50f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.4f, 39.2f,
	62, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Twin Bird", "A two-headed Pokémon that was discovered as asudden mutation. It runs at a pace of over 60 milesper hour.",
	35, 85, 45, 35, 35, 75, 0, Color.clear,
	new int[] { 1, 20, 24, 30, 36, 40, 44},
	new string[]
	{
		 "Peck", "Growl", "Fury Attack", "Drill Peck", "Rage", "Tri Attack", "Agility",
	},
	new string[]
	{
		 "Whirlwind", "Fly", "Body_Slam", "Take_Down", "Double_Edge", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Sky_Attack", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {85}, new string[] {"Level,31"}),


new PokemonData(85, "Dodrio", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Run-away", "Early-bird", "Tangled-feet",
	50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.8f, 85.2f,
	165, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Triple Bird", "An enemy that takes its eyes off any of thethree heads--even for a second--will getpecked severely.",
	60, 110, 70, 60, 60, 110, 0, Color.clear,
	new int[] { 1, 1, 20, 30, 39, 45, 51},
	new string[]
	{
		 "Fury Attack", "Peck", "Growl", "Drill Peck", "Rage", "Tri Attack", "Agility",
	},
	new string[]
	{
		 "Whirlwind", "Fly", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Sky_Attack", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(86, "Seel", PokemonData.Type.WATER, PokemonData.Type.NONE, "Thick-fat", "Hydration", "Ice-body",
	50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.1f, 90f,
	65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.WHITE, 70,
	"Sea Lion", "A Pokémon that lives on icebergs. It swims in thesea using the point on its head to break up ice.",
	65, 45, 55, 45, 70, 45, 0, Color.clear,
	new int[] { 1, 30, 35, 40, 45, 50},
	new string[]
	{
		 "Headbutt", "Growl", "Aurora Beam", "Rest", "Take Down", "Ice Beam",
	},
	new string[]
	{
		 "Pay_Day", "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Strength", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {87}, new string[] {"Level,34"}),


new PokemonData(87, "Dewgong", PokemonData.Type.WATER, PokemonData.Type.ICE, "Thick-fat", "Hydration", "Ice-body",
	50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 120f,
	166, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.WHITE, 70,
	"Sea Lion", "Its body is covered with a pure white fur. The colder the weather, the more activeit becomes.",
	90, 70, 80, 70, 95, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 50},
	new string[]
	{
		 "Headbutt", "Growl", "Aurora Beam", "Take Down",
	},
	new string[]
	{
		 "Pay_Day", "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Strength", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(88, "Grimer", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Sticky-hold", "Poison-touch",
	50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.9f, 30f,
	65, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Sludge", "Sludge exposed to X-rays from the moontransformed into Grimer. It loves feedingon filthy things.",
	80, 80, 50, 40, 50, 25, 0, Color.clear,
	new int[] { 1, 1, 30, 33, 37, 42, 48, 55},
	new string[]
	{
		 "Pound", "Disable", "Poison Gas", "Minimize", "Sludge", "Harden", "Screech", "Acid Armor",
	},
	new string[]
	{
		 "Body_Slam", "Mega_Drain", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Self_Destruct", "Fire_Blast", "Explosion", "Rest", "Substitute"
	},
	new int[] {89}, new string[] {"Level,38"}),


new PokemonData(89, "Muk", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Sticky-hold", "Poison-touch",
	50f, 75, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 30f,
	175, PokemonData.LevelingRate.MEDIUMFAST, 1, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Sludge", "They love to gather in smelly areas where sludgeaccumulates, making the stench aroundthem worse.",
	105, 105, 75, 65, 100, 50, 0, Color.clear,
	new int[] { 1, 1, 1, 33, 37, 45, 53},
	new string[]
	{
		 "Pound", "Disable", "Poison Gas", "Minimize", "Sludge", "Harden", "Screech",
	},
	new string[]
	{
		 "Body_Slam", "Hyper_Beam", "Mega_Drain", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Self_Destruct", "Fire_Blast", "Explosion", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(90, "Shellder", PokemonData.Type.WATER, PokemonData.Type.NONE, "Shell-armor", "Skill-link", "Overcoat",
	50f, 190, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.3f, 4f,
	61, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Bivalve", "Its hard shell repels any kind of attack. It is vulnerable only when its shell is open.",
	30, 65, 100, 45, 25, 40, 0, Color.clear,
	new int[] { 1, 1, 18, 23, 30, 39, 50},
	new string[]
	{
		 "Tackle", "Withdraw", "Supersonic", "Clamp", "Aurora Beam", "Leer", "Ice Beam",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Toxic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Self_Destruct", "Swift", "Explosion", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(91, "Cloyster", PokemonData.Type.WATER, PokemonData.Type.ICE, "Shell-armor", "Skill-link", "Overcoat",
	50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.5f, 132.5f,
	184, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Bivalve", "Cloyster that live in seas with harsh tidal currentsgrow large, sharp spikes on their shells.",
	50, 95, 180, 85, 45, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 50},
	new string[]
	{
		 "Supersonic", "Aurora Beam", "Withdraw", "Clamp", "Spike Cannon",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Toxic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Self_Destruct", "Swift", "Explosion", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(92, "Gastly", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Levitate", null, null,
	50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.3f, 0.1f,
	62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Gas", "Its body is made of gas. Despite lacking substance,it can envelop an opponent of any size andcause suffocation.",
	30, 35, 30, 100, 35, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 27, 35},
	new string[]
	{
		 "Night Shade", "Confuse Ray", "Lick", "Hypnosis", "Dream Eater",
	},
	new string[]
	{
		 "Mega_Drain", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Rage", "Mimic", "Double_Team", "Bide", "Self_Destruct", "Dream_Eater", "Psywave", "Explosion", "Rest", "Substitute"
	},
	new int[] {93}, new string[] {"Level,25"}),


new PokemonData(93, "Haunter", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Levitate", null, null,
	50f, 90, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.6f, 0.1f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Gas", "If you get the feeling of being watched in darknesswhen nobody is around, Haunter is there.",
	45, 50, 45, 115, 55, 95, 0, Color.clear,
	new int[] { 1, 1, 1, 29, 38},
	new string[]
	{
		 "Night Shade", "Confuse Ray", "Lick", "Hypnosis", "Dream Eater",
	},
	new string[]
	{
		 "Mega_Drain", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Rage", "Mimic", "Double_Team", "Bide", "Self_Destruct", "Dream_Eater", "Psywave", "Explosion", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(94, "Gengar", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Cursed-body", null, null,
	50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.5f, 40.5f,
	225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Shadow", "It hides in shadows. It is said that if Gengaris hiding, it cools the area by nearly10 degrees Fahrenheit.",
	60, 65, 60, 130, 75, 110, 0, Color.clear,
	new int[] { 1, 1, 1, 29, 38},
	new string[]
	{
		 "Night Shade", "Confuse Ray", "Lick", "Hypnosis", "Dream Eater",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Mega_Drain", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Self_Destruct", "Skull_Bash", "Dream_Eater", "Psywave", "Explosion", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(95, "Onix", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Weak-armor",
	50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 8.8f, 210f,
	77, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Rock Snake", "Burrows at high speed in search of food. The tunnels it leaves are used as homesby Diglett.",
	35, 45, 160, 30, 45, 70, 0, Color.clear,
	new int[] { 1, 1, 15, 19, 25, 33, 43},
	new string[]
	{
		 "Tackle", "Screech", "Bind", "Rock Throw", "Rage", "Slam", "Harden",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Self_Destruct", "Skull_Bash", "Explosion", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(96, "Drowzee", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Insomnia", "Forewarn", "Inner-focus",
	50f, 190, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1f, 32.4f,
	66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Hypnosis", "Puts enemies to sleep, then eats their dreams. Occasionally gets sick from eating only bad dreams.",
	60, 48, 45, 43, 90, 42, 0, Color.clear,
	new int[] { 1, 1, 12, 17, 24, 29, 32, 37},
	new string[]
	{
		 "Pound", "Hypnosis", "Disable", "Confusion", "Headbutt", "Poison Gas", "Psychic", "Meditate",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Thunder_Wave", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Skull_Bash", "Dream_Eater", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {97}, new string[] {"Level,26"}),


new PokemonData(97, "Hypno", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Insomnia", "Forewarn", "Inner-focus",
	50f, 75, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.6f, 75.6f,
	169, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Hypnosis", "It carries a pendulum-like device. There oncewas an incident in which it took away a childit hypnotized.",
	85, 73, 70, 73, 115, 67, 0, Color.clear,
	new int[] { 1, 1, 1, 17, 24, 33, 37, 43},
	new string[]
	{
		 "Pound", "Disable", "Hypnosis", "Confusion", "Headbutt", "Poison Gas", "Psychic", "Meditate",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Thunder_Wave", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Skull_Bash", "Dream_Eater", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(98, "Krabby", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Sheer-force",
	50f, 225, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.4f, 6.5f,
	65, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"River Crab", "If it senses danger approaching, it cloaks itself withbubbles from its mouth so it will look bigger.",
	30, 105, 90, 25, 25, 50, 0, Color.clear,
	new int[] { 1, 1, 20, 25, 30, 35, 40},
	new string[]
	{
		 "Leer", "Bubble", "Vice Grip", "Guillotine", "Stomp", "Crabhammer", "Harden",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Strength", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Rest", "Substitute"
	},
	new int[] {99}, new string[] {"Level,28"}),


new PokemonData(99, "Kingler", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Sheer-force",
	50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.3f, 60f,
	166, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Pincer", "Its large and hard pincer has 10,000-horsepowerstrength. However, being so big, it is unwieldyto move.",
	55, 130, 115, 50, 50, 75, 0, Color.clear,
	new int[] { 1, 1, 1, 34, 42, 49},
	new string[]
	{
		 "Vice Grip", "Leer", "Bubble", "Stomp", "Crabhammer", "Harden",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Strength", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(100, "Voltorb", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Soundproof", "Static", "Aftermath",
	112.5f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.5f, 10.4f,
	66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Ball", "It was discovered when Poké Balls wereintroduced. It is said that there issome connection.",
	40, 30, 50, 55, 55, 100, 0, Color.clear,
	new int[] { 1, 1, 17, 22, 29, 36, 43},
	new string[]
	{
		 "Tackle", "Screech", "Sonic Boom", "Self-Destruct", "Light Screen", "Swift", "Explosion",
	},
	new string[]
	{
		 "Take_Down", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Self_Destruct", "Swift", "Flash", "Explosion", "Rest", "Substitute"
	},
	new int[] {101}, new string[] {"Level,30"}),


new PokemonData(101, "Electrode", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Soundproof", "Static", "Aftermath",
	112.5f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.2f, 66.6f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.RED, 70,
	"Ball", "It explodes in response to even minor stimuli. It isfeared, with the nickname of “The Bomb Ball. ",
	60, 50, 70, 80, 80, 150, 0, Color.clear,
	new int[] { 1, 1, 22, 29, 40, 50},
	new string[]
	{
		 "Tackle", "Sonic Boom", "Self-Destruct", "Light Screen", "Swift", "Explosion",
	},
	new string[]
	{
		 "Take_Down", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Self_Destruct", "Swift", "Skull_Bash", "Flash", "Explosion", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(102, "Exeggcute", PokemonData.Type.GRASS, PokemonData.Type.PSYCHIC, "Chlorophyll", null, "Harvest",
	50f, 90, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 2.5f,
	65, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Egg", "Its six eggs converse using telepathy. They canquickly gather if they become separated.",
	60, 40, 80, 60, 45, 40, 0, Color.clear,
	new int[] { 1, 1, 25, 28, 32, 37, 42, 48},
	new string[]
	{
		 "Hypnosis", "Barrage", "Reflect", "Leech Seed", "Stun Spore", "Poison Powder", "Solar Beam", "Sleep Powder",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Self_Destruct", "Egg_Bomb", "Psywave", "Explosion", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(103, "Exeggutor", PokemonData.Type.GRASS, PokemonData.Type.PSYCHIC, "Chlorophyll", null, "Harvest",
	50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 2f, 120f,
	186, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Coconut", "Its three heads think independently. However,they are friendly and never appear to squabble.",
	95, 95, 85, 125, 75, 55, 0, Color.clear,
	new int[] { 1, 1, 28},
	new string[]
	{
		 "Hypnosis", "Barrage", "Stomp",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Hyper_Beam", "Strength", "Mega_Drain", "Solar_Beam", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Self_Destruct", "Egg_Bomb", "Psywave", "Explosion", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(104, "Cubone", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Rock-head", "Lightning-rod", "Battle-armor",
	50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 6.5f,
	64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Lonely", "It wears the skull of its dead mother on its head. When it becomes lonesome, it is said to cry loudly.",
	50, 50, 95, 40, 50, 35, 0, Color.clear,
	new int[] { 1, 1, 25, 31, 38, 43, 46},
	new string[]
	{
		 "Growl", "Bone Club", "Leer", "Focus Energy", "Thrash", "Bonemerang", "Rage",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {105}, new string[] {"Level,28"}),


new PokemonData(105, "Marowak", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Rock-head", "Lightning-rod", "Battle-armor",
	50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 45f,
	149, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Bone Keeper", "It is small and was originally very weak. Its temperament turned ferocious when it beganusing bones.",
	60, 80, 110, 50, 80, 45, 0, Color.clear,
	new int[] { 1, 1, 41, 48, 55},
	new string[]
	{
		 "Leer", "Focus Energy", "Thrash", "Bonemerang", "Rage",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {106}, new string[] {"Level,20"}),


new PokemonData(106, "Hitmonlee", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Limber", "Reckless", "Unburden",
	100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.5f, 49.8f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Kicking", "The legs freely contract and stretch. The stretchylegs allow it to hit a distant foe with a rising kick.",
	50, 120, 53, 35, 110, 87, 0, Color.clear,
	new int[] { 1, 1, 33, 38, 43, 48, 53},
	new string[]
	{
		 "Double Kick", "Meditate", "Rolling Kick", "Jump Kick", "Focus Energy", "High Jump Kick", "Mega Kick",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Strength", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {107}, new string[] {"Level,20"}),


new PokemonData(107, "Hitmonchan", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Keen-eye", "Iron-fist", "Inner-focus",
	100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 50.2f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BROWN, 70,
	"Punching", "The arm-twisting punches it throws pulverize evenconcrete. It rests after three minutes of fighting.",
	50, 105, 79, 35, 110, 76, 0, Color.clear,
	new int[] { 1, 1, 33, 38, 43, 48, 53},
	new string[]
	{
		 "Comet Punch", "Agility", "Fire Punch", "Ice Punch", "Thunder Punch", "Mega Punch", "Counter",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Submission", "Counter", "Seismic_Toss", "Strength", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Metronome", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(108, "Lickitung", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Own-tempo", "Oblivious", "Cloud-nine",
	50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 65.5f,
	77, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Licking", "Its long tongue, slathered with a gooey saliva,sticks to anything, so it is very useful.",
	90, 55, 75, 60, 75, 30, 0, Color.clear,
	new int[] { 1, 1, 7, 15, 23, 31, 39},
	new string[]
	{
		 "Wrap", "Supersonic", "Stomp", "Disable", "Defense Curl", "Slam", "Screech",
	},
	new string[]
	{
		 "Mega_Punch", "Swords_Dance", "Cut", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Fissure", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(109, "Koffing", PokemonData.Type.POISON, PokemonData.Type.NONE, "Levitate", null, null,
	50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 1f,
	68, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Gas", "Its thin, balloon-like body is inflated by horriblytoxic gases. It reeks when it is nearby.",
	40, 65, 95, 60, 45, 35, 0, Color.clear,
	new int[] { 1, 1, 32, 37, 40, 45, 48},
	new string[]
	{
		 "Tackle", "Smog", "Sludge", "Smokescreen", "Self-Destruct", "Haze", "Explosion",
	},
	new string[]
	{
		 "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Self_Destruct", "Fire_Blast", "Explosion", "Rest", "Substitute"
	},
	new int[] {110}, new string[] {"Level,35"}),


new PokemonData(110, "Weezing", PokemonData.Type.POISON, PokemonData.Type.NONE, "Levitate", null, null,
	50f, 60, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 9.5f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Gas", "If one of the twin Koffing inflates, the other onedeflates. It constantly mixes its poisonous gases.",
	65, 90, 120, 85, 70, 60, 0, Color.clear,
	new int[] { 1, 1, 1, 39, 43, 49},
	new string[]
	{
		 "Tackle", "Smog", "Sludge", "Smokescreen", "Self-Destruct", "Haze",
	},
	new string[]
	{
		 "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Self_Destruct", "Fire_Blast", "Explosion", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(111, "Rhyhorn", PokemonData.Type.GROUND, PokemonData.Type.ROCK, "Lightning-rod", "Rock-head", "Reckless",
	50f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1f, 115f,
	69, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Spikes", "Strong, but not too bright, this Pokémon canshatter even a skyscraper with its charging Tackles.",
	80, 85, 95, 30, 30, 25, 0, Color.clear,
	new int[] { 1, 30, 35, 40, 45, 50, 55},
	new string[]
	{
		 "Horn Attack", "Stomp", "Tail Whip", "Fury Attack", "Horn Drill", "Leer", "Take Down",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {112}, new string[] {"Level,42"}),


new PokemonData(112, "Rhydon", PokemonData.Type.GROUND, PokemonData.Type.ROCK, "Lightning-rod", "Rock-head", "Reckless",
	50f, 60, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1.9f, 120f,
	170, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Drill", "Protected by an armor-like hide, it is capable ofliving in molten lava of 3,600 degrees Fahrenheit.",
	105, 130, 120, 45, 45, 40, 0, Color.clear,
	new int[] { 1, 1, 1, 64},
	new string[]
	{
		 "Stomp", "Fury Attack", "Tail Whip", "Take Down",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Fissure", "Dig", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(113, "Chansey", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Natural-cure", "Serene-grace", "Healer",
	0f, 30, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.1f, 34.6f,
	395, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
	"Egg", "It is said to deliver happiness. Being compassionate, it shares its eggswith injured people.",
	250, 5, 5, 35, 105, 50, 0, Color.clear,
	new int[] { 1, 1, 24, 30, 38, 44, 48, 54},
	new string[]
	{
		 "Pound", "Double Slap", "Sing", "Growl", "Minimize", "Defense Curl", "Light Screen", "Double-Edge",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Egg_Bomb", "Fire_Blast", "Skull_Bash", "Soft_Boiled", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(114, "Tangela", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Leaf-guard", "Regenerator",
	50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1f, 35f,
	87, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Vine", "Many writhing vines cover it, so its true identityremains unknown. The blue vines grow its wholelife long.",
	65, 55, 115, 100, 40, 60, 0, Color.clear,
	new int[] { 1, 1, 29, 32, 36, 39, 45, 49},
	new string[]
	{
		 "Bind", "Constrict", "Absorb", "Poison Powder", "Stun Spore", "Sleep Powder", "Slam", "Growth",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Mega_Drain", "Solar_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(115, "Kangaskhan", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Early-bird", "Scrappy", "Inner-focus",
	0f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.2f, 80f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Parent", "It raises its offspring in its belly pouch. It lets thebaby out to play only when it feels safe.",
	105, 95, 80, 40, 80, 90, 0, Color.clear,
	new int[] { 1, 1, 26, 31, 36, 41, 46},
	new string[]
	{
		 "Comet Punch", "Rage", "Bite", "Tail Whip", "Mega Punch", "Leer", "Dizzy Punch",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Fissure", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(116, "Horsea", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Sniper", "Damp",
	50f, 225, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 8f,
	59, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Dragon", "Known to shoot down flying bugs with precisionblasts of ink from the surface of the water.",
	30, 40, 70, 70, 25, 60, 0, Color.clear,
	new int[] { 1, 19, 24, 30, 37, 45},
	new string[]
	{
		 "Bubble", "Smokescreen", "Leer", "Water Gun", "Agility", "Hydro Pump",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {117}, new string[] {"Level,32"}),


new PokemonData(117, "Seadra", PokemonData.Type.WATER, PokemonData.Type.NONE, "Poison-point", "Sniper", "Damp",
	50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 25f,
	154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Dragon", "Its body bristles with sharp spikes. Carelessly tryingto touch it could cause fainting from the spikes.",
	55, 65, 95, 95, 45, 85, 0, Color.clear,
	new int[] { 1, 24, 30, 41, 52},
	new string[]
	{
		 "Smokescreen", "Leer", "Water Gun", "Agility", "Hydro Pump",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(118, "Goldeen", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Water-veil", "Lightning-rod",
	50f, 225, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 0.6f, 15f,
	64, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Goldfish", "It swims at a steady 5 knots. If it senses danger,it will strike back with its sharp horn.",
	45, 67, 60, 35, 50, 63, 0, Color.clear,
	new int[] { 1, 1, 19, 24, 30, 37, 45, 54},
	new string[]
	{
		 "Tail Whip", "Peck", "Supersonic", "Horn Attack", "Fury Attack", "Waterfall", "Horn Drill", "Agility",
	},
	new string[]
	{
		 "Horn_Drill", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {119}, new string[] {"Level,33"}),


new PokemonData(119, "Seaking", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Water-veil", "Lightning-rod",
	50f, 60, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 1.3f, 39f,
	158, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Goldfish", "In the autumn spawning season, they can be seenswimming powerfully up rivers and creeks.",
	80, 92, 65, 65, 80, 68, 0, Color.clear,
	new int[] { 1, 1, 24, 30, 39, 48, 54},
	new string[]
	{
		 "Tail Whip", "Supersonic", "Horn Attack", "Fury Attack", "Waterfall", "Horn Drill", "Agility",
	},
	new string[]
	{
		 "Horn_Drill", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(120, "Staryu", PokemonData.Type.WATER, PokemonData.Type.NONE, "Illuminate", "Natural-cure", "Analytic",
	112.5f, 225, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.8f, 34.5f,
	68, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Star Shape", "Even if its body is torn, it can regenerate as long asthe glowing central core remains intact.",
	30, 45, 55, 70, 55, 85, 0, Color.clear,
	new int[] { 1, 17, 22, 27, 32, 37, 42, 47},
	new string[]
	{
		 "Tackle", "Water Gun", "Harden", "Recover", "Swift", "Minimize", "Light Screen", "Hydro Pump",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(121, "Starmie", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Illuminate", "Natural-cure", "Analytic",
	112.5f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.1f, 80f,
	182, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
	"Mysterious", "Its central core glows with the seven colors of therainbow. Some people value the core as a gem.",
	60, 75, 85, 100, 85, 115, 0, Color.clear,
	new int[] { 1, 1, 1},
	new string[]
	{
		 "Tackle", "Water Gun", "Harden",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(122, "Mr-mime", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Soundproof", "Filter", "Technician",
	50f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.3f, 54.5f,
	161, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PINK, 70,
	"Barrier", "Emanations from its fingertips solidify the air intoinvisible walls that repel even harsh attacks.",
	40, 45, 65, 100, 120, 90, 0, Color.clear,
	new int[] { 1, 1, 23, 31, 47},
	new string[]
	{
		 "Confusion", "Barrier", "Light Screen", "Double Slap", "Substitute",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Skull_Bash", "Flash", "Psywave", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(123, "Scyther", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", "Technician", "Steadfast",
	50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.5f, 56f,
	100, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Mantis", "It tears and shreds prey with its wickedly sharpscythes. It very rarely spreads its wings to fly.",
	70, 110, 80, 55, 80, 105, 0, Color.clear,
	new int[] { 1, 17, 20, 24, 29, 35, 42},
	new string[]
	{
		 "Quick Attack", "Leer", "Focus Energy", "Double Team", "Slash", "Swords Dance", "Agility",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Take_Down", "Double_Edge", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {124}, new string[] {"Level,30"}),


new PokemonData(124, "Jynx", PokemonData.Type.ICE, PokemonData.Type.PSYCHIC, "Oblivious", "Forewarn", "Dry-skin",
	0f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 40.6f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Human Shape", "It wiggles its hips as it walks. It cancause people to dance in unison with it.",
	65, 50, 35, 115, 95, 95, 0, Color.clear,
	new int[] { 1, 1, 18, 23, 31, 39, 47, 58},
	new string[]
	{
		 "Pound", "Lovely Kiss", "Lick", "Double Slap", "Ice Punch", "Body Slam", "Thrash", "Blizzard",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Skull_Bash", "Psywave", "Rest", "Substitute"
	},
	new int[] {125}, new string[] {"Level,30"}),


new PokemonData(125, "Electabuzz", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Vital-spirit",
	75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.1f, 30f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Electric", "Electricity runs across the surface of its body. In darkness, its entire body glows a whitish blue.",
	65, 83, 57, 95, 85, 105, 0, Color.clear,
	new int[] { 1, 1, 34, 37, 42, 49, 54},
	new string[]
	{
		 "Leer", "Quick Attack", "Thunder Shock", "Screech", "Thunder Punch", "Light Screen", "Thunder",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Swift", "Skull_Bash", "Flash", "Psywave", "Rest", "Substitute"
	},
	new int[] {126}, new string[] {"Level,30"}),


new PokemonData(126, "Magmar", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flame-body", null, "Vital-spirit",
	75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.3f, 44.5f,
	173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Spitfire", "Found near the mouth of a volcano. This fire-breather’s body temperature isnearly 2,200 degrees Fahrenheit.",
	65, 95, 57, 100, 85, 93, 0, Color.clear,
	new int[] { 1, 36, 39, 43, 48, 52, 55},
	new string[]
	{
		 "Ember", "Leer", "Confuse Ray", "Fire Punch", "Smokescreen", "Smog", "Flamethrower",
	},
	new string[]
	{
		 "Mega_Punch", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Bide", "Metronome", "Fire_Blast", "Skull_Bash", "Psywave", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(127, "Pinsir", PokemonData.Type.BUG, PokemonData.Type.NONE, "Hyper-cutter", "Mold-breaker", "Moxie",
	50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.5f, 55f,
	175, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Stag Beetle", "It grips prey with its pincers until the prey is tornin half. What it can’t tear, it tosses far.",
	65, 125, 100, 55, 70, 85, 0, Color.clear,
	new int[] { 1, 25, 30, 36, 43, 49, 54},
	new string[]
	{
		 "Vice Grip", "Seismic Toss", "Guillotine", "Focus Energy", "Harden", "Slash", "Swords Dance",
	},
	new string[]
	{
		 "Swords_Dance", "Cut", "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Submission", "Seismic_Toss", "Strength", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(128, "Tauros", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Intimidate", "Anger-point", "Sheer-force",
	100f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 88.4f,
	172, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Wild Bull", "After heightening its will to fight by whipping itselfwith its three tails, it charges at full speed.",
	75, 100, 95, 40, 70, 110, 0, Color.clear,
	new int[] { 1, 21, 28, 35, 44, 51},
	new string[]
	{
		 "Tackle", "Stomp", "Tail Whip", "Leer", "Rage", "Take Down",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Fissure", "Toxic", "Rage", "Mimic", "Double_Team", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(129, "Magikarp", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Rattled",
	50f, 255, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 0.9f, 10f,
	40, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Fish", "It is virtually worthless in terms of both power andspeed. It is the most weak and pathetic Pokémonin the world.",
	20, 10, 55, 15, 20, 80, 0, Color.clear,
	new int[] { 1, 15},
	new string[]
	{
		 "Splash", "Tackle",
	},
	new string[]
	{
		
	},
	new int[] {130}, new string[] {"Level,20"}),


new PokemonData(130, "Gyarados", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Intimidate", null, "Moxie",
	50f, 45, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 6.5f, 235f,
	189, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Atrocious", "In ancient literature, there is a record of a Gyaradosthat razed a village when violence flared.",
	95, 125, 79, 60, 100, 81, 0, Color.clear,
	new int[] { 1, 1, 1, 20},
	new string[]
	{
		 "Leer", "Hydro Pump", "Dragon Rage", "Bite",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Strength", "Dragon_Rage", "Thunderbolt", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(131, "Lapras", PokemonData.Type.WATER, PokemonData.Type.ICE, "Water-absorb", "Shell-armor", "Hydration",
	50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.5f, 220f,
	187, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Transport", "They have gentle hearts. Because they rarelyfight, many have been caught. Their numberhas dwindled.",
	130, 85, 80, 85, 95, 60, 0, Color.clear,
	new int[] { 1, 1, 16, 20, 25, 31, 38, 46},
	new string[]
	{
		 "Growl", "Water Gun", "Sing", "Mist", "Body Slam", "Confuse Ray", "Ice Beam", "Hydro Pump",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Strength", "Solar_Beam", "Dragon_Rage", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Psywave", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(132, "Ditto", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Limber", null, "Imposter",
	112.5f, 35, PokemonData.EggGroup.DITTO, PokemonData.EggGroup.DITTO, 0, 0.3f, 4f,
	101, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Transform", "It has the ability to reconstitute its entire cellularstructure to transform into whatever it sees.",
	48, 48, 48, 48, 48, 48, 0, Color.clear,
	new int[] { 1},
	new string[]
	{
		 "Transform",
	},
	new string[]
	{
		
	},
	new int[] {}, new string[] {}),


new PokemonData(133, "Eevee", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Adaptability", "Anticipation",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.3f, 6.5f,
	65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BROWN, 70,
	"Evolution", "A rare Pokémon that adapts to harsh environmentsby taking on different evolutionary forms.",
	55, 55, 50, 45, 65, 55, 0, Color.clear,
	new int[] { 1, 1, 27, 31, 37, 45},
	new string[]
	{
		 "Sand Attack", "Tackle", "Quick Attack", "Tail Whip", "Bite", "Take Down",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(134, "Vaporeon", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", null, "Hydration",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 29f,
	184, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Bubble Jet", "It prefers beautiful shores. With cells similar towater molecules, it could melt in water.",
	130, 65, 60, 110, 95, 65, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 37, 40, 42, 48},
	new string[]
	{
		 "Sand Attack", "Tackle", "Water Gun", "Quick Attack", "Tail Whip", "Bite", "Acid Armor", "Mist",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(135, "Jolteon", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Volt-absorb", null, "Quick-feet",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 24.5f,
	184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Lightning", "Every hair on its body starts to stand sharply onend if it becomes charged with electricity.",
	65, 65, 60, 110, 95, 130, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 37, 42, 44, 48, 54},
	new string[]
	{
		 "Sand Attack", "Tackle", "Thunder Shock", "Quick Attack", "Tail Whip", "Double Kick", "Agility", "Pin Missile", "Thunder",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Flash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(136, "Flareon", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Guts",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 25f,
	184, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Flame", "It has a flame sac in its body. Its body temperaturetops 1,650 degrees Fahrenheit before battle.",
	65, 130, 60, 95, 110, 65, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 37, 40, 42, 44},
	new string[]
	{
		 "Sand Attack", "Tackle", "Ember", "Quick Attack", "Tail Whip", "Bite", "Leer", "Fire Spin",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(137, "Porygon", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Trace", "Download", "Analytic",
	112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.8f, 36.5f,
	79, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Virtual", "A man-made Pokémon that came aboutas a result of research. It is programmedwith only basic motions.",
	65, 60, 70, 85, 75, 40, 0, Color.clear,
	new int[] { 1, 1, 1, 23, 28, 35, 42},
	new string[]
	{
		 "Tackle", "Sharpen", "Conversion", "Psybeam", "Recover", "Agility", "Tri Attack",
	},
	new string[]
	{
		 "Take_Down", "Double_Edge", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(138, "Omanyte", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Shell-armor", "Weak-armor",
	87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 7.5f,
	71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Spiral", "A prehistoric Pokémon that lived in the primordialsea, it swims by twisting its 10 tentacles about.",
	35, 40, 100, 90, 55, 35, 0, Color.clear,
	new int[] { 1, 1, 34, 39, 46, 53},
	new string[]
	{
		 "Water Gun", "Withdraw", "Horn Attack", "Leer", "Spike Cannon", "Hydro Pump",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {139}, new string[] {"Level,40"}),


new PokemonData(139, "Omastar", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Shell-armor", "Weak-armor",
	87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1f, 35f,
	173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Spiral", "Its tentacles are highly developed as if they arehands and feet. As soon as it ensnares prey,it bites.",
	70, 60, 125, 115, 70, 55, 0, Color.clear,
	new int[] { 1, 1, 1, 44, 49},
	new string[]
	{
		 "Horn Attack", "Water Gun", "Withdraw", "Spike Cannon", "Hydro Pump",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Seismic_Toss", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(140, "Kabuto", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Battle-armor", "Weak-armor",
	87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 11.5f,
	71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Shellfish", "It is thought to have inhabited beaches 300 millionyears ago. It is protected by a stiff shell.",
	30, 80, 90, 55, 45, 55, 0, Color.clear,
	new int[] { 1, 1, 34, 39, 44, 49},
	new string[]
	{
		 "Scratch", "Harden", "Absorb", "Slash", "Leer", "Hydro Pump",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Rest", "Substitute"
	},
	new int[] {141}, new string[] {"Level,40"}),


new PokemonData(141, "Kabutops", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Battle-armor", "Weak-armor",
	87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.3f, 40.5f,
	173, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Shellfish", "In the water, it tucks in its limbs to become morecompact, then it wiggles its shell to swim fast.",
	60, 115, 105, 65, 70, 80, 0, Color.clear,
	new int[] { 1, 1, 39, 46, 53},
	new string[]
	{
		 "Scratch", "Absorb", "Slash", "Leer", "Hydro Pump",
	},
	new string[]
	{
		 "Razor_Wind", "Swords_Dance", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Seismic_Toss", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(142, "Aerodactyl", PokemonData.Type.ROCK, PokemonData.Type.FLYING, "Rock-head", "Pressure", "Unnerve",
	87.5f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.8f, 59f,
	180, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
	"Fossil", "It was regenerated from a dinosaur’s geneticmatter that was found in amber. It flies withhigh-pitched cries.",
	80, 105, 65, 60, 75, 130, 0, Color.clear,
	new int[] { 1, 1, 33, 38, 45, 54},
	new string[]
	{
		 "Wing Attack", "Agility", "Supersonic", "Bite", "Take Down", "Hyper Beam",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Fly", "Take_Down", "Double_Edge", "Hyper_Beam", "Dragon_Rage", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Sky_Attack", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(143, "Snorlax", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Immunity", "Thick-fat", "Gluttony",
	87.5f, 25, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.1f, 460f,
	189, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
	"Sleeping", "It is not satisfied unless it eats over 880 pounds offood every day. When it is done eating, it goespromptly to sleep.",
	160, 110, 65, 65, 110, 30, 0, Color.clear,
	new int[] { 1, 1, 1, 35, 41, 48, 56},
	new string[]
	{
		 "Headbutt", "Amnesia", "Rest", "Body Slam", "Harden", "Double-Edge", "Hyper Beam",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Fissure", "Toxic", "Psychic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Self_Destruct", "Fire_Blast", "Skull_Bash", "Psywave", "Rest", "Rock_Slide", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(144, "Articuno", PokemonData.Type.ICE, PokemonData.Type.FLYING, "Pressure", null, "Snow-cloak",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.7f, 55.4f,
	261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.BLUE, 35,
	"Freeze", "A legendary bird Pokémon. It can create blizzardsby freezing moisture in the air.",
	90, 85, 100, 95, 125, 85, 0, Color.clear,
	new int[] { 1, 1, 51, 55, 60},
	new string[]
	{
		 "Ice Beam", "Peck", "Blizzard", "Agility", "Mist",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Fly", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Sky_Attack", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(145, "Zapdos", PokemonData.Type.ELECTRIC, PokemonData.Type.FLYING, "Pressure", null, "Static",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.6f, 52.6f,
	261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
	"Electric", "A legendary bird Pokémon that is said toappear from clouds while dropping enormouslightning bolts.",
	90, 90, 85, 125, 90, 100, 0, Color.clear,
	new int[] { 1, 1, 51, 55, 60},
	new string[]
	{
		 "Drill Peck", "Thunder Shock", "Thunder", "Agility", "Light Screen",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Fly", "Take_Down", "Double_Edge", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Swift", "Sky_Attack", "Flash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(146, "Moltres", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Pressure", null, "Flame-body",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 60f,
	261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
	"Flame", "It is said to be the legendary bird Pokémon of fire. Every flap of its wings creates a dazzling flareof flames.",
	90, 100, 90, 125, 85, 90, 0, Color.clear,
	new int[] { 1, 1, 51, 55, 60},
	new string[]
	{
		 "Peck", "Fire Spin", "Leer", "Agility", "Sky Attack",
	},
	new string[]
	{
		 "Razor_Wind", "Whirlwind", "Fly", "Take_Down", "Double_Edge", "Hyper_Beam", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Sky_Attack", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(147, "Dratini", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Shed-skin", null, "Marvel-scale",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.8f, 3.3f,
	60, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
	"Dragon", "It is called the “Mirage Pokémon” because so fewhave seen it. Its shed skin has been found.",
	41, 64, 45, 50, 50, 50, 0, Color.clear,
	new int[] { 1, 1, 10, 20, 30, 40, 50},
	new string[]
	{
		 "Wrap", "Leer", "Thunder Wave", "Agility", "Slam", "Dragon Rage", "Hyper Beam",
	},
	new string[]
	{
		 "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Dragon_Rage", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {148}, new string[] {"Level,30"}),


new PokemonData(148, "Dragonair", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Shed-skin", null, "Marvel-scale",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 4f, 16.5f,
	147, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
	"Dragon", "Its crystalline orbs appear to give this Pokémonthe power to freely control the weather.",
	61, 84, 65, 70, 70, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 35, 45, 55},
	new string[]
	{
		 "Wrap", "Leer", "Thunder Wave", "Slam", "Dragon Rage", "Hyper Beam",
	},
	new string[]
	{
		 "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Dragon_Rage", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {149}, new string[] {"Level,55"}),


new PokemonData(149, "Dragonite", PokemonData.Type.DRAGON, PokemonData.Type.FLYING, "Inner-focus", null, "Multiscale",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 2.2f, 210f,
	270, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 35,
	"Dragon", "It can fly in spite of its big and bulky physique. It circles the globe in just 16 hours.",
	91, 134, 95, 100, 100, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 20, 35, 45, 60},
	new string[]
	{
		 "Wrap", "Leer", "Thunder Wave", "Agility", "Slam", "Dragon Rage", "Hyper Beam",
	},
	new string[]
	{
		 "Razor_Wind", "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Strength", "Dragon_Rage", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Rage", "Mimic", "Double_Team", "Reflect", "Bide", "Fire_Blast", "Swift", "Skull_Bash", "Rest", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(150, "Mewtwo", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Pressure", null, "Unnerve",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 122f,
	306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.PURPLE, 0,
	"Genetic", "It was created by a scientist after years of horrificgene-splicing and DNA-engineering experiments.",
	106, 110, 90, 154, 90, 130, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 63, 75, 81},
	new string[]
	{
		 "Disable", "Confusion", "Psychic", "Swift", "Barrier", "Mist", "Amnesia",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Mega_Kick", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Self_Destruct", "Fire_Blast", "Skull_Bash", "Flash", "Psywave", "Rest", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {}),


new PokemonData(151, "Mew", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", null, null,
	112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.4f, 4f,
	270, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 100,
	"New Species", "Because it can use all kinds of moves, manyscientists believe Mew to be the ancestorof Pokémon.",
	100, 100, 100, 100, 100, 100, 0, Color.clear,
	new int[] { 1, 10, 20, 30, 40},
	new string[]
	{
		 "Pound", "Transform", "Mega Punch", "Metronome", "Psychic",
	},
	new string[]
	{
		 "Mega_Punch", "Pay_Day", "Razor_Wind", "Swords_Dance", "Cut", "Whirlwind", "Fly", "Mega_Kick", "Horn_Drill", "Body_Slam", "Take_Down", "Double_Edge", "Water_Gun", "Surf", "Ice_Beam", "Blizzard", "Bubble_Beam", "Hyper_Beam", "Submission", "Counter", "Seismic_Toss", "Strength", "Mega_Drain", "Solar_Beam", "Dragon_Rage", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Fissure", "Dig", "Toxic", "Psychic", "Rage", "Teleport", "Mimic", "Double_Team", "Reflect", "Bide", "Metronome", "Self_Destruct", "Egg_Bomb", "Fire_Blast", "Swift", "Skull_Bash", "Soft_Boiled", "Dream_Eater", "Sky_Attack", "Flash", "Psywave", "Explosion", "Rest", "Rock_Slide", "Tri_Attack", "Substitute"
	},
	new int[] {}, new string[] {})
    };

    private static int[] expTableErratic = new int[]
    {
        0, 15, 52, 122, 237, 406, 637, 942, 1326, 1800,
        2369, 3041, 3822, 4719, 5737, 6881, 8155, 9564, 11111, 12800,
        14632, 16610, 18737, 21012, 23437, 26012, 28737, 31610, 34632, 37800,
        41111, 44564, 48155, 51881, 55737, 59719, 63822, 68041, 72369, 76800,
        81326, 85942, 90637, 95406, 100237, 105122, 110052, 115105, 120001, 125000,
        131324, 137795, 144410, 151165, 158056, 165079, 172229, 179503, 186894, 194400,
        202013, 209728, 217540, 225443, 233431, 241496, 249633, 257834, 267406, 276458,
        286328, 296358, 305767, 316074, 326531, 336255, 346965, 357812, 567807, 378880,
        390077, 400293, 411686, 423190, 433572, 445239, 457001, 467489, 479378, 491346,
        501878, 513934, 526049, 536557, 548720, 560922, 571333, 583539, 591882, 600000
    };

    private static int[] expTableFast = new int[]
    {
        0, 6, 21, 51, 100, 172, 274, 409, 583, 800,
        1064, 1382, 1757, 2195, 2700, 3276, 3930, 4665, 5487, 6400,
        7408, 8518, 9733, 11059, 12500, 14060, 15746, 17561, 19511, 21600,
        23832, 26214, 28749, 31443, 34300, 37324, 40522, 43897, 47455, 51200,
        55136, 59270, 63605, 68147, 72900, 77868, 83058, 88473, 94119, 100000,
        106120, 112486, 119101, 125971, 133100, 140492, 148154, 156089, 164303, 172800,
        181584, 190662, 200037, 209715, 219700, 229996, 240610, 251545, 262807, 274400,
        286328, 298598, 311213, 324179, 337500, 351180, 365226, 379641, 394431, 409600,
        425152, 441094, 457429, 474163, 491300, 508844, 526802, 545177, 563975, 583200,
        602856, 622950, 643485, 664467, 685900, 707788, 730138, 752953, 776239, 800000
    };

    private static int[] expTableMediumFast = new int[]
    {
        0, 8, 27, 64, 125, 216, 343, 512, 729, 1000,
        1331, 1728, 2197, 2744, 3375, 4096, 4913, 5832, 6859, 8000,
        9261, 10648, 12167, 13824, 15625, 17576, 19683, 21952, 24389, 27000,
        29791, 32768, 35937, 39304, 42875, 46656, 50653, 54872, 59319, 64000,
        68921, 74088, 79507, 85184, 91125, 97336, 103823, 110592, 117649, 125000,
        132651, 140608, 148877, 157464, 166375, 175616, 185193, 195112, 205379, 216000,
        226981, 238328, 250047, 262144, 274625, 287496, 300763, 314432, 328509, 343000,
        357911, 373248, 389017, 405224, 421875, 438976, 456533, 474552, 493039, 512000,
        531441, 551368, 571787, 592704, 614125, 636056, 658503, 681472, 704969, 729000,
        753571, 778688, 804357, 830584, 857375, 884736, 912673, 941192, 970299, 1000000
    };

    private static int[] expTableMediumSlow = new int[]
    {
        0, 9, 57, 96, 135, 179, 236, 314, 419, 560,
        742, 973, 1261, 1612, 2035, 2535, 3120, 3798, 4575, 5460,
        6458, 7577, 8825, 10208, 11735, 13411, 15244, 17242, 19411, 21760,
        24294, 27021, 29949, 33084, 36435, 40007, 43808, 47846, 52127, 56660,
        61450, 66505, 71833, 77440, 83335, 89523, 96012, 102810, 109923, 117360,
        125126, 133229, 141677, 150476, 159635, 169159, 179056, 189334, 199999, 211060,
        222522, 234393, 246681, 259392, 272535, 286115, 300140, 314618, 329555, 344960,
        360838, 377197, 394045, 411388, 429235, 447591, 466464, 485862, 505791, 526260,
        547274, 568841, 590969, 613664, 636935, 660787, 685228, 710266, 735907, 762160,
        789030, 816525, 844653, 873420, 902835, 932903, 963632, 995030, 1027103, 1059860
    };

    private static int[] expTableSlow = new int[]
    {
        0, 10, 33, 80, 156, 270, 428, 640, 911, 1250,
        1663, 2160, 2746, 3430, 4218, 5120, 6141, 7290, 8573, 10000,
        11576, 13310, 15208, 17280, 19531, 21970, 24603, 27440, 30486, 33750,
        37238, 40960, 44921, 49130, 53593, 58320, 63316, 68590, 74148, 80000,
        86151, 92610, 99383, 106480, 113906, 121670, 129778, 138240, 147061, 156250,
        165813, 175760, 186096, 196830, 207968, 219520, 231491, 243890, 256723, 270000,
        283726, 297910, 312558, 327680, 343281, 359370, 375953, 393040, 410636, 428750,
        447388, 466560, 486271, 506530, 527343, 548720, 570666, 593190, 616298, 640000,
        664301, 689210, 714733, 740880, 767656, 795070, 823128, 851840, 881211, 911250,
        941963, 973360, 1005446, 1038230, 1071718, 1105920, 1140841, 1176490, 1212873, 1250000
    };

    private static int[] expTableFluctuating = new int[]
    {
        0, 4, 13, 32, 65, 112, 178, 276, 393, 540,
        745, 967, 1230, 1591, 1957, 2457, 3046, 3732, 4526, 5440,
        6482, 7666, 9003, 10506, 12187, 14060, 16140, 18439, 20974, 23760,
        26811, 30146, 33780, 37731, 42017, 46656, 50653, 55969, 60505, 66560,
        71677, 78533, 84277, 91998, 98415, 107069, 114205, 123863, 131766, 142500,
        151222, 163105, 172697, 185807, 196322, 210739, 222231, 238036, 250562, 267840,
        281456, 300293, 315059, 335544, 351520, 373744, 390991, 415050, 433631, 459620,
        479600, 507617, 529063, 559209, 582187, 614566, 639146, 673863, 700115, 737280,
        765275, 804997, 834809, 877201, 908905, 954084, 987754, 1035837, 1071552, 1122660,
        1160499, 1214753, 1254796, 1312322, 1354652, 1415577, 1460276, 1524731, 1571884, 1640000
    };

    public static PokemonData getPokemon(int ID)
    {
        PokemonData result = null;
        int i = 1;
        while (result == null)
        {
            if (pokedex[i].getID() == ID)
            {
                result = pokedex[i];
            }
            i += 1;
            if (i >= pokedex.Length)
            {
                return null;
            }
        }
        return result;
    }

    public static int getLevelExp(PokemonData.LevelingRate levelingRate, int currentLevel)
    {
        int exp = 0;
        if (currentLevel > 100)
        {
            currentLevel = 100;
        }
        if (levelingRate == PokemonData.LevelingRate.ERRATIC)
        {
            exp = expTableErratic[currentLevel - 1]; //Because the array starts at 0, not 1.
        }
        else if (levelingRate == PokemonData.LevelingRate.FAST)
        {
            exp = expTableFast[currentLevel - 1];
        }
        else if (levelingRate == PokemonData.LevelingRate.MEDIUMFAST)
        {
            exp = expTableMediumFast[currentLevel - 1];
        }
        else if (levelingRate == PokemonData.LevelingRate.MEDIUMSLOW)
        {
            exp = expTableMediumSlow[currentLevel - 1];
        }
        else if (levelingRate == PokemonData.LevelingRate.SLOW)
        {
            exp = expTableSlow[currentLevel - 1];
        }
        else if (levelingRate == PokemonData.LevelingRate.FLUCTUATING)
        {
            exp = expTableFluctuating[currentLevel - 1];
        }

        return exp;
    }
}
