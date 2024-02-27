using System;

public partial class Program
{
    static void Main(string[] args)
    {
        // Create a new Picture object
        var db = new TopologiEditorContext();



        db.Add(new Picture
        {
            Name = "My test picture",
            Grid = "Grid213",
        });

        db.SaveChanges();

        var changes = db.SaveChanges();
        Console.WriteLine(changes);
    }
}

