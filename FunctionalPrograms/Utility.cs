//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;
    using System.Threading;
    
    
    /// <summary>
    /// Utility class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Harmonic  the number.
        /// </summary>
        /// <param name="number">number as parameter</param>
       public void Harmonic(float number)
        {
            float harmonic = 1;
            try
            {
                Console.WriteLine("Enter any number");
               number = Convert.ToInt32(Console.ReadLine());
                
                    for (int i = 2; i <= number; i++)
                    { 
                        harmonic += (float)1 / i;                      
                    }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Hormonic number" + harmonic);
            Console.ReadKey();
        }

        /// <summary>
        /// Primes the factor.
        /// </summary>
        /// <param name="number">The number.</param>
       public void PrimeFactor(int number)
        {
            int checkCouneter=0;

            Console.WriteLine("The prime Factors are:");
            for (int outerLoopCounter = 2; ( outerLoopCounter) <= number; outerLoopCounter++) {
                if (number % outerLoopCounter == 0) {
                    for (int innerLoopCounter = 2; innerLoopCounter <= outerLoopCounter/2; innerLoopCounter++) {
                        if (outerLoopCounter % innerLoopCounter == 0) {
                            checkCouneter++;
                            break;
                        }
                    }
                    if (checkCouneter == 0)
                    {
                        Console.WriteLine(outerLoopCounter);
                        checkCouneter = 0;
                    }
                }
                
            }
        }

        /// <summary>
        /// Powers the function.
        /// </summary>
        /// <param name="number">The number.</param>
       public void PowerFunction(int number)
       {
            try
            {
                int temp = 0;
                int power = 1;
                /*
                if (number > 0)
                {
                    while (i <= number)
                    {
                        Console.WriteLine("Power of Number = 2^" + i + "= " + power);
                        power = power * 2;
                        i++;
                    }
                }
                else
                {
                    if (i >= number)
                    {
                        Console.WriteLine("Power of Number = 2^ " + i + "=" + power);
                        i--;
                   }
                }*/
             

                if (number < 30)
                {
                    for (int loopCounter = 0; loopCounter < number; loopCounter++)
                    {
                        temp = loopCounter;
                        while (temp != 0)
                        {
                            power = power * 2;
                            temp--;
                        }
                        Console.WriteLine("Power of Number = 2^ " + loopCounter + " = " + power);
                        power = 2;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Replace User Name as function
        /// </summary>
        /// <param name="username">username as parameter</param>
       public void ReplaceUserName(string username)
        {
            try
            {
                if (username.Length > 3)
                {
                    string input = "Hello <<UserName>>, How are you?";
                    input = input.Replace("<<UserName>>", username);
                    Console.WriteLine(input);                   
                }
                else
                {
                    Console.WriteLine("Enter name should be greater than three character");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("String Not Find" + e.Message);
            }
        }

        /// <summary>
        /// Toss game
        /// </summary>
        /// <param name="coins">coins as parameter</param>
       public void Tossgame(int coins)
        {
            try
            {
                int heads = 0;
                int tails = 0;
                if (coins > 1)
                {
                    Random random = new Random();
                    double randomvariable = 0.0;
                   
                    for (int i = 0; i < coins; i++)
                    {
                        randomvariable = random.NextDouble();
                        Console.WriteLine(randomvariable);
                        
                        if (randomvariable < 0.5)
                        {
                            heads += 1;
                        }
                        else
                        {
                            tails += 1;
                        }
                    }

                    double heasdpercentage = (double)(heads * 100) / coins;
                    double tailspercentage = (double)(tails * 100) / coins;
                    Console.WriteLine(heasdpercentage + "%" + "\n" + tailspercentage + "%");  
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Win  loss game
        /// </summary>
        /// <param name = "stake">stake as parameter</param>
        /// <param name = "goal">goal as parameter</param>     
       public void Winlossgame(int stake, int goal)
        {
            int win = 0;
            int bets = 0;
            try
            {
                Console.WriteLine("Enter trails glamber");
                int trials = Convert.ToInt32(Console.ReadLine());
                if(trials < 0)
                {
                    Console.WriteLine("trails should be greater then 0");
                    this.Winlossgame(stake, goal);
                }

             
                Random random = new Random();
                for (int i = 0; i < trials; i++)
                {
                    if (random.NextDouble() < 0.5)
                    {
                        stake--;
                        bets++;
                    }
                    else
                    {
                        stake++;
                        win++;
                    }
                    if (goal == win)
                    {
                        break;
                    }
                }
                Console.WriteLine(win + " " + "wins of" + " " + trials);
                Console.WriteLine("percertange of wins=" + (100.0 * win / trials) + "%");
                Console.WriteLine("percertange of loss=" + (100.0 * bets / trials) + "%");
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }

        /// <summary>
        /// Create Coupon
        /// </summary>
        /// <param name="rows">rows as parameter</param>
        /// <param name="column">column as parameter</param>
        public void CreateCoupon(int rows, int column)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static int noOfCoupen, random1 = 0, loopCounter = 0, distinctCoupenCount = 0;
        public static int randomNumberCount;
        public static int[] coupenArray;
        public  void getDistinctCoupenFromRandomValues(int noOfCoupen, Random randomObj)
        {
            int loopCounter = 0, randomNumber = 0;
            coupenArray = new int[noOfCoupen];  //array of coupens

            for (loopCounter = 0; loopCounter < noOfCoupen; loopCounter++)
            {
                int temp = 0;
                randomNumber = randomObj.Next(noOfCoupen);
                randomNumberCount++;

                for (int j = 0; j <= loopCounter; j++)
                {
                    if (coupenArray[j] == randomNumber)
                    {
                        temp++;
                        break;
                    }

                }
                if (temp == 0)                            //check for the 
                {

                    coupenArray[distinctCoupenCount] = randomNumber;
                    distinctCoupenCount++;
                }
                loopCounter = distinctCoupenCount;
            }
            display();
        }
        //display which display the disticnt coupen 
        public void display()
        {

            Console.WriteLine("No.of coupen generated");
            for (loopCounter = 0; loopCounter < distinctCoupenCount; loopCounter++)
            {
                Console.WriteLine(coupenArray[loopCounter]);
            }
            distinctCoupenCount++;

            Console.WriteLine(noOfCoupen);
            Console.WriteLine("The nuber of times random function call :" + randomNumberCount);
            Console.WriteLine("The nuber of coupens are:" + distinctCoupenCount);
        }
        /// <summary>
        /// User Input Array
        /// </summary>
        /// <param name="rows">row as parameter</param>
        /// <param name="columns">column as parameter</param>
        public void UserInputArray(int rows, int columns)
        {
            try
            {
                rows = Convert.ToInt32(Console.ReadLine());
                columns = Convert.ToInt32(Console.ReadLine());

                int[,] array = new int[rows, columns];
                Console.WriteLine("Enter Array Element");
                for (int i = 0; i <= rows; i++)
                {
                    for (int j = 0; j <= columns; j++)
                    {
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Multiplication of array as function
        /// </summary>
        /// <param name="row">row as parameter</param>
        /// <param name="column">column as parameter</param>
        public void Multiplicationofarray(int row, int column)
        {
            try
            {
                Console.WriteLine("Enter number of rows");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of columns ");
                column = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[2, 2];
                Console.WriteLine("Enter element into 2D Array:");
                ////this for loop used to take a array elemnt 
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                //// this for loop used to dispaly array
                Console.WriteLine("Entered element of 2D Array are:");
                for (int i = 0; i < row; i++) 
                {
                    
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write("|"+array[i, j] + "\t");
                    }

                    Console.WriteLine();
                }
                ////this for loop used to take a second array elemnt 
                int[,] array2 = new int[2, 2];
                Console.WriteLine("Enter elements into second array");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                //// dispaly array
                Console.WriteLine("Entered elements of second 2D array are:");
                for (int i = 0; i < row; i++) 
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write("|"+array2[i, j] + "\t");
                    }

                    Console.WriteLine();
                }

                int[,] result = new int[row, column];
                ////This for loop used to multipication of 2d array
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        result[i, j] = 0;
                        for (int k = 0; k < row; k++)
                        {
                            result[i, j] = array[i, j] * array2[i, j];
                        }
                    }
                }

                Console.WriteLine("Multipication of two 2D arrays are :");
                ////This for loop used to diplay multipication of 2d array
                for (int i = 0; i < row; i++)
                {
                    Console.Write("|" );
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(+result[i, j] + "|");
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Triple Addition as function
        /// </summary>
        /// <param name="number">number as parameter</param>
        public void TripleAddition(int number)
        {
            try
            {
                int i, j, k;
                int count = 0;
                Console.WriteLine("Enetr number of elements:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Sorry Triple not found in given array");
                    Console.WriteLine("Array length should be greater than two:");
                }
                int[] array = new int[number];
                ////loop used to take a array element
                Console.WriteLine("Enetr Elements into the array:");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("The sub arrays of triple elements are:");
                for (i = 0; i < array.Length - 2; i++)
                {
                    for (j = i + 1; j < array.Length - 1; j++)
                    {
                        for (k = j + 1; k < array.Length; k++)
                        {
                            if (array[i] + array[j] + array[k] == 0)
                            {
                                count++;
                                
                                Console.WriteLine("[" + array[i] + " ," + array[j] + " ," + array[k]+"]");
                            }                           
                        }                  
                    }
                }

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// DistanceFromPoint as function
        /// </summary>
        /// <param name="x">x as parameter</param>
        /// <param name="y">y as parameter</param>
        public void DistanceFromPoint(int x, int y)
        {
            Console.WriteLine("Enter Two Points");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            double distance = 0;
            distance = Math.Sqrt((x * x) + (y * y));
            
            Console.WriteLine("Euclidean Distance for " + x + " and " + y + " from origine (0,0) is " + distance + " .");
        }


        /// <summary>
        /// FindPermutation as function
        /// </summary>
        /// <param name="letter">letter as parameter</param>       
        ///count number of distinct permuatations
        static int DistinctPermutationCount = 0, k;
        ///lenght of the input string,newlenght is lenght of the disticnt permutation array of string
        public static int lenght, newlenght = 0;
        ///factorial of the lenght of the string for dynamic array length and set it to possiblePermuatationlenght 
        static int factorial = 1, possiblePermuatationlenght;
        ///array of string for distinct string permutations
        public static String[] distinctPermutationStringArray = new String[10000]; 

        public void FindPermutation(string m_InputStringparam)
        {
            
            void permutation(string m_InputString, int start, int end)
            {

                if (start == end)
                {
                    Console.WriteLine(m_InputString);
                    getDistinctString(m_InputString);
                }
                else
                {
                    for (int i = start; i <= end; i++)
                    {
                        m_InputString = swap(m_InputString, start, i);
                        permutation(m_InputString, start + 1, end);
                        m_InputString = swap(m_InputString, start, i);

                    }
                }
            }
        }
        
        /** 
     * Swap Characters at position 
     * @param string string value 
     * @param i position 1 
     * @param j position 2 
     * @return swapped string 
*/

        public String swap(string m_InputString, int i, int j)
        {
            char temp;
            char[] charArray = m_InputString.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string charsStr = new string(charArray);
            return charsStr;

        }
        public static void getDistinctString(String paramString)
        {
            int i = 0, icnt = 1;
            for (i = 0; i < newlenght; i++)
            {
                if (distinctPermutationStringArray[i].Equals(paramString))
                {
                    icnt++;
                    break;
                }
            }
            if (newlenght == 0)
            {
                distinctPermutationStringArray[newlenght] = paramString;
                newlenght++;
                DistinctPermutationCount++;
                icnt++;
            }
            else if (icnt == 1)
            {
                distinctPermutationStringArray[newlenght] = paramString;
                newlenght++;
                DistinctPermutationCount++;
            }
        }
        /// <summary>
        /// ElapsedTime as function
        /// </summary>
        public void ElapsedTime()
        {
            /*char start;
            char stop;
            double startT;
            double stopT;
            Stopwatch stopwatchObj = new Stopwatch();
            //Scanner sc = new Scanner(System.in);
            do
            {
                Console.WriteLine("If you want to start Stopwatch then Please press Y: ");
                start = Convert.ToChar(Console.ReadLine());

            } while (start != 'Y');

            startT = stopwatchObj.startWatch();

            do
            {
                Console.WriteLine("If you want to stop Stopwatch then Please press Y: ");
                stopT = Convert.ToChar(Console.ReadLine()); ;

            } while (stopT != 'Y');
            stopT = stopwatchObj.endWatch();
            startT = stopT - startT;
            Console.WriteLine("Time Elepsed :" + startT / 1000 + " Second");
            */
            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();
            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }


            stopwatch.Stop();
            Console.WriteLine("Elapsed Time = " + stopwatch.Elapsed);
        }

        /// <summary>
        /// Quadratic as function
        /// </summary>
        /// <param name="first">first as parameter</param>
        /// <param name="second"> second as parameter</param>
        /// <param name="third">third as parameter</param>
        public void Quadratic(int a, int b,int c)
        {
            Console.WriteLine("\n To find the roots of a quadratic equation of " +
                              "the form a*x*x + b*x + c = 0");
            /* double delta, root1, root2;
             delta = (b * b) - (4 * a * c);
             root1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
             root2 = ((-b) - Math.Sqrt(delta)) / (2 * a);
             Console.WriteLine(delta + "\n" + root1 + "\n" + root2);
             */
            Console.Write("\n Enter value for a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter value for b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter value for c : ");
            c = Convert.ToInt32(Console.ReadLine());

                int m;
                double r1, r2, d1;
             
                d1 = b * b - 4 * a * c;

            if (a == 0)
                m = 1;
            else if (d1 > 0)
                m = 2;
            else if (d1 == 0) 
                    m = 3;
                else
                    m = 4;
                switch (m)
                {
                    case 1:
                        Console.WriteLine(@"\n Not a Quadratic equation, 
                                          Linear equation");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("\n Roots are Real and Distinct");
                        r1 = (-b + Math.Sqrt(d1)) / (2 * a);
                        r2 = (-b - Math.Sqrt(d1)) / (2 * a);
                        Console.WriteLine("\n First root is {0:#.##}", r1);
                        Console.WriteLine("\n Second root is {0:#.##}", r2);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("\n Roots are Real and Equal");
                        r1 = r2 = (-b) / (2 * a);
                        Console.WriteLine("\n First root is {0:#.##}", r1);
                        Console.WriteLine("\n Second root is {0:#.##}", r2);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("\n Roots are Imaginary");
                        r1 = (-b) / (2 * a);
                        r2 = Math.Sqrt(-d1) / (2 * a);
                        Console.WriteLine("\n First root is {0:#.##} + i {1:#.##}",
                                           r1, r2);
                        Console.WriteLine("\n Second root is {0:#.##} - i {1:#.##}",
                                          r1, r2);
                        Console.ReadLine();
                        break;
                }
        }

        /// <summary>
        /// Calculate Temperature as function
        /// </summary>
        /// <param name="temperature">temperature as parameter</param>
        /// <param name="speed">speed as parameter</param>
        public void CalculateTemperature(int temperature, int speed)
        {
            double windchill;
            Console.WriteLine("Enter temperature");
            temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter speed");
            speed = Convert.ToInt32(Console.ReadLine());
            if ((temperature <= 50) && (speed > 3 && speed < 120))
            {
                Console.WriteLine(temperature + " " + speed);
            }
            else
            {
               this.CalculateTemperature(temperature, speed);
            }

            windchill = (35.75 + 0.6215) * (temperature + 0.4275) * (temperature - 35.75) * Math.Pow(speed, 0.16);
            Console.WriteLine(windchill);
        }

        /// <summary>
        /// FindLeapYear is function
        /// </summary>
        /// <param name="year">year is parameter</param>
        public void FindLeapYear(int year)
        {
            try
            {
                year = Math.Abs(year);
                if (year <= 4 && year >= 4)
                {
                    Console.WriteLine("year shoukd be 4 digits");
                    this.FindLeapYear(year);
                }

                if (year % 4 == 0 || year % 100 == 0 || year % 400 == 0)
                {
                    Console.WriteLine(year + " " + "It is leap year");
                }
                else
                {
                    Console.WriteLine(year + " " + "This is not leap year");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Cross Game as method
        /// </summary>
        public void CrossGame()
        {
            try
            {
               char[] array = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                int player = 1;
                int choice;
                int flag = 0;
                do
                {
                    Console.WriteLine("Player1:X and Player2:O");
                    Console.WriteLine("\n");
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Player 2 have been chance");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 have been chance");
                    }

                    Console.WriteLine("\n");
                    Board();
                    choice = int.Parse(Console.ReadLine());
                    if (array[choice] != 'X' && array[choice] != 'O')
                    {
                        if (player % 2 == 0)
                        {
                            array[choice] = 'O';
                            player++;
                        }
                        else
                        {
                            array[choice] = 'X';
                            player++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("row {0} is already fill with {1}", choice, array[choice]);
                        Console.WriteLine("\n");
                        Console.WriteLine("wait for 2 seconds");
                        Thread.Sleep(2000);
                    }

                    flag = CheckWin();
                }
                while (flag != 1 && flag != -1);
                Console.Clear();
                Board();
                if (flag == 1)
                {
                    Console.WriteLine("player {0} has won", (player % 2) + 1);
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                Console.ReadLine();
                 void Board()
                {
                    Console.WriteLine("     |     |      ");
                    Console.WriteLine("  {0}  |  {1}  |  {2}", array[1], array[2], array[3]);
                    Console.WriteLine("_____|_____|_____ ");
                    Console.WriteLine("     |     |      ");
                    Console.WriteLine("  {0}  |  {1}  |  {2}", array[4], array[5], array[6]);
                    Console.WriteLine("_____|_____|_____ ");
                    Console.WriteLine("     |     |      ");
                    Console.WriteLine("  {0}  |  {1}  |  {2}", array[7], array[8], array[9]);
                    Console.WriteLine("     |     |      ");
                }

                int CheckWin()
                {                                  
                    if (array[1] == array[2] && array[2] == array[3])
                    {
                        return 1;
                    }                               
                    else if (array[4] == array[5] && array[5] == array[6])
                    {
                        return 1;
                    }                   
                    else if (array[6] == array[7] && array[7] == array[8])
                    {
                        return 1;
                    }                                            
                    else if (array[1] == array[4] && array[4] == array[7])
                    {
                        return 1;
                    }                    
                    else if (array[2] == array[5] && array[5] == array[8])
                    {
                        return 1;
                    }                  
                    else if (array[3] == array[6] && array[6] == array[9])
                    {
                        return 1;
                    }                   
                    else if (array[1] == array[5] && array[5] == array[9])
                    {
                        return 1;
                    }
                    else if (array[3] == array[5] && array[5] == array[7])
                    {
                        return 1;
                    }                                   
                    else if (array[1] != '1' && array[2] != '2' && array[3] != '3' && array[4] != '4' && array[5] != '5' && array[6] != '6' && array[7] != '7' && array[8] != '8' && array[9] != '9')
                    {
                        return -1;
                    }             
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }   
}
