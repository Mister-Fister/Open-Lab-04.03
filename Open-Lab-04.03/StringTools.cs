using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if(original.Length < 2)
            {
                return original;
            }

            char[] a = new char[original.Length - 1];
            for(int i = 0; i < original.Length - 1; i++)
            {
                a[i] = original[i];
            }
            Array.Reverse(a);
            char[] b = new char[a.Length - 1];
            for (int i = 0; i < a.Length - 1; i++)
            {
                b[i] = a[i];
            }
            Array.Reverse(b);
            string vysl = String.Join("", b);
            return vysl;
        } 
        

    }
}
