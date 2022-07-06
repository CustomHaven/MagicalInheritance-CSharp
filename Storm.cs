// Storm.cs
using System;

namespace MagicalInheritance
{
    class Storm : Spell
    {
        // FIELDS

        // PROPERTIES - Q2
        /* As for Q19 we place this inside the abstract class Spell
        public override string Essence
        { get; private set; }
        public override bool IsStrong
        { get; private set; }
        public override string Caster
        { get; private set; }
        */

        // CONSTRUCTOR
        public Storm(string essence, bool isStrong, string caster)
        { // Q3
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        public override string Announce() // Q4
        {
            string strength = IsStrong == true ? "strong" : "weak";
            return $"{Caster} cast a {strength} {Essence} storm!";
        }

    }
}
