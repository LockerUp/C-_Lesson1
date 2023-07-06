/* **Задача 33:**Задайте массив.Напишите программу,
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/

Console.Write("Введите длину массив: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] arr = CreatArr(n);
FindNum(arr, num);

int[] CreatArr(int size){
int[] arr = new int[size];
Console.Write("Введите массив: ");
for(int i = 0; i < size; i++){
arr[i] = int.Parse(Console.ReadLine());
}
return arr;
}

void FindNum(int[] arr, int number){
for(int i = 0;i < arr.Length;i++){
if(arr[i] == number){
Console.Write(" да");
break;

}
if(i == arr.Length - 1){
Console.Write(" нет");
}
}
}