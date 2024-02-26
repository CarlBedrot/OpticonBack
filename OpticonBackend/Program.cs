using System;

    public partial class Program
    {
        static void Main(string[] args)
        {
            // Create a new Picture object
            Picture picture = new Picture
            {
                Id = 1,
                Name = "ExamplePicture",
                Grid = "TestGrid"
            };

            // Output some information about the picture
            Console.WriteLine($"Id: {picture.Id}, Name: {picture.Name}");
        }
    }

