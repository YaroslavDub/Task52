// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [m, n];
int sum = 0;
double[] array = new double[n];
for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write( matrix[i,j]+ " ");
        sum = sum + matrix[i,j];
    }
    Console.WriteLine();
}
for (int j = 0; j < n; j++) {
    for (int i = 0; i < m; i++) {
        array[j] = array[j] + matrix[i,j];
    }
    array[j] = Math.Round(array[j] / n, 1);
}
Console.WriteLine("Среднее арифметическое каждого столбца: "+ string.Join("; ", array));