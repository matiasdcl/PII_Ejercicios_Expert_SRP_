using System;
using System.Collections.Generic;
namespace SRP;

public class Shelve
{
    public string ShelveName = "";
    public List<Book> Shelves = new List<Book> { };

    public Shelve(string name)
    {
        this.ShelveName = name;
    }

    public void AddBookToShelve(Book x)
    {
        Shelves.Add(x);
    }

}