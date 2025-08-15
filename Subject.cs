using System.Diagnostics;


namespace CS_Examination_System;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public Exam Exam { get; set; } = default!;

    private void SetExamType()
    {
        bool validInput = int.TryParse(Console.ReadLine(), out int examType);
        if (validInput && (examType == 1 || examType == 2))
        {
            if (examType == 1)
                Exam = new PracticalExam();
            else
                Exam = new FinalExam();
        }
        else
        {
            Console.WriteLine("Invalid Exam Type!.");
            SetExamType();
        }
    }
    private static int SetQuestionType()
    {
        bool validInput = int.TryParse(Console.ReadLine(), out int questionType);
        if (validInput && (questionType == 1 || questionType == 2))
            return questionType;
        else
        {
            Console.WriteLine("Invalid Question Type!.");
            return SetQuestionType();
        }
    }
    public void CreateExam()
    {
        Console.WriteLine("Please Enter The Type Of Exam (1 for Practical | 2 for Final)");
        SetExamType();

        Console.WriteLine("Please Enter The Time For Exam (30 min To 180 min)");
        Exam.SetTime();

        Console.Write("Please Enter Number Of Questions: ");
        Exam.SetNumberOfQuestions();
        Console.Clear();

        for (int i = 1; i <= Exam.NumberOfQuestions; i++)
        {
            Question question; 
            if (Exam is  FinalExam final)
            {
                Console.WriteLine($"Please Enter The Type Of Question {i} (1 For [MCQ] | 2 For [True/False])");
                int num = SetQuestionType();
                if (num == 1)
                    question = new McqQuestion();
                else
                    question = new TrueFalseQuestion();
                question.CreateQuestion();
                final.AddQuestion(question);
            }
            else if(Exam is PracticalExam practical)
            {
                question = new McqQuestion();
                question.CreateQuestion();
                practical.AddQuestion(question);
            }
            Console.Clear();
        }

        Console.WriteLine("Do You Want To start Exam? (Y/N)");
        if (Console.ReadLine()?.Trim().ToUpper() == "Y")
            StartExam();
    }
    public void StartExam()
    {
        Console.Clear();
        Stopwatch stopwatch = new();
        stopwatch.Start();
        Exam.ShowExam();
        stopwatch.Stop();
        Console.WriteLine($"Time taken for Exam: {stopwatch}");
        Console.WriteLine("Thank You! :)");
    }
}






