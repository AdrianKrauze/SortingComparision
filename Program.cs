using System.Diagnostics;

namespace SortProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("time table for performing sorting, please wait bubble sort is ongoing over 20sec");
            Console.WriteLine("elements\t|ShellSort21\t|ShellsSort32\t\t|ShellsSort43\t|BubbleSort\t|QuickSort\t|InsertionSort ");
            Sorter Sorter = new Sorter();

            int[] arrayForShellSort2110k, arrayForShellSort3210k, arrayForShellSort4310k, arrayForBubbleSort10k, arrayForQuickSort10k, arrayForInsertionSort10k;
            int[] initialArrayFor10k = Sorter.FillArray(10000);
            int[] initialArrayFor20k = Sorter.FillArray(20000);
            int[] initialArrayFor30k = Sorter.FillArray(30000);
            int[] initialArrayFor40k = Sorter.FillArray(40000);
            int[] initialArrayFor50k = Sorter.FillArray(50000);

            arrayForShellSort2110k = (int[])initialArrayFor10k.Clone();
            arrayForShellSort3210k = (int[])initialArrayFor10k.Clone();
            arrayForShellSort4310k = (int[])initialArrayFor10k.Clone();
            arrayForBubbleSort10k = (int[])initialArrayFor10k.Clone();
            arrayForQuickSort10k = (int[])initialArrayFor10k.Clone();
            arrayForInsertionSort10k = (int[])initialArrayFor10k.Clone();


            //10.000 elements
            Stopwatch SS2110 = Stopwatch.StartNew();
            Sorter.ShellSort21(arrayForShellSort2110k);
            SS2110.Stop();

            List<int> SS3210Gaps = Sorter.generateStasiewiczGaps(10000);
            Stopwatch SS3210 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort3210k, SS3210Gaps);
            SS3210.Stop();

            Stopwatch SS4310 = Stopwatch.StartNew();
            List<int> SS4310Gaps = Sorter.generateSegewickGaps(10000);
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort4310k, SS4310Gaps);
            SS4310.Stop();

            Stopwatch BBS10 = Stopwatch.StartNew();
            BBS10.Start();
            Sorter.BubbleSort(arrayForBubbleSort10k);
            BBS10.Stop();

            Stopwatch QS10 = Stopwatch.StartNew();

            Sorter.QuickSort(arrayForQuickSort10k, 0, arrayForQuickSort10k.Length - 1);
            QS10.Stop();

            Stopwatch IS10 = Stopwatch.StartNew();

            Sorter.InsertionSort(arrayForInsertionSort10k);
            IS10.Stop();



            int[] arrayForShellSort2120k, arrayForShellSort3220k, arrayForShellSort420k, arrayForBubbleSort20k, arrayForQuickSort20k, arrayForInsertionSort20k;

            arrayForShellSort2120k = (int[])initialArrayFor20k.Clone();
            arrayForShellSort3220k = (int[])initialArrayFor20k.Clone();
            arrayForShellSort420k = (int[])initialArrayFor20k.Clone();
            arrayForBubbleSort20k = (int[])initialArrayFor20k.Clone();
            arrayForQuickSort20k = (int[])initialArrayFor20k.Clone();
            arrayForInsertionSort20k = (int[])initialArrayFor20k.Clone();

            //20k elements
            Stopwatch SS2120 = Stopwatch.StartNew();
            Sorter.ShellSort21(arrayForShellSort2120k);
            SS2120.Stop();

            List<int> SS3220Gaps = Sorter.generateStasiewiczGaps(20000);
            Stopwatch SS3220 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort3220k, SS3220Gaps);
            SS3220.Stop();

            List<int> SS4320Gaps = Sorter.generateSegewickGaps(20000);
            Stopwatch SS4320 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort420k, SS4320Gaps);
            SS4320.Stop();

            Stopwatch BBS20 = Stopwatch.StartNew();
            Sorter.BubbleSort(arrayForBubbleSort20k);
            BBS20.Stop();

            Stopwatch QS20 = Stopwatch.StartNew();
            Sorter.QuickSort(arrayForQuickSort20k, 0, arrayForQuickSort20k.Length - 1);
            QS20.Stop();

            Stopwatch IS20 = Stopwatch.StartNew();
            Sorter.InsertionSort(arrayForInsertionSort20k);
            IS20.Stop();

            int[] arrayForShellSort2130k, arrayForShellSort3230k, arrayForShellSort4330k, arrayForBubbleSort30k, arrayForQuickSort30k, arrayForInsertionFor30k;

            arrayForShellSort2130k = (int[])initialArrayFor30k.Clone();
            arrayForShellSort3230k = (int[])initialArrayFor30k.Clone();
            arrayForShellSort4330k = (int[])initialArrayFor30k.Clone();
            arrayForBubbleSort30k = (int[])initialArrayFor30k.Clone();
            arrayForQuickSort30k = (int[])initialArrayFor30k.Clone();
            arrayForInsertionFor30k = (int[])initialArrayFor30k.Clone();

            //30k elements
            Stopwatch SS2130 = Stopwatch.StartNew();
            Sorter.ShellSort21(arrayForShellSort2130k);
            SS2130.Stop();

            List<int> SS3230Gaps = Sorter.generateStasiewiczGaps(30000);
            Stopwatch SS3230 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort3230k, SS3230Gaps);
            SS3230.Stop();

            List<int> SS4330Gaps = Sorter.generateSegewickGaps(30000);
            Stopwatch SS4330 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort4330k, SS4330Gaps);
            SS4330.Stop();

            Stopwatch BBS30 = Stopwatch.StartNew();
            Sorter.BubbleSort(arrayForBubbleSort30k);
            BBS30.Stop();

            Stopwatch QS30 = Stopwatch.StartNew();
            Sorter.QuickSort(arrayForQuickSort30k, 0, arrayForQuickSort30k.Length - 1);
            QS30.Stop();

            Stopwatch IS30 = Stopwatch.StartNew();
            Sorter.InsertionSort(arrayForInsertionFor30k);
            IS30.Stop();

            // 40,000 elements
            int[] arrayForShellSort2140k, arrayForShellSort3240k, arrayForShellSort4340k, arrayForBubbleSort40k, arrayForQuickSort40k, arrayForInsertionSort40k;

            arrayForShellSort2140k = (int[])initialArrayFor40k.Clone();
            arrayForShellSort3240k = (int[])initialArrayFor40k.Clone();
            arrayForShellSort4340k = (int[])initialArrayFor40k.Clone();
            arrayForBubbleSort40k = (int[])initialArrayFor40k.Clone();
            arrayForQuickSort40k = (int[])initialArrayFor40k.Clone();
            arrayForInsertionSort40k = (int[])initialArrayFor40k.Clone();

            Stopwatch SS2140 = Stopwatch.StartNew();
            Sorter.ShellSort21(arrayForShellSort2140k);
            SS2140.Stop();

            List<int> SS3240Gaps = Sorter.generateStasiewiczGaps(40000);
            Stopwatch SS3240 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort3240k, SS3240Gaps);
            SS3240.Stop();

            List<int> SS4340Gaps = Sorter.generateSegewickGaps(40000);
            Stopwatch SS4340 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort4340k, SS4340Gaps);
            SS4340.Stop();

            Stopwatch BBS40 = Stopwatch.StartNew();
            Sorter.BubbleSort(arrayForBubbleSort40k);
            BBS40.Stop();

            Stopwatch QS40 = Stopwatch.StartNew();
            Sorter.QuickSort(arrayForQuickSort40k, 0, arrayForQuickSort40k.Length - 1);
            QS40.Stop();

            Stopwatch IS40 = Stopwatch.StartNew();
            Sorter.InsertionSort(arrayForInsertionSort40k);
            IS40.Stop();

            // 50000 elements
            int[] arrayForShellSort2150k, arrayForShellSort3250k, arrayForShellSort4350k, arrayForBubbleSort50k, arrayForQuickSort50k, arrayForInsertionSort50k;

            arrayForShellSort2150k = (int[])initialArrayFor50k.Clone();
            arrayForShellSort3250k = (int[])initialArrayFor50k.Clone();
            arrayForShellSort4350k = (int[])initialArrayFor50k.Clone();
            arrayForBubbleSort50k = (int[])initialArrayFor50k.Clone();
            arrayForQuickSort50k = (int[])initialArrayFor50k.Clone();
            arrayForInsertionSort50k = (int[])initialArrayFor50k.Clone();

            Stopwatch SS2150 = Stopwatch.StartNew();
            Sorter.ShellSort21(arrayForShellSort2150k);
            SS2150.Stop();

            List<int> SS3250Gaps = Sorter.generateStasiewiczGaps(50000);
            Stopwatch SS3250 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort3250k, SS3250Gaps);
            SS3250.Stop();

            List<int> SS4350Gaps = Sorter.generateSegewickGaps(50000);
            Stopwatch SS4350 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(arrayForShellSort4350k, SS4350Gaps);
            SS4350.Stop();

            Stopwatch BBS50 = Stopwatch.StartNew();
            Sorter.BubbleSort(arrayForBubbleSort50k);
            BBS50.Stop();

            Stopwatch QS50 = Stopwatch.StartNew();
            Sorter.QuickSort(arrayForQuickSort50k, 0, arrayForQuickSort50k.Length - 1);
            QS50.Stop();

            Stopwatch IS50 = Stopwatch.StartNew();
            Sorter.InsertionSort(arrayForInsertionSort50k);
            IS50.Stop();

            Console.WriteLine($"10000\t\t|{SS2110.ElapsedMilliseconds}ms\t\t|{SS3210.ElapsedMilliseconds}ms\t\t\t|{SS4310.ElapsedMilliseconds}ms\t\t|{BBS10.ElapsedMilliseconds}ms\t\t|{QS10.ElapsedMilliseconds}ms\t\t|{IS10.ElapsedMilliseconds}ms");
            Console.WriteLine($"20000\t\t|{SS2120.ElapsedMilliseconds}ms\t\t|{SS3220.ElapsedMilliseconds}ms\t\t\t|{SS4320.ElapsedMilliseconds}ms\t\t|{BBS20.ElapsedMilliseconds}ms\t\t|{QS20.ElapsedMilliseconds}ms\t\t|{IS20.ElapsedMilliseconds}ms");
            Console.WriteLine($"30000\t\t|{SS2130.ElapsedMilliseconds}ms\t\t|{SS3230.ElapsedMilliseconds}ms\t\t\t|{SS4330.ElapsedMilliseconds}ms\t\t|{BBS30.ElapsedMilliseconds}ms\t\t|{QS30.ElapsedMilliseconds}ms\t\t|{IS30.ElapsedMilliseconds}ms");
            Console.WriteLine($"40000\t\t|{SS2140.ElapsedMilliseconds}ms\t\t|{SS3240.ElapsedMilliseconds}ms\t\t\t|{SS4340.ElapsedMilliseconds}ms\t\t|{BBS40.ElapsedMilliseconds}ms\t\t|{QS40.ElapsedMilliseconds}ms\t\t|{IS40.ElapsedMilliseconds}ms");
            Console.WriteLine($"50000\t\t|{SS2150.ElapsedMilliseconds}ms\t\t|{SS3250.ElapsedMilliseconds}ms\t\t\t|{SS4350.ElapsedMilliseconds}ms\t\t|{BBS50.ElapsedMilliseconds}ms\t\t|{QS50.ElapsedMilliseconds}ms\t\t|{IS50.ElapsedMilliseconds}ms");

            //section of my own gaps
            int[] array1ForMyOwnGaps10k;
            array1ForMyOwnGaps10k = (int[])initialArrayFor10k.Clone();
            List<int> myOwnGaps11 = Sorter.GenerateMyOwnGaps3k(10000);
            Stopwatch myOwnGapsTime11 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array1ForMyOwnGaps10k, myOwnGaps11);
            myOwnGapsTime11.Stop();

            int[] array1ForMyOwnGaps20k;
            array1ForMyOwnGaps20k = (int[])initialArrayFor20k.Clone();
            List<int> myOwnGaps12 = Sorter.GenerateMyOwnGaps3k(20000);
            Stopwatch myOwnGapsTime12 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array1ForMyOwnGaps20k, myOwnGaps12);
            myOwnGapsTime12.Stop();

            int[] array1ForMyOwnGaps30k;
            array1ForMyOwnGaps30k = (int[])initialArrayFor30k.Clone();
            List<int> myOwnGaps13 = Sorter.GenerateMyOwnGaps3k(30000);
            Stopwatch myOwnGapsTime13 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array1ForMyOwnGaps30k, myOwnGaps13);
            myOwnGapsTime13.Stop();

            int[] array1ForMyOwnGaps40k;
            array1ForMyOwnGaps40k = (int[])initialArrayFor40k.Clone();
            List<int> myOwnGaps14 = Sorter.GenerateMyOwnGaps3k(40000);
            Stopwatch myOwnGapsTime14 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array1ForMyOwnGaps40k, myOwnGaps14);
            myOwnGapsTime14.Stop();

            int[] array1ForMyOwnGaps50k;
            array1ForMyOwnGaps50k = (int[])initialArrayFor50k.Clone();
            List<int> myOwnGaps15 = Sorter.GenerateMyOwnGaps3k(50000);
            Stopwatch myOwnGapsTime15 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array1ForMyOwnGaps50k, myOwnGaps15);
            myOwnGapsTime15.Stop();



            int[] array2ForPrimeGaps10k;
            array2ForPrimeGaps10k = (int[])initialArrayFor10k.Clone();
            List<int> primeNumberGaps10k = Sorter.FillPrimeNumbers(10000);
            Stopwatch primeNumberGapsTime21 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array2ForPrimeGaps10k, primeNumberGaps10k);
            primeNumberGapsTime21.Stop();

            int[] array2ForPrimeGaps20k;
            array2ForPrimeGaps20k = (int[])initialArrayFor20k.Clone();
            List<int> primeNumberGaps20k = Sorter.FillPrimeNumbers(20000);
            Stopwatch primeNumberGapsTime22 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array2ForPrimeGaps20k, primeNumberGaps20k);
            primeNumberGapsTime22.Stop();

            int[] array2ForPrimeGaps30k;
            array2ForPrimeGaps30k = (int[])initialArrayFor30k.Clone();
            List<int> primeNumberGaps30k = Sorter.FillPrimeNumbers(30000);
            Stopwatch primeNumberGapsTime23 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array2ForPrimeGaps30k, primeNumberGaps30k);
            primeNumberGapsTime23.Stop();

            int[] array2ForPrimeGaps40k;
            array2ForPrimeGaps40k = (int[])initialArrayFor40k.Clone();
            List<int> primeNumberGaps40k = Sorter.FillPrimeNumbers(40000);
            Stopwatch primeNumberGapsTime24 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array2ForPrimeGaps40k, primeNumberGaps40k);
            primeNumberGapsTime24.Stop();

            int[] array2ForPrimeGaps50k;
            array2ForPrimeGaps50k = (int[])initialArrayFor50k.Clone();
            List<int> primeNumberGaps50k = Sorter.FillPrimeNumbers(50000);
            Stopwatch primeNumberGapsTime25 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array2ForPrimeGaps50k, primeNumberGaps50k);
            primeNumberGapsTime25.Stop();


            int[] array3ForMyOwnGaps10k;
            array3ForMyOwnGaps10k = (int[])initialArrayFor10k.Clone();
            List<int> myOwnGaps31 = Sorter.generateOwnGapSegewickModified(10000);
            Stopwatch myOwnGapsTime31 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array3ForMyOwnGaps10k, myOwnGaps31);
            myOwnGapsTime31.Stop();

            int[] array3ForMyOwnGaps20k;
            array3ForMyOwnGaps20k = (int[])initialArrayFor20k.Clone();
            List<int> myOwnGaps32 = Sorter.generateOwnGapSegewickModified(20000);
            Stopwatch myOwnGapsTime32 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array3ForMyOwnGaps20k, myOwnGaps32);
            myOwnGapsTime32.Stop();

            int[] array3ForMyOwnGaps30k;
            array3ForMyOwnGaps30k = (int[])initialArrayFor30k.Clone();
            List<int> myOwnGaps33 = Sorter.generateOwnGapSegewickModified(30000);
            Stopwatch myOwnGapsTime33 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array3ForMyOwnGaps30k, myOwnGaps33);
            myOwnGapsTime33.Stop();

            int[] array3ForMyOwnGaps40k;
            array3ForMyOwnGaps40k = (int[])initialArrayFor40k.Clone();
            List<int> myOwnGaps34 = Sorter.generateOwnGapSegewickModified(40000);
            Stopwatch myOwnGapsTime34 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array3ForMyOwnGaps40k, myOwnGaps34);
            myOwnGapsTime34.Stop();

            int[] array3ForMyOwnGaps50k;
            array3ForMyOwnGaps50k = (int[])initialArrayFor50k.Clone();
            List<int> myOwnGaps35 = Sorter.generateOwnGapSegewickModified(50000);
            Stopwatch myOwnGapsTime35 = Stopwatch.StartNew();
            Sorter.ShellSortWithMyOwnGaps(array3ForMyOwnGaps50k, myOwnGaps35);
            myOwnGapsTime35.Stop();


            Console.WriteLine("elements\t|ShellSortMyOwnGap3k+1\t|ShellSortMyOwnGapPrimeNumb\t|ShellSortMyOwnGapSegewickModified");
            Console.WriteLine($"10000\t\t|{myOwnGapsTime11.ElapsedMilliseconds}ms\t\t\t|{primeNumberGapsTime21.ElapsedMilliseconds}ms\t\t\t\t|{myOwnGapsTime31.ElapsedMilliseconds}ms");
            Console.WriteLine($"20000\t\t|{myOwnGapsTime12.ElapsedMilliseconds}ms\t\t\t|{primeNumberGapsTime22.ElapsedMilliseconds}ms\t\t\t\t|{myOwnGapsTime32.ElapsedMilliseconds}ms");
            Console.WriteLine($"30000\t\t|{myOwnGapsTime13.ElapsedMilliseconds}ms\t\t\t|{primeNumberGapsTime23.ElapsedMilliseconds}ms\t\t\t\t|{myOwnGapsTime33.ElapsedMilliseconds}ms");
            Console.WriteLine($"40000\t\t|{myOwnGapsTime14.ElapsedMilliseconds}ms\t\t\t|{primeNumberGapsTime24.ElapsedMilliseconds}ms\t\t\t\t|{myOwnGapsTime34.ElapsedMilliseconds}ms");
            Console.WriteLine($"50000\t\t|{myOwnGapsTime15.ElapsedMilliseconds}ms\t\t\t|{primeNumberGapsTime25.ElapsedMilliseconds}ms\t\t\t\t|{myOwnGapsTime35.ElapsedMilliseconds}ms");



            var data = new string[]
                {

                SS2110.ElapsedMilliseconds.ToString(),SS3210.ElapsedMilliseconds.ToString(),SS4310.ElapsedMilliseconds.ToString(),QS10.ElapsedMilliseconds.ToString(),myOwnGapsTime11.ElapsedMilliseconds.ToString(),primeNumberGapsTime21.ElapsedMilliseconds.ToString(),myOwnGapsTime31.ElapsedMilliseconds.ToString(),
                SS2120.ElapsedMilliseconds.ToString(),SS3220.ElapsedMilliseconds.ToString(),SS4320.ElapsedMilliseconds.ToString(),QS20.ElapsedMilliseconds.ToString(),myOwnGapsTime12.ElapsedMilliseconds.ToString(),primeNumberGapsTime22.ElapsedMilliseconds.ToString(),myOwnGapsTime32.ElapsedMilliseconds.ToString(),
                SS2130.ElapsedMilliseconds.ToString(),SS3230.ElapsedMilliseconds.ToString(),SS4330.ElapsedMilliseconds.ToString(),QS30.ElapsedMilliseconds.ToString(),myOwnGapsTime13.ElapsedMilliseconds.ToString(),primeNumberGapsTime23.ElapsedMilliseconds.ToString(),myOwnGapsTime33.ElapsedMilliseconds.ToString(),
                SS2140.ElapsedMilliseconds.ToString(),SS3240.ElapsedMilliseconds.ToString(),SS4340.ElapsedMilliseconds.ToString(),QS40.ElapsedMilliseconds.ToString(),myOwnGapsTime14.ElapsedMilliseconds.ToString(),primeNumberGapsTime24.ElapsedMilliseconds.ToString(),myOwnGapsTime34.ElapsedMilliseconds.ToString(),
                SS2150.ElapsedMilliseconds.ToString(),SS3250.ElapsedMilliseconds.ToString(),SS4350.ElapsedMilliseconds.ToString(),QS50.ElapsedMilliseconds.ToString(),myOwnGapsTime15.ElapsedMilliseconds.ToString(),primeNumberGapsTime25.ElapsedMilliseconds.ToString(),myOwnGapsTime35.ElapsedMilliseconds.ToString()



                };

            //string filePath = @"C:\Users\adria\OneDrive\Pulpit\danesortowanie\pythonProject\file.csv";

            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    for (int i = 0; i < data.Length; i++)
            //    {
            //        writer.Write(data[i]);


            //        if ((i+1) % 7 != 0)
            //        { writer.Write(';'); }
            //        else
            //        {
            //            writer.WriteLine();
            //        }
            //    }
            //}
            //Console.WriteLine(BBS50.ElapsedMilliseconds);*/

            Console.WriteLine();
            Console.WriteLine("\t\t\t|ShellSort21\t|ShellsSort32\t|ShellsSort43\t|BubbleSort\t|QuickSort\t|InsertionSort ");
            Console.WriteLine($"Are functions sorted?\t|{Sorter.checkTable(arrayForShellSort2150k)}\t\t|{Sorter.checkTable(arrayForShellSort3250k)}\t\t|{Sorter.checkTable(arrayForShellSort4350k)}\t\t|{Sorter.checkTable(arrayForBubbleSort50k)}\t\t|{Sorter.checkTable(arrayForQuickSort50k)}\t\t|{Sorter.checkTable(arrayForInsertionSort50k)}");
            Console.WriteLine();
            Console.WriteLine("\t\t\t|My own gap\t\t\t|My own prime gaps\t\t|My own Segewick Modified gaps");
            Console.WriteLine($"\t\t\t|{Sorter.checkTable(array1ForMyOwnGaps50k)}\t\t\t\t|{Sorter.checkTable(array2ForPrimeGaps50k)}\t\t\t\t|{Sorter.checkTable(array3ForMyOwnGaps50k)}");
        }
    }
}
