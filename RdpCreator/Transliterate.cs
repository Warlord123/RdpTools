    using System;
    using System.Collections.Generic;
    using System.Text;

namespace RdpCreator
    {
        public enum TransliterationType
        {
            Gost,
            ISO,
            Mechel
        }
        public static class Transliteration
        {
            private static Dictionary<string, string> gost = new Dictionary<string, string>(); //ГОСТ 16876-71
            private static Dictionary<string, string> iso = new Dictionary<string, string>(); //ISO 9-95
            private static Dictionary<string, string> mechel = new Dictionary<string, string>(); //ISO 9-95
            public static string Front(string text)
            {
                return Front(text, TransliterationType.Mechel);
            }
            public static string Front(string text, TransliterationType type)
            {
                Dictionary<string, string> tdict = GetDictionaryByType(type);
                string output = "";
                StringBuilder sb = new StringBuilder(text);
                for (int i = 0; i < sb.Length; i++)
                {
                    if (tdict.ContainsKey(sb[i].ToString()))
                        output += tdict[sb[i].ToString()];
                    else output += sb[i].ToString();
                }

                return output;
            }

            public static string Back(string text)
            {
                return Back(text, TransliterationType.ISO);
            }
            public static string Back(string text, TransliterationType type)
            {
                string output = text;
                Dictionary<string, string> tdict = GetDictionaryByType(type);

                foreach (KeyValuePair<string, string> key in tdict)
                {
                    output = output.Replace(key.Value, key.Key);
                }
                return output;
            }

            private static Dictionary<string, string> GetDictionaryByType(TransliterationType type)
            {
                Dictionary<string, string> tdict = iso;
                if (type == TransliterationType.Gost) tdict = gost;
                if (type==TransliterationType.Mechel) tdict = mechel;
                return tdict;
            }

            static Transliteration()
            {
                gost.Add("Є", "EH");
                gost.Add("І", "I");
                gost.Add("і", "i");
                gost.Add("№", "#");
                gost.Add("є", "eh");
                gost.Add("А", "A");
                gost.Add("Б", "B");
                gost.Add("В", "V");
                gost.Add("Г", "G");
                gost.Add("Д", "D");
                gost.Add("Е", "E");
                gost.Add("Ё", "JO");
                gost.Add("Ж", "ZH");
                gost.Add("З", "Z");
                gost.Add("И", "I");
                gost.Add("Й", "JJ");
                gost.Add("К", "K");
                gost.Add("Л", "L");
                gost.Add("М", "M");
                gost.Add("Н", "N");
                gost.Add("О", "O");
                gost.Add("П", "P");
                gost.Add("Р", "R");
                gost.Add("С", "S");
                gost.Add("Т", "T");
                gost.Add("У", "U");
                gost.Add("Ф", "F");
                gost.Add("Х", "KH");
                gost.Add("Ц", "C");
                gost.Add("Ч", "CH");
                gost.Add("Ш", "SH");
                gost.Add("Щ", "SHH");
                gost.Add("Ъ", "'");
                gost.Add("Ы", "Y");
                gost.Add("Ь", "");
                gost.Add("Э", "EH");
                gost.Add("Ю", "YU");
                gost.Add("Я", "YA");
                gost.Add("а", "a");
                gost.Add("б", "b");
                gost.Add("в", "v");
                gost.Add("г", "g");
                gost.Add("д", "d");
                gost.Add("е", "e");
                gost.Add("ё", "jo");
                gost.Add("ж", "zh");
                gost.Add("з", "z");
                gost.Add("и", "i");
                gost.Add("й", "jj");
                gost.Add("к", "k");
                gost.Add("л", "l");
                gost.Add("м", "m");
                gost.Add("н", "n");
                gost.Add("о", "o");
                gost.Add("п", "p");
                gost.Add("р", "r");
                gost.Add("с", "s");
                gost.Add("т", "t");
                gost.Add("у", "u");

                gost.Add("ф", "f");
                gost.Add("х", "kh");
                gost.Add("ц", "c");
                gost.Add("ч", "ch");
                gost.Add("ш", "sh");
                gost.Add("щ", "shh");
                gost.Add("ъ", "");
                gost.Add("ы", "y");
                gost.Add("ь", "");
                gost.Add("э", "eh");
                gost.Add("ю", "yu");
                gost.Add("я", "ya");
                gost.Add("«", "");
                gost.Add("»", "");
                gost.Add("—", "-");

                iso.Add("Є", "YE");
                iso.Add("І", "I");
                iso.Add("Ѓ", "G");
                iso.Add("і", "i");
                iso.Add("№", "#");
                iso.Add("є", "ye");
                iso.Add("ѓ", "g");
                iso.Add("А", "A");
                iso.Add("Б", "B");
                iso.Add("В", "V");
                iso.Add("Г", "G");
                iso.Add("Д", "D");
                iso.Add("Е", "E");
                iso.Add("Ё", "YO");
                iso.Add("Ж", "ZH");
                iso.Add("З", "Z");
                iso.Add("И", "I");
                iso.Add("Й", "J");
                iso.Add("К", "K");
                iso.Add("Л", "L");
                iso.Add("М", "M");
                iso.Add("Н", "N");
                iso.Add("О", "O");
                iso.Add("П", "P");
                iso.Add("Р", "R");
                iso.Add("С", "S");
                iso.Add("Т", "T");
                iso.Add("У", "U");
                iso.Add("Ф", "F");
                iso.Add("Х", "X");
                iso.Add("Ц", "C");
                iso.Add("Ч", "CH");
                iso.Add("Ш", "SH");
                iso.Add("Щ", "SHH");
                iso.Add("Ъ", "'");
                iso.Add("Ы", "Y");
                iso.Add("Ь", "");
                iso.Add("Э", "E");
                iso.Add("Ю", "YU");
                iso.Add("Я", "YA");
                iso.Add("а", "a");
                iso.Add("б", "b");
                iso.Add("в", "v");
                iso.Add("г", "g");
                iso.Add("д", "d");
                iso.Add("е", "e");
                iso.Add("ё", "yo");
                iso.Add("ж", "zh");
                iso.Add("з", "z");
                iso.Add("и", "i");
                iso.Add("й", "j");
                iso.Add("к", "k");
                iso.Add("л", "l");
                iso.Add("м", "m");
                iso.Add("н", "n");
                iso.Add("о", "o");
                iso.Add("п", "p");
                iso.Add("р", "r");
                iso.Add("с", "s");
                iso.Add("т", "t");
                iso.Add("у", "u");
                iso.Add("ф", "f");
                iso.Add("х", "x");
                iso.Add("ц", "c");
                iso.Add("ч", "ch");
                iso.Add("ш", "sh");
                iso.Add("щ", "shh");
                iso.Add("ъ", "");
                iso.Add("ы", "y");
                iso.Add("ь", "");
                iso.Add("э", "e");
                iso.Add("ю", "yu");
                iso.Add("я", "ya");
                iso.Add("«", "");
                iso.Add("»", "");
                iso.Add("—", "-");

                mechel.Add("А", "A");
                mechel.Add("Б", "B");
                mechel.Add("В", "V");
                mechel.Add("Г", "G");
                mechel.Add("Д", "D");
                mechel.Add("Е", "E");
                mechel.Add("Ё", "YO");
                mechel.Add("Ж", "ZH");
                mechel.Add("З", "Z");
                mechel.Add("И", "I");
                mechel.Add("Й", "Y");
                mechel.Add("К", "K");
                mechel.Add("Л", "L");
                mechel.Add("М", "M");
                mechel.Add("Н", "N");
                mechel.Add("О", "O");
                mechel.Add("П", "P");
                mechel.Add("Р", "R");
                mechel.Add("С", "S");
                mechel.Add("Т", "T");
                mechel.Add("У", "U");
                mechel.Add("Ф", "F");
                mechel.Add("Х", "KH");
                mechel.Add("Ц", "C");
                mechel.Add("Ч", "CH");
                mechel.Add("Ш", "SH");
                mechel.Add("Щ", "SCH");
                mechel.Add("Ъ", "");
                mechel.Add("Ы", "Y");
                mechel.Add("Ь", "");
                mechel.Add("Э", "E");
                mechel.Add("Ю", "YU");
                mechel.Add("Я", "YA");
                mechel.Add("а", "a");
                mechel.Add("б", "b");
                mechel.Add("в", "v");
                mechel.Add("г", "g");
                mechel.Add("д", "d");
                mechel.Add("е", "e");
                mechel.Add("ё", "yo");
                mechel.Add("ж", "zh");
                mechel.Add("з", "z");
                mechel.Add("и", "i");
                mechel.Add("й", "y");
                mechel.Add("к", "k");
                mechel.Add("л", "l");
                mechel.Add("м", "m");
                mechel.Add("н", "n");
                mechel.Add("о", "o");
                mechel.Add("п", "p");
                mechel.Add("р", "r");
                mechel.Add("с", "s");
                mechel.Add("т", "t");
                mechel.Add("у", "u");
                mechel.Add("ф", "f");
                mechel.Add("х", "kh");
                mechel.Add("ц", "c");
                mechel.Add("ч", "ch");
                mechel.Add("ш", "sh");
                mechel.Add("щ", "sch");
                mechel.Add("ъ", "");
                mechel.Add("ы", "y");
                mechel.Add("ь", "");
                mechel.Add("э", "e");
                mechel.Add("ю", "yu");
                mechel.Add("я", "ya");

            }
        }
    }

