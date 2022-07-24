// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// пример: 0, 7, 8, -2, -2 -> 2
// пример: 1, -7, 567, 89, 223-> 3

int count =0;
int num1=1;
Console.WriteLine("ввод чисел можно завершить вводом 0"); // когда придумывала это решение, не заметила 0 в примере при условии задачи
while(num1!=0){Console.WriteLine("введите число"); // 0 не положителен и не отрицателен
num1 = Convert.ToInt32(Console.ReadLine());
if(num1>0){
    count++;
}
}
Console.WriteLine(count);

// решение, предложенное на семинаре
// int M = Convert.ToInt32(Console.ReadLine()); // задает количество чисел,которые будут вводиться
// int countPositives = 0;

// for(int i = 0; i<M; i++){
// int digit = Convert.ToInt32(Console.ReadLine());
// if(digit>0){
// countPositives++;
// }
// }
// Console.WriteLine("Positives: {0}", countPositives);