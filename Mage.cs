// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil // Q9
    {
        // CONSTRUCTOR - Q19 origin
        public Mage(string title) : base(title) // Q10
        { }

        // Overload - Q19
        public Mage(string title, string origin) : base(title, origin)
        { }

        // METHODS
        // Q16 we put virtual in the method so a child class can override
        public virtual Storm CastRainStorm() // Q11 
        {
            return new Storm("rain", false, Title);
        }

    }
}
