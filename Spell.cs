// Spell.cs
using System;

namespace MagicalInheritance
{ // Q19 abstract
    abstract class Spell
    {
        public string Essence
        { get; protected set; }

        public bool IsStrong
        { get; protected set; }

        public string Caster
        { get; protected set; }

        public abstract string Announce();
    }
}
