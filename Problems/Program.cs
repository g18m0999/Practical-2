using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            var ans = Console.ReadLine();
            Console.WriteLine(Prefix(ans));
            Console.ReadKey();

        }
        public static string Prefix(string Str)
        {
            var count = Str.Length;
            char[] spaces = new char[] {' ', '\r', '\n' };
            var wordCount = Str.Split(spaces,StringSplitOptions.RemoveEmptyEntries).Length; 
            
            return count + "," + wordCount + ":" + Str;
            

        }
    }
}
