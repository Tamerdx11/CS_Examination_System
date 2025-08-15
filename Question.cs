namespace CS_Examination_System;

public abstract class Question
{
    internal protected string Header { get; set; } = default!;
    internal protected string Body { get; set; } = default!;
    internal protected int Mark { get; set; }
    internal protected Answers[] Answers { get; set; } = [];
    internal protected int RightAnswerId { get; set; }

    public void CreateQuestion()
    {
        this.SetBody();
        this.SetMark();
        this.SetAnswers();
        this.SetRightAnswer();
    }
    public void SetBody()
    {
        Console.Write("Enter Question Body: ");
        var body = Console.ReadLine();
        if (string.IsNullOrEmpty(body))
        {
            Console.WriteLine("Invalid Empty Question Body!.");
            this.SetBody();
        }
        else
            Body = body;
    }
    public void SetMark()
    {
        Console.Write("Enter Question Mark: ");
        if (int.TryParse(Console.ReadLine(), out int mark))
            Mark = mark;
        else
        {
            Console.WriteLine("Invald Numeric Value For Mark!.");
            this.SetMark();
        }
    }
    public abstract void SetAnswers();
    public abstract void SetRightAnswer();

}






