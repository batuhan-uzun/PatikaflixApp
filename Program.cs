// Initialize the list of TV series
using PatikaflixApp.Models;

List<TVSeries> seriesList = new List<TVSeries>
        {
            new TVSeries { Name = "Avrupa Yakası", ProductionYear = 2004, Genre = "Comedy", StartYear = 2004, Director = "Yüksel Aksu", FirstPlatform = "Kanal D" },
            new TVSeries { Name = "Yalan Dünya", ProductionYear = 2012, Genre = "Comedy", StartYear = 2012, Director = "Gülseren Buda Başkaya", FirstPlatform = "Fox TV" },
            new TVSeries { Name = "Jet Sosyete", ProductionYear = 2018, Genre = "Comedy", StartYear = 2018, Director = "Gülseren Buda Başkaya", FirstPlatform = "TV8" },
            new TVSeries { Name = "Dadı", ProductionYear = 2006, Genre = "Comedy", StartYear = 2006, Director = "Yusuf Pirhasan", FirstPlatform = "Kanal D" },
            new TVSeries { Name = "Belalı Baldız", ProductionYear = 2007, Genre = "Comedy", StartYear = 2007, Director = "Yüksel Aksu", FirstPlatform = "Kanal D" },
            new TVSeries { Name = "Arka Sokaklar", ProductionYear = 2004, Genre = "Crime, Drama", StartYear = 2004, Director = "Orhan Oğuz", FirstPlatform = "Kanal D" },
            new TVSeries { Name = "Aşk-ı Memnu", ProductionYear = 2008, Genre = "Drama, Romance", StartYear = 2008, Director = "Hilal Saral", FirstPlatform = "Kanal D" },
            new TVSeries { Name = "Muhteşem Yüzyıl", ProductionYear = 2011, Genre = "Historical, Drama", StartYear = 2011, Director = "Mercan Çilingiroğlu", FirstPlatform = "Star TV" },
            new TVSeries { Name = "Yaprak Dökümü", ProductionYear = 2006, Genre = "Drama", StartYear = 2006, Director = "Serdar Akar", FirstPlatform = "Kanal D" }
        };

// Filter comedy series
var comedySeries = seriesList
    .Where(s => s.Genre.Contains("Comedy"))
    .Select(s => new { s.Name, s.Genre, s.Director })
    .OrderBy(s => s.Name)
    .ThenBy(s => s.Director)
    .ToList();

// Print comedy series
Console.WriteLine("Comedy Series:");
foreach (var series in comedySeries)
{
    Console.WriteLine($"Name: {series.Name}, Genre: {series.Genre}, Director: {series.Director}");
}
Console.WriteLine();

// Allow the user to add new series
while (true)
{
    Console.WriteLine("Do you want to add a new series? (y/n)");
    string answer = Console.ReadLine()?.ToLower();

    if (answer == "n")
    {
        break;
    }
    else if (answer == "y")
    {
        Console.WriteLine("Enter the name of the series:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the production year:");
        int productionYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the genre:");
        string genre = Console.ReadLine();

        Console.WriteLine("Enter the start year:");
        int startYear = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the director:");
        string director = Console.ReadLine();

        Console.WriteLine("Enter the first platform:");
        string firstPlatform = Console.ReadLine();

        seriesList.Add(new TVSeries
        {
            Name = name,
            ProductionYear = productionYear,
            Genre = genre,
            StartYear = startYear,
            Director = director,
            FirstPlatform = firstPlatform
        });

        Console.WriteLine("The new series has been added to the list!\n");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
    }
}

// Print all series
Console.WriteLine("All TV Series:");
seriesList.ForEach(s =>
{
    Console.WriteLine($"Name: {s.Name}, Production Year: {s.ProductionYear}, Genre: {s.Genre}, Start Year: {s.StartYear}, Director: {s.Director}, First Platform: {s.FirstPlatform}");
});