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
        //  PokemonData(ID, NAME, PokemonData.Type.TYPE1, PokemonData.Type.TYPE1, Ability1, Ability2, HiddenAbility,
        //				MaleRatio, CatchRate, PokemonData.EggGroup.EGGGROUP1, PokemonData.EggGroup.EGGGROUP2, HatchTime, Height, Weight,
        //				EXPYield, PokemonData.LevelingRate.LEVELINGRATE, evYieldHP,ATK,DEF,SPA,SPD,SPE, PokemonData.PokedexColor.COLOR, BaseFriendship,
        //				Species, PokedexEntry (choose your favourite)
        //				baseStatsHP,ATK,DEF,SPA,SPD,SPE, Luminance (0 if unknown), LightColor (Color.clear if unknown)
        //				new int[]{ level, level, level, etc...}
        //				new string[]{ "move", "move", "move", etc...} ),
        //				new int[]{pokemonID}, new string[]{"Method,Parameter"}),
        new PokemonData(1, "Bulbasaur", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Overgrow", null, "Chlorophyll",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.7f, 6.9f,
    64, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Seed", "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon.",
    45, 49, 49, 65, 65, 45, 0, Color.clear,
    new int[] { 1, 3, 7, 9, 13, 13, 15, 19, 21, 25, 27, 31, 33, 37},
    new string[]
    {
         "Tackle", "Growl", "Leech Seed", "Vine Whip", "Poison Powder", "Sleep Powder", "Take Down", "Razor Leaf", "Sweet Scent", "Growth", "Double-Edge", "Worry Seed", "Synthesis", "Seed Bomb",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {2}, new string[] {"Level,16"}),


new PokemonData(2, "Ivysaur", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Overgrow", null, "Chlorophyll",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 13f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Seed", "There is a plant bulb on its back. When it absorbs nutrients, the bulb is said toblossom into a large flower.",
    60, 62, 63, 80, 80, 60, 0, Color.clear,
    new int[] { 1, 1, 7, 9, 13, 13, 15, 20, 23, 28, 31, 36, 39, 44},
    new string[]
    {
         "Tackle", "Growl", "Leech Seed", "Vine Whip", "Poison Powder", "Sleep Powder", "Take Down", "Razor Leaf", "Sweet Scent", "Growth", "Double-Edge", "Worry Seed", "Synthesis", "Solar Beam",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {3}, new string[] {"Level,32"}),


new PokemonData(3, "Venusaur", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Overgrow", null, "Chlorophyll",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 2f, 100f,
    236, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Seed", "By spreading the broad petals of its flowerand catching the sun’s rays, it fills its bodywith power.",
    80, 82, 83, 100, 100, 80, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 13, 15, 20, 23, 28, 31, 32, 39, 45, 50, 53},
    new string[]
    {
         "Vine Whip", "Growl", "Leech Seed", "Poison Powder", "Sleep Powder", "Take Down", "Razor Leaf", "Sweet Scent", "Growth", "Double-Edge", "Petal Dance", "Worry Seed", "Synthesis", "Petal Blizzard", "Solar Beam",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Venoshock", "Round", "Echoed_Voice", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(4, "Charmander", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Solar-power",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 8.5f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
    "Lizard", "The flame on its tail indicates Charmander’s lifeforce. If it is healthy, the flame burns brightly.",
    39, 52, 43, 60, 50, 65, 0, Color.clear,
    new int[] { 1, 1, 7, 10, 16, 19, 25, 28, 34, 37, 43, 46},
    new string[]
    {
         "Scratch", "Growl", "Ember", "Smokescreen", "Dragon Rage", "Scary Face", "Fire Fang", "Flame Burst", "Slash", "Flamethrower", "Fire Spin", "Inferno",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Fling", "Shadow_Claw", "Hone_Claws", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {5}, new string[] {"Level,16"}),


new PokemonData(5, "Charmeleon", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Solar-power",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.1f, 19f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.RED, 70,
    "Flame", "It lashes about with its tail to knock down its foe. It then tears up the fallen opponent withsharp claws.",
    58, 64, 58, 80, 65, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 17, 21, 28, 32, 39, 50, 54},
    new string[]
    {
         "Scratch", "Growl", "Ember", "Smokescreen", "Dragon Rage", "Scary Face", "Fire Fang", "Flame Burst", "Slash", "Fire Spin", "Inferno",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Fling", "Shadow_Claw", "Hone_Claws", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {6}, new string[] {"Level,36"}),


new PokemonData(6, "Charizard", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Blaze", null, "Solar-power",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.7f, 90.5f,
    240, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Flame", "When expelling a blast of superhot fire,the red flame at the tip of its tail burnsmore intensely.",
    78, 84, 78, 109, 85, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 17, 21, 28, 32, 36, 56, 62},
    new string[]
    {
         "Scratch", "Growl", "Ember", "Smokescreen", "Heat Wave", "Flare Blitz", "Shadow Claw", "Dragon Rage", "Scary Face", "Fire Fang", "Flame Burst", "Wing Attack", "Fire Spin", "Inferno",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Roost", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Flame_Charge", "Round", "Echoed_Voice", "Sky_Drop", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(7, "Squirtle", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Rain-dish",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 9f,
    63, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Tiny Turtle", "It shelters itself in its shell, then strikes backwith spouts of water at every opportunity.",
    44, 48, 65, 50, 64, 43, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40},
    new string[]
    {
         "Tackle", "Tail Whip", "Water Gun", "Withdraw", "Bubble", "Bite", "Rapid Spin", "Protect", "Water Pulse", "Aqua Tail", "Skull Bash", "Iron Defense", "Rain Dance", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Round", "Scald", "Confide", "Power_Up_Punch"
    },
    new int[] {8}, new string[] {"Level,16"}),


new PokemonData(8, "Wartortle", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Rain-dish",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 22.5f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Turtle", "When tapped, this Pokémon will pull in its head,but its tail will still stick out a little bit.",
    59, 63, 80, 65, 80, 58, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 13, 20, 24, 28, 32, 36, 40, 44},
    new string[]
    {
         "Tackle", "Tail Whip", "Water Gun", "Withdraw", "Bubble", "Rapid Spin", "Protect", "Water Pulse", "Aqua Tail", "Skull Bash", "Iron Defense", "Rain Dance",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Round", "Scald", "Confide", "Power_Up_Punch"
    },
    new int[] {9}, new string[] {"Level,36"}),


new PokemonData(9, "Blastoise", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Rain-dish",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.6f, 85.5f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.BLUE, 70,
    "Shellfish", "It crushes its foe under its heavy body to causefainting. In a pinch, it will withdraw inside its shell.",
    79, 83, 100, 85, 105, 78, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 13, 20, 24, 28, 32, 46, 53},
    new string[]
    {
         "Tackle", "Tail Whip", "Water Gun", "Withdraw", "Flash Cannon", "Bubble", "Rapid Spin", "Protect", "Water Pulse", "Aqua Tail", "Iron Defense", "Rain Dance",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Smack_Down", "Round", "Scald", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(10, "Caterpie", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shield-dust", null, "Run-away",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 2.9f,
    39, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Worm", "For protection, it releases a horrible stench fromthe antennae on its head to drive away enemies.",
    45, 30, 35, 20, 20, 45, 0, Color.clear,
    new int[] { 1, 1, 15},
    new string[]
    {
         "Tackle", "String Shot", "Bug Bite",
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
    new int[] { 1, 12, 12, 12, 16, 18, 22, 24, 28, 30, 34, 40, 42, 46},
    new string[]
    {
         "Confusion", "Poison Powder", "Stun Spore", "Sleep Powder", "Gust", "Supersonic", "Whirlwind", "Psybeam", "Silver Wind", "Tailwind", "Rage Powder", "Captivate", "Bug Buzz", "Quiver Dance",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "U_turn", "Energy_Ball", "Giga_Impact", "Venoshock", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(13, "Weedle", PokemonData.Type.BUG, PokemonData.Type.POISON, "Shield-dust", null, "Run-away",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 3.2f,
    39, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Hairy Bug", "Often found in forests and grasslands. It has a sharp, toxic barb of around two incheson top of its head.",
    40, 35, 30, 20, 20, 50, 0, Color.clear,
    new int[] { 1, 1, 15},
    new string[]
    {
         "Poison Sting", "String Shot", "Bug Bite",
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
    new int[] { 1, 13, 19, 22, 25, 28, 31, 34, 37, 40, 45},
    new string[]
    {
         "Fury Attack", "Focus Energy", "Rage", "Pursuit", "Toxic Spikes", "Pin Missile", "Agility", "Assurance", "Poison Jab", "Endeavor", "Fell Stinger",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Roost", "U_turn", "Payback", "Poison_Jab", "X_Scissor", "Giga_Impact", "Venoshock", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(16, "Pidgey", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 1.8f,
    50, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Tiny Bird", "A common sight in forests and woods. It flapsits wings at ground level to kick up blinding sand.",
    40, 45, 40, 35, 35, 56, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53},
    new string[]
    {
         "Tackle", "Sand Attack", "Gust", "Quick Attack", "Whirlwind", "Twister", "Feather Dance", "Agility", "Wing Attack", "Roost", "Tailwind", "Mirror Move", "Air Slash", "Hurricane",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Round", "Confide"
    },
    new int[] {17}, new string[] {"Level,18"}),


new PokemonData(17, "Pidgeotto", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
    50f, 120, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.1f, 30f,
    122, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Bird", "The claws on its feet are well developed. It can carry prey such as an Exeggcuteto its nest over 60 miles away.",
    63, 60, 55, 50, 50, 71, 0, Color.clear,
    new int[] { 1, 1, 13, 17, 22, 27, 32, 42, 47, 52, 57, 62},
    new string[]
    {
         "Gust", "Sand Attack", "Quick Attack", "Whirlwind", "Twister", "Feather Dance", "Agility", "Roost", "Tailwind", "Mirror Move", "Air Slash", "Hurricane",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Round", "Confide"
    },
    new int[] {18}, new string[] {"Level,36"}),


new PokemonData(18, "Pidgeot", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.5f, 39.5f,
    216, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.BROWN, 70,
    "Bird", "When hunting, it skims the surface of waterat high speed to pick off unwary prey suchas Magikarp.",
    83, 80, 75, 70, 70, 101, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 22, 27, 32, 44, 50, 62},
    new string[]
    {
         "Gust", "Sand Attack", "Quick Attack", "Hurricane", "Whirlwind", "Twister", "Feather Dance", "Agility", "Roost", "Tailwind", "Air Slash",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Giga_Impact", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(19, "Rattata", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Guts", "Hustle",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.3f, 3.5f,
    51, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Mouse", "Living wherever there is food available,it ceaselessly scavenges for ediblesthe entire day.",
    30, 56, 35, 25, 35, 72, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34},
    new string[]
    {
         "Tackle", "Tail Whip", "Quick Attack", "Focus Energy", "Bite", "Pursuit", "Hyper Fang", "Sucker Punch", "Crunch", "Assurance", "Super Fang", "Double-Edge", "Endeavor",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "U_turn", "Grass_Knot", "Charge_Beam", "Round", "Retaliate", "Wild_Charge", "Confide"
    },
    new int[] {20}, new string[] {"Level,20"}),


new PokemonData(20, "Raticate", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Guts", "Hustle",
    50f, 127, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.7f, 18.5f,
    145, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Mouse", "It whittles its constantly growing fangs by gnawingon hard things. It can chew apart cinder walls.",
    55, 81, 60, 50, 70, 97, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 7, 10, 13, 16, 19, 20, 24, 29, 34, 39, 44},
    new string[]
    {
         "Swords Dance", "Tackle", "Tail Whip", "Quick Attack", "Focus Energy", "Bite", "Pursuit", "Hyper Fang", "Sucker Punch", "Scary Face", "Crunch", "Assurance", "Super Fang", "Double-Edge", "Endeavor",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "U_turn", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Round", "Retaliate", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(21, "Spearow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", null, "Sniper",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 2f,
    52, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Tiny Bird", "Very protective of its territory, it flaps its shortwings busily to dart around at high speed.",
    40, 60, 30, 31, 31, 70, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37},
    new string[]
    {
         "Growl", "Peck", "Leer", "Fury Attack", "Pursuit", "Aerial Ace", "Mirror Move", "Agility", "Assurance", "Roost", "Drill Peck",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {22}, new string[] {"Level,20"}),


new PokemonData(22, "Fearow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", null, "Sniper",
    50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.2f, 38f,
    155, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Beak", "With its huge and magnificent wings, it can keepaloft without ever having to land for rest.",
    65, 90, 65, 61, 61, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 13, 17, 23, 29, 35, 41, 47},
    new string[]
    {
         "Fury Attack", "Growl", "Peck", "Pluck", "Drill Run", "Leer", "Pursuit", "Aerial Ace", "Mirror Move", "Agility", "Assurance", "Roost", "Drill Peck",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Giga_Impact", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(23, "Ekans", PokemonData.Type.POISON, PokemonData.Type.NONE, "Intimidate", "Shed-skin", "Unnerve",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2f, 6.9f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Snake", "The older it gets, the longer it grows. At night, it wraps its long body aroundtree branches to rest.",
    35, 60, 44, 40, 54, 55, 0, Color.clear,
    new int[] { 1, 1, 4, 9, 12, 17, 20, 25, 25, 25, 28, 33, 36, 38, 41, 44, 49},
    new string[]
    {
         "Wrap", "Leer", "Poison Sting", "Bite", "Glare", "Screech", "Acid", "Stockpile", "Spit Up", "Swallow", "Acid Spray", "Mud Bomb", "Gastro Acid", "Belch", "Haze", "Coil", "Gunk Shot",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Torment", "Facade", "Rock_Tomb", "Payback", "Poison_Jab", "Dark_Pulse", "Venoshock", "Sludge_Wave", "Round", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {24}, new string[] {"Level,22"}),


new PokemonData(24, "Arbok", PokemonData.Type.POISON, PokemonData.Type.NONE, "Intimidate", "Shed-skin", "Unnerve",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 3.5f, 65f,
    157, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Cobra", "The pattern on its belly appears to be a frighteningface. Weak foes will flee just at the sight ofthe pattern.",
    60, 95, 69, 65, 79, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 12, 17, 22, 27, 27, 27, 32, 39, 44, 48, 51, 56, 63},
    new string[]
    {
         "Wrap", "Poison Sting", "Bite", "Thunder Fang", "Ice Fang", "Fire Fang", "Glare", "Screech", "Crunch", "Stockpile", "Spit Up", "Swallow", "Acid Spray", "Mud Bomb", "Gastro Acid", "Belch", "Haze", "Coil", "Gunk Shot",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Torment", "Facade", "Rock_Tomb", "Payback", "Poison_Jab", "Dark_Pulse", "Giga_Impact", "Venoshock", "Sludge_Wave", "Round", "Bulldoze", "Dragon_Tail", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(25, "Pikachu", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Lightning-rod",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.4f, 6f,
    112, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Mouse", "It raises its tail to check its surroundings. The tail is sometimes struck by lightningin this pose.",
    35, 55, 40, 50, 50, 90, 0, Color.clear,
    new int[] { 1, 1, 5, 7, 10, 13, 18, 21, 23, 26, 29, 34, 37, 42, 45, 50},
    new string[]
    {
         "Tail Whip", "Thunder Shock", "Growl", "Play Nice", "Quick Attack", "Thunder Wave", "Electro Ball", "Double Team", "Nuzzle", "Slam", "Thunderbolt", "Feint", "Agility", "Discharge", "Light Screen", "Thunder",
    },
    new string[]
    {
         "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Brick_Break", "Fling", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Volt_Switch", "Wild_Charge", "Confide"
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
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Brick_Break", "Fling", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(27, "Sandshrew", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", null, "Sand-rush",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 12f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Mouse", "It burrows and lives underground. If threatened,it curls itself up into a ball for protection.",
    50, 75, 85, 20, 30, 40, 0, Color.clear,
    new int[] { 1, 1, 3, 5, 7, 9, 11, 14, 17, 20, 23, 26, 30, 34, 38, 42, 46},
    new string[]
    {
         "Scratch", "Defense Curl", "Sand Attack", "Poison Sting", "Rollout", "Rapid Spin", "Swift", "Fury Cutter", "Magnitude", "Fury Swipes", "Sand Tomb", "Slash", "Dig", "Gyro Ball", "Swords Dance", "Sandstorm", "Earthquake",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Gyro_Ball", "Fling", "Poison_Jab", "X_Scissor", "Shadow_Claw", "Hone_Claws", "Round", "Bulldoze", "Confide"
    },
    new int[] {28}, new string[] {"Level,22"}),


new PokemonData(28, "Sandslash", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", null, "Sand-rush",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 29.5f,
    158, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Mouse", "If it digs at an incredible pace, it may snap offits spikes and claws. They grow back in a day.",
    75, 100, 110, 45, 55, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 7, 9, 11, 14, 17, 20, 22, 23, 26, 30, 34, 38, 42, 46},
    new string[]
    {
         "Scratch", "Sand Attack", "Defense Curl", "Poison Sting", "Rollout", "Rapid Spin", "Swift", "Fury Cutter", "Magnitude", "Fury Swipes", "Crush Claw", "Sand Tomb", "Slash", "Dig", "Gyro Ball", "Swords Dance", "Sandstorm", "Earthquake",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Gyro_Ball", "Fling", "Poison_Jab", "X_Scissor", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(29, "Nidoran-f", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
    0f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 7f,
    55, PokemonData.LevelingRate.MEDIUMSLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Poison Pin", "Although small, its venomous barbs renderthis Pokémon dangerous. The female hassmaller horns.",
    55, 47, 52, 40, 40, 41, 0, Color.clear,
    new int[] { 1, 1, 7, 9, 13, 19, 21, 25, 31, 33, 37, 43, 45},
    new string[]
    {
         "Scratch", "Growl", "Tail Whip", "Double Kick", "Poison Sting", "Fury Swipes", "Bite", "Helping Hand", "Toxic Spikes", "Flatter", "Crunch", "Captivate", "Poison Fang",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Aerial_Ace", "Poison_Jab", "Shadow_Claw", "Hone_Claws", "Venoshock", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {30}, new string[] {"Level,16"}),


new PokemonData(30, "Nidorina", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
    0f, 120, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.8f, 20f,
    128, PokemonData.LevelingRate.MEDIUMSLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Poison Pin", "The female has a gentle temperament. It emits ultrasonic cries that have the powerto befuddle foes.",
    70, 62, 67, 55, 55, 56, 0, Color.clear,
    new int[] { 1, 1, 7, 9, 13, 20, 23, 28, 35, 38, 43, 50, 58},
    new string[]
    {
         "Scratch", "Growl", "Tail Whip", "Double Kick", "Poison Sting", "Fury Swipes", "Bite", "Helping Hand", "Toxic Spikes", "Flatter", "Crunch", "Captivate", "Poison Fang",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Aerial_Ace", "Poison_Jab", "Shadow_Claw", "Hone_Claws", "Venoshock", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(31, "Nidoqueen", PokemonData.Type.POISON, PokemonData.Type.GROUND, "Poison-point", "Rivalry", "Sheer-force",
    0f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.3f, 60f,
    227, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Drill", "It uses its scaly, rugged body to seal the entranceof its nest and protect its young from predators.",
    90, 92, 87, 75, 85, 76, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 23, 35},
    new string[]
    {
         "Scratch", "Double Kick", "Tail Whip", "Poison Sting", "Superpower", "Chip Away", "Body Slam",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Venoshock", "Smack_Down", "Sludge_Wave", "Round", "Echoed_Voice", "Incinerate", "Quash", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(32, "Nidoran-m", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
    100f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 9f,
    55, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Pin", "It scans its surroundings by raising its ears out ofthe grass. Its toxic horn is for protection.",
    46, 57, 40, 40, 40, 50, 0, Color.clear,
    new int[] { 1, 1, 7, 9, 13, 19, 21, 25, 31, 33, 37, 43, 45},
    new string[]
    {
         "Leer", "Peck", "Focus Energy", "Double Kick", "Poison Sting", "Fury Attack", "Horn Attack", "Helping Hand", "Toxic Spikes", "Flatter", "Poison Jab", "Captivate", "Horn Drill",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Poison_Jab", "Shadow_Claw", "Hone_Claws", "Venoshock", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {33}, new string[] {"Level,16"}),


new PokemonData(33, "Nidorino", PokemonData.Type.POISON, PokemonData.Type.NONE, "Poison-point", "Rivalry", "Hustle",
    100f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 19.5f,
    128, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Pin", "It raises its big ears to check its surroundings. If it senses anything, it attacks immediately.",
    61, 72, 57, 55, 55, 65, 0, Color.clear,
    new int[] { 1, 1, 7, 9, 13, 20, 23, 28, 35, 38, 43, 50, 58},
    new string[]
    {
         "Leer", "Peck", "Focus Energy", "Double Kick", "Poison Sting", "Fury Attack", "Horn Attack", "Helping Hand", "Toxic Spikes", "Flatter", "Poison Jab", "Captivate", "Horn Drill",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Poison_Jab", "Shadow_Claw", "Hone_Claws", "Venoshock", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(34, "Nidoking", PokemonData.Type.POISON, PokemonData.Type.GROUND, "Poison-point", "Rivalry", "Sheer-force",
    100f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.4f, 62f,
    227, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Drill", "It is recognized by its rock-hard hide andits extended horn. Be careful with the horn,as it contains venom.",
    81, 102, 77, 85, 75, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 23, 35},
    new string[]
    {
         "Double Kick", "Poison Sting", "Peck", "Focus Energy", "Megahorn", "Chip Away", "Thrash",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Venoshock", "Smack_Down", "Sludge_Wave", "Round", "Echoed_Voice", "Incinerate", "Quash", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(35, "Clefairy", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Cute-charm", "Magic-guard", "Friend-guard",
    25f, 150, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.6f, 7.5f,
    113, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
    "Fairy", "It is said that happiness will come to those who seea gathering of Clefairy dancing under a full moon.",
    70, 45, 48, 60, 65, 35, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 7, 10, 13, 16, 19, 22, 25, 31, 34, 40, 43, 46, 49, 50},
    new string[]
    {
         "Pound", "Growl", "Encore", "Healing Wish", "After You", "Disarming Voice", "Sing", "Double Slap", "Defense Curl", "Follow Me", "Bestow", "Wake-Up Slap", "Minimize", "Metronome", "Cosmic Power", "Body Slam", "Moonlight", "Moonblast", "Gravity", "Meteor Mash",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Calm_Mind", "Fling", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(36, "Clefable", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Cute-charm", "Magic-guard", "Unaware",
    25f, 25, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.3f, 40f,
    217, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
    "Fairy", "Its hearing is so acute it can hear a pin drop overhalf a mile away. It lives on quiet mountains.",
    95, 70, 73, 95, 90, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1},
    new string[]
    {
         "Double Slap", "Sing", "Minimize", "Metronome", "Disarming Voice",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Calm_Mind", "Fling", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(37, "Vulpix", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Drought",
    25f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 9.9f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Fox", "When it is born, it has just one snow-white tail. The tail splits from its tip as it grows older.",
    38, 41, 40, 50, 65, 65, 0, Color.clear,
    new int[] { 1, 4, 7, 9, 10, 12, 15, 18, 20, 23, 26, 28, 31, 34, 36, 39, 42, 44, 47, 50},
    new string[]
    {
         "Ember", "Tail Whip", "Roar", "Baby-Doll Eyes", "Quick Attack", "Fire Spin", "Confuse Ray", "Imprison", "Feint Attack", "Flame Burst", "Will-O-Wisp", "Hex", "Payback", "Flamethrower", "Safeguard", "Extrasensory", "Fire Blast", "Grudge", "Captivate", "Inferno",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Will_O_Wisp", "Facade", "Overheat", "Payback", "Dark_Pulse", "Energy_Ball", "Flame_Charge", "Round", "Incinerate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(38, "Ninetales", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Drought",
    25f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 19.9f,
    177, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Fox", "It has nine long tails and fur that gleams gold. It is said to live for 1,000 years.",
    73, 76, 75, 81, 100, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1},
    new string[]
    {
         "Flamethrower", "Quick Attack", "Confuse Ray", "Safeguard", "Imprison", "Nasty Plot",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Dream_Eater", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Will_O_Wisp", "Facade", "Overheat", "Calm_Mind", "Payback", "Dark_Pulse", "Energy_Ball", "Giga_Impact", "Psyshock", "Flame_Charge", "Round", "Incinerate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(39, "Jigglypuff", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Cute-charm", "Competitive", "Friend-guard",
    25f, 170, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.5f, 5.5f,
    95, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Balloon", "It captivates foes with its huge, round eyes,then lulls them to sleep by singing asoothing melody.",
    115, 45, 20, 45, 25, 20, 0, Color.clear,
    new int[] { 1, 5, 7, 10, 13, 17, 21, 25, 29, 33, 37, 41, 45, 48, 50, 53},
    new string[]
    {
         "Sing", "Defense Curl", "Pound", "Play Nice", "Disable", "Round", "Rollout", "Double Slap", "Rest", "Body Slam", "Gyro Ball", "Wake-Up Slap", "Mimic", "Hyper Voice", "Disarming Voice", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Brick_Break", "Gyro_Ball", "Fling", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Wild_Charge", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(40, "Wigglytuff", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Cute-charm", "Competitive", "Frisk",
    25f, 50, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1f, 12f,
    196, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Balloon", "Their fur feels so good that if two of them snuggletogether, they won’t want to be separated.",
    140, 70, 45, 85, 50, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1},
    new string[]
    {
         "Double Slap", "Double-Edge", "Sing", "Disable", "Defense Curl", "Play Rough",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Brick_Break", "Gyro_Ball", "Fling", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Wild_Charge", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(41, "Zubat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 0.8f, 7.5f,
    49, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Bat", "Even though it has no eyes, it can sense obstaclesusing ultrasonic waves it emits from its mouth.",
    40, 45, 35, 30, 40, 55, 0, Color.clear,
    new int[] { 1, 4, 8, 12, 15, 19, 23, 26, 30, 34, 37, 41, 45},
    new string[]
    {
         "Leech Life", "Supersonic", "Astonish", "Bite", "Wing Attack", "Confuse Ray", "Swift", "Air Cutter", "Acrobatics", "Mean Look", "Poison Fang", "Haze", "Air Slash",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "Roost", "U_turn", "Payback", "Venoshock", "Round", "Acrobatics", "Confide"
    },
    new int[] {42}, new string[] {"Level,22"}),


new PokemonData(42, "Golbat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
    50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.6f, 55f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
    "Bat", "Once it bites, it will not stop draining energyfrom the victim even if it gets too heavy to fly.",
    75, 80, 70, 65, 75, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 12, 15, 19, 24, 33, 38, 42, 47, 52},
    new string[]
    {
         "Supersonic", "Leech Life", "Astonish", "Bite", "Wing Attack", "Confuse Ray", "Swift", "Acrobatics", "Mean Look", "Poison Fang", "Haze", "Air Slash",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "Roost", "U_turn", "Payback", "Giga_Impact", "Venoshock", "Round", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(43, "Oddish", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Run-away",
    50f, 255, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.5f, 5.4f,
    64, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Weed", "During the day, it stays in the cold undergroundto avoid the sun. It grows by bathing in moonlight.",
    45, 50, 55, 75, 65, 30, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 15, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Absorb", "Sweet Scent", "Acid", "Poison Powder", "Stun Spore", "Sleep Powder", "Mega Drain", "Lucky Chant", "Natural Gift", "Moonlight", "Giga Drain", "Petal Dance", "Grassy Terrain",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {44}, new string[] {"Level,21"}),


new PokemonData(44, "Gloom", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Stench",
    50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 0.8f, 8.6f,
    138, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Weed", "Smells incredibly foul! However, around one outof a thousand people enjoy sniffing itsnose-bending stink.",
    60, 65, 70, 85, 75, 40, 0, Color.clear,
    new int[] { 1, 1, 13, 15, 17, 23, 29, 35, 47, 50, 53, 56},
    new string[]
    {
         "Acid", "Sweet Scent", "Poison Powder", "Stun Spore", "Sleep Powder", "Mega Drain", "Lucky Chant", "Natural Gift", "Giga Drain", "Petal Blizzard", "Petal Dance", "Grassy Terrain",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Fling", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(45, "Vileplume", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Effect-spore",
    50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 1.2f, 18.6f,
    221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Flower", "The larger its petals, the more toxic pollen itcontains. Its big head is heavy and hard to hold up.",
    75, 80, 85, 110, 90, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 50, 53, 65},
    new string[]
    {
         "Mega Drain", "Poison Powder", "Stun Spore", "Aromatherapy", "Petal Blizzard", "Petal Dance", "Solar Beam",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Fling", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Venoshock", "Round", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(46, "Paras", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Effect-spore", "Dry-skin", "Damp",
    50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 5.4f,
    57, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Mushroom", "Growing out of the bug’s back are mushroomscalled tochukaso. The mushrooms growwith the bug host.",
    35, 70, 55, 45, 55, 25, 0, Color.clear,
    new int[] { 1, 6, 6, 11, 17, 22, 27, 33, 38, 43, 49, 54},
    new string[]
    {
         "Scratch", "Poison Powder", "Stun Spore", "Leech Life", "Fury Cutter", "Spore", "Slash", "Growth", "Giga Drain", "Aromatherapy", "Rage Powder", "X-Scissor",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Aerial_Ace", "X_Scissor", "Energy_Ball", "Grass_Knot", "Hone_Claws", "Venoshock", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {47}, new string[] {"Level,24"}),


new PokemonData(47, "Parasect", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Effect-spore", "Dry-skin", "Damp",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1f, 29.5f,
    142, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 1, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Mushroom", "A mushroom grown larger than the host’s bodycontrols Parasect. It scatters poisonous spores.",
    60, 95, 80, 60, 80, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 17, 29, 37, 44, 51, 59, 66},
    new string[]
    {
         "Scratch", "Poison Powder", "Leech Life", "Cross Poison", "Stun Spore", "Fury Cutter", "Slash", "Growth", "Giga Drain", "Aromatherapy", "Rage Powder", "X-Scissor",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Aerial_Ace", "X_Scissor", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Hone_Claws", "Venoshock", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(48, "Venonat", PokemonData.Type.BUG, PokemonData.Type.POISON, "Compound-eyes", "Tinted-lens", "Run-away",
    50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1f, 30f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Insect", "Its big eyes are actually clusters of tiny eyes. At night, its kind is drawn by light.",
    60, 55, 50, 40, 55, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 11, 13, 17, 23, 25, 29, 35, 37, 41, 47},
    new string[]
    {
         "Tackle", "Disable", "Foresight", "Supersonic", "Confusion", "Poison Powder", "Leech Life", "Stun Spore", "Psybeam", "Sleep Powder", "Signal Beam", "Zen Headbutt", "Poison Fang", "Psychic",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Venoshock", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {49}, new string[] {"Level,31"}),


new PokemonData(49, "Venomoth", PokemonData.Type.BUG, PokemonData.Type.POISON, "Shield-dust", "Tinted-lens", "Wonder-skin",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.5f, 12.5f,
    158, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Moth", "The scales it scatters will paralyze anyone whotouches them, making that person unable to stand.",
    70, 65, 60, 90, 75, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 11, 13, 17, 23, 25, 29, 31, 37, 47, 55},
    new string[]
    {
         "Tackle", "Supersonic", "Foresight", "Silver Wind", "Bug Buzz", "Quiver Dance", "Confusion", "Poison Powder", "Leech Life", "Stun Spore", "Psybeam", "Sleep Powder", "Gust", "Signal Beam", "Poison Fang", "Psychic",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Energy_Ball", "Giga_Impact", "Venoshock", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(50, "Diglett", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", "Arena-trap", "Sand-force",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.2f, 0.8f,
    53, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Mole", "Lives about one yard underground where it feedson plant roots. It sometimes appears aboveground.",
    10, 55, 25, 35, 45, 95, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 12, 15, 18, 23, 26, 29, 34, 37, 40, 45},
    new string[]
    {
         "Scratch", "Sand Attack", "Growl", "Astonish", "Mud-Slap", "Magnitude", "Bulldoze", "Sucker Punch", "Mud Bomb", "Earth Power", "Dig", "Slash", "Earthquake", "Fissure",
    },
    new string[]
    {
         "Cut", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Shadow_Claw", "Hone_Claws", "Round", "Echoed_Voice", "Bulldoze", "Confide"
    },
    new int[] {51}, new string[] {"Level,26"}),


new PokemonData(51, "Dugtrio", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-veil", "Arena-trap", "Sand-force",
    50f, 50, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 33.3f,
    149, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Mole", "In battle, it digs through the ground and strikesthe unsuspecting foe from an unexpected direction.",
    35, 100, 50, 50, 70, 120, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 7, 12, 15, 18, 23, 26, 28, 33, 40, 45, 57},
    new string[]
    {
         "Scratch", "Sand Attack", "Growl", "Tri Attack", "Night Slash", "Rototiller", "Astonish", "Mud-Slap", "Magnitude", "Bulldoze", "Sucker Punch", "Sand Tomb", "Mud Bomb", "Earth Power", "Dig", "Slash", "Fissure",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Sludge_Wave", "Round", "Echoed_Voice", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(52, "Meowth", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Technician", "Unnerve",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 4.2f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Scratch Cat", "It is nocturnal in nature. If it spots something shiny,its eyes glitter brightly.",
    40, 45, 35, 40, 40, 90, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 14, 17, 22, 25, 30, 33, 38, 41, 46, 49, 50},
    new string[]
    {
         "Scratch", "Growl", "Bite", "Fake Out", "Fury Swipes", "Screech", "Feint Attack", "Taunt", "Pay Day", "Slash", "Nasty Plot", "Assurance", "Captivate", "Night Slash", "Feint",
    },
    new string[]
    {
         "Cut", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "U_turn", "Payback", "Dark_Pulse", "Shadow_Claw", "Hone_Claws", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {53}, new string[] {"Level,28"}),


new PokemonData(53, "Persian", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Limber", "Technician", "Unnerve",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 32f,
    154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Classy Cat", "Although its fur has many admirers, it is toughto raise as a pet because of its fickle meanness.",
    65, 70, 60, 65, 65, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 14, 17, 22, 28, 32, 37, 44, 49, 56, 61, 65},
    new string[]
    {
         "Scratch", "Bite", "Fake Out", "Switcheroo", "Play Rough", "Fury Swipes", "Screech", "Feint Attack", "Swift", "Power Gem", "Slash", "Nasty Plot", "Assurance", "Captivate", "Night Slash", "Feint",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "U_turn", "Payback", "Embargo", "Dark_Pulse", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(54, "Psyduck", PokemonData.Type.WATER, PokemonData.Type.NONE, "Damp", "Cloud-nine", "Swift-swim",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 19.6f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Duck", "It is constantly wracked by a headache. When the headache turns intense,it begins using mysterious powers.",
    50, 52, 48, 65, 50, 55, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43, 46, 50},
    new string[]
    {
         "Scratch", "Water Sport", "Tail Whip", "Water Gun", "Disable", "Confusion", "Water Pulse", "Fury Swipes", "Screech", "Zen Headbutt", "Aqua Tail", "Soak", "Psych Up", "Amnesia", "Hydro Pump", "Wonder Room",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Waterfall", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Aerial_Ace", "Calm_Mind", "Fling", "Shadow_Claw", "Hone_Claws", "Psyshock", "Round", "Scald", "Confide", "Power_Up_Punch"
    },
    new int[] {55}, new string[] {"Level,33"}),


new PokemonData(55, "Golduck", PokemonData.Type.WATER, PokemonData.Type.NONE, "Damp", "Cloud-nine", "Swift-swim",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 76.6f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Duck", "It appears by waterways at dusk. It may use telekinetic powersif its forehead glows mysteriously.",
    80, 82, 78, 95, 80, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 15, 18, 22, 25, 29, 32, 38, 43, 49, 60},
    new string[]
    {
         "Scratch", "Tail Whip", "Water Gun", "Water Sport", "Aqua Jet", "Confusion", "Water Pulse", "Fury Swipes", "Screech", "Zen Headbutt", "Aqua Tail", "Soak", "Psych Up", "Amnesia", "Wonder Room",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Waterfall", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Aerial_Ace", "Calm_Mind", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Psyshock", "Low_Sweep", "Round", "Scald", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(56, "Mankey", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Vital-spirit", "Anger-point", "Defiant",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 28f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Pig Monkey", "It’s unsafe to approach if it gets violently enragedfor no reason and can’t distinguish friendsfrom foes.",
    40, 80, 35, 35, 45, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 9, 13, 17, 21, 25, 33, 37, 41, 45, 49, 53},
    new string[]
    {
         "Scratch", "Leer", "Low Kick", "Focus Energy", "Covet", "Fury Swipes", "Karate Chop", "Seismic Toss", "Screech", "Assurance", "Swagger", "Cross Chop", "Thrash", "Punishment", "Close Combat", "Final Gambit",
    },
    new string[]
    {
         "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "U_turn", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Hone_Claws", "Smack_Down", "Low_Sweep", "Round", "Acrobatics", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {57}, new string[] {"Level,28"}),


new PokemonData(57, "Primeape", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Vital-spirit", "Anger-point", "Defiant",
    50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 32f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Pig Monkey", "It stops being angry only when nobody else isaround. To view this moment is very difficult.",
    65, 105, 60, 60, 70, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 9, 13, 17, 21, 25, 28, 35, 41, 47, 53, 59},
    new string[]
    {
         "Scratch", "Leer", "Low Kick", "Focus Energy", "Fling", "Final Gambit", "Fury Swipes", "Karate Chop", "Seismic Toss", "Screech", "Assurance", "Rage", "Swagger", "Cross Chop", "Thrash", "Punishment", "Close Combat",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "U_turn", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Hone_Claws", "Smack_Down", "Low_Sweep", "Round", "Acrobatics", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(58, "Growlithe", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Intimidate", "Flash-fire", "Justified",
    75f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 19f,
    70, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Puppy", "Very friendly and faithful to people. It will try torepel enemies by barking and biting.",
    55, 70, 45, 70, 50, 60, 0, Color.clear,
    new int[] { 1, 1, 6, 8, 10, 12, 17, 19, 21, 23, 28, 30, 32, 34, 39, 41, 43, 45},
    new string[]
    {
         "Bite", "Roar", "Ember", "Leer", "Odor Sleuth", "Helping Hand", "Flame Wheel", "Reversal", "Fire Fang", "Take Down", "Flame Burst", "Agility", "Retaliate", "Flamethrower", "Crunch", "Heat Wave", "Outrage", "Flare Blitz",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Overheat", "Aerial_Ace", "Flame_Charge", "Round", "Incinerate", "Retaliate", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(59, "Arcanine", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Intimidate", "Flash-fire", "Justified",
    75f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.9f, 155f,
    194, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Legendary", "A Pokémon that has long been admired for itsbeauty. It runs agilely as if on wings.",
    90, 110, 80, 100, 80, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 34},
    new string[]
    {
         "Bite", "Roar", "Odor Sleuth", "Thunder Fang", "Fire Fang", "Extreme Speed",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Overheat", "Aerial_Ace", "Giga_Impact", "Flame_Charge", "Round", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(60, "Poliwag", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", "Damp", "Swift-swim",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 12.4f,
    60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Tadpole", "Its slick black skin is thin and damp. A part of itsinternal organs can be seen through the skin as aspiral pattern.",
    40, 50, 40, 40, 40, 90, 0, Color.clear,
    new int[] { 1, 5, 8, 11, 15, 18, 21, 25, 28, 31, 35, 38, 41},
    new string[]
    {
         "Water Sport", "Water Gun", "Hypnosis", "Bubble", "Double Slap", "Rain Dance", "Body Slam", "Bubble Beam", "Mud Shot", "Belly Drum", "Wake-Up Slap", "Hydro Pump", "Mud Bomb",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Round", "Scald", "Confide"
    },
    new int[] {61}, new string[] {"Level,25"}),


new PokemonData(61, "Poliwhirl", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", "Damp", "Swift-swim",
    50f, 120, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1f, 20f,
    135, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
    "Tadpole", "It can live in or out of water. When out of water,it constantly sweats to keep its body slimy.",
    65, 65, 65, 50, 50, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 15, 18, 21, 27, 32, 37, 43, 53},
    new string[]
    {
         "Water Gun", "Hypnosis", "Water Sport", "Double Slap", "Rain Dance", "Body Slam", "Bubble Beam", "Mud Shot", "Belly Drum", "Wake-Up Slap", "Mud Bomb",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Fling", "Round", "Scald", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(62, "Poliwrath", PokemonData.Type.WATER, PokemonData.Type.FIGHTING, "Water-absorb", "Damp", "Swift-swim",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.3f, 54f,
    230, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Tadpole", "With its extremely tough muscles, it can keepswimming in the Pacific Ocean without resting.",
    90, 95, 95, 70, 90, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 32, 43},
    new string[]
    {
         "Double Slap", "Bubble Beam", "Submission", "Hypnosis", "Circle Throw", "Dynamic Punch", "Mind Reader",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Low_Sweep", "Round", "Scald", "Bulldoze", "Confide", "Power_Up_Punch"
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
         "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Calm_Mind", "Embargo", "Fling", "Energy_Ball", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {64}, new string[] {"Level,16"}),


new PokemonData(64, "Kadabra", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", "Inner-focus", "Magic-guard",
    75f, 100, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.3f, 56.5f,
    140, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Psi", "When it uses its psychic power, it emits strongalpha waves that can ruin precision devices.",
    40, 35, 30, 120, 70, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 18, 22, 24, 28, 30, 34, 36, 40, 42, 48, 50},
    new string[]
    {
         "Confusion", "Teleport", "Kinesis", "Disable", "Miracle Eye", "Ally Switch", "Psybeam", "Reflect", "Telekinesis", "Recover", "Psycho Cut", "Role Play", "Future Sight", "Trick",
    },
    new string[]
    {
         "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Calm_Mind", "Embargo", "Fling", "Energy_Ball", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(65, "Alakazam", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", "Inner-focus", "Magic-guard",
    75f, 50, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.5f, 48f,
    225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Psi", "Its brain cells multiply continually until it dies. As a result, it remembers everything.",
    55, 50, 45, 135, 95, 120, 0, Color.clear,
    new int[] { 1, 1, 1, 18, 22, 24, 28, 30, 34, 36, 40, 42, 48, 50},
    new string[]
    {
         "Confusion", "Teleport", "Kinesis", "Disable", "Miracle Eye", "Ally Switch", "Psybeam", "Reflect", "Telekinesis", "Recover", "Psycho Cut", "Calm Mind", "Future Sight", "Trick",
    },
    new string[]
    {
         "Hyper_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Calm_Mind", "Embargo", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(66, "Machop", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
    75f, 180, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.8f, 19.5f,
    61, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Superpower", "It hefts a Graveler repeatedly to strengthenits entire body. It uses every type of martial arts.",
    70, 80, 50, 35, 35, 35, 0, Color.clear,
    new int[] { 1, 1, 7, 10, 13, 19, 22, 25, 31, 34, 37, 43, 46, 49},
    new string[]
    {
         "Leer", "Low Kick", "Focus Energy", "Karate Chop", "Low Sweep", "Foresight", "Seismic Toss", "Revenge", "Vital Throw", "Submission", "Wake-Up Slap", "Cross Chop", "Scary Face", "Dynamic Punch",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Smack_Down", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {67}, new string[] {"Level,28"}),


new PokemonData(67, "Machoke", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
    75f, 90, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.5f, 70.5f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Superpower", "Its muscular body is so powerful, it must wear apower-save belt to be able to regulate its motions.",
    80, 100, 70, 50, 60, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 19, 22, 25, 32, 36, 40, 44, 55},
    new string[]
    {
         "Karate Chop", "Low Kick", "Focus Energy", "Low Sweep", "Foresight", "Seismic Toss", "Revenge", "Vital Throw", "Submission", "Wake-Up Slap", "Cross Chop", "Dynamic Punch",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Smack_Down", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(68, "Machamp", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "No-guard", "Steadfast",
    75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.6f, 130f,
    227, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Superpower", "Its four ruggedly developed arms can launcha flurry of 1,000 punches in just two seconds.",
    90, 130, 80, 65, 85, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 19, 22, 25, 32, 36, 40, 44, 55},
    new string[]
    {
         "Karate Chop", "Low Kick", "Focus Energy", "Wide Guard", "Low Sweep", "Foresight", "Seismic Toss", "Revenge", "Vital Throw", "Submission", "Wake-Up Slap", "Cross Chop", "Dynamic Punch",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Smack_Down", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(69, "Bellsprout", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Gluttony",
    50f, 255, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.7f, 4f,
    60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Flower", "Even though its body is extremely skinny, it isblindingly fast when catching its prey.",
    50, 75, 35, 70, 30, 40, 0, Color.clear,
    new int[] { 1, 7, 11, 13, 15, 17, 23, 27, 29, 35, 39, 41, 47},
    new string[]
    {
         "Vine Whip", "Growth", "Wrap", "Sleep Powder", "Poison Powder", "Stun Spore", "Acid", "Knock Off", "Sweet Scent", "Gastro Acid", "Razor Leaf", "Slam", "Wring Out",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Confide", "Infestation"
    },
    new int[] {70}, new string[] {"Level,21"}),


new PokemonData(70, "Weepinbell", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Gluttony",
    50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1f, 6.4f,
    137, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Flycatcher", "The leafy parts act as cutters for slashing foes. It spits a fluid that dissolves everything.",
    65, 90, 50, 85, 45, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 13, 15, 17, 27, 29, 35, 41, 47},
    new string[]
    {
         "Vine Whip", "Wrap", "Growth", "Sleep Powder", "Poison Powder", "Stun Spore", "Knock Off", "Sweet Scent", "Gastro Acid", "Slam", "Wring Out",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(71, "Victreebel", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Chlorophyll", null, "Gluttony",
    50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1.7f, 15.5f,
    221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Flycatcher", "Said to live in huge colonies deep in jungles,although no one has ever returned from there.",
    80, 105, 65, 100, 70, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 27, 47, 47},
    new string[]
    {
         "Vine Whip", "Razor Leaf", "Sleep Powder", "Sweet Scent", "Stockpile", "Spit Up", "Swallow", "Leaf Tornado", "Leaf Blade", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Venoshock", "Round", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(72, "Tentacool", PokemonData.Type.WATER, PokemonData.Type.POISON, "Clear-body", "Liquid-ooze", "Rain-dish",
    50f, 190, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.9f, 45.5f,
    67, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Jellyfish", "Its body is virtually composed of water. It shootsstrange beams from its crystal-like eyes.",
    40, 40, 35, 50, 100, 70, 0, Color.clear,
    new int[] { 1, 5, 8, 12, 15, 19, 22, 26, 29, 33, 36, 40, 43, 47, 50, 54},
    new string[]
    {
         "Poison Sting", "Supersonic", "Constrict", "Acid", "Toxic Spikes", "Bubble Beam", "Wrap", "Acid Spray", "Barrier", "Water Pulse", "Poison Jab", "Screech", "Hex", "Hydro Pump", "Sludge Wave", "Wring Out",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Payback", "Poison_Jab", "Venoshock", "Sludge_Wave", "Round", "Scald", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {73}, new string[] {"Level,30"}),


new PokemonData(73, "Tentacruel", PokemonData.Type.WATER, PokemonData.Type.POISON, "Clear-body", "Liquid-ooze", "Rain-dish",
    50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.6f, 55f,
    180, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLUE, 70,
    "Jellyfish", "The tentacles are normally kept short. On hunts,they are extended to ensnare and immobilize prey.",
    80, 70, 65, 80, 120, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 19, 22, 26, 29, 38, 43, 47, 52, 56},
    new string[]
    {
         "Poison Sting", "Supersonic", "Constrict", "Wring Out", "Reflect Type", "Bubble Beam", "Wrap", "Acid Spray", "Barrier", "Poison Jab", "Screech", "Hex", "Hydro Pump", "Sludge Wave",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Payback", "Poison_Jab", "Giga_Impact", "Venoshock", "Sludge_Wave", "Round", "Scald", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(74, "Geodude", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
    50f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.4f, 20f,
    60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Rock", "Found in fields and mountains. Mistaking them forboulders, people often step or trip on them.",
    40, 80, 100, 30, 30, 20, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43, 46, 50},
    new string[]
    {
         "Tackle", "Defense Curl", "Mud Sport", "Rock Polish", "Rollout", "Magnitude", "Rock Throw", "Rock Blast", "Smack Down", "Self-Destruct", "Bulldoze", "Stealth Rock", "Earthquake", "Explosion", "Double-Edge", "Stone Edge",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Rock_Polish", "Stone_Edge", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {75}, new string[] {"Level,25"}),


new PokemonData(75, "Graveler", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
    50f, 120, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 105f,
    137, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Rock", "With a free and uncaring nature, it doesn’t mindif pieces break off while it rolls down mountains.",
    55, 95, 115, 45, 45, 35, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 11, 15, 18, 27, 31, 36, 42, 47, 53, 58},
    new string[]
    {
         "Tackle", "Defense Curl", "Mud Sport", "Rock Polish", "Rollout", "Magnitude", "Rock Throw", "Smack Down", "Self-Destruct", "Bulldoze", "Stealth Rock", "Earthquake", "Explosion", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Rock_Polish", "Stone_Edge", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(76, "Golem", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sand-veil",
    50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.4f, 300f,
    223, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Megaton", "It tumbles down mountains, leaving groovesfrom peak to base. Stay clear of these grooves.",
    80, 120, 130, 55, 65, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 11, 15, 18, 27, 31, 42, 47, 53, 58},
    new string[]
    {
         "Tackle", "Defense Curl", "Mud Sport", "Rock Polish", "Heavy Slam", "Steamroller", "Magnitude", "Rock Throw", "Smack Down", "Self-Destruct", "Stealth Rock", "Earthquake", "Explosion", "Double-Edge",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(77, "Ponyta", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Run-away", "Flash-fire", "Flame-body",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 30f,
    82, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Fire Horse", "As a newborn, it can barely stand. However, through galloping, itslegs are made tougher and faster.",
    50, 85, 55, 65, 65, 90, 0, Color.clear,
    new int[] { 1, 1, 4, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49},
    new string[]
    {
         "Tackle", "Growl", "Tail Whip", "Ember", "Flame Wheel", "Stomp", "Flame Charge", "Fire Spin", "Take Down", "Inferno", "Agility", "Fire Blast", "Bounce", "Flare Blitz",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Will_O_Wisp", "Facade", "Overheat", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Wild_Charge", "Confide"
    },
    new int[] {78}, new string[] {"Level,40"}),


new PokemonData(78, "Rapidash", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Run-away", "Flash-fire", "Flame-body",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.7f, 95f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Fire Horse", "Very competitive, this Pokémon will chase anythingthat moves fast in the hopes of racing it.",
    65, 100, 70, 80, 80, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 13, 17, 21, 29, 33, 37, 40, 41, 45, 49},
    new string[]
    {
         "Tail Whip", "Ember", "Quick Attack", "Megahorn", "Poison Jab", "Flame Wheel", "Stomp", "Flame Charge", "Take Down", "Inferno", "Agility", "Fury Attack", "Fire Blast", "Bounce", "Flare Blitz",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Will_O_Wisp", "Facade", "Overheat", "Poison_Jab", "Giga_Impact", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(79, "Slowpoke", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
    50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 36f,
    63, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Dopey", "It is always vacantly lost in thought, but no oneknows what it is thinking about. It is good at fishingwith its tail.",
    90, 65, 65, 40, 40, 15, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 14, 19, 23, 28, 32, 36, 41, 45, 49, 54, 58},
    new string[]
    {
         "Tackle", "Curse", "Yawn", "Growl", "Water Gun", "Confusion", "Disable", "Headbutt", "Water Pulse", "Zen Headbutt", "Slack Off", "Amnesia", "Psychic", "Rain Dance", "Psych Up", "Heal Pulse",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Strength", "Thunder_Wave", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Hail", "Facade", "Calm_Mind", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Scald", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {80}, new string[] {"Level,37"}),


new PokemonData(80, "Slowbro", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
    50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.6f, 78.5f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Hermit Crab", "An attached Shellder won’t let go because ofthe tasty flavor that oozes out of its tail.",
    95, 75, 110, 100, 80, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 9, 14, 23, 28, 32, 36, 37, 43, 49, 55, 62},
    new string[]
    {
         "Tackle", "Growl", "Curse", "Yawn", "Heal Pulse", "Water Gun", "Confusion", "Headbutt", "Water Pulse", "Zen Headbutt", "Slack Off", "Withdraw", "Amnesia", "Psychic", "Rain Dance", "Psych Up",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunder_Wave", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Aerial_Ace", "Calm_Mind", "Fling", "Focus_Blast", "Giga_Impact", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Scald", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(81, "Magnemite", PokemonData.Type.ELECTRIC, PokemonData.Type.STEEL, "Magnet-pull", "Sturdy", "Analytic",
    112.5f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.3f, 6f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Magnet", "The units at the sides of its body generateantigravity energy to keep it aloft in the air.",
    25, 35, 70, 95, 55, 45, 0, Color.clear,
    new int[] { 1, 4, 7, 11, 15, 18, 21, 25, 29, 32, 35, 39, 43, 46, 49, 53, 57},
    new string[]
    {
         "Tackle", "Supersonic", "Thunder Shock", "Sonic Boom", "Thunder Wave", "Magnet Bomb", "Spark", "Mirror Shot", "Metal Sound", "Electro Ball", "Flash Cannon", "Screech", "Discharge", "Lock-On", "Magnet Rise", "Gyro Ball", "Zap Cannon",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Facade", "Gyro_Ball", "Flash_Cannon", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {82}, new string[] {"Level,30"}),


new PokemonData(82, "Magneton", PokemonData.Type.ELECTRIC, PokemonData.Type.STEEL, "Magnet-pull", "Sturdy", "Analytic",
    112.5f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 60f,
    163, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Magnet", "A linked cluster formed of several Magnemite. It discharges powerful magnetic waves athigh voltage.",
    50, 60, 95, 120, 70, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 11, 18, 21, 25, 29, 34, 39, 45, 51, 62, 67},
    new string[]
    {
         "Tackle", "Supersonic", "Thunder Shock", "Tri Attack", "Zap Cannon", "Electric Terrain", "Magnet Bomb", "Spark", "Mirror Shot", "Metal Sound", "Electro Ball", "Flash Cannon", "Screech", "Discharge", "Magnet Rise", "Gyro Ball",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Facade", "Gyro_Ball", "Giga_Impact", "Flash_Cannon", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(83, "Farfetchd", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Inner-focus", "Defiant",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.8f, 15f,
    132, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Wild Duck", "The plant stalk it holds is its weapon. The stalk isused like a sword to cut all sorts of things.",
    52, 90, 55, 58, 62, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 7, 9, 13, 19, 21, 25, 31, 33, 43, 45, 49},
    new string[]
    {
         "Sand Attack", "Leer", "Peck", "Fury Cutter", "Poison Jab", "Brave Bird", "Fury Attack", "Aerial Ace", "Knock Off", "Slash", "Air Cutter", "Swords Dance", "Agility", "Night Slash", "Feint", "False Swipe", "Air Slash",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Facade", "Aerial_Ace", "Roost", "U_turn", "Poison_Jab", "Round", "Acrobatics", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(84, "Doduo", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Run-away", "Early-bird", "Tangled-feet",
    50f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.4f, 39.2f,
    62, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Twin Bird", "A two-headed Pokémon that was discovered as asudden mutation. It runs at a pace of over 60 milesper hour.",
    35, 85, 45, 35, 35, 75, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 46, 50},
    new string[]
    {
         "Growl", "Peck", "Quick Attack", "Rage", "Fury Attack", "Pursuit", "Uproar", "Acupressure", "Double Hit", "Agility", "Drill Peck", "Endeavor", "Thrash",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {85}, new string[] {"Level,31"}),


new PokemonData(85, "Dodrio", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Run-away", "Early-bird", "Tangled-feet",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.8f, 85.2f,
    165, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Triple Bird", "An enemy that takes its eyes off any of thethree heads--even for a second--will getpecked severely.",
    60, 110, 70, 60, 60, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 14, 19, 23, 28, 34, 41, 47, 54, 60},
    new string[]
    {
         "Growl", "Peck", "Quick Attack", "Pluck", "Rage", "Fury Attack", "Pursuit", "Uproar", "Acupressure", "Tri Attack", "Agility", "Drill Peck", "Endeavor", "Thrash",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Torment", "Facade", "Taunt", "Aerial_Ace", "Roost", "Payback", "Giga_Impact", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(86, "Seel", PokemonData.Type.WATER, PokemonData.Type.NONE, "Thick-fat", "Hydration", "Ice-body",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.1f, 90f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.WHITE, 70,
    "Sea Lion", "A Pokémon that lives on icebergs. It swims in thesea using the point on its head to break up ice.",
    65, 45, 55, 45, 70, 45, 0, Color.clear,
    new int[] { 1, 3, 7, 11, 13, 17, 21, 23, 27, 31, 33, 37, 41, 43, 47, 51, 53},
    new string[]
    {
         "Headbutt", "Growl", "Water Sport", "Icy Wind", "Encore", "Ice Shard", "Rest", "Aqua Ring", "Aurora Beam", "Aqua Jet", "Brine", "Take Down", "Dive", "Aqua Tail", "Ice Beam", "Safeguard", "Hail",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Fling", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {87}, new string[] {"Level,34"}),


new PokemonData(87, "Dewgong", PokemonData.Type.WATER, PokemonData.Type.ICE, "Thick-fat", "Hydration", "Ice-body",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 120f,
    166, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.WHITE, 70,
    "Sea Lion", "Its body is covered with a pure white fur. The colder the weather, the more activeit becomes.",
    90, 70, 80, 70, 95, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 17, 21, 23, 27, 31, 33, 39, 45, 49, 65},
    new string[]
    {
         "Headbutt", "Growl", "Icy Wind", "Signal Beam", "Encore", "Ice Shard", "Rest", "Aqua Ring", "Aurora Beam", "Aqua Jet", "Brine", "Take Down", "Dive", "Aqua Tail", "Hail",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Fling", "Giga_Impact", "Round", "Echoed_Voice", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(88, "Grimer", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Sticky-hold", "Poison-touch",
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.9f, 30f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sludge", "Sludge exposed to X-rays from the moontransformed into Grimer. It loves feedingon filthy things.",
    80, 80, 50, 40, 50, 25, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 12, 15, 18, 21, 26, 29, 32, 37, 40, 43, 46, 48},
    new string[]
    {
         "Pound", "Poison Gas", "Harden", "Mud-Slap", "Disable", "Sludge", "Minimize", "Mud Bomb", "Sludge Bomb", "Fling", "Screech", "Sludge Wave", "Acid Armor", "Gunk Shot", "Belch", "Memento",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Rock_Tomb", "Payback", "Fling", "Poison_Jab", "Venoshock", "Sludge_Wave", "Round", "Incinerate", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {89}, new string[] {"Level,38"}),


new PokemonData(89, "Muk", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Sticky-hold", "Poison-touch",
    50f, 75, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 30f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 1, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sludge", "They love to gather in smelly areas where sludgeaccumulates, making the stench aroundthem worse.",
    105, 105, 75, 65, 100, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 12, 15, 21, 26, 29, 32, 37, 43, 49, 53},
    new string[]
    {
         "Pound", "Harden", "Poison Gas", "Mud-Slap", "Disable", "Sludge", "Mud Bomb", "Sludge Bomb", "Fling", "Screech", "Sludge Wave", "Acid Armor", "Gunk Shot", "Belch",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Payback", "Fling", "Poison_Jab", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Venoshock", "Sludge_Wave", "Round", "Incinerate", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(90, "Shellder", PokemonData.Type.WATER, PokemonData.Type.NONE, "Shell-armor", "Skill-link", "Overcoat",
    50f, 190, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.3f, 4f,
    61, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Bivalve", "Its hard shell repels any kind of attack. It is vulnerable only when its shell is open.",
    30, 65, 100, 45, 25, 40, 0, Color.clear,
    new int[] { 1, 4, 8, 13, 16, 20, 25, 28, 32, 37, 40, 44, 49, 52, 56, 61},
    new string[]
    {
         "Tackle", "Withdraw", "Supersonic", "Icicle Spear", "Protect", "Leer", "Clamp", "Ice Shard", "Razor Shell", "Aurora Beam", "Whirlpool", "Brine", "Iron Defense", "Ice Beam", "Shell Smash", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Payback", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(91, "Cloyster", PokemonData.Type.WATER, PokemonData.Type.ICE, "Shell-armor", "Skill-link", "Overcoat",
    50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.5f, 132.5f,
    184, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Bivalve", "Cloyster that live in seas with harsh tidal currentsgrow large, sharp spikes on their shells.",
    50, 95, 180, 85, 45, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 13, 28, 50},
    new string[]
    {
         "Supersonic", "Hydro Pump", "Aurora Beam", "Withdraw", "Protect", "Toxic Spikes", "Shell Smash", "Spike Cannon", "Spikes", "Icicle Crash",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Torment", "Facade", "Payback", "Poison_Jab", "Giga_Impact", "Round", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(92, "Gastly", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Levitate", null, null,
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.3f, 0.1f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Gas", "Its body is made of gas. Despite lacking substance,it can envelop an opponent of any size andcause suffocation.",
    30, 35, 30, 100, 35, 80, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 19, 22, 26, 29, 33, 36, 40, 43, 47},
    new string[]
    {
         "Hypnosis", "Lick", "Spite", "Mean Look", "Curse", "Night Shade", "Confuse Ray", "Sucker Punch", "Payback", "Shadow Ball", "Dream Eater", "Dark Pulse", "Destiny Bond", "Hex", "Nightmare",
    },
    new string[]
    {
         "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Payback", "Embargo", "Dark_Pulse", "Energy_Ball", "Trick_Room", "Venoshock", "Round", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {93}, new string[] {"Level,25"}),


new PokemonData(93, "Haunter", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Levitate", null, null,
    50f, 90, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.6f, 0.1f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Gas", "If you get the feeling of being watched in darknesswhen nobody is around, Haunter is there.",
    45, 50, 45, 115, 55, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 12, 15, 19, 22, 25, 28, 33, 39, 44, 55, 61},
    new string[]
    {
         "Hypnosis", "Lick", "Spite", "Mean Look", "Curse", "Night Shade", "Confuse Ray", "Sucker Punch", "Shadow Punch", "Payback", "Shadow Ball", "Dream Eater", "Dark Pulse", "Hex", "Nightmare",
    },
    new string[]
    {
         "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "Energy_Ball", "Shadow_Claw", "Trick_Room", "Venoshock", "Round", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(94, "Gengar", PokemonData.Type.GHOST, PokemonData.Type.POISON, "Cursed-body", null, null,
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.5f, 40.5f,
    225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Shadow", "It hides in shadows. It is said that if Gengaris hiding, it cools the area by nearly10 degrees Fahrenheit.",
    60, 65, 60, 130, 75, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 12, 15, 19, 22, 25, 28, 33, 39, 44, 55, 61},
    new string[]
    {
         "Hypnosis", "Lick", "Spite", "Mean Look", "Curse", "Night Shade", "Confuse Ray", "Sucker Punch", "Shadow Punch", "Payback", "Shadow Ball", "Dream Eater", "Dark Pulse", "Hex", "Nightmare",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Trick_Room", "Venoshock", "Round", "Confide", "Dazzling_Gleam", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(95, "Onix", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Weak-armor",
    50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 8.8f, 210f,
    77, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Rock Snake", "Burrows at high speed in search of food. The tunnels it leaves are used as homesby Diglett.",
    35, 45, 160, 30, 45, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 4, 7, 10, 13, 16, 19, 20, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52},
    new string[]
    {
         "Bind", "Tackle", "Harden", "Mud Sport", "Curse", "Rock Throw", "Rock Tomb", "Rage", "Stealth Rock", "Rock Polish", "Gyro Ball", "Smack Down", "Dragon Breath", "Slam", "Screech", "Rock Slide", "Sand Tomb", "Iron Tail", "Dig", "Stone Edge", "Double-Edge", "Sandstorm",
    },
    new string[]
    {
         "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Taunt", "Rock_Tomb", "Gyro_Ball", "Payback", "Rock_Polish", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Round", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(96, "Drowzee", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Insomnia", "Forewarn", "Inner-focus",
    50f, 190, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1f, 32.4f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Hypnosis", "Puts enemies to sleep, then eats their dreams. Occasionally gets sick from eating only bad dreams.",
    60, 48, 45, 43, 90, 42, 0, Color.clear,
    new int[] { 1, 1, 9, 13, 17, 21, 25, 33, 37, 41, 45, 49, 53, 57, 61},
    new string[]
    {
         "Pound", "Hypnosis", "Confusion", "Headbutt", "Poison Gas", "Meditate", "Psybeam", "Psych Up", "Synchronoise", "Zen Headbutt", "Swagger", "Psychic", "Nasty Plot", "Psyshock", "Future Sight",
    },
    new string[]
    {
         "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Brick_Break", "Calm_Mind", "Fling", "Trick_Room", "Grass_Knot", "Psyshock", "Low_Sweep", "Round", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {97}, new string[] {"Level,26"}),


new PokemonData(97, "Hypno", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Insomnia", "Forewarn", "Inner-focus",
    50f, 75, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.6f, 75.6f,
    169, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Hypnosis", "It carries a pendulum-like device. There oncewas an incident in which it took away a childit hypnotized.",
    85, 73, 70, 73, 115, 67, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 13, 17, 21, 25, 33, 37, 45, 57},
    new string[]
    {
         "Pound", "Confusion", "Hypnosis", "Nightmare", "Future Sight", "Nasty Plot", "Disable", "Headbutt", "Poison Gas", "Meditate", "Psybeam", "Psych Up", "Synchronoise", "Swagger", "Psyshock",
    },
    new string[]
    {
         "Hyper_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Brick_Break", "Calm_Mind", "Fling", "Focus_Blast", "Giga_Impact", "Trick_Room", "Grass_Knot", "Psyshock", "Low_Sweep", "Round", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(98, "Krabby", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Sheer-force",
    50f, 225, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.4f, 6.5f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "River Crab", "If it senses danger approaching, it cloaks itself withbubbles from its mouth so it will look bigger.",
    30, 105, 90, 25, 25, 50, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 11, 15, 19, 21, 25, 29, 31, 35, 39, 41, 45},
    new string[]
    {
         "Bubble", "Mud Sport", "Vice Grip", "Leer", "Harden", "Bubble Beam", "Mud Shot", "Metal Claw", "Stomp", "Protect", "Guillotine", "Slam", "Brine", "Crabhammer", "Flail",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "X_Scissor", "Hone_Claws", "Round", "Scald", "Confide"
    },
    new int[] {99}, new string[] {"Level,28"}),


new PokemonData(99, "Kingler", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Sheer-force",
    50f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.3f, 60f,
    166, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Pincer", "Its large and hard pincer has 10,000-horsepowerstrength. However, being so big, it is unwieldyto move.",
    55, 130, 115, 50, 50, 75, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 11, 19, 21, 25, 32, 44, 51, 56, 63},
    new string[]
    {
         "Vice Grip", "Leer", "Bubble", "Mud Sport", "Wide Guard", "Harden", "Mud Shot", "Metal Claw", "Stomp", "Protect", "Slam", "Brine", "Crabhammer", "Flail",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "X_Scissor", "Giga_Impact", "Hone_Claws", "Round", "Scald", "Quash", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(100, "Voltorb", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Soundproof", "Static", "Aftermath",
    112.5f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.5f, 10.4f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
    "Ball", "It was discovered when Poké Balls wereintroduced. It is said that there issome connection.",
    40, 30, 50, 55, 55, 100, 0, Color.clear,
    new int[] { 1, 5, 8, 10, 12, 15, 19, 22, 26, 29, 33, 36, 40, 43, 47, 50},
    new string[]
    {
         "Charge", "Tackle", "Sonic Boom", "Eerie Impulse", "Spark", "Rollout", "Screech", "Charge Beam", "Light Screen", "Electro Ball", "Self-Destruct", "Swift", "Magnet Rise", "Gyro Ball", "Explosion", "Mirror Coat",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Torment", "Facade", "Taunt", "Gyro_Ball", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {101}, new string[] {"Level,30"}),


new PokemonData(101, "Electrode", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Soundproof", "Static", "Aftermath",
    112.5f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.2f, 66.6f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.RED, 70,
    "Ball", "It explodes in response to even minor stimuli. It isfeared, with the nickname of “The Bomb Ball. ",
    60, 50, 70, 80, 80, 150, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 8, 15, 19, 22, 26, 29, 35, 40, 46, 51, 57},
    new string[]
    {
         "Tackle", "Spark", "Charge", "Magnetic Flux", "Eerie Impulse", "Rollout", "Screech", "Charge Beam", "Light Screen", "Electro Ball", "Self-Destruct", "Swift", "Magnet Rise", "Gyro Ball", "Explosion",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Torment", "Facade", "Taunt", "Gyro_Ball", "Giga_Impact", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(102, "Exeggcute", PokemonData.Type.GRASS, PokemonData.Type.PSYCHIC, "Chlorophyll", null, "Harvest",
    50f, 90, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 2.5f,
    65, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Egg", "Its six eggs converse using telepathy. They canquickly gather if they become separated.",
    60, 40, 80, 60, 45, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 11, 17, 19, 21, 23, 27, 33, 37, 43, 47, 50},
    new string[]
    {
         "Hypnosis", "Barrage", "Uproar", "Reflect", "Leech Seed", "Bullet Seed", "Stun Spore", "Poison Powder", "Sleep Powder", "Confusion", "Worry Seed", "Natural Gift", "Solar Beam", "Extrasensory", "Bestow",
    },
    new string[]
    {
         "Swords_Dance", "Strength", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Facade", "Nature_Power", "Energy_Ball", "Trick_Room", "Grass_Knot", "Round", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(103, "Exeggutor", PokemonData.Type.GRASS, PokemonData.Type.PSYCHIC, "Chlorophyll", null, "Harvest",
    50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 2f, 120f,
    186, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Coconut", "Its three heads think independently. However,they are friendly and never appear to squabble.",
    95, 95, 85, 125, 75, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 17, 27, 37, 47},
    new string[]
    {
         "Stomp", "Confusion", "Hypnosis", "Barrage", "Seed Bomb", "Psyshock", "Egg Bomb", "Wood Hammer", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Facade", "Nature_Power", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(104, "Cubone", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Rock-head", "Lightning-rod", "Battle-armor",
    50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 6.5f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Lonely", "It wears the skull of its dead mother on its head. When it becomes lonesome, it is said to cry loudly.",
    50, 50, 95, 40, 50, 35, 0, Color.clear,
    new int[] { 1, 3, 7, 11, 13, 17, 21, 23, 27, 31, 33, 37, 41, 43, 47},
    new string[]
    {
         "Growl", "Tail Whip", "Bone Club", "Headbutt", "Leer", "Focus Energy", "Bonemerang", "Rage", "False Swipe", "Thrash", "Fling", "Bone Rush", "Endeavor", "Double-Edge", "Retaliate",
    },
    new string[]
    {
         "Swords_Dance", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Smack_Down", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {105}, new string[] {"Level,28"}),


new PokemonData(105, "Marowak", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Rock-head", "Lightning-rod", "Battle-armor",
    50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 45f,
    149, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Bone Keeper", "It is small and was originally very weak. Its temperament turned ferocious when it beganusing bones.",
    60, 80, 110, 50, 80, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 23, 27, 37, 43, 49, 53, 59},
    new string[]
    {
         "Headbutt", "Tail Whip", "Growl", "Bone Club", "Focus Energy", "Rage", "False Swipe", "Fling", "Bone Rush", "Endeavor", "Double-Edge", "Retaliate",
    },
    new string[]
    {
         "Swords_Dance", "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Smack_Down", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {106}, new string[] {"Level,20"}),


new PokemonData(106, "Hitmonlee", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Limber", "Reckless", "Unburden",
    100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.5f, 49.8f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Kicking", "The legs freely contract and stretch. The stretchylegs allow it to hit a distant foe with a rising kick.",
    50, 120, 53, 35, 110, 87, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 9, 17, 21, 25, 29, 33, 45, 49},
    new string[]
    {
         "Double Kick", "Mega Kick", "Reversal", "Revenge", "Close Combat", "Meditate", "Rolling Kick", "Brick Break", "Focus Energy", "Feint", "High Jump Kick", "Mind Reader", "Blaze Kick", "Endure",
    },
    new string[]
    {
         "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Fling", "Poison_Jab", "Focus_Blast", "Stone_Edge", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {107}, new string[] {"Level,20"}),


new PokemonData(107, "Hitmonchan", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Keen-eye", "Iron-fist", "Inner-focus",
    100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 50.2f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BROWN, 70,
    "Punching", "The arm-twisting punches it throws pulverize evenconcrete. It rests after three minutes of fighting.",
    50, 105, 79, 35, 110, 76, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 11, 16, 16, 21, 31, 36, 36, 36, 41, 46, 50},
    new string[]
    {
         "Comet Punch", "Counter", "Focus Punch", "Close Combat", "Pursuit", "Mach Punch", "Bullet Punch", "Feint", "Quick Guard", "Fire Punch", "Ice Punch", "Thunder Punch", "Sky Uppercut", "Mega Punch", "Detect",
    },
    new string[]
    {
         "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Fling", "Focus_Blast", "Stone_Edge", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(108, "Lickitung", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Own-tempo", "Oblivious", "Cloud-nine",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 65.5f,
    77, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Licking", "Its long tongue, slathered with a gooey saliva,sticks to anything, so it is very useful.",
    90, 55, 75, 60, 75, 30, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57},
    new string[]
    {
         "Lick", "Supersonic", "Defense Curl", "Knock Off", "Wrap", "Stomp", "Disable", "Slam", "Rollout", "Chip Away", "Me First", "Refresh", "Screech", "Power Whip", "Wring Out",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Dream_Eater", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "Giga_Impact", "Round", "Incinerate", "Retaliate", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(109, "Koffing", PokemonData.Type.POISON, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 1f,
    68, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Gas", "Its thin, balloon-like body is inflated by horriblytoxic gases. It reeks when it is nearby.",
    40, 65, 95, 60, 45, 35, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 12, 15, 18, 23, 26, 29, 34, 37, 40, 42, 45},
    new string[]
    {
         "Tackle", "Poison Gas", "Smog", "Smokescreen", "Assurance", "Clear Smog", "Sludge", "Self-Destruct", "Haze", "Gyro Ball", "Sludge Bomb", "Explosion", "Destiny Bond", "Belch", "Memento",
    },
    new string[]
    {
         "Flamethrower", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Gyro_Ball", "Payback", "Dark_Pulse", "Venoshock", "Round", "Incinerate", "Confide", "Infestation"
    },
    new int[] {110}, new string[] {"Level,35"}),


new PokemonData(110, "Weezing", PokemonData.Type.POISON, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 60, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 9.5f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Gas", "If one of the twin Koffing inflates, the other onedeflates. It constantly mixes its poisonous gases.",
    65, 90, 120, 85, 70, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 12, 15, 23, 29, 34, 40, 46, 50, 54},
    new string[]
    {
         "Tackle", "Smokescreen", "Smog", "Poison Gas", "Assurance", "Clear Smog", "Self-Destruct", "Double Hit", "Sludge Bomb", "Explosion", "Destiny Bond", "Belch", "Memento",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Gyro_Ball", "Payback", "Dark_Pulse", "Giga_Impact", "Venoshock", "Round", "Incinerate", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(111, "Rhyhorn", PokemonData.Type.GROUND, PokemonData.Type.ROCK, "Lightning-rod", "Rock-head", "Reckless",
    50f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1f, 115f,
    69, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Spikes", "Strong, but not too bright, this Pokémon canshatter even a skyscraper with its charging Tackles.",
    80, 85, 95, 30, 30, 25, 0, Color.clear,
    new int[] { 1, 1, 8, 12, 19, 23, 30, 34, 41, 45, 52, 56, 63, 67},
    new string[]
    {
         "Horn Attack", "Tail Whip", "Stomp", "Fury Attack", "Scary Face", "Rock Blast", "Bulldoze", "Chip Away", "Take Down", "Drill Run", "Stone Edge", "Earthquake", "Horn Drill", "Megahorn",
    },
    new string[]
    {
         "Swords_Dance", "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Payback", "Rock_Polish", "Poison_Jab", "Stone_Edge", "Round", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {112}, new string[] {"Level,42"}),


new PokemonData(112, "Rhydon", PokemonData.Type.GROUND, PokemonData.Type.ROCK, "Lightning-rod", "Rock-head", "Reckless",
    50f, 60, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1.9f, 120f,
    170, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Drill", "Protected by an armor-like hide, it is capable ofliving in molten lava of 3,600 degrees Fahrenheit.",
    105, 130, 120, 45, 45, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 19, 30, 34, 41, 42, 47, 56, 62, 71},
    new string[]
    {
         "Stomp", "Fury Attack", "Tail Whip", "Megahorn", "Scary Face", "Bulldoze", "Chip Away", "Take Down", "Hammer Arm", "Drill Run", "Stone Edge", "Earthquake", "Horn Drill",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Payback", "Fling", "Rock_Polish", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(113, "Chansey", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Natural-cure", "Serene-grace", "Healer",
    0f, 30, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.1f, 34.6f,
    395, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
    "Egg", "It is said to deliver happiness. Being compassionate, it shares its eggswith injured people.",
    250, 5, 5, 35, 105, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 12, 16, 20, 23, 27, 31, 34, 38, 42, 46, 50},
    new string[]
    {
         "Pound", "Double-Edge", "Growl", "Defense Curl", "Refresh", "Double Slap", "Soft-Boiled", "Bestow", "Minimize", "Take Down", "Sing", "Fling", "Heal Pulse", "Egg Bomb", "Light Screen", "Healing Wish",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Calm_Mind", "Fling", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(114, "Tangela", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Leaf-guard", "Regenerator",
    50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1f, 35f,
    87, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Vine", "Many writhing vines cover it, so its true identityremains unknown. The blue vines grow its wholelife long.",
    65, 55, 115, 100, 40, 60, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 14, 17, 20, 23, 27, 30, 33, 36, 38, 41, 44, 46, 48, 50},
    new string[]
    {
         "Constrict", "Ingrain", "Sleep Powder", "Vine Whip", "Absorb", "Poison Powder", "Bind", "Growth", "Mega Drain", "Knock Off", "Stun Spore", "Natural Gift", "Giga Drain", "Ancient Power", "Slam", "Tickle", "Wring Out", "Grassy Terrain", "Power Whip",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(115, "Kangaskhan", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Early-bird", "Scrappy", "Inner-focus",
    0f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.2f, 80f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Parent", "It raises its offspring in its belly pouch. It lets thebaby out to play only when it feels safe.",
    105, 95, 80, 40, 80, 90, 0, Color.clear,
    new int[] { 1, 1, 7, 10, 13, 19, 22, 25, 31, 34, 37, 43, 46, 49, 50},
    new string[]
    {
         "Comet Punch", "Leer", "Fake Out", "Tail Whip", "Bite", "Double Hit", "Rage", "Mega Punch", "Chip Away", "Dizzy Punch", "Crunch", "Endure", "Outrage", "Sucker Punch", "Reversal",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Round", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(116, "Horsea", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Sniper", "Damp",
    50f, 225, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 8f,
    59, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Dragon", "Known to shoot down flying bugs with precisionblasts of ink from the surface of the water.",
    30, 40, 70, 70, 25, 60, 0, Color.clear,
    new int[] { 1, 4, 8, 11, 14, 18, 23, 26, 30, 35, 38, 42},
    new string[]
    {
         "Water Gun", "Smokescreen", "Leer", "Bubble", "Focus Energy", "Bubble Beam", "Agility", "Twister", "Brine", "Hydro Pump", "Dragon Dance", "Dragon Pulse",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Flash_Cannon", "Round", "Scald", "Confide"
    },
    new int[] {117}, new string[] {"Level,32"}),


new PokemonData(117, "Seadra", PokemonData.Type.WATER, PokemonData.Type.NONE, "Poison-point", "Sniper", "Damp",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 25f,
    154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Dragon", "Its body bristles with sharp spikes. Carelessly tryingto touch it could cause fainting from the spikes.",
    55, 65, 95, 95, 45, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 18, 23, 30, 40, 48, 57},
    new string[]
    {
         "Leer", "Smokescreen", "Bubble", "Bubble Beam", "Agility", "Brine", "Hydro Pump", "Dragon Dance", "Dragon Pulse",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Giga_Impact", "Flash_Cannon", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(118, "Goldeen", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Water-veil", "Lightning-rod",
    50f, 225, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 0.6f, 15f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Goldfish", "It swims at a steady 5 knots. If it senses danger,it will strike back with its sharp horn.",
    45, 67, 60, 35, 50, 63, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 11, 17, 21, 27, 31, 37, 41, 47, 50, 57},
    new string[]
    {
         "Tail Whip", "Peck", "Water Sport", "Supersonic", "Horn Attack", "Water Pulse", "Flail", "Aqua Ring", "Fury Attack", "Waterfall", "Horn Drill", "Agility", "Soak", "Megahorn",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Poison_Jab", "Round", "Scald", "Confide"
    },
    new int[] {119}, new string[] {"Level,33"}),


new PokemonData(119, "Seaking", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Water-veil", "Lightning-rod",
    50f, 60, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 1.3f, 39f,
    158, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Goldfish", "In the autumn spawning season, they can be seenswimming powerfully up rivers and creeks.",
    80, 92, 65, 65, 80, 68, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 11, 17, 21, 27, 31, 40, 47, 56, 63},
    new string[]
    {
         "Tail Whip", "Supersonic", "Megahorn", "Poison Jab", "Horn Attack", "Water Pulse", "Flail", "Aqua Ring", "Fury Attack", "Waterfall", "Horn Drill", "Agility", "Soak",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Poison_Jab", "Giga_Impact", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(120, "Staryu", PokemonData.Type.WATER, PokemonData.Type.NONE, "Illuminate", "Natural-cure", "Analytic",
    112.5f, 225, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.8f, 34.5f,
    68, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Star Shape", "Even if its body is torn, it can regenerate as long asthe glowing central core remains intact.",
    30, 45, 55, 70, 55, 85, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 12, 15, 18, 22, 25, 30, 33, 36, 40, 43, 48, 52},
    new string[]
    {
         "Tackle", "Harden", "Water Gun", "Rapid Spin", "Recover", "Camouflage", "Swift", "Bubble Beam", "Minimize", "Gyro Ball", "Light Screen", "Brine", "Reflect Type", "Power Gem", "Cosmic Power", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Hail", "Facade", "Gyro_Ball", "Flash_Cannon", "Round", "Scald", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(121, "Starmie", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Illuminate", "Natural-cure", "Analytic",
    112.5f, 60, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.1f, 80f,
    182, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
    "Mysterious", "Its central core glows with the seven colors of therainbow. Some people value the core as a gem.",
    60, 75, 85, 100, 85, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 22},
    new string[]
    {
         "Water Gun", "Hydro Pump", "Recover", "Swift", "Rapid Spin", "Confuse Ray",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Hail", "Facade", "Gyro_Ball", "Giga_Impact", "Flash_Cannon", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Scald", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(122, "Mr-mime", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Soundproof", "Filter", "Technician",
    50f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.3f, 54.5f,
    161, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PINK, 70,
    "Barrier", "Emanations from its fingertips solidify the air intoinvisible walls that repel even harsh attacks.",
    40, 45, 65, 100, 120, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 4, 8, 11, 15, 15, 18, 22, 22, 25, 29, 32, 36, 39, 43, 46, 50},
    new string[]
    {
         "Confusion", "Barrier", "Magical Leaf", "Power Swap", "Guard Swap", "Wide Guard", "Quick Guard", "Misty Terrain", "Copycat", "Meditate", "Double Slap", "Mimic", "Psywave", "Encore", "Light Screen", "Reflect", "Psybeam", "Substitute", "Recycle", "Trick", "Psychic", "Role Play", "Baton Pass", "Safeguard",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Brick_Break", "Aerial_Ace", "Calm_Mind", "Payback", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide", "Dazzling_Gleam", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(123, "Scyther", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", "Technician", "Steadfast",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.5f, 56f,
    100, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Mantis", "It tears and shreds prey with its wickedly sharpscythes. It very rarely spreads its wings to fly.",
    70, 110, 80, 55, 80, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 50, 57, 61},
    new string[]
    {
         "Leer", "Quick Attack", "Vacuum Wave", "Focus Energy", "Pursuit", "False Swipe", "Agility", "Wing Attack", "Fury Cutter", "Slash", "Razor Wind", "Double Team", "X-Scissor", "Night Slash", "Double Hit", "Air Slash", "Swords Dance", "Feint",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Toxic", "Double_Team", "Light_Screen", "Rest", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Roost", "U_turn", "X_Scissor", "Giga_Impact", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {124}, new string[] {"Level,30"}),


new PokemonData(124, "Jynx", PokemonData.Type.ICE, PokemonData.Type.PSYCHIC, "Oblivious", "Forewarn", "Dry-skin",
    0f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 40.6f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Human Shape", "It wiggles its hips as it walks. It cancause people to dance in unison with it.",
    65, 50, 35, 115, 95, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 8, 15, 18, 21, 25, 28, 33, 39, 44, 49, 55, 60},
    new string[]
    {
         "Pound", "Lick", "Powder Snow", "Draining Kiss", "Lovely Kiss", "Double Slap", "Ice Punch", "Heart Stamp", "Mean Look", "Fake Tears", "Wake-Up Slap", "Avalanche", "Body Slam", "Wring Out", "Perish Song", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Hail", "Torment", "Facade", "Taunt", "Brick_Break", "Calm_Mind", "Payback", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Frost_Breath", "Confide", "Power_Up_Punch"
    },
    new int[] {125}, new string[] {"Level,30"}),


new PokemonData(125, "Electabuzz", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Vital-spirit",
    75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.1f, 30f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Electric", "Electricity runs across the surface of its body. In darkness, its entire body glows a whitish blue.",
    65, 83, 57, 95, 85, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 12, 15, 19, 22, 26, 29, 36, 42, 55},
    new string[]
    {
         "Leer", "Thunder Shock", "Quick Attack", "Low Kick", "Swift", "Shock Wave", "Thunder Wave", "Electro Ball", "Light Screen", "Thunder Punch", "Discharge", "Screech", "Thunder",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Brick_Break", "Fling", "Focus_Blast", "Giga_Impact", "Charge_Beam", "Low_Sweep", "Round", "Volt_Switch", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {126}, new string[] {"Level,30"}),


new PokemonData(126, "Magmar", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flame-body", null, "Vital-spirit",
    75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.3f, 44.5f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Spitfire", "Found near the mouth of a volcano. This fire-breather’s body temperature isnearly 2,200 degrees Fahrenheit.",
    65, 95, 57, 100, 85, 93, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 12, 15, 19, 22, 26, 29, 36, 42, 55},
    new string[]
    {
         "Leer", "Ember", "Smog", "Smokescreen", "Feint Attack", "Fire Spin", "Clear Smog", "Flame Burst", "Confuse Ray", "Fire Punch", "Lava Plume", "Sunny Day", "Fire Blast",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Brick_Break", "Overheat", "Fling", "Focus_Blast", "Giga_Impact", "Flame_Charge", "Low_Sweep", "Round", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(127, "Pinsir", PokemonData.Type.BUG, PokemonData.Type.NONE, "Hyper-cutter", "Mold-breaker", "Moxie",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.5f, 55f,
    175, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Stag Beetle", "It grips prey with its pincers until the prey is tornin half. What it can’t tear, it tosses far.",
    65, 125, 100, 55, 70, 85, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 11, 15, 18, 22, 26, 29, 33, 36, 40, 43, 47},
    new string[]
    {
         "Vice Grip", "Focus Energy", "Bind", "Seismic Toss", "Harden", "Revenge", "Brick Break", "Vital Throw", "Submission", "X-Scissor", "Storm Throw", "Thrash", "Swords Dance", "Superpower", "Guillotine",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Fling", "X_Scissor", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Smack_Down", "Round", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(128, "Tauros", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Intimidate", "Anger-point", "Sheer-force",
    100f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 88.4f,
    172, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Wild Bull", "After heightening its will to fight by whipping itselfwith its three tails, it charges at full speed.",
    75, 100, 95, 40, 70, 110, 0, Color.clear,
    new int[] { 1, 3, 5, 8, 11, 15, 19, 24, 29, 35, 41, 48, 50, 63},
    new string[]
    {
         "Tackle", "Tail Whip", "Rage", "Horn Attack", "Scary Face", "Pursuit", "Rest", "Payback", "Work Up", "Zen Headbutt", "Take Down", "Swagger", "Thrash", "Giga Impact",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Payback", "Giga_Impact", "Stone_Edge", "Round", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Confide"
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
    new int[] { 1, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47},
    new string[]
    {
         "Thrash", "Bite", "Dragon Rage", "Leer", "Twister", "Ice Fang", "Aqua Tail", "Rain Dance", "Hydro Pump", "Dragon Dance", "Hyper Beam",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Payback", "Dark_Pulse", "Giga_Impact", "Stone_Edge", "Round", "Scald", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(131, "Lapras", PokemonData.Type.WATER, PokemonData.Type.ICE, "Water-absorb", "Shell-armor", "Hydration",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.5f, 220f,
    187, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Transport", "They have gentle hearts. Because they rarelyfight, many have been caught. Their numberhas dwindled.",
    130, 85, 80, 85, 95, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 7, 10, 14, 18, 22, 27, 32, 37, 43, 47, 50},
    new string[]
    {
         "Growl", "Sing", "Water Gun", "Mist", "Confuse Ray", "Ice Shard", "Water Pulse", "Body Slam", "Rain Dance", "Perish Song", "Ice Beam", "Brine", "Safeguard", "Hydro Pump", "Sheer Cold",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Waterfall", "Dream_Eater", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Giga_Impact", "Round", "Echoed_Voice", "Bulldoze", "Frost_Breath", "Confide"
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
    new int[] { 1, 1, 1, 1, 5, 9, 10, 13, 17, 20, 23, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Tail Whip", "Growl", "Helping Hand", "Sand Attack", "Baby-Doll Eyes", "Swift", "Quick Attack", "Bite", "Refresh", "Covet", "Take Down", "Charm", "Baton Pass", "Double-Edge", "Last Resort", "Trump Card",
    },
    new string[]
    {
         "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(134, "Vaporeon", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", null, "Hydration",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 29f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Bubble Jet", "It prefers beautiful shores. With cells similar towater molecules, it could melt in water.",
    130, 65, 60, 110, 95, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 20, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Water Gun", "Quick Attack", "Water Pulse", "Aurora Beam", "Aqua Ring", "Acid Armor", "Haze", "Muddy Water", "Last Resort", "Hydro Pump",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Giga_Impact", "Round", "Echoed_Voice", "Scald", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(135, "Jolteon", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Volt-absorb", null, "Quick-feet",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 24.5f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Lightning", "Every hair on its body starts to stand sharply onend if it becomes charged with electricity.",
    65, 65, 60, 110, 95, 130, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 20, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Thunder Shock", "Quick Attack", "Double Kick", "Thunder Fang", "Pin Missile", "Agility", "Thunder Wave", "Discharge", "Last Resort", "Thunder",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Giga_Impact", "Charge_Beam", "Round", "Echoed_Voice", "Retaliate", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(136, "Flareon", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flash-fire", null, "Guts",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 25f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Flame", "It has a flame sac in its body. Its body temperaturetops 1,650 degrees Fahrenheit before battle.",
    65, 130, 60, 95, 110, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 20, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Ember", "Quick Attack", "Bite", "Fire Fang", "Fire Spin", "Scary Face", "Smog", "Lava Plume", "Last Resort", "Flare Blitz",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Overheat", "Giga_Impact", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(137, "Porygon", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Trace", "Download", "Analytic",
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.8f, 36.5f,
    79, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Virtual", "A man-made Pokémon that came aboutas a result of research. It is programmedwith only basic motions.",
    65, 60, 70, 85, 75, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 7, 12, 18, 23, 29, 34, 40, 45, 50, 56, 62},
    new string[]
    {
         "Tackle", "Sharpen", "Conversion", "Conversion 2", "Psybeam", "Agility", "Recover", "Magnet Rise", "Signal Beam", "Recycle", "Discharge", "Lock-On", "Tri Attack", "Magic Coat", "Zap Cannon",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Giga_Impact", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(138, "Omanyte", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Shell-armor", "Weak-armor",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 7.5f,
    71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Spiral", "A prehistoric Pokémon that lived in the primordialsea, it swims by twisting its 10 tentacles about.",
    35, 40, 100, 90, 55, 35, 0, Color.clear,
    new int[] { 1, 1, 7, 10, 16, 19, 25, 28, 34, 37, 43, 46, 50, 55},
    new string[]
    {
         "Withdraw", "Constrict", "Bite", "Water Gun", "Rollout", "Leer", "Mud Shot", "Brine", "Protect", "Ancient Power", "Tickle", "Rock Blast", "Shell Smash", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Gyro_Ball", "Rock_Polish", "Smack_Down", "Round", "Scald", "Confide"
    },
    new int[] {139}, new string[] {"Level,40"}),


new PokemonData(139, "Omastar", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Shell-armor", "Weak-armor",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1f, 35f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Spiral", "Its tentacles are highly developed as if they arehands and feet. As soon as it ensnares prey,it bites.",
    70, 60, 125, 115, 70, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 16, 19, 25, 28, 34, 37, 40, 48, 56, 67},
    new string[]
    {
         "Bite", "Hydro Pump", "Constrict", "Rollout", "Leer", "Mud Shot", "Brine", "Protect", "Ancient Power", "Spike Cannon", "Tickle", "Rock Blast", "Shell Smash",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Gyro_Ball", "Rock_Polish", "Giga_Impact", "Stone_Edge", "Smack_Down", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(140, "Kabuto", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Battle-armor", "Weak-armor",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 11.5f,
    71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Shellfish", "It is thought to have inhabited beaches 300 millionyears ago. It is protected by a stiff shell.",
    30, 80, 90, 55, 45, 55, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 46, 50},
    new string[]
    {
         "Scratch", "Harden", "Absorb", "Leer", "Mud Shot", "Sand Attack", "Endure", "Aqua Jet", "Mega Drain", "Metal Sound", "Ancient Power", "Wring Out",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Rock_Polish", "Hone_Claws", "Smack_Down", "Round", "Scald", "Confide"
    },
    new int[] {141}, new string[] {"Level,40"}),


new PokemonData(141, "Kabutops", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Swift-swim", "Battle-armor", "Weak-armor",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.3f, 40.5f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Shellfish", "In the water, it tucks in its limbs to become morecompact, then it wiggles its shell to swim fast.",
    60, 115, 105, 65, 70, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 6, 16, 21, 26, 36, 40, 45, 54, 63},
    new string[]
    {
         "Scratch", "Leer", "Harden", "Feint", "Night Slash", "Absorb", "Mud Shot", "Sand Attack", "Endure", "Mega Drain", "Slash", "Metal Sound", "Ancient Power", "Wring Out",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Rock_Polish", "X_Scissor", "Giga_Impact", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(142, "Aerodactyl", PokemonData.Type.ROCK, PokemonData.Type.FLYING, "Rock-head", "Pressure", "Unnerve",
    87.5f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.8f, 59f,
    180, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
    "Fossil", "It was regenerated from a dinosaur’s geneticmatter that was found in amber. It flies withhigh-pitched cries.",
    80, 105, 65, 60, 75, 130, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 9, 17, 25, 33, 41, 65, 73, 81},
    new string[]
    {
         "Wing Attack", "Bite", "Supersonic", "Scary Face", "Thunder Fang", "Ice Fang", "Fire Fang", "Iron Head", "Roar", "Agility", "Ancient Power", "Crunch", "Take Down", "Hyper Beam", "Rock Slide", "Giga Impact",
    },
    new string[]
    {
         "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Roost", "Payback", "Rock_Polish", "Giga_Impact", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Sky_Drop", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(143, "Snorlax", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Immunity", "Thick-fat", "Gluttony",
    87.5f, 25, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.1f, 460f,
    189, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Sleeping", "It is not satisfied unless it eats over 880 pounds offood every day. When it is done eating, it goespromptly to sleep.",
    160, 110, 65, 65, 110, 30, 0, Color.clear,
    new int[] { 1, 4, 9, 12, 17, 20, 25, 28, 28, 33, 36, 41, 44, 49, 50, 57},
    new string[]
    {
         "Tackle", "Defense Curl", "Amnesia", "Lick", "Chip Away", "Yawn", "Body Slam", "Rest", "Snore", "Sleep Talk", "Rollout", "Block", "Belly Drum", "Crunch", "Heavy Slam", "Giga Impact",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "Focus_Blast", "Giga_Impact", "Smack_Down", "Round", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(144, "Articuno", PokemonData.Type.ICE, PokemonData.Type.FLYING, "Pressure", null, "Snow-cloak",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.7f, 55.4f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.BLUE, 35,
    "Freeze", "A legendary bird Pokémon. It can create blizzardsby freezing moisture in the air.",
    90, 85, 100, 95, 125, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 8, 22, 29, 36, 43, 50, 57, 71, 85},
    new string[]
    {
         "Gust", "Powder Snow", "Sheer Cold", "Tailwind", "Hurricane", "Mist", "Mind Reader", "Ancient Power", "Agility", "Ice Beam", "Reflect", "Hail", "Blizzard", "Roost",
    },
    new string[]
    {
         "Fly", "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Reflect", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Aerial_Ace", "Roost", "U_turn", "Giga_Impact", "Round", "Sky_Drop", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(145, "Zapdos", PokemonData.Type.ELECTRIC, PokemonData.Type.FLYING, "Pressure", null, "Static",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.6f, 52.6f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
    "Electric", "A legendary bird Pokémon that is said toappear from clouds while dropping enormouslightning bolts.",
    90, 90, 85, 125, 90, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 8, 29, 36, 43, 50, 57, 64, 78},
    new string[]
    {
         "Peck", "Drill Peck", "Zap Cannon", "Roost", "Thunder Wave", "Ancient Power", "Charge", "Agility", "Discharge", "Rain Dance", "Light Screen", "Thunder",
    },
    new string[]
    {
         "Fly", "Roar", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Aerial_Ace", "Roost", "U_turn", "Giga_Impact", "Charge_Beam", "Round", "Sky_Drop", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(146, "Moltres", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Pressure", null, "Flame-body",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 60f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
    "Flame", "It is said to be the legendary bird Pokémon of fire. Every flap of its wings creates a dazzling flareof flames.",
    90, 100, 90, 125, 85, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 8, 15, 29, 36, 43, 50, 57, 71, 85},
    new string[]
    {
         "Wing Attack", "Ember", "Sky Attack", "Heat Wave", "Hurricane", "Fire Spin", "Agility", "Ancient Power", "Flamethrower", "Safeguard", "Air Slash", "Sunny Day", "Solar Beam", "Roost",
    },
    new string[]
    {
         "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Overheat", "Aerial_Ace", "Roost", "U_turn", "Giga_Impact", "Flame_Charge", "Round", "Sky_Drop", "Incinerate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(147, "Dratini", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Shed-skin", null, "Marvel-scale",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.8f, 3.3f,
    60, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Dragon", "It is called the “Mirage Pokémon” because so fewhave seen it. Its shed skin has been found.",
    41, 64, 45, 50, 50, 50, 0, Color.clear,
    new int[] { 1, 1, 5, 11, 15, 21, 25, 31, 35, 41, 45, 51, 55, 61},
    new string[]
    {
         "Wrap", "Leer", "Thunder Wave", "Twister", "Dragon Rage", "Slam", "Agility", "Dragon Tail", "Aqua Tail", "Dragon Rush", "Safeguard", "Dragon Dance", "Outrage", "Hyper Beam",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Fire_Blast", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Hail", "Facade", "Round", "Incinerate", "Dragon_Tail", "Confide"
    },
    new int[] {148}, new string[] {"Level,30"}),


new PokemonData(148, "Dragonair", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Shed-skin", null, "Marvel-scale",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 4f, 16.5f,
    147, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Dragon", "Its crystalline orbs appear to give this Pokémonthe power to freely control the weather.",
    61, 84, 65, 70, 70, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 15, 21, 33, 39, 47, 53, 67, 75},
    new string[]
    {
         "Wrap", "Leer", "Thunder Wave", "Twister", "Dragon Rage", "Slam", "Dragon Tail", "Aqua Tail", "Dragon Rush", "Safeguard", "Outrage", "Hyper Beam",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Fire_Blast", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Hail", "Facade", "Round", "Incinerate", "Dragon_Tail", "Confide"
    },
    new int[] {149}, new string[] {"Level,55"}),


new PokemonData(149, "Dragonite", PokemonData.Type.DRAGON, PokemonData.Type.FLYING, "Inner-focus", null, "Multiscale",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 2.2f, 210f,
    270, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 35,
    "Dragon", "It can fly in spite of its big and bulky physique. It circles the globe in just 16 hours.",
    91, 134, 95, 100, 100, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 15, 21, 33, 39, 47, 53, 55, 67, 75},
    new string[]
    {
         "Fire Punch", "Thunder Punch", "Wrap", "Leer", "Thunder Wave", "Twister", "Roost", "Hurricane", "Dragon Rage", "Slam", "Dragon Tail", "Aqua Tail", "Dragon Rush", "Safeguard", "Wing Attack", "Outrage", "Hyper Beam",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Fire_Blast", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Roost", "Fling", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Hone_Claws", "Round", "Sky_Drop", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(150, "Mewtwo", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Pressure", null, "Unnerve",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 122f,
    306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.PURPLE, 0,
    "Genetic", "It was created by a scientist after years of horrificgene-splicing and DNA-engineering experiments.",
    106, 110, 90, 154, 90, 130, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 15, 22, 29, 36, 43, 43, 50, 57, 64, 70, 79, 86, 93, 100},
    new string[]
    {
         "Disable", "Confusion", "Safeguard", "Swift", "Future Sight", "Psych Up", "Miracle Eye", "Psycho Cut", "Power Swap", "Guard Swap", "Recover", "Psychic", "Barrier", "Aura Sphere", "Amnesia", "Mist", "Me First", "Psystrike",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Calm_Mind", "Embargo", "Fling", "Poison_Jab", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Trick_Room", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Psyshock", "Low_Sweep", "Round", "Incinerate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(151, "Mew", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", null, null,
    112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.4f, 4f,
    270, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 100,
    "New Species", "Because it can use all kinds of moves, manyscientists believe Mew to be the ancestorof Pokémon.",
    100, 100, 100, 100, 100, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100},
    new string[]
    {
         "Pound", "Transform", "Reflect Type", "Mega Punch", "Metronome", "Psychic", "Barrier", "Ancient Power", "Amnesia", "Me First", "Baton Pass", "Nasty Plot", "Aura Sphere",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Fly", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Waterfall", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Torment", "Will_O_Wisp", "Facade", "Nature_Power", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Calm_Mind", "Roost", "Gyro_Ball", "U_turn", "Payback", "Embargo", "Fling", "Rock_Polish", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Trick_Room", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Psyshock", "Venoshock", "Smack_Down", "Sludge_Wave", "Flame_Charge", "Low_Sweep", "Round", "Echoed_Voice", "Scald", "Sky_Drop", "Incinerate", "Quash", "Acrobatics", "Retaliate", "Volt_Switch", "Struggle_Bug", "Bulldoze", "Frost_Breath", "Dragon_Tail", "Wild_Charge", "Snarl", "Confide", "Dazzling_Gleam", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(152, "Chikorita", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Leaf-guard",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 6.4f,
    64, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Leaf", "A sweet aroma gently wafts from the leaf on itshead. It is docile and loves to soak up sun rays.",
    45, 49, 65, 49, 65, 45, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 12, 17, 20, 23, 28, 31, 34, 39, 42, 45},
    new string[]
    {
         "Tackle", "Growl", "Razor Leaf", "Poison Powder", "Synthesis", "Reflect", "Magical Leaf", "Natural Gift", "Sweet Scent", "Light Screen", "Body Slam", "Safeguard", "Aromatherapy", "Solar Beam",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {153}, new string[] {"Level,16"}),


new PokemonData(153, "Bayleef", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Leaf-guard",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 15.8f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Leaf", "A spicy aroma emanates from around its neck. The aroma acts as a stimulant to restore health.",
    60, 62, 80, 63, 80, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 12, 18, 22, 26, 32, 40, 46, 50},
    new string[]
    {
         "Tackle", "Growl", "Razor Leaf", "Poison Powder", "Synthesis", "Reflect", "Magical Leaf", "Natural Gift", "Sweet Scent", "Body Slam", "Safeguard", "Aromatherapy",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {154}, new string[] {"Level,32"}),


new PokemonData(154, "Meganium", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Leaf-guard",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1.8f, 100.5f,
    236, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 2, 0, PokemonData.PokedexColor.GREEN, 70,
    "Herb", "The aroma that rises from its petals contains asubstance that calms aggressive feelings.",
    80, 82, 100, 83, 100, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 12, 18, 22, 26, 34, 40, 46, 54, 60},
    new string[]
    {
         "Tackle", "Growl", "Razor Leaf", "Poison Powder", "Petal Blizzard", "Synthesis", "Reflect", "Magical Leaf", "Natural Gift", "Sweet Scent", "Light Screen", "Body Slam", "Safeguard", "Aromatherapy",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Echoed_Voice", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(155, "Cyndaquil", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Flash-fire",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 7.9f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Fire Mouse", "It is timid and always curls itself up in a ball. If attacked, it flares up its back for protection.",
    39, 52, 43, 60, 50, 65, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 13, 19, 22, 28, 31, 37, 40, 46, 49, 55, 58},
    new string[]
    {
         "Tackle", "Leer", "Smokescreen", "Ember", "Quick Attack", "Flame Wheel", "Defense Curl", "Flame Charge", "Swift", "Lava Plume", "Flamethrower", "Inferno", "Rollout", "Double-Edge", "Eruption",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Will_O_Wisp", "Facade", "Nature_Power", "Overheat", "Aerial_Ace", "Flame_Charge", "Round", "Incinerate", "Wild_Charge", "Confide"
    },
    new int[] {156}, new string[] {"Level,14"}),


new PokemonData(156, "Quilava", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Flash-fire",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 19f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Volcano", "Before battle, it turns its back on its opponent todemonstrate how ferociously its fire blazes.",
    58, 64, 58, 80, 65, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 13, 20, 31, 35, 42, 46, 53, 57, 64, 68},
    new string[]
    {
         "Tackle", "Leer", "Smokescreen", "Ember", "Quick Attack", "Flame Wheel", "Swift", "Flame Charge", "Lava Plume", "Flamethrower", "Inferno", "Rollout", "Double-Edge", "Eruption",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Brick_Break", "Overheat", "Aerial_Ace", "Flame_Charge", "Round", "Incinerate", "Wild_Charge", "Confide"
    },
    new int[] {157}, new string[] {"Level,36"}),


new PokemonData(157, "Typhlosion", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Flash-fire",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.7f, 79.5f,
    240, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Volcano", "If its rage peaks, it becomes so hot that anythingthat touches it will instantly go up in flames.",
    78, 84, 78, 109, 85, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 13, 20, 31, 35, 43, 56, 61},
    new string[]
    {
         "Tackle", "Double-Edge", "Ember", "Smokescreen", "Eruption", "Quick Attack", "Flame Wheel", "Swift", "Flame Charge", "Lava Plume", "Inferno", "Rollout",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Gyro_Ball", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Flame_Charge", "Round", "Incinerate", "Bulldoze", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(158, "Totodile", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Sheer-force",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 9.5f,
    63, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Big Jaw", "It is small but rough and tough. It won’t hesitate totake a bite out of anything that moves.",
    50, 65, 64, 44, 48, 43, 0, Color.clear,
    new int[] { 1, 1, 6, 8, 13, 15, 20, 22, 27, 29, 34, 36, 41, 43, 48, 50},
    new string[]
    {
         "Scratch", "Leer", "Water Gun", "Rage", "Bite", "Scary Face", "Ice Fang", "Flail", "Crunch", "Chip Away", "Slash", "Screech", "Thrash", "Aqua Tail", "Superpower", "Hydro Pump",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Fling", "Shadow_Claw", "Hone_Claws", "Round", "Scald", "Confide", "Power_Up_Punch"
    },
    new int[] {159}, new string[] {"Level,18"}),


new PokemonData(159, "Croconaw", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Sheer-force",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.1f, 25f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Big Jaw", "If it loses a fang, a new one grows back in itsplace. There are always 48 fangs lining its mouth.",
    65, 80, 80, 59, 63, 58, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 13, 15, 21, 24, 30, 33, 39, 42, 48, 51, 57},
    new string[]
    {
         "Scratch", "Leer", "Water Gun", "Rage", "Bite", "Scary Face", "Ice Fang", "Flail", "Crunch", "Chip Away", "Slash", "Screech", "Thrash", "Aqua Tail", "Superpower",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Fling", "Shadow_Claw", "Hone_Claws", "Round", "Scald", "Confide", "Power_Up_Punch"
    },
    new int[] {160}, new string[] {"Level,30"}),


new PokemonData(160, "Feraligatr", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Sheer-force",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.3f, 88.8f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Big Jaw", "It usually moves slowly, but it goes at blindingspeed when it attacks and bites prey.",
    85, 105, 100, 79, 83, 78, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 15, 21, 24, 30, 32, 37, 45, 58, 63, 71},
    new string[]
    {
         "Scratch", "Leer", "Water Gun", "Rage", "Bite", "Scary Face", "Ice Fang", "Flail", "Agility", "Crunch", "Chip Away", "Slash", "Thrash", "Aqua Tail", "Superpower",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Scald", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(161, "Sentret", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Keen-eye", "Frisk",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 6f,
    43, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Scout", "When acting as a lookout, it warns others of dangerby screeching and hitting the ground with its tail.",
    35, 46, 34, 35, 45, 20, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 13, 16, 19, 25, 28, 31, 36, 39, 42, 47},
    new string[]
    {
         "Scratch", "Foresight", "Defense Curl", "Quick Attack", "Fury Swipes", "Helping Hand", "Follow Me", "Slam", "Rest", "Sucker Punch", "Amnesia", "Baton Pass", "Me First", "Hyper Voice",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Surf", "Ice_Beam", "Solar_Beam", "Thunderbolt", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Brick_Break", "U_turn", "Fling", "Shadow_Claw", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Round", "Echoed_Voice", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {162}, new string[] {"Level,15"}),


new PokemonData(162, "Furret", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Keen-eye", "Frisk",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.8f, 32.5f,
    145, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Long Body", "The mother puts its offspring to sleep by curling uparound them. It corners foes with speed.",
    85, 76, 64, 45, 55, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 13, 17, 21, 28, 32, 36, 42, 46, 50, 56},
    new string[]
    {
         "Scratch", "Quick Attack", "Foresight", "Defense Curl", "Fury Swipes", "Helping Hand", "Follow Me", "Slam", "Rest", "Sucker Punch", "Amnesia", "Baton Pass", "Me First", "Hyper Voice",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "U_turn", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Round", "Echoed_Voice", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(163, "Hoothoot", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Insomnia", "Keen-eye", "Tinted-lens",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.7f, 21.2f,
    52, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Owl", "It has a perfect sense of time. Whatever happens,it keeps rhythm by precisely tilting its head in time.",
    60, 30, 30, 36, 56, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57},
    new string[]
    {
         "Tackle", "Growl", "Foresight", "Hypnosis", "Peck", "Uproar", "Reflect", "Confusion", "Echoed Voice", "Take Down", "Air Slash", "Zen Headbutt", "Synchronoise", "Extrasensory", "Psycho Shift", "Roost", "Dream Eater",
    },
    new string[]
    {
         "Fly", "Toxic", "Psychic", "Double_Team", "Reflect", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {164}, new string[] {"Level,20"}),


new PokemonData(164, "Noctowl", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Insomnia", "Keen-eye", "Tinted-lens",
    50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.6f, 40.8f,
    158, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Owl", "Its eyes are specially adapted. They concentrateeven faint light and enable it to see in the dark.",
    100, 50, 50, 86, 96, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 9, 13, 22, 27, 32, 37, 42, 47, 52, 57, 62},
    new string[]
    {
         "Tackle", "Growl", "Hypnosis", "Dream Eater", "Foresight", "Peck", "Uproar", "Confusion", "Echoed Voice", "Take Down", "Air Slash", "Zen Headbutt", "Synchronoise", "Extrasensory", "Psycho Shift", "Roost",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Reflect", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "Giga_Impact", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(165, "Ledyba", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", "Early-bird", "Rattled",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1f, 10.8f,
    53, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.RED, 70,
    "Five Star", "When the weather turns cold, lots of Ledyba gatherfrom everywhere to cluster and keep eachother warm.",
    40, 20, 30, 40, 80, 55, 0, Color.clear,
    new int[] { 1, 6, 9, 14, 14, 14, 17, 22, 25, 30, 33, 38, 41},
    new string[]
    {
         "Tackle", "Supersonic", "Comet Punch", "Light Screen", "Reflect", "Safeguard", "Mach Punch", "Baton Pass", "Silver Wind", "Agility", "Swift", "Double-Edge", "Bug Buzz",
    },
    new string[]
    {
         "Swords_Dance", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Brick_Break", "Aerial_Ace", "Roost", "U_turn", "Fling", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {166}, new string[] {"Level,18"}),


new PokemonData(166, "Ledian", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", "Early-bird", "Iron-fist",
    50f, 90, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.4f, 35.6f,
    137, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.RED, 70,
    "Five Star", "When the stars flicker in the night sky, it fluttersabout, scattering a glowing powder.",
    55, 35, 50, 55, 110, 85, 0, Color.clear,
    new int[] { 1, 1, 14, 14, 14, 17, 24, 29, 41, 48, 53},
    new string[]
    {
         "Comet Punch", "Supersonic", "Light Screen", "Reflect", "Safeguard", "Mach Punch", "Baton Pass", "Silver Wind", "Swift", "Double-Edge", "Bug Buzz",
    },
    new string[]
    {
         "Swords_Dance", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Roost", "U_turn", "Fling", "Focus_Blast", "Giga_Impact", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(167, "Spinarak", PokemonData.Type.BUG, PokemonData.Type.POISON, "Swarm", "Insomnia", "Sniper",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.5f, 8.5f,
    50, PokemonData.LevelingRate.FAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "String Spit", "It spins a web using fine--but durable--thread. It then waits patiently for prey to be trapped.",
    40, 60, 40, 40, 40, 30, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 19, 22, 26, 29, 33, 36, 40, 43, 47, 50},
    new string[]
    {
         "Poison Sting", "String Shot", "Scary Face", "Constrict", "Leech Life", "Night Shade", "Shadow Sneak", "Fury Swipes", "Sucker Punch", "Spider Web", "Agility", "Pin Missile", "Psychic", "Poison Jab", "Cross Poison", "Sticky Web",
    },
    new string[]
    {
         "Solar_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Poison_Jab", "X_Scissor", "Hone_Claws", "Venoshock", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {168}, new string[] {"Level,22"}),


new PokemonData(168, "Ariados", PokemonData.Type.BUG, PokemonData.Type.POISON, "Swarm", "Insomnia", "Sniper",
    50f, 90, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.1f, 33.5f,
    140, PokemonData.LevelingRate.FAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Long Leg", "It spins string not only from its rear but also fromits mouth. It’s hard to tell which end is which.",
    70, 90, 70, 60, 70, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 15, 19, 23, 32, 37, 41, 46, 50, 55, 58},
    new string[]
    {
         "Poison Sting", "String Shot", "Constrict", "Scary Face", "Bug Bite", "Fell Stinger", "Venom Drench", "Night Shade", "Shadow Sneak", "Fury Swipes", "Spider Web", "Agility", "Pin Missile", "Psychic", "Poison Jab", "Cross Poison", "Sticky Web",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Poison_Jab", "X_Scissor", "Giga_Impact", "Hone_Claws", "Venoshock", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(169, "Crobat", PokemonData.Type.POISON, PokemonData.Type.FLYING, "Inner-focus", null, "Infiltrator",
    50f, 90, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.8f, 75f,
    241, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.PURPLE, 70,
    "Bat", "It flies so silently through the dark on its four wingsthat it may not be noticed even when nearby.",
    85, 90, 80, 70, 80, 130, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 12, 15, 19, 24, 33, 38, 42, 47, 52},
    new string[]
    {
         "Supersonic", "Leech Life", "Astonish", "Cross Poison", "Bite", "Wing Attack", "Confuse Ray", "Swift", "Acrobatics", "Mean Look", "Poison Fang", "Haze", "Air Slash",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "Roost", "U_turn", "Payback", "Dark_Pulse", "X_Scissor", "Giga_Impact", "Venoshock", "Round", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(170, "Chinchou", PokemonData.Type.WATER, PokemonData.Type.ELECTRIC, "Volt-absorb", "Illuminate", "Water-absorb",
    50f, 190, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.5f, 12f,
    66, PokemonData.LevelingRate.SLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Angler", "On the dark ocean floor, its only means ofcommunication is its constantly flashing lights.",
    75, 38, 38, 56, 56, 67, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 12, 17, 20, 23, 28, 31, 34, 39, 42, 45, 47, 50},
    new string[]
    {
         "Supersonic", "Water Gun", "Thunder Wave", "Flail", "Bubble", "Confuse Ray", "Spark", "Take Down", "Electro Ball", "Bubble Beam", "Signal Beam", "Discharge", "Aqua Ring", "Hydro Pump", "Ion Deluge", "Charge",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Charge_Beam", "Round", "Scald", "Volt_Switch", "Wild_Charge", "Confide", "Dazzling_Gleam"
    },
    new int[] {171}, new string[] {"Level,27"}),


new PokemonData(171, "Lanturn", PokemonData.Type.WATER, PokemonData.Type.ELECTRIC, "Volt-absorb", "Illuminate", "Water-absorb",
    50f, 75, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 1.2f, 22.5f,
    161, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Light", "Lanturn’s light can shine up from great depths. It is nicknamed “The Deep-Sea Star. ",
    125, 58, 58, 76, 76, 67, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 12, 20, 23, 27, 27, 27, 30, 35, 40, 47, 52, 57, 60, 64},
    new string[]
    {
         "Supersonic", "Water Gun", "Thunder Wave", "Eerie Impulse", "Flail", "Bubble", "Spark", "Take Down", "Stockpile", "Spit Up", "Swallow", "Electro Ball", "Bubble Beam", "Signal Beam", "Discharge", "Aqua Ring", "Hydro Pump", "Ion Deluge", "Charge",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Giga_Impact", "Charge_Beam", "Round", "Scald", "Volt_Switch", "Wild_Charge", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(172, "Pichu", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Lightning-rod",
    50f, 190, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 2f,
    41, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Tiny Mouse", "It plays with others by touching tails and setting offsparks. This appears to be a test of courage.",
    20, 40, 15, 35, 35, 60, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 13, 18},
    new string[]
    {
         "Thunder Shock", "Charm", "Tail Whip", "Sweet Kiss", "Thunder Wave", "Nasty Plot",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Fling", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(173, "Cleffa", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Cute-charm", "Magic-guard", "Friend-guard",
    25f, 150, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 3f,
    44, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PINK, 140,
    "Star Shape", "Because of its unusual, starlike silhouette, peoplebelieve that it came here on a meteor.",
    50, 25, 28, 45, 55, 15, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16},
    new string[]
    {
         "Pound", "Charm", "Encore", "Sing", "Sweet Kiss", "Copycat", "Magical Leaf",
    },
    new string[]
    {
         "Flamethrower", "Solar_Beam", "Thunder_Wave", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Fling", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Incinerate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(174, "Igglybuff", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Cute-charm", "Competitive", "Friend-guard",
    25f, 170, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 1f,
    42, PokemonData.LevelingRate.FAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Balloon", "Instead of walking with its short legs, it movesaround by bouncing on its soft, tender body.",
    90, 30, 15, 40, 20, 15, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17},
    new string[]
    {
         "Sing", "Charm", "Defense Curl", "Pound", "Sweet Kiss", "Copycat",
    },
    new string[]
    {
         "Flamethrower", "Solar_Beam", "Thunder_Wave", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Fling", "Grass_Knot", "Round", "Echoed_Voice", "Incinerate", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(175, "Togepi", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Hustle", "Serene-grace", "Super-luck",
    87.5f, 190, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 1.5f,
    49, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.WHITE, 70,
    "Spike Ball", "The shell seems to be filled with joy. It is said thatit will share good luck when treated kindly.",
    35, 20, 65, 40, 65, 20, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53},
    new string[]
    {
         "Growl", "Charm", "Metronome", "Sweet Kiss", "Yawn", "Encore", "Follow Me", "Bestow", "Wish", "Ancient Power", "Safeguard", "Baton Pass", "Double-Edge", "Last Resort", "After You",
    },
    new string[]
    {
         "Flamethrower", "Solar_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Fling", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Incinerate", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(176, "Togetic", PokemonData.Type.FAIRY, PokemonData.Type.FLYING, "Hustle", "Serene-grace", "Super-luck",
    87.5f, 75, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.6f, 3.2f,
    142, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.WHITE, 70,
    "Happiness", "It grows dispirited if it is not with kind people. It can float in midair without moving its wings.",
    55, 40, 85, 80, 105, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 13, 14, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53},
    new string[]
    {
         "Growl", "Metronome", "Charm", "Magical Leaf", "Sweet Kiss", "Yawn", "Fairy Wind", "Encore", "Follow Me", "Bestow", "Wish", "Ancient Power", "Safeguard", "Baton Pass", "Double-Edge", "Last Resort", "After You",
    },
    new string[]
    {
         "Fly", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Roost", "Fling", "Giga_Impact", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(177, "Natu", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Synchronize", "Early-bird", "Magic-bounce",
    50f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.2f, 2f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Tiny Bird", "Because its wings aren’t yet fully grown, it hasto hop to get around. It is always staringat something.",
    40, 50, 45, 70, 45, 70, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 12, 17, 20, 23, 28, 33, 36, 39, 44, 47, 47, 50},
    new string[]
    {
         "Leer", "Peck", "Night Shade", "Teleport", "Lucky Chant", "Miracle Eye", "Me First", "Confuse Ray", "Wish", "Psycho Shift", "Future Sight", "Stored Power", "Ominous Wind", "Power Swap", "Guard Swap", "Psychic",
    },
    new string[]
    {
         "Solar_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Calm_Mind", "Roost", "U_turn", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {178}, new string[] {"Level,25"}),


new PokemonData(178, "Xatu", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Synchronize", "Early-bird", "Magic-bounce",
    50f, 75, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.5f, 15f,
    165, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Mystic", "Once it begins to meditate at sunrise, the entire daywill pass before it will move again.",
    65, 75, 70, 95, 70, 95, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 12, 17, 20, 23, 27, 30, 37, 42, 47, 54, 54, 59, 66},
    new string[]
    {
         "Leer", "Peck", "Night Shade", "Teleport", "Lucky Chant", "Miracle Eye", "Me First", "Confuse Ray", "Tailwind", "Wish", "Psycho Shift", "Future Sight", "Stored Power", "Power Swap", "Ominous Wind", "Guard Swap", "Psychic",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Solar_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Calm_Mind", "Roost", "U_turn", "Giga_Impact", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(179, "Mareep", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Plus",
    50f, 235, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 7.8f,
    56, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Wool", "Its fluffy coat swells to double when staticelectricity builds up. Touching it can be shocking.",
    55, 40, 40, 65, 45, 35, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43, 46},
    new string[]
    {
         "Tackle", "Growl", "Thunder Wave", "Thunder Shock", "Cotton Spore", "Charge", "Take Down", "Electro Ball", "Confuse Ray", "Power Gem", "Discharge", "Cotton Guard", "Signal Beam", "Light Screen", "Thunder",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Facade", "Charge_Beam", "Round", "Echoed_Voice", "Wild_Charge", "Confide"
    },
    new int[] {180}, new string[] {"Level,15"}),


new PokemonData(180, "Flaaffy", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Plus",
    50f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.8f, 13.3f,
    128, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Wool", "Its fluffy fleece easily stores electricity. Its rubberyhide keeps it from being electrocuted.",
    70, 55, 55, 80, 60, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 11, 16, 20, 25, 29, 34, 38, 43, 47, 52, 56},
    new string[]
    {
         "Tackle", "Growl", "Thunder Shock", "Thunder Wave", "Cotton Spore", "Charge", "Take Down", "Electro Ball", "Confuse Ray", "Power Gem", "Discharge", "Cotton Guard", "Signal Beam", "Light Screen", "Thunder",
    },
    new string[]
    {
         "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Brick_Break", "Fling", "Charge_Beam", "Round", "Echoed_Voice", "Volt_Switch", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {181}, new string[] {"Level,30"}),


new PokemonData(181, "Ampharos", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Plus",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.4f, 61.5f,
    230, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Light", "The tail’s tip shines brightly and can be seen fromfar away. It acts as a beacon for lost people.",
    90, 75, 85, 115, 90, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 4, 11, 16, 20, 25, 29, 30, 40, 46, 51, 57, 62},
    new string[]
    {
         "Fire Punch", "Tackle", "Growl", "Thunder Shock", "Zap Cannon", "Dragon Pulse", "Ion Deluge", "Magnetic Flux", "Thunder Wave", "Cotton Spore", "Charge", "Take Down", "Electro Ball", "Confuse Ray", "Thunder Punch", "Discharge", "Cotton Guard", "Signal Beam", "Light Screen", "Thunder",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Brick_Break", "Fling", "Focus_Blast", "Giga_Impact", "Charge_Beam", "Round", "Echoed_Voice", "Volt_Switch", "Bulldoze", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(182, "Bellossom", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", null, "Healer",
    50f, 45, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 5.8f,
    221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.GREEN, 70,
    "Flower", "Bellossom gather at times and seem to dance. They say that the dance is a ritual to summonthe sun.",
    75, 80, 95, 90, 100, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 23},
    new string[]
    {
         "Mega Drain", "Stun Spore", "Sweet Scent", "Sunny Day", "Leaf Blade", "Leaf Storm", "Magical Leaf",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Fling", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Venoshock", "Round", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(183, "Marill", PokemonData.Type.WATER, PokemonData.Type.FAIRY, "Thick-fat", "Huge-power", "Sap-sipper",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 8.5f,
    88, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Aqua Mouse", "The fur on its body naturally repels water. It canstay dry, even when it plays in the water.",
    70, 20, 50, 20, 50, 40, 0, Color.clear,
    new int[] { 1, 1, 2, 5, 7, 10, 10, 13, 16, 20, 23, 28, 31, 37, 40, 45},
    new string[]
    {
         "Tackle", "Water Gun", "Tail Whip", "Water Sport", "Bubble", "Defense Curl", "Rollout", "Bubble Beam", "Helping Hand", "Aqua Tail", "Double-Edge", "Aqua Ring", "Rain Dance", "Superpower", "Hydro Pump", "Play Rough",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Light_Screen", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Fling", "Grass_Knot", "Round", "Scald", "Confide", "Power_Up_Punch"
    },
    new int[] {184}, new string[] {"Level,18"}),


new PokemonData(184, "Azumarill", PokemonData.Type.WATER, PokemonData.Type.FAIRY, "Thick-fat", "Huge-power", "Sap-sipper",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 28.5f,
    189, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Aqua Rabbit", "Its long ears are superb sensors. It can distinguishthe movements of living things on riverbeds.",
    100, 50, 80, 60, 80, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 10, 10, 13, 16, 21, 25, 35, 42, 46, 50},
    new string[]
    {
         "Tackle", "Tail Whip", "Water Sport", "Bubble", "Defense Curl", "Rollout", "Bubble Beam", "Helping Hand", "Aqua Tail", "Double-Edge", "Rain Dance", "Superpower", "Hydro Pump", "Play Rough",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Light_Screen", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Fling", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Round", "Scald", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(185, "Sudowoodo", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Sturdy", "Rock-head", "Rattled",
    50f, 65, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 257, 1.2f, 38f,
    144, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Imitation", "Although it always pretends to be a tree, itscomposition appears more similar to rock thanto vegetation.",
    70, 100, 115, 30, 65, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 15, 22, 26, 29, 36, 40, 43, 47},
    new string[]
    {
         "Low Kick", "Rock Throw", "Flail", "Copycat", "Wood Hammer", "Slam", "Rock Tomb", "Block", "Rock Slide", "Sucker Punch", "Double-Edge", "Stone Edge", "Hammer Arm",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Taunt", "Brick_Break", "Rock_Tomb", "Calm_Mind", "Fling", "Rock_Polish", "Stone_Edge", "Smack_Down", "Round", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(186, "Politoed", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-absorb", "Damp", "Drizzle",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1.1f, 33.9f,
    225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.GREEN, 70,
    "Frog", "Whenever three or more of these get together,they sing in a loud voice that sounds like bellowing.",
    90, 75, 75, 90, 100, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 27, 37, 48},
    new string[]
    {
         "Double Slap", "Bubble Beam", "Hypnosis", "Perish Song", "Swagger", "Bounce", "Hyper Voice",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Payback", "Fling", "Focus_Blast", "Giga_Impact", "Round", "Echoed_Voice", "Scald", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(187, "Hoppip", PokemonData.Type.GRASS, PokemonData.Type.FLYING, "Chlorophyll", "Leaf-guard", "Infiltrator",
    50f, 255, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 0.5f,
    50, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PINK, 70,
    "Cottonweed", "Its body is so light, it must grip the ground firmlywith its feet to keep from being blown away.",
    35, 35, 40, 35, 55, 50, 0, Color.clear,
    new int[] { 1, 4, 6, 8, 10, 12, 14, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49},
    new string[]
    {
         "Splash", "Synthesis", "Tail Whip", "Tackle", "Fairy Wind", "Poison Powder", "Stun Spore", "Sleep Powder", "Bullet Seed", "Leech Seed", "Mega Drain", "Acrobatics", "Rage Powder", "Cotton Spore", "U-turn", "Worry Seed", "Giga Drain", "Bounce", "Memento",
    },
    new string[]
    {
         "Swords_Dance", "Solar_Beam", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Facade", "Aerial_Ace", "U_turn", "Energy_Ball", "Grass_Knot", "Round", "Acrobatics", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {188}, new string[] {"Level,18"}),


new PokemonData(188, "Skiploom", PokemonData.Type.GRASS, PokemonData.Type.FLYING, "Chlorophyll", "Leaf-guard", "Infiltrator",
    50f, 120, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.6f, 1f,
    119, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
    "Cottonweed", "The bloom on top of its head opens and closesas the temperature fluctuates up and down.",
    55, 45, 50, 45, 65, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 6, 10, 12, 14, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56},
    new string[]
    {
         "Tackle", "Splash", "Synthesis", "Tail Whip", "Fairy Wind", "Poison Powder", "Stun Spore", "Sleep Powder", "Bullet Seed", "Leech Seed", "Mega Drain", "Acrobatics", "Rage Powder", "Cotton Spore", "U-turn", "Worry Seed", "Giga Drain", "Bounce",
    },
    new string[]
    {
         "Swords_Dance", "Solar_Beam", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Facade", "Aerial_Ace", "U_turn", "Energy_Ball", "Grass_Knot", "Round", "Acrobatics", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {189}, new string[] {"Level,27"}),


new PokemonData(189, "Jumpluff", PokemonData.Type.GRASS, PokemonData.Type.FLYING, "Chlorophyll", "Leaf-guard", "Infiltrator",
    50f, 45, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.8f, 3f,
    207, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.BLUE, 70,
    "Cottonweed", "Blown by seasonal winds, it circles the globe,scattering cotton spores as it goes.",
    75, 55, 70, 55, 95, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 6, 10, 12, 14, 16, 20, 24, 29, 34, 39, 44, 49, 54, 59, 64},
    new string[]
    {
         "Tackle", "Splash", "Synthesis", "Tail Whip", "Fairy Wind", "Poison Powder", "Stun Spore", "Sleep Powder", "Bullet Seed", "Leech Seed", "Mega Drain", "Acrobatics", "Rage Powder", "Cotton Spore", "U-turn", "Worry Seed", "Giga Drain", "Bounce",
    },
    new string[]
    {
         "Swords_Dance", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Facade", "Aerial_Ace", "U_turn", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Acrobatics", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(190, "Aipom", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Pickup", "Skill-link",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.8f, 11.5f,
    72, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Long Tail", "It lives atop tall trees. When leaping from branch tobranch, it deftly uses its tail for balance.",
    55, 70, 55, 40, 55, 85, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43},
    new string[]
    {
         "Scratch", "Tail Whip", "Sand Attack", "Astonish", "Baton Pass", "Tickle", "Fury Swipes", "Swift", "Screech", "Agility", "Double Hit", "Fling", "Nasty Plot", "Last Resort",
    },
    new string[]
    {
         "Cut", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Aerial_Ace", "U_turn", "Payback", "Fling", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Acrobatics", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(191, "Sunkern", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Solar-power", "Early-bird",
    50f, 235, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.3f, 1.8f,
    36, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Seed", "It may plummet from the sky. If attacked by aSpearow, it will violently shake its leaves.",
    30, 30, 30, 30, 30, 30, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43},
    new string[]
    {
         "Absorb", "Growth", "Ingrain", "Grass Whistle", "Mega Drain", "Leech Seed", "Razor Leaf", "Worry Seed", "Giga Drain", "Endeavor", "Synthesis", "Natural Gift", "Solar Beam", "Double-Edge", "Sunny Day", "Seed Bomb",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(192, "Sunflora", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Solar-power", "Early-bird",
    50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.8f, 8.5f,
    149, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Sun", "As the hot season approaches, the petals on thisPokémon’s face become more vivid and lively.",
    75, 75, 55, 105, 85, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 50},
    new string[]
    {
         "Pound", "Absorb", "Growth", "Flower Shield", "Ingrain", "Grass Whistle", "Mega Drain", "Leech Seed", "Razor Leaf", "Worry Seed", "Giga Drain", "Bullet Seed", "Petal Dance", "Natural Gift", "Solar Beam", "Double-Edge", "Sunny Day", "Leaf Storm", "Petal Blizzard",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(193, "Yanma", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Speed-boost", "Compound-eyes", "Frisk",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.2f, 38f,
    78, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
    "Clear Wing", "Its eyes can see 360 degrees without moving itshead. It won’t miss prey--even those behind it.",
    65, 65, 45, 75, 45, 95, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 14, 17, 22, 27, 30, 33, 38, 43, 46, 49, 54, 57},
    new string[]
    {
         "Tackle", "Foresight", "Quick Attack", "Double Team", "Sonic Boom", "Detect", "Supersonic", "Uproar", "Pursuit", "Ancient Power", "Hypnosis", "Wing Attack", "Screech", "U-turn", "Air Slash", "Bug Buzz",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "U_turn", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(194, "Wooper", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Damp", "Water-absorb", "Unaware",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 0.4f, 8.5f,
    42, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Water Fish", "This Pokémon lives in cold water. It will leave thewater to search for food when it gets cold outside.",
    55, 45, 45, 25, 25, 15, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 15, 19, 23, 29, 33, 37, 43, 43, 47},
    new string[]
    {
         "Tail Whip", "Water Gun", "Mud Sport", "Mud Shot", "Slam", "Mud Bomb", "Amnesia", "Yawn", "Earthquake", "Rain Dance", "Mist", "Haze", "Muddy Water",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Sludge_Wave", "Round", "Scald", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {195}, new string[] {"Level,20"}),


new PokemonData(195, "Quagsire", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Damp", "Water-absorb", "Unaware",
    50f, 90, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1.4f, 75f,
    151, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Water Fish", "It has a sluggish nature. It lies at the river’s bottom,waiting for prey to stray into its mouth.",
    95, 85, 85, 65, 65, 35, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 15, 19, 24, 31, 36, 41, 48, 48},
    new string[]
    {
         "Tail Whip", "Water Gun", "Mud Sport", "Mud Shot", "Slam", "Mud Bomb", "Amnesia", "Yawn", "Earthquake", "Rain Dance", "Mist", "Haze",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Sludge_Wave", "Round", "Scald", "Bulldoze", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(196, "Espeon", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Synchronize", null, "Magic-bounce",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 26.5f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sun", "The tip of its forked tail quivers when it is predictingits opponent’s next move.",
    65, 65, 60, 130, 95, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 20, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Confusion", "Quick Attack", "Swift", "Psybeam", "Future Sight", "Psych Up", "Morning Sun", "Psychic", "Last Resort", "Power Swap",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Calm_Mind", "Giga_Impact", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Retaliate", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(197, "Umbreon", PokemonData.Type.DARK, PokemonData.Type.NONE, "Synchronize", null, "Inner-focus",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 27f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLACK, 35,
    "Moonlight", "The light of the moon changed Eevee’s geneticstructure. It lurks in darkness for prey.",
    95, 65, 110, 60, 130, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 20, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Pursuit", "Quick Attack", "Confuse Ray", "Feint Attack", "Assurance", "Screech", "Moonlight", "Mean Look", "Last Resort", "Guard Swap",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Payback", "Dark_Pulse", "Giga_Impact", "Round", "Echoed_Voice", "Retaliate", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(198, "Murkrow", PokemonData.Type.DARK, PokemonData.Type.FLYING, "Insomnia", "Super-luck", "Prankster",
    50f, 30, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 0.5f, 2.1f,
    81, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLACK, 35,
    "Darkness", "It hides any shiny object it finds in a secretlocation. Murkrow and Meowth loot oneanother’s stashes.",
    60, 85, 42, 85, 42, 91, 0, Color.clear,
    new int[] { 1, 1, 5, 11, 15, 21, 25, 31, 35, 41, 45, 50, 55, 61, 65},
    new string[]
    {
         "Peck", "Astonish", "Pursuit", "Haze", "Wing Attack", "Night Shade", "Assurance", "Taunt", "Feint Attack", "Mean Look", "Foul Play", "Tailwind", "Sucker Punch", "Torment", "Quash",
    },
    new string[]
    {
         "Fly", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Roost", "Payback", "Embargo", "Dark_Pulse", "Round", "Quash", "Retaliate", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(199, "Slowking", PokemonData.Type.WATER, PokemonData.Type.PSYCHIC, "Oblivious", "Own-tempo", "Regenerator",
    50f, 70, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2f, 79.5f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.PINK, 70,
    "Royal", "It has incredible intellect and intuition. Whateverthe situation, it remains calm and collected.",
    95, 75, 80, 100, 110, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 9, 14, 19, 23, 28, 32, 36, 41, 45, 49, 54},
    new string[]
    {
         "Tackle", "Curse", "Hidden Power", "Yawn", "Power Gem", "Heal Pulse", "Growl", "Water Gun", "Confusion", "Disable", "Headbutt", "Water Pulse", "Zen Headbutt", "Nasty Plot", "Swagger", "Psychic", "Trump Card", "Psych Up",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunder_Wave", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Calm_Mind", "Fling", "Focus_Blast", "Giga_Impact", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Scald", "Incinerate", "Quash", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(200, "Misdreavus", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.7f, 1f,
    87, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GRAY, 35,
    "Screech", "It gets nourishment from fear that it absorbs into itsred orbs. In daytime, it sleeps in darkness.",
    60, 60, 60, 85, 85, 85, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 46, 50, 55},
    new string[]
    {
         "Growl", "Psywave", "Spite", "Astonish", "Confuse Ray", "Mean Look", "Hex", "Psybeam", "Pain Split", "Payback", "Shadow Ball", "Perish Song", "Grudge", "Power Gem",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Payback", "Embargo", "Dark_Pulse", "Trick_Room", "Charge_Beam", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
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
         "Hidden_Power"
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
         "Safeguard"
    },
    new int[] {}, new string[] {}),


new PokemonData(203, "Girafarig", PokemonData.Type.NORMAL, PokemonData.Type.PSYCHIC, "Inner-focus", "Early-bird", "Sap-sipper",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.5f, 41.5f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Long Neck", "While it sleeps, the head on its tail keeps watch. The tail doesn’t need to sleep.",
    70, 80, 65, 90, 65, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 46},
    new string[]
    {
         "Tackle", "Growl", "Confusion", "Astonish", "Power Swap", "Guard Swap", "Odor Sleuth", "Stomp", "Agility", "Psybeam", "Baton Pass", "Assurance", "Double Hit", "Psychic", "Zen Headbutt", "Crunch",
    },
    new string[]
    {
         "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Calm_Mind", "Energy_Ball", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Retaliate", "Bulldoze", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(204, "Pineco", PokemonData.Type.BUG, PokemonData.Type.NONE, "Sturdy", null, "Overcoat",
    50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.6f, 7.2f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Bagworm", "It likes to make its shell thicker by adding layers oftree bark. The additional weight doesn’t bother it.",
    50, 65, 90, 35, 35, 15, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 12, 17, 20, 23, 28, 31, 34, 39, 42, 45},
    new string[]
    {
         "Tackle", "Protect", "Self-Destruct", "Bug Bite", "Take Down", "Rapid Spin", "Bide", "Natural Gift", "Spikes", "Payback", "Explosion", "Iron Defense", "Gyro Ball", "Double-Edge",
    },
    new string[]
    {
         "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Gyro_Ball", "Payback", "Venoshock", "Round", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {205}, new string[] {"Level,31"}),


new PokemonData(205, "Forretress", PokemonData.Type.BUG, PokemonData.Type.STEEL, "Sturdy", null, "Overcoat",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.2f, 125.8f,
    163, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Bagworm", "It is encased in a steel shell. Its peering eyes areall that can be seen of its mysterious innards.",
    75, 90, 140, 60, 60, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 12, 20, 23, 28, 32, 36, 42, 46, 50, 56},
    new string[]
    {
         "Tackle", "Self-Destruct", "Protect", "Zap Cannon", "Toxic Spikes", "Magnet Rise", "Bug Bite", "Heavy Slam", "Take Down", "Bide", "Natural Gift", "Spikes", "Autotomize", "Payback", "Explosion", "Iron Defense", "Gyro Ball", "Double-Edge",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Gyro_Ball", "Payback", "Rock_Polish", "Giga_Impact", "Flash_Cannon", "Venoshock", "Round", "Volt_Switch", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(206, "Dunsparce", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Serene-grace", "Run-away", "Rattled",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.5f, 14f,
    145, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Land Snake", "When spotted, this Pokémon escapes backward byfuriously boring into the ground with its tail.",
    100, 70, 70, 65, 65, 45, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49},
    new string[]
    {
         "Rage", "Defense Curl", "Rollout", "Spite", "Pursuit", "Screech", "Yawn", "Ancient Power", "Take Down", "Roost", "Glare", "Dig", "Double-Edge", "Coil", "Endure", "Drill Run", "Endeavor", "Flail",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Dream_Eater", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Rock_Tomb", "Calm_Mind", "Roost", "Gyro_Ball", "Poison_Jab", "Charge_Beam", "Round", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(207, "Gligar", PokemonData.Type.GROUND, PokemonData.Type.FLYING, "Hyper-cutter", "Sand-veil", "Immunity",
    50f, 60, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.1f, 64.8f,
    86, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Fly Scorpion", "It usually clings to cliffs. When it spots its prey,it spreads its wings and glides down to attack.",
    65, 75, 105, 35, 65, 85, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 27, 30, 35, 40, 45, 50, 55},
    new string[]
    {
         "Poison Sting", "Sand Attack", "Harden", "Knock Off", "Quick Attack", "Fury Cutter", "Feint Attack", "Acrobatics", "Slash", "U-turn", "Screech", "X-Scissor", "Sky Uppercut", "Swords Dance", "Guillotine",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Roost", "U_turn", "Payback", "Fling", "Rock_Polish", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Stone_Edge", "Hone_Claws", "Venoshock", "Round", "Acrobatics", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(208, "Steelix", PokemonData.Type.STEEL, PokemonData.Type.GROUND, "Rock-head", "Sturdy", "Sheer-force",
    50f, 25, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 257, 9.2f, 400f,
    179, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Iron Snake", "Tempered underground under high pressure andheat, its body is harder than any metal.",
    75, 85, 200, 55, 65, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 4, 7, 10, 13, 16, 19, 20, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52},
    new string[]
    {
         "Bind", "Tackle", "Harden", "Mud Sport", "Thunder Fang", "Ice Fang", "Fire Fang", "Curse", "Rock Throw", "Rock Tomb", "Rage", "Stealth Rock", "Autotomize", "Gyro Ball", "Smack Down", "Dragon Breath", "Slam", "Screech", "Rock Slide", "Crunch", "Iron Tail", "Dig", "Stone Edge", "Double-Edge", "Sandstorm",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Taunt", "Rock_Tomb", "Gyro_Ball", "Payback", "Rock_Polish", "Dark_Pulse", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Round", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(209, "Snubbull", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Intimidate", "Run-away", "Rattled",
    25f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 7.8f,
    60, PokemonData.LevelingRate.FAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Fairy", "It has an active, playful nature. Many women like tofrolic with it because of its affectionate ways.",
    60, 80, 50, 40, 40, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Tackle", "Tail Whip", "Scary Face", "Charm", "Thunder Fang", "Ice Fang", "Fire Fang", "Bite", "Lick", "Headbutt", "Roar", "Rage", "Play Rough", "Payback", "Crunch",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Reflect", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Overheat", "Bulk_Up", "Payback", "Fling", "Round", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Snarl", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {210}, new string[] {"Level,23"}),


new PokemonData(210, "Granbull", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Intimidate", "Quick-feet", "Rattled",
    25f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 48.7f,
    158, PokemonData.LevelingRate.FAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Fairy", "It is timid in spite of its looks. If it becomesenraged, however, it will strike with its huge fangs.",
    90, 120, 75, 60, 60, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 7, 13, 19, 27, 35, 43, 51, 59},
    new string[]
    {
         "Tackle", "Tail Whip", "Scary Face", "Outrage", "Thunder Fang", "Ice Fang", "Fire Fang", "Bite", "Lick", "Headbutt", "Roar", "Rage", "Play Rough", "Payback", "Crunch",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Reflect", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Round", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Snarl", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(211, "Qwilfish", PokemonData.Type.WATER, PokemonData.Type.POISON, "Poison-point", "Swift-swim", "Intimidate",
    50f, 45, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.5f, 3.9f,
    88, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Balloon", "To fire its poison spikes, it must inflate its body bydrinking over 2. 6 gallons of water all at once.",
    65, 95, 85, 55, 55, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 9, 13, 21, 25, 25, 29, 33, 37, 41, 45, 49},
    new string[]
    {
         "Tackle", "Poison Sting", "Water Gun", "Hydro Pump", "Spikes", "Destiny Bond", "Fell Stinger", "Minimize", "Bubble", "Toxic Spikes", "Stockpile", "Spit Up", "Revenge", "Brine", "Pin Missile", "Take Down", "Aqua Tail", "Poison Jab",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Thunder_Wave", "Toxic", "Double_Team", "Waterfall", "Explosion", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Facade", "Taunt", "Gyro_Ball", "Payback", "Poison_Jab", "Venoshock", "Sludge_Wave", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(212, "Scizor", PokemonData.Type.BUG, PokemonData.Type.STEEL, "Swarm", "Technician", "Light-metal",
    50f, 25, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.8f, 118f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Pincer", "This Pokémon’s pincers, which contain steel, cancrush any hard object it gets ahold of into bits.",
    70, 130, 100, 55, 80, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 49, 50, 57},
    new string[]
    {
         "Leer", "Quick Attack", "Feint", "Bullet Punch", "Focus Energy", "Pursuit", "False Swipe", "Agility", "Metal Claw", "Fury Cutter", "Slash", "Razor Wind", "Iron Defense", "X-Scissor", "Double Hit", "Iron Head", "Swords Dance",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Toxic", "Double_Team", "Light_Screen", "Rest", "Substitute", "Thief", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Roost", "U_turn", "Fling", "X_Scissor", "Giga_Impact", "Flash_Cannon", "Venoshock", "Round", "Acrobatics", "Struggle_Bug", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(213, "Shuckle", PokemonData.Type.BUG, PokemonData.Type.ROCK, "Sturdy", "Gluttony", "Contrary",
    50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.6f, 20.5f,
    177, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Mold", "The berries stored in its jar-like shell eventuallybecome a thick, pulpy juice.",
    20, 10, 230, 10, 230, 5, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 9, 12, 16, 20, 23, 27, 31, 34, 38, 42, 45, 45, 49},
    new string[]
    {
         "Withdraw", "Bide", "Constrict", "Rollout", "Sticky Web", "Encore", "Wrap", "Struggle Bug", "Safeguard", "Rest", "Rock Throw", "Gastro Acid", "Power Trick", "Shell Smash", "Rock Slide", "Bug Bite", "Guard Split", "Power Split", "Stone Edge",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Gyro_Ball", "Rock_Polish", "Stone_Edge", "Venoshock", "Smack_Down", "Sludge_Wave", "Round", "Struggle_Bug", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(214, "Heracross", PokemonData.Type.BUG, PokemonData.Type.FIGHTING, "Swarm", "Guts", "Moxie",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1.5f, 54f,
    175, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Single Horn", "This powerful Pokémon thrusts its prized horn underits enemies’ bellies, then lifts and throws them.",
    80, 125, 75, 40, 95, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 7, 10, 16, 19, 25, 28, 31, 34, 37, 43, 46},
    new string[]
    {
         "Horn Attack", "Tackle", "Leer", "Endure", "Arm Thrust", "Bullet Seed", "Night Slash", "Fury Attack", "Aerial Ace", "Chip Away", "Counter", "Brick Break", "Take Down", "Pin Missile", "Close Combat", "Feint", "Reversal", "Megahorn",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Venoshock", "Smack_Down", "Round", "Retaliate", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(215, "Sneasel", PokemonData.Type.DARK, PokemonData.Type.ICE, "Inner-focus", "Keen-eye", "Pickpocket",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.9f, 28f,
    86, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLACK, 35,
    "Sharp Claw", "It feeds on eggs stolen from nests. Its sharplyhooked claws rip vulnerable spots on prey.",
    55, 95, 55, 35, 75, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 10, 14, 16, 20, 22, 25, 28, 32, 35, 40, 44, 47},
    new string[]
    {
         "Scratch", "Leer", "Taunt", "Quick Attack", "Feint Attack", "Icy Wind", "Fury Swipes", "Agility", "Metal Claw", "Hone Claws", "Beat Up", "Screech", "Slash", "Snatch", "Punishment", "Ice Shard",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Reflect", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Brick_Break", "Aerial_Ace", "Calm_Mind", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Shadow_Claw", "Hone_Claws", "Low_Sweep", "Round", "Retaliate", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(216, "Teddiursa", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Quick-feet", "Honey-gather",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 8.8f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Little Bear", "If it finds honey, its crescent mark glows. It alwayslicks its paws because they’re soaked with honey.",
    60, 80, 50, 50, 50, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 8, 15, 22, 29, 36, 43, 43, 50},
    new string[]
    {
         "Scratch", "Lick", "Fake Tears", "Covet", "Fling", "Baby-Doll Eyes", "Fury Swipes", "Feint Attack", "Sweet Scent", "Slash", "Charm", "Rest", "Snore", "Thrash",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Payback", "Fling", "Shadow_Claw", "Hone_Claws", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {217}, new string[] {"Level,30"}),


new PokemonData(217, "Ursaring", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Guts", "Quick-feet", "Unnerve",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.8f, 125.8f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Hibernator", "With its ability to distinguish any aroma, itunfailingly finds all food buried deep underground.",
    90, 130, 75, 75, 75, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 8, 15, 22, 29, 38, 47, 49, 58},
    new string[]
    {
         "Scratch", "Leer", "Lick", "Fake Tears", "Covet", "Hammer Arm", "Fury Swipes", "Feint Attack", "Sweet Scent", "Slash", "Scary Face", "Rest", "Snore", "Thrash",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Payback", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(218, "Slugma", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Magma-armor", "Flame-body", "Weak-armor",
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.7f, 35f,
    50, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Lava", "A common sight in volcanic areas, it slowly slithersaround in a constant search for warm places.",
    40, 40, 40, 70, 40, 20, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 46, 50, 55},
    new string[]
    {
         "Smog", "Yawn", "Ember", "Rock Throw", "Harden", "Recover", "Flame Burst", "Ancient Power", "Amnesia", "Lava Plume", "Rock Slide", "Body Slam", "Flamethrower", "Earth Power",
    },
    new string[]
    {
         "Flamethrower", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Overheat", "Rock_Tomb", "Flame_Charge", "Round", "Incinerate", "Confide", "Infestation"
    },
    new int[] {219}, new string[] {"Level,38"}),


new PokemonData(219, "Magcargo", PokemonData.Type.FIRE, PokemonData.Type.ROCK, "Magma-armor", "Flame-body", "Weak-armor",
    50f, 75, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.8f, 55f,
    151, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Lava", "Its brittle shell occasionally spouts intense flamesthat circulate throughout its body.",
    60, 50, 120, 90, 80, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 14, 23, 28, 32, 38, 44, 52},
    new string[]
    {
         "Ember", "Rock Throw", "Smog", "Yawn", "Earth Power", "Harden", "Flame Burst", "Ancient Power", "Amnesia", "Shell Smash", "Rock Slide", "Body Slam",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Overheat", "Rock_Tomb", "Gyro_Ball", "Rock_Polish", "Giga_Impact", "Stone_Edge", "Smack_Down", "Flame_Charge", "Round", "Incinerate", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(220, "Swinub", PokemonData.Type.ICE, PokemonData.Type.GROUND, "Oblivious", "Snow-cloak", "Thick-fat",
    50f, 225, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 6.5f,
    50, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Pig", "It rubs its snout on the ground to find and dig upfood. It sometimes discovers hot springs.",
    50, 50, 40, 30, 30, 50, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 11, 14, 18, 21, 24, 28, 35, 37, 40, 44, 48},
    new string[]
    {
         "Tackle", "Odor Sleuth", "Mud Sport", "Powder Snow", "Mud-Slap", "Endure", "Mud Bomb", "Icy Wind", "Ice Shard", "Take Down", "Mist", "Earthquake", "Flail", "Blizzard", "Amnesia",
    },
    new string[]
    {
         "Roar", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Round", "Bulldoze", "Confide"
    },
    new int[] {221}, new string[] {"Level,33"}),


new PokemonData(221, "Piloswine", PokemonData.Type.ICE, PokemonData.Type.GROUND, "Oblivious", "Snow-cloak", "Thick-fat",
    50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.1f, 55.8f,
    158, PokemonData.LevelingRate.SLOW, 1, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Swine", "Although its legs are short, its rugged hoovesprevent it from slipping, even on icy ground.",
    100, 100, 80, 60, 60, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 14, 18, 21, 24, 28, 33, 37, 41, 46, 52, 58},
    new string[]
    {
         "Peck", "Powder Snow", "Ancient Power", "Mud Sport", "Endure", "Mud Bomb", "Icy Wind", "Ice Fang", "Take Down", "Fury Attack", "Mist", "Thrash", "Earthquake", "Blizzard", "Amnesia",
    },
    new string[]
    {
         "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Giga_Impact", "Stone_Edge", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(222, "Corsola", PokemonData.Type.WATER, PokemonData.Type.ROCK, "Hustle", "Natural-cure", "Regenerator",
    25f, 60, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 5f,
    144, PokemonData.LevelingRate.FAST, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.PINK, 70,
    "Coral", "It continuously sheds and grows. The tip of its headis prized as a treasure because of its beauty.",
    65, 55, 95, 65, 95, 35, 0, Color.clear,
    new int[] { 1, 4, 8, 10, 13, 17, 20, 23, 27, 29, 31, 35, 38, 41, 45, 47, 50},
    new string[]
    {
         "Tackle", "Harden", "Bubble", "Recover", "Refresh", "Bubble Beam", "Ancient Power", "Lucky Chant", "Spike Cannon", "Iron Defense", "Rock Blast", "Endure", "Aqua Ring", "Power Gem", "Mirror Coat", "Earth Power", "Flail",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Nature_Power", "Rock_Tomb", "Calm_Mind", "Rock_Polish", "Stone_Edge", "Round", "Scald", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(223, "Remoraid", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hustle", "Sniper", "Moody",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 12f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Jet", "It has superb accuracy. The water it shoots out canstrike moving prey from more than 300 feet away.",
    35, 65, 35, 65, 35, 65, 0, Color.clear,
    new int[] { 1, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50},
    new string[]
    {
         "Water Gun", "Lock-On", "Psybeam", "Aurora Beam", "Bubble Beam", "Focus Energy", "Water Pulse", "Signal Beam", "Ice Beam", "Bullet Seed", "Hydro Pump", "Hyper Beam", "Soak",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Charge_Beam", "Smack_Down", "Round", "Scald", "Incinerate", "Confide"
    },
    new int[] {224}, new string[] {"Level,25"}),


new PokemonData(224, "Octillery", PokemonData.Type.WATER, PokemonData.Type.NONE, "Suction-cups", "Sniper", "Moody",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 0.9f, 28.5f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Jet", "It has a tendency to want to be in holes. It prefersrock crags or pots and sprays ink from thembefore attacking.",
    75, 105, 75, 105, 75, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 22, 28, 34, 40, 46, 52, 64},
    new string[]
    {
         "Water Gun", "Psybeam", "Aurora Beam", "Constrict", "Rock Blast", "Gunk Shot", "Focus Energy", "Wring Out", "Signal Beam", "Ice Beam", "Bullet Seed", "Hydro Pump", "Soak",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Payback", "Energy_Ball", "Giga_Impact", "Flash_Cannon", "Charge_Beam", "Smack_Down", "Sludge_Wave", "Round", "Scald", "Incinerate", "Confide"
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
         "Fly", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Brick_Break", "Aerial_Ace", "Fling", "Round", "Frost_Breath", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(226, "Mantine", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Swift-swim", "Water-absorb", "Water-veil",
    50f, 25, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 2.1f, 220f,
    170, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Kite", "If it builds up enough speed swimming, it can flyover 300 feet out of the water from the surface ofthe ocean.",
    85, 40, 70, 80, 140, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 11, 14, 16, 19, 23, 27, 36, 39, 46},
    new string[]
    {
         "Tackle", "Supersonic", "Psybeam", "Bubble Beam", "Bubble", "Signal Beam", "Bullet Seed", "Confuse Ray", "Wing Attack", "Headbutt", "Water Pulse", "Wide Guard", "Take Down", "Air Slash", "Aqua Ring", "Bounce",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Rock_Tomb", "Aerial_Ace", "Giga_Impact", "Round", "Scald", "Acrobatics", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(227, "Skarmory", PokemonData.Type.STEEL, PokemonData.Type.FLYING, "Keen-eye", "Sturdy", "Weak-armor",
    50f, 25, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.7f, 50.5f,
    163, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Armor Bird", "After nesting in bramble bushes, the wings of itschicks grow hard from scratches by thorns.",
    65, 80, 140, 40, 70, 70, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 12, 17, 20, 23, 28, 31, 34, 39, 42, 45, 50},
    new string[]
    {
         "Leer", "Peck", "Sand Attack", "Swift", "Agility", "Fury Attack", "Feint", "Air Cutter", "Spikes", "Metal Sound", "Steel Wing", "Autotomize", "Air Slash", "Slash", "Night Slash",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Fly", "Roar", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Roost", "Payback", "Dark_Pulse", "X_Scissor", "Flash_Cannon", "Round", "Sky_Drop", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(228, "Houndour", PokemonData.Type.DARK, PokemonData.Type.FIRE, "Early-bird", "Flash-fire", "Unnerve",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 10.8f,
    66, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Dark", "Around dawn, its ominous howl echoes throughthe area to announce that this is its territory.",
    45, 60, 30, 80, 50, 65, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 13, 16, 20, 25, 28, 32, 37, 40, 44, 49, 52, 56},
    new string[]
    {
         "Leer", "Ember", "Howl", "Smog", "Roar", "Bite", "Odor Sleuth", "Beat Up", "Fire Fang", "Feint Attack", "Embargo", "Foul Play", "Flamethrower", "Crunch", "Nasty Plot", "Inferno",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Payback", "Embargo", "Dark_Pulse", "Flame_Charge", "Round", "Incinerate", "Retaliate", "Snarl", "Confide"
    },
    new int[] {229}, new string[] {"Level,24"}),


new PokemonData(229, "Houndoom", PokemonData.Type.DARK, PokemonData.Type.FIRE, "Early-bird", "Flash-fire", "Unnerve",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.4f, 35f,
    175, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Dark", "Long ago, people imagined its eerie howls to bethe call of the grim reaper.",
    75, 90, 50, 110, 80, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 13, 16, 20, 26, 30, 45, 50, 56},
    new string[]
    {
         "Leer", "Ember", "Smog", "Howl", "Nasty Plot", "Inferno", "Roar", "Bite", "Odor Sleuth", "Beat Up", "Fire Fang", "Foul Play", "Flamethrower", "Crunch",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Payback", "Embargo", "Dark_Pulse", "Giga_Impact", "Flame_Charge", "Round", "Incinerate", "Retaliate", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(230, "Kingdra", PokemonData.Type.WATER, PokemonData.Type.DRAGON, "Swift-swim", "Sniper", "Damp",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.8f, 152f,
    243, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 1, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Dragon", "It is said that it usually hides in underwater caves. It can create whirlpools by yawning.",
    75, 95, 95, 95, 95, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 18, 23, 30, 40, 48},
    new string[]
    {
         "Leer", "Smokescreen", "Bubble", "Yawn", "Dragon Pulse", "Bubble Beam", "Agility", "Brine", "Hydro Pump", "Dragon Dance",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Giga_Impact", "Flash_Cannon", "Round", "Scald", "Quash", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(231, "Phanpy", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Pickup", null, "Sand-veil",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 33.5f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Long Nose", "As a sign of affection, it bumps with its snout. However, it is so strong, it may send you flying.",
    90, 60, 60, 40, 40, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 10, 15, 19, 24, 28, 33, 37, 42},
    new string[]
    {
         "Tackle", "Growl", "Defense Curl", "Odor Sleuth", "Flail", "Take Down", "Rollout", "Natural Gift", "Slam", "Endure", "Charm", "Last Resort", "Double-Edge",
    },
    new string[]
    {
         "Roar", "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Round", "Echoed_Voice", "Bulldoze", "Confide"
    },
    new int[] {232}, new string[] {"Level,25"}),


new PokemonData(232, "Donphan", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sturdy", null, "Sand-veil",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.1f, 120f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Armor", "It has sharp, hard tusks and a rugged hide. Its Tackle is strong enough to knock down a house.",
    90, 120, 120, 60, 60, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 6, 10, 15, 19, 24, 25, 31, 39, 46, 54},
    new string[]
    {
         "Horn Attack", "Growl", "Defense Curl", "Thunder Fang", "Fire Fang", "Bulldoze", "Rapid Spin", "Knock Off", "Rollout", "Magnitude", "Slam", "Fury Attack", "Assurance", "Scary Face", "Earthquake", "Giga Impact",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Gyro_Ball", "Rock_Polish", "Poison_Jab", "Giga_Impact", "Stone_Edge", "Round", "Echoed_Voice", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(233, "Porygon2", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Trace", "Download", "Analytic",
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.6f, 32.5f,
    180, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Virtual", "Further research enhanced its abilities. Sometimes,it may exhibit motions that were not programmed.",
    85, 80, 90, 105, 95, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 7, 12, 18, 23, 29, 40, 50, 67},
    new string[]
    {
         "Tackle", "Defense Curl", "Conversion", "Conversion 2", "Zap Cannon", "Magic Coat", "Psybeam", "Agility", "Recover", "Magnet Rise", "Signal Beam", "Discharge", "Tri Attack", "Hyper Beam",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Giga_Impact", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(234, "Stantler", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Intimidate", "Frisk", "Sap-sipper",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 71.2f,
    163, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Big Horn", "Staring at its antlers creates an odd sensationas if one were being drawn into their centers.",
    73, 95, 62, 85, 65, 85, 0, Color.clear,
    new int[] { 1, 1, 3, 7, 10, 13, 16, 21, 23, 27, 33, 43, 49, 50},
    new string[]
    {
         "Tackle", "Me First", "Leer", "Astonish", "Hypnosis", "Stomp", "Sand Attack", "Take Down", "Confuse Ray", "Calm Mind", "Role Play", "Jump Kick", "Imprison", "Captivate",
    },
    new string[]
    {
         "Roar", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Calm_Mind", "Energy_Ball", "Giga_Impact", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Retaliate", "Bulldoze", "Wild_Charge", "Confide"
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
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Tackle", "Foresight", "Fake Out", "Helping Hand",
    },
    new string[]
    {
         "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Bulk_Up", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide"
    },
    new int[] {237}, new string[] {"Level,20"}),


new PokemonData(237, "Hitmontop", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Intimidate", "Technician", "Steadfast",
    100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 48f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BROWN, 70,
    "Handstand", "It fights while spinning like a top. The centrifugalforce boosts its destructive power by 10.",
    50, 95, 95, 35, 110, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 10, 15, 19, 24, 28, 33, 37, 46, 50},
    new string[]
    {
         "Rolling Kick", "Revenge", "Endeavor", "Close Combat", "Focus Energy", "Pursuit", "Quick Attack", "Triple Kick", "Rapid Spin", "Counter", "Feint", "Agility", "Quick Guard", "Detect",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Bulk_Up", "Gyro_Ball", "Stone_Edge", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(238, "Smoochum", PokemonData.Type.ICE, PokemonData.Type.PSYCHIC, "Oblivious", "Forewarn", "Hydration",
    0f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.4f, 6f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Kiss", "Its lips are the most sensitive part of its body. It always uses its lips first to examine things.",
    45, 30, 15, 85, 65, 65, 0, Color.clear,
    new int[] { 1, 5, 8, 11, 15, 18, 21, 25, 28, 31, 35, 38, 41, 45, 48},
    new string[]
    {
         "Pound", "Lick", "Sweet Kiss", "Powder Snow", "Confusion", "Sing", "Heart Stamp", "Mean Look", "Fake Tears", "Lucky Chant", "Avalanche", "Psychic", "Copycat", "Perish Song", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Hail", "Facade", "Calm_Mind", "Payback", "Fling", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(239, "Elekid", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", null, "Vital-spirit",
    75f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.6f, 23.5f,
    72, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Electric", "It generates electricity by whirling its arms. However, it can’t store the energy it makes.",
    45, 63, 37, 65, 55, 95, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 19, 22, 26, 29, 33, 36, 40, 43},
    new string[]
    {
         "Leer", "Quick Attack", "Thunder Shock", "Low Kick", "Swift", "Shock Wave", "Thunder Wave", "Electro Ball", "Light Screen", "Thunder Punch", "Discharge", "Screech", "Thunderbolt", "Thunder",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Brick_Break", "Fling", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(240, "Magby", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flame-body", null, "Vital-spirit",
    75f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.7f, 21.4f,
    73, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
    "Live Coal", "It’s small, but its body temperature is over1,100 degrees Fahrenheit. Embers escape itsmouth and nose when it breathes.",
    45, 75, 37, 70, 55, 83, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 19, 22, 26, 29, 33, 36, 40, 43},
    new string[]
    {
         "Leer", "Smog", "Ember", "Smokescreen", "Feint Attack", "Fire Spin", "Clear Smog", "Flame Burst", "Confuse Ray", "Fire Punch", "Lava Plume", "Sunny Day", "Flamethrower", "Fire Blast",
    },
    new string[]
    {
         "Flamethrower", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Brick_Break", "Overheat", "Fling", "Flame_Charge", "Round", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(241, "Miltank", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Thick-fat", "Scrappy", "Sap-sipper",
    0f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 75.5f,
    172, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Milk Cow", "If it is around babies, the milk it produces containsmuch more nutrition than usual.",
    95, 80, 105, 40, 70, 100, 0, Color.clear,
    new int[] { 1, 3, 5, 8, 11, 15, 19, 24, 29, 35, 41, 48, 50},
    new string[]
    {
         "Tackle", "Growl", "Defense Curl", "Stomp", "Milk Drink", "Bide", "Rollout", "Body Slam", "Zen Headbutt", "Captivate", "Gyro Ball", "Heal Bell", "Wake-Up Slap",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Focus_Blast", "Giga_Impact", "Round", "Echoed_Voice", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(242, "Blissey", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Natural-cure", "Serene-grace", "Healer",
    0f, 30, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.5f, 46.8f,
    608, PokemonData.LevelingRate.FAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
    "Happiness", "The eggs it lays are filled with happiness. Eatingeven one bite will bring a smile to anyone.",
    255, 10, 10, 75, 135, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 12, 16, 20, 23, 27, 31, 34, 38, 42, 46, 50},
    new string[]
    {
         "Pound", "Double-Edge", "Growl", "Defense Curl", "Refresh", "Double Slap", "Soft-Boiled", "Bestow", "Minimize", "Take Down", "Sing", "Fling", "Heal Pulse", "Egg Bomb", "Light Screen", "Healing Wish",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Calm_Mind", "Fling", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(243, "Raikou", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Pressure", null, "Inner-focus",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.9f, 178f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 2, PokemonData.PokedexColor.YELLOW, 35,
    "Thunder", "The rain clouds it carries let it fire thunderboltsat will. They say that it descended with lightning.",
    90, 85, 75, 115, 100, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 8, 15, 22, 29, 36, 43, 50, 71, 85},
    new string[]
    {
         "Leer", "Bite", "Extrasensory", "Discharge", "Thunder Shock", "Roar", "Quick Attack", "Spark", "Reflect", "Crunch", "Thunder Fang", "Rain Dance", "Thunder",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Calm_Mind", "Giga_Impact", "Charge_Beam", "Round", "Quash", "Volt_Switch", "Bulldoze", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(244, "Entei", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Pressure", null, "Inner-focus",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2.1f, 198f,
    261, PokemonData.LevelingRate.SLOW, 1, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 35,
    "Volcano", "A Pokémon that races across the land. It is saidthat one is born every time a new volcano appears.",
    115, 115, 85, 90, 75, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 8, 15, 22, 29, 36, 43, 50, 64, 71, 78},
    new string[]
    {
         "Leer", "Bite", "Sacred Fire", "Eruption", "Lava Plume", "Ember", "Roar", "Fire Spin", "Stomp", "Flamethrower", "Swagger", "Fire Fang", "Extrasensory", "Fire Blast", "Calm Mind",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Reflect", "Fire_Blast", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Overheat", "Calm_Mind", "Giga_Impact", "Stone_Edge", "Flame_Charge", "Round", "Incinerate", "Quash", "Bulldoze", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(245, "Suicune", PokemonData.Type.WATER, PokemonData.Type.NONE, "Pressure", null, "Inner-focus",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 187f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 2, 0, PokemonData.PokedexColor.BLUE, 35,
    "Aurora", "It races around the world to purify fouled water. It dashes away with the north wind.",
    100, 75, 115, 90, 115, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 8, 15, 22, 29, 36, 43},
    new string[]
    {
         "Leer", "Bite", "Hydro Pump", "Extrasensory", "Tailwind", "Bubble Beam", "Rain Dance", "Gust", "Aurora Beam", "Mist", "Mirror Coat",
    },
    new string[]
    {
         "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Reflect", "Waterfall", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Calm_Mind", "Giga_Impact", "Round", "Scald", "Quash", "Bulldoze", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(246, "Larvitar", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Guts", null, "Sand-veil",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 72f,
    60, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 35,
    "Rock Skin", "It feeds on soil. After it has eaten a large mountain,it falls asleep so it can grow.",
    50, 64, 50, 45, 50, 41, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 46, 50, 55},
    new string[]
    {
         "Leer", "Bite", "Sandstorm", "Screech", "Chip Away", "Rock Slide", "Scary Face", "Thrash", "Dark Pulse", "Payback", "Crunch", "Earthquake", "Stone Edge", "Hyper Beam",
    },
    new string[]
    {
         "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Payback", "Rock_Polish", "Dark_Pulse", "Stone_Edge", "Smack_Down", "Round", "Retaliate", "Bulldoze", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {247}, new string[] {"Level,30"}),


new PokemonData(247, "Pupitar", PokemonData.Type.ROCK, PokemonData.Type.GROUND, "Shed-skin", null, null,
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.2f, 152f,
    144, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 35,
    "Hard Shell", "Its body is as hard as bedrock. By ventingpressurized gas, it can launch itself like a rocket.",
    70, 84, 70, 65, 70, 51, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 14, 23, 28, 34, 41, 54, 60, 67},
    new string[]
    {
         "Leer", "Bite", "Screech", "Sandstorm", "Chip Away", "Scary Face", "Thrash", "Dark Pulse", "Payback", "Earthquake", "Stone Edge", "Hyper Beam",
    },
    new string[]
    {
         "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Payback", "Rock_Polish", "Dark_Pulse", "Stone_Edge", "Smack_Down", "Round", "Retaliate", "Bulldoze", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {248}, new string[] {"Level,55"}),


new PokemonData(248, "Tyranitar", PokemonData.Type.ROCK, PokemonData.Type.DARK, "Sand-stream", null, "Unnerve",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2f, 202f,
    270, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 35,
    "Armor", "In just one of its mighty hands, it has the power tomake the ground shake and mountains crumble.",
    100, 134, 110, 95, 100, 61, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 14, 23, 28, 34, 41, 54, 63, 73, 82},
    new string[]
    {
         "Leer", "Bite", "Screech", "Sandstorm", "Thunder Fang", "Ice Fang", "Fire Fang", "Chip Away", "Scary Face", "Thrash", "Dark Pulse", "Payback", "Earthquake", "Stone Edge", "Hyper Beam", "Giga Impact",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Payback", "Fling", "Rock_Polish", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Incinerate", "Retaliate", "Bulldoze", "Dragon_Tail", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(249, "Lugia", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Pressure", null, "Multiscale",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 5.2f, 216f,
    306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.WHITE, 0,
    "Diving", "It sleeps in a deep-sea trench. If it flaps its wings,it is said to cause a 40-day storm.",
    106, 90, 130, 90, 154, 110, 0, Color.clear,
    new int[] { 1, 1, 9, 15, 23, 29, 37, 43, 50, 57, 65, 71, 79, 85, 93, 99},
    new string[]
    {
         "Whirlwind", "Weather Ball", "Gust", "Dragon Rush", "Extrasensory", "Rain Dance", "Hydro Pump", "Aeroblast", "Punishment", "Ancient Power", "Safeguard", "Recover", "Future Sight", "Natural Gift", "Calm Mind", "Sky Attack",
    },
    new string[]
    {
         "Fly", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Aerial_Ace", "Calm_Mind", "Roost", "Giga_Impact", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Sky_Drop", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(250, "Ho-oh", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Pressure", null, "Regenerator",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 3.8f, 199f,
    306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.RED, 0,
    "Rainbow", "A legend says that its body glows in seven colors. A rainbow is said to form behind it when it flies.",
    106, 130, 90, 110, 154, 90, 0, Color.clear,
    new int[] { 1, 1, 9, 15, 23, 29, 37, 43, 50, 57, 65, 71, 79, 85, 93, 99},
    new string[]
    {
         "Whirlwind", "Weather Ball", "Gust", "Brave Bird", "Extrasensory", "Sunny Day", "Fire Blast", "Sacred Fire", "Punishment", "Ancient Power", "Safeguard", "Recover", "Future Sight", "Natural Gift", "Calm Mind", "Sky Attack",
    },
    new string[]
    {
         "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Overheat", "Aerial_Ace", "Calm_Mind", "Roost", "Giga_Impact", "Charge_Beam", "Flame_Charge", "Round", "Echoed_Voice", "Sky_Drop", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(251, "Celebi", PokemonData.Type.PSYCHIC, PokemonData.Type.GRASS, "Natural-cure", null, null,
    112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.6f, 5f,
    270, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 100,
    "Time Travel", "This Pokémon wanders across time. Grass and treesflourish in the forests in which it has appeared.",
    100, 100, 100, 100, 100, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 19, 28, 37, 46, 55, 64, 73, 82, 91},
    new string[]
    {
         "Leech Seed", "Confusion", "Recover", "Heal Bell", "Safeguard", "Magical Leaf", "Ancient Power", "Baton Pass", "Natural Gift", "Heal Block", "Future Sight", "Healing Wish", "Leaf Storm", "Perish Song",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Nature_Power", "Aerial_Ace", "Calm_Mind", "U_turn", "Fling", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(252, "Treecko", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Unburden",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 5f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Wood Gecko", "It quickly scales even vertical walls. It senseshumidity with its tail to predict the nextday’s weather.",
    40, 45, 35, 65, 55, 70, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 46, 50},
    new string[]
    {
         "Pound", "Leer", "Absorb", "Quick Attack", "Pursuit", "Screech", "Mega Drain", "Agility", "Slam", "Detect", "Giga Drain", "Energy Ball",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Energy_Ball", "Grass_Knot", "Round", "Acrobatics", "Confide", "Power_Up_Punch"
    },
    new int[] {253}, new string[] {"Level,16"}),


new PokemonData(253, "Grovyle", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Unburden",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 21.6f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
    "Wood Gecko", "Its strongly developed thigh muscles give itastounding agility and jumping performance.",
    50, 65, 45, 85, 65, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 16, 17, 29, 41, 47, 53, 59},
    new string[]
    {
         "Pound", "Leer", "Absorb", "Quick Attack", "Fury Cutter", "Pursuit", "Leaf Blade", "Slam", "Detect", "False Swipe", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "X_Scissor", "Energy_Ball", "Grass_Knot", "Low_Sweep", "Round", "Acrobatics", "Confide", "Power_Up_Punch"
    },
    new int[] {254}, new string[] {"Level,36"}),


new PokemonData(254, "Sceptile", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Unburden",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.7f, 52.2f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.GREEN, 70,
    "Forest", "The leaves that grow on its arms can slice downthick trees. It is without peer in jungle combat.",
    70, 85, 65, 105, 85, 120, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 16, 17, 29, 43, 51, 59},
    new string[]
    {
         "Pound", "Leer", "Absorb", "Quick Attack", "Night Slash", "Leaf Storm", "X-Scissor", "Pursuit", "Leaf Blade", "Slam", "Detect", "False Swipe",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Fling", "X_Scissor", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Acrobatics", "Bulldoze", "Confide", "Power_Up_Punch"
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
         "Swords_Dance", "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Overheat", "Rock_Tomb", "Aerial_Ace", "Shadow_Claw", "Hone_Claws", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Confide"
    },
    new int[] {256}, new string[] {"Level,16"}),


new PokemonData(256, "Combusken", PokemonData.Type.FIRE, PokemonData.Type.FIGHTING, "Blaze", null, "Speed-boost",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.9f, 19.5f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Young Fowl", "Its kicking mastery lets it loose 10 kicks persecond. It emits sharp cries to intimidate foes.",
    60, 85, 60, 85, 60, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 16, 21, 28, 32, 39, 50, 54},
    new string[]
    {
         "Scratch", "Growl", "Ember", "Focus Energy", "Double Kick", "Sand Attack", "Bulk Up", "Quick Attack", "Slash", "Sky Uppercut", "Flare Blitz",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Fling", "Poison_Jab", "Focus_Blast", "Shadow_Claw", "Hone_Claws", "Flame_Charge", "Low_Sweep", "Round", "Echoed_Voice", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {257}, new string[] {"Level,36"}),


new PokemonData(257, "Blaziken", PokemonData.Type.FIRE, PokemonData.Type.FIGHTING, "Blaze", null, "Speed-boost",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.9f, 52f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Blaze", "It can clear a 30-story building in a leap. Its fiery punches scorch its foes.",
    80, 120, 70, 110, 70, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 16, 21, 28, 32, 36, 42, 59},
    new string[]
    {
         "Fire Punch", "Scratch", "Growl", "Ember", "Focus Energy", "Flare Blitz", "Double Kick", "Sand Attack", "Bulk Up", "Quick Attack", "Blaze Kick", "Slash", "Sky Uppercut",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Flame_Charge", "Low_Sweep", "Round", "Echoed_Voice", "Incinerate", "Acrobatics", "Bulldoze", "Confide", "Power_Up_Punch"
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
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Sludge_Wave", "Round", "Echoed_Voice", "Scald", "Confide"
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
         "Tackle", "Growl", "Water Gun", "Mud-Slap", "Bide", "Mud Shot", "Mud Bomb", "Take Down", "Muddy Water", "Protect", "Endeavor",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "Sludge_Wave", "Round", "Echoed_Voice", "Scald", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {260}, new string[] {"Level,36"}),


new PokemonData(260, "Swampert", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Torrent", null, "Damp",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.5f, 81.9f,
    241, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Mud Fish", "Its arms are hard as rock. With one swing, it canbreak a boulder into pieces.",
    100, 110, 90, 85, 90, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 15, 16, 31, 39, 46, 61},
    new string[]
    {
         "Tackle", "Growl", "Water Gun", "Mud-Slap", "Hammer Arm", "Bide", "Mud Shot", "Take Down", "Muddy Water", "Protect", "Endeavor",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Sludge_Wave", "Round", "Echoed_Voice", "Scald", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(261, "Poochyena", PokemonData.Type.DARK, PokemonData.Type.NONE, "Run-away", "Quick-feet", "Rattled",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 13.6f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Bite", "A Pokémon with a persistent nature, it chases itschosen prey until the prey becomes exhausted.",
    35, 55, 35, 30, 30, 35, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53},
    new string[]
    {
         "Tackle", "Howl", "Sand Attack", "Bite", "Odor Sleuth", "Roar", "Swagger", "Assurance", "Scary Face", "Taunt", "Embargo", "Take Down", "Sucker Punch", "Crunch",
    },
    new string[]
    {
         "Roar", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Payback", "Embargo", "Dark_Pulse", "Round", "Incinerate", "Retaliate", "Snarl", "Confide"
    },
    new int[] {262}, new string[] {"Level,18"}),


new PokemonData(262, "Mightyena", PokemonData.Type.DARK, PokemonData.Type.NONE, "Intimidate", "Quick-feet", "Moxie",
    50f, 127, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 37f,
    147, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Bite", "It will always obey the commands of a skilledTrainer. Its behavior arises from its living in packsin ancient times.",
    70, 90, 70, 60, 60, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 27, 37, 47, 52, 57, 62},
    new string[]
    {
         "Sand Attack", "Bite", "Crunch", "Howl", "Odor Sleuth", "Swagger", "Scary Face", "Embargo", "Take Down", "Thief", "Sucker Punch",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Payback", "Embargo", "Dark_Pulse", "Giga_Impact", "Round", "Incinerate", "Retaliate", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(263, "Zigzagoon", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Gluttony", "Quick-feet",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 17.5f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Tiny Raccoon", "It walks in zigzag fashion. It’s good at findingitems in the grass and even in the ground.",
    38, 30, 41, 30, 41, 60, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 11, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49},
    new string[]
    {
         "Tackle", "Growl", "Tail Whip", "Headbutt", "Baby-Doll Eyes", "Sand Attack", "Odor Sleuth", "Mud Sport", "Pin Missile", "Covet", "Bestow", "Flail", "Rest", "Belly Drum", "Fling",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Fling", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {264}, new string[] {"Level,20"}),


new PokemonData(264, "Linoone", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Gluttony", "Quick-feet",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 32.5f,
    147, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.WHITE, 70,
    "Rushing", "When running in a straight line, it can easily top60 miles an hour. It has a tough time withcurved roads.",
    78, 70, 61, 50, 61, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 13, 17, 23, 29, 35, 41, 47, 53, 59, 65},
    new string[]
    {
         "Headbutt", "Tail Whip", "Switcheroo", "Rototiller", "Play Rough", "Sand Attack", "Odor Sleuth", "Mud Sport", "Fury Swipes", "Covet", "Bestow", "Slash", "Rest", "Belly Drum", "Fling",
    },
    new string[]
    {
         "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Fling", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(265, "Wurmple", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shield-dust", null, "Run-away",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 3.6f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Worm", "It loves to eat leaves. If it is attacked by a Starly,it will defend itself with its spiked rear.",
    45, 45, 35, 20, 30, 20, 0, Color.clear,
    new int[] { 1, 1, 5, 15},
    new string[]
    {
         "Tackle", "String Shot", "Poison Sting", "Bug Bite",
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
    new int[] { 1, 13, 17, 20, 27, 31, 34, 38, 41, 45},
    new string[]
    {
         "Absorb", "Gust", "Stun Spore", "Morning Sun", "Whirlwind", "Attract", "Silver Wind", "Giga Drain", "Bug Buzz", "Quiver Dance",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "U_turn", "Energy_Ball", "Giga_Impact", "Venoshock", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Infestation"
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
    new int[] { 1, 13, 17, 20, 24, 27, 34, 38, 41, 45},
    new string[]
    {
         "Confusion", "Gust", "Protect", "Moonlight", "Psybeam", "Whirlwind", "Silver Wind", "Toxic", "Bug Buzz", "Quiver Dance",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "U_turn", "Energy_Ball", "Giga_Impact", "Venoshock", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(270, "Lotad", PokemonData.Type.WATER, PokemonData.Type.GRASS, "Swift-swim", "Rain-dish", "Own-tempo",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 2.6f,
    44, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Water Weed", "It looks like an aquatic plant and serves as a ferryto Pokémon that can’t swim.",
    40, 30, 30, 40, 50, 30, 0, Color.clear,
    new int[] { 1, 3, 5, 7, 11, 15, 19, 25, 31, 37, 45},
    new string[]
    {
         "Astonish", "Growl", "Absorb", "Nature Power", "Mist", "Natural Gift", "Mega Drain", "Bubble Beam", "Zen Headbutt", "Rain Dance", "Energy Ball",
    },
    new string[]
    {
         "Swords_Dance", "Surf", "Ice_Beam", "Blizzard", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Hail", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Echoed_Voice", "Scald", "Confide"
    },
    new int[] {271}, new string[] {"Level,14"}),


new PokemonData(271, "Lombre", PokemonData.Type.WATER, PokemonData.Type.GRASS, "Swift-swim", "Rain-dish", "Own-tempo",
    50f, 120, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 32.5f,
    119, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.GREEN, 70,
    "Jolly", "It lives at the water’s edge where it is sunny. It sleeps on a bed of water-grass by day andbecomes active at night.",
    60, 50, 50, 60, 70, 50, 0, Color.clear,
    new int[] { 1, 3, 5, 7, 11, 15, 19, 25, 31, 37, 45},
    new string[]
    {
         "Astonish", "Growl", "Absorb", "Nature Power", "Fake Out", "Fury Swipes", "Water Sport", "Bubble Beam", "Zen Headbutt", "Uproar", "Hydro Pump",
    },
    new string[]
    {
         "Swords_Dance", "Surf", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Nature_Power", "Brick_Break", "Fling", "Energy_Ball", "Grass_Knot", "Hone_Claws", "Round", "Echoed_Voice", "Scald", "Confide", "Power_Up_Punch"
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
         "Growl", "Mega Drain", "Nature Power", "Astonish",
    },
    new string[]
    {
         "Swords_Dance", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Nature_Power", "Brick_Break", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Hone_Claws", "Round", "Echoed_Voice", "Scald", "Confide", "Power_Up_Punch"
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
         "Swords_Dance", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Explosion", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Retaliate", "Confide"
    },
    new int[] {274}, new string[] {"Level,14"}),


new PokemonData(274, "Nuzleaf", PokemonData.Type.GRASS, PokemonData.Type.DARK, "Chlorophyll", "Early-bird", "Pickpocket",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1f, 28f,
    119, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Wily", "The sound of its grass flute makes its listenersuneasy. It lives deep in forests.",
    70, 70, 40, 60, 40, 60, 0, Color.clear,
    new int[] { 1, 1, 3, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Pound", "Razor Leaf", "Harden", "Growth", "Nature Power", "Fake Out", "Torment", "Feint Attack", "Razor Wind", "Swagger", "Extrasensory",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Payback", "Embargo", "Fling", "Dark_Pulse", "Energy_Ball", "Grass_Knot", "Low_Sweep", "Round", "Retaliate", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(275, "Shiftry", PokemonData.Type.GRASS, PokemonData.Type.DARK, "Chlorophyll", "Early-bird", "Pickpocket",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.3f, 59.6f,
    216, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Wicked", "A Pokémon that was feared as a forest guardian. It can read the foe’s mind and takepreemptive action.",
    90, 100, 60, 90, 60, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 19, 49},
    new string[]
    {
         "Whirlwind", "Razor Leaf", "Feint Attack", "Nasty Plot", "Leaf Tornado", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Embargo", "Fling", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Low_Sweep", "Round", "Retaliate", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(276, "Taillow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Guts", null, "Scrappy",
    50f, 200, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 2.3f,
    54, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Tiny Swallow", "It has a gutsy spirit that makes it bravely take ontough foes. It flies in search of warm climates.",
    40, 55, 30, 30, 30, 85, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 13, 19, 26, 34, 43, 53},
    new string[]
    {
         "Growl", "Peck", "Focus Energy", "Quick Attack", "Wing Attack", "Double Team", "Endeavor", "Aerial Ace", "Agility", "Air Slash",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {277}, new string[] {"Level,22"}),


new PokemonData(277, "Swellow", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Guts", null, "Scrappy",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.7f, 19.8f,
    159, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
    "Swallow", "If its two tail feathers are standing at attention, it isproof of good health. It soars elegantly in the sky.",
    60, 85, 60, 75, 50, 125, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 13, 38, 49},
    new string[]
    {
         "Growl", "Peck", "Quick Attack", "Focus Energy", "Pluck", "Air Slash", "Wing Attack", "Aerial Ace", "Agility",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Giga_Impact", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(278, "Wingull", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Keen-eye", "Hydration", "Rain-dish",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 9.5f,
    54, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.WHITE, 70,
    "Seagull", "Catching sea winds with its long wings, it soarsas if it were a glider. It folds its wings to rest.",
    40, 30, 30, 55, 30, 85, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 14, 17, 22, 26, 30, 33, 38, 42, 46, 49},
    new string[]
    {
         "Growl", "Water Gun", "Supersonic", "Wing Attack", "Mist", "Water Pulse", "Quick Attack", "Roost", "Pursuit", "Air Cutter", "Agility", "Aerial Ace", "Air Slash", "Hurricane",
    },
    new string[]
    {
         "Fly", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Aerial_Ace", "Roost", "U_turn", "Round", "Echoed_Voice", "Scald", "Confide"
    },
    new int[] {279}, new string[] {"Level,25"}),


new PokemonData(279, "Pelipper", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Keen-eye", "Drizzle", "Rain-dish",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 28f,
    154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Water Bird", "It dips its large bill in the sea, then scoops upnumerous prey along with water.",
    60, 50, 100, 95, 70, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 6, 14, 17, 28, 34, 39, 39, 39, 46, 63},
    new string[]
    {
         "Wing Attack", "Water Gun", "Hydro Pump", "Water Sport", "Tailwind", "Soak", "Supersonic", "Mist", "Water Pulse", "Roost", "Brine", "Stockpile", "Spit Up", "Swallow", "Fling", "Hurricane",
    },
    new string[]
    {
         "Fly", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Aerial_Ace", "Roost", "U_turn", "Payback", "Fling", "Giga_Impact", "Round", "Echoed_Voice", "Scald", "Sky_Drop", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(280, "Ralts", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Synchronize", "Trace", "Telepathy",
    50f, 235, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.4f, 6.6f,
    40, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Feeling", "If its horns capture the warm feelings of people orPokémon, its body warms up slightly.",
    28, 25, 25, 45, 35, 40, 0, Color.clear,
    new int[] { 1, 6, 10, 12, 17, 21, 23, 28, 32, 34, 39, 43, 45, 49, 54},
    new string[]
    {
         "Growl", "Confusion", "Double Team", "Teleport", "Lucky Chant", "Magical Leaf", "Heal Pulse", "Calm Mind", "Psychic", "Imprison", "Future Sight", "Charm", "Hypnosis", "Dream Eater", "Stored Power",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Calm_Mind", "Fling", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {281}, new string[] {"Level,20"}),


new PokemonData(281, "Kirlia", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Synchronize", "Trace", "Telepathy",
    50f, 120, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.8f, 20.2f,
    97, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Emotion", "The cheerful spirit of its Trainer gives it energy forits psychokinetic power. It spins and danceswhen happy.",
    38, 35, 35, 65, 55, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 17, 22, 25, 31, 39, 45, 50, 53, 59, 64},
    new string[]
    {
         "Growl", "Confusion", "Teleport", "Double Team", "Lucky Chant", "Magical Leaf", "Heal Pulse", "Calm Mind", "Imprison", "Future Sight", "Charm", "Hypnosis", "Dream Eater", "Stored Power",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Calm_Mind", "Fling", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {282}, new string[] {"Level,30"}),


new PokemonData(282, "Gardevoir", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Synchronize", "Trace", "Telepathy",
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.6f, 48.4f,
    233, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Embrace", "To protect its Trainer, it will expend all its psychicpower to create a small black hole.",
    68, 65, 65, 125, 115, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 10, 17, 22, 33, 45, 53, 60, 65, 73},
    new string[]
    {
         "Growl", "Confusion", "Teleport", "Healing Wish", "Stored Power", "Misty Terrain", "Moonblast", "Double Team", "Wish", "Magical Leaf", "Calm Mind", "Imprison", "Future Sight", "Captivate", "Hypnosis", "Dream Eater",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Calm_Mind", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(283, "Surskit", PokemonData.Type.BUG, PokemonData.Type.WATER, "Swift-swim", null, "Rain-dish",
    50f, 200, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 1.7f,
    54, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Pond Skater", "They usually live on ponds, but after an eveningshower, they may appear on puddles in towns.",
    40, 30, 32, 50, 52, 65, 0, Color.clear,
    new int[] { 1, 7, 13, 19, 25, 31, 37, 37, 43, 46},
    new string[]
    {
         "Bubble", "Quick Attack", "Sweet Scent", "Water Sport", "Bubble Beam", "Agility", "Mist", "Haze", "Baton Pass", "Sticky Web",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Round", "Scald", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {284}, new string[] {"Level,22"}),


new PokemonData(284, "Masquerain", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Intimidate", null, "Unnerve",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 3.6f,
    159, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Eyeball", "Its antennae have eye patterns on them. Its fourwings enable it to hover and fly in any direction.",
    70, 60, 62, 100, 82, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 22, 26},
    new string[]
    {
         "Whirlwind", "Quick Attack", "Sweet Scent", "Water Sport", "Bug Buzz", "Quiver Dance", "Gust", "Scary Face",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "U_turn", "Energy_Ball", "Giga_Impact", "Round", "Scald", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(285, "Shroomish", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Effect-spore", "Poison-heal", "Quick-feet",
    50f, 255, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 4.5f,
    59, PokemonData.LevelingRate.ERRATIC, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Mushroom", "It prefers damp places. By day it remains still inthe forest shade. It releases toxic powder fromits head.",
    60, 40, 60, 40, 60, 35, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Absorb", "Tackle", "Stun Spore", "Leech Seed", "Mega Drain", "Headbutt", "Poison Powder", "Worry Seed", "Growth", "Giga Drain", "Seed Bomb", "Spore",
    },
    new string[]
    {
         "Swords_Dance", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Confide"
    },
    new int[] {286}, new string[] {"Level,23"}),


new PokemonData(286, "Breloom", PokemonData.Type.GRASS, PokemonData.Type.FIGHTING, "Effect-spore", "Poison-heal", "Technician",
    50f, 90, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.2f, 39.2f,
    161, PokemonData.LevelingRate.ERRATIC, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Mushroom", "Its short arms stretch when it throws punches. Itstechnique is equal to that of pro boxers.",
    60, 130, 80, 60, 60, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 17, 21, 23, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Absorb", "Leech Seed", "Stun Spore", "Mega Drain", "Headbutt", "Mach Punch", "Force Palm", "Sky Uppercut", "Mind Reader", "Seed Bomb", "Dynamic Punch",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Venoshock", "Low_Sweep", "Round", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(287, "Slakoth", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Truant", null, null,
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 24f,
    56, PokemonData.LevelingRate.SLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Slacker", "The way Slakoth lolls around makes anyone whowatches it feel like doing the same.",
    60, 60, 60, 35, 35, 30, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Scratch", "Yawn", "Encore", "Slack Off", "Feint Attack", "Amnesia", "Covet", "Chip Away", "Counter", "Flail",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Fling", "Shadow_Claw", "Hone_Claws", "Round", "Incinerate", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {288}, new string[] {"Level,18"}),


new PokemonData(288, "Vigoroth", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Vital-spirit", null, null,
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 46.5f,
    154, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.WHITE, 70,
    "Wild Monkey", "Its heartbeat is fast and its blood so agitated thatit can’t sit still for one second.",
    80, 80, 80, 55, 55, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 19, 31, 37, 43, 49},
    new string[]
    {
         "Scratch", "Focus Energy", "Reversal", "Encore", "Uproar", "Fury Swipes", "Slash", "Counter", "Chip Away", "Focus Punch",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Fling", "Focus_Blast", "Shadow_Claw", "Hone_Claws", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {289}, new string[] {"Level,36"}),


new PokemonData(289, "Slaking", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Truant", null, null,
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2f, 130.5f,
    252, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Lazy", "The world’s laziest Pokémon. It moves to anotherspot when there’s no food left within its reach.",
    150, 160, 100, 95, 65, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 19, 25, 36, 43, 49, 55},
    new string[]
    {
         "Scratch", "Encore", "Slack Off", "Hammer Arm", "Punishment", "Feint Attack", "Amnesia", "Swagger", "Counter", "Flail", "Fling",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Smack_Down", "Low_Sweep", "Round", "Incinerate", "Quash", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
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
         "Cut", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Aerial_Ace", "X_Scissor", "Hone_Claws", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {291}, new string[] {"Level,20"}),


new PokemonData(291, "Ninjask", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Speed-boost", null, "Infiltrator",
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.8f, 12f,
    160, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Ninja", "Its cry leaves a lasting headache if heard for toolong. It moves so quickly that it is almost invisible.",
    61, 90, 45, 50, 50, 160, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 19, 20, 20, 20, 25, 31, 45, 52},
    new string[]
    {
         "Scratch", "Sand Attack", "Harden", "Leech Life", "Bug Bite", "Mind Reader", "Screech", "Double Team", "Fury Cutter", "Swords Dance", "Slash", "Baton Pass", "X-Scissor",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "U_turn", "X_Scissor", "Giga_Impact", "Hone_Claws", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(292, "Shedinja", PokemonData.Type.BUG, PokemonData.Type.GHOST, "Wonder-guard", null, null,
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.8f, 1.2f,
    83, PokemonData.LevelingRate.FLUCTUATING, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Shed", "A discarded bug shell that came to life. Peering intothe crack on its back is said to steal one’s spirit.",
    1, 90, 45, 30, 30, 40, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 14, 19, 25, 31, 38, 43, 47, 50, 59},
    new string[]
    {
         "Scratch", "Harden", "Leech Life", "Sand Attack", "Fury Swipes", "Mind Reader", "Spite", "Confuse Ray", "Shadow Sneak", "Grudge", "Phantom Force", "Heal Block", "Shadow Ball",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Will_O_Wisp", "Facade", "Aerial_Ace", "X_Scissor", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(293, "Whismur", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Soundproof", null, "Rattled",
    50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 16.3f,
    48, PokemonData.LevelingRate.MEDIUMSLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Whisper", "It usually murmurs but starts cryingloudly if it senses danger. It stopswhen its ear covers are shut.",
    64, 51, 23, 51, 23, 28, 0, Color.clear,
    new int[] { 1, 5, 11, 15, 21, 25, 31, 35, 41, 45, 45, 50},
    new string[]
    {
         "Pound", "Uproar", "Astonish", "Howl", "Supersonic", "Stomp", "Screech", "Roar", "Synchronoise", "Rest", "Sleep Talk", "Hyper Voice",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Fling", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Confide"
    },
    new int[] {294}, new string[] {"Level,20"}),


new PokemonData(294, "Loudred", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Soundproof", null, "Scrappy",
    50f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 40.5f,
    126, PokemonData.LevelingRate.MEDIUMSLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Big Voice", "It shouts loudly by inhaling air, and then uses itswell-developed stomach muscles to exhale.",
    84, 71, 43, 71, 43, 48, 0, Color.clear,
    new int[] { 1, 1, 1, 15, 20, 23, 29, 37, 43, 51, 57, 57},
    new string[]
    {
         "Pound", "Uproar", "Astonish", "Howl", "Bite", "Supersonic", "Stomp", "Screech", "Roar", "Synchronoise", "Rest", "Sleep Talk",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Fling", "Smack_Down", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {295}, new string[] {"Level,40"}),


new PokemonData(295, "Exploud", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Soundproof", null, "Scrappy",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.5f, 84f,
    221, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Loud Noise", "Its howls can be heard over six miles away. It emitsall sorts of noises from the ports on its body.",
    104, 91, 63, 91, 73, 68, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 15, 20, 23, 29, 37, 40, 45, 55, 55, 63, 79},
    new string[]
    {
         "Pound", "Uproar", "Astonish", "Thunder Fang", "Ice Fang", "Fire Fang", "Boomburst", "Howl", "Bite", "Supersonic", "Stomp", "Screech", "Crunch", "Roar", "Rest", "Synchronoise", "Sleep Talk", "Hyper Beam",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Fling", "Focus_Blast", "Giga_Impact", "Smack_Down", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(296, "Makuhita", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Thick-fat", "Guts", "Sheer-force",
    75f, 180, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1f, 86.4f,
    47, PokemonData.LevelingRate.ERRATIC, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Guts", "It toughens up by slamming into thick trees overand over. It gains a sturdy body anddauntless spirit.",
    72, 60, 30, 20, 30, 25, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46},
    new string[]
    {
         "Tackle", "Focus Energy", "Sand Attack", "Arm Thrust", "Vital Throw", "Fake Out", "Whirlwind", "Knock Off", "Smelling Salts", "Belly Drum", "Force Palm", "Seismic Toss", "Wake-Up Slap", "Endure", "Close Combat", "Reversal", "Heavy Slam",
    },
    new string[]
    {
         "Surf", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Fling", "Poison_Jab", "Focus_Blast", "Smack_Down", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {297}, new string[] {"Level,24"}),


new PokemonData(297, "Hariyama", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Thick-fat", "Guts", "Sheer-force",
    75f, 200, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 2.3f, 253.8f,
    166, PokemonData.LevelingRate.ERRATIC, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Arm Thrust", "It stomps on the ground to build power. It can senda 10-ton truck flying with a straight-arm punch.",
    144, 120, 60, 40, 60, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 13, 16, 19, 22, 27, 32, 37, 47, 52, 57, 62},
    new string[]
    {
         "Sand Attack", "Focus Energy", "Arm Thrust", "Brine", "Vital Throw", "Fake Out", "Whirlwind", "Knock Off", "Smelling Salts", "Belly Drum", "Force Palm", "Seismic Toss", "Endure", "Close Combat", "Reversal", "Heavy Slam",
    },
    new string[]
    {
         "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Smack_Down", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(298, "Azurill", PokemonData.Type.NORMAL, PokemonData.Type.FAIRY, "Thick-fat", "Huge-power", "Sap-sipper",
    25f, 150, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.2f, 2f,
    38, PokemonData.LevelingRate.FAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Polka Dot", "A Pokémon that lives by water. It moves quickly onland by bouncing on its big tail.",
    50, 20, 40, 20, 40, 20, 0, Color.clear,
    new int[] { 1, 1, 2, 5, 7, 10, 13, 16, 20, 23},
    new string[]
    {
         "Water Gun", "Splash", "Tail Whip", "Water Sport", "Bubble", "Charm", "Bubble Beam", "Helping Hand", "Slam", "Bounce",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Light_Screen", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(299, "Nosepass", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Sturdy", "Magnet-pull", "Sand-force",
    50f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 97f,
    75, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Compass", "Its magnetic nose always faces north and drawsiron objects to its body to protect itself better.",
    30, 45, 135, 45, 90, 30, 0, Color.clear,
    new int[] { 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43, 46, 50, 50},
    new string[]
    {
         "Tackle", "Harden", "Block", "Rock Throw", "Thunder Wave", "Rock Blast", "Rest", "Spark", "Rock Slide", "Power Gem", "Sandstorm", "Discharge", "Earth Power", "Stone Edge", "Zap Cannon", "Lock-On",
    },
    new string[]
    {
         "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Rock_Polish", "Stone_Edge", "Smack_Down", "Round", "Volt_Switch", "Bulldoze", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(300, "Skitty", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Cute-charm", "Normalize", "Wonder-skin",
    25f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 11f,
    52, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PINK, 70,
    "Kitten", "It can’t stop itself from chasing moving things,and it runs in a circle, chasing its own tail.",
    50, 45, 45, 35, 35, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 42, 46, 49},
    new string[]
    {
         "Tackle", "Tail Whip", "Growl", "Fake Out", "Foresight", "Attract", "Sing", "Double Slap", "Copycat", "Assist", "Charm", "Feint Attack", "Wake-Up Slap", "Covet", "Heal Bell", "Double-Edge", "Captivate", "Play Rough",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Calm_Mind", "Payback", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Retaliate", "Wild_Charge", "Confide"
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
         "Double Slap", "Sing", "Attract", "Fake Out",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Calm_Mind", "Payback", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Retaliate", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(302, "Sableye", PokemonData.Type.DARK, PokemonData.Type.GHOST, "Keen-eye", "Stall", "Prankster",
    50f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.5f, 11f,
    133, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 35,
    "Darkness", "It hides in the darkness of caves. Its diet of gemshas transformed its eyes into gemstones.",
    50, 75, 75, 65, 65, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43, 46},
    new string[]
    {
         "Scratch", "Leer", "Mean Look", "Zen Headbutt", "Foresight", "Night Shade", "Astonish", "Fury Swipes", "Fake Out", "Detect", "Shadow Sneak", "Knock Off", "Feint Attack", "Punishment", "Shadow Claw", "Power Gem", "Confuse Ray",
    },
    new string[]
    {
         "Cut", "Dig", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Calm_Mind", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "Shadow_Claw", "Hone_Claws", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Snarl", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(303, "Mawile", PokemonData.Type.STEEL, PokemonData.Type.FAIRY, "Hyper-cutter", "Intimidate", "Sheer-force",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 11.5f,
    133, PokemonData.LevelingRate.FAST, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Deceiver", "It uses its docile-looking face to lull foes intocomplacency, then bites with its huge,relentless jaws.",
    50, 85, 85, 55, 55, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 46, 50, 50, 50, 60},
    new string[]
    {
         "Growl", "Taunt", "Astonish", "Iron Head", "Fairy Wind", "Fake Tears", "Bite", "Sweet Scent", "Vice Grip", "Feint Attack", "Baton Pass", "Crunch", "Iron Defense", "Sucker Punch", "Stockpile", "Spit Up", "Swallow", "Play Rough",
    },
    new string[]
    {
         "Swords_Dance", "Flamethrower", "Ice_Beam", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Payback", "Embargo", "Fling", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Round", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(304, "Aron", PokemonData.Type.STEEL, PokemonData.Type.ROCK, "Sturdy", "Rock-head", "Heavy-metal",
    50f, 180, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 60f,
    66, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 35,
    "Iron Armor", "It usually lives deep in mountains. However, hungermay drive it to eat railroad tracks and cars.",
    50, 70, 100, 40, 40, 30, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43, 46, 50},
    new string[]
    {
         "Tackle", "Harden", "Mud-Slap", "Headbutt", "Metal Claw", "Iron Defense", "Roar", "Take Down", "Iron Head", "Protect", "Metal Sound", "Iron Tail", "Autotomize", "Heavy Slam", "Double-Edge", "Metal Burst",
    },
    new string[]
    {
         "Cut", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Rock_Polish", "Shadow_Claw", "Hone_Claws", "Round", "Bulldoze", "Confide"
    },
    new int[] {305}, new string[] {"Level,32"}),


new PokemonData(305, "Lairon", PokemonData.Type.STEEL, PokemonData.Type.ROCK, "Sturdy", "Rock-head", "Heavy-metal",
    50f, 90, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 120f,
    151, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 35,
    "Iron Armor", "It loves iron ore. Groups of them fight for territoryby bashing one another with their steel bodies.",
    60, 90, 140, 50, 50, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 11, 15, 18, 22, 25, 29, 34, 45, 51, 56, 62},
    new string[]
    {
         "Headbutt", "Harden", "Mud-Slap", "Metal Claw", "Iron Defense", "Roar", "Take Down", "Iron Head", "Protect", "Metal Sound", "Autotomize", "Heavy Slam", "Double-Edge", "Metal Burst",
    },
    new string[]
    {
         "Cut", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Rock_Polish", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Round", "Bulldoze", "Confide"
    },
    new int[] {306}, new string[] {"Level,42"}),


new PokemonData(306, "Aggron", PokemonData.Type.STEEL, PokemonData.Type.ROCK, "Sturdy", "Rock-head", "Heavy-metal",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.1f, 360f,
    239, PokemonData.LevelingRate.SLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.GRAY, 35,
    "Iron Armor", "It claims an entire mountain as its own. The more wounds it has, the more it has battled,so don’t take it lightly.",
    70, 110, 180, 60, 60, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 11, 15, 18, 22, 25, 29, 34, 48, 57, 65, 74},
    new string[]
    {
         "Headbutt", "Harden", "Mud-Slap", "Metal Claw", "Iron Defense", "Roar", "Take Down", "Iron Head", "Protect", "Metal Sound", "Autotomize", "Heavy Slam", "Double-Edge", "Metal Burst",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Payback", "Fling", "Rock_Polish", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(307, "Meditite", PokemonData.Type.FIGHTING, PokemonData.Type.PSYCHIC, "Pure-power", null, "Telepathy",
    50f, 180, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 0.6f, 11.2f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Meditate", "It always trains deep in mountains. It levitateswhen it heightens its spiritual powerthrough meditation.",
    30, 40, 55, 40, 55, 60, 0, Color.clear,
    new int[] { 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43, 46, 50},
    new string[]
    {
         "Bide", "Meditate", "Confusion", "Detect", "Hidden Power", "Mind Reader", "Feint", "Calm Mind", "Force Palm", "High Jump Kick", "Psych Up", "Acupressure", "Power Trick", "Reversal", "Recover",
    },
    new string[]
    {
         "Strength", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Calm_Mind", "Fling", "Poison_Jab", "Focus_Blast", "Grass_Knot", "Psyshock", "Low_Sweep", "Round", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {308}, new string[] {"Level,37"}),


new PokemonData(308, "Medicham", PokemonData.Type.FIGHTING, PokemonData.Type.PSYCHIC, "Pure-power", null, "Telepathy",
    50f, 90, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.3f, 31.5f,
    144, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.RED, 70,
    "Meditate", "It elegantly avoids attacks with dance-like steps,then launches a devastating blow in thesame motion.",
    60, 60, 75, 60, 75, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 4, 18, 22, 25, 29, 32, 36, 42, 49, 55, 62},
    new string[]
    {
         "Fire Punch", "Ice Punch", "Thunder Punch", "Confusion", "Bide", "Detect", "Zen Headbutt", "Meditate", "Mind Reader", "Feint", "Calm Mind", "Force Palm", "High Jump Kick", "Psych Up", "Acupressure", "Power Trick", "Reversal", "Recover",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Calm_Mind", "Fling", "Poison_Jab", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Psyshock", "Low_Sweep", "Round", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(309, "Electrike", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", "Lightning-rod", "Minus",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 15.2f,
    59, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Lightning", "Using electricity stored in its fur, it stimulates itsmuscles to heighten its reaction speed.",
    40, 45, 40, 65, 40, 65, 0, Color.clear,
    new int[] { 1, 4, 9, 12, 17, 20, 25, 28, 33, 36, 41, 44, 49, 52},
    new string[]
    {
         "Tackle", "Thunder Wave", "Leer", "Howl", "Quick Attack", "Spark", "Odor Sleuth", "Bite", "Thunder Fang", "Roar", "Discharge", "Charge", "Wild Charge", "Thunder",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {310}, new string[] {"Level,26"}),


new PokemonData(310, "Manectric", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Static", "Lightning-rod", "Minus",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.5f, 40.2f,
    166, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Discharge", "It rarely appears before people. It is said to nestwhere lightning has fallen.",
    70, 75, 60, 105, 60, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 17, 20, 25, 42, 49, 54, 61},
    new string[]
    {
         "Tackle", "Leer", "Thunder Wave", "Howl", "Fire Fang", "Electric Terrain", "Quick Attack", "Spark", "Odor Sleuth", "Roar", "Discharge", "Charge", "Wild Charge",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Overheat", "Giga_Impact", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(311, "Plusle", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Plus", null, "Lightning-rod",
    50f, 200, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 4.2f,
    142, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Cheering", "It cheers on friends with pom-poms made of sparks. It drains power from telephone poles.",
    60, 50, 40, 85, 75, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 3, 7, 10, 15, 17, 21, 24, 31, 35, 38, 42, 44, 48, 50},
    new string[]
    {
         "Growl", "Nasty Plot", "Entrainment", "Nuzzle", "Thunder Wave", "Quick Attack", "Helping Hand", "Spark", "Encore", "Play Nice", "Copycat", "Swift", "Fake Tears", "Charge", "Thunder", "Baton Pass", "Agility", "Last Resort",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Fling", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(312, "Minun", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Minus", null, "Volt-absorb",
    50f, 200, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 4.2f,
    142, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Cheering", "Exposure to electricity from Minun and Pluslepromotes blood circulation and relaxes muscles.",
    60, 40, 50, 75, 85, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 3, 7, 10, 15, 17, 21, 24, 31, 35, 38, 42, 44, 48, 51},
    new string[]
    {
         "Growl", "Nasty Plot", "Entrainment", "Nuzzle", "Thunder Wave", "Quick Attack", "Helping Hand", "Spark", "Encore", "Charm", "Copycat", "Swift", "Fake Tears", "Charge", "Thunder", "Baton Pass", "Agility", "Trump Card",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Fling", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(313, "Volbeat", PokemonData.Type.BUG, PokemonData.Type.NONE, "Illuminate", "Swarm", "Prankster",
    100f, 150, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.7f, 17.7f,
    151, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GRAY, 70,
    "Firefly", "It communicates with others by lighting up its rearat night. It loves Illumise’s sweet aroma.",
    65, 73, 75, 47, 85, 85, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Flash", "Double Team", "Confuse Ray", "Moonlight", "Quick Attack", "Tail Glow", "Signal Beam", "Protect", "Helping Hand", "Zen Headbutt", "Bug Buzz", "Double-Edge",
    },
    new string[]
    {
         "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Brick_Break", "Aerial_Ace", "Roost", "U_turn", "Fling", "Charge_Beam", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(314, "Illumise", PokemonData.Type.BUG, PokemonData.Type.NONE, "Oblivious", "Tinted-lens", "Prankster",
    0f, 150, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.6f, 17.7f,
    151, PokemonData.LevelingRate.ERRATIC, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Firefly", "Its fragrance attracts a swarm of Volbeat, so theydraw over 200 patterns in the night sky.",
    65, 47, 75, 73, 85, 85, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Play Nice", "Sweet Scent", "Charm", "Moonlight", "Quick Attack", "Wish", "Encore", "Flatter", "Helping Hand", "Zen Headbutt", "Bug Buzz", "Covet",
    },
    new string[]
    {
         "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Brick_Break", "Aerial_Ace", "Roost", "U_turn", "Fling", "Charge_Beam", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(315, "Roselia", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Natural-cure", "Poison-point", "Leaf-guard",
    50f, 150, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 257, 0.3f, 2f,
    140, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Thorn", "It uses the different poisons in each handseparately when it attacks. The stronger its aroma,the healthier it is.",
    50, 60, 45, 100, 80, 65, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 50},
    new string[]
    {
         "Absorb", "Growth", "Poison Sting", "Stun Spore", "Mega Drain", "Leech Seed", "Magical Leaf", "Grass Whistle", "Giga Drain", "Toxic Spikes", "Sweet Scent", "Ingrain", "Petal Dance", "Toxic", "Aromatherapy", "Synthesis", "Petal Blizzard",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Nature_Power", "Poison_Jab", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(316, "Gulpin", PokemonData.Type.POISON, PokemonData.Type.NONE, "Liquid-ooze", "Sticky-hold", "Gluttony",
    50f, 225, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 257, 0.4f, 10.3f,
    60, PokemonData.LevelingRate.ERRATIC, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Stomach", "It has a small heart and brain. Its stomachcomprises most of its body, with enzymes todissolve anything.",
    70, 43, 53, 43, 53, 40, 0, Color.clear,
    new int[] { 1, 6, 9, 14, 17, 23, 28, 34, 39, 39, 39, 40, 44, 49, 54, 59},
    new string[]
    {
         "Pound", "Yawn", "Poison Gas", "Sludge", "Amnesia", "Encore", "Toxic", "Acid Spray", "Stockpile", "Spit Up", "Swallow", "Belch", "Sludge Bomb", "Gastro Acid", "Wring Out", "Gunk Shot",
    },
    new string[]
    {
         "Ice_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Dream_Eater", "Explosion", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Venoshock", "Sludge_Wave", "Round", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {317}, new string[] {"Level,26"}),


new PokemonData(317, "Swalot", PokemonData.Type.POISON, PokemonData.Type.NONE, "Liquid-ooze", "Sticky-hold", "Gluttony",
    50f, 75, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 257, 1.7f, 80f,
    163, PokemonData.LevelingRate.ERRATIC, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Poison Bag", "It swallows anything whole. It sweats toxic fluidsfrom its follicles to douse foes.",
    100, 73, 83, 73, 83, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 23, 26, 30, 45, 45, 45, 46, 59, 66},
    new string[]
    {
         "Pound", "Sludge", "Poison Gas", "Yawn", "Gunk Shot", "Encore", "Body Slam", "Toxic", "Stockpile", "Spit Up", "Swallow", "Belch", "Gastro Acid", "Wring Out",
    },
    new string[]
    {
         "Ice_Beam", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Dream_Eater", "Explosion", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Giga_Impact", "Venoshock", "Sludge_Wave", "Round", "Bulldoze", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(318, "Carvanha", PokemonData.Type.WATER, PokemonData.Type.DARK, "Rough-skin", null, "Speed-boost",
    50f, 225, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.8f, 20.8f,
    61, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 35,
    "Savage", "They form packs to attack boats and rip out theirhulls to sink them. They live in rivers in the jungle.",
    45, 90, 20, 65, 20, 65, 0, Color.clear,
    new int[] { 1, 1, 6, 8, 11, 16, 18, 21, 26, 28, 31, 36, 38},
    new string[]
    {
         "Leer", "Bite", "Rage", "Focus Energy", "Scary Face", "Ice Fang", "Screech", "Swagger", "Assurance", "Crunch", "Aqua Jet", "Agility", "Take Down",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Torment", "Facade", "Taunt", "Payback", "Dark_Pulse", "Round", "Scald", "Retaliate", "Snarl", "Confide"
    },
    new int[] {319}, new string[] {"Level,30"}),


new PokemonData(319, "Sharpedo", PokemonData.Type.WATER, PokemonData.Type.DARK, "Rough-skin", null, "Speed-boost",
    50f, 60, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 1.8f, 88.8f,
    161, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Brutal", "Its fangs rip through sheet iron. It swims at 75 mphand is known as “The Bully of the Sea. ",
    70, 120, 40, 95, 40, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 11, 21, 26, 28, 30, 34, 40, 45},
    new string[]
    {
         "Leer", "Bite", "Rage", "Focus Energy", "Feint", "Night Slash", "Scary Face", "Swagger", "Assurance", "Crunch", "Slash", "Aqua Jet", "Taunt", "Agility",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Rock_Tomb", "Payback", "Poison_Jab", "Dark_Pulse", "Giga_Impact", "Round", "Scald", "Retaliate", "Bulldoze", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(320, "Wailmer", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-veil", "Oblivious", "Pressure",
    50f, 125, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2f, 130f,
    80, PokemonData.LevelingRate.ERRATIC, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Ball Whale", "It bounces playfully like a ball. The more seawaterit swallows, the higher it bounces.",
    130, 70, 35, 70, 35, 60, 0, Color.clear,
    new int[] { 1, 4, 7, 11, 14, 17, 21, 24, 27, 31, 34, 37, 41, 44, 47, 50},
    new string[]
    {
         "Splash", "Growl", "Water Gun", "Rollout", "Whirlpool", "Astonish", "Water Pulse", "Mist", "Rest", "Brine", "Water Spout", "Amnesia", "Dive", "Bounce", "Hydro Pump", "Heavy Slam",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Round", "Echoed_Voice", "Scald", "Bulldoze", "Confide"
    },
    new int[] {321}, new string[] {"Level,40"}),


new PokemonData(321, "Wailord", PokemonData.Type.WATER, PokemonData.Type.NONE, "Water-veil", "Oblivious", "Pressure",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 14.5f, 398f,
    175, PokemonData.LevelingRate.ERRATIC, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Float Whale", "It can sometimes knock out opponents with theshock created by breaching and crashing its bigbody onto the water.",
    170, 90, 45, 90, 45, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 21, 27, 31, 34, 37, 46, 54, 70},
    new string[]
    {
         "Growl", "Water Gun", "Splash", "Rollout", "Astonish", "Water Pulse", "Rest", "Brine", "Water Spout", "Amnesia", "Dive", "Bounce", "Heavy Slam",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Giga_Impact", "Round", "Echoed_Voice", "Scald", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(322, "Numel", PokemonData.Type.FIRE, PokemonData.Type.GROUND, "Oblivious", "Simple", "Own-tempo",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.7f, 24f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Numb", "Its humped back stores intensely hot magma. In rain, the magma cools, slowing its movement.",
    60, 60, 40, 65, 45, 35, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 19, 22, 26, 29, 31, 36, 40, 43, 47},
    new string[]
    {
         "Tackle", "Growl", "Ember", "Magnitude", "Focus Energy", "Flame Burst", "Amnesia", "Lava Plume", "Earth Power", "Curse", "Take Down", "Yawn", "Earthquake", "Flamethrower", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Overheat", "Rock_Tomb", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {323}, new string[] {"Level,33"}),


new PokemonData(323, "Camerupt", PokemonData.Type.FIRE, PokemonData.Type.GROUND, "Magma-armor", "Solid-rock", "Anger-point",
    50f, 150, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.9f, 220f,
    161, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Eruption", "The volcanoes on its back have a major eruptionevery 10 years--or whenever it becomesreally angry.",
    70, 100, 70, 105, 75, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 15, 19, 22, 29, 31, 33},
    new string[]
    {
         "Tackle", "Growl", "Ember", "Fissure", "Magnitude", "Eruption", "Flame Burst", "Amnesia", "Lava Plume", "Curse", "Take Down", "Rock Slide",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Overheat", "Rock_Tomb", "Rock_Polish", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(324, "Torkoal", PokemonData.Type.FIRE, PokemonData.Type.NONE, "White-smoke", "Drought", "Shell-armor",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 80.4f,
    165, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Coal", "You find abandoned coal mines full of them. They dig tirelessly in search of coal.",
    70, 85, 140, 85, 70, 20, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 4, 7, 12, 17, 20, 23, 25, 28, 33, 36, 39, 49, 60},
    new string[]
    {
         "Ember", "Flail", "Heat Wave", "Shell Smash", "Smog", "Withdraw", "Curse", "Fire Spin", "Smokescreen", "Flame Wheel", "Rapid Spin", "Flamethrower", "Body Slam", "Protect", "Lava Plume", "Amnesia", "Inferno",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Overheat", "Rock_Tomb", "Gyro_Ball", "Giga_Impact", "Stone_Edge", "Flame_Charge", "Round", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(325, "Spoink", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Thick-fat", "Own-tempo", "Gluttony",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 30.6f,
    66, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLACK, 70,
    "Bounce", "It bounces constantly, using its tail like a spring. The shock of bouncing keeps its heart beating.",
    60, 25, 35, 70, 80, 60, 0, Color.clear,
    new int[] { 1, 7, 10, 14, 15, 18, 21, 26, 29, 29, 33, 38, 40, 44, 50},
    new string[]
    {
         "Splash", "Psywave", "Odor Sleuth", "Psybeam", "Psych Up", "Confuse Ray", "Magic Coat", "Zen Headbutt", "Rest", "Snore", "Power Gem", "Psyshock", "Payback", "Psychic", "Bounce",
    },
    new string[]
    {
         "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Calm_Mind", "Payback", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide"
    },
    new int[] {326}, new string[] {"Level,32"}),


new PokemonData(326, "Grumpig", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Thick-fat", "Own-tempo", "Gluttony",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 71.5f,
    165, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Manipulate", "It uses black pearls to amplify its psychic power. It does a strange dance to control foes’ minds.",
    80, 45, 65, 90, 110, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 15, 18, 21, 26, 29, 29, 35, 42, 46},
    new string[]
    {
         "Psybeam", "Psywave", "Odor Sleuth", "Psych Up", "Confuse Ray", "Magic Coat", "Zen Headbutt", "Rest", "Snore", "Power Gem", "Psyshock", "Payback",
    },
    new string[]
    {
         "Hyper_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Brick_Break", "Calm_Mind", "Payback", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(327, "Spinda", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Own-tempo", "Tangled-feet", "Contrary",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 5f,
    126, PokemonData.LevelingRate.FAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Spot Panda", "No two Spinda have the same pattern of spots. Its tottering step fouls the aim of foes.",
    60, 60, 60, 60, 60, 60, 0, Color.clear,
    new int[] { 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 46, 50, 50},
    new string[]
    {
         "Tackle", "Uproar", "Copycat", "Feint Attack", "Psybeam", "Hypnosis", "Dizzy Punch", "Sucker Punch", "Teeter Dance", "Psych Up", "Double-Edge", "Thrash", "Flail",
    },
    new string[]
    {
         "Strength", "Dig", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Calm_Mind", "Fling", "Trick_Room", "Round", "Retaliate", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(328, "Trapinch", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Hyper-cutter", "Arena-trap", "Sheer-force",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.7f, 15f,
    58, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Ant Pit", "It lives in arid deserts. It makes a sloping pit trap insand where it patiently awaits prey.",
    45, 100, 45, 45, 45, 10, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 4, 7, 13, 17, 21, 25, 34, 44, 49, 55},
    new string[]
    {
         "Bite", "Fissure", "Superpower", "Feint", "Sand Attack", "Feint Attack", "Mud-Slap", "Bide", "Bulldoze", "Rock Slide", "Crunch", "Sandstorm", "Hyper Beam", "Earthquake",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Round", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {329}, new string[] {"Level,35"}),


new PokemonData(329, "Vibrava", PokemonData.Type.GROUND, PokemonData.Type.DRAGON, "Levitate", null, null,
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.1f, 15.3f,
    119, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Vibration", "The ultrasonic waves it generates by rubbing its twowings together cause severe headaches.",
    50, 70, 50, 50, 50, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 21, 25, 34, 35, 44, 49},
    new string[]
    {
         "Sand Attack", "Sonic Boom", "Feint Attack", "Sand Tomb", "Bide", "Bulldoze", "Rock Slide", "Screech", "Dragon Breath", "Sandstorm", "Hyper Beam",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Roost", "U_turn", "Round", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {330}, new string[] {"Level,45"}),


new PokemonData(330, "Flygon", PokemonData.Type.GROUND, PokemonData.Type.DRAGON, "Levitate", null, null,
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 2f, 82f,
    234, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
    "Mystic", "It hides itself by kicking up desert sand with itswings. Red covers shield its eyes from sand.",
    80, 100, 80, 80, 80, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 21, 25, 34, 35, 39, 44, 45, 49},
    new string[]
    {
         "Sand Attack", "Sonic Boom", "Feint Attack", "Sand Tomb", "Bide", "Bulldoze", "Rock Slide", "Screech", "Dragon Breath", "Earth Power", "Sandstorm", "Dragon Tail", "Hyper Beam",
    },
    new string[]
    {
         "Fly", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Roost", "U_turn", "Giga_Impact", "Stone_Edge", "Hone_Claws", "Round", "Incinerate", "Struggle_Bug", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(331, "Cacnea", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Sand-veil", null, "Water-absorb",
    50f, 190, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 51.3f,
    67, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 35,
    "Cactus", "It lives in arid locations. Its yellow flowers bloomonce a year.",
    50, 85, 40, 85, 40, 35, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57},
    new string[]
    {
         "Poison Sting", "Leer", "Absorb", "Growth", "Leech Seed", "Sand Attack", "Pin Missile", "Ingrain", "Feint Attack", "Spikes", "Sucker Punch", "Payback", "Needle Arm", "Cotton Spore", "Sandstorm", "Destiny Bond",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Brick_Break", "Payback", "Fling", "Poison_Jab", "Dark_Pulse", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Confide", "Power_Up_Punch"
    },
    new int[] {332}, new string[] {"Level,32"}),


new PokemonData(332, "Cacturne", PokemonData.Type.GRASS, PokemonData.Type.DARK, "Sand-veil", null, "Water-absorb",
    50f, 60, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 1.3f, 77.4f,
    166, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 35,
    "Scarecrow", "It becomes active at night, seeking prey that isexhausted from the day’s desert heat.",
    70, 115, 60, 115, 60, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 17, 21, 25, 29, 35, 41, 47, 53},
    new string[]
    {
         "Poison Sting", "Leer", "Absorb", "Growth", "Destiny Bond", "Revenge", "Sand Attack", "Pin Missile", "Ingrain", "Feint Attack", "Spikes", "Sucker Punch", "Payback", "Needle Arm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Brick_Break", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Venoshock", "Round", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(333, "Swablu", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Natural-cure", null, "Cloud-nine",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.4f, 1.2f,
    62, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Cotton Bird", "For some reason, it likes to land on people’s headssoftly and act like it’s a hat.",
    45, 40, 60, 40, 75, 50, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 10, 13, 15, 18, 21, 25, 29, 34, 39, 42, 48, 50},
    new string[]
    {
         "Growl", "Peck", "Astonish", "Sing", "Fury Attack", "Safeguard", "Mist", "Round", "Natural Gift", "Take Down", "Refresh", "Mirror Move", "Cotton Guard", "Dragon Pulse", "Perish Song", "Moonblast",
    },
    new string[]
    {
         "Fly", "Ice_Beam", "Solar_Beam", "Toxic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Facade", "Aerial_Ace", "Roost", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {334}, new string[] {"Level,35"}),


new PokemonData(334, "Altaria", PokemonData.Type.DRAGON, PokemonData.Type.FLYING, "Natural-cure", null, "Cloud-nine",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.1f, 20.6f,
    172, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLUE, 70,
    "Humming", "It flies gracefully through the sky. Its melodichumming makes you feel like you’re in a dream.",
    75, 70, 90, 70, 105, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 10, 13, 18, 21, 25, 29, 35, 42, 48, 60},
    new string[]
    {
         "Growl", "Sing", "Peck", "Sky Attack", "Astonish", "Pluck", "Fury Attack", "Safeguard", "Round", "Natural Gift", "Take Down", "Refresh", "Dragon Breath", "Cotton Guard", "Dragon Pulse", "Moonblast",
    },
    new string[]
    {
         "Fly", "Roar", "Flamethrower", "Ice_Beam", "Hyper_Beam", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Aerial_Ace", "Dragon_Claw", "Roost", "Giga_Impact", "Hone_Claws", "Round", "Echoed_Voice", "Incinerate", "Bulldoze", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(335, "Zangoose", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Immunity", null, "Toxic-boost",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.3f, 40.3f,
    160, PokemonData.LevelingRate.FLUCTUATING, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Cat Ferret", "It has feuded with Seviper for many generations. Its sharp claws are its biggest weapons.",
    73, 115, 60, 60, 60, 90, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 19, 22, 26, 29, 33, 36, 40, 43, 47},
    new string[]
    {
         "Scratch", "Leer", "Quick Attack", "Fury Cutter", "Pursuit", "Slash", "Embargo", "Crush Claw", "Revenge", "False Swipe", "Detect", "X-Scissor", "Taunt", "Swords Dance", "Close Combat",
    },
    new string[]
    {
         "Swords_Dance", "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Embargo", "Fling", "Poison_Jab", "X_Scissor", "Focus_Blast", "Shadow_Claw", "Hone_Claws", "Round", "Incinerate", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(336, "Seviper", PokemonData.Type.POISON, PokemonData.Type.NONE, "Shed-skin", null, "Infiltrator",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2.7f, 52.5f,
    160, PokemonData.LevelingRate.ERRATIC, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Fang Snake", "In battle, it uses its bladed tail to counter anyZangoose. It secretes a deadly venom in its tail.",
    73, 100, 60, 100, 60, 65, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 12, 16, 20, 23, 27, 28, 31, 34, 38, 42, 45, 46, 48, 50},
    new string[]
    {
         "Wrap", "Swagger", "Bite", "Lick", "Poison Tail", "Screech", "Venoshock", "Glare", "Poison Fang", "Venom Drench", "Night Slash", "Gastro Acid", "Haze", "Poison Jab", "Crunch", "Belch", "Coil", "Wring Out",
    },
    new string[]
    {
         "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Payback", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Venoshock", "Sludge_Wave", "Round", "Retaliate", "Bulldoze", "Dragon_Tail", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(337, "Lunatone", PokemonData.Type.ROCK, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 168f,
    161, PokemonData.LevelingRate.FAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Meteorite", "Because it turns active on nights of the full moon,it is said to have some link to the lunar phases.",
    90, 55, 65, 95, 85, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49},
    new string[]
    {
         "Tackle", "Rock Throw", "Harden", "Magic Room", "Hypnosis", "Rock Polish", "Psywave", "Embargo", "Rock Slide", "Cosmic Power", "Psychic", "Heal Block", "Stone Edge", "Future Sight", "Explosion",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Embargo", "Rock_Polish", "Giga_Impact", "Trick_Room", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Psyshock", "Smack_Down", "Round", "Acrobatics", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(338, "Solrock", PokemonData.Type.ROCK, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    112.5f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.2f, 154f,
    161, PokemonData.LevelingRate.FAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Meteorite", "Solar energy is the source of its power,so it is strong during the daytime. When it spins, its body shines.",
    90, 95, 85, 55, 65, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49},
    new string[]
    {
         "Tackle", "Rock Throw", "Harden", "Wonder Room", "Fire Spin", "Rock Polish", "Psywave", "Embargo", "Rock Slide", "Cosmic Power", "Psychic", "Heal Block", "Stone Edge", "Solar Beam", "Explosion",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Solar_Beam", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Overheat", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Embargo", "Rock_Polish", "Giga_Impact", "Trick_Room", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Psyshock", "Smack_Down", "Round", "Incinerate", "Acrobatics", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(339, "Barboach", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Oblivious", "Anticipation", "Hydration",
    50f, 190, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.4f, 1.9f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Whiskers", "It coats its entire body with a slimy fluid so it cansquirm and slip away if grabbed.",
    50, 48, 43, 46, 41, 60, 0, Color.clear,
    new int[] { 1, 6, 6, 10, 14, 18, 22, 26, 31, 31, 35, 39, 43, 47},
    new string[]
    {
         "Mud-Slap", "Mud Sport", "Water Sport", "Water Gun", "Mud Bomb", "Amnesia", "Water Pulse", "Magnitude", "Rest", "Snore", "Aqua Tail", "Earthquake", "Future Sight", "Fissure",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Rock_Tomb", "Round", "Scald", "Bulldoze", "Confide"
    },
    new int[] {340}, new string[] {"Level,30"}),


new PokemonData(340, "Whiscash", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Oblivious", "Anticipation", "Hydration",
    50f, 75, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.9f, 23.6f,
    164, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Whiskers", "It claims a large swamp to itself. If a foe comesnear it, it sets off tremors by thrashing around.",
    110, 78, 73, 76, 71, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 14, 18, 26, 33, 33, 39, 45, 51, 57},
    new string[]
    {
         "Mud-Slap", "Mud Sport", "Water Sport", "Zen Headbutt", "Water Gun", "Mud Bomb", "Amnesia", "Magnitude", "Rest", "Snore", "Aqua Tail", "Earthquake", "Future Sight", "Fissure",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Giga_Impact", "Stone_Edge", "Round", "Scald", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(341, "Corphish", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hyper-cutter", "Shell-armor", "Adaptability",
    50f, 205, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 11.5f,
    62, PokemonData.LevelingRate.ERRATIC, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Ruffian", "No matter how dirty the water in the river, it willadapt and thrive. It has a strong will to survive.",
    43, 80, 65, 50, 35, 35, 0, Color.clear,
    new int[] { 1, 7, 10, 13, 20, 23, 26, 32, 35, 38, 44, 47, 53},
    new string[]
    {
         "Bubble", "Harden", "Vice Grip", "Leer", "Bubble Beam", "Protect", "Knock Off", "Taunt", "Night Slash", "Crabhammer", "Swords Dance", "Crunch", "Guillotine",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Fling", "X_Scissor", "Hone_Claws", "Round", "Scald", "Confide"
    },
    new int[] {342}, new string[] {"Level,30"}),


new PokemonData(342, "Crawdaunt", PokemonData.Type.WATER, PokemonData.Type.DARK, "Hyper-cutter", "Shell-armor", "Adaptability",
    50f, 155, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.1f, 32.8f,
    164, PokemonData.LevelingRate.ERRATIC, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Rogue", "It is a ruffian that uses its pincers to pick up andtoss out other Pokémon from its pond.",
    63, 120, 85, 90, 55, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 23, 26, 34, 39, 44, 52, 57, 65},
    new string[]
    {
         "Vice Grip", "Leer", "Harden", "Bubble", "Protect", "Knock Off", "Taunt", "Night Slash", "Crabhammer", "Swords Dance", "Crunch", "Guillotine",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Nature_Power", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Fling", "Dark_Pulse", "X_Scissor", "Giga_Impact", "Hone_Claws", "Sludge_Wave", "Round", "Scald", "Retaliate", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(343, "Baltoy", PokemonData.Type.GROUND, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    112.5f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.5f, 21.5f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BROWN, 70,
    "Clay Doll", "It moves while spinning around on its single foot. Some Baltoy have been seen spinning ontheir heads.",
    40, 40, 55, 40, 70, 55, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 17, 21, 25, 28, 31, 34, 34, 37, 41, 45, 49},
    new string[]
    {
         "Confusion", "Harden", "Rapid Spin", "Mud-Slap", "Rock Tomb", "Psybeam", "Power Trick", "Ancient Power", "Self-Destruct", "Extrasensory", "Cosmic Power", "Guard Split", "Power Split", "Earth Power", "Sandstorm", "Heal Block", "Explosion",
    },
    new string[]
    {
         "Ice_Beam", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Rock_Polish", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Smack_Down", "Round", "Bulldoze", "Confide", "Dazzling_Gleam"
    },
    new int[] {344}, new string[] {"Level,36"}),


new PokemonData(344, "Claydol", PokemonData.Type.GROUND, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    112.5f, 90, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.5f, 108f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLACK, 70,
    "Clay Doll", "An ancient clay figurine that came to life as aPokémon from exposure to a mysterious rayof light.",
    60, 70, 105, 70, 120, 75, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 7, 10, 13, 17, 25, 28, 31, 34, 34, 36, 40, 47, 54, 61},
    new string[]
    {
         "Confusion", "Teleport", "Harden", "Rapid Spin", "Mud-Slap", "Rock Tomb", "Psybeam", "Power Trick", "Self-Destruct", "Extrasensory", "Cosmic Power", "Guard Split", "Power Split", "Hyper Beam", "Earth Power", "Sandstorm", "Heal Block", "Explosion",
    },
    new string[]
    {
         "Ice_Beam", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Rock_Polish", "Giga_Impact", "Trick_Room", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Psyshock", "Smack_Down", "Round", "Bulldoze", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(345, "Lileep", PokemonData.Type.ROCK, PokemonData.Type.GRASS, "Suction-cups", null, "Storm-drain",
    87.5f, 45, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1f, 23.8f,
    71, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sea Lily", "It disguises its tentacles as flowers to attract andcatch prey. It became extinct in ancient times.",
    66, 41, 77, 61, 87, 23, 0, Color.clear,
    new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50, 57, 57, 57, 64},
    new string[]
    {
         "Constrict", "Astonish", "Acid", "Ingrain", "Confuse Ray", "Amnesia", "Gastro Acid", "Ancient Power", "Energy Ball", "Stockpile", "Spit Up", "Swallow", "Wring Out",
    },
    new string[]
    {
         "Swords_Dance", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Rock_Tomb", "Rock_Polish", "Energy_Ball", "Grass_Knot", "Smack_Down", "Round", "Confide", "Infestation"
    },
    new int[] {346}, new string[] {"Level,40"}),


new PokemonData(346, "Cradily", PokemonData.Type.ROCK, PokemonData.Type.GRASS, "Suction-cups", null, "Storm-drain",
    87.5f, 45, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.5f, 60.4f,
    173, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.GREEN, 70,
    "Barnacle", "It lives in the shallows of warm seas. When the tidegoes out, it digs up prey from beaches.",
    86, 81, 97, 81, 107, 43, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 15, 29, 36, 56, 66},
    new string[]
    {
         "Acid", "Constrict", "Stockpile", "Swallow", "Astonish", "Wring Out", "Ingrain", "Amnesia", "Ancient Power", "Energy Ball", "Spit Up",
    },
    new string[]
    {
         "Swords_Dance", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Rock_Polish", "Energy_Ball", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Smack_Down", "Sludge_Wave", "Round", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(347, "Anorith", PokemonData.Type.ROCK, PokemonData.Type.BUG, "Battle-armor", null, "Swift-swim",
    87.5f, 45, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.7f, 12.5f,
    71, PokemonData.LevelingRate.FLUCTUATING, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Old Shrimp", "It is a kind of Pokémon progenitor. It uses itsextending claws to catch prey hiding among rockson the seafloor.",
    45, 95, 50, 40, 50, 75, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49, 55, 61},
    new string[]
    {
         "Scratch", "Harden", "Mud Sport", "Water Gun", "Metal Claw", "Protect", "Ancient Power", "Fury Cutter", "Slash", "Rock Blast", "Crush Claw", "X-Scissor",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Rock_Polish", "X_Scissor", "Hone_Claws", "Smack_Down", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {348}, new string[] {"Level,40"}),


new PokemonData(348, "Armaldo", PokemonData.Type.ROCK, PokemonData.Type.BUG, "Battle-armor", null, "Swift-swim",
    87.5f, 45, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.5f, 68.2f,
    173, PokemonData.LevelingRate.FLUCTUATING, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Plate", "Its enormous, retractable claws can cut throughmost anything. Its entire body is clad insturdy plates.",
    75, 125, 100, 70, 80, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 19, 25, 31, 37, 46, 55, 67, 73},
    new string[]
    {
         "Scratch", "Water Gun", "Mud Sport", "Metal Claw", "Protect", "Ancient Power", "Fury Cutter", "Slash", "Rock Blast", "Crush Claw", "X-Scissor",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Rock_Polish", "X_Scissor", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Struggle_Bug", "Bulldoze", "Confide"
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
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Light_Screen", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(350, "Milotic", PokemonData.Type.WATER, PokemonData.Type.NONE, "Marvel-scale", "Competitive", "Cute-charm",
    50f, 60, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 6.2f, 162f,
    189, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PINK, 70,
    "Tender", "Milotic is breathtakingly beautiful. Those that see itare said to forget their combative spirits.",
    95, 60, 79, 100, 125, 81, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49},
    new string[]
    {
         "Wrap", "Water Gun", "Water Sport", "Refresh", "Water Pulse", "Twister", "Recover", "Captivate", "Aqua Tail", "Rain Dance", "Hydro Pump", "Attract", "Safeguard", "Aqua Ring",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Light_Screen", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Hail", "Facade", "Giga_Impact", "Round", "Scald", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(351, "Castform", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Forecast", null, null,
    50f, 45, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.3f, 0.8f,
    147, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Weather", "This Pokémon can change its cells, taking differentforms based on the temperature and humidity.",
    70, 70, 70, 70, 70, 70, 0, Color.clear,
    new int[] { 1, 10, 10, 10, 15, 20, 20, 20, 30, 40, 40, 40},
    new string[]
    {
         "Tackle", "Ember", "Water Gun", "Powder Snow", "Headbutt", "Rain Dance", "Sunny Day", "Hail", "Weather Ball", "Hydro Pump", "Blizzard", "Fire Blast",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Hail", "Facade", "Energy_Ball", "Round", "Scald", "Incinerate", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(352, "Kecleon", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Color-change", null, "Protean",
    50f, 200, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 22f,
    154, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Color Swap", "It can freely change its body’s color. The zigzagpattern on its belly doesn’t change, however.",
    60, 90, 70, 60, 120, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 4, 7, 10, 14, 18, 22, 27, 32, 37, 43, 49},
    new string[]
    {
         "Scratch", "Tail Whip", "Lick", "Thief", "Ancient Power", "Synchronoise", "Bind", "Feint Attack", "Fury Swipes", "Feint", "Psybeam", "Shadow Sneak", "Slash", "Screech", "Substitute", "Sucker Punch", "Shadow Claw",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Shadow_Claw", "Trick_Room", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Round", "Incinerate", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(353, "Shuppet", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Insomnia", "Frisk", "Cursed-body",
    50f, 225, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 2.3f,
    59, PokemonData.LevelingRate.FAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Puppet", "It uses its horn to feed on envy and malice--or so it’s said. It’s very active at night.",
    44, 75, 35, 63, 33, 45, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 26, 30, 34, 38, 42, 46, 50},
    new string[]
    {
         "Knock Off", "Screech", "Night Shade", "Spite", "Will-O-Wisp", "Shadow Sneak", "Curse", "Feint Attack", "Hex", "Shadow Ball", "Sucker Punch", "Embargo", "Snatch", "Grudge", "Trick",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Calm_Mind", "Payback", "Embargo", "Dark_Pulse", "Trick_Room", "Charge_Beam", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {354}, new string[] {"Level,37"}),


new PokemonData(354, "Banette", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Insomnia", "Frisk", "Cursed-body",
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.1f, 12.5f,
    159, PokemonData.LevelingRate.FAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Marionette", "A doll that became a Pokémon over its grudge frombeing junked. It seeks the child that disowned it.",
    64, 115, 65, 83, 63, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 13, 16, 22, 26, 30, 34, 40, 46, 52, 58},
    new string[]
    {
         "Night Shade", "Curse", "Knock Off", "Screech", "Will-O-Wisp", "Shadow Sneak", "Feint Attack", "Hex", "Shadow Ball", "Sucker Punch", "Embargo", "Snatch", "Grudge", "Trick",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Calm_Mind", "Payback", "Embargo", "Fling", "Dark_Pulse", "Giga_Impact", "Shadow_Claw", "Trick_Room", "Charge_Beam", "Round", "Confide", "Dazzling_Gleam", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(355, "Duskull", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Levitate", null, "Frisk",
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.8f, 15f,
    59, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLACK, 35,
    "Requiem", "It doggedly pursues its prey wherever it goes. However, the chase is abandoned at sunrise.",
    20, 40, 90, 30, 90, 25, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 14, 17, 22, 25, 30, 33, 38, 41, 46, 49},
    new string[]
    {
         "Leer", "Night Shade", "Disable", "Foresight", "Astonish", "Confuse Ray", "Shadow Sneak", "Pursuit", "Curse", "Will-O-Wisp", "Hex", "Mean Look", "Payback", "Future Sight",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Calm_Mind", "Payback", "Embargo", "Fling", "Dark_Pulse", "Trick_Room", "Charge_Beam", "Round", "Confide", "Infestation"
    },
    new int[] {356}, new string[] {"Level,37"}),


new PokemonData(356, "Dusclops", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Pressure", null, "Frisk",
    50f, 90, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.6f, 30.6f,
    159, PokemonData.LevelingRate.FAST, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.BLACK, 35,
    "Beckon", "Anyone who dares peer into its body to see itsspectral ball of fire will have their spirit stolen away.",
    40, 70, 130, 60, 130, 25, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 9, 14, 17, 22, 25, 30, 33, 37, 42, 49, 58, 61},
    new string[]
    {
         "Fire Punch", "Ice Punch", "Thunder Punch", "Bind", "Leer", "Disable", "Gravity", "Foresight", "Astonish", "Confuse Ray", "Shadow Sneak", "Pursuit", "Curse", "Will-O-Wisp", "Shadow Punch", "Hex", "Mean Look", "Payback", "Future Sight",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Calm_Mind", "Payback", "Embargo", "Fling", "Dark_Pulse", "Giga_Impact", "Trick_Room", "Charge_Beam", "Round", "Bulldoze", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(357, "Tropius", PokemonData.Type.GRASS, PokemonData.Type.FLYING, "Chlorophyll", "Solar-power", "Harvest",
    50f, 200, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2f, 100f,
    161, PokemonData.LevelingRate.SLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Fruit", "It flies by flapping its broad leaves and givesthe sweet, delicious fruit around its neckto children.",
    99, 68, 83, 72, 87, 51, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 7, 11, 17, 21, 27, 31, 37, 41, 47, 57, 61},
    new string[]
    {
         "Gust", "Leer", "Natural Gift", "Leaf Storm", "Growth", "Razor Leaf", "Stomp", "Sweet Scent", "Whirlwind", "Magical Leaf", "Body Slam", "Synthesis", "Leaf Tornado", "Bestow", "Solar Beam",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Fly", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Aerial_Ace", "Roost", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(358, "Chimecho", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 1f,
    159, PokemonData.LevelingRate.FAST, 0, 0, 0, 1, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Wind Chime", "It uses the sucker on its head to hang from a treeor from eaves. It can produce seven different tones.",
    75, 50, 80, 95, 90, 65, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 14, 17, 22, 25, 30, 33, 38, 41, 46, 49, 54},
    new string[]
    {
         "Wrap", "Healing Wish", "Growl", "Astonish", "Confusion", "Uproar", "Take Down", "Yawn", "Psywave", "Double-Edge", "Heal Bell", "Safeguard", "Extrasensory", "Heal Pulse", "Synchronoise",
    },
    new string[]
    {
         "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Calm_Mind", "Energy_Ball", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(359, "Absol", PokemonData.Type.DARK, PokemonData.Type.NONE, "Pressure", "Super-luck", "Justified",
    50f, 30, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 47f,
    163, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Disaster", "It senses coming disasters and appears beforepeople only to warn them of impending danger.",
    65, 130, 60, 75, 60, 75, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 4, 9, 12, 20, 25, 28, 36, 41, 44, 47},
    new string[]
    {
         "Scratch", "Razor Wind", "Perish Song", "Taunt", "Me First", "Leer", "Quick Attack", "Pursuit", "Bite", "Double Team", "Slash", "Future Sight", "Night Slash", "Detect", "Psycho Cut",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Calm_Mind", "Payback", "Dark_Pulse", "X_Scissor", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Charge_Beam", "Hone_Claws", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Snarl", "Confide"
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
         "Safeguard"
    },
    new int[] {}, new string[] {}),


new PokemonData(361, "Snorunt", PokemonData.Type.ICE, PokemonData.Type.NONE, "Inner-focus", "Ice-body", "Moody",
    50f, 190, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.7f, 16.8f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Snow Hat", "It is said that several Snorunt gather under giantleaves and live together in harmony.",
    50, 50, 50, 50, 50, 50, 0, Color.clear,
    new int[] { 1, 1, 4, 10, 13, 19, 22, 28, 31, 37, 40, 46},
    new string[]
    {
         "Leer", "Powder Snow", "Double Team", "Bite", "Icy Wind", "Headbutt", "Protect", "Ice Fang", "Crunch", "Ice Shard", "Hail", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Facade", "Round", "Frost_Breath", "Confide"
    },
    new int[] {362}, new string[] {"Level,42"}),


new PokemonData(362, "Glalie", PokemonData.Type.ICE, PokemonData.Type.NONE, "Inner-focus", "Ice-body", "Moody",
    50f, 75, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.5f, 256.5f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Face", "To protect itself, it clad its body in an armor of ice,made by freezing moisture in the air.",
    80, 80, 80, 80, 80, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 19, 22, 31, 40, 51},
    new string[]
    {
         "Leer", "Bite", "Double Team", "Sheer Cold", "Icy Wind", "Headbutt", "Protect", "Crunch", "Hail", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Flash", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Torment", "Facade", "Taunt", "Gyro_Ball", "Payback", "Dark_Pulse", "Giga_Impact", "Round", "Bulldoze", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(363, "Spheal", PokemonData.Type.ICE, PokemonData.Type.WATER, "Thick-fat", "Ice-body", "Oblivious",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 39.5f,
    58, PokemonData.LevelingRate.MEDIUMSLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Clap", "They can’t swim well yet, and they move muchfaster by rolling. When they’re happy, theyclap fins.",
    70, 40, 50, 55, 50, 25, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 7, 13, 19, 25, 31, 37, 37, 43, 49},
    new string[]
    {
         "Growl", "Water Gun", "Defense Curl", "Powder Snow", "Encore", "Ice Ball", "Body Slam", "Aurora Beam", "Hail", "Rest", "Snore", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Round", "Echoed_Voice", "Bulldoze", "Frost_Breath", "Confide"
    },
    new int[] {364}, new string[] {"Level,32"}),


new PokemonData(364, "Sealeo", PokemonData.Type.ICE, PokemonData.Type.WATER, "Thick-fat", "Ice-body", "Oblivious",
    50f, 120, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.1f, 87.6f,
    144, PokemonData.LevelingRate.MEDIUMSLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Ball Roll", "It has a very sensitive nose. It touches new thingswith its nose to examine them.",
    90, 60, 70, 75, 70, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 19, 25, 32, 39, 39, 47, 55},
    new string[]
    {
         "Growl", "Water Gun", "Powder Snow", "Encore", "Ice Ball", "Body Slam", "Aurora Beam", "Swagger", "Rest", "Snore", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Round", "Echoed_Voice", "Bulldoze", "Frost_Breath", "Confide"
    },
    new int[] {365}, new string[] {"Level,44"}),


new PokemonData(365, "Walrein", PokemonData.Type.ICE, PokemonData.Type.WATER, "Thick-fat", "Ice-body", "Oblivious",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.4f, 150.6f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Ice Break", "It shatters ice with its big tusks. Its thick blubberrepels not only the cold, but also enemy attacks.",
    110, 80, 90, 95, 90, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 19, 25, 31, 32, 39, 39, 44, 52, 65},
    new string[]
    {
         "Growl", "Water Gun", "Powder Snow", "Encore", "Ice Ball", "Body Slam", "Aurora Beam", "Hail", "Swagger", "Rest", "Snore", "Ice Fang", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Giga_Impact", "Round", "Echoed_Voice", "Bulldoze", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(366, "Clamperl", PokemonData.Type.WATER, PokemonData.Type.NONE, "Shell-armor", null, "Rattled",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 52.5f,
    69, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Bivalve", "When it evolves, it makes a mysterious pearl thatamplifies psychic powers when it’s held.",
    35, 64, 85, 74, 55, 32, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 50},
    new string[]
    {
         "Water Gun", "Clamp", "Whirlpool", "Iron Defense", "Shell Smash",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(367, "Huntail", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Water-veil",
    50f, 60, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 27f,
    170, PokemonData.LevelingRate.FLUCTUATING, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Deep Sea", "It lives deep in the sea where no light ever filtersdown. It lights up its small fishlike tail toattract prey.",
    55, 104, 105, 94, 75, 52, 0, Color.clear,
    new int[] { 1, 6, 10, 15, 19, 24, 28, 33, 37, 42, 46, 50},
    new string[]
    {
         "Whirlpool", "Bite", "Screech", "Water Pulse", "Scary Face", "Ice Fang", "Brine", "Baton Pass", "Dive", "Crunch", "Aqua Tail", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Rock_Tomb", "Giga_Impact", "Round", "Scald", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(368, "Gorebyss", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Hydration",
    50f, 60, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.8f, 22.6f,
    170, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "South Sea", "It lives at the bottom of the sea. In the springtime,its pink body turns more vivid for some reason.",
    55, 84, 105, 114, 75, 52, 0, Color.clear,
    new int[] { 1, 6, 10, 15, 19, 24, 28, 33, 37, 42, 46, 50},
    new string[]
    {
         "Whirlpool", "Confusion", "Agility", "Water Pulse", "Amnesia", "Aqua Ring", "Captivate", "Baton Pass", "Dive", "Psychic", "Aqua Tail", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Hail", "Facade", "Giga_Impact", "Round", "Scald", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(369, "Relicanth", PokemonData.Type.WATER, PokemonData.Type.ROCK, "Swift-swim", "Rock-head", "Sturdy",
    87.5f, 25, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1f, 23.4f,
    170, PokemonData.LevelingRate.SLOW, 1, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Longevity", "It has remained unchanged for 100 million years. It was discovered during a deep-sea exploration.",
    100, 90, 130, 45, 65, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 8, 29, 50, 57, 64},
    new string[]
    {
         "Tackle", "Hydro Pump", "Ancient Power", "Mud Sport", "Head Smash", "Water Gun", "Take Down", "Double-Edge", "Dive", "Rest",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Calm_Mind", "Rock_Polish", "Giga_Impact", "Stone_Edge", "Smack_Down", "Round", "Scald", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(370, "Luvdisc", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Hydration",
    25f, 225, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 0.6f, 8.7f,
    116, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PINK, 70,
    "Rendezvous", "It lives in warm seas. It is said that a couple findingthis Pokémon will be blessed with eternal love.",
    43, 30, 55, 40, 65, 97, 0, Color.clear,
    new int[] { 1, 4, 7, 9, 14, 17, 22, 27, 31, 37, 40, 46, 50, 55},
    new string[]
    {
         "Tackle", "Charm", "Water Gun", "Agility", "Take Down", "Lucky Chant", "Water Pulse", "Attract", "Flail", "Sweet Kiss", "Hydro Pump", "Aqua Ring", "Captivate", "Safeguard",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Hail", "Facade", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(371, "Bagon", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Rock-head", null, "Sheer-force",
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 0.6f, 42.1f,
    60, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Rock Head", "Its well-developed neck muscles and iron-likehead can smash boulders into pieces.",
    45, 75, 60, 40, 30, 50, 0, Color.clear,
    new int[] { 1, 5, 10, 16, 20, 25, 31, 35, 40, 46, 50, 55},
    new string[]
    {
         "Rage", "Bite", "Leer", "Headbutt", "Focus Energy", "Ember", "Dragon Breath", "Zen Headbutt", "Scary Face", "Crunch", "Dragon Claw", "Double-Edge",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Strength", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Shadow_Claw", "Hone_Claws", "Round", "Incinerate", "Confide"
    },
    new int[] {372}, new string[] {"Level,30"}),


new PokemonData(372, "Shelgon", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Rock-head", null, "Overcoat",
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 1.1f, 110.5f,
    147, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Endurance", "Within its rugged shell, its cells have begunchanging. The shell peels off the instant it evolves.",
    65, 95, 100, 60, 50, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 20, 25, 30, 32, 37, 43, 50, 55},
    new string[]
    {
         "Headbutt", "Leer", "Rage", "Bite", "Focus Energy", "Ember", "Protect", "Dragon Breath", "Zen Headbutt", "Scary Face", "Crunch", "Dragon Claw",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Strength", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Shadow_Claw", "Hone_Claws", "Round", "Incinerate", "Confide"
    },
    new int[] {373}, new string[] {"Level,50"}),


new PokemonData(373, "Salamence", PokemonData.Type.DRAGON, PokemonData.Type.FLYING, "Intimidate", null, "Moxie",
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 1.5f, 102.6f,
    270, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Dragon", "It becomes uncontrollable if it is enraged. Itdestroys everything with shredding claws and fire.",
    95, 135, 80, 110, 80, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 20, 25, 30, 32, 37, 43, 50, 53, 61, 70, 80},
    new string[]
    {
         "Headbutt", "Leer", "Rage", "Thunder Fang", "Fire Fang", "Bite", "Focus Energy", "Ember", "Protect", "Dragon Breath", "Zen Headbutt", "Scary Face", "Fly", "Crunch", "Dragon Claw", "Double-Edge", "Dragon Tail",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Roost", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Round", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide"
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
    new int[] { 1, 1, 1, 1, 23, 26, 29, 32, 35, 38, 47, 50},
    new string[]
    {
         "Take Down", "Confusion", "Metal Claw", "Magnet Rise", "Pursuit", "Miracle Eye", "Zen Headbutt", "Bullet Punch", "Scary Face", "Agility", "Iron Defense", "Hyper Beam",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Gyro_Ball", "Rock_Polish", "Flash_Cannon", "Grass_Knot", "Hone_Claws", "Psyshock", "Round", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {376}, new string[] {"Level,45"}),


new PokemonData(376, "Metagross", PokemonData.Type.STEEL, PokemonData.Type.PSYCHIC, "Clear-body", null, "Light-metal",
    112.5f, 3, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.6f, 550f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Iron Leg", "With four linked brains, it’s more intelligent than asupercomputer, and it uses calculations toanalyze foes.",
    80, 135, 130, 95, 90, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 23, 26, 29, 32, 35, 38, 45, 53, 62},
    new string[]
    {
         "Take Down", "Confusion", "Metal Claw", "Magnet Rise", "Pursuit", "Miracle Eye", "Zen Headbutt", "Bullet Punch", "Scary Face", "Agility", "Hammer Arm", "Iron Defense", "Hyper Beam",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Gyro_Ball", "Rock_Polish", "Giga_Impact", "Flash_Cannon", "Grass_Knot", "Hone_Claws", "Psyshock", "Round", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(377, "Regirock", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Clear-body", null, "Sturdy",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.7f, 230f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BROWN, 35,
    "Rock Peak", "Its entire body is made of rock. If any part chips offin battle, it attaches rocks to repair itself.",
    80, 100, 200, 50, 100, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 17, 25, 33, 41, 49, 57, 89},
    new string[]
    {
         "Stomp", "Explosion", "Zap Cannon", "Hammer Arm", "Rock Throw", "Curse", "Superpower", "Ancient Power", "Iron Defense", "Charge Beam", "Lock-On", "Hyper Beam",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Charge_Beam", "Smack_Down", "Round", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(378, "Regice", PokemonData.Type.ICE, PokemonData.Type.NONE, "Clear-body", null, "Ice-body",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.8f, 175f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.BLUE, 35,
    "Iceberg", "It is said to have slept in a glacier for thousands ofyears. Its body can’t be melted, even by magma.",
    80, 50, 100, 100, 200, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 17, 25, 41, 73, 89},
    new string[]
    {
         "Stomp", "Explosion", "Zap Cannon", "Lock-On", "Hammer Arm", "Curse", "Superpower", "Amnesia", "Ice Beam", "Hyper Beam",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Charge_Beam", "Round", "Bulldoze", "Frost_Breath", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(379, "Registeel", PokemonData.Type.STEEL, PokemonData.Type.NONE, "Clear-body", null, "Light-metal",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.9f, 205f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 1, 0, PokemonData.PokedexColor.GRAY, 35,
    "Iron", "Tempered by pressure underground over tens ofthousands of years, its body cannot be scratched.",
    80, 75, 150, 75, 150, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 9, 17, 25, 33, 41, 41, 57, 89},
    new string[]
    {
         "Stomp", "Explosion", "Zap Cannon", "Hammer Arm", "Iron Head", "Metal Claw", "Curse", "Superpower", "Ancient Power", "Amnesia", "Iron Defense", "Lock-On", "Hyper Beam",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Charge_Beam", "Hone_Claws", "Round", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(380, "Latias", PokemonData.Type.DRAGON, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    0f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.4f, 40f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.RED, 90,
    "Eon", "It communicates using telepathy. Its body iscovered in down that refracts light to makeit invisible.",
    80, 80, 90, 110, 130, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 10, 20, 25, 30, 35, 45, 60, 65},
    new string[]
    {
         "Psywave", "Charm", "Healing Wish", "Dragon Pulse", "Guard Split", "Reflect Type", "Wish", "Helping Hand", "Dragon Breath", "Water Sport", "Refresh", "Mist Ball", "Recover", "Psychic", "Heal Pulse",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Surf", "Ice_Beam", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Dragon_Claw", "Calm_Mind", "Roost", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Psyshock", "Round", "Retaliate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(381, "Latios", PokemonData.Type.DRAGON, PokemonData.Type.PSYCHIC, "Levitate", null, null,
    100f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 60f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BLUE, 90,
    "Eon", "A highly intelligent Pokémon. By folding back itswings in flight, it can overtake jet planes.",
    80, 90, 80, 130, 110, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 15, 20, 25, 30, 35, 45, 60, 70},
    new string[]
    {
         "Psywave", "Memento", "Dragon Dance", "Dragon Pulse", "Power Split", "Heal Pulse", "Heal Block", "Safeguard", "Dragon Breath", "Protect", "Refresh", "Luster Purge", "Recover", "Psychic", "Telekinesis",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Surf", "Ice_Beam", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Dragon_Claw", "Calm_Mind", "Roost", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Psyshock", "Round", "Retaliate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(382, "Kyogre", PokemonData.Type.WATER, PokemonData.Type.NONE, "Drizzle", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 4.5f, 352f,
    302, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BLUE, 0,
    "Sea Basin", "A mythical Pokémon said to have swelled the seaswith rain and tidal waves. It battled with Groudon.",
    100, 100, 90, 150, 140, 90, 0, Color.clear,
    new int[] { 1, 5, 15, 20, 30, 35, 45, 50, 60, 65, 75, 80, 90},
    new string[]
    {
         "Water Pulse", "Scary Face", "Body Slam", "Muddy Water", "Aqua Ring", "Ice Beam", "Ancient Power", "Water Spout", "Calm Mind", "Aqua Tail", "Sheer Cold", "Double-Edge", "Hydro Pump",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Calm_Mind", "Giga_Impact", "Round", "Scald", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(383, "Groudon", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Drought", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 3.5f, 950f,
    302, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 0,
    "Continent", "Said to have expanded the lands by evaporatingwater with raging heat. It battled titanicallywith Kyogre.",
    100, 150, 140, 100, 90, 90, 0, Color.clear,
    new int[] { 1, 5, 15, 20, 30, 35, 45, 50, 60, 65, 75, 80, 90},
    new string[]
    {
         "Mud Shot", "Scary Face", "Lava Plume", "Hammer Arm", "Rest", "Earthquake", "Ancient Power", "Eruption", "Bulk Up", "Earth Power", "Fissure", "Solar Beam", "Fire Blast",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Fling", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(384, "Rayquaza", PokemonData.Type.DRAGON, PokemonData.Type.FLYING, "Air-lock", null, null,
    112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 7f, 206.5f,
    306, PokemonData.LevelingRate.SLOW, 0, 2, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 0,
    "Sky High", "It lives in the ozone layer far above the clouds andcannot be seen from the ground.",
    105, 150, 90, 150, 90, 95, 0, Color.clear,
    new int[] { 1, 5, 15, 20, 30, 35, 45, 50, 60, 65, 75, 80, 90},
    new string[]
    {
         "Twister", "Scary Face", "Crunch", "Hyper Voice", "Rest", "Air Slash", "Ancient Power", "Outrage", "Dragon Dance", "Fly", "Extreme Speed", "Hyper Beam", "Dragon Pulse",
    },
    new string[]
    {
         "Swords_Dance", "Fly", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Gyro_Ball", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Round", "Echoed_Voice", "Sky_Drop", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(385, "Jirachi", PokemonData.Type.STEEL, PokemonData.Type.PSYCHIC, "Serene-grace", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 1.1f,
    270, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 100,
    "Wish", "Generations have believed that any wish written ona note on its head will come true when it awakens.",
    100, 100, 100, 100, 100, 100, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 15, 20, 25, 35, 40, 45, 50, 60, 65, 70},
    new string[]
    {
         "Confusion", "Wish", "Rest", "Swift", "Helping Hand", "Psychic", "Refresh", "Zen Headbutt", "Double-Edge", "Gravity", "Healing Wish", "Cosmic Power", "Last Resort", "Doom Desire",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Calm_Mind", "U_turn", "Fling", "Energy_Ball", "Giga_Impact", "Flash_Cannon", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(386, "Deoxys-normal", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Pressure", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.7f, 60.8f,
    270, PokemonData.LevelingRate.SLOW, 0, 1, 0, 1, 0, 1, PokemonData.PokedexColor.RED, 0,
    "DNA", "An alien virus that fell to earth on a meteorunderwent a DNA mutation to becomethis Pokémon.",
    50, 150, 50, 150, 50, 150, 0, Color.clear,
    new int[] { 1, 1, 9, 17, 25, 33, 41, 49, 57, 65, 73, 81, 89, 97},
    new string[]
    {
         "Wrap", "Leer", "Night Shade", "Teleport", "Knock Off", "Pursuit", "Psychic", "Snatch", "Psycho Shift", "Zen Headbutt", "Cosmic Power", "Recover", "Psycho Boost", "Hyper Beam",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Calm_Mind", "Fling", "Poison_Jab", "Dark_Pulse", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Flash_Cannon", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Low_Sweep", "Round", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(387, "Turtwig", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Shell-armor",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.4f, 10.2f,
    64, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Tiny Leaf", "Photosynthesis occurs across its body under thesun. The shell on its back is actually hardened soil.",
    55, 68, 64, 45, 55, 31, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Withdraw", "Absorb", "Razor Leaf", "Curse", "Bite", "Mega Drain", "Leech Seed", "Synthesis", "Crunch", "Giga Drain", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Confide"
    },
    new int[] {388}, new string[] {"Level,18"}),


new PokemonData(388, "Grotle", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Shell-armor",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.1f, 97f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Grove", "It lives along water in forests. In the daytime,it leaves the forest to sunbathe its treed shell.",
    75, 89, 85, 55, 65, 36, 0, Color.clear,
    new int[] { 1, 1, 9, 13, 22, 27, 32, 37, 42, 47, 52},
    new string[]
    {
         "Tackle", "Withdraw", "Absorb", "Razor Leaf", "Bite", "Mega Drain", "Leech Seed", "Synthesis", "Crunch", "Giga Drain", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Confide"
    },
    new int[] {389}, new string[] {"Level,32"}),


new PokemonData(389, "Torterra", PokemonData.Type.GRASS, PokemonData.Type.GROUND, "Overgrow", null, "Shell-armor",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.2f, 310f,
    236, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 1, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Continent", "Ancient people imagined that beneath the ground,a gigantic Torterra dwelled.",
    95, 109, 105, 75, 85, 56, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 22, 33, 39, 45, 51, 57},
    new string[]
    {
         "Tackle", "Absorb", "Razor Leaf", "Withdraw", "Wood Hammer", "Bite", "Leech Seed", "Synthesis", "Crunch", "Giga Drain", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Rock_Tomb", "Rock_Polish", "Energy_Ball", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(390, "Chimchar", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Iron-fist",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 6.2f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Chimp", "Its fiery rear end is fueled by gas made in its belly. Even rain can’t extinguish the fire.",
    44, 58, 44, 58, 44, 61, 0, Color.clear,
    new int[] { 1, 1, 7, 9, 15, 17, 23, 25, 31, 33, 39, 41, 47},
    new string[]
    {
         "Scratch", "Leer", "Ember", "Taunt", "Fury Swipes", "Flame Wheel", "Nasty Plot", "Torment", "Facade", "Fire Spin", "Acrobatics", "Slack Off", "Flamethrower",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "Aerial_Ace", "Bulk_Up", "U_turn", "Fling", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Flame_Charge", "Low_Sweep", "Round", "Incinerate", "Acrobatics", "Confide", "Power_Up_Punch"
    },
    new int[] {391}, new string[] {"Level,14"}),


new PokemonData(391, "Monferno", PokemonData.Type.FIRE, PokemonData.Type.FIGHTING, "Blaze", null, "Iron-fist",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 22f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Playful", "It skillfully controls the intensity of the fire on itstail to keep its foes at an ideal distance.",
    64, 78, 52, 78, 52, 81, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 14, 16, 19, 26, 29, 36, 46, 49, 56},
    new string[]
    {
         "Scratch", "Leer", "Ember", "Taunt", "Mach Punch", "Fury Swipes", "Flame Wheel", "Feint", "Torment", "Close Combat", "Acrobatics", "Slack Off", "Flare Blitz",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Flamethrower", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "U_turn", "Fling", "Poison_Jab", "Focus_Blast", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Flame_Charge", "Low_Sweep", "Round", "Incinerate", "Acrobatics", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {392}, new string[] {"Level,36"}),


new PokemonData(392, "Infernape", PokemonData.Type.FIRE, PokemonData.Type.FIGHTING, "Blaze", null, "Iron-fist",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 55f,
    240, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 1, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Flame", "Its crown of fire is indicative of its fiery nature. It is beaten by none in terms of quickness.",
    76, 104, 71, 104, 71, 108, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 14, 16, 19, 26, 29, 36},
    new string[]
    {
         "Scratch", "Leer", "Ember", "Taunt", "Flare Blitz", "Mach Punch", "Fury Swipes", "Flame Wheel", "Feint", "Punishment", "Close Combat",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Calm_Mind", "U_turn", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Flame_Charge", "Low_Sweep", "Round", "Incinerate", "Acrobatics", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(393, "Piplup", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Defiant",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 5.2f,
    63, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Penguin", "It doesn’t like to be taken care of. It’s difficult tobond with since it won’t listen to its Trainer.",
    53, 51, 53, 61, 56, 40, 0, Color.clear,
    new int[] { 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43},
    new string[]
    {
         "Pound", "Growl", "Bubble", "Water Sport", "Peck", "Bubble Beam", "Bide", "Fury Attack", "Brine", "Whirlpool", "Mist", "Drill Peck", "Hydro Pump",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Grass_Knot", "Round", "Echoed_Voice", "Scald", "Quash", "Confide"
    },
    new int[] {394}, new string[] {"Level,16"}),


new PokemonData(394, "Prinplup", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Defiant",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 23f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Penguin", "It lives alone, away from others. Apparently, everyone of them believes it is the most important.",
    64, 66, 68, 81, 76, 50, 0, Color.clear,
    new int[] { 1, 1, 8, 11, 15, 16, 19, 24, 28, 33, 37, 46, 50},
    new string[]
    {
         "Tackle", "Growl", "Bubble", "Water Sport", "Peck", "Metal Claw", "Bubble Beam", "Bide", "Fury Attack", "Brine", "Whirlpool", "Drill Peck", "Hydro Pump",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Round", "Echoed_Voice", "Scald", "Quash", "Confide"
    },
    new int[] {395}, new string[] {"Level,36"}),


new PokemonData(395, "Empoleon", PokemonData.Type.WATER, PokemonData.Type.STEEL, "Torrent", null, "Defiant",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.7f, 84.5f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Emperor", "It swims as fast as a jet boat. The edges of itswings are sharp and can slice apart drifting ice.",
    84, 86, 88, 111, 101, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 11, 15, 16, 19, 28, 33, 36, 39, 52, 59},
    new string[]
    {
         "Tackle", "Growl", "Bubble", "Swords Dance", "Peck", "Metal Claw", "Bubble Beam", "Fury Attack", "Brine", "Aqua Jet", "Whirlpool", "Drill Peck", "Hydro Pump",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Grass_Knot", "Hone_Claws", "Round", "Echoed_Voice", "Scald", "Quash", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(396, "Starly", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", null, "Reckless",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 0.3f, 2f,
    49, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Starling", "They flock in great numbers. Though small, theyflap their wings with great power.",
    40, 55, 30, 30, 30, 60, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41},
    new string[]
    {
         "Tackle", "Growl", "Quick Attack", "Wing Attack", "Double Team", "Endeavor", "Whirlwind", "Aerial Ace", "Take Down", "Agility", "Brave Bird", "Final Gambit",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {397}, new string[] {"Level,14"}),


new PokemonData(397, "Staravia", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Intimidate", null, "Reckless",
    50f, 120, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 0.6f, 15.5f,
    119, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Starling", "They maintain huge flocks, although fierce scufflesbreak out between various flocks.",
    55, 75, 50, 40, 40, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 18, 23, 28, 33, 38, 43, 48},
    new string[]
    {
         "Tackle", "Growl", "Quick Attack", "Wing Attack", "Endeavor", "Whirlwind", "Aerial Ace", "Take Down", "Agility", "Brave Bird", "Final Gambit",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {398}, new string[] {"Level,34"}),


new PokemonData(398, "Staraptor", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Intimidate", null, "Reckless",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.2f, 24.9f,
    218, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Predator", "The muscles in its wings and legs are strong. It can easily fly while gripping a small Pokémon.",
    85, 120, 70, 50, 60, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 18, 28, 33, 34, 41, 49, 57},
    new string[]
    {
         "Wing Attack", "Tackle", "Growl", "Quick Attack", "Endeavor", "Aerial Ace", "Take Down", "Close Combat", "Agility", "Brave Bird", "Final Gambit",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Giga_Impact", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(399, "Bidoof", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Simple", "Unaware", "Moody",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 0.5f, 20f,
    50, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Plump Mouse", "With nerves of steel, nothing can perturb it. It ismore agile and active than it appears.",
    59, 45, 40, 35, 40, 31, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Growl", "Defense Curl", "Rollout", "Headbutt", "Hyper Fang", "Yawn", "Amnesia", "Take Down", "Super Fang", "Superpower", "Curse",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {400}, new string[] {"Level,15"}),


new PokemonData(400, "Bibarel", PokemonData.Type.NORMAL, PokemonData.Type.WATER, "Simple", "Unaware", "Moody",
    50f, 127, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1f, 31.5f,
    144, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Beaver", "It busily makes its nest with stacks of branches androots it has cut up with its sharp incisors.",
    79, 85, 60, 55, 60, 71, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 13, 18, 23, 28, 33, 38, 43, 48, 53},
    new string[]
    {
         "Tackle", "Growl", "Rototiller", "Defense Curl", "Rollout", "Headbutt", "Hyper Fang", "Yawn", "Amnesia", "Take Down", "Super Fang", "Superpower", "Curse",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "Fling", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Scald", "Retaliate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(401, "Kricketot", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shed-skin", null, "Run-away",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 0.3f, 2.2f,
    39, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Cricket", "It chats with others using the sounds of its collidingantennae. These sounds are fall hallmarks.",
    37, 25, 41, 25, 41, 25, 0, Color.clear,
    new int[] { 1, 1, 6, 16},
    new string[]
    {
         "Growl", "Bide", "Struggle Bug", "Bug Bite",
    },
    new string[]
    {
         "Struggle_Bug"
    },
    new int[] {402}, new string[] {"Level,10"}),


new PokemonData(402, "Kricketune", PokemonData.Type.BUG, PokemonData.Type.NONE, "Swarm", null, "Technician",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 1f, 25.5f,
    134, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Cricket", "It crosses its knifelike arms in front of its chestwhen it cries. It can compose melodies ad lib.",
    77, 85, 51, 55, 51, 65, 0, Color.clear,
    new int[] { 1, 1, 10, 14, 18, 22, 26, 30, 34, 36, 38, 42, 44, 46, 50},
    new string[]
    {
         "Growl", "Bide", "Fury Cutter", "Leech Life", "Sing", "Focus Energy", "Slash", "X-Scissor", "Screech", "Fell Stinger", "Taunt", "Night Slash", "Sticky Web", "Bug Buzz", "Perish Song",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Aerial_Ace", "X_Scissor", "Giga_Impact", "Hone_Claws", "Round", "Echoed_Voice", "Struggle_Bug", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(403, "Shinx", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Rivalry", "Intimidate", "Guts",
    50f, 235, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.5f, 9.5f,
    53, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Flash", "The extension and contraction of its musclesgenerates electricity. It glows when in trouble.",
    45, 65, 34, 40, 34, 45, 0, Color.clear,
    new int[] { 1, 5, 9, 11, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Leer", "Charge", "Baby-Doll Eyes", "Spark", "Bite", "Roar", "Swagger", "Thunder Fang", "Crunch", "Scary Face", "Discharge", "Wild Charge",
    },
    new string[]
    {
         "Roar", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {404}, new string[] {"Level,15"}),


new PokemonData(404, "Luxio", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Rivalry", "Intimidate", "Guts",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.9f, 30.5f,
    127, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 100,
    "Spark", "Its claws loose electricity with enough amperageto cause fainting. They live in small groups.",
    60, 85, 49, 60, 49, 60, 0, Color.clear,
    new int[] { 1, 1, 9, 13, 23, 28, 33, 38, 43, 48, 53},
    new string[]
    {
         "Tackle", "Leer", "Charge", "Spark", "Roar", "Swagger", "Thunder Fang", "Crunch", "Scary Face", "Discharge", "Wild Charge",
    },
    new string[]
    {
         "Roar", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {405}, new string[] {"Level,30"}),


new PokemonData(405, "Luxray", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Rivalry", "Intimidate", "Guts",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.4f, 42f,
    235, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Gleam Eyes", "When its eyes gleam gold, it can spot hidingprey--even those taking shelter behind a wall.",
    80, 120, 79, 95, 79, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 23, 28, 42, 49, 56, 63},
    new string[]
    {
         "Tackle", "Leer", "Charge", "Electric Terrain", "Spark", "Roar", "Swagger", "Crunch", "Scary Face", "Discharge", "Wild Charge",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Giga_Impact", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(406, "Budew", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Natural-cure", "Poison-point", "Leaf-guard",
    50f, 255, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.2f, 1.2f,
    56, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Bud", "When it feels the sun’s warm touch, it opens its budto release pollen. It lives alongside clear pools.",
    40, 30, 35, 50, 70, 55, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 16},
    new string[]
    {
         "Absorb", "Growth", "Water Sport", "Stun Spore", "Mega Drain", "Worry Seed",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(407, "Roserade", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Natural-cure", "Poison-point", "Technician",
    50f, 75, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 257, 0.9f, 14.5f,
    232, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Bouquet", "Luring prey with a sweet scent, it uses poison whipson its arms to poison, bind, and finish off the prey.",
    60, 70, 65, 125, 105, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1},
    new string[]
    {
         "Poison Sting", "Mega Drain", "Sweet Scent", "Weather Ball", "Magical Leaf", "Grassy Terrain", "Venom Drench",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Nature_Power", "Poison_Jab", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Venoshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(408, "Cranidos", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Mold-breaker", null, "Sheer-force",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.9f, 31.5f,
    70, PokemonData.LevelingRate.FLUCTUATING, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Head Butt", "It was resurrected from an iron ball-like fossil. It downs prey with its headbutts.",
    67, 125, 40, 30, 30, 58, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 19, 24, 28, 33, 37, 42, 46},
    new string[]
    {
         "Headbutt", "Leer", "Focus Energy", "Pursuit", "Take Down", "Scary Face", "Assurance", "Chip Away", "Ancient Power", "Zen Headbutt", "Screech", "Head Smash",
    },
    new string[]
    {
         "Swords_Dance", "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Payback", "Fling", "Rock_Polish", "Stone_Edge", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {409}, new string[] {"Level,30"}),


new PokemonData(409, "Rampardos", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Mold-breaker", null, "Sheer-force",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.6f, 102.5f,
    173, PokemonData.LevelingRate.FLUCTUATING, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Head Butt", "Its skull withstands impacts of any magnitude. As aresult, its brain never gets the chance to grow.",
    97, 165, 60, 65, 50, 58, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 19, 24, 28, 30, 36, 43, 51, 58},
    new string[]
    {
         "Headbutt", "Leer", "Focus Energy", "Pursuit", "Take Down", "Scary Face", "Assurance", "Chip Away", "Endeavor", "Ancient Power", "Zen Headbutt", "Screech", "Head Smash",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Payback", "Fling", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(410, "Shieldon", PokemonData.Type.ROCK, PokemonData.Type.STEEL, "Sturdy", null, "Soundproof",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 57f,
    70, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Shield", "It habitually polishes its face by rubbing it againsttree trunks. It is weak to attacks from behind.",
    30, 42, 118, 42, 88, 30, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 19, 24, 28, 33, 37, 42, 46},
    new string[]
    {
         "Tackle", "Protect", "Taunt", "Metal Sound", "Take Down", "Iron Defense", "Swagger", "Ancient Power", "Endure", "Metal Burst", "Iron Head", "Heavy Slam",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Rock_Polish", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {411}, new string[] {"Level,30"}),


new PokemonData(411, "Bastiodon", PokemonData.Type.ROCK, PokemonData.Type.STEEL, "Sturdy", null, "Soundproof",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.3f, 149.5f,
    173, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Shield", "When they lined up side by side, no foe couldbreak through. They shielded their young inthat way.",
    60, 52, 168, 47, 138, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 15, 19, 24, 28, 30, 36, 43, 51, 58},
    new string[]
    {
         "Tackle", "Protect", "Taunt", "Metal Sound", "Take Down", "Iron Defense", "Swagger", "Ancient Power", "Block", "Endure", "Metal Burst", "Iron Head", "Heavy Slam",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Rock_Polish", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(412, "Burmy", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shed-skin", null, "Overcoat",
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.2f, 3.4f,
    45, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Bagworm", "To shelter itself from cold, wintry winds, it coversitself with a cloak made of twigs and leaves.",
    40, 29, 45, 29, 45, 36, 0, Color.clear,
    new int[] { 1, 10, 15, 20},
    new string[]
    {
         "Protect", "Tackle", "Bug Bite", "Hidden Power",
    },
    new string[]
    {
         "Protect", "Hidden_Power"
    },
    new int[] {413}, new string[] {"Level,20"}),


new PokemonData(413, "Wormadam-plant", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Anticipation", null, "Overcoat",
    0f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.5f, 6.5f,
    148, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.GREEN, 70,
    "Bagworm", "Its appearance changes depending on where itevolved. The materials on hand become a part ofits body.",
    60, 59, 85, 79, 105, 36, 0, Color.clear,
    new int[] { 1, 10, 15, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47},
    new string[]
    {
         "Tackle", "Protect", "Bug Bite", "Hidden Power", "Confusion", "Razor Leaf", "Growth", "Psybeam", "Captivate", "Flail", "Attract", "Psychic", "Leaf Storm",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Venoshock", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {414}, new string[] {"Level,20"}),


new PokemonData(414, "Mothim", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Swarm", null, "Tinted-lens",
    100f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.9f, 23.3f,
    148, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Moth", "It loves the honey of flowers and steals honeycollected by Combee.",
    70, 94, 50, 94, 50, 66, 0, Color.clear,
    new int[] { 1, 10, 15, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50},
    new string[]
    {
         "Tackle", "Protect", "Bug Bite", "Hidden Power", "Confusion", "Gust", "Poison Powder", "Psybeam", "Camouflage", "Silver Wind", "Air Slash", "Psychic", "Bug Buzz", "Quiver Dance",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "U_turn", "Energy_Ball", "Giga_Impact", "Venoshock", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(415, "Combee", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Honey-gather", null, "Hustle",
    87.5f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 257, 0.3f, 5.5f,
    49, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Tiny Bee", "The trio is together from birth. It constantly gathershoney from flowers to please Vespiquen.",
    30, 30, 42, 30, 42, 70, 0, Color.clear,
    new int[] { 1, 1, 13, 29},
    new string[]
    {
         "Gust", "Sweet Scent", "Bug Bite", "Bug Buzz",
    },
    new string[]
    {

    },
    new int[] {416}, new string[] {"Level,21"}),


new PokemonData(416, "Vespiquen", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Pressure", null, "Unnerve",
    0f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.2f, 38.5f,
    166, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Beehive", "It houses its colony in cells in its body and releasesvarious pheromones to make those grubs doits bidding.",
    70, 80, 102, 80, 102, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Gust", "Poison Sting", "Confuse Ray", "Destiny Bond", "Sweet Scent", "Fell Stinger", "Fury Cutter", "Pursuit", "Fury Swipes", "Defend Order", "Slash", "Power Gem", "Heal Order", "Toxic", "Air Slash", "Captivate", "Attack Order",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "Roost", "U_turn", "Fling", "X_Scissor", "Giga_Impact", "Hone_Claws", "Venoshock", "Round", "Quash", "Acrobatics", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(417, "Pachirisu", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Run-away", "Pickup", "Volt-absorb",
    50f, 200, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.4f, 3.9f,
    142, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.WHITE, 100,
    "EleSquirrel", "It makes fur balls that crackle with static electricity. It stores them with berries in tree holes.",
    60, 45, 70, 45, 90, 95, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 19, 21, 25, 29, 33, 37, 41, 45, 49},
    new string[]
    {
         "Growl", "Bide", "Quick Attack", "Charm", "Spark", "Endure", "Nuzzle", "Swift", "Electro Ball", "Sweet Kiss", "Thunder Wave", "Super Fang", "Discharge", "Last Resort", "Hyper Fang",
    },
    new string[]
    {
         "Cut", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "U_turn", "Fling", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Volt_Switch", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(418, "Buizel", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Water-veil",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 0.7f, 29.5f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Sea Weasel", "It swims by rotating its two tails like a screw. When it dives, its flotation sac collapses.",
    55, 65, 35, 60, 30, 85, 0, Color.clear,
    new int[] { 1, 4, 7, 11, 15, 18, 21, 24, 27, 31, 35, 38, 41, 45},
    new string[]
    {
         "Sonic Boom", "Growl", "Water Sport", "Quick Attack", "Water Gun", "Pursuit", "Swift", "Aqua Jet", "Double Hit", "Whirlpool", "Razor Wind", "Aqua Tail", "Agility", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Round", "Echoed_Voice", "Scald", "Confide", "Power_Up_Punch"
    },
    new int[] {419}, new string[] {"Level,26"}),


new PokemonData(419, "Floatzel", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", null, "Water-veil",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 257, 1.1f, 33.5f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 70,
    "Sea Weasel", "It floats using its well-developed flotation sac. It assists in the rescues of drowning people.",
    85, 105, 55, 85, 50, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 15, 18, 24, 29, 35, 41, 51, 57},
    new string[]
    {
         "Growl", "Quick Attack", "Crunch", "Water Sport", "Ice Fang", "Water Gun", "Pursuit", "Aqua Jet", "Double Hit", "Whirlpool", "Razor Wind", "Agility", "Hydro Pump",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Focus_Blast", "Giga_Impact", "Round", "Echoed_Voice", "Scald", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(420, "Cherubi", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", null, null,
    50f, 190, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 3.3f,
    55, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Cherry", "Sunlight colors it red. When the small ball isdrained of nutrients, it shrivels to herald evolution.",
    45, 35, 45, 62, 53, 35, 0, Color.clear,
    new int[] { 1, 1, 7, 10, 13, 19, 22, 28, 31, 37, 40, 47},
    new string[]
    {
         "Tackle", "Morning Sun", "Growth", "Leech Seed", "Helping Hand", "Magical Leaf", "Sunny Day", "Worry Seed", "Take Down", "Solar Beam", "Lucky Chant", "Petal Blizzard",
    },
    new string[]
    {
         "Swords_Dance", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {421}, new string[] {"Level,25"}),


new PokemonData(421, "Cherrim", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Flower-gift", null, null,
    50f, 75, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.5f, 9.3f,
    158, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Blossom", "During times of strong sunlight, its bud blooms,its petals open fully, and it becomes very active.",
    70, 60, 70, 87, 78, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 13, 19, 22, 25, 30, 35, 48, 50},
    new string[]
    {
         "Tackle", "Growth", "Morning Sun", "Leech Seed", "Helping Hand", "Magical Leaf", "Sunny Day", "Petal Dance", "Worry Seed", "Take Down", "Lucky Chant", "Petal Blizzard",
    },
    new string[]
    {
         "Swords_Dance", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(422, "Shellos", PokemonData.Type.WATER, PokemonData.Type.NONE, "Sticky-hold", "Storm-drain", "Sand-force",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.3f, 6.3f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sea Slug", "Beware of pushing strongly on its squishy body,as it makes a mysterious purple fluid ooze out.",
    76, 48, 48, 57, 62, 34, 0, Color.clear,
    new int[] { 1, 2, 4, 7, 11, 16, 22, 29, 37, 46},
    new string[]
    {
         "Mud-Slap", "Mud Sport", "Harden", "Water Pulse", "Mud Bomb", "Hidden Power", "Rain Dance", "Body Slam", "Muddy Water", "Recover",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Round", "Scald", "Confide", "Infestation"
    },
    new int[] {423}, new string[] {"Level,30"}),


new PokemonData(423, "Gastrodon", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Sticky-hold", "Storm-drain", "Sand-force",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.9f, 29.9f,
    166, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Sea Slug", "When its natural enemy attacks, it oozes purplefluid and escapes.",
    111, 83, 68, 92, 82, 39, 0, Color.clear,
    new int[] { 1, 1, 1, 16, 22, 29, 54},
    new string[]
    {
         "Harden", "Mud Sport", "Water Pulse", "Hidden Power", "Rain Dance", "Body Slam", "Recover",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Giga_Impact", "Stone_Edge", "Sludge_Wave", "Round", "Scald", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(424, "Ambipom", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Technician", "Pickup", "Skill-link",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.2f, 20.3f,
    169, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 100,
    "Long Tail", "They work in large colonies and make rings bylinking their tails, apparently in friendship.",
    75, 100, 66, 60, 66, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 11, 18, 22, 25, 29, 32, 36, 39, 43},
    new string[]
    {
         "Scratch", "Sand Attack", "Astonish", "Baton Pass", "Fury Swipes", "Swift", "Screech", "Agility", "Double Hit", "Fling", "Nasty Plot", "Last Resort",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Aerial_Ace", "U_turn", "Payback", "Fling", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Acrobatics", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(425, "Drifloon", PokemonData.Type.GHOST, PokemonData.Type.FLYING, "Aftermath", "Unburden", "Flare-boost",
    50f, 125, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.4f, 1.2f,
    70, PokemonData.LevelingRate.ERRATIC, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Balloon", "A Pokémon formed by the spirits of people andPokémon. It loves damp, humid seasons.",
    90, 50, 34, 60, 44, 70, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 13, 16, 20, 25, 27, 32, 32, 36, 40, 44, 50},
    new string[]
    {
         "Minimize", "Constrict", "Astonish", "Gust", "Focus Energy", "Payback", "Ominous Wind", "Stockpile", "Hex", "Spit Up", "Swallow", "Shadow Ball", "Amnesia", "Baton Pass", "Explosion",
    },
    new string[]
    {
         "Cut", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Calm_Mind", "Gyro_Ball", "Payback", "Embargo", "Charge_Beam", "Round", "Acrobatics", "Confide"
    },
    new int[] {426}, new string[] {"Level,28"}),


new PokemonData(426, "Drifblim", PokemonData.Type.GHOST, PokemonData.Type.FLYING, "Aftermath", "Unburden", "Flare-boost",
    50f, 60, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 15f,
    174, PokemonData.LevelingRate.ERRATIC, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Blimp", "It carries people and Pokémon when it flies. But since it only drifts, it can end up anywhere.",
    150, 80, 44, 90, 54, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 20, 25, 27, 34, 34, 40, 46, 52, 60},
    new string[]
    {
         "Gust", "Constrict", "Astonish", "Phantom Force", "Focus Energy", "Ominous Wind", "Stockpile", "Hex", "Spit Up", "Swallow", "Shadow Ball", "Amnesia", "Baton Pass", "Explosion",
    },
    new string[]
    {
         "Cut", "Fly", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Calm_Mind", "Gyro_Ball", "Payback", "Embargo", "Giga_Impact", "Charge_Beam", "Round", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(427, "Buneary", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Klutz", "Limber",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 5.5f,
    70, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 0,
    "Rabbit", "Its ears are always rolled up. They can be forcefullyextended to shatter even a large boulder.",
    55, 66, 44, 44, 56, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 10, 13, 16, 23, 26, 33, 36, 43, 46, 50, 56, 63},
    new string[]
    {
         "Pound", "Defense Curl", "Splash", "Foresight", "Endure", "Baby-Doll Eyes", "Frustration", "Quick Attack", "Jump Kick", "Baton Pass", "Agility", "Dizzy Punch", "After You", "Charm", "Entrainment", "Bounce", "Healing Wish",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Fling", "Grass_Knot", "Charge_Beam", "Round", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(428, "Lopunny", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Cute-charm", "Klutz", "Limber",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 33.3f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BROWN, 140,
    "Rabbit", "Extremely cautious, it quickly bounds offwhen it senses danger.",
    65, 76, 84, 54, 96, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 6, 13, 16, 23, 26, 33, 36, 43, 46, 53, 63},
    new string[]
    {
         "Pound", "Defense Curl", "Splash", "Foresight", "Mirror Coat", "Magic Coat", "Bounce", "Rototiller", "Endure", "Return", "Quick Attack", "Jump Kick", "Baton Pass", "Agility", "Dizzy Punch", "After You", "Charm", "Entrainment", "Healing Wish",
    },
    new string[]
    {
         "Cut", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Fling", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Low_Sweep", "Round", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(429, "Mismagius", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.9f, 4.4f,
    173, PokemonData.LevelingRate.FAST, 0, 0, 0, 1, 1, 0, PokemonData.PokedexColor.PURPLE, 35,
    "Magical", "It chants incantations. While they usually tormenttargets, some chants bring happiness.",
    60, 60, 60, 105, 105, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1},
    new string[]
    {
         "Growl", "Psywave", "Spite", "Astonish", "Magical Leaf", "Lucky Chant", "Power Gem", "Phantom Force",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Payback", "Embargo", "Dark_Pulse", "Energy_Ball", "Giga_Impact", "Trick_Room", "Charge_Beam", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(430, "Honchkrow", PokemonData.Type.DARK, PokemonData.Type.FLYING, "Insomnia", "Super-luck", "Moxie",
    50f, 30, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.9f, 27.3f,
    177, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Big Boss", "If one utters a deep cry, many Murkrow gatherquickly. For this, it is called “Summoner of Night. ",
    100, 125, 52, 105, 52, 71, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 25, 45, 65, 75},
    new string[]
    {
         "Wing Attack", "Haze", "Pursuit", "Astonish", "Sucker Punch", "Night Slash", "Swagger", "Foul Play", "Quash", "Dark Pulse",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Roost", "Payback", "Embargo", "Dark_Pulse", "Giga_Impact", "Round", "Incinerate", "Quash", "Retaliate", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(431, "Glameow", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Limber", "Own-tempo", "Keen-eye",
    25f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 3.9f,
    62, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GRAY, 70,
    "Catty", "It claws if displeased and purrs when affectionate. Its fickleness is very popular among some.",
    49, 55, 42, 42, 37, 85, 0, Color.clear,
    new int[] { 1, 5, 8, 13, 17, 20, 25, 29, 32, 37, 41, 44, 48, 50},
    new string[]
    {
         "Fake Out", "Scratch", "Growl", "Hypnosis", "Feint Attack", "Fury Swipes", "Charm", "Assist", "Captivate", "Slash", "Sucker Punch", "Attract", "Hone Claws", "Play Rough",
    },
    new string[]
    {
         "Cut", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "U_turn", "Payback", "Shadow_Claw", "Hone_Claws", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {432}, new string[] {"Level,38"}),


new PokemonData(432, "Purugly", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Thick-fat", "Own-tempo", "Defiant",
    25f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 43.8f,
    158, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GRAY, 70,
    "Tiger Cat", "It would claim another Pokémon’s nest as its ownif it finds a nest sufficiently comfortable.",
    71, 82, 64, 64, 59, 112, 0, Color.clear,
    new int[] { 1, 1, 1, 17, 20, 25, 29, 32, 37, 38, 52, 60},
    new string[]
    {
         "Scratch", "Growl", "Fake Out", "Feint Attack", "Fury Swipes", "Charm", "Assist", "Captivate", "Slash", "Swagger", "Attract", "Hone Claws",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Thunderbolt", "Thunder", "Dig", "Toxic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "U_turn", "Payback", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Echoed_Voice", "Retaliate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(433, "Chingling", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 120, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.2f, 0.6f,
    57, PokemonData.LevelingRate.FAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Bell", "Each time it hops, it makes a ringing sound. It deafens foes by emitting high-frequency cries.",
    45, 30, 50, 65, 50, 45, 0, Color.clear,
    new int[] { 1, 6, 9, 14, 17, 22, 25},
    new string[]
    {
         "Wrap", "Growl", "Astonish", "Confusion", "Uproar", "Last Resort", "Entrainment",
    },
    new string[]
    {
         "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Calm_Mind", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(434, "Stunky", PokemonData.Type.POISON, PokemonData.Type.DARK, "Stench", "Aftermath", "Keen-eye",
    50f, 225, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 19.2f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Skunk", "It sprays a foul fluid from its rear. Its stenchspreads over a mile radius, driving Pokémon away.",
    63, 63, 47, 41, 41, 74, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 14, 18, 22, 27, 32, 37, 43, 46, 49},
    new string[]
    {
         "Scratch", "Focus Energy", "Poison Gas", "Screech", "Fury Swipes", "Smokescreen", "Feint", "Slash", "Toxic", "Acid Spray", "Night Slash", "Memento", "Belch", "Explosion",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Payback", "Dark_Pulse", "Shadow_Claw", "Hone_Claws", "Venoshock", "Round", "Incinerate", "Snarl", "Confide"
    },
    new int[] {435}, new string[] {"Level,34"}),


new PokemonData(435, "Skuntank", PokemonData.Type.POISON, PokemonData.Type.DARK, "Stench", "Aftermath", "Keen-eye",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 38f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Skunk", "It sprays a vile-smelling fluid from the tip of its tailto attack. Its range is over 160 feet.",
    103, 93, 67, 71, 61, 84, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 10, 14, 18, 22, 27, 32, 34, 41, 51, 56},
    new string[]
    {
         "Scratch", "Focus Energy", "Poison Gas", "Screech", "Fury Swipes", "Smokescreen", "Feint", "Slash", "Toxic", "Acid Spray", "Flamethrower", "Night Slash", "Memento", "Belch",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Payback", "Poison_Jab", "Dark_Pulse", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Venoshock", "Round", "Incinerate", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(436, "Bronzor", PokemonData.Type.STEEL, PokemonData.Type.PSYCHIC, "Levitate", "Heatproof", "Heavy-metal",
    112.5f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.5f, 60.5f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Bronze", "Ancient people believed that the pattern onBronzor’s back contained a mysterious power.",
    57, 24, 86, 24, 86, 23, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 11, 15, 19, 21, 25, 29, 31, 35, 39, 41, 45, 49},
    new string[]
    {
         "Tackle", "Confusion", "Hypnosis", "Imprison", "Confuse Ray", "Psywave", "Iron Defense", "Feint Attack", "Safeguard", "Future Sight", "Metal Sound", "Gyro Ball", "Extrasensory", "Payback", "Heal Block", "Heavy Slam",
    },
    new string[]
    {
         "Solar_Beam", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Payback", "Rock_Polish", "Flash_Cannon", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Bulldoze", "Confide"
    },
    new int[] {437}, new string[] {"Level,33"}),


new PokemonData(437, "Bronzong", PokemonData.Type.STEEL, PokemonData.Type.PSYCHIC, "Levitate", "Heatproof", "Heavy-metal",
    112.5f, 90, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.3f, 187f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.GREEN, 70,
    "Bronze Bell", "In ages past, this Pokémon was revered as abringer of rain. It was found buried in the ground.",
    67, 89, 116, 79, 116, 33, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 15, 19, 21, 25, 29, 33, 36, 42, 46, 52, 58},
    new string[]
    {
         "Tackle", "Confusion", "Hypnosis", "Rain Dance", "Sunny Day", "Imprison", "Psywave", "Iron Defense", "Feint Attack", "Safeguard", "Future Sight", "Block", "Gyro Ball", "Extrasensory", "Payback", "Heal Block", "Heavy Slam",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Payback", "Rock_Polish", "Giga_Impact", "Flash_Cannon", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(438, "Bonsly", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Sturdy", "Rock-head", "Rattled",
    50f, 255, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.5f, 15f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Bonsai", "It prefers arid environments. It leaks water from itseyes to adjust its body’s fluid levels.",
    50, 80, 95, 10, 45, 10, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 19, 22, 26, 29, 33, 36, 40},
    new string[]
    {
         "Fake Tears", "Copycat", "Flail", "Low Kick", "Rock Throw", "Mimic", "Feint Attack", "Rock Tomb", "Block", "Rock Slide", "Counter", "Sucker Punch", "Double-Edge",
    },
    new string[]
    {
         "Dig", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Calm_Mind", "Rock_Polish", "Smack_Down", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(439, "Mime-jr", PokemonData.Type.PSYCHIC, PokemonData.Type.FAIRY, "Soundproof", "Filter", "Technician",
    50f, 145, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.6f, 13f,
    62, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PINK, 70,
    "Mime", "In an attempt to confuse its enemy, it mimics theenemy’s movements. Then it wastes no time inmaking itself scarce",
    20, 25, 45, 70, 90, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 8, 11, 15, 18, 22, 22, 25, 29, 32, 36, 39, 43, 46, 50},
    new string[]
    {
         "Confusion", "Barrier", "Tickle", "Copycat", "Meditate", "Double Slap", "Mimic", "Encore", "Light Screen", "Reflect", "Psybeam", "Substitute", "Recycle", "Trick", "Psychic", "Role Play", "Baton Pass", "Safeguard",
    },
    new string[]
    {
         "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Brick_Break", "Calm_Mind", "Fling", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(440, "Happiny", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Natural-cure", "Serene-grace", "Friend-guard",
    0f, 130, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.6f, 24.4f,
    110, PokemonData.LevelingRate.FAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 140,
    "Playhouse", "It carries a round, egg-shaped rock in its bellypouch and gives the rock to its friends.",
    100, 5, 5, 15, 65, 30, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 12},
    new string[]
    {
         "Pound", "Charm", "Copycat", "Refresh", "Sweet Kiss",
    },
    new string[]
    {
         "Flamethrower", "Solar_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Hail", "Facade", "Fling", "Grass_Knot", "Round", "Echoed_Voice", "Incinerate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(441, "Chatot", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Tangled-feet", "Big-pecks",
    50f, 30, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.5f, 1.9f,
    144, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 35,
    "Music Note", "It mimics the cries of other Pokémon to trick theminto thinking it’s one of them. This way they won’tattack it.",
    76, 65, 45, 92, 42, 91, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 9, 13, 17, 29, 33, 37, 45},
    new string[]
    {
         "Peck", "Taunt", "Hyper Voice", "Chatter", "Confide", "Growl", "Mirror Move", "Sing", "Fury Attack", "Round", "Mimic", "Echoed Voice", "Uproar",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Torment", "Facade", "Taunt", "Aerial_Ace", "Roost", "U_turn", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(442, "Spiritomb", PokemonData.Type.GHOST, PokemonData.Type.DARK, "Pressure", null, "Infiltrator",
    50f, 100, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1f, 108f,
    170, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Forbidden", "A Pokémon that was formed by 108 spirits. It isbound to a fissure in an odd keystone.",
    50, 92, 108, 92, 108, 35, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 7, 13, 19, 25, 31, 37, 43, 49},
    new string[]
    {
         "Confuse Ray", "Curse", "Spite", "Pursuit", "Shadow Sneak", "Feint Attack", "Hypnosis", "Dream Eater", "Ominous Wind", "Sucker Punch", "Nasty Plot", "Memento", "Dark Pulse",
    },
    new string[]
    {
         "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Rock_Tomb", "Calm_Mind", "Embargo", "Dark_Pulse", "Giga_Impact", "Round", "Quash", "Retaliate", "Snarl", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(443, "Gible", PokemonData.Type.DRAGON, PokemonData.Type.GROUND, "Sand-veil", null, "Rough-skin",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 0.7f, 20.5f,
    60, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Land Shark", "It nests in horizontal holes warmed by geothermalheat. Foes who get too close can expect to bepounced on and bitten.",
    58, 70, 45, 40, 45, 42, 0, Color.clear,
    new int[] { 1, 3, 7, 13, 15, 19, 25, 27, 31, 37},
    new string[]
    {
         "Tackle", "Sand Attack", "Dragon Rage", "Sandstorm", "Take Down", "Sand Tomb", "Slash", "Dragon Claw", "Dig", "Dragon Rush",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Round", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {444}, new string[] {"Level,24"}),


new PokemonData(444, "Gabite", PokemonData.Type.DRAGON, PokemonData.Type.GROUND, "Sand-veil", null, "Rough-skin",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1.4f, 56f,
    144, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Cave", "It loves sparkly things. It seeks treasures in cavesand hoards the loot in its nest.",
    68, 90, 65, 50, 55, 82, 0, Color.clear,
    new int[] { 1, 7, 13, 15, 19, 24, 28, 33, 40, 49},
    new string[]
    {
         "Sand Attack", "Dragon Rage", "Sandstorm", "Take Down", "Sand Tomb", "Dual Chop", "Slash", "Dragon Claw", "Dig", "Dragon Rush",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Round", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {445}, new string[] {"Level,48"}),


new PokemonData(445, "Garchomp", PokemonData.Type.DRAGON, PokemonData.Type.GROUND, "Sand-veil", null, "Rough-skin",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1.9f, 95f,
    270, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Mach", "When it folds up its body and extends its wings,it looks like a jet plane. It flies at sonic speed.",
    108, 130, 95, 80, 85, 102, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 15, 19, 24, 28, 33, 55},
    new string[]
    {
         "Sand Attack", "Dragon Rage", "Sandstorm", "Fire Fang", "Take Down", "Sand Tomb", "Dual Chop", "Slash", "Dragon Claw", "Dragon Rush",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Flamethrower", "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Fling", "Poison_Jab", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Round", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(446, "Munchlax", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Thick-fat", "Gluttony",
    87.5f, 50, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.6f, 105f,
    78, PokemonData.LevelingRate.SLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Big Eater", "It hides food under its long body hair. However,it forgets it has hidden the food.",
    135, 85, 40, 40, 85, 5, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 4, 20, 25, 28, 33, 36, 41, 44, 49},
    new string[]
    {
         "Tackle", "Metronome", "Lick", "Snatch", "Last Resort", "Defense Curl", "Screech", "Body Slam", "Stockpile", "Swallow", "Rollout", "Fling", "Belly Drum", "Natural Gift",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "Round", "Incinerate", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(447, "Riolu", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Steadfast", "Inner-focus", "Prankster",
    87.5f, 75, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.7f, 20.2f,
    57, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Emanation", "It uses the shapes of auras, which changeaccording to emotion, to communicate with others.",
    40, 70, 40, 35, 40, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 6, 11, 15, 19, 24, 29, 47, 50},
    new string[]
    {
         "Quick Attack", "Foresight", "Endure", "Counter", "Feint", "Force Palm", "Copycat", "Screech", "Reversal", "Nasty Plot", "Final Gambit",
    },
    new string[]
    {
         "Swords_Dance", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Shadow_Claw", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(448, "Lucario", PokemonData.Type.FIGHTING, PokemonData.Type.STEEL, "Steadfast", "Inner-focus", "Justified",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 54f,
    184, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Aura", "By catching the aura emanating from others, it canread their thoughts and movements.",
    70, 110, 70, 115, 70, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 6, 11, 15, 19, 29, 33, 47, 51, 60},
    new string[]
    {
         "Quick Attack", "Foresight", "Detect", "Metal Claw", "Extreme Speed", "Close Combat", "Aura Sphere", "Counter", "Feint", "Power-Up Punch", "Swords Dance", "Bone Rush", "Quick Guard", "Calm Mind", "Heal Pulse", "Dragon Pulse",
    },
    new string[]
    {
         "Swords_Dance", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Calm_Mind", "Payback", "Fling", "Poison_Jab", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Stone_Edge", "Hone_Claws", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(449, "Hippopotas", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-stream", null, "Sand-force",
    50f, 140, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.8f, 49.5f,
    66, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Hippo", "It lives in arid places. Instead of perspiration,it expels grainy sand from its body.",
    68, 72, 78, 38, 42, 32, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 19, 25, 31, 37, 44, 50},
    new string[]
    {
         "Sand Attack", "Tackle", "Bite", "Yawn", "Take Down", "Dig", "Sand Tomb", "Crunch", "Earthquake", "Double-Edge", "Fissure",
    },
    new string[]
    {
         "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Round", "Bulldoze", "Confide"
    },
    new int[] {450}, new string[] {"Level,34"}),


new PokemonData(450, "Hippowdon", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-stream", null, "Sand-force",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 2f, 300f,
    184, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Heavyweight", "It brandishes its gaping mouth in a display offearsome strength. It raises vast quantities of sandwhile attacking.",
    108, 112, 118, 68, 72, 47, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 19, 19, 31, 50, 60},
    new string[]
    {
         "Sand Attack", "Tackle", "Bite", "Yawn", "Thunder Fang", "Ice Fang", "Fire Fang", "Take Down", "Dig", "Crunch", "Double-Edge", "Fissure",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Giga_Impact", "Stone_Edge", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(451, "Skorupi", PokemonData.Type.POISON, PokemonData.Type.BUG, "Battle-armor", "Sniper", "Keen-eye",
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.8f, 12f,
    66, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Scorpion", "It grips prey with its tail claws and injects poison. It tenaciously hangs on until the poison takes.",
    40, 50, 90, 30, 55, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 16, 20, 23, 27, 30, 34, 38, 41, 45, 47, 49},
    new string[]
    {
         "Poison Sting", "Leer", "Bite", "Knock Off", "Pin Missile", "Acupressure", "Pursuit", "Bug Bite", "Poison Fang", "Venoshock", "Hone Claws", "Toxic Spikes", "Night Slash", "Scary Face", "Crunch", "Fell Stinger", "Cross Poison",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Fling", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Hone_Claws", "Venoshock", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {452}, new string[] {"Level,40"}),


new PokemonData(452, "Drapion", PokemonData.Type.POISON, PokemonData.Type.DARK, "Battle-armor", "Sniper", "Keen-eye",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.3f, 61.5f,
    175, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Ogre Scorpion", "It takes pride in its strength. Even though it cantear foes apart, it finishes them off withpowerful poison.",
    70, 90, 110, 60, 75, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 9, 13, 16, 20, 27, 30, 34, 38, 43, 49, 53, 57},
    new string[]
    {
         "Poison Sting", "Leer", "Bite", "Knock Off", "Thunder Fang", "Ice Fang", "Fire Fang", "Pin Missile", "Acupressure", "Pursuit", "Bug Bite", "Venoshock", "Hone Claws", "Toxic Spikes", "Night Slash", "Scary Face", "Crunch", "Fell Stinger", "Cross Poison",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Fling", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Giga_Impact", "Hone_Claws", "Venoshock", "Round", "Retaliate", "Struggle_Bug", "Bulldoze", "Snarl", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(453, "Croagunk", PokemonData.Type.POISON, PokemonData.Type.FIGHTING, "Anticipation", "Dry-skin", "Poison-touch",
    50f, 140, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 0.7f, 23f,
    60, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 100,
    "Toxic Mouth", "Its cheeks hold poison sacs. It tries to catch foesoff guard to jab them with toxic fingers.",
    48, 61, 40, 61, 40, 50, 0, Color.clear,
    new int[] { 1, 3, 8, 10, 15, 17, 22, 24, 29, 31, 36, 38, 43, 45, 47, 50},
    new string[]
    {
         "Astonish", "Mud-Slap", "Poison Sting", "Taunt", "Pursuit", "Feint Attack", "Revenge", "Swagger", "Mud Bomb", "Sucker Punch", "Venoshock", "Nasty Plot", "Poison Jab", "Sludge Bomb", "Belch", "Flatter",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Venoshock", "Sludge_Wave", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {454}, new string[] {"Level,37"}),


new PokemonData(454, "Toxicroak", PokemonData.Type.POISON, PokemonData.Type.FIGHTING, "Anticipation", "Dry-skin", "Poison-touch",
    50f, 75, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 257, 1.3f, 44.4f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Toxic Mouth", "It has a poison sac at its throat. When it croaks,the stored poison is churned for greater potency.",
    83, 106, 65, 86, 65, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 15, 22, 29, 31, 36, 41, 49, 54, 58, 62},
    new string[]
    {
         "Poison Sting", "Mud-Slap", "Astonish", "Taunt", "Pursuit", "Revenge", "Mud Bomb", "Sucker Punch", "Venoshock", "Nasty Plot", "Poison Jab", "Sludge Bomb", "Belch", "Flatter",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Venoshock", "Sludge_Wave", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(455, "Carnivine", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 200, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1.4f, 27f,
    159, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Bug Catcher", "It attracts prey with its sweet-smelling saliva, thenchomps down. It takes a whole day to eat prey.",
    74, 100, 72, 90, 72, 46, 0, Color.clear,
    new int[] { 1, 1, 7, 11, 17, 21, 27, 31, 37, 37, 37, 41, 47, 50},
    new string[]
    {
         "Bind", "Growth", "Bite", "Vine Whip", "Sweet Scent", "Ingrain", "Feint Attack", "Leaf Tornado", "Stockpile", "Spit Up", "Swallow", "Crunch", "Wring Out", "Power Whip",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Payback", "Fling", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(456, "Finneon", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Storm-drain", "Water-veil",
    50f, 190, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 0.4f, 7f,
    66, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Wing Fish", "The line running down its side can store sunlight. It shines vividly at night.",
    49, 49, 56, 49, 61, 66, 0, Color.clear,
    new int[] { 1, 6, 10, 13, 17, 22, 26, 29, 33, 38, 42, 45, 49, 54},
    new string[]
    {
         "Pound", "Water Gun", "Attract", "Rain Dance", "Gust", "Water Pulse", "Captivate", "Safeguard", "Aqua Ring", "Whirlpool", "U-turn", "Bounce", "Silver Wind", "Soak",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Hail", "Facade", "Nature_Power", "U_turn", "Payback", "Round", "Scald", "Confide"
    },
    new int[] {457}, new string[] {"Level,31"}),


new PokemonData(457, "Lumineon", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Storm-drain", "Water-veil",
    50f, 75, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 257, 1.2f, 24f,
    161, PokemonData.LevelingRate.FLUCTUATING, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
    "Neon", "It lives on the deep-sea floor. It attracts prey byflashing the patterns on its four tail fins.",
    69, 69, 76, 69, 86, 91, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 13, 22, 26, 35, 42, 48, 53, 59},
    new string[]
    {
         "Pound", "Gust", "Attract", "Soak", "Water Gun", "Rain Dance", "Water Pulse", "Captivate", "Aqua Ring", "Whirlpool", "U-turn", "Bounce", "Silver Wind",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Hail", "Facade", "U_turn", "Payback", "Giga_Impact", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(458, "Mantyke", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Swift-swim", "Water-absorb", "Water-veil",
    50f, 25, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1f, 65f,
    69, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BLUE, 70,
    "Kite", "The pattern on its back varies by region. It often swims in a school of Remoraid.",
    45, 20, 50, 60, 120, 50, 0, Color.clear,
    new int[] { 1, 1, 3, 7, 11, 14, 16, 19, 23, 27, 32, 36, 39, 46, 49},
    new string[]
    {
         "Tackle", "Bubble", "Supersonic", "Bubble Beam", "Confuse Ray", "Wing Attack", "Headbutt", "Water Pulse", "Wide Guard", "Take Down", "Agility", "Air Slash", "Aqua Ring", "Bounce", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Earthquake", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Aerial_Ace", "Round", "Scald", "Acrobatics", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(459, "Snover", PokemonData.Type.GRASS, PokemonData.Type.ICE, "Snow-warning", null, "Soundproof",
    50f, 120, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 1f, 50.5f,
    67, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Frost Tree", "During cold seasons, it migrates to the mountain’slower reaches. It returns to the snow-coveredsummit in the spring.",
    60, 62, 50, 62, 60, 40, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 26, 31, 36, 41, 46},
    new string[]
    {
         "Leer", "Powder Snow", "Razor Leaf", "Icy Wind", "Grass Whistle", "Swagger", "Mist", "Ice Shard", "Ingrain", "Wood Hammer", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Swords_Dance", "Ice_Beam", "Blizzard", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Facade", "Energy_Ball", "Grass_Knot", "Round", "Frost_Breath", "Confide"
    },
    new int[] {460}, new string[] {"Level,40"}),


new PokemonData(460, "Abomasnow", PokemonData.Type.GRASS, PokemonData.Type.ICE, "Snow-warning", null, "Soundproof",
    50f, 60, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 2.2f, 135.5f,
    173, PokemonData.LevelingRate.SLOW, 0, 1, 0, 1, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Frost Tree", "It blankets wide areas in snow by whipping upblizzards. It is also known as “The Ice Monster. ",
    90, 92, 75, 92, 85, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 21, 26, 31, 36, 47, 58},
    new string[]
    {
         "Ice Punch", "Leer", "Razor Leaf", "Icy Wind", "Grass Whistle", "Mist", "Ice Shard", "Ingrain", "Wood Hammer", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Swords_Dance", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Bulldoze", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(461, "Weavile", PokemonData.Type.DARK, PokemonData.Type.ICE, "Pressure", null, "Pickpocket",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.1f, 34f,
    179, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 1, PokemonData.PokedexColor.BLACK, 35,
    "Sharp Claw", "It lives in snowy regions. It carves patterns in treeswith its claws as a signal to others.",
    70, 120, 65, 45, 85, 125, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 10, 14, 16, 20, 22, 25, 28, 35, 40, 44, 47},
    new string[]
    {
         "Scratch", "Leer", "Quick Attack", "Taunt", "Revenge", "Assurance", "Embargo", "Feint Attack", "Icy Wind", "Fury Swipes", "Nasty Plot", "Metal Claw", "Hone Claws", "Fling", "Night Slash", "Snatch", "Punishment", "Dark Pulse",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Reflect", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Brick_Break", "Aerial_Ace", "Calm_Mind", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Low_Sweep", "Round", "Retaliate", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(462, "Magnezone", PokemonData.Type.ELECTRIC, PokemonData.Type.STEEL, "Magnet-pull", "Sturdy", "Analytic",
    112.5f, 30, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.2f, 180f,
    241, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Magnet Area", "Sometimes the magnetism emitted by Magnezone istoo strong, making them attract each other so theycannot move.",
    70, 70, 115, 130, 90, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 7, 11, 15, 18, 21, 25, 29, 34, 39, 45, 51, 62, 67},
    new string[]
    {
         "Tackle", "Supersonic", "Barrier", "Zap Cannon", "Mirror Coat", "Magnetic Flux", "Thunder Shock", "Electric Terrain", "Thunder Wave", "Magnet Bomb", "Spark", "Mirror Shot", "Metal Sound", "Electro Ball", "Flash Cannon", "Screech", "Discharge", "Magnet Rise", "Gyro Ball",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Facade", "Gyro_Ball", "Giga_Impact", "Flash_Cannon", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(463, "Lickilicky", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Own-tempo", "Oblivious", "Cloud-nine",
    50f, 30, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.7f, 140f,
    180, PokemonData.LevelingRate.MEDIUMFAST, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Licking", "It wraps things with its extensible tongue. Gettingtoo close to it will leave you soaked with drool.",
    110, 85, 95, 80, 95, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 45, 49, 61},
    new string[]
    {
         "Lick", "Wring Out", "Power Whip", "Supersonic", "Defense Curl", "Knock Off", "Wrap", "Stomp", "Disable", "Slam", "Rollout", "Refresh", "Screech", "Gyro Ball",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Dream_Eater", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Focus_Blast", "Giga_Impact", "Round", "Incinerate", "Retaliate", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(464, "Rhyperior", PokemonData.Type.GROUND, PokemonData.Type.ROCK, "Lightning-rod", "Solid-rock", "Reckless",
    50f, 30, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 257, 2.4f, 282.8f,
    241, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Drill", "From holes in its palms, it fires out Geodude. Its carapace can withstand volcanic eruptions.",
    115, 140, 130, 55, 55, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 19, 30, 41, 42, 47, 62, 71},
    new string[]
    {
         "Stomp", "Fury Attack", "Tail Whip", "Megahorn", "Poison Jab", "Rock Wrecker", "Scary Face", "Chip Away", "Take Down", "Hammer Arm", "Drill Run", "Earthquake", "Horn Drill",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Payback", "Fling", "Rock_Polish", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Round", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(465, "Tangrowth", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Leaf-guard", "Regenerator",
    50f, 30, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 257, 2f, 128.6f,
    187, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Vine", "It ensnares prey by extending arms made of vines. Losing arms to predators does not trouble it.",
    100, 100, 125, 110, 50, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 7, 10, 14, 17, 20, 23, 27, 30, 36, 40, 43, 46, 49, 50, 53},
    new string[]
    {
         "Constrict", "Ingrain", "Block", "Sleep Powder", "Vine Whip", "Absorb", "Poison Powder", "Bind", "Growth", "Mega Drain", "Knock Off", "Stun Spore", "Giga Drain", "Ancient Power", "Slam", "Tickle", "Wring Out", "Grassy Terrain", "Power Whip",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(466, "Electivire", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Motor-drive", null, "Vital-spirit",
    75f, 30, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.8f, 138.6f,
    243, PokemonData.LevelingRate.MEDIUMFAST, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Thunderbolt", "As its electric charge amplifies, blue sparks beginto crackle between its horns.",
    75, 123, 67, 95, 85, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 12, 15, 19, 22, 26, 29, 36, 42, 49, 55, 62},
    new string[]
    {
         "Fire Punch", "Leer", "Low Kick", "Quick Attack", "Ion Deluge", "Electric Terrain", "Thunder Shock", "Swift", "Shock Wave", "Thunder Wave", "Electro Ball", "Light Screen", "Thunder Punch", "Discharge", "Screech", "Thunderbolt", "Thunder", "Giga Impact",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Fling", "Focus_Blast", "Giga_Impact", "Charge_Beam", "Low_Sweep", "Round", "Volt_Switch", "Bulldoze", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(467, "Magmortar", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Flame-body", null, "Vital-spirit",
    75f, 30, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.6f, 68f,
    243, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Blast", "It blasts fireballs of over 3,600 degrees Fahrenheitfrom the ends of its arms. It lives involcanic craters.",
    75, 95, 67, 125, 95, 83, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 12, 15, 19, 22, 29, 36, 42, 55, 62},
    new string[]
    {
         "Thunder Punch", "Leer", "Ember", "Smokescreen", "Smog", "Feint Attack", "Fire Spin", "Clear Smog", "Flame Burst", "Fire Punch", "Lava Plume", "Sunny Day", "Fire Blast", "Hyper Beam",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Earthquake", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Fling", "Focus_Blast", "Giga_Impact", "Flame_Charge", "Low_Sweep", "Round", "Incinerate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(468, "Togekiss", PokemonData.Type.FAIRY, PokemonData.Type.FLYING, "Hustle", "Serene-grace", "Super-luck",
    87.5f, 30, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.5f, 38f,
    245, PokemonData.LevelingRate.FAST, 0, 0, 0, 2, 1, 0, PokemonData.PokedexColor.WHITE, 70,
    "Jubilee", "As everyone knows, it visits peaceful regions,bringing them gifts of kindness andsweet blessings.",
    85, 50, 95, 120, 115, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1},
    new string[]
    {
         "Sky Attack", "Extreme Speed", "Aura Sphere", "Air Slash", "After You",
    },
    new string[]
    {
         "Fly", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Roost", "Fling", "Giga_Impact", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(469, "Yanmega", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Speed-boost", "Tinted-lens", "Frisk",
    50f, 30, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.9f, 51.5f,
    180, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Ogre Darner", "It prefers to battle by biting apart foes’ headsinstantly while flying by at high speed.",
    86, 76, 86, 116, 56, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 14, 17, 22, 27, 30, 33, 38, 49, 57},
    new string[]
    {
         "Tackle", "Quick Attack", "Double Team", "Foresight", "Night Slash", "Air Slash", "Bug Bite", "Sonic Boom", "Detect", "Supersonic", "Uproar", "Pursuit", "Ancient Power", "Feint", "U-turn", "Bug Buzz",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Roost", "U_turn", "Giga_Impact", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(470, "Leafeon", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Leaf-guard", null, "Chlorophyll",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 25.5f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GREEN, 35,
    "Verdant", "When you see Leafeon asleep in a patch ofsunshine, you’ll know it is using photosynthesisto produce clean air.",
    65, 110, 130, 60, 65, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 20, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Razor Leaf", "Quick Attack", "Grass Whistle", "Magical Leaf", "Giga Drain", "Swords Dance", "Synthesis", "Sunny Day", "Last Resort", "Leaf Blade",
    },
    new string[]
    {
         "Swords_Dance", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Nature_Power", "Aerial_Ace", "X_Scissor", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Echoed_Voice", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(471, "Glaceon", PokemonData.Type.ICE, PokemonData.Type.NONE, "Snow-cloak", null, "Ice-body",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 25.9f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Fresh Snow", "By controlling its body heat, it can freeze theatmosphere around it to make adiamond-dust flurry.",
    65, 60, 110, 130, 95, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 20, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Sand Attack", "Icy Wind", "Quick Attack", "Bite", "Ice Fang", "Ice Shard", "Barrier", "Mirror Coat", "Hail", "Last Resort", "Blizzard",
    },
    new string[]
    {
         "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Giga_Impact", "Round", "Echoed_Voice", "Retaliate", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(472, "Gliscor", PokemonData.Type.GROUND, PokemonData.Type.FLYING, "Hyper-cutter", "Sand-veil", "Poison-heal",
    50f, 30, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 2f, 42.5f,
    179, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Fang Scorpion", "It observes prey while hanging inverted frombranches. When the chance presents itself,it swoops",
    75, 95, 125, 45, 75, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 16, 22, 27, 30, 35, 40},
    new string[]
    {
         "Guillotine", "Sand Attack", "Harden", "Knock Off", "Poison Jab", "Thunder Fang", "Ice Fang", "Fire Fang", "Fury Cutter", "Acrobatics", "Night Slash", "U-turn", "Screech", "X-Scissor",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Roost", "U_turn", "Payback", "Fling", "Rock_Polish", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Giga_Impact", "Stone_Edge", "Hone_Claws", "Venoshock", "Round", "Acrobatics", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(473, "Mamoswine", PokemonData.Type.ICE, PokemonData.Type.GROUND, "Oblivious", "Snow-cloak", "Thick-fat",
    50f, 50, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 2.5f, 291f,
    239, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Twin Tusk", "A frozen Mamoswine was dug from ice dating back10,000 years. This Pokémon has been around along, long, long time.",
    110, 130, 80, 70, 60, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 11, 14, 18, 21, 24, 28, 33, 37, 41, 46, 52, 58},
    new string[]
    {
         "Peck", "Powder Snow", "Ancient Power", "Mud Sport", "Mud-Slap", "Endure", "Mud Bomb", "Hail", "Ice Fang", "Take Down", "Double Hit", "Mist", "Thrash", "Earthquake", "Blizzard", "Scary Face",
    },
    new string[]
    {
         "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Giga_Impact", "Stone_Edge", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(474, "Porygon-z", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Adaptability", "Download", "Analytic",
    112.5f, 30, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.9f, 34f,
    241, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Virtual", "Additional software was installed to make it a betterPokémon. It began acting oddly, however.",
    85, 80, 70, 135, 75, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 7, 12, 18, 23, 34, 40, 50, 67},
    new string[]
    {
         "Tackle", "Conversion", "Conversion 2", "Zap Cannon", "Magic Coat", "Nasty Plot", "Trick Room", "Psybeam", "Agility", "Recover", "Magnet Rise", "Embargo", "Discharge", "Tri Attack", "Hyper Beam",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Embargo", "Dark_Pulse", "Giga_Impact", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(475, "Gallade", PokemonData.Type.PSYCHIC, PokemonData.Type.FIGHTING, "Steadfast", null, "Justified",
    100f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.6f, 52f,
    233, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 35,
    "Blade", "Because it can sense what its foe is thinking,its attacks burst out first, fast, and fierce.",
    68, 125, 65, 65, 115, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 12, 17, 31, 36, 39, 45, 50, 53},
    new string[]
    {
         "Leer", "Confusion", "Double Team", "Leaf Blade", "Close Combat", "Stored Power", "Teleport", "Fury Cutter", "Swords Dance", "Psycho Cut", "Helping Hand", "Feint", "False Swipe", "Protect",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Calm_Mind", "Fling", "Poison_Jab", "X_Scissor", "Focus_Blast", "Giga_Impact", "Trick_Room", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Psyshock", "Low_Sweep", "Round", "Echoed_Voice", "Retaliate", "Bulldoze", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(476, "Probopass", PokemonData.Type.ROCK, PokemonData.Type.STEEL, "Sturdy", "Magnet-pull", "Sand-force",
    50f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.4f, 340f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 2, 0, PokemonData.PokedexColor.GRAY, 70,
    "Compass", "It exudes strong magnetism from all over. It controls three small units called Mini-Noses.",
    60, 55, 145, 75, 150, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 8, 15, 18, 22, 25, 29, 32, 36, 39, 43, 50, 50},
    new string[]
    {
         "Tackle", "Iron Defense", "Gravity", "Magnet Rise", "Magnet Bomb", "Block", "Thunder Wave", "Rock Blast", "Rest", "Spark", "Rock Slide", "Power Gem", "Sandstorm", "Discharge", "Earth Power", "Zap Cannon", "Lock-On",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Rock_Polish", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Round", "Volt_Switch", "Bulldoze", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(477, "Dusknoir", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Pressure", null, "Frisk",
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 2.2f, 106.6f,
    236, PokemonData.LevelingRate.FAST, 0, 0, 1, 0, 2, 0, PokemonData.PokedexColor.BLACK, 35,
    "Gripper", "It is said to take lost spirits into its pliant body andguide them home.",
    45, 100, 135, 65, 135, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 9, 14, 17, 22, 25, 30, 33, 37, 42, 49, 58, 61},
    new string[]
    {
         "Fire Punch", "Ice Punch", "Thunder Punch", "Bind", "Leer", "Disable", "Gravity", "Foresight", "Astonish", "Confuse Ray", "Shadow Sneak", "Pursuit", "Curse", "Will-O-Wisp", "Shadow Punch", "Hex", "Mean Look", "Payback", "Future Sight",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Calm_Mind", "Payback", "Embargo", "Fling", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Trick_Room", "Charge_Beam", "Round", "Bulldoze", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(478, "Froslass", PokemonData.Type.ICE, PokemonData.Type.GHOST, "Snow-cloak", null, "Cursed-body",
    0f, 75, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.3f, 26.6f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.WHITE, 70,
    "Snow Land", "It freezes foes with an icy breath nearly-60 degrees Fahrenheit. What seems to be its bodyis actually hollow.",
    70, 80, 70, 80, 70, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 22, 31, 37, 40, 51},
    new string[]
    {
         "Leer", "Double Team", "Powder Snow", "Destiny Bond", "Astonish", "Ominous Wind", "Captivate", "Ice Shard", "Hail", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Hail", "Torment", "Facade", "Taunt", "Payback", "Embargo", "Fling", "Giga_Impact", "Round", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(479, "Rotom", PokemonData.Type.ELECTRIC, PokemonData.Type.GHOST, "Levitate", null, null,
    112.5f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.3f, 0.3f,
    154, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.RED, 70,
    "Plasma", "Research continues on this Pokémon, which couldbe the power source of a unique motor.",
    50, 50, 77, 95, 77, 91, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 8, 15, 22, 36, 43, 50},
    new string[]
    {
         "Thunder Shock", "Thunder Wave", "Confuse Ray", "Charge", "Astonish", "Discharge", "Uproar", "Double Team", "Shock Wave", "Substitute", "Electro Ball", "Hex",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Dark_Pulse", "Charge_Beam", "Round", "Volt_Switch", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(480, "Uxie", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Levitate", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 0.3f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 2, 0, 1, 0, PokemonData.PokedexColor.YELLOW, 140,
    "Knowledge", "Known as “The Being of Knowledge. ” It is said thatit can wipe out the memory of those who seeits eyes.",
    75, 75, 130, 75, 130, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 6, 21, 36, 46, 50},
    new string[]
    {
         "Confusion", "Rest", "Flail", "Memento", "Natural Gift", "Imprison", "Swift", "Future Sight", "Amnesia", "Extrasensory",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Calm_Mind", "U_turn", "Fling", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Acrobatics", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(481, "Mesprit", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Levitate", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 0.3f,
    261, PokemonData.LevelingRate.SLOW, 0, 1, 0, 1, 1, 0, PokemonData.PokedexColor.PINK, 140,
    "Emotion", "Known as “The Being of Emotion. ” It taughthumans the nobility of sorrow, pain, and joy.",
    80, 105, 105, 105, 105, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 16, 21, 31, 36, 46, 50, 66},
    new string[]
    {
         "Confusion", "Rest", "Healing Wish", "Copycat", "Imprison", "Protect", "Swift", "Lucky Chant", "Future Sight", "Charm", "Extrasensory", "Natural Gift",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Calm_Mind", "U_turn", "Fling", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Acrobatics", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(482, "Azelf", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Levitate", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.3f, 0.3f,
    261, PokemonData.LevelingRate.SLOW, 0, 2, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 140,
    "Willpower", "Known as “The Being of Willpower. ” It sleeps at thebottom of a lake to keep the world in balance.",
    75, 125, 70, 125, 70, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 6, 16, 21, 31, 36, 46, 50, 61, 76},
    new string[]
    {
         "Confusion", "Rest", "Natural Gift", "Imprison", "Detect", "Swift", "Uproar", "Future Sight", "Nasty Plot", "Extrasensory", "Last Resort", "Explosion",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Explosion", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Calm_Mind", "U_turn", "Payback", "Fling", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Incinerate", "Acrobatics", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(483, "Dialga", PokemonData.Type.STEEL, PokemonData.Type.DRAGON, "Pressure", null, "Telepathy",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 5.4f, 683f,
    306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.WHITE, 0,
    "Temporal", "A Pokémon spoken of in legend. It is said that timebegan moving when Dialga was born.",
    100, 120, 120, 150, 100, 90, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 19, 24, 28, 33, 37, 42, 46, 50},
    new string[]
    {
         "Scary Face", "Dragon Breath", "Metal Claw", "Ancient Power", "Slash", "Power Gem", "Metal Burst", "Dragon Claw", "Earth Power", "Aura Sphere", "Iron Tail", "Roar of Time", "Flash Cannon",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Trick_Room", "Stone_Edge", "Hone_Claws", "Round", "Echoed_Voice", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(484, "Palkia", PokemonData.Type.WATER, PokemonData.Type.DRAGON, "Pressure", null, "Telepathy",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 4.2f, 336f,
    306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.PURPLE, 0,
    "Spatial", "It is said to live in a gap in the spatial dimensionparallel to ours. It appears in mythology.",
    90, 120, 100, 150, 120, 100, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 24, 28, 33, 37, 46, 50},
    new string[]
    {
         "Scary Face", "Dragon Breath", "Water Pulse", "Ancient Power", "Slash", "Aqua Tail", "Dragon Claw", "Earth Power", "Aura Sphere", "Spacial Rend", "Hydro Pump",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Trick_Room", "Stone_Edge", "Hone_Claws", "Round", "Echoed_Voice", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(485, "Heatran", PokemonData.Type.FIRE, PokemonData.Type.STEEL, "Flash-fire", null, "Flame-body",
    50f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.7f, 430f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BROWN, 100,
    "Lava Dome", "It dwells in volcanic caves. It digs in with itscross-shaped feet to crawl on ceilings and walls.",
    91, 90, 106, 130, 106, 77, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 9, 33, 49},
    new string[]
    {
         "Fire Spin", "Ancient Power", "Heat Wave", "Earth Power", "Iron Head", "Magma Storm", "Leer", "Crunch", "Lava Plume",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Nature_Power", "Taunt", "Overheat", "Rock_Tomb", "Payback", "Dark_Pulse", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Flame_Charge", "Round", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(486, "Regigigas", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Slow-start", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 3.7f, 420f,
    302, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 0,
    "Colossal", "It is said to have made Pokémon that look likeitself from a special ice mountain, rocks,and magma.",
    110, 160, 110, 80, 110, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 25, 50, 65, 100},
    new string[]
    {
         "Fire Punch", "Ice Punch", "Thunder Punch", "Confuse Ray", "Dizzy Punch", "Foresight", "Knock Off", "Crush Grip", "Heavy Slam", "Revenge", "Zen Headbutt", "Payback", "Giga Impact",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Double_Team", "Rock_Slide", "Substitute", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Fling", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Smack_Down", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(487, "Giratina-altered", PokemonData.Type.GHOST, PokemonData.Type.DRAGON, "Pressure", null, "Telepathy",
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 4.5f, 750f,
    306, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 0,
    "Renegade", "This Pokémon is said to live in a world on thereverse side of ours, where common knowledge isdistorted and strange.",
    150, 100, 120, 100, 120, 90, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 19, 24, 28, 33, 37, 42, 46, 50},
    new string[]
    {
         "Scary Face", "Dragon Breath", "Ominous Wind", "Ancient Power", "Slash", "Shadow Sneak", "Destiny Bond", "Dragon Claw", "Earth Power", "Aura Sphere", "Shadow Claw", "Shadow Force", "Hex",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Protect", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Aerial_Ace", "Dragon_Claw", "Calm_Mind", "Payback", "Dark_Pulse", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Charge_Beam", "Hone_Claws", "Round", "Echoed_Voice", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(488, "Cresselia", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Levitate", null, null,
    0f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.5f, 85.6f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.YELLOW, 100,
    "Lunar", "Shiny particles are released from its wings like aveil. It is said to represent the crescent moon.",
    120, 70, 120, 75, 130, 85, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 11, 20, 29, 47, 66, 93},
    new string[]
    {
         "Confusion", "Double Team", "Moonlight", "Psycho Shift", "Lunar Dance", "Safeguard", "Mist", "Aurora Beam", "Slash", "Psycho Cut", "Psychic",
    },
    new string[]
    {
         "Ice_Beam", "Hyper_Beam", "Solar_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Calm_Mind", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(489, "Phione", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hydration", null, null,
    112.5f, 30, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 3.1f,
    216, PokemonData.LevelingRate.SLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Sea Drifter", "When the water warms, they inflate the flotation sacon their heads and drift languidly on the seain packs.",
    80, 80, 80, 80, 80, 80, 0, Color.clear,
    new int[] { 1, 1, 9, 16, 24, 31, 39, 46, 54, 61, 69},
    new string[]
    {
         "Bubble", "Water Sport", "Charm", "Supersonic", "Bubble Beam", "Acid Armor", "Whirlpool", "Water Pulse", "Aqua Ring", "Dive", "Rain Dance",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Hail", "Facade", "U_turn", "Fling", "Grass_Knot", "Round", "Scald", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(490, "Manaphy", PokemonData.Type.WATER, PokemonData.Type.NONE, "Hydration", null, null,
    112.5f, 3, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.3f, 1.4f,
    270, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Seafaring", "It is born with a wondrous power that lets it bondwith any kind of Pokémon.",
    100, 100, 100, 100, 100, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 9, 16, 24, 31, 39, 46, 54, 61, 69, 76},
    new string[]
    {
         "Bubble", "Tail Glow", "Water Sport", "Charm", "Supersonic", "Bubble Beam", "Acid Armor", "Whirlpool", "Water Pulse", "Aqua Ring", "Dive", "Rain Dance", "Heart Swap",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Waterfall", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Hail", "Facade", "Calm_Mind", "U_turn", "Fling", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Scald", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(491, "Darkrai", PokemonData.Type.DARK, PokemonData.Type.NONE, "Bad-dreams", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.5f, 50.5f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 1, PokemonData.PokedexColor.BLACK, 0,
    "Pitch-Black", "It chases people and Pokémon from its territory bycausing them to experience deep,nightmarish slumbers.",
    70, 90, 90, 135, 90, 125, 0, Color.clear,
    new int[] { 1, 1, 11, 20, 29, 38, 47, 57, 66, 75, 84, 93},
    new string[]
    {
         "Disable", "Ominous Wind", "Quick Attack", "Hypnosis", "Feint Attack", "Nightmare", "Double Team", "Haze", "Dark Void", "Nasty Plot", "Dream Eater", "Dark Pulse",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Calm_Mind", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Charge_Beam", "Round", "Incinerate", "Retaliate", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(492, "Shaymin-land", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Natural-cure", null, null,
    112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.2f, 2.1f,
    270, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 100,
    "Gratitude", "It can dissolve toxins in the air to instantlytransform ruined land into a lush field of flowers.",
    100, 100, 100, 100, 100, 100, 0, Color.clear,
    new int[] { 1, 10, 19, 28, 37, 46, 55, 64, 73, 82, 91, 100},
    new string[]
    {
         "Growth", "Magical Leaf", "Leech Seed", "Synthesis", "Sweet Scent", "Natural Gift", "Worry Seed", "Aromatherapy", "Energy Ball", "Sweet Kiss", "Healing Wish", "Seed Flare",
    },
    new string[]
    {
         "Swords_Dance", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Facade", "Nature_Power", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(493, "Arceus", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Multitype", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 3.2f, 320f,
    324, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 0,
    "Alpha", "According to the legends of Sinnoh, this Pokémonemerged from an egg and shaped all there is inthis world.",
    120, 120, 120, 120, 120, 120, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100},
    new string[]
    {
         "Seismic Toss", "Cosmic Power", "Natural Gift", "Punishment", "Gravity", "Earth Power", "Hyper Voice", "Extreme Speed", "Refresh", "Future Sight", "Recover", "Hyper Beam", "Perish Song", "Judgment",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Fly", "Roar", "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Waterfall", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Hail", "Will_O_Wisp", "Facade", "Brick_Break", "Overheat", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Calm_Mind", "Payback", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Trick_Room", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Psyshock", "Round", "Echoed_Voice", "Incinerate", "Quash", "Retaliate", "Bulldoze", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(494, "Victini", PokemonData.Type.PSYCHIC, PokemonData.Type.FIRE, "Victory-star", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.4f, 4f,
    270, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 100,
    "Victory", "This Pokémon brings victory. It is said that Trainerswith Victini always win, regardless of the typeof encounter.",
    100, 100, 100, 100, 100, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 9, 17, 25, 33, 41, 49, 57, 65, 73, 81, 89, 97},
    new string[]
    {
         "Confusion", "Quick Attack", "Focus Energy", "Incinerate", "Searing Shot", "Endure", "Headbutt", "Flame Charge", "Reversal", "Flame Burst", "Zen Headbutt", "Inferno", "Double-Edge", "Flare Blitz", "Final Gambit", "Stored Power", "Overheat",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "U_turn", "Embargo", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Flame_Charge", "Round", "Incinerate", "Wild_Charge", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(495, "Snivy", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Contrary",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 8.1f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Grass Snake", "Being exposed to sunlight makes its movementsswifter. It uses vines more adeptly than its hands.",
    45, 45, 55, 45, 55, 63, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43},
    new string[]
    {
         "Tackle", "Leer", "Vine Whip", "Wrap", "Growth", "Leaf Tornado", "Leech Seed", "Mega Drain", "Slam", "Leaf Blade", "Coil", "Giga Drain", "Wring Out", "Gastro Acid", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Torment", "Facade", "Nature_Power", "Taunt", "Aerial_Ace", "Calm_Mind", "Energy_Ball", "Grass_Knot", "Round", "Confide"
    },
    new int[] {496}, new string[] {"Level,17"}),


new PokemonData(496, "Servine", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Contrary",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 16f,
    145, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
    "Grass Snake", "It moves along the ground as if sliding. Its swiftmovements befuddle its foes, and it then attackswith a vine whip.",
    60, 60, 75, 60, 75, 83, 0, Color.clear,
    new int[] { 1, 1, 4, 13, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52},
    new string[]
    {
         "Vine Whip", "Wrap", "Leer", "Growth", "Leaf Tornado", "Leech Seed", "Mega Drain", "Slam", "Leaf Blade", "Coil", "Giga Drain", "Wring Out", "Gastro Acid", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Torment", "Facade", "Nature_Power", "Taunt", "Aerial_Ace", "Calm_Mind", "Energy_Ball", "Grass_Knot", "Round", "Confide"
    },
    new int[] {497}, new string[] {"Level,36"}),


new PokemonData(497, "Serperior", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Contrary",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 3.3f, 63f,
    238, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.GREEN, 70,
    "Regal", "It only gives its all against strong opponents whoare not fazed by the glare from Serperior’snoble eyes.",
    75, 75, 95, 75, 95, 113, 0, Color.clear,
    new int[] { 1, 1, 4, 13, 16, 20, 24, 28, 32, 38, 44, 50, 56, 62},
    new string[]
    {
         "Vine Whip", "Wrap", "Leer", "Growth", "Leaf Tornado", "Leech Seed", "Mega Drain", "Slam", "Leaf Blade", "Coil", "Giga Drain", "Wring Out", "Gastro Acid", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Taunt", "Aerial_Ace", "Calm_Mind", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(498, "Tepig", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Thick-fat",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 9.9f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Fire Pig", "It can deftly dodge its foe’s attacks while shootingfireballs from its nose. It roasts berries before iteats them.",
    65, 63, 45, 45, 45, 45, 0, Color.clear,
    new int[] { 1, 3, 7, 9, 13, 15, 19, 21, 25, 27, 31, 33, 37, 39, 43},
    new string[]
    {
         "Tackle", "Tail Whip", "Ember", "Odor Sleuth", "Defense Curl", "Flame Charge", "Smog", "Rollout", "Take Down", "Heat Crash", "Assurance", "Flamethrower", "Head Smash", "Roar", "Flare Blitz",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Rock_Tomb", "Gyro_Ball", "Grass_Knot", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Wild_Charge", "Confide"
    },
    new int[] {499}, new string[] {"Level,17"}),


new PokemonData(499, "Pignite", PokemonData.Type.FIRE, PokemonData.Type.FIGHTING, "Blaze", null, "Thick-fat",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 55.5f,
    146, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Fire Pig", "The more it eats, the more fuel it has to make thefire in its stomach stronger. This fills it with evenmore power.",
    90, 93, 55, 70, 55, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 15, 17, 20, 23, 28, 31, 44, 52},
    new string[]
    {
         "Tackle", "Tail Whip", "Ember", "Odor Sleuth", "Defense Curl", "Flame Charge", "Arm Thrust", "Smog", "Rollout", "Take Down", "Heat Crash", "Head Smash", "Flare Blitz",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Gyro_Ball", "Fling", "Poison_Jab", "Focus_Blast", "Stone_Edge", "Grass_Knot", "Flame_Charge", "Low_Sweep", "Round", "Echoed_Voice", "Incinerate", "Bulldoze", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {500}, new string[] {"Level,36"}),


new PokemonData(500, "Emboar", PokemonData.Type.FIRE, PokemonData.Type.FIGHTING, "Blaze", null, "Reckless",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.6f, 150f,
    238, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Mega Fire Pig", "It can throw a fire punch by setting its fists on firewith its fiery chin. It cares deeply about its friends.",
    110, 123, 65, 100, 65, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 15, 17, 20, 23, 28, 31, 38, 50, 62},
    new string[]
    {
         "Tackle", "Tail Whip", "Ember", "Odor Sleuth", "Defense Curl", "Flame Charge", "Arm Thrust", "Smog", "Rollout", "Take Down", "Heat Crash", "Assurance", "Head Smash", "Flare Blitz",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Bulk_Up", "Gyro_Ball", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Smack_Down", "Flame_Charge", "Low_Sweep", "Round", "Echoed_Voice", "Scald", "Incinerate", "Bulldoze", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(501, "Oshawott", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Shell-armor",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 5.9f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Sea Otter", "The scalchop on its stomach isn’t just used forbattle--it can be used to break open hard berriesas well.",
    55, 55, 45, 63, 45, 45, 0, Color.clear,
    new int[] { 1, 5, 7, 11, 13, 17, 19, 23, 25, 29, 31, 35, 37, 41, 43},
    new string[]
    {
         "Tackle", "Tail Whip", "Water Gun", "Water Sport", "Focus Energy", "Razor Shell", "Fury Cutter", "Water Pulse", "Revenge", "Aqua Jet", "Encore", "Aqua Tail", "Retaliate", "Swords Dance", "Hydro Pump",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Taunt", "Aerial_Ace", "Fling", "X_Scissor", "Grass_Knot", "Round", "Scald", "Retaliate", "Confide"
    },
    new int[] {502}, new string[] {"Level,17"}),


new PokemonData(502, "Dewott", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Shell-armor",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 24.5f,
    145, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Discipline", "Strict training is how it learns its flowingdouble-scalchop technique.",
    75, 75, 60, 83, 60, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 13, 17, 20, 28, 33, 36, 41, 44, 49, 52},
    new string[]
    {
         "Tackle", "Tail Whip", "Water Sport", "Water Gun", "Focus Energy", "Razor Shell", "Fury Cutter", "Revenge", "Aqua Jet", "Encore", "Aqua Tail", "Retaliate", "Swords Dance", "Hydro Pump",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Taunt", "Aerial_Ace", "Fling", "X_Scissor", "Grass_Knot", "Round", "Scald", "Retaliate", "Confide"
    },
    new int[] {503}, new string[] {"Level,36"}),


new PokemonData(503, "Samurott", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Shell-armor",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.5f, 94.6f,
    238, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Formidable", "In the time it takes a foe to blink, it can draw andsheathe the seamitars attached to its front legs.",
    95, 100, 85, 108, 70, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 7, 13, 17, 20, 28, 33, 36, 38, 45, 50, 57, 62},
    new string[]
    {
         "Tackle", "Tail Whip", "Megahorn", "Water Sport", "Water Gun", "Focus Energy", "Razor Shell", "Fury Cutter", "Revenge", "Aqua Jet", "Slash", "Encore", "Aqua Tail", "Retaliate", "Swords Dance", "Hydro Pump",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Taunt", "Aerial_Ace", "Fling", "X_Scissor", "Giga_Impact", "Grass_Knot", "Round", "Scald", "Retaliate", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(504, "Patrat", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Run-away", "Keen-eye", "Analytic",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 11.6f,
    51, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Scout", "Using food stored in cheek pouches, they can keepwatch for days. They use their tails to communicatewith others.",
    45, 55, 39, 35, 39, 42, 0, Color.clear,
    new int[] { 1, 3, 6, 8, 11, 13, 16, 18, 21, 23, 26, 28, 31, 33, 36},
    new string[]
    {
         "Tackle", "Leer", "Bite", "Bide", "Detect", "Sand Attack", "Crunch", "Hypnosis", "Super Fang", "After You", "Work Up", "Hyper Fang", "Mean Look", "Baton Pass", "Slam",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Thunderbolt", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Fling", "Grass_Knot", "Round", "Retaliate", "Confide"
    },
    new int[] {505}, new string[] {"Level,20"}),


new PokemonData(505, "Watchog", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Illuminate", "Keen-eye", "Analytic",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 27f,
    147, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Lookout", "Using luminescent matter, it makes its eyes andbody glow and stuns attacking opponents.",
    60, 85, 69, 60, 69, 77, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 8, 11, 13, 16, 18, 20, 22, 25, 29, 32, 36, 39, 43},
    new string[]
    {
         "Tackle", "Leer", "Low Kick", "Rototiller", "Bite", "Bide", "Detect", "Sand Attack", "Crunch", "Hypnosis", "Confuse Ray", "Super Fang", "After You", "Psych Up", "Hyper Fang", "Mean Look", "Baton Pass", "Slam",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Flamethrower", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Fling", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Round", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(506, "Lillipup", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Vital-spirit", "Pickup", "Run-away",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 4.1f,
    55, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Puppy", "The long hair around its face provides an amazingradar that lets it sense subtle changes inits surroundings.",
    45, 60, 45, 25, 45, 55, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 10, 12, 15, 19, 22, 26, 29, 33, 36, 40, 45},
    new string[]
    {
         "Tackle", "Leer", "Odor Sleuth", "Bite", "Baby-Doll Eyes", "Helping Hand", "Take Down", "Work Up", "Crunch", "Roar", "Retaliate", "Reversal", "Last Resort", "Giga Impact", "Play Rough",
    },
    new string[]
    {
         "Roar", "Thunderbolt", "Thunder_Wave", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Giga_Impact", "Round", "Retaliate", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {507}, new string[] {"Level,16"}),


new PokemonData(507, "Herdier", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Intimidate", "Sand-rush", "Scrappy",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 14.7f,
    130, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Loyal Dog", "This very loyal Pokémon helps Trainers, and it alsotakes care of other Pokémon.",
    65, 80, 65, 35, 65, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 12, 15, 20, 24, 33, 38, 47, 52},
    new string[]
    {
         "Tackle", "Leer", "Bite", "Odor Sleuth", "Helping Hand", "Take Down", "Work Up", "Crunch", "Retaliate", "Reversal", "Giga Impact", "Play Rough",
    },
    new string[]
    {
         "Roar", "Surf", "Strength", "Thunderbolt", "Thunder_Wave", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Payback", "Giga_Impact", "Round", "Retaliate", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {508}, new string[] {"Level,32"}),


new PokemonData(508, "Stoutland", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Intimidate", "Sand-rush", "Scrappy",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 61f,
    225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Big-Hearted", "It rescues people stranded by blizzards in themountains. Its shaggy fur shields it from the cold.",
    85, 110, 90, 45, 90, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 12, 15, 20, 24, 36, 42, 59, 63},
    new string[]
    {
         "Tackle", "Leer", "Bite", "Odor Sleuth", "Thunder Fang", "Ice Fang", "Fire Fang", "Helping Hand", "Take Down", "Work Up", "Crunch", "Retaliate", "Reversal", "Giga Impact", "Play Rough",
    },
    new string[]
    {
         "Roar", "Surf", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Payback", "Giga_Impact", "Round", "Retaliate", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(509, "Purrloin", PokemonData.Type.DARK, PokemonData.Type.NONE, "Limber", "Unburden", "Prankster",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 10.1f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Devious", "Its cute act is a ruse. When victims let down theirguard, they find their items taken. It attacks withsharp claws.",
    41, 50, 37, 50, 37, 66, 0, Color.clear,
    new int[] { 1, 3, 6, 10, 12, 15, 19, 21, 24, 28, 30, 33, 37, 39, 42, 46, 49},
    new string[]
    {
         "Scratch", "Growl", "Assist", "Sand Attack", "Fury Swipes", "Pursuit", "Torment", "Fake Out", "Hone Claws", "Assurance", "Slash", "Captivate", "Night Slash", "Snatch", "Nasty Plot", "Sucker Punch", "Play Rough",
    },
    new string[]
    {
         "Cut", "Thunder_Wave", "Toxic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "U_turn", "Payback", "Embargo", "Dark_Pulse", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Round", "Echoed_Voice", "Snarl", "Confide"
    },
    new int[] {510}, new string[] {"Level,20"}),


new PokemonData(510, "Liepard", PokemonData.Type.DARK, PokemonData.Type.NONE, "Limber", "Unburden", "Prankster",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 37.5f,
    156, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
    "Cruel", "Their beautiful form comes from the muscles theyhave developed. They run silently in the night.",
    64, 88, 50, 88, 50, 106, 0, Color.clear,
    new int[] { 1, 1, 1, 3, 12, 15, 19, 22, 26, 31, 34, 38, 43, 50, 55, 58},
    new string[]
    {
         "Scratch", "Sand Attack", "Assist", "Growl", "Fury Swipes", "Pursuit", "Torment", "Fake Out", "Hone Claws", "Assurance", "Slash", "Taunt", "Night Slash", "Nasty Plot", "Sucker Punch", "Play Rough",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Thunder_Wave", "Toxic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Aerial_Ace", "U_turn", "Payback", "Embargo", "Dark_Pulse", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Round", "Echoed_Voice", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(511, "Pansage", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Gluttony", null, "Overgrow",
    87.5f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 10.5f,
    63, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Grass Monkey", "It shares the leaf on its head with weary-lookingPokémon. These leaves are known to relieve stress.",
    50, 53, 48, 53, 48, 64, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43},
    new string[]
    {
         "Scratch", "Play Nice", "Leer", "Lick", "Vine Whip", "Fury Swipes", "Leech Seed", "Bite", "Seed Bomb", "Torment", "Fling", "Acrobatics", "Grass Knot", "Recycle", "Natural Gift", "Crunch",
    },
    new string[]
    {
         "Cut", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Taunt", "Rock_Tomb", "Payback", "Fling", "Energy_Ball", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(512, "Simisage", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Gluttony", null, "Overgrow",
    87.5f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 30.5f,
    174, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
    "Thorn Monkey", "It attacks enemies with strikes of its thorn-coveredtail. This Pokémon is wild tempered.",
    75, 98, 63, 98, 63, 101, 0, Color.clear,
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Leer", "Lick", "Fury Swipes", "Seed Bomb",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Taunt", "Brick_Break", "Rock_Tomb", "Payback", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Acrobatics", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(513, "Pansear", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Gluttony", null, "Blaze",
    87.5f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 11f,
    63, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
    "High Temp", "Very intelligent, it roasts berries before eating them. It likes to help people.",
    50, 53, 48, 53, 48, 64, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43},
    new string[]
    {
         "Scratch", "Play Nice", "Leer", "Lick", "Incinerate", "Fury Swipes", "Yawn", "Bite", "Flame Burst", "Amnesia", "Fling", "Acrobatics", "Fire Blast", "Recycle", "Natural Gift", "Crunch",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Rock_Tomb", "Payback", "Fling", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Flame_Charge", "Low_Sweep", "Round", "Incinerate", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(514, "Simisear", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Gluttony", null, "Blaze",
    87.5f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 28f,
    174, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.RED, 70,
    "Ember", "A flame burns inside its body. It scatters embersfrom its head and tail to sear its opponents.",
    75, 98, 63, 98, 63, 101, 0, Color.clear,
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Leer", "Lick", "Fury Swipes", "Flame Burst",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Payback", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Flame_Charge", "Low_Sweep", "Round", "Incinerate", "Acrobatics", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(515, "Panpour", PokemonData.Type.WATER, PokemonData.Type.NONE, "Gluttony", null, "Torrent",
    87.5f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 13.5f,
    63, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Spray", "The water stored inside the tuft on its head is fullof nutrients. It waters plants with it using its tail.",
    50, 53, 48, 53, 48, 64, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43},
    new string[]
    {
         "Scratch", "Play Nice", "Leer", "Lick", "Water Gun", "Fury Swipes", "Water Sport", "Bite", "Scald", "Taunt", "Fling", "Acrobatics", "Brine", "Recycle", "Natural Gift", "Crunch",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Rock_Tomb", "Payback", "Fling", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Scald", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(516, "Simipour", PokemonData.Type.WATER, PokemonData.Type.NONE, "Gluttony", null, "Torrent",
    87.5f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 29f,
    174, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
    "Geyser", "The high-pressure water expelled from its tail is sopowerful, it can destroy a concrete wall.",
    75, 98, 63, 98, 63, 101, 0, Color.clear,
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Leer", "Lick", "Fury Swipes", "Scald",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Payback", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Scald", "Acrobatics", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(517, "Munna", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Forewarn", "Synchronize", "Telepathy",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 23.3f,
    58, PokemonData.LevelingRate.FAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Dream Eater", "This Pokémon appears before people and Pokémonwho are having nightmares and eats those dreams.",
    76, 25, 45, 67, 55, 24, 0, Color.clear,
    new int[] { 1, 1, 5, 7, 11, 13, 17, 19, 23, 25, 29, 31, 35, 37, 41, 43, 47},
    new string[]
    {
         "Defense Curl", "Psywave", "Lucky Chant", "Yawn", "Psybeam", "Imprison", "Moonlight", "Hypnosis", "Zen Headbutt", "Synchronoise", "Nightmare", "Future Sight", "Calm Mind", "Psychic", "Dream Eater", "Telekinesis", "Stored Power",
    },
    new string[]
    {
         "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Energy_Ball", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(518, "Musharna", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Forewarn", "Synchronize", "Telepathy",
    50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 60.5f,
    170, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Drowsing", "The mist emanating from their foreheads is packedwith the dreams of people and Pokémon.",
    116, 55, 85, 107, 95, 29, 0, Color.clear,
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Psybeam", "Hypnosis", "Defense Curl", "Lucky Chant",
    },
    new string[]
    {
         "Hyper_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Energy_Ball", "Giga_Impact", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(519, "Pidove", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Big-pecks", "Super-luck", "Rivalry",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 2.1f,
    53, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Tiny Pigeon", "This very forgetful Pokémon will wait for a neworder from its Trainer even though it alreadyhas one.",
    50, 55, 50, 36, 30, 43, 0, Color.clear,
    new int[] { 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43, 46, 50},
    new string[]
    {
         "Gust", "Growl", "Leer", "Quick Attack", "Air Cutter", "Roost", "Detect", "Taunt", "Air Slash", "Razor Wind", "Feather Dance", "Swagger", "Facade", "Tailwind", "Sky Attack",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Taunt", "Aerial_Ace", "Roost", "U_turn", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {520}, new string[] {"Level,21"}),


new PokemonData(520, "Tranquill", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Big-pecks", "Super-luck", "Rivalry",
    50f, 120, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.6f, 15f,
    125, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Wild Pigeon", "Many people believe that, deep in the forest whereTranquill live, there is a peaceful place where thereis no war.",
    62, 77, 62, 50, 42, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 15, 18, 23, 27, 32, 36, 41, 45, 50, 54},
    new string[]
    {
         "Gust", "Leer", "Quick Attack", "Growl", "Air Cutter", "Roost", "Detect", "Taunt", "Air Slash", "Razor Wind", "Feather Dance", "Swagger", "Facade", "Tailwind",
    },
    new string[]
    {
         "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Taunt", "Aerial_Ace", "Roost", "U_turn", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {521}, new string[] {"Level,32"}),


new PokemonData(521, "Unfezant", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Big-pecks", "Super-luck", "Rivalry",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 257, 1.2f, 29f,
    220, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Proud", "Males swing their head plumage to threatenopponents. The females’ flying abilities surpassthose of the males.",
    80, 115, 80, 65, 55, 93, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 15, 18, 23, 27, 33, 38, 44, 49, 55, 60},
    new string[]
    {
         "Gust", "Leer", "Quick Attack", "Growl", "Air Cutter", "Roost", "Detect", "Taunt", "Air Slash", "Razor Wind", "Feather Dance", "Swagger", "Facade", "Tailwind",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Facade", "Taunt", "Aerial_Ace", "Roost", "U_turn", "Giga_Impact", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(522, "Blitzle", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Lightning-rod", "Motor-drive", "Sap-sipper",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.8f, 29.8f,
    59, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLACK, 70,
    "Electrified", "When thunderclouds cover the sky, it will appear. It can catch lightning with its mane and storethe electricity.",
    45, 60, 32, 50, 32, 76, 0, Color.clear,
    new int[] { 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43},
    new string[]
    {
         "Quick Attack", "Tail Whip", "Charge", "Shock Wave", "Thunder Wave", "Flame Charge", "Pursuit", "Spark", "Stomp", "Discharge", "Agility", "Wild Charge", "Thrash",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Charge_Beam", "Flame_Charge", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {523}, new string[] {"Level,27"}),


new PokemonData(523, "Zebstrika", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Lightning-rod", "Motor-drive", "Sap-sipper",
    50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.6f, 79.5f,
    174, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLACK, 70,
    "Thunderbolt", "When this ill-tempered Pokémon runs wild, itshoots lightning from its mane in all directions.",
    75, 100, 63, 80, 63, 116, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 15, 18, 22, 25, 31, 36, 42, 47, 53},
    new string[]
    {
         "Tail Whip", "Quick Attack", "Charge", "Ion Deluge", "Thunder Wave", "Flame Charge", "Pursuit", "Spark", "Stomp", "Discharge", "Agility", "Wild Charge", "Thrash",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Overheat", "Giga_Impact", "Charge_Beam", "Flame_Charge", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(524, "Roggenrola", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Sturdy", "Weak-armor", "Sand-force",
    50f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.4f, 18f,
    56, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Mantle", "Its ear is hexagonal in shape. Compressedunderground, its body is as hard as steel.",
    55, 75, 85, 25, 25, 15, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 14, 17, 20, 23, 27, 30, 33, 36, 40},
    new string[]
    {
         "Tackle", "Harden", "Sand Attack", "Headbutt", "Rock Blast", "Mud-Slap", "Iron Defense", "Smack Down", "Rock Slide", "Stealth Rock", "Sandstorm", "Stone Edge", "Explosion",
    },
    new string[]
    {
         "Strength", "Earthquake", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Nature_Power", "Rock_Tomb", "Rock_Polish", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Round", "Bulldoze", "Confide"
    },
    new int[] {525}, new string[] {"Level,25"}),


new PokemonData(525, "Boldore", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Sturdy", "Weak-armor", "Sand-force",
    50f, 120, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.9f, 102f,
    137, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Ore", "Because its energy was too great to be contained,the energy leaked and formed orange crystals.",
    70, 105, 105, 50, 40, 20, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 14, 17, 20, 23, 25, 30, 36, 42, 48},
    new string[]
    {
         "Sand Attack", "Tackle", "Harden", "Headbutt", "Rock Blast", "Mud-Slap", "Iron Defense", "Smack Down", "Power Gem", "Rock Slide", "Stealth Rock", "Sandstorm", "Stone Edge",
    },
    new string[]
    {
         "Strength", "Earthquake", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Nature_Power", "Rock_Tomb", "Rock_Polish", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(526, "Gigalith", PokemonData.Type.ROCK, PokemonData.Type.NONE, "Sturdy", "Sand-stream", "Sand-force",
    50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.7f, 260f,
    232, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Compressed", "The solar rays it absorbs are processed in itsenergy core and fired as a ball of light.",
    85, 135, 130, 60, 80, 25, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 14, 17, 20, 23, 25, 30, 36, 42, 48},
    new string[]
    {
         "Sand Attack", "Tackle", "Harden", "Headbutt", "Rock Blast", "Mud-Slap", "Iron Defense", "Smack Down", "Power Gem", "Rock Slide", "Stealth Rock", "Sandstorm", "Stone Edge",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Nature_Power", "Rock_Tomb", "Rock_Polish", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(527, "Woobat", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Unaware", "Klutz", "Simple",
    50f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.4f, 2.1f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Bat", "Its habitat is dark forests and caves. It emitsultrasonic waves from its nose to learn aboutits surroundings.",
    65, 45, 43, 55, 43, 72, 0, Color.clear,
    new int[] { 1, 4, 8, 12, 15, 19, 21, 25, 29, 29, 32, 36, 41, 47},
    new string[]
    {
         "Confusion", "Odor Sleuth", "Gust", "Assurance", "Heart Stamp", "Imprison", "Air Cutter", "Attract", "Amnesia", "Calm Mind", "Air Slash", "Future Sight", "Psychic", "Endeavor",
    },
    new string[]
    {
         "Fly", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Roost", "Gyro_Ball", "U_turn", "Embargo", "Energy_Ball", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(528, "Swoobat", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Unaware", "Klutz", "Simple",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.9f, 10.5f,
    149, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
    "Courting", "It shakes its tail vigorously when it emits ultrasonicwaves strong enough to reduce concrete to rubble.",
    67, 57, 55, 77, 55, 114, 0, Color.clear,
    new int[] { 1, 1, 1, 15, 19, 21, 25, 29, 36, 41, 47},
    new string[]
    {
         "Gust", "Odor Sleuth", "Assurance", "Heart Stamp", "Imprison", "Air Cutter", "Attract", "Amnesia", "Future Sight", "Psychic", "Endeavor",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Roost", "Gyro_Ball", "U_turn", "Embargo", "Energy_Ball", "Giga_Impact", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(529, "Drilbur", PokemonData.Type.GROUND, PokemonData.Type.NONE, "Sand-rush", "Sand-force", "Mold-breaker",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.3f, 8.5f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Mole", "It makes its way swiftly through the soil by puttingboth claws together and rotating at high speed.",
    60, 85, 40, 30, 45, 68, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 19, 22, 26, 29, 33, 36, 40, 43, 47},
    new string[]
    {
         "Scratch", "Mud Sport", "Rapid Spin", "Mud-Slap", "Fury Swipes", "Metal Claw", "Dig", "Hone Claws", "Slash", "Rock Slide", "Earthquake", "Swords Dance", "Sandstorm", "Drill Run", "Fissure",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Poison_Jab", "X_Scissor", "Shadow_Claw", "Hone_Claws", "Round", "Bulldoze", "Confide"
    },
    new int[] {530}, new string[] {"Level,31"}),


new PokemonData(530, "Excadrill", PokemonData.Type.GROUND, PokemonData.Type.STEEL, "Sand-rush", "Sand-force", "Mold-breaker",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 40.4f,
    178, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Subterrene", "It can help in tunnel construction. Its drill hasevolved into steel strong enough to bore throughiron plates.",
    110, 135, 60, 50, 65, 88, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 12, 19, 22, 26, 29, 31, 36, 42, 55, 62},
    new string[]
    {
         "Scratch", "Mud-Slap", "Rapid Spin", "Mud Sport", "Rototiller", "Fury Swipes", "Dig", "Hone Claws", "Slash", "Rock Slide", "Horn Drill", "Earthquake", "Swords Dance", "Drill Run", "Fissure",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Fling", "Poison_Jab", "X_Scissor", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(531, "Audino", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Healer", "Regenerator", "Klutz",
    50f, 255, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.1f, 31f,
    390, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Hearing", "Using the feelers on its ears, it can tell howsomeone is feeling or when an egg might hatch.",
    103, 60, 86, 60, 86, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 10, 15, 20, 25, 30, 35, 40, 50},
    new string[]
    {
         "Pound", "Growl", "Helping Hand", "Last Resort", "Play Nice", "Refresh", "Double Slap", "Attract", "Secret Power", "Entrainment", "Take Down", "Heal Pulse", "After You", "Double-Edge",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Calm_Mind", "Fling", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Wild_Charge", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(532, "Timburr", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "Sheer-force", "Iron-fist",
    75f, 180, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.6f, 12.5f,
    61, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Muscular", "These Pokémon appear at building sites and helpout with construction. They always carrysquared logs.",
    75, 80, 55, 25, 35, 35, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 12, 16, 20, 24, 28, 31, 34, 37, 40, 43, 46, 49},
    new string[]
    {
         "Pound", "Leer", "Focus Energy", "Bide", "Low Kick", "Rock Throw", "Wake-Up Slap", "Chip Away", "Bulk Up", "Rock Slide", "Dynamic Punch", "Scary Face", "Hammer Arm", "Stone Edge", "Focus Punch", "Superpower",
    },
    new string[]
    {
         "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Stone_Edge", "Grass_Knot", "Smack_Down", "Low_Sweep", "Round", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {533}, new string[] {"Level,25"}),


new PokemonData(533, "Gurdurr", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "Sheer-force", "Iron-fist",
    75f, 90, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.2f, 40f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Muscular", "With strengthened bodies, they skillfully wield steelbeams to take down buildings.",
    85, 105, 85, 40, 50, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 12, 16, 20, 24, 29, 33, 37, 41, 45, 49, 53, 57},
    new string[]
    {
         "Pound", "Leer", "Focus Energy", "Bide", "Low Kick", "Rock Throw", "Wake-Up Slap", "Chip Away", "Bulk Up", "Rock Slide", "Dynamic Punch", "Scary Face", "Hammer Arm", "Stone Edge", "Focus Punch", "Superpower",
    },
    new string[]
    {
         "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Stone_Edge", "Grass_Knot", "Smack_Down", "Low_Sweep", "Round", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(534, "Conkeldurr", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "Sheer-force", "Iron-fist",
    75f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 87f,
    227, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Muscular", "It is thought that Conkeldurr taught humans how tomake concrete more than 2,000 years ago.",
    105, 140, 95, 55, 65, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 12, 16, 20, 24, 29, 33, 37, 41, 45, 49, 53, 57},
    new string[]
    {
         "Pound", "Leer", "Focus Energy", "Bide", "Low Kick", "Rock Throw", "Wake-Up Slap", "Chip Away", "Bulk Up", "Rock Slide", "Dynamic Punch", "Scary Face", "Hammer Arm", "Stone Edge", "Focus Punch", "Superpower",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Smack_Down", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(535, "Tympole", PokemonData.Type.WATER, PokemonData.Type.NONE, "Swift-swim", "Hydration", "Water-absorb",
    50f, 255, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 4.5f,
    59, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Tadpole", "By vibrating its cheeks, it emits sound wavesimperceptible to humans and warns othersof danger.",
    50, 50, 40, 50, 40, 64, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 12, 16, 20, 23, 27, 31, 34, 38, 42, 45},
    new string[]
    {
         "Growl", "Bubble", "Supersonic", "Round", "Bubble Beam", "Mud Shot", "Aqua Ring", "Uproar", "Muddy Water", "Rain Dance", "Flail", "Echoed Voice", "Hydro Pump", "Hyper Voice",
    },
    new string[]
    {
         "Surf", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Sludge_Wave", "Round", "Echoed_Voice", "Scald", "Confide", "Infestation"
    },
    new int[] {536}, new string[] {"Level,25"}),


new PokemonData(536, "Palpitoad", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Swift-swim", "Hydration", "Water-absorb",
    50f, 120, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.8f, 17f,
    134, PokemonData.LevelingRate.MEDIUMSLOW, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Vibration", "When they vibrate the bumps on their heads, theycan make waves in water or earthquake-likevibrations on land.",
    75, 65, 55, 65, 55, 69, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 12, 16, 20, 23, 28, 33, 37, 51},
    new string[]
    {
         "Growl", "Supersonic", "Bubble", "Round", "Bubble Beam", "Mud Shot", "Aqua Ring", "Uproar", "Muddy Water", "Rain Dance", "Flail", "Hyper Voice",
    },
    new string[]
    {
         "Surf", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Sludge_Wave", "Round", "Echoed_Voice", "Scald", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {537}, new string[] {"Level,36"}),


new PokemonData(537, "Seismitoad", PokemonData.Type.WATER, PokemonData.Type.GROUND, "Swift-swim", "Poison-touch", "Water-absorb",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.5f, 62f,
    229, PokemonData.LevelingRate.MEDIUMSLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Vibration", "It increases the power of its punches by vibratingthe bumps on its fists. It can turn a boulder torubble with one punch.",
    105, 95, 75, 85, 75, 74, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 12, 16, 20, 23, 28, 33, 39, 44, 53, 59},
    new string[]
    {
         "Growl", "Supersonic", "Bubble", "Round", "Bubble Beam", "Mud Shot", "Aqua Ring", "Uproar", "Muddy Water", "Rain Dance", "Flail", "Drain Punch", "Hydro Pump", "Hyper Voice",
    },
    new string[]
    {
         "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Brick_Break", "Rock_Tomb", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Venoshock", "Sludge_Wave", "Round", "Echoed_Voice", "Scald", "Bulldoze", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(538, "Throh", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Guts", "Inner-focus", "Mold-breaker",
    100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.3f, 55.5f,
    163, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Judo", "When it tightens its belt, it becomes stronger. WildThroh use vines to weave their own belts.",
    120, 100, 85, 30, 85, 45, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 48, 50},
    new string[]
    {
         "Bind", "Leer", "Bide", "Focus Energy", "Seismic Toss", "Vital Throw", "Revenge", "Storm Throw", "Body Slam", "Bulk Up", "Circle Throw", "Endure", "Wide Guard", "Superpower", "Reversal",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(539, "Sawk", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Sturdy", "Inner-focus", "Mold-breaker",
    100f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.4f, 51f,
    163, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Karate", "Desiring the strongest karate chop, they secludethemselves in mountains and train without sleeping.",
    75, 125, 75, 30, 75, 85, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 48, 50},
    new string[]
    {
         "Leer", "Rock Smash", "Bide", "Focus Energy", "Double Kick", "Low Sweep", "Counter", "Karate Chop", "Brick Break", "Bulk Up", "Retaliate", "Endure", "Quick Guard", "Close Combat", "Reversal",
    },
    new string[]
    {
         "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(540, "Sewaddle", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Swarm", "Chlorophyll", "Overcoat",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 2.5f,
    62, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Sewing", "This Pokémon makes clothes for itself. It chews upleaves and sews them with sticky thread extrudedfrom its mouth.",
    45, 53, 70, 40, 60, 42, 0, Color.clear,
    new int[] { 1, 1, 8, 15, 22, 29, 31, 36, 43},
    new string[]
    {
         "Tackle", "String Shot", "Bug Bite", "Razor Leaf", "Struggle Bug", "Endure", "Sticky Web", "Bug Buzz", "Flail",
    },
    new string[]
    {
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Calm_Mind", "Payback", "Energy_Ball", "Grass_Knot", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {541}, new string[] {"Level,20"}),


new PokemonData(541, "Swadloon", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Leaf-guard", "Chlorophyll", "Overcoat",
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.5f, 7.3f,
    133, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Leaf-Wrapped", "Forests where Swadloon live have superb foliagebecause the nutrients they make from fallen leavesnourish the plant life.",
    55, 63, 90, 50, 80, 42, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 20},
    new string[]
    {
         "Tackle", "Razor Leaf", "String Shot", "Grass Whistle", "Bug Bite", "Protect",
    },
    new string[]
    {
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Calm_Mind", "Payback", "Energy_Ball", "Grass_Knot", "Round", "Struggle_Bug", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(542, "Leavanny", PokemonData.Type.BUG, PokemonData.Type.GRASS, "Swarm", "Chlorophyll", "Overcoat",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.2f, 20.5f,
    225, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Nurturing", "Upon finding a small Pokémon, it weaves clothingfor it from leaves by using the sticky silk secretedfrom its mouth.",
    75, 103, 80, 70, 80, 92, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 22, 29, 32, 34, 36, 39, 46, 50},
    new string[]
    {
         "Tackle", "Razor Leaf", "False Swipe", "Bug Bite", "Struggle Bug", "Slash", "Helping Hand", "Fell Stinger", "Leaf Blade", "X-Scissor", "Swords Dance", "Leaf Storm",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Aerial_Ace", "Calm_Mind", "Payback", "Poison_Jab", "X_Scissor", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Round", "Retaliate", "Struggle_Bug", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(543, "Venipede", PokemonData.Type.BUG, PokemonData.Type.POISON, "Poison-point", "Swarm", "Speed-boost",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.4f, 5.3f,
    52, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Centipede", "It discovers what is going on around it by using thefeelers on its head and tail. It is brutally aggressive.",
    30, 45, 59, 30, 39, 57, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 19, 22, 26, 29, 36, 40, 43},
    new string[]
    {
         "Defense Curl", "Rollout", "Poison Sting", "Screech", "Pursuit", "Protect", "Poison Tail", "Bug Bite", "Venoshock", "Agility", "Toxic", "Rock Climb", "Double-Edge",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Gyro_Ball", "Payback", "Poison_Jab", "Venoshock", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {544}, new string[] {"Level,22"}),


new PokemonData(544, "Whirlipede", PokemonData.Type.BUG, PokemonData.Type.POISON, "Poison-point", "Swarm", "Speed-boost",
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.2f, 58.5f,
    126, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Curlipede", "Protected by a hard shell, it spins its body like awheel and crashes furiously into its enemies.",
    40, 55, 99, 40, 79, 47, 0, Color.clear,
    new int[] { 1, 1, 1, 12, 15, 19, 22, 23, 28, 32, 37, 43, 46, 50},
    new string[]
    {
         "Poison Sting", "Screech", "Rollout", "Pursuit", "Protect", "Poison Tail", "Iron Defense", "Bug Bite", "Venoshock", "Agility", "Steamroller", "Venom Drench", "Rock Climb", "Double-Edge",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Gyro_Ball", "Payback", "Poison_Jab", "Venoshock", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {545}, new string[] {"Level,30"}),


new PokemonData(545, "Scolipede", PokemonData.Type.BUG, PokemonData.Type.POISON, "Poison-point", "Swarm", "Speed-boost",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 2.5f, 200.5f,
    218, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.RED, 70,
    "Megapede", "It clasps its prey with the claws on its neck until itstops moving. Then it finishes it off withdeadly poison.",
    60, 100, 89, 55, 69, 112, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 12, 15, 19, 23, 28, 33, 39, 47, 50, 55},
    new string[]
    {
         "Poison Sting", "Screech", "Rollout", "Megahorn", "Pursuit", "Protect", "Poison Tail", "Bug Bite", "Venoshock", "Agility", "Steamroller", "Venom Drench", "Rock Climb", "Double-Edge",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Gyro_Ball", "Payback", "Poison_Jab", "X_Scissor", "Giga_Impact", "Venoshock", "Round", "Struggle_Bug", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(546, "Cottonee", PokemonData.Type.GRASS, PokemonData.Type.FAIRY, "Prankster", "Infiltrator", "Chlorophyll",
    50f, 190, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.3f, 0.6f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Cotton Puff", "When attacked, it escapes by shooting cotton fromits body. The cotton serves as a decoy to distractthe attacker.",
    40, 27, 60, 37, 50, 66, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 10, 13, 17, 19, 22, 26, 28, 31, 35, 37, 40, 44, 46},
    new string[]
    {
         "Absorb", "Fairy Wind", "Growth", "Leech Seed", "Stun Spore", "Mega Drain", "Cotton Spore", "Razor Leaf", "Poison Powder", "Giga Drain", "Charm", "Helping Hand", "Energy Ball", "Cotton Guard", "Sunny Day", "Endeavor", "Solar Beam",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Taunt", "Energy_Ball", "Grass_Knot", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(547, "Whimsicott", PokemonData.Type.GRASS, PokemonData.Type.FAIRY, "Prankster", "Infiltrator", "Chlorophyll",
    50f, 75, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.7f, 6.6f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
    "Windveiled", "They appear along with whirlwinds. They pullpranks, such as moving furniture and leaving ballsof cotton in homes.",
    60, 67, 85, 77, 75, 116, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 28, 46, 50},
    new string[]
    {
         "Mega Drain", "Leech Seed", "Growth", "Cotton Spore", "Gust", "Tailwind", "Hurricane", "Moonblast",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Facade", "Nature_Power", "Taunt", "U_turn", "Fling", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(548, "Petilil", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Own-tempo", "Leaf-guard",
    0f, 190, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.5f, 6.6f,
    56, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Bulb", "The leaves on its head are very bitter. Eating oneof these leaves is known to refresh a tired body.",
    45, 35, 50, 70, 50, 30, 0, Color.clear,
    new int[] { 1, 4, 8, 10, 13, 17, 19, 22, 26, 28, 31, 35, 37, 40, 44, 46},
    new string[]
    {
         "Absorb", "Growth", "Leech Seed", "Sleep Powder", "Mega Drain", "Synthesis", "Magical Leaf", "Stun Spore", "Giga Drain", "Aromatherapy", "Helping Hand", "Energy Ball", "Entrainment", "Sunny Day", "After You", "Leaf Storm",
    },
    new string[]
    {
         "Cut", "Solar_Beam", "Toxic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(549, "Lilligant", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Chlorophyll", "Own-tempo", "Leaf-guard",
    0f, 75, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1.1f, 16.3f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Flowering", "The fragrance of the garland on its head has arelaxing effect. It withers if a Trainer does not takegood care of it.",
    70, 60, 75, 110, 75, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 28, 46, 50},
    new string[]
    {
         "Mega Drain", "Leech Seed", "Growth", "Synthesis", "Teeter Dance", "Quiver Dance", "Petal Dance", "Petal Blizzard",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(550, "Basculin-red-striped", PokemonData.Type.WATER, PokemonData.Type.NONE, "Reckless", "Adaptability", "Mold-breaker",
    50f, 25, PokemonData.EggGroup.WATER2, PokemonData.EggGroup.WATER2, 0, 1f, 18f,
    161, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GREEN, 70,
    "Hostile", "Red- and blue-striped Basculin are very violent andalways fighting. They are also remarkably tasty.",
    70, 92, 65, 80, 55, 98, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 4, 7, 10, 13, 16, 20, 24, 28, 32, 50},
    new string[]
    {
         "Tackle", "Thrash", "Tail Whip", "Water Gun", "Flail", "Uproar", "Headbutt", "Bite", "Aqua Jet", "Chip Away", "Take Down", "Crunch", "Aqua Tail", "Soak", "Final Gambit",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Taunt", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(551, "Sandile", PokemonData.Type.GROUND, PokemonData.Type.DARK, "Intimidate", "Moxie", "Anger-point",
    50f, 180, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 15.2f,
    58, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Desert Croc", "It moves along below the sand’s surface, exceptfor its nose and eyes. A dark membrane shields itseyes from the sun.",
    50, 72, 35, 35, 35, 65, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46},
    new string[]
    {
         "Leer", "Rage", "Bite", "Sand Attack", "Torment", "Sand Tomb", "Assurance", "Mud-Slap", "Embargo", "Swagger", "Crunch", "Dig", "Scary Face", "Foul Play", "Sandstorm", "Earthquake", "Thrash",
    },
    new string[]
    {
         "Cut", "Roar", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Torment", "Facade", "Taunt", "Rock_Tomb", "Payback", "Embargo", "Dark_Pulse", "Stone_Edge", "Hone_Claws", "Round", "Incinerate", "Retaliate", "Bulldoze", "Snarl", "Confide"
    },
    new int[] {552}, new string[] {"Level,29"}),


new PokemonData(552, "Krokorok", PokemonData.Type.GROUND, PokemonData.Type.DARK, "Intimidate", "Moxie", "Anger-point",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 33.4f,
    123, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Desert Croc", "They live in groups of a few individuals. Protectivemembranes shield their eyes from sandstorms.",
    60, 82, 45, 45, 45, 74, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 13, 16, 19, 22, 25, 28, 32, 36, 40, 44},
    new string[]
    {
         "Sand Attack", "Leer", "Bite", "Rage", "Torment", "Sand Tomb", "Assurance", "Mud-Slap", "Embargo", "Swagger", "Crunch", "Dig", "Scary Face", "Foul Play", "Sandstorm",
    },
    new string[]
    {
         "Cut", "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Payback", "Embargo", "Fling", "Dark_Pulse", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Bulldoze", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {553}, new string[] {"Level,40"}),


new PokemonData(553, "Krookodile", PokemonData.Type.GROUND, PokemonData.Type.DARK, "Intimidate", "Moxie", "Anger-point",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.5f, 96.3f,
    234, PokemonData.LevelingRate.MEDIUMSLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Intimidation", "Very violent Pokémon, they try to clamp down onanything that moves in front of their eyes.",
    95, 117, 80, 65, 70, 92, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 13, 16, 19, 22, 25, 28, 32, 36, 42},
    new string[]
    {
         "Sand Attack", "Bite", "Rage", "Outrage", "Torment", "Sand Tomb", "Assurance", "Mud-Slap", "Embargo", "Swagger", "Crunch", "Dig", "Scary Face", "Foul Play",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Payback", "Embargo", "Fling", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Smack_Down", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Bulldoze", "Dragon_Tail", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(554, "Darumaka", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Hustle", null, "Inner-focus",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 37.5f,
    63, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Zen Charm", "Darumaka’s droppings are hot, so people used toput them in their clothes to keep themselves warm.",
    70, 90, 45, 15, 45, 50, 0, Color.clear,
    new int[] { 1, 3, 6, 9, 11, 14, 17, 19, 22, 25, 27, 30, 33, 35, 39, 42},
    new string[]
    {
         "Tackle", "Rollout", "Incinerate", "Rage", "Fire Fang", "Headbutt", "Uproar", "Facade", "Fire Punch", "Work Up", "Thrash", "Belly Drum", "Flare Blitz", "Taunt", "Superpower", "Overheat",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Gyro_Ball", "U_turn", "Fling", "Grass_Knot", "Flame_Charge", "Round", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {555}, new string[] {"Level,35"}),


new PokemonData(555, "Darmanitan-standard", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Sheer-force", null, "Zen-mode",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.3f, 92.9f,
    168, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Blazing", "When one is injured in a fierce battle, it hardensinto a stone-like form. Then it meditates andsharpens its mind.",
    105, 140, 55, 30, 55, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 11, 14, 19, 22, 27, 33, 35, 39, 47, 54},
    new string[]
    {
         "Tackle", "Rage", "Rollout", "Incinerate", "Fire Fang", "Headbutt", "Facade", "Fire Punch", "Thrash", "Flare Blitz", "Hammer Arm", "Taunt", "Superpower", "Overheat",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Torment", "Will_O_Wisp", "Facade", "Taunt", "Brick_Break", "Overheat", "Rock_Tomb", "Bulk_Up", "Gyro_Ball", "U_turn", "Payback", "Fling", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Smack_Down", "Flame_Charge", "Round", "Incinerate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(556, "Maractus", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Water-absorb", "Chlorophyll", "Storm-drain",
    50f, 255, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1f, 28f,
    161, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Cactus", "It uses an up-tempo song and dance to drive awaythe bird Pokémon that prey on its flower seeds.",
    75, 86, 67, 106, 67, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 3, 6, 10, 13, 15, 18, 22, 26, 29, 33, 38, 42, 45, 48, 50, 55},
    new string[]
    {
         "Peck", "Absorb", "After You", "Sweet Scent", "Growth", "Pin Missile", "Mega Drain", "Synthesis", "Cotton Spore", "Needle Arm", "Giga Drain", "Acupressure", "Ingrain", "Petal Dance", "Sucker Punch", "Sunny Day", "Petal Blizzard", "Solar Beam", "Cotton Guard",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Facade", "Nature_Power", "Aerial_Ace", "Poison_Jab", "Energy_Ball", "Grass_Knot", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(557, "Dwebble", PokemonData.Type.BUG, PokemonData.Type.ROCK, "Sturdy", "Shell-armor", "Weak-armor",
    50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 14.5f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Rock Inn", "It makes a hole in a suitable rock. If that rockbreaks, the Pokémon remains agitated until itlocates a replacement.",
    50, 65, 85, 35, 35, 55, 0, Color.clear,
    new int[] { 1, 5, 7, 11, 13, 17, 19, 23, 24, 29, 31, 35, 37, 41, 43},
    new string[]
    {
         "Fury Cutter", "Rock Blast", "Withdraw", "Sand Attack", "Feint Attack", "Smack Down", "Rock Polish", "Bug Bite", "Stealth Rock", "Rock Slide", "Slash", "X-Scissor", "Shell Smash", "Flail", "Rock Wrecker",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Nature_Power", "Rock_Tomb", "Aerial_Ace", "Rock_Polish", "Poison_Jab", "X_Scissor", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {558}, new string[] {"Level,34"}),


new PokemonData(558, "Crustle", PokemonData.Type.BUG, PokemonData.Type.ROCK, "Sturdy", "Shell-armor", "Weak-armor",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.4f, 200f,
    170, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Stone Home", "It possesses legs of enormous strength, enabling itto carry heavy slabs for many days, even whencrossing arid land.",
    70, 105, 125, 65, 75, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 13, 17, 23, 24, 29, 31, 38, 50, 55},
    new string[]
    {
         "Sand Attack", "Rock Blast", "Shell Smash", "Withdraw", "Feint Attack", "Smack Down", "Bug Bite", "Stealth Rock", "Rock Slide", "Slash", "X-Scissor", "Flail", "Rock Wrecker",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Nature_Power", "Rock_Tomb", "Aerial_Ace", "Rock_Polish", "Poison_Jab", "X_Scissor", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Struggle_Bug", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(559, "Scraggy", PokemonData.Type.DARK, PokemonData.Type.FIGHTING, "Shed-skin", "Moxie", "Intimidate",
    50f, 180, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 11.8f,
    70, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
    "Shedding", "Its skin has a rubbery elasticity, so it can reducedamage by defensively pulling its skin up toits neck.",
    50, 75, 70, 35, 70, 48, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 12, 16, 20, 23, 27, 31, 34, 38, 42, 45, 48, 50},
    new string[]
    {
         "Leer", "Low Kick", "Sand Attack", "Feint Attack", "Headbutt", "Swagger", "Brick Break", "Payback", "Chip Away", "High Jump Kick", "Scary Face", "Crunch", "Facade", "Rock Climb", "Focus Punch", "Head Smash",
    },
    new string[]
    {
         "Roar", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Dragon_Claw", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Dark_Pulse", "Focus_Blast", "Stone_Edge", "Grass_Knot", "Smack_Down", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Dragon_Tail", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {560}, new string[] {"Level,39"}),


new PokemonData(560, "Scrafty", PokemonData.Type.DARK, PokemonData.Type.FIGHTING, "Shed-skin", "Moxie", "Intimidate",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.1f, 30f,
    171, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.RED, 70,
    "Hoodlum", "It pulls up its shed skin to protect itself whileit kicks. The bigger the crest, the more respectedit is.",
    65, 90, 115, 45, 115, 58, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 20, 23, 27, 31, 34, 38, 45, 51, 58, 65},
    new string[]
    {
         "Sand Attack", "Leer", "Low Kick", "Feint Attack", "Brick Break", "Payback", "Chip Away", "High Jump Kick", "Scary Face", "Crunch", "Facade", "Rock Climb", "Focus Punch", "Head Smash",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Dragon_Claw", "Bulk_Up", "Payback", "Fling", "Poison_Jab", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Smack_Down", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Dragon_Tail", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(561, "Sigilyph", PokemonData.Type.PSYCHIC, PokemonData.Type.FLYING, "Wonder-skin", "Magic-guard", "Tinted-lens",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.4f, 14f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Avianoid", "The guardians of an ancient city, they use theirpsychic power to attack enemies that invadetheir territory.",
    72, 58, 80, 103, 80, 97, 0, Color.clear,
    new int[] { 1, 1, 4, 8, 11, 14, 18, 21, 24, 28, 31, 34, 38, 41, 44, 48, 50},
    new string[]
    {
         "Gust", "Miracle Eye", "Hypnosis", "Psywave", "Tailwind", "Whirlwind", "Psybeam", "Air Cutter", "Light Screen", "Reflect", "Synchronoise", "Mirror Move", "Gravity", "Air Slash", "Psychic", "Cosmic Power", "Sky Attack",
    },
    new string[]
    {
         "Fly", "Ice_Beam", "Hyper_Beam", "Solar_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Facade", "Aerial_Ace", "Calm_Mind", "Roost", "Dark_Pulse", "Energy_Ball", "Flash_Cannon", "Trick_Room", "Charge_Beam", "Psyshock", "Smack_Down", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(562, "Yamask", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Mummy", null, null,
    50f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.5f, 1.5f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Spirit", "These Pokémon arose from the spirits of peopleinterred in graves. Each retains memories of itsformer life.",
    38, 30, 85, 55, 65, 30, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 33, 37, 41, 45, 49},
    new string[]
    {
         "Protect", "Astonish", "Disable", "Haze", "Night Shade", "Hex", "Will-O-Wisp", "Ominous Wind", "Curse", "Guard Split", "Power Split", "Shadow Ball", "Grudge", "Mean Look", "Destiny Bond",
    },
    new string[]
    {
         "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Calm_Mind", "Payback", "Embargo", "Dark_Pulse", "Energy_Ball", "Trick_Room", "Round", "Confide", "Infestation"
    },
    new int[] {563}, new string[] {"Level,34"}),


new PokemonData(563, "Cofagrigus", PokemonData.Type.GHOST, PokemonData.Type.NONE, "Mummy", null, null,
    50f, 90, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.7f, 76.5f,
    169, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Coffin", "It has been said that they swallow those who gettoo close and turn them into mummies. They like toeat gold nuggets.",
    58, 50, 145, 95, 105, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 17, 21, 25, 33, 33, 34, 39, 45, 51, 57},
    new string[]
    {
         "Disable", "Haze", "Protect", "Astonish", "Hex", "Will-O-Wisp", "Ominous Wind", "Guard Split", "Power Split", "Scary Face", "Shadow Ball", "Grudge", "Mean Look", "Destiny Bond",
    },
    new string[]
    {
         "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Calm_Mind", "Payback", "Embargo", "Dark_Pulse", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Round", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(564, "Tirtouga", PokemonData.Type.WATER, PokemonData.Type.ROCK, "Solid-rock", "Sturdy", "Swift-swim",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.7f, 16.5f,
    71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Prototurtle", "About 100 million years ago, these Pokémon swamin oceans. It is thought they also went on land toattack prey.",
    54, 78, 103, 53, 45, 22, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 8, 11, 15, 18, 21, 25, 28, 31, 35, 38, 41, 45, 48, 50},
    new string[]
    {
         "Water Gun", "Withdraw", "Bide", "Rollout", "Bite", "Protect", "Aqua Jet", "Ancient Power", "Crunch", "Wide Guard", "Brine", "Smack Down", "Curse", "Shell Smash", "Aqua Tail", "Rock Slide", "Rain Dance", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Rock_Tomb", "Rock_Polish", "Stone_Edge", "Smack_Down", "Round", "Scald", "Bulldoze", "Confide"
    },
    new int[] {565}, new string[] {"Level,37"}),


new PokemonData(565, "Carracosta", PokemonData.Type.WATER, PokemonData.Type.ROCK, "Solid-rock", "Sturdy", "Swift-swim",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 81f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Prototurtle", "They can live both in the ocean and on land. A slapfrom one of them is enough to open a hole in thebottom of a tanker.",
    74, 108, 133, 83, 65, 32, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 8, 11, 15, 18, 21, 25, 28, 31, 35, 40, 45, 51, 61},
    new string[]
    {
         "Water Gun", "Withdraw", "Bide", "Rollout", "Bite", "Protect", "Aqua Jet", "Ancient Power", "Crunch", "Wide Guard", "Brine", "Smack Down", "Curse", "Shell Smash", "Aqua Tail", "Rock Slide", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Rock_Tomb", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Smack_Down", "Round", "Scald", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(566, "Archen", PokemonData.Type.ROCK, PokemonData.Type.FLYING, "Defeatist", null, null,
    87.5f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.5f, 9.5f,
    71, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "First Bird", "Revived from a fossil, this Pokémon is thought tobe the ancestor of all bird Pokémon.",
    55, 112, 45, 74, 45, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 8, 11, 15, 18, 21, 25, 28, 31, 35, 38, 41, 45, 48, 50},
    new string[]
    {
         "Wing Attack", "Leer", "Quick Attack", "Rock Throw", "Double Team", "Scary Face", "Pluck", "Ancient Power", "Agility", "Quick Guard", "Acrobatics", "Dragon Breath", "Crunch", "Endeavor", "U-turn", "Rock Slide", "Dragon Claw", "Thrash",
    },
    new string[]
    {
         "Cut", "Roar", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Roost", "U_turn", "Rock_Polish", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Acrobatics", "Bulldoze", "Confide"
    },
    new int[] {567}, new string[] {"Level,37"}),


new PokemonData(567, "Archeops", PokemonData.Type.ROCK, PokemonData.Type.FLYING, "Defeatist", null, null,
    87.5f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.4f, 32f,
    177, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "First Bird", "They are intelligent and will cooperate to catchprey. From the ground, they use a running start totake flight.",
    75, 140, 65, 112, 65, 110, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 8, 11, 15, 18, 25, 28, 31, 35, 40, 45, 51, 56, 61},
    new string[]
    {
         "Wing Attack", "Leer", "Rock Throw", "Quick Attack", "Double Team", "Scary Face", "Pluck", "Ancient Power", "Quick Guard", "Acrobatics", "Dragon Breath", "Crunch", "Endeavor", "U-turn", "Rock Slide", "Dragon Claw", "Thrash",
    },
    new string[]
    {
         "Cut", "Fly", "Roar", "Hyper_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Roost", "U_turn", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Smack_Down", "Round", "Acrobatics", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(568, "Trubbish", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Sticky-hold", "Aftermath",
    50f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.6f, 31f,
    66, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GREEN, 70,
    "Trash Bag", "The combination of garbage bags and industrialwaste caused the chemical reaction that createdthis Pokémon.",
    50, 50, 62, 40, 62, 65, 0, Color.clear,
    new int[] { 1, 1, 3, 7, 12, 14, 18, 23, 23, 25, 29, 34, 36, 40, 42, 45, 47},
    new string[]
    {
         "Pound", "Poison Gas", "Recycle", "Toxic Spikes", "Acid Spray", "Double Slap", "Sludge", "Stockpile", "Swallow", "Take Down", "Sludge Bomb", "Clear Smog", "Toxic", "Amnesia", "Belch", "Gunk Shot", "Explosion",
    },
    new string[]
    {
         "Toxic", "Double_Team", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Payback", "Dark_Pulse", "Venoshock", "Sludge_Wave", "Round", "Confide", "Infestation"
    },
    new int[] {569}, new string[] {"Level,36"}),


new PokemonData(569, "Garbodor", PokemonData.Type.POISON, PokemonData.Type.NONE, "Stench", "Weak-armor", "Aftermath",
    50f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.9f, 107.3f,
    166, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Trash Heap", "It clenches opponents with its left arm and finishesthem off with foul-smelling poison gas belched fromits mouth.",
    80, 95, 82, 60, 82, 75, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 12, 14, 18, 23, 23, 25, 29, 34, 39, 46, 49, 54, 59},
    new string[]
    {
         "Pound", "Poison Gas", "Recycle", "Toxic Spikes", "Acid Spray", "Double Slap", "Sludge", "Stockpile", "Swallow", "Body Slam", "Sludge Bomb", "Clear Smog", "Toxic", "Amnesia", "Belch", "Gunk Shot", "Explosion",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Explosion", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Payback", "Fling", "Rock_Polish", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Venoshock", "Smack_Down", "Sludge_Wave", "Round", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(570, "Zorua", PokemonData.Type.DARK, PokemonData.Type.NONE, "Illusion", null, null,
    87.5f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 12.5f,
    66, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Tricky Fox", "It changes so it looks just like its foe, tricks it, andthen uses that opportunity to flee.",
    40, 65, 40, 80, 40, 65, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57},
    new string[]
    {
         "Scratch", "Leer", "Pursuit", "Fake Tears", "Fury Swipes", "Feint Attack", "Scary Face", "Taunt", "Foul Play", "Torment", "Agility", "Embargo", "Punishment", "Nasty Plot", "Imprison", "Night Daze",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "U_turn", "Payback", "Embargo", "Fling", "Dark_Pulse", "Grass_Knot", "Hone_Claws", "Round", "Incinerate", "Retaliate", "Snarl", "Confide"
    },
    new int[] {571}, new string[] {"Level,30"}),


new PokemonData(571, "Zoroark", PokemonData.Type.DARK, PokemonData.Type.NONE, "Illusion", null, null,
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.6f, 81.1f,
    179, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Illusion Fox", "Each has the ability to fool a large group of peoplesimultaneously. They protect their lair withillusory scenery.",
    60, 105, 60, 120, 60, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 13, 17, 21, 25, 30, 39, 44, 49, 54},
    new string[]
    {
         "Scratch", "Leer", "Pursuit", "Imprison", "Hone Claws", "Night Daze", "Fury Swipes", "Feint Attack", "Scary Face", "Taunt", "Night Slash", "Agility", "Embargo", "Punishment", "Nasty Plot",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "U_turn", "Payback", "Embargo", "Fling", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Incinerate", "Retaliate", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(572, "Minccino", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Cute-charm", "Technician", "Skill-link",
    25f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 5.8f,
    60, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GRAY, 70,
    "Chinchilla", "Minccino greet each other by grooming one anotherthoroughly with their tails.",
    55, 50, 40, 40, 40, 75, 0, Color.clear,
    new int[] { 1, 3, 7, 9, 13, 15, 19, 21, 25, 27, 31, 33, 37, 39, 43, 45, 49},
    new string[]
    {
         "Pound", "Baby-Doll Eyes", "Helping Hand", "Tickle", "Double Slap", "Encore", "Swift", "Sing", "Tail Slap", "Charm", "Wake-Up Slap", "Echoed Voice", "Slam", "Captivate", "Hyper Voice", "Last Resort", "After You",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Calm_Mind", "U_turn", "Fling", "Grass_Knot", "Round", "Echoed_Voice", "Retaliate", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(573, "Cinccino", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Cute-charm", "Technician", "Skill-link",
    25f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 7.5f,
    165, PokemonData.LevelingRate.FAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.GRAY, 70,
    "Scarf", "Their white fur feels amazing to touch. Their furrepels dust and prevents static electricity frombuilding up.",
    75, 95, 60, 65, 60, 115, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1},
    new string[]
    {
         "Sing", "Helping Hand", "Tickle", "Bullet Seed", "Rock Blast", "Tail Slap",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Calm_Mind", "U_turn", "Fling", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Round", "Echoed_Voice", "Retaliate", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(574, "Gothita", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Frisk", "Competitive", "Shadow-tag",
    25f, 200, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.4f, 5.8f,
    58, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Fixation", "Their ribbonlike feelers increase their psychicpower. They are always staring at something.",
    45, 30, 50, 55, 65, 45, 0, Color.clear,
    new int[] { 1, 3, 7, 8, 10, 14, 16, 19, 24, 25, 28, 31, 33, 37, 40, 46, 48},
    new string[]
    {
         "Pound", "Confusion", "Tickle", "Play Nice", "Fake Tears", "Double Slap", "Psybeam", "Embargo", "Feint Attack", "Psyshock", "Flatter", "Future Sight", "Heal Block", "Psychic", "Telekinesis", "Charm", "Magic Room",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Rock_Tomb", "Calm_Mind", "Payback", "Embargo", "Fling", "Energy_Ball", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide"
    },
    new int[] {575}, new string[] {"Level,32"}),


new PokemonData(575, "Gothorita", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Frisk", "Competitive", "Shadow-tag",
    25f, 100, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.7f, 18f,
    137, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Manipulate", "Starlight is the source of their power. At night,they mark star positions by using psychic powerto float stones.",
    60, 45, 70, 75, 85, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 14, 16, 24, 25, 28, 31, 34, 43, 50, 53},
    new string[]
    {
         "Pound", "Confusion", "Tickle", "Play Nice", "Fake Tears", "Double Slap", "Psybeam", "Feint Attack", "Psyshock", "Flatter", "Future Sight", "Heal Block", "Telekinesis", "Charm", "Magic Room",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Rock_Tomb", "Calm_Mind", "Payback", "Embargo", "Fling", "Energy_Ball", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Confide"
    },
    new int[] {576}, new string[] {"Level,41"}),


new PokemonData(576, "Gothitelle", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Frisk", "Competitive", "Shadow-tag",
    25f, 50, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.5f, 44f,
    221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Astral Body", "Starry skies thousands of light-years away arevisible in the space distorted by their intensepsychic power.",
    70, 55, 95, 95, 110, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 14, 16, 24, 25, 28, 31, 34, 45, 54, 59},
    new string[]
    {
         "Pound", "Confusion", "Tickle", "Play Nice", "Fake Tears", "Double Slap", "Psybeam", "Feint Attack", "Psyshock", "Flatter", "Future Sight", "Heal Block", "Telekinesis", "Charm", "Magic Room",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Calm_Mind", "Payback", "Embargo", "Fling", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Low_Sweep", "Round", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(577, "Solosis", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Overcoat", "Magic-guard", "Regenerator",
    50f, 200, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.3f, 1f,
    58, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Cell", "Because their bodies are enveloped in a specialliquid, they are fine in any environment, no matterhow severe.",
    45, 30, 40, 105, 50, 20, 0, Color.clear,
    new int[] { 1, 3, 7, 10, 14, 16, 19, 24, 25, 28, 31, 33, 37, 40, 46, 48},
    new string[]
    {
         "Psywave", "Reflect", "Rollout", "Snatch", "Hidden Power", "Light Screen", "Charm", "Recover", "Psyshock", "Endeavor", "Future Sight", "Pain Split", "Psychic", "Skill Swap", "Heal Block", "Wonder Room",
    },
    new string[]
    {
         "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Embargo", "Energy_Ball", "Flash_Cannon", "Trick_Room", "Psyshock", "Round", "Confide", "Infestation"
    },
    new int[] {578}, new string[] {"Level,32"}),


new PokemonData(578, "Duosion", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Overcoat", "Magic-guard", "Regenerator",
    50f, 100, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 8f,
    130, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Mitosis", "Since they have two divided brains, at times theysuddenly try to take two different actions at once.",
    65, 40, 50, 125, 60, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 14, 16, 19, 24, 25, 28, 31, 39, 43, 53},
    new string[]
    {
         "Reflect", "Rollout", "Snatch", "Hidden Power", "Light Screen", "Charm", "Recover", "Psyshock", "Endeavor", "Future Sight", "Psychic", "Skill Swap", "Wonder Room",
    },
    new string[]
    {
         "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Embargo", "Energy_Ball", "Flash_Cannon", "Trick_Room", "Psyshock", "Round", "Confide", "Infestation"
    },
    new int[] {579}, new string[] {"Level,41"}),


new PokemonData(579, "Reuniclus", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Overcoat", "Magic-guard", "Regenerator",
    50f, 50, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1f, 20.1f,
    221, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Multiplying", "They use psychic power to control their arms,which are made of a special liquid. They can crushboulders psychically.",
    110, 65, 75, 125, 85, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 14, 16, 19, 24, 25, 28, 31, 39, 45, 59},
    new string[]
    {
         "Reflect", "Psywave", "Rollout", "Snatch", "Hidden Power", "Light Screen", "Charm", "Recover", "Psyshock", "Endeavor", "Future Sight", "Psychic", "Skill Swap", "Wonder Room",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Embargo", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Flash_Cannon", "Trick_Room", "Grass_Knot", "Psyshock", "Round", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(580, "Ducklett", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Keen-eye", "Big-pecks", "Hydration",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 5.5f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Water Bird", "When attacked, it uses its feathers to splash water,escaping under cover of the spray.",
    62, 44, 50, 44, 50, 55, 0, Color.clear,
    new int[] { 1, 3, 6, 9, 13, 15, 19, 21, 24, 27, 30, 34, 37, 41, 46},
    new string[]
    {
         "Water Gun", "Water Sport", "Defog", "Wing Attack", "Water Pulse", "Aerial Ace", "Bubble Beam", "Feather Dance", "Aqua Ring", "Air Slash", "Roost", "Rain Dance", "Tailwind", "Brave Bird", "Hurricane",
    },
    new string[]
    {
         "Fly", "Surf", "Ice_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Aerial_Ace", "Roost", "Round", "Scald", "Confide"
    },
    new int[] {581}, new string[] {"Level,35"}),


new PokemonData(581, "Swanna", PokemonData.Type.WATER, PokemonData.Type.FLYING, "Keen-eye", "Big-pecks", "Hydration",
    50f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.3f, 24.2f,
    166, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.WHITE, 70,
    "White Bird", "Despite their elegant appearance, they can flaptheir wings strongly and fly for thousands of miles.",
    75, 87, 63, 87, 63, 98, 0, Color.clear,
    new int[] { 1, 1, 1, 15, 19, 21, 24, 27, 30, 34, 40, 47},
    new string[]
    {
         "Wing Attack", "Water Sport", "Defog", "Aerial Ace", "Bubble Beam", "Feather Dance", "Aqua Ring", "Air Slash", "Roost", "Rain Dance", "Tailwind", "Brave Bird",
    },
    new string[]
    {
         "Fly", "Surf", "Ice_Beam", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Aerial_Ace", "Roost", "Giga_Impact", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(582, "Vanillite", PokemonData.Type.ICE, PokemonData.Type.NONE, "Ice-body", "Snow-cloak", "Weak-armor",
    50f, 255, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.4f, 5.7f,
    61, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Fresh Snow", "The temperature of their breath is -58 degreesFahrenheit. They create snow crystals and makesnow fall in the areas around them.",
    36, 50, 50, 65, 60, 44, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 26, 31, 35, 40, 44, 49, 53},
    new string[]
    {
         "Icicle Spear", "Harden", "Astonish", "Uproar", "Icy Wind", "Mist", "Avalanche", "Taunt", "Mirror Shot", "Acid Armor", "Ice Beam", "Hail", "Mirror Coat", "Blizzard", "Sheer Cold",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Light_Screen", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Taunt", "Flash_Cannon", "Round", "Frost_Breath", "Confide"
    },
    new int[] {583}, new string[] {"Level,35"}),


new PokemonData(583, "Vanillish", PokemonData.Type.ICE, PokemonData.Type.NONE, "Ice-body", "Snow-cloak", "Weak-armor",
    50f, 120, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.1f, 41f,
    138, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Icy Snow", "They cool down the surrounding air and create iceparticles, which they use to freeze their foes.",
    51, 65, 65, 80, 75, 59, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 13, 16, 19, 22, 26, 36, 47, 53},
    new string[]
    {
         "Harden", "Uproar", "Astonish", "Icicle Spear", "Icy Wind", "Mist", "Avalanche", "Taunt", "Mirror Shot", "Ice Beam", "Mirror Coat", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Toxic", "Double_Team", "Light_Screen", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Taunt", "Flash_Cannon", "Round", "Frost_Breath", "Confide"
    },
    new int[] {584}, new string[] {"Level,47"}),


new PokemonData(584, "Vanilluxe", PokemonData.Type.ICE, PokemonData.Type.NONE, "Ice-body", "Snow-warning", "Weak-armor",
    50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.3f, 57.5f,
    241, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Snowstorm", "If both heads get angry simultaneously, thisPokémon expels a blizzard, burying everythingin snow.",
    71, 95, 85, 110, 95, 79, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 13, 16, 19, 22, 26, 36, 50, 59},
    new string[]
    {
         "Harden", "Uproar", "Astonish", "Sheer Cold", "Freeze-Dry", "Icy Wind", "Mist", "Avalanche", "Taunt", "Mirror Shot", "Ice Beam", "Mirror Coat", "Blizzard",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Double_Team", "Light_Screen", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Taunt", "Giga_Impact", "Flash_Cannon", "Round", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(585, "Deerling", PokemonData.Type.NORMAL, PokemonData.Type.GRASS, "Chlorophyll", "Sap-sipper", "Serene-grace",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 19.5f,
    67, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PINK, 70,
    "Season", "Their coloring changes according to the seasonsand can be slightly affected by the temperature andhumidity as well.",
    60, 60, 50, 40, 50, 75, 0, Color.clear,
    new int[] { 1, 1, 4, 7, 10, 13, 16, 20, 24, 28, 32, 36, 41, 46, 51},
    new string[]
    {
         "Tackle", "Camouflage", "Growl", "Sand Attack", "Double Kick", "Leech Seed", "Feint Attack", "Take Down", "Jump Kick", "Aromatherapy", "Energy Ball", "Charm", "Nature Power", "Double-Edge", "Solar Beam",
    },
    new string[]
    {
         "Solar_Beam", "Thunder_Wave", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Facade", "Nature_Power", "Energy_Ball", "Grass_Knot", "Round", "Echoed_Voice", "Retaliate", "Wild_Charge", "Confide"
    },
    new int[] {586}, new string[] {"Level,34"}),


new PokemonData(586, "Sawsbuck", PokemonData.Type.NORMAL, PokemonData.Type.GRASS, "Chlorophyll", "Sap-sipper", "Serene-grace",
    50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.9f, 92.5f,
    166, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Season", "They migrate according to the seasons. People cantell the season by looking at Sawsbuck’s horns.",
    80, 100, 70, 60, 70, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 16, 20, 24, 28, 32, 36, 37, 44, 52, 60},
    new string[]
    {
         "Sand Attack", "Growl", "Megahorn", "Camouflage", "Double Kick", "Feint Attack", "Take Down", "Jump Kick", "Aromatherapy", "Energy Ball", "Charm", "Horn Leech", "Nature Power", "Double-Edge", "Solar Beam",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Solar_Beam", "Thunder_Wave", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Nature_Power", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Echoed_Voice", "Retaliate", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(587, "Emolga", PokemonData.Type.ELECTRIC, PokemonData.Type.FLYING, "Static", null, "Motor-drive",
    50f, 200, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 5f,
    150, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.WHITE, 70,
    "Sky Squirrel", "They live on treetops and glide using the inside ofa cape-like membrane while discharging electricity.",
    55, 75, 60, 75, 60, 103, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 15, 16, 19, 22, 26, 30, 34, 38, 42, 46, 50},
    new string[]
    {
         "Thunder Shock", "Quick Attack", "Tail Whip", "Charge", "Spark", "Nuzzle", "Pursuit", "Double Team", "Shock Wave", "Electro Ball", "Acrobatics", "Light Screen", "Encore", "Volt Switch", "Agility", "Discharge",
    },
    new string[]
    {
         "Cut", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Taunt", "Aerial_Ace", "Roost", "U_turn", "Fling", "Charge_Beam", "Round", "Acrobatics", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(588, "Karrablast", PokemonData.Type.BUG, PokemonData.Type.NONE, "Swarm", "Shed-skin", "No-guard",
    50f, 200, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.5f, 5.9f,
    63, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Clamping", "These mysterious Pokémon evolve when theyreceive electrical stimulation while they are in thesame place as Shelmet.",
    50, 75, 45, 40, 45, 60, 0, Color.clear,
    new int[] { 1, 4, 8, 13, 16, 20, 25, 28, 32, 37, 40, 44, 49, 52, 56},
    new string[]
    {
         "Peck", "Leer", "Endure", "Fury Cutter", "Fury Attack", "Headbutt", "False Swipe", "Bug Buzz", "Slash", "Take Down", "Scary Face", "X-Scissor", "Flail", "Swords Dance", "Double-Edge",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Aerial_Ace", "Poison_Jab", "X_Scissor", "Energy_Ball", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(589, "Escavalier", PokemonData.Type.BUG, PokemonData.Type.STEEL, "Swarm", "Shell-armor", "Overcoat",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1f, 33f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Cavalry", "Wearing the shell covering they stole from Shelmet,they defend themselves and attack with two lances.",
    70, 135, 105, 60, 105, 20, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 4, 16, 20, 25, 28, 32, 37, 40, 44, 49, 52, 56, 60},
    new string[]
    {
         "Double-Edge", "Twineedle", "Peck", "Quick Guard", "Leer", "Fury Attack", "Headbutt", "False Swipe", "Bug Buzz", "Slash", "Iron Head", "Iron Defense", "X-Scissor", "Reversal", "Swords Dance", "Giga Impact", "Fell Stinger",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Aerial_Ace", "Poison_Jab", "X_Scissor", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(590, "Foongus", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Effect-spore", null, "Regenerator",
    50f, 190, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.2f, 1f,
    59, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Mushroom", "It lures people in with its Poké Ball pattern, thenreleases poison spores. Why it resembles aPoké Ball is unknown.",
    69, 55, 45, 55, 55, 15, 0, Color.clear,
    new int[] { 1, 6, 8, 12, 15, 18, 20, 24, 28, 32, 35, 39, 43, 45, 50},
    new string[]
    {
         "Absorb", "Growth", "Astonish", "Bide", "Mega Drain", "Ingrain", "Feint Attack", "Sweet Scent", "Giga Drain", "Toxic", "Synthesis", "Clear Smog", "Solar Beam", "Rage Powder", "Spore",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Nature_Power", "Payback", "Energy_Ball", "Grass_Knot", "Venoshock", "Round", "Confide"
    },
    new int[] {591}, new string[] {"Level,39"}),


new PokemonData(591, "Amoonguss", PokemonData.Type.GRASS, PokemonData.Type.POISON, "Effect-spore", null, "Regenerator",
    50f, 75, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.6f, 10.5f,
    162, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Mushroom", "They show off their Poké Ball caps to lure prey,but very few Pokémon are fooled by this.",
    114, 85, 70, 85, 80, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 15, 18, 20, 24, 28, 32, 35, 43},
    new string[]
    {
         "Absorb", "Growth", "Bide", "Astonish", "Mega Drain", "Ingrain", "Feint Attack", "Sweet Scent", "Giga Drain", "Toxic", "Synthesis", "Clear Smog",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Nature_Power", "Payback", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Venoshock", "Round", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(592, "Frillish", PokemonData.Type.WATER, PokemonData.Type.GHOST, "Water-absorb", "Cursed-body", "Damp",
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 257, 1.2f, 33f,
    67, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.WHITE, 70,
    "Floating", "They paralyze prey with poison, then drag themdown to their lairs, five miles below the surface.",
    55, 40, 50, 65, 85, 40, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 22, 27, 32, 37, 43, 49, 55, 61},
    new string[]
    {
         "Bubble", "Water Sport", "Absorb", "Night Shade", "Bubble Beam", "Recover", "Water Pulse", "Ominous Wind", "Brine", "Rain Dance", "Hex", "Hydro Pump", "Wring Out", "Water Spout",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Psychic", "Double_Team", "Waterfall", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Hail", "Will_O_Wisp", "Facade", "Taunt", "Dark_Pulse", "Energy_Ball", "Trick_Room", "Sludge_Wave", "Round", "Scald", "Confide", "Dazzling_Gleam"
    },
    new int[] {593}, new string[] {"Level,40"}),


new PokemonData(593, "Jellicent", PokemonData.Type.WATER, PokemonData.Type.GHOST, "Water-absorb", "Cursed-body", "Damp",
    50f, 60, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 257, 2.2f, 135f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.WHITE, 70,
    "Floating", "Its body is mostly seawater. It’s said there’s acastle of ships Jellicent have sunk on the seafloor.",
    100, 60, 70, 85, 105, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 13, 17, 22, 32, 37, 45, 53},
    new string[]
    {
         "Absorb", "Bubble", "Water Spout", "Wring Out", "Night Shade", "Bubble Beam", "Recover", "Water Pulse", "Brine", "Rain Dance", "Hex", "Hydro Pump",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Waterfall", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Hail", "Will_O_Wisp", "Facade", "Taunt", "Dark_Pulse", "Energy_Ball", "Giga_Impact", "Trick_Room", "Sludge_Wave", "Round", "Scald", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(594, "Alomomola", PokemonData.Type.WATER, PokemonData.Type.NONE, "Healer", "Hydration", "Regenerator",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.2f, 31.6f,
    165, PokemonData.LevelingRate.FAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Caring", "Floating in the open sea is how they live. When they find a wounded Pokémon,they embrace it and bring it to shore.",
    165, 75, 80, 40, 45, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 9, 13, 17, 25, 29, 37, 45, 49},
    new string[]
    {
         "Pound", "Hydro Pump", "Water Sport", "Healing Wish", "Wide Guard", "Aqua Ring", "Aqua Jet", "Double Slap", "Heal Pulse", "Water Pulse", "Wake-Up Slap", "Wish", "Safeguard", "Helping Hand",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Waterfall", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Hail", "Facade", "Calm_Mind", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(595, "Joltik", PokemonData.Type.BUG, PokemonData.Type.ELECTRIC, "Compound-eyes", "Unnerve", "Swarm",
    50f, 190, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.1f, 0.6f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Attaching", "Since it can’t generate its own electricity, it sticksonto large-bodied Pokémon and absorbsstatic electricity.",
    50, 47, 50, 57, 50, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 7, 12, 15, 18, 23, 26, 29, 34, 37, 40, 45, 48},
    new string[]
    {
         "String Shot", "Leech Life", "Spider Web", "Thunder Wave", "Screech", "Fury Cutter", "Electroweb", "Bug Bite", "Gastro Acid", "Slash", "Electro Ball", "Signal Beam", "Agility", "Sucker Punch", "Discharge", "Bug Buzz",
    },
    new string[]
    {
         "Cut", "Thunderbolt", "Thunder_Wave", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Poison_Jab", "X_Scissor", "Energy_Ball", "Charge_Beam", "Round", "Volt_Switch", "Struggle_Bug", "Wild_Charge", "Confide", "Infestation"
    },
    new int[] {596}, new string[] {"Level,36"}),


new PokemonData(596, "Galvantula", PokemonData.Type.BUG, PokemonData.Type.ELECTRIC, "Compound-eyes", "Unnerve", "Swarm",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.8f, 14.3f,
    165, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "EleSpider", "They employ an electrically charged web to traptheir prey. While it is immobilized by shock,they leisurely consume it.",
    70, 77, 60, 97, 60, 108, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 7, 12, 15, 18, 23, 26, 29, 34, 46, 54, 60},
    new string[]
    {
         "String Shot", "Thunder Wave", "Leech Life", "Spider Web", "Sticky Web", "Screech", "Fury Cutter", "Electroweb", "Bug Bite", "Gastro Acid", "Slash", "Electro Ball", "Signal Beam", "Sucker Punch", "Discharge", "Bug Buzz",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Poison_Jab", "X_Scissor", "Energy_Ball", "Giga_Impact", "Charge_Beam", "Round", "Volt_Switch", "Struggle_Bug", "Wild_Charge", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(597, "Ferroseed", PokemonData.Type.GRASS, PokemonData.Type.STEEL, "Iron-barbs", null, null,
    50f, 255, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.6f, 18.8f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Thorn Seed", "When threatened, it attacks by shooting a barrageof spikes, which gives it a chance to escape byrolling away.",
    44, 50, 91, 24, 86, 10, 0, Color.clear,
    new int[] { 1, 1, 6, 9, 14, 18, 21, 26, 30, 35, 38, 43, 47, 52, 55},
    new string[]
    {
         "Tackle", "Harden", "Rollout", "Curse", "Metal Claw", "Pin Missile", "Gyro Ball", "Iron Defense", "Mirror Shot", "Ingrain", "Self-Destruct", "Iron Head", "Payback", "Flash Cannon", "Explosion",
    },
    new string[]
    {
         "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Toxic", "Double_Team", "Flash", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Gyro_Ball", "Payback", "Rock_Polish", "Poison_Jab", "Energy_Ball", "Flash_Cannon", "Hone_Claws", "Round", "Confide"
    },
    new int[] {598}, new string[] {"Level,40"}),


new PokemonData(598, "Ferrothorn", PokemonData.Type.GRASS, PokemonData.Type.STEEL, "Iron-barbs", null, "Anticipation",
    50f, 90, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1f, 110f,
    171, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Thorn Pod", "By swinging around its three spiky feelers andshooting spikes, it can obliterate an opponent.",
    74, 94, 131, 54, 116, 20, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 14, 18, 21, 26, 30, 35, 38, 40, 46, 53, 61, 67},
    new string[]
    {
         "Tackle", "Harden", "Curse", "Rock Climb", "Rollout", "Metal Claw", "Pin Missile", "Gyro Ball", "Iron Defense", "Mirror Shot", "Ingrain", "Self-Destruct", "Power Whip", "Iron Head", "Payback", "Flash Cannon", "Explosion",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Flash", "Explosion", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Aerial_Ace", "Gyro_Ball", "Payback", "Rock_Polish", "Poison_Jab", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Grass_Knot", "Hone_Claws", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(599, "Klink", PokemonData.Type.STEEL, PokemonData.Type.NONE, "Plus", "Minus", "Clear-body",
    112.5f, 130, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.3f, 21f,
    60, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Gear", "Interlocking two bodies and spinning aroundgenerates the energy they need to live.",
    40, 55, 70, 45, 60, 30, 0, Color.clear,
    new int[] { 1, 6, 11, 16, 21, 26, 31, 36, 39, 42, 45, 48, 50, 54, 57},
    new string[]
    {
         "Vice Grip", "Charge", "Thunder Shock", "Gear Grind", "Bind", "Charge Beam", "Autotomize", "Mirror Shot", "Screech", "Discharge", "Metal Sound", "Shift Gear", "Lock-On", "Zap Cannon", "Hyper Beam",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Rock_Polish", "Flash_Cannon", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {600}, new string[] {"Level,38"}),


new PokemonData(600, "Klang", PokemonData.Type.STEEL, PokemonData.Type.NONE, "Plus", "Minus", "Clear-body",
    112.5f, 60, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.6f, 51f,
    154, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Gear", "By changing the direction in which it rotates,it communicates its feelings to others. When angry,it rotates faster.",
    60, 80, 95, 70, 85, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 21, 26, 31, 36, 44, 52, 56, 60, 64},
    new string[]
    {
         "Vice Grip", "Thunder Shock", "Charge", "Gear Grind", "Bind", "Charge Beam", "Autotomize", "Mirror Shot", "Discharge", "Shift Gear", "Lock-On", "Zap Cannon", "Hyper Beam",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Rock_Polish", "Flash_Cannon", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {601}, new string[] {"Level,49"}),


new PokemonData(601, "Klinklang", PokemonData.Type.STEEL, PokemonData.Type.NONE, "Plus", "Minus", "Clear-body",
    112.5f, 30, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.6f, 81f,
    234, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Gear", "The gear with the red core is rotated at high speedfor a rapid energy charge.",
    60, 100, 115, 70, 85, 90, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 21, 25, 31, 36, 44, 54, 72, 76},
    new string[]
    {
         "Vice Grip", "Thunder Shock", "Zap Cannon", "Charge", "Gear Grind", "Bind", "Charge Beam", "Autotomize", "Mirror Shot", "Discharge", "Shift Gear", "Hyper Beam", "Magnetic Flux",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Rock_Polish", "Giga_Impact", "Flash_Cannon", "Trick_Room", "Charge_Beam", "Round", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(602, "Tynamo", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.2f, 0.3f,
    55, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.WHITE, 70,
    "EleFish", "While one alone doesn’t have much power, a chainof many Tynamo can be as powerful as lightning.",
    35, 55, 40, 45, 40, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1},
    new string[]
    {
         "Tackle", "Thunder Wave", "Spark", "Charge Beam",
    },
    new string[]
    {
         "Thunder_Wave", "Charge_Beam"
    },
    new int[] {603}, new string[] {"Level,39"}),


new PokemonData(603, "Eelektrik", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 60, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1.2f, 22f,
    142, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "EleFish", "It wraps itself around its prey and paralyzes it withelectricity from the round spots on its sides. Then it chomps.",
    65, 85, 70, 75, 70, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 9, 19, 29, 39, 44, 49, 54, 59, 64, 69, 74},
    new string[]
    {
         "Headbutt", "Thunder Wave", "Spark", "Charge Beam", "Bind", "Acid", "Discharge", "Crunch", "Thunderbolt", "Acid Spray", "Coil", "Wild Charge", "Gastro Acid", "Zap Cannon", "Thrash",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "U_turn", "Flash_Cannon", "Charge_Beam", "Round", "Acrobatics", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(604, "Eelektross", PokemonData.Type.ELECTRIC, PokemonData.Type.NONE, "Levitate", null, null,
    50f, 30, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 2.1f, 80.5f,
    232, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "EleFish", "With their sucker mouths, they suck in prey. Then they use their fangs to shock the preywith electricity.",
    85, 115, 80, 105, 80, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
    new string[]
    {
         "Headbutt", "Thrash", "Acid", "Zap Cannon", "Crunch", "Crush Claw", "Gastro Acid", "Discharge", "Coil", "Ion Deluge",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Dragon_Claw", "U_turn", "Giga_Impact", "Flash_Cannon", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Round", "Acrobatics", "Volt_Switch", "Dragon_Tail", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(605, "Elgyem", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Telepathy", "Synchronize", "Analytic",
    50f, 255, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.5f, 9f,
    67, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Cerebral", "It uses its strong psychic power to squeeze itsopponent’s brain, causing unendurable headaches.",
    55, 55, 55, 85, 55, 30, 0, Color.clear,
    new int[] { 1, 4, 8, 11, 15, 18, 22, 25, 29, 32, 36, 39, 43, 46, 50, 50, 53, 56},
    new string[]
    {
         "Confusion", "Growl", "Heal Block", "Miracle Eye", "Psybeam", "Headbutt", "Hidden Power", "Imprison", "Simple Beam", "Zen Headbutt", "Psych Up", "Psychic", "Calm Mind", "Recover", "Guard Split", "Power Split", "Synchronoise", "Wonder Room",
    },
    new string[]
    {
         "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Facade", "Rock_Tomb", "Calm_Mind", "Embargo", "Dark_Pulse", "Energy_Ball", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {606}, new string[] {"Level,42"}),


new PokemonData(606, "Beheeyem", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Telepathy", "Synchronize", "Analytic",
    50f, 90, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1f, 34.5f,
    170, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Cerebral", "Apparently, it communicates by flashing its threefingers, but those patterns haven’t been decoded.",
    75, 75, 75, 125, 95, 40, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 8, 18, 22, 25, 29, 32, 36, 39, 45, 50, 56, 58, 63},
    new string[]
    {
         "Growl", "Confusion", "Miracle Eye", "Wonder Room", "Heal Block", "Headbutt", "Hidden Power", "Imprison", "Simple Beam", "Zen Headbutt", "Psych Up", "Psychic", "Calm Mind", "Recover", "Guard Split", "Power Split", "Synchronoise",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Shadow_Ball", "Facade", "Rock_Tomb", "Calm_Mind", "Embargo", "Dark_Pulse", "Energy_Ball", "Giga_Impact", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(607, "Litwick", PokemonData.Type.GHOST, PokemonData.Type.FIRE, "Flash-fire", "Flame-body", "Infiltrator",
    50f, 190, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.3f, 3.1f,
    55, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Candle", "While shining a light and pretending to be a guide,it leeches off the life force of any who follow it.",
    50, 30, 55, 65, 55, 20, 0, Color.clear,
    new int[] { 1, 1, 3, 5, 7, 10, 13, 16, 20, 24, 28, 33, 38, 43, 49, 55, 61},
    new string[]
    {
         "Ember", "Astonish", "Minimize", "Smog", "Fire Spin", "Confuse Ray", "Night Shade", "Will-O-Wisp", "Flame Burst", "Imprison", "Hex", "Memento", "Inferno", "Curse", "Shadow Ball", "Pain Split", "Overheat",
    },
    new string[]
    {
         "Flamethrower", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Calm_Mind", "Payback", "Embargo", "Dark_Pulse", "Energy_Ball", "Trick_Room", "Flame_Charge", "Round", "Incinerate", "Confide"
    },
    new int[] {608}, new string[] {"Level,41"}),


new PokemonData(608, "Lampent", PokemonData.Type.GHOST, PokemonData.Type.FIRE, "Flash-fire", "Flame-body", "Infiltrator",
    50f, 90, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.6f, 13f,
    130, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Lamp", "The spirits it absorbs fuel its baleful fire. It hangsaround hospitals waiting for people to pass on.",
    60, 40, 60, 95, 60, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 7, 13, 16, 20, 24, 28, 33, 38, 53, 61, 69},
    new string[]
    {
         "Ember", "Minimize", "Smog", "Astonish", "Fire Spin", "Night Shade", "Will-O-Wisp", "Flame Burst", "Imprison", "Hex", "Memento", "Inferno", "Shadow Ball", "Pain Split", "Overheat",
    },
    new string[]
    {
         "Flamethrower", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Calm_Mind", "Payback", "Embargo", "Dark_Pulse", "Energy_Ball", "Trick_Room", "Flame_Charge", "Round", "Incinerate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(609, "Chandelure", PokemonData.Type.GHOST, PokemonData.Type.FIRE, "Flash-fire", "Flame-body", "Infiltrator",
    50f, 45, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 1f, 34.3f,
    234, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Luring", "Being consumed in Chandelure’s flame burns upthe spirit, leaving the body behind.",
    60, 55, 90, 145, 90, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1},
    new string[]
    {
         "Confuse Ray", "Smog", "Pain Split", "Flame Burst", "Hex",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Fire_Blast", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Calm_Mind", "Payback", "Embargo", "Dark_Pulse", "Energy_Ball", "Giga_Impact", "Trick_Room", "Flame_Charge", "Round", "Incinerate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(610, "Axew", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Rivalry", "Mold-breaker", "Unnerve",
    50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.6f, 18f,
    64, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 35,
    "Tusk", "They use their tusks to crush the berries they eat. Repeated regrowth makes their tusks strongand sharp.",
    46, 87, 60, 30, 40, 57, 0, Color.clear,
    new int[] { 1, 4, 7, 10, 13, 16, 20, 24, 28, 32, 36, 41, 46, 50, 56, 61},
    new string[]
    {
         "Scratch", "Leer", "Assurance", "Dragon Rage", "Dual Chop", "Scary Face", "Slash", "False Swipe", "Dragon Claw", "Dragon Dance", "Taunt", "Dragon Pulse", "Swords Dance", "Guillotine", "Outrage", "Giga Impact",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Payback", "Fling", "Poison_Jab", "X_Scissor", "Giga_Impact", "Hone_Claws", "Round", "Incinerate", "Confide"
    },
    new int[] {611}, new string[] {"Level,38"}),


new PokemonData(611, "Fraxure", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Rivalry", "Mold-breaker", "Unnerve",
    50f, 60, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 36f,
    144, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 35,
    "Axe Jaw", "Their tusks can shatter rocks. Territory battlesbetween Fraxure can be intensely violent.",
    66, 117, 70, 40, 50, 67, 0, Color.clear,
    new int[] { 1, 1, 1, 10, 13, 16, 20, 24, 28, 32, 36, 48, 54, 60, 66},
    new string[]
    {
         "Scratch", "Leer", "Assurance", "Dragon Rage", "Dual Chop", "Scary Face", "Slash", "False Swipe", "Dragon Claw", "Dragon Dance", "Taunt", "Swords Dance", "Guillotine", "Outrage", "Giga Impact",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Payback", "Fling", "Poison_Jab", "X_Scissor", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Incinerate", "Dragon_Tail", "Confide"
    },
    new int[] {612}, new string[] {"Level,48"}),


new PokemonData(612, "Haxorus", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Rivalry", "Mold-breaker", "Unnerve",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.8f, 105.5f,
    243, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
    "Axe Jaw", "They are kind but can be relentless when defendingterritory. They challenge foes with tusks that cancut steel.",
    76, 147, 90, 60, 70, 97, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 10, 13, 16, 20, 28, 32, 36, 50, 58, 74},
    new string[]
    {
         "Scratch", "Leer", "Outrage", "Assurance", "Dragon Rage", "Dual Chop", "Scary Face", "Slash", "Dragon Claw", "Dragon Dance", "Taunt", "Swords Dance", "Guillotine", "Giga Impact",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Payback", "Fling", "Poison_Jab", "X_Scissor", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Round", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(613, "Cubchoo", PokemonData.Type.ICE, PokemonData.Type.NONE, "Snow-cloak", "Slush-rush", "Rattled",
    50f, 120, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.5f, 8.5f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Chill", "Its nose is always running. It sniffs the snot back upbecause the mucus provides the raw material forits moves.",
    55, 70, 40, 60, 40, 40, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 15, 17, 21, 25, 29, 33, 36, 41, 45, 49, 53, 57},
    new string[]
    {
         "Growl", "Powder Snow", "Bide", "Icy Wind", "Play Nice", "Fury Swipes", "Brine", "Endure", "Charm", "Slash", "Flail", "Rest", "Blizzard", "Hail", "Thrash", "Sheer Cold",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Aerial_Ace", "Fling", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Round", "Echoed_Voice", "Frost_Breath", "Confide", "Power_Up_Punch"
    },
    new int[] {614}, new string[] {"Level,37"}),


new PokemonData(614, "Beartic", PokemonData.Type.ICE, PokemonData.Type.NONE, "Snow-cloak", "Slush-rush", "Swift-swim",
    50f, 60, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2.6f, 260f,
    177, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Freezing", "They love the cold seas of the north. They createpathways across the ocean waters by freezing theirown breath.",
    95, 130, 80, 70, 80, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 9, 17, 29, 33, 36, 37, 41, 45, 53},
    new string[]
    {
         "Thrash", "Bide", "Powder Snow", "Icy Wind", "Superpower", "Sheer Cold", "Aqua Jet", "Play Nice", "Fury Swipes", "Swagger", "Slash", "Flail", "Icicle Crash", "Rest", "Blizzard", "Hail",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Round", "Echoed_Voice", "Bulldoze", "Frost_Breath", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(615, "Cryogonal", PokemonData.Type.ICE, PokemonData.Type.NONE, "Levitate", null, null,
    112.5f, 25, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.1f, 148f,
    180, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BLUE, 70,
    "Crystallizing", "They are born in snow clouds. They use chainsmade of ice crystals to capture prey.",
    80, 50, 50, 95, 135, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 9, 13, 17, 25, 29, 37, 41, 45, 49, 53, 57},
    new string[]
    {
         "Bind", "Mist", "Haze", "Sheer Cold", "Ice Shard", "Sharpen", "Rapid Spin", "Icy Wind", "Aurora Beam", "Acid Armor", "Light Screen", "Slash", "Confuse Ray", "Recover", "Solar Beam", "Night Slash",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Hail", "Facade", "Poison_Jab", "Flash_Cannon", "Round", "Acrobatics", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(616, "Shelmet", PokemonData.Type.BUG, PokemonData.Type.NONE, "Hydration", "Shell-armor", "Overcoat",
    50f, 200, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.4f, 7.7f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Snail", "When it and Karrablast are together, and bothreceive electrical stimulation, they both evolve.",
    50, 40, 85, 40, 65, 25, 0, Color.clear,
    new int[] { 1, 4, 8, 13, 16, 20, 25, 28, 32, 37, 40, 44, 49, 50, 56},
    new string[]
    {
         "Leech Life", "Acid", "Bide", "Curse", "Struggle Bug", "Mega Drain", "Yawn", "Protect", "Acid Armor", "Giga Drain", "Body Slam", "Bug Buzz", "Recover", "Guard Swap", "Final Gambit",
    },
    new string[]
    {
         "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Energy_Ball", "Venoshock", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(617, "Accelgor", PokemonData.Type.BUG, PokemonData.Type.NONE, "Hydration", "Sticky-hold", "Unburden",
    50f, 75, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.8f, 25.3f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.RED, 70,
    "Shell Out", "Having removed its heavy shell, it becomes verylight and can fight with ninja-like movements.",
    80, 70, 40, 100, 60, 145, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 8, 16, 20, 25, 28, 32, 37, 40, 49, 56},
    new string[]
    {
         "Quick Attack", "Leech Life", "Power Swap", "Acid Spray", "Double Team", "Struggle Bug", "Mega Drain", "Swift", "Me First", "Agility", "Giga Drain", "U-turn", "Recover", "Final Gambit",
    },
    new string[]
    {
         "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "U_turn", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Venoshock", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(618, "Stunfisk", PokemonData.Type.GROUND, PokemonData.Type.ELECTRIC, "Static", "Limber", "Sand-veil",
    50f, 75, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.7f, 11f,
    165, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Trap", "Its skin is very hard, so it is unhurt even if steppedon by sumo wrestlers. It smiles whentransmitting electricity.",
    109, 66, 84, 81, 99, 32, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 9, 13, 17, 21, 25, 30, 35, 40, 45, 50},
    new string[]
    {
         "Tackle", "Water Gun", "Fissure", "Flail", "Mud Sport", "Thunder Shock", "Mud Shot", "Camouflage", "Mud Bomb", "Discharge", "Endure", "Bounce", "Muddy Water", "Thunderbolt", "Revenge",
    },
    new string[]
    {
         "Surf", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "Rock_Tomb", "Payback", "Stone_Edge", "Sludge_Wave", "Round", "Scald", "Bulldoze", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(619, "Mienfoo", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Inner-focus", "Regenerator", "Reckless",
    50f, 180, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 20f,
    70, PokemonData.LevelingRate.MEDIUMSLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.YELLOW, 70,
    "Martial Arts", "It takes pride in the speed at which it can usemoves. What it loses in power, it makes up forin quantity.",
    45, 85, 50, 55, 50, 65, 0, Color.clear,
    new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 50, 57, 61},
    new string[]
    {
         "Pound", "Meditate", "Detect", "Fake Out", "Double Slap", "Swift", "Calm Mind", "Force Palm", "Drain Punch", "Jump Kick", "U-turn", "Quick Guard", "Bounce", "High Jump Kick", "Reversal", "Aura Sphere",
    },
    new string[]
    {
         "Swords_Dance", "Strength", "Dig", "Toxic", "Double_Team", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Calm_Mind", "U_turn", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Stone_Edge", "Grass_Knot", "Low_Sweep", "Round", "Acrobatics", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {620}, new string[] {"Level,50"}),


new PokemonData(620, "Mienshao", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Inner-focus", "Regenerator", "Reckless",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 35.5f,
    179, PokemonData.LevelingRate.MEDIUMSLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.PURPLE, 70,
    "Martial Arts", "It wields the fur on its arms like a whip. Its armattacks come with such rapidity that they cannoteven be seen.",
    65, 125, 60, 95, 60, 105, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 9, 17, 25, 29, 37, 41, 45, 56},
    new string[]
    {
         "Pound", "Meditate", "Reversal", "Fake Out", "Aura Sphere", "Detect", "Double Slap", "Calm Mind", "Force Palm", "Jump Kick", "U-turn", "Wide Guard", "High Jump Kick",
    },
    new string[]
    {
         "Swords_Dance", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Calm_Mind", "U_turn", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Low_Sweep", "Round", "Acrobatics", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(621, "Druddigon", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Rough-skin", "Sheer-force", "Mold-breaker",
    50f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.6f, 139f,
    170, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Cave", "It races through narrow caves, using its sharp clawsto catch prey. The skin on its face is harder thana rock.",
    77, 120, 90, 60, 90, 48, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 18, 21, 25, 27, 31, 35, 40, 45, 49, 55, 62},
    new string[]
    {
         "Scratch", "Leer", "Hone Claws", "Bite", "Scary Face", "Dragon Rage", "Slash", "Crunch", "Dragon Claw", "Chip Away", "Revenge", "Night Slash", "Dragon Tail", "Rock Climb", "Superpower", "Outrage",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Payback", "Fling", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Charge_Beam", "Hone_Claws", "Smack_Down", "Round", "Incinerate", "Retaliate", "Bulldoze", "Dragon_Tail", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(622, "Golett", PokemonData.Type.GROUND, PokemonData.Type.GHOST, "Iron-fist", "Klutz", "No-guard",
    112.5f, 190, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1f, 92f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Automaton", "The energy that burns inside it enables it to move,but no one has yet been able to identifythis energy.",
    59, 74, 50, 35, 50, 35, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 13, 17, 21, 25, 30, 35, 40, 45, 50, 55},
    new string[]
    {
         "Pound", "Defense Curl", "Astonish", "Mud-Slap", "Rollout", "Shadow Punch", "Iron Defense", "Mega Punch", "Magnitude", "Dynamic Punch", "Night Shade", "Curse", "Earthquake", "Hammer Arm", "Focus Punch",
    },
    new string[]
    {
         "Ice_Beam", "Strength", "Earthquake", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Rock_Polish", "Focus_Blast", "Grass_Knot", "Low_Sweep", "Round", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {623}, new string[] {"Level,43"}),


new PokemonData(623, "Golurk", PokemonData.Type.GROUND, PokemonData.Type.GHOST, "Iron-fist", "Klutz", "No-guard",
    112.5f, 90, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 2.8f, 330f,
    169, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Automaton", "It is said that Golurk were ordered to protectpeople and Pokémon by the ancient people whomade them.",
    89, 124, 80, 55, 80, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 13, 17, 21, 25, 30, 35, 40, 43, 50, 60},
    new string[]
    {
         "Pound", "Defense Curl", "Mud-Slap", "Focus Punch", "Phantom Force", "Shadow Punch", "Iron Defense", "Mega Punch", "Magnitude", "Dynamic Punch", "Night Shade", "Curse", "Heavy Slam", "Earthquake", "Hammer Arm",
    },
    new string[]
    {
         "Fly", "Ice_Beam", "Hyper_Beam", "Strength", "Solar_Beam", "Thunderbolt", "Earthquake", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Gyro_Ball", "Fling", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Low_Sweep", "Round", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(624, "Pawniard", PokemonData.Type.DARK, PokemonData.Type.STEEL, "Defiant", "Inner-focus", "Pressure",
    50f, 120, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.5f, 10.2f,
    68, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 35,
    "Sharp Blade", "Blades comprise this Pokémon’s entire body. If battling dulls the blades, it sharpens them onstones by the river.",
    45, 85, 70, 40, 40, 60, 0, Color.clear,
    new int[] { 1, 6, 9, 14, 17, 22, 25, 30, 33, 38, 41, 46, 49, 54, 57, 62},
    new string[]
    {
         "Scratch", "Leer", "Fury Cutter", "Torment", "Feint Attack", "Scary Face", "Metal Claw", "Slash", "Assurance", "Metal Sound", "Embargo", "Iron Defense", "Night Slash", "Iron Head", "Swords Dance", "Guillotine",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Thunder_Wave", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Embargo", "Fling", "Rock_Polish", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Shadow_Claw", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Retaliate", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {625}, new string[] {"Level,52"}),


new PokemonData(625, "Bisharp", PokemonData.Type.DARK, PokemonData.Type.STEEL, "Defiant", "Inner-focus", "Pressure",
    50f, 45, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 1.6f, 70f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 35,
    "Sword Blade", "This pitiless Pokémon commands a group ofPawniard to hound prey into immobility. It thenmoves in to finish the prey off.",
    65, 125, 100, 60, 70, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 17, 22, 33, 41, 46, 49},
    new string[]
    {
         "Scratch", "Guillotine", "Leer", "Fury Cutter", "Torment", "Metal Burst", "Iron Head", "Feint Attack", "Scary Face", "Assurance", "Embargo", "Iron Defense", "Night Slash",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Thunder_Wave", "Dig", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Embargo", "Fling", "Rock_Polish", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Retaliate", "Snarl", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(626, "Bouffalant", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Reckless", "Sap-sipper", "Soundproof",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.6f, 94.6f,
    172, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Bash Buffalo", "They charge wildly and headbutt everything. Their headbutts have enough destructive force toderail a train.",
    95, 110, 95, 40, 95, 55, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 46, 50, 56, 61},
    new string[]
    {
         "Leer", "Pursuit", "Rage", "Fury Attack", "Horn Attack", "Scary Face", "Revenge", "Head Charge", "Focus Energy", "Megahorn", "Reversal", "Thrash", "Swords Dance", "Giga Impact",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Strength", "Earthquake", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Payback", "Poison_Jab", "Giga_Impact", "Stone_Edge", "Round", "Retaliate", "Bulldoze", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(627, "Rufflet", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Sheer-force", "Hustle",
    100f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.5f, 10.5f,
    70, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Eaglet", "They crush berries with their talons. They bravelystand up to any opponent, no matter how strongit is.",
    70, 83, 50, 37, 50, 60, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 46, 50, 55, 59, 64},
    new string[]
    {
         "Leer", "Peck", "Fury Attack", "Wing Attack", "Hone Claws", "Scary Face", "Aerial Ace", "Slash", "Defog", "Tailwind", "Air Slash", "Crush Claw", "Sky Drop", "Whirlwind", "Brave Bird", "Thrash",
    },
    new string[]
    {
         "Cut", "Fly", "Strength", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Roost", "U_turn", "Shadow_Claw", "Hone_Claws", "Round", "Sky_Drop", "Retaliate", "Confide"
    },
    new int[] {628}, new string[] {"Level,54"}),


new PokemonData(628, "Braviary", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Keen-eye", "Sheer-force", "Defiant",
    100f, 60, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.5f, 41f,
    179, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Valiant", "For the sake of its friends, this brave warrior of thesky will not stop battling, even if injured.",
    100, 123, 75, 57, 75, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 14, 19, 23, 28, 37, 41, 50, 57, 70},
    new string[]
    {
         "Wing Attack", "Fury Attack", "Leer", "Peck", "Superpower", "Brave Bird", "Hone Claws", "Scary Face", "Aerial Ace", "Slash", "Tailwind", "Air Slash", "Sky Drop", "Whirlwind", "Thrash",
    },
    new string[]
    {
         "Cut", "Fly", "Hyper_Beam", "Strength", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Roost", "U_turn", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Sky_Drop", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(629, "Vullaby", PokemonData.Type.DARK, PokemonData.Type.FLYING, "Big-pecks", "Overcoat", "Weak-armor",
    0f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.5f, 9f,
    74, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 35,
    "Diapered", "Its wings are too tiny to allow it to fly. As the timeapproaches for it to evolve, it discards the bonesit was wearing.",
    70, 55, 75, 45, 65, 60, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 14, 19, 23, 28, 32, 37, 41, 46, 50, 55, 59, 64},
    new string[]
    {
         "Gust", "Leer", "Fury Attack", "Pluck", "Nasty Plot", "Flatter", "Feint Attack", "Punishment", "Defog", "Tailwind", "Air Slash", "Dark Pulse", "Embargo", "Whirlwind", "Brave Bird", "Mirror Move",
    },
    new string[]
    {
         "Cut", "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Roost", "U_turn", "Payback", "Embargo", "Dark_Pulse", "Round", "Incinerate", "Retaliate", "Snarl", "Confide"
    },
    new int[] {630}, new string[] {"Level,54"}),


new PokemonData(630, "Mandibuzz", PokemonData.Type.DARK, PokemonData.Type.FLYING, "Big-pecks", "Overcoat", "Weak-armor",
    0f, 60, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.2f, 39.5f,
    179, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BROWN, 35,
    "Bone Vulture", "They fly in circles around the sky. When they spotprey, they attack and carry it back to their nestwith ease.",
    110, 65, 105, 55, 95, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 5, 28, 32, 41, 46, 50},
    new string[]
    {
         "Gust", "Whirlwind", "Leer", "Mirror Move", "Bone Rush", "Pluck", "Brave Bird", "Fury Attack", "Punishment", "Defog", "Air Slash", "Dark Pulse", "Embargo",
    },
    new string[]
    {
         "Cut", "Fly", "Hyper_Beam", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Roost", "U_turn", "Payback", "Embargo", "Dark_Pulse", "Giga_Impact", "Round", "Incinerate", "Retaliate", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(631, "Heatmor", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Gluttony", "Flash-fire", "White-smoke",
    50f, 90, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.4f, 58f,
    169, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Anteater", "Using their very hot, flame-covered tongues,they burn through Durant’s steel bodies andconsume their insides.",
    85, 97, 66, 105, 66, 65, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 44, 47, 50, 50, 50},
    new string[]
    {
         "Tackle", "Lick", "Hone Claws", "Incinerate", "Inferno", "Odor Sleuth", "Bind", "Fire Spin", "Fury Swipes", "Snatch", "Flame Burst", "Bug Bite", "Slash", "Amnesia", "Flamethrower", "Stockpile", "Spit Up", "Swallow",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(632, "Durant", PokemonData.Type.BUG, PokemonData.Type.STEEL, "Swarm", "Hustle", "Truant",
    50f, 90, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 33f,
    169, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Iron Ant", "Individuals each play different roles in drivingHeatmor, their natural predator, away fromtheir colony.",
    58, 109, 112, 48, 48, 109, 0, Color.clear,
    new int[] { 1, 1, 1, 6, 11, 16, 21, 26, 31, 36, 41, 46, 51, 56},
    new string[]
    {
         "Vice Grip", "Guillotine", "Metal Sound", "Fury Cutter", "Bite", "Agility", "Metal Claw", "Bug Bite", "Crunch", "Iron Head", "Dig", "Entrainment", "X-Scissor", "Iron Defense",
    },
    new string[]
    {
         "Cut", "Strength", "Thunder_Wave", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Rock_Tomb", "Aerial_Ace", "Rock_Polish", "X_Scissor", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Stone_Edge", "Hone_Claws", "Round", "Retaliate", "Struggle_Bug", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(633, "Deino", PokemonData.Type.DARK, PokemonData.Type.DRAGON, "Hustle", null, null,
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 0.8f, 17.3f,
    60, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Irate", "They cannot see, so they tackle and bite to learnabout their surroundings. Their bodies are coveredin wounds.",
    52, 65, 50, 45, 50, 38, 0, Color.clear,
    new int[] { 1, 1, 4, 9, 12, 17, 20, 25, 28, 32, 38, 42, 48, 50, 58, 62},
    new string[]
    {
         "Tackle", "Dragon Rage", "Focus Energy", "Bite", "Headbutt", "Dragon Breath", "Roar", "Crunch", "Slam", "Dragon Pulse", "Work Up", "Dragon Rush", "Body Slam", "Scary Face", "Hyper Voice", "Outrage",
    },
    new string[]
    {
         "Roar", "Strength", "Thunder_Wave", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Torment", "Facade", "Taunt", "Dark_Pulse", "Round", "Incinerate", "Dragon_Tail", "Confide"
    },
    new int[] {634}, new string[] {"Level,50"}),


new PokemonData(634, "Zweilous", PokemonData.Type.DARK, PokemonData.Type.DRAGON, "Hustle", null, null,
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 1.4f, 50f,
    147, PokemonData.LevelingRate.SLOW, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Hostile", "The two heads do not get along. Whichever headeats more than the other gets to be the leader.",
    72, 85, 70, 65, 70, 58, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 12, 17, 25, 28, 32, 38, 42, 48, 64, 71},
    new string[]
    {
         "Bite", "Dragon Rage", "Focus Energy", "Double Hit", "Headbutt", "Dragon Breath", "Crunch", "Slam", "Dragon Pulse", "Work Up", "Dragon Rush", "Body Slam", "Hyper Voice", "Outrage",
    },
    new string[]
    {
         "Roar", "Strength", "Thunder_Wave", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Torment", "Facade", "Taunt", "Dark_Pulse", "Round", "Incinerate", "Dragon_Tail", "Confide"
    },
    new int[] {635}, new string[] {"Level,64"}),


new PokemonData(635, "Hydreigon", PokemonData.Type.DARK, PokemonData.Type.DRAGON, "Levitate", null, null,
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 1.8f, 160f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Brutal", "The heads on their arms do not have brains. They use all three heads to consume anddestroy everything.",
    92, 105, 90, 125, 90, 98, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 12, 25, 28, 38, 42, 48, 55},
    new string[]
    {
         "Bite", "Dragon Rage", "Focus Energy", "Outrage", "Hyper Voice", "Headbutt", "Crunch", "Slam", "Work Up", "Dragon Rush", "Body Slam", "Scary Face",
    },
    new string[]
    {
         "Fly", "Roar", "Flamethrower", "Surf", "Hyper_Beam", "Strength", "Thunder_Wave", "Earthquake", "Toxic", "Double_Team", "Reflect", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Rock_Smash", "Torment", "Facade", "Taunt", "Rock_Tomb", "Roost", "U_turn", "Payback", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Charge_Beam", "Round", "Echoed_Voice", "Incinerate", "Acrobatics", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(636, "Larvesta", PokemonData.Type.BUG, PokemonData.Type.FIRE, "Flame-body", null, "Swarm",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.1f, 28.8f,
    72, PokemonData.LevelingRate.SLOW, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Torch", "Said to have been born from the sun, it spews firefrom its horns and encases itself in a cocoon of firewhen it evolves.",
    55, 85, 55, 50, 55, 60, 0, Color.clear,
    new int[] { 1, 1, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100},
    new string[]
    {
         "Ember", "String Shot", "Leech Life", "Take Down", "Flame Charge", "Bug Bite", "Double-Edge", "Flame Wheel", "Bug Buzz", "Amnesia", "Thrash", "Flare Blitz",
    },
    new string[]
    {
         "Flamethrower", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Will_O_Wisp", "Facade", "Overheat", "Calm_Mind", "U_turn", "Flame_Charge", "Round", "Incinerate", "Acrobatics", "Struggle_Bug", "Wild_Charge", "Confide"
    },
    new int[] {637}, new string[] {"Level,59"}),


new PokemonData(637, "Volcarona", PokemonData.Type.BUG, PokemonData.Type.FIRE, "Flame-body", null, "Swarm",
    50f, 15, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.6f, 46f,
    248, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Sun", "A sea of fire engulfs the surroundings of theirbattles, since they use their six wings to scattertheir ember scales.",
    85, 60, 65, 135, 105, 100, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 30, 80, 90},
    new string[]
    {
         "Gust", "Thrash", "Ember", "String Shot", "Amnesia", "Leech Life", "Heat Wave", "Flare Blitz", "Bug Buzz", "Quiver Dance", "Fiery Dance", "Fire Spin", "Rage Powder", "Hurricane",
    },
    new string[]
    {
         "Fly", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Will_O_Wisp", "Facade", "Overheat", "Aerial_Ace", "Calm_Mind", "Roost", "U_turn", "Poison_Jab", "Giga_Impact", "Flame_Charge", "Round", "Incinerate", "Acrobatics", "Struggle_Bug", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(638, "Cobalion", PokemonData.Type.STEEL, PokemonData.Type.FIGHTING, "Justified", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2.1f, 250f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.BLUE, 35,
    "Iron Will", "It has a body and heart of steel. Its glare issufficient to make even an unruly Pokémon obey it.",
    91, 90, 129, 90, 72, 108, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 7, 13, 19, 25, 37, 49, 73},
    new string[]
    {
         "Leer", "Quick Attack", "Metal Burst", "Quick Guard", "Work Up", "Double Kick", "Metal Claw", "Take Down", "Helping Hand", "Iron Head", "Swords Dance", "Close Combat",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Hyper_Beam", "Strength", "Thunder_Wave", "Toxic", "Double_Team", "Reflect", "Rest", "Substitute", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Psych_Up", "Rock_Smash", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Rock_Polish", "Poison_Jab", "X_Scissor", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Hone_Claws", "Round", "Retaliate", "Volt_Switch", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(639, "Terrakion", PokemonData.Type.ROCK, PokemonData.Type.FIGHTING, "Justified", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.9f, 260f,
    261, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GRAY, 35,
    "Cavern", "Its charge is strong enough to break through agiant castle wall in one blow. This Pokémon isspoken of in legends.",
    91, 129, 90, 72, 90, 108, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 7, 13, 19, 25, 37, 49},
    new string[]
    {
         "Leer", "Quick Attack", "Close Combat", "Quick Guard", "Work Up", "Double Kick", "Smack Down", "Take Down", "Helping Hand", "Rock Slide", "Swords Dance",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "False_Swipe", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Psych_Up", "Rock_Smash", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "Calm_Mind", "Rock_Polish", "Poison_Jab", "X_Scissor", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Smack_Down", "Round", "Retaliate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(640, "Virizion", PokemonData.Type.GRASS, PokemonData.Type.FIGHTING, "Justified", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2f, 200f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.GREEN, 35,
    "Grassland", "Its head sprouts horns as sharp as blades. Usingwhirlwind-like movements, it confounds and swiftlycuts opponents.",
    91, 90, 72, 90, 129, 108, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 7, 13, 19, 25, 37, 49, 73},
    new string[]
    {
         "Leer", "Quick Attack", "Leaf Blade", "Quick Guard", "Work Up", "Double Kick", "Magical Leaf", "Take Down", "Helping Hand", "Giga Drain", "Swords Dance", "Close Combat",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Rock_Smash", "Facade", "Nature_Power", "Taunt", "Aerial_Ace", "Calm_Mind", "X_Scissor", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Round", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(641, "Tornadus-incarnate", PokemonData.Type.FLYING, PokemonData.Type.NONE, "Prankster", null, "Defiant",
    100f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.5f, 63f,
    261, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 90,
    "Cyclone", "The lower half of its body is wrapped in a cloud ofenergy. It zooms through the sky at 200 mph.",
    79, 115, 70, 125, 80, 111, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 7, 19, 25, 31, 37, 43, 49, 55, 61, 73},
    new string[]
    {
         "Gust", "Thrash", "Uproar", "Astonish", "Hammer Arm", "Hurricane", "Swagger", "Revenge", "Air Cutter", "Extrasensory", "Agility", "Air Slash", "Crunch", "Tailwind", "Rain Dance", "Dark Pulse",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Strength", "Toxic", "Psychic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Aerial_Ace", "Bulk_Up", "U_turn", "Payback", "Embargo", "Fling", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Smack_Down", "Sludge_Wave", "Round", "Sky_Drop", "Incinerate", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(642, "Thundurus-incarnate", PokemonData.Type.ELECTRIC, PokemonData.Type.FLYING, "Prankster", null, "Defiant",
    100f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.5f, 61f,
    261, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 90,
    "Bolt Strike", "The spikes on its tail discharge immense bolts oflightning. It flies around the Unova region firing offlightning bolts.",
    79, 115, 70, 125, 80, 111, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 7, 25, 37, 49, 67, 73},
    new string[]
    {
         "Thrash", "Thunder Shock", "Uproar", "Charge", "Astonish", "Hammer Arm", "Nasty Plot", "Swagger", "Shock Wave", "Agility", "Crunch", "Thunder", "Dark Pulse",
    },
    new string[]
    {
         "Fly", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Bulk_Up", "U_turn", "Payback", "Embargo", "Fling", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Grass_Knot", "Charge_Beam", "Smack_Down", "Sludge_Wave", "Round", "Sky_Drop", "Incinerate", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(643, "Reshiram", PokemonData.Type.DRAGON, PokemonData.Type.FIRE, "Turboblaze", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 3.2f, 330f,
    306, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.WHITE, 0,
    "Vast White", "This legendary Pokémon can scorch the world withfire. It helps those who want to build a worldof truth.",
    100, 120, 100, 150, 120, 90, 0, Color.clear,
    new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50, 54, 71, 78, 85, 100},
    new string[]
    {
         "Dragon Rage", "Fire Fang", "Imprison", "Ancient Power", "Flamethrower", "Dragon Breath", "Slash", "Extrasensory", "Fusion Flare", "Dragon Pulse", "Crunch", "Fire Blast", "Outrage", "Blue Flare",
    },
    new string[]
    {
         "Cut", "Fly", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Overheat", "Rock_Tomb", "Dragon_Claw", "Roost", "Payback", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Hone_Claws", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(644, "Zekrom", PokemonData.Type.DRAGON, PokemonData.Type.ELECTRIC, "Teravolt", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 2.9f, 345f,
    306, PokemonData.LevelingRate.SLOW, 0, 3, 0, 0, 0, 0, PokemonData.PokedexColor.BLACK, 0,
    "Deep Black", "This legendary Pokémon can scorch the world withlightning. It assists those who want to build anideal world.",
    100, 150, 120, 120, 100, 90, 0, Color.clear,
    new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50, 54, 71, 78, 85, 100},
    new string[]
    {
         "Dragon Rage", "Thunder Fang", "Imprison", "Ancient Power", "Thunderbolt", "Dragon Breath", "Slash", "Zen Headbutt", "Fusion Bolt", "Dragon Claw", "Crunch", "Thunder", "Outrage", "Bolt Strike",
    },
    new string[]
    {
         "Cut", "Fly", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Rock_Smash", "Facade", "Rock_Tomb", "Dragon_Claw", "Roost", "Payback", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Stone_Edge", "Charge_Beam", "Hone_Claws", "Round", "Echoed_Voice", "Volt_Switch", "Dragon_Tail", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(645, "Landorus-incarnate", PokemonData.Type.GROUND, PokemonData.Type.FLYING, "Sand-force", null, "Sheer-force",
    100f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.5f, 68f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BROWN, 90,
    "Abundance", "Lands visited by Landorus grant such bountifulcrops that it has been hailed as “The Guardian ofthe Fields. ",
    89, 125, 90, 115, 80, 101, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 7, 19, 25, 31, 37, 43, 55, 73},
    new string[]
    {
         "Fissure", "Outrage", "Rock Tomb", "Block", "Mud Shot", "Hammer Arm", "Imprison", "Bulldoze", "Rock Throw", "Extrasensory", "Swords Dance", "Earth Power", "Earthquake", "Stone Edge",
    },
    new string[]
    {
         "Swords_Dance", "Fly", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Bulk_Up", "Calm_Mind", "U_turn", "Payback", "Fling", "Rock_Polish", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Smack_Down", "Sludge_Wave", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(646, "Kyurem", PokemonData.Type.DRAGON, PokemonData.Type.ICE, "Pressure", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 3f, 325f,
    297, PokemonData.LevelingRate.SLOW, 1, 1, 0, 1, 0, 0, PokemonData.PokedexColor.GRAY, 0,
    "Boundary", "This legendary ice Pokémon waits for a hero to fillin the missing parts of its body with truth or ideals.",
    125, 130, 90, 130, 90, 95, 0, Color.clear,
    new int[] { 1, 1, 8, 15, 22, 29, 36, 43, 50, 57, 71, 78, 85},
    new string[]
    {
         "Dragon Rage", "Icy Wind", "Imprison", "Ancient Power", "Ice Beam", "Dragon Breath", "Slash", "Scary Face", "Glaciate", "Dragon Pulse", "Endeavor", "Blizzard", "Outrage",
    },
    new string[]
    {
         "Cut", "Fly", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Dragon_Claw", "Roost", "Payback", "Fling", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Stone_Edge", "Hone_Claws", "Round", "Echoed_Voice", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(647, "Keldeo-ordinary", PokemonData.Type.WATER, PokemonData.Type.FIGHTING, "Justified", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.4f, 48.5f,
    261, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.YELLOW, 35,
    "Colt", "It crosses the world, running over the surfaces ofoceans and rivers. It appears at scenic waterfronts.",
    91, 72, 90, 129, 90, 108, 0, Color.clear,
    new int[] { 1, 1, 7, 13, 19, 25, 31, 37, 43, 49, 55, 61, 67, 73},
    new string[]
    {
         "Leer", "Aqua Jet", "Double Kick", "Bubble Beam", "Take Down", "Helping Hand", "Retaliate", "Aqua Tail", "Sacred Sword", "Swords Dance", "Quick Guard", "Work Up", "Hydro Pump", "Close Combat",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Surf", "Hyper_Beam", "Strength", "Toxic", "Double_Team", "Reflect", "Rest", "Substitute", "Protect", "False_Swipe", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Hail", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Poison_Jab", "X_Scissor", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Round", "Scald", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(648, "Meloetta-aria", PokemonData.Type.NORMAL, PokemonData.Type.PSYCHIC, "Serene-grace", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.6f, 6.5f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 1, 1, PokemonData.PokedexColor.WHITE, 100,
    "Melody", "The melodies sung by Meloetta have the power tomake Pokémon that hear them happy or sad.",
    100, 77, 77, 128, 128, 90, 0, Color.clear,
    new int[] { 1, 6, 11, 16, 21, 26, 31, 36, 43, 50, 57, 64, 71, 78, 85},
    new string[]
    {
         "Round", "Quick Attack", "Confusion", "Sing", "Teeter Dance", "Acrobatics", "Psybeam", "Echoed Voice", "U-turn", "Wake-Up Slap", "Psychic", "Hyper Voice", "Role Play", "Close Combat", "Perish Song",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Calm_Mind", "U_turn", "Payback", "Embargo", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Trick_Room", "Stone_Edge", "Grass_Knot", "Charge_Beam", "Hone_Claws", "Psyshock", "Low_Sweep", "Round", "Echoed_Voice", "Acrobatics", "Retaliate", "Confide", "Dazzling_Gleam", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(649, "Genesect", PokemonData.Type.BUG, PokemonData.Type.STEEL, "Download", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.5f, 82.5f,
    270, PokemonData.LevelingRate.SLOW, 0, 1, 0, 1, 0, 1, PokemonData.PokedexColor.PURPLE, 0,
    "Paleozoic", "This ancient bug Pokémon was altered by TeamPlasma. They upgraded the cannon on its back.",
    71, 120, 95, 120, 95, 99, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 7, 11, 18, 22, 29, 33, 40, 44, 51, 55, 62, 66, 73, 77},
    new string[]
    {
         "Quick Attack", "Screech", "Metal Claw", "Magnet Rise", "Techno Blast", "Fell Stinger", "Fury Cutter", "Lock-On", "Flame Charge", "Magnet Bomb", "Slash", "Metal Sound", "Signal Beam", "Tri Attack", "X-Scissor", "Bug Buzz", "Simple Beam", "Zap Cannon", "Hyper Beam", "Self-Destruct",
    },
    new string[]
    {
         "Fly", "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Solar_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Explosion", "Rest", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Facade", "Aerial_Ace", "U_turn", "Rock_Polish", "Dark_Pulse", "X_Scissor", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Charge_Beam", "Hone_Claws", "Flame_Charge", "Round", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(650, "Chespin", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Bulletproof",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 9f,
    63, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Spiny Nut", "The quills on its head are usually soft. When it flexes them, the points becomeso hard and sharp that they can pierce rock.",
    56, 61, 65, 48, 45, 38, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 11, 15, 18, 27, 32, 35, 39, 42, 45, 48},
    new string[]
    {
         "Tackle", "Growl", "Vine Whip", "Rollout", "Bite", "Leech Seed", "Pin Missile", "Take Down", "Seed Bomb", "Mud Shot", "Bulk Up", "Body Slam", "Pain Split", "Wood Hammer",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Gyro_Ball", "Payback", "Fling", "Poison_Jab", "Energy_Ball", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Smack_Down", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {651}, new string[] {"Level,16"}),


new PokemonData(651, "Quilladin", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Overgrow", null, "Bulletproof",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.7f, 29f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Spiny Armor", "It relies on its sturdy shell to deflect predators’attacks. It counterattacks with its sharp quills.",
    61, 78, 95, 56, 58, 57, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 11, 15, 20, 26, 30, 35, 39, 44, 48, 52, 55},
    new string[]
    {
         "Tackle", "Growl", "Vine Whip", "Rollout", "Bite", "Leech Seed", "Pin Missile", "Needle Arm", "Take Down", "Seed Bomb", "Mud Shot", "Bulk Up", "Body Slam", "Pain Split", "Wood Hammer",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Gyro_Ball", "Payback", "Fling", "Poison_Jab", "Energy_Ball", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Smack_Down", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {652}, new string[] {"Level,36"}),


new PokemonData(652, "Chesnaught", PokemonData.Type.GRASS, PokemonData.Type.FIGHTING, "Overgrow", null, "Bulletproof",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.6f, 90f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 3, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Spiny Armor", "Its Tackle is forceful enough to flip a 50-ton tank. It shields its allies from danger with its own body.",
    88, 107, 122, 74, 75, 64, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 5, 8, 11, 15, 20, 26, 30, 35, 36, 41, 44, 48, 52, 55, 70},
    new string[]
    {
         "Tackle", "Growl", "Belly Drum", "Hammer Arm", "Vine Whip", "Rollout", "Bite", "Leech Seed", "Pin Missile", "Needle Arm", "Take Down", "Seed Bomb", "Spiky Shield", "Mud Shot", "Bulk Up", "Body Slam", "Pain Split", "Wood Hammer", "Giga Impact",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Reflect", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Gyro_Ball", "Payback", "Fling", "Poison_Jab", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Smack_Down", "Low_Sweep", "Round", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(653, "Fennekin", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Magician",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 9.4f,
    61, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Fox", "Eating a twig fills it with energy,and its roomy ears give vent to airhotter than 390 degrees Fahrenheit.",
    40, 45, 40, 62, 60, 60, 0, Color.clear,
    new int[] { 1, 1, 5, 11, 14, 17, 20, 25, 27, 31, 35, 38, 41, 43, 46, 48},
    new string[]
    {
         "Scratch", "Tail Whip", "Ember", "Howl", "Flame Charge", "Psybeam", "Fire Spin", "Lucky Chant", "Light Screen", "Psyshock", "Flamethrower", "Will-O-Wisp", "Psychic", "Sunny Day", "Magic Room", "Fire Blast",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Will_O_Wisp", "Facade", "Overheat", "Embargo", "Grass_Knot", "Psyshock", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {654}, new string[] {"Level,16"}),


new PokemonData(654, "Braixen", PokemonData.Type.FIRE, PokemonData.Type.NONE, "Blaze", null, "Magician",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 14.5f,
    143, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Fox", "It has a twig stuck in its tail. Withfriction from its tail fur, it sets thetwig on fire and launches into battle.",
    59, 59, 58, 90, 70, 73, 0, Color.clear,
    new int[] { 1, 1, 5, 11, 14, 18, 22, 27, 30, 34, 41, 45, 48, 51, 53, 55},
    new string[]
    {
         "Scratch", "Tail Whip", "Ember", "Howl", "Flame Charge", "Psybeam", "Fire Spin", "Lucky Chant", "Light Screen", "Psyshock", "Flamethrower", "Will-O-Wisp", "Psychic", "Sunny Day", "Magic Room", "Fire Blast",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Will_O_Wisp", "Facade", "Overheat", "Embargo", "Grass_Knot", "Psyshock", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {655}, new string[] {"Level,36"}),


new PokemonData(655, "Delphox", PokemonData.Type.FIRE, PokemonData.Type.PSYCHIC, "Blaze", null, "Magician",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.5f, 39f,
    240, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Fox", "It gazes into the flame at the tip ofits branch to achieve a focused state,which allows it to see into the future.",
    75, 69, 72, 114, 100, 104, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 11, 14, 18, 22, 27, 30, 34, 36, 42, 51, 55, 58, 61},
    new string[]
    {
         "Scratch", "Tail Whip", "Shadow Ball", "Future Sight", "Role Play", "Switcheroo", "Ember", "Howl", "Flame Charge", "Psybeam", "Fire Spin", "Lucky Chant", "Light Screen", "Psyshock", "Mystical Fire", "Flamethrower", "Psychic", "Sunny Day", "Magic Room", "Fire Blast",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Will_O_Wisp", "Facade", "Overheat", "Calm_Mind", "Embargo", "Giga_Impact", "Trick_Room", "Grass_Knot", "Psyshock", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(656, "Froakie", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Protean",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.3f, 7f,
    63, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BLUE, 70,
    "Bubble Frog", "It secretes flexible bubbles from its chest and back. The bubbles reduce the damage it would otherwisetake when attacked.",
    41, 56, 40, 62, 44, 71, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 10, 14, 18, 21, 25, 29, 35, 39, 43, 48},
    new string[]
    {
         "Pound", "Growl", "Bubble", "Quick Attack", "Lick", "Water Pulse", "Smokescreen", "Round", "Fling", "Smack Down", "Substitute", "Bounce", "Double Team", "Hydro Pump",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "U_turn", "Fling", "Grass_Knot", "Smack_Down", "Round", "Echoed_Voice", "Scald", "Acrobatics", "Confide", "Power_Up_Punch"
    },
    new int[] {657}, new string[] {"Level,16"}),


new PokemonData(657, "Frogadier", PokemonData.Type.WATER, PokemonData.Type.NONE, "Torrent", null, "Protean",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.6f, 10.9f,
    142, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
    "Bubble Frog", "It can throw bubble-covered pebbles with precisecontrol, hitting empty cans up to a hundred feet away.",
    54, 63, 52, 83, 56, 97, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 10, 14, 20, 23, 28, 33, 38, 44, 48, 55},
    new string[]
    {
         "Pound", "Growl", "Bubble", "Quick Attack", "Lick", "Water Pulse", "Smokescreen", "Round", "Fling", "Smack Down", "Substitute", "Bounce", "Double Team", "Hydro Pump",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "U_turn", "Fling", "Dark_Pulse", "Grass_Knot", "Smack_Down", "Round", "Echoed_Voice", "Scald", "Acrobatics", "Confide", "Power_Up_Punch"
    },
    new int[] {658}, new string[] {"Level,36"}),


new PokemonData(658, "Greninja", PokemonData.Type.WATER, PokemonData.Type.DARK, "Torrent", null, "Protean",
    87.5f, 45, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.5f, 40f,
    239, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.BLUE, 70,
    "Ninja", "It creates throwing stars out of compressed water. When it spins them and throws them at high speed,these stars can split metal in two.",
    72, 95, 67, 103, 71, 122, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 8, 10, 14, 20, 28, 33, 36, 43, 49, 52, 56, 60},
    new string[]
    {
         "Pound", "Growl", "Role Play", "Night Slash", "Mat Block", "Bubble", "Quick Attack", "Lick", "Water Pulse", "Smokescreen", "Spikes", "Feint Attack", "Water Shuriken", "Substitute", "Extrasensory", "Double Team", "Haze", "Hydro Pump",
    },
    new string[]
    {
         "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Dig", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Taunt", "Rock_Tomb", "Aerial_Ace", "U_turn", "Fling", "Dark_Pulse", "Giga_Impact", "Grass_Knot", "Smack_Down", "Round", "Echoed_Voice", "Scald", "Acrobatics", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(659, "Bunnelby", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Pickup", "Cheek-pouch", "Huge-power",
    50f, 255, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.4f, 5f,
    47, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.BROWN, 70,
    "Digging", "They use their large ears to dig burrows. They will dig the whole night through.",
    38, 36, 38, 32, 36, 57, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 10, 13, 15, 18, 20, 25, 29, 33, 38, 42, 47, 49},
    new string[]
    {
         "Tackle", "Leer", "Agility", "Quick Attack", "Double Slap", "Mud-Slap", "Take Down", "Mud Shot", "Double Kick", "Odor Sleuth", "Flail", "Dig", "Bounce", "Super Fang", "Facade", "Earthquake",
    },
    new string[]
    {
         "Cut", "Surf", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Bulk_Up", "U_turn", "Payback", "Fling", "Stone_Edge", "Grass_Knot", "Smack_Down", "Round", "Bulldoze", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {660}, new string[] {"Level,20"}),


new PokemonData(660, "Diggersby", PokemonData.Type.NORMAL, PokemonData.Type.GROUND, "Pickup", "Cheek-pouch", "Huge-power",
    50f, 127, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 42.4f,
    148, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Digging", "With their powerful ears, they can heftboulders of a ton or more with ease. They can be a big help at construction sites.",
    85, 56, 77, 50, 77, 78, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 7, 13, 15, 18, 20, 26, 31, 37, 42, 48, 53, 57},
    new string[]
    {
         "Swords Dance", "Tackle", "Leer", "Agility", "Hammer Arm", "Rototiller", "Quick Attack", "Mud-Slap", "Take Down", "Mud Shot", "Double Kick", "Odor Sleuth", "Flail", "Dig", "Bounce", "Super Fang", "Facade", "Earthquake",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Brick_Break", "Rock_Tomb", "Bulk_Up", "U_turn", "Payback", "Fling", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Smack_Down", "Round", "Bulldoze", "Wild_Charge", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(661, "Fletchling", PokemonData.Type.NORMAL, PokemonData.Type.FLYING, "Big-pecks", null, "Gale-wings",
    50f, 255, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.3f, 1.7f,
    56, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.RED, 70,
    "Tiny Robin", "These friendly Pokémon send signalsto one another with beautiful chirpsand tail-feather movements.",
    45, 50, 43, 40, 38, 62, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 13, 16, 21, 25, 29, 34, 39, 41, 45, 48},
    new string[]
    {
         "Tackle", "Growl", "Quick Attack", "Peck", "Agility", "Flail", "Roost", "Razor Wind", "Natural Gift", "Flame Charge", "Acrobatics", "Me First", "Tailwind", "Steel Wing",
    },
    new string[]
    {
         "Swords_Dance", "Fly", "Toxic", "Double_Team", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Facade", "Taunt", "Overheat", "Aerial_Ace", "Roost", "U_turn", "Flame_Charge", "Round", "Acrobatics", "Confide"
    },
    new int[] {662}, new string[] {"Level,17"}),


new PokemonData(662, "Fletchinder", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Flame-body", null, "Gale-wings",
    50f, 120, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.7f, 16f,
    134, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.RED, 70,
    "Ember", "From its beak, it expels embers that setthe tall grass on fire. Then it pounces onthe bewildered prey that pop out of the grass.",
    62, 73, 55, 56, 52, 84, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 13, 16, 17, 25, 27, 31, 38, 42, 46, 51, 55},
    new string[]
    {
         "Tackle", "Growl", "Quick Attack", "Peck", "Agility", "Flail", "Ember", "Roost", "Razor Wind", "Natural Gift", "Flame Charge", "Acrobatics", "Me First", "Tailwind", "Steel Wing",
    },
    new string[]
    {
         "Swords_Dance", "Fly", "Flamethrower", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Aerial_Ace", "Roost", "U_turn", "Flame_Charge", "Round", "Incinerate", "Acrobatics", "Confide"
    },
    new int[] {663}, new string[] {"Level,35"}),


new PokemonData(663, "Talonflame", PokemonData.Type.FIRE, PokemonData.Type.FLYING, "Flame-body", null, "Gale-wings",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.2f, 24.5f,
    175, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 0, 0, 3, PokemonData.PokedexColor.RED, 70,
    "Scorching", "In the fever of an exciting battle, itshowers embers from the gaps betweenits feathers and takes to the air.",
    78, 81, 71, 74, 69, 126, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 10, 13, 16, 17, 25, 27, 31, 44, 49, 55, 60},
    new string[]
    {
         "Tackle", "Growl", "Flare Blitz", "Brave Bird", "Quick Attack", "Peck", "Agility", "Flail", "Ember", "Roost", "Razor Wind", "Natural Gift", "Acrobatics", "Me First", "Tailwind", "Steel Wing",
    },
    new string[]
    {
         "Swords_Dance", "Fly", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Aerial_Ace", "Bulk_Up", "Roost", "U_turn", "Giga_Impact", "Hone_Claws", "Flame_Charge", "Round", "Incinerate", "Acrobatics", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(664, "Scatterbug", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shield-dust", "Compound-eyes", "Friend-guard",
    50f, 255, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 2.5f,
    40, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Scatterdust", "When under attack from bird Pokémon,it spews a poisonous black powderthat causes paralysis on contact.",
    38, 35, 40, 27, 25, 35, 0, Color.clear,
    new int[] { 1, 1, 6, 15},
    new string[]
    {
         "Tackle", "String Shot", "Stun Spore", "Bug Bite",
    },
    new string[]
    {

    },
    new int[] {665}, new string[] {"Level,9"}),


new PokemonData(665, "Spewpa", PokemonData.Type.BUG, PokemonData.Type.NONE, "Shed-skin", null, "Friend-guard",
    50f, 120, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 0.3f, 8.4f,
    75, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BLACK, 70,
    "Scatterdust", "It lives hidden within thicket shadows. When predators attack, it quickly bristles the furcovering its body in an effort to threaten them.",
    45, 22, 60, 27, 30, 29, 0, Color.clear,
    new int[] { 1, 9},
    new string[]
    {
         "Harden", "Protect",
    },
    new string[]
    {
         "Protect"
    },
    new int[] {666}, new string[] {"Level,12"}),


new PokemonData(666, "Vivillon", PokemonData.Type.BUG, PokemonData.Type.FLYING, "Shield-dust", "Compound-eyes", "Friend-guard",
    50f, 45, PokemonData.EggGroup.BUG, PokemonData.EggGroup.BUG, 0, 1.2f, 17f,
    185, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 1, 0, 1, PokemonData.PokedexColor.WHITE, 70,
    "Scale", "Vivillon with many different patterns arefound all over the world. These patternsare affected by the climate of their habitat.",
    80, 52, 50, 90, 50, 89, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 12, 17, 21, 25, 31, 35, 41, 45, 50},
    new string[]
    {
         "Gust", "Poison Powder", "Stun Spore", "Sleep Powder", "Light Screen", "Powder", "Struggle Bug", "Psybeam", "Supersonic", "Draining Kiss", "Aromatherapy", "Bug Buzz", "Safeguard", "Quiver Dance", "Hurricane",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Facade", "Aerial_Ace", "Calm_Mind", "Roost", "U_turn", "Energy_Ball", "Giga_Impact", "Round", "Acrobatics", "Struggle_Bug", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(667, "Litleo", PokemonData.Type.FIRE, PokemonData.Type.NORMAL, "Rivalry", "Unnerve", "Moxie",
    12.5f, 220, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 13.5f,
    74, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Lion Cub", "The stronger the opponent it faces,the more heat surges from its maneand the more power flows through its body.",
    62, 50, 58, 73, 54, 72, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 11, 15, 20, 23, 28, 33, 36, 39, 43, 46, 50},
    new string[]
    {
         "Tackle", "Leer", "Ember", "Work Up", "Headbutt", "Noble Roar", "Take Down", "Fire Fang", "Endeavor", "Echoed Voice", "Flamethrower", "Crunch", "Hyper Voice", "Incinerate", "Overheat",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Payback", "Dark_Pulse", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {668}, new string[] {"Level,35"}),


new PokemonData(668, "Pyroar", PokemonData.Type.FIRE, PokemonData.Type.NORMAL, "Rivalry", "Unnerve", "Moxie",
    12.5f, 65, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 1.5f, 81.5f,
    177, PokemonData.LevelingRate.MEDIUMSLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Royal", "The male with the largest mane of fireis the leader of the pride.",
    86, 68, 72, 109, 66, 106, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 8, 11, 15, 20, 23, 28, 33, 38, 42, 48, 51, 57},
    new string[]
    {
         "Tackle", "Leer", "Hyper Beam", "Ember", "Work Up", "Headbutt", "Noble Roar", "Take Down", "Fire Fang", "Endeavor", "Echoed Voice", "Flamethrower", "Crunch", "Hyper Voice", "Incinerate", "Overheat",
    },
    new string[]
    {
         "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Taunt", "Overheat", "Payback", "Dark_Pulse", "Giga_Impact", "Flame_Charge", "Round", "Echoed_Voice", "Incinerate", "Retaliate", "Bulldoze", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(669, "Flabebe", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Flower-veil", null, "Symbiosis",
    0f, 225, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.1f, 0.1f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.WHITE, 70,
    "Single Bloom", "It draws out and controls the hidden powerof flowers. The flower Flabébé holdsis most likely part of its body.",
    44, 38, 39, 61, 79, 42, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 20, 22, 24, 28, 33, 37, 41, 45, 48},
    new string[]
    {
         "Vine Whip", "Tackle", "Fairy Wind", "Lucky Chant", "Razor Leaf", "Wish", "Magical Leaf", "Grassy Terrain", "Petal Blizzard", "Aromatherapy", "Misty Terrain", "Moonblast", "Petal Dance", "Solar Beam",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Nature_Power", "Calm_Mind", "Energy_Ball", "Grass_Knot", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {670}, new string[] {"Level,19"}),


new PokemonData(670, "Floette", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Flower-veil", null, "Symbiosis",
    0f, 120, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.2f, 0.9f,
    130, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.WHITE, 70,
    "Single Bloom", "It flutters around fields of flowers and cares forflowers that are starting to wilt. It drawsout the hidden power of flowers to battle.",
    54, 45, 47, 75, 98, 52, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 15, 20, 25, 27, 33, 38, 43, 46, 51, 58},
    new string[]
    {
         "Vine Whip", "Tackle", "Fairy Wind", "Lucky Chant", "Razor Leaf", "Wish", "Magical Leaf", "Grassy Terrain", "Petal Blizzard", "Aromatherapy", "Misty Terrain", "Moonblast", "Petal Dance", "Solar Beam",
    },
    new string[]
    {
         "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Nature_Power", "Calm_Mind", "Energy_Ball", "Grass_Knot", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(671, "Florges", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Flower-veil", null, "Symbiosis",
    0f, 45, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 1.1f, 10f,
    248, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.WHITE, 70,
    "Garden", "It claims exquisite flower gardens as its territory,and it obtains power from basking in the energyemitted by flowering plants.",
    78, 65, 68, 112, 154, 75, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
    new string[]
    {
         "Petal Dance", "Wish", "Aromatherapy", "Magical Leaf", "Lucky Chant", "Grass Knot", "Petal Blizzard", "Disarming Voice", "Flower Shield", "Grassy Terrain", "Misty Terrain", "Moonblast",
    },
    new string[]
    {
         "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Nature_Power", "Calm_Mind", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(672, "Skiddo", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Sap-sipper", null, "Grass-pelt",
    50f, 200, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.9f, 31f,
    70, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Mount", "Thought to be one of the first Pokémon to live inharmony with humans, it has a placid disposition.",
    66, 65, 48, 62, 57, 52, 0, Color.clear,
    new int[] { 1, 1, 7, 9, 12, 13, 16, 20, 22, 26, 30, 34, 38, 42, 45, 50},
    new string[]
    {
         "Tackle", "Growth", "Vine Whip", "Tail Whip", "Leech Seed", "Razor Leaf", "Worry Seed", "Synthesis", "Take Down", "Bulldoze", "Seed Bomb", "Bulk Up", "Double-Edge", "Horn Leech", "Leaf Blade", "Milk Drink",
    },
    new string[]
    {
         "Roar", "Surf", "Strength", "Solar_Beam", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Bulk_Up", "Payback", "Energy_Ball", "Grass_Knot", "Round", "Retaliate", "Bulldoze", "Wild_Charge", "Confide"
    },
    new int[] {673}, new string[] {"Level,32"}),


new PokemonData(673, "Gogoat", PokemonData.Type.GRASS, PokemonData.Type.NONE, "Sap-sipper", null, "Grass-pelt",
    50f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.7f, 91f,
    186, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Mount", "It can tell how its Trainer is feeling bysubtle shifts in the grip on its horns. This empathic sense lets them run as if one being.",
    123, 100, 62, 97, 81, 68, 0, Color.clear,
    new int[] { 1, 1, 1, 7, 9, 12, 13, 16, 20, 22, 26, 30, 40, 47, 55, 58, 60},
    new string[]
    {
         "Tackle", "Growth", "Aerial Ace", "Vine Whip", "Tail Whip", "Leech Seed", "Razor Leaf", "Worry Seed", "Synthesis", "Take Down", "Bulldoze", "Seed Bomb", "Double-Edge", "Horn Leech", "Leaf Blade", "Milk Drink", "Earthquake",
    },
    new string[]
    {
         "Roar", "Surf", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "Nature_Power", "Brick_Break", "Aerial_Ace", "Bulk_Up", "Payback", "Energy_Ball", "Giga_Impact", "Grass_Knot", "Round", "Retaliate", "Bulldoze", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(674, "Pancham", PokemonData.Type.FIGHTING, PokemonData.Type.NONE, "Iron-fist", "Mold-breaker", "Scrappy",
    50f, 220, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.6f, 8f,
    70, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Playful", "It does its best to be taken seriously by its enemies,but its glare is not sufficiently intimidating. Chewing on a leaf is its trademark.",
    67, 82, 62, 46, 48, 43, 0, Color.clear,
    new int[] { 1, 1, 7, 10, 12, 15, 20, 25, 27, 33, 39, 42, 45, 48},
    new string[]
    {
         "Tackle", "Leer", "Arm Thrust", "Work Up", "Karate Chop", "Comet Punch", "Slash", "Circle Throw", "Vital Throw", "Body Slam", "Crunch", "Entrainment", "Parting Shot", "Sky Uppercut",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Surf", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Payback", "Fling", "Dark_Pulse", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Low_Sweep", "Round", "Echoed_Voice", "Retaliate", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {675}, new string[] {"Level,32"}),


new PokemonData(675, "Pangoro", PokemonData.Type.FIGHTING, PokemonData.Type.DARK, "Iron-fist", "Mold-breaker", "Scrappy",
    50f, 65, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 2.1f, 136f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Daunting", "Although it possesses a violent temperament,it won’t put up with bullying. It uses the leaf inits mouth to sense the movements of its enemies.",
    95, 124, 78, 69, 71, 58, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 7, 10, 12, 15, 20, 27, 35, 42, 48, 52, 65},
    new string[]
    {
         "Tackle", "Leer", "Hammer Arm", "Entrainment", "Arm Thrust", "Work Up", "Karate Chop", "Comet Punch", "Slash", "Vital Throw", "Body Slam", "Crunch", "Parting Shot", "Sky Uppercut", "Taunt",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Roar", "Surf", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Payback", "Embargo", "Fling", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Echoed_Voice", "Quash", "Retaliate", "Bulldoze", "Snarl", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(676, "Furfrou", PokemonData.Type.NORMAL, PokemonData.Type.NONE, "Fur-coat", null, null,
    50f, 160, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1.2f, 28f,
    165, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.WHITE, 70,
    "Poodle", "Trimming its fluffy fur not only makesit more elegant but also increases theswiftness of its movements.",
    75, 80, 60, 65, 90, 102, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 12, 15, 22, 27, 33, 35, 38, 42, 48},
    new string[]
    {
         "Tackle", "Growl", "Sand Attack", "Baby-Doll Eyes", "Headbutt", "Tail Whip", "Bite", "Odor Sleuth", "Retaliate", "Take Down", "Charm", "Sucker Punch", "Cotton Guard",
    },
    new string[]
    {
         "Roar", "Surf", "Thunder_Wave", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Facade", "U_turn", "Dark_Pulse", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Round", "Echoed_Voice", "Retaliate", "Wild_Charge", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(677, "Espurr", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Keen-eye", "Infiltrator", "Own-tempo",
    50f, 190, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.3f, 3.5f,
    71, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.GRAY, 70,
    "Restraint", "The organ that emits its intense psychic power issheltered by its ears to keep power from leaking out.",
    62, 48, 54, 63, 60, 68, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 17, 19, 22, 25},
    new string[]
    {
         "Scratch", "Leer", "Covet", "Confusion", "Light Screen", "Psybeam", "Fake Out", "Disarming Voice", "Psyshock",
    },
    new string[]
    {
         "Cut", "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Torment", "Facade", "Calm_Mind", "Payback", "Dark_Pulse", "Energy_Ball", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide"
    },
    new int[] {678}, new string[] {"Level,25"}),


new PokemonData(678, "Meowstic-male", PokemonData.Type.PSYCHIC, PokemonData.Type.NONE, "Keen-eye", "Infiltrator", "Prankster",
    50f, 75, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 257, 0.6f, 8.5f,
    163, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.BLUE, 70,
    "Constraint", "When in danger, it raises its ears andreleases enough psychic power togrind a 10-ton truck into dust.",
    74, 48, 76, 83, 81, 104, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 9, 13, 17, 19, 25, 28, 31, 35, 40, 43, 45, 48, 50},
    new string[]
    {
         "Scratch", "Leer", "Mean Look", "Helping Hand", "Quick Guard", "Covet", "Confusion", "Light Screen", "Psybeam", "Fake Out", "Psyshock", "Charm", "Miracle Eye", "Reflect", "Psychic", "Role Play", "Imprison", "Sucker Punch", "Misty Terrain",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Dig", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Calm_Mind", "Payback", "Dark_Pulse", "Energy_Ball", "Giga_Impact", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(679, "Honedge", PokemonData.Type.STEEL, PokemonData.Type.GHOST, "No-guard", null, null,
    50f, 180, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.8f, 2f,
    65, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Sword", "Apparently this Pokémon is born when adeparted spirit inhabits a sword. It attaches itselfto people and drinks their life force.",
    45, 80, 100, 35, 37, 28, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 13, 18, 20, 22, 26, 29, 32, 35, 39, 42, 47},
    new string[]
    {
         "Swords Dance", "Tackle", "Fury Cutter", "Metal Sound", "Pursuit", "Autotomize", "Shadow Sneak", "Aerial Ace", "Retaliate", "Slash", "Iron Defense", "Night Slash", "Power Trick", "Iron Head", "Sacred Sword",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Toxic", "Double_Team", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Gyro_Ball", "Shadow_Claw", "Flash_Cannon", "Retaliate", "Confide"
    },
    new int[] {680}, new string[] {"Level,35"}),


new PokemonData(680, "Doublade", PokemonData.Type.STEEL, PokemonData.Type.GHOST, "No-guard", null, null,
    50f, 90, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.8f, 4.5f,
    157, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Sword", "When Honedge evolves, it divides into two swords,which cooperate via telepathy to coordinate attacksand slash their enemies to ribbons.",
    59, 110, 150, 45, 49, 35, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 13, 18, 20, 22, 26, 29, 32, 36, 41, 45, 51},
    new string[]
    {
         "Swords Dance", "Tackle", "Fury Cutter", "Metal Sound", "Pursuit", "Autotomize", "Shadow Sneak", "Aerial Ace", "Retaliate", "Slash", "Iron Defense", "Night Slash", "Power Trick", "Iron Head", "Sacred Sword",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Toxic", "Double_Team", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Gyro_Ball", "Shadow_Claw", "Flash_Cannon", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(681, "Aegislash-shield", PokemonData.Type.STEEL, PokemonData.Type.GHOST, "Stance-change", null, null,
    50f, 45, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 1.7f, 53f,
    234, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 1, 0, PokemonData.PokedexColor.BROWN, 70,
    "Royal Sword", "Generations of kings were attended by thesePokémon, which used their spectral power tomanipulate and control people and Pokémon.",
    60, 50, 150, 50, 150, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
    new string[]
    {
         "Swords Dance", "Slash", "Fury Cutter", "Pursuit", "Aerial Ace", "Iron Defense", "Power Trick", "Night Slash", "Shadow Sneak", "Iron Head", "Head Smash", "Autotomize", "Sacred Sword", "King’s Shield",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Hyper_Beam", "Toxic", "Double_Team", "Reflect", "Rest", "Rock_Slide", "Substitute", "Protect", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Facade", "Brick_Break", "Aerial_Ace", "Gyro_Ball", "Giga_Impact", "Shadow_Claw", "Flash_Cannon", "Round", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(682, "Spritzee", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Healer", null, "Aroma-veil",
    50f, 200, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.2f, 0.5f,
    68, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Perfume", "It emits a scent that enraptures thosewho smell it. This fragrance changesdepending on what it has eaten.",
    78, 52, 60, 63, 65, 23, 0, Color.clear,
    new int[] { 1, 1, 6, 8, 13, 17, 21, 25, 29, 31, 35, 38, 42, 44, 48, 50},
    new string[]
    {
         "Sweet Scent", "Fairy Wind", "Sweet Kiss", "Odor Sleuth", "Echoed Voice", "Calm Mind", "Draining Kiss", "Aromatherapy", "Attract", "Moonblast", "Charm", "Flail", "Misty Terrain", "Skill Swap", "Psychic", "Disarming Voice",
    },
    new string[]
    {
         "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Torment", "Facade", "Calm_Mind", "Gyro_Ball", "Energy_Ball", "Flash_Cannon", "Trick_Room", "Charge_Beam", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(683, "Aromatisse", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Healer", null, "Aroma-veil",
    50f, 140, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.8f, 15.5f,
    162, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.PINK, 70,
    "Fragrance", "It devises various scents, pleasant and unpleasant,and emits scents that its enemies dislike in orderto gain an edge in battle.",
    101, 72, 72, 99, 89, 29, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 6, 8, 13, 17, 21, 25, 29, 31, 35, 38, 42, 44, 48, 53, 57, 64},
    new string[]
    {
         "Sweet Scent", "Heal Pulse", "Fairy Wind", "Aromatic Mist", "Sweet Kiss", "Odor Sleuth", "Echoed Voice", "Calm Mind", "Draining Kiss", "Aromatherapy", "Attract", "Moonblast", "Charm", "Flail", "Misty Terrain", "Skill Swap", "Psychic", "Disarming Voice", "Reflect", "Psych Up",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Torment", "Facade", "Calm_Mind", "Gyro_Ball", "Energy_Ball", "Giga_Impact", "Flash_Cannon", "Trick_Room", "Charge_Beam", "Psyshock", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(684, "Swirlix", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Sweet-veil", null, "Unburden",
    50f, 200, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.4f, 3.5f,
    68, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Cotton Candy", "To entangle its opponents in battle, it extrudeswhite threads as sweet and sticky as cotton candy.",
    62, 48, 66, 59, 57, 49, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 10, 13, 17, 21, 26, 31, 36, 41, 45, 49, 58, 67},
    new string[]
    {
         "Tackle", "Sweet Scent", "Fairy Wind", "Play Nice", "Fake Tears", "Round", "Cotton Spore", "Endeavor", "Aromatherapy", "Draining Kiss", "Energy Ball", "Cotton Guard", "Wish", "Play Rough", "Light Screen", "Safeguard",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Facade", "Calm_Mind", "Energy_Ball", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(685, "Slurpuff", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Sweet-veil", null, "Unburden",
    50f, 140, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.8f, 5f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.WHITE, 70,
    "Meringue", "It can distinguish the faintest of scents. It puts its sensitive sense of smell to useby helping pastry chefs in their work.",
    82, 80, 86, 85, 75, 72, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 10, 13, 17, 21, 26, 31, 36, 41, 45, 49, 58, 67},
    new string[]
    {
         "Tackle", "Sweet Scent", "Fairy Wind", "Play Nice", "Fake Tears", "Round", "Cotton Spore", "Endeavor", "Aromatherapy", "Draining Kiss", "Energy Ball", "Cotton Guard", "Wish", "Play Rough", "Light Screen", "Safeguard",
    },
    new string[]
    {
         "Flamethrower", "Surf", "Hyper_Beam", "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Facade", "Calm_Mind", "Energy_Ball", "Giga_Impact", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(686, "Inkay", PokemonData.Type.DARK, PokemonData.Type.PSYCHIC, "Contrary", "Suction-cups", "Infiltrator",
    50f, 190, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.4f, 3.5f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Revolving", "Opponents who stare at the flashing of thelight-emitting spots on its body becomedazed and lose their will to fight.",
    53, 54, 53, 37, 46, 45, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 8, 12, 13, 15, 18, 21, 23, 27, 31, 35, 39, 43, 46, 48},
    new string[]
    {
         "Tackle", "Peck", "Constrict", "Reflect", "Foul Play", "Swagger", "Psywave", "Topsy-Turvy", "Hypnosis", "Psybeam", "Switcheroo", "Payback", "Light Screen", "Pluck", "Psycho Cut", "Slash", "Night Slash", "Superpower",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Torment", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Payback", "Embargo", "Fling", "Dark_Pulse", "Trick_Room", "Round", "Retaliate", "Confide"
    },
    new int[] {687}, new string[] {"Level,30"}),


new PokemonData(687, "Malamar", PokemonData.Type.DARK, PokemonData.Type.PSYCHIC, "Contrary", "Suction-cups", "Infiltrator",
    50f, 80, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.5f, 47f,
    169, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Overturning", "It wields the most compelling hypnotic powersof any Pokémon, and it forces others to dowhatever it wants.",
    86, 92, 88, 68, 75, 73, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 4, 8, 12, 13, 15, 18, 21, 23, 27, 31, 39, 43, 46},
    new string[]
    {
         "Tackle", "Peck", "Constrict", "Reversal", "Superpower", "Reflect", "Foul Play", "Swagger", "Psywave", "Topsy-Turvy", "Hypnosis", "Psybeam", "Switcheroo", "Payback", "Light Screen", "Psycho Cut", "Slash", "Night Slash",
    },
    new string[]
    {
         "Cut", "Flamethrower", "Hyper_Beam", "Thunderbolt", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Torment", "Facade", "Taunt", "Aerial_Ace", "Calm_Mind", "Payback", "Embargo", "Fling", "Dark_Pulse", "Giga_Impact", "Trick_Room", "Psyshock", "Round", "Retaliate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(688, "Binacle", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Tough-claws", "Sniper", "Pickpocket",
    50f, 120, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 0.5f, 31f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Two-Handed", "Two Binacle live together on one rock. When they fight, one of them will moveto a different rock.",
    42, 52, 67, 39, 56, 50, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 7, 10, 13, 18, 20, 24, 28, 32, 37, 41, 45, 49},
    new string[]
    {
         "Scratch", "Sand Attack", "Shell Smash", "Water Gun", "Withdraw", "Fury Swipes", "Slash", "Mud-Slap", "Clamp", "Rock Polish", "Ancient Power", "Hone Claws", "Fury Cutter", "Night Slash", "Razor Shell", "Cross Chop",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Payback", "Embargo", "Fling", "Rock_Polish", "Poison_Jab", "X_Scissor", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Smack_Down", "Sludge_Wave", "Round", "Scald", "Bulldoze", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {689}, new string[] {"Level,39"}),


new PokemonData(689, "Barbaracle", PokemonData.Type.ROCK, PokemonData.Type.WATER, "Tough-claws", "Sniper", "Pickpocket",
    50f, 45, PokemonData.EggGroup.WATER3, PokemonData.EggGroup.WATER3, 0, 1.3f, 96f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Collective", "When they evolve, two Binacle multiply into seven. They fight with the power of seven Binacle.",
    72, 105, 115, 54, 86, 68, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 4, 7, 13, 18, 20, 24, 28, 37, 44, 48, 55},
    new string[]
    {
         "Scratch", "Sand Attack", "Skull Bash", "Stone Edge", "Shell Smash", "Water Gun", "Withdraw", "Slash", "Mud-Slap", "Clamp", "Rock Polish", "Ancient Power", "Fury Cutter", "Night Slash", "Razor Shell", "Cross Chop",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Sandstorm", "False_Swipe", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Torment", "Facade", "Nature_Power", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Bulk_Up", "Payback", "Embargo", "Fling", "Rock_Polish", "Poison_Jab", "X_Scissor", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Smack_Down", "Sludge_Wave", "Round", "Scald", "Bulldoze", "Confide", "Infestation", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(690, "Skrelp", PokemonData.Type.POISON, PokemonData.Type.WATER, "Poison-point", "Poison-touch", "Adaptability",
    50f, 225, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 7.3f,
    64, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.BROWN, 70,
    "Mock Kelp", "Camouflaged as rotten kelp, they sprayliquid poison on prey that approachesunawares and then finish it off.",
    50, 60, 60, 60, 60, 30, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 9, 12, 15, 19, 23, 25, 28, 32, 35, 38, 42, 49},
    new string[]
    {
         "Tackle", "Water Gun", "Smokescreen", "Feint Attack", "Tail Whip", "Bubble", "Acid", "Camouflage", "Poison Tail", "Water Pulse", "Double Team", "Toxic", "Aqua Tail", "Sludge Bomb", "Hydro Pump", "Dragon Pulse",
    },
    new string[]
    {
         "Surf", "Thunderbolt", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Facade", "Venoshock", "Sludge_Wave", "Round", "Scald", "Confide"
    },
    new int[] {691}, new string[] {"Level,48"}),


new PokemonData(691, "Dragalge", PokemonData.Type.POISON, PokemonData.Type.DRAGON, "Poison-point", "Poison-touch", "Adaptability",
    50f, 55, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.8f, 81.5f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.BROWN, 70,
    "Mock Kelp", "Their poison is strong enough to eat throughthe hull of a tanker, and they spit it indiscriminatelyat anything that enters their territory.",
    65, 75, 90, 97, 123, 44, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 5, 9, 12, 15, 23, 25, 28, 32, 35, 38, 42, 53},
    new string[]
    {
         "Tackle", "Water Gun", "Smokescreen", "Twister", "Dragon Tail", "Feint Attack", "Tail Whip", "Bubble", "Acid", "Poison Tail", "Water Pulse", "Double Team", "Toxic", "Aqua Tail", "Sludge Bomb", "Hydro Pump", "Dragon Pulse",
    },
    new string[]
    {
         "Surf", "Hyper_Beam", "Thunderbolt", "Thunder", "Toxic", "Double_Team", "Waterfall", "Rest", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Hail", "Facade", "Focus_Blast", "Giga_Impact", "Venoshock", "Sludge_Wave", "Round", "Scald", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(692, "Clauncher", PokemonData.Type.WATER, PokemonData.Type.NONE, "Mega-launcher", null, null,
    50f, 225, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 0.5f, 8.3f,
    66, PokemonData.LevelingRate.SLOW, 0, 0, 0, 1, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Water Gun", "They knock down flying prey by firingcompressed water from their massiveclaws like shooting a pistol.",
    50, 53, 62, 58, 63, 44, 0, Color.clear,
    new int[] { 1, 1, 7, 9, 12, 16, 20, 25, 30, 34, 39, 43, 48},
    new string[]
    {
         "Water Gun", "Splash", "Water Sport", "Vice Grip", "Bubble", "Flail", "Bubble Beam", "Swords Dance", "Crabhammer", "Water Pulse", "Smack Down", "Aqua Jet", "Muddy Water",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Facade", "U_turn", "Flash_Cannon", "Venoshock", "Smack_Down", "Sludge_Wave", "Round", "Scald", "Confide"
    },
    new int[] {693}, new string[] {"Level,37"}),


new PokemonData(693, "Clawitzer", PokemonData.Type.WATER, PokemonData.Type.NONE, "Mega-launcher", null, null,
    50f, 55, PokemonData.EggGroup.WATER1, PokemonData.EggGroup.WATER1, 0, 1.3f, 35.3f,
    100, PokemonData.LevelingRate.SLOW, 0, 0, 0, 2, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Howitzer", "Their enormous claws launch cannonballs ofwater powerful enough to pierce tanker hulls.",
    71, 73, 88, 120, 89, 59, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 7, 9, 12, 16, 20, 25, 30, 34, 42, 53, 57},
    new string[]
    {
         "Water Gun", "Splash", "Aura Sphere", "Dragon Pulse", "Heal Pulse", "Water Sport", "Vice Grip", "Bubble", "Flail", "Bubble Beam", "Swords Dance", "Crabhammer", "Water Pulse", "Smack Down", "Muddy Water", "Dark Pulse",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Surf", "Ice_Beam", "Hyper_Beam", "Toxic", "Double_Team", "Waterfall", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Shadow_Ball", "Facade", "U_turn", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Venoshock", "Smack_Down", "Sludge_Wave", "Round", "Scald", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(694, "Helioptile", PokemonData.Type.ELECTRIC, PokemonData.Type.NORMAL, "Dry-skin", "Sand-veil", "Solar-power",
    50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.5f, 6f,
    58, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Generator", "They make their home in deserts. They cangenerate their energy from basking in the sun,so eating food is not a requirement.",
    44, 38, 33, 61, 43, 70, 0, Color.clear,
    new int[] { 1, 1, 6, 11, 13, 17, 22, 25, 31, 35, 40, 45, 49},
    new string[]
    {
         "Pound", "Tail Whip", "Thunder Shock", "Charge", "Mud-Slap", "Quick Attack", "Razor Wind", "Parabolic Charge", "Thunder Wave", "Bulldoze", "Volt Switch", "Electrify", "Thunderbolt",
    },
    new string[]
    {
         "Cut", "Surf", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Facade", "Rock_Tomb", "U_turn", "Dark_Pulse", "Grass_Knot", "Charge_Beam", "Low_Sweep", "Round", "Volt_Switch", "Bulldoze", "Dragon_Tail", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(695, "Heliolisk", PokemonData.Type.ELECTRIC, PokemonData.Type.NORMAL, "Dry-skin", "Sand-veil", "Solar-power",
    50f, 75, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 21f,
    168, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 1, 0, 1, PokemonData.PokedexColor.YELLOW, 70,
    "Generator", "They flare their frills and generate energy. A single Heliolisk can generate sufficientelectricity to power a skyscraper.",
    62, 55, 52, 109, 94, 109, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 1},
    new string[]
    {
         "Razor Wind", "Thunder", "Quick Attack", "Charge", "Parabolic Charge", "Electrify", "Eerie Impulse",
    },
    new string[]
    {
         "Cut", "Surf", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Light_Screen", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Psych_Up", "Facade", "Rock_Tomb", "U_turn", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Low_Sweep", "Round", "Volt_Switch", "Bulldoze", "Dragon_Tail", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(696, "Tyrunt", PokemonData.Type.ROCK, PokemonData.Type.DRAGON, "Strong-jaw", null, "Sturdy",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 0.8f, 26f,
    72, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Royal Heir", "This Pokémon was restored from a fossil. If something happens that it doesn’t like,it throws a tantrum and runs wild.",
    58, 89, 77, 45, 45, 48, 0, Color.clear,
    new int[] { 1, 1, 6, 10, 12, 15, 17, 20, 26, 30, 34, 37, 40, 44, 49},
    new string[]
    {
         "Tackle", "Tail Whip", "Roar", "Stomp", "Bide", "Stealth Rock", "Bite", "Charm", "Ancient Power", "Dragon Tail", "Crunch", "Dragon Claw", "Thrash", "Earthquake", "Horn Drill",
    },
    new string[]
    {
         "Roar", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Rock_Polish", "Dark_Pulse", "Stone_Edge", "Hone_Claws", "Round", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {697}, new string[] {"Level,39"}),


new PokemonData(697, "Tyrantrum", PokemonData.Type.ROCK, PokemonData.Type.DRAGON, "Strong-jaw", null, "Rock-head",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.5f, 270f,
    182, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 70,
    "Despot", "Thanks to its gargantuan jaws, which could shredthick metal plates as if they were paper, it wasinvincible in the ancient world it once inhabited.",
    82, 121, 119, 69, 59, 71, 0, Color.clear,
    new int[] { 1, 1, 1, 6, 10, 12, 15, 17, 20, 26, 34, 37, 42, 47, 53, 68, 75},
    new string[]
    {
         "Tackle", "Tail Whip", "Head Smash", "Roar", "Stomp", "Bide", "Stealth Rock", "Bite", "Charm", "Ancient Power", "Crunch", "Dragon Claw", "Thrash", "Earthquake", "Horn Drill", "Rock Slide", "Giga Impact",
    },
    new string[]
    {
         "Roar", "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Dragon_Claw", "Rock_Polish", "Dark_Pulse", "Giga_Impact", "Stone_Edge", "Hone_Claws", "Round", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(698, "Amaura", PokemonData.Type.ROCK, PokemonData.Type.ICE, "Refrigerate", null, "Snow-warning",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1.3f, 25.2f,
    72, PokemonData.LevelingRate.MEDIUMFAST, 1, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Tundra", "This ancient Pokémon was restoredfrom part of its body that had beenfrozen in ice for over 100 million years.",
    77, 59, 50, 67, 63, 46, 0, Color.clear,
    new int[] { 1, 1, 5, 10, 13, 15, 18, 20, 26, 30, 34, 38, 41, 44, 47, 50, 57, 65},
    new string[]
    {
         "Growl", "Powder Snow", "Thunder Wave", "Rock Throw", "Icy Wind", "Take Down", "Mist", "Aurora Beam", "Ancient Power", "Round", "Avalanche", "Hail", "Nature Power", "Encore", "Light Screen", "Ice Beam", "Hyper Beam", "Blizzard",
    },
    new string[]
    {
         "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Hail", "Facade", "Nature_Power", "Rock_Tomb", "Calm_Mind", "Rock_Polish", "Dark_Pulse", "Flash_Cannon", "Stone_Edge", "Charge_Beam", "Round", "Echoed_Voice", "Bulldoze", "Frost_Breath", "Dragon_Tail", "Confide"
    },
    new int[] {699}, new string[] {"Level,39"}),


new PokemonData(699, "Aurorus", PokemonData.Type.ROCK, PokemonData.Type.ICE, "Refrigerate", null, "Snow-warning",
    87.5f, 45, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2.7f, 225f,
    104, PokemonData.LevelingRate.MEDIUMFAST, 2, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Tundra", "The diamond-shaped crystals on its bodyexpel air as cold as -240 degrees Fahrenheit,surrounding its enemies and encasing them in ice.",
    123, 77, 72, 99, 92, 58, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 10, 13, 15, 18, 20, 26, 30, 34, 38, 43, 46, 50, 56, 63, 74},
    new string[]
    {
         "Growl", "Powder Snow", "Freeze-Dry", "Thunder Wave", "Rock Throw", "Icy Wind", "Take Down", "Mist", "Aurora Beam", "Ancient Power", "Round", "Avalanche", "Hail", "Nature Power", "Encore", "Light Screen", "Ice Beam", "Hyper Beam", "Blizzard",
    },
    new string[]
    {
         "Roar", "Ice_Beam", "Blizzard", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Earthquake", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Psych_Up", "Rock_Smash", "Hail", "Facade", "Nature_Power", "Rock_Tomb", "Calm_Mind", "Rock_Polish", "Dark_Pulse", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Charge_Beam", "Round", "Echoed_Voice", "Bulldoze", "Frost_Breath", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(700, "Sylveon", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Cute-charm", null, "Pixilate",
    87.5f, 45, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 1f, 23.5f,
    184, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PINK, 70,
    "Intertwining", "It sends a soothing aura from itsribbonlike feelers to calm fights.",
    95, 65, 65, 110, 130, 60, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 5, 9, 13, 17, 20, 25, 29, 33, 37, 41, 45},
    new string[]
    {
         "Tackle", "Tail Whip", "Helping Hand", "Disarming Voice", "Sand Attack", "Fairy Wind", "Quick Attack", "Swift", "Draining Kiss", "Skill Swap", "Misty Terrain", "Light Screen", "Moonblast", "Last Resort", "Psych Up",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Dig", "Toxic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Facade", "Calm_Mind", "Giga_Impact", "Psyshock", "Round", "Echoed_Voice", "Retaliate", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(701, "Hawlucha", PokemonData.Type.FIGHTING, PokemonData.Type.FLYING, "Limber", "Unburden", "Mold-breaker",
    50f, 100, PokemonData.EggGroup.HUMANSHAPE, PokemonData.EggGroup.HUMANSHAPE, 0, 0.8f, 21.5f,
    175, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 70,
    "Wrestling", "Although its body is small, its proficientfighting skills enable it to keep up withbig bruisers like Machamp and Hariyama.",
    78, 92, 75, 74, 63, 118, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 55, 60},
    new string[]
    {
         "Tackle", "Detect", "Hone Claws", "Karate Chop", "Wing Attack", "Roost", "Aerial Ace", "Encore", "Fling", "Flying Press", "Bounce", "Endeavor", "Feather Dance", "High Jump Kick", "Sky Attack", "Sky Drop", "Swords Dance",
    },
    new string[]
    {
         "Swords_Dance", "Cut", "Fly", "Strength", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "False_Swipe", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Torment", "Facade", "Taunt", "Brick_Break", "Rock_Tomb", "Aerial_Ace", "Bulk_Up", "Roost", "U_turn", "Payback", "Fling", "Poison_Jab", "X_Scissor", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Hone_Claws", "Low_Sweep", "Round", "Sky_Drop", "Acrobatics", "Retaliate", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(702, "Dedenne", PokemonData.Type.ELECTRIC, PokemonData.Type.FAIRY, "Cheek-pouch", "Pickup", "Plus",
    50f, 180, PokemonData.EggGroup.GROUND, PokemonData.EggGroup.GROUND, 0, 0.2f, 2.2f,
    151, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.YELLOW, 70,
    "Antenna", "Its whiskers serve as antennas. By sending andreceiving electrical waves, it can communicatewith others over vast distances.",
    67, 58, 57, 81, 67, 101, 0, Color.clear,
    new int[] { 1, 1, 7, 11, 14, 17, 20, 23, 26, 30, 31, 34, 39, 42, 45, 50},
    new string[]
    {
         "Tackle", "Tail Whip", "Thunder Shock", "Charge", "Charm", "Parabolic Charge", "Nuzzle", "Thunder Wave", "Volt Switch", "Rest", "Snore", "Charge Beam", "Entrainment", "Play Rough", "Thunder", "Discharge",
    },
    new string[]
    {
         "Cut", "Thunderbolt", "Thunder_Wave", "Thunder", "Dig", "Toxic", "Double_Team", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Aerial_Ace", "U_turn", "Fling", "Giga_Impact", "Grass_Knot", "Charge_Beam", "Round", "Retaliate", "Volt_Switch", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(703, "Carbink", PokemonData.Type.ROCK, PokemonData.Type.FAIRY, "Clear-body", null, "Sturdy",
    112.5f, 60, PokemonData.EggGroup.FAIRY, PokemonData.EggGroup.FAIRY, 0, 0.3f, 5.7f,
    100, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 1, 0, PokemonData.PokedexColor.GRAY, 70,
    "Jewel", "Born from the temperatures and pressuresdeep underground, it fires beams from thestone in its head.",
    50, 50, 150, 50, 150, 50, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 18, 21, 27, 31, 35, 40, 46, 49, 50, 60, 70},
    new string[]
    {
         "Tackle", "Harden", "Rock Throw", "Sharpen", "Smack Down", "Reflect", "Stealth Rock", "Guard Split", "Ancient Power", "Flail", "Skill Swap", "Power Gem", "Stone Edge", "Moonblast", "Light Screen", "Safeguard",
    },
    new string[]
    {
         "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Hail", "Facade", "Nature_Power", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Rock_Polish", "Trick_Room", "Stone_Edge", "Smack_Down", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(704, "Goomy", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Sap-sipper", "Hydration", "Gooey",
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 0.3f, 2.8f,
    60, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 1, 0, PokemonData.PokedexColor.PURPLE, 35,
    "Soft Tissue", "The weakest Dragon-type Pokémon,it lives in damp, shady places, so itsbody doesn’t dry out.",
    45, 50, 35, 55, 75, 40, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 18, 25, 28, 32, 38, 42},
    new string[]
    {
         "Tackle", "Bubble", "Absorb", "Protect", "Bide", "Dragon Breath", "Rain Dance", "Flail", "Body Slam", "Muddy Water", "Dragon Pulse",
    },
    new string[]
    {
         "Thunderbolt", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Sludge_Wave", "Round", "Confide", "Infestation"
    },
    new int[] {705}, new string[] {"Level,40"}),


new PokemonData(705, "Sliggoo", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Sap-sipper", "Hydration", "Gooey",
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 0.8f, 17.5f,
    158, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 2, 0, PokemonData.PokedexColor.PURPLE, 35,
    "Soft Tissue", "It drives away opponents by excreting asticky liquid that can dissolve anything. Its eyes devolved, so it can’t see anything.",
    68, 75, 53, 83, 113, 60, 0, Color.clear,
    new int[] { 1, 1, 5, 9, 13, 18, 25, 28, 32, 38, 47},
    new string[]
    {
         "Tackle", "Bubble", "Absorb", "Protect", "Bide", "Dragon Breath", "Rain Dance", "Flail", "Body Slam", "Muddy Water", "Dragon Pulse",
    },
    new string[]
    {
         "Ice_Beam", "Blizzard", "Thunderbolt", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Facade", "Sludge_Wave", "Round", "Confide", "Infestation"
    },
    new int[] {706}, new string[] {"Level,50"}),


new PokemonData(706, "Goodra", PokemonData.Type.DRAGON, PokemonData.Type.NONE, "Sap-sipper", "Hydration", "Gooey",
    50f, 45, PokemonData.EggGroup.DRAGON, PokemonData.EggGroup.DRAGON, 0, 2f, 150.5f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 0, 3, 0, PokemonData.PokedexColor.PURPLE, 35,
    "Dragon", "This very friendly Dragon-type Pokémonwill hug its beloved Trainer, leavingthat Trainer covered in sticky slime.",
    90, 100, 70, 110, 150, 80, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 5, 9, 13, 25, 28, 32, 38, 47, 50, 55},
    new string[]
    {
         "Tackle", "Bubble", "Outrage", "Feint", "Absorb", "Protect", "Bide", "Rain Dance", "Flail", "Body Slam", "Muddy Water", "Dragon Pulse", "Aqua Tail", "Power Whip",
    },
    new string[]
    {
         "Flamethrower", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Thunderbolt", "Thunder", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Rock_Smash", "Hail", "Facade", "Focus_Blast", "Giga_Impact", "Sludge_Wave", "Round", "Incinerate", "Bulldoze", "Dragon_Tail", "Confide", "Infestation"
    },
    new int[] {}, new string[] {}),


new PokemonData(707, "Klefki", PokemonData.Type.STEEL, PokemonData.Type.FAIRY, "Prankster", null, "Magician",
    50f, 75, PokemonData.EggGroup.MINERAL, PokemonData.EggGroup.MINERAL, 0, 0.2f, 3f,
    165, PokemonData.LevelingRate.FAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.GRAY, 70,
    "Key Ring", "These key collectors threaten any attackersby fiercely jingling their keys at them.",
    57, 80, 91, 80, 87, 75, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 15, 18, 23, 27, 32, 34, 36, 40, 43, 44, 50},
    new string[]
    {
         "Tackle", "Fairy Lock", "Fairy Wind", "Astonish", "Metal Sound", "Spikes", "Draining Kiss", "Crafty Shield", "Foul Play", "Torment", "Mirror Shot", "Imprison", "Recycle", "Play Rough", "Magic Room", "Heal Block",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Torment", "Facade", "Calm_Mind", "Giga_Impact", "Flash_Cannon", "Psyshock", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(708, "Phantump", PokemonData.Type.GHOST, PokemonData.Type.GRASS, "Natural-cure", "Frisk", "Harvest",
    50f, 120, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 0.4f, 7f,
    62, PokemonData.LevelingRate.MEDIUMFAST, 0, 1, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Stump", "These Pokémon are created whenspirits possess rotten tree stumps. They prefer to live in abandoned forests.",
    43, 70, 48, 50, 60, 38, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 13, 19, 23, 28, 31, 35, 39, 45, 49, 54},
    new string[]
    {
         "Tackle", "Confuse Ray", "Astonish", "Growth", "Ingrain", "Feint Attack", "Leech Seed", "Curse", "Will-O-Wisp", "Forest’s Curse", "Destiny Bond", "Phantom Force", "Wood Hammer", "Horn Leech",
    },
    new string[]
    {
         "Cut", "Strength", "Solar_Beam", "Dig", "Toxic", "Psychic", "Double_Team", "Reflect", "Dream_Eater", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Poison_Jab", "Dark_Pulse", "Energy_Ball", "Shadow_Claw", "Trick_Room", "Grass_Knot", "Round", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(709, "Trevenant", PokemonData.Type.GHOST, PokemonData.Type.GRASS, "Natural-cure", "Frisk", "Harvest",
    50f, 60, PokemonData.EggGroup.PLANT, PokemonData.EggGroup.PLANT, 0, 1.5f, 71f,
    166, PokemonData.LevelingRate.MEDIUMFAST, 0, 2, 0, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Elder Tree", "It can control trees at will. It will trap peoplewho harm the forest, so they can never leave.",
    85, 110, 76, 65, 82, 56, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 8, 13, 19, 23, 28, 31, 35, 39, 49, 55},
    new string[]
    {
         "Tackle", "Confuse Ray", "Horn Leech", "Astonish", "Growth", "Ingrain", "Feint Attack", "Leech Seed", "Curse", "Will-O-Wisp", "Forest’s Curse", "Destiny Bond", "Wood Hammer", "Shadow Claw",
    },
    new string[]
    {
         "Cut", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Dig", "Toxic", "Psychic", "Double_Team", "Reflect", "Dream_Eater", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Calm_Mind", "Poison_Jab", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Shadow_Claw", "Trick_Room", "Grass_Knot", "Hone_Claws", "Round", "Bulldoze", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(710, "Pumpkaboo-average", PokemonData.Type.GHOST, PokemonData.Type.GRASS, "Pickup", "Frisk", "Insomnia",
    50f, 120, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.4f, 5f,
    67, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Pumpkin", "The pumpkin body is inhabited by a spirittrapped in this world. As the sun sets,it becomes restless and active.",
    49, 66, 70, 44, 55, 51, 0, Color.clear,
    new int[] { 1, 1, 1, 4, 6, 11, 16, 20, 26, 30, 36, 42, 48},
    new string[]
    {
         "Confuse Ray", "Trick", "Astonish", "Scary Face", "Trick-or-Treat", "Worry Seed", "Razor Leaf", "Leech Seed", "Bullet Seed", "Shadow Sneak", "Shadow Ball", "Pain Split", "Seed Bomb",
    },
    new string[]
    {
         "Flamethrower", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Gyro_Ball", "Dark_Pulse", "Energy_Ball", "Trick_Room", "Grass_Knot", "Charge_Beam", "Flame_Charge", "Round", "Incinerate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(711, "Gourgeist-average", PokemonData.Type.GHOST, PokemonData.Type.GRASS, "Pickup", "Frisk", "Insomnia",
    50f, 60, PokemonData.EggGroup.INDETERMINATE, PokemonData.EggGroup.INDETERMINATE, 0, 0.9f, 12.5f,
    173, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BROWN, 70,
    "Pumpkin", "Singing in eerie voices, they wandertown streets on the night of the new moon. Anyone who hears their song is cursed.",
    65, 90, 122, 58, 75, 84, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 11, 16, 20, 23, 26, 30, 36, 42, 48},
    new string[]
    {
         "Confuse Ray", "Explosion", "Astonish", "Phantom Force", "Worry Seed", "Razor Leaf", "Leech Seed", "Trick-or-Treat", "Bullet Seed", "Shadow Sneak", "Shadow Ball", "Pain Split", "Seed Bomb",
    },
    new string[]
    {
         "Flamethrower", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Fire_Blast", "Dream_Eater", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Sludge_Bomb", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Rock_Smash", "Will_O_Wisp", "Facade", "Nature_Power", "Gyro_Ball", "Dark_Pulse", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Flame_Charge", "Round", "Incinerate", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(712, "Bergmite", PokemonData.Type.ICE, PokemonData.Type.NONE, "Own-tempo", "Ice-body", "Sturdy",
    50f, 190, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 1f, 99.5f,
    61, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 1, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Ice Chunk", "It blocks opponents’ attacks with theice that shields its body. It uses cold airto repair any cracks with new ice.",
    55, 69, 85, 32, 35, 28, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 10, 15, 20, 22, 26, 30, 35, 39, 43, 47, 49},
    new string[]
    {
         "Tackle", "Bite", "Harden", "Powder Snow", "Icy Wind", "Take Down", "Sharpen", "Curse", "Ice Fang", "Ice Ball", "Rapid Spin", "Avalanche", "Blizzard", "Recover", "Double-Edge",
    },
    new string[]
    {
         "Surf", "Ice_Beam", "Blizzard", "Strength", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Gyro_Ball", "Rock_Polish", "Flash_Cannon", "Stone_Edge", "Round", "Frost_Breath", "Confide"
    },
    new int[] {713}, new string[] {"Level,37"}),


new PokemonData(713, "Avalugg", PokemonData.Type.ICE, PokemonData.Type.NONE, "Own-tempo", "Ice-body", "Sturdy",
    50f, 55, PokemonData.EggGroup.MONSTER, PokemonData.EggGroup.MONSTER, 0, 2f, 505f,
    180, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 2, 0, 0, 0, PokemonData.PokedexColor.BLUE, 70,
    "Iceberg", "Its ice-covered body is as hard as steel. Its cumbersome frame crushes anything thatstands in its way.",
    95, 117, 184, 44, 46, 28, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 10, 15, 22, 26, 35, 42, 46, 51, 56},
    new string[]
    {
         "Tackle", "Bite", "Harden", "Skull Bash", "Crunch", "Iron Defense", "Powder Snow", "Icy Wind", "Take Down", "Curse", "Ice Fang", "Rapid Spin", "Avalanche", "Blizzard", "Recover", "Double-Edge",
    },
    new string[]
    {
         "Roar", "Surf", "Ice_Beam", "Blizzard", "Hyper_Beam", "Strength", "Earthquake", "Toxic", "Double_Team", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Attract", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Rock_Smash", "Hail", "Facade", "Rock_Tomb", "Gyro_Ball", "Rock_Polish", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Round", "Bulldoze", "Frost_Breath", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(714, "Noibat", PokemonData.Type.FLYING, PokemonData.Type.DRAGON, "Frisk", "Infiltrator", "Telepathy",
    50f, 190, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 0.5f, 8f,
    49, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 1, PokemonData.PokedexColor.PURPLE, 70,
    "Sound Wave", "They live in pitch-black caves. Their enormous earscan emit ultrasonic waves of 200,000 hertz.",
    40, 30, 35, 45, 40, 55, 0, Color.clear,
    new int[] { 1, 1, 1, 5, 11, 13, 16, 18, 23, 27, 31, 35, 40, 43, 48, 58},
    new string[]
    {
         "Tackle", "Supersonic", "Screech", "Leech Life", "Gust", "Bite", "Wing Attack", "Agility", "Air Cutter", "Roost", "Razor Wind", "Tailwind", "Whirlwind", "Super Fang", "Air Slash", "Hurricane",
    },
    new string[]
    {
         "Cut", "Fly", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Brick_Break", "Aerial_Ace", "Roost", "U_turn", "Dark_Pulse", "X_Scissor", "Shadow_Claw", "Round", "Echoed_Voice", "Acrobatics", "Wild_Charge", "Confide"
    },
    new int[] {715}, new string[] {"Level,48"}),


new PokemonData(715, "Noivern", PokemonData.Type.FLYING, PokemonData.Type.DRAGON, "Frisk", "Infiltrator", "Telepathy",
    50f, 45, PokemonData.EggGroup.FLYING, PokemonData.EggGroup.FLYING, 0, 1.5f, 85f,
    187, PokemonData.LevelingRate.MEDIUMFAST, 0, 0, 0, 0, 0, 2, PokemonData.PokedexColor.PURPLE, 70,
    "Sound Wave", "They fly around on moonless nightsand attack careless prey. Nothing canbeat them in a battle in the dark.",
    85, 70, 80, 97, 80, 123, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 1, 5, 11, 13, 16, 18, 23, 27, 31, 35, 40, 43, 53, 62},
    new string[]
    {
         "Tackle", "Supersonic", "Screech", "Moonlight", "Dragon Pulse", "Boomburst", "Leech Life", "Gust", "Bite", "Wing Attack", "Agility", "Air Cutter", "Roost", "Razor Wind", "Tailwind", "Whirlwind", "Super Fang", "Air Slash", "Hurricane",
    },
    new string[]
    {
         "Cut", "Fly", "Flamethrower", "Hyper_Beam", "Solar_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Attract", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Brick_Break", "Aerial_Ace", "Dragon_Claw", "Roost", "U_turn", "Dark_Pulse", "X_Scissor", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Echoed_Voice", "Acrobatics", "Wild_Charge", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(716, "Xerneas", PokemonData.Type.FAIRY, PokemonData.Type.NONE, "Fairy-aura", null, null,
    112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 3f, 215f,
    306, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.BLUE, 0,
    "Life", "Legends say it can share eternal life. It slept for a thousand years in the formof a tree before its revival.",
    126, 131, 95, 131, 98, 99, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 5, 10, 18, 26, 35, 44, 51, 55, 59, 63, 72, 80, 88, 93},
    new string[]
    {
         "Take Down", "Ingrain", "Aromatherapy", "Heal Pulse", "Light Screen", "Aurora Beam", "Gravity", "Geomancy", "Moonblast", "Megahorn", "Night Slash", "Horn Leech", "Psych Up", "Misty Terrain", "Nature Power", "Close Combat", "Giga Impact", "Outrage",
    },
    new string[]
    {
         "Cut", "Roar", "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Thunder", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Rest", "Rock_Slide", "Substitute", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Hail", "Facade", "Nature_Power", "Calm_Mind", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Grass_Knot", "Psyshock", "Round", "Echoed_Voice", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(717, "Yveltal", PokemonData.Type.DARK, PokemonData.Type.FLYING, "Dark-aura", null, null,
    112.5f, 45, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 5.8f, 203f,
    306, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.RED, 0,
    "Destruction", "When this legendary Pokémon’s wings andtail feathers spread wide and glow red,it absorbs the life force of living creatures.",
    126, 131, 95, 131, 98, 99, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 5, 10, 18, 26, 35, 44, 51, 55, 59, 63, 72, 80, 88, 93},
    new string[]
    {
         "Razor Wind", "Taunt", "Roost", "Hurricane", "Double Team", "Air Slash", "Snarl", "Oblivion Wing", "Disable", "Dark Pulse", "Foul Play", "Phantom Force", "Psychic", "Dragon Rush", "Focus Blast", "Sucker Punch", "Hyper Beam", "Sky Attack",
    },
    new string[]
    {
         "Cut", "Fly", "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Dream_Eater", "Rest", "Rock_Slide", "Substitute", "Thief", "Protect", "Swagger", "Steel_Wing", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Shadow_Ball", "Torment", "Facade", "Taunt", "Aerial_Ace", "Dragon_Claw", "Roost", "U_turn", "Embargo", "Dark_Pulse", "Focus_Blast", "Giga_Impact", "Shadow_Claw", "Hone_Claws", "Round", "Sky_Drop", "Acrobatics", "Snarl", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(718, "Zygarde", PokemonData.Type.DRAGON, PokemonData.Type.GROUND, "Aura-break", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 5f, 305f,
    270, PokemonData.LevelingRate.SLOW, 3, 0, 0, 0, 0, 0, PokemonData.PokedexColor.GREEN, 0,
    "Order", "When the Kalos region’s ecosystem falls intodisarray, it appears and reveals its secret power.",
    108, 100, 121, 81, 95, 95, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 5, 10, 18, 26, 35, 44, 51, 55, 59, 63, 72, 80, 88, 93},
    new string[]
    {
         "Bite", "Glare", "Dragon Breath", "Bulldoze", "Safeguard", "Dig", "Bind", "Land’s Wrath", "Sandstorm", "Haze", "Crunch", "Earthquake", "Camouflage", "Dragon Pulse", "Dragon Dance", "Coil", "Extreme Speed", "Outrage",
    },
    new string[]
    {
         "Hyper_Beam", "Strength", "Earthquake", "Dig", "Toxic", "Double_Team", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Facade", "Brick_Break", "Focus_Blast", "Giga_Impact", "Stone_Edge", "Grass_Knot", "Sludge_Wave", "Round", "Bulldoze", "Dragon_Tail", "Confide"
    },
    new int[] {}, new string[] {}),


new PokemonData(719, "Diancie", PokemonData.Type.ROCK, PokemonData.Type.FAIRY, "Clear-body", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.7f, 8.8f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 1, 0, 2, 0, PokemonData.PokedexColor.PINK, 70,
    "Jewel", "A sudden transformation of Carbink,its pink, glimmering body is said to bethe loveliest sight in the whole world.",
    50, 100, 150, 100, 150, 50, 0, Color.clear,
    new int[] { 1, 1, 5, 8, 12, 18, 21, 27, 31, 35, 40, 46, 49, 50, 50, 60, 70},
    new string[]
    {
         "Tackle", "Harden", "Rock Throw", "Sharpen", "Smack Down", "Reflect", "Stealth Rock", "Guard Split", "Ancient Power", "Flail", "Skill Swap", "Trick Room", "Stone Edge", "Moonblast", "Diamond Storm", "Light Screen", "Safeguard",
    },
    new string[]
    {
         "Hyper_Beam", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Flash", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Sunny_Day", "Psych_Up", "Hail", "Facade", "Nature_Power", "Rock_Tomb", "Calm_Mind", "Gyro_Ball", "Rock_Polish", "Giga_Impact", "Trick_Room", "Stone_Edge", "Psyshock", "Smack_Down", "Round", "Confide", "Dazzling_Gleam"
    },
    new int[] {}, new string[] {}),


new PokemonData(720, "Hoopa", PokemonData.Type.PSYCHIC, PokemonData.Type.GHOST, "Magician", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 0.5f, 9f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.PURPLE, 100,
    "Mischief", "This troublemaker sends anythingand everything to faraway placesusing its loop, which can warp space.",
    80, 110, 60, 150, 130, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 1, 1, 6, 10, 15, 19, 25, 29, 35, 46, 50, 55, 68, 75},
    new string[]
    {
         "Confusion", "Destiny Bond", "Trick", "Ally Switch", "Hyperspace Hole", "Astonish", "Magic Coat", "Psybeam", "Light Screen", "Skill Swap", "Power Split", "Guard Split", "Phantom Force", "Wonder Room", "Trick Room", "Shadow Ball", "Psychic",
    },
    new string[]
    {
         "Hyper_Beam", "Thunderbolt", "Thunder_Wave", "Toxic", "Psychic", "Double_Team", "Light_Screen", "Reflect", "Dream_Eater", "Flash", "Rest", "Substitute", "Thief", "Protect", "Swagger", "Sleep_Talk", "Return", "Frustration", "Safeguard", "Hidden_Power", "Rain_Dance", "Sunny_Day", "Psych_Up", "Shadow_Ball", "Torment", "Facade", "Taunt", "Brick_Break", "Calm_Mind", "Embargo", "Fling", "Focus_Blast", "Energy_Ball", "Giga_Impact", "Trick_Room", "Grass_Knot", "Charge_Beam", "Psyshock", "Round", "Quash", "Confide", "Power_Up_Punch"
    },
    new int[] {}, new string[] {}),


new PokemonData(721, "Volcanion", PokemonData.Type.FIRE, PokemonData.Type.WATER, "Water-absorb", null, null,
    112.5f, 3, PokemonData.EggGroup.NONE, PokemonData.EggGroup.NONE, 0, 1.7f, 195f,
    270, PokemonData.LevelingRate.SLOW, 0, 0, 0, 3, 0, 0, PokemonData.PokedexColor.BROWN, 100,
    "Steam", "It lets out billows of steam and disappears intothe dense fog. It’s said to live in mountainswhere humans do not tread.",
    80, 110, 120, 130, 90, 70, 0, Color.clear,
    new int[] { 1, 1, 1, 8, 11, 21, 28, 32, 40, 46, 50, 65, 76},
    new string[]
    {
         "Take Down", "Flare Blitz", "Steam Eruption", "Mist", "Haze", "Water Pulse", "Stomp", "Scald", "Weather Ball", "Body Slam", "Hydro Pump", "Overheat", "Explosion",
    },
    new string[]
    {
         "Cut", "Roar", "Flamethrower", "Hyper_Beam", "Strength", "Solar_Beam", "Earthquake", "Toxic", "Double_Team", "Fire_Blast", "Explosion", "Rest", "Rock_Slide", "Substitute", "Protect", "Sludge_Bomb", "Sandstorm", "Swagger", "Sleep_Talk", "Return", "Frustration", "Hidden_Power", "Sunny_Day", "Rock_Smash", "Will_O_Wisp", "Facade", "Brick_Break", "Overheat", "Gyro_Ball", "Fling", "Focus_Blast", "Giga_Impact", "Flash_Cannon", "Stone_Edge", "Smack_Down", "Sludge_Wave", "Flame_Charge", "Round", "Scald", "Incinerate", "Bulldoze", "Confide"
    },
    new int[] {}, new string[] {}),
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
