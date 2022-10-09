using static System.Text.Json.JsonSerializer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.VisualBasic;

namespace inverted_index
{
    internal class indexing
    {
        public string str1 { get; set; }
        public string str2 { get; set; }

        public List<int> Index { get; set; } = new List<int>();
        //public List<int> indexList { get; set; } = new List<int>();
        public Dictionary<int, List<int>> indexList { get; set; } = new Dictionary<int, List<int>>();
        public Dictionary<int, string> dic { get; set; } = new Dictionary<int, string>();
        public Dictionary<int, List<string>> wordIndex { get; set; } = new Dictionary<int, List<string>>();
        public Dictionary<string, Dictionary<int, List<int>>> address { get; set; } = new Dictionary<string, Dictionary<int, List<int>>>();
        public List<int> indexList1 { get; set; } = new List<int>();

        public void Print(object input)
        {
            Console.WriteLine(Serialize(input));
            Console.WriteLine("-------------------");
        }
        
        private List<string> CleanString(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    input[i] = input[i].Trim();
                    input[i] = input[i].Replace(",", "");
                    input[i] = input[i].Replace("\"", "");
                    input[i] = input[i].Replace(")", " ");
                    input[i] = input[i].Replace("(", " ");
                    input[i] = input[i].Replace("<", " ");
                    input[i] = input[i].Replace(">", " ");
                    input[i] = input[i].Replace("?", "");
                    input[i] = input[i].Replace("!", "");
                    input[i] = input[i].Replace(".", "");
                    input[i] = input[i].Replace("=", "");
                    input[i] = input[i].Replace("+", "");
                    input[i] = input[i].Replace("-", "");
                    input[i] = input[i].Replace("@", "");
                    input[i] = input[i].Replace("#", "");
                    input[i] = input[i].Replace("$", "");
                    input[i] = input[i].Replace("%", "");
                    input[i] = input[i].Replace("^", "");
                    input[i] = input[i].Replace("&", "");
                    input[i] = input[i].Replace("*", "");
                    input[i] = input[i].Replace("_", "");
                    input[i] = input[i].Replace("\\", "");
                    input[i] = input[i].Replace("~", "");
                    input[i] = input[i].Replace("'", "");
                    input[i] = input[i].Replace("/", " ");
                    input[i] = input[i].Replace("*", "");
                    input[i] = input[i].Replace("-", "");
                    input[i] = input[i].Replace(";", "");
                    input[i] = input[i].Replace(":", " ");
                }
            }
            return input;
        }
        
        private List<string> CleanWords(List<string> input)
        {
            for (int i = 0; i < input.Count; i++)
            {

                if (input[i][0] == 'A' && input[i][1] == 'M' && input[i][2] == ' ') input[i] = input[i].Remove(0, 3);
                else if (input[i][0] == 'T' && input[i][1] == 'H' && input[i][2] == 'E' && input[i][2] == ' ') input[i] = input[i].Remove(0, 4);
                else if (input[i][0] == 'I' && input[i][1] == ' ') input[i] = input[i].Remove(0, 2);
                else if (input[i][0] == 'I' && input[i][1] == 'S' && input[i][2] == ' ') input[i] = input[i].Remove(0, 3);
                else if (input[i][0] == 'T' && input[i][1] == 'O' && input[i][2] == ' ') input[i] = input[i].Remove(0, 3);
                else if (input[i][0] == 'O' && input[i][1] == 'F' && input[i][2] == ' ') input[i] = input[i].Remove(0, 3);
                else if (input[i][0] == 'A' && input[i][1] == 'T' && input[i][2] == ' ') input[i] = input[i].Remove(0, 3);
                else if (input[i][0] == 'A' && input[i][1] == ' ') input[i] = input[i].Remove(0, 2);
                else if (input[i][0] == 'W' && input[i][1] == 'I' && input[i][2] == 'T' && input[i][3] == 'H' && input[i][4] == ' ') input[i] = input[i].Remove(0, 5);
                else if (input[i][0] == 'T' && input[i][1] == 'H' && input[i][2] == 'I' && input[i][3] == 'S' && input[i][4] == ' ') input[i] = input[i].Remove(0, 5);
                else if (input[i][0] == 'W' && input[i][1] == 'I' && input[i][2] == 'L' && input[i][3] == 'L' && input[i][4] == ' ') input[i] = input[i].Remove(0, 5);
                else if (input[i][0] == 'T' && input[i][1] == 'H' && input[i][2] == 'E' && input[i][3] == 'I' && input[i][4] == 'R' && input[i][2] == ' ') input[i] = input[i].Remove(0, 6);
                else if (input[i][0] == 'B' && input[i][1] == 'Y' && input[i][2] == ' ') input[i] = input[i].Remove(0, 3);
                else if (input[i][0] == 'B' && input[i][1] == 'E' && input[i][2] == 'E' && input[i][3] == 'N' && input[i][2] == ' ') input[i] = input[i].Remove(0, 5);
                else if (input[i][0] == 'I' && input[i][1] == 'T' && input[i][2] == ' ') input[i] = input[i].Remove(0, 3);
                input[i] = input[i].Replace(" AM ", " ");
                input[i] = input[i].Replace(" THE ", " ");
                input[i] = input[i].Replace(" I ", " ");
                input[i] = input[i].Replace(" IS ", " ");
                input[i] = input[i].Replace(" TO ", " ");
                input[i] = input[i].Replace(" OF ", " ");
                input[i] = input[i].Replace(" AT ", " ");
                input[i] = input[i].Replace(" A ", " ");
                input[i] = input[i].Replace(" WITH ", " ");
                input[i] = input[i].Replace(" WILL ", " ");
                input[i] = input[i].Replace(" THIS ", " ");
                input[i] = input[i].Replace(" THEIR ", " ");
                input[i] = input[i].Replace(" BY ", " ");
                input[i] = input[i].Replace(" BEEN ", " ");
                input[i] = input[i].Replace(" IT ", " ");
                input[i] = input[i].Trim();
                input[i] = input[i].ToUpper();
            }
            return input;
        }

        private void WordIndex(string str,int i)
        {
            List<string> words = new List<string>();
            Index.Add(0);
            Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
            List<int> list1 = new List<int>();
            List<int> list = new List<int>();
            Index[i] = 0;

            for (int j = 0; Index[i] < str.LastIndexOf(" ");)
            {
                Index[i] = str.IndexOf(" ", Index[i]);
                if (str[Index[i] + 1] == ' ')
                {
                    Index[i]++;
                    continue;
                }

                list.Add(Index[i]);

                Console.WriteLine("*******");
                Console.WriteLine(Index[i]);

                list1.Add(j);
                if (j == 0) words.Add(str.Substring(0, list[j]));
                else words.Add(str.Substring(list[j - 1] + 1, list[j] - list[j - 1] - 1));
                if (address.ContainsKey(words[j]))
                {

                    if (address[words[j]].ContainsKey(i))
                    {
                        address[words[j]][i].Add(j);
                    }
                    else
                    {
                        address[words[j]].Add(i, new List<int> { { j } });
                    }
                }
                else address.Add(words[j], new Dictionary<int, List<int>> { { i, new List<int>() { j } } });
                Index[i]++;
                j++;
            }
        }
        private void Indexer( List<string> input)
        {
            
            
            for (int i = 0; i < input.Count; i++)
            {
                WordIndex(input[i], i);
            }

        }
    
        public indexing()
        {

        }
        
        public indexing(List<string> strs)
        {
            NewFile(strs);
        }

        public void NewFile(List<string> strings)
        {
            // تمیز سازی حروف
            strings = CleanString(strings);
           
            // تمیز سازی کلمات
            strings = CleanWords(strings);

            // ایندکس گذاری
            Indexer(strings);            
        }

        public Dictionary<int,List<int>> Search1(string word)
        {
            word = word.ToUpper();
            Console.WriteLine(word);
            Print(address[word]);
            return address[word]; 
        }
    }
}

















/*
if (address.ContainsKey("salam"))
{

    if (address["salam"].ContainsKey(1))
    {
        address["salam"][1].Add(5);
    }
    else
    {
        address["salam"].Add(1, new List<int> { { 5 } });
    }
}
else address.Add("salam", new Dictionary<int, List<int>> { { 1, new List<int>() { 5 } } });*/