using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1) Reverse letters
            char c1 = Console.ReadKey().KeyChar;
            Console.ReadLine();
            char c2 = Console.ReadKey().KeyChar;
            Console.ReadLine();
            char c3 = Console.ReadKey().KeyChar;
            Console.ReadLine();
            Console.WriteLine("{2} {1} {0}",c1,c2,c3);
            Console.ReadKey();
            */

            /* 2)Triangle
            int n = Convert.ToInt16(Console.ReadLine());
            int width = Convert.ToInt16(Console.ReadLine());
            int f = width;
            for(int i=1;i<=width;i++)
            {
                for(int j=1;j<= width;j++)
                {
                    if (j >= f)
                        Console.Write(" " + n + " ");
                    else
                        Console.Write(" ");
                }
                f--;
                Console.WriteLine();
            }
            Console.ReadKey();
            */


            /* 3) Validation
            int @try = 0;
            while(@try<3)
            {
                Console.Write("Enter User Id : ");
                String user_id = Console.ReadLine();
                Console.Write("Enter Password : ");
                String password = Console.ReadLine();
                @try++;
                if (user_id.Equals(password))
                {
                    Console.WriteLine("Welcome ! " + user_id);
                    break;
                }
                else if(@try!=3)
                    Console.WriteLine("Try Again !");
            }
            if (@try == 3)
                Console.WriteLine("Sorry ! You are not Authorized");
            Console.ReadKey();
            */

            /* 5) Perimeter and Area of a circle
            Console.Write("Enter the radius of circle : ");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter = "+(6.28 * radius));
            Console.WriteLine("Area = " + (3.14 * radius * radius));
            Console.ReadKey();
            */

            /* 6) Function : x = y2 + 2y + 1
            Console.WriteLine("Function : x = y2 + 2y + 1");
            for (int i = -5; i <= 5; i++)
                Console.WriteLine("When y = "+i+" then x = "+((i*i)+(2*i)+1));
            Console.ReadKey();
            */

            /* 7) Speed
            Console.Write("Enter distance : ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time : ");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Speed = " + (distance / time) + " kmph");
            Console.WriteLine("Speed = " + (distance / time) * 0.62137119223733 + " mph");
            Console.ReadKey();
            */

            /* 8) Sphere
            Console.Write("Enter the radius of sphere : ");
            float radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Surface area = " + (12.56 * radius * radius));
            Console.WriteLine("Volume = " + ((4 / 3) * 3.14 * radius * radius * radius));
            Console.ReadKey();
            */

            /* 9) Vowel or digit 
            Console.Write("Enter a lowercase letter : ");
            char letter = Console.ReadKey().KeyChar;
            Console.ReadLine();
            if (letter >= 97 && letter <= 122)
            {
                if(letter == 97 || letter == 101 || letter == 105 || letter == 111 || letter == 117)
                    Console.WriteLine("It is a Vowel");
                else
                    Console.WriteLine("It is a Consonant");
            }
            else if (letter >= 48 && letter <= 57)
                Console.WriteLine("It is a Digit");
            else
                Console.WriteLine("It is a Special Symbol");
            Console.ReadKey();
            */

            /* 10) Odd or even 
            int n1 = Convert.ToInt16(Console.ReadLine());
            int n2 = Convert.ToInt16(Console.ReadLine());
            if (n1 % 2 == 0 && n2 % 2 == 0)
                Console.WriteLine("True");
            else if (n1 % 2 != 0 && n2 % 2 != 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.ReadKey();
            */

            /* 11) Decimal to Binary
            Console.Write("Enter a decimal number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary Format : "+Convert.ToString(n,2));
            Console.ReadKey();
            */

            /* 12)
            Console.Write("Enter Number 1 : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            int n2 = int.Parse(Console.ReadLine());
            if(n1==n2)
                Console.Write("Both are equal");
            else
                Console.Write("Not equal");
            Console.ReadKey();
            */

            /* 13)
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            if(n%2==0)
                Console.Write("Even");
            else
                Console.Write("Odd");
            Console.ReadKey();
            */

            /* 14)
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
                Console.Write("Positive");
            else
                Console.Write("Negative");
            Console.ReadKey();
            */

            /* 15) leap year
            Console.Write("Enter the year : ");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
                Console.WriteLine("Leap Year");
            else if(year % 4 ==0 && year % 100 != 0)
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not Leap Year");
            Console.ReadKey();
            */

            /* 16)
            Console.Write("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            if (age > 18)
                Console.WriteLine("Your eligible to cast vote .");
            else
                Console.WriteLine("You are not eligible to vote .");
            Console.ReadKey();
            */

            /* 17)
            Console.Write("Enter the value of m : ");
            int m = int.Parse(Console.ReadLine());
            if (m > 0)
                Console.WriteLine("n = 1");
            else if(m == 0)
                Console.WriteLine("n = 0");
            else
                Console.WriteLine("n = -1");
            Console.ReadKey();
            */


            /* 18)
            Console.Write("Enter your height in feet : ");
            float height = float.Parse(Console.ReadLine());
            if (height < 5)
                Console.WriteLine("You're Short !");
            else if (height > 5 && height < 7)
                Console.WriteLine("You're Medium !");
            else
                Console.WriteLine("You're very tall !");
            Console.ReadKey();
            */

            /* 19) Largest of three numbers
            Console.Write("Enter Number 1 : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number 3 : ");
            int n3 = int.Parse(Console.ReadLine());
            if(n1 > n2)
            {
                if (n1 >= n3)
                    Console.WriteLine(n1 + " is large");
                else
                    Console.WriteLine(n3 + " is large");
            }
            else
            {
                if (n2 >= n3)
                    Console.WriteLine(n2 + " is large");
                else
                    Console.WriteLine(n3 + " is large");
            }
            Console.ReadKey();
            */


            /* 20) x,y coordinate
            Console.Write("Enter x coordinate : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate : ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("The point ( " + x + " , " + y + " ) lies in 1st quadrant");
            else if(x < 0 && y > 0)
                Console.WriteLine("The point ( " + x + " , " + y + " ) lies in 2nd quadrant");
            else if(x < 0 && y < 0)
                Console.WriteLine("The point ( " + x + " , " + y + " ) lies in 3rd quadrant");
            else
                Console.WriteLine("The point ( " + x + " , " + y + " ) lies in 4th quadrant");
            Console.ReadKey();
            */

            /* 21) Eligibility
            Console.Write("Enter marks in maths : ");
            int math = int.Parse(Console.ReadLine());
            Console.Write("Enter marks in physics : ");
            int phy = int.Parse(Console.ReadLine());
            Console.Write("Enter marks in chemistry : ");
            int chem = int.Parse(Console.ReadLine());
            if (math >= 65 && phy >= 55 && chem >= 50 && math + phy + chem >= 180)
                Console.WriteLine("You're Eligible");
            else
                Console.WriteLine("You're Not Eligible");
            Console.ReadKey();
            */


            /* 22) Quadratic roots 
            Console.Write("Enter the value of a : ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter the value of b : ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter the value of c : ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Root 1 = " + ((-1) * b + Math.Sqrt(b * b - 4 * a * c)) / ( 2 * a ));
            Console.WriteLine("Root 2 = " + ((-1) * b - Math.Sqrt(b * b - 4 * a * c)) / ( 2 * a ));
            Console.ReadKey();
            */

            /* 23)
            Console.Write("Enter the Roll number : ");
            String roll_no = Console.ReadLine();
            Console.Write("Enter the Name : ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the Marks in three subject : ");
            Console.Write("Enter marks in maths : ");
            int math = int.Parse(Console.ReadLine());
            Console.Write("Enter marks in physics : ");
            int phy = int.Parse(Console.ReadLine());
            Console.Write("Enter marks in chemistry : ");
            int chem = int.Parse(Console.ReadLine());
            Console.WriteLine("Total = "+(math + phy + chem));
            Console.WriteLine("Percentage = "+ ((math + phy + chem)/3)+"%");
            Console.ReadKey();
            */

            /* 24) Temperature
            Console.Write("Enter the temperature : ");
            int temp = Convert.ToInt16(Console.ReadLine());
            if (temp < 0)
                Console.WriteLine("Freezing weather");
            else if (temp >= 0 && temp < 10)
                Console.WriteLine("Very cold weather");
            else if (temp >= 10 && temp < 20)
                Console.WriteLine("Cold weather");
            else if (temp >= 20 && temp < 30)
                Console.WriteLine("Normal in Temp");
            else if (temp >= 30 && temp < 40)
                Console.WriteLine("Its Hot");
            else if(temp > 40)
                Console.WriteLine("Its Very Hot");
            Console.ReadKey();
            */

            /* 25) Triangle
            Console.WriteLine("Enter the angles of Triangle");
            Console.Write("Enter 1st angle : ");
            int angle1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter 2nd angle : ");
            int angle2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter 3rd angle : ");
            int angle3 = Convert.ToInt16(Console.ReadLine());
            if (angle1 == angle2 && angle2 == angle3 && angle3 == angle1)
                Console.WriteLine("It is an Equilateral triangle");
            else if (angle1 != angle2 && angle2 != angle3 && angle3 != angle1)
                Console.WriteLine("It is an Scalene triangle");
            else
                Console.WriteLine("It is an Isosceles triangle");
            Console.ReadKey();
            */


            /* 26) Triangle
            Console.WriteLine("Enter the angles of Triangle");
            Console.Write("Enter 1st angle : ");
            int angle1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter 2nd angle : ");
            int angle2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter 3rd angle : ");
            int angle3 = Convert.ToInt16(Console.ReadLine());
            if (angle1 + angle2 + angle3 == 180)
                Console.WriteLine("It is a Triangle .");
            else
                Console.WriteLine("It is not a Triangle .");
            Console.ReadKey();
            */


            /* 27)
            Console.Write("Enter a alphabet : ");
            char alpha = Console.ReadKey().KeyChar;
            char letter = Char.ToLower(alpha);
            Console.ReadLine();
            if (letter >= 97 && letter <= 122)
            {
                if (letter == 97 || letter == 101 || letter == 105 || letter == 111 || letter == 117)
                    Console.WriteLine(alpha + " is a Vowel .");
                else
                    Console.WriteLine(alpha + " is a Consonant .");
            }
            Console.ReadKey();
            */


            /* 28) Profit or Loss
            Console.Write("Enter the Cost price : ");
            float cp = float.Parse(Console.ReadLine());
            Console.Write("Enter the Selling price : ");
            float sp = float.Parse(Console.ReadLine());
            if (sp > cp)
                Console.WriteLine("Profit");
            else if (sp < cp)
                Console.WriteLine("Loss");
            else if (sp == cp)
                Console.WriteLine("Neither Loss Nor Profit");
            Console.ReadKey();
            */


            /* 29) Electricity bill
            Console.Write("Enter the Customer_Id : ");
            String cus_id = Console.ReadLine();
            Console.Write("Enter the Name : ");
            String name = Console.ReadLine();
            Console.Write("Enter the energy consumed : ");
            float ene = float.Parse(Console.ReadLine());
            if (ene <= 100)
                Console.WriteLine(name + " has to pay Rs."+(ene * 1.50));
            else if(ene >100 && ene <= 200)
                Console.WriteLine(name + " has to pay Rs." + (ene * 2.00));
            else if (ene > 200 && ene <= 300)
                Console.WriteLine(name + " has to pay Rs." + (ene * 2.50));
            else if (ene > 300 && ene <= 400)
                Console.WriteLine(name + " has to pay Rs." + (ene * 3.00));
            else if (ene > 400 && ene <= 500)
                Console.WriteLine(name + " has to pay Rs." + (ene * 4.00));
            else if (ene > 500)
                Console.WriteLine(name + " has to pay Rs." + (ene * 5.00));
            Console.ReadKey();
            */


            /* 30) Grade
            Console.Write("Enter the grade : ");
            char grade = Console.ReadKey().KeyChar;
            Console.ReadLine();
            switch(grade)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default :
                    Console.WriteLine("Invalid grade !");
                    break;
            }
            Console.ReadKey();
            */


            /* 31) Day
            Console.Write("Enter day number : ");
            int day = int.Parse(Console.ReadLine());
            switch(day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default :
                    Console.WriteLine("Invalid day !");
                    break;
            }
            Console.ReadKey();
            */


            /* 32) Digit
            Console.Write("Enter any digit : ");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 0:
                    Console.WriteLine("Zero");
                    break;
                default:
                    Console.WriteLine("Invalid digit !");
                    break;
            }
            Console.ReadKey();
            */


            /* 33) Months
            Console.Write("Enter Month : ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("Febraury");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Invalid Month !");
                    break;
            }
            Console.ReadKey();
            */


            /* 34) Days in month
            Console.Write("Enter Month : ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("January has 31 days .");
                    break;
                case 2:
                    Console.WriteLine("Febraury  has 28 or 29 days .");
                    break;
                case 3:
                    Console.WriteLine("March has 31 days .");
                    break;
                case 4:
                    Console.WriteLine("April has 30 days .");
                    break;
                case 5:
                    Console.WriteLine("May has 31 days .");
                    break;
                case 6:
                    Console.WriteLine("June has 30 days .");
                    break;
                case 7:
                    Console.WriteLine("July has 31 days .");
                    break;
                case 8:
                    Console.WriteLine("August has 31 days .");
                    break;
                case 9:
                    Console.WriteLine("September has 30 days .");
                    break;
                case 10:
                    Console.WriteLine("October has 31 days .");
                    break;
                case 11:
                    Console.WriteLine("November  has 30 days .");
                    break;
                case 12:
                    Console.WriteLine("December has 31 days .");
                    break;
                default:
                    Console.WriteLine("Invalid Month !");
                    break;
            }
            Console.ReadKey();
            */


            /* 35) Menu driven for geometrical shapes
            int choice;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1) Area of Circle");
                Console.WriteLine("2) Area of Square");
                Console.WriteLine("3) Area of Rectangle");
                Console.WriteLine("4) Exit");
                Console.Write("Enter your Choice : ");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the radius of the circle : ");
                        int radius = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The area of circle is : "+(3.14 * radius * radius));
                        break;
                    case 2:
                        Console.Write("Enter the side of the Square : ");
                        int side = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The area of square is : " + (side * side));
                        break;
                    case 3:
                        Console.WriteLine("Enter the length and breadth of the circle : ");
                        int length = Convert.ToInt16(Console.ReadLine());
                        int breadth = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("The area of circle is : " + (length * breadth));
                        break;
                    default:
                        Console.WriteLine("Exit ! Invalid Option");
                        break;
                }
            } while (choice < 4);
            Console.ReadKey();
            */



            /* 36) Menu driven for simple calculations
            int choice;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraction");
                Console.WriteLine("3) Multiplication");
                Console.WriteLine("4) Division");
                Console.WriteLine("4) Exit");
                Console.Write("Enter your Choice : ");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter two numbers to Add : ");
                            int n1 = Convert.ToInt16(Console.ReadLine());
                            int n2 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("The Addition produces : " + (n1 + n2));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter two numbers to Subtract : ");
                            int n1 = Convert.ToInt16(Console.ReadLine());
                            int n2 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("The Subtraction produces : " + (n1 - n2));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter two numbers to Multiply : ");
                            int n1 = Convert.ToInt16(Console.ReadLine());
                            int n2 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("The Multiplication produces : " + (n1 * n2));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter two numbers to Divide : ");
                            int n1 = Convert.ToInt16(Console.ReadLine());
                            int n2 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("The Division produces : " + (n1 / n2));
                            break;
                        }
                    default:
                        Console.WriteLine("Exit ! Invalid Option");
                        break;
                }
            } while (choice < 5);
            Console.ReadKey();
            */


            /* 37) Sum of first 10 natural numbers
            Console.WriteLine("Sum of first 10 natural numbers is : ");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
                sum += i;
            Console.WriteLine(sum);
            Console.ReadKey();
            */

            /* 38) sum of n terms
            Console.Write("Enter the number of terms : ");
            int n = Convert.ToInt16(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("The term is : "+i);
                sum += i;
            }
            Console.WriteLine("The sum of "+n+" terms is "+sum);
            Console.ReadKey();
            */

            /* 39) Sum of 10 terms
            Console.WriteLine("Enter 10 number : ");
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                int n = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("The entered number is : " + n);
                sum += n;
            }
            Console.WriteLine("The sum of terms is " + sum);
            Console.WriteLine("The average of terms is " + sum/10);
            Console.ReadKey();
            */

            /* 40) Cube of numbers
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine("The cube of "+i+" is "+(i*i*i));
            Console.ReadKey();
            */

            /* 41) sum of odd natural numbers 
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = Convert.ToInt16(Console.ReadLine());
                if(num%2!=0)
                sum += num;
            }
            Console.WriteLine("The sum of Odd natural terms is " + sum);
            Console.ReadKey();
            */

            /* 42) Pattern 
            Console.Write("Enter the height of the Triangle : ");
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */


            /* 43) Pattern
            Console.Write("Enter the height of the Triangle : ");
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            /* 44) Pattern
            Console.Write("Enter the height of the Triangle : ");
            int h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */



            /* 45) Pattern
            Console.Write("Enter the height of the Triangle : ");
            int h = int.Parse(Console.ReadLine());
            int c = 1;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(c+++" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            */

            /* 46) Pattern
            Console.Write("Enter the height of the Triangle : ");
            int h = int.Parse(Console.ReadLine());
            int f = h;
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h; j++)
                {
                    if (j >= f)
                        Console.Write(" " + i + " ");
                    else
                        Console.Write(" ");
                }
                f--;
                Console.WriteLine();
            }
            Console.ReadKey();
            */
        }
    }
}
