using System.Runtime.CompilerServices;

sealed class Array1 : BaseArray
{
    private Random random;
    private int[] array;

    public Array1(int length, bool usInp = false)
    {
        InitializeArray();
    }


    protected override void InitializeArray()
    {
        Console.Write("Enter the length of the array1: ");
        string lengthInput = Console.ReadLine();
        if (int.TryParse(lengthInput, out int length))
        {
            Console.Write("Enter 'true' for user input or 'false' for random input: ");
            string usInpInput = Console.ReadLine();
            if (bool.TryParse(usInpInput, out bool usInp))
            {

                array = new int[length];
                random = new Random();

                if (usInp)
                {
                    ArrUsInp();
                }

                else
                {
                    ArrRand();
                }
            }
        }
    }


    public void ArrUsInp()
    {
        Console.WriteLine($"Введите {array.Length} чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
    }


    public  void ArrRand()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }
    }


    public override double CalculateAverage()
    {
        int sum = 0;
        foreach (int value in array)
        {
            sum += value;
        }
        return (double)sum / array.Length;
    }


    public override void PrintArray()
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

}