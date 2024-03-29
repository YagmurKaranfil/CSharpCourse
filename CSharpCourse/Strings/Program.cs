﻿namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Intro
            string sentence = "My name is Engin Demiroğ";

            var resut = sentence.Length;
            var resut2 = sentence.Clone();
            sentence = "My name is Derin Demiroğ";

            bool result3 = sentence.EndsWith("ğ"); //ğ İLE BİTİYOR MU
            bool result4 = sentence.StartsWith("My name"); // ile başlıyor mu

            var result5 = sentence.IndexOf("name"); //arama yapmayı sağlar
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello");
            var result9 = sentence.Substring(3, 4); //parçalar
            var result10 = sentence.ToLower(); //küçük harf
            var result11 = sentence.ToUpper(); //büyük harf
            var result12 = sentence.Replace(" ","-"); //değiştirir
            var result13 = sentence.Remove(2,5); //belli bir yerden sonra  5tane siler

            Console.WriteLine(resut);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";


            Console.WriteLine(String.Format("{0} {1}", city, city2));

        }
    }
}
