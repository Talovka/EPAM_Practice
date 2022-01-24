using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1_2
{
    class StartGenerator
    {
        private User user = new User("Pavel");

        public void PaintStart()
        {
            string menu;

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить фигуру");
            Console.WriteLine("2. Вывести фигуры");
            Console.WriteLine("3. Удалить все фигуры");
            Console.WriteLine("4. Выход");
            menu = Console.ReadLine();

            switch (menu)
            {
                case "1":

                    Console.WriteLine("Выберите, какую фигуру создать:");
                    Console.WriteLine("1. Создать линию");
                    Console.WriteLine("2. Создать окружность");
                    Console.WriteLine("3. Создать круг");
                    Console.WriteLine("4. Создать кольцо");
                    Console.WriteLine("5. Создать треугольник");
                    Console.WriteLine("6. Создать прямоугольник");
                    Console.WriteLine("7. Создать квадрат");

                    string figure = Console.ReadLine();
                    Point pointfirst;
                    Point pointsecond;
                    Point pointthird;
                    double innerradius;
                    double radius;
                    double heigth;
                    double length;

                    switch (figure)
                    {
                        case "1":
                            pointfirst = StartPoint("Первая точка");
                            pointsecond = StartPoint("Вторая точка");
                            try
                            {
                                Line line = new Line(pointfirst, pointsecond);
                                user.AddShape(line);
                                Console.WriteLine($"Создана {line}");
                                PaintStart();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "2":
                            pointfirst = StartPoint("Центр окружности");
                            Console.Write("Введите радиус: ");
                            radius= double.Parse(Console.ReadLine());
                            try
                            {
                                Round round = new Round(pointfirst, radius);
                                user.AddShape(round);
                                Console.WriteLine($"Создана {round}");
                                PaintStart();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;
                        case "3":
                            pointfirst = StartPoint("Центр круга");
                            Console.Write("Введите радиус: ");
                            radius= double.Parse(Console.ReadLine());
                            try
                            {
                                Circle circle = new Circle(pointfirst, radius);
                                user.AddShape(circle);
                                Console.WriteLine($"Создан {circle}");
                                PaintStart();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "4":
                            pointfirst = StartPoint("Центр кольца");
                            Console.Write("Введите внутренний радиус: ");
                            innerradius = double.Parse(Console.ReadLine()); ;
                            Console.Write("Введите внешний радиус: ");
                            radius = double.Parse(Console.ReadLine()); ;
                            try
                            {
                                Ring ring = new Ring(pointfirst, innerradius, radius);
                                user.AddShape(ring);
                                Console.WriteLine($"Создано {ring}");
                                PaintStart();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "5":
                            pointfirst = StartPoint("Первая сторона");
                            pointsecond = StartPoint("Вторая сторона");
                            pointthird = StartPoint("Третья сторона");
                            try
                            {
                                Triangle triangle = new Triangle(pointfirst, pointsecond, pointthird);
                                user.AddShape(triangle);
                                Console.WriteLine($"Создан {triangle}");
                                PaintStart();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "6":
                            pointfirst = StartPoint("Начальная точка");
                            Console.WriteLine("Введите ширину: ");
                            heigth = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите длину: ");
                            length = double.Parse(Console.ReadLine());
                            try
                            {
                                Rectangle rectangle = new Rectangle(pointfirst, heigth, length);
                                user.AddShape(rectangle);
                                Console.WriteLine($"Создан {rectangle}");
                                PaintStart();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        case "7":
                            pointfirst = StartPoint("Начальная точка");
                            Console.WriteLine("Введите длину стороны: ");
                            length = double.Parse(Console.ReadLine());
                            try
                            {
                                Square square = new Square(pointfirst, length);
                                user.AddShape(square);
                                Console.WriteLine($"Создан {square}");
                                PaintStart();
                            }
                            catch
                            {
                                throw new Exception();
                            }
                            break;

                        default:
                            throw new NotImplementedException();
                    }
                    break;

                case "2":
                    int i = 1;
                    foreach (var item in user.ListofShape)
                    {
                        Console.WriteLine("№ - {0} {1}", i, item);
                        i++;
                    }
                    PaintStart();
                    break;

                case "3":
                    user.ListofShape.Clear();
                    Console.WriteLine("Все фигуры удалены");
                    PaintStart();
                    break;

                case "4":
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
        public static Point StartPoint(string name)
        {
            double x;
            double y;
            Console.Write($"{name}:\n" + $"X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            y = double.Parse(Console.ReadLine());
            return new Point(x, y);
        }
    }
}
