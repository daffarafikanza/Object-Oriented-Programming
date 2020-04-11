using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person("Muhammad Daffa", 19);
			person.GetNameAndAge();

			Teacher teacher = new Teacher("Rafikanza", 30, "191128", "Math");
			teacher.GetNameAndAge();

			Student student = new Student("Noor", 19, "2832", "muhammad.2826@students.amikom.ac.id");
			student.GetNameAndAge();

			Console.ReadKey();
		}
	}
}