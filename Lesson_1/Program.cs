namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // откомментировать необходимое задание
            //Task1();
            //Task2();
            //Task3();
        }

        private static void Task1()
        {
            string input;

            Console.WriteLine("Введите сторону a");
            input = Console.ReadLine();
            double.TryParse(input, out double side1);

            Console.WriteLine("Введите сторону b");
            input = Console.ReadLine();
            double.TryParse(input, out double side2);

            Rectangle rect = new Rectangle(side1, side2);
            double area = rect.AreaCalculator();
            double perimeter = rect.PerimeterCalculator();

            Console.WriteLine($"Прямоугольник со сторонами {side1} {side2}");
            Console.WriteLine($"Площадь = {area}");
            Console.WriteLine($"Периметр = {perimeter}");

            Console.ReadKey();
        }

        private static void Task2()
        {
            Console.WriteLine("Введите автора");
            string author = Console.ReadLine();

            Console.WriteLine("Введите название");
            string title = Console.ReadLine();

            Console.WriteLine("Введите содержание");
            string content = Console.ReadLine();

            Book book = new Book(author, title, content);

            book.Author.Show();
            book.Title.Show();
            book.Content.Show();

            Console.ReadKey();
        }

        private static void Task3()
        {
            Point point1 = new Point(0, 0, "pochka");
            Point point2 = new Point(0, 1, "pochka");
            Point point3 = new Point(1, 1, "pochka");
            Point point4 = new Point(2, 4, "pochka");

            Figure figure = new Figure(point1, point2, point3, point4);
            figure.CalculatePerimeter();
        }
    }

    public class Rectangle
    {
        public double Side1;
        public double Side2;

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double AreaCalculator()
        {
            return Side1 * Side2;
        }

        public double PerimeterCalculator()
        {
            return (Side1 + Side2) * 2f;
        }
    }

    public class Book
    {
        public Author Author;
        public Title Title;
        public Content Content;

        public Book
        (
            string author,
            string title,
            string content
        )
        {
            Author = new Author(author);
            Title = new Title(title);
            Content = new Content(content);
        }
    }

    public class Author
    {
        public string Value;

        private const ConsoleColor _color = ConsoleColor.Blue;

        public Author(string title)
        {
            Value = title;
        }

        public void Show()
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = _color;
            Console.WriteLine(Value);
            Console.ForegroundColor = currentColor;
        }
    }

    public class Title
    {
        public string Value;

        private const ConsoleColor _color = ConsoleColor.Red;

        public Title(string title)
        {
            Value = title;
        }

        public void Show()
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = _color;
            Console.WriteLine(Value);
            Console.ForegroundColor = currentColor;
        }
    }

    public class Content
    {
        public string Value;

        private const ConsoleColor _color = ConsoleColor.Green;

        public Content(string title)
        {
            Value = title;
        }

        public void Show()
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = _color;
            Console.WriteLine(Value);
            Console.ForegroundColor = currentColor;
        }
    }

    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public string NoNames;

        public Point(double x, double y, string noNames)
        {
            X = x;
            Y = y;
            NoNames = noNames;
        }
    }

    public class Figure
    {
        private Point[] _points;

        public Figure(Point point1, Point point2, Point point3)
        {
            _points = new Point[3];
            _points[0] = point1;
            _points[1] = point2;
            _points[2] = point3;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            _points = new Point[4];
            _points[0] = point1;
            _points[1] = point2;
            _points[2] = point3;
            _points[3] = point4;
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            _points = new Point[5];
            _points[0] = point1;
            _points[1] = point2;
            _points[2] = point3;
            _points[3] = point4;
            _points[4] = point5;
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(A.X * B.X + A.Y * B.Y);
        }

        public void CalculatePerimeter()
        {
            double sum = 0;

            for (int i = 0; i < _points.Length - 1; i++)
            {
                var point1 = _points[i];
                var point2 = _points[i + 1];
                sum += LengthSide(point1, point2);
            }

            Console.WriteLine($"Периметр равен: {sum}");
        }
    }
}