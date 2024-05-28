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

            Console.WriteLine("------------------");

            int[] ints = new int[5]; //array of 5 integers without knowing elements that will be in the array

            List<String> days = new List<String>(); //list of strings, can add or remove elements
            List<int> numvers = new List<int>(); 

            days.Add("Monday"); //add elements to the list
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            days.Add("Sunday");
            days.Add("day");

            int count = days.Count; //count the number of elements in the list

            days.Remove("day"); //remove element from the list

            days.Insert(4, "randday"); //insert element at a specific index

            days.RemoveAt(2); //remove element at a specific index

            days.Sort(); //sort elements in the list

            Console.WriteLine("-----------------------"); 
            Console.WriteLine("\n-----sorted array-----");

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }


            days.Reverse(); //reverse the order of elements in the list

            Console.WriteLine("-----------------------");
            Console.WriteLine("\n----reversed array----");

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }

            days.FindIndex(x => x == "saturday"); //find the index of an element in the list


            bool sat = days.Contains("Saturday"); //check if an element is in the list

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\n----check if saturday is in the list----");
            if (sat)
            {
                Console.WriteLine("Saturday is in the list");
            }
       

            days.Clear(); //remove all elements from the list

            Console.WriteLine("------------------");
            Console.WriteLine("\n----clear list----");
            if (days.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
        }     
    }
}
