/*Задача 37:**Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6]-> 36 21*/
Console.Clear();
int[] arrey = GetArr();
int[] prouduct_of_numbers = GetProductOfNumbers(arrey);
Console.Write($"{String.Join(", ",arrey)} -> {String.Join(", ",prouduct_of_numbers)}");

int[] GetArr(){
int size = new Random().Next(2, 10);
int[] arr = new int[size];
for(int i = 0;i < arr.Length;i++){
arr[i] = new Random().Next(1, 20);
}
return arr;
}

int[] GetProductOfNumbers(int[] numbers){
int[] prouduct_of_numbers = new int[numbers.Length / 2];
for(int i = 0;i < numbers.Length / 2;i++){
prouduct_of_numbers[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
return prouduct_of_numbers;
}