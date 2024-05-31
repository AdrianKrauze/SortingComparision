namespace SortProject
{
    public class Sorter
    {


        public List<int> generateSegewickGaps(int gapLimit)
        {
            List<int> gaps = new List<int>();


            gaps.Add(1);


            int i = 1;


            while (true)
            {
                int gap = (int)(Math.Pow(4, i) + 3 * Math.Pow(2, i - 1) + 1);

                if (gap < gapLimit)
                {
                    gaps.Add(gap);
                    i++;
                }
                else
                {
                    break;
                }
            }
            gaps.Reverse();
            return gaps;
        }

        public List<int> generateOwnGapSegewickModified(int gapLimit)
        {
            List<int> gaps = new List<int>();


            gaps.Add(1);


            int i = 1;


            while (true)
            {
                int gap = (int)(Math.Pow(5, i) + 3 * Math.Pow(7, i - 1) - 1);

                if (gap < gapLimit)
                {
                    gaps.Add(gap);
                    i++;
                }
                else
                {
                    break;
                }
            }
            gaps.Reverse();
            return gaps;
        }




        public List<int> generateStasiewiczGaps(int gapLimit)
        {
            List<int> gaps = new List<int>();
            // Generowanie odstępów na podstawie wyrazu ogólnego k^2 - 1
            for (int k = 1; k < gapLimit; k += k)
            {
                if (k == 1)
                {
                    gaps.Add(k);
                }
                else
                {
                    k++;
                    gaps.Add(k);
                    k--;
                }

            }
            // Odwrócenie listy odstępów, aby sortowanie zaczynało się od największego odstępu
            gaps.Reverse();
            return gaps;
        }



        public int[] FillArray(int x)
        {
            int[] arrayX = new int[x];
            Random rand = new Random();

            for (int i = 0; i < arrayX.Length; i++)
            {
                int randomValue = rand.Next(10000, 500000);
                arrayX[i] = randomValue;
            }
            return arrayX;
        }



        public void ShellSort21(int[] arr)
        {

            for (int gap = arr.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j = j - gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }



        public void ShellSortWithMyOwnGaps(int[] arr, List<int> gaps)
        {

            foreach (int gap in gaps)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
        }



        public void BubbleSort(int[] arr)
        {

            int n = arr.Length;
            int temp;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }


        }


        public void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(array, leftIndex, j);
            if (i < rightIndex)
                QuickSort(array, i, rightIndex);
        }

        public void InsertionSort(int[] arr)
        {

            for (int i = 1; i < arr.Length; ++i)
            {
                int current = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = current;
            }
        }

        public List<int> GenerateMyOwnGaps3k(int gapLimit)
        {
            List<int> gaps = new List<int>();
            for (int k = 1; k < gapLimit; k += 2 * k)
            {
                if (k == 1)
                {

                    gaps.Add(k);
                }
                else
                {
                    k++;
                    gaps.Add(k);
                    k--;

                }

            }

            gaps.Reverse();
            return gaps;
        }


        public List<int> FillPrimeNumbers(int gapLimit)
        {

            List<int> primeNumbers = new List<int>
            {
              5464033, 3928669, 2432597, 1000003, 876817, 740903, 606569, 474667, 345181, 219763, 100003, 84437, 45641, 10007, 8171, 6343, 4639, 2957, 1429, 101, 67, 29, 11, 1
            };

            List<int> filteredPrimeNumbers = primeNumbers.FindAll(prime => prime <= gapLimit);

            return filteredPrimeNumbers;
        }

        public bool checkTable(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}

