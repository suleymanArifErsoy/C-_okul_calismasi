using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        uint A1 = 0x12345678;
        uint A2 = 0xABCDEF12;
        ulong altmısDortBitlikSayi = ((ulong)A1 << 32) | A2;
        ulong maske = 0x8000000000000000;

        int enUzun = 0;
        int temp = 0;

        while (maske > 0)
        {
            if ((altmısDortBitlikSayi & maske) != 0)
            {
                temp++;
            }
            else
            {
                if (temp > enUzun)
                {
                    enUzun = temp;
                }
                temp = 0;
            }

            maske >>= 1;
        }

        Console.WriteLine(enUzun);
    }
}