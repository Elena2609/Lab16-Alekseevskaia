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
// Шаг 3. Сортировка массива
Console.WriteLine("Шаг 3");
int[] grades = { 4, 5, 3, 5, 4, 2 };

for (int i = 0; i < grades.Length - 1; i++)
{
    for (int j = 0; j < grades.Length - 1 - i; j++)
    {
        if (grades[j] < grades[j + 1])
        {
            int temp = grades[j];
            grades[j] = grades[j + 1];
            grades[j + 1] = temp;
        }
    }
}

foreach (int grade in grades)
{
    Console.WriteLine(grade);
} 

// Шаг 4. Метод, возвращающий массив
Console.WriteLine("Шаг 4");
int[] GenerateScheduleSlots(int lessonsCount)
{
    int[] slots = new int[lessonsCount];

    for (int i = 0; i < lessonsCount; i++)
    {
        slots[i] = i + 1;
    }

    return slots;
}

int[] slots = GenerateScheduleSlots(6);
Console.WriteLine("Массив чисел");
foreach (int slot in slots)
{
    Console.WriteLine(slot);
} 
int[] GenerateEvenSlots(int lessonsCount)
{
    int[] slots = new int[lessonsCount];
    for (int i = 0; i < lessonsCount; i++)
    {
        slots[i] = (i + 1) * 2;
    }

    return slots;
} 
int[] slotsEven = GenerateEvenSlots(6);
Console.WriteLine("Массив четных чисел");
foreach (int slotE in slotsEven)
{
    Console.WriteLine(slotE);
}

// //Шаг 5. Знакомство с Array.Sort()
// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// } 

//Самостоятельные задания
// Console.WriteLine("Задача A");
// int N = int.Parse(Console.ReadLine());
// int[] num = new int[N];

// for (int i = 0; i < N; i++)
// {
//     num[i] = (i + 1) * (i + 1);
// } 
// foreach (int n in num){
//     Console.WriteLine(n);
// } 

// Console.WriteLine("Задача A");
// int[] numbers = {5, -3, 10, -7, 0, 8, 67};

// for (int i = 0; i < numbers.Length; i++){
//     if (numbers[i] < 0){
//         numbers[i] = 0;
//     }
// } 

// foreach (int n in numbers){
//     Console.WriteLine(n);
// } 
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Console.WriteLine("Вариант 1");
// Console.Write("Введите размер массива: ");
// int count = int.Parse(Console.ReadLine());
// int[] numbers = new int[count];
// int sum = 0;

// for (int i = 0; i < count; i++){
//     numbers[i] = int.Parse(Console.ReadLine());
//     sum += numbers[i];
// } 
// Console.WriteLine($"Сумма введеных чисел: {sum}");

// Console.WriteLine("Вариант 9");
// int[] MergeArrays(int[] first, int[] second){
//     int[] res = new int[first.Length + second.Length];
//     for (int i = 0; i < first.Length; i++){
//         res[i] = first[i];
//     }
//     for (int i = 0; i < second.Length; i++){
//         res[i+first.Length] = second[i];
//     } 
//     return res;
// } 
// int[] first = {1, 2, 3};
// int[] second = {4, 5, 6};
// int[] result = MergeArrays(first, second);
// foreach (var arr in result)
// {
//     Console.WriteLine(arr);
// }

//Дополнительное задание.Рейтинг студентов
// string[] names = {"Алина", "Катя", "Маша", "Оля"};
// int[] scores = {5, 4, 3, 5};
// for (int i = 0; i < scores.Length - 1; i++){
//     for (int j = 0; j < scores.Length - 1 - i; j++)
//     {
//         if (scores[j] < scores[j + 1])
//         {
//             int tempScore = scores[j];
//             scores[j] = scores[j + 1];
//             scores[j + 1] = tempScore;

//             string tempName = names[j];
//             names[j] = names[j+1];
//             names [j+1] = tempName;
//         }
//     }
// }

// Console.WriteLine("Итоговый рейтинг");
// for (int i = 0; i < names.Length; i++){
//     Console.WriteLine($"{i+1}. {names[i]} - {scores[i]}");
// }