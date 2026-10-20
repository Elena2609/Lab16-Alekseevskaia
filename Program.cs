//Шаг 1. Создание и заполнениемассива
using System.Drawing;

// Console.Write("Сколько студентов в группе?");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];

// for (int i = 0; i < grades.Length; i++){
//     Console.WriteLine($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }
// int sum = 0;
// int count = 0;
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum += grade;
//     count++;
// }
// double average = (double)sum /count;
// Console.WriteLine($"Средний балл: {average});

//Шаг 2. Изменение элементов массива
// int[] points = { 4, 7, 2, 9, 5 };

// for (int i = 0; i < points.Length; i++){
//     if (points[i] < 10){
//         points[i] = points[i] + 1;
//     } 

// }

// foreach (int point in points)
// {
//     Console.WriteLine(point);
// } 
//Шаг 3. Сортировка массива
// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// } 

//Шаг 4. Метод, возвращающий массив
// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;
//     }

//     return slots;
// }

// int[] slots = GenerateScheduleSlots(6);
// Console.WriteLine("Массив чисел");
// foreach (int slot in slots)
// {
//     Console.WriteLine(slot);
// } 
// int[] GenerateEvenSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = (i + 1) * 2;
//     }

//     return slots;
// } 
// int[] slotsEven = GenerateEvenSlots(6);
// Console.WriteLine("Массив четных чисел");
// foreach (int slotE in slotsEven)
// {
//     Console.WriteLine(slotE);
// }

// //Шаг 5. Знакомство с Array.Sort()
// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// } 

//Самостоятельные задания
Console.WriteLine("Задача A");
int N = int.Parse(Console.ReadLine());
int[] num = new int[N];

for (int i = 0; i < N; i++)
{
    num[i] = (i + 1) * (i + 1);
} 
foreach (int n in num){
    Console.WriteLine(n);
}