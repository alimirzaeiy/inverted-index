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
using System.ComponentModel.DataAnnotations;
using inverted_index;

namespace inverted_index
{

    public class Clean
    {
        public List<string> String(List<string> input)
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
        public List<string> Words(List<string> input)
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
    }
    public class FileAndToken
    {
        public Dictionary<int, List<int>> TokenKeyValues { get; set; } = new Dictionary<int, List<int>>();

    }
    public class WordDictionary
    {
        public Dictionary<string,FileAndToken> dictionary { get; set; } = new Dictionary<string,FileAndToken>();
    }
    public static class Print
    {
        public static void it(object input)
        {
            Console.WriteLine(Serialize(input));
            Console.WriteLine("-------------------");
        }
    }
    internal class indexing
    {
        WordDictionary wordDictionary = new WordDictionary();
        private void Indexer( List<string> input)
        {

            WordIndexer findWords = new WordIndexer();
            for (int i = 0; i < input.Count; i++)
            {
                wordDictionary = findWords.WordIndexCalculator(input[i], i, wordDictionary);
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
            Clean clean = new Clean();
            // تمیز سازی حروف
            strings = clean.String(strings);
           
            // تمیز سازی کلمات
            strings = clean.Words(strings);

            // ایندکس گذاری
            Indexer(strings);            
        }

        public FileAndToken Search1(string word)
        {
            word = word.ToUpper();
            Console.WriteLine(word);
            Print.it(wordDictionary.dictionary[word]);
            return wordDictionary.dictionary[word]; 
        }
    }
    public class Index
    {
        public List<int> indexes { get; set; } = new List<int>();
    }
    public static class IsNext
    {
        public static bool Space(string input, int index)
        {
            return input[index + 1] == ' ';
        }
    }
    public class ListOfIndices
    {
        public List<int> indices { get; set; } = new List<int>();
    }
    public static class Add
    {
        public static List<string> Word(string str, int j, List<string> words, ListOfIndices listOfIndices)
        {
            if (j == 0) words.Add(str.Substring(0, listOfIndices.indices[j]));
            else words.Add(str.Substring(listOfIndices.indices[j - 1] + 1, listOfIndices.indices[j] - listOfIndices.indices[j - 1] - 1));
            return words;
        }
        public static ListOfIndices Address(string word, int i, int j, WordDictionary addressesByFileIdByToken, ListOfIndices listOfIndices)
        {

            if (addressesByFileIdByToken.dictionary.ContainsKey(word))
            {
                FileAndToken keyValuePairs = addressesByFileIdByToken.dictionary[word];
                if (keyValuePairs.TokenKeyValues.ContainsKey(i))
                {
                    keyValuePairs.TokenKeyValues[i].Add(j);
                }
                else
                {
                    keyValuePairs.TokenKeyValues.Add(i, new List<int> { { j } });
                }
            }
            else
            {
                FileAndToken fileAndToken = new FileAndToken();
                fileAndToken.TokenKeyValues.Add(i, new List<int> { { j } });
                addressesByFileIdByToken.dictionary.Add(word, fileAndToken);
            }
            return listOfIndices;
        }
    }
    public class Words
    {
        public List<string> list { get; set; } = new List<string>();
    }
    public class WordIndexer
    {
        Words words = new Words();
        ListOfIndices listOfIndices = new ListOfIndices();
        Index index = new Index();
        FindWord findWord = new FindWord();
        public WordDictionary WordIndexCalculator(string str, int i, WordDictionary addressesByFileIdByToken)
        {
            index.indexes.Add(0);
            index.indexes[i] = 0;
            findWord.repeat(i, index.indexes, str, listOfIndices, words, addressesByFileIdByToken);
            return addressesByFileIdByToken;
        }
    }
    public class FindWord
    {
        public void repeat(int i, List<int> Index, string str, ListOfIndices listOfIndices, Words words, WordDictionary addressesByFileIdByToken)
        {
            for (int j = 0; Index[i] < str.LastIndexOf(" ");)
            {
                Index[i] = str.IndexOf(" ", Index[i]);
                if (IsNext.Space(str, Index[i]))
                {
                    Index[i]++;
                    continue;
                }
                listOfIndices.indices.Add(Index[i]);
                words.list = Add.Word(str, j, words.list, listOfIndices);
                listOfIndices = Add.Address(words.list[j], i, j, addressesByFileIdByToken, listOfIndices);
                Index[i]++;
                j++;
            }
        }
    }
}

