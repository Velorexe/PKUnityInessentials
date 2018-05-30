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

        public string Luminance { get; set; }       //Done
        public string LightColor { get; set; }      //Done

        public string LevelMoves { get; set; }
        public string TMMoves { get; set; }

        public string PokemonEvolution { get; set; }//Done
        public string LevelEvolution { get; set; }  //Done

        public string Forms { get; set; }
        public string HeldItem { get; set; }

        public override string ToString()
        {
            return string.Format($"new PokemonData( Id: Pokemons.{NAME.ToUpper()}, regionalDex: new int[{RegionalDex}], type1: Types.{Type1}, type2: Types.{Type2},\n" +
                $"ability1: Abilities.{Ability1}, ability2: Abilities.{Ability2}, hiddenAbility: Abilities.{HiddenAbility},\n" +
                $"maleRatio: {MaleRatio}, catchRate: {CatchRate}, eggGroup1: EggGroups.{EggGroup1}, eggGroup2: EggGroups.{EggGroup2}, hatchTime: {HatchTime},\n" +
                $"height: {Height}, weight: {Weight}, baseExpYield: {EXPYield}, levelingRate: LevelingRate.{LevelingRate},\n" +
                $"pokedexColor: Color.{PokedexColor}, baseFriendship: {BaseFriendship},\n" +
                $"baseStatsHP: {BSHP}, baseStatsATK: {BSATK}, baseStatsDEF: {BSDEF}, baseStats: {BSSPA}, baseStatsSPD: {BSSPD}, baseStatsSPE: {BSSPE},\n" +
                $"luminance: {Luminance},\n" +
                @"movesetmoves: new PokemonMoveset[] " +
                $"\n" +
                @"{{" +
                $"{LevelMoves}\n" +
                $"{TMMoves}\n" +
                @"}}," +
                $"\n" +
                @"evolution: new IPokemonEvolution[] {{" +
                $"{PokemonEvolution}" +
                @"}}," +
                $"\nheldItem: {HeldItem})");
        }
    }
}
