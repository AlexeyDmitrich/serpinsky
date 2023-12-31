// стираем консоль
Console.Clear();
//создаём генератор рандомных чисел
Random rnd = new Random();

//int iterCount = 0;
//while (iterCount < 15){
//iterCount ++;
//await Task.Delay(2);
//}

//вызываем метод который всё сделает
Run();

//сам метод:
void Run (){
    //определяем количество итерраций
int iterration =100000;
    //задаем координаты первой точки (нижняя правая вершина)
int xA=95, yA=1;
    //задаем координаты второй точки (нижняя левая вершина)
int xB=1, yB=63;
    //задаем координаты третьей точки (верхняя вершина)
int xC=180, yC=63;
    // для каждой консоли эти значения надо будет подгонять индивидуально. 


// Устанавливаем курсор на первую вершиу
Console.SetCursorPosition(xA,yA);
// отрисовываем там звездочку
// проделываем то же с остальными
Console.WriteLine("*");
Console.SetCursorPosition(xB,yB);
Console.WriteLine("*");
Console.SetCursorPosition(xC,yC);
Console.WriteLine("*");

// обозначаем сторону с которой будем начинать фигачить зарисовку треугольника
int x = xA;
int y = xB;

// инициализируем счётчик
int count = 0;

// запиливаем цикл
while (count < iterration){ // если синтаксис не знаком, переведу: "доколе счётчик меньше числа итерраций, будем повторять то, что в фигурных скобочках"
    int line = rnd.Next(0,3); // (0...2]  //лайн будет рандомным целым числом от 0 до 3, включая 0, не включая 3.
// здесь нужно вчитаться в код. "иф" - это тупо "если"
// здесь происходит выбор точки,куда будем размещать курсор
    if (line == 0){
        x=(x+xA)/2;
        y=(y+yA)/2;
    }
    if (line == 1){
        x=(x+xB)/2;
        y=(y+yB)/2;
        //Console.ForegroundColor = ConsoleColor.DarkCyan;
    }
    if (line == 2){
        x=(x+xC)/2;
        y=(y+yC)/2;
        //Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }

    // Размещаем курсор на заданную позицию
    Console.SetCursorPosition(x,y);
    
    // счётчик для цвета. он будет отталкиваться от координаты точки, которая будет выбираться случайно
    // изначально была задумка на мягкий градиент, но консоль или шарп не вывозят столько цветов
    int colorCount = y / 5; 
    /*
    int colorCount = rnd.Next(1,16);
    if (colorCount < 1) colorCount = 1;
    if (colorCount == 8) colorCount = rnd.Next(7,10);
    if (colorCount == 8) colorCount = 9;
    */

    // выбираем цвет для устанавливаемой звёздочки
    Console.ForegroundColor = (ConsoleColor)(colorCount);
    
    // устанавливаем звёздочку в то место, где находится курсор
    Console.WriteLine("*");
    
    // это задержка в милисекундах. можно раскомментировать - движняк будет медленнее. сильно медленнее.
    //await Task.Delay(1);

    // прибавляем счётчик на 1. если этого не сделать, цикл будет вечным.
    count++;

    // сбрасываем значение цвета
    Console.ResetColor();
} // конец одной итеррации

} // конец метода ран.

// возвращаем курсор на удобную позицию
Console.SetCursorPosition(1,63); // это последнее, что сделает программа.

