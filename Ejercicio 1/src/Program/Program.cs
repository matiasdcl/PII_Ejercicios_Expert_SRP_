

namespace SRP
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Sector sector1 = new Sector("A");
            Shelve shelve1 = new Shelve("A1");
            shelve1.AddBookToShelve(book1);
            sector1.AddShelveToSector(shelve1);
        }
    }
}