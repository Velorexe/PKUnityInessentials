using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Text.RegularExpressions;
using System.Threading;
using Console = Colorful.Console;
using System.Drawing;

namespace CSVDatabaseReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Generations = new string[16]
            {
                "Blue and Red", "Yellow", "Gold and Silver", "Crystal", "Ruby and Sapphire", "Emerald", "FireRed and LeafGreen", "Diamond and Pearl", "Platinum", "Heartgold and Soulsilver", "Black and White", "Black 2 and White 2", "X and Y", "Omega Ruby and Alpha Sapphire", "Sun and Moon", "Ultra Sun and Ultra Moon"
            };
            Console.Title = "Veekun's CSV Database to Pokemon Unity's PokemonDatabase Converter ~ by Velorexe";
            Console.WriteAscii("POKEMON UNITY", Color.FromArgb(66, 167, 199));
            Console.WriteLine("This tool is created by Velorexe for the Pokemon Unity project to easily convert the Veekun Pokemon Database to the format that is used in Pokemon Unity");
            Console.WriteLine("Please fill in the source path to the CSV Pokemon Database from Veekun. This should be a direct path to the directory.\nExample: C:/Users/Velorexe/Desktop/PokemonSprites/PokemonDatabase/Veekun Database/CSV\n");
            string SourcePath = Console.ReadLine();
            string[] csvFiles = Directory.GetFiles(SourcePath);
            csvFiles = csvFiles.Where(w => Path.GetExtension(w) == ".csv").ToArray();
            while (csvFiles.Length != 172)
            {
                Console.WriteLine("The folder should contain 172 CSV files, yours only contains " + csvFiles.Length + ". Please fill in the correct path.");
                SourcePath = Console.ReadLine();
                csvFiles = Directory.GetFiles(SourcePath);
                csvFiles = csvFiles.Where(w => Path.GetExtension(w) == ".csv").ToArray();
            }
            Console.WriteLine();
            Console.WriteLine($"{csvFiles.Length} csv files found.\n");
            Console.Write("Loading Generations");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.Clear();
            Console.WriteLine("Wich generation would you like to convert? Please press a key to load the generations. (Every key except 'Enter' please I haven't optimised the code yet)");
            Console.WriteLine("---------------------------");

            int SelectedItem = 0;
            var k = Console.ReadKey();
            while (k.Key != ConsoleKey.Enter)
            {
                if (k.Key == ConsoleKey.UpArrow)
                {
                    SelectedItem--;
                }
                else if (k.Key == ConsoleKey.DownArrow)
                {
                    SelectedItem++;
                }
                Console.Clear();
                Console.WriteLine("Wich generation would you like to convert?");
                Console.WriteLine("---------------------------");
                for (int i = 0; i < Generations.Length; i++)
                {
                    if (SelectedItem == Generations.Length)
                    {
                        SelectedItem = 0;
                    }
                    else if (SelectedItem == -1)
                    {
                        SelectedItem = Generations.Length - 1;
                    }
                    if (i == SelectedItem)
                    {
                        Console.ForegroundColor = Color.Blue;
                        Console.WriteLine(Generations[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(Generations[i]);
                    }
                }
                Console.WriteLine("---------------------------");
                k = Console.ReadKey();
            }
            int displayItem = SelectedItem;
            SelectedItem++;
            if (SelectedItem > 11)
            {
                SelectedItem = SelectedItem + 2;
            }
            Console.WriteLine("Converting now...\n");

            File.Delete(SourcePath + @"\POKEMONOUTPUT " + Generations[displayItem] + ".txt");
            StreamWriter Output = File.CreateText(SourcePath + @"\POKEMONOUTPUT " + Generations[displayItem] + ".txt");
            Output.Dispose();

            int PokemonCounter = 1;
            int MaxPoke = 0;
            string Generation = SelectedItem.ToString();

            /*
            Corresponding numbers with gens
            1 Red and blue
            2 Yellow
            3 Gold and Silver
            4 Crystal
            5 Sapphire
            6 Emerald
            7 FireRed and LeafGreen
            8 Diamond and Pearl
            9 Platinum
            10 Heartgold and Soulsilver
            11 Black And White
            14 Black 2 and White 2
            15 X and Y
            16 Omega Ruby and Alpha Sapphire
            17 Sun and Moon
            18 Ultra Sun and Ultra Moon
             */

            int Gen1 = 151;
            int Gen2 = 251;
            int Gen3 = 386;
            int Gen4 = 493;
            int Gen5 = 649;
            int Gen6 = 721;
            int Gen7 = 807;

            switch (SelectedItem)
            {
                case (1):
                case (2):
                    MaxPoke = Gen1;
                    break;
                case (3):
                case (4):
                    MaxPoke = Gen2;
                    break;
                case (5):
                case (6):
                case (7):
                    MaxPoke = Gen3;
                    break;
                case (8):
                case (9):
                case (10):
                    MaxPoke = Gen4;
                    break;
                case (11):
                case (14):
                    MaxPoke = Gen5;
                    break;
                case (15):
                case (16):
                    MaxPoke = Gen6;
                    break;
                case (17):
                case (18):
                    MaxPoke = Gen7;
                    break;
            }

            int RegionDex = 1;
            while (PokemonCounter < MaxPoke + 1)
            {
                string Ability1 = "";
                string Ability2 = "";
                string HiddenAbility = "";

                string Type1 = "";
                string Type2 = "";

                string EggGroup1 = "";
                string EggGroup2 = "";

                string GrowthRate = "";

                string Color_ID = "";

                int EvolutionID = 0;

                Dictionary<string, int> MoveLevelDictionary = new Dictionary<string, int>();
                List<string> TMList = new List<string>();

                string Entry = PokemonCounter.ToString();

                Pokemon Pokemon = new Pokemon();

                if (RegionDex == Gen1 || RegionDex == Gen2 || RegionDex == Gen3 || RegionDex == Gen4 || RegionDex == Gen5 || RegionDex == Gen6 || RegionDex == Gen7)
                {
                    RegionDex = 1;
                }
                Pokemon.RegionalDex = PokemonCounter.ToString();

                //Pokemon
                TextReader CsvReader = File.OpenText(csvFiles[129]);
                var csv = new CsvReader(CsvReader);

                Pokemon.ID = Entry;
                Pokemon.LightColor = "clear";
                Pokemon.Luminance = "0";
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Entry)
                    {
                        Pokemon.NAME = UpperCaseFirst(csv.GetField<string>(1));
                        Pokemon.Weight = csv.GetField<double>(4) / 10.0 + "f";
                        Pokemon.Height = csv.GetField<double>(3) / 10.0 + "f";
                        Pokemon.EXPYield = csv.GetField<string>(5);
                    }
                }

                //Pokemon_Types
                CsvReader = File.OpenText(csvFiles[155]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Entry)
                    {
                        Type1 = csv.GetField<string>(1);
                        csv.Read();
                        if (csv.GetField<string>(0) == Entry)
                        {
                            Type2 = csv.GetField<string>(1);
                        }
                    }
                }

                //Types
                CsvReader = File.OpenText(csvFiles[163]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Type1)
                    {
                        Type1 = csv.GetField<string>(1).ToUpper();
                        Pokemon.Type1 = Type1;
                    }
                    else if (csv.GetField<string>(0) == Type2)
                    {
                        Type2 = csv.GetField<string>(1).ToUpper();
                        Pokemon.Type2 = Type2;
                    }
                }
                if (Type2 == null || Type2 == "")
                {
                    Pokemon.Type2 = "NONE";
                }

                //Pokemon_Abilities
                CsvReader = File.OpenText(csvFiles[130]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Entry && csv.GetField<int>(2) == 1)
                    {
                        HiddenAbility = csv.GetField<string>(1);
                    }
                    else if (csv.GetField<string>(0) == Entry && csv.GetField<string>(2) != "1")
                    {
                        Ability1 = csv.GetField<string>(1);
                        csv.Read();
                        if (csv.GetField<string>(0) == Entry && csv.GetField<string>(2) != "1")
                        {
                            Ability2 = csv.GetField<string>(1);
                        }
                        else if (csv.GetField<string>(0) == Entry && csv.GetField<string>(2) == "1")
                        {
                            HiddenAbility = csv.GetField<string>(1);
                        }
                        csv.Read();
                        if (csv.GetField<string>(0) != Entry)
                        {
                            Ability2 = "NONE";
                            Pokemon.Ability2 = Ability2;
                        }
                        else if (csv.GetField<string>(0) == Entry && csv.GetField<string>(2) == "1")
                        {
                            HiddenAbility = csv.GetField<string>(1);
                        }
                    }
                }

                //Abilities
                CsvReader = File.OpenText(csvFiles[0]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Ability1)
                    {
                        Pokemon.Ability1 = "" + UpperCaseFirst(csv.GetField<string>(1)) + "";
                    }
                    else if (csv.GetField<string>(0) == Ability2 && Ability2 != "NONE")
                    {
                        Pokemon.Ability2 = "" + UpperCaseFirst(csv.GetField<string>(1)) + "";
                    }
                    else if (csv.GetField<string>(0) == HiddenAbility)
                    {
                        Pokemon.HiddenAbility = "" + UpperCaseFirst(csv.GetField<string>(1)) + "";
                    }
                }

                if (Pokemon.HiddenAbility == "" || Pokemon.HiddenAbility == null)
                {
                    Pokemon.HiddenAbility = "NONE";
                }

                //Pokemon_Species
                CsvReader = File.OpenText(csvFiles[149]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Entry)
                    {
                        Pokemon.MaleRatio = (100.0 - (100.0 / 8.0 * csv.GetField<double>(8))).ToString() + "f";
                        Pokemon.CatchRate = csv.GetField<string>(9);
                        Pokemon.BaseFriendship = csv.GetField<string>(10);
                        Pokemon.HatchTime = (257 * csv.GetField<int>(12)).ToString();
                        GrowthRate = csv.GetField<string>(14);
                        Color_ID = csv.GetField<string>(5);
                        if (csv.GetField<string>(4) != "")
                        {
                            string test = csv.GetField<string>(4);
                            EvolutionID = csv.GetField<int>(4);
                        }
                    }
                }

                //Pokemon_Evolution
                //For Level
                CsvReader = File.OpenText(csvFiles[149]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(1) == (PokemonCounter + 1).ToString() && csv.GetField<string>(2) == "1" && csv.GetField<string>(4) != "")
                    {
                        string PokemonEvolution = $"new PokemonEvolution(Pokemons.{Pokemon.NAME.ToUpper()}, EvolutionMethod.Level, {csv.GetField<string>(4)})";
                        Pokemon.PokemonEvolution = csv.GetField<string>(1);
                    }
                }

                if (Pokemon.PokemonEvolution != "")
                {
                    //Pokemon_Evolution
                    //For Item
                    CsvReader = File.OpenText(csvFiles[149]);
                    csv = new CsvReader(CsvReader);
                    while (csv.Read())
                    {
                        if (csv.GetField<string>(1) == (PokemonCounter + 1).ToString() && csv.GetField<string>(2) == "3" && csv.GetField<string>(5) == "")
                        {
                            if (csv.GetField<string>(11) != "" && csv.GetField<string>(8) == "")
                            {
                                if (csv.GetField<string>(8) == "")
                                {
                                    string ItemEvolution = $"new PokemonEvolution(Pokemons.{Pokemon.NAME.ToUpper()}, EvolutionMethod.Item)";
                                }
                                else if(csv.GetField<string>(8) == "day")
                                {
                                    string ItemEvolution = $"new PokemonEvolution(Pokemons.{Pokemon.NAME.ToUpper()}, EvolutionMethod.ItemHeldDay)"; //Add everything else
                                }
                            }
                            else
                            {
                                string ItemEvolution = $"new PokemonEvolution(Pokemons.{Pokemon.NAME.ToUpper()}, EvolutionMethod.Item)";
                            }
                        }
                        else if (csv.GetField<string>(1) == (PokemonCounter + 1).ToString() && csv.GetField<string>(2) == "3" && csv.GetField<string>(5) != "")
                        {
                            if (csv.GetField<string>(5) == "1")
                            {
                                string ItemEvolution = $"new PokemonEvolution(Pokemons.{Pokemon.NAME.ToUpper()}, EvolutionMethod.ItemFemale)";
                            }
                            else
                            {
                                string ItemEvolution = $"new PokemonEvolution(Pokemons.{Pokemon.NAME.ToUpper()}, EvolutionMethod.ItemMale)";
                            }
                        }
                        else if (csv.GetField<string>(1) == (PokemonCounter + 1).ToString() && csv.GetField<string>(2) == "2")
                        {
                            if (csv.GetField<string>(5) != "")
                            {
                                string ItemEvolution = $"new PokemonEvolution(Pokemons.{Pokemon.NAME.ToUpper()}, EvolutionMethod.Trade)";
                            }
                            else
                            {
                                string ItemEvolution = $"new PokemonEvolution(Pokemons.{Pokemon.NAME.ToUpper()}, EvolutionMethod.TradeItem)";
                            }
                        }
                        else if (csv.GetField<string>(1) == (PokemonCounter + 1).ToString() && csv.GetField<string>(2) == "4")
                        {

                        }
                    }
                }

                //Pokemon_colors
                CsvReader = File.OpenText(csvFiles[131]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Color_ID)
                    {
                        Pokemon.PokedexColor = csv.GetField<string>(1).ToUpper();
                    }
                }

                //Growth_Rates
                CsvReader = File.OpenText(csvFiles[67]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == GrowthRate)
                    {
                        Pokemon.LevelingRate = csv.GetField<string>(1).ToUpper();
                        Pokemon.LevelingRate = Pokemon.LevelingRate.Replace("-", "");
                        Pokemon.LevelingRate = Pokemon.LevelingRate.Replace("SLOWTHENVERYFAST", "FLUCTUATING");
                        if (Pokemon.LevelingRate == "MEDIUM")
                        {
                            Pokemon.LevelingRate = "MEDIUMFAST";
                        }
                        Pokemon.LevelingRate = Pokemon.LevelingRate.Replace("FASTTHENVERYSLOW", "ERRATIC");
                    }
                }

                //Pokemon_Egg_Groups
                CsvReader = File.OpenText(csvFiles[134]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Entry)
                    {
                        EggGroup1 = csv.GetField<string>(1);
                        csv.Read();
                        if (csv.GetField<string>(0) == Entry)
                        {
                            EggGroup2 = csv.GetField<string>(1);
                        }
                        else
                        {
                            EggGroup2 = "NONE";
                            Pokemon.EggGroup2 = EggGroup2;
                        }
                    }
                }

                //Egg_groups
                CsvReader = File.OpenText(csvFiles[49]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == EggGroup1)
                    {
                        if (csv.GetField<string>(1) == "ground")
                        {
                            EggGroup1 = "FIELD";
                        }
                        else if (csv.GetField<string>(1) == "plant")
                        {
                            EggGroup1 = "GRASS";
                        }
                        else if (csv.GetField<string>(1) == "humanshape")
                        {
                            EggGroup1 = "HUMANLIKE";
                        }
                        else if (csv.GetField<string>(1) == "indeterminate")
                        {
                            EggGroup1 = "AMORPHOUS";
                        }
                        else if (csv.GetField<string>(1) == "no-eggs")
                        {
                            EggGroup1 = "UNDISCOVERED";
                        }
                        else
                        {
                            Pokemon.EggGroup1 = csv.GetField<string>(1).ToUpper();
                        }
                    }
                    else if (csv.GetField<string>(0) == EggGroup2 && EggGroup2 != "NONE")
                    {
                        if (csv.GetField<string>(1) == "ground")
                        {
                            EggGroup2 = "FIELD";
                        }
                        else if (csv.GetField<string>(1) == "plant")
                        {
                            EggGroup2 = "GRASS";
                        }
                        else if (csv.GetField<string>(1) == "humanshape")
                        {
                            EggGroup2 = "HUMANLIKE";
                        }
                        else if (csv.GetField<string>(1) == "indeterminate")
                        {
                            EggGroup2 = "AMORPHOUS";
                        }
                        else if (csv.GetField<string>(1) == "no-eggs")
                        {
                            EggGroup2 = "UNDISCOVERED";
                        }
                        else
                        {
                            Pokemon.EggGroup2 = csv.GetField<string>(1).ToUpper();
                        }
                    }
                }
                Pokemon.EggGroup1 = Pokemon.EggGroup1.Replace("-", "");
                Pokemon.EggGroup2 = Pokemon.EggGroup2.Replace("-", "");

                //Pokemon_Stats
                CsvReader = File.OpenText(csvFiles[154]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == "1")
                    {
                        Pokemon.BSHP = csv.GetField<string>(2);
                        Pokemon.EYHP = csv.GetField<string>(3);
                        csv.Read();
                        if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == "2")
                        {
                            Pokemon.BSATK = csv.GetField<string>(2);
                            Pokemon.EYATK = csv.GetField<string>(3);
                        }
                        csv.Read();
                        if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == "3")
                        {
                            Pokemon.BSDEF = csv.GetField<string>(2);
                            Pokemon.EYDEF = csv.GetField<string>(3);
                        }
                        csv.Read();
                        if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == "4")
                        {
                            Pokemon.BSSPA = csv.GetField<string>(2);
                            Pokemon.EYSPA = csv.GetField<string>(3);
                        }
                        csv.Read();
                        if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == "5")
                        {
                            Pokemon.BSSPD = csv.GetField<string>(2);
                            Pokemon.EYSPD = csv.GetField<string>(3);
                        }
                        csv.Read();
                        if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == "6")
                        {
                            Pokemon.BSSPE = csv.GetField<string>(2);
                            Pokemon.EYSPE = csv.GetField<string>(3);
                        }
                    }
                }

                //Pokemon_Species_Names
                CsvReader = File.OpenText(csvFiles[152]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == "9")
                    {
                        string Species = csv.GetField<string>(3);
                        Species = Species.Replace(" PokÃ©mon", "");
                        Species = Species.Replace(" Pokémon", "");
                        Pokemon.Species = Species;
                    }
                }

                //Pokemon_Species_Flavor_Text
                CsvReader = File.OpenText(csvFiles[151]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == "23" && csv.GetField<string>(2) == "9")
                    {
                        string PokedexEntry = csv.GetField<string>(3);
                        PokedexEntry = PokedexEntry.Replace("\n", "");
                        PokedexEntry = PokedexEntry.Replace("\r", "");
                        PokedexEntry = PokedexEntry.Replace(".", ". ");
                        PokedexEntry = PokedexEntry.Replace("  ", " ");
                        PokedexEntry = PokedexEntry.Replace("   ", " ");
                        PokedexEntry = PokedexEntry.Remove(PokedexEntry.Length - 1);
                        Pokemon.Description = PokedexEntry;
                    }
                }

                //Pokemon_Moves
                List<string> Moves = new List<string>();
                List<int> Level = new List<int>();
                CsvReader = File.OpenText(csvFiles[144]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == Generation && csv.GetField<string>(3) == "1" && csv.GetField<string>(4) != "")
                    {
                        Level.Add(csv.GetField<int>(4));
                        Moves.Add(csv.GetField<string>(2));
                    }
                    else if (csv.GetField<string>(0) == Entry && csv.GetField<string>(1) == Generation && csv.GetField<string>(3) == "4")
                    {
                        TMList.Add(csv.GetField<string>(2));
                    }
                }
                string[] TMArray = TMList.ToArray();

                //Move_Names
                string TM = "";
                string LevelString = "";

                CsvReader = File.OpenText(csvFiles[114]);
                csv = new CsvReader(CsvReader);
                while (csv.Read())
                {
                    for (int i = 0; i < TMArray.Length; i++)
                    {
                        if (csv.GetField<string>(0) == TMArray[i] && csv.GetField<string>(1) == "9")
                        {
                            string TMMove = csv.GetField<string>(2);
                            TMMove = TMMove.Replace(' ', '_');
                            TMMove = TMMove.Replace('-', '_');
                            TM = TM +
                            $"\tnew PokemonMoveset" +
                            $"\n\t(" +
                                $"\tmoveId: Moves.{TMMove}," +
                                $"\n\t\tmethod: LearnMethod.machine," +
                            $"\n\t),\n";
                        }
                    }
                    for (int i = 0; i < Moves.Count; i++)
                    {
                        if (csv.GetField<string>(0) == Moves[i] && csv.GetField<string>(1) == "9")
                        {
                            Moves[i] = csv.GetField<string>(2);
                        }
                    }
                }
                for (int i = 0; i < Moves.Count; i++)
                {
                    try
                    {
                        MoveLevelDictionary.Add(Moves[i], Level[i]);
                    }
                    catch
                    {
                        i++;
                    }
                }

                var items = from KeyValuePair in MoveLevelDictionary orderby KeyValuePair.Value ascending select KeyValuePair;

                foreach (KeyValuePair<string, int> pair in items)
                {
                    string moveId = pair.Key.Replace(' ', '_');
                    moveId = moveId.Replace('-', '_');
                    LevelString = LevelString +
                        (
                        $"\tnew PokemonMoveset" +
                        $"\n\t(" +
                            $"\tmoveId: Moves.{moveId}," +
                            $"\n\t\tmethod: LearnMethod.levelup," +
                            $"\n\t\tlevel: {pair.Value}" +
                        $"\n\t),\n");
                }
                if (TM != "")
                {
                    TM = TM.Remove(TM.Length - 1);
                }
                TM = TM.Replace("\n", System.Environment.NewLine);
                LevelString = LevelString.Replace("\n", System.Environment.NewLine);
                LevelString = LevelString.Remove(LevelString.Length - 1);
                Pokemon.LevelMoves = LevelString;
                Pokemon.TMMoves = TM;

                //Showing the Pokemon in console
                string OutputText1 = Pokemon.ToString();
                Console.WriteLine(OutputText1.Replace("\n", System.Environment.NewLine));
                PokemonCounter++;
                RegionDex++;

                using (Output = File.AppendText(SourcePath + @"\POKEMONOUTPUT " + Generations[displayItem] + ".txt"))
                {
                    string OutputText = Pokemon.ToString();
                    OutputText = OutputText.Replace("\n", System.Environment.NewLine);
                    Output.WriteLine(OutputText);
                    Output.Write("\n");
                }
            }
            Console.WriteLine($"Database is done writing, your file can be found in {SourcePath}/POKEMONOUTPUT.TXT");
            Console.ReadKey();
        }

        //Method to make the first letter of a string uppercase
        static string UpperCaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
