// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] arr= new int [8];

int[] fillArray(int[] array) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(50);
    }
    return arr;
}

System.Console.WriteLine($"[{String.Join(", ", fillArray(arr))}]");