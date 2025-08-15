namespace CS_Examination_System;

public class Answers(int id, string text)
{
    public int Id { get; set; } = id;
    public string Text { get; set; } = text;
    override public string ToString() => $"{Id}. {Text}";
}






