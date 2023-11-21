using System;

namespace LC_RomanToInterger
{
    internal class Program
    {
        public static string CheckNumber(int index, string s)
        {
            index++;
            if (index >= s.Length)
            {
                return string.Empty;
            }
            return s[index].ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("s = ");
            string s = Console.ReadLine();
            char[] chars = s.ToCharArray();
            int number = 0;
            bool loop = false;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'V')
                {
                    if (loop)
                    {
                        loop = false;
                        continue;
                    }
                    else
                    {
                        number += 5;
                    }

                }

                if (chars[i] == 'L')
                    if (loop)
                    {
                        loop = false;
                        continue;
                    }
                    else
                    {
                        number += 50;
                    }

                if (chars[i] == 'D')
                {
                    if (loop)
                    {
                        loop = false;
                        continue;
                    }
                    else
                    {
                        number += 500;
                    }

                }

                if (chars[i] == 'M')
                    if (loop)
                    {
                        loop = false;
                        continue;
                    }
                    else
                    {
                        number += 1000;
                    }


                if (chars[i] == 'I')
                {
                    string check = CheckNumber(i, s);
                    if (check == "")
                    {
                        number += 1;
                        loop = false;
                    }
                    else
                    {
                        if (char.Parse(check) == 'V')
                        {
                            number += 4;
                            loop = true;
                        }
                        else if (char.Parse(check) == 'X')
                        {
                            number += 9;
                            loop = true;
                        }
                        else
                        {
                            number += 1;
                            loop = false;
                        }
                    }
                }

                if (chars[i] == 'X')
                {
                    if (loop == true)
                        continue;
                    else
                    {
                        string check = CheckNumber(i, s);
                        if (check == "")
                        {
                            number += 10;
                            loop = false;
                        }
                        else
                        {
                            if (char.Parse(check) == 'L')
                            {
                                number += 40;
                                loop = true;
                            }
                            else if (char.Parse(check) == 'C')
                            {
                                number += 90;
                                loop = true;
                            }
                            else
                            {
                                number += 10;
                                loop = false;
                            }
                        }
                    }
                }

                if (chars[i] == 'C')
                {
                    if (loop == true)
                    {
                        loop = false;
                        continue;
                    }
                    else
                    {
                        string check = CheckNumber(i, s);
                        if (check == "")
                        {
                            number += 100;
                            loop = false;
                        }
                        else
                        {
                            if (char.Parse(check) == 'D')
                            {
                                number += 400;
                                loop = true;
                            }
                            else if (char.Parse(check) == 'M')
                            {
                                number += 900;
                                loop = true;
                            }
                            else
                            {
                                number += 100;
                                loop = false;
                            }
                        }
                    }
                }
            }
            Console.Write(number);
            Console.ReadKey();
        }
    }
}
