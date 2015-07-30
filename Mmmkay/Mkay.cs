using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mmmkay
{
    class Mkay
    {
        private Random r = new Random();
        private string input { get; set; }

        public Mkay(string input)
        {
            //Constructs all the things
            this.input = input;
        }


        public string getMkay(int num)
        {
            if (num == 0)
                return "m'kay";
            else if (num == 1)
                return "mm'kay";
            else return "mmm'kay";
        }

        public string getMKAY(int num)
        {
            if (num == 0)
                return "M'kay";
            else if (num == 1)
                return "Mm'kay";
            else return "Mmm'kay";
        }

        public void computeString()
        {
            string[] parts = this.input.Split(null);
            List<string> text = parts.ToList<string>();
            StringBuilder sb = new StringBuilder();
            bool found = false;
            List<int> places = new List<int>();
            
            for (int i = 0; i < parts.Length; i++ )
            {
                string temp = parts[i];
                if(temp.Contains(','))
                {
                    if(FiftyFifty())
                    {
                        text[i] += " " + getMkay(r.Next(0, 3)) + ", ";
                        found = true;
                    }
                    else
                    {
                        places.Add(i);
                    }
                }
                else if (temp.Contains('.') || temp.Contains('?') || temp.Contains('!'))
                {
                    if (FiftyFifty())
                    {
                        char end = temp[temp.Length - 1];
                        text[i] += " " + getMKAY(r.Next(0, 3)) + end + " ";
                        found = true;
                    }
                    else
                    {
                        places.Add(i);
                    }
                }

                text[i] += " ";
            }
               
            if(!found)
            {
                int position = r.Next(0, places.Count);
                if(parts[position].Contains(','))
                    text[position] += getMkay(r.Next(0, 3)) + ", ";
                else
                {
                    char end = parts[position].ElementAt(parts.Length - 1);
                    text[position] += getMKAY(r.Next(0, 3)) + end + " ";
                }
            }
            foreach(string s in text)
            {
                Console.Write(s);
            }
        }

        public bool FiftyFifty()
        {
            if (r.Next(0, 2) == 0)
                return false;
            else return true;
        }
    }
}
