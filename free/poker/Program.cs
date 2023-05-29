using System;
using System.Threading.Channels;
using static poker.main;

namespace poker
{
    class main
    {

        static Random random = new Random();
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
            for(int i = 0 ; i < 100; i++)
            {
                Cards();
                showcard();
                Console.WriteLine();
                shuffle();
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.Clear();
            }
            
        }

        static void Cards()
        {
            int num = 0;
            int cardnum = 0;
            for (int i = 0; i < card.Length; i++)
            {
                num++;
                card[i].suit = suit.S + cardnum;
                card[i].number = num;
                if (num >= 13)
                {
                    num = 0;
                    cardnum++;
                }
            }
            
        }

        static void showcard()
        {
            for(int i = 0; i < card.Length;i++)
            {
                Console.Write($"{card[i].suit} {card[i].number}.");
                if (card[i].number > 12)
                {
                    Console.WriteLine();
                }
            }
        }

        static void shuffle()
        {
            int line = 0;
            List<Card> list = new List<Card>();
            List<Card> cards = new List<Card>();
            for (int i = 0; i < card.Length; ++i)
            {
                list.Add(card[i]);
            }
            for (int i = list.Count; i > 0; i--)
            {
                int c = random.Next(0, i);
                Console.Write($"{list[c].suit} {list[c].number}.");
                cards.Add(list[c]);
                list.Remove(list[c]);
                line++;
                if (line % 13 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Distribute(cards);
        }


        #region 수정중
        static void Distribute(List<Card> list)
        {
            for (int i = 0; i < player; i++)
            {
                Console.Write($"Player {i + 1}: ");
                Card[] playerCards = new Card[5];
                for (int j = 0; j < 5; j++)
                {
                    playerCards[j] = list[i * 5 + j];
                    Console.Write($"{list[i * 5 + j].suit} {list[i * 5 + j].number}.");
                }
                CheckCard(playerCards);
            }
        }
        #endregion
        static void CheckCard(Card[] playerCards)
        {

            switch (checkOnePair(playerCards))
            {
                case "onepair":
                    Console.WriteLine("One Pair");
                    break;
                case "twopair":
                    Console.WriteLine("Two Pair");
                    break;
                case "triple":
                    Console.WriteLine("Triple");
                    break;
                default:
                    Console.WriteLine("No Pair");
                    break;
            }
            Console.WriteLine();
        }

        static string checkTwoPair(Card[] cards)
        {
            int count = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = i + 1; j < cards.Length; j++)
                {
                    if (cards[i].number == cards[j].number)
                    {
                        ++count;     
                    }
                    
                } 
                
            }
            if (count == 2)
            {
                return "twopair";
            }
            else
            {
                return checkOnePair(cards);
            }
            
        }

        static string checkOnePair(Card[] cards)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = i + 1; j < cards.Length; j++)
                {
                    if (cards[i].number == cards[j].number)
                    {
                        return "onepair";
                    }
                }
            }
            return "";
        }
    }
}