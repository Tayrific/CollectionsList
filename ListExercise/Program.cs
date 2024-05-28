using System.Text;

namespace ListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objs = new List<object>();

            objs.Add(2.5d);
            objs.Add(2.0d);
            objs.Add(3);
            objs.Add(2);
            objs.Add("Hello");
            objs.Add("World");

            int intSum = 0;
            double doubleSum = 0;          
            StringBuilder stringConcat = new StringBuilder();

            foreach (var obj in objs)
            {
                string type = obj.GetType().ToString();
                Console.WriteLine(type);

                if (obj is double doubleVal)
                {
                    doubleSum += doubleVal;
                }
                else if (obj is int intVal)
                {
                    intSum += intVal;
                }
                else if (obj is string stringVal)
                {
                    stringConcat.Append((stringVal) + " ");               
                } 
                else
                {
                   Console.WriteLine("Unknown type: {0}", type);
                }
            
            }
            Console.WriteLine("Sum of ints: {0}", intSum);
            Console.WriteLine("Sum of doubles: {0}", doubleSum);       
            Console.WriteLine("Concatenated string: {0}", stringConcat);
        }
    }
}
