using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    abstract class Location
    {
        public const string NEW_LINE = "\r\n";

        public string Name { get; private set; }

        public virtual string Description
        {
            get { 
                var exits = string.Join(", ", Exits.Select(e => e.Name).ToArray());
                return $"You're standing in the {Name}.{NEW_LINE}You see exists to the following places: {exits}.";
            }
        }

        public Location[] Exits;

        public Location(string name)
        {
            Name = name;
        }
    }
}
