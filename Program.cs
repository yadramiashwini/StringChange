namespace StringChange
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter string:");
            string str = Console.ReadLine().ToLower();
            string output = " ";

            for (int i = 0; i < str.Length; i++)
            {
                if(i % 2 == 0)
                {
                    output += char.ToUpper(str[i]);
                }
                else
                {
                    output += char.ToLower(str[i]);
                }
            }
            Console.WriteLine(output);

        }
    }
}
