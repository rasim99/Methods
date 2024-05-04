using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 
            //Console.WriteLine(PrintTwoNumResult(2,5));  

            //Task2
            //Console.WriteLine(PrintNumSquart(2));

            //Task3 
            //Console.WriteLine(SumArrayElements(10,20,30));

            //Task4 
            //PrintWelcomeMessage("Rasim","Mahmudov");

            //Task5
            //PrintReverseWord("Salam");

            //Task6
            //PrintNumberDeviceSeven(32);

            //Task7 
            //ucbucagin peremetri
            //Console.WriteLine(PrintPeremetr(10,15,5));

            //Kvadratin Peremetri
            //Console.WriteLine(PrintPeremetr(10));

            //Task8
            Console.WriteLine(CountOfSpice(" salam qaqa necesen  "));

        }

        //task 1 Gonderilmis iki int parametrnin hasilini tapan method yazin
        public static int PrintTwoNumResult(int a, int b)
        {
            int result = a * b;
            return result;
        }

        //Task2 Gonderilmis int parametrnin kvadratini tapan method yazin.
        public static int PrintNumSquart(int a)
        {
            int result = a * a;
            return result;
        }

        //Task 3 Gonderilmis bir olculu array parametrindeki elementlerin cemini tapan method yazin.
        public static int SumArrayElements(params int[]arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //Task 4.Iki string (name, surname) parametrinin xosgelmisen mesajini qaytaran method yazin.
        public static void PrintWelcomeMessage(string name,string surname)
        {
            Console.WriteLine($"{name} {surname} Xosh Gelmisiniz");
        }

        //Task 5.Gonderilmis bir string parametrni tersine qaytaran method yazin.
        public static void PrintReverseWord(string word)
        {
            string reversWord = " ";
            for (int i = word.Length-1;  i>=0; i--)
            {

                reversWord += word[i];
            }
            Console.WriteLine(reversWord);
        }


        //Task6.Methoda bir int parametr oturulur, eger o variable 7e bolunurse print edilsin ki 7e bolunur, 
        //bolunmurse hemin variable en yaxin ededi qaytarsin.
        public static void PrintNumberDeviceSeven(int number)
        {
            if (number %7==0)
            {
                Console.WriteLine($"{number} ededi 7e bolunur");
            }
            else
            {
                int temp = number % 7;
                Console.WriteLine(number-temp);
            }
        }

        //Task7Overload - bir birine overload olan iki metod yazin hansi ki biri kvadratinb perimetrini
        //digeri ise ucbucaqlinin perimetrini tapsin

        public static int PrintPeremetr(int a, int b,int c)
        {
            int peremetr=a+b+c;
            return peremetr;
        }
        public static int PrintPeremetr(int a)
        {
            int peremetr = a * 4;
            return peremetr;
        }


        //Task 8. Bir metod yazin hansi ki o string sentence gozleyir ve netice olaraq cumlede nece dene bosluq oldugunu qaytarir

        public static int CountOfSpice(string sentence)
        {
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    count++;
                }
            }

            return count;
        }

    }
}
