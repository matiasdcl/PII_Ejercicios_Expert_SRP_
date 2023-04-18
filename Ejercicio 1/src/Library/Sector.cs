using System;
using System.Collections.Generic;
namespace SRP;

public class Sector
{
    public string SectorName = "";
    public List<Shelve> Sectors = new List<Shelve> { };

    public Sector(string name)
    {
        this.SectorName = name;
    }

    public void AddShelveToSector(Shelve shelve)
    {
        Sectors.Add(shelve);
    }

}
