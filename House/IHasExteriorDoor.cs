using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
