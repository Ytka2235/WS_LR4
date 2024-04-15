using library;
using person;

internal class Program
{
    private static void Main(string[] args)
    {
        Student[] students = new Student[3];
        students[0] = new (18, "Тряпкин", "В.Д.", "12ИТ22");
        students[1] = new (20, "Маркин", "О.А.", "67ПТ21");
        students[2] = new (19, "Степанов", "Д.Ю.", "87ИТ78");

        students[1].WriteStudent();

        Reader[] readers = new Reader[3];
        readers[0] = new ("Петров Г.П.", "89276347689", "веб-програмирование", "23.09.2000", "98к68");
        readers[1] = new ("Рябинов Н.Л.", "89297650989", "высшая математика", "13.02.1999", "87н36");
        readers[2] = new ("Песков А.К.",  "89276543214", "ядерная физика", "3.12.2001", "76д09");

        readers[0].WriteReader();
        readers[1].takeBook(5);
        readers[1].returnBook(3);
        readers[2].takeBook("Война и мир","Преступление и наказание","Гаргантюа и Пантагрюэль");
        readers[2].returnBook(new string[]{ "Мёртвые души", "Сборник стихов Есенина"});

    }
}
namespace person
{
    class Student
    {
        private int age;
        public int Age { get { return age; } set { age = value; } }
        public string Name;
        public string initials;
        public string group;
        public Student(int age, string name, string init, string group)
        {
            this.age = age;
            Name = name;
            initials = init;
            this.group = group;
        }

        public void WriteStudent()
        {
            Console.WriteLine($"{Name} {initials} возраст {age}, группа {group}");
        }
    }
}
namespace library
{
    class Reader
    {

        private string name;
        public string Name { get { return name; } set { name = value; } }

        public string telefon;
        public string talon;
        private string age;
        public string Age { get { return age; } set { age = value; } }
        public string faculty;

        public Reader(string name, string tele, string fac, string age, string talon)
        {
            Name = name;
            telefon = tele;
            faculty = fac;
            Age = age;
            this.talon = talon;
        }

        public void WriteReader()
        {
            Console.WriteLine($"{Name} {age}, факультатив {faculty}, талон {talon}, телефон{telefon}");
        }

        public void takeBook(int book)
        {
            Console.WriteLine($"{Name} взял {book} книг");
        }
        public void takeBook(params string[] books)
        {
            Console.Write($"{Name} взял книги");
            foreach (string book in books) Console.Write(", " + book);
            Console.WriteLine(".");
        }

        public void returnBook(int book)
        {
            Console.WriteLine($"{Name} вернул {book} книг");
        }
        public void returnBook(params string[] books)
        {
            Console.Write($"{Name} вернул книги");
            foreach (string book in books) Console.Write(", " + book);
            Console.WriteLine(".");
            
        }
    }
}
