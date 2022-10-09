using inverted_index;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
 
        List<string> list = new List<string>();
        list.Add(File.ReadAllText("F:/misc/mohaymen/CodeStar/EnglishData/57110"));
        list.Add(File.ReadAllText("F:/misc/mohaymen/CodeStar/EnglishData/58043"));
        //list.Add(File.ReadAllText("F:/misc/mohaymen/CodeStar/EnglishData/58044"));
        //list.Add(File.ReadAllText("F:/misc/mohaymen/CodeStar/EnglishData/58045"));




        indexing Indexing = new indexing(list);
        Dictionary<int, List<int>> addr = new Dictionary<int, List<int>>();
        Indexing.Search1("stories");
















        //string str1;
        //string str2;
        //str1 = "My Name is Ali Mirzaei and I am going to learn CodeStar";
        //str2 = "Mohammad is going to learn CSharp";
        //str1 = str1.Trim();
        //str2 = str2.Trim ();
        //Dictionary<int, string> dic = new Dictionary<int, string>();

        //str1.ToUpper();
        //str2.ToUpper();

        //int index = 0;
        //List<int> indexList = new List<int>();

        //for (; index < str1.LastIndexOf(" ");)
        //{
        //    Console.WriteLine(index);
        //    index = str1.IndexOf(" ",index);
        //    indexList.Add(index);
        //    index++;
        //}
        //List<string> wordIndex = new List<string>();
        ////foreach (var item in indexList)
        ////{
        ////    wordIndex.Add(str1.Substring(item,item-(item-1)));
        ////}
        //Console.WriteLine("------------------------------------");
        //Console.WriteLine("indexlist count is:{0}", indexList.Count);
        //Console.WriteLine("------------------------------------");







        //for (int i = -1; i < indexList.Count; i++)
        //{

        //    //Console.WriteLine(indexList[i+1] + " " + i);
        //    if (i==indexList.Count-1)  wordIndex.Add(str1.Substring(indexList[i]+1, str1.Length - indexList[i]-1));
        //    else if (i== -1) wordIndex.Add(str1.Substring(0, indexList[0]));
        //    else wordIndex.Add(str1.Substring(indexList[i]+1, indexList[i+1] - indexList[i]));

        //}
        //foreach (var item in wordIndex)
        //{
        //    item.Trim();
        //}


        //Console.WriteLine("=====================words==========================");
        //foreach (var item in wordIndex)
        //{
        //    Console.WriteLine(item);
        //}
        //for (int i = 0; i < wordIndex.Count; i++)
        //{
        //    dic.Add(i, wordIndex[i]);
        //}
        //for (int i = 0; i < dic.Count; i++)
        //{
        //    Console.WriteLine("number is: "+ i +" and word is " + dic[i].ToString());
        //}



    }
}