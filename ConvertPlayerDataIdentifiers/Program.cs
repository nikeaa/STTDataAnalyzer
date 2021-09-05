using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System;

namespace ConvertPlayerDataIdentifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the class generated from the JSON file.
            string directory = "C:\\Users\\nikea\\source\\repos\\STTDataAnalyzer\\Models";
            string fileName = directory.ToString() + "\\PlayerData.cs";
            string playerData = File.ReadAllText(fileName);

            // Remove underscores and capitalize first letter of each word.
            var regex = new Regex(@"_[a-z]", RegexOptions.IgnoreCase);
            playerData = regex.Replace(playerData, m => m.ToString().Replace("_", "").ToUpper());

            // Capitalize the first letter of identifiers
            var regex2 = new Regex(@"\b\w* \{", RegexOptions.IgnoreCase);
            playerData = regex2.Replace(playerData, m => new String(m.ToString().Select((ch, index) => (index != 0) ? ch : Char.ToUpper(ch)).ToArray()));

            // Write back to original file.
            File.WriteAllText(fileName, playerData);

            // Display the first 100 updated lines.
            string[] x = playerData.Split('\r');
            for (int i=0; i < 100; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadLine();
        }
    }
}
