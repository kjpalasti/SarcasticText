using System;
using System.Collections.Generic;

namespace SarcasticText
{
    public class ApplySarcasm
    {
        string _text;

        public ApplySarcasm(string text)
        {
            _text = text.ToLower();
        }

        public string applySarcasm()
        {
            bool capitalize = false;
            var splitText = _text.Split(" ");
            var sarcasticArray = new string[splitText.Length];
            int count = 0;

            foreach(var word in splitText)
            {
                var characterList = new List<string>();
                foreach(char letter in word)
                {
                    if (capitalize)
                        characterList.Add(char.ToUpper(letter).ToString());
                    else
                        characterList.Add(char.ToLower(letter).ToString());

                    capitalize = !capitalize;
                }
                sarcasticArray[count] = string.Join("", characterList);
                count++;
            }

            return string.Join(" ", sarcasticArray);
        }
    }
}
