using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_C__2026
{
    public class Teacher : Person, ISpeaker
    {
        public string Major;
        public string AcademicRank;

        public Teacher(string firstName, string lastName, string phone, string email,
                       string major, string academicRank)
            : base(firstName, lastName, phone, email)
        {
            Major = major;
            AcademicRank = academicRank;
        }

        public void Train()
        {
            Console.WriteLine($"teacher {FirstName} Currently undergoing training.");
        }

        public void Approve(Person p)
        {
            Console.WriteLine($"teacher{FirstName} The result has been approved. {p.FirstName}");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"branch: {Major}");
            Console.WriteLine($"rank: {AcademicRank}");
            Console.WriteLine("---------------------");
        }
    }
}