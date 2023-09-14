Console.Clear();
Random rnd = new Random();

//int iterCount = 0;

//while (iterCount < 15){
Run();
//iterCount ++;
//await Task.Delay(2);
//}

void Run (){
int iterration =100000;
int xA=95, yA=1;
int xB=1, yB=63;
int xC=180, yC=63;

Console.SetCursorPosition(xA,yA);
Console.WriteLine("*");
Console.SetCursorPosition(xB,yB);
Console.WriteLine("*");
Console.SetCursorPosition(xC,yC);
Console.WriteLine("*");

int x = xA;
int y = xB;

int count = 0;

while (count < iterration){
    int line = rnd.Next(0,3); // (0...2]
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
    Console.SetCursorPosition(x,y);
    
    int colorCount = y / 5; 
    /*
    int colorCount = rnd.Next(1,16);
    if (colorCount < 1) colorCount = 1;
    if (colorCount == 8) colorCount = rnd.Next(7,10);
    if (colorCount == 8) colorCount = 9;
    */
    Console.ForegroundColor = (ConsoleColor)(colorCount);

    Console.WriteLine("*");
    //await Task.Delay(1);
    count++;
    Console.ResetColor();
}
}
Console.SetCursorPosition(1,63);

