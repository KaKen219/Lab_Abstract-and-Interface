using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_C__2026
{
    class Program
    {
        static void Main()
        {
            List<Person> participants = new List<Person>();

            Student s = new Student("Akkarapon", "Ouamin", "0623308720", "akkarapon.so@kkumail.com", "CS", "683450198-9");
            Teacher t = new Teacher("phat", "amin", "0822222222", "t@mail.com", "CS", "Assistant Professor.");
            GeneralPerson g = new GeneralPerson("Castorice", "Painon", "0833333333", "g@mail.com", "company ABC", "manager");

            participants.Add(s);
            participants.Add(t);
            participants.Add(g);

            Console.WriteLine("===== List of training participants=====");
            foreach (var p in participants)
            {
                p.ShowInfo();
                p.Register();
            }

            Console.WriteLine("\n===== Training =====");

            ISpeaker speaker1 = t;
            speaker1.Train();
            speaker1.Approve(s);
        }
    }
}