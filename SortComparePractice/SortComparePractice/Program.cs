using System;
using System.Collections.Generic;

namespace SortComparePractice
{
    class Program
    {
        private static bool SearchCondition(int i)
        {
            return i == 10;
        }

        static void Main(string[] args)
        {
            //Sorting an Array
            int[] numbers = { 8, 9, 2, 20, 1, 5, 3, 10, 7, 6 };
            Array.Sort(numbers);
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            //Reversing Order of Array
            Array.Reverse(numbers);
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            //int searchResult = Array.Find(numbers, SearchCondition);
            int searchResult = Array.Find(numbers, search => search == 10);

            //this code will find the value returned by SearchCondition method
            int results = Array.Find(numbers, SearchCondition);

            //another example
            int result2 = Array.Find(numbers, search => search < 5);
            int result3 = Array.Find(numbers, search => search > 6 & search < 8);
            Console.WriteLine("Seach Results: " + searchResult + " " + results + " " + result2 +
                " " + result3);

            object myvalue = 20;
            Array.Sort(numbers);
            int bSearchResult = Array.BinarySearch(numbers, myvalue);
            Console.WriteLine("Search Results: " + searchResult);
            Console.WriteLine("Binary Search Results: " + bSearchResult);

            DateTime[] dates = {Convert.ToDateTime("2/1/2019"), Convert.ToDateTime("3/1/2017"),
                Convert.ToDateTime("3/20/2019")};
            Array.Sort(dates);
            foreach (DateTime date in dates)
                Console.WriteLine(date.ToString());

            //Sorting a list
            List<char> myList = new List<char>();
            myList.Add('c');
            myList.Add('a');
            myList.Add('d');
            myList.Add('b');
            myList.Add('e');

            myList.Sort();
            foreach(char item in myList)
            {
                Console.WriteLine(item);
            }

            //Reverse List
            myList.Reverse();
            foreach(char item in myList)
            {
                Console.WriteLine(item);
            }

            //Creating Complex Data
            SuperHero superman = new SuperHero("Superman", 10, 9, 5);
            SuperHero batman = new SuperHero("Batman", 3, 2, 7);
            SuperHero flash = new SuperHero("Flash", 6, 10, 4);

            SuperHero[] allSuperHeroes = { superman, batman, flash };

            //need a Comparer to Sort SuperHeroes
            //speed
            SuperSpeedComparer speedComparer = new SuperSpeedComparer();
            Array.Sort(allSuperHeroes, speedComparer);
            Console.WriteLine("\nList of Fastest Heroes");

            foreach(SuperHero hero in allSuperHeroes)
            {
                Console.WriteLine(hero.name);
            }

            SuperHero fastest = allSuperHeroes.GetValue(0) as SuperHero;
            Console.WriteLine("\nThe FASTEST Super Hero is " + fastest.name);

            //strength
            SuperStrengthComparer strengthComparer = new SuperStrengthComparer();
            Array.Sort(allSuperHeroes, strengthComparer);
            Console.WriteLine("\nList of Strongest Heroes");

            foreach(SuperHero hero in allSuperHeroes)
            {
                Console.WriteLine(hero.name);
            }

            SuperHero strongest = allSuperHeroes.GetValue(0) as SuperHero;
            Console.WriteLine("\nThe Sttrongest Super Hero is " + strongest.name);
        }
    }
}
