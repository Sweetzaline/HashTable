using System;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Welcome to Hash-Table");
            MapNode<String, int> myHashMap = new MapNode<String, int>(5);
            String sentence = "to be or not to be";
            String[] words = sentence.ToLower().Split(" ");
            
            foreach (String word in words)
            {
                Console.WriteLine(word + " --> Added to HashTable");
                int value = myHashMap.Get(word);
                if (value == 0)
                    value = 1;
                else
                    value = value + 1;
                myHashMap.Add(word, value);
            }

            int frequency = myHashMap.Get("be");
            Console.WriteLine("Frequency of word -> be -> " + frequency +" times. \n \n");
          
            sentence = "Paranoids are not paranoid because they are paranoid but because they " + "keep putting themselves deliberately into paranoid avoidable situations";
            words = sentence.ToLower().Split(" ");
            
            foreach (String word in words)
            {
                Console.WriteLine(word + " --> Added to HashTable");
                int value = myHashMap.Get(word);
                if (value == 0)
                    value = 1;
                else
                    value = value + 1;
                myHashMap.Add(word, value);
            }

            frequency = myHashMap.Get("paranoid");
            Console.WriteLine("Frequency of word -->paranoid --> " + frequency + " times. \n \n");
            myHashMap.Remove("avoidable");
            Console.ReadLine();
        }
    }
}