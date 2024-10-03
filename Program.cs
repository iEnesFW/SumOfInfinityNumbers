using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string val1 = "6125362154612546125361253612546125615263";
            string val2 = "3454423544235664266523324123234112644";
            var stringList = new List<string>();
            var stringList2 = new List<string>();
            for (int i = 0; i < val1.Length; i++)
            {
                stringList.Add(val1.Substring(i, 1));
            }

            for (int i = 0; i < val2.Length; i++)
            {
                stringList2.Add(val2.Substring(i, 1));
            }
            if (stringList.Count > 0 && stringList2.Count > 0)
            {
                string toplam = "";
                int elde = 0;
                if (stringList.Count() > stringList2.Count())
                {
                    int count = stringList2.Count();
                    for (int i = stringList.Count(); i > 0; i--)
                    {
                        string deger = ((Convert.ToInt16(stringList[i - 1]) + (count > 0 ? Convert.ToInt16(stringList2[count - 1]) : 0)) + elde).ToString();
                        toplam = deger.Substring(deger.Length-1,1) + toplam;
                        elde = 0;
                        if ((Convert.ToInt16(stringList[i - 1]) + (count > 0 ? Convert.ToInt16(stringList2[count - 1]) : 0)) > 9)
                        {
                            elde++;
                            if(i == 1)
                            {
                                toplam = elde + toplam;
                            }
                        }
                        count--;
                    }
                }
                else
                {
                    int count = stringList.Count();
                    for (int i = stringList2.Count(); i > 0; i--)
                    {
                        string deger = ((Convert.ToInt16(stringList2[i - 1]) + (count > 0 ? Convert.ToInt16(stringList[count - 1]) : 0)) + elde).ToString();
                        toplam = deger.Substring(deger.Length - 1, 1) + toplam;
                        elde = 0;
                        if ((Convert.ToInt16(stringList2[i - 1]) + (count > 0 ? Convert.ToInt16(stringList[count - 1]) : 0)) > 9)
                        {
                            elde++;
                            if (i == 1)
                            {
                                toplam = elde + toplam;
                            }
                        }
                        count--;
                    }
                }
                Console.WriteLine(toplam);
            }
        }
    }
}