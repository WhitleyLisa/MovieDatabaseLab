using MovieDatabaseLab;

string repeat = "Y";


List<Movie> movieList = new List<Movie>
            {
                new Movie("Sing 2", "family"),
                new Movie("Nobody", "action"),
                new Movie("Split", "thriller"),
                new Movie("Encanto", "family"),
                new Movie("Spiral", "horror"),
                new Movie("Cold Pursuit", "thriller"),
                new Movie("Moana", "family"),
                new Movie("Ride Along", "comedy"),
                new Movie("Raya and The Last Dragon", "family"),
                new Movie("Free Guy", "action"),
                new Movie("IT", "horror"),
                new Movie("Clifford The Big Red Dog", "family"),
                new Movie("Infinite", "action"),
                new Movie("Red Notice", "horror"),
                new Movie("Eternals", "action"),
                new Movie("Where The Wild Things Are", "family"),
                new Movie("6 Underground", "thriller")


            };


Console.WriteLine("Welcome to the movie list database!");
Console.WriteLine();
Console.WriteLine("Our movie selection is growing! More to come soon!");
Console.WriteLine();
Console.WriteLine("Here are the film categories to pick from: family, action, thriller, horror, or comedy.");
Console.WriteLine("\n");


do
{

    Console.WriteLine("Please chose one from the list of film categories listed above:");
    var userInput = Console.ReadLine().ToLower();

    if (userInput.Contains("family"))
    {
        var familyMovies = movieList.Where(x => x.Category == "family").ToList();
        foreach (Movie x in familyMovies)
        {
            Console.WriteLine(x.Title);
        }
    }
    else if (userInput.Contains("action"))
    {
        var actionMovies = movieList.Where(x => x.Category == "action").ToList();
        foreach (Movie x in actionMovies)
        {
            Console.WriteLine(x.Title);
        }
    }
    else if (userInput.Contains("thriller"))
    {
        var thrillerMovies = movieList.Where(x => x.Category == "thriller").ToList();
        foreach (Movie x in thrillerMovies)
        {
            Console.WriteLine(x.Title);
        }
    }
    else if (userInput.Contains("horror"))
    {
        var horrorMovies = movieList.Where(x => x.Category == "horror").ToList();
        foreach (Movie x in horrorMovies)
        {
            Console.WriteLine(x.Title);
        }
    }
    else if (userInput.Contains("comedy"))
    {
        var comedyMovies = movieList.Where(x => x.Category == "comedy").ToList();
        foreach (Movie x in comedyMovies)
        {
            Console.WriteLine(x.Title);
        }
    }
    else
    {
        Console.WriteLine("That was not a valid entry, please pick from the following categories: family, action, thriller, horror, or comedy");
        Console.WriteLine();
        continue;
    }

    Console.WriteLine("Would you like to see another category of film? (Y/N)?");
    repeat = Console.ReadLine().ToUpper();

}
while (repeat == "Y");

Console.WriteLine("Come back next time to see more films based on categories you pick from!");
