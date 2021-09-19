using System;

namespace _10.RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            
            int headsedCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int keyboardSum = 0;
            int displayCount = 0;
            
            for (int i = 1; i <= gamesLost; i++)
            {
                if (i % 2 == 0)
                {
                    headsedCount++;
                }
                if (i % 3 == 0)
                {
                    mouseCount++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;
                    keyboardSum ++;
                }
                if (keyboardCount % 2 == 0 && keyboardCount != 0)
                {
                    displayCount++;
                    keyboardCount = 0;
                }
            }

            double expenses = (headsetPrice * headsedCount) + (mousePrice * mouseCount) + (keyboardPrice * keyboardSum) + (displayPrice * displayCount);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
