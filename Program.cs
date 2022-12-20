Console.Clear();

Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
 
            if( a > b )
            {
                Console.WriteLine("число " + a + " max");
                Console.WriteLine("число " + b + " min");

            }
            else if ( a < b )
            {
                Console.WriteLine("число " + b + " max");
                Console.WriteLine("число " + a + " min");

            }