using System;
using System.Collections.Generic;

namespace CodeWars
{
    public class Rot13Converter
    {
        public static string Rot13(string message)
        {
            
            string result ="";
            //initalize rot13 cryptlist
            Dictionary<char,char> rot13Dic = GetRot13Dic();

            //convert string
            for (int i = 0; i < message.Length; i++)
            {
                if(rot13Dic.ContainsKey(message[i]))
                {
                    result+=rot13Dic[message[i]];
                }
                else
                {
                    result+=message[i];
                }
                
            }

            return result;
        }

        private static Dictionary<char,char> GetRot13Dic()
        {
            Dictionary<char, char> rot13Dic = new Dictionary<char,char>();
            for (int i = 0; i < 26; i++)
            {
                if (i < 13)
                {
                    rot13Dic.Add(Convert.ToChar(65+i),Convert.ToChar(65+i+13));
                    rot13Dic.Add(Convert.ToChar(97+i),Convert.ToChar(97+i+13));
                }
                else
                {
                    rot13Dic.Add(Convert.ToChar(65+i),Convert.ToChar(65+i-13));
                    rot13Dic.Add(Convert.ToChar(97+i),Convert.ToChar(97+i-13));
                }
            }
            return rot13Dic;
        }
    }
}