using System;

namespace Inheritance
{
	using System;
	using System.Linq;

	class Person
	{
		protected string firstName;
		protected string lastName;
		protected int id;

		public Person() { }
		public Person(string firstName, string lastName, int identification)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
		}
		public void printPerson()
		{
			Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
		}
	}

	class Student : Person
	{
		private int[] testScores;

		public Student(string name,string surname,int id_,int[] score) 
		{
			firstName = name;
			lastName = surname;
			id = id_;
			testScores = score;
			
		}

		public string Calculate()
        {
			int sum = testScores.Sum();
			int average = sum / testScores.Count();
			
			if (90 <= average && average <= 100)
				return "O";
			else if (80 <= average && average <= 90)
				return "E";
			else if (70 <= average && average <= 80)
				return "A";
			else if (55 <= average && average <= 70)
				return "P";
			else if (40 <= average && average <= 55)
				return "D";
            else
            { return "T"; }


			
        }
	}
	class Solution
	{
		static void Main()
		{
			string[] inputs = Console.ReadLine().Split();
			string firstName = inputs[0];//ad atama
			string lastName = inputs[1];//soyad atama
			int id = Convert.ToInt32(inputs[2]);//id atama
			int numScores = Convert.ToInt32(Console.ReadLine());//test sayısı atama
			inputs = Console.ReadLine().Split();//test puanları atama
			int[] scores = new int[numScores];//test puanlarının atanacagı liste
			for (int i = 0; i < numScores; i++)
			{
				scores[i] = Convert.ToInt32(inputs[i]);
			}//test puanlarını atama işlemi

			Student s = new Student(firstName, lastName, id, scores);
			s.printPerson();
			Console.WriteLine("Grade: " + s.Calculate() + "\n");
		}
	}
}
