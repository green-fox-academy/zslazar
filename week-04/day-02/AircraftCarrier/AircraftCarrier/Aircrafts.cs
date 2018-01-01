using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    /*Aircrafts
    Create a class that represents an aircraft
    There are 2 types of aircrafts: F16 and F35
    Both aircraft should track how many ammo it has 
    All the aircrafts should be created with empty ammo store
    
    Methods:
    fight
        It should use all the ammos (set it to 0) and it should return the damage it deals
        The damage is the multiplication of the base damage and the ammos
    refill
        It should take a number as parameter and substract as much ammo as possibe
        It can't have more ammo than the number or the max ammo
        It should return the remaining ammo
        Eg. Filling an empty F35 with 300 would completely fill the storage of the aircraft and would return the remaining 288
    getType
        It should return it's type as a string
    getStatus
        It should return a string like: Type F35, Ammo: 10, Base Damage: 50, All Damage: 500*/

    public class Aircrafts
    {
        public int MaxAmmo { get; set; }
        public int BaseDamage { get; set; }
        public int CurrentAmmo { get; set; }
        public int AllDamage { get; set; }

    }
}
