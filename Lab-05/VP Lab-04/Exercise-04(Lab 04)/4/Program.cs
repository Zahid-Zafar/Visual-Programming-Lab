using System;

class Program
{
    static void Main()
    {
        int[] ratings = { 5, 2, 3, 1, 4, 5, 2, 3, 4,
                          5, 1, 1, 2, 3, 4, 5, 1, 2, 3, 4,
                          5, 1, 2, 3, 4, 5, 1, 2, 3, 4, 2, 3 };

        int[] frequency = new int[5];

        foreach (int rating in ratings)
        {
            if (rating >= 1 && rating <= 5)
            {
                frequency[rating - 1]++;
            }
        }

        for (int i = 0; i < frequency.Length; i++)
        {
            Console.WriteLine($"Response {i + 1} given by: {frequency[i]} people");
        }
    }
}
