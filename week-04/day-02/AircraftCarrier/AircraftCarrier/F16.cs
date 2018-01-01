using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    /*   
    F16
    Max ammo: 8
    Base damage: 30
    All the aircrafts should be created with empty ammo store
    */

    public class F16 : Aircrafts
    {
        public F16()
        {
            MaxAmmo = 8;
            BaseDamage = 30;
        }
    }
}
