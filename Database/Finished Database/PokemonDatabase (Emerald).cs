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
         "Cut", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Overheat", "Aerial_Ace", "Dragon_Claw"
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
         "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Overheat", "Aerial_Ace", "Dragon_Claw"
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
         "Cut", "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Overheat", "Aerial_Ace", "Dragon_Claw"
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
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Water_Pulse"
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
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Water_Pulse"
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
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Water_Pulse"
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
    new int[] { 1, 13, 14, 15, 18, 23, 28, 34, 47},
    new string[]
    {
         "Confusion", "Poison Powder", "Stun Spore", "Sleep Powder", "Supersonic", "Whirlwind", "Gust", "Psybeam", "Silver Wind",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Aerial_Ace"
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
    new int[] { 1, 15, 25, 30, 35, 40, 45},
    new string[]
    {
         "Fury Attack", "Focus Energy", "Rage", "Pursuit", "Pin Missile", "Agility", "Endeavor",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(16, "Pidgey", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 1.8f,
    50, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Tiny Bird", "A common sight in forests and woods. It flapsits wings at ground level to kick up blinding sand.",
    40, 45, 40, 35, 35, 56, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 19, 25, 31, 39, 47},
    new string[]
    {
         "Tackle", "Sand Attack", "Gust", "Quick Attack", "Whirlwind", "Wing Attack", "Feather Dance", "Agility", "Mirror Move",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {17}, new string[] {"Level,18"}),


new PokemonData(17, "Pidgeotto", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
    50f, 120, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.1f, 30f,
    122, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Bird", "The claws on its feet are well developed. It can carry prey such as an Exeggcuteto its nest over 60 miles away.",
    63, 60, 55, 50, 50, 71, 0, Color.clear,
    new int[] { 1, 1, 13, 20, 34, 43, 52},
    new string[]
    {
         "Gust", "Sand Attack", "Quick Attack", "Whirlwind", "Feather Dance", "Agility", "Mirror Move",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {18}, new string[] {"Level,36"}),


new PokemonData(18, "Pidgeot", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.5f, 39.5f,
    216, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.BROWN, 70,
    "Bird", "When hunting, it skims the surface of waterat high speed to pick off unwary prey suchas Magikarp.",
    83, 80, 75, 70, 70, 101, 0, Color.clear,
    new int[] { 1, 1, 1, 20, 34, 48},
    new string[]
    {
         "Gust", "Sand Attack", "Quick Attack", "Whirlwind", "Feather Dance", "Agility",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(19, "Rattata", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Guts", "Hustle",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.3f, 3.5f,
    51, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Mouse", "Living wherever there is food available,it ceaselessly scavenges for ediblesthe entire day.",
    30, 56, 35, 25, 35, 72, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 20, 27, 34, 41},
    new string[]
    {
         "Tackle", "Tail Whip", "Quick Attack", "Hyper Fang", "Focus Energy", "Pursuit", "Super Fang", "Endeavor",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "Secret_Power", "Shock_Wave"
    },
    new int[] {20}, new string[] {"Level,20"}),


new PokemonData(20, "Raticate", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Guts", "Hustle",
    50f, 127, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.7f, 18.5f,
    145, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Mouse", "It whittles its constantly growing fangs by gnawingon hard things. It can chew apart cinder walls.",
    55, 81, 60, 50, 70, 97, 0, Color.clear,
    new int[] { 1, 1, 1, 20, 30, 40, 50},
    new string[]
    {
         "Tackle", "Tail Whip", "Quick Attack", "Scary Face", "Pursuit", "Super Fang", "Endeavor",
    },
    new string[]
    {
         "Cut", "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(21, "Spearow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", null, "Sniper",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 2f,
    52, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Tiny Bird", "Very protective of its territory, it flaps its shortwings busily to dart around at high speed.",
    40, 60, 30, 31, 31, 70, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43},
    new string[]
    {
         "Growl", "Peck", "Leer", "Fury Attack", "Pursuit", "Aerial Ace", "Mirror Move", "Drill Peck", "Agility",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
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
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(23, "Ekans", PokemonData.Type.POISON, PokemonData.Type.NONE, "Intimidate", "Shed-skin", "Unnerve",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2f, 6.9f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Snake", "The older it gets, the longer it grows. At night, it wraps its long body aroundtree branches to rest.",
    35, 60, 44, 40, 54, 55, 0, Color.clear,
    new int[] { 1, 1, 8, 13, 20, 25, 32, 37, 37, 37, 44},
    new string[]
    {
         "Wrap", "Leer", "Poison Sting", "Bite", "Glare", "Screech", "Acid", "Stockpile", "Spit Up", "Swallow", "Haze",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Torment", "Facade", "Snatch", "Secret_Power"
    },
    new int[] {24}, new string[] {"Level,22"}),


new PokemonData(24, "Arbok", PokemonData.Type.POISON, PokemonData.Type.NONE, "Intimidate", "Shed-skin", "Unnerve",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 3.5f, 65f,
    157, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Cobra", "The pattern on its belly appears to be a frighteningface. Weak foes will flee just at the sight ofthe pattern.",
    60, 95, 69, 65, 79, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 20, 28, 46, 46, 46, 56},
    new string[]
    {
         "Wrap", "Poison Sting", "Bite", "Glare", "Screech", "Stockpile", "Spit Up", "Swallow", "Haze",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Torment", "Facade", "Snatch", "Secret_Power"
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
         "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Shock_Wave"
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
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(27, "Sandshrew", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", null, "Sand-rush",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 12f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Mouse", "It burrows and lives underground. If threatened,it curls itself up into a ball for protection.",
    50, 75, 85, 20, 30, 40, 0, Color.clear,
    new int[] { 1, 6, 11, 17, 23, 30, 37, 45, 53},
    new string[]
    {
         "Scratch", "Defense Curl", "Sand Attack", "Poison Sting", "Slash", "Swift", "Fury Swipes", "Sand Tomb", "Sandstorm",
    },
    new string[]
    {
         "Cut", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {28}, new string[] {"Level,22"}),


new PokemonData(28, "Sandslash", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", null, "Sand-rush",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 29.5f,
    158, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Mouse", "If it digs at an incredible pace, it may snap offits spikes and claws. They grow back in a day.",
    75, 100, 110, 45, 55, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 24, 42, 52, 62},
    new string[]
    {
         "Scratch", "Sand Attack", "Defense Curl", "Slash", "Fury Swipes", "Sand Tomb", "Sandstorm",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(29, "Nidoran-f", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
    0f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 7f,
    55, PokemonData.LevelingRate.MEDIUMSLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Poison Pin", "Although small, its venomous barbs renderthis Pokémon dangerous. The female hassmaller horns.",
    55, 47, 52, 40, 40, 41, 0, Color.clear,
    new int[] { 1, 1, 8, 12, 17, 20, 23, 30, 38, 47},
    new string[]
    {
         "Scratch", "Growl", "Tail Whip", "Double Kick", "Poison Sting", "Bite", "Helping Hand", "Fury Swipes", "Flatter", "Crunch",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {30}, new string[] {"Level,16"}),


new PokemonData(30, "Nidorina", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
    0f, 120, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.8f, 20f,
    128, PokemonData.LevelingRate.MEDIUMSLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Poison Pin", "The female has a gentle temperament. It emits ultrasonic cries that have the powerto befuddle foes.",
    70, 62, 67, 55, 55, 56, 0, Color.clear,
    new int[] { 1, 1, 8, 12, 18, 22, 26, 34, 43, 53},
    new string[]
    {
         "Scratch", "Growl", "Tail Whip", "Double Kick", "Poison Sting", "Bite", "Helping Hand", "Fury Swipes", "Flatter", "Crunch",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
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
         "Scratch", "Double Kick", "Tail Whip", "Poison Sting", "Body Slam",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(32, "Nidoran-m", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
    100f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 9f,
    55, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Pin", "It scans its surroundings by raising its ears out ofthe grass. Its toxic horn is for protection.",
    46, 57, 40, 40, 40, 50, 0, Color.clear,
    new int[] { 1, 1, 8, 12, 17, 20, 23, 30, 38, 47},
    new string[]
    {
         "Leer", "Peck", "Focus Energy", "Double Kick", "Poison Sting", "Horn Attack", "Helping Hand", "Fury Attack", "Flatter", "Horn Drill",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
    },
    new int[] {33}, new string[] {"Level,16"}),


new PokemonData(33, "Nidorino", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
    100f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 19.5f,
    128, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Pin", "It raises its big ears to check its surroundings. If it senses anything, it attacks immediately.",
    61, 72, 57, 55, 55, 65, 0, Color.clear,
    new int[] { 1, 1, 8, 12, 18, 22, 26, 34, 43, 53},
    new string[]
    {
         "Leer", "Peck", "Focus Energy", "Double Kick", "Poison Sting", "Horn Attack", "Helping Hand", "Fury Attack", "Flatter", "Horn Drill",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
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
         "Double Kick", "Poison Sting", "Peck", "Focus Energy", "Thrash",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Rock_Tomb", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(35, "Clefairy", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Cute-charm", "Magic-guard", "Friend-guard",
    25f, 150, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.6f, 7.5f,
    113, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
    "Fairy", "It is said that happiness will come to those who seea gathering of Clefairy dancing under a full moon.",
    70, 45, 48, 60, 65, 35, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Pound", "Growl", "Encore", "Sing", "Double Slap", "Follow Me", "Minimize", "Defense Curl", "Metronome", "Cosmic Power", "Moonlight", "Light Screen", "Meteor Mash",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Focus_Punch", "Brick_Break", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave", "Water_Pulse"
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
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Focus_Punch", "Brick_Break", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(37, "Vulpix", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Drought",
    25f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 9.9f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Fox", "When it is born, it has just one snow-white tail. The tail splits from its tip as it grows older.",
    38, 41, 40, 50, 65, 65, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41},
    new string[]
    {
         "Ember", "Tail Whip", "Roar", "Quick Attack", "Will-O-Wisp", "Confuse Ray", "Imprison", "Flamethrower", "Safeguard", "Grudge", "Fire Spin",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Overheat"
    },
    new int[] {}, new string[] {}),


new PokemonData(38, "Ninetales", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Drought",
    25f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 19.9f,
    177, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Fox", "It has nine long tails and fur that gleams gold. It is said to live for 1,000 years.",
    73, 76, 75, 81, 100, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 45},
    new string[]
    {
         "Ember", "Quick Attack", "Confuse Ray", "Safeguard", "Fire Spin",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Overheat"
    },
    new int[] {}, new string[] {}),


new PokemonData(39, "Jigglypuff", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Cute-charm", "Competitive", "Friend-guard",
    25f, 170, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.5f, 5.5f,
    95, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Balloon", "It captivates foes with its huge, round eyes,then lulls them to sleep by singing asoothing melody.",
    115, 45, 20, 45, 25, 20, 0, Color.clear,
    new int[] { 1, 4, 9, 14, 19, 24, 29, 34, 39, 44, 49},
    new string[]
    {
         "Sing", "Defense Curl", "Pound", "Disable", "Rollout", "Double Slap", "Rest", "Body Slam", "Mimic", "Hyper Voice", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Focus_Punch", "Brick_Break", "Snatch", "Secret_Power", "Shock_Wave", "Water_Pulse"
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
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Focus_Punch", "Brick_Break", "Snatch", "Secret_Power", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(41, "Zubat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 0.8f, 7.5f,
    49, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Bat", "Even though it has no eyes, it can sense obstaclesusing ultrasonic waves it emits from its mouth.",
    40, 45, 35, 30, 40, 55, 0, Color.clear,
    new int[] { 1, 6, 11, 16, 21, 26, 31, 36, 41, 46},
    new string[]
    {
         "Leech Life", "Supersonic", "Astonish", "Bite", "Wing Attack", "Confuse Ray", "Air Cutter", "Mean Look", "Poison Fang", "Haze",
    },
    new string[]
    {
         "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power", "Aerial_Ace"
    },
    new int[] {42}, new string[] {"Level,22"}),


new PokemonData(42, "Golbat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
    50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.6f, 55f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
    "Bat", "Once it bites, it will not stop draining energyfrom the victim even if it gets too heavy to fly.",
    75, 80, 70, 65, 75, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 16, 21, 28, 42, 49, 56},
    new string[]
    {
         "Supersonic", "Leech Life", "Astonish", "Bite", "Wing Attack", "Confuse Ray", "Mean Look", "Poison Fang", "Haze",
    },
    new string[]
    {
         "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power", "Aerial_Ace"
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
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(45, "Vileplume", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Effect-spore",
    50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 1.2f, 18.6f,
    221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Flower", "The larger its petals, the more toxic pollen itcontains. Its big head is heavy and hard to hold up.",
    75, 80, 85, 110, 90, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 44},
    new string[]
    {
         "Absorb", "Mega Drain", "Stun Spore", "Aromatherapy", "Petal Dance",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(46, "Paras", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Effect-spore", "Dry-skin", "Damp",
    50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 5.4f,
    57, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Mushroom", "Growing out of the bug’s back are mushroomscalled tochukaso. The mushrooms growwith the bug host.",
    35, 70, 55, 45, 55, 25, 0, Color.clear,
    new int[] { 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Scratch", "Stun Spore", "Poison Powder", "Leech Life", "Spore", "Slash", "Growth", "Giga Drain", "Aromatherapy",
    },
    new string[]
    {
         "Cut", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed", "Aerial_Ace"
    },
    new int[] {47}, new string[] {"Level,24"}),


new PokemonData(47, "Parasect", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Effect-spore", "Dry-skin", "Damp",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1f, 29.5f,
    142, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 1, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Mushroom", "A mushroom grown larger than the host’s bodycontrols Parasect. It scatters poisonous spores.",
    60, 95, 80, 60, 80, 30, 0, Color.clear,
    new int[] { 1, 1, 7, 19, 27, 35, 43, 51, 59},
    new string[]
    {
         "Scratch", "Poison Powder", "Stun Spore", "Leech Life", "Spore", "Slash", "Growth", "Giga Drain", "Aromatherapy",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed", "Aerial_Ace"
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
         "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Skill_Swap", "Secret_Power"
    },
    new int[] {49}, new string[] {"Level,31"}),


new PokemonData(49, "Venomoth", PokemonData.Type.BUG, PokemonData.Type.POISON, "Shield-dust", "Tinted-lens", "Wonder-skin",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.5f, 12.5f,
    158, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Moth", "The scales it scatters will paralyze anyone whotouches them, making that person unable to stand.",
    70, 65, 60, 90, 75, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 20, 25, 28, 31, 36, 42, 52},
    new string[]
    {
         "Tackle", "Supersonic", "Foresight", "Silver Wind", "Confusion", "Poison Powder", "Leech Life", "Stun Spore", "Gust", "Psybeam", "Sleep Powder", "Psychic",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Skill_Swap", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(50, "Diglett", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", "Arena-trap", "Sand-force",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.2f, 0.8f,
    53, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Mole", "Lives about one yard underground where it feedson plant roots. It sometimes appears aboveground.",
    10, 55, 25, 35, 45, 95, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 17, 25, 33, 41, 49},
    new string[]
    {
         "Scratch", "Sand Attack", "Growl", "Magnitude", "Dig", "Mud-Slap", "Slash", "Earthquake", "Fissure",
    },
    new string[]
    {
         "Cut", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {51}, new string[] {"Level,26"}),


new PokemonData(51, "Dugtrio", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", "Arena-trap", "Sand-force",
    50f, 50, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 33.3f,
    149, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Mole", "In battle, it digs through the ground and strikesthe unsuspecting foe from an unexpected direction.",
    35, 100, 50, 50, 70, 120, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 17, 25, 26, 38, 64},
    new string[]
    {
         "Scratch", "Sand Attack", "Growl", "Tri Attack", "Magnitude", "Dig", "Mud-Slap", "Sand Tomb", "Slash", "Fissure",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(52, "Meowth", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Technician", "Unnerve",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 4.2f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Scratch Cat", "It is nocturnal in nature. If it spots something shiny,its eyes glitter brightly.",
    40, 45, 35, 40, 40, 90, 0, Color.clear,
    new int[] { 1, 1, 11, 20, 28, 35, 41, 46, 50},
    new string[]
    {
         "Scratch", "Growl", "Bite", "Pay Day", "Feint Attack", "Screech", "Fury Swipes", "Slash", "Fake Out",
    },
    new string[]
    {
         "Cut", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {53}, new string[] {"Level,28"}),


new PokemonData(53, "Persian", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Limber", "Technician", "Unnerve",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 32f,
    154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Classy Cat", "Although its fur has many admirers, it is toughto raise as a pet because of its fickle meanness.",
    65, 70, 60, 65, 65, 115, 0, Color.clear,
    new int[] { 1, 1, 20, 29, 38, 46, 53, 59},
    new string[]
    {
         "Scratch", "Bite", "Pay Day", "Feint Attack", "Screech", "Fury Swipes", "Slash", "Fake Out",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(54, "Psyduck", PokemonData.Type.WATER, PokemonData.Type.NONE, "Damp", "Cloud-nine", "Swift-swim",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 19.6f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Duck", "It is constantly wracked by a headache. When the headache turns intense,it begins using mysterious powers.",
    50, 52, 48, 65, 50, 55, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 16, 23, 31, 40, 50},
    new string[]
    {
         "Scratch", "Water Sport", "Tail Whip", "Disable", "Confusion", "Screech", "Psych Up", "Fury Swipes", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Aerial_Ace", "Calm_Mind", "Water_Pulse"
    },
    new int[] {55}, new string[] {"Level,33"}),


new PokemonData(55, "Golduck", PokemonData.Type.WATER, PokemonData.Type.NONE, "Damp", "Cloud-nine", "Swift-swim",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 76.6f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Duck", "It appears by waterways at dusk. It may use telekinetic powersif its forehead glows mysteriously.",
    80, 82, 78, 95, 80, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 16, 23, 31, 44, 58},
    new string[]
    {
         "Scratch", "Tail Whip", "Water Sport", "Disable", "Confusion", "Screech", "Psych Up", "Fury Swipes", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Aerial_Ace", "Calm_Mind", "Water_Pulse"
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
         "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up"
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
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up"
    },
    new int[] {}, new string[] {}),


new PokemonData(58, "Growlithe", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Intimidate", "Flash-fire", "Justified",
    75f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 19f,
    70, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Puppy", "Very friendly and faithful to people. It will try torepel enemies by barking and biting.",
    55, 70, 45, 70, 50, 60, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Bite", "Roar", "Ember", "Leer", "Odor Sleuth", "Take Down", "Flame Wheel", "Helping Hand", "Agility", "Flamethrower",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Overheat", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(59, "Arcanine", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Intimidate", "Flash-fire", "Justified",
    75f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.9f, 155f,
    194, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Legendary", "A Pokémon that has long been admired for itsbeauty. It runs agilely as if on wings.",
    90, 110, 80, 100, 80, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 49},
    new string[]
    {
         "Bite", "Roar", "Ember", "Odor Sleuth", "Extreme Speed",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Overheat", "Aerial_Ace"
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
         "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
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
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Water_Pulse"
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
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Rock_Tomb", "Bulk_Up", "Water_Pulse"
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
         "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Focus_Punch", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {64}, new string[] {"Level,16"}),


new PokemonData(64, "Kadabra", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", "Inner-focus", "Magic-guard",
    75f, 100, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.3f, 56.5f,
    140, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Psi", "When it uses its psychic power, it emits strongalpha waves that can ruin precision devices.",
    40, 35, 30, 120, 70, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 18, 21, 23, 25, 30, 33, 43},
    new string[]
    {
         "Confusion", "Teleport", "Kinesis", "Disable", "Psybeam", "Reflect", "Recover", "Future Sight", "Role Play", "Trick",
    },
    new string[]
    {
         "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Focus_Punch", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(65, "Alakazam", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", "Inner-focus", "Magic-guard",
    75f, 50, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.5f, 48f,
    225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Psi", "Its brain cells multiply continually until it dies. As a result, it remembers everything.",
    55, 50, 45, 135, 95, 120, 0, Color.clear,
    new int[] { 1, 1, 1, 18, 21, 23, 25, 30, 33, 43},
    new string[]
    {
         "Confusion", "Teleport", "Kinesis", "Disable", "Psybeam", "Reflect", "Recover", "Future Sight", "Calm Mind", "Trick",
    },
    new string[]
    {
         "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Focus_Punch", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(66, "Machop", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
    75f, 180, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.8f, 19.5f,
    61, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Superpower", "It hefts a Graveler repeatedly to strengthenits entire body. It uses every type of martial arts.",
    70, 80, 50, 35, 35, 35, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 22, 25, 31, 37, 40, 43, 49},
    new string[]
    {
         "Leer", "Low Kick", "Focus Energy", "Karate Chop", "Seismic Toss", "Foresight", "Revenge", "Vital Throw", "Submission", "Cross Chop", "Scary Face", "Dynamic Punch",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up"
    },
    new int[] {67}, new string[] {"Level,28"}),


new PokemonData(67, "Machoke", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
    75f, 90, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.5f, 70.5f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Superpower", "Its muscular body is so powerful, it must wear apower-save belt to be able to regulate its motions.",
    80, 100, 70, 50, 60, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 19, 22, 25, 33, 41, 46, 59},
    new string[]
    {
         "Leer", "Low Kick", "Focus Energy", "Karate Chop", "Seismic Toss", "Foresight", "Revenge", "Vital Throw", "Submission", "Cross Chop", "Dynamic Punch",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up"
    },
    new int[] {}, new string[] {}),


new PokemonData(68, "Machamp", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
    75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.6f, 130f,
    227, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Superpower", "Its four ruggedly developed arms can launcha flurry of 1,000 punches in just two seconds.",
    90, 130, 80, 65, 85, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 19, 22, 25, 33, 41, 46, 59},
    new string[]
    {
         "Leer", "Low Kick", "Focus Energy", "Karate Chop", "Seismic Toss", "Foresight", "Revenge", "Vital Throw", "Submission", "Cross Chop", "Dynamic Punch",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up"
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
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
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
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(74, "Geodude", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
    50f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.4f, 20f,
    60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Rock", "Found in fields and mountains. Mistaking them forboulders, people often step or trip on them.",
    40, 80, 100, 30, 30, 20, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 46},
    new string[]
    {
         "Tackle", "Defense Curl", "Mud Sport", "Rock Throw", "Magnitude", "Self-Destruct", "Rollout", "Rock Blast", "Earthquake", "Explosion", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb"
    },
    new int[] {75}, new string[] {"Level,25"}),


new PokemonData(75, "Graveler", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
    50f, 120, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 105f,
    137, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Rock", "With a free and uncaring nature, it doesn’t mindif pieces break off while it rolls down mountains.",
    55, 95, 115, 45, 45, 35, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 16, 21, 29, 53, 62},
    new string[]
    {
         "Tackle", "Rock Throw", "Defense Curl", "Mud Sport", "Magnitude", "Self-Destruct", "Rollout", "Explosion", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(76, "Golem", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
    50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.4f, 300f,
    223, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Megaton", "It tumbles down mountains, leaving groovesfrom peak to base. Stay clear of these grooves.",
    80, 120, 130, 55, 65, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 16, 21, 29, 53, 62},
    new string[]
    {
         "Tackle", "Rock Throw", "Defense Curl", "Mud Sport", "Magnitude", "Self-Destruct", "Rollout", "Explosion", "Double-Edge",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(77, "Ponyta", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Run-away", "Flash-fire", "Flame-body",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 30f,
    82, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Fire Horse", "As a newborn, it can barely stand. However, through galloping, itslegs are made tougher and faster.",
    50, 85, 55, 65, 65, 90, 0, Color.clear,
    new int[] { 1, 5, 9, 14, 19, 25, 31, 38, 45, 53},
    new string[]
    {
         "Tackle", "Growl", "Tail Whip", "Ember", "Stomp", "Fire Spin", "Take Down", "Agility", "Bounce", "Fire Blast",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Overheat"
    },
    new int[] {78}, new string[] {"Level,40"}),


new PokemonData(78, "Rapidash", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Run-away", "Flash-fire", "Flame-body",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.7f, 95f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Fire Horse", "Very competitive, this Pokémon will chase anythingthat moves fast in the hopes of racing it.",
    65, 100, 70, 80, 80, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 19, 31, 38, 40, 50, 63},
    new string[]
    {
         "Tackle", "Tail Whip", "Ember", "Growl", "Stomp", "Take Down", "Agility", "Fury Attack", "Bounce", "Fire Blast",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Overheat"
    },
    new int[] {}, new string[] {}),


new PokemonData(79, "Slowpoke", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
    50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 36f,
    63, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Dopey", "It is always vacantly lost in thought, but no oneknows what it is thinking about. It is good at fishingwith its tail.",
    90, 65, 65, 40, 40, 15, 0, Color.clear,
    new int[] { 1, 1, 1, 6, 15, 20, 29, 34, 43, 48},
    new string[]
    {
         "Tackle", "Curse", "Yawn", "Growl", "Water Gun", "Confusion", "Disable", "Headbutt", "Amnesia", "Psychic",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Hail", "Facade", "Skill_Swap", "Secret_Power", "Dive", "Calm_Mind", "Water_Pulse"
    },
    new int[] {80}, new string[] {"Level,37"}),


new PokemonData(80, "Slowbro", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
    50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.6f, 78.5f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Hermit Crab", "An attached Shellder won’t let go because ofthe tasty flavor that oozes out of its tail.",
    95, 75, 110, 100, 80, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 15, 20, 34, 37, 46, 54},
    new string[]
    {
         "Tackle", "Growl", "Curse", "Yawn", "Water Gun", "Confusion", "Headbutt", "Withdraw", "Amnesia", "Psychic",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Skill_Swap", "Secret_Power", "Dive", "Calm_Mind", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(81, "Magnemite", PokemonData.Type.ELECTRIC, PokemonData.Type.STEEL, "Magnet-pull", "Sturdy", "Analytic",
    112.5f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.3f, 6f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Magnet", "The units at the sides of its body generateantigravity energy to keep it aloft in the air.",
    25, 35, 70, 95, 55, 45, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 32, 38, 44, 50},
    new string[]
    {
         "Tackle", "Metal Sound", "Thunder Shock", "Supersonic", "Sonic Boom", "Thunder Wave", "Spark", "Lock-On", "Swift", "Screech", "Zap Cannon",
    },
    new string[]
    {
         "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Protect", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Shock_Wave"
    },
    new int[] {82}, new string[] {"Level,30"}),


new PokemonData(82, "Magneton", PokemonData.Type.ELECTRIC, PokemonData.Type.STEEL, "Magnet-pull", "Sturdy", "Analytic",
    112.5f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 60f,
    163, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Magnet", "A linked cluster formed of several Magnemite. It discharges powerful magnetic waves athigh voltage.",
    50, 60, 95, 120, 70, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 26, 35, 44, 53, 62},
    new string[]
    {
         "Tackle", "Supersonic", "Thunder Shock", "Metal Sound", "Spark", "Lock-On", "Tri Attack", "Screech", "Zap Cannon",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Protect", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(83, "Farfetchd", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Inner-focus", "Defiant",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.8f, 15f,
    132, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Wild Duck", "The plant stalk it holds is its weapon. The stalk isused like a sword to cut all sorts of things.",
    52, 90, 55, 58, 62, 60, 0, Color.clear,
    new int[] { 1, 6, 11, 16, 21, 26, 31, 36, 41, 46},
    new string[]
    {
         "Peck", "Sand Attack", "Leer", "Fury Attack", "Knock Off", "Fury Cutter", "Swords Dance", "Agility", "Slash", "False Swipe",
    },
    new string[]
    {
         "Cut", "Fly", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(84, "Doduo", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Run-away", "Early-bird", "Tangled-feet",
    50f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.4f, 39.2f,
    62, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Twin Bird", "A two-headed Pokémon that was discovered as asudden mutation. It runs at a pace of over 60 milesper hour.",
    35, 85, 45, 35, 35, 75, 0, Color.clear,
    new int[] { 1, 1, 9, 13, 21, 25, 33, 37, 45},
    new string[]
    {
         "Growl", "Peck", "Pursuit", "Fury Attack", "Tri Attack", "Rage", "Uproar", "Drill Peck", "Agility",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {85}, new string[] {"Level,31"}),


new PokemonData(85, "Dodrio", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Run-away", "Early-bird", "Tangled-feet",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.8f, 85.2f,
    165, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Triple Bird", "An enemy that takes its eyes off any of thethree heads--even for a second--will getpecked severely.",
    60, 110, 70, 60, 60, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 21, 25, 47, 60},
    new string[]
    {
         "Fury Attack", "Peck", "Pursuit", "Tri Attack", "Rage", "Drill Peck", "Agility",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Torment", "Facade", "Taunt", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(86, "Seel", PokemonData.Type.WATER, PokemonData.Type.NONE, "Thick-fat", "Hydration", "Ice-body",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.1f, 90f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.WHITE, 70,
    "Sea Lion", "A Pokémon that lives on icebergs. It swims in thesea using the point on its head to break up ice.",
    65, 45, 55, 45, 70, 45, 0, Color.clear,
    new int[] { 1, 9, 17, 21, 29, 37, 41, 49},
    new string[]
    {
         "Headbutt", "Growl", "Icy Wind", "Aurora Beam", "Rest", "Take Down", "Ice Beam", "Safeguard",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {87}, new string[] {"Level,34"}),


new PokemonData(87, "Dewgong", PokemonData.Type.WATER, PokemonData.Type.ICE, "Thick-fat", "Hydration", "Ice-body",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 120f,
    166, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.WHITE, 70,
    "Sea Lion", "Its body is covered with a pure white fur. The colder the weather, the more activeit becomes.",
    90, 70, 80, 70, 95, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 34, 42},
    new string[]
    {
         "Headbutt", "Growl", "Aurora Beam", "Icy Wind", "Sheer Cold", "Take Down",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(88, "Grimer", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Sticky-hold", "Poison-touch",
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.9f, 30f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sludge", "Sludge exposed to X-rays from the moontransformed into Grimer. It loves feedingon filthy things.",
    80, 80, 50, 40, 50, 25, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 13, 19, 26, 34, 43, 53},
    new string[]
    {
         "Pound", "Poison Gas", "Harden", "Disable", "Sludge", "Minimize", "Screech", "Acid Armor", "Sludge Bomb", "Memento",
    },
    new string[]
    {
         "Flamethrower", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Torment", "Facade", "Taunt", "Secret_Power", "Rock_Tomb", "Shock_Wave"
    },
    new int[] {89}, new string[] {"Level,38"}),


new PokemonData(89, "Muk", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Sticky-hold", "Poison-touch",
    50f, 75, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 30f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 1, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sludge", "They love to gather in smelly areas where sludgeaccumulates, making the stench aroundthem worse.",
    105, 105, 75, 65, 100, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 13, 26, 34, 47, 61},
    new string[]
    {
         "Pound", "Harden", "Poison Gas", "Disable", "Sludge", "Screech", "Acid Armor", "Sludge Bomb", "Memento",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Rock_Tomb", "Shock_Wave"
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
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(91, "Cloyster", PokemonData.Type.WATER, PokemonData.Type.ICE, "Shell-armor", "Skill-link", "Overcoat",
    50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.5f, 132.5f,
    184, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Bivalve", "Cloyster that live in seas with harsh tidal currentsgrow large, sharp spikes on their shells.",
    50, 95, 180, 85, 45, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 33, 41},
    new string[]
    {
         "Supersonic", "Aurora Beam", "Withdraw", "Protect", "Spikes", "Spike Cannon",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Torment", "Facade", "Secret_Power", "Dive", "Water_Pulse"
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
         "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power"
    },
    new int[] {93}, new string[] {"Level,25"}),


new PokemonData(93, "Haunter", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Levitate", null, null,
    50f, 90, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.6f, 0.1f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Gas", "If you get the feeling of being watched in darknesswhen nobody is around, Haunter is there.",
    45, 50, 45, 115, 55, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 16, 21, 25, 31, 39},
    new string[]
    {
         "Hypnosis", "Lick", "Spite", "Mean Look", "Curse", "Night Shade", "Shadow Punch", "Confuse Ray", "Dream Eater",
    },
    new string[]
    {
         "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power"
    },
    new int[] {}, new string[] {}),


new PokemonData(94, "Gengar", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Cursed-body", null, null,
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.5f, 40.5f,
    225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Shadow", "It hides in shadows. It is said that if Gengaris hiding, it cools the area by nearly10 degrees Fahrenheit.",
    60, 65, 60, 130, 75, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 16, 21, 25, 31, 39},
    new string[]
    {
         "Hypnosis", "Lick", "Spite", "Mean Look", "Curse", "Night Shade", "Shadow Punch", "Confuse Ray", "Dream Eater",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power"
    },
    new int[] {}, new string[] {}),


new PokemonData(95, "Onix", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Weak-armor",
    50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 8.8f, 210f,
    77, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Rock Snake", "Burrows at high speed in search of food. The tunnels it leaves are used as homesby Diglett.",
    35, 45, 160, 30, 45, 70, 0, Color.clear,
    new int[] { 1, 1, 9, 13, 21, 25, 33, 37, 45, 49, 57},
    new string[]
    {
         "Tackle", "Screech", "Bind", "Rock Throw", "Harden", "Rage", "Sandstorm", "Slam", "Iron Tail", "Sand Tomb", "Double-Edge",
    },
    new string[]
    {
         "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Secret_Power", "Rock_Tomb"
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
         "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind"
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
         "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind"
    },
    new int[] {}, new string[] {}),


new PokemonData(98, "Krabby", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Sheer-force",
    50f, 225, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.4f, 6.5f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "River Crab", "If it senses danger approaching, it cloaks itself withbubbles from its mouth so it will look bigger.",
    30, 105, 90, 25, 25, 50, 0, Color.clear,
    new int[] { 1, 5, 12, 16, 23, 27, 34, 41, 45},
    new string[]
    {
         "Bubble", "Leer", "Vice Grip", "Harden", "Mud Shot", "Stomp", "Guillotine", "Protect", "Crabhammer",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {99}, new string[] {"Level,28"}),


new PokemonData(99, "Kingler", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Sheer-force",
    50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.3f, 60f,
    166, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Pincer", "Its large and hard pincer has 10,000-horsepowerstrength. However, being so big, it is unwieldyto move.",
    55, 130, 115, 50, 50, 75, 0, Color.clear,
    new int[] { 1, 1, 1, 23, 27, 49, 57},
    new string[]
    {
         "Vice Grip", "Leer", "Bubble", "Mud Shot", "Stomp", "Protect", "Crabhammer",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(100, "Voltorb", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Soundproof", "Static", "Aftermath",
    112.5f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.5f, 10.4f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
    "Ball", "It was discovered when Poké Balls wereintroduced. It is said that there issome connection.",
    40, 30, 50, 55, 55, 100, 0, Color.clear,
    new int[] { 1, 1, 8, 15, 21, 27, 32, 37, 42, 46, 49},
    new string[]
    {
         "Tackle", "Charge", "Screech", "Sonic Boom", "Spark", "Self-Destruct", "Rollout", "Light Screen", "Swift", "Explosion", "Mirror Coat",
    },
    new string[]
    {
         "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Thief", "Protect", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Torment", "Facade", "Taunt", "Secret_Power", "Shock_Wave"
    },
    new int[] {101}, new string[] {"Level,30"}),


new PokemonData(101, "Electrode", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Soundproof", "Static", "Aftermath",
    112.5f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.2f, 66.6f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.RED, 70,
    "Ball", "It explodes in response to even minor stimuli. It isfeared, with the nickname of “The Bomb Ball. ",
    60, 50, 70, 80, 80, 150, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 21, 27, 34, 41, 48, 54, 59},
    new string[]
    {
         "Tackle", "Sonic Boom", "Charge", "Screech", "Spark", "Self-Destruct", "Rollout", "Light Screen", "Swift", "Explosion", "Mirror Coat",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Thief", "Protect", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Torment", "Facade", "Taunt", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(102, "Exeggcute", PokemonData.Type.GRASS, PokemonData.Type.PSYCHIC, "Chlorophyll", null, "Harvest",
    50f, 90, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 2.5f,
    65, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Egg", "Its six eggs converse using telepathy. They canquickly gather if they become separated.",
    60, 40, 80, 60, 45, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 13, 19, 25, 31, 37, 43},
    new string[]
    {
         "Hypnosis", "Barrage", "Uproar", "Reflect", "Leech Seed", "Confusion", "Stun Spore", "Poison Powder", "Sleep Powder", "Solar Beam",
    },
    new string[]
    {
         "Strength", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Skill_Swap", "Secret_Power", "Bullet_Seed"
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
         "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Skill_Swap", "Secret_Power", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(104, "Cubone", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Rock-head", "Lightning-rod", "Battle-armor",
    50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 6.5f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Lonely", "It wears the skull of its dead mother on its head. When it becomes lonesome, it is said to cry loudly.",
    50, 50, 95, 40, 50, 35, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Growl", "Tail Whip", "Bone Club", "Headbutt", "Leer", "Focus Energy", "Bonemerang", "Rage", "False Swipe", "Thrash", "Bone Rush", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {105}, new string[] {"Level,28"}),


new PokemonData(105, "Marowak", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Rock-head", "Lightning-rod", "Battle-armor",
    50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 45f,
    149, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Bone Keeper", "It is small and was originally very weak. Its temperament turned ferocious when it beganusing bones.",
    60, 80, 110, 50, 80, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 21, 32, 39, 53, 61},
    new string[]
    {
         "Headbutt", "Tail Whip", "Growl", "Bone Club", "Focus Energy", "Rage", "False Swipe", "Bone Rush", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {106}, new string[] {"Level,20"}),


new PokemonData(106, "Hitmonlee", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Limber", "Reckless", "Unburden",
    100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.5f, 49.8f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Kicking", "The legs freely contract and stretch. The stretchylegs allow it to hit a distant foe with a rising kick.",
    50, 120, 53, 35, 110, 87, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 20, 21, 26, 31, 36, 41, 46, 51},
    new string[]
    {
         "Double Kick", "Revenge", "Meditate", "Rolling Kick", "Jump Kick", "Brick Break", "Focus Energy", "High Jump Kick", "Mind Reader", "Foresight", "Endure", "Mega Kick", "Reversal",
    },
    new string[]
    {
         "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up"
    },
    new int[] {107}, new string[] {"Level,20"}),


new PokemonData(107, "Hitmonchan", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Keen-eye", "Iron-fist", "Inner-focus",
    100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 50.2f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BROWN, 70,
    "Punching", "The arm-twisting punches it throws pulverize evenconcrete. It rests after three minutes of fighting.",
    50, 105, 79, 35, 110, 76, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 20, 26, 26, 26, 32, 38, 44, 50},
    new string[]
    {
         "Comet Punch", "Revenge", "Agility", "Pursuit", "Mach Punch", "Fire Punch", "Ice Punch", "Thunder Punch", "Sky Uppercut", "Mega Punch", "Detect", "Counter",
    },
    new string[]
    {
         "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up"
    },
    new int[] {}, new string[] {}),


new PokemonData(108, "Lickitung", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Own-tempo", "Oblivious", "Cloud-nine",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 65.5f,
    77, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Licking", "Its long tongue, slathered with a gooey saliva,sticks to anything, so it is very useful.",
    90, 55, 75, 60, 75, 30, 0, Color.clear,
    new int[] { 1, 7, 12, 18, 23, 29, 34, 40, 45, 51},
    new string[]
    {
         "Lick", "Supersonic", "Defense Curl", "Knock Off", "Stomp", "Wrap", "Disable", "Slam", "Screech", "Refresh",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(109, "Koffing", PokemonData.Type.POISON, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 1f,
    68, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Gas", "Its thin, balloon-like body is inflated by horriblytoxic gases. It reeks when it is nearby.",
    40, 65, 95, 60, 45, 35, 0, Color.clear,
    new int[] { 1, 1, 9, 17, 21, 25, 33, 41, 45, 49},
    new string[]
    {
         "Tackle", "Poison Gas", "Smog", "Self-Destruct", "Sludge", "Smokescreen", "Haze", "Explosion", "Destiny Bond", "Memento",
    },
    new string[]
    {
         "Flamethrower", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Secret_Power", "Shock_Wave"
    },
    new int[] {110}, new string[] {"Level,35"}),


new PokemonData(110, "Weezing", PokemonData.Type.POISON, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 60, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 9.5f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Gas", "If one of the twin Koffing inflates, the other onedeflates. It constantly mixes its poisonous gases.",
    65, 90, 120, 85, 70, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 21, 25, 33, 44, 51, 58},
    new string[]
    {
         "Tackle", "Self-Destruct", "Poison Gas", "Smog", "Sludge", "Smokescreen", "Haze", "Explosion", "Destiny Bond", "Memento",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(111, "Rhyhorn", PokemonData.Type.GROUND, PokemonData.Type.ROCK, "Lightning-rod", "Rock-head", "Reckless",
    50f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1f, 115f,
    69, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Spikes", "Strong, but not too bright, this Pokémon canshatter even a skyscraper with its charging Tackles.",
    80, 85, 95, 30, 30, 25, 0, Color.clear,
    new int[] { 1, 1, 10, 15, 24, 29, 38, 43, 52, 57},
    new string[]
    {
         "Horn Attack", "Tail Whip", "Stomp", "Fury Attack", "Scary Face", "Rock Blast", "Horn Drill", "Take Down", "Earthquake", "Megahorn",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Shock_Wave"
    },
    new int[] {112}, new string[] {"Level,42"}),


new PokemonData(112, "Rhydon", PokemonData.Type.GROUND, PokemonData.Type.ROCK, "Lightning-rod", "Rock-head", "Reckless",
    50f, 60, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1.9f, 120f,
    170, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Drill", "Protected by an armor-like hide, it is capable ofliving in molten lava of 3,600 degrees Fahrenheit.",
    105, 130, 120, 45, 45, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 24, 29, 46, 58, 66},
    new string[]
    {
         "Stomp", "Fury Attack", "Tail Whip", "Scary Face", "Rock Blast", "Take Down", "Earthquake", "Megahorn",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(113, "Chansey", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Natural-cure", "Serene-grace", "Healer",
    0f, 30, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.1f, 34.6f,
    395, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
    "Egg", "It is said to deliver happiness. Being compassionate, it shares its eggswith injured people.",
    250, 5, 5, 35, 105, 50, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 23, 29, 35, 41, 49, 57},
    new string[]
    {
         "Pound", "Growl", "Tail Whip", "Refresh", "Soft-Boiled", "Double Slap", "Minimize", "Sing", "Egg Bomb", "Defense Curl", "Light Screen", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Flash", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power", "Rock_Tomb", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(114, "Tangela", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Leaf-guard", "Regenerator",
    50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1f, 35f,
    87, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Vine", "Many writhing vines cover it, so its true identityremains unknown. The blue vines grow its wholelife long.",
    65, 55, 115, 100, 40, 60, 0, Color.clear,
    new int[] { 1, 1, 4, 10, 13, 19, 22, 28, 31, 37, 40, 46},
    new string[]
    {
         "Constrict", "Ingrain", "Sleep Powder", "Absorb", "Growth", "Poison Powder", "Vine Whip", "Bind", "Mega Drain", "Stun Spore", "Slam", "Tickle",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(115, "Kangaskhan", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Early-bird", "Scrappy", "Inner-focus",
    0f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.2f, 80f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Parent", "It raises its offspring in its belly pouch. It lets thebaby out to play only when it feels safe.",
    105, 95, 80, 40, 80, 90, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Comet Punch", "Leer", "Bite", "Tail Whip", "Fake Out", "Mega Punch", "Rage", "Endure", "Dizzy Punch", "Reversal",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(116, "Horsea", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Sniper", "Damp",
    50f, 225, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 8f,
    59, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Dragon", "Known to shoot down flying bugs with precisionblasts of ink from the surface of the water.",
    30, 40, 70, 70, 25, 60, 0, Color.clear,
    new int[] { 1, 8, 15, 22, 29, 36, 43, 50},
    new string[]
    {
         "Bubble", "Smokescreen", "Leer", "Water Gun", "Twister", "Agility", "Hydro Pump", "Dragon Dance",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {117}, new string[] {"Level,32"}),


new PokemonData(117, "Seadra", PokemonData.Type.WATER, PokemonData.Type.NONE, "Poison-point", "Sniper", "Damp",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 25f,
    154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Dragon", "Its body bristles with sharp spikes. Carelessly tryingto touch it could cause fainting from the spikes.",
    55, 65, 95, 95, 45, 85, 0, Color.clear,
    new int[] { 1, 1, 22, 29, 40, 51, 62},
    new string[]
    {
         "Leer", "Smokescreen", "Water Gun", "Twister", "Agility", "Hydro Pump", "Dragon Dance",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(118, "Goldeen", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Water-veil", "Lightning-rod",
    50f, 225, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 0.6f, 15f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Goldfish", "It swims at a steady 5 knots. If it senses danger,it will strike back with its sharp horn.",
    45, 67, 60, 35, 50, 63, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 15, 24, 29, 38, 43, 52},
    new string[]
    {
         "Tail Whip", "Peck", "Water Sport", "Supersonic", "Horn Attack", "Flail", "Fury Attack", "Waterfall", "Horn Drill", "Agility",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {119}, new string[] {"Level,33"}),


new PokemonData(119, "Seaking", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Water-veil", "Lightning-rod",
    50f, 60, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 1.3f, 39f,
    158, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Goldfish", "In the autumn spawning season, they can be seenswimming powerfully up rivers and creeks.",
    80, 92, 65, 65, 80, 68, 0, Color.clear,
    new int[] { 1, 1, 1, 15, 24, 29, 41, 49, 61},
    new string[]
    {
         "Tail Whip", "Supersonic", "Water Sport", "Horn Attack", "Flail", "Fury Attack", "Waterfall", "Horn Drill", "Agility",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(120, "Staryu", PokemonData.Type.WATER, PokemonData.Type.NONE, "Illuminate", "Natural-cure", "Analytic",
    112.5f, 225, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.8f, 34.5f,
    68, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Star Shape", "Even if its body is torn, it can regenerate as long asthe glowing central core remains intact.",
    30, 45, 55, 70, 55, 85, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 19, 24, 28, 33, 37, 42, 46},
    new string[]
    {
         "Tackle", "Harden", "Water Gun", "Rapid Spin", "Recover", "Camouflage", "Swift", "Bubble Beam", "Minimize", "Light Screen", "Cosmic Power", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Flash", "Rest", "Protect", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(121, "Starmie", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Illuminate", "Natural-cure", "Analytic",
    112.5f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.1f, 80f,
    182, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
    "Mysterious", "Its central core glows with the seven colors of therainbow. Some people value the core as a gem.",
    60, 75, 85, 100, 85, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 33},
    new string[]
    {
         "Water Gun", "Recover", "Swift", "Rapid Spin", "Confuse Ray",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Flash", "Rest", "Protect", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Skill_Swap", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(122, "Mr-mime", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Soundproof", "Filter", "Technician",
    50f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.3f, 54.5f,
    161, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PINK, 70,
    "Barrier", "Emanations from its fingertips solidify the air intoinvisible walls that repel even harsh attacks.",
    40, 45, 65, 100, 120, 90, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 21, 25, 29, 33, 37, 41, 45, 49, 53},
    new string[]
    {
         "Barrier", "Confusion", "Substitute", "Meditate", "Double Slap", "Light Screen", "Reflect", "Encore", "Psybeam", "Recycle", "Trick", "Role Play", "Psychic", "Baton Pass", "Safeguard",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(123, "Scyther", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", "Technician", "Steadfast",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.5f, 56f,
    100, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Mantis", "It tears and shreds prey with its wickedly sharpscythes. It very rarely spreads its wings to fly.",
    70, 110, 80, 55, 80, 105, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 46},
    new string[]
    {
         "Leer", "Quick Attack", "Focus Energy", "Pursuit", "False Swipe", "Agility", "Wing Attack", "Slash", "Swords Dance", "Double Team", "Fury Cutter",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {124}, new string[] {"Level,30"}),


new PokemonData(124, "Jynx", PokemonData.Type.ICE, PokemonData.Type.PSYCHIC, "Oblivious", "Forewarn", "Dry-skin",
    0f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 40.6f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Human Shape", "It wiggles its hips as it walks. It cancause people to dance in unison with it.",
    65, 50, 35, 115, 95, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 21, 25, 35, 41, 51, 57, 67},
    new string[]
    {
         "Pound", "Lick", "Lovely Kiss", "Powder Snow", "Double Slap", "Ice Punch", "Mean Look", "Fake Tears", "Body Slam", "Perish Song", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Skill_Swap", "Secret_Power", "Calm_Mind", "Water_Pulse"
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
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Shock_Wave"
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
         "Flamethrower", "Hyper_Beam", "Strength", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power"
    },
    new int[] {}, new string[] {}),


new PokemonData(127, "Pinsir", PokemonData.Type.BUG, PokemonData.Type.NONE, "Hyper-cutter", "Mold-breaker", "Moxie",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.5f, 55f,
    175, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Stag Beetle", "It grips prey with its pincers until the prey is tornin half. What it can’t tear, it tosses far.",
    65, 125, 100, 55, 70, 85, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Vice Grip", "Focus Energy", "Bind", "Seismic Toss", "Harden", "Revenge", "Brick Break", "Guillotine", "Submission", "Swords Dance",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up"
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
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Shock_Wave", "Water_Pulse"
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
    new int[] { 1, 20, 25, 30, 35, 40, 45, 50, 55},
    new string[]
    {
         "Thrash", "Bite", "Dragon Rage", "Leer", "Twister", "Hydro Pump", "Rain Dance", "Dragon Dance", "Hyper Beam",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(131, "Lapras", PokemonData.Type.WATER, PokemonData.Type.ICE, "Water-absorb", "Shell-armor", "Hydration",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.5f, 220f,
    187, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Transport", "They have gentle hearts. Because they rarelyfight, many have been caught. Their numberhas dwindled.",
    130, 85, 80, 85, 95, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 13, 19, 25, 31, 37, 43, 49, 55},
    new string[]
    {
         "Growl", "Sing", "Water Gun", "Mist", "Body Slam", "Confuse Ray", "Perish Song", "Ice Beam", "Rain Dance", "Safeguard", "Hydro Pump", "Sheer Cold",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Shock_Wave", "Water_Pulse"
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
    new int[] { 1, 1, 1, 8, 16, 23, 30, 36, 42},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Growl", "Quick Attack", "Bite", "Baton Pass", "Take Down",
    },
    new string[]
    {
         "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power"
    },
    new int[] {}, new string[] {}),


new PokemonData(134, "Vaporeon", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", null, "Hydration",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 29f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Bubble Jet", "It prefers beautiful shores. With cells similar towater molecules, it could melt in water.",
    130, 65, 60, 110, 95, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Water Gun", "Quick Attack", "Bite", "Aurora Beam", "Haze", "Acid Armor", "Hydro Pump",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(135, "Jolteon", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Volt-absorb", null, "Quick-feet",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 24.5f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Lightning", "Every hair on its body starts to stand sharply onend if it becomes charged with electricity.",
    65, 65, 60, 110, 95, 130, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Thunder Shock", "Quick Attack", "Double Kick", "Pin Missile", "Thunder Wave", "Agility", "Thunder",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(136, "Flareon", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Guts",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 25f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Flame", "It has a flame sac in its body. Its body temperaturetops 1,650 degrees Fahrenheit before battle.",
    65, 130, 60, 95, 110, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Ember", "Quick Attack", "Bite", "Fire Spin", "Smog", "Leer", "Flamethrower",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Overheat"
    },
    new int[] {}, new string[] {}),


new PokemonData(137, "Porygon", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Trace", "Download", "Analytic",
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.8f, 36.5f,
    79, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Virtual", "A man-made Pokémon that came aboutas a result of research. It is programmedwith only basic motions.",
    65, 60, 70, 85, 75, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 12, 20, 24, 32, 36, 44, 48},
    new string[]
    {
         "Tackle", "Conversion", "Conversion 2", "Agility", "Psybeam", "Recover", "Sharpen", "Lock-On", "Tri Attack", "Recycle", "Zap Cannon",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(138, "Omanyte", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Shell-armor", "Weak-armor",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 7.5f,
    71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Spiral", "A prehistoric Pokémon that lived in the primordialsea, it swims by twisting its 10 tentacles about.",
    35, 40, 100, 90, 55, 35, 0, Color.clear,
    new int[] { 1, 1, 13, 19, 25, 31, 37, 43, 49, 55},
    new string[]
    {
         "Withdraw", "Constrict", "Bite", "Water Gun", "Mud Shot", "Leer", "Protect", "Tickle", "Ancient Power", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {139}, new string[] {"Level,40"}),


new PokemonData(139, "Omastar", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Shell-armor", "Weak-armor",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1f, 35f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Spiral", "Its tentacles are highly developed as if they arehands and feet. As soon as it ensnares prey,it bites.",
    70, 60, 125, 115, 70, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 25, 31, 37, 40, 46, 55, 65},
    new string[]
    {
         "Bite", "Withdraw", "Constrict", "Mud Shot", "Leer", "Protect", "Spike Cannon", "Tickle", "Ancient Power", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(140, "Kabuto", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Battle-armor", "Weak-armor",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 11.5f,
    71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Shellfish", "It is thought to have inhabited beaches 300 millionyears ago. It is protected by a stiff shell.",
    30, 80, 90, 55, 45, 55, 0, Color.clear,
    new int[] { 1, 1, 13, 19, 25, 31, 37, 43, 49, 55},
    new string[]
    {
         "Scratch", "Harden", "Absorb", "Leer", "Mud Shot", "Sand Attack", "Endure", "Metal Sound", "Mega Drain", "Ancient Power",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Water_Pulse"
    },
    new int[] {141}, new string[] {"Level,40"}),


new PokemonData(141, "Kabutops", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Battle-armor", "Weak-armor",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.3f, 40.5f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Shellfish", "In the water, it tucks in its limbs to become morecompact, then it wiggles its shell to swim fast.",
    60, 115, 105, 65, 70, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 19, 25, 31, 37, 40, 46, 65},
    new string[]
    {
         "Scratch", "Absorb", "Harden", "Leer", "Mud Shot", "Sand Attack", "Endure", "Slash", "Metal Sound", "Ancient Power",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Secret_Power", "Dive", "Rock_Tomb", "Aerial_Ace", "Water_Pulse"
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
         "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sandstorm", "Steel_Wing", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw"
    },
    new int[] {}, new string[] {}),


new PokemonData(143, "Snorlax", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Immunity", "Thick-fat", "Gluttony",
    87.5f, 25, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.1f, 460f,
    189, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Sleeping", "It is not satisfied unless it eats over 880 pounds offood every day. When it is done eating, it goespromptly to sleep.",
    160, 110, 65, 65, 110, 30, 0, Color.clear,
    new int[] { 1, 6, 10, 15, 19, 24, 28, 28, 33, 37, 42, 46, 51},
    new string[]
    {
         "Tackle", "Amnesia", "Defense Curl", "Belly Drum", "Headbutt", "Yawn", "Rest", "Snore", "Body Slam", "Block", "Covet", "Rollout", "Hyper Beam",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(144, "Articuno", PokemonData.Type.ICE, PokemonData.Type.FLYING, "Pressure", null, "Snow-cloak",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.7f, 55.4f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.BLUE, 35,
    "Freeze", "A legendary bird Pokémon. It can create blizzardsby freezing moisture in the air.",
    90, 85, 100, 95, 125, 85, 0, Color.clear,
    new int[] { 1, 1, 13, 25, 37, 49, 61, 73, 85},
    new string[]
    {
         "Gust", "Powder Snow", "Mist", "Agility", "Mind Reader", "Ice Beam", "Reflect", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Fly", "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Reflect", "Rest", "Protect", "Sandstorm", "Steel_Wing", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Aerial_Ace", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(145, "Zapdos", PokemonData.Type.ELECTRIC, PokemonData.Type.FLYING, "Pressure", null, "Static",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.6f, 52.6f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
    "Electric", "A legendary bird Pokémon that is said toappear from clouds while dropping enormouslightning bolts.",
    90, 90, 85, 125, 90, 100, 0, Color.clear,
    new int[] { 1, 1, 13, 25, 37, 49, 61, 73, 85},
    new string[]
    {
         "Peck", "Thunder Shock", "Thunder Wave", "Agility", "Detect", "Drill Peck", "Charge", "Light Screen", "Thunder",
    },
    new string[]
    {
         "Fly", "Roar", "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Sandstorm", "Steel_Wing", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Aerial_Ace", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(146, "Moltres", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Pressure", null, "Flame-body",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 60f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
    "Flame", "It is said to be the legendary bird Pokémon of fire. Every flap of its wings creates a dazzling flareof flames.",
    90, 100, 90, 125, 85, 90, 0, Color.clear,
    new int[] { 1, 1, 13, 25, 37, 49, 61, 73, 85},
    new string[]
    {
         "Wing Attack", "Ember", "Fire Spin", "Agility", "Endure", "Flamethrower", "Safeguard", "Heat Wave", "Sky Attack",
    },
    new string[]
    {
         "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Steel_Wing", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Overheat", "Aerial_Ace"
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
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Hail", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
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
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Hail", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
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
         "Cut", "Fly", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Protect", "Sandstorm", "Steel_Wing", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Shock_Wave", "Water_Pulse"
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
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Calm_Mind", "Shock_Wave", "Water_Pulse"
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
         "Cut", "Fly", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Waterfall", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power", "Dive", "Overheat", "Rock_Tomb", "Bullet_Seed", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Calm_Mind", "Shock_Wave", "Water_Pulse"
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
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed"
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
         "Cut", "Flamethrower", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Overheat", "Aerial_Ace"
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
         "Cut", "Roar", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Overheat", "Aerial_Ace"
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
         "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Overheat", "Aerial_Ace"
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
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Aerial_Ace", "Water_Pulse"
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
         "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Aerial_Ace", "Water_Pulse"
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
         "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Aerial_Ace", "Dragon_Claw", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(161, "Sentret", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Keen-eye", "Frisk",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 6f,
    43, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Scout", "When acting as a lookout, it warns others of dangerby screeching and hitting the ground with its tail.",
    35, 46, 34, 35, 45, 20, 0, Color.clear,
    new int[] { 1, 4, 7, 12, 17, 24, 31, 40, 49},
    new string[]
    {
         "Scratch", "Defense Curl", "Quick Attack", "Fury Swipes", "Helping Hand", "Slam", "Follow Me", "Rest", "Amnesia",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Surf", "Ice_Beam", "Solar_Beam", "Thunderbolt", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Shock_Wave", "Water_Pulse"
    },
    new int[] {162}, new string[] {"Level,15"}),


new PokemonData(162, "Furret", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Keen-eye", "Frisk",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.8f, 32.5f,
    145, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Long Body", "The mother puts its offspring to sleep by curling uparound them. It corners foes with speed.",
    85, 76, 64, 45, 55, 90, 0, Color.clear,
    new int[] { 1, 1, 4, 12, 19, 28, 37, 48, 59},
    new string[]
    {
         "Scratch", "Quick Attack", "Defense Curl", "Fury Swipes", "Helping Hand", "Slam", "Follow Me", "Rest", "Amnesia",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Shock_Wave", "Water_Pulse"
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
         "Fly", "Toxic", "Psychic", "Double_Team", "Reflect", "Flash", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace"
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
         "Fly", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Reflect", "Flash", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace"
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
         "Solar_Beam", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Aerial_Ace"
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
         "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Aerial_Ace"
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
         "Poison Sting", "String Shot", "Scary Face", "Constrict", "Night Shade", "Leech Life", "Fury Swipes", "Spider Web", "Agility", "Psychic",
    },
    new string[]
    {
         "Solar_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power"
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
         "Poison Sting", "String Shot", "Constrict", "Scary Face", "Night Shade", "Fury Swipes", "Spider Web", "Agility", "Psychic",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power"
    },
    new int[] {}, new string[] {}),


new PokemonData(169, "Crobat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
    50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.8f, 75f,
    241, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.PURPLE, 70,
    "Bat", "It flies so silently through the dark on its four wingsthat it may not be noticed even when nearby.",
    85, 90, 80, 70, 80, 130, 0, Color.clear,
    new int[] { 1, 1, 1, 16, 21, 28, 42, 49, 56},
    new string[]
    {
         "Supersonic", "Leech Life", "Astonish", "Bite", "Wing Attack", "Confuse Ray", "Mean Look", "Poison Fang", "Haze",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(170, "Chinchou", PokemonData.Type.WATER, PokemonData.Type.ELECTRIC, "Volt-absorb", "Illuminate", "Water-absorb",
    50f, 190, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.5f, 12f,
    66, PokemonData.LevelingRate.SLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Angler", "On the dark ocean floor, its only means ofcommunication is its constantly flashing lights.",
    75, 38, 38, 56, 56, 67, 0, Color.clear,
    new int[] { 1, 1, 5, 13, 17, 25, 29, 37, 41, 49},
    new string[]
    {
         "Thunder Wave", "Bubble", "Supersonic", "Flail", "Water Gun", "Spark", "Confuse Ray", "Take Down", "Hydro Pump", "Charge",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Shock_Wave", "Water_Pulse"
    },
    new int[] {171}, new string[] {"Level,27"}),


new PokemonData(171, "Lanturn", PokemonData.Type.WATER, PokemonData.Type.ELECTRIC, "Volt-absorb", "Illuminate", "Water-absorb",
    50f, 75, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 1.2f, 22.5f,
    161, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Light", "Lanturn’s light can shine up from great depths. It is nicknamed “The Deep-Sea Star. ",
    125, 58, 58, 76, 76, 67, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 25, 32, 43, 50, 61},
    new string[]
    {
         "Supersonic", "Thunder Wave", "Bubble", "Flail", "Spark", "Confuse Ray", "Take Down", "Hydro Pump", "Charge",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Shock_Wave", "Water_Pulse"
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
         "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Facade", "Secret_Power", "Shock_Wave"
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
         "Flamethrower", "Solar_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
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
         "Flamethrower", "Solar_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(175, "Togepi", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Hustle", "Serene-grace", "Super-luck",
    87.5f, 190, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 1.5f,
    49, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.WHITE, 70,
    "Spike Ball", "The shell seems to be filled with joy. It is said thatit will share good luck when treated kindly.",
    35, 20, 65, 40, 65, 20, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 31, 36, 41},
    new string[]
    {
         "Growl", "Charm", "Metronome", "Sweet Kiss", "Yawn", "Encore", "Follow Me", "Wish", "Safeguard", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(176, "Togetic", PokemonData.Type.FAIRY, PokemonData.Type.FLYING, "Hustle", "Serene-grace", "Super-luck",
    87.5f, 75, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.6f, 3.2f,
    142, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.WHITE, 70,
    "Happiness", "It grows dispirited if it is not with kind people. It can float in midair without moving its wings.",
    55, 40, 85, 80, 105, 40, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 31, 36, 41},
    new string[]
    {
         "Growl", "Charm", "Metronome", "Sweet Kiss", "Yawn", "Encore", "Follow Me", "Wish", "Safeguard", "Double-Edge",
    },
    new string[]
    {
         "Fly", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(177, "Natu", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Synchronize", "Early-bird", "Magic-bounce",
    50f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.2f, 2f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Tiny Bird", "Because its wings aren’t yet fully grown, it hasto hop to get around. It is always staringat something.",
    40, 50, 45, 70, 45, 70, 0, Color.clear,
    new int[] { 1, 1, 10, 20, 30, 30, 40, 50},
    new string[]
    {
         "Leer", "Peck", "Night Shade", "Teleport", "Future Sight", "Wish", "Confuse Ray", "Psychic",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Aerial_Ace", "Calm_Mind"
    },
    new int[] {178}, new string[] {"Level,25"}),


new PokemonData(178, "Xatu", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Synchronize", "Early-bird", "Magic-bounce",
    50f, 75, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.5f, 15f,
    165, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Mystic", "Once it begins to meditate at sunrise, the entire daywill pass before it will move again.",
    65, 75, 70, 95, 70, 95, 0, Color.clear,
    new int[] { 1, 1, 10, 20, 35, 35, 50, 65},
    new string[]
    {
         "Leer", "Peck", "Night Shade", "Teleport", "Future Sight", "Wish", "Confuse Ray", "Psychic",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Aerial_Ace", "Calm_Mind"
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
         "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Facade", "Secret_Power", "Shock_Wave"
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
         "Strength", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Shock_Wave"
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
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(182, "Bellossom", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", null, "Healer",
    50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 5.8f,
    221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.GREEN, 70,
    "Flower", "Bellossom gather at times and seem to dance. They say that the dance is a ritual to summonthe sun.",
    75, 80, 95, 90, 100, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 44, 55},
    new string[]
    {
         "Absorb", "Stun Spore", "Sweet Scent", "Magical Leaf", "Petal Dance", "Solar Beam",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(183, "Marill", PokemonData.Type.WATER, PokemonData.Type.FAIRY, "Thick-fat", "Huge-power", "Sap-sipper",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 8.5f,
    88, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Aqua Mouse", "The fur on its body naturally repels water. It canstay dry, even when it plays in the water.",
    70, 20, 50, 20, 50, 40, 0, Color.clear,
    new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45},
    new string[]
    {
         "Tackle", "Defense Curl", "Tail Whip", "Water Gun", "Rollout", "Bubble Beam", "Double-Edge", "Rain Dance", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {184}, new string[] {"Level,18"}),


new PokemonData(184, "Azumarill", PokemonData.Type.WATER, PokemonData.Type.FAIRY, "Thick-fat", "Huge-power", "Sap-sipper",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 28.5f,
    189, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Aqua Rabbit", "Its long ears are superb sensors. It can distinguishthe movements of living things on riverbeds.",
    100, 50, 80, 60, 80, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 24, 34, 45, 57},
    new string[]
    {
         "Tackle", "Tail Whip", "Defense Curl", "Water Gun", "Bubble Beam", "Double-Edge", "Rain Dance", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(185, "Sudowoodo", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Sturdy", "Rock-head", "Rattled",
    50f, 65, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 257, 1.2f, 38f,
    144, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Imitation", "Although it always pretends to be a tree, itscomposition appears more similar to rock thanto vegetation.",
    70, 100, 115, 30, 65, 30, 0, Color.clear,
    new int[] { 1, 1, 9, 17, 25, 33, 41, 49, 57},
    new string[]
    {
         "Rock Throw", "Mimic", "Flail", "Low Kick", "Rock Slide", "Block", "Feint Attack", "Slam", "Double-Edge",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Rock_Tomb", "Calm_Mind"
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
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(187, "Hoppip", PokemonData.Type.GRASS, PokemonData.Type.FLYING, "Chlorophyll", "Leaf-guard", "Infiltrator",
    50f, 255, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 0.5f,
    50, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PINK, 70,
    "Cottonweed", "Its body is so light, it must grip the ground firmlywith its feet to keep from being blown away.",
    35, 35, 40, 35, 55, 50, 0, Color.clear,
    new int[] { 1, 5, 5, 10, 13, 15, 17, 20, 25, 30},
    new string[]
    {
         "Splash", "Tail Whip", "Synthesis", "Tackle", "Poison Powder", "Stun Spore", "Sleep Powder", "Leech Seed", "Cotton Spore", "Mega Drain",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed", "Aerial_Ace"
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
         "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed", "Aerial_Ace"
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
         "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(190, "Aipom", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Pickup", "Skill-link",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.8f, 11.5f,
    72, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Long Tail", "It lives atop tall trees. When leaping from branch tobranch, it deftly uses its tail for balance.",
    55, 70, 55, 40, 55, 85, 0, Color.clear,
    new int[] { 1, 1, 6, 13, 18, 25, 31, 38, 43, 50},
    new string[]
    {
         "Scratch", "Tail Whip", "Sand Attack", "Astonish", "Baton Pass", "Tickle", "Fury Swipes", "Swift", "Screech", "Agility",
    },
    new string[]
    {
         "Cut", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Snatch", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(191, "Sunkern", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Solar-power", "Early-bird",
    50f, 235, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.3f, 1.8f,
    36, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Seed", "It may plummet from the sky. If attacked by aSpearow, it will violently shake its leaves.",
    30, 30, 30, 30, 30, 30, 0, Color.clear,
    new int[] { 1, 6, 13, 18, 25, 30, 37, 42},
    new string[]
    {
         "Absorb", "Growth", "Mega Drain", "Ingrain", "Endeavor", "Sunny Day", "Synthesis", "Giga Drain",
    },
    new string[]
    {
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(192, "Sunflora", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Solar-power", "Early-bird",
    50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.8f, 8.5f,
    149, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Sun", "As the hot season approaches, the petals on thisPokémon’s face become more vivid and lively.",
    75, 75, 55, 105, 85, 30, 0, Color.clear,
    new int[] { 1, 1, 6, 13, 18, 25, 30, 37, 42},
    new string[]
    {
         "Pound", "Absorb", "Growth", "Razor Leaf", "Ingrain", "Bullet Seed", "Sunny Day", "Petal Dance", "Solar Beam",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(193, "Yanma", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Speed-boost", "Compound-eyes", "Frisk",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.2f, 38f,
    78, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
    "Clear Wing", "Its eyes can see 360 degrees without moving itshead. It won’t miss prey--even those behind it.",
    65, 65, 45, 75, 45, 95, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Tackle", "Foresight", "Quick Attack", "Double Team", "Sonic Boom", "Detect", "Supersonic", "Uproar", "Wing Attack", "Screech",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(194, "Wooper", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Damp", "Water-absorb", "Unaware",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 0.4f, 8.5f,
    42, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Water Fish", "This Pokémon lives in cold water. It will leave thewater to search for food when it gets cold outside.",
    55, 45, 45, 25, 25, 15, 0, Color.clear,
    new int[] { 1, 1, 11, 16, 21, 31, 36, 41, 51, 51},
    new string[]
    {
         "Tail Whip", "Water Gun", "Slam", "Mud Shot", "Amnesia", "Yawn", "Earthquake", "Rain Dance", "Mist", "Haze",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Protect", "Sludge_Bomb", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {195}, new string[] {"Level,20"}),


new PokemonData(195, "Quagsire", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Damp", "Water-absorb", "Unaware",
    50f, 90, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1.4f, 75f,
    151, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Water Fish", "It has a sluggish nature. It lies at the river’s bottom,waiting for prey to stray into its mouth.",
    95, 85, 85, 65, 65, 35, 0, Color.clear,
    new int[] { 1, 1, 11, 16, 23, 35, 42, 49, 61, 61},
    new string[]
    {
         "Tail Whip", "Water Gun", "Slam", "Mud Shot", "Amnesia", "Yawn", "Earthquake", "Rain Dance", "Mist", "Haze",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Protect", "Sludge_Bomb", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(196, "Espeon", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", null, "Magic-bounce",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 26.5f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sun", "The tip of its forked tail quivers when it is predictingits opponent’s next move.",
    65, 65, 60, 130, 95, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Confusion", "Quick Attack", "Swift", "Psybeam", "Psych Up", "Psychic", "Morning Sun",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Calm_Mind"
    },
    new int[] {}, new string[] {}),


new PokemonData(197, "Umbreon", PokemonData.Type.DARK, PokemonData.Type.NONE, "Synchronize", null, "Inner-focus",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 27f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLACK, 35,
    "Moonlight", "The light of the moon changed Eevee’s geneticstructure. It lurks in darkness for prey.",
    95, 65, 110, 60, 130, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 16, 23, 30, 36, 42, 47, 52},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Pursuit", "Quick Attack", "Confuse Ray", "Feint Attack", "Mean Look", "Screech", "Moonlight",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power"
    },
    new int[] {}, new string[] {}),


new PokemonData(198, "Murkrow", PokemonData.Type.DARK, PokemonData.Type.FLYING, "Insomnia", "Super-luck", "Prankster",
    50f, 30, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 0.5f, 2.1f,
    81, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLACK, 35,
    "Darkness", "It hides any shiny object it finds in a secretlocation. Murkrow and Meowth loot oneanother’s stashes.",
    60, 85, 42, 85, 42, 91, 0, Color.clear,
    new int[] { 1, 9, 14, 22, 27, 35, 40, 48},
    new string[]
    {
         "Peck", "Astonish", "Pursuit", "Haze", "Night Shade", "Feint Attack", "Taunt", "Mean Look",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power", "Aerial_Ace", "Calm_Mind"
    },
    new int[] {}, new string[] {}),


new PokemonData(199, "Slowking", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
    50f, 70, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2f, 79.5f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.PINK, 70,
    "Royal", "It has incredible intellect and intuition. Whateverthe situation, it remains calm and collected.",
    95, 75, 80, 100, 110, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 6, 15, 20, 29, 34, 43, 48},
    new string[]
    {
         "Tackle", "Curse", "Yawn", "Growl", "Water Gun", "Confusion", "Disable", "Headbutt", "Swagger", "Psychic",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Skill_Swap", "Secret_Power", "Dive", "Calm_Mind", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(200, "Misdreavus", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.7f, 1f,
    87, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GRAY, 35,
    "Screech", "It gets nourishment from fear that it absorbs into itsred orbs. In daytime, it sleeps in darkness.",
    60, 60, 60, 85, 85, 85, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 17, 23, 30, 37, 45, 53},
    new string[]
    {
         "Growl", "Psywave", "Spite", "Astonish", "Confuse Ray", "Mean Look", "Psybeam", "Pain Split", "Perish Song", "Grudge",
    },
    new string[]
    {
         "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Aerial_Ace", "Calm_Mind", "Shock_Wave"
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
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Tackle", "Growl", "Astonish", "Confusion", "Stomp", "Odor Sleuth", "Agility", "Baton Pass", "Psybeam", "Crunch",
    },
    new string[]
    {
         "Strength", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Skill_Swap", "Secret_Power", "Calm_Mind", "Shock_Wave"
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
         "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power"
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
         "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power"
    },
    new int[] {}, new string[] {}),


new PokemonData(206, "Dunsparce", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Serene-grace", "Run-away", "Rattled",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.5f, 14f,
    145, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Land Snake", "When spotted, this Pokémon escapes backward byfuriously boring into the ground with its tail.",
    100, 70, 70, 65, 65, 45, 0, Color.clear,
    new int[] { 1, 4, 11, 14, 21, 24, 31, 34, 41},
    new string[]
    {
         "Rage", "Defense Curl", "Yawn", "Glare", "Spite", "Pursuit", "Screech", "Take Down", "Endeavor",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Calm_Mind", "Shock_Wave", "Water_Pulse"
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
         "Cut", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Steel_Wing", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(208, "Steelix", PokemonData.Type.STEEL, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sheer-force",
    50f, 25, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 257, 9.2f, 400f,
    179, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Iron Snake", "Tempered underground under high pressure andheat, its body is harder than any metal.",
    75, 85, 200, 55, 65, 30, 0, Color.clear,
    new int[] { 1, 1, 9, 13, 21, 25, 33, 37, 45, 49, 57},
    new string[]
    {
         "Tackle", "Screech", "Bind", "Rock Throw", "Harden", "Rage", "Sandstorm", "Slam", "Iron Tail", "Crunch", "Double-Edge",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Secret_Power", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(209, "Snubbull", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Intimidate", "Run-away", "Rattled",
    25f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 7.8f,
    60, PokemonData.LevelingRate.FAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Fairy", "It has an active, playful nature. Many women like tofrolic with it because of its affectionate ways.",
    60, 80, 50, 40, 40, 30, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 13, 19, 26, 34, 43, 53},
    new string[]
    {
         "Tackle", "Scary Face", "Tail Whip", "Charm", "Bite", "Lick", "Roar", "Rage", "Take Down", "Crunch",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Overheat", "Bulk_Up", "Shock_Wave", "Water_Pulse"
    },
    new int[] {210}, new string[] {"Level,23"}),


new PokemonData(210, "Granbull", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Intimidate", "Quick-feet", "Rattled",
    25f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 48.7f,
    158, PokemonData.LevelingRate.FAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Fairy", "It is timid in spite of its looks. If it becomesenraged, however, it will strike with its huge fangs.",
    90, 120, 75, 60, 60, 45, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 13, 19, 28, 38, 49, 61},
    new string[]
    {
         "Tackle", "Scary Face", "Tail Whip", "Charm", "Bite", "Lick", "Roar", "Rage", "Take Down", "Crunch",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Overheat", "Rock_Tomb", "Bulk_Up", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(211, "Qwilfish", PokemonData.Type.WATER, PokemonData.Type.POISON, "Poison-point", "Swift-swim", "Intimidate",
    50f, 45, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.5f, 3.9f,
    88, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Balloon", "To fire its poison spikes, it must inflate its body bydrinking over 2. 6 gallons of water all at once.",
    65, 95, 85, 55, 55, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 10, 19, 28, 37, 46},
    new string[]
    {
         "Tackle", "Poison Sting", "Spikes", "Harden", "Minimize", "Water Gun", "Pin Missile", "Take Down", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Facade", "Secret_Power", "Dive", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(212, "Scizor", PokemonData.Type.BUG, PokemonData.Type.STEEL, "Swarm", "Technician", "Light-metal",
    50f, 25, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.8f, 118f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Pincer", "This Pokémon’s pincers, which contain steel, cancrush any hard object it gets ahold of into bits.",
    70, 130, 100, 55, 80, 65, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 46},
    new string[]
    {
         "Leer", "Quick Attack", "Focus Energy", "Pursuit", "False Swipe", "Agility", "Metal Claw", "Slash", "Swords Dance", "Double Team", "Fury Cutter",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sandstorm", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Aerial_Ace"
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
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Sandstorm", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(214, "Heracross", PokemonData.Type.BUG, PokemonData.Type.FIGHTING, "Swarm", "Guts", "Moxie",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.5f, 54f,
    175, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Single Horn", "This powerful Pokémon thrusts its prized horn underits enemies’ bellies, then lifts and throws them.",
    80, 125, 75, 40, 95, 85, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 17, 23, 30, 37, 45, 53},
    new string[]
    {
         "Tackle", "Leer", "Horn Attack", "Endure", "Fury Attack", "Brick Break", "Counter", "Take Down", "Reversal", "Megahorn",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up"
    },
    new int[] {}, new string[] {}),


new PokemonData(215, "Sneasel", PokemonData.Type.DARK, PokemonData.Type.ICE, "Inner-focus", "Keen-eye", "Pickpocket",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.9f, 28f,
    86, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLACK, 35,
    "Sharp Claw", "It feeds on eggs stolen from nests. Its sharplyhooked claws rip vulnerable spots on prey.",
    55, 95, 55, 35, 75, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 15, 22, 29, 36, 43, 50, 57, 64},
    new string[]
    {
         "Scratch", "Leer", "Taunt", "Quick Attack", "Screech", "Feint Attack", "Fury Swipes", "Agility", "Icy Wind", "Slash", "Beat Up", "Metal Claw",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Snatch", "Secret_Power", "Aerial_Ace", "Calm_Mind"
    },
    new int[] {}, new string[] {}),


new PokemonData(216, "Teddiursa", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Quick-feet", "Honey-gather",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 8.8f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Little Bear", "If it finds honey, its crescent mark glows. It alwayslicks its paws because they’re soaked with honey.",
    60, 80, 50, 50, 50, 40, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Scratch", "Leer", "Lick", "Fury Swipes", "Fake Tears", "Feint Attack", "Rest", "Slash", "Snore", "Thrash",
    },
    new string[]
    {
         "Cut", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Aerial_Ace", "Bulk_Up"
    },
    new int[] {217}, new string[] {"Level,30"}),


new PokemonData(217, "Ursaring", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Guts", "Quick-feet", "Unnerve",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.8f, 125.8f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Hibernator", "With its ability to distinguish any aroma, itunfailingly finds all food buried deep underground.",
    90, 130, 75, 75, 75, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Scratch", "Leer", "Lick", "Fury Swipes", "Fake Tears", "Feint Attack", "Rest", "Slash", "Snore", "Thrash",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Bulk_Up"
    },
    new int[] {}, new string[] {}),


new PokemonData(218, "Slugma", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Magma-armor", "Flame-body", "Weak-armor",
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.7f, 35f,
    50, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Lava", "A common sight in volcanic areas, it slowly slithersaround in a constant search for warm places.",
    40, 40, 40, 70, 40, 20, 0, Color.clear,
    new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50},
    new string[]
    {
         "Smog", "Yawn", "Ember", "Rock Throw", "Harden", "Amnesia", "Flamethrower", "Rock Slide", "Body Slam",
    },
    new string[]
    {
         "Flamethrower", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Overheat"
    },
    new int[] {219}, new string[] {"Level,38"}),


new PokemonData(219, "Magcargo", PokemonData.Type.FIRE, PokemonData.Type.ROCK, "Magma-armor", "Flame-body", "Weak-armor",
    50f, 75, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.8f, 55f,
    151, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Lava", "Its brittle shell occasionally spouts intense flamesthat circulate throughout its body.",
    60, 50, 120, 90, 80, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 29, 48, 60},
    new string[]
    {
         "Ember", "Rock Throw", "Smog", "Yawn", "Amnesia", "Rock Slide", "Body Slam",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Overheat", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(220, "Swinub", PokemonData.Type.ICE, PokemonData.Type.GROUND, "Oblivious", "Snow-cloak", "Thick-fat",
    50f, 225, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 6.5f,
    50, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Pig", "It rubs its snout on the ground to find and dig upfood. It sometimes discovers hot springs.",
    50, 50, 40, 30, 30, 50, 0, Color.clear,
    new int[] { 1, 1, 10, 19, 28, 37, 46, 55},
    new string[]
    {
         "Tackle", "Odor Sleuth", "Powder Snow", "Endure", "Take Down", "Mist", "Blizzard", "Amnesia",
    },
    new string[]
    {
         "Roar", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Rock_Tomb"
    },
    new int[] {221}, new string[] {"Level,33"}),


new PokemonData(221, "Piloswine", PokemonData.Type.ICE, PokemonData.Type.GROUND, "Oblivious", "Snow-cloak", "Thick-fat",
    50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.1f, 55.8f,
    158, PokemonData.LevelingRate.SLOW, 1, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Swine", "Although its legs are short, its rugged hoovesprevent it from slipping, even on icy ground.",
    100, 100, 80, 60, 60, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 19, 28, 33, 42, 56, 70},
    new string[]
    {
         "Horn Attack", "Powder Snow", "Odor Sleuth", "Endure", "Take Down", "Fury Attack", "Mist", "Blizzard", "Amnesia",
    },
    new string[]
    {
         "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(222, "Corsola", PokemonData.Type.WATER, PokemonData.Type.ROCK, "Hustle", "Natural-cure", "Regenerator",
    25f, 60, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 5f,
    144, PokemonData.LevelingRate.FAST, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.PINK, 70,
    "Coral", "It continuously sheds and grows. The tip of its headis prized as a treasure because of its beauty.",
    65, 55, 95, 65, 95, 35, 0, Color.clear,
    new int[] { 1, 6, 12, 17, 17, 23, 28, 34, 39, 45},
    new string[]
    {
         "Tackle", "Harden", "Bubble", "Recover", "Refresh", "Bubble Beam", "Spike Cannon", "Rock Blast", "Mirror Coat", "Ancient Power",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Rock_Tomb", "Calm_Mind", "Water_Pulse"
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
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Dive", "Water_Pulse"
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
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Dive", "Bullet_Seed", "Water_Pulse"
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
         "Fly", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Focus_Punch", "Secret_Power", "Aerial_Ace", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(226, "Mantine", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Swift-swim", "Water-absorb", "Water-veil",
    50f, 25, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 2.1f, 220f,
    170, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Kite", "If it builds up enough speed swimming, it can flyover 300 feet out of the water from the surface ofthe ocean.",
    85, 40, 70, 80, 140, 70, 0, Color.clear,
    new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50},
    new string[]
    {
         "Tackle", "Bubble", "Supersonic", "Bubble Beam", "Take Down", "Agility", "Wing Attack", "Water Pulse", "Confuse Ray",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Aerial_Ace", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(227, "Skarmory", PokemonData.Type.STEEL, PokemonData.Type.FLYING, "Keen-eye", "Sturdy", "Weak-armor",
    50f, 25, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.7f, 50.5f,
    163, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Armor Bird", "After nesting in bramble bushes, the wings of itschicks grow hard from scratches by thorns.",
    65, 80, 140, 40, 70, 70, 0, Color.clear,
    new int[] { 1, 1, 10, 13, 16, 26, 29, 32, 42, 45},
    new string[]
    {
         "Leer", "Peck", "Sand Attack", "Swift", "Agility", "Fury Attack", "Air Cutter", "Steel Wing", "Spikes", "Metal Sound",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sandstorm", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(228, "Houndour", PokemonData.Type.DARK, PokemonData.Type.FIRE, "Early-bird", "Flash-fire", "Unnerve",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 10.8f,
    66, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Dark", "Around dawn, its ominous howl echoes throughthe area to announce that this is its territory.",
    45, 60, 30, 80, 50, 65, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Leer", "Ember", "Howl", "Smog", "Roar", "Bite", "Odor Sleuth", "Feint Attack", "Flamethrower", "Crunch",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power", "Overheat"
    },
    new int[] {229}, new string[] {"Level,24"}),


new PokemonData(229, "Houndoom", PokemonData.Type.DARK, PokemonData.Type.FIRE, "Early-bird", "Flash-fire", "Unnerve",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.4f, 35f,
    175, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Dark", "Long ago, people imagined its eerie howls to bethe call of the grim reaper.",
    75, 90, 50, 110, 80, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 19, 27, 35, 43, 51, 59},
    new string[]
    {
         "Leer", "Ember", "Howl", "Smog", "Roar", "Bite", "Odor Sleuth", "Feint Attack", "Flamethrower", "Crunch",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power", "Overheat"
    },
    new int[] {}, new string[] {}),


new PokemonData(230, "Kingdra", PokemonData.Type.WATER, PokemonData.Type.DRAGON, "Swift-swim", "Sniper", "Damp",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.8f, 152f,
    243, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 1, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Dragon", "It is said that it usually hides in underwater caves. It can create whirlpools by yawning.",
    75, 95, 95, 95, 95, 85, 0, Color.clear,
    new int[] { 1, 1, 22, 29, 40, 51, 62},
    new string[]
    {
         "Leer", "Smokescreen", "Water Gun", "Twister", "Agility", "Hydro Pump", "Dragon Dance",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(231, "Phanpy", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Pickup", null, "Sand-veil",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 33.5f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Long Nose", "As a sign of affection, it bumps with its snout. However, it is so strong, it may send you flying.",
    90, 60, 60, 40, 40, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 17, 25, 33, 41, 49},
    new string[]
    {
         "Tackle", "Growl", "Odor Sleuth", "Defense Curl", "Flail", "Take Down", "Rollout", "Endure", "Double-Edge",
    },
    new string[]
    {
         "Roar", "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb"
    },
    new int[] {232}, new string[] {"Level,25"}),


new PokemonData(232, "Donphan", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sturdy", null, "Sand-veil",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.1f, 120f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Armor", "It has sharp, hard tusks and a rugged hide. Its Tackle is strong enough to knock down a house.",
    90, 120, 120, 60, 60, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 17, 25, 33, 41, 49},
    new string[]
    {
         "Horn Attack", "Growl", "Odor Sleuth", "Defense Curl", "Flail", "Fury Attack", "Rollout", "Rapid Spin", "Earthquake",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(233, "Porygon2", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Trace", "Download", "Analytic",
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.6f, 32.5f,
    180, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Virtual", "Further research enhanced its abilities. Sometimes,it may exhibit motions that were not programmed.",
    85, 80, 90, 105, 95, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 12, 20, 24, 32, 36, 44, 48},
    new string[]
    {
         "Tackle", "Conversion", "Conversion 2", "Agility", "Psybeam", "Recover", "Defense Curl", "Lock-On", "Tri Attack", "Recycle", "Zap Cannon",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(234, "Stantler", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Intimidate", "Frisk", "Sap-sipper",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 71.2f,
    163, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Big Horn", "Staring at its antlers creates an odd sensationas if one were being drawn into their centers.",
    73, 95, 62, 85, 65, 85, 0, Color.clear,
    new int[] { 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Tackle", "Leer", "Astonish", "Hypnosis", "Stomp", "Sand Attack", "Take Down", "Confuse Ray", "Calm Mind",
    },
    new string[]
    {
         "Roar", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Calm_Mind", "Shock_Wave"
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
         "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Bulk_Up"
    },
    new int[] {237}, new string[] {"Level,20"}),


new PokemonData(237, "Hitmontop", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Intimidate", "Technician", "Steadfast",
    100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 48f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BROWN, 70,
    "Handstand", "It fights while spinning like a top. The centrifugalforce boosts its destructive power by 10.",
    50, 95, 95, 35, 110, 70, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 20, 25, 31, 37, 43, 49},
    new string[]
    {
         "Rolling Kick", "Revenge", "Focus Energy", "Pursuit", "Quick Attack", "Triple Kick", "Rapid Spin", "Counter", "Agility", "Detect", "Endeavor",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Bulk_Up"
    },
    new int[] {}, new string[] {}),


new PokemonData(238, "Smoochum", PokemonData.Type.ICE, PokemonData.Type.PSYCHIC, "Oblivious", "Forewarn", "Hydration",
    0f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.4f, 6f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Kiss", "Its lips are the most sensitive part of its body. It always uses its lips first to examine things.",
    45, 30, 15, 85, 65, 65, 0, Color.clear,
    new int[] { 1, 1, 9, 13, 21, 25, 33, 37, 45, 49, 57},
    new string[]
    {
         "Pound", "Lick", "Sweet Kiss", "Powder Snow", "Confusion", "Sing", "Mean Look", "Fake Tears", "Psychic", "Perish Song", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Facade", "Skill_Swap", "Secret_Power", "Calm_Mind", "Water_Pulse"
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
         "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Shock_Wave"
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
         "Flamethrower", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power"
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
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(242, "Blissey", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Natural-cure", "Serene-grace", "Healer",
    0f, 30, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.5f, 46.8f,
    608, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
    "Happiness", "The eggs it lays are filled with happiness. Eatingeven one bite will bring a smile to anyone.",
    255, 10, 10, 75, 135, 55, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 18, 23, 28, 33, 40, 47},
    new string[]
    {
         "Pound", "Growl", "Tail Whip", "Refresh", "Soft-Boiled", "Double Slap", "Minimize", "Sing", "Egg Bomb", "Defense Curl", "Light Screen", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Flash", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power", "Rock_Tomb", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(243, "Raikou", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Pressure", null, "Inner-focus",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.9f, 178f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 2, PokemonData.PokedexColor.YELLOW, 35,
    "Thunder", "The rain clouds it carries let it fire thunderboltsat will. They say that it descended with lightning.",
    90, 85, 75, 115, 100, 115, 0, Color.clear,
    new int[] { 1, 1, 11, 21, 31, 41, 51, 61, 71, 81},
    new string[]
    {
         "Leer", "Bite", "Thunder Shock", "Roar", "Quick Attack", "Spark", "Reflect", "Crunch", "Thunder", "Calm Mind",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(244, "Entei", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Pressure", null, "Inner-focus",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2.1f, 198f,
    261, PokemonData.LevelingRate.SLOW, 1, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 35,
    "Volcano", "A Pokémon that races across the land. It is saidthat one is born every time a new volcano appears.",
    115, 115, 85, 90, 75, 100, 0, Color.clear,
    new int[] { 1, 1, 11, 21, 31, 41, 51, 61, 71, 81},
    new string[]
    {
         "Leer", "Bite", "Ember", "Roar", "Fire Spin", "Stomp", "Flamethrower", "Swagger", "Fire Blast", "Calm Mind",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Calm_Mind"
    },
    new int[] {}, new string[] {}),


new PokemonData(245, "Suicune", PokemonData.Type.WATER, PokemonData.Type.NONE, "Pressure", null, "Inner-focus",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 187f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 2, 0, PokemonData.PokedexColor.BLUE, 35,
    "Aurora", "It races around the world to purify fouled water. It dashes away with the north wind.",
    100, 75, 115, 90, 115, 85, 0, Color.clear,
    new int[] { 1, 1, 11, 21, 31, 41, 51, 61, 71, 81},
    new string[]
    {
         "Leer", "Bite", "Bubble Beam", "Rain Dance", "Gust", "Aurora Beam", "Mist", "Mirror Coat", "Hydro Pump", "Calm Mind",
    },
    new string[]
    {
         "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Reflect", "Waterfall", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Calm_Mind", "Water_Pulse"
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
         "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Secret_Power"
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
         "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Secret_Power"
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
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Shock_Wave", "Water_Pulse"
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
         "Whirlwind", "Safeguard", "Gust", "Recover", "Hydro Pump", "Rain Dance", "Swift", "Aeroblast", "Ancient Power", "Future Sight",
    },
    new string[]
    {
         "Fly", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Steel_Wing", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Skill_Swap", "Secret_Power", "Dive", "Aerial_Ace", "Calm_Mind", "Shock_Wave", "Water_Pulse"
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
         "Whirlwind", "Safeguard", "Gust", "Recover", "Fire Blast", "Sunny Day", "Swift", "Sacred Fire", "Ancient Power", "Future Sight",
    },
    new string[]
    {
         "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Steel_Wing", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Secret_Power", "Overheat", "Aerial_Ace", "Calm_Mind", "Shock_Wave"
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
         "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Aerial_Ace", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(252, "Treecko", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Unburden",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 5f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Wood Gecko", "It quickly scales even vertical walls. It senseshumidity with its tail to predict the nextday’s weather.",
    40, 45, 35, 65, 55, 70, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 46},
    new string[]
    {
         "Pound", "Leer", "Absorb", "Quick Attack", "Pursuit", "Screech", "Mega Drain", "Agility", "Slam", "Detect", "Giga Drain",
    },
    new string[]
    {
         "Cut", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bullet_Seed", "Aerial_Ace"
    },
    new int[] {253}, new string[] {"Level,16"}),


new PokemonData(253, "Grovyle", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Unburden",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 21.6f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
    "Wood Gecko", "Its strongly developed thigh muscles give itastounding agility and jumping performance.",
    50, 65, 45, 85, 65, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 16, 17, 29, 41, 47, 53},
    new string[]
    {
         "Pound", "Leer", "Absorb", "Quick Attack", "Fury Cutter", "Pursuit", "Leaf Blade", "Slam", "Detect", "False Swipe",
    },
    new string[]
    {
         "Cut", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bullet_Seed", "Aerial_Ace"
    },
    new int[] {254}, new string[] {"Level,36"}),


new PokemonData(254, "Sceptile", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Unburden",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.7f, 52.2f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.GREEN, 70,
    "Forest", "The leaves that grow on its arms can slice downthick trees. It is without peer in jungle combat.",
    70, 85, 65, 105, 85, 120, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 16, 17, 29, 43, 51, 59},
    new string[]
    {
         "Pound", "Leer", "Absorb", "Quick Attack", "Fury Cutter", "Pursuit", "Leaf Blade", "Slam", "Detect", "False Swipe",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bullet_Seed", "Aerial_Ace", "Dragon_Claw"
    },
    new int[] {}, new string[] {}),


new PokemonData(255, "Torchic", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Speed-boost",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.4f, 2.5f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Chick", "It has a flame sac inside its belly that perpetuallyburns. It feels warm if it is hugged.",
    45, 60, 40, 70, 50, 45, 0, Color.clear,
    new int[] { 1, 1, 7, 10, 16, 19, 25, 28, 34, 37, 43},
    new string[]
    {
         "Scratch", "Growl", "Focus Energy", "Ember", "Peck", "Sand Attack", "Fire Spin", "Quick Attack", "Slash", "Mirror Move", "Flamethrower",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Overheat", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {256}, new string[] {"Level,16"}),


new PokemonData(256, "Combusken", PokemonData.Type.FIRE, PokemonData.Type.FIGHTING, "Blaze", null, "Speed-boost",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.9f, 19.5f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Young Fowl", "Its kicking mastery lets it loose 10 kicks persecond. It emits sharp cries to intimidate foes.",
    60, 85, 60, 85, 60, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 16, 21, 28, 32, 39, 50},
    new string[]
    {
         "Scratch", "Growl", "Ember", "Focus Energy", "Double Kick", "Sand Attack", "Bulk Up", "Quick Attack", "Slash", "Sky Uppercut",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up"
    },
    new int[] {257}, new string[] {"Level,36"}),


new PokemonData(257, "Blaziken", PokemonData.Type.FIRE, PokemonData.Type.FIGHTING, "Blaze", null, "Speed-boost",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.9f, 52f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Blaze", "It can clear a 30-story building in a leap. Its fiery punches scorch its foes.",
    80, 120, 70, 110, 70, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 16, 21, 28, 32, 36, 42, 59},
    new string[]
    {
         "Fire Punch", "Scratch", "Growl", "Ember", "Focus Energy", "Double Kick", "Sand Attack", "Bulk Up", "Quick Attack", "Blaze Kick", "Slash", "Sky Uppercut",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up"
    },
    new int[] {}, new string[] {}),


new PokemonData(258, "Mudkip", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Damp",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 7.6f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Mud Fish", "Its large tail fin propels it through water withpowerful acceleration. It is strong in spite ofits size.",
    50, 70, 50, 50, 50, 40, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 19, 24, 28, 33, 37, 42, 46},
    new string[]
    {
         "Tackle", "Growl", "Mud-Slap", "Water Gun", "Bide", "Foresight", "Mud Sport", "Take Down", "Whirlpool", "Protect", "Hydro Pump", "Endeavor",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {259}, new string[] {"Level,16"}),


new PokemonData(259, "Marshtomp", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Torrent", null, "Damp",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.7f, 28f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Mud Fish", "Its sturdy legs give it sure footing, even in mud. It burrows into dirt to sleep.",
    70, 85, 70, 60, 70, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 15, 16, 25, 31, 37, 42, 53},
    new string[]
    {
         "Tackle", "Growl", "Water Gun", "Mud-Slap", "Bide", "Mud Shot", "Mud Sport", "Take Down", "Muddy Water", "Protect", "Endeavor",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {260}, new string[] {"Level,36"}),


new PokemonData(260, "Swampert", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Torrent", null, "Damp",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.5f, 81.9f,
    241, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Mud Fish", "Its arms are hard as rock. With one swing, it canbreak a boulder into pieces.",
    100, 110, 90, 85, 90, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 15, 16, 25, 31, 39, 46, 61},
    new string[]
    {
         "Tackle", "Growl", "Water Gun", "Mud-Slap", "Bide", "Mud Shot", "Mud Sport", "Take Down", "Muddy Water", "Protect", "Endeavor",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(261, "Poochyena", PokemonData.Type.DARK, PokemonData.Type.NONE, "Run-away", "Quick-feet", "Rattled",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 13.6f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Bite", "A Pokémon with a persistent nature, it chases itschosen prey until the prey becomes exhausted.",
    35, 55, 35, 30, 30, 35, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Howl", "Sand Attack", "Bite", "Odor Sleuth", "Roar", "Swagger", "Scary Face", "Take Down", "Taunt", "Crunch", "Thief",
    },
    new string[]
    {
         "Roar", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power"
    },
    new int[] {262}, new string[] {"Level,18"}),


new PokemonData(262, "Mightyena", PokemonData.Type.DARK, PokemonData.Type.NONE, "Intimidate", "Quick-feet", "Moxie",
    50f, 127, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 37f,
    147, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Bite", "It will always obey the commands of a skilledTrainer. Its behavior arises from its living in packsin ancient times.",
    70, 90, 70, 60, 60, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 17, 27, 32, 37, 42, 47, 52},
    new string[]
    {
         "Sand Attack", "Bite", "Howl", "Odor Sleuth", "Swagger", "Scary Face", "Take Down", "Taunt", "Crunch", "Thief",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power"
    },
    new int[] {}, new string[] {}),


new PokemonData(263, "Zigzagoon", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Gluttony", "Quick-feet",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 17.5f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Tiny Raccoon", "It walks in zigzag fashion. It’s good at findingitems in the grass and even in the ground.",
    38, 30, 41, 30, 41, 60, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41},
    new string[]
    {
         "Tackle", "Growl", "Tail Whip", "Headbutt", "Sand Attack", "Odor Sleuth", "Mud Sport", "Pin Missile", "Covet", "Flail", "Rest", "Belly Drum",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
    },
    new int[] {264}, new string[] {"Level,20"}),


new PokemonData(264, "Linoone", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Gluttony", "Quick-feet",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 32.5f,
    147, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.WHITE, 70,
    "Rushing", "When running in a straight line, it can easily top60 miles an hour. It has a tough time withcurved roads.",
    78, 70, 61, 50, 61, 100, 0, Color.clear,
    new int[] { 1, 1, 13, 17, 23, 29, 35, 41, 47, 53},
    new string[]
    {
         "Headbutt", "Tail Whip", "Sand Attack", "Odor Sleuth", "Mud Sport", "Fury Swipes", "Covet", "Slash", "Rest", "Belly Drum",
    },
    new string[]
    {
         "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(265, "Wurmple", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shield-dust", null, "Run-away",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 3.6f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Worm", "It loves to eat leaves. If it is attacked by a Starly,it will defend itself with its spiked rear.",
    45, 45, 35, 20, 30, 20, 0, Color.clear,
    new int[] { 1, 1, 5},
    new string[]
    {
         "Tackle", "String Shot", "Poison Sting",
    },
    new string[]
    {

    },
    new int[] {266}, new string[] {"Level,7"}),


new PokemonData(266, "Silcoon", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shed-skin", null, null,
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.6f, 10f,
    72, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Cocoon", "It wraps silk around the branches of a tree. It drinksrainwater on its silk while awaiting evolution.",
    50, 35, 55, 25, 25, 15, 0, Color.clear,
    new int[] { 1},
    new string[]
    {
         "Harden",
    },
    new string[]
    {

    },
    new int[] {267}, new string[] {"Level,10"}),


new PokemonData(267, "Beautifly", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", null, "Rivalry",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1f, 28.4f,
    178, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Butterfly", "Vibrantly patterned wings are its prominent feature. It sucks sweet flower nectar with its long mouth.",
    60, 70, 50, 100, 50, 65, 0, Color.clear,
    new int[] { 1, 13, 17, 20, 27, 31, 34, 38},
    new string[]
    {
         "Absorb", "Gust", "Stun Spore", "Morning Sun", "Whirlwind", "Attract", "Silver Wind", "Giga Drain",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {268}, new string[] {"Level,7"}),


new PokemonData(268, "Cascoon", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shed-skin", null, null,
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.7f, 11.5f,
    72, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Cocoon", "Its body, which is made of soft silk, hardens overtime. When cracks appear, evolution is near.",
    50, 35, 55, 25, 25, 15, 0, Color.clear,
    new int[] { 1},
    new string[]
    {
         "Harden",
    },
    new string[]
    {

    },
    new int[] {269}, new string[] {"Level,10"}),


new PokemonData(269, "Dustox", PokemonData.Type.BUG, PokemonData.Type.POISON, "Shield-dust", null, "Compound-eyes",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.2f, 31.6f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.GREEN, 70,
    "Poison Moth", "A nocturnal Pokémon. Drawn by streetlights, theymessily eat the leaves of trees lining boulevards.",
    60, 50, 70, 50, 90, 65, 0, Color.clear,
    new int[] { 1, 13, 17, 20, 24, 27, 34, 38},
    new string[]
    {
         "Confusion", "Gust", "Protect", "Moonlight", "Psybeam", "Whirlwind", "Silver Wind", "Toxic",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Flash", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(270, "Lotad", PokemonData.Type.WATER, PokemonData.Type.GRASS, "Swift-swim", "Rain-dish", "Own-tempo",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 2.6f,
    44, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Water Weed", "It looks like an aquatic plant and serves as a ferryto Pokémon that can’t swim.",
    40, 30, 30, 40, 50, 30, 0, Color.clear,
    new int[] { 1, 3, 7, 13, 21, 31, 43},
    new string[]
    {
         "Astonish", "Growl", "Absorb", "Nature Power", "Mist", "Rain Dance", "Mega Drain",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Hail", "Facade", "Secret_Power", "Bullet_Seed", "Water_Pulse"
    },
    new int[] {271}, new string[] {"Level,14"}),


new PokemonData(271, "Lombre", PokemonData.Type.WATER, PokemonData.Type.GRASS, "Swift-swim", "Rain-dish", "Own-tempo",
    50f, 120, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 32.5f,
    119, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.GREEN, 70,
    "Jolly", "It lives at the water’s edge where it is sunny. It sleeps on a bed of water-grass by day andbecomes active at night.",
    60, 50, 50, 60, 70, 50, 0, Color.clear,
    new int[] { 1, 3, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Astonish", "Growl", "Absorb", "Nature Power", "Fake Out", "Fury Swipes", "Water Sport", "Thief", "Uproar", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Secret_Power", "Dive", "Bullet_Seed", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(272, "Ludicolo", PokemonData.Type.WATER, PokemonData.Type.GRASS, "Swift-swim", "Rain-dish", "Own-tempo",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1.5f, 55f,
    216, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.GREEN, 70,
    "Carefree", "If it hears festive music, all its muscles fill withenergy. It can’t help breaking out into a dance.",
    80, 70, 70, 90, 100, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Growl", "Absorb", "Nature Power", "Astonish",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Dive", "Bullet_Seed", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(273, "Seedot", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Early-bird", "Pickpocket",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 4f,
    44, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Acorn", "It attaches itself to a tree branch using the top ofits head. Strong winds can sometimes make it fall.",
    40, 40, 50, 30, 30, 30, 0, Color.clear,
    new int[] { 1, 3, 7, 13, 21, 31, 43},
    new string[]
    {
         "Bide", "Harden", "Growth", "Nature Power", "Synthesis", "Sunny Day", "Explosion",
    },
    new string[]
    {
         "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed"
    },
    new int[] {274}, new string[] {"Level,14"}),


new PokemonData(274, "Nuzleaf", PokemonData.Type.GRASS, PokemonData.Type.DARK, "Chlorophyll", "Early-bird", "Pickpocket",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1f, 28f,
    119, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Wily", "The sound of its grass flute makes its listenersuneasy. It lives deep in forests.",
    70, 70, 40, 60, 40, 60, 0, Color.clear,
    new int[] { 1, 3, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Pound", "Harden", "Growth", "Nature Power", "Fake Out", "Torment", "Feint Attack", "Razor Wind", "Swagger", "Extrasensory",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(275, "Shiftry", PokemonData.Type.GRASS, PokemonData.Type.DARK, "Chlorophyll", "Early-bird", "Pickpocket",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.3f, 59.6f,
    216, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Wicked", "A Pokémon that was feared as a forest guardian. It can read the foe’s mind and takepreemptive action.",
    90, 100, 60, 90, 60, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Pound", "Growth", "Harden", "Nature Power",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bullet_Seed", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(276, "Taillow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Guts", null, "Scrappy",
    50f, 200, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 2.3f,
    54, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Tiny Swallow", "It has a gutsy spirit that makes it bravely take ontough foes. It flies in search of warm climates.",
    40, 55, 30, 30, 30, 85, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 13, 19, 26, 34, 43},
    new string[]
    {
         "Growl", "Peck", "Focus Energy", "Quick Attack", "Wing Attack", "Double Team", "Endeavor", "Aerial Ace", "Agility",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {277}, new string[] {"Level,22"}),


new PokemonData(277, "Swellow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Guts", null, "Scrappy",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.7f, 19.8f,
    159, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
    "Swallow", "If its two tail feathers are standing at attention, it isproof of good health. It soars elegantly in the sky.",
    60, 85, 60, 75, 50, 125, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 38, 49},
    new string[]
    {
         "Growl", "Peck", "Quick Attack", "Focus Energy", "Wing Attack", "Aerial Ace", "Agility",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(278, "Wingull", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Keen-eye", "Hydration", "Rain-dish",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 9.5f,
    54, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.WHITE, 70,
    "Seagull", "Catching sea winds with its long wings, it soarsas if it were a glider. It folds its wings to rest.",
    40, 30, 30, 55, 30, 85, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 21, 31, 43, 55},
    new string[]
    {
         "Growl", "Water Gun", "Supersonic", "Wing Attack", "Mist", "Quick Attack", "Pursuit", "Agility",
    },
    new string[]
    {
         "Fly", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {279}, new string[] {"Level,25"}),


new PokemonData(279, "Pelipper", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Keen-eye", "Drizzle", "Rain-dish",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 28f,
    154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Water Bird", "It dips its large bill in the sea, then scoops upnumerous prey along with water.",
    60, 50, 100, 95, 70, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 21, 25, 33, 33, 47},
    new string[]
    {
         "Wing Attack", "Water Gun", "Water Sport", "Supersonic", "Mist", "Protect", "Stockpile", "Swallow", "Spit Up",
    },
    new string[]
    {
         "Fly", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(280, "Ralts", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Synchronize", "Trace", "Telepathy",
    50f, 235, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.4f, 6.6f,
    40, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Feeling", "If its horns capture the warm feelings of people orPokémon, its body warms up slightly.",
    28, 25, 25, 45, 35, 40, 0, Color.clear,
    new int[] { 1, 6, 11, 16, 21, 26, 31, 36, 41, 46},
    new string[]
    {
         "Growl", "Confusion", "Double Team", "Teleport", "Calm Mind", "Psychic", "Imprison", "Future Sight", "Hypnosis", "Dream Eater",
    },
    new string[]
    {
         "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {281}, new string[] {"Level,20"}),


new PokemonData(281, "Kirlia", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Synchronize", "Trace", "Telepathy",
    50f, 120, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.8f, 20.2f,
    97, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Emotion", "The cheerful spirit of its Trainer gives it energy forits psychokinetic power. It spins and danceswhen happy.",
    38, 35, 35, 65, 55, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 11, 21, 33, 40, 47, 54},
    new string[]
    {
         "Growl", "Confusion", "Teleport", "Double Team", "Calm Mind", "Imprison", "Future Sight", "Hypnosis", "Dream Eater",
    },
    new string[]
    {
         "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {282}, new string[] {"Level,30"}),


new PokemonData(282, "Gardevoir", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Synchronize", "Trace", "Telepathy",
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.6f, 48.4f,
    233, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Embrace", "To protect its Trainer, it will expend all its psychicpower to create a small black hole.",
    68, 65, 65, 125, 115, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 11, 21, 33, 42, 51, 60},
    new string[]
    {
         "Growl", "Confusion", "Teleport", "Double Team", "Calm Mind", "Imprison", "Future Sight", "Hypnosis", "Dream Eater",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(283, "Surskit", PokemonData.Type.BUG, PokemonData.Type.WATER, "Swift-swim", null, "Rain-dish",
    50f, 200, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 1.7f,
    54, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Pond Skater", "They usually live on ponds, but after an eveningshower, they may appear on puddles in towns.",
    40, 30, 32, 50, 52, 65, 0, Color.clear,
    new int[] { 1, 7, 13, 19, 25, 31, 37, 37},
    new string[]
    {
         "Bubble", "Quick Attack", "Sweet Scent", "Water Sport", "Bubble Beam", "Agility", "Mist", "Haze",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Water_Pulse"
    },
    new int[] {284}, new string[] {"Level,22"}),


new PokemonData(284, "Masquerain", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Intimidate", null, "Unnerve",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 3.6f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Eyeball", "Its antennae have eye patterns on them. Its fourwings enable it to hover and fly in any direction.",
    70, 60, 62, 100, 82, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 26, 33, 40, 53},
    new string[]
    {
         "Quick Attack", "Sweet Scent", "Water Sport", "Gust", "Scary Face", "Stun Spore", "Whirlwind",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(285, "Shroomish", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Effect-spore", "Poison-heal", "Quick-feet",
    50f, 255, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 4.5f,
    59, PokemonData.LevelingRate.ERRATIC, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Mushroom", "It prefers damp places. By day it remains still inthe forest shade. It releases toxic powder fromits head.",
    60, 40, 60, 40, 60, 35, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 16, 22, 28, 36, 45, 54},
    new string[]
    {
         "Absorb", "Tackle", "Stun Spore", "Leech Seed", "Mega Drain", "Headbutt", "Poison Powder", "Growth", "Giga Drain", "Spore",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Snatch", "Secret_Power", "Bullet_Seed"
    },
    new int[] {286}, new string[] {"Level,23"}),


new PokemonData(286, "Breloom", PokemonData.Type.GRASS, PokemonData.Type.FIGHTING, "Effect-spore", "Poison-heal", "Technician",
    50f, 90, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.2f, 39.2f,
    161, PokemonData.LevelingRate.ERRATIC, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Mushroom", "Its short arms stretch when it throws punches. Itstechnique is equal to that of pro boxers.",
    60, 130, 80, 60, 60, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 16, 22, 23, 36, 45, 54},
    new string[]
    {
         "Tackle", "Absorb", "Leech Seed", "Stun Spore", "Mega Drain", "Headbutt", "Mach Punch", "Sky Uppercut", "Mind Reader", "Dynamic Punch",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Snatch", "Secret_Power", "Bullet_Seed", "Bulk_Up"
    },
    new int[] {}, new string[] {}),


new PokemonData(287, "Slakoth", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Truant", null, null,
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 24f,
    56, PokemonData.LevelingRate.SLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Slacker", "The way Slakoth lolls around makes anyone whowatches it feel like doing the same.",
    60, 60, 60, 35, 35, 30, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43},
    new string[]
    {
         "Scratch", "Yawn", "Encore", "Slack Off", "Feint Attack", "Amnesia", "Covet", "Counter", "Flail",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Aerial_Ace", "Bulk_Up", "Shock_Wave", "Water_Pulse"
    },
    new int[] {288}, new string[] {"Level,18"}),


new PokemonData(288, "Vigoroth", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Vital-spirit", null, null,
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 46.5f,
    154, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.WHITE, 70,
    "Wild Monkey", "Its heartbeat is fast and its blood so agitated thatit can’t sit still for one second.",
    80, 80, 80, 55, 55, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Scratch", "Focus Energy", "Encore", "Uproar", "Fury Swipes", "Endure", "Slash", "Counter", "Focus Punch", "Reversal",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Aerial_Ace", "Bulk_Up", "Shock_Wave", "Water_Pulse"
    },
    new int[] {289}, new string[] {"Level,36"}),


new PokemonData(289, "Slaking", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Truant", null, null,
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2f, 130.5f,
    252, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Lazy", "The world’s laziest Pokémon. It moves to anotherspot when there’s no food left within its reach.",
    150, 160, 100, 95, 65, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 19, 25, 36, 37, 43},
    new string[]
    {
         "Scratch", "Encore", "Slack Off", "Feint Attack", "Amnesia", "Swagger", "Counter", "Flail",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Aerial_Ace", "Bulk_Up", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(290, "Nincada", PokemonData.Type.BUG, PokemonData.Type.GROUND, "Compound-eyes", null, "Run-away",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.5f, 5.5f,
    53, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Trainee", "Because it lived almost entirely underground, it isnearly blind. It uses its antennae instead.",
    31, 45, 90, 30, 30, 40, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 14, 19, 25, 31, 38, 45},
    new string[]
    {
         "Scratch", "Harden", "Leech Life", "Sand Attack", "Fury Swipes", "Mind Reader", "False Swipe", "Mud-Slap", "Metal Claw", "Dig",
    },
    new string[]
    {
         "Cut", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {291}, new string[] {"Level,20"}),


new PokemonData(291, "Ninjask", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Speed-boost", null, "Infiltrator",
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.8f, 12f,
    160, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Ninja", "Its cry leaves a lasting headache if heard for toolong. It moves so quickly that it is almost invisible.",
    61, 90, 45, 50, 50, 160, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 19, 20, 20, 20, 25, 31, 45},
    new string[]
    {
         "Scratch", "Sand Attack", "Harden", "Leech Life", "Mind Reader", "Screech", "Double Team", "Fury Cutter", "Swords Dance", "Slash", "Baton Pass",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(292, "Shedinja", PokemonData.Type.BUG, PokemonData.Type.GHOST, "Wonder-guard", null, null,
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.8f, 1.2f,
    83, PokemonData.LevelingRate.FLUCTUATING, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Shed", "A discarded bug shell that came to life. Peering intothe crack on its back is said to steal one’s spirit.",
    1, 90, 45, 30, 30, 40, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 14, 19, 25, 31, 38, 45},
    new string[]
    {
         "Scratch", "Harden", "Leech Life", "Sand Attack", "Fury Swipes", "Mind Reader", "Spite", "Confuse Ray", "Shadow Ball", "Grudge",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Sandstorm", "Giga_Drain", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(293, "Whismur", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Soundproof", null, "Rattled",
    50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 16.3f,
    48, PokemonData.LevelingRate.MEDIUMSLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Whisper", "It usually murmurs but starts cryingloudly if it senses danger. It stopswhen its ear covers are shut.",
    64, 51, 23, 51, 23, 28, 0, Color.clear,
    new int[] { 1, 5, 11, 15, 21, 25, 31, 35, 41, 41, 45},
    new string[]
    {
         "Pound", "Uproar", "Astonish", "Howl", "Supersonic", "Stomp", "Screech", "Roar", "Rest", "Sleep Talk", "Hyper Voice",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
    },
    new int[] {294}, new string[] {"Level,20"}),


new PokemonData(294, "Loudred", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Soundproof", null, "Scrappy",
    50f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 40.5f,
    126, PokemonData.LevelingRate.MEDIUMSLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Big Voice", "It shouts loudly by inhaling air, and then uses itswell-developed stomach muscles to exhale.",
    84, 71, 43, 71, 43, 48, 0, Color.clear,
    new int[] { 1, 1, 1, 15, 23, 29, 37, 43, 51, 51},
    new string[]
    {
         "Pound", "Uproar", "Astonish", "Howl", "Supersonic", "Stomp", "Screech", "Roar", "Rest", "Sleep Talk",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Secret_Power", "Overheat", "Shock_Wave", "Water_Pulse"
    },
    new int[] {295}, new string[] {"Level,40"}),


new PokemonData(295, "Exploud", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Soundproof", null, "Scrappy",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.5f, 84f,
    221, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Loud Noise", "Its howls can be heard over six miles away. It emitsall sorts of noises from the ports on its body.",
    104, 91, 63, 91, 73, 68, 0, Color.clear,
    new int[] { 1, 1, 1, 15, 23, 29, 37, 40, 45, 55, 55},
    new string[]
    {
         "Pound", "Uproar", "Astonish", "Howl", "Supersonic", "Stomp", "Screech", "Hyper Beam", "Roar", "Rest", "Sleep Talk",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Secret_Power", "Overheat", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(296, "Makuhita", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Thick-fat", "Guts", "Sheer-force",
    75f, 180, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1f, 86.4f,
    47, PokemonData.LevelingRate.ERRATIC, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Guts", "It toughens up by slamming into thick trees overand over. It gains a sturdy body anddauntless spirit.",
    72, 60, 30, 20, 30, 25, 0, Color.clear,
    new int[] { 1, 1, 4, 10, 13, 19, 22, 28, 31, 37, 40, 46, 49},
    new string[]
    {
         "Tackle", "Focus Energy", "Sand Attack", "Arm Thrust", "Vital Throw", "Fake Out", "Whirlwind", "Knock Off", "Smelling Salts", "Belly Drum", "Endure", "Seismic Toss", "Reversal",
    },
    new string[]
    {
         "Surf", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up"
    },
    new int[] {297}, new string[] {"Level,24"}),


new PokemonData(297, "Hariyama", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Thick-fat", "Guts", "Sheer-force",
    75f, 200, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 2.3f, 253.8f,
    166, PokemonData.LevelingRate.ERRATIC, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Arm Thrust", "It stomps on the ground to build power. It can senda 10-ton truck flying with a straight-arm punch.",
    144, 120, 60, 40, 60, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 19, 22, 29, 33, 40, 44, 51, 55},
    new string[]
    {
         "Sand Attack", "Focus Energy", "Arm Thrust", "Vital Throw", "Fake Out", "Whirlwind", "Knock Off", "Smelling Salts", "Belly Drum", "Endure", "Seismic Toss", "Reversal",
    },
    new string[]
    {
         "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up"
    },
    new int[] {}, new string[] {}),


new PokemonData(298, "Azurill", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Thick-fat", "Huge-power", "Sap-sipper",
    25f, 150, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.2f, 2f,
    38, PokemonData.LevelingRate.FAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Polka Dot", "A Pokémon that lives by water. It moves quickly onland by bouncing on its big tail.",
    50, 20, 40, 20, 40, 20, 0, Color.clear,
    new int[] { 1, 3, 6, 10, 15, 21},
    new string[]
    {
         "Splash", "Charm", "Tail Whip", "Bubble", "Slam", "Water Gun",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(299, "Nosepass", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Sturdy", "Magnet-pull", "Sand-force",
    50f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 97f,
    75, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Compass", "Its magnetic nose always faces north and drawsiron objects to its body to protect itself better.",
    30, 45, 135, 45, 90, 30, 0, Color.clear,
    new int[] { 1, 7, 13, 16, 22, 28, 31, 37, 43, 46},
    new string[]
    {
         "Tackle", "Harden", "Rock Throw", "Block", "Thunder Wave", "Rock Slide", "Sandstorm", "Rest", "Zap Cannon", "Lock-On",
    },
    new string[]
    {
         "Strength", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Secret_Power", "Rock_Tomb", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(300, "Skitty", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Cute-charm", "Normalize", "Wonder-skin",
    25f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 11f,
    52, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PINK, 70,
    "Kitten", "It can’t stop itself from chasing moving things,and it runs in a circle, chasing its own tail.",
    50, 45, 45, 35, 35, 50, 0, Color.clear,
    new int[] { 1, 1, 3, 7, 13, 15, 19, 25, 27, 31, 37, 39},
    new string[]
    {
         "Tackle", "Growl", "Tail Whip", "Attract", "Sing", "Double Slap", "Assist", "Charm", "Feint Attack", "Covet", "Heal Bell", "Double-Edge",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(301, "Delcatty", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Cute-charm", "Normalize", "Wonder-skin",
    25f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 32.6f,
    140, PokemonData.LevelingRate.FAST, 1, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Prim", "It dislikes dirty places. It often searches for acomfortable place in which to groom itself.",
    70, 65, 65, 55, 55, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Double Slap", "Growl", "Sing", "Attract",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Secret_Power", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(302, "Sableye", PokemonData.Type.DARK, PokemonData.Type.GHOST, "Keen-eye", "Stall", "Prankster",
    50f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.5f, 11f,
    133, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 35,
    "Darkness", "It hides in the darkness of caves. Its diet of gemshas transformed its eyes into gemstones.",
    50, 75, 75, 65, 65, 50, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Scratch", "Leer", "Foresight", "Night Shade", "Astonish", "Fury Swipes", "Fake Out", "Detect", "Feint Attack", "Knock Off", "Confuse Ray", "Shadow Ball", "Mean Look",
    },
    new string[]
    {
         "Cut", "Dig", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Snatch", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(303, "Mawile", PokemonData.Type.STEEL, PokemonData.Type.FAIRY, "Hyper-cutter", "Intimidate", "Sheer-force",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 11.5f,
    133, PokemonData.LevelingRate.FAST, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Deceiver", "It uses its docile-looking face to lull foes intocomplacency, then bites with its huge,relentless jaws.",
    50, 85, 85, 55, 55, 50, 0, Color.clear,
    new int[] { 1, 6, 11, 16, 21, 26, 31, 36, 41, 46, 46, 46},
    new string[]
    {
         "Astonish", "Fake Tears", "Bite", "Sweet Scent", "Vice Grip", "Feint Attack", "Baton Pass", "Crunch", "Iron Defense", "Stockpile", "Spit Up", "Swallow",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sludge_Bomb", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(304, "Aron", PokemonData.Type.STEEL, PokemonData.Type.ROCK, "Sturdy", "Rock-head", "Heavy-metal",
    50f, 180, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 60f,
    66, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 35,
    "Iron Armor", "It usually lives deep in mountains. However, hungermay drive it to eat railroad tracks and cars.",
    50, 70, 100, 40, 40, 30, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 17, 21, 25, 29, 34, 39, 44},
    new string[]
    {
         "Tackle", "Harden", "Mud-Slap", "Headbutt", "Metal Claw", "Iron Defense", "Roar", "Take Down", "Iron Tail", "Protect", "Metal Sound", "Double-Edge",
    },
    new string[]
    {
         "Cut", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {305}, new string[] {"Level,32"}),


new PokemonData(305, "Lairon", PokemonData.Type.STEEL, PokemonData.Type.ROCK, "Sturdy", "Rock-head", "Heavy-metal",
    50f, 90, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 120f,
    151, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 35,
    "Iron Armor", "It loves iron ore. Groups of them fight for territoryby bashing one another with their steel bodies.",
    60, 90, 140, 50, 50, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 17, 21, 25, 45, 53},
    new string[]
    {
         "Headbutt", "Harden", "Mud-Slap", "Metal Claw", "Iron Defense", "Roar", "Take Down", "Metal Sound", "Double-Edge",
    },
    new string[]
    {
         "Cut", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {306}, new string[] {"Level,42"}),


new PokemonData(306, "Aggron", PokemonData.Type.STEEL, PokemonData.Type.ROCK, "Sturdy", "Rock-head", "Heavy-metal",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.1f, 360f,
    239, PokemonData.LevelingRate.SLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.GRAY, 35,
    "Iron Armor", "It claims an entire mountain as its own. The more wounds it has, the more it has battled,so don’t take it lightly.",
    70, 110, 180, 60, 60, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 17, 21, 25, 50, 63},
    new string[]
    {
         "Headbutt", "Harden", "Mud-Slap", "Metal Claw", "Iron Defense", "Roar", "Take Down", "Metal Sound", "Double-Edge",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(307, "Meditite", PokemonData.Type.FIGHTING, PokemonData.Type.PSYCHIC, "Pure-power", null, "Telepathy",
    50f, 180, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 0.6f, 11.2f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Meditate", "It always trains deep in mountains. It levitateswhen it heightens its spiritual powerthrough meditation.",
    30, 40, 55, 40, 55, 60, 0, Color.clear,
    new int[] { 1, 4, 9, 12, 18, 22, 28, 32, 38, 42, 48},
    new string[]
    {
         "Bide", "Meditate", "Confusion", "Detect", "Hidden Power", "Mind Reader", "Calm Mind", "High Jump Kick", "Psych Up", "Reversal", "Recover",
    },
    new string[]
    {
         "Strength", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up", "Calm_Mind"
    },
    new int[] {308}, new string[] {"Level,37"}),


new PokemonData(308, "Medicham", PokemonData.Type.FIGHTING, PokemonData.Type.PSYCHIC, "Pure-power", null, "Telepathy",
    50f, 90, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.3f, 31.5f,
    144, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.RED, 70,
    "Meditate", "It elegantly avoids attacks with dance-like steps,then launches a devastating blow in thesame motion.",
    60, 60, 75, 60, 75, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 4, 22, 28, 32, 40, 46, 54},
    new string[]
    {
         "Fire Punch", "Ice Punch", "Thunder Punch", "Confusion", "Bide", "Detect", "Meditate", "Mind Reader", "Calm Mind", "High Jump Kick", "Psych Up", "Reversal", "Recover",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Bulk_Up", "Calm_Mind"
    },
    new int[] {}, new string[] {}),


new PokemonData(309, "Electrike", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", "Lightning-rod", "Minus",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 15.2f,
    59, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Lightning", "Using electricity stored in its fur, it stimulates itsmuscles to heighten its reaction speed.",
    40, 45, 40, 65, 40, 65, 0, Color.clear,
    new int[] { 1, 4, 9, 12, 17, 20, 25, 28, 33, 36, 41},
    new string[]
    {
         "Tackle", "Thunder Wave", "Leer", "Howl", "Quick Attack", "Spark", "Odor Sleuth", "Roar", "Bite", "Thunder", "Charge",
    },
    new string[]
    {
         "Roar", "Strength", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Facade", "Secret_Power", "Shock_Wave"
    },
    new int[] {310}, new string[] {"Level,26"}),


new PokemonData(310, "Manectric", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", "Lightning-rod", "Minus",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.5f, 40.2f,
    166, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Discharge", "It rarely appears before people. It is said to nestwhere lightning has fallen.",
    70, 75, 60, 105, 60, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 20, 25, 31, 53},
    new string[]
    {
         "Tackle", "Leer", "Thunder Wave", "Howl", "Quick Attack", "Spark", "Odor Sleuth", "Roar", "Charge",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Facade", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(311, "Plusle", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Plus", null, "Lightning-rod",
    50f, 200, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 4.2f,
    142, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Cheering", "It cheers on friends with pom-poms made of sparks. It drains power from telephone poles.",
    60, 50, 40, 85, 75, 95, 0, Color.clear,
    new int[] { 1, 4, 10, 13, 19, 22, 28, 31, 37, 40, 47},
    new string[]
    {
         "Growl", "Thunder Wave", "Quick Attack", "Helping Hand", "Spark", "Encore", "Fake Tears", "Charge", "Thunder", "Baton Pass", "Agility",
    },
    new string[]
    {
         "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Facade", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(312, "Minun", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Minus", null, "Volt-absorb",
    50f, 200, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 4.2f,
    142, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Cheering", "Exposure to electricity from Minun and Pluslepromotes blood circulation and relaxes muscles.",
    60, 40, 50, 75, 85, 95, 0, Color.clear,
    new int[] { 1, 4, 10, 13, 19, 22, 28, 31, 37, 40, 47},
    new string[]
    {
         "Growl", "Thunder Wave", "Quick Attack", "Helping Hand", "Spark", "Encore", "Charm", "Charge", "Thunder", "Baton Pass", "Agility",
    },
    new string[]
    {
         "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Facade", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(313, "Volbeat", PokemonData.Type.BUG, PokemonData.Type.NONE, "Illuminate", "Swarm", "Prankster",
    100f, 150, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.7f, 17.7f,
    151, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GRAY, 70,
    "Firefly", "It communicates with others by lighting up its rearat night. It loves Illumise’s sweet aroma.",
    65, 73, 75, 47, 85, 85, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37},
    new string[]
    {
         "Tackle", "Confuse Ray", "Double Team", "Moonlight", "Quick Attack", "Tail Glow", "Signal Beam", "Protect", "Helping Hand", "Double-Edge",
    },
    new string[]
    {
         "Solar_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(314, "Illumise", PokemonData.Type.BUG, PokemonData.Type.NONE, "Oblivious", "Tinted-lens", "Prankster",
    0f, 150, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.6f, 17.7f,
    151, PokemonData.LevelingRate.ERRATIC, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Firefly", "Its fragrance attracts a swarm of Volbeat, so theydraw over 200 patterns in the night sky.",
    65, 47, 75, 73, 85, 85, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37},
    new string[]
    {
         "Tackle", "Sweet Scent", "Charm", "Moonlight", "Quick Attack", "Wish", "Encore", "Flatter", "Helping Hand", "Covet",
    },
    new string[]
    {
         "Solar_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(315, "Roselia", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Natural-cure", "Poison-point", "Leaf-guard",
    50f, 150, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 257, 0.3f, 2f,
    140, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Thorn", "It uses the different poisons in each handseparately when it attacks. The stronger its aroma,the healthier it is.",
    50, 60, 45, 100, 80, 65, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57},
    new string[]
    {
         "Absorb", "Growth", "Poison Sting", "Stun Spore", "Mega Drain", "Leech Seed", "Magical Leaf", "Grass Whistle", "Giga Drain", "Sweet Scent", "Ingrain", "Toxic", "Petal Dance", "Aromatherapy", "Synthesis",
    },
    new string[]
    {
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(316, "Gulpin", PokemonData.Type.POISON, PokemonData.Type.NONE, "Liquid-ooze", "Sticky-hold", "Gluttony",
    50f, 225, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 257, 0.4f, 10.3f,
    60, PokemonData.LevelingRate.ERRATIC, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Stomach", "It has a small heart and brain. Its stomachcomprises most of its body, with enzymes todissolve anything.",
    70, 43, 53, 43, 53, 40, 0, Color.clear,
    new int[] { 1, 6, 9, 14, 17, 23, 28, 34, 34, 34, 39},
    new string[]
    {
         "Pound", "Yawn", "Poison Gas", "Sludge", "Amnesia", "Encore", "Toxic", "Stockpile", "Spit Up", "Swallow", "Sludge Bomb",
    },
    new string[]
    {
         "Ice_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Snatch", "Secret_Power", "Bullet_Seed", "Shock_Wave", "Water_Pulse"
    },
    new int[] {317}, new string[] {"Level,26"}),


new PokemonData(317, "Swalot", PokemonData.Type.POISON, PokemonData.Type.NONE, "Liquid-ooze", "Sticky-hold", "Gluttony",
    50f, 75, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 257, 1.7f, 80f,
    163, PokemonData.LevelingRate.ERRATIC, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Bag", "It swallows anything whole. It sweats toxic fluidsfrom its follicles to douse foes.",
    100, 73, 83, 73, 83, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 23, 26, 31, 40, 40, 40},
    new string[]
    {
         "Pound", "Sludge", "Poison Gas", "Yawn", "Encore", "Body Slam", "Toxic", "Stockpile", "Spit Up", "Swallow",
    },
    new string[]
    {
         "Ice_Beam", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Rest", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Snatch", "Secret_Power", "Bullet_Seed", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(318, "Carvanha", PokemonData.Type.WATER, PokemonData.Type.DARK, "Rough-skin", null, "Speed-boost",
    50f, 225, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.8f, 20.8f,
    61, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 35,
    "Savage", "They form packs to attack boats and rip out theirhulls to sink them. They live in rivers in the jungle.",
    45, 90, 20, 65, 20, 65, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 16, 22, 28, 31, 37, 43},
    new string[]
    {
         "Leer", "Bite", "Rage", "Focus Energy", "Scary Face", "Crunch", "Screech", "Take Down", "Swagger", "Agility",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Torment", "Facade", "Taunt", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {319}, new string[] {"Level,30"}),


new PokemonData(319, "Sharpedo", PokemonData.Type.WATER, PokemonData.Type.DARK, "Rough-skin", null, "Speed-boost",
    50f, 60, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 1.8f, 88.8f,
    161, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Brutal", "Its fangs rip through sheet iron. It swims at 75 mphand is known as “The Bully of the Sea. ",
    70, 120, 40, 95, 40, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 16, 22, 33, 38, 43, 53},
    new string[]
    {
         "Leer", "Bite", "Rage", "Focus Energy", "Scary Face", "Crunch", "Slash", "Taunt", "Swagger", "Agility",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(320, "Wailmer", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-veil", "Oblivious", "Pressure",
    50f, 125, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2f, 130f,
    80, PokemonData.LevelingRate.ERRATIC, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Ball Whale", "It bounces playfully like a ball. The more seawaterit swallows, the higher it bounces.",
    130, 70, 35, 70, 35, 60, 0, Color.clear,
    new int[] { 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 46, 50},
    new string[]
    {
         "Splash", "Growl", "Water Gun", "Rollout", "Whirlpool", "Astonish", "Water Pulse", "Mist", "Rest", "Water Spout", "Amnesia", "Hydro Pump",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {321}, new string[] {"Level,40"}),


new PokemonData(321, "Wailord", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-veil", "Oblivious", "Pressure",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 14.5f, 398f,
    175, PokemonData.LevelingRate.ERRATIC, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Float Whale", "It can sometimes knock out opponents with theshock created by breaching and crashing its bigbody onto the water.",
    170, 90, 45, 90, 45, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 23, 28, 37, 44, 52},
    new string[]
    {
         "Growl", "Water Gun", "Splash", "Rollout", "Astonish", "Water Pulse", "Rest", "Water Spout", "Amnesia",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(322, "Numel", PokemonData.Type.FIRE, PokemonData.Type.GROUND, "Oblivious", "Simple", "Own-tempo",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.7f, 24f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Numb", "Its humped back stores intensely hot magma. In rain, the magma cools, slowing its movement.",
    60, 60, 40, 65, 45, 35, 0, Color.clear,
    new int[] { 1, 1, 11, 19, 25, 29, 31, 35, 41, 49},
    new string[]
    {
         "Tackle", "Growl", "Ember", "Magnitude", "Focus Energy", "Take Down", "Amnesia", "Earthquake", "Flamethrower", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Overheat", "Rock_Tomb"
    },
    new int[] {323}, new string[] {"Level,33"}),


new PokemonData(323, "Camerupt", PokemonData.Type.FIRE, PokemonData.Type.GROUND, "Magma-armor", "Solid-rock", "Anger-point",
    50f, 150, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.9f, 220f,
    161, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Eruption", "The volcanoes on its back have a major eruptionevery 10 years--or whenever it becomesreally angry.",
    70, 100, 70, 105, 75, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 25, 29, 31, 33, 55},
    new string[]
    {
         "Tackle", "Growl", "Ember", "Magnitude", "Focus Energy", "Take Down", "Amnesia", "Rock Slide", "Fissure",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Overheat", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(324, "Torkoal", PokemonData.Type.FIRE, PokemonData.Type.NONE, "White-smoke", "Drought", "Shell-armor",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 80.4f,
    165, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Coal", "You find abandoned coal mines full of them. They dig tirelessly in search of coal.",
    70, 85, 140, 85, 70, 20, 0, Color.clear,
    new int[] { 1, 4, 7, 14, 17, 20, 27, 30, 33, 40, 43, 46},
    new string[]
    {
         "Ember", "Smog", "Curse", "Smokescreen", "Fire Spin", "Body Slam", "Protect", "Flamethrower", "Iron Defense", "Amnesia", "Flail", "Heat Wave",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Overheat"
    },
    new int[] {}, new string[] {}),


new PokemonData(325, "Spoink", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Thick-fat", "Own-tempo", "Gluttony",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 30.6f,
    66, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLACK, 70,
    "Bounce", "It bounces constantly, using its tail like a spring. The shock of bouncing keeps its heart beating.",
    60, 25, 35, 70, 80, 60, 0, Color.clear,
    new int[] { 1, 7, 10, 16, 19, 25, 28, 34, 37, 37, 43},
    new string[]
    {
         "Splash", "Psywave", "Odor Sleuth", "Psybeam", "Psych Up", "Confuse Ray", "Magic Coat", "Psychic", "Rest", "Snore", "Bounce",
    },
    new string[]
    {
         "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {326}, new string[] {"Level,32"}),


new PokemonData(326, "Grumpig", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Thick-fat", "Own-tempo", "Gluttony",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 71.5f,
    165, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Manipulate", "It uses black pearls to amplify its psychic power. It does a strange dance to control foes’ minds.",
    80, 45, 65, 90, 110, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 19, 25, 28, 43, 43},
    new string[]
    {
         "Psybeam", "Psywave", "Odor Sleuth", "Psych Up", "Confuse Ray", "Magic Coat", "Rest", "Snore",
    },
    new string[]
    {
         "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Focus_Punch", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(327, "Spinda", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Own-tempo", "Tangled-feet", "Contrary",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 5f,
    126, PokemonData.LevelingRate.FAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Spot Panda", "No two Spinda have the same pattern of spots. Its tottering step fouls the aim of foes.",
    60, 60, 60, 60, 60, 60, 0, Color.clear,
    new int[] { 1, 5, 12, 16, 23, 27, 34, 38, 45, 49, 56},
    new string[]
    {
         "Tackle", "Uproar", "Feint Attack", "Psybeam", "Hypnosis", "Dizzy Punch", "Teeter Dance", "Psych Up", "Double-Edge", "Flail", "Thrash",
    },
    new string[]
    {
         "Strength", "Dig", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power", "Rock_Tomb", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(328, "Trapinch", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Hyper-cutter", "Arena-trap", "Sheer-force",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.7f, 15f,
    58, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Ant Pit", "It lives in arid deserts. It makes a sloping pit trap insand where it patiently awaits prey.",
    45, 100, 45, 45, 45, 10, 0, Color.clear,
    new int[] { 1, 9, 17, 25, 33, 41, 49, 57},
    new string[]
    {
         "Bite", "Sand Attack", "Feint Attack", "Sand Tomb", "Crunch", "Dig", "Sandstorm", "Hyper Beam",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb"
    },
    new int[] {329}, new string[] {"Level,35"}),


new PokemonData(329, "Vibrava", PokemonData.Type.GROUND, PokemonData.Type.DRAGON, "Levitate", null, null,
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.1f, 15.3f,
    119, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Vibration", "The ultrasonic waves it generates by rubbing its twowings together cause severe headaches.",
    50, 70, 50, 50, 50, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 33, 35, 41, 57},
    new string[]
    {
         "Sand Attack", "Feint Attack", "Sand Tomb", "Crunch", "Dragon Breath", "Screech", "Hyper Beam",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb"
    },
    new int[] {330}, new string[] {"Level,45"}),


new PokemonData(330, "Flygon", PokemonData.Type.GROUND, PokemonData.Type.DRAGON, "Levitate", null, null,
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 2f, 82f,
    234, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
    "Mystic", "It hides itself by kicking up desert sand with itswings. Red covers shield its eyes from sand.",
    80, 100, 80, 80, 80, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 33, 35, 41, 65},
    new string[]
    {
         "Sand Attack", "Feint Attack", "Sand Tomb", "Crunch", "Dragon Breath", "Screech", "Hyper Beam",
    },
    new string[]
    {
         "Fly", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Dragon_Claw"
    },
    new int[] {}, new string[] {}),


new PokemonData(331, "Cacnea", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Sand-veil", null, "Water-absorb",
    50f, 190, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 51.3f,
    67, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 35,
    "Cactus", "It lives in arid locations. Its yellow flowers bloomonce a year.",
    50, 85, 40, 85, 40, 35, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Poison Sting", "Leer", "Absorb", "Growth", "Leech Seed", "Sand Attack", "Pin Missile", "Ingrain", "Feint Attack", "Spikes", "Needle Arm", "Cotton Spore", "Sandstorm",
    },
    new string[]
    {
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Focus_Punch", "Secret_Power", "Bullet_Seed"
    },
    new int[] {332}, new string[] {"Level,32"}),


new PokemonData(332, "Cacturne", PokemonData.Type.GRASS, PokemonData.Type.DARK, "Sand-veil", null, "Water-absorb",
    50f, 60, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 1.3f, 77.4f,
    166, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 35,
    "Scarecrow", "It becomes active at night, seeking prey that isexhausted from the day’s desert heat.",
    70, 115, 60, 115, 60, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 21, 25, 29, 35, 41, 53},
    new string[]
    {
         "Poison Sting", "Leer", "Absorb", "Growth", "Sand Attack", "Pin Missile", "Ingrain", "Feint Attack", "Spikes", "Needle Arm", "Sandstorm",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Focus_Punch", "Secret_Power", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(333, "Swablu", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Natural-cure", null, "Cloud-nine",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.4f, 1.2f,
    62, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Cotton Bird", "For some reason, it likes to land on people’s headssoftly and act like it’s a hat.",
    45, 40, 60, 40, 75, 50, 0, Color.clear,
    new int[] { 1, 1, 8, 11, 18, 21, 28, 31, 38, 41, 48},
    new string[]
    {
         "Growl", "Peck", "Astonish", "Sing", "Fury Attack", "Safeguard", "Mist", "Take Down", "Mirror Move", "Refresh", "Perish Song",
    },
    new string[]
    {
         "Fly", "Ice_Beam", "Solar_Beam", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Secret_Power", "Aerial_Ace"
    },
    new int[] {334}, new string[] {"Level,35"}),


new PokemonData(334, "Altaria", PokemonData.Type.DRAGON, PokemonData.Type.FLYING, "Natural-cure", null, "Cloud-nine",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.1f, 20.6f,
    172, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLUE, 70,
    "Humming", "It flies gracefully through the sky. Its melodichumming makes you feel like you’re in a dream.",
    75, 70, 90, 70, 105, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 18, 21, 31, 35, 45, 54, 59},
    new string[]
    {
         "Growl", "Sing", "Peck", "Astonish", "Fury Attack", "Safeguard", "Take Down", "Dragon Breath", "Refresh", "Perish Song", "Sky Attack",
    },
    new string[]
    {
         "Fly", "Roar", "Flamethrower", "Ice_Beam", "Hyper_Beam", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Aerial_Ace", "Dragon_Claw"
    },
    new int[] {}, new string[] {}),


new PokemonData(335, "Zangoose", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Immunity", null, "Toxic-boost",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.3f, 40.3f,
    160, PokemonData.LevelingRate.FLUCTUATING, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Cat Ferret", "It has feuded with Seviper for many generations. Its sharp claws are its biggest weapons.",
    73, 115, 60, 60, 60, 90, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 19, 25, 31, 37, 46, 55},
    new string[]
    {
         "Scratch", "Leer", "Quick Attack", "Swords Dance", "Fury Cutter", "Slash", "Pursuit", "Crush Claw", "Taunt", "Detect", "False Swipe",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Thief", "Protect", "Giga_Drain", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Taunt", "Brick_Break", "Secret_Power", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(336, "Seviper", PokemonData.Type.POISON, PokemonData.Type.NONE, "Shed-skin", null, "Infiltrator",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2.7f, 52.5f,
    160, PokemonData.LevelingRate.ERRATIC, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Fang Snake", "In battle, it uses its bladed tail to counter anyZangoose. It secretes a deadly venom in its tail.",
    73, 100, 60, 100, 60, 65, 0, Color.clear,
    new int[] { 1, 7, 10, 16, 19, 25, 28, 34, 37, 43},
    new string[]
    {
         "Wrap", "Lick", "Bite", "Poison Tail", "Screech", "Glare", "Crunch", "Poison Fang", "Swagger", "Haze",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Thief", "Protect", "Sludge_Bomb", "Giga_Drain", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Snatch", "Secret_Power"
    },
    new int[] {}, new string[] {}),


new PokemonData(337, "Lunatone", PokemonData.Type.ROCK, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 168f,
    161, PokemonData.LevelingRate.FAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Meteorite", "Because it turns active on nights of the full moon,it is said to have some link to the lunar phases.",
    90, 55, 65, 95, 85, 70, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Tackle", "Harden", "Confusion", "Rock Throw", "Hypnosis", "Psywave", "Cosmic Power", "Psychic", "Future Sight", "Explosion",
    },
    new string[]
    {
         "Ice_Beam", "Hyper_Beam", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Rock_Tomb", "Calm_Mind"
    },
    new int[] {}, new string[] {}),


new PokemonData(338, "Solrock", PokemonData.Type.ROCK, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.2f, 154f,
    161, PokemonData.LevelingRate.FAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Meteorite", "Solar energy is the source of its power,so it is strong during the daytime. When it spins, its body shines.",
    90, 95, 85, 55, 65, 70, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Tackle", "Harden", "Confusion", "Rock Throw", "Fire Spin", "Psywave", "Cosmic Power", "Rock Slide", "Solar Beam", "Explosion",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Solar_Beam", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Flash", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Overheat", "Rock_Tomb", "Calm_Mind"
    },
    new int[] {}, new string[] {}),


new PokemonData(339, "Barboach", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Oblivious", "Anticipation", "Hydration",
    50f, 190, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.4f, 1.9f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Whiskers", "It coats its entire body with a slimy fluid so it cansquirm and slip away if grabbed.",
    50, 48, 43, 46, 41, 60, 0, Color.clear,
    new int[] { 1, 6, 6, 11, 16, 21, 26, 26, 31, 36, 41},
    new string[]
    {
         "Mud-Slap", "Mud Sport", "Water Sport", "Water Gun", "Magnitude", "Amnesia", "Rest", "Snore", "Earthquake", "Future Sight", "Fissure",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {340}, new string[] {"Level,30"}),


new PokemonData(340, "Whiscash", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Oblivious", "Anticipation", "Hydration",
    50f, 75, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.9f, 23.6f,
    164, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Whiskers", "It claims a large swamp to itself. If a foe comesnear it, it sets off tremors by thrashing around.",
    110, 78, 73, 76, 71, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 11, 16, 21, 26, 26, 36, 46, 56},
    new string[]
    {
         "Mud-Slap", "Mud Sport", "Water Sport", "Water Gun", "Magnitude", "Amnesia", "Rest", "Snore", "Earthquake", "Future Sight", "Fissure",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(341, "Corphish", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Adaptability",
    50f, 205, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 11.5f,
    62, PokemonData.LevelingRate.ERRATIC, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Ruffian", "No matter how dirty the water in the river, it willadapt and thrive. It has a strong will to survive.",
    43, 80, 65, 50, 35, 35, 0, Color.clear,
    new int[] { 1, 7, 10, 13, 20, 23, 26, 32, 35, 38, 44},
    new string[]
    {
         "Bubble", "Harden", "Vice Grip", "Leer", "Bubble Beam", "Protect", "Knock Off", "Taunt", "Crabhammer", "Swords Dance", "Guillotine",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Taunt", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Water_Pulse"
    },
    new int[] {342}, new string[] {"Level,30"}),


new PokemonData(342, "Crawdaunt", PokemonData.Type.WATER, PokemonData.Type.DARK, "Hyper-cutter", "Shell-armor", "Adaptability",
    50f, 155, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.1f, 32.8f,
    164, PokemonData.LevelingRate.ERRATIC, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Rogue", "It is a ruffian that uses its pincers to pick up andtoss out other Pokémon from its pond.",
    63, 120, 85, 90, 55, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 23, 26, 34, 39, 44},
    new string[]
    {
         "Vice Grip", "Leer", "Harden", "Protect", "Knock Off", "Taunt", "Crabhammer", "Swords Dance",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Sludge_Bomb", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Taunt", "Brick_Break", "Secret_Power", "Dive", "Rock_Tomb", "Aerial_Ace", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(343, "Baltoy", PokemonData.Type.GROUND, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    112.5f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.5f, 21.5f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BROWN, 70,
    "Clay Doll", "It moves while spinning around on its single foot. Some Baltoy have been seen spinning ontheir heads.",
    40, 40, 55, 40, 70, 55, 0, Color.clear,
    new int[] { 1, 3, 5, 7, 11, 15, 19, 25, 31, 37, 45},
    new string[]
    {
         "Confusion", "Harden", "Rapid Spin", "Mud-Slap", "Psybeam", "Rock Tomb", "Self-Destruct", "Ancient Power", "Sandstorm", "Cosmic Power", "Explosion",
    },
    new string[]
    {
         "Ice_Beam", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Rock_Tomb"
    },
    new int[] {344}, new string[] {"Level,36"}),


new PokemonData(344, "Claydol", PokemonData.Type.GROUND, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    112.5f, 90, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.5f, 108f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLACK, 70,
    "Clay Doll", "An ancient clay figurine that came to life as aPokémon from exposure to a mysterious rayof light.",
    60, 70, 105, 70, 120, 75, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 7, 11, 15, 31, 36, 42, 55},
    new string[]
    {
         "Confusion", "Teleport", "Harden", "Rapid Spin", "Mud-Slap", "Psybeam", "Rock Tomb", "Sandstorm", "Hyper Beam", "Cosmic Power", "Explosion",
    },
    new string[]
    {
         "Ice_Beam", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Skill_Swap", "Secret_Power", "Rock_Tomb"
    },
    new int[] {}, new string[] {}),


new PokemonData(345, "Lileep", PokemonData.Type.ROCK, PokemonData.Type.GRASS, "Suction-cups", null, "Storm-drain",
    87.5f, 45, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1f, 23.8f,
    71, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sea Lily", "It disguises its tentacles as flowers to attract andcatch prey. It became extinct in ancient times.",
    66, 41, 77, 61, 87, 23, 0, Color.clear,
    new int[] { 1, 8, 15, 22, 29, 36, 43, 50, 50, 50},
    new string[]
    {
         "Astonish", "Constrict", "Acid", "Ingrain", "Confuse Ray", "Amnesia", "Ancient Power", "Stockpile", "Spit Up", "Swallow",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Double_Team", "Rest", "Protect", "Sludge_Bomb", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Secret_Power", "Bullet_Seed"
    },
    new int[] {346}, new string[] {"Level,40"}),


new PokemonData(346, "Cradily", PokemonData.Type.ROCK, PokemonData.Type.GRASS, "Suction-cups", null, "Storm-drain",
    87.5f, 45, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.5f, 60.4f,
    173, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.GREEN, 70,
    "Barnacle", "It lives in the shallows of warm seas. When the tidegoes out, it digs up prey from beaches.",
    86, 81, 97, 81, 107, 43, 0, Color.clear,
    new int[] { 1, 1, 1, 48, 60, 60, 60},
    new string[]
    {
         "Acid", "Constrict", "Ingrain", "Ancient Power", "Stockpile", "Spit Up", "Swallow",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Rest", "Protect", "Sludge_Bomb", "Sandstorm", "Giga_Drain", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Rock_Tomb", "Bullet_Seed"
    },
    new int[] {}, new string[] {}),


new PokemonData(347, "Anorith", PokemonData.Type.ROCK, PokemonData.Type.BUG, "Battle-armor", null, "Swift-swim",
    87.5f, 45, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.7f, 12.5f,
    71, PokemonData.LevelingRate.FLUCTUATING, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Old Shrimp", "It is a kind of Pokémon progenitor. It uses itsextending claws to catch prey hiding among rockson the seafloor.",
    45, 95, 50, 40, 50, 75, 0, Color.clear,
    new int[] { 1, 7, 13, 19, 25, 31, 37, 43, 49, 55},
    new string[]
    {
         "Scratch", "Harden", "Mud Sport", "Water Gun", "Metal Claw", "Protect", "Ancient Power", "Fury Cutter", "Slash", "Rock Blast",
    },
    new string[]
    {
         "Cut", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Water_Pulse"
    },
    new int[] {348}, new string[] {"Level,40"}),


new PokemonData(348, "Armaldo", PokemonData.Type.ROCK, PokemonData.Type.BUG, "Battle-armor", null, "Swift-swim",
    87.5f, 45, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.5f, 68.2f,
    173, PokemonData.LevelingRate.FLUCTUATING, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Plate", "Its enormous, retractable claws can cut throughmost anything. Its entire body is clad insturdy plates.",
    75, 125, 100, 70, 80, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 25, 31, 37, 46, 55},
    new string[]
    {
         "Scratch", "Water Gun", "Mud Sport", "Harden", "Metal Claw", "Protect", "Ancient Power", "Fury Cutter", "Slash",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(349, "Feebas", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Oblivious", "Adaptability",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 7.4f,
    40, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Fish", "It eats anything, so it can even live in pollutedstreams and lakes. No one pays any attention to it.",
    20, 15, 20, 10, 55, 80, 0, Color.clear,
    new int[] { 1, 15, 30},
    new string[]
    {
         "Splash", "Tackle", "Flail",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(350, "Milotic", PokemonData.Type.WATER, PokemonData.Type.NONE, "Marvel-scale", "Competitive", "Cute-charm",
    50f, 60, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 6.2f, 162f,
    189, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PINK, 70,
    "Tender", "Milotic is breathtakingly beautiful. Those that see itare said to forget their combative spirits.",
    95, 60, 79, 100, 125, 81, 0, Color.clear,
    new int[] { 1, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50},
    new string[]
    {
         "Water Gun", "Wrap", "Water Sport", "Refresh", "Water Pulse", "Twister", "Recover", "Rain Dance", "Hydro Pump", "Attract", "Safeguard",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(351, "Castform", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Forecast", null, null,
    50f, 45, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.3f, 0.8f,
    147, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Weather", "This Pokémon can change its cells, taking differentforms based on the temperature and humidity.",
    70, 70, 70, 70, 70, 70, 0, Color.clear,
    new int[] { 1, 10, 10, 10, 20, 20, 20, 30},
    new string[]
    {
         "Tackle", "Ember", "Water Gun", "Powder Snow", "Rain Dance", "Sunny Day", "Hail", "Weather Ball",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Solar_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Hail", "Facade", "Secret_Power", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(352, "Kecleon", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Color-change", null, "Protean",
    50f, 200, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 22f,
    154, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Color Swap", "It can freely change its body’s color. The zigzagpattern on its belly doesn’t change, however.",
    60, 90, 70, 60, 120, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 4, 7, 12, 17, 24, 31, 40, 49},
    new string[]
    {
         "Scratch", "Tail Whip", "Lick", "Thief", "Astonish", "Bind", "Feint Attack", "Fury Swipes", "Psybeam", "Screech", "Slash", "Substitute", "Ancient Power",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Skill_Swap", "Snatch", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(353, "Shuppet", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Insomnia", "Frisk", "Cursed-body",
    50f, 225, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 2.3f,
    59, PokemonData.LevelingRate.FAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Puppet", "It uses its horn to feed on envy and malice--or so it’s said. It’s very active at night.",
    44, 75, 35, 63, 33, 45, 0, Color.clear,
    new int[] { 1, 8, 13, 20, 25, 32, 37, 44, 49, 56},
    new string[]
    {
         "Knock Off", "Screech", "Night Shade", "Curse", "Spite", "Will-O-Wisp", "Feint Attack", "Shadow Ball", "Snatch", "Grudge",
    },
    new string[]
    {
         "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {354}, new string[] {"Level,37"}),


new PokemonData(354, "Banette", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Insomnia", "Frisk", "Cursed-body",
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.1f, 12.5f,
    159, PokemonData.LevelingRate.FAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Marionette", "A doll that became a Pokémon over its grudge frombeing junked. It seeks the child that disowned it.",
    64, 115, 65, 83, 63, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 32, 39, 48, 55, 64},
    new string[]
    {
         "Night Shade", "Curse", "Knock Off", "Screech", "Will-O-Wisp", "Feint Attack", "Shadow Ball", "Snatch", "Grudge",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(355, "Duskull", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Levitate", null, "Frisk",
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.8f, 15f,
    59, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLACK, 35,
    "Requiem", "It doggedly pursues its prey wherever it goes. However, the chase is abandoned at sunrise.",
    20, 40, 90, 30, 90, 25, 0, Color.clear,
    new int[] { 1, 1, 5, 12, 16, 23, 27, 34, 38, 45, 49},
    new string[]
    {
         "Leer", "Night Shade", "Disable", "Foresight", "Astonish", "Confuse Ray", "Pursuit", "Curse", "Will-O-Wisp", "Mean Look", "Future Sight",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind"
    },
    new int[] {356}, new string[] {"Level,37"}),


new PokemonData(356, "Dusclops", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Pressure", null, "Frisk",
    50f, 90, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.6f, 30.6f,
    159, PokemonData.LevelingRate.FAST, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.BLACK, 35,
    "Beckon", "Anyone who dares peer into its body to see itsspectral ball of fire will have their spirit stolen away.",
    40, 70, 130, 60, 130, 25, 0, Color.clear,
    new int[] { 1, 1, 1, 12, 16, 23, 27, 34, 37, 41, 51, 58},
    new string[]
    {
         "Bind", "Leer", "Disable", "Foresight", "Astonish", "Confuse Ray", "Pursuit", "Curse", "Shadow Punch", "Will-O-Wisp", "Mean Look", "Future Sight",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Thief", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Focus_Punch", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Rock_Tomb", "Calm_Mind"
    },
    new int[] {}, new string[] {}),


new PokemonData(357, "Tropius", PokemonData.Type.GRASS, PokemonData.Type.FLYING, "Chlorophyll", "Solar-power", "Harvest",
    50f, 200, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2f, 100f,
    161, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Fruit", "It flies by flapping its broad leaves and givesthe sweet, delicious fruit around its neckto children.",
    99, 68, 83, 72, 87, 51, 0, Color.clear,
    new int[] { 1, 1, 7, 11, 17, 21, 27, 31, 37, 41, 47},
    new string[]
    {
         "Gust", "Leer", "Growth", "Razor Leaf", "Stomp", "Sweet Scent", "Whirlwind", "Magical Leaf", "Body Slam", "Solar Beam", "Synthesis",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Flash", "Rest", "Protect", "Giga_Drain", "Steel_Wing", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Secret_Power", "Bullet_Seed", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(358, "Chimecho", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 1f,
    159, PokemonData.LevelingRate.FAST, 0, 0, 0, 1, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Wind Chime", "It uses the sucker on its head to hang from a treeor from eaves. It can produce seven different tones.",
    75, 50, 80, 95, 90, 65, 0, Color.clear,
    new int[] { 1, 6, 9, 14, 17, 22, 25, 30, 33, 38, 41, 46},
    new string[]
    {
         "Wrap", "Growl", "Astonish", "Confusion", "Take Down", "Uproar", "Yawn", "Psywave", "Double-Edge", "Heal Bell", "Safeguard", "Psychic",
    },
    new string[]
    {
         "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Skill_Swap", "Snatch", "Secret_Power", "Calm_Mind", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(359, "Absol", PokemonData.Type.DARK, PokemonData.Type.NONE, "Pressure", "Super-luck", "Justified",
    50f, 30, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 47f,
    163, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Disaster", "It senses coming disasters and appears beforepeople only to warn them of impending danger.",
    65, 130, 60, 75, 60, 75, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 26, 31, 36, 41, 46},
    new string[]
    {
         "Scratch", "Leer", "Taunt", "Quick Attack", "Razor Wind", "Bite", "Swords Dance", "Double Team", "Slash", "Future Sight", "Perish Song",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Thief", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Snatch", "Secret_Power", "Aerial_Ace", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(360, "Wynaut", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Shadow-tag", null, "Telepathy",
    50f, 125, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.6f, 14f,
    52, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Bright", "It tends to move in a pack with others. They clusterin a tight group to sleep in a cave.",
    95, 23, 48, 23, 48, 23, 0, Color.clear,
    new int[] { 1, 1, 1, 15, 15, 15, 15},
    new string[]
    {
         "Splash", "Charm", "Encore", "Counter", "Destiny Bond", "Safeguard", "Mirror Coat",
    },
    new string[]
    {

    },
    new int[] {}, new string[] {}),


new PokemonData(361, "Snorunt", PokemonData.Type.ICE, PokemonData.Type.NONE, "Inner-focus", "Ice-body", "Moody",
    50f, 190, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.7f, 16.8f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Snow Hat", "It is said that several Snorunt gather under giantleaves and live together in harmony.",
    50, 50, 50, 50, 50, 50, 0, Color.clear,
    new int[] { 1, 1, 7, 10, 16, 19, 25, 28, 34, 37, 43},
    new string[]
    {
         "Leer", "Powder Snow", "Double Team", "Bite", "Icy Wind", "Headbutt", "Protect", "Crunch", "Ice Beam", "Hail", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Facade", "Secret_Power", "Water_Pulse"
    },
    new int[] {362}, new string[] {"Level,42"}),


new PokemonData(362, "Glalie", PokemonData.Type.ICE, PokemonData.Type.NONE, "Inner-focus", "Ice-body", "Moody",
    50f, 75, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.5f, 256.5f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Face", "To protect itself, it clad its body in an armor of ice,made by freezing moisture in the air.",
    80, 80, 80, 80, 80, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 16, 19, 25, 28, 42, 53, 61},
    new string[]
    {
         "Leer", "Bite", "Double Team", "Icy Wind", "Headbutt", "Protect", "Crunch", "Hail", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Torment", "Facade", "Taunt", "Secret_Power", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(363, "Spheal", PokemonData.Type.ICE, PokemonData.Type.WATER, "Thick-fat", "Ice-body", "Oblivious",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 39.5f,
    58, PokemonData.LevelingRate.MEDIUMSLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Clap", "They can’t swim well yet, and they move muchfaster by rolling. When they’re happy, theyclap fins.",
    70, 40, 50, 55, 50, 25, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 13, 19, 25, 31, 37, 37, 43, 49},
    new string[]
    {
         "Growl", "Water Gun", "Powder Snow", "Encore", "Ice Ball", "Body Slam", "Aurora Beam", "Hail", "Rest", "Snore", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {364}, new string[] {"Level,32"}),


new PokemonData(364, "Sealeo", PokemonData.Type.ICE, PokemonData.Type.WATER, "Thick-fat", "Ice-body", "Oblivious",
    50f, 120, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.1f, 87.6f,
    144, PokemonData.LevelingRate.MEDIUMSLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Ball Roll", "It has a very sensitive nose. It touches new thingswith its nose to examine them.",
    90, 60, 70, 75, 70, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 19, 25, 39, 39, 47, 55},
    new string[]
    {
         "Growl", "Water Gun", "Powder Snow", "Encore", "Ice Ball", "Body Slam", "Aurora Beam", "Rest", "Snore", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {365}, new string[] {"Level,44"}),


new PokemonData(365, "Walrein", PokemonData.Type.ICE, PokemonData.Type.WATER, "Thick-fat", "Ice-body", "Oblivious",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.4f, 150.6f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Ice Break", "It shatters ice with its big tusks. Its thick blubberrepels not only the cold, but also enemy attacks.",
    110, 80, 90, 95, 90, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 19, 25, 39, 39, 50, 61},
    new string[]
    {
         "Growl", "Water Gun", "Powder Snow", "Encore", "Ice Ball", "Body Slam", "Aurora Beam", "Rest", "Snore", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(366, "Clamperl", PokemonData.Type.WATER, PokemonData.Type.NONE, "Shell-armor", null, "Rattled",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 52.5f,
    69, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Bivalve", "When it evolves, it makes a mysterious pearl thatamplifies psychic powers when it’s held.",
    35, 64, 85, 74, 55, 32, 0, Color.clear,
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Water Gun", "Clamp", "Whirlpool", "Iron Defense",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(367, "Huntail", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Water-veil",
    50f, 60, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 27f,
    170, PokemonData.LevelingRate.FLUCTUATING, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Deep Sea", "It lives deep in the sea where no light ever filtersdown. It lights up its small fishlike tail toattract prey.",
    55, 104, 105, 94, 75, 52, 0, Color.clear,
    new int[] { 1, 8, 15, 22, 29, 36, 43, 50},
    new string[]
    {
         "Whirlpool", "Bite", "Screech", "Water Pulse", "Scary Face", "Crunch", "Baton Pass", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Snatch", "Secret_Power", "Dive", "Rock_Tomb", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(368, "Gorebyss", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Hydration",
    50f, 60, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.8f, 22.6f,
    170, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "South Sea", "It lives at the bottom of the sea. In the springtime,its pink body turns more vivid for some reason.",
    55, 84, 105, 114, 75, 52, 0, Color.clear,
    new int[] { 1, 8, 15, 22, 29, 36, 43, 50},
    new string[]
    {
         "Whirlpool", "Confusion", "Agility", "Water Pulse", "Amnesia", "Psychic", "Baton Pass", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(369, "Relicanth", PokemonData.Type.WATER, PokemonData.Type.ROCK, "Swift-swim", "Rock-head", "Sturdy",
    87.5f, 25, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1f, 23.4f,
    170, PokemonData.LevelingRate.SLOW, 1, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Longevity", "It has remained unchanged for 100 million years. It was discovered during a deep-sea exploration.",
    100, 90, 130, 45, 65, 55, 0, Color.clear,
    new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50, 57, 64},
    new string[]
    {
         "Tackle", "Harden", "Water Gun", "Rock Tomb", "Yawn", "Take Down", "Mud Sport", "Ancient Power", "Rest", "Double-Edge", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Sandstorm", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Secret_Power", "Dive", "Rock_Tomb", "Calm_Mind", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(370, "Luvdisc", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Hydration",
    25f, 225, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.6f, 8.7f,
    116, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PINK, 70,
    "Rendezvous", "It lives in warm seas. It is said that a couple findingthis Pokémon will be blessed with eternal love.",
    43, 30, 55, 40, 65, 97, 0, Color.clear,
    new int[] { 1, 4, 12, 16, 24, 28, 36, 40, 48},
    new string[]
    {
         "Tackle", "Charm", "Water Gun", "Agility", "Take Down", "Attract", "Sweet Kiss", "Flail", "Safeguard",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Secret_Power", "Dive", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(371, "Bagon", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Rock-head", null, "Sheer-force",
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 0.6f, 42.1f,
    60, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Rock Head", "Its well-developed neck muscles and iron-likehead can smash boulders into pieces.",
    45, 75, 60, 40, 30, 50, 0, Color.clear,
    new int[] { 1, 5, 9, 17, 21, 25, 33, 37, 41, 49, 53},
    new string[]
    {
         "Rage", "Bite", "Leer", "Headbutt", "Focus Energy", "Ember", "Dragon Breath", "Scary Face", "Crunch", "Dragon Claw", "Double-Edge",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Strength", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw"
    },
    new int[] {372}, new string[] {"Level,30"}),


new PokemonData(372, "Shelgon", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Rock-head", null, "Overcoat",
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 1.1f, 110.5f,
    147, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Endurance", "Within its rugged shell, its cells have begunchanging. The shell peels off the instant it evolves.",
    65, 95, 100, 60, 50, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 21, 25, 30, 38, 47, 56, 69},
    new string[]
    {
         "Headbutt", "Leer", "Rage", "Bite", "Focus Energy", "Ember", "Protect", "Dragon Breath", "Scary Face", "Crunch", "Dragon Claw",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Strength", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Attract", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw"
    },
    new int[] {373}, new string[] {"Level,50"}),


new PokemonData(373, "Salamence", PokemonData.Type.DRAGON, PokemonData.Type.FLYING, "Intimidate", null, "Moxie",
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 1.5f, 102.6f,
    270, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Dragon", "It becomes uncontrollable if it is enraged. Itdestroys everything with shredding claws and fire.",
    95, 135, 80, 110, 80, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 21, 25, 30, 38, 47, 50, 61, 79},
    new string[]
    {
         "Headbutt", "Leer", "Rage", "Bite", "Focus Energy", "Ember", "Protect", "Dragon Breath", "Scary Face", "Fly", "Crunch", "Dragon Claw",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Steel_Wing", "Attract", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw"
    },
    new int[] {}, new string[] {}),


new PokemonData(374, "Beldum", PokemonData.Type.STEEL, PokemonData.Type.PSYCHIC, "Clear-body", null, "Light-metal",
    112.5f, 3, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.6f, 95.2f,
    60, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Iron Ball", "The magnetic force generated by its body repelsthe ground’s natural magnetism, letting it float.",
    40, 55, 80, 35, 60, 30, 0, Color.clear,
    new int[] { 1},
    new string[]
    {
         "Take Down",
    },
    new string[]
    {

    },
    new int[] {375}, new string[] {"Level,20"}),


new PokemonData(375, "Metang", PokemonData.Type.STEEL, PokemonData.Type.PSYCHIC, "Clear-body", null, "Light-metal",
    112.5f, 3, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.2f, 202.5f,
    147, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Iron Claw", "It is formed by two Beldum joining together. Its steel body won’t be scratched if it collideswith a jet.",
    60, 75, 100, 55, 80, 50, 0, Color.clear,
    new int[] { 1, 20, 20, 26, 32, 38, 44, 50, 56, 62},
    new string[]
    {
         "Take Down", "Confusion", "Metal Claw", "Scary Face", "Pursuit", "Psychic", "Iron Defense", "Meteor Mash", "Agility", "Hyper Beam",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Sludge_Bomb", "Sandstorm", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {376}, new string[] {"Level,45"}),


new PokemonData(376, "Metagross", PokemonData.Type.STEEL, PokemonData.Type.PSYCHIC, "Clear-body", null, "Light-metal",
    112.5f, 3, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.6f, 550f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Iron Leg", "With four linked brains, it’s more intelligent than asupercomputer, and it uses calculations toanalyze foes.",
    80, 135, 130, 95, 90, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 44, 66, 77},
    new string[]
    {
         "Take Down", "Confusion", "Scary Face", "Metal Claw", "Iron Defense", "Agility", "Hyper Beam",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Sludge_Bomb", "Sandstorm", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace"
    },
    new int[] {}, new string[] {}),


new PokemonData(377, "Regirock", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Clear-body", null, "Sturdy",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.7f, 230f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BROWN, 35,
    "Rock Peak", "Its entire body is made of rock. If any part chips offin battle, it attaches rocks to repair itself.",
    80, 100, 200, 50, 100, 50, 0, Color.clear,
    new int[] { 1, 9, 17, 25, 33, 41, 49, 57, 65},
    new string[]
    {
         "Explosion", "Rock Throw", "Curse", "Superpower", "Ancient Power", "Iron Defense", "Zap Cannon", "Lock-On", "Hyper Beam",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(378, "Regice", PokemonData.Type.ICE, PokemonData.Type.NONE, "Clear-body", null, "Ice-body",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.8f, 175f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.BLUE, 35,
    "Iceberg", "It is said to have slept in a glacier for thousands ofyears. Its body can’t be melted, even by magma.",
    80, 50, 100, 100, 200, 50, 0, Color.clear,
    new int[] { 1, 9, 17, 25, 33, 41, 49, 57, 65},
    new string[]
    {
         "Explosion", "Icy Wind", "Curse", "Superpower", "Ancient Power", "Amnesia", "Zap Cannon", "Lock-On", "Hyper Beam",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Rest", "Protect", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(379, "Registeel", PokemonData.Type.STEEL, PokemonData.Type.NONE, "Clear-body", null, "Light-metal",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.9f, 205f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 1, 0, PokemonData.PokedexColor.GRAY, 35,
    "Iron", "Tempered by pressure underground over tens ofthousands of years, its body cannot be scratched.",
    80, 75, 150, 75, 150, 50, 0, Color.clear,
    new int[] { 1, 9, 17, 25, 33, 41, 41, 49, 57, 65},
    new string[]
    {
         "Explosion", "Metal Claw", "Curse", "Superpower", "Ancient Power", "Amnesia", "Iron Defense", "Zap Cannon", "Lock-On", "Hyper Beam",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Focus_Punch", "Brick_Break", "Secret_Power", "Rock_Tomb", "Aerial_Ace", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(380, "Latias", PokemonData.Type.DRAGON, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    0f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.4f, 40f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.RED, 90,
    "Eon", "It communicates using telepathy. Its body iscovered in down that refracts light to makeit invisible.",
    80, 80, 90, 110, 130, 110, 0, Color.clear,
    new int[] { 1, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50},
    new string[]
    {
         "Psywave", "Wish", "Helping Hand", "Safeguard", "Dragon Breath", "Water Sport", "Refresh", "Mist Ball", "Psychic", "Recover", "Charm",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Surf", "Ice_Beam", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Flash", "Rest", "Protect", "Sandstorm", "Steel_Wing", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Dive", "Aerial_Ace", "Dragon_Claw", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(381, "Latios", PokemonData.Type.DRAGON, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    100f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 60f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BLUE, 90,
    "Eon", "A highly intelligent Pokémon. By folding back itswings in flight, it can overtake jet planes.",
    80, 90, 80, 130, 110, 110, 0, Color.clear,
    new int[] { 1, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50},
    new string[]
    {
         "Psywave", "Memento", "Helping Hand", "Safeguard", "Dragon Breath", "Protect", "Refresh", "Luster Purge", "Psychic", "Recover", "Dragon Dance",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Surf", "Ice_Beam", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Flash", "Rest", "Protect", "Sandstorm", "Steel_Wing", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Secret_Power", "Dive", "Aerial_Ace", "Dragon_Claw", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(382, "Kyogre", PokemonData.Type.WATER, PokemonData.Type.NONE, "Drizzle", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 4.5f, 352f,
    302, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BLUE, 0,
    "Sea Basin", "A mythical Pokémon said to have swelled the seaswith rain and tidal waves. It battled with Groudon.",
    100, 100, 90, 150, 140, 90, 0, Color.clear,
    new int[] { 1, 5, 15, 20, 30, 35, 45, 50, 60, 65, 75},
    new string[]
    {
         "Water Pulse", "Scary Face", "Ancient Power", "Body Slam", "Calm Mind", "Ice Beam", "Hydro Pump", "Rest", "Sheer Cold", "Double-Edge", "Water Spout",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Protect", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Secret_Power", "Dive", "Rock_Tomb", "Calm_Mind", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(383, "Groudon", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Drought", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 3.5f, 950f,
    302, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 0,
    "Continent", "Said to have expanded the lands by evaporatingwater with raging heat. It battled titanicallywith Kyogre.",
    100, 150, 140, 100, 90, 90, 0, Color.clear,
    new int[] { 1, 5, 15, 20, 30, 35, 45, 50, 60, 65, 75},
    new string[]
    {
         "Mud Shot", "Scary Face", "Ancient Power", "Slash", "Bulk Up", "Earthquake", "Fire Blast", "Rest", "Fissure", "Solar Beam", "Eruption",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Safeguard", "Iron_Tail", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Overheat", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Shock_Wave"
    },
    new int[] {}, new string[] {}),


new PokemonData(384, "Rayquaza", PokemonData.Type.DRAGON, PokemonData.Type.FLYING, "Air-lock", null, null,
    112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 7f, 206.5f,
    306, PokemonData.LevelingRate.SLOW, 0, 2, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 0,
    "Sky High", "It lives in the ozone layer far above the clouds andcannot be seen from the ground.",
    105, 150, 90, 150, 90, 95, 0, Color.clear,
    new int[] { 1, 5, 15, 20, 30, 35, 45, 50, 60, 65, 75},
    new string[]
    {
         "Twister", "Scary Face", "Ancient Power", "Dragon Claw", "Dragon Dance", "Crunch", "Fly", "Rest", "Extreme Speed", "Outrage", "Hyper Beam",
    },
    new string[]
    {
         "Fly", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Iron_Tail", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Secret_Power", "Dive", "Overheat", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Shock_Wave", "Water_Pulse"
    },
    new int[] {}, new string[] {}),


new PokemonData(385, "Jirachi", PokemonData.Type.STEEL, PokemonData.Type.PSYCHIC, "Serene-grace", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 1.1f,
    270, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 100,
    "Wish", "Generations have believed that any wish written ona note on its head will come true when it awakens.",
    100, 100, 100, 100, 100, 100, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 15, 20, 25, 35, 45, 50},
    new string[]
    {
         "Confusion", "Wish", "Rest", "Swift", "Helping Hand", "Psychic", "Refresh", "Double-Edge", "Cosmic Power", "Doom Desire",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Protect", "Sandstorm", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Skill_Swap", "Secret_Power", "Aerial_Ace", "Calm_Mind", "Shock_Wave", "Water_Pulse"
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
