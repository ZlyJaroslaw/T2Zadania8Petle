namespace T2Zadania8Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program1
            Console.WriteLine("Program 1: Ile jest liczb pierwszych w zakresie 0-100");
            Console.ReadLine();
            int lowLimit = 0;
            int highLimit = 100;

            int loopLowLimit;
            int loopHighLimit;

            int numberOfPrimeNumbers = 0;
            bool primeNumber = true;

            // 0 and 1 are not prime numbers, so we need this statement
            if (lowLimit < 2)
            {
                loopLowLimit = 2;
            }
            else
            {
                loopLowLimit = lowLimit;
            }

            if (highLimit < 2)
            {
                loopHighLimit = 2;
            }
            else
            {
                loopHighLimit = highLimit;
            }


            for (int i = loopLowLimit; i <= loopHighLimit; i++) 
            {
                primeNumber = true;
                for (int j = 2; j < i; j++) 
                {
                    if (i % j == 0) 
                    {
                        primeNumber = false;
                    }
                }
                if (primeNumber) 
                {
                    numberOfPrimeNumbers++;
                }
                
            }
            Console.WriteLine("W zakresie " + "0" + " - " + "100" + " jest " +  numberOfPrimeNumbers + " liczb pierwszych");
            Console.ReadLine();

            //Program2
            Console.WriteLine("Program 2: Wszystkie liczby parzyste od 0 do 1000:");
            Console.ReadLine();

            int task2LowLimit = 0;
            int task2HighLimit = 1000;

            int k = task2LowLimit;
            do
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                    ;
                }
                //Console.WriteLine(k);
                k++;
            }
            while (k <= task2HighLimit);

            Console.ReadLine() ;

            //Program3
            Console.WriteLine("Program 3: Ciąg Fibonacciego");
            Console.ReadLine();
            int fibonacciSequenceLimit = 10;
            Console.Write("Podaj ile wyrazów ma mieć ciąg: ");
            string fibonacciSequenceLimitFromConsole = Console.ReadLine();
            Int32.TryParse(fibonacciSequenceLimitFromConsole, out fibonacciSequenceLimit);

            long number = 0;
            long number_1 = 0;
            long number_2 = 0;

            for (int l = 0; l <= fibonacciSequenceLimit; l++)
            {
                if (l <= 1)
                {
                    number = l;
                }
                else
                {
                    number = number_1 + number_2;
                }
                number_2 = number_1;
                number_1 = number;

                if (number < 0)
                {
                    Console.WriteLine("Number exceeds INT32 limit");
                    break;
                }
                Console.WriteLine($"F({l}) = " + number);
            }

            Console.ReadLine();

            //Program4
            Console.WriteLine("Program4: Piramida\n");
            Console.Write("Podaj ostatnią z liczb składających się na piramidę: ");
            int pyramidMax;
            string pyramidMaxFromConsole = Console.ReadLine();
            Int32.TryParse(pyramidMaxFromConsole, out pyramidMax);

            int m = 1; //number
            int n = 1; //row in pyramid
            while (m <= pyramidMax)
            {
                for (int o = 0; o < n; o++) //o is position in row, each subsequent row has one more position
                {
                    Console.Write(m + " ");
                    m++;
                    if (m > pyramidMax)
                    { 
                        break; 
                    }
                }
                Console.WriteLine();
                n++;
            }

            Console.ReadLine();

            //Program5
            Console.WriteLine("Program5: Potęgi\n");
            double maxPower = 20;
            double numberRaisedToAPower;

            for (double p = 1; p <= maxPower; p++)
            {
                numberRaisedToAPower = Math.Pow(p, 3);
                Console.WriteLine($"{p} do potęgi 3 = {numberRaisedToAPower}");
            }

            Console.ReadLine() ;

            //Program6
            Console.WriteLine("Program6: Suma ciągu\n");
            double sequenceMax = 20;
            double sequenceSum = 0;

            for (double q = 0; q <= sequenceMax; q++)
            {
                if (q == 0)
                {
                    Console.Write("0");
                }
                else if (q >= 1)
                {
                    Console.Write("1");
                    sequenceSum = 1;
                }

                if (q > 1)
                {                     
                    for (int r = 2; r <= q; r++)
                    {
                        Console.Write($" + 1/{r}");
                    }                    
                }
                Console.Write(" = ");
                
                for (double s = 2; s <= q; s++)
                {
                    sequenceSum = sequenceSum + (1/s);
                }
                Console.WriteLine(sequenceSum);
            }

            Console.ReadLine();

            //Program7

            Console.WriteLine("Program7: Diament:");
            Console.Write("Podaj długość przekątnej diamentu: ");

            string diamondDiagonalFromConsole = Console.ReadLine();
            int diamondDiagonal;
            int diamondHeight;
            bool diamondHalfAchieved = false;

            Int32.TryParse(diamondDiagonalFromConsole, out diamondDiagonal);

            int numberOfStars;
            int diamondCenter;
            //int diamondGap;
            int diamondDiagonalEven = 0;

            
            if (diamondDiagonal%2 == 0) 
            {
                diamondCenter = diamondDiagonal / 2;
                diamondHeight = diamondDiagonal - 1;
                numberOfStars = 2;
                diamondDiagonalEven = 1;
            }
            else
            {
                diamondCenter = (diamondDiagonal / 2)+1;
                diamondHeight = diamondDiagonal;
                numberOfStars = 1;
            }

            // Console.WriteLine($"Srodek diamentu = {diamondCenter}");

            for (int i = 1;i <= diamondHeight; i++)
            {
                // Console.WriteLine($"Ilość gwiazdek : {numberOfStars}") ;
                if (i == diamondCenter)
                {
                    diamondHalfAchieved=true;
                }

                for (int j = 1;j <= diamondDiagonal; j++)
                {
                    if ((j >= diamondCenter-(numberOfStars/2)+diamondDiagonalEven)&&(j <= diamondCenter+(numberOfStars/2)))
                    {
                        Console.Write("*") ;
                    }
                    else
                    {
                        Console.Write(" ") ;
                    }
                }
                Console.WriteLine();
                if (diamondHalfAchieved)
                {
                    numberOfStars = numberOfStars - 2;
                }
                else
                {
                    numberOfStars = numberOfStars + 2;
                }
            }

            Console.ReadLine();

            //Program8

            Console.WriteLine("Program 8: Napisz coś, a ja to odwrócę");
            Console.Write("Napisz jakiś string: ");

            string wordFromConsole = Console.ReadLine();

            string outWord = "";

            foreach (char a in wordFromConsole)
            {
                outWord = a + outWord;
            }

            Console.WriteLine("Rezultat:");

            Console.WriteLine(outWord);

            Console.ReadLine();

            //Program9

            Console.WriteLine("Program 9: Zamiana liczby dziesiętnej na binarną");
            Console.Write("Podaj liczbę: ");

            string decimalNumberFromConsole = Console.ReadLine();

            bool decimalNumberNegative = false;

            int decimalNumber;

            Int32.TryParse(decimalNumberFromConsole, out decimalNumber);

            int maxExponent = 30; //for INT32

            if (decimalNumber < 0)
            {
                decimalNumberNegative = true;
                decimalNumber = (-decimalNumber)-1;
                Console.Write("1 ");
            }
            else
            {
                Console.Write("0 ");
            }

            for (int i = maxExponent; i >= 0; i--)
            {
                int powerOfTwo = 1;
                for (int j = 0; j < i; j++) //Math.Pow didn't work for me with integer type at the moment, so I did this...
                {
                    powerOfTwo = powerOfTwo * 2;
                }

                if (decimalNumber >= powerOfTwo)
                {
                    if (decimalNumberNegative)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }

                    decimalNumber = decimalNumber - powerOfTwo;
                }
                else
                {
                    if (decimalNumberNegative)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    
                }            

            }

            Console.ReadLine();

            //Program10

            Console.WriteLine("Program 10: Najmniejsza wspólna wielokrotność");
            Console.WriteLine("Podaj dwie liczby:\n");

            Console.Write("Liczba 1: ");

            int numberOne;
            string numberOneFromConsole = Console.ReadLine();
            Int32.TryParse(numberOneFromConsole, out numberOne);

            Console.Write("Liczba 2: ");

            int numberTwo;
            string numberTwoFromConsole = Console.ReadLine();
            Int32.TryParse(numberTwoFromConsole, out numberTwo);

            int productOfNumbers = numberOne * numberTwo;
            int searchMinimum = 0;

            if (numberOne > numberTwo)
            {
                searchMinimum = numberOne;
            }
            else
            {
                searchMinimum = numberTwo;
            }

            int leastCommonMultiple = 0;

            int numberOneRest = -1;
            int numberTwoRest = -1;

            for (int i = searchMinimum; i <= productOfNumbers; i++)
            {
                numberOneRest = i % numberOne;
                numberTwoRest = i % numberTwo;

                if ((numberOneRest == 0) && (numberTwoRest == 0))
                {
                    leastCommonMultiple = i;
                    break;
                }
            }
            //while ((numberOneRest != 0) && (numberTwoRest != 0) && (leastCommonMultiple > productOfNumbers)) //I guess I made some error using "While" loop, and I don't know where, so maybe next time
            //{
            //    numberOneRest = leastCommonMultiple % numberOne;
            //    Console.WriteLine($"numberOne: {numberOneRest}");
            //    numberTwoRest = leastCommonMultiple % numberTwo;
            //    Console.WriteLine($"numberTwo: {numberTwoRest}");
            //    leastCommonMultiple++;
            //}
            

            Console.WriteLine($"Najmniejsza wspólna wielokrotność liczb {numberOne} i {numberTwo} to {leastCommonMultiple}");

        }
    }
}
