using System;
using System.Threading.Channels;
using static poker.main;

namespace poker
{
    class main
    {
        public enum suit { S, D, H, C };
        public struct Card
        {
            public suit suit;
            public int number;
        }

        public static Card[] card = new Card[52];
        public static int player = 5;
        static void Main(string[] args)
        {
            Cards();
            shuffle();
        }

        static void Cards()
        {
            int num = 0;
            int cardnum = 0;
            for (int i = 0; i < card.Length; i++)
            {
                num++;
                card[i] = new Card();
                card[i].suit = suit.S + cardnum;
                card[i].number = num;
                if (num >= 13)
                {
                    num = 0;
                    cardnum++;
                }
                Console.Write($"{card[i].suit} {card[i].number}.");
                if (card[i].number > 12)
                {
                    Console.WriteLine();
                }
            }
        }
        static void shuffle()
        {

        }

        static void give()
        {                                                   
            Random random = new Random();
            Card[] cardi = new Card[52];
            for(int i = 0; i < cardi.Length; i++)
            {
                cardi[i] = card[random.Next(card.Length)];
            }
            int num = 0;
            for(int j = 0; j < player; j++)
            {
                Console.Write($"player{j} ");
                for (int i = 1; i < player; i++)
                {
                    int rand = random.Next(card.Length);
                    Console.Write($"{cardi[rand].suit} {cardi[rand].number}.");
                }
                Console.WriteLine();
            }
            
        }
    }


}