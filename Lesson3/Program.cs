//Нахождение длины отрезка через координаты на плоскости
//Теорема Пифагора - квадрат гепотенузы равен сумме квадратов катетов.
//AB^2 = AC^2 + BC^2;
//AB = Sqrt(AC^2 + BC^2);
double GetDistance(double x1, double y1, double x2, double y2)
{
    //для начала найдем длины катетов
    double xLine = x2 - x1; // длина первого катета
    double yLine = y2 - y1; // длина второго катета  

    double distQuad = (xLine * xLine) + (yLine * yLine); //квадрат гипотинузы   
    double result = Math.Sqrt(distQuad); //длина гипотенузы
    
    return result;
}
