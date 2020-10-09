using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Opponent
    {
        private Random random;

        private Location myLocation;

        public Opponent(Location startingLocation)
        {
            myLocation = startingLocation;
            random = new Random();
        }

        public void Move()
        {
            while (true)
            {
                if (myLocation is IHasExteriorDoor)
                {
                    IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;
                    if (random.Next(2) == 1)
                    {
                        myLocation = locationWithDoor.DoorLocation;
                    }
                }
                int rand = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];
                if (myLocation is IHidingPlace)
                {
                    break;
                }
            }
        }

        public bool Check(Location locationToCheck)
        {
            return locationToCheck == myLocation;
        }
    }
}
