using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticingLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression");
            List<Person> listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);
            Retriveing_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
            ChechkingForTeenagerPerson(listPersonInCity);
            AllPersonsAverageAge(listPersonInCity);
            SpecificPersonName(listPersonInCity);
            Skip_Person_Age_LessThanSixty(listPersonInCity);
            Remove_Person(listPersonInCity);
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton,OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore,NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", 95));

            Console.WriteLine(listPersonInCity.ToString());
            listPersonInCity.ForEach(x => Console.WriteLine("{0}\t",x.Name.ToString()));
        }
        private static void Retriveing_TopTwoRecord_ForAgels_LessThanSixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + "\t\tAge");
            }
        }
        private static void ChechkingForTeenagerPerson(List<Person> listPersonInCity)
        {
            if (listPersonInCity.Any(e => e.Age >= 13 && e.Age < 19))
            {
                Console.WriteLine("Yes, we have some teen-agers in the list");
            }
            else
                Console.WriteLine("No, we don't have teen-ager in the list");
        }
        private static void AllPersonsAverageAge(List<Person> listPersonInCity)
        {
            var avgage = listPersonInCity.Average(e => e.Age);

            Console.WriteLine("Average In Person Data:" + avgage);
        }
        private static void SpecificPersonName(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter Person Name:");
            string personName = Console.ReadLine();
            if (listPersonInCity.Exists(e => e.Name.Equals(personName)))
            {
                Console.WriteLine(personName+ "" + "Exist in list");
            }
            else
            {
                Console.WriteLine(personName+ "" + " Not exist in list");
            }
        }
        private static void Skip_Person_Age_LessThanSixty(List<Person> listPersonInCity)
        {
           foreach(Person person in listPersonInCity.SkipWhile(e => e.Age < 60))
           {
              Console.WriteLine("Name : " + person.Name + " \t\tAge" );
           }
        }
        private static void Remove_Person(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter Person Name:");
            string personName = Console.ReadLine();
            listPersonInCity.RemoveAll(e => (e.Name == personName));
            
        }
    }
       
}
