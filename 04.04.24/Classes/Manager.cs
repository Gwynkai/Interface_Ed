using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._24.Classes
{
    public class Manager : IEmployee
    {
        private string? _name;
        public string? Name
        {
            get
            {
                return _name;
            }
            set { _name = value; }
        }

        private int? _age;
        public int? Age
        {
            get
            {
                return _age;
            }
            set { _age = value; }
        }

        private string? _post;
        public string? Post
        {
            get
            {
                return _post;
            }
            set { _post = value; }
        }

        private bool _appeared;
        public bool Appeared
        {
            get
            {
                return _appeared;
            }
            set { _appeared = value; }
        }

        public Manager(string? name, int? age, string? post, bool appeared)
        {
            Name = name;
            Age = age;
            Post = post;
            Appeared = appeared;
        }

        public void AppearanceCheck()
        {
            if (_appeared)
            {
                Console.WriteLine("Присутствует");
            }
            else
            {
                Console.WriteLine("Отсутствует");
            }
        }

        public void ViewInfo(string data)
        {
            Console.WriteLine(data.ToString());
        }
        public void ViewInfo(int data)
        {
            Console.WriteLine(data.ToString());
        }

        public void ViewInfo(bool data)
        {
            Console.WriteLine(data.ToString());
        }

        public void DeleteInfo(string? data)
        {

            if (data == Name)
            {
                Name = "unknown";
            }
            else
            {
                Post = "empty";
            }

        }

        public void DeleteInfo(int? data)
        {
            Age = 0;
        }

        public void AddInfo(string? data)
        {
            if (data == "unknown" || data == "empty")
            {

                if (data == Name)
                {
                    Console.WriteLine("Введите имя");
                    Name = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Введите должность");
                    Post = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Информация о сотруднике уже добавлена");
            }
        }
        public void AddInfo(int? data)
        {
            if (data == 0)
            {
                Console.WriteLine("Введите возраст");
                data = Convert.ToInt32(Console.ReadLine());
                Age = data;
            }
            else
            {
                Console.WriteLine("Информация о сотруднике уже добавлена");
            }
        }

        public void EditInfo(int? data)
        {
            Console.WriteLine("Введите возраст");
            data = Convert.ToInt32(Console.ReadLine());
            Age = data;
        }
        public void EditInfo(string? data)
        {
            if (data == Name)
            {
                Console.WriteLine("Введите имя");
                Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Введите должность");
                Post = Console.ReadLine();
            }
        }

        public void EditInfo()
        {
            Console.WriteLine("1 - Присутствует");
            Console.WriteLine("2 - Отсутствует");
            string key = Console.ReadLine();
            switch (key)
            {
                case "1":

                    Appeared = true;
                    break;
                case "2":
                    Appeared = false;
                    break;
                default:
                    Console.WriteLine("Неверная команда");
                    break;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} | Ahe: {Age} | Post: {Post} | Appearance: {Appeared} \n";
        }
    }
}
