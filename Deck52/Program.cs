using System;
using System.Collections.Generic;
using System.Linq;


namespace Deck52
{
    public static class StrHelper
    {
        public static string ChangeFirstLatterCase(this string inputString)
        {
            if(inputString.Length > 0)
            {
                char[] CharArrays = inputString.ToCharArray();
                CharArrays[0] = char.IsUpper(CharArrays[0])? char.ToLower(CharArrays[0]) : char.ToUpper(CharArrays[0]);
                return new string(CharArrays);
            }
            return inputString;
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            List<Deck> FUllDeck = new List<Deck>();
            FUllDeck.CreateDeck();
            FUllDeck.ShowCards();
            FUllDeck.Shuffle();
            FUllDeck.ShowCards();
            FUllDeck = FUllDeck.ResetDeck();
            FUllDeck.ShowCards();
            Console.ReadLine();
        }
    }

    public class Deck 
    {
        public int Sr { get; set; }
        public string Card { get; set; }
        public string Suite { get; set; }
    }

    public static class DeckHelper
    {
        public static void CreateDeck(this List<Deck> deck1)
        {
            deck1.AddSuites("Clubs");
            deck1.AddSuites("Dimonds");
            deck1.AddSuites("Hearts");
            deck1.AddSuites("Spades");
        }

        private static void AddSuites(this List<Deck> p, string SuiteName)
        {
            p.Add(new Deck { Sr = p.Count + 1, Card = "ACE",   Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Two",   Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Three", Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Four",  Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Five",  Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Six",   Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Seven", Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Eight", Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Nine",  Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Ten",   Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Joker", Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "Queen", Suite = SuiteName });
            p.Add(new Deck { Sr = p.Count + 1, Card = "king",  Suite = SuiteName });
        }
    }

    public static class MySuffule
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void ShowCards(this List<Deck> list)
        {
            Console.WriteLine("====================Show Cards started======================");
            int k = 0;
            foreach (var i in list)
            {
                
                Console.WriteLine(k + " = " + i.Sr + " - " + i.Card + "- Of " + i.Suite);
                k = k + 1;
            }
            Console.WriteLine("====================Show Cards Ended=======================");
        }
        public static List<Deck> ResetDeck(this List<Deck> list)
        {
            return list.OrderBy(x => x.Sr).ToList();
        }
    }
}





//string strName = string.Empty;
//var ress = strName.ChangeFirstLatterCase();
//var ress1 = StrHelper.ChangeFirstLatterCase(strName);
//Console.WriteLine(ress);