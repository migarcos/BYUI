using System;
class Program
{
    static void Main(string[] args)
    {
        Assignment task01 = new Assignment();
        Console.WriteLine(task01.GetSummary());

        Assignment task02 = new Assignment("Pedro","Canto del gallo");
        Console.WriteLine(task02.GetSummary());

        Assignment task03 = new Assignment();
        task03.setAssignment("Judas","30 monedas");
        Console.WriteLine(task03.GetSummary());

        MathAssignment task04 = new MathAssignment();
        Console.WriteLine(task04.GetHomeworkList());

        MathAssignment task05 = new MathAssignment("AAAA","BBBB","CCCC","DDDD");
        Console.WriteLine(task05.GetHomeworkList());

        WritingAssignment task06 = new WritingAssignment();
        Console.WriteLine(task06.GetWritingInformation());

        WritingAssignment task07 = new WritingAssignment("EEEE", "FFFF", "GGGG");
        Console.WriteLine(task07.GetWritingInformation());
    }
}