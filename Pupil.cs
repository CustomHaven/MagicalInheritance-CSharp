// Pupil.cs
using System;

namespace MagicalInheritance
{
    class Pupil // Q6 Properties and constructor
    {
        // PROPERTIES
        public string Title
        { get; private set; }

        // Q19 extras
        public string Origin
        { get; private set; }

        // CONSTRUCTOR
        public Pupil(string title)
        {
            Title = title;
        }

        //  - Q19 we add an Overload
        public Pupil(string title, string origin) : this(title)
        {
            Origin = origin;
        }

        // METHOD

        public Storm CastWindStorm() // Q7
        {
            return new Storm("wind", false, Title);
        }

    }
}
