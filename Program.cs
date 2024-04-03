// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

static void BubbleSort(int[] numbers)
{

    bool sorted = false;
    int timesRan = 0;

    while (!sorted)
    {
        timesRan++;
        bool swapCalled = false;

        for (int i = 0; i < numbers.Length - 1; i++)
        {

            if (numbers[i] > numbers[i + 1])
            {
                Swap(i + 1, i, numbers);
                swapCalled = true;
            }
        }

        if (!swapCalled)
        {
            sorted = true;
        }
    }

    foreach (int number in numbers)
    {
        System.Console.WriteLine(number);
    }

    Console.WriteLine($"Sorted {timesRan - 1} time{((timesRan > 1) ? "s" : "")}.\n");
}

static void SelectionSort(int[] numbers)
{
    int timesSwapped = 0;
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int swapIndex = i;
        for (int j = i+1; j < numbers.Length; j++)
        {
            if (numbers[swapIndex] > numbers[j])
            {
                swapIndex = j;
            }
        }

        if(swapIndex != i){
            Swap(swapIndex, i, numbers);
            timesSwapped++;
        }
    }

    foreach (int number in numbers)
    {
        System.Console.WriteLine(number);
    }

    Console.WriteLine($"Sorted {timesSwapped} time{((timesSwapped > 1) ? "s" : "")}.\n");
}

static void Swap(int smallerIndex, int largerIndex, int[] numbers)
{
    (numbers[smallerIndex], numbers[largerIndex]) = (numbers[largerIndex], numbers[smallerIndex]);
}

int[] numbers = [10, 9, 3, 4, 5, 6, 7, 1, 2, 8];

var watch = System.Diagnostics.Stopwatch.StartNew();
BubbleSort(numbers);
watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine($"Time: {elapsedMs}");
Console.ReadKey();

numbers = [10, 9, 3, 4, 5, 6, 7, 1, 2, 8];

watch = System.Diagnostics.Stopwatch.StartNew();
SelectionSort(numbers);
watch.Stop();
elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine($"Time: {elapsedMs}");
Console.ReadKey();