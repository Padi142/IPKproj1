using CommandLine;
using IPKproj1.Enum;
using IPKproj1.model;

namespace IPKproj1;

class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Arguments>(args)
            .WithParsed(RunWithArguments)
            .WithNotParsed(ArgumentsError);
    }

    static void RunWithArguments(Arguments arguments)
    {
        Console.WriteLine("Waking up eepy client...");

        ClientModel clientModel = new ClientModel
        {
            ClientState = ClientState.Start
        };

        bool shouldContinue = true;
        Console.WriteLine("Client is ready to go!");

        while (shouldContinue)
        {
            string? command = Console.ReadLine();

            if (command == null)
            {
                continue;
            }

            Command parsedCommand = ParseCommand(command);

            switch (parsedCommand)
            {
                case Command.Auth:
                    Console.WriteLine("Authenticating...");
                    break;
                case Command.Join:
                    Console.WriteLine("Joining...");
                    break;
                case Command.Help:
                    Console.WriteLine("Available commands: /auth, /join, /help, /rename");
                    break;
                case Command.Rename:
                    Console.WriteLine("Renaming...");
                    break;
                case Command.Unknown:
                    Console.WriteLine("Unknown command. Type /help for available commands.");
                    break;
            }

        }

        static Command ParseCommand(string command)
        {
            switch (command)
            {
                case "/auth":
                    return Command.Auth;
                case "/join":
                    return Command.Join;
                case "/help":
                    return Command.Help;
                case "/rename":
                    return Command.Rename;
                default:
                    return Command.Unknown;
            }

        }


    }
    static void ArgumentsError(IEnumerable<Error> errors)
    {
        Console.WriteLine("Invalid arguments, exiting...");
    }
}