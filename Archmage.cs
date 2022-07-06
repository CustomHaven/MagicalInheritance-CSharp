// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage // Q13
    {
        //  CONSTRUCTOR - Q19 origin
        public Archmage(string title) : base(title) // Q14
        { }

        // Overload - Q19
        public Archmage(string title, string origin) : base(title, origin)
        { }

        public override Storm CastRainStorm() // Q15
        {
            return new Storm("rain", true, Title);
        }

        public Storm CastLightningStorm() // Q17
        {
            return new Storm("lightning", true, Title);
        }
    }
}
