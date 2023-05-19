using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InputToJsonFormatTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BookClass> bookList = new List<BookClass>();
            List<ProductClass> productList = new List<ProductClass>();
            List<PeopleClass> peopleList = new List<PeopleClass>();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filename = @"theJsondata.txt";
            string path = Path.Combine(desktopPath, filename);
            string jsondata = "";
            Console.WriteLine("What type of data do you want to convert to Json?");
            Console.WriteLine("Press 'B' to make book data, Press 'P' to make Product data, Press 'H' to make data for people, Press any other key to quit.");
            string type = Console.ReadLine();
            switch (type.ToLower())
            {
                case "b":
                    while (true)
                    {
                        Console.WriteLine("What is the title of your book? :");
                        string title = Console.ReadLine();
                        Console.WriteLine("What is the price of the book? :");
                        string price = Console.ReadLine();
                        Console.WriteLine("What is the description of the book? :");
                        string description = Console.ReadLine();
                        Console.WriteLine("The url of the image :");
                        string image = Console.ReadLine();
                        Console.WriteLine("Who is the author of the book? :");
                        string author = Console.ReadLine();
                        Console.WriteLine("Do you want to continue adding data? 'Y' to continue, any other key to quit.");
                        string answer = Console.ReadLine();
                        bookList.Add(new BookClass(title, Convert.ToDouble(price), description, image, author));
                        if (answer.ToLower() != "y")
                        {
                            jsondata = JsonSerializer.Serialize(bookList);
                            break;
                        }
                    }
                    Console.WriteLine("Finished adding all the book data");
                    Console.WriteLine("---------- Gap ----------");
                    Console.WriteLine("Books inserted =>");
                    foreach (var each in bookList)
                    {
                        Console.WriteLine(each.ToString());
                    }
                    break;
                case "p":
                    while (true)
                    {
                        Console.WriteLine("What is the name of your product? :");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is the price of the product? :");
                        string price = Console.ReadLine();
                        Console.WriteLine("The url of the image :");
                        string image = Console.ReadLine();
                        Console.WriteLine("What is the description of the product? :");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the rating of the product? :");
                        string rating = Console.ReadLine();
                        Console.WriteLine("Where is the origin of the product? :");
                        string origin = Console.ReadLine();
                        Console.WriteLine("Do you want to continue adding data? 'Y' to continue, any other key to quit.");
                        string answer = Console.ReadLine();
                        productList.Add(new ProductClass(name, Convert.ToDouble(price), image, description, rating, origin));
                        if (answer.ToLower() != "y")
                        {
                            jsondata = JsonSerializer.Serialize(productList);
                            break;
                        }
                    }
                    Console.WriteLine("Finished adding all the product data");
                    Console.WriteLine("---------- Gap ----------");
                    Console.WriteLine("Products inserted =>");
                    foreach (var each in productList)
                    {
                        Console.WriteLine(each.ToString());
                    }
                    break;
                case "h":
                    while (true)
                    {
                        Console.WriteLine("Please insert the Name? :");
                        string name = Console.ReadLine();
                        Console.WriteLine("insert the Age :");
                        string age = Console.ReadLine();
                        Console.WriteLine("insert the Job please :");
                        string job = Console.ReadLine();
                        Console.WriteLine("What is the salary? :");
                        string salary = Console.ReadLine();
                        Console.WriteLine("Any quote? (e.g. No Pain, No Gain. ) :");
                        string quote = Console.ReadLine();
                        Console.WriteLine("Do you want to continue adding data? 'Y' to continue, any other key to quit.");
                        string answer = Console.ReadLine();
                        peopleList.Add(new PeopleClass(name, Convert.ToInt32(age), job, Convert.ToDouble(salary), quote));
                        if (answer.ToLower() != "y")
                        {
                            jsondata = JsonSerializer.Serialize(peopleList);
                            break;
                        }
                    }
                    Console.WriteLine("Finished adding all the person data");
                    Console.WriteLine("---------- Gap ----------");
                    Console.WriteLine("People inserted =>");
                    foreach (var each in peopleList)
                    {
                        Console.WriteLine(each.ToString());
                    }
                    break;
            }
            Console.WriteLine("---------- Gap ----------");
            Console.WriteLine("Thanks for using, now proceed to Convert");

            using (StreamWriter sw = File.CreateText(path))
            {
                File.WriteAllText(path, jsondata);
            }
            Console.WriteLine(". . .");
            Console.WriteLine("Converted, Thank you again, Bye.");
        }
    }
}
