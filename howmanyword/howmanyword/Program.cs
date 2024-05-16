namespace howmanyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string smpWord = "Code Academy";
           
            char[] characters = new char[smpWord.Length];

            for (int i = 0; i < smpWord.Length; i++)
            {
                characters[i] = smpWord[i];
            }

            int[] charactersCounts = new int[52];

            foreach (char c in characters)
            {
                if (c != ' ')
                {
                    int index = char.ToUpper(c) - 'A';
                    charactersCounts[index]++;
                }
            }
            for (int i = 0; i < charactersCounts.Length; i++)
            {
                char currentChar = (char)('A' + i);
                int count = charactersCounts[i];

                if (count > 0)
                {
                    Console.WriteLine($"{currentChar} : {count}");
                }
            }
        
        }
    }
}
