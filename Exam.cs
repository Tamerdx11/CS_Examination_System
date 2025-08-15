namespace CS_Examination_System;

public abstract class Exam
{
    public int Time { get; set; }
    public int NumberOfQuestions { get; set; }
    protected List<Question> Questions { get; } = [];
    protected int Score { get; set; }

    public void SetTime()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int time) && time >= 30 && time <= 180)
            {
                Time = time;
                break;
            }
            Console.WriteLine("Invalid time!");
        }
    }

    public void SetNumberOfQuestions()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
            {
                NumberOfQuestions = num;
                break;
            }
            Console.WriteLine("Invalid number!");
        }
    }

    public void AddQuestion(Question question) => Questions.Add(question);

    protected int[] AskQuestionsAndGetAnswers()
    {
        int[] UserInputIds = new int[Questions.Count];
        Score = 0;
        for (int i = 0; i < Questions.Count; i++)
        {
            var q = Questions[i];
            Console.WriteLine($"\n{i + 1}) {q.Header}   (Mark: {q.Mark})");
            Console.WriteLine(q.Body);

            foreach (var ans in q.Answers)
                Console.WriteLine(ans);
            Console.Write("Please Enter Your Answer Id: ");
            int answerId = ReadValidAnswer();
            UserInputIds[i] = answerId;
            if (answerId == q.RightAnswerId)
                Score += q.Mark;
        }
        return UserInputIds;
    }
    public abstract void ShowExam();
    private static int ReadValidAnswer()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int ans) && ans >= 1 && ans <= 3)
                return ans;
            Console.WriteLine($"Invalid choice! Enter 1, 2 or 3");
        }
    }
}






