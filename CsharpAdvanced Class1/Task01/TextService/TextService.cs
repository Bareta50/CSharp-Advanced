
using System.Collections.Generic;
using Task01.Models;

namespace Task01.TextService
{
    public class TextService
    {
        public List<NameCountResult> CountAppearancesInText(string text, List<string> names)
        {
            string[] wordsInText = text.Split(new char[] {' ','.',',','!'});
            List<NameCountResult> namesCountResult = new List<NameCountResult>();

            foreach (string name in names)
            {
                int nameCounter = 0;
                foreach (string word in wordsInText)
                {
                    if (word.ToLower() == name.ToLower())
                    {
                        nameCounter++;
                    }
                }
                NameCountResult result = new NameCountResult(name, nameCounter);
                namesCountResult.Add(result);
            }

            return namesCountResult;
        }
    }
}
