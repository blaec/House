using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.DoorDescription = doorDescription;
        }

        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }

        public override string Description
        {
            get
            {
                return $"{base.Description} You see {DoorDescription}."; 
            }
        }
    }
}
