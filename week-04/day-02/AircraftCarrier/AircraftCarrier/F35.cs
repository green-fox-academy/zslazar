using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    /*            
    F35
    Max ammo: 12
    Base damage: 50
    All the aircrafts should be created with empty ammo store
    */
    public class F35 : Aircrafts
    {
        public F35()
        {
            MaxAmmo = 12;
            BaseDamage = 50;
        }
    }
}
