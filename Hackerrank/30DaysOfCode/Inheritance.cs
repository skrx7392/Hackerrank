using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank._30DaysOfCode
{
    class Inheritance
    {
        static void inheritance(String[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = int.Parse(inputs[2]);
            int numScores = int.Parse(Console.ReadLine());
            inputs = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(inputs, int.Parse);
            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: {0}\n", s.calculate());
        }
    }

    class InheritancePerson
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public InheritancePerson() { }
        public InheritancePerson(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: {0}, {1}\nID: {2}", lastName, firstName, id);
        }
    }

    class Student : InheritancePerson
    {
        private int[] testScores;
        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = scores;
        }
        public char calculate()
        {
            double avg = 0;
            for(int i=0; i<testScores.Length; i++)
            {
                avg += testScores[i];
            }
            avg = avg / testScores.Length;
            if(avg<40)
            {
                return 'T';
            }
            if(avg<55)
            {
                return 'D';
            }
            if(avg<70)
            {
                return 'P';
            }
            if(avg<80)
            {
                return 'A';
            }
            if(avg<90)
            {
                return 'E';
            }
            return 'O';
        }
    }
}
