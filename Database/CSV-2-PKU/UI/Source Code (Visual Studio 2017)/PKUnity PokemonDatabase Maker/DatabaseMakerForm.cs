using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using CsvHelper;

namespace PKUnity_PokemonDatabase_Maker
{
    public partial class DatabaseMakerForm : Form
    {
        public string OutputFolder;
        public string[] csvFiles;

        public string[] Generations = new string[16]
        {
            "Blue and Red", "Yellow", "Gold and Silver", "Crystal", "Ruby and Saphire", "Emerald", "FireRed and LeafGreen", "Diamond and Pearl", "Platinum", "Heartgold and Soulsilver", "Black and White", "Black 2 and White 2", "X and Y", "Omega Ruby and Alpha Sapphire", "Sun and Moon", "Ultra Sun and Ultra Moon"
        };

        public DatabaseMakerForm()
        {
            InitializeComponent();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            var InformationForm = new Information();
            InformationForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PKUnityVersionComboBox.SelectedItem.ToString() == "Old Format")
            {
                ExamplePokemonOld.Visible = true;
                ExamplePokemonNew.Visible = false;
            }
            else if (PKUnityVersionComboBox.SelectedItem.ToString() == "New Format (Experimental)")
            {
                ExamplePokemonOld.Visible = false;
                ExamplePokemonNew.Visible = true;
            }
        }

        private void SourceFolderButton_Click(object sender, EventArgs e)
        {
            using (var FolderBrowser = new FolderBrowserDialog())
            {
                DialogResult SourceFolder = FolderBrowser.ShowDialog();

                if (SourceFolder == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowser.SelectedPath))
                {
                    csvFiles = Directory.GetFiles(FolderBrowser.SelectedPath);
                    csvFiles = csvFiles.Where(w => Path.GetExtension(w) == ".csv").ToArray();
                    if (csvFiles.Length != 172)
                    {
                        CSVFilesLabel.Text = $"{csvFiles.Length} CSV Files found. It should be 172, check your folder to see if every CSV File is there.";
                    }
                    else
                    {
                        CSVFilesLabel.Text = $"{csvFiles.Length} CSV Files found.";
                    }
                }
            }
        }

        private void OutputFolderButton_Click(object sender, EventArgs e)
        {
            using (var FolderBrowser = new FolderBrowserDialog())
            {
                DialogResult SourceFolder = FolderBrowser.ShowDialog();

                if (SourceFolder == DialogResult.OK && !string.IsNullOrWhiteSpace(FolderBrowser.SelectedPath))
                {
                    OutputFolder = FolderBrowser.SelectedPath;
                }
            }

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (csvFiles.Length == 172 && (OutputFolder != null || OutputFolder != "") && PokemonGenerationComboBox.SelectedItem.ToString() != "" && PokemonGenerationComboBox.SelectedItem.ToString() != "")
            {
                int PokemonCounter = 1;
                int MaxPoke = 0;
                string Generation = "";
                int RegionDex = 1;

                int Gen1 = 151;
                int Gen2 = 251;
                int Gen3 = 386;
                int Gen4 = 493;
                int Gen5 = 649;
                int Gen6 = 721;
                int Gen7 = 807;


                string SelectedGeneration = PokemonGenerationComboBox.SelectedItem.ToString();

                switch (SelectedGeneration)
                {
                    case ("Blue and Red"):
                        Generation = "1";
                        MaxPoke = 151;
                        break;
                    case ("Yellow"):
                        Generation = "2";
                        MaxPoke = 151;
                        break;
                    case ("Gold and Silver"):
                        Generation = "3";
                        MaxPoke = 251;
                        break;
                    case ("Crystal"):
                        Generation = "4";
                        MaxPoke = 251;
                        break;
                    case ("Ruby and Saphire"):
                        Generation = "5";
                        MaxPoke = 386;
                        break;
                    case ("Emerald"):
                        Generation = "6";
                        MaxPoke = 386;
                        break;
                    case ("FireRed and LeafGreen"):
                        Generation = "7";
                        MaxPoke = 386;
                        break;
                    case ("Diamond and Pearl"):
                        Generation = "8";
                        MaxPoke = 493;
                        break;
                    case ("Platinum"):
                        Generation = "9";
                        MaxPoke = 493;
                        break;
                    case ("Heartgold and Soulsilver"):
                        Generation = "10";
                        MaxPoke = 493;
                        break;
                    case ("Black and White"):
                        Generation = "11";
                        MaxPoke = 649;
                        break;
                    case ("Black 2 and White 2"):
                        Generation = "14";
                        MaxPoke = 649;
                        break;
                    case ("X and Y"):
                        Generation = "15";
                        MaxPoke = 721;
                        break;
                    case ("Omega Ruby and Alpha Saphire"):
                        Generation = "16";
                        MaxPoke = 721;
                        break;
                    case ("Sun and Moon"):
                        Generation = "17";
                        MaxPoke = 807;
                        break;
                    case ("Ultra Sun and Ultra Moon"):
                        Generation = "18";
                        MaxPoke = 807;
                        break;
                }

                File.Delete(OutputFolder + @"\OUTPUT " + SelectedGeneration + ".txt");
                StreamWriter Output = File.CreateText(OutputFolder + @"\OUTPUT " + SelectedGeneration + ".txt");
                Output.Dispose();
                #region OLD FORMAT
                if (PKUnityVersionComboBox.SelectedItem.ToString() == "Old Format")
                {
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
                        string MoveLevel = "";

                        string Entry = PokemonCounter.ToString();

                        PokemonOld Pokemon = new PokemonOld();

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
                                    Ability2 = "null";
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
                                Pokemon.Ability1 = "\"" + UpperCaseFirst(csv.GetField<string>(1)) + "\"";
                            }
                            else if (csv.GetField<string>(0) == Ability2 && Ability2 != "null")
                            {
                                Pokemon.Ability2 = "\"" + UpperCaseFirst(csv.GetField<string>(1)) + "\"";
                            }
                            else if (csv.GetField<string>(0) == HiddenAbility)
                            {
                                Pokemon.HiddenAbility = "\"" + UpperCaseFirst(csv.GetField<string>(1)) + "\"";
                            }
                        }

                        if (Pokemon.HiddenAbility == "" || Pokemon.HiddenAbility == null)
                        {
                            Pokemon.HiddenAbility = "null";
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
                                Pokemon.BaseFrienship = csv.GetField<string>(10);
                                Pokemon.HatchTime = (257 * csv.GetField<int>(13)).ToString();
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
                        CsvReader = File.OpenText(csvFiles[135]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.GetField<string>(1) == (PokemonCounter + 1).ToString() && csv.GetField<string>(2) == "1" && csv.GetField<string>(4) != "")
                            {
                                Pokemon.LevelEvolution = "\"Level," + csv.GetField<string>(4) + "\"";
                                Pokemon.PokemonEvolution = csv.GetField<string>(1);
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
                                Pokemon.EggGroup1 = csv.GetField<string>(1).ToUpper();
                            }
                            else if (csv.GetField<string>(0) == EggGroup2 && EggGroup2 != "null")
                            {
                                Pokemon.EggGroup2 = csv.GetField<string>(1).ToUpper();
                            }
                        }
                        Pokemon.EggGroup1 = Pokemon.EggGroup1.Replace("-", "");
                        Pokemon.EggGroup2 = Pokemon.EggGroup2.Replace("-", "");
                        Pokemon.EggGroup1 = Pokemon.EggGroup1.Replace("NOEGGS", "NONE");
                        Pokemon.EggGroup2 = Pokemon.EggGroup1.Replace("NOEGGS", "NONE");

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
                                    TM = TM + " \"" + TMMove + "\",";
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
                            LevelString = LevelString + " " + pair.Value + ",";
                            MoveLevel = MoveLevel + " \"" + pair.Key + "\",";
                        }
                        if (TM != "")
                        {
                            TM = TM.Remove(TM.Length - 1);
                        }
                        LevelString = LevelString.Remove(LevelString.Length - 1);
                        Pokemon.Level = LevelString;
                        Pokemon.Moves = MoveLevel;
                        Pokemon.TMMoves = TM;

                        //Showing the Pokemon in console
                        Console.WriteLine(Pokemon.ToString());
                        PokemonCounter++;

                        using (Output = File.AppendText(OutputFolder + @"\OUTPUT " + SelectedGeneration + ".txt"))
                        {
                            string OutputText = Pokemon.ToString();
                            OutputText = OutputText.Replace("\n", System.Environment.NewLine);
                            Output.WriteLine(OutputText);
                            Output.Write("\n");
                        }
                    }
                    FinishedLabel.Visible = true;
                    FinishedLabel.Text = ($"Database is done writing, your file can be found in {OutputFolder}/OUTPUT.TXT");
                }
                #endregion
                #region NEW FORMAT
                else if (PKUnityVersionComboBox.SelectedItem.ToString() == "New Format (Experimental)")
                {
                    PokemonNew[] Pokemons = new PokemonNew[MaxPoke];

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

                        //Dictionary<string, int> MoveLevelDictionary = new Dictionary<string, int>();
                        Dictionary<string, int[]> MoveLevelDictionary = new Dictionary<string, int[]>();
                        List<string> TMList = new List<string>();

                        string Entry = PokemonCounter.ToString();

                        PokemonNew Pokemon = new PokemonNew();

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
                            if (csv.Context.Record[0] == Entry)
                            {
                                Pokemon.NAME = UpperCaseFirst(csv.Context.Record[1]);
                                Pokemon.Weight = csv.GetField<double>(4) / 10.0 + "f";
                                Pokemon.Height = csv.GetField<double>(3) / 10.0 + "f";
                                Pokemon.EXPYield = csv.Context.Record[5];
                            }
                        }
                        Console.WriteLine($"Pokemon ID: {PokemonCounter}, Name: {Pokemon.NAME.ToUpper()}");
                        Console.Write("Progress |");

                        //Pokemon_Types
                        CsvReader = File.OpenText(csvFiles[155]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Entry)
                            {
                                Type1 = csv.Context.Record[1];
                                csv.Read();
                                if (csv.Context.Record[0] == Entry)
                                {
                                    Type2 = csv.Context.Record[1];
                                }
                            }
                        }
                        Console.Write("+");

                        //Types
                        CsvReader = File.OpenText(csvFiles[163]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Type1)
                            {
                                Type1 = csv.Context.Record[1].ToUpper();
                                Pokemon.Type1 = Type1;
                            }
                            else if (csv.Context.Record[0] == Type2)
                            {
                                Type2 = csv.Context.Record[1].ToUpper();
                                Pokemon.Type2 = Type2;
                            }
                        }
                        if (Type2 == null || Type2 == "")
                        {
                            Pokemon.Type2 = "NONE";
                        }
                        Console.Write("+");

                        //Pokemon_Abilities
                        CsvReader = File.OpenText(csvFiles[130]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Entry && int.Parse(csv.Context.Record[2]) == 1)
                            {
                                HiddenAbility = csv.Context.Record[1];
                            }
                            else if (csv.Context.Record[0] == Entry && csv.Context.Record[2] != "1")
                            {
                                Ability1 = csv.Context.Record[1];
                                csv.Read();
                                if (csv.Context.Record[0] == Entry && csv.Context.Record[2] != "1")
                                {
                                    Ability2 = csv.Context.Record[1];
                                }
                                else if (csv.Context.Record[0] == Entry && csv.Context.Record[2] == "1")
                                {
                                    HiddenAbility = csv.Context.Record[1];
                                }
                                csv.Read();
                                if (csv.Context.Record[0] != Entry)
                                {
                                    Ability2 = "NONE";
                                    Pokemon.Ability2 = Ability2;
                                }
                                else if (csv.Context.Record[0] == Entry && csv.Context.Record[2] == "1")
                                {
                                    HiddenAbility = csv.Context.Record[1];
                                }
                            }
                        }
                        Console.Write("+");

                        //Abilities
                        CsvReader = File.OpenText(csvFiles[0]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Ability1)
                            {
                                Pokemon.Ability1 = "" + UpperCaseFirst(csv.Context.Record[1]) + "";
                                Pokemon.Ability1 = Pokemon.Ability1.ToUpper();
                                Pokemon.Ability1 = Pokemon.Ability1.Replace(' ', '_');
                                Pokemon.Ability1 = Pokemon.Ability1.Replace('-', '_');
                            }
                            else if (csv.Context.Record[0] == Ability2 && Ability2 != "NONE")
                            {
                                Pokemon.Ability2 = "" + UpperCaseFirst(csv.Context.Record[1]) + "";
                                Pokemon.Ability2 = Pokemon.Ability2.ToUpper();
                                Pokemon.Ability2 = Pokemon.Ability2.Replace(' ', '_');
                                Pokemon.Ability2 = Pokemon.Ability2.Replace('-', '_');
                            }
                            else if (csv.Context.Record[0] == HiddenAbility)
                            {
                                Pokemon.HiddenAbility = "" + UpperCaseFirst(csv.Context.Record[1]) + "";
                                Pokemon.HiddenAbility = Pokemon.HiddenAbility.ToUpper();
                                Pokemon.HiddenAbility = Pokemon.HiddenAbility.Replace(' ', '_');
                                Pokemon.HiddenAbility = Pokemon.HiddenAbility.Replace('-', '_');
                            }
                        }

                        if (Pokemon.HiddenAbility == "" || Pokemon.HiddenAbility == null)
                        {
                            Pokemon.HiddenAbility = "NONE";
                            Pokemon.HiddenAbility = Pokemon.HiddenAbility.ToUpper();
                            Pokemon.HiddenAbility = Pokemon.HiddenAbility.Replace(' ', '_');
                            Pokemon.HiddenAbility = Pokemon.HiddenAbility.Replace('-', '_');
                        }
                        Console.Write("+");

                        //Pokemon_Species
                        CsvReader = File.OpenText(csvFiles[149]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Entry)
                            {
                                Pokemon.MaleRatio = (100.0 - (100.0 / 8.0 * csv.GetField<double>(8))).ToString() + "f";
                                Pokemon.CatchRate = csv.Context.Record[9];
                                Pokemon.BaseFriendship = csv.Context.Record[10];
                                Pokemon.HatchTime = (257 * int.Parse(csv.Context.Record[12])).ToString();
                                GrowthRate = csv.Context.Record[14];
                                Color_ID = csv.Context.Record[5];
                                if (!string.IsNullOrEmpty(csv.Context.Record[4]))
                                {
                                    string test = csv.Context.Record[4];
                                    EvolutionID = int.Parse(csv.Context.Record[4]);
                                }
                            }
                        }
                        Console.Write("+");

                        //Pokemon_colors
                        CsvReader = File.OpenText(csvFiles[131]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Color_ID)
                            {
                                Pokemon.PokedexColor = csv.Context.Record[1].ToUpper();
                            }
                        }
                        Console.Write("+");

                        //Growth_Rates
                        CsvReader = File.OpenText(csvFiles[67]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == GrowthRate)
                            {
                                Pokemon.LevelingRate = csv.Context.Record[1].ToUpper();
                                Pokemon.LevelingRate = Pokemon.LevelingRate.Replace("-", "");
                                Pokemon.LevelingRate = Pokemon.LevelingRate.Replace("SLOWTHENVERYFAST", "FLUCTUATING");
                                if (Pokemon.LevelingRate == "MEDIUM")
                                {
                                    Pokemon.LevelingRate = "MEDIUMFAST";
                                }
                                Pokemon.LevelingRate = Pokemon.LevelingRate.Replace("FASTTHENVERYSLOW", "ERRATIC");
                            }
                        }
                        Console.Write("+");

                        //Pokemon_Egg_Groups
                        CsvReader = File.OpenText(csvFiles[134]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Entry)
                            {
                                EggGroup1 = csv.Context.Record[1];
                                csv.Read();
                                //got a null error on last value
                                if ((!string.IsNullOrEmpty(csv.Context.RawRecord) /*|| !string.IsNullOrEmpty(csv.Context.Record[0])*/) && csv.Context.Record[0] == Entry)
                                {
                                    EggGroup2 = csv.Context.Record[1];
                                }
                                else
                                {
                                    EggGroup2 = "NONE";
                                    Pokemon.EggGroup2 = EggGroup2;
                                }
                            }
                        }
                        Console.Write("+");

                        //Egg_groups
                        CsvReader = File.OpenText(csvFiles[49]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == EggGroup1)
                            {
                                if (csv.Context.Record[1] == "ground")
                                {
                                    Pokemon.EggGroup1 = "FIELD";
                                }
                                else if (csv.Context.Record[1] == "plant")
                                {
                                    Pokemon.EggGroup1 = "GRASS";
                                }
                                else if (csv.Context.Record[1] == "humanshape")
                                {
                                    Pokemon.EggGroup1 = "HUMANLIKE";
                                }
                                else if (csv.Context.Record[1] == "indeterminate")
                                {
                                    Pokemon.EggGroup1 = "AMORPHOUS";
                                }
                                else if (csv.Context.Record[1] == "no-eggs")
                                {
                                    Pokemon.EggGroup1 = "UNDISCOVERED";
                                }
                                else
                                {
                                    Pokemon.EggGroup1 = csv.Context.Record[1].ToUpper();
                                }
                            }
                            else if (csv.Context.Record[0] /*csv.Context.Record[0]*/ == EggGroup2 && EggGroup2 != "NONE")
                            {
                                if (csv.Context.Record[1] == "ground")
                                {
                                    Pokemon.EggGroup2 = "FIELD";
                                }
                                else if (csv.Context.Record[1] == "plant")
                                {
                                    Pokemon.EggGroup2 = "GRASS";
                                }
                                else if (csv.Context.Record[1] == "humanshape")
                                {
                                    Pokemon.EggGroup2 = "HUMANLIKE";
                                }
                                else if (csv.Context.Record[1] == "indeterminate")
                                {
                                    Pokemon.EggGroup2 = "AMORPHOUS";
                                }
                                else if (csv.Context.Record[1] == "no-eggs")
                                {
                                    Pokemon.EggGroup2 = "UNDISCOVERED";
                                }
                                else
                                {
                                    Pokemon.EggGroup2 = csv.Context.Record[1].ToUpper();
                                }
                            }
                        }
                        Pokemon.EggGroup1 = Pokemon.EggGroup1.Replace("-", "");
                        if (EggGroup2 != null)
                        {
                            Pokemon.EggGroup2 = Pokemon.EggGroup2.Replace("-", "");
                        }
                        else
                        {
                            Pokemon.EggGroup2 = "NONE";
                        }
                        Console.Write("+");

                        //Pokemon_Stats
                        CsvReader = File.OpenText(csvFiles[154]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Entry && csv.Context.Record[1] == "1")
                            {
                                Pokemon.BSHP = csv.Context.Record[2];
                                Pokemon.EYHP = csv.Context.Record[3];
                                csv.Read();
                                if (csv.Context.Record[0] == Entry && csv.Context.Record[1] == "2")
                                {
                                    Pokemon.BSATK = csv.Context.Record[2];
                                    Pokemon.EYATK = csv.Context.Record[3];
                                }
                                csv.Read();
                                if (csv.Context.Record[0] == Entry && csv.Context.Record[1] == "3")
                                {
                                    Pokemon.BSDEF = csv.Context.Record[2];
                                    Pokemon.EYDEF = csv.Context.Record[3];
                                }
                                csv.Read();
                                if (csv.Context.Record[0] == Entry && csv.Context.Record[1] == "4")
                                {
                                    Pokemon.BSSPA = csv.Context.Record[2];
                                    Pokemon.EYSPA = csv.Context.Record[3];
                                }
                                csv.Read();
                                if (csv.Context.Record[0] == Entry && csv.Context.Record[1] == "5")
                                {
                                    Pokemon.BSSPD = csv.Context.Record[2];
                                    Pokemon.EYSPD = csv.Context.Record[3];
                                }
                                csv.Read();
                                if (csv.Context.Record[0] == Entry && csv.Context.Record[1] == "6")
                                {
                                    Pokemon.BSSPE = csv.Context.Record[2];
                                    Pokemon.EYSPE = csv.Context.Record[3];
                                }
                            }
                        }
                        Console.Write("+");

                        //Pokemon_Species_Names
                        CsvReader = File.OpenText(csvFiles[152]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Entry && csv.Context.Record[1] == "9")
                            {
                                string Species = csv.Context.Record[3];
                                Species = Species.Replace(" PokÃ©mon", "");
                                Species = Species.Replace(" Pokémon", "");
                                Pokemon.Species = Species;
                            }
                        }
                        Console.Write("+");

                        //Pokemon_Species_Flavor_Text
                        CsvReader = File.OpenText(csvFiles[151]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Entry && csv.Context.Record[1] == "23" && csv.Context.Record[2] == "9")
                            {
                                string PokedexEntry = csv.Context.Record[3];
                                PokedexEntry = PokedexEntry.Replace("\n", "");
                                PokedexEntry = PokedexEntry.Replace("\r", "");
                                PokedexEntry = PokedexEntry.Replace(".", ". ");
                                PokedexEntry = PokedexEntry.Replace("  ", " ");
                                PokedexEntry = PokedexEntry.Replace("   ", " ");
                                PokedexEntry = PokedexEntry.Remove(PokedexEntry.Length - 1);
                                Pokemon.Description = PokedexEntry;
                            }
                        }
                        Console.Write("+");

                        //Pokemon_Moves
                        List<string> Moves = new List<string>();
                        List<int> Level = new List<int>();
                        List<int> Gen = new List<int>();
                        List<string> Egg = new List<string>();
                        List<string> Tutor = new List<string>();
                        List<string> lbe = new List<string>();
                        List<string> Purification = new List<string>();
                        List<string> FormChange = new List<string>();
                        List<string> Shadow = new List<string>();
                        CsvReader = File.OpenText(csvFiles[144]);
                        csv = new CsvReader(CsvReader);
                        csv.Read();
                        while (csv.Read())
                        {
                            if (csv.Context.Record[0] == Entry && int.Parse(csv.Context.Record[1]) == Convert.ToInt32(Generation) && csv.Context.Record[3] == "1" && !string.IsNullOrEmpty(csv.Context.Record[4]))
                            {
                                Level.Add(int.Parse(csv.Context.Record[4]));
                                Gen.Add(int.Parse(csv.Context.Record[1]));
                                Moves.Add(csv.Context.Record[2]);
                            }
                            else if (csv.Context.Record[0] == Entry && int.Parse(csv.Context.Record[1]) == Convert.ToInt32(Generation) && csv.Context.Record[3] == "4")
                            {
                                if (!TMList.Contains(csv.Context.Record[2])) TMList.Add(csv.Context.Record[2]);
                            }
                            else if (csv.Context.Record[0] == Entry && int.Parse(csv.Context.Record[1]) == Convert.ToInt32(Generation) && csv.Context.Record[3] == "3")
                            {
                                if (!Tutor.Contains(csv.Context.Record[2])) Tutor.Add(csv.Context.Record[2]);
                            }
                            else if (csv.Context.Record[0] == Entry && int.Parse(csv.Context.Record[1]) == Convert.ToInt32(Generation) && csv.Context.Record[3] == "2")
                            {
                                if (!Egg.Contains(csv.Context.Record[2])) Egg.Add(csv.Context.Record[2]);
                            }
                            else if (csv.Context.Record[0] == Entry && int.Parse(csv.Context.Record[1]) == Convert.ToInt32(Generation) && csv.Context.Record[3] == "6")
                            {
                                if (!lbe.Contains(csv.Context.Record[2])) lbe.Add(csv.Context.Record[2]);
                            }
                            else if (csv.Context.Record[0] == Entry && int.Parse(csv.Context.Record[1]) == Convert.ToInt32(Generation) && (csv.Context.Record[3] == "7" || csv.Context.Record[3] == "9"))
                            {
                                if (!Purification.Contains(csv.Context.Record[2])) Purification.Add(csv.Context.Record[2]);
                            }
                            else if (csv.Context.Record[0] == Entry && int.Parse(csv.Context.Record[1]) == Convert.ToInt32(Generation) && csv.Context.Record[3] == "10")
                            {
                                if (!FormChange.Contains(csv.Context.Record[2])) FormChange.Add(csv.Context.Record[2]);
                            }
                            else if (csv.Context.Record[0] == Entry && int.Parse(csv.Context.Record[1]) == Convert.ToInt32(Generation) && csv.Context.Record[3] == "8")
                            {
                                if (!Shadow.Contains(csv.Context.Record[2])) Shadow.Add(csv.Context.Record[2]);
                            }
                        }
                        string[] TMArray = TMList.ToArray();
                        string[] EggArray = Egg.ToArray();
                        string[] TutorArray = Tutor.ToArray();
                        string[] LBEArray = lbe.ToArray();
                        string[] PureArray = Purification.ToArray();
                        string[] FormArray = FormChange.ToArray();
                        string[] ShadowArray = Shadow.ToArray();
                        Console.Write("+");

                        //Move_Names
                        string TM = "";
                        string LevelString = "";
                        string SEgg = "";
                        string STutor = "";
                        string SLBE = "";
                        string SPure = "";
                        string SForm = "";
                        string SShadow = "";

                        CsvReader = File.OpenText(csvFiles[93]);
                        csv = new CsvReader(CsvReader);
                        while (csv.Read())
                        {
                            for (int i = 0; i < TMArray.Length; i++)
                            {
                                if (csv.Context.Record[0] == TMArray[i])
                                {
                                    string TMMove = csv.Context.Record[1];
                                    TMMove = TMMove.Replace(' ', '_');
                                    TMMove = TMMove.Replace('-', '_');
                                    TM = TM +
                                    $"new PokemonMoveset" +
                                    $"(" +
                                        $"\n\t\tmoveId: Moves.{TMMove.ToUpper()}," +
                                        $"\n\t\tmethod: LearnMethod.machine" +
                                    $"\n\t), ";
                                }
                            }
                            for (int i = 0; i < EggArray.Length; i++)
                            {
                                if (csv.Context.Record[0] == EggArray[i])
                                {
                                    string EggMove = csv.Context.Record[1];
                                    EggMove = EggMove.Replace(' ', '_');
                                    EggMove = EggMove.Replace('-', '_');
                                    SEgg = SEgg +
                                    $"new PokemonMoveset" +
                                    $"(" +
                                        $"\n\t\tmoveId: Moves.{EggMove.ToUpper()}," +
                                        $"\n\t\tmethod: LearnMethod.egg" +
                                    $"\n\t), ";
                                }
                            }
                            for (int i = 0; i < TutorArray.Length; i++)
                            {
                                if (csv.Context.Record[0] == TutorArray[i])
                                {
                                    string TutorMove = csv.Context.Record[1];
                                    TutorMove = TutorMove.Replace(' ', '_');
                                    TutorMove = TutorMove.Replace('-', '_');
                                    STutor = STutor +
                                    $"new PokemonMoveset" +
                                    $"(" +
                                        $"\n\t\tmoveId: Moves.{TutorMove.ToUpper()}," +
                                        $"\n\t\tmethod: LearnMethod.tutor" +
                                    $"\n\t), ";
                                }
                            }
                            for (int i = 0; i < LBEArray.Length; i++)
                            {
                                if (csv.Context.Record[0] == LBEArray[i])
                                {
                                    string LBEMove = csv.Context.Record[1];
                                    LBEMove = LBEMove.Replace(' ', '_');
                                    LBEMove = LBEMove.Replace('-', '_');
                                    SLBE = SLBE +
                                    $"new PokemonMoveset" +
                                    $"(" +
                                        $"\n\t\tmoveId: Moves.{LBEMove.ToUpper()}," +
                                        $"\n\t\tmethod: LearnMethod.light_ball_egg" +
                                    $"\n\t), ";
                                }
                            }
                            for (int i = 0; i < FormArray.Length; i++)
                            {
                                if (csv.Context.Record[0] == FormArray[i])
                                {
                                    string FormMove = csv.Context.Record[1];
                                    FormMove = FormMove.Replace(' ', '_');
                                    FormMove = FormMove.Replace('-', '_');
                                    SForm = SForm +
                                    $"new PokemonMoveset" +
                                    $"(" +
                                        $"\n\t\tmoveId: Moves.{FormMove.ToUpper()}," +
                                        $"\n\t\tmethod: LearnMethod.form_change" +
                                    $"\n\t), ";
                                }
                            }
                            for (int i = 0; i < PureArray.Length; i++)
                            {
                                if (csv.Context.Record[0] == PureArray[i])
                                {
                                    string PureMove = csv.Context.Record[1];
                                    PureMove = PureMove.Replace(' ', '_');
                                    PureMove = PureMove.Replace('-', '_');
                                    SPure = SPure +
                                    $"new PokemonMoveset" +
                                    $"(" +
                                        $"\n\t\tmoveId: Moves.{PureMove.ToUpper()}," +
                                        $"\n\t\tmethod: LearnMethod.purification" +
                                    $"\n\t), ";
                                }
                            }
                            for (int i = 0; i < ShadowArray.Length; i++)
                            {
                                if (csv.Context.Record[0] == ShadowArray[i])
                                {
                                    string ShadowMove = csv.Context.Record[1];
                                    ShadowMove = ShadowMove.Replace(' ', '_');
                                    ShadowMove = ShadowMove.Replace('-', '_');
                                    SShadow = SShadow +
                                    $"new PokemonMoveset" +
                                    $"(" +
                                        $"\n\t\tmoveId: Moves.{ShadowMove.ToUpper()}," +
                                        $"\n\t\tmethod: LearnMethod.shadow" +
                                    $"\n\t), ";
                                }
                            }
                            for (int i = 0; i < Moves.Count; i++)
                            {
                                if (csv.Context.Record[0] == Moves[i])// && int.Parse(csv.Context.Record[2]) == Convert.ToInt32(Generation)
                                {
                                    //Moves[i] = csv.Context.Record[1];
                                    //MoveLevelDictionary.Add(Moves[i], new int[] { Level[i], Gen[i] });
                                    //string moveId = pair.Key.ToString().Replace(' ', '_');
                                    //moveId = moveId.Replace('-', '_');
                                    LevelString = LevelString +
                                        ($"new PokemonMoveset" +
                                        $"(" +
                                            $"\n\t\tmoveId: Moves.{csv.Context.Record[1].Replace(' ', '_').Replace('-', '_').ToUpper()}," +
                                            $"\n\t\tmethod: LearnMethod.levelup," +
                                            $"\n\t\tlevel: {Level[i]}" +
                                            $"\n\t\t//,generation: {Gen[i]}" +
                                        $"\n\t), ");
                                }
                            }
                        }
                        string FinalMoves = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}",
                        string.IsNullOrWhiteSpace(LevelString) ? "" : "\t" + LevelString,
                        string.IsNullOrWhiteSpace(TM) ? "" : "\n\n\t" + TM,
                        string.IsNullOrWhiteSpace(SEgg) ? "" : "\n\n\t" + SEgg,
                        string.IsNullOrWhiteSpace(STutor) ? "" : "\n\n\t" + STutor,
                        string.IsNullOrWhiteSpace(SLBE) ? "" : "\n\n\t" + SLBE,
                        string.IsNullOrWhiteSpace(SShadow) ? "" : "\n\n\t" + SShadow,
                        string.IsNullOrWhiteSpace(SPure) ? "" : "\n\n\t" + SPure,
                        string.IsNullOrWhiteSpace(SForm) ? "" : "\n\n\t" + SForm
                        );
                        //FinalMoves = FinalMoves.Replace("\n", System.Environment.NewLine);

                        /*If last comma doesnt exist, you could end up removing an entire value off the end
                        var index = FinalMoves.LastIndexOf(',');
                        if (index >= 0)
                        {
                            FinalMoves = FinalMoves.Substring(0, index);
                        }*/

                        Pokemon.Moves = FinalMoves.TrimEnd(',');

                        //Adding the Pokemon to the array
                        Pokemons[PokemonCounter - 1] = Pokemon;

                        //Counters
                        PokemonCounter++;
                        RegionDex++;
                    }

                    int progress = Convert.ToInt32(Generation) / 10;
                    for (int i = 0; i < Pokemons.Length; i++)
                    {
                        Method(i + 1, csvFiles, Pokemons[i].NAME, Pokemons[i], Generation, Pokemons);
                    }

                    using (Output = File.AppendText(OutputFolder + @"\POKEMONOUTPUT " + SelectedGeneration + ".txt"))
                    {
                        foreach (PokemonNew poke in Pokemons)
                        {
                            string OutputText = poke.ToString();
                            OutputText = OutputText.Replace("\n", System.Environment.NewLine);
                            Output.WriteLine(OutputText);
                            Output.Write("\n");
                        }
                    }

                    FinishedLabel.Visible = true;
                    FinishedLabel.Text = ($"Database is done writing, your file can be found in {OutputFolder}/OUTPUT {SelectedGeneration}.txt");
                }
                #endregion
            }
            else
            {
                if(PokemonGenerationComboBox.SelectedItem == null)
                {
                    GenerationWarningLabel.Visible = true;
                }
                else
                {
                    GenerationWarningLabel.Visible = false;
                }

                if(PKUnityVersionComboBox.SelectedItem == null)
                {
                    PokemonDataVersionWarningLabel.Visible = true;
                }
                else
                {
                    PokemonDataVersionWarningLabel.Visible = false;
                }
                if ((CSVFilesLabel.Text != "172 CSV Files found.") && (OutputFolder == "" || OutputFolder == null))
                {
                    FolderWarningLabel.Visible = true;
                    FolderWarningLabel.Text = "Please fill in a valid source path and output path.";
                }
                else if(CSVFilesLabel.Text != "172 CSV Files found.")
                {
                    FolderWarningLabel.Visible = true;
                    FolderWarningLabel.Text = "Please fill in a valid source path. Not enough CSV Files were found.";
                }
                else if(OutputFolder == "" || OutputFolder == null)
                {
                    FolderWarningLabel.Visible = true;
                    FolderWarningLabel.Text = "Please fill in a valid output path.";
                }
                else
                {
                    FolderWarningLabel.Visible = false;
                }
            }
        }
        static string UpperCaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        static void Method(int counter, string[] csvFiles, string name, PokemonNew pokemon, string gen, PokemonNew[] pokemons)
        {
            string MethodCode = "";
            string Item = "";
            TextReader CsvReader = File.OpenText(csvFiles[135]);
            CsvReader csv = new CsvReader(CsvReader);
            while (csv.Read())
            {
                if (csv.Context.Record[1] == (counter).ToString())
                {
                    #region Happiness Evolution
                    if (csv.Context.Record[8] == "night" && !string.IsNullOrEmpty(csv.Context.Record[11]))
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.HappinessNight, {csv.Context.Record[11]}),";
                    }
                    else if (csv.Context.Record[8] == "day" && !string.IsNullOrEmpty(csv.Context.Record[11]))
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.HappinessDay, {csv.Context.Record[11]}),";
                    }
                    else if (!string.IsNullOrEmpty(csv.Context.Record[11]))
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Happiness, {csv.Context.Record[11]}),";
                    }
                    #endregion

                    #region Item Evolution
                    if (csv.Context.Record[2] == "3" && csv.Context.Record[5] == "1" && !string.IsNullOrEmpty(csv.Context.Record[3]))
                    {
                        Item = csv.Context.Record[3];
                        TextReader CsvReader2 = File.OpenText(csvFiles[69]);
                        CsvReader csv2 = new CsvReader(CsvReader2);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == Item)
                            {
                                string tempItem = csv2.Context.Record[1];
                                tempItem = tempItem.Replace('-', '_');
                                tempItem = tempItem.Replace(' ', '_');
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.ItemFemale, {tempItem}),";
                                break;
                            }
                        }
                    }
                    else if (csv.Context.Record[2] == "3" && csv.Context.Record[5] == "2" && !string.IsNullOrEmpty(csv.Context.Record[3]))
                    {
                        Item = csv.Context.Record[3];
                        TextReader CsvReader2 = File.OpenText(csvFiles[69]);
                        CsvReader csv2 = new CsvReader(CsvReader2);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == Item)
                            {
                                string tempItem = csv2.Context.Record[1];
                                tempItem = tempItem.Replace('-', '_');
                                tempItem = tempItem.Replace(' ', '_');
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.ItemMale, {tempItem}),";
                                break;
                            }
                        }
                    }
                    else if (csv.Context.Record[2] == "3" && !string.IsNullOrEmpty(csv.Context.Record[3]))
                    {
                        Item = csv.Context.Record[3];
                        TextReader CsvReader2 = File.OpenText(csvFiles[69]);
                        CsvReader csv2 = new CsvReader(CsvReader2);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == Item)
                            {
                                string tempItem = csv2.Context.Record[1];
                                tempItem = tempItem.Replace('-', '_');
                                tempItem = tempItem.Replace(' ', '_');
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Item, {tempItem}),";
                                break;
                            }
                        }
                    }
                    #endregion

                    #region Location Evolution
                    if (!string.IsNullOrEmpty(csv.Context.Record[6]))
                    {
                        string LocationId = csv.Context.Record[6];
                        TextReader CsvReader2 = File.OpenText(csvFiles[91]);
                        CsvReader csv2 = new CsvReader(CsvReader);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == LocationId)
                            {
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Location, //location: map: {csv.Context.Record[1]}\n),";
                                break;
                            }
                        }
                    }
                    #endregion

                    #region Trade Evolution
                    string test2 = csv.Context.Record[17];
                    string test = csv.Context.Record[2];
                    if (!string.IsNullOrEmpty(csv.Context.Record[17]) && csv.Context.Record[2] == "2")
                    {
                        string EvolutionSpecies = csv.Context.Record[17];
                        TextReader CsvReader2 = File.OpenText(csvFiles[129]);
                        var csv2 = new CsvReader(CsvReader2);

                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == EvolutionSpecies)
                            {
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.TradeSpecies, {csv.Context.Record[1].ToUpper()}),";
                                break;
                            }
                        }
                    }
                    else if (csv.Context.Record[2] == "2" && !string.IsNullOrEmpty(csv.Context.Record[7]) && csv.Context.Record[17] == "")
                    {
                        Item = csv.Context.Record[7];
                        TextReader CsvReader2 = File.OpenText(csvFiles[69]);
                        CsvReader csv2 = new CsvReader(CsvReader2);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == Item)
                            {
                                string tempItem = csv2.Context.Record[1];
                                tempItem = tempItem.Replace('-', '_');
                                tempItem = tempItem.Replace(' ', '_');
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.TradeItem, {tempItem}),";
                                break;
                            }
                        }
                    }
                    else if (csv.Context.Record[2] == "2" && csv.Context.Record[7] == "" && csv.Context.Record[17] == "")
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Trade) ";
                    }
                    #endregion

                    #region Hold Item
                    if (csv.Context.Record[2] == "1" && !string.IsNullOrEmpty(csv.Context.Record[7]) && csv.Context.Record[8] == "day")
                    {
                        Item = csv.Context.Record[7];
                        TextReader CsvReader2 = File.OpenText(csvFiles[69]);
                        CsvReader csv2 = new CsvReader(CsvReader2);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == Item)
                            {
                                string tempItem = csv2.Context.Record[1];
                                tempItem = tempItem.Replace('-', '_');
                                tempItem = tempItem.Replace(' ', '_');
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.HoldItemDay, {tempItem}),";
                                break;
                            }
                        }
                    }
                    else if (csv.Context.Record[2] == "1" && !string.IsNullOrEmpty(csv.Context.Record[7]) && csv.Context.Record[8] == "night")
                    {
                        Item = csv.Context.Record[7];
                        TextReader CsvReader2 = File.OpenText(csvFiles[69]);
                        CsvReader csv2 = new CsvReader(CsvReader2);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == Item)
                            {
                                string tempItem = csv2.Context.Record[1];
                                tempItem = tempItem.Replace('-', '_');
                                tempItem = tempItem.Replace(' ', '_');
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.HoldItemNight, {tempItem}),";
                                break;
                            }
                        }
                    }
                    else if (csv.Context.Record[2] == "1" && !string.IsNullOrEmpty(csv.Context.Record[7]))
                    {
                        Item = csv.Context.Record[7];
                        TextReader CsvReader2 = File.OpenText(csvFiles[69]);
                        CsvReader csv2 = new CsvReader(CsvReader2);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == Item)
                            {
                                string tempItem = csv2.Context.Record[1];
                                tempItem = tempItem.Replace('-', '_');
                                tempItem = tempItem.Replace(' ', '_');
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.HoldItem, {tempItem}),";
                                break;
                            }
                        }
                    }
                    #endregion

                    #region Beauty
                    if (csv.Context.Record[2] == "1" && !string.IsNullOrEmpty(csv.Context.Record[12]))
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Beauty, {csv.Context.Record[12]}),";
                    }
                    #endregion

                    #region Move
                    if (csv.Context.Record[2] == "1" && !string.IsNullOrEmpty(csv.Context.Record[9]) && csv.Context.Record[15] == "")
                    {
                        string tempMove = csv.Context.Record[9];
                        TextReader CsvReader2 = File.OpenText(csvFiles[114]);
                        CsvReader csv2 = new CsvReader(CsvReader2);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == tempMove && csv.Context.Record[1] == gen)
                            {
                                tempMove = csv2.Context.Record[2];
                                tempMove = tempMove.Replace(' ', '_');
                                tempMove = tempMove.Replace('-', '_');
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Move, {tempMove}),";
                                break;
                            }
                        }
                    }
                    else if (csv.Context.Record[2] == "1" && !string.IsNullOrEmpty(csv.Context.Record[10]))
                    {
                        string tempType = csv.Context.Record[10];
                        TextReader CsvReader2 = File.OpenText(csvFiles[114]);
                        CsvReader csv2 = new CsvReader(CsvReader2);
                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == tempType && csv2.Context.Record[1] == gen)
                            {
                                tempType = csv2.Context.Record[1];
                                tempType = tempType.Replace(' ', '_');
                                tempType = tempType.Replace('-', '_');
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Move, {tempType}),";
                                break;
                            }
                        }
                    }
                    #endregion

                    #region Party
                    if (csv.Context.Record[2] == "1" && !string.IsNullOrEmpty(csv.Context.Record[15]))
                    {
                        string EvolutionSpecies = csv.Context.Record[15];
                        TextReader CsvReader2 = File.OpenText(csvFiles[129]);
                        var csv2 = new CsvReader(CsvReader2);

                        while (csv2.Read())
                        {
                            if (csv2.Context.Record[0] == EvolutionSpecies)
                            {
                                MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Party, {csv.Context.Record[1].ToUpper()}),";
                                break;
                            }
                        }
                    }
                    #endregion

                    #region Attack > Defense > Equal =
                    if (csv.Context.Record[2] == "1" && csv.Context.Record[14] == "1")           //Attack Greater Than Defense (Attack > Defense)    1
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.AttackGreater),";
                    }
                    else if (csv.Context.Record[2] == "1" && csv.Context.Record[14] == "-1")    //Defense Greater Than Attack (Attack < Defense)    -1
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.DefenseGreater),";
                    }
                    else if (csv.Context.Record[2] == "1" && csv.Context.Record[14] == "-1")    //Attack Equal To Attack (Attack = Defense)         0
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.AtkDefEqual),";
                    }
                    #endregion

                    #region Silcoon
                    if (csv.Context.Record[1] == "266" && csv.Context.Record[2] == "1")
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Silcoon),";
                    }
                    #endregion

                    #region Cascoon
                    if (csv.Context.Record[1] == "268" && csv.Context.Record[2] == "1")
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Cascoon),";
                    }
                    #endregion

                    #region Ninjask
                    if (csv.Context.Record[1] == "291" && csv.Context.Record[2] == "1")
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Ninjask),";
                    }
                    #endregion

                    #region Shedinja
                    if (csv.Context.Record[1] == "292" && csv.Context.Record[2] == "1")
                    {
                        MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Shedinja),";
                    }
                    #endregion

                    #region Level
                    if (csv.Context.Record[2] == "1" && csv.Context.Record[3] == "" && !string.IsNullOrEmpty(csv.Context.Record[4]) && csv.Context.Record[11] == "" && csv.Context.Record[19] == "0")
                    {
                        if (csv.Context.Record[5] == "1")
                        {
                            MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.LevelFemale, {csv.Context.Record[4]}),";
                        }
                        else if (csv.Context.Record[5] == "2")
                        {
                            MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.LevelMale, {csv.Context.Record[4]}),";
                        }
                        else
                        {
                            MethodCode = MethodCode + $"\n\tnew PokemonEvolution(Pokemons.{name.ToUpper()}, EvolutionMethod.Level, {csv.Context.Record[4]}),";
                        }
                    }
                    #endregion
                    break;
                }
            }
            CsvReader = File.OpenText(csvFiles[149]);
            csv = new CsvReader(CsvReader);
            while (csv.Read())
            {
                if (csv.Context.Record[0] == counter.ToString() && !string.IsNullOrEmpty(csv.Context.Record[3]))
                {
                    if (int.Parse(csv.Context.Record[3]) < pokemons.Length)
                    {
                        string output;
                        /*if (MethodCode != "")
                        {
                            MethodCode = MethodCode.Remove(MethodCode.Length - 1);
                        }*/
                        //Cleaner to remove only want you need it to; just in case a problem occurs, you're prepared.
                        output = MethodCode.TrimEnd(',').Replace("\n", System.Environment.NewLine);
                        pokemons[int.Parse(csv.Context.Record[3]) - 1].PokemonEvolution = pokemons[int.Parse(csv.Context.Record[3]) - 1].PokemonEvolution + output;
                        break;
                    }
                }
            }
        }
    }
}