using System.Data;
using System.Runtime.InteropServices;

sealed class Array2 : BaseArray
{
	private Random random;
	private int[,] array;

	public Array2(int rows, int columns, bool usInp = false)
	{
        InitializeArray();
    }


    protected override void InitializeArray()
    {
        Console.Write("Enter the number of rows in array2: ");
    string rowsInput = Console.ReadLine();
    if (int.TryParse(rowsInput, out int rows))
    {
        Console.Write("Enter the number of columns in array2: ");
        string columnsInput = Console.ReadLine();
        if (int.TryParse(columnsInput, out int columns))
        {
            Console.Write("Enter 'true' for user input or 'false' for random input: ");
            string usInpInput = Console.ReadLine();
            if (bool.TryParse(usInpInput, out bool usInp))
            {
                
        		random = new Random();
				array = new int[rows, columns];

                if (usInp)
                {
                    ArrUsInp();
                }

                else
                {
                    ArrRand();
                }
            }
            else
            {
                Console.WriteLine("Invalid input for usInp. Defaulting to random input.");
                array = new int[rows, columns];
                ArrRand();
            }
        }
        else
        {
            Console.WriteLine("Invalid input for columns. Defaulting to 10.");
            array = new int[rows, 10];
            ArrRand();
        }
    }
    else
    {
        Console.WriteLine("Invalid input for rows. Defaulting to 10.");
        array = new int[4, 4];
        ArrRand();
    }
}

	public void ArrUsInp()
	{
    	Console.WriteLine("Введите элементы матрицы через пробел: ");
        	for (int i = 0; i < array.GetLength(0); i++)
        	{
            	var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            	for (int j = 0; j < array.GetLength(1); j++)
            	{
                	array[i, j] = int.Parse(line[j]);
            	}
        	}
	}

	public void ArrRand()
	{
    	for (int i = 0; i < array.GetLength(0); i++)
        	{
            	for (int j = 0; j < array.GetLength(1); j++)
            	{
                	array[i, j] = random.Next(1, 100);
            	}
        	}
	}


	public override void PrintArray()
	{
    	for (int i = 0; i < array.GetLength(0); i++)
    	{
        	for (int j = 0; j < array.GetLength(1); j++)
        	{
            	Console.Write(array[i, j] + " ");
        	}
        	Console.WriteLine();
    	}
	}
    
    	public override double CalculateAverage()
	{
    	double sum = 0;
    	for (int i = 0; i < array.GetLength(0); i++)
    	{
        	for (int j = 0; j < array.GetLength(1); j++)
        	{
            	sum += array[i, j];
        	}
    	}
    	return sum / (array.GetLength(0) * array.GetLength(1));
	}

}
