using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace alg
{
    internal class Program
    {
        static void Main()
        {
            1

            Console.WriteLine("Введите фамилию: ");
            string fam = Console.ReadLine();
            Console.WriteLine("Введите оценку: ");
            string mark = Console.ReadLine();

            Console.WriteLine($"Поздравляю, {fam}! У Вас автоматом {mark} за экзамен.");


            2
            Console.WriteLine("Введите количество чисел: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            int[] ints = new int[Num];

            float sum = 0;
            int test;

            for (int i = 0; i < Num; i++)
            {
                Console.WriteLine($"Введите число номер {1 + i}");
                test = Convert.ToInt32(Console.ReadLine());
                ints[i] = test;
                sum += Convert.ToSingle(test);
            }

            Console.WriteLine($"среднее значение {sum / Num} округление {Math.Round(sum / Num)} в меньшую {Math.Floor(sum / Num)}");


            3


            bool cheakNum = false;
            bool cheakZagl = false;
            bool cheakProp = false;
            bool cheakSpecSym = false;



            while (true)
            {
                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();
                for (int i = 0; i < password.Length; i++)
                {

                    if (char.IsDigit(password[i]))
                    {
                        cheakNum = true;
                    }
                    if (char.IsUpper(password[i]))
                    {
                        cheakZagl = true;
                    }
                    if (char.IsLower(password[i]))
                    {
                        cheakProp = true;
                    }
                    if (!char.IsLetterOrDigit(password[i]))
                    {
                        cheakSpecSym = true;
                    }

                }
                if (password.Length < 8 || password.Length > 20)
                {
                    Console.WriteLine("Пароль от 8 до 20");
                }
                else if (!cheakNum)
                {
                    Console.WriteLine("В пароле должны быть числа");
                }
                else if (!cheakZagl)
                {
                    Console.WriteLine("В пароле должны быть заглавные буквы");
                }
                else if (!cheakProp)
                {
                    Console.WriteLine("В пароле должны быть прописные буквы");
                }
                else if (!cheakSpecSym)
                {
                    Console.WriteLine("В пароле должны быть спецсимволы");
                }
                else
                {
                    Console.WriteLine("пароль подходит");
                    break;
                }

            }


            4
            var random = new Random();
            int score = 0;

            for (int i = 0; i < 3; i++)
            {


                int a = random.Next(1, 24);
                int b = random.Next(1, 24);
                int c = random.Next(1, 24);

                //Console.WriteLine($"{a} {b} {c}");

                Console.WriteLine($"Введите число номер {1 + i}: ");
                int nums = Convert.ToInt32(Console.ReadLine());

                if (nums == a || nums == b || nums == c)
                {
                    score += 1;
                }




            }
            if (score >= 2)
            {
                Console.WriteLine("Вы победили ");
            }
            else
            {
                Console.WriteLine("Вы проиграли");
            }

            5
            Random random = new Random();
            DateTime rod = DateTime.Now.Date.AddDays(random.Next(-7, 1));
            double price = random.Next(10, 200);
            int srokGodn = random.Next(1, 7);

            Console.WriteLine($"дата изготовления: {rod}, цена: {price} руб., срок: {srokGodn} дня");

            if (rod == DateTime.Now.Date)
            {

            }
            else if (rod.AddDays(srokGodn) > DateTime.Now.Date)
            {
                price *= 0.8;
            }
            else
            {
                price = 0;
            }
            Console.WriteLine(price);



            6

            var person_dict = new Dictionary<string, List<object>>()
            {
                { "person_id", new List<object>() {41, 84, 72 } },
                { "person_name",  new List<object>(){"Keanu Reeves", "Jim Carrey", "Негр"} }
            };
            var travel_log = new Dictionary<string, List<object>>()
            {
                { "travel_id", new List<object>() { 101, 102, 105 } },
                { "person_id", new List<object>() { 41, 72, 41 } },
                { "country", new List<object>() { "USA", "Japan", "China" } }
            };

            Console.WriteLine("Кто вам интересен: ");
            string name = Console.ReadLine();

            int cheak = 0;
            int cheakCoutry = 0;

            for (int i = 0; i < person_dict["person_name"].Count; i++)
            {
                if (name == Convert.ToString(person_dict["person_name"][i]))
                {
                    for (int j = 0; j < travel_log["person_id"].Count; j++)
                    {
                        if (Convert.ToInt32(person_dict["person_id"][i]) == Convert.ToInt32(travel_log["person_id"][j]))
                        {
                            cheakCoutry = j;
                            cheak++;
                        }

                    }
                }
            }
            if (cheak == 2)
            {
                Console.WriteLine("Several");
            }
            else if (cheak == 1)
            {
                Console.WriteLine(travel_log["country"][cheakCoutry]);
            }
            else
            {
                Console.WriteLine("None");
            }
            7

            Random random = new Random();
            List<object> MarksMask = new List<object> { "Б", "П", "Н", 2, 3, 4, 5 };
            List<DateTime> dateMarks = new List<DateTime> { };
            List<object> Marks = new List<object> { };

            for (int i = 0; i < 11; i++)
            {
                Marks.Add(MarksMask[random.Next(MarksMask.Count)]);
                dateMarks.Add(DateTime.Now.AddDays(i).Date);


            }
            for (int j = 0; j < Marks.Count; j++)
            {
                Console.WriteLine($"{Marks[j]}|| {dateMarks[j]}");
            }

            Console.WriteLine("");
            int NumB = 0;
            for (int c = 0; c < Marks.Count; c++)
            {
                if (Convert.ToString(Marks[c]) == "Б" && dateMarks[c].Month == DateTime.Now.Month)
                {
                    NumB++;
                    Console.WriteLine(dateMarks[c]);
                }

            }
            Console.WriteLine($"Количество пропусков по болезни в этом месяце {NumB}");

            8
                var student = new Student();
            student.SetStudent("Островский", "Bc-21", "2023");
            student.Print(student);
            student.GenerateMarks();
            student.PrintMarks();

            var student2 = new Student();
            student2.SetStudent("Ytuhs", "Bc-21", "2023");
            student2.Print(student2);
            student2.GenerateMarks();
            student2.PrintMarks();
            var group = new Group();
            group.SetGroup("Ис-21");
            group.AddStudents(student);
            group.AddStudents(student2);
            group.PrintAllStudINGoup(group);




        }
        class Student
        {
            public List<object> marks = new List<object> { };
            public List<object> dateMarks = new List<object> { };
            public List<object> randomMaks = new List<object> { "б", "п", "н", 2, 3, 4, 5 };
            public string fio;
            public string year_of_admission;
            public string group;

            public void SetStudent(string name, string year_of_admission, string group)
            {

                this.fio = name;
                this.group = group;
                this.year_of_admission = year_of_admission;



            }
            public void Print(Student student)
            {
                Console.WriteLine(student.fio);
                Console.WriteLine(student.year_of_admission);
                Console.WriteLine(student.group);
            }
            public void GenerateMarks()
            {
                Random random = new Random();
                for (int i = 0; i < 11; i++)
                {
                    this.marks.Add(this.randomMaks[random.Next(this.randomMaks.Count)]);
                    this.dateMarks.Add(DateTime.Now.AddDays(i).Date);

                }
            }
            public void PrintMarks()
            {
                for (int j = 0; j < this.marks.Count; j++)
                {
                    Console.WriteLine($"Оценка ученика {this.fio} :{this.marks[j]} || {this.dateMarks[j]}");
                }
            }

        }
        class Group
        {
            public string name;
            public List<Student> students = new List<Student> { };

            public void SetGroup(string name)
            {
                this.name = name;
            }

            public void AddStudents(Student student)
            {
                this.students.Add(student);
            }

            public void PrintAllStudINGoup(Group group)
            {
                for (int a = 0; a < group.students.Count; a++)
                {
                    Console.WriteLine($"Группа {group.name} Студент {group.students[a].fio}");
                }
            }
        }
    }
}
