﻿//Lab Exercise 5.14.2025 Problem 4
//Author: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add code here


        }

        static bool isPrime(int n)
        {
            for (int i = 2; i < Math.Sqrt(n) + 1; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}

//Sample Output
//Enter a positive integer: 1234
//1234 = 3 + 1231
//1234 = 5 + 1229
//1234 = 11 + 1223
//1234 = 17 + 1217
//1234 = 41 + 1193
//1234 = 47 + 1187
//1234 = 53 + 1181
//1234 = 71 + 1163
//1234 = 83 + 1151
//1234 = 131 + 1103
//1234 = 137 + 1097
//1234 = 173 + 1061
//1234 = 251 + 983
//1234 = 257 + 977
//1234 = 263 + 971
//1234 = 281 + 953
//1234 = 293 + 941
//1234 = 347 + 887
//1234 = 353 + 881
//1234 = 461 + 773
//1234 = 491 + 743
//1234 = 557 + 677
//1234 = 587 + 647
//1234 = 593 + 641
//1234 = 617 + 617
//1234 = 641 + 593
//1234 = 647 + 587
//1234 = 677 + 557
//1234 = 743 + 491
//1234 = 773 + 461
//1234 = 881 + 353
//1234 = 887 + 347
//1234 = 941 + 293
//1234 = 953 + 281
//1234 = 971 + 263
//1234 = 977 + 257
//1234 = 983 + 251
//1234 = 1061 + 173
//1234 = 1097 + 137
//1234 = 1103 + 131
//1234 = 1151 + 83
//1234 = 1163 + 71
//1234 = 1181 + 53
//1234 = 1187 + 47
//1234 = 1193 + 41
//1234 = 1217 + 17
//1234 = 1223 + 11
//1234 = 1229 + 5
//1234 = 1231 + 3