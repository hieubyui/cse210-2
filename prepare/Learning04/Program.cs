using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment();
        test.studentName = "Samuel Bennett";
        test.topic = "Multiplication";
        test.GetSummary();

        MathAssignment math = new MathAssignment();
        math.studentName = "Roberto Rodriguez";
        math.topic = "Fractions";
        math.textbookSection = "Section 7.3";
        math.problems = "8-19";
        math.GetSummary();
        math.GetHomeworkList();
    }
}