using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace CSVDatabaseReader
{
    class Pokemon
    {
        public string RegionalDex { get; set; }     //Done
        public string ID { get; set; }              //Done
        public string NAME { get; set; }            //Done
        public enum Types
        {
            NONE = 0,
            NORMAL = 1,
            FIGHTING = 2,
            FLYING = 3,
            POISON = 4,
            GROUND = 5,
            ROCK = 6,
            BUG = 7,
            GHOST = 8,
            STEEL = 9,
            FIRE = 10,
            WATER = 11,
            GRASS = 12,
            ELECTRIC = 13,
            PSYCHIC = 14,
            ICE = 15,
            DRAGON = 16,
            DARK = 17,
            FAIRY = 18,
            UNKNOWN = 10001,
            SHADOW = 10002
        }
        public string Type1 { get; set; }           //Done
        public string Type2 { get; set; }           //Done

        public string Ability1 { get; set; }        //Done
        public string Ability2 { get; set; }        //Done
        public string HiddenAbility { get; set; }   //Done

        public string MaleRatio { get; set; }       //Done

        public string CatchRate { get; set; }       //Done

        public string EggGroup1 { get; set; }       //Done
        public string EggGroup2 { get; set; }       //Done

        public string HatchTime { get; set; }       //Done

        public string Height { get; set; }          //Done
        public string Weight { get; set; }          //Done

        public string EXPYield { get; set; }        //Done
        public string LevelingRate { get; set; }    //Done

        public string EYHP { get; set; }            //Done
        public string EYATK { get; set; }           //Done
        public string EYDEF { get; set; }           //Done
        public string EYSPA { get; set; }           //Done
        public string EYSPD { get; set; }           //Done
        public string EYSPE { get; set; }           //Done

        public string PokedexColor { get; set; }    //Done

        public string BaseFriendship { get; set; }   //Done

        public string Species { get; set; }         //Done

        public string Description { get; set; }     //Done

        public string BSHP { get; set; }            //Done
        public string BSATK { get; set; }           //Done
        public string BSDEF { get; set; }           //Done
        public string BSSPA { get; set; }           //Done
        public string BSSPD { get; set; }           //Done
        public string BSSPE { get; set; }           //Done

        public string Luminance { get; set; }       //not needed
        public string LightColor { get; set; }      //Done

        public string Moves { get; set; }           //Replaced with one string, easier this way

        public string PokemonEvolution { get; set; }//Done
        public string LevelEvolution { get; set; }  //Done

        public string Forms { get; set; }			//manually
        public string HeldItem { get; set; }		//manually

        ///<summary>Int value doesnt matter, ex `.ToString(1);`</summary>
        public override string ToString()
        {
            return string.Format("new PokemonData({0} {1} {2} {3} {4} {5} {6} {7} {8} {9} " +
                                                "{10} {11} {12} {13} {14} {15} {16} {17} {18} {19} " +
                                                "{20} {21} {22} {23} {24} {25} {26} {27} {28} {29} " +
                                                "{30} {31}),",
                NAME == null ? ""                   : "\nId: Pokemons." + System.Text.RegularExpressions.Regex.Replace(NAME.ToUpper().Replace('-', '_'),@"[\.']",""),
                RegionalDex == null ? ""            : ",\n//regionalDex: new int[]{" + RegionalDex + "}",
                Type1 == null || Type1 == "NONE" ? "" : ",\ntype1: Types." + Type1,
                Type2 == null || Type2 == "NONE" ? "" : ",\ntype2: Types." + Type2,
                Ability1 == null || Ability1 == "NONE" ? "" : ",\nability1: Abilities." + Ability1,
                Ability2 == null || Ability2 == "NONE" ? "" : ",\nability2: Abilities." + Ability2,
                HiddenAbility == null || HiddenAbility == "NONE" ? "" : ",\nhiddenAbility: Abilities." + HiddenAbility,
                MaleRatio == null ? ""              : ",\nmaleRatio: " + MaleRatio,
                CatchRate == null ? ""              : ",\ncatchRate: " + CatchRate,
                EggGroup1 == null || EggGroup1 == "NONE" ? "" : ",\neggGroup1: EggGroups." + EggGroup1,
                EggGroup2 == null || EggGroup2 == "NONE" ? "" : ",\neggGroup2: EggGroups." + EggGroup2,
                HatchTime == null ? ""              : ",\nhatchTime: " + HatchTime,
                Height == null ? ""                 : ",\nheight: " + Height,
                Weight == null ? ""                 : ",\nweight: " + Weight,
                LevelingRate == null ? ""           : ",\nlevelingRate: LevelingRate." + LevelingRate,//\n" +
                PokedexColor == null ? ""           : ",\npokedexColor: Color." + PokedexColor,
                BaseFriendship == null ? ""         : ",\nbaseFriendship: " + BaseFriendship,
                EXPYield == null ? ""               : ",\nbaseExpYield: " + EXPYield,
                BSHP == null ? ""                   : ",\nbaseStatsHP: " + BSHP,
                BSATK == null ? ""                  : ",baseStatsATK: " + BSATK,
                BSDEF == null ? ""                  : ",baseStatsDEF: " + BSDEF,
                BSSPA == null ? ""                  : ",baseStatsSPA: " + BSSPA,
                BSSPD == null ? ""                  : ",baseStatsSPD: " + BSSPD,
                BSSPE == null ? ""                  : ",baseStatsSPE: " + BSSPE,//\n" +
                EYHP == null || EYHP == "0" ? ""    : ",\nevHP: " + EYHP,
                EYATK == null || EYATK == "0" ? ""  : ",\nevATK: " + EYATK,
                EYDEF == null || EYDEF == "0" ? ""  : ",\nevDEF: " + EYDEF,
                EYSPA == null || EYSPA == "0" ? ""  : ",\nevSPA: " + EYSPA,
                EYSPD == null || EYSPD == "0" ? ""  : ",\nevSPD: " + EYSPD,
                EYSPE == null || EYSPE == "0" ? ""  : ",\nevSPE: " + EYSPE,//\n" +
                //NAME == null? "" : "$"luminance: "+Luminance,\n" +
                ",\nmovesetmoves: new PokemonMoveset[] " +
                //$"\n" +
                "{\n" +
                    //trimend goes on last value, but there's also a comma before every value so it's fine
                    //it balances out the extra, and also if the value is null, you're not left with additional
                    //or dangling commas to trigger any errors.
                    Moves.Replace("'","").TrimEnd(',') + "\n" +
                "}",
                //$"\n" +
                PokemonEvolution == null ? "" : ",\nevolution: new IPokemonEvolution[] {" + PokemonEvolution.TrimEnd(',') + "\n}"
                //,HeldItem == null? "" : "heldItem: "+HeldItem +","
             );
        }
    }
}