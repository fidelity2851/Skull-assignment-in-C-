using System;
					
public class Program
{
	public static void Main()
	{
		// Get Number of Student from User
		Console.WriteLine("Enter Number of Students");
		int student_number = Convert.ToInt32(Console.ReadLine());
		
		// Allocate this array of n of Student
		int[] student_age = new int[student_number];
		
		int sum = 0;
		int i = 0;
		while (i < student_number) 
		{
			// Store student ages in an Array
			Console.WriteLine("\nEnter Age of Student Number " + (i + 1));
			student_age[i] = Convert.ToInt32(Console.ReadLine());
			
			// Calculating the sum of the students age
			sum += student_age[i];
			
			// Iterate the couter
			i++;
		}
		
		// Calculate the Avarage Age of the Students
		int avarage = sum / student_age.Length;
		
		Console.WriteLine("\nThe Average Age of Students is : " + avarage);
		
	}
}