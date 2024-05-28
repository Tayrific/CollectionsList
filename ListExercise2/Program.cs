namespace ListExercise2
{
    public class Program
    {
        public class Person
        {
            public string? Name { get; set; }
            public int Age { get; set; }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List <Person> person = new List<Person>() 
            { 
                new Person { Name = "Joe", Age = 24 },
                new Person { Name = "Jack", Age = 22 },
                new Person { Name = "Tim", Age = 23 }

            };
           
            object[] data = new object[]
            {
                5.5f, 10.5f, 200.25d, 5.5d, 2,3,4, "Apple", "Banana", "Grapes", "Orange", person
            };

            float floatSum = 0;
            double doubleSum = 0;
            int intSum = 0;
            List<string> fruitList = new List<string>();


            foreach (var item in data)
            {
                string type = item.GetType().ToString();
                if (item is float floatVal)
                {
                    floatSum += floatVal;
                }
                else if (item is double doubleVal)
                {
                    doubleSum += doubleVal;
                }
                else if (item is int intVal)
                {
                    intSum += intVal;
                }
                else if (item is string stringVal)
                {
                    fruitList.Add(stringVal);
                }
                else if (item is List<Person> personList)
                {
                    foreach (var p in personList)
                    {
                        Console.WriteLine(" Name: {0}, Age: {1}", p.Name, p.Age);
                    }
                }
                else
                {
                    Console.WriteLine("Unknown type: {0}", type);
                }
            }
            Console.WriteLine("Sum of floats: {0}", floatSum);
            Console.WriteLine("Sum of ints: {0}", intSum);
            Console.WriteLine("Sum of doubles: {0}", doubleSum);
            foreach (var fruit in fruitList)
            {
                Console.WriteLine("The fruits are : {0}",fruit);
            }

            int ageSum = 0;
            int averageAge = 0;
            foreach (var p in person)
            {
                ageSum += p.Age;             
            }
            averageAge = ageSum / person.Count;

            Console.WriteLine(" average age : {0}", averageAge);

        }
    }
}
