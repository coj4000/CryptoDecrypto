using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDecrypto
{
    class Program
    {
        /// <summary>
        /// 1 -> A<br/>
        /// 2 -> B<br/>
        /// 3 -> C<br/>
        /// ...
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public static string ExcelColumnFromNumber(int column)
        {
            string columnString = "";
            decimal columnNumber = column;
            while (columnNumber > 0)
            {
                decimal currentLetterNumber = (columnNumber - 1) % 26;
                char currentLetter = (char)(currentLetterNumber + 65);
                columnString = currentLetter + columnString;
                columnNumber = (columnNumber - (currentLetterNumber + 1)) / 26;
            }
            return columnString;
        }

        /// <summary>
        /// A -> 1<br/>
        /// B -> 2<br/>
        /// C -> 3<br/>
        /// ...
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public static int NumberFromExcelColumn(string column)
        {
            int retVal = 0;
            string col = column.ToUpper();
            for (int iChar = col.Length - 1; iChar >= 0; iChar--)
            {
                char colPiece = col[iChar];
                int colNum = colPiece - 64;
                retVal = retVal + colNum * (int)Math.Pow(26, col.Length - (iChar + 1));
            }
            return retVal;
        }
        static void Main(string[] args)
        {
            var plaintext = Console.ReadLine();
            char mellemrum = ' ';
            String[] strings = plaintext.Split(mellemrum);
            string cypherText = "";
            foreach (var s in strings)
            {
                cypherText += NumberFromExcelColumn(s);
                    cypherText += "#";
                
                    
                
                
            }
            Console.WriteLine(cypherText);
            Console.ReadKey();
            //var lines = cypherText.Split('#').Select(int.Parse).ToList();
            //string decryptedText = "";
            //foreach (int li in lines)
            //{
                
                
            //    decryptedText += ExcelColumnFromNumber(li) + " ";
            //}
           // Console.WriteLine(decryptedText);
            //var Cyphertext = NumberFromExcelColumn(plaintext);

            //Console.WriteLine("Din encryptede data er: " + Cyphertext);


            //Console.WriteLine("Indtast den encryptede data");
            //var encryptText = Console.ReadLine();
            //int encryptnr = Int32.Parse(encryptText);
            //string DecryptText = ExcelColumnFromNumber(encryptnr);
            //Console.WriteLine("Den decryptede data er: " + DecryptText);
            //Console.ReadKey();
        }
    }
}
