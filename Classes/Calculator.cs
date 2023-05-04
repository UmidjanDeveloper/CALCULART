namespace CalculatR.Classes
{
    public class Calculator
    {
        public int FirstNumber { get; private set; }

        public int SecondNumber { get; private set; }

        public string Operation { get; set; }

        public void GetInputs()
        {
            Console.WriteLine("Type 1st number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any operation that you want to process with (-,+,*,/,%): ");
            Operation = Console.ReadLine();
            Console.WriteLine("Type 2nd number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }

        public bool IsFirstNumberPositive()
        {
            return FirstNumber >= 0;
        }

        public bool IsSecondNumberPositive()
        {
            return SecondNumber >= 0;
        }

        public void CompareInputs()
        {
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("1st number is greater than 2nd number");
            }
            else if (FirstNumber == SecondNumber)
            {
                Console.WriteLine("1st number is equal to 2nd number");
            }
            else if (FirstNumber < SecondNumber)
            {
                Console.WriteLine("2nd number is greater than 1st number");
            }
            else
            {
                Console.WriteLine("Did you really mention numbers?");
            }
        }

        public string Calculate()
        {
            return Operation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}",
                _ => "Operation not found!"
            };
        }

        public void PrintEvenNumbers()
        {
            System.Console.WriteLine("Printing even nubers till first input...");
            Thread.Sleep(2000);
            int counter = 2;
            while(counter < FirstNumber)
            {
                System.Console.WriteLine(counter);
                counter+= 2;
            }
        }
        public void PrintMultiplicationTable()
        {
            for (int iterator = 1; iterator <= 10; iterator++)
            {
                for (int innerIterator = 1; innerIterator <= 10; innerIterator++)
                {
                    Console.WriteLine($"{iterator} x {innerIterator} = {iterator * innerIterator}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
