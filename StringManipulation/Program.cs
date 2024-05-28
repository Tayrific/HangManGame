namespace StringManipulation
{
    internal class Program
    {
        public class positionOfChar
        {
            public string? word { get; set; }
            public string? c { get; set; }
            public int pos { get; set; }
        }

        static void Main(string[] args)
        {
            string contents = "";
            List<positionOfChar> list = new List<positionOfChar>();

            try
            {
                string path = @"Files/Words.txt";
                string filename = Path.GetFileName(path);

                using (var sr = new StreamReader(path))
                {
                    contents = sr.ReadToEnd();
                }
                Console.WriteLine("File contents read successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            var array = contents.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Words array:");
            foreach (var w in array)
            {
                Console.WriteLine(w);
            }

            string letterToFind = "o";

            foreach (var word in array)
            {
                string letter = letterToFind.ToLower();
                string wordLower = word.ToLower();
                Console.WriteLine("Word: " + wordLower);

                int index = 0;

                if (wordLower.Contains(letter))
                {
                    while ((index = wordLower.IndexOf(letter, index)) != -1)
                    {
                        Console.WriteLine("letter {1} found at index {2}", wordLower, letter, index);
                        list.Add(new positionOfChar { word = wordLower, c = letter, pos = index });
                        index++; // Move to the next character position
                    }
                }
                else
                {
                    Console.WriteLine("letter {1} not found in {0}", wordLower, letter);
                }

                Console.WriteLine(" ");
            }
        }
    }
}