using System;

namespace _09.PadawanEquipment
{
    class PadawanEquipment
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabers = lightsabersPrice * Math.Ceiling(students + students * 0.10);
            double belts = beltsPrice * (students - (students / 6));
            
            double robe = robePrice * students;

            double totalPrice = lightsabers + belts + robe;

            if (totalPrice <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalPrice - amountOfMoney):f2}lv more.");
            }
            
        }
    }
}
