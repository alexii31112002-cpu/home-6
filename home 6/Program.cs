int[] arr1 = { 10, 20, 30, 40, 50 };

Console.Write("Исходный массив: ");
foreach (int x in arr1)
{
    Console.Write(x + " ");
}
Console.WriteLine();

int[] arr2 = new int[arr1.Length];

for (int i = 0; i < arr1.Length; i++)
{
    arr2[i] = arr1[arr1.Length - 1 - i];
}

Console.Write("Перевернутый массив: ");
foreach (int x in arr2)
{
    Console.Write(x + " ");
}

Console.ReadLine();
