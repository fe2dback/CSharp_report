using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project_H.String_M
{
    class StringGroup
    {
        static int groups = 3;

        static string tag = "";
        public string stringGroup_M()
        {
            string word = "";
            return word = pick_tag();
        }
        static string pick_tag()
        {
            switch (random(1, groups + 1))
            {
                case 1:
                    tag = "fruit";
                    return fruits();
                    break;
                case 2:
                    
                    tag = "world";
                    return worlds();
                    break;
                case 3:
                    tag = "sport";
                    return sports();
                    break;
                default:
                    return "";
                    break;
            }

        }
        static string pick_word(string path)
        {
            string[] words = File.ReadAllLines(path);
            string[] value = new string[words.Length];
            if (words.Length > 0)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    value[i] = words[i];
                }
            }


            return value[random(0, words.Length)];
        }


        static string fruits()
        {
            string path = @"../../../../fruit.txt";
            return pick_word(path);

        }
        static string worlds()
        {
            string path = @"../../../../world.txt";
            return pick_word(path);
        }

        static string sports()
        {
            string path = @"../../../../sport.txt";
            return pick_word(path);
        }
        static int random(int start, int end)
        {
            Random random = new Random();
            int value = random.Next(start, end);
            return value;
        }
    }
}
