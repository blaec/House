using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return $"You see {base.Description}.";
            }
        }
    }
}
