using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKUnity_PokemonDatabase_Maker
{
    class PokemonOld
    {
        public string ID { get; set; }              //Done
        public string NAME { get; set; }            //Done
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
        public string BaseFrienship { get; set; }   //Done
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
        public string Level { get; set; }           //Done
        public string Moves { get; set; }           //Done
        public string TMMoves { get; set; }         //Done
        public string PokemonEvolution { get; set; }//Done
        public string LevelEvolution { get; set; }  //Done

        public override string ToString()
        {
            return string.Format($"new PokemonData({ID}, \"{NAME}\", PokemonData.Type.{Type1}, PokemonData.Type.{Type2}, \"{Ability1}\", \"{Ability2}\", \"{HiddenAbility}\",\n\t" +
                 $"{MaleRatio}, {CatchRate}, PokemonData.EggGroup.{EggGroup1}, PokemonData.EggGroup.{EggGroup2}, {HatchTime}, {Height}, {Weight},\n\t" +
                 $"{EXPYield}, PokemonData.LevelingRate.{LevelingRate}, {EYHP}, {EYATK}, {EYDEF}, {EYSPA}, {EYSPD}, {EYSPE}, PokemonData.PokedexColor.{PokedexColor}, {BaseFrienship},\n\t" +
                 $"\"{Species}\", \"{Description}\",\n\t" +
                 $"{BSHP}, {BSATK}, {BSDEF}, {BSSPA}, {BSSPD}, {BSSPE}, {Luminance}, Color.{LightColor},\n\t" +
                 @"new int[] {{" +
                 $"{Level}" +
                 @"}}," +

                 $"\n\t" +
                 @"new string[]" +
                 $"\n\t" +
                 @"{{" +
                 $"\n\t\t{Moves}\n\t" +
                 @"}}," +
                 $"\n\t" +

                 @"new string[]" +
                 $"\n\t" +
                 @"{{" +
                 $"\n\t\t{TMMoves}\n\t" +
                 @"}}," +

                 $"\n\t" +
                 @"new int[] {{" +
                 $"{PokemonEvolution}" +
                 @"}}, " +

                 @"new string[] {{" +
                 $"{LevelEvolution}" +
                 @"}})," +
                 $"\n");
        }
    }
}
