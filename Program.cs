
internal class Program
    {

        static void Main(string[] args)
        {
            Array1 one = new Array1(4);

            Array2 two = new Array2(4, 4);

            Array3 three = new Array3(4);
  
            BaseArray[] baseArrays = new BaseArray[3]
            {
                one, two, three
            };

            foreach(BaseArray item in baseArrays)
            {
                Console.WriteLine($"Элементы массива {item.GetType()}");
                item.PrintArray();
                Console.WriteLine($"Среднее значение {item.GetType()} массива {item.CalculateAverage()}");
            }
        }
    }
