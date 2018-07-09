using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVDatabaseReader
{
    class Move
    {
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Catagory { get; set; }
        public string Power { get; set; }
        public string Accuracy { get; set; }
        public string PP { get; set; }
        public enum target
        {
            SELF,
            ADJACENT,
            ANY,
            ADJACENTALLY,
            ADJACENTOPPONENT,
            ADJACENTALLYSELF,
            ALL,
            ALLADJACENT,
            ALLADJACENTOPPONENT,
            ALLOPPONENT,
            ALLALLY
        }
        public target Target { get; set; }
        public string Priority { get; set; }
        public bool Contact { get; set; }
        public bool Protectable { get; set; }
        public bool MagicCoat { get; set; }
        public bool Snatchable { get; set; }
        public enum moveEffects
        {
            /// <summary>
            /// if this check fails, no later effects will run
            /// </summary>
            Chance,
            /// <summary>
            /// for the very specific move effects
            /// </summary>
            Unique,
            Sound, Punch, Powder,
            /// <summary>
            /// (only works on 0= opposite, 1= opposite or genderless)
            /// </summary>
            Gender,
            Burn, Freeze, Paralyze, Poison, Sleep, Toxic,
            /// <summary>
            /// (chance)
            /// </summary>
            ATK, DEF, SPA, SPD, SPE, ACC, EVA,
            ATKself, DEFself, SPAself, SPDself, SPEself, ACCself, EVAself,
            /// <summary>
            /// (x=set, 0=2-5)
            /// </summary>
            xHits,
            /// <summary>
            /// (amount)
            /// </summary>
            Heal,
            /// <summary>
            /// (amount)
            /// </summary>
            HPDrain,
            /// <summary>
            /// (x=set, 0=level)
            /// </summary>
            SetDamage,
            /// <summary>
            /// based off of user's maxHp
            /// </summary>
            Critical, Recoil,
            Flinch, RecoilMax
        }
        public moveEffects MoveEffects { get; set; }
        public string MoveParamters { get; set; }
        public enum contest
        {
            COOL,
            BEAUTIFUL,
            CUTE,
            CLEVER,
            TOUGH
        }
        public contest Contest { get; set; }
        public string Appeal { get; set; }
        public string Jamming { get; set; }
        public string Description { get; set; }

        /*public override string ToString()
        {
            return string.Format();
        }*/
    }
}
