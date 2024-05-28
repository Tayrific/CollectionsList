namespace PluralSightVids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = //square brackets = array not single value
            {
                //definite order
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunda"
            };

            daysOfWeek[6] = "Sunday"; // fix "sunda" to "sunday"

            foreach (var day in daysOfWeek) //enumerating (going through) through each element in the array
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("------------------");

            int number = 0;
            while (number < 1 || number > 7)
            {
                Console.WriteLine("\nEnter a number between 1 and 7"); //prompt user to enter a number
                number = int.Parse(Console.ReadLine());

                if (number < 1 || number > 7) //checks if number is within range
                {
                    Console.WriteLine("\nNumber is out of range"); //if number is out of range, display this message
                    Console.WriteLine("------------------");
                }
            }
            
            string chosenDay = daysOfWeek[number - 1]; //array index starts at 0, so subtract 1 from the number entered by the user
            Console.WriteLine("your chosen day is {0}", chosenDay); //display the chosen day

            Console.ReadLine();

            Console.WriteLine("------------------");

            
        }     
    }
}
