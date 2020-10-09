using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorDescription) 
            : base(name, decoration, hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }

        public override string Description
        {
            get
            {
                return $"{base.Description}{NEW_LINE}You see {DoorDescription}.";
            }
        }
    }
}
