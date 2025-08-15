namespace CS_Examination_System;

public class McqQuestion : Question
{
    public McqQuestion()
    {
        Header = "Multiple Choice Question";
    }
    public override void SetAnswers()
    {
        Answers = new Answers[3];
        for (int i = 1; i < 4; i++)
        {
            Console.Write($"Enter answer {i}: ");
            var answerText = Console.ReadLine();
            if (string.IsNullOrEmpty(answerText))
            {
                Console.WriteLine("Invalid Empty Answer!.");
                i--;
                continue;
            }
            Answers[i - 1] = new Answers(i, answerText);
        }
    }
    public override void SetRightAnswer()
    {
        Console.WriteLine("Enter the right answer Id:  (1 , 2 or 3)");
        bool validInput = int.TryParse(Console.ReadLine(), out int Id);
        if (validInput && Id >= 1 && Id <= 3) 
            RightAnswerId = Id;
        else
        {
            Console.WriteLine("Invalid answer Id.");
            this.SetRightAnswer();
        }
    }
}






