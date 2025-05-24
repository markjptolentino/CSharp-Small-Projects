using System;
using System.Threading; // For Thread.Sleep

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment: Display a stunning ASCII art header with an enhanced space operation theme
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
  🌌  ██████╗  ██████╗  ██████╗     ██╗   ██╗██╗███╗   ██╗ ██████╗  🌠
  🌟  ██╔══██╗██╔══██╗██╔═══██╗    ██║   ██║██║████╗  ██║██╔════╝  🌌
  ✨  ██████╔╝██████╔╝██║   ██║    ██║   ██║██║██╔██╗ ██║██║  ███╗  🌠
  🌑  ██╔══██╗██╔══██╗██║   ██║    ╚██╗ ██╔╝██║██║╚██╗██║██║   ██║  ✨
  🌟  ██████╔╝██║  ██║╚██████╔╝     ╚████╔╝ ██║██║ ╚████║╚██████╔╝  🌌
      ╚═════╝ ╚═╝  ╚═╝ ╚═════╝       ╚═══╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝  
        E N H A N C E D   S P A C E   O P E R A T I O N   M I S S I O N");
            Console.ResetColor();
            Console.WriteLine($"\nWelcome to the Enhanced Space Operation Mission by MARK TOLENTINO! (v1.0 - 04:28 PM EDT, May 24, 2025)\n");

            // Assignment: Create an instance of the SpaceOperator class for signal processing
            SpaceOperator operatorUnit = new SpaceOperator(); // Instantiate the class

            // Assignment: Animate a signal processing startup with a spinning spaceship
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== Initializing Signal Processor ===");
            Console.WriteLine("Starting up space systems...");
            int spinnerIndex = 0;
            string[] spinner = { "🚀|", "🚀/", "🚀-", "🚀\\" }; // Spaceship spinner frames
            for (int i = 0; i < 20; i++) // Run animation for 2 seconds
            {
                Console.Write($"\r{spinner[spinnerIndex]}"); // Update spinner
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
                Thread.Sleep(100); // 100ms delay per frame
            }
            Console.WriteLine("\rSystems Online! 🚀");
            Console.ResetColor();

            // Assignment: Call the ProcessSignal method using positional parameters
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n=== Processing Signal (Positional Parameters) ===");
            operatorUnit.ProcessSignal(10, 50); // Call method with powerLevel = 10, frequency = 50
            Console.ResetColor();

            // Assignment: Call the ProcessSignal method using named parameters
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n=== Processing Signal (Named Parameters) ===");
            operatorUnit.ProcessSignal(powerLevel: 15, frequency: 75); // Call method with named parameters
            Console.ResetColor();

            // Assignment: Display a confirmation message with mission status
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMission Control: Signal processing completed successfully! ✅");
            Console.WriteLine("Optimal Range: Power Level (5-20), Frequency (50-100 Hz).");
            Console.WriteLine("Tip: Higher frequencies improve signal clarity!");
            Console.ResetColor();

            // Assignment: Prompt the user to exit with a thematic farewell
            Console.WriteLine("\nPress any key to return to the cosmic operations hub...");
            Console.ReadKey();
        }
    }
}