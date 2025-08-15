namespace CS_Examination_System;

public class TrueFalseQuestion : Question
{
    public TrueFalseQuestion()
    {
        Header = "True/False Question";
    }
    public override void SetAnswers()
    {
        Answers =
        [
            new(1, "True"),
            new(2, "False")
        ];
    }
    public override void SetRightAnswer()
    {
        Console.WriteLine("Enter the right answer Id:  (1 for True | 2 for False)");
        bool validInput = int.TryParse(Console.ReadLine(), out int Id);
        if (validInput && (Id == 1 || Id == 2))
            RightAnswerId = Id;
        else
        {
            Console.WriteLine("Invalid answer Id!.");
            SetRightAnswer();
        }

    }
}






