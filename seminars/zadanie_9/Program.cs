//30 Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
//int[]
// //[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7);
// int b = new Random().Next(2);

Console.Clear();
int[] arr= new int [8];

int[] fillArray(int[] array) {
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(50);
    }
    return arr;
}

System.Console.WriteLine($"[{String.Join(", ", fillArray(arr))}]");