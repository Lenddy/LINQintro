List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
// IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!



// * Use LINQ to find the first eruption that is in Chile and print the result.
// Eruption? chile = eruptions.Where(c => c.Location == "Chile").FirstOrDefault();
// Console.WriteLine(chile);

// * Find the first eruption from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
// Eruption? hawaii = eruptions.Where(l => l.Location == "Hawaiian Is").FirstOrDefault();
// if(hawaii == null){
// Console.WriteLine("No Hawaiian Eruption found");
// }
// else
// {
//     Console.WriteLine(hawaii);
// }


// * Find the first eruption that is after the year 1900 AND in "New Zealand", then print it.
// Eruption? NewZealand = eruptions.Where(z => z.Year >= 1900 && z.Location == "New Zealand").FirstOrDefault();
// Console.WriteLine(NewZealand);


// *  Use   IEnumerable  when dealing with more that one
// * Find all eruptions where the volcano's elevation is over 2000m and print them.
// IEnumerable<Eruption> elevetion = eruptions.Where(v => v.ElevationInMeters >= 2000);
// PrintEach(elevetion,"Elevation over 2000m");
// // error message is going to kep apering untill this is use
// // * for later
// // Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
// static void PrintEach(IEnumerable<dynamic> items, string msg = "")
// {
//     Console.WriteLine("\n" + msg);
//     foreach (var item in items)
//     {
//         Console.WriteLine(item.ToString());
//     }
// }

// //* Find all eruptions where the volcano's name starts with "Z" and print them. Also print the number of eruptions found.
// IEnumerable<Eruption> startsZ = eruptions.Where(s => s.Volcano.StartsWith("Z"));
// PrintEach(startsZ,"Volcano name starts with z");


// // Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
// static void PrintEach(IEnumerable<dynamic> items, string msg = "")
// {
//     Console.WriteLine("\n" + msg);
//     foreach (var item in items)
//     {
//         Console.WriteLine(item.ToString());
//         if(item.Length()== 0 ){
//             Console.WriteLine("0 volcanos star with the letter Z");
//         }
//     }
// }


// //* Find the highest elevation, and print only that integer (Hint: Look up how to use LINQ to find the max!)
// int maxvalue = eruptions.Max(m => m.ElevationInMeters);
// Console.WriteLine("the highest elevation of all the volcanos is \n" + maxvalue);

// //* Use the highest elevation variable to find a print the name of the Volcano with that elevation.
// Eruption? name = eruptions.FirstOrDefault(m => m.ElevationInMeters == maxvalue);
// if(name != null){
// Console.WriteLine(name.Volcano);
// }




// IEnumerable<Eruption> names = eruptions.OrderBy(n => n.Volcano);
// PrintEach(names,"Volcanos name on Alphabetic order");

// // foreach(var item in names){
// //     Console.WriteLine(item.Volcano);
// // }

// static void PrintEach(IEnumerable<dynamic> items, string msg = "")
// {
//     Console.WriteLine("\n" + msg);
//     foreach (var item in items)
//     {
//         Console.WriteLine(item.ToString());
//     }
// }


// IEnumerable<Eruption>  = eruptions.OrderBy(n => n.Year >= 1000);
// // IEnumerable<Eruption> Epoch = eruptions.OrderBy(epoch => epoch.Year < 1000);

// IEnumerable<Eruption> Alphabetic = eruptions.Where(v => v.Year < 1000).OrderBy(v=> v.Volcano).ToList();
// // foreach(var item in Alphabetic){
// //     Console.WriteLine(item.Volcano);
// // }
// PrintEach(Alphabetic,"Volcanos name on Alphabetic order");

// static void PrintEach(IEnumerable<dynamic> items, string msg = "")
// {
//     Console.WriteLine("\n" + msg);
//     foreach (var item in items)
//     {
//         Console.WriteLine(item.ToString());
//     }
// }



// IEnumerable<Eruption> Alphabetic2 = eruptions.Where(v => v.Year < 1000).OrderBy(v=> v.Volcano);
// // foreach(var item in Alphabetic){
// //     Console.WriteLine(item.Volcano);
// // }
// PrintEach(Alphabetic2,"Volcanos name on Alphabetic order");

// static void PrintEach(IEnumerable<dynamic> items, string msg = "")
// {
//     Console.WriteLine("\n" + msg);
//     foreach (var item in items)
//     {
//         Console.WriteLine(item.Volcano.ToString());
//     }
// }

