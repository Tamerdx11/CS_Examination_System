namespace CS_Examination_System;

public class FinalExam : Exam
{
    public override void ShowExam()
    {
        var UserAnswers = AskQuestionsAndGetAnswers();
        Console.Clear();
        int totalMarks = Questions.Sum(q => q.Mark);

        Console.WriteLine($"Exam Completed! Your Grade is {Score} From {totalMarks}");
        Console.WriteLine("\nReview:\n");
        for (int i = 0; i < Questions.Count; i++)
        {
            Question? q = Questions[i];
            Console.WriteLine($"{q.Header}: {q.Body}");
            foreach (var ans in q.Answers)
                Console.WriteLine(ans);
            Console.WriteLine($"Your Answer: {q.Answers[UserAnswers[i] - 1]}");
            Console.WriteLine($"Correct Answer: {q.Answers[q.RightAnswerId - 1]}");
            Console.WriteLine(new string('-', 50));
        }
    }
}






