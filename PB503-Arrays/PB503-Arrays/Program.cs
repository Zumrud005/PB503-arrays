using System.Diagnostics;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace PB503_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Max number
            //Verilmiş ededler siyahisindaki(int[]) en böyük ededi tapan alqoritm

            //int[] numbers = { 1, 2, 120, 78, 23, 96, 87, 65,547 };
            //int maxNumber = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine($"bu array'daki en boyuk eded: {maxNumber}");





            #endregion


            #region AVG
            //Verilmiş Products arrayindəki Product objectlərinin Id'ləri tək olanlarının
            //Price'larının ədədi ortasını tapan algorithm yazın.
            //(Product objectinin propertyləri: Id(yeni reqem ve ya eded), Name, Price, StockCount)


            var Products1 = new { Id = 1, Name = "notebook", Price = 3, StockCount = 9  };
            var Products2 = new { Id = 2, Name = "book", Price = 12, StockCount = 3 };
            var Products3 = new { Id = 3, Name = "pen", Price = 2, StockCount = 19 };
            var Products4 = new { Id = 4, Name = "ruler", Price = 5, StockCount = 11 };
            var Products5 = new { Id = 5, Name = "marker", Price = 7, StockCount = 4 };
            var Products6 = new { Id = 6, Name = "paper", Price = 30, StockCount = 10 };
            var Products7 = new { Id = 7, Name = "eraser", Price = 1, StockCount = 40 };
            var Products8 = new { Id = 8, Name = "glue", Price = 21, StockCount = 55 };
            var Products = new[] {Products1 ,Products2, Products3, Products4, Products5, Products6, Products7, Products8};
            double sum = 0;
            int count = 0;
            double avg = 0;
            foreach (var prd in Products)
            {
                if (prd.Id % 2== 1)
                {
                    sum=sum+prd.Price;
                    count++;
                }
            }
            avg = sum/count;
            Console.WriteLine($"middle value of singles Id = {avg}");
            


            #endregion
        }
    }
}
