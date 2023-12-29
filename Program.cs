// Screen Sound Program

// List
//List<string> listBands = new List<string>  {"U2", "Mastodon", "Gojira", "Evanescence"};

Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>();

//Function to Create a Title Modified
void BeautifyTitle(string title)
{
    int numberOfLetters = title.Length;
    string asteriscos = string.Empty.PadLeft(numberOfLetters, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(title);
    Console.WriteLine(asteriscos + "\n");
}

// Logo
void WelcomeMessage()
{
    BeautifyTitle("☕️ Screen Sound.📟");
}

// Function of the Menu with a Loop inside
void MenuMessage()
{
    WelcomeMessage();

    Console.WriteLine("- 1 to -> Register a New Band.");
    Console.WriteLine("- 2 to -> Show All Bands");
    Console.WriteLine("- 3 to -> Avaluate a Band");
    Console.WriteLine("- 4 to -> Show Average Score of a Band");
    Console.WriteLine("- 0 to -> Exit\n");

    Console.Write("-> ");
    string opt = Console.ReadLine()!;
    
    // String converted to numeric to use in SWITCH
    int numbOpt = int.Parse(opt);

    switch(numbOpt)
    {
        case 1: RegisterBand();
            break;
        case 2: ShowBands();
            break;
        case 3: Console.WriteLine("\nYou choose option number: " + numbOpt + "\n");
            break;
        case 4: Console.WriteLine("\nYou choose option number: " + numbOpt + "\n");
            break;
        case 0: Console.WriteLine("\nClosing the program\nGood-Bye!\n");
            break;
        default: Console.WriteLine("\nWrong option!\n");
            break;
    }
}

// Function to Register a New Band in the List
void RegisterBand()
{
    Console.Clear();

    BeautifyTitle("Register of Bands.");

    Console.Write("\nWrite the name of the Band: ");
    string newBand = Console.ReadLine()!;
    registeredBands.Add(newBand, new List<int>());
    Console.Write($"The Band {newBand} were Registered.");

    Thread.Sleep(2000);
    Console.Clear();
    MenuMessage();

}


// Function to Show all Bands Registered
void ShowBands()
{
    Console.Clear();

    BeautifyTitle("All Bands.");

    foreach (string band in registeredBands.Keys)
    {
        Console.WriteLine($"-> {band}");
    }

    Console.WriteLine("\nWrite something to return.");
    Console.ReadKey();
    Console.Clear();

    MenuMessage();
}


// Call the Menu
MenuMessage();