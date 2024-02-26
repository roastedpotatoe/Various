/*
Given a string and a pattern, find the starting indices of all occurrences of the pattern in the string. 
For example, given the string "abracadabra" and the pattern "abr", you should return [0, 7]
*/


using System;
using System.Diagnostics;


class Occurences
{
    public static string generatedString;

    public Occurences()
    {
        //generate a string
        Random rnd = new();
    
    for(int i=0; i<15;i++)
        {
            char letter =(char)('a' + rnd.Next(1,26));
            generatedString += letter;
        }
    }   

    public void ExecuteTask()
    {
        string[] args = {"true"};
        if(args[0]=="true")
        {
            Console.WriteLine("Enter a string");
            generatedString = Console.ReadLine();
        }

        Console.WriteLine("Use this string \"{0}\" to search for a occurences ", generatedString);
        string inputString = Console.ReadLine();
        List<int> occurence= findStringOccurence(inputString);
        Console.WriteLine("These are the occurences for your input: ");
        foreach(int i in occurence)
        {
            Console.Write(i+" ");
        }
    }

    private List<int> findStringOccurence(string inputString)
    {
        List<int> occuredStrings = new();
        //Iterate over the generated String, check for occurence of input string
        for(int i=0;i<=generatedString.Length; i++)
        {   
            string compareString ="";
            for(int j=0; j<inputString.Length;j++)
            {
                if(i+j<generatedString.Length)
                {
                    compareString += generatedString[i+j];
                }
            }

            if(compareString==inputString)
            {
                occuredStrings.Add(i);
            }
        }
        return occuredStrings;
    }
}