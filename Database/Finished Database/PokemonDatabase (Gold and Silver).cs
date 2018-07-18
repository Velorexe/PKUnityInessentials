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
	new int[] { 1, 4, 7, 10, 15, 15, 20, 25, 32, 39, 46},
	new string[]
	{
		 "Tackle", "Growl", "Leech Seed", "Vine Whip", "Poison Powder", "Sleep Powder", "Razor Leaf", "Sweet Scent", "Growth", "Synthesis", "Solar Beam",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Solar_Beam", "Toxic", "Double_Team", "Defense_Curl", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Giga_Drain", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {2}, new string[] {"Level,16"}),


new PokemonData(2, "Ivysaur", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Overgrow", null, "Chlorophyll",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 13f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 1, 0, PokemonData.PokedexColor.GREEN, 70,
	"Seed", "There is a plant bulb on its back. When it absorbs nutrients, the bulb is said toblossom into a large flower.",
	60, 62, 63, 80, 80, 60, 0, Color.clear,
	new int[] { 1, 1, 7, 10, 15, 15, 22, 29, 38, 47, 56},
	new string[]
	{
		 "Tackle", "Growl", "Leech Seed", "Vine Whip", "Poison Powder", "Sleep Powder", "Razor Leaf", "Sweet Scent", "Growth", "Synthesis", "Solar Beam",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Solar_Beam", "Toxic", "Double_Team", "Defense_Curl", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Giga_Drain", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {3}, new string[] {"Level,32"}),


new PokemonData(3, "Venusaur", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Overgrow", null, "Chlorophyll",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 2f, 100f,
	236, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 1, 0, PokemonData.PokedexColor.GREEN, 70,
	"Seed", "By spreading the broad petals of its flowerand catching the sun’s rays, it fills its bodywith power.",
	80, 82, 83, 100, 100, 80, 0, Color.clear,
	new int[] { 1, 1, 7, 15, 15, 22, 29, 41, 53, 65},
	new string[]
	{
		 "Vine Whip", "Growl", "Leech Seed", "Poison Powder", "Sleep Powder", "Razor Leaf", "Sweet Scent", "Growth", "Synthesis", "Solar Beam",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Roar", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Defense_Curl", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Giga_Drain", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(4, "Charmander", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Solar-power",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 8.5f,
	62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Lizard", "The flame on its tail indicates Charmander’s lifeforce. If it is healthy, the flame burns brightly.",
	39, 52, 43, 60, 50, 65, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
	new string[]
	{
		 "Scratch", "Growl", "Ember", "Smokescreen", "Rage", "Scary Face", "Flamethrower", "Slash", "Dragon Rage", "Fire Spin",
	},
	new string[]
	{
		 "Fire_Punch", "Cut", "Headbutt", "Strength", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {5}, new string[] {"Level,16"}),


new PokemonData(5, "Charmeleon", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Solar-power",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.1f, 19f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Flame", "It lashes about with its tail to knock down its foe. It then tears up the fallen opponent withsharp claws.",
	58, 64, 58, 80, 65, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 13, 20, 27, 41, 48, 55},
	new string[]
	{
		 "Scratch", "Growl", "Ember", "Smokescreen", "Rage", "Scary Face", "Slash", "Dragon Rage", "Fire Spin",
	},
	new string[]
	{
		 "Fire_Punch", "Cut", "Headbutt", "Strength", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {6}, new string[] {"Level,36"}),


new PokemonData(6, "Charizard", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Blaze", null, "Solar-power",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.7f, 90.5f,
	240, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Flame", "When expelling a blast of superhot fire,the red flame at the tip of its tail burnsmore intensely.",
	78, 84, 78, 109, 85, 100, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 20, 27, 36, 54, 64},
	new string[]
	{
		 "Scratch", "Growl", "Ember", "Smokescreen", "Rage", "Scary Face", "Wing Attack", "Dragon Rage", "Fire Spin",
	},
	new string[]
	{
		 "Fire_Punch", "Cut", "Fly", "Headbutt", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Swagger", "Fury_Cutter", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(7, "Squirtle", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Rain-dish",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 9f,
	63, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Tiny Turtle", "It shelters itself in its shell, then strikes backwith spouts of water at every opportunity.",
	44, 48, 65, 50, 64, 43, 0, Color.clear,
	new int[] { 1, 4, 7, 10, 13, 18, 23, 28, 33, 40, 47},
	new string[]
	{
		 "Tackle", "Tail Whip", "Bubble", "Withdraw", "Water Gun", "Bite", "Rapid Spin", "Protect", "Rain Dance", "Skull Bash", "Hydro Pump",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Waterfall", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {8}, new string[] {"Level,16"}),


new PokemonData(8, "Wartortle", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Rain-dish",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 22.5f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.BLUE, 70,
	"Turtle", "When tapped, this Pokémon will pull in its head,but its tail will still stick out a little bit.",
	59, 63, 80, 65, 80, 58, 0, Color.clear,
	new int[] { 1, 1, 1, 10, 13, 25, 37, 45, 53},
	new string[]
	{
		 "Tackle", "Tail Whip", "Bubble", "Withdraw", "Water Gun", "Rapid Spin", "Rain Dance", "Skull Bash", "Hydro Pump",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Waterfall", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {9}, new string[] {"Level,36"}),


new PokemonData(9, "Blastoise", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Rain-dish",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.6f, 85.5f,
	239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.BLUE, 70,
	"Shellfish", "It crushes its foe under its heavy body to causefainting. In a pinch, it will withdraw inside its shell.",
	79, 83, 100, 85, 105, 78, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 13, 25, 42, 68},
	new string[]
	{
		 "Tackle", "Tail Whip", "Withdraw", "Bubble", "Water Gun", "Rapid Spin", "Rain Dance", "Hydro Pump",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Waterfall", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
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
	new int[] { 1, 13, 14, 15, 18, 23, 28, 34},
	new string[]
	{
		 "Confusion", "Poison Powder", "Stun Spore", "Sleep Powder", "Supersonic", "Whirlwind", "Gust", "Psybeam",
	},
	new string[]
	{
		 "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Swift", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
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
	new int[] { 1, 15, 25, 30, 35, 40},
	new string[]
	{
		 "Fury Attack", "Focus Energy", "Rage", "Pursuit", "Pin Missile", "Agility",
	},
	new string[]
	{
		 "Cut", "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(16, "Pidgey", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
	50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 1.8f,
	50, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Tiny Bird", "A common sight in forests and woods. It flapsits wings at ground level to kick up blinding sand.",
	40, 45, 40, 35, 35, 56, 0, Color.clear,
	new int[] { 1, 5, 9, 15, 21, 29, 37, 47},
	new string[]
	{
		 "Tackle", "Sand Attack", "Gust", "Quick Attack", "Whirlwind", "Wing Attack", "Agility", "Mirror Move",
	},
	new string[]
	{
		 "Fly", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {17}, new string[] {"Level,18"}),


new PokemonData(17, "Pidgeotto", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
	50f, 120, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.1f, 30f,
	122, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
	"Bird", "The claws on its feet are well developed. It can carry prey such as an Exeggcuteto its nest over 60 miles away.",
	63, 60, 55, 50, 50, 71, 0, Color.clear,
	new int[] { 1, 1, 15, 23, 43, 55},
	new string[]
	{
		 "Gust", "Sand Attack", "Quick Attack", "Whirlwind", "Agility", "Mirror Move",
	},
	new string[]
	{
		 "Fly", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {18}, new string[] {"Level,36"}),


new PokemonData(18, "Pidgeot", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
	50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.5f, 39.5f,
	216, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.BROWN, 70,
	"Bird", "When hunting, it skims the surface of waterat high speed to pick off unwary prey suchas Magikarp.",
	83, 80, 75, 70, 70, 101, 0, Color.clear,
	new int[] { 1, 1, 1, 23, 46},
	new string[]
	{
		 "Gust", "Sand Attack", "Quick Attack", "Whirlwind", "Agility",
	},
	new string[]
	{
		 "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(19, "Rattata", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Guts", "Hustle",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.3f, 3.5f,
	51, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
	"Mouse", "Living wherever there is food available,it ceaselessly scavenges for ediblesthe entire day.",
	30, 56, 35, 25, 35, 72, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 20, 27, 34},
	new string[]
	{
		 "Tackle", "Tail Whip", "Quick Attack", "Hyper Fang", "Focus Energy", "Pursuit", "Super Fang",
	},
	new string[]
	{
		 "Headbutt", "Blizzard", "Thunder", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {20}, new string[] {"Level,20"}),


new PokemonData(20, "Raticate", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Guts", "Hustle",
	50f, 127, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.7f, 18.5f,
	145, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
	"Mouse", "It whittles its constantly growing fangs by gnawingon hard things. It can chew apart cinder walls.",
	55, 81, 60, 50, 70, 97, 0, Color.clear,
	new int[] { 1, 1, 1, 20, 30, 40},
	new string[]
	{
		 "Tackle", "Tail Whip", "Quick Attack", "Scary Face", "Pursuit", "Super Fang",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Roar", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(21, "Spearow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", null, "Sniper",
	50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 2f,
	52, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Tiny Bird", "Very protective of its territory, it flaps its shortwings busily to dart around at high speed.",
	40, 60, 30, 31, 31, 70, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 25, 31, 37, 43},
	new string[]
	{
		 "Growl", "Peck", "Leer", "Fury Attack", "Pursuit", "Mirror Move", "Drill Peck", "Agility",
	},
	new string[]
	{
		 "Fly", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {22}, new string[] {"Level,20"}),


new PokemonData(22, "Fearow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", null, "Sniper",
	50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.2f, 38f,
	155, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
	"Beak", "With its huge and magnificent wings, it can keepaloft without ever having to land for rest.",
	65, 90, 65, 61, 61, 100, 0, Color.clear,
	new int[] { 1, 1, 1, 7, 26, 32, 40, 47},
	new string[]
	{
		 "Fury Attack", "Growl", "Peck", "Leer", "Pursuit", "Mirror Move", "Drill Peck", "Agility",
	},
	new string[]
	{
		 "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(23, "Ekans", PokemonData.Type.POISON, PokemonData.Type.NONE, "Intimidate", "Shed-skin", "Unnerve",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2f, 6.9f,
	58, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Snake", "The older it gets, the longer it grows. At night, it wraps its long body aroundtree branches to rest.",
	35, 60, 44, 40, 54, 55, 0, Color.clear,
	new int[] { 1, 1, 9, 15, 23, 29, 37, 43},
	new string[]
	{
		 "Wrap", "Leer", "Poison Sting", "Bite", "Glare", "Screech", "Acid", "Haze",
	},
	new string[]
	{
		 "Headbutt", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {24}, new string[] {"Level,22"}),


new PokemonData(24, "Arbok", PokemonData.Type.POISON, PokemonData.Type.NONE, "Intimidate", "Shed-skin", "Unnerve",
	50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 3.5f, 65f,
	157, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Cobra", "The pattern on its belly appears to be a frighteningface. Weak foes will flee just at the sight ofthe pattern.",
	60, 95, 69, 65, 79, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 25, 33, 51},
	new string[]
	{
		 "Wrap", "Poison Sting", "Bite", "Glare", "Screech", "Haze",
	},
	new string[]
	{
		 "Headbutt", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(25, "Pikachu", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Lightning-rod",
	50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.4f, 6f,
	112, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Mouse", "It raises its tail to check its surroundings. The tail is sometimes struck by lightningin this pose.",
	35, 55, 40, 50, 50, 90, 0, Color.clear,
	new int[] { 1, 1, 6, 8, 11, 15, 20, 26, 33, 41, 50},
	new string[]
	{
		 "Growl", "Thunder Shock", "Tail Whip", "Thunder Wave", "Quick Attack", "Double Team", "Slam", "Thunderbolt", "Agility", "Thunder", "Light Screen",
	},
	new string[]
	{
		 "Thunder_Punch", "Headbutt", "Strength", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance"
	},
	new int[] {}, new string[] {}),


new PokemonData(26, "Raichu", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Lightning-rod",
	50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.8f, 30f,
	218, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.YELLOW, 70,
	"Mouse", "When its electricity builds, its muscles are stimulated,and it becomes more aggressive than usual.",
	60, 90, 55, 90, 80, 110, 0, Color.clear,
	new int[] { 1, 1, 1, 1},
	new string[]
	{
		 "Tail Whip", "Thunder Shock", "Thunderbolt", "Quick Attack",
	},
	new string[]
	{
		 "Thunder_Punch", "Headbutt", "Hyper_Beam", "Strength", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance"
	},
	new int[] {}, new string[] {}),


new PokemonData(27, "Sandshrew", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", null, "Sand-rush",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 12f,
	60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Mouse", "It burrows and lives underground. If threatened,it curls itself up into a ball for protection.",
	50, 75, 85, 20, 30, 40, 0, Color.clear,
	new int[] { 1, 6, 11, 17, 23, 30, 37, 45},
	new string[]
	{
		 "Scratch", "Defense Curl", "Sand Attack", "Poison Sting", "Slash", "Swift", "Fury Swipes", "Sandstorm",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Sandstorm", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {28}, new string[] {"Level,22"}),


new PokemonData(28, "Sandslash", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", null, "Sand-rush",
	50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 29.5f,
	158, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Mouse", "If it digs at an incredible pace, it may snap offits spikes and claws. They grow back in a day.",
	75, 100, 110, 45, 55, 65, 0, Color.clear,
	new int[] { 1, 1, 1, 24, 42, 52},
	new string[]
	{
		 "Scratch", "Sand Attack", "Defense Curl", "Slash", "Fury Swipes", "Sandstorm",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Sandstorm", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(29, "Nidoran-f", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
	0f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 7f,
	55, PokemonData.LevelingRate.MEDIUMSLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Poison Pin", "Although small, its venomous barbs renderthis Pokémon dangerous. The female hassmaller horns.",
	55, 47, 52, 40, 40, 41, 0, Color.clear,
	new int[] { 1, 1, 8, 12, 17, 23, 30, 38},
	new string[]
	{
		 "Tackle", "Growl", "Scratch", "Double Kick", "Poison Sting", "Tail Whip", "Bite", "Fury Swipes",
	},
	new string[]
	{
		 "Headbutt", "Blizzard", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day"
	},
	new int[] {30}, new string[] {"Level,16"}),


new PokemonData(30, "Nidorina", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
	0f, 120, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.8f, 20f,
	128, PokemonData.LevelingRate.MEDIUMSLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Poison Pin", "The female has a gentle temperament. It emits ultrasonic cries that have the powerto befuddle foes.",
	70, 62, 67, 55, 55, 56, 0, Color.clear,
	new int[] { 1, 1, 8, 12, 19, 27, 36, 46},
	new string[]
	{
		 "Tackle", "Growl", "Scratch", "Double Kick", "Poison Sting", "Tail Whip", "Bite", "Fury Swipes",
	},
	new string[]
	{
		 "Headbutt", "Blizzard", "Strength", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(31, "Nidoqueen", PokemonData.Type.POISON, PokemonData.Type.GROUND, "Poison-point", "Rivalry", "Sheer-force",
	0f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.3f, 60f,
	227, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Drill", "It uses its scaly, rugged body to seal the entranceof its nest and protect its young from predators.",
	90, 92, 87, 75, 85, 76, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 23},
	new string[]
	{
		 "Scratch", "Double Kick", "Tackle", "Tail Whip", "Body Slam",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Earthquake", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Sandstorm", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(32, "Nidoran-m", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
	100f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 9f,
	55, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Pin", "It scans its surroundings by raising its ears out ofthe grass. Its toxic horn is for protection.",
	46, 57, 40, 40, 40, 50, 0, Color.clear,
	new int[] { 1, 1, 8, 12, 17, 23, 30, 38},
	new string[]
	{
		 "Tackle", "Leer", "Horn Attack", "Double Kick", "Poison Sting", "Focus Energy", "Fury Attack", "Horn Drill",
	},
	new string[]
	{
		 "Headbutt", "Blizzard", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day"
	},
	new int[] {33}, new string[] {"Level,16"}),


new PokemonData(33, "Nidorino", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
	100f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 19.5f,
	128, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Pin", "It raises its big ears to check its surroundings. If it senses anything, it attacks immediately.",
	61, 72, 57, 55, 55, 65, 0, Color.clear,
	new int[] { 1, 1, 8, 12, 19, 27, 36, 46},
	new string[]
	{
		 "Tackle", "Leer", "Horn Attack", "Double Kick", "Poison Sting", "Focus Energy", "Fury Attack", "Horn Drill",
	},
	new string[]
	{
		 "Headbutt", "Blizzard", "Strength", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(34, "Nidoking", PokemonData.Type.POISON, PokemonData.Type.GROUND, "Poison-point", "Rivalry", "Sheer-force",
	100f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.4f, 62f,
	227, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Drill", "It is recognized by its rock-hard hide andits extended horn. Be careful with the horn,as it contains venom.",
	81, 102, 77, 85, 75, 85, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 23},
	new string[]
	{
		 "Double Kick", "Horn Attack", "Tackle", "Poison Sting", "Thrash",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Earthquake", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Sandstorm", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(35, "Clefairy", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Cute-charm", "Magic-guard", "Friend-guard",
	25f, 150, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.6f, 7.5f,
	113, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
	"Fairy", "It is said that happiness will come to those who seea gathering of Clefairy dancing under a full moon.",
	70, 45, 48, 60, 65, 35, 0, Color.clear,
	new int[] { 1, 1, 4, 8, 13, 19, 26, 34, 43, 53},
	new string[]
	{
		 "Pound", "Growl", "Encore", "Sing", "Double Slap", "Minimize", "Defense Curl", "Metronome", "Moonlight", "Light Screen",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Blizzard", "Strength", "Solar_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
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
		 "Double Slap", "Sing", "Metronome", "Moonlight",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(37, "Vulpix", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Drought",
	25f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 9.9f,
	60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Fox", "When it is born, it has just one snow-white tail. The tail splits from its tip as it grows older.",
	38, 41, 40, 50, 65, 65, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 19, 25, 31, 37},
	new string[]
	{
		 "Tail Whip", "Ember", "Quick Attack", "Roar", "Confuse Ray", "Safeguard", "Flamethrower", "Fire Spin",
	},
	new string[]
	{
		 "Headbutt", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(38, "Ninetales", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Drought",
	25f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 19.9f,
	177, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Fox", "It has nine long tails and fur that gleams gold. It is said to live for 1,000 years.",
	73, 76, 75, 81, 100, 100, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 43},
	new string[]
	{
		 "Ember", "Quick Attack", "Confuse Ray", "Safeguard", "Fire Spin",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(39, "Jigglypuff", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Cute-charm", "Competitive", "Friend-guard",
	25f, 170, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.5f, 5.5f,
	95, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Balloon", "It captivates foes with its huge, round eyes,then lulls them to sleep by singing asoothing melody.",
	115, 45, 20, 45, 25, 20, 0, Color.clear,
	new int[] { 1, 4, 9, 14, 19, 24, 29, 34, 39},
	new string[]
	{
		 "Sing", "Defense Curl", "Pound", "Disable", "Rollout", "Double Slap", "Rest", "Body Slam", "Double-Edge",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Blizzard", "Strength", "Solar_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
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
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(41, "Zubat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
	50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 0.8f, 7.5f,
	49, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
	"Bat", "Even though it has no eyes, it can sense obstaclesusing ultrasonic waves it emits from its mouth.",
	40, 45, 35, 30, 40, 55, 0, Color.clear,
	new int[] { 1, 6, 12, 19, 27, 36, 46},
	new string[]
	{
		 "Leech Life", "Supersonic", "Bite", "Confuse Ray", "Wing Attack", "Mean Look", "Haze",
	},
	new string[]
	{
		 "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Detect", "Giga_Drain", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {42}, new string[] {"Level,22"}),


new PokemonData(42, "Golbat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
	50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.6f, 55f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
	"Bat", "Once it bites, it will not stop draining energyfrom the victim even if it gets too heavy to fly.",
	75, 80, 70, 65, 75, 90, 0, Color.clear,
	new int[] { 1, 1, 12, 19, 30, 42, 55},
	new string[]
	{
		 "Supersonic", "Leech Life", "Bite", "Confuse Ray", "Wing Attack", "Mean Look", "Haze",
	},
	new string[]
	{
		 "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Detect", "Giga_Drain", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(43, "Oddish", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Run-away",
	50f, 255, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.5f, 5.4f,
	64, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Weed", "During the day, it stays in the cold undergroundto avoid the sun. It grows by bathing in moonlight.",
	45, 50, 55, 75, 65, 30, 0, Color.clear,
	new int[] { 1, 7, 14, 16, 18, 23, 32, 39},
	new string[]
	{
		 "Absorb", "Sweet Scent", "Poison Powder", "Stun Spore", "Sleep Powder", "Acid", "Moonlight", "Petal Dance",
	},
	new string[]
	{
		 "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {44}, new string[] {"Level,21"}),


new PokemonData(44, "Gloom", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Stench",
	50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 0.8f, 8.6f,
	138, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Weed", "Smells incredibly foul! However, around one outof a thousand people enjoy sniffing itsnose-bending stink.",
	60, 65, 70, 85, 75, 40, 0, Color.clear,
	new int[] { 1, 1, 1, 18, 24, 44},
	new string[]
	{
		 "Absorb", "Poison Powder", "Sweet Scent", "Sleep Powder", "Acid", "Petal Dance",
	},
	new string[]
	{
		 "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(45, "Vileplume", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Effect-spore",
	50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 1.2f, 18.6f,
	221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Flower", "The larger its petals, the more toxic pollen itcontains. Its big head is heavy and hard to hold up.",
	75, 80, 85, 110, 90, 50, 0, Color.clear,
	new int[] { 1, 1, 1, 1},
	new string[]
	{
		 "Absorb", "Stun Spore", "Petal Dance", "Sweet Scent",
	},
	new string[]
	{
		 "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(46, "Paras", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Effect-spore", "Dry-skin", "Damp",
	50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 5.4f,
	57, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Mushroom", "Growing out of the bug’s back are mushroomscalled tochukaso. The mushrooms growwith the bug host.",
	35, 70, 55, 45, 55, 25, 0, Color.clear,
	new int[] { 1, 7, 13, 19, 25, 31, 37, 43},
	new string[]
	{
		 "Scratch", "Stun Spore", "Poison Powder", "Leech Life", "Spore", "Slash", "Growth", "Giga Drain",
	},
	new string[]
	{
		 "Cut", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {47}, new string[] {"Level,24"}),


new PokemonData(47, "Parasect", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Effect-spore", "Dry-skin", "Damp",
	50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1f, 29.5f,
	142, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 1, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Mushroom", "A mushroom grown larger than the host’s bodycontrols Parasect. It scatters poisonous spores.",
	60, 95, 80, 60, 80, 30, 0, Color.clear,
	new int[] { 1, 1, 7, 19, 28, 37, 46, 55},
	new string[]
	{
		 "Scratch", "Poison Powder", "Stun Spore", "Leech Life", "Spore", "Slash", "Growth", "Giga Drain",
	},
	new string[]
	{
		 "Cut", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(48, "Venonat", PokemonData.Type.BUG, PokemonData.Type.POISON, "Compound-eyes", "Tinted-lens", "Run-away",
	50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1f, 30f,
	61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Insect", "Its big eyes are actually clusters of tiny eyes. At night, its kind is drawn by light.",
	60, 55, 50, 40, 55, 45, 0, Color.clear,
	new int[] { 1, 1, 1, 9, 17, 20, 25, 28, 33, 36, 41},
	new string[]
	{
		 "Tackle", "Disable", "Foresight", "Supersonic", "Confusion", "Poison Powder", "Leech Life", "Stun Spore", "Psybeam", "Sleep Powder", "Psychic",
	},
	new string[]
	{
		 "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {49}, new string[] {"Level,31"}),


new PokemonData(49, "Venomoth", PokemonData.Type.BUG, PokemonData.Type.POISON, "Shield-dust", "Tinted-lens", "Wonder-skin",
	50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.5f, 12.5f,
	158, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Moth", "The scales it scatters will paralyze anyone whotouches them, making that person unable to stand.",
	70, 65, 60, 90, 75, 90, 0, Color.clear,
	new int[] { 1, 1, 1, 17, 20, 25, 28, 31, 36, 42, 52},
	new string[]
	{
		 "Tackle", "Supersonic", "Foresight", "Confusion", "Poison Powder", "Leech Life", "Stun Spore", "Gust", "Psybeam", "Sleep Powder", "Psychic",
	},
	new string[]
	{
		 "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Swift", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(50, "Diglett", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", "Arena-trap", "Sand-force",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.2f, 0.8f,
	53, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Mole", "Lives about one yard underground where it feedson plant roots. It sometimes appears aboveground.",
	10, 55, 25, 35, 45, 95, 0, Color.clear,
	new int[] { 1, 5, 9, 17, 25, 33, 41, 49},
	new string[]
	{
		 "Scratch", "Growl", "Magnitude", "Dig", "Sand Attack", "Slash", "Earthquake", "Fissure",
	},
	new string[]
	{
		 "Cut", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {51}, new string[] {"Level,26"}),


new PokemonData(51, "Dugtrio", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", "Arena-trap", "Sand-force",
	50f, 50, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 33.3f,
	149, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
	"Mole", "In battle, it digs through the ground and strikesthe unsuspecting foe from an unexpected direction.",
	35, 100, 50, 50, 70, 120, 0, Color.clear,
	new int[] { 1, 1, 1, 17, 25, 37, 61},
	new string[]
	{
		 "Scratch", "Growl", "Magnitude", "Dig", "Sand Attack", "Slash", "Fissure",
	},
	new string[]
	{
		 "Cut", "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(52, "Meowth", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Technician", "Unnerve",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 4.2f,
	58, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Scratch Cat", "It is nocturnal in nature. If it spots something shiny,its eyes glitter brightly.",
	40, 45, 35, 40, 40, 90, 0, Color.clear,
	new int[] { 1, 1, 11, 20, 28, 35, 41, 46},
	new string[]
	{
		 "Scratch", "Growl", "Bite", "Pay Day", "Feint Attack", "Screech", "Fury Swipes", "Slash",
	},
	new string[]
	{
		 "Headbutt", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {53}, new string[] {"Level,28"}),


new PokemonData(53, "Persian", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Limber", "Technician", "Unnerve",
	50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 32f,
	154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Classy Cat", "Although its fur has many admirers, it is toughto raise as a pet because of its fickle meanness.",
	65, 70, 60, 65, 65, 115, 0, Color.clear,
	new int[] { 1, 1, 20, 29, 38, 46, 53},
	new string[]
	{
		 "Scratch", "Bite", "Pay Day", "Feint Attack", "Screech", "Fury Swipes", "Slash",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Hyper_Beam", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(54, "Psyduck", PokemonData.Type.WATER, PokemonData.Type.NONE, "Damp", "Cloud-nine", "Swift-swim",
	50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 19.6f,
	64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Duck", "It is constantly wracked by a headache. When the headache turns intense,it begins using mysterious powers.",
	50, 52, 48, 65, 50, 55, 0, Color.clear,
	new int[] { 1, 5, 10, 16, 23, 31, 40, 50},
	new string[]
	{
		 "Scratch", "Tail Whip", "Disable", "Confusion", "Screech", "Psych Up", "Fury Swipes", "Hydro Pump",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Whirlpool"
	},
	new int[] {55}, new string[] {"Level,33"}),


new PokemonData(55, "Golduck", PokemonData.Type.WATER, PokemonData.Type.NONE, "Damp", "Cloud-nine", "Swift-swim",
	50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 76.6f,
	175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Duck", "It appears by waterways at dusk. It may use telekinetic powersif its forehead glows mysteriously.",
	80, 82, 78, 95, 80, 85, 0, Color.clear,
	new int[] { 1, 1, 1, 10, 31, 44, 58},
	new string[]
	{
		 "Scratch", "Tail Whip", "Confusion", "Disable", "Psych Up", "Fury Swipes", "Hydro Pump",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(56, "Mankey", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Vital-spirit", "Anger-point", "Defiant",
	50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 28f,
	61, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Pig Monkey", "It’s unsafe to approach if it gets violently enragedfor no reason and can’t distinguish friendsfrom foes.",
	40, 80, 35, 35, 45, 70, 0, Color.clear,
	new int[] { 1, 1, 9, 15, 21, 27, 33, 39, 45, 51},
	new string[]
	{
		 "Scratch", "Leer", "Low Kick", "Karate Chop", "Fury Swipes", "Focus Energy", "Seismic Toss", "Cross Chop", "Screech", "Thrash",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Strength", "Thunder", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash"
	},
	new int[] {57}, new string[] {"Level,28"}),


new PokemonData(57, "Primeape", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Vital-spirit", "Anger-point", "Defiant",
	50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 32f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Pig Monkey", "It stops being angry only when nobody else isaround. To view this moment is very difficult.",
	65, 105, 60, 60, 70, 95, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 15, 21, 27, 45, 63},
	new string[]
	{
		 "Scratch", "Leer", "Low Kick", "Rage", "Karate Chop", "Fury Swipes", "Focus Energy", "Cross Chop", "Thrash",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Strength", "Thunder", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(58, "Growlithe", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Intimidate", "Flash-fire", "Justified",
	75f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 19f,
	70, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Puppy", "Very friendly and faithful to people. It will try torepel enemies by barking and biting.",
	55, 70, 45, 70, 50, 60, 0, Color.clear,
	new int[] { 1, 1, 9, 18, 26, 34, 42, 50},
	new string[]
	{
		 "Bite", "Roar", "Ember", "Leer", "Take Down", "Flame Wheel", "Agility", "Flamethrower",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(59, "Arcanine", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Intimidate", "Flash-fire", "Justified",
	75f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.9f, 155f,
	194, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Legendary", "A Pokémon that has long been admired for itsbeauty. It runs agilely as if on wings.",
	90, 110, 80, 100, 80, 95, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 50},
	new string[]
	{
		 "Take Down", "Leer", "Roar", "Flame Wheel", "Extreme Speed",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(60, "Poliwag", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", "Damp", "Swift-swim",
	50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 12.4f,
	60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
	"Tadpole", "Its slick black skin is thin and damp. A part of itsinternal organs can be seen through the skin as aspiral pattern.",
	40, 50, 40, 40, 40, 90, 0, Color.clear,
	new int[] { 1, 7, 13, 19, 25, 31, 37, 43},
	new string[]
	{
		 "Bubble", "Hypnosis", "Water Gun", "Double Slap", "Rain Dance", "Body Slam", "Belly Drum", "Hydro Pump",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Waterfall", "Rest", "Thief", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {61}, new string[] {"Level,25"}),


new PokemonData(61, "Poliwhirl", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", "Damp", "Swift-swim",
	50f, 120, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1f, 20f,
	135, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
	"Tadpole", "It can live in or out of water. When out of water,it constantly sweats to keep its body slimy.",
	65, 65, 65, 50, 50, 90, 0, Color.clear,
	new int[] { 1, 1, 19, 27, 35, 43},
	new string[]
	{
		 "Water Gun", "Hypnosis", "Double Slap", "Rain Dance", "Body Slam", "Belly Drum",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Waterfall", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(62, "Poliwrath", PokemonData.Type.WATER, PokemonData.Type.FIGHTING, "Water-absorb", "Damp", "Swift-swim",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.3f, 54f,
	230, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Tadpole", "With its extremely tough muscles, it can keepswimming in the Pacific Ocean without resting.",
	90, 95, 95, 70, 90, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 51},
	new string[]
	{
		 "Double Slap", "Water Gun", "Submission", "Mind Reader",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Waterfall", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
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
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {64}, new string[] {"Level,16"}),


new PokemonData(64, "Kadabra", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", "Inner-focus", "Magic-guard",
	75f, 100, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.3f, 56.5f,
	140, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Psi", "When it uses its psychic power, it emits strongalpha waves that can ruin precision devices.",
	40, 35, 30, 120, 70, 105, 0, Color.clear,
	new int[] { 1, 1, 1, 18, 21, 26, 31, 45},
	new string[]
	{
		 "Confusion", "Teleport", "Kinesis", "Disable", "Psybeam", "Recover", "Future Sight", "Reflect",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Dig", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(65, "Alakazam", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", "Inner-focus", "Magic-guard",
	75f, 50, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.5f, 48f,
	225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Psi", "Its brain cells multiply continually until it dies. As a result, it remembers everything.",
	55, 50, 45, 135, 95, 120, 0, Color.clear,
	new int[] { 1, 1, 1, 18, 21, 26, 31, 45},
	new string[]
	{
		 "Confusion", "Teleport", "Kinesis", "Disable", "Psybeam", "Recover", "Future Sight", "Reflect",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(66, "Machop", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
	75f, 180, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.8f, 19.5f,
	61, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Superpower", "It hefts a Graveler repeatedly to strengthenits entire body. It uses every type of martial arts.",
	70, 80, 50, 35, 35, 35, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
	new string[]
	{
		 "Leer", "Low Kick", "Focus Energy", "Karate Chop", "Seismic Toss", "Foresight", "Vital Throw", "Cross Chop", "Scary Face", "Submission",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {67}, new string[] {"Level,28"}),


new PokemonData(67, "Machoke", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
	75f, 90, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.5f, 70.5f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Superpower", "Its muscular body is so powerful, it must wear apower-save belt to be able to regulate its motions.",
	80, 100, 70, 50, 60, 45, 0, Color.clear,
	new int[] { 1, 1, 1, 15, 19, 25, 34, 43, 61},
	new string[]
	{
		 "Leer", "Low Kick", "Focus Energy", "Karate Chop", "Seismic Toss", "Foresight", "Vital Throw", "Cross Chop", "Submission",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(68, "Machamp", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
	75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.6f, 130f,
	227, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Superpower", "Its four ruggedly developed arms can launcha flurry of 1,000 punches in just two seconds.",
	90, 130, 80, 65, 85, 55, 0, Color.clear,
	new int[] { 1, 1, 1, 15, 19, 25, 34, 43, 61},
	new string[]
	{
		 "Leer", "Low Kick", "Focus Energy", "Karate Chop", "Seismic Toss", "Foresight", "Vital Throw", "Cross Chop", "Submission",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(69, "Bellsprout", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Gluttony",
	50f, 255, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.7f, 4f,
	60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Flower", "Even though its body is extremely skinny, it isblindingly fast when catching its prey.",
	50, 75, 35, 70, 30, 40, 0, Color.clear,
	new int[] { 1, 6, 11, 15, 17, 19, 23, 30, 37, 45},
	new string[]
	{
		 "Vine Whip", "Growth", "Wrap", "Sleep Powder", "Poison Powder", "Stun Spore", "Acid", "Sweet Scent", "Razor Leaf", "Slam",
	},
	new string[]
	{
		 "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {70}, new string[] {"Level,21"}),


new PokemonData(70, "Weepinbell", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Gluttony",
	50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1f, 6.4f,
	137, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Flycatcher", "The leafy parts act as cutters for slashing foes. It spits a fluid that dissolves everything.",
	65, 90, 50, 85, 45, 55, 0, Color.clear,
	new int[] { 1, 1, 1, 15, 17, 19, 33, 54},
	new string[]
	{
		 "Vine Whip", "Wrap", "Growth", "Sleep Powder", "Poison Powder", "Stun Spore", "Sweet Scent", "Slam",
	},
	new string[]
	{
		 "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(71, "Victreebel", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Gluttony",
	50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1.7f, 15.5f,
	221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Flycatcher", "Said to live in huge colonies deep in jungles,although no one has ever returned from there.",
	80, 105, 65, 100, 70, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 1},
	new string[]
	{
		 "Vine Whip", "Razor Leaf", "Sleep Powder", "Sweet Scent",
	},
	new string[]
	{
		 "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(72, "Tentacool", PokemonData.Type.WATER, PokemonData.Type.POISON, "Clear-body", "Liquid-ooze", "Rain-dish",
	50f, 190, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.9f, 45.5f,
	67, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLUE, 70,
	"Jellyfish", "Its body is virtually composed of water. It shootsstrange beams from its crystal-like eyes.",
	40, 40, 35, 50, 100, 70, 0, Color.clear,
	new int[] { 1, 6, 12, 19, 25, 30, 36, 43, 49},
	new string[]
	{
		 "Poison Sting", "Supersonic", "Constrict", "Acid", "Bubble Beam", "Wrap", "Barrier", "Screech", "Hydro Pump",
	},
	new string[]
	{
		 "Cut", "Surf", "Blizzard", "Toxic", "Double_Team", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Icy_Wind", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {73}, new string[] {"Level,30"}),


new PokemonData(73, "Tentacruel", PokemonData.Type.WATER, PokemonData.Type.POISON, "Clear-body", "Liquid-ooze", "Rain-dish",
	50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.6f, 55f,
	180, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLUE, 70,
	"Jellyfish", "The tentacles are normally kept short. On hunts,they are extended to ensnare and immobilize prey.",
	80, 70, 65, 80, 120, 100, 0, Color.clear,
	new int[] { 1, 1, 1, 25, 30, 38, 47, 55},
	new string[]
	{
		 "Poison Sting", "Supersonic", "Constrict", "Bubble Beam", "Wrap", "Barrier", "Screech", "Hydro Pump",
	},
	new string[]
	{
		 "Cut", "Surf", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Icy_Wind", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(74, "Geodude", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
	50f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.4f, 20f,
	60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Rock", "Found in fields and mountains. Mistaking them forboulders, people often step or trip on them.",
	40, 80, 100, 30, 30, 20, 0, Color.clear,
	new int[] { 1, 6, 11, 16, 21, 26, 31, 36, 41},
	new string[]
	{
		 "Tackle", "Defense Curl", "Rock Throw", "Magnitude", "Self-Destruct", "Harden", "Rollout", "Earthquake", "Explosion",
	},
	new string[]
	{
		 "Fire_Punch", "Headbutt", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {75}, new string[] {"Level,25"}),


new PokemonData(75, "Graveler", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
	50f, 120, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 105f,
	137, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Rock", "With a free and uncaring nature, it doesn’t mindif pieces break off while it rolls down mountains.",
	55, 95, 115, 45, 45, 35, 0, Color.clear,
	new int[] { 1, 1, 1, 16, 27, 34, 48},
	new string[]
	{
		 "Tackle", "Rock Throw", "Defense Curl", "Magnitude", "Harden", "Rollout", "Explosion",
	},
	new string[]
	{
		 "Fire_Punch", "Headbutt", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(76, "Golem", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
	50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.4f, 300f,
	223, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Megaton", "It tumbles down mountains, leaving groovesfrom peak to base. Stay clear of these grooves.",
	80, 120, 130, 55, 65, 45, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 27, 34, 48},
	new string[]
	{
		 "Tackle", "Rock Throw", "Defense Curl", "Magnitude", "Harden", "Rollout", "Explosion",
	},
	new string[]
	{
		 "Fire_Punch", "Headbutt", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(77, "Ponyta", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Run-away", "Flash-fire", "Flame-body",
	50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 30f,
	82, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Fire Horse", "As a newborn, it can barely stand. However, through galloping, itslegs are made tougher and faster.",
	50, 85, 55, 65, 65, 90, 0, Color.clear,
	new int[] { 1, 4, 8, 13, 19, 26, 34, 43, 53},
	new string[]
	{
		 "Tackle", "Growl", "Tail Whip", "Ember", "Stomp", "Fire Spin", "Take Down", "Agility", "Fire Blast",
	},
	new string[]
	{
		 "Headbutt", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day"
	},
	new int[] {78}, new string[] {"Level,40"}),


new PokemonData(78, "Rapidash", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Run-away", "Flash-fire", "Flame-body",
	50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.7f, 95f,
	175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Fire Horse", "Very competitive, this Pokémon will chase anythingthat moves fast in the hopes of racing it.",
	65, 100, 70, 80, 80, 105, 0, Color.clear,
	new int[] { 1, 1, 1, 4, 19, 34, 40, 47, 61},
	new string[]
	{
		 "Tackle", "Tail Whip", "Ember", "Growl", "Stomp", "Take Down", "Fury Attack", "Agility", "Fire Blast",
	},
	new string[]
	{
		 "Headbutt", "Hyper_Beam", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(79, "Slowpoke", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
	50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 36f,
	63, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Dopey", "It is always vacantly lost in thought, but no oneknows what it is thinking about. It is good at fishingwith its tail.",
	90, 65, 65, 40, 40, 15, 0, Color.clear,
	new int[] { 1, 1, 6, 15, 20, 29, 34, 43, 48},
	new string[]
	{
		 "Tackle", "Curse", "Growl", "Water Gun", "Confusion", "Disable", "Headbutt", "Amnesia", "Psychic",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Swift", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {80}, new string[] {"Level,37"}),


new PokemonData(80, "Slowbro", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
	50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.6f, 78.5f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Hermit Crab", "An attached Shellder won’t let go because ofthe tasty flavor that oozes out of its tail.",
	95, 75, 110, 100, 80, 30, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 34, 37, 46, 54},
	new string[]
	{
		 "Tackle", "Growl", "Water Gun", "Curse", "Headbutt", "Withdraw", "Amnesia", "Psychic",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Swift", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(81, "Magnemite", PokemonData.Type.ELECTRIC, PokemonData.Type.STEEL, "Magnet-pull", "Sturdy", "Analytic",
	112.5f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.3f, 6f,
	65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Magnet", "The units at the sides of its body generateantigravity energy to keep it aloft in the air.",
	25, 35, 70, 95, 55, 45, 0, Color.clear,
	new int[] { 1, 6, 11, 16, 21, 27, 33, 39, 45},
	new string[]
	{
		 "Tackle", "Thunder Shock", "Supersonic", "Sonic Boom", "Thunder Wave", "Lock-On", "Swift", "Screech", "Zap Cannon",
	},
	new string[]
	{
		 "Thunder", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Rollout", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance"
	},
	new int[] {82}, new string[] {"Level,30"}),


new PokemonData(82, "Magneton", PokemonData.Type.ELECTRIC, PokemonData.Type.STEEL, "Magnet-pull", "Sturdy", "Analytic",
	112.5f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 60f,
	163, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Magnet", "A linked cluster formed of several Magnemite. It discharges powerful magnetic waves athigh voltage.",
	50, 60, 95, 120, 70, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 16, 27, 35, 43, 53},
	new string[]
	{
		 "Tackle", "Supersonic", "Thunder Shock", "Sonic Boom", "Lock-On", "Swift", "Screech", "Zap Cannon",
	},
	new string[]
	{
		 "Hyper_Beam", "Thunder", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Rollout", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance"
	},
	new int[] {}, new string[] {}),


new PokemonData(83, "Farfetchd", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Inner-focus", "Defiant",
	50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.8f, 15f,
	132, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Wild Duck", "The plant stalk it holds is its weapon. The stalk isused like a sword to cut all sorts of things.",
	52, 90, 55, 58, 62, 60, 0, Color.clear,
	new int[] { 1, 7, 13, 19, 25, 31, 37, 44},
	new string[]
	{
		 "Peck", "Sand Attack", "Leer", "Fury Attack", "Swords Dance", "Agility", "Slash", "False Swipe",
	},
	new string[]
	{
		 "Cut", "Fly", "Headbutt", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Psych_Up"
	},
	new int[] {}, new string[] {}),


new PokemonData(84, "Doduo", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Run-away", "Early-bird", "Tangled-feet",
	50f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.4f, 39.2f,
	62, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Twin Bird", "A two-headed Pokémon that was discovered as asudden mutation. It runs at a pace of over 60 milesper hour.",
	35, 85, 45, 35, 35, 75, 0, Color.clear,
	new int[] { 1, 1, 9, 13, 21, 25, 33, 37},
	new string[]
	{
		 "Growl", "Peck", "Pursuit", "Fury Attack", "Tri Attack", "Rage", "Drill Peck", "Agility",
	},
	new string[]
	{
		 "Fly", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {85}, new string[] {"Level,31"}),


new PokemonData(85, "Dodrio", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Run-away", "Early-bird", "Tangled-feet",
	50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.8f, 85.2f,
	165, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Triple Bird", "An enemy that takes its eyes off any of thethree heads--even for a second--will getpecked severely.",
	60, 110, 70, 60, 60, 110, 0, Color.clear,
	new int[] { 1, 1, 1, 21, 25, 38, 47},
	new string[]
	{
		 "Fury Attack", "Peck", "Pursuit", "Tri Attack", "Rage", "Drill Peck", "Agility",
	},
	new string[]
	{
		 "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(86, "Seel", PokemonData.Type.WATER, PokemonData.Type.NONE, "Thick-fat", "Hydration", "Ice-body",
	50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.1f, 90f,
	65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.WHITE, 70,
	"Sea Lion", "A Pokémon that lives on icebergs. It swims in thesea using the point on its head to break up ice.",
	65, 45, 55, 45, 70, 45, 0, Color.clear,
	new int[] { 1, 5, 16, 21, 32, 37, 48},
	new string[]
	{
		 "Headbutt", "Growl", "Aurora Beam", "Rest", "Take Down", "Ice Beam", "Safeguard",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {87}, new string[] {"Level,34"}),


new PokemonData(87, "Dewgong", PokemonData.Type.WATER, PokemonData.Type.ICE, "Thick-fat", "Hydration", "Ice-body",
	50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 120f,
	166, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.WHITE, 70,
	"Sea Lion", "Its body is covered with a pure white fur. The colder the weather, the more activeit becomes.",
	90, 70, 80, 70, 95, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 32, 60},
	new string[]
	{
		 "Headbutt", "Growl", "Aurora Beam", "Take Down", "Safeguard",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(88, "Grimer", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Sticky-hold", "Poison-touch",
	50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.9f, 30f,
	65, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Sludge", "Sludge exposed to X-rays from the moontransformed into Grimer. It loves feedingon filthy things.",
	80, 80, 50, 40, 50, 25, 0, Color.clear,
	new int[] { 1, 1, 5, 10, 16, 23, 31, 40, 50},
	new string[]
	{
		 "Pound", "Poison Gas", "Harden", "Disable", "Sludge", "Minimize", "Screech", "Acid Armor", "Sludge Bomb",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Zap_Cannon", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day"
	},
	new int[] {89}, new string[] {"Level,38"}),


new PokemonData(89, "Muk", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Sticky-hold", "Poison-touch",
	50f, 75, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 30f,
	175, PokemonData.LevelingRate.MEDIUMFAST, 1, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Sludge", "They love to gather in smelly areas where sludgeaccumulates, making the stench aroundthem worse.",
	105, 105, 75, 65, 100, 50, 0, Color.clear,
	new int[] { 1, 1, 1, 31, 37, 45, 45, 60},
	new string[]
	{
		 "Pound", "Harden", "Poison Gas", "Screech", "Disable", "Sludge", "Acid Armor", "Sludge Bomb",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Hyper_Beam", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Zap_Cannon", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(90, "Shellder", PokemonData.Type.WATER, PokemonData.Type.NONE, "Shell-armor", "Skill-link", "Overcoat",
	50f, 190, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.3f, 4f,
	61, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Bivalve", "Its hard shell repels any kind of attack. It is vulnerable only when its shell is open.",
	30, 65, 100, 45, 25, 40, 0, Color.clear,
	new int[] { 1, 1, 9, 17, 25, 33, 41, 49},
	new string[]
	{
		 "Tackle", "Withdraw", "Supersonic", "Aurora Beam", "Protect", "Leer", "Clamp", "Ice Beam",
	},
	new string[]
	{
		 "Surf", "Blizzard", "Toxic", "Double_Team", "Swift", "Rest", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(91, "Cloyster", PokemonData.Type.WATER, PokemonData.Type.ICE, "Shell-armor", "Skill-link", "Overcoat",
	50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.5f, 132.5f,
	184, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Bivalve", "Cloyster that live in seas with harsh tidal currentsgrow large, sharp spikes on their shells.",
	50, 95, 180, 85, 45, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 41},
	new string[]
	{
		 "Supersonic", "Aurora Beam", "Withdraw", "Protect", "Spike Cannon",
	},
	new string[]
	{
		 "Surf", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Rest", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(92, "Gastly", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Levitate", null, null,
	50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.3f, 0.1f,
	62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Gas", "Its body is made of gas. Despite lacking substance,it can envelop an opponent of any size andcause suffocation.",
	30, 35, 30, 100, 35, 80, 0, Color.clear,
	new int[] { 1, 1, 8, 13, 16, 21, 28, 33, 36},
	new string[]
	{
		 "Hypnosis", "Lick", "Spite", "Mean Look", "Curse", "Night Shade", "Confuse Ray", "Dream Eater", "Destiny Bond",
	},
	new string[]
	{
		 "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {93}, new string[] {"Level,25"}),


new PokemonData(93, "Haunter", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Levitate", null, null,
	50f, 90, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.6f, 0.1f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Gas", "If you get the feeling of being watched in darknesswhen nobody is around, Haunter is there.",
	45, 50, 45, 115, 55, 95, 0, Color.clear,
	new int[] { 1, 1, 1, 13, 16, 21, 31, 39},
	new string[]
	{
		 "Hypnosis", "Lick", "Spite", "Mean Look", "Curse", "Night Shade", "Confuse Ray", "Dream Eater",
	},
	new string[]
	{
		 "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(94, "Gengar", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Cursed-body", null, null,
	50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.5f, 40.5f,
	225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Shadow", "It hides in shadows. It is said that if Gengaris hiding, it cools the area by nearly10 degrees Fahrenheit.",
	60, 65, 60, 130, 75, 110, 0, Color.clear,
	new int[] { 1, 1, 1, 13, 16, 21, 31, 39},
	new string[]
	{
		 "Hypnosis", "Lick", "Spite", "Mean Look", "Curse", "Night Shade", "Confuse Ray", "Dream Eater",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Strength", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(95, "Onix", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Weak-armor",
	50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 8.8f, 210f,
	77, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Rock Snake", "Burrows at high speed in search of food. The tunnels it leaves are used as homesby Diglett.",
	35, 45, 160, 30, 45, 70, 0, Color.clear,
	new int[] { 1, 1, 10, 14, 23, 27, 36, 40},
	new string[]
	{
		 "Tackle", "Screech", "Bind", "Rock Throw", "Harden", "Rage", "Sandstorm", "Slam",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(96, "Drowzee", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Insomnia", "Forewarn", "Inner-focus",
	50f, 190, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1f, 32.4f,
	66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Hypnosis", "Puts enemies to sleep, then eats their dreams. Occasionally gets sick from eating only bad dreams.",
	60, 48, 45, 43, 90, 42, 0, Color.clear,
	new int[] { 1, 1, 10, 18, 25, 31, 36, 40, 43, 45},
	new string[]
	{
		 "Pound", "Hypnosis", "Disable", "Confusion", "Headbutt", "Poison Gas", "Meditate", "Psychic", "Psych Up", "Future Sight",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {97}, new string[] {"Level,26"}),


new PokemonData(97, "Hypno", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Insomnia", "Forewarn", "Inner-focus",
	50f, 75, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.6f, 75.6f,
	169, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Hypnosis", "It carries a pendulum-like device. There oncewas an incident in which it took away a childit hypnotized.",
	85, 73, 70, 73, 115, 67, 0, Color.clear,
	new int[] { 1, 1, 1, 18, 25, 33, 40, 49, 55, 60},
	new string[]
	{
		 "Pound", "Disable", "Hypnosis", "Confusion", "Headbutt", "Poison Gas", "Meditate", "Psychic", "Psych Up", "Future Sight",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(98, "Krabby", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Sheer-force",
	50f, 225, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.4f, 6.5f,
	65, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"River Crab", "If it senses danger approaching, it cloaks itself withbubbles from its mouth so it will look bigger.",
	30, 105, 90, 25, 25, 50, 0, Color.clear,
	new int[] { 1, 5, 12, 16, 23, 27, 34, 41},
	new string[]
	{
		 "Bubble", "Leer", "Vice Grip", "Harden", "Stomp", "Guillotine", "Protect", "Crabhammer",
	},
	new string[]
	{
		 "Cut", "Surf", "Blizzard", "Strength", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {99}, new string[] {"Level,28"}),


new PokemonData(99, "Kingler", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Sheer-force",
	50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.3f, 60f,
	166, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Pincer", "Its large and hard pincer has 10,000-horsepowerstrength. However, being so big, it is unwieldyto move.",
	55, 130, 115, 50, 50, 75, 0, Color.clear,
	new int[] { 1, 1, 1, 23, 38, 49},
	new string[]
	{
		 "Vice Grip", "Leer", "Bubble", "Stomp", "Protect", "Crabhammer",
	},
	new string[]
	{
		 "Cut", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(100, "Voltorb", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Soundproof", "Static", "Aftermath",
	112.5f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.5f, 10.4f,
	66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Ball", "It was discovered when Poké Balls wereintroduced. It is said that there issome connection.",
	40, 30, 50, 55, 55, 100, 0, Color.clear,
	new int[] { 1, 9, 17, 23, 29, 33, 37, 39, 41},
	new string[]
	{
		 "Tackle", "Screech", "Sonic Boom", "Self-Destruct", "Rollout", "Light Screen", "Swift", "Explosion", "Mirror Coat",
	},
	new string[]
	{
		 "Headbutt", "Thunder", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Rollout", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance"
	},
	new int[] {101}, new string[] {"Level,30"}),


new PokemonData(101, "Electrode", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Soundproof", "Static", "Aftermath",
	112.5f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.2f, 66.6f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.RED, 70,
	"Ball", "It explodes in response to even minor stimuli. It isfeared, with the nickname of “The Bomb Ball. ",
	60, 50, 70, 80, 80, 150, 0, Color.clear,
	new int[] { 1, 1, 1, 9, 29, 34, 44, 48},
	new string[]
	{
		 "Tackle", "Sonic Boom", "Self-Destruct", "Screech", "Rollout", "Light Screen", "Explosion", "Mirror Coat",
	},
	new string[]
	{
		 "Headbutt", "Hyper_Beam", "Thunder", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Rollout", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance"
	},
	new int[] {}, new string[] {}),


new PokemonData(102, "Exeggcute", PokemonData.Type.GRASS, PokemonData.Type.PSYCHIC, "Chlorophyll", null, "Harvest",
	50f, 90, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 2.5f,
	65, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Egg", "Its six eggs converse using telepathy. They canquickly gather if they become separated.",
	60, 40, 80, 60, 45, 40, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43},
	new string[]
	{
		 "Hypnosis", "Barrage", "Reflect", "Leech Seed", "Confusion", "Stun Spore", "Poison Powder", "Sleep Powder", "Solar Beam",
	},
	new string[]
	{
		 "Strength", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up"
	},
	new int[] {}, new string[] {}),


new PokemonData(103, "Exeggutor", PokemonData.Type.GRASS, PokemonData.Type.PSYCHIC, "Chlorophyll", null, "Harvest",
	50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 2f, 120f,
	186, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Coconut", "Its three heads think independently. However,they are friendly and never appear to squabble.",
	95, 95, 85, 125, 75, 55, 0, Color.clear,
	new int[] { 1, 1, 1, 19, 31},
	new string[]
	{
		 "Confusion", "Hypnosis", "Barrage", "Stomp", "Egg Bomb",
	},
	new string[]
	{
		 "Headbutt", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up"
	},
	new int[] {}, new string[] {}),


new PokemonData(104, "Cubone", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Rock-head", "Lightning-rod", "Battle-armor",
	50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 6.5f,
	64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Lonely", "It wears the skull of its dead mother on its head. When it becomes lonesome, it is said to cry loudly.",
	50, 50, 95, 40, 50, 35, 0, Color.clear,
	new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41},
	new string[]
	{
		 "Growl", "Tail Whip", "Bone Club", "Headbutt", "Leer", "Focus Energy", "Bonemerang", "Rage", "False Swipe", "Thrash", "Bone Rush",
	},
	new string[]
	{
		 "Fire_Punch", "Thunder_Punch", "Headbutt", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Sandstorm", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {105}, new string[] {"Level,28"}),


new PokemonData(105, "Marowak", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Rock-head", "Lightning-rod", "Battle-armor",
	50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 45f,
	149, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Bone Keeper", "It is small and was originally very weak. Its temperament turned ferocious when it beganusing bones.",
	60, 80, 110, 50, 80, 45, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 21, 32, 39, 53},
	new string[]
	{
		 "Headbutt", "Tail Whip", "Growl", "Bone Club", "Focus Energy", "Rage", "False Swipe", "Bone Rush",
	},
	new string[]
	{
		 "Fire_Punch", "Thunder_Punch", "Headbutt", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Sandstorm", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {106}, new string[] {"Level,20"}),


new PokemonData(106, "Hitmonlee", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Limber", "Reckless", "Unburden",
	100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.5f, 49.8f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Kicking", "The legs freely contract and stretch. The stretchylegs allow it to hit a distant foe with a rising kick.",
	50, 120, 53, 35, 110, 87, 0, Color.clear,
	new int[] { 1, 6, 11, 16, 21, 26, 31, 36, 41, 46, 51},
	new string[]
	{
		 "Double Kick", "Meditate", "Rolling Kick", "Jump Kick", "Focus Energy", "High Jump Kick", "Mind Reader", "Foresight", "Endure", "Mega Kick", "Reversal",
	},
	new string[]
	{
		 "Headbutt", "Strength", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {107}, new string[] {"Level,20"}),


new PokemonData(107, "Hitmonchan", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Keen-eye", "Iron-fist", "Inner-focus",
	100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 50.2f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BROWN, 70,
	"Punching", "The arm-twisting punches it throws pulverize evenconcrete. It rests after three minutes of fighting.",
	50, 105, 79, 35, 110, 76, 0, Color.clear,
	new int[] { 1, 7, 13, 26, 26, 26, 32, 38, 44, 50},
	new string[]
	{
		 "Comet Punch", "Agility", "Pursuit", "Fire Punch", "Ice Punch", "Thunder Punch", "Mach Punch", "Mega Punch", "Detect", "Counter",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Strength", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(108, "Lickitung", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Own-tempo", "Oblivious", "Cloud-nine",
	50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 65.5f,
	77, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Licking", "Its long tongue, slathered with a gooey saliva,sticks to anything, so it is very useful.",
	90, 55, 75, 60, 75, 30, 0, Color.clear,
	new int[] { 1, 7, 13, 19, 25, 31, 37, 43},
	new string[]
	{
		 "Lick", "Supersonic", "Defense Curl", "Stomp", "Wrap", "Disable", "Slam", "Screech",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Cut", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Earthquake", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(109, "Koffing", PokemonData.Type.POISON, PokemonData.Type.NONE, "Levitate", null, null,
	50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 1f,
	68, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Gas", "Its thin, balloon-like body is inflated by horriblytoxic gases. It reeks when it is nearby.",
	40, 65, 95, 60, 45, 35, 0, Color.clear,
	new int[] { 1, 1, 9, 17, 21, 25, 33, 41, 45},
	new string[]
	{
		 "Tackle", "Poison Gas", "Smog", "Self-Destruct", "Sludge", "Smokescreen", "Haze", "Explosion", "Destiny Bond",
	},
	new string[]
	{
		 "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Zap_Cannon", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {110}, new string[] {"Level,35"}),


new PokemonData(110, "Weezing", PokemonData.Type.POISON, PokemonData.Type.NONE, "Levitate", null, null,
	50f, 60, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 9.5f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Poison Gas", "If one of the twin Koffing inflates, the other onedeflates. It constantly mixes its poisonous gases.",
	65, 90, 120, 85, 70, 60, 0, Color.clear,
	new int[] { 1, 1, 1, 9, 21, 25, 33, 44, 51},
	new string[]
	{
		 "Tackle", "Self-Destruct", "Poison Gas", "Smog", "Sludge", "Smokescreen", "Haze", "Explosion", "Destiny Bond",
	},
	new string[]
	{
		 "Hyper_Beam", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Zap_Cannon", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(111, "Rhyhorn", PokemonData.Type.GROUND, PokemonData.Type.ROCK, "Lightning-rod", "Rock-head", "Reckless",
	50f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1f, 115f,
	69, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Spikes", "Strong, but not too bright, this Pokémon canshatter even a skyscraper with its charging Tackles.",
	80, 85, 95, 30, 30, 25, 0, Color.clear,
	new int[] { 1, 1, 13, 19, 31, 37, 49, 55},
	new string[]
	{
		 "Horn Attack", "Tail Whip", "Stomp", "Fury Attack", "Scary Face", "Horn Drill", "Take Down", "Earthquake",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Blizzard", "Strength", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {112}, new string[] {"Level,42"}),


new PokemonData(112, "Rhydon", PokemonData.Type.GROUND, PokemonData.Type.ROCK, "Lightning-rod", "Rock-head", "Reckless",
	50f, 60, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1.9f, 120f,
	170, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Drill", "Protected by an armor-like hide, it is capable ofliving in molten lava of 3,600 degrees Fahrenheit.",
	105, 130, 120, 45, 45, 40, 0, Color.clear,
	new int[] { 1, 1, 1, 31, 54, 65},
	new string[]
	{
		 "Stomp", "Fury Attack", "Tail Whip", "Scary Face", "Take Down", "Earthquake",
	},
	new string[]
	{
		 "Fire_Punch", "Thunder_Punch", "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Sandstorm", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(113, "Chansey", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Natural-cure", "Serene-grace", "Healer",
	0f, 30, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.1f, 34.6f,
	395, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
	"Egg", "It is said to deliver happiness. Being compassionate, it shares its eggswith injured people.",
	250, 5, 5, 35, 105, 50, 0, Color.clear,
	new int[] { 1, 5, 9, 13, 17, 23, 29, 35, 41, 49, 57},
	new string[]
	{
		 "Pound", "Growl", "Tail Whip", "Soft-Boiled", "Double Slap", "Minimize", "Sing", "Egg Bomb", "Defense Curl", "Light Screen", "Double-Edge",
	},
	new string[]
	{
		 "Headbutt", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(114, "Tangela", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Leaf-guard", "Regenerator",
	50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1f, 35f,
	87, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Vine", "Many writhing vines cover it, so its true identityremains unknown. The blue vines grow its wholelife long.",
	65, 55, 115, 100, 40, 60, 0, Color.clear,
	new int[] { 1, 4, 10, 13, 19, 25, 31, 34, 40, 46},
	new string[]
	{
		 "Constrict", "Sleep Powder", "Absorb", "Poison Powder", "Vine Whip", "Bind", "Mega Drain", "Stun Spore", "Slam", "Growth",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day", "Psych_Up"
	},
	new int[] {}, new string[] {}),


new PokemonData(115, "Kangaskhan", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Early-bird", "Scrappy", "Inner-focus",
	0f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.2f, 80f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Parent", "It raises its offspring in its belly pouch. It lets thebaby out to play only when it feels safe.",
	105, 95, 80, 40, 80, 90, 0, Color.clear,
	new int[] { 1, 7, 13, 19, 25, 31, 37, 43, 49},
	new string[]
	{
		 "Comet Punch", "Leer", "Bite", "Tail Whip", "Mega Punch", "Rage", "Endure", "Dizzy Punch", "Reversal",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Sandstorm", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(116, "Horsea", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Sniper", "Damp",
	50f, 225, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 8f,
	59, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Dragon", "Known to shoot down flying bugs with precisionblasts of ink from the surface of the water.",
	30, 40, 70, 70, 25, 60, 0, Color.clear,
	new int[] { 1, 8, 15, 22, 29, 36, 43},
	new string[]
	{
		 "Bubble", "Smokescreen", "Leer", "Water Gun", "Twister", "Agility", "Hydro Pump",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {117}, new string[] {"Level,32"}),


new PokemonData(117, "Seadra", PokemonData.Type.WATER, PokemonData.Type.NONE, "Poison-point", "Sniper", "Damp",
	50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 25f,
	154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Dragon", "Its body bristles with sharp spikes. Carelessly tryingto touch it could cause fainting from the spikes.",
	55, 65, 95, 95, 45, 85, 0, Color.clear,
	new int[] { 1, 1, 22, 29, 40, 51},
	new string[]
	{
		 "Leer", "Smokescreen", "Water Gun", "Twister", "Agility", "Hydro Pump",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(118, "Goldeen", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Water-veil", "Lightning-rod",
	50f, 225, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 0.6f, 15f,
	64, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Goldfish", "It swims at a steady 5 knots. If it senses danger,it will strike back with its sharp horn.",
	45, 67, 60, 35, 50, 63, 0, Color.clear,
	new int[] { 1, 1, 10, 15, 24, 29, 38, 43, 52},
	new string[]
	{
		 "Tail Whip", "Peck", "Supersonic", "Horn Attack", "Flail", "Fury Attack", "Waterfall", "Horn Drill", "Agility",
	},
	new string[]
	{
		 "Surf", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance"
	},
	new int[] {119}, new string[] {"Level,33"}),


new PokemonData(119, "Seaking", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Water-veil", "Lightning-rod",
	50f, 60, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 1.3f, 39f,
	158, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Goldfish", "In the autumn spawning season, they can be seenswimming powerfully up rivers and creeks.",
	80, 92, 65, 65, 80, 68, 0, Color.clear,
	new int[] { 1, 1, 10, 15, 24, 29, 41, 49, 61},
	new string[]
	{
		 "Tail Whip", "Peck", "Supersonic", "Horn Attack", "Flail", "Fury Attack", "Waterfall", "Horn Drill", "Agility",
	},
	new string[]
	{
		 "Surf", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance"
	},
	new int[] {}, new string[] {}),


new PokemonData(120, "Staryu", PokemonData.Type.WATER, PokemonData.Type.NONE, "Illuminate", "Natural-cure", "Analytic",
	112.5f, 225, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.8f, 34.5f,
	68, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Star Shape", "Even if its body is torn, it can regenerate as long asthe glowing central core remains intact.",
	30, 45, 55, 70, 55, 85, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 50},
	new string[]
	{
		 "Tackle", "Harden", "Water Gun", "Rapid Spin", "Recover", "Swift", "Bubble Beam", "Minimize", "Light Screen", "Hydro Pump",
	},
	new string[]
	{
		 "Surf", "Blizzard", "Thunder", "Toxic", "Psychic", "Double_Team", "Waterfall", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(121, "Starmie", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Illuminate", "Natural-cure", "Analytic",
	112.5f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.1f, 80f,
	182, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
	"Mysterious", "Its central core glows with the seven colors of therainbow. Some people value the core as a gem.",
	60, 75, 85, 100, 85, 115, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 37},
	new string[]
	{
		 "Tackle", "Bubble Beam", "Recover", "Rapid Spin", "Confuse Ray",
	},
	new string[]
	{
		 "Surf", "Blizzard", "Hyper_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Waterfall", "Swift", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(122, "Mr-mime", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Soundproof", "Filter", "Technician",
	50f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.3f, 54.5f,
	161, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PINK, 70,
	"Barrier", "Emanations from its fingertips solidify the air intoinvisible walls that repel even harsh attacks.",
	40, 45, 65, 100, 120, 90, 0, Color.clear,
	new int[] { 1, 6, 11, 16, 21, 26, 26, 31, 36, 41, 46},
	new string[]
	{
		 "Barrier", "Confusion", "Substitute", "Meditate", "Double Slap", "Light Screen", "Reflect", "Encore", "Psybeam", "Baton Pass", "Safeguard",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Solar_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(123, "Scyther", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", "Technician", "Steadfast",
	50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.5f, 56f,
	100, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Mantis", "It tears and shreds prey with its wickedly sharpscythes. It very rarely spreads its wings to fly.",
	70, 110, 80, 55, 80, 105, 0, Color.clear,
	new int[] { 1, 1, 6, 12, 18, 24, 30, 36, 42, 48},
	new string[]
	{
		 "Leer", "Quick Attack", "Focus Energy", "Pursuit", "False Swipe", "Agility", "Wing Attack", "Slash", "Swords Dance", "Double Team",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Detect", "Endure", "Swagger", "Fury_Cutter", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {124}, new string[] {"Level,30"}),


new PokemonData(124, "Jynx", PokemonData.Type.ICE, PokemonData.Type.PSYCHIC, "Oblivious", "Forewarn", "Dry-skin",
	0f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 40.6f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Human Shape", "It wiggles its hips as it walks. It cancause people to dance in unison with it.",
	65, 50, 35, 115, 95, 95, 0, Color.clear,
	new int[] { 1, 1, 1, 13, 21, 25, 35, 41, 51, 57},
	new string[]
	{
		 "Pound", "Lick", "Lovely Kiss", "Powder Snow", "Double Slap", "Ice Punch", "Mean Look", "Body Slam", "Perish Song", "Blizzard",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Blizzard", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Sweet_Scent", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball"
	},
	new int[] {125}, new string[] {"Level,30"}),


new PokemonData(125, "Electabuzz", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Vital-spirit",
	75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.1f, 30f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Electric", "Electricity runs across the surface of its body. In darkness, its entire body glows a whitish blue.",
	65, 83, 57, 95, 85, 105, 0, Color.clear,
	new int[] { 1, 1, 17, 25, 36, 47, 58},
	new string[]
	{
		 "Thunder Punch", "Quick Attack", "Light Screen", "Swift", "Screech", "Thunderbolt", "Thunder",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Strength", "Thunder", "Toxic", "Psychic", "Double_Team", "Swift", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash"
	},
	new int[] {126}, new string[] {"Level,30"}),


new PokemonData(126, "Magmar", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flame-body", null, "Vital-spirit",
	75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.3f, 44.5f,
	173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Spitfire", "Found near the mouth of a volcano. This fire-breather’s body temperature isnearly 2,200 degrees Fahrenheit.",
	65, 95, 57, 100, 85, 93, 0, Color.clear,
	new int[] { 1, 1, 1, 7, 25, 33, 41, 49},
	new string[]
	{
		 "Fire Punch", "Ember", "Smog", "Leer", "Smokescreen", "Sunny Day", "Flamethrower", "Confuse Ray",
	},
	new string[]
	{
		 "Fire_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Strength", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(127, "Pinsir", PokemonData.Type.BUG, PokemonData.Type.NONE, "Hyper-cutter", "Mold-breaker", "Moxie",
	50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.5f, 55f,
	175, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Stag Beetle", "It grips prey with its pincers until the prey is tornin half. What it can’t tear, it tosses far.",
	65, 125, 100, 55, 70, 85, 0, Color.clear,
	new int[] { 1, 7, 13, 19, 25, 31, 37, 43},
	new string[]
	{
		 "Vice Grip", "Focus Energy", "Bind", "Seismic Toss", "Harden", "Guillotine", "Submission", "Swords Dance",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Hyper_Beam", "Strength", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(128, "Tauros", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Intimidate", "Anger-point", "Sheer-force",
	100f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 88.4f,
	172, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
	"Wild Bull", "After heightening its will to fight by whipping itselfwith its three tails, it charges at full speed.",
	75, 100, 95, 40, 70, 110, 0, Color.clear,
	new int[] { 1, 4, 8, 13, 19, 26, 34, 43, 53},
	new string[]
	{
		 "Tackle", "Tail Whip", "Rage", "Horn Attack", "Scary Face", "Pursuit", "Rest", "Thrash", "Take Down",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(129, "Magikarp", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Rattled",
	50f, 255, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 0.9f, 10f,
	40, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Fish", "It is virtually worthless in terms of both power andspeed. It is the most weak and pathetic Pokémonin the world.",
	20, 10, 55, 15, 20, 80, 0, Color.clear,
	new int[] { 1, 15, 30},
	new string[]
	{
		 "Splash", "Tackle", "Flail",
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
	new int[] { 1, 20, 25, 30, 35, 40, 45, 50},
	new string[]
	{
		 "Thrash", "Bite", "Dragon Rage", "Leer", "Twister", "Hydro Pump", "Rain Dance", "Hyper Beam",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Icy_Wind", "Sandstorm", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(131, "Lapras", PokemonData.Type.WATER, PokemonData.Type.ICE, "Water-absorb", "Shell-armor", "Hydration",
	50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.5f, 220f,
	187, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Transport", "They have gentle hearts. Because they rarelyfight, many have been caught. Their numberhas dwindled.",
	130, 85, 80, 85, 95, 60, 0, Color.clear,
	new int[] { 1, 1, 1, 8, 15, 22, 29, 36, 43, 50, 57},
	new string[]
	{
		 "Growl", "Sing", "Water Gun", "Mist", "Body Slam", "Confuse Ray", "Perish Song", "Ice Beam", "Rain Dance", "Safeguard", "Hydro Pump",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
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
	new int[] { 1, 1, 8, 16, 23, 30, 36, 42},
	new string[]
	{
		 "Tackle", "Tail Whip", "Sand Attack", "Growl", "Quick Attack", "Bite", "Focus Energy", "Take Down",
	},
	new string[]
	{
		 "Headbutt", "Toxic", "Double_Team", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(134, "Vaporeon", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", null, "Hydration",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 29f,
	184, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Bubble Jet", "It prefers beautiful shores. With cells similar towater molecules, it could melt in water.",
	130, 65, 60, 110, 95, 65, 0, Color.clear,
	new int[] { 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
	new string[]
	{
		 "Tackle", "Tail Whip", "Sand Attack", "Water Gun", "Quick Attack", "Bite", "Aurora Beam", "Haze", "Acid Armor", "Hydro Pump",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(135, "Jolteon", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Volt-absorb", null, "Quick-feet",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 24.5f,
	184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
	"Lightning", "Every hair on its body starts to stand sharply onend if it becomes charged with electricity.",
	65, 65, 60, 110, 95, 130, 0, Color.clear,
	new int[] { 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
	new string[]
	{
		 "Tackle", "Tail Whip", "Sand Attack", "Thunder Shock", "Quick Attack", "Double Kick", "Pin Missile", "Thunder Wave", "Agility", "Thunder",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Hyper_Beam", "Thunder", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(136, "Flareon", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Guts",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 25f,
	184, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Flame", "It has a flame sac in its body. Its body temperaturetops 1,650 degrees Fahrenheit before battle.",
	65, 130, 60, 95, 110, 65, 0, Color.clear,
	new int[] { 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
	new string[]
	{
		 "Tackle", "Tail Whip", "Sand Attack", "Ember", "Quick Attack", "Bite", "Fire Spin", "Smog", "Leer", "Flamethrower",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Hyper_Beam", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(137, "Porygon", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Trace", "Download", "Analytic",
	112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.8f, 36.5f,
	79, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Virtual", "A man-made Pokémon that came aboutas a result of research. It is programmedwith only basic motions.",
	65, 60, 70, 85, 75, 40, 0, Color.clear,
	new int[] { 1, 1, 1, 9, 12, 20, 24, 32, 36, 44},
	new string[]
	{
		 "Tackle", "Conversion", "Conversion 2", "Agility", "Psybeam", "Recover", "Sharpen", "Lock-On", "Tri Attack", "Zap Cannon",
	},
	new string[]
	{
		 "Blizzard", "Hyper_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Swift", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Icy_Wind", "Endure", "Swagger", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up"
	},
	new int[] {}, new string[] {}),


new PokemonData(138, "Omanyte", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Shell-armor", "Weak-armor",
	87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 7.5f,
	71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Spiral", "A prehistoric Pokémon that lived in the primordialsea, it swims by twisting its 10 tentacles about.",
	35, 40, 100, 90, 55, 35, 0, Color.clear,
	new int[] { 1, 1, 13, 19, 31, 37, 49, 55},
	new string[]
	{
		 "Withdraw", "Constrict", "Bite", "Water Gun", "Leer", "Protect", "Ancient Power", "Hydro Pump",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Icy_Wind", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {139}, new string[] {"Level,40"}),


new PokemonData(139, "Omastar", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Shell-armor", "Weak-armor",
	87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1f, 35f,
	173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Spiral", "Its tentacles are highly developed as if they arehands and feet. As soon as it ensnares prey,it bites.",
	70, 60, 125, 115, 70, 55, 0, Color.clear,
	new int[] { 1, 1, 1, 31, 37, 40, 54, 65},
	new string[]
	{
		 "Bite", "Withdraw", "Constrict", "Leer", "Protect", "Spike Cannon", "Ancient Power", "Hydro Pump",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Icy_Wind", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(140, "Kabuto", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Battle-armor", "Weak-armor",
	87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 11.5f,
	71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Shellfish", "It is thought to have inhabited beaches 300 millionyears ago. It is protected by a stiff shell.",
	30, 80, 90, 55, 45, 55, 0, Color.clear,
	new int[] { 1, 1, 10, 19, 28, 37, 46, 55},
	new string[]
	{
		 "Scratch", "Harden", "Absorb", "Leer", "Sand Attack", "Endure", "Mega Drain", "Ancient Power",
	},
	new string[]
	{
		 "Blizzard", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Icy_Wind", "Sandstorm", "Giga_Drain", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash"
	},
	new int[] {141}, new string[] {"Level,40"}),


new PokemonData(141, "Kabutops", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Battle-armor", "Weak-armor",
	87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.3f, 40.5f,
	173, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Shellfish", "In the water, it tucks in its limbs to become morecompact, then it wiggles its shell to swim fast.",
	60, 115, 105, 65, 70, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 19, 28, 37, 40, 65},
	new string[]
	{
		 "Scratch", "Absorb", "Harden", "Leer", "Sand Attack", "Endure", "Slash", "Ancient Power",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Icy_Wind", "Sandstorm", "Giga_Drain", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(142, "Aerodactyl", PokemonData.Type.ROCK, PokemonData.Type.FLYING, "Rock-head", "Pressure", "Unnerve",
	87.5f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.8f, 59f,
	180, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
	"Fossil", "It was regenerated from a dinosaur’s geneticmatter that was found in amber. It flies withhigh-pitched cries.",
	80, 105, 65, 60, 75, 130, 0, Color.clear,
	new int[] { 1, 8, 15, 22, 29, 36, 43, 50},
	new string[]
	{
		 "Wing Attack", "Agility", "Bite", "Supersonic", "Ancient Power", "Scary Face", "Take Down", "Hyper Beam",
	},
	new string[]
	{
		 "Fly", "Headbutt", "Roar", "Hyper_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Detect", "Sandstorm", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(143, "Snorlax", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Immunity", "Thick-fat", "Gluttony",
	87.5f, 25, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.1f, 460f,
	189, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
	"Sleeping", "It is not satisfied unless it eats over 880 pounds offood every day. When it is done eating, it goespromptly to sleep.",
	160, 110, 65, 65, 110, 30, 0, Color.clear,
	new int[] { 1, 8, 15, 22, 29, 36, 36, 43, 50, 57},
	new string[]
	{
		 "Tackle", "Amnesia", "Defense Curl", "Belly Drum", "Headbutt", "Rest", "Snore", "Body Slam", "Rollout", "Hyper Beam",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(144, "Articuno", PokemonData.Type.ICE, PokemonData.Type.FLYING, "Pressure", null, "Snow-cloak",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.7f, 55.4f,
	261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.BLUE, 35,
	"Freeze", "A legendary bird Pokémon. It can create blizzardsby freezing moisture in the air.",
	90, 85, 100, 95, 125, 85, 0, Color.clear,
	new int[] { 1, 1, 13, 25, 37, 49, 61, 73},
	new string[]
	{
		 "Gust", "Powder Snow", "Mist", "Agility", "Mind Reader", "Ice Beam", "Reflect", "Blizzard",
	},
	new string[]
	{
		 "Fly", "Roar", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Sandstorm", "Endure", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(145, "Zapdos", PokemonData.Type.ELECTRIC, PokemonData.Type.FLYING, "Pressure", null, "Static",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.6f, 52.6f,
	261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
	"Electric", "A legendary bird Pokémon that is said toappear from clouds while dropping enormouslightning bolts.",
	90, 90, 85, 125, 90, 100, 0, Color.clear,
	new int[] { 1, 1, 13, 25, 37, 49, 61, 73},
	new string[]
	{
		 "Peck", "Thunder Shock", "Thunder Wave", "Agility", "Detect", "Drill Peck", "Light Screen", "Thunder",
	},
	new string[]
	{
		 "Fly", "Roar", "Hyper_Beam", "Thunder", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Sandstorm", "Endure", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(146, "Moltres", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Pressure", null, "Flame-body",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 60f,
	261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
	"Flame", "It is said to be the legendary bird Pokémon of fire. Every flap of its wings creates a dazzling flareof flames.",
	90, 100, 90, 125, 85, 90, 0, Color.clear,
	new int[] { 1, 1, 13, 25, 37, 49, 61, 73},
	new string[]
	{
		 "Wing Attack", "Ember", "Fire Spin", "Agility", "Endure", "Flamethrower", "Safeguard", "Sky Attack",
	},
	new string[]
	{
		 "Fly", "Roar", "Hyper_Beam", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Sandstorm", "Endure", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(147, "Dratini", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Shed-skin", null, "Marvel-scale",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.8f, 3.3f,
	60, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
	"Dragon", "It is called the “Mirage Pokémon” because so fewhave seen it. Its shed skin has been found.",
	41, 64, 45, 50, 50, 50, 0, Color.clear,
	new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50, 57},
	new string[]
	{
		 "Wrap", "Leer", "Thunder Wave", "Twister", "Dragon Rage", "Slam", "Agility", "Safeguard", "Outrage", "Hyper Beam",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Rain_Dance"
	},
	new int[] {148}, new string[] {"Level,30"}),


new PokemonData(148, "Dragonair", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Shed-skin", null, "Marvel-scale",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 4f, 16.5f,
	147, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
	"Dragon", "Its crystalline orbs appear to give this Pokémonthe power to freely control the weather.",
	61, 84, 65, 70, 70, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 22, 29, 47, 56, 65},
	new string[]
	{
		 "Wrap", "Leer", "Thunder Wave", "Twister", "Dragon Rage", "Slam", "Safeguard", "Outrage", "Hyper Beam",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Rain_Dance"
	},
	new int[] {149}, new string[] {"Level,55"}),


new PokemonData(149, "Dragonite", PokemonData.Type.DRAGON, PokemonData.Type.FLYING, "Inner-focus", null, "Multiscale",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 2.2f, 210f,
	270, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 35,
	"Dragon", "It can fly in spite of its big and bulky physique. It circles the globe in just 16 hours.",
	91, 134, 95, 100, 100, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 22, 29, 47, 55, 61, 75},
	new string[]
	{
		 "Wrap", "Leer", "Thunder Wave", "Twister", "Dragon Rage", "Slam", "Safeguard", "Wing Attack", "Outrage", "Hyper Beam",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Fly", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Detect", "Sandstorm", "Endure", "Swagger", "Fury_Cutter", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(150, "Mewtwo", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Pressure", null, "Unnerve",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 122f,
	306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.PURPLE, 0,
	"Genetic", "It was created by a scientist after years of horrificgene-splicing and DNA-engineering experiments.",
	106, 110, 90, 154, 90, 130, 0, Color.clear,
	new int[] { 1, 1, 11, 22, 33, 44, 55, 66, 77, 88, 99},
	new string[]
	{
		 "Disable", "Confusion", "Barrier", "Swift", "Psych Up", "Future Sight", "Mist", "Psychic", "Amnesia", "Recover", "Safeguard",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Swift", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Detect", "Endure", "Swagger", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(151, "Mew", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", null, null,
	112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.4f, 4f,
	270, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 100,
	"New Species", "Because it can use all kinds of moves, manyscientists believe Mew to be the ancestorof Pokémon.",
	100, 100, 100, 100, 100, 100, 0, Color.clear,
	new int[] { 1, 10, 20, 30, 40, 50},
	new string[]
	{
		 "Pound", "Transform", "Mega Punch", "Metronome", "Psychic", "Ancient Power",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Cut", "Fly", "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunder", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Waterfall", "Swift", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Detect", "Sandstorm", "Giga_Drain", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Dragon_Breath", "Sweet_Scent", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(152, "Chikorita", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Leaf-guard",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 6.4f,
	64, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
	"Leaf", "A sweet aroma gently wafts from the leaf on itshead. It is docile and loves to soak up sun rays.",
	45, 49, 65, 49, 65, 45, 0, Color.clear,
	new int[] { 1, 1, 8, 12, 15, 22, 29, 36, 43, 50},
	new string[]
	{
		 "Tackle", "Growl", "Razor Leaf", "Reflect", "Poison Powder", "Synthesis", "Body Slam", "Light Screen", "Safeguard", "Solar Beam",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Iron_Tail", "Hidden_Power", "Sunny_Day"
	},
	new int[] {153}, new string[] {"Level,16"}),


new PokemonData(153, "Bayleef", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Leaf-guard",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 15.8f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
	"Leaf", "A spicy aroma emanates from around its neck. The aroma acts as a stimulant to restore health.",
	60, 62, 80, 63, 80, 60, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 15, 23, 31, 39},
	new string[]
	{
		 "Tackle", "Growl", "Razor Leaf", "Reflect", "Poison Powder", "Synthesis", "Body Slam", "Light Screen",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Giga_Drain", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {154}, new string[] {"Level,32"}),


new PokemonData(154, "Meganium", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Leaf-guard",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1.8f, 100.5f,
	236, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 2, 0, PokemonData.PokedexColor.GREEN, 70,
	"Herb", "The aroma that rises from its petals contains asubstance that calms aggressive feelings.",
	80, 82, 100, 83, 100, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 15, 23, 31, 41},
	new string[]
	{
		 "Tackle", "Growl", "Razor Leaf", "Reflect", "Poison Powder", "Synthesis", "Body Slam", "Light Screen",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Giga_Drain", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(155, "Cyndaquil", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Flash-fire",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 7.9f,
	62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Fire Mouse", "It is timid and always curls itself up in a ball. If attacked, it flares up its back for protection.",
	39, 52, 43, 60, 50, 65, 0, Color.clear,
	new int[] { 1, 1, 6, 12, 19, 27, 36, 46},
	new string[]
	{
		 "Tackle", "Leer", "Smokescreen", "Ember", "Quick Attack", "Flame Wheel", "Swift", "Flamethrower",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day"
	},
	new int[] {156}, new string[] {"Level,14"}),


new PokemonData(156, "Quilava", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Flash-fire",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 19f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Volcano", "Before battle, it turns its back on its opponent todemonstrate how ferociously its fire blazes.",
	58, 64, 58, 80, 65, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 12, 21, 31, 54},
	new string[]
	{
		 "Tackle", "Leer", "Smokescreen", "Ember", "Quick Attack", "Flame Wheel", "Flamethrower",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Roar", "Strength", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {157}, new string[] {"Level,36"}),


new PokemonData(157, "Typhlosion", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Flash-fire",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.7f, 79.5f,
	240, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Volcano", "If its rage peaks, it becomes so hot that anythingthat touches it will instantly go up in flames.",
	78, 84, 78, 109, 85, 100, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 21, 31},
	new string[]
	{
		 "Tackle", "Leer", "Ember", "Smokescreen", "Quick Attack", "Flame Wheel",
	},
	new string[]
	{
		 "Fire_Punch", "Thunder_Punch", "Cut", "Headbutt", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(158, "Totodile", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Sheer-force",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 9.5f,
	63, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Big Jaw", "It is small but rough and tough. It won’t hesitate totake a bite out of anything that moves.",
	50, 65, 64, 44, 48, 43, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 20, 27, 35, 43, 52},
	new string[]
	{
		 "Scratch", "Leer", "Rage", "Water Gun", "Bite", "Scary Face", "Slash", "Screech", "Hydro Pump",
	},
	new string[]
	{
		 "Ice_Punch", "Cut", "Headbutt", "Surf", "Blizzard", "Dig", "Toxic", "Double_Team", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {159}, new string[] {"Level,18"}),


new PokemonData(159, "Croconaw", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Sheer-force",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.1f, 25f,
	142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Big Jaw", "If it loses a fang, a new one grows back in itsplace. There are always 48 fangs lining its mouth.",
	65, 80, 80, 59, 63, 58, 0, Color.clear,
	new int[] { 1, 1, 1, 13, 21, 28, 37, 55},
	new string[]
	{
		 "Scratch", "Leer", "Rage", "Water Gun", "Bite", "Scary Face", "Slash", "Hydro Pump",
	},
	new string[]
	{
		 "Ice_Punch", "Cut", "Headbutt", "Roar", "Surf", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {160}, new string[] {"Level,30"}),


new PokemonData(160, "Feraligatr", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Sheer-force",
	87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.3f, 88.8f,
	239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Big Jaw", "It usually moves slowly, but it goes at blindingspeed when it attacks and bites prey.",
	85, 105, 100, 79, 83, 78, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 21, 28, 38},
	new string[]
	{
		 "Scratch", "Leer", "Water Gun", "Rage", "Bite", "Scary Face", "Slash",
	},
	new string[]
	{
		 "Ice_Punch", "Cut", "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(161, "Sentret", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Keen-eye", "Frisk",
	50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 6f,
	43, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Scout", "When acting as a lookout, it warns others of dangerby screeching and hitting the ground with its tail.",
	35, 46, 34, 35, 45, 20, 0, Color.clear,
	new int[] { 1, 5, 11, 17, 25, 33, 41},
	new string[]
	{
		 "Tackle", "Defense Curl", "Quick Attack", "Fury Swipes", "Slam", "Rest", "Amnesia",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Cut", "Headbutt", "Surf", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Shadow_Ball"
	},
	new int[] {162}, new string[] {"Level,15"}),


new PokemonData(162, "Furret", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Keen-eye", "Frisk",
	50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.8f, 32.5f,
	145, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
	"Long Body", "The mother puts its offspring to sleep by curling uparound them. It corners foes with speed.",
	85, 76, 64, 45, 55, 90, 0, Color.clear,
	new int[] { 1, 1, 5, 18, 28, 38, 48},
	new string[]
	{
		 "Scratch", "Quick Attack", "Defense Curl", "Fury Swipes", "Slam", "Rest", "Amnesia",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Cut", "Headbutt", "Surf", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(163, "Hoothoot", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Insomnia", "Keen-eye", "Tinted-lens",
	50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.7f, 21.2f,
	52, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Owl", "It has a perfect sense of time. Whatever happens,it keeps rhythm by precisely tilting its head in time.",
	60, 30, 30, 36, 56, 50, 0, Color.clear,
	new int[] { 1, 1, 6, 11, 16, 22, 28, 34, 48},
	new string[]
	{
		 "Tackle", "Growl", "Foresight", "Peck", "Hypnosis", "Reflect", "Take Down", "Confusion", "Dream Eater",
	},
	new string[]
	{
		 "Fly", "Toxic", "Double_Team", "Swift", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {164}, new string[] {"Level,20"}),


new PokemonData(164, "Noctowl", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Insomnia", "Keen-eye", "Tinted-lens",
	50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.6f, 40.8f,
	158, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Owl", "Its eyes are specially adapted. They concentrateeven faint light and enable it to see in the dark.",
	100, 50, 50, 86, 96, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 16, 25, 33, 57},
	new string[]
	{
		 "Tackle", "Growl", "Peck", "Foresight", "Hypnosis", "Reflect", "Take Down", "Dream Eater",
	},
	new string[]
	{
		 "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(165, "Ledyba", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", "Early-bird", "Rattled",
	50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1f, 10.8f,
	53, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.RED, 70,
	"Five Star", "When the weather turns cold, lots of Ledyba gatherfrom everywhere to cluster and keep eachother warm.",
	40, 20, 30, 40, 80, 55, 0, Color.clear,
	new int[] { 1, 8, 15, 22, 22, 22, 29, 36, 43, 50},
	new string[]
	{
		 "Tackle", "Supersonic", "Comet Punch", "Light Screen", "Reflect", "Safeguard", "Baton Pass", "Swift", "Agility", "Double-Edge",
	},
	new string[]
	{
		 "Ice_Punch", "Thunder_Punch", "Headbutt", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Giga_Drain", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {166}, new string[] {"Level,18"}),


new PokemonData(166, "Ledian", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", "Early-bird", "Iron-fist",
	50f, 90, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.4f, 35.6f,
	137, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.RED, 70,
	"Five Star", "When the stars flicker in the night sky, it fluttersabout, scattering a glowing powder.",
	55, 35, 50, 55, 110, 85, 0, Color.clear,
	new int[] { 1, 1, 15, 24, 24, 24, 33, 42, 60},
	new string[]
	{
		 "Tackle", "Supersonic", "Comet Punch", "Light Screen", "Reflect", "Safeguard", "Baton Pass", "Swift", "Double-Edge",
	},
	new string[]
	{
		 "Ice_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Giga_Drain", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(167, "Spinarak", PokemonData.Type.BUG, PokemonData.Type.POISON, "Swarm", "Insomnia", "Sniper",
	50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.5f, 8.5f,
	50, PokemonData.LevelingRate.FAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"String Spit", "It spins a web using fine--but durable--thread. It then waits patiently for prey to be trapped.",
	40, 60, 40, 40, 40, 30, 0, Color.clear,
	new int[] { 1, 1, 6, 11, 17, 23, 30, 37, 45, 53},
	new string[]
	{
		 "Poison Sting", "String Shot", "Scary Face", "Constrict", "Night Shade", "Leech Life", "Fury Swipes", "Spider Web", "Screech", "Psychic",
	},
	new string[]
	{
		 "Solar_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {168}, new string[] {"Level,22"}),


new PokemonData(168, "Ariados", PokemonData.Type.BUG, PokemonData.Type.POISON, "Swarm", "Insomnia", "Sniper",
	50f, 90, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.1f, 33.5f,
	140, PokemonData.LevelingRate.FAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Long Leg", "It spins string not only from its rear but also fromits mouth. It’s hard to tell which end is which.",
	70, 90, 70, 60, 70, 40, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 17, 34, 43, 53, 63},
	new string[]
	{
		 "Poison Sting", "String Shot", "Constrict", "Scary Face", "Night Shade", "Fury Swipes", "Spider Web", "Screech", "Psychic",
	},
	new string[]
	{
		 "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(169, "Crobat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
	50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.8f, 75f,
	241, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.PURPLE, 70,
	"Bat", "It flies so silently through the dark on its four wingsthat it may not be noticed even when nearby.",
	85, 90, 80, 70, 80, 130, 0, Color.clear,
	new int[] { 1, 1, 12, 19, 30, 42, 55},
	new string[]
	{
		 "Supersonic", "Leech Life", "Bite", "Confuse Ray", "Wing Attack", "Mean Look", "Haze",
	},
	new string[]
	{
		 "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Detect", "Giga_Drain", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(170, "Chinchou", PokemonData.Type.WATER, PokemonData.Type.ELECTRIC, "Volt-absorb", "Illuminate", "Water-absorb",
	50f, 190, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.5f, 12f,
	66, PokemonData.LevelingRate.SLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Angler", "On the dark ocean floor, its only means ofcommunication is its constantly flashing lights.",
	75, 38, 38, 56, 56, 67, 0, Color.clear,
	new int[] { 1, 1, 5, 13, 17, 25, 29, 37, 41},
	new string[]
	{
		 "Thunder Wave", "Bubble", "Supersonic", "Flail", "Water Gun", "Spark", "Confuse Ray", "Take Down", "Hydro Pump",
	},
	new string[]
	{
		 "Surf", "Thunder", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {171}, new string[] {"Level,27"}),


new PokemonData(171, "Lanturn", PokemonData.Type.WATER, PokemonData.Type.ELECTRIC, "Volt-absorb", "Illuminate", "Water-absorb",
	50f, 75, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 1.2f, 22.5f,
	161, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Light", "Lanturn’s light can shine up from great depths. It is nicknamed “The Deep-Sea Star. ",
	125, 58, 58, 76, 76, 67, 0, Color.clear,
	new int[] { 1, 1, 1, 13, 25, 33, 45, 53},
	new string[]
	{
		 "Supersonic", "Thunder Wave", "Bubble", "Flail", "Spark", "Confuse Ray", "Take Down", "Hydro Pump",
	},
	new string[]
	{
		 "Surf", "Hyper_Beam", "Thunder", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(172, "Pichu", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Lightning-rod",
	50f, 190, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 2f,
	41, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Tiny Mouse", "It plays with others by touching tails and setting offsparks. This appears to be a test of courage.",
	20, 40, 15, 35, 35, 60, 0, Color.clear,
	new int[] { 1, 1, 6, 8, 11},
	new string[]
	{
		 "Thunder Shock", "Charm", "Tail Whip", "Thunder Wave", "Sweet Kiss",
	},
	new string[]
	{
		 "Headbutt", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance"
	},
	new int[] {}, new string[] {}),


new PokemonData(173, "Cleffa", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Cute-charm", "Magic-guard", "Friend-guard",
	25f, 150, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 3f,
	44, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PINK, 140,
	"Star Shape", "Because of its unusual, starlike silhouette, peoplebelieve that it came here on a meteor.",
	50, 25, 28, 45, 55, 15, 0, Color.clear,
	new int[] { 1, 1, 4, 8, 13},
	new string[]
	{
		 "Pound", "Charm", "Encore", "Sing", "Sweet Kiss",
	},
	new string[]
	{
		 "Headbutt", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(174, "Igglybuff", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Cute-charm", "Competitive", "Friend-guard",
	25f, 170, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 1f,
	42, PokemonData.LevelingRate.FAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Balloon", "Instead of walking with its short legs, it movesaround by bouncing on its soft, tender body.",
	90, 30, 15, 40, 20, 15, 0, Color.clear,
	new int[] { 1, 1, 4, 9, 14},
	new string[]
	{
		 "Sing", "Charm", "Defense Curl", "Pound", "Sweet Kiss",
	},
	new string[]
	{
		 "Headbutt", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(175, "Togepi", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Hustle", "Serene-grace", "Super-luck",
	87.5f, 190, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 1.5f,
	49, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.WHITE, 70,
	"Spike Ball", "The shell seems to be filled with joy. It is said thatit will share good luck when treated kindly.",
	35, 20, 65, 40, 65, 20, 0, Color.clear,
	new int[] { 1, 1, 7, 18, 25, 31, 38},
	new string[]
	{
		 "Growl", "Charm", "Metronome", "Sweet Kiss", "Encore", "Safeguard", "Double-Edge",
	},
	new string[]
	{
		 "Headbutt", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Swift", "Dream_Eater", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(176, "Togetic", PokemonData.Type.FAIRY, PokemonData.Type.FLYING, "Hustle", "Serene-grace", "Super-luck",
	87.5f, 75, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.6f, 3.2f,
	142, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.WHITE, 70,
	"Happiness", "It grows dispirited if it is not with kind people. It can float in midair without moving its wings.",
	55, 40, 85, 80, 105, 40, 0, Color.clear,
	new int[] { 1, 1, 7, 18, 25, 31, 38},
	new string[]
	{
		 "Growl", "Charm", "Metronome", "Sweet Kiss", "Encore", "Safeguard", "Double-Edge",
	},
	new string[]
	{
		 "Fly", "Headbutt", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Swift", "Dream_Eater", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Rollout", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(177, "Natu", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Synchronize", "Early-bird", "Magic-bounce",
	50f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.2f, 2f,
	64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 70,
	"Tiny Bird", "Because its wings aren’t yet fully grown, it hasto hop to get around. It is always staringat something.",
	40, 50, 45, 70, 45, 70, 0, Color.clear,
	new int[] { 1, 1, 10, 20, 30, 40, 50},
	new string[]
	{
		 "Leer", "Peck", "Night Shade", "Teleport", "Future Sight", "Confuse Ray", "Psychic",
	},
	new string[]
	{
		 "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Swift", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Detect", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up"
	},
	new int[] {178}, new string[] {"Level,25"}),


new PokemonData(178, "Xatu", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Synchronize", "Early-bird", "Magic-bounce",
	50f, 75, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.5f, 15f,
	165, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.GREEN, 70,
	"Mystic", "Once it begins to meditate at sunrise, the entire daywill pass before it will move again.",
	65, 75, 70, 95, 70, 95, 0, Color.clear,
	new int[] { 1, 1, 1, 20, 35, 65},
	new string[]
	{
		 "Leer", "Peck", "Night Shade", "Teleport", "Future Sight", "Psychic",
	},
	new string[]
	{
		 "Fly", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Swift", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Detect", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up"
	},
	new int[] {}, new string[] {}),


new PokemonData(179, "Mareep", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Plus",
	50f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 7.8f,
	56, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.WHITE, 70,
	"Wool", "Its fluffy coat swells to double when staticelectricity builds up. Touching it can be shocking.",
	55, 40, 40, 65, 45, 35, 0, Color.clear,
	new int[] { 1, 1, 9, 16, 23, 30, 37},
	new string[]
	{
		 "Tackle", "Growl", "Thunder Shock", "Thunder Wave", "Cotton Spore", "Light Screen", "Thunder",
	},
	new string[]
	{
		 "Headbutt", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance"
	},
	new int[] {180}, new string[] {"Level,15"}),


new PokemonData(180, "Flaaffy", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Plus",
	50f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.8f, 13.3f,
	128, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Wool", "Its fluffy fleece easily stores electricity. Its rubberyhide keeps it from being electrocuted.",
	70, 55, 55, 80, 60, 45, 0, Color.clear,
	new int[] { 1, 1, 1, 27, 36, 45},
	new string[]
	{
		 "Tackle", "Growl", "Thunder Shock", "Cotton Spore", "Light Screen", "Thunder",
	},
	new string[]
	{
		 "Fire_Punch", "Thunder_Punch", "Headbutt", "Strength", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash"
	},
	new int[] {181}, new string[] {"Level,30"}),


new PokemonData(181, "Ampharos", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Plus",
	50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.4f, 61.5f,
	230, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Light", "The tail’s tip shines brightly and can be seen fromfar away. It acts as a beacon for lost people.",
	90, 75, 85, 115, 90, 55, 0, Color.clear,
	new int[] { 1, 1, 1, 18, 27, 30, 42, 57},
	new string[]
	{
		 "Tackle", "Growl", "Thunder Shock", "Thunder Wave", "Cotton Spore", "Thunder Punch", "Light Screen", "Thunder",
	},
	new string[]
	{
		 "Fire_Punch", "Thunder_Punch", "Headbutt", "Hyper_Beam", "Strength", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(182, "Bellossom", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", null, "Healer",
	50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 5.8f,
	221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.GREEN, 70,
	"Flower", "Bellossom gather at times and seem to dance. They say that the dance is a ritual to summonthe sun.",
	75, 80, 95, 90, 100, 50, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 55},
	new string[]
	{
		 "Absorb", "Stun Spore", "Petal Dance", "Sweet Scent", "Solar Beam",
	},
	new string[]
	{
		 "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(183, "Marill", PokemonData.Type.WATER, PokemonData.Type.FAIRY, "Thick-fat", "Huge-power", "Sap-sipper",
	50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 8.5f,
	88, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Aqua Mouse", "The fur on its body naturally repels water. It canstay dry, even when it plays in the water.",
	70, 20, 50, 20, 50, 40, 0, Color.clear,
	new int[] { 1, 3, 6, 10, 15, 21, 28, 36},
	new string[]
	{
		 "Tackle", "Defense Curl", "Tail Whip", "Water Gun", "Rollout", "Bubble Beam", "Double-Edge", "Rain Dance",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Toxic", "Double_Team", "Defense_Curl", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {184}, new string[] {"Level,18"}),


new PokemonData(184, "Azumarill", PokemonData.Type.WATER, PokemonData.Type.FAIRY, "Thick-fat", "Huge-power", "Sap-sipper",
	50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 28.5f,
	189, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Aqua Rabbit", "Its long ears are superb sensors. It can distinguishthe movements of living things on riverbeds.",
	100, 50, 80, 60, 80, 50, 0, Color.clear,
	new int[] { 1, 1, 1, 10, 25, 36, 48},
	new string[]
	{
		 "Tackle", "Tail Whip", "Defense Curl", "Water Gun", "Bubble Beam", "Double-Edge", "Rain Dance",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Toxic", "Double_Team", "Defense_Curl", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(185, "Sudowoodo", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Sturdy", "Rock-head", "Rattled",
	50f, 65, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 257, 1.2f, 38f,
	144, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Imitation", "Although it always pretends to be a tree, itscomposition appears more similar to rock thanto vegetation.",
	70, 100, 115, 30, 65, 30, 0, Color.clear,
	new int[] { 1, 1, 10, 19, 28, 37, 46},
	new string[]
	{
		 "Rock Throw", "Mimic", "Flail", "Low Kick", "Rock Slide", "Feint Attack", "Slam",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(186, "Politoed", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", "Damp", "Drizzle",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1.1f, 33.9f,
	225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.GREEN, 70,
	"Frog", "Whenever three or more of these get together,they sing in a loud voice that sounds like bellowing.",
	90, 75, 75, 90, 100, 70, 0, Color.clear,
	new int[] { 1, 1, 1, 1},
	new string[]
	{
		 "Double Slap", "Water Gun", "Hypnosis", "Perish Song",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Waterfall", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(187, "Hoppip", PokemonData.Type.GRASS, PokemonData.Type.FLYING, "Chlorophyll", "Leaf-guard", "Infiltrator",
	50f, 255, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 0.5f,
	50, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PINK, 70,
	"Cottonweed", "Its body is so light, it must grip the ground firmlywith its feet to keep from being blown away.",
	35, 35, 40, 35, 55, 50, 0, Color.clear,
	new int[] { 1, 1, 5, 10, 13, 15, 17, 20, 25, 30},
	new string[]
	{
		 "Splash", "Synthesis", "Tail Whip", "Tackle", "Poison Powder", "Stun Spore", "Sleep Powder", "Leech Seed", "Cotton Spore", "Mega Drain",
	},
	new string[]
	{
		 "Headbutt", "Solar_Beam", "Toxic", "Double_Team", "Defense_Curl", "Flash", "Rest", "Snore", "Curse", "Protect", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {188}, new string[] {"Level,18"}),


new PokemonData(188, "Skiploom", PokemonData.Type.GRASS, PokemonData.Type.FLYING, "Chlorophyll", "Leaf-guard", "Infiltrator",
	50f, 120, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.6f, 1f,
	119, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
	"Cottonweed", "The bloom on top of its head opens and closesas the temperature fluctuates up and down.",
	55, 45, 50, 45, 65, 80, 0, Color.clear,
	new int[] { 1, 1, 1, 5, 13, 15, 17, 22, 29, 36},
	new string[]
	{
		 "Tackle", "Splash", "Synthesis", "Tail Whip", "Poison Powder", "Stun Spore", "Sleep Powder", "Leech Seed", "Cotton Spore", "Mega Drain",
	},
	new string[]
	{
		 "Headbutt", "Solar_Beam", "Toxic", "Double_Team", "Defense_Curl", "Flash", "Rest", "Snore", "Curse", "Protect", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {189}, new string[] {"Level,27"}),


new PokemonData(189, "Jumpluff", PokemonData.Type.GRASS, PokemonData.Type.FLYING, "Chlorophyll", "Leaf-guard", "Infiltrator",
	50f, 45, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.8f, 3f,
	207, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.BLUE, 70,
	"Cottonweed", "Blown by seasonal winds, it circles the globe,scattering cotton spores as it goes.",
	75, 55, 70, 55, 95, 110, 0, Color.clear,
	new int[] { 1, 1, 1, 5, 13, 15, 17, 22, 33, 44},
	new string[]
	{
		 "Tackle", "Splash", "Synthesis", "Tail Whip", "Poison Powder", "Stun Spore", "Sleep Powder", "Leech Seed", "Cotton Spore", "Mega Drain",
	},
	new string[]
	{
		 "Headbutt", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Defense_Curl", "Flash", "Rest", "Snore", "Curse", "Protect", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(190, "Aipom", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Pickup", "Skill-link",
	50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.8f, 11.5f,
	72, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
	"Long Tail", "It lives atop tall trees. When leaping from branch tobranch, it deftly uses its tail for balance.",
	55, 70, 55, 40, 55, 85, 0, Color.clear,
	new int[] { 1, 1, 6, 12, 19, 27, 36, 46},
	new string[]
	{
		 "Scratch", "Tail Whip", "Sand Attack", "Baton Pass", "Fury Swipes", "Swift", "Screech", "Agility",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Cut", "Headbutt", "Strength", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(191, "Sunkern", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Solar-power", "Early-bird",
	50f, 235, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.3f, 1.8f,
	36, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Seed", "It may plummet from the sky. If attacked by aSpearow, it will violently shake its leaves.",
	30, 30, 30, 30, 30, 30, 0, Color.clear,
	new int[] { 1, 4, 10, 19, 31, 46},
	new string[]
	{
		 "Absorb", "Growth", "Mega Drain", "Sunny Day", "Synthesis", "Giga Drain",
	},
	new string[]
	{
		 "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(192, "Sunflora", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Solar-power", "Early-bird",
	50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.8f, 8.5f,
	149, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Sun", "As the hot season approaches, the petals on thisPokémon’s face become more vivid and lively.",
	75, 75, 55, 105, 85, 30, 0, Color.clear,
	new int[] { 1, 1, 4, 10, 19, 31, 46},
	new string[]
	{
		 "Pound", "Absorb", "Growth", "Razor Leaf", "Sunny Day", "Petal Dance", "Solar Beam",
	},
	new string[]
	{
		 "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(193, "Yanma", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Speed-boost", "Compound-eyes", "Frisk",
	50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.2f, 38f,
	78, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Clear Wing", "Its eyes can see 360 degrees without moving itshead. It won’t miss prey--even those behind it.",
	65, 65, 45, 75, 45, 95, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43},
	new string[]
	{
		 "Tackle", "Foresight", "Quick Attack", "Double Team", "Sonic Boom", "Detect", "Supersonic", "Swift", "Screech",
	},
	new string[]
	{
		 "Headbutt", "Solar_Beam", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Detect", "Giga_Drain", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(194, "Wooper", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Damp", "Water-absorb", "Unaware",
	50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 0.4f, 8.5f,
	42, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Water Fish", "This Pokémon lives in cold water. It will leave thewater to search for food when it gets cold outside.",
	55, 45, 45, 25, 25, 15, 0, Color.clear,
	new int[] { 1, 1, 11, 21, 31, 41, 51, 51},
	new string[]
	{
		 "Tail Whip", "Water Gun", "Slam", "Amnesia", "Earthquake", "Rain Dance", "Mist", "Haze",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {195}, new string[] {"Level,20"}),


new PokemonData(195, "Quagsire", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Damp", "Water-absorb", "Unaware",
	50f, 90, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1.4f, 75f,
	151, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Water Fish", "It has a sluggish nature. It lies at the river’s bottom,waiting for prey to stray into its mouth.",
	95, 85, 85, 65, 65, 35, 0, Color.clear,
	new int[] { 1, 1, 11, 23, 35, 47, 59, 59},
	new string[]
	{
		 "Tail Whip", "Water Gun", "Slam", "Amnesia", "Earthquake", "Rain Dance", "Mist", "Haze",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(196, "Espeon", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", null, "Magic-bounce",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 26.5f,
	184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Sun", "The tip of its forked tail quivers when it is predictingits opponent’s next move.",
	65, 65, 60, 130, 95, 110, 0, Color.clear,
	new int[] { 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
	new string[]
	{
		 "Tackle", "Tail Whip", "Sand Attack", "Confusion", "Quick Attack", "Swift", "Psybeam", "Psych Up", "Psychic", "Morning Sun",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Swift", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(197, "Umbreon", PokemonData.Type.DARK, PokemonData.Type.NONE, "Synchronize", null, "Inner-focus",
	87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 27f,
	184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLACK, 35,
	"Moonlight", "The light of the moon changed Eevee’s geneticstructure. It lurks in darkness for prey.",
	95, 65, 110, 60, 130, 65, 0, Color.clear,
	new int[] { 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
	new string[]
	{
		 "Tackle", "Tail Whip", "Sand Attack", "Pursuit", "Quick Attack", "Confuse Ray", "Feint Attack", "Mean Look", "Screech", "Moonlight",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Swift", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(198, "Murkrow", PokemonData.Type.DARK, PokemonData.Type.FLYING, "Insomnia", "Super-luck", "Prankster",
	50f, 30, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 0.5f, 2.1f,
	81, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLACK, 35,
	"Darkness", "It hides any shiny object it finds in a secretlocation. Murkrow and Meowth loot oneanother’s stashes.",
	60, 85, 42, 85, 42, 91, 0, Color.clear,
	new int[] { 1, 11, 16, 26, 31, 41},
	new string[]
	{
		 "Peck", "Pursuit", "Haze", "Night Shade", "Feint Attack", "Mean Look",
	},
	new string[]
	{
		 "Fly", "Toxic", "Double_Team", "Swift", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(199, "Slowking", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
	50f, 70, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2f, 79.5f,
	172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.PINK, 70,
	"Royal", "It has incredible intellect and intuition. Whateverthe situation, it remains calm and collected.",
	95, 75, 80, 100, 110, 30, 0, Color.clear,
	new int[] { 1, 1, 6, 15, 20, 29, 34, 43, 48},
	new string[]
	{
		 "Tackle", "Curse", "Growl", "Water Gun", "Confusion", "Disable", "Headbutt", "Swagger", "Psychic",
	},
	new string[]
	{
		 "Ice_Punch", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Swift", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(200, "Misdreavus", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Levitate", null, null,
	50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.7f, 1f,
	87, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GRAY, 35,
	"Screech", "It gets nourishment from fear that it absorbs into itsred orbs. In daytime, it sleeps in darkness.",
	60, 60, 60, 85, 85, 85, 0, Color.clear,
	new int[] { 1, 1, 6, 12, 19, 27, 36, 46},
	new string[]
	{
		 "Growl", "Psywave", "Spite", "Confuse Ray", "Mean Look", "Psybeam", "Pain Split", "Perish Song",
	},
	new string[]
	{
		 "Headbutt", "Thunder", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Swift", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(201, "Unown", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Levitate", null, null,
	112.5f, 225, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.5f, 5f,
	118, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.BLACK, 70,
	"Symbol", "Its flat, thin body is always stuck on walls. Its shapeappears to have some meaning.",
	48, 72, 48, 72, 48, 48, 0, Color.clear,
	new int[] { 1},
	new string[]
	{
		 "Hidden Power",
	},
	new string[]
	{
		
	},
	new int[] {202}, new string[] {"Level,15"}),


new PokemonData(202, "Wobbuffet", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Shadow-tag", null, "Telepathy",
	50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 257, 1.3f, 28.5f,
	142, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Patient", "It hates light and shock. If attacked, it inflates itsbody to build up its counterstrike.",
	190, 33, 58, 33, 58, 33, 0, Color.clear,
	new int[] { 1, 1, 1, 1},
	new string[]
	{
		 "Counter", "Destiny Bond", "Safeguard", "Mirror Coat",
	},
	new string[]
	{
		
	},
	new int[] {}, new string[] {}),


new PokemonData(203, "Girafarig", PokemonData.Type.NORMAL, PokemonData.Type.PSYCHIC, "Inner-focus", "Early-bird", "Sap-sipper",
	50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.5f, 41.5f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Long Neck", "While it sleeps, the head on its tail keeps watch. The tail doesn’t need to sleep.",
	70, 80, 65, 90, 65, 85, 0, Color.clear,
	new int[] { 1, 1, 1, 30, 41, 54},
	new string[]
	{
		 "Stomp", "Growl", "Confusion", "Baton Pass", "Psybeam", "Crunch",
	},
	new string[]
	{
		 "Headbutt", "Strength", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Swift", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(204, "Pineco", PokemonData.Type.BUG, PokemonData.Type.NONE, "Sturdy", null, "Overcoat",
	50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.6f, 7.2f,
	58, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Bagworm", "It likes to make its shell thicker by adding layers oftree bark. The additional weight doesn’t bother it.",
	50, 65, 90, 35, 35, 15, 0, Color.clear,
	new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50},
	new string[]
	{
		 "Tackle", "Protect", "Self-Destruct", "Take Down", "Rapid Spin", "Bide", "Explosion", "Spikes", "Double-Edge",
	},
	new string[]
	{
		 "Headbutt", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Snore", "Curse", "Protect", "Giga_Drain", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {205}, new string[] {"Level,31"}),


new PokemonData(205, "Forretress", PokemonData.Type.BUG, PokemonData.Type.STEEL, "Sturdy", null, "Overcoat",
	50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.2f, 125.8f,
	163, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Bagworm", "It is encased in a steel shell. Its peering eyes areall that can be seen of its mysterious innards.",
	75, 90, 140, 60, 60, 40, 0, Color.clear,
	new int[] { 1, 1, 1, 15, 22, 29, 49, 59},
	new string[]
	{
		 "Tackle", "Self-Destruct", "Protect", "Take Down", "Rapid Spin", "Bide", "Spikes", "Double-Edge",
	},
	new string[]
	{
		 "Headbutt", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Snore", "Curse", "Protect", "Sandstorm", "Giga_Drain", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(206, "Dunsparce", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Serene-grace", "Run-away", "Rattled",
	50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.5f, 14f,
	145, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Land Snake", "When spotted, this Pokémon escapes backward byfuriously boring into the ground with its tail.",
	100, 70, 70, 65, 65, 45, 0, Color.clear,
	new int[] { 1, 5, 13, 18, 26, 30, 38},
	new string[]
	{
		 "Rage", "Defense Curl", "Glare", "Spite", "Pursuit", "Screech", "Take Down",
	},
	new string[]
	{
		 "Headbutt", "Strength", "Solar_Beam", "Thunder", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(207, "Gligar", PokemonData.Type.GROUND, PokemonData.Type.FLYING, "Hyper-cutter", "Sand-veil", "Immunity",
	50f, 60, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.1f, 64.8f,
	86, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Fly Scorpion", "It usually clings to cliffs. When it spots its prey,it spreads its wings and glides down to attack.",
	65, 75, 105, 35, 65, 85, 0, Color.clear,
	new int[] { 1, 6, 13, 20, 28, 36, 44, 52},
	new string[]
	{
		 "Poison Sting", "Sand Attack", "Harden", "Quick Attack", "Feint Attack", "Slash", "Screech", "Guillotine",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Strength", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Detect", "Sandstorm", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(208, "Steelix", PokemonData.Type.STEEL, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sheer-force",
	50f, 25, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 257, 9.2f, 400f,
	179, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Iron Snake", "Tempered underground under high pressure andheat, its body is harder than any metal.",
	75, 85, 200, 55, 65, 30, 0, Color.clear,
	new int[] { 1, 1, 10, 14, 23, 27, 36, 40, 49},
	new string[]
	{
		 "Tackle", "Screech", "Bind", "Rock Throw", "Harden", "Rage", "Sandstorm", "Slam", "Crunch",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(209, "Snubbull", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Intimidate", "Run-away", "Rattled",
	25f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 7.8f,
	60, PokemonData.LevelingRate.FAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Fairy", "It has an active, playful nature. Many women like tofrolic with it because of its affectionate ways.",
	60, 80, 50, 40, 40, 30, 0, Color.clear,
	new int[] { 1, 1, 4, 8, 13, 19, 26, 34, 43},
	new string[]
	{
		 "Tackle", "Scary Face", "Tail Whip", "Charm", "Bite", "Lick", "Roar", "Rage", "Take Down",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Roar", "Strength", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {210}, new string[] {"Level,23"}),


new PokemonData(210, "Granbull", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Intimidate", "Quick-feet", "Rattled",
	25f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 48.7f,
	158, PokemonData.LevelingRate.FAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Fairy", "It is timid in spite of its looks. If it becomesenraged, however, it will strike with its huge fangs.",
	90, 120, 75, 60, 60, 45, 0, Color.clear,
	new int[] { 1, 1, 4, 8, 13, 19, 28, 38, 51},
	new string[]
	{
		 "Tackle", "Scary Face", "Tail Whip", "Charm", "Bite", "Lick", "Roar", "Rage", "Take Down",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Roar", "Hyper_Beam", "Strength", "Thunder", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Thief", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(211, "Qwilfish", PokemonData.Type.WATER, PokemonData.Type.POISON, "Poison-point", "Swift-swim", "Intimidate",
	50f, 45, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.5f, 3.9f,
	88, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Balloon", "To fire its poison spikes, it must inflate its body bydrinking over 2. 6 gallons of water all at once.",
	65, 95, 85, 55, 55, 85, 0, Color.clear,
	new int[] { 1, 1, 10, 10, 19, 28, 37, 46},
	new string[]
	{
		 "Tackle", "Poison Sting", "Harden", "Minimize", "Water Gun", "Pin Missile", "Take Down", "Hydro Pump",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Toxic", "Double_Team", "Defense_Curl", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Icy_Wind", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(212, "Scizor", PokemonData.Type.BUG, PokemonData.Type.STEEL, "Swarm", "Technician", "Light-metal",
	50f, 25, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.8f, 118f,
	175, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Pincer", "This Pokémon’s pincers, which contain steel, cancrush any hard object it gets ahold of into bits.",
	70, 130, 100, 55, 80, 65, 0, Color.clear,
	new int[] { 1, 1, 6, 12, 18, 24, 30, 36, 42, 48},
	new string[]
	{
		 "Leer", "Quick Attack", "Focus Energy", "Pursuit", "False Swipe", "Agility", "Metal Claw", "Slash", "Swords Dance", "Double Team",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Hyper_Beam", "Strength", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Detect", "Sandstorm", "Endure", "Swagger", "Fury_Cutter", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(213, "Shuckle", PokemonData.Type.BUG, PokemonData.Type.ROCK, "Sturdy", "Gluttony", "Contrary",
	50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.6f, 20.5f,
	177, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.YELLOW, 70,
	"Mold", "The berries stored in its jar-like shell eventuallybecome a thick, pulpy juice.",
	20, 10, 230, 10, 230, 5, 0, Color.clear,
	new int[] { 1, 1, 9, 14, 23, 28, 37},
	new string[]
	{
		 "Withdraw", "Constrict", "Wrap", "Encore", "Safeguard", "Bide", "Rest",
	},
	new string[]
	{
		 "Headbutt", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Flash", "Rest", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(214, "Heracross", PokemonData.Type.BUG, PokemonData.Type.FIGHTING, "Swarm", "Guts", "Moxie",
	50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.5f, 54f,
	175, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Single Horn", "This powerful Pokémon thrusts its prized horn underits enemies’ bellies, then lifts and throws them.",
	80, 125, 75, 40, 95, 85, 0, Color.clear,
	new int[] { 1, 1, 6, 12, 19, 27, 35, 44, 54},
	new string[]
	{
		 "Tackle", "Leer", "Horn Attack", "Endure", "Fury Attack", "Counter", "Take Down", "Reversal", "Megahorn",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Thief", "Snore", "Curse", "Protect", "Detect", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(215, "Sneasel", PokemonData.Type.DARK, PokemonData.Type.ICE, "Inner-focus", "Keen-eye", "Pickpocket",
	50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.9f, 28f,
	86, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLACK, 35,
	"Sharp Claw", "It feeds on eggs stolen from nests. Its sharplyhooked claws rip vulnerable spots on prey.",
	55, 95, 55, 35, 75, 115, 0, Color.clear,
	new int[] { 1, 1, 9, 17, 25, 33, 41, 49, 57},
	new string[]
	{
		 "Scratch", "Leer", "Quick Attack", "Screech", "Feint Attack", "Fury Swipes", "Agility", "Slash", "Beat Up",
	},
	new string[]
	{
		 "Ice_Punch", "Cut", "Headbutt", "Surf", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(216, "Teddiursa", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Quick-feet", "Honey-gather",
	50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 8.8f,
	66, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Little Bear", "If it finds honey, its crescent mark glows. It alwayslicks its paws because they’re soaked with honey.",
	60, 80, 50, 50, 50, 40, 0, Color.clear,
	new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50},
	new string[]
	{
		 "Scratch", "Leer", "Lick", "Fury Swipes", "Feint Attack", "Rest", "Slash", "Snore", "Thrash",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Cut", "Headbutt", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {217}, new string[] {"Level,30"}),


new PokemonData(217, "Ursaring", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Guts", "Quick-feet", "Unnerve",
	50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.8f, 125.8f,
	175, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Hibernator", "With its ability to distinguish any aroma, itunfailingly finds all food buried deep underground.",
	90, 130, 75, 75, 75, 55, 0, Color.clear,
	new int[] { 1, 1, 1, 15, 22, 29, 39, 49, 59},
	new string[]
	{
		 "Scratch", "Leer", "Lick", "Fury Swipes", "Feint Attack", "Rest", "Slash", "Snore", "Thrash",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Cut", "Headbutt", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Endure", "Rollout", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(218, "Slugma", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Magma-armor", "Flame-body", "Weak-armor",
	50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.7f, 35f,
	50, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Lava", "A common sight in volcanic areas, it slowly slithersaround in a constant search for warm places.",
	40, 40, 40, 70, 40, 20, 0, Color.clear,
	new int[] { 1, 8, 15, 22, 29, 36, 43, 50},
	new string[]
	{
		 "Smog", "Ember", "Rock Throw", "Harden", "Amnesia", "Flamethrower", "Rock Slide", "Body Slam",
	},
	new string[]
	{
		 "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {219}, new string[] {"Level,38"}),


new PokemonData(219, "Magcargo", PokemonData.Type.FIRE, PokemonData.Type.ROCK, "Magma-armor", "Flame-body", "Weak-armor",
	50f, 75, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.8f, 55f,
	151, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Lava", "Its brittle shell occasionally spouts intense flamesthat circulate throughout its body.",
	60, 50, 120, 90, 80, 30, 0, Color.clear,
	new int[] { 1, 1, 1, 29, 48, 60},
	new string[]
	{
		 "Ember", "Rock Throw", "Smog", "Amnesia", "Rock Slide", "Body Slam",
	},
	new string[]
	{
		 "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Defense_Curl", "Fire_Blast", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(220, "Swinub", PokemonData.Type.ICE, PokemonData.Type.GROUND, "Oblivious", "Snow-cloak", "Thick-fat",
	50f, 225, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 6.5f,
	50, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Pig", "It rubs its snout on the ground to find and dig upfood. It sometimes discovers hot springs.",
	50, 50, 40, 30, 30, 50, 0, Color.clear,
	new int[] { 1, 10, 19, 28, 37, 46},
	new string[]
	{
		 "Tackle", "Powder Snow", "Endure", "Take Down", "Mist", "Blizzard",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Blizzard", "Strength", "Earthquake", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash"
	},
	new int[] {221}, new string[] {"Level,33"}),


new PokemonData(221, "Piloswine", PokemonData.Type.ICE, PokemonData.Type.GROUND, "Oblivious", "Snow-cloak", "Thick-fat",
	50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.1f, 55.8f,
	158, PokemonData.LevelingRate.SLOW, 1, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Swine", "Although its legs are short, its rugged hoovesprevent it from slipping, even on icy ground.",
	100, 100, 80, 60, 60, 50, 0, Color.clear,
	new int[] { 1, 1, 19, 28, 33, 42, 56},
	new string[]
	{
		 "Horn Attack", "Powder Snow", "Endure", "Take Down", "Fury Attack", "Mist", "Blizzard",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(222, "Corsola", PokemonData.Type.WATER, PokemonData.Type.ROCK, "Hustle", "Natural-cure", "Regenerator",
	25f, 60, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 5f,
	144, PokemonData.LevelingRate.FAST, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.PINK, 70,
	"Coral", "It continuously sheds and grows. The tip of its headis prized as a treasure because of its beauty.",
	65, 55, 95, 65, 95, 35, 0, Color.clear,
	new int[] { 1, 7, 13, 19, 25, 31, 37, 43},
	new string[]
	{
		 "Tackle", "Harden", "Bubble", "Recover", "Bubble Beam", "Spike Cannon", "Mirror Coat", "Ancient Power",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(223, "Remoraid", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hustle", "Sniper", "Moody",
	50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 12f,
	60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Jet", "It has superb accuracy. The water it shoots out canstrike moving prey from more than 300 feet away.",
	35, 65, 35, 65, 35, 65, 0, Color.clear,
	new int[] { 1, 11, 22, 22, 22, 33, 44, 55},
	new string[]
	{
		 "Water Gun", "Lock-On", "Psybeam", "Bubble Beam", "Aurora Beam", "Focus Energy", "Ice Beam", "Hyper Beam",
	},
	new string[]
	{
		 "Surf", "Hyper_Beam", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {224}, new string[] {"Level,25"}),


new PokemonData(224, "Octillery", PokemonData.Type.WATER, PokemonData.Type.NONE, "Suction-cups", "Sniper", "Moody",
	50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 0.9f, 28.5f,
	168, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Jet", "It has a tendency to want to be in holes. It prefersrock crags or pots and sprays ink from thembefore attacking.",
	75, 105, 75, 105, 75, 45, 0, Color.clear,
	new int[] { 1, 11, 22, 22, 22, 25, 38, 54, 70},
	new string[]
	{
		 "Water Gun", "Constrict", "Psybeam", "Bubble Beam", "Aurora Beam", "Octazooka", "Focus Energy", "Ice Beam", "Hyper Beam",
	},
	new string[]
	{
		 "Surf", "Hyper_Beam", "Toxic", "Double_Team", "Defense_Curl", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(225, "Delibird", PokemonData.Type.ICE, PokemonData.Type.FLYING, "Vital-spirit", "Hustle", "Insomnia",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.9f, 16f,
	116, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Delivery", "It carries food rolled up in its tail. It has the habit ofsharing food with people lost in mountains.",
	45, 55, 45, 65, 45, 75, 0, Color.clear,
	new int[] { 1},
	new string[]
	{
		 "Present",
	},
	new string[]
	{
		 "Fly", "Headbutt", "Blizzard", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance"
	},
	new int[] {}, new string[] {}),


new PokemonData(226, "Mantine", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Swift-swim", "Water-absorb", "Water-veil",
	50f, 25, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 2.1f, 220f,
	170, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Kite", "If it builds up enough speed swimming, it can flyover 300 feet out of the water from the surface ofthe ocean.",
	85, 40, 70, 80, 140, 70, 0, Color.clear,
	new int[] { 1, 1, 10, 18, 25, 32, 40, 49},
	new string[]
	{
		 "Tackle", "Bubble", "Supersonic", "Bubble Beam", "Take Down", "Agility", "Wing Attack", "Confuse Ray",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(227, "Skarmory", PokemonData.Type.STEEL, PokemonData.Type.FLYING, "Keen-eye", "Sturdy", "Weak-armor",
	50f, 25, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.7f, 50.5f,
	163, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Armor Bird", "After nesting in bramble bushes, the wings of itschicks grow hard from scratches by thorns.",
	65, 80, 140, 40, 70, 70, 0, Color.clear,
	new int[] { 1, 1, 13, 19, 25, 37, 49},
	new string[]
	{
		 "Leer", "Peck", "Sand Attack", "Swift", "Agility", "Fury Attack", "Steel Wing",
	},
	new string[]
	{
		 "Cut", "Fly", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Sandstorm", "Endure", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(228, "Houndour", PokemonData.Type.DARK, PokemonData.Type.FIRE, "Early-bird", "Flash-fire", "Unnerve",
	50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 10.8f,
	66, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLACK, 35,
	"Dark", "Around dawn, its ominous howl echoes throughthe area to announce that this is its territory.",
	45, 60, 30, 80, 50, 65, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 20, 27, 35, 43},
	new string[]
	{
		 "Leer", "Ember", "Roar", "Smog", "Bite", "Feint Attack", "Flamethrower", "Crunch",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {229}, new string[] {"Level,24"}),


new PokemonData(229, "Houndoom", PokemonData.Type.DARK, PokemonData.Type.FIRE, "Early-bird", "Flash-fire", "Unnerve",
	50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.4f, 35f,
	175, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLACK, 35,
	"Dark", "Long ago, people imagined its eerie howls to bethe call of the grim reaper.",
	75, 90, 50, 110, 80, 95, 0, Color.clear,
	new int[] { 1, 1, 7, 13, 20, 30, 41, 52},
	new string[]
	{
		 "Leer", "Ember", "Roar", "Smog", "Bite", "Feint Attack", "Flamethrower", "Crunch",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Sludge_Bomb", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(230, "Kingdra", PokemonData.Type.WATER, PokemonData.Type.DRAGON, "Swift-swim", "Sniper", "Damp",
	50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.8f, 152f,
	243, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 1, 1, 0, PokemonData.PokedexColor.BLUE, 70,
	"Dragon", "It is said that it usually hides in underwater caves. It can create whirlpools by yawning.",
	75, 95, 95, 95, 95, 85, 0, Color.clear,
	new int[] { 1, 1, 22, 29, 40, 51},
	new string[]
	{
		 "Leer", "Smokescreen", "Water Gun", "Twister", "Agility", "Hydro Pump",
	},
	new string[]
	{
		 "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Hidden_Power", "Rain_Dance", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(231, "Phanpy", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Pickup", null, "Sand-veil",
	50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 33.5f,
	66, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
	"Long Nose", "As a sign of affection, it bumps with its snout. However, it is so strong, it may send you flying.",
	90, 60, 60, 40, 40, 40, 0, Color.clear,
	new int[] { 1, 1, 9, 17, 25, 33, 41, 49},
	new string[]
	{
		 "Tackle", "Growl", "Defense Curl", "Flail", "Take Down", "Rollout", "Endure", "Double-Edge",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Strength", "Earthquake", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {232}, new string[] {"Level,25"}),


new PokemonData(232, "Donphan", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sturdy", null, "Sand-veil",
	50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.1f, 120f,
	175, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
	"Armor", "It has sharp, hard tusks and a rugged hide. Its Tackle is strong enough to knock down a house.",
	90, 120, 120, 60, 60, 50, 0, Color.clear,
	new int[] { 1, 1, 9, 17, 25, 33, 41, 49},
	new string[]
	{
		 "Horn Attack", "Growl", "Defense Curl", "Flail", "Fury Attack", "Rollout", "Rapid Spin", "Earthquake",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(233, "Porygon2", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Trace", "Download", "Analytic",
	112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.6f, 32.5f,
	180, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
	"Virtual", "Further research enhanced its abilities. Sometimes,it may exhibit motions that were not programmed.",
	85, 80, 90, 105, 95, 60, 0, Color.clear,
	new int[] { 1, 1, 1, 9, 12, 20, 24, 32, 36, 44},
	new string[]
	{
		 "Tackle", "Conversion", "Conversion 2", "Agility", "Psybeam", "Recover", "Defense Curl", "Lock-On", "Tri Attack", "Zap Cannon",
	},
	new string[]
	{
		 "Blizzard", "Hyper_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Swift", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Zap_Cannon", "Icy_Wind", "Endure", "Swagger", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up"
	},
	new int[] {}, new string[] {}),


new PokemonData(234, "Stantler", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Intimidate", "Frisk", "Sap-sipper",
	50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 71.2f,
	163, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
	"Big Horn", "Staring at its antlers creates an odd sensationas if one were being drawn into their centers.",
	73, 95, 62, 85, 65, 85, 0, Color.clear,
	new int[] { 1, 8, 15, 23, 31, 40, 49},
	new string[]
	{
		 "Tackle", "Leer", "Hypnosis", "Stomp", "Sand Attack", "Take Down", "Confuse Ray",
	},
	new string[]
	{
		 "Headbutt", "Roar", "Earthquake", "Toxic", "Psychic", "Double_Team", "Swift", "Dream_Eater", "Flash", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up"
	},
	new int[] {}, new string[] {}),


new PokemonData(235, "Smeargle", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Own-tempo", "Technician", "Moody",
	50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 58f,
	88, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.WHITE, 70,
	"Painter", "It marks its territory by using its tail like apaintbrush. There are more than 5,000different marks.",
	55, 20, 35, 20, 45, 75, 0, Color.clear,
	new int[] { 1},
	new string[]
	{
		 "Sketch",
	},
	new string[]
	{
		
	},
	new int[] {}, new string[] {}),


new PokemonData(236, "Tyrogue", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "Steadfast", "Vital-spirit",
	100f, 75, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.7f, 21f,
	42, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
	"Scuffle", "It is always bursting with energy. To make itselfstronger, it keeps on fighting even if it loses.",
	35, 35, 35, 35, 35, 35, 0, Color.clear,
	new int[] { 1},
	new string[]
	{
		 "Tackle",
	},
	new string[]
	{
		 "Headbutt", "Strength", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {237}, new string[] {"Level,20"}),


new PokemonData(237, "Hitmontop", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Intimidate", "Technician", "Steadfast",
	100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 48f,
	159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BROWN, 70,
	"Handstand", "It fights while spinning like a top. The centrifugalforce boosts its destructive power by 10.",
	50, 95, 95, 35, 110, 70, 0, Color.clear,
	new int[] { 1, 7, 13, 19, 25, 31, 37, 43, 49},
	new string[]
	{
		 "Rolling Kick", "Focus Energy", "Pursuit", "Quick Attack", "Rapid Spin", "Counter", "Agility", "Detect", "Triple Kick",
	},
	new string[]
	{
		 "Headbutt", "Strength", "Dig", "Toxic", "Double_Team", "Swift", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(238, "Smoochum", PokemonData.Type.ICE, PokemonData.Type.PSYCHIC, "Oblivious", "Forewarn", "Hydration",
	0f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.4f, 6f,
	61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Kiss", "Its lips are the most sensitive part of its body. It always uses its lips first to examine things.",
	45, 30, 15, 85, 65, 65, 0, Color.clear,
	new int[] { 1, 1, 9, 13, 21, 25, 33, 37, 45, 49},
	new string[]
	{
		 "Pound", "Lick", "Sweet Kiss", "Powder Snow", "Confusion", "Sing", "Mean Look", "Psychic", "Perish Song", "Blizzard",
	},
	new string[]
	{
		 "Ice_Punch", "Blizzard", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Thief", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Sweet_Scent", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball"
	},
	new int[] {}, new string[] {}),


new PokemonData(239, "Elekid", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Vital-spirit",
	75f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.6f, 23.5f,
	72, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
	"Electric", "It generates electricity by whirling its arms. However, it can’t store the energy it makes.",
	45, 63, 37, 65, 55, 95, 0, Color.clear,
	new int[] { 1, 1, 9, 17, 25, 33, 41, 49},
	new string[]
	{
		 "Leer", "Quick Attack", "Thunder Punch", "Light Screen", "Swift", "Screech", "Thunderbolt", "Thunder",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Thunder", "Toxic", "Psychic", "Double_Team", "Swift", "Flash", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance"
	},
	new int[] {}, new string[] {}),


new PokemonData(240, "Magby", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flame-body", null, "Vital-spirit",
	75f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.7f, 21.4f,
	73, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
	"Live Coal", "It’s small, but its body temperature is over1,100 degrees Fahrenheit. Embers escape itsmouth and nose when it breathes.",
	45, 75, 37, 70, 55, 83, 0, Color.clear,
	new int[] { 1, 7, 13, 19, 25, 31, 37, 43, 49},
	new string[]
	{
		 "Ember", "Leer", "Smog", "Fire Punch", "Smokescreen", "Sunny Day", "Flamethrower", "Confuse Ray", "Fire Blast",
	},
	new string[]
	{
		 "Fire_Punch", "Thunder_Punch", "Headbutt", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Iron_Tail", "Hidden_Power", "Sunny_Day"
	},
	new int[] {}, new string[] {}),


new PokemonData(241, "Miltank", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Thick-fat", "Scrappy", "Sap-sipper",
	0f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 75.5f,
	172, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
	"Milk Cow", "If it is around babies, the milk it produces containsmuch more nutrition than usual.",
	95, 80, 105, 40, 70, 100, 0, Color.clear,
	new int[] { 1, 4, 8, 13, 19, 26, 34, 43, 53},
	new string[]
	{
		 "Tackle", "Growl", "Defense Curl", "Stomp", "Milk Drink", "Bide", "Rollout", "Body Slam", "Heal Bell",
	},
	new string[]
	{
		 "Fire_Punch", "Ice_Punch", "Thunder_Punch", "Headbutt", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Earthquake", "Toxic", "Double_Team", "Defense_Curl", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Sweet_Scent", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(242, "Blissey", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Natural-cure", "Serene-grace", "Healer",
	0f, 30, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.5f, 46.8f,
	608, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
	"Happiness", "The eggs it lays are filled with happiness. Eatingeven one bite will bring a smile to anyone.",
	255, 10, 10, 75, 135, 55, 0, Color.clear,
	new int[] { 1, 4, 7, 10, 13, 18, 23, 28, 33, 40, 47},
	new string[]
	{
		 "Pound", "Growl", "Tail Whip", "Soft-Boiled", "Double Slap", "Minimize", "Sing", "Egg Bomb", "Defense Curl", "Light Screen", "Double-Edge",
	},
	new string[]
	{
		 "Headbutt", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunder", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Sandstorm", "Endure", "Rollout", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(243, "Raikou", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Pressure", null, "Inner-focus",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.9f, 178f,
	261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 2, PokemonData.PokedexColor.YELLOW, 35,
	"Thunder", "The rain clouds it carries let it fire thunderboltsat will. They say that it descended with lightning.",
	90, 85, 75, 115, 100, 115, 0, Color.clear,
	new int[] { 1, 1, 11, 21, 31, 41, 51, 61, 71},
	new string[]
	{
		 "Leer", "Bite", "Thunder Shock", "Roar", "Quick Attack", "Spark", "Reflect", "Crunch", "Thunder",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Roar", "Hyper_Beam", "Strength", "Thunder", "Dig", "Toxic", "Double_Team", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Sandstorm", "Endure", "Swagger", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(244, "Entei", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Pressure", null, "Inner-focus",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2.1f, 198f,
	261, PokemonData.LevelingRate.SLOW, 1, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 35,
	"Volcano", "A Pokémon that races across the land. It is saidthat one is born every time a new volcano appears.",
	115, 115, 85, 90, 75, 100, 0, Color.clear,
	new int[] { 1, 1, 11, 21, 31, 41, 51, 61, 71},
	new string[]
	{
		 "Leer", "Bite", "Ember", "Roar", "Fire Spin", "Stomp", "Flamethrower", "Swagger", "Fire Blast",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Swift", "Flash", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Sandstorm", "Endure", "Swagger", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(245, "Suicune", PokemonData.Type.WATER, PokemonData.Type.NONE, "Pressure", null, "Inner-focus",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 187f,
	261, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 2, 0, PokemonData.PokedexColor.BLUE, 35,
	"Aurora", "It races around the world to purify fouled water. It dashes away with the north wind.",
	100, 75, 115, 90, 115, 85, 0, Color.clear,
	new int[] { 1, 1, 11, 21, 31, 41, 51, 61, 71},
	new string[]
	{
		 "Leer", "Bite", "Water Gun", "Roar", "Gust", "Bubble Beam", "Mist", "Mirror Coat", "Hydro Pump",
	},
	new string[]
	{
		 "Cut", "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Waterfall", "Swift", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Icy_Wind", "Detect", "Sandstorm", "Endure", "Swagger", "Sleep_Talk", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(246, "Larvitar", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Guts", null, "Sand-veil",
	50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 72f,
	60, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 35,
	"Rock Skin", "It feeds on soil. After it has eaten a large mountain,it falls asleep so it can grow.",
	50, 64, 50, 45, 50, 41, 0, Color.clear,
	new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50, 57},
	new string[]
	{
		 "Leer", "Bite", "Sandstorm", "Screech", "Rock Slide", "Thrash", "Scary Face", "Crunch", "Earthquake", "Hyper Beam",
	},
	new string[]
	{
		 "Headbutt", "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Sandstorm", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day"
	},
	new int[] {247}, new string[] {"Level,30"}),


new PokemonData(247, "Pupitar", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Shed-skin", null, null,
	50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 152f,
	144, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 35,
	"Hard Shell", "Its body is as hard as bedrock. By ventingpressurized gas, it can launch itself like a rocket.",
	70, 84, 70, 65, 70, 51, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 29, 38, 56, 65},
	new string[]
	{
		 "Leer", "Bite", "Screech", "Sandstorm", "Thrash", "Scary Face", "Earthquake", "Hyper Beam",
	},
	new string[]
	{
		 "Headbutt", "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Sandstorm", "Endure", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day"
	},
	new int[] {248}, new string[] {"Level,55"}),


new PokemonData(248, "Tyranitar", PokemonData.Type.ROCK, PokemonData.Type.DARK, "Sand-stream", null, "Unnerve",
	50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2f, 202f,
	270, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 35,
	"Armor", "In just one of its mighty hands, it has the power tomake the ground shake and mountains crumble.",
	100, 134, 110, 95, 100, 61, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 29, 38, 61, 75},
	new string[]
	{
		 "Leer", "Bite", "Screech", "Sandstorm", "Thrash", "Scary Face", "Earthquake", "Hyper Beam",
	},
	new string[]
	{
		 "Fire_Punch", "Cut", "Headbutt", "Roar", "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Sandstorm", "Endure", "Swagger", "Fury_Cutter", "Attract", "Sleep_Talk", "Return", "Frustration", "Dynamic_Punch", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(249, "Lugia", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Pressure", null, "Multiscale",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 5.2f, 216f,
	306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.WHITE, 0,
	"Diving", "It sleeps in a deep-sea trench. If it flaps its wings,it is said to cause a 40-day storm.",
	106, 90, 130, 90, 154, 110, 0, Color.clear,
	new int[] { 1, 11, 22, 33, 44, 55, 66, 77, 88, 99},
	new string[]
	{
		 "Aeroblast", "Safeguard", "Gust", "Recover", "Hydro Pump", "Rain Dance", "Swift", "Whirlwind", "Ancient Power", "Future Sight",
	},
	new string[]
	{
		 "Fly", "Headbutt", "Roar", "Surf", "Blizzard", "Hyper_Beam", "Strength", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Waterfall", "Swift", "Dream_Eater", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Icy_Wind", "Detect", "Sandstorm", "Giga_Drain", "Endure", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Whirlpool"
	},
	new int[] {}, new string[] {}),


new PokemonData(250, "Ho-oh", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Pressure", null, "Regenerator",
	112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 3.8f, 199f,
	306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.RED, 0,
	"Rainbow", "A legend says that its body glows in seven colors. A rainbow is said to form behind it when it flies.",
	106, 130, 90, 110, 154, 90, 0, Color.clear,
	new int[] { 1, 11, 22, 33, 44, 55, 66, 77, 88, 99},
	new string[]
	{
		 "Sacred Fire", "Safeguard", "Gust", "Recover", "Fire Blast", "Sunny Day", "Swift", "Whirlwind", "Ancient Power", "Future Sight",
	},
	new string[]
	{
		 "Fly", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Swift", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Zap_Cannon", "Detect", "Sandstorm", "Giga_Drain", "Endure", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Dragon_Breath", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash"
	},
	new int[] {}, new string[] {}),


new PokemonData(251, "Celebi", PokemonData.Type.PSYCHIC, PokemonData.Type.GRASS, "Natural-cure", null, null,
	112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.6f, 5f,
	270, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 100,
	"Time Travel", "This Pokémon wanders across time. Grass and treesflourish in the forests in which it has appeared.",
	100, 100, 100, 100, 100, 100, 0, Color.clear,
	new int[] { 1, 1, 1, 1, 10, 20, 30, 40, 50},
	new string[]
	{
		 "Leech Seed", "Confusion", "Recover", "Heal Bell", "Safeguard", "Ancient Power", "Future Sight", "Baton Pass", "Perish Song",
	},
	new string[]
	{
		 "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Defense_Curl", "Swift", "Dream_Eater", "Flash", "Rest", "Nightmare", "Snore", "Curse", "Protect", "Mud_Slap", "Detect", "Sandstorm", "Giga_Drain", "Endure", "Swagger", "Sleep_Talk", "Return", "Frustration", "Sweet_Scent", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball"
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
