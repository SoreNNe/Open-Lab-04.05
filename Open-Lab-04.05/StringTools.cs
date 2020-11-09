using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string ja = "";
            for (int i = 0; i < orig.Length; i++)
            {
                for (int u = 0; u < n; u++)
                {
                    ja = ja + orig[i];
                }
            }
            return ja;
        }
    }
}
