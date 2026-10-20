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
int[] points = { 4, 7, 2, 9, 5 };

for (int i = 0; i < points.Length; i++){
    if (points[i] < 10){
        points[i] = points[i] + 1;
    } 
    
}

foreach (int point in points)
{
    Console.WriteLine(point);
} 
