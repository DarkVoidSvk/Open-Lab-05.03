﻿using System;

namespace Open_Lab_05._03
{
    public class Numbers
    {
        public string FormatNum(int num)
        {
            string string_number = num.ToString();
            if (string_number.Length > 3 && string_number.Length < 7)
            {
                return string_number.Insert(string_number.Length - 3, ",");
            }
            else if (string_number.Length < 4)
            {
                return string_number;
            }
            else
            {

                for (int i = string_number.Length - 1; i >= 3; i -= 1)
                {
                    if (i % 3 == 0)
                    {
                        string_number = string_number.Insert(string_number.Length - i, " ");
                    }
                }
                return string_number;
            }
        }
    }
}
