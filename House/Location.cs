using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    abstract class Location
    {

        public string Name { get; private set; }

        public virtual string Description
        {
            get { 
                var exits = string.Join(", ", Exits.Select(e => e.Name).ToArray());
                return $"You're standing in the {Name}. You see exists to the following places: {exits}.";
            }
        }

        public Location[] Exits;

        public Location(string name)
        {
            Name = name;
        }
    }
}
