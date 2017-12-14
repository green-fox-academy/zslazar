﻿using System;
using System.Collections.Generic;


namespace _05_FleetOfThings
{
    class Thing
    {
    private string Name;
    private bool Completed;

    public Thing(string name)
    {
        this.Name = name;
    }

    public void Complete()
    {
        this.Completed = true;
    }

    public bool GetCompleted()
    {
       return Completed;
    }

    public string GetName()
    {
        return Name;
    }
    }
}
