namespace essız
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sorting numbers do you want?");
            int selected = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the starting value");
            int selected1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select the end value");
            int selected2 = Convert.ToInt32(Console.ReadLine());

            int[] array1 = new int[selected];

            Random random = new Random();

            for (int i = 0; i < selected;)
            {
                int number = random.Next(selected1, selected2);

                bool control = false;
                for (int j = 0; j < i; j++)
                {
                    if (array1[j] == number)
                    {
                        control = true;
                        break;
                    }
                }

                if (control == false)
                {
                    array1[i++] = number;
                }
            }
            

            Console.WriteLine("Random Numbers:");

            for (int i = 0; i < selected; i++)
            {
                Console.WriteLine(array1[i]);
            }

            Console.ReadLine();
        }


    }
}







//static void Main(string[] args)
//{
//    Console.WriteLine("How many sorting numbers do you want?");
//    int selected = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Select the starting value");
//    int selected1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Select the end value");
//    int selected2 = Convert.ToInt32(Console.ReadLine());

//    int emptynumber;

//    int[] array1 = new int[selected];

//    Random random = new Random();
//    for (int i = 0; i < selected; i++)
//    {
//        int number = random.Next(selected1, selected2);
//        Console.WriteLine("Random number = " + number);
//        array1[i] = number;
//    }


//    for (int j = 0; j < selected; j++)
//    {
//        emptynumber = array1[j];
//        for (int k = 0; k < selected; k++)
//        {
//            if (emptynumber != array1[k])
//            {
//                continue;
//            }
//            else if (emptynumber == array1[k])
//            {
//                break;
//            }
//        }
//    }
//}
//    }