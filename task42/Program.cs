int countPositive (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine("This program assepts your numbers and count quantity of positive numbers.");
Console.Write("Enter quantity of numbers, that you want to enter: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] arrayNumbers = new int [N];

for (int i = 0; i < arrayNumbers.Length; i++)
{
    Console.Write("Enter number: ");
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
}

int res = countPositive(arrayNumbers);
Console.WriteLine($"Here is {res} positive numbers");