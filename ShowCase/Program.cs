using System;
using Newtonsoft.Json;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        // Account account = new Account
        // {
        //     Name = "John Doe",
        //     Email = "john@nuget.org",
        //     DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
        // };

        // string json = JsonConvert.SerializeObject(account, Formatting.Indented);
        // Console.WriteLine(json);

        int row = 0;
        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
                              $"{(input.StartsWithUpper() ? "Yes" : "No")}\n");
            row += 3;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
            row = 3;
        }
    }
}