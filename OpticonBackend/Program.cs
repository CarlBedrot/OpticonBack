using System;
using System.Data.Common;

public partial class Program
    {
        static void Main(string[] args)
        {
            using var context = new TopologiEditorContext();

            context.Database.EnsureCreated();
            context.SaveChanges();
            foreach (var picture in context.Pictures) {
                Console.WriteLine($"Picture {picture.Name} has grid {picture.Grid}");
            }
        }
    }

