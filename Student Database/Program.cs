//create 3 arrays. Fill them with student info. Name, hometown, food.

string[] studentName = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };
string[] favFood = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "Tacos", "Pasta", "Pounded Yam" };
string[] homeTown = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };

string loop = "y";
string doTheySpeakEnglishInWhat = "y";

do
{

    //prompt user to ask student by number. Convert. Print name.
    //remember to use 1-17 user prompts and 0-16 for code side
    Console.WriteLine("");
    Console.WriteLine("Enter number for student information or '0' for directory.");
    int index = int.Parse(Console.ReadLine()) - 1;
    if (index >= 0 && index < studentName.Length)
    {
        Console.WriteLine(studentName[index]);
        Console.WriteLine("");


        //prompt user to ask hometown or fav food.
        do
        {
            doTheySpeakEnglishInWhat = "y";
            Console.WriteLine("Display next? Type 'HOMETOWN' or 'FOOD' for more information.");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            if (choice.ToLower() == "hometown")
            {
                Console.WriteLine(homeTown[index]);
                Console.WriteLine("");
                doTheySpeakEnglishInWhat = "n";
            }
            else if (choice.ToLower() == "food")
            {
                Console.WriteLine(favFood[index]);
                Console.WriteLine("");
                doTheySpeakEnglishInWhat = "n";
            }
            else
            {
                Console.WriteLine("Do they speak english in what?");
            }

        }
        while (doTheySpeakEnglishInWhat == "y");

        //ask to continue

        Console.WriteLine("Search database again? 'Y' or 'N'.");
        loop = (Console.ReadLine());
        if (loop.ToLower() == "n")
        {
            loop = "n";
        }
        else
        {
            loop = "y";
        }
    }

    else if (index == -1)
    {
        foreach (var name in studentName)
        {
            Console.WriteLine(name);
            
        }
        Console.WriteLine("");
        Console.WriteLine("have fun counting");
    }

    else
    {
        Console.WriteLine("Invalid choice. Try again");
        Console.WriteLine("");
    }

    


}
while (loop == "y");




