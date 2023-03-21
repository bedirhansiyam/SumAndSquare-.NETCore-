namespace SumAndSquare;
class Program
{
    static void Main(string[] args)
    {
        bool isInt = true;
        List<int> numbers = new List<int>();
        int sumOfLess = 0; 
        double sumofGreaterSquare = 0;

        Console.Write("Please enter space-separated integers : ");

        do
        {
            string[] strNumbers = Console.ReadLine().Split(' ');
  
            for (int i = 0; i < strNumbers.Count(); i++)
            {
                isInt = int.TryParse(strNumbers[i], out int number);
                if(isInt == false)
                {
                    Console.WriteLine("");
                    Console.Write("Please enter only integers : ");
                    numbers.Clear();
                    break;
                }
                else
                    numbers.Add(number);
            }            
        } while (isInt == false);

        foreach (var number in numbers)
        {
            if(number < 67)
            {
                int diff = 67 - number;
                sumOfLess += diff;
            }
            else if(number > 67)
            {
                double diff = number - 67;
                sumofGreaterSquare += Math.Pow(diff,2);
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Result : " + sumOfLess + " " + sumofGreaterSquare);
    }
}
