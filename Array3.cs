sealed class Array3 : BaseArray
    {
        private Random random;
        private int[][] array;

        public Array3(int length, bool usInp = false)
        {
        InitializeArray();
        }

        protected override void InitializeArray()
        {
            random = new Random();

            Console.Write("Enter the length of the array3: ");
    string lengthInput = Console.ReadLine();
    if (int.TryParse(lengthInput, out int length))
    {
        Console.Write("Enter 'true' for user input or 'false' for random input: ");
        string usInpInput = Console.ReadLine();
        if (bool.TryParse(usInpInput, out bool usInp))
        {
            array = new int[length][];

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
            array = new int[length][];
            ArrRand();
        }
    }
    else
    {
        Console.WriteLine("Invalid input for length. Defaulting to length of 10.");
        array = new int[10][];
        ArrRand();
    }
}


        public override double CalculateAverage()
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++){
                for (int j = 0; j < array[i].Length; j++){
                    sum += array[i][j];
                    count++;
                }
            }
            return (double)sum / count;
        }


        public void ArrUsInp()
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Сколько элементов в ступене массива？");
                int collumn = int.Parse(Console.ReadLine());
                array[i] = new int[collumn];

                for (int j = 0; j < collumn; j++)
                {
                    Console.WriteLine($"элемент № {i}{j}");
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void ArrRand()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int col = random.Next(3, 10);
                array[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    array[i][j] = random.Next(0, 10);
                }
            }
        }

        public override void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
