using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_H.String_M
{
    class StringArray
    {
        public void blank()
        {
            StringSize();
        }

        static void StringSize()
        {
            
            StringGroup stg = new StringGroup();
            string word = stg.stringGroup_M();
            
            for (int i = 0; i < word.Length; i++) 
            {
                Console.SetCursorPosition(i, 2);
                Console.WriteLine("_");
            }
        }

    }
}
