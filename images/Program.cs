using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro1
{
    class Program
    {
        static int Wronganswers(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == 0)
                    count++;
            return count;
        }
        static int Corranswers(int[] a)
        {
            static void vew(string[] a, int[] b, int[] c)
            {
                Console.WriteLine("Questions UserAnswers CorrectAnswers");
                Console.WriteLine("******************************")
                    for (int i = 0; i < a.Lenght; i++)
                    Console.WriteLine(a[i] + "        " + b[i] + "          " + c[i]);
            }
            static void Main(string[] args)
            {
                Random number = new Random();
                int qq, charnum, rend, symbnum, choice;
                char cr;
                string[] questions;
                char[] chars;
                char[] symbols;
                int[] correctanswers;
                int[] useranswers;
                int[] result;
                Console.WriteLine("please enter the maximum number of questions");
                qq = int.Parse(Console.ReadLine());
                questions = new string[qq];
                symbols = new char[qq];
                correctanswers = new int[qq];
                useranswers = new int[qq];
                result = new int[qq];
                Console.WriteLine("***************************************");
                for (int i = 1; i <= qq; i++)
                {

                    Console.WriteLine("Question:" + i);
                    Console.WriteLine("Please enter an integer value between 3 and 100 (the number of characters from which to enumerate certain sympol== degree of difficulty)");
                    charnum = int.Parse(Console.ReadLine());
                    for (int j = 0; j < charnum; j++)
                    {
                        Rand = number.Next(48, 123);
                        while ((Rand > 90 && Rand < 97) || (Rand > 57 && Rand < 65))
                            rand = number.next(48, 123);
                        ques += (char)rend;
                    }
                    symbnum = number.Next(0, ques, length);
                    cr = ques[symbunm];

                    questions[i - 1] = ques;
                    symbbols[i - 1] = cr;
                    Console.WriteLine("How many times the symbol" + cr + "has bees repaeted in the following characters");
                    Console.WriteLine(ques);
                    answer = Console.reedline();
                    if (answer == "loger")
                        useranswer[i - 1] = -1;
                    else
                        useranswer[i - 1] = int.Parse(answer);
                    chars = ques.TocharArray();
                    for (int k = 0; k chars.lenght; k++)
            {
                if (cr == cgars[k])
                    count++;
            }
            correctanswer[if-1]= count;
            if (count == uesranswer[if-1])
                    result[if-1]= 1;
            else
                Result[i - 1] = 0;
            count = 0;
            ques = "";

        }
        Console.WriteLine("***********************************");
          Console.WriteLine("To get the numbers of wrong answers, type 1\n To get the unmber of right answer ,type 2\n To view all the queations with correct and answer responses, type 3\nto exit type exit");
            Console.WriteLine("********************************")

            choice = Console.Readline()
            while(choice !="exit")
            {
            if (choice=="1")
            Console.Writeline("The number of worng answers is :"+ worganswers(Result));
        else 
        if(choice=="2")
            Console.Writeline("The number of right answers is :"+ worganswers(Result));
        else
        if (choice =="3")
            vew(questione , useranswers, correctanswers);
        Console.writeline("************************************");
            console.writeline("To get the numbers of wrong answers, type 1\n To get the unmber of right answer ,type 2\n To view all the queations with correct and answer responses, type 3\nto exit type exit");
            Console.WriteLine("********************************");
            choice = Console.readline();
            
            }

    }
}
