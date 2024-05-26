namespace Pandemic_Board_Game_Bono
{
    namespace Pandemic_Board_Game_Bono
    {
        public class Program
        {
            static List<Player> players = new List<Player>
        {
            new Player("player1", "Description for player1"),
            new Player("player2", "Description for player2")
        };

            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Pandemic The Game!");

                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("");
                    MainMenu();

                    flag = false;
                }
            }

            public class Player
            {
                public string Name { get; set; }
                public string Description { get; set; }

                public Player(string name, string description)
                {
                    Name = name;
                    Description = description;
                }

                public override string ToString()
                {
                    return $"{Name} - {Description}";
                }
            }

            // Main Menu
            public static void MainMenu()
            {
                Console.Clear();
                List<string> options = new List<string> {
                "Start Game",
                "Manage Players",
                "Read Rules",
                "Quit"
            };
                int choice = DisplayMenuOptions(options, "Main menu - select an option");
                switch (choice)
                {
                    case 1:
                        StartGame();
                        break;
                    case 2:
                        ManagePlayers();
                        break;
                    case 3:
                        ReadRules();
                        break;
                    case 4:
                        QuitGame();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        MainMenu();
                        break;
                }
            }

            // Display Menu Options
            public static int DisplayMenuOptions(List<string> options, string title)
            {
                Console.WriteLine(title);
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {options[i]}");
                }
                Console.Write("Please select an option: ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > options.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and " + options.Count);
                }
                return choice;
            }

            // Start Game
            public static void StartGame()
            {
                Console.Clear();
                Console.WriteLine("Games");
                Console.WriteLine("=================");

                List<string> options = new List<string> {
                "Start New Game",
                "Load Game",
                "Game History",
                "Go back"
            };

                int choice = DisplayMenuOptions(options, "Games - select an option");
                switch (choice)
                {
                    case 1:
                        StartNewGame();
                        break;
                    case 2:
                        LoadGame();
                        break;
                    case 3:
                        GameHistory();
                        break;
                    case 4:
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        StartGame();
                        break;
                }
            }

            // Start New Game
            public static void StartNewGame()
            {
                int actionsLeft = 4;

                while (actionsLeft > 0)
                {
                    Console.Clear();
                    Console.WriteLine("Player Turn");
                    Console.WriteLine("=================");
                    Console.WriteLine("Shows player details, cards, and role");
                    Console.WriteLine($"Actions left: {actionsLeft}");
                    Console.WriteLine("");

                    List<string> options = new List<string>
                {
                    "Drive / ferry",
                    "Direct flight",
                    "Charter flight",
                    "Shuttle flight",
                    "Build research station",
                    "Treat disease",
                    "Share knowledge",
                    "Discover a cure",
                    "Pass",
                    "Save game and exit"
                };

                    int choice = DisplayMenuOptions(options, "Choose move action or other options:");
                    switch (choice)
                    {
                        case 1:
                            DriveFerry();
                            break;
                        case 2:
                            DirectFlight();
                            break;
                        case 3:
                            CharterFlight();
                            break;
                        case 4:
                            ShuttleFlight();
                            break;
                        case 5:
                            BuildResearchStation();
                            break;
                        case 6:
                            TreatDisease();
                            break;
                        case 7:
                            ShareKnowledge();
                            break;
                        case 8:
                            DiscoverCure();
                            break;
                        case 9:
                            PassTurn();
                            break;
                        case 10:
                            SaveGameAndExit();
                            return; // Exit the method to return to the main menu
                        default:
                            Console.WriteLine("Invalid choice");
                            continue;
                    }

                    actionsLeft--;

                    if (actionsLeft > 0)
                    {
                        Console.WriteLine("Press any key to continue to the next action...");
                        Console.ReadKey();
                    }
                }

                Console.WriteLine("Turn ended. Press any key to continue...");
                Console.ReadKey();
                // Code to handle end of turn and switch to next player
                MainMenu(); // For this example, return to main menu
            }

            public static void DriveFerry()
            {
                Console.Clear();
                Console.WriteLine("Driving/Ferrying...");
                // Voeg hier de code toe voor deze actie
            }

            public static void DirectFlight()
            {
                Console.Clear();
                Console.WriteLine("Taking a direct flight...");
                // Voeg hier de code toe voor deze actie
            }

            public static void CharterFlight()
            {
                Console.Clear();
                Console.WriteLine("Chartering a flight...");
                // Voeg hier de code toe voor deze actie
            }

            public static void ShuttleFlight()
            {
                Console.Clear();
                Console.WriteLine("Taking a shuttle flight...");
                // Voeg hier de code toe voor deze actie
            }

            public static void BuildResearchStation()
            {
                Console.Clear();
                Console.WriteLine("Building a research station...");
                // Voeg hier de code toe voor deze actie
            }

            public static void TreatDisease()
            {
                Console.Clear();
                Console.WriteLine("Treating disease...");
                // Voeg hier de code toe voor deze actie
            }

            public static void ShareKnowledge()
            {
                Console.Clear();
                Console.WriteLine("Sharing knowledge...");
                // Voeg hier de code toe voor deze actie
            }

            public static void DiscoverCure()
            {
                Console.Clear();
                Console.WriteLine("Discovering a cure...");
                // Voeg hier de code toe voor deze actie
            }

            public static void PassTurn()
            {
                Console.Clear();
                Console.WriteLine("Passing turn...");
                // Voeg hier de code toe voor deze actie
            }

            public static void SaveGameAndExit()
            {
                Console.Clear();
                Console.WriteLine("Saving game and exiting...");
                // Voeg hier de code toe om het spel op te slaan en te afsluiten
            }

            // Load Game
            public static void LoadGame()
            {
                Console.Clear();
                Console.WriteLine("Load Game");
                Console.WriteLine("=================");
                Console.WriteLine("Saved games:");

                // normaal komt dit uit database
                List<string> savedGames = new List<string>
            {
                "Game 1 (01/01/2024 10:00 AM)",
                "Game 2 (02/01/2024 02:00 PM)",
                "Game 3 (03/01/2024 04:00 PM)"
            };

                for (int i = 0; i < savedGames.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {savedGames[i]}");
                }

                Console.WriteLine("");
                Console.WriteLine($"{savedGames.Count + 1}. Cancel");
                Console.Write("Select the game you want to load or cancel: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > savedGames.Count + 1)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                if (choice == savedGames.Count + 1)
                {
                    StartGame();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("This feature is not finished yet.");
                    Console.WriteLine("Press any key to go back to the menu...");
                    Console.ReadKey();
                    StartGame();
                }
            }

            // Game History
            public static void GameHistory()
            {
                Console.Clear();
                Console.WriteLine("Game History");
                Console.WriteLine("=================");
                Console.WriteLine("Completed games:");

                // echte versie komt dit uit database
                List<string> completedGames = new List<string>
            {
                "Game 1 (01/01/2024 10:00 AM) (Win)",
                "Game 2 (02/01/2024 02:00 PM) (Loss)"
            };

                foreach (var game in completedGames)
                {
                    Console.WriteLine($"- {game}");
                }

                Console.WriteLine("");
                Console.WriteLine("1. Go back");
                Console.Write("Please select an option: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice != 1)
                {
                    Console.WriteLine("Invalid input. Please enter 1 to go back.");
                }

                StartGame();
            }

            // Manage Players
            public static void ManagePlayers()
            {
                Console.Clear();
                Console.WriteLine("Manage Players");
                Console.WriteLine("=================");
                Console.WriteLine("Players:");
                foreach (var player in players)
                {
                    Console.WriteLine($"- {player.Name} - {player.Description}");
                }
                Console.WriteLine("");

                List<string> options = new List<string>
            {
                "Add new player",
                "Edit player",
                "Remove player",
                "Go back"
            };
                int choice = DisplayMenuOptions(options, "Manage players - select an option");
                switch (choice)
                {
                    case 1:
                        CreatePlayer();
                        break;
                    case 2:
                        EditPlayer();
                        break;
                    case 3:
                        RemovePlayer();
                        break;
                    case 4:
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        ManagePlayers();
                        break;
                }
            }

            // Create Player
            public static void CreatePlayer()
            {
                Console.Clear();
                Console.Write("Enter the name of the new player: ");
                string newPlayerName = Console.ReadLine();
                Console.Write("Enter the description of the new player: ");
                string newDescription = Console.ReadLine();
                players.Add(new Player(newPlayerName, newDescription));
                Console.WriteLine($"{newPlayerName} has been added with the description: {newDescription}.");
                ManagePlayers();
            }

            // Edit Player
            public static void EditPlayer()
            {
                Console.Clear();
                Console.WriteLine("Select a player to edit:");
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {players[i].Name} - {players[i].Description}");
                }
                Console.Write("Enter the number of the player: ");
                int playerIndex;
                while (!int.TryParse(Console.ReadLine(), out playerIndex) || playerIndex < 1 || playerIndex > players.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                Console.Write("Enter the new name for the player: ");
                string newName = Console.ReadLine();
                Console.Write("Enter the new description for the player: ");
                string newDescription = Console.ReadLine();
                players[playerIndex - 1].Name = newName;
                players[playerIndex - 1].Description = newDescription;
                Console.WriteLine($"Player name has been updated to {newName} with the description: {newDescription}.");
                ManagePlayers();
            }

            // Remove Player
            public static void RemovePlayer()
            {
                Console.Clear();
                Console.WriteLine("Select a player to remove:");
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {players[i].Name} - {players[i].Description}");
                }
                Console.Write("Enter the number of the player: ");
                int playerIndex;
                while (!int.TryParse(Console.ReadLine(), out playerIndex) || playerIndex < 1 || playerIndex > players.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                Console.WriteLine($"{players[playerIndex - 1].Name} has been removed.");
                players.RemoveAt(playerIndex - 1);
                ManagePlayers();
            }

            // Read Rules
            public static void ReadRules()
            {
                List<string> rules = new List<string>
             {
                "Objective\n\nThe objective of the game is for the players to work together to discover cures for all four diseases before any of several losing conditions are met.",
                "Setup\n\nSetup the Board:\n- Place the board in the center of the play area.\n- Place the Outbreaks marker on the '0' space of the Outbreaks track.\n- Place the Infection Rate marker on the left-most '2' space of the Infection Rate track.\n- Place the six Research Stations supply nearby.\n- Place one Research Station in Atlanta.\n\nPrepare the Infection Deck:\n- Shuffle the Infection Deck and draw 9 cards.\n- Place 3 disease cubes on each of the first 3 cities drawn.\n- Place 2 disease cubes on each of the next 3 cities drawn.\n- Place 1 disease cube on each of the last 3 cities drawn.\n- Place the Infection Deck on the Infection Draw Pile space.\n\nPrepare the Player Deck:\n- Separate the Epidemic cards from the Player Deck.\n- Divide the Player Deck into piles according to the number of Epidemic cards (based on difficulty level).\n- Shuffle one Epidemic card into each pile and stack them to form the Player Draw Pile.\n- Deal 2 Player cards to each player.\n\nSet Player Roles:\n- Assign each player a Role card randomly.\n- Place the corresponding pawn for each player in Atlanta.\n- Each player starts with 4 action points per turn.",
                "Player Actions\n\nOn each player's turn, they may take up to 4 actions. The actions available are:\n\nDrive/Ferry:\n- Move to a city connected by a white line.\n\nDirect Flight:\n- Discard a City card to move to the city named on the card.\n\nCharter Flight:\n- Discard the City card that matches the city you are in to move to any city.\n\nShuttle Flight:\n- Move from a city with a Research Station to any other city with a Research Station.\n\nBuild a Research Station:\n- Discard the City card that matches the city you are in to place a Research Station there.\n\nTreat Disease:\n- Remove one disease cube from the city you are in. If a cure has been discovered for this disease, remove all cubes of that color from the city.\n\nShare Knowledge:\n- Give the City card that matches the city you are in to another player in that city. Both players must be in the same city.\n\nDiscover a Cure:\n- At any Research Station, discard 5 City cards of the same color to discover a cure for that disease.",
                "Drawing Cards\n\nAt the end of a player's turn, they draw 2 cards from the Player Deck.\n\nIf a player draws an Epidemic card:\n\nIncrease:\n- Move the Infection Rate marker forward one space.\n\nInfect:\n- Draw the bottom card from the Infection Deck. Place 3 cubes on that city.\n\nIntensify:\n- Shuffle the cards in the Infection Discard Pile and place them on top of the Infection Deck.",
                "Infecting Cities\n\nAfter drawing Player cards, draw Infection cards equal to the current Infection Rate.\n\nFor each Infection card drawn, add one disease cube to the city shown on the card.",
                "Outbreaks\n\nIf a city already has 3 cubes of the color being added, an outbreak occurs.\n\nMove the Outbreaks marker forward one space.\n\nAdd one disease cube to each city connected to the city with the outbreak.",
                "Winning the Game\n\nThe players win if they discover cures for all four diseases.",
                "Losing the Game\n\nThe players lose if any of the following occurs:\n\n- The Outbreaks marker reaches the last space on the Outbreaks track.\n\n- There are not enough disease cubes to place on the board when needed.\n\n- There are not enough cards in the Player Deck when players need to draw."
             };

                int currentPage = 0;

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(rules[currentPage]);
                    Console.WriteLine("\nPress 'N' for next page, 'P' for previous page, or 'C' to cancel...");

                    var key = Console.ReadKey().Key;
                    if (key == ConsoleKey.C)
                    {
                        break;
                    }
                    else if (key == ConsoleKey.N)
                    {
                        if (currentPage < rules.Count - 1)
                        {
                            currentPage++;
                        }
                    }
                    else if (key == ConsoleKey.P)
                    {
                        if (currentPage > 0)
                        {
                            currentPage--;
                        }
                    }
                }

                MainMenu();
            }

            // Quit Game
            public static void QuitGame()
            {
                Console.Clear();
                Console.WriteLine("Quitting the game. Goodbye!");
                Environment.Exit(0);
            }
        }
    }
}