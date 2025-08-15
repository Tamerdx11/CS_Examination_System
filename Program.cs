namespace CS_Examination_System;

internal class Program
{
    static void Main()
    {
        Subject subject = new()
        {
            Id = 1,
            Name = "Computer Science"
        };

        subject.CreateExam();

        Console.ReadKey();

    }
}






