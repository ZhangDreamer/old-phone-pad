using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePad
{
    public class HanldeOldPhone
    {
        public static String HandleOldPhonePad(string input)
        {
            Dictionary<char, string> keypad = new Dictionary<char, string>()
            {
                {'1', "&'("},   
                {'2', "ABC"},
                {'3', "DEF"},
                {'4', "GHI"},
                {'5', "JKL"},
                {'6', "MNO"},
                {'7', "PQRS"},
                {'8', "TUV"},
                {'9', "WXYZ"},
                {'0', " "},
            };       


            StringBuilder sb = new StringBuilder();          

            int index = 0; //pointer to iterate through the input
            while (index < input.Length)
            {
                char currentKey = input[index];

                if (currentKey == '#')
                    {
                        break; //ends the loop when it reaches the # char
                    }
                else if (currentKey == '*')
                    {
                        //handle backspace
                        if (sb.Length > 0)
                        {
                            sb.Length--;
                        }
                        index++;
                        continue;
                    }
                else if (currentKey == ' ') 
                    {
                        //handle pauses
                        index++;
                        continue;
                    }
                else 
                    {
                        int count = 0; //initialize counter for consecutive of the same input

                        //while the next input is not out of bounds and is equal to the current input, then add to counter and move the pointer                 
                        while (index + 1 < input.Length && input[index] == input[index + 1])
                        {
                            count++;
                            index++;
                        }                       
                        string letters = keypad[currentKey];
                        char selectedChar = letters[count];
                        sb.Append(selectedChar);
                    }
                index++;
            }

            return sb.ToString();

        }
    }
}