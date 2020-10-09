using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; private set; }

        public override string Description
        {
            get
            {
                return $"{base.Description}{NEW_LINE}Someone could hide {HidingPlaceName}";
            }
        }
    }
}
