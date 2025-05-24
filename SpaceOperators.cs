using System;

namespace VoidMethodAssignment
{
    class SpaceOperator
    {
        // Method: Takes two integers, squares the first to simulate power surge, displays the second as a frequency
        public void ProcessSignal(int powerLevel, int frequency)
        {
            int surgedPower = powerLevel * powerLevel; // Squares the first integer to simulate a power surge
            Console.WriteLine($"Power Surge: {powerLevel} squared = {surgedPower} units ⚡"); // Displays the surged power
            Console.WriteLine($"Signal Frequency: {frequency} Hz 📡"); // Displays the second integer as frequency
        }
    }
}