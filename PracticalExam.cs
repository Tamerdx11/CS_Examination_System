namespace CS_Examination_System;

public class PracticalExam : Exam
{
    public override void ShowExam()
    {
        var _ = AskQuestionsAndGetAnswers();
        Console.Clear();
        int totalMarks = Questions.Sum(q => q.Mark);

        Console.WriteLine($"Practical Exam Completed! Your Grade is {Score} From {totalMarks}\nThe Exam Right Answers:");
        Console.WriteLine("\nReview:\n");
        foreach (var q in Questions)
        {
            Console.WriteLine($"Correct Answer: {q.Answers[q.RightAnswerId - 1]}");
            Console.WriteLine(new string('-', 50));
        }
    }
}






