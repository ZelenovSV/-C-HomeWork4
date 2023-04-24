Console.WriteLine("Введите число А: ");
    int A = int.Parse(Console.ReadLine());
    double function(int number)
    {
    int sum = 0;
    for (int i = 1; i <= A; i++)
    sum = sum + A[i];
    return sum;
    }
    Console.WriteLine($"Сумма чисел: {function(A)}");
    