using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }
        
        public string HidingPlaceName { get; private set; }

        public override string Description
        {
            get
            {
                return $"{base.Description}{NEW_LINE}Someone could hide {HidingPlaceName}.";
            }
        }
    }
}
