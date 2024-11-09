using System;
using System.Collections.Generic;
using System.Text;
using Challenge.DataContracts;

namespace ConsoleApp;

public class Solver
{
    public static string Solve(TaskResponse taskResponse)
    {
        var line = taskResponse.Question.TrimEnd(new char[] { '\r', '\n' }).Split('\n');
        return "";
    }

    public static string SolvePolynomialRoot(string uravnenie)
    {
        
    }
    
}
