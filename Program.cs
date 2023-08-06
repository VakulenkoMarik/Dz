using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////////////////////
//                                    //
//        🞓🞓🞓         🞓🞓🞓🞓       //
//     🞓🞓     🞓     🞓      🞓     //
//   🞓              🞓        🞓   //
//  🞓               🞓        🞓  //
//  🞓                 🞓🞓🞓🞓🞓🞓  \\
//  🞓        🞓🞓🞓            🞓   \\
//   🞓          🞓            🞓    \\
//     🞓🞓     🞓             🞓      \\
//       🞓🞓🞓🞓        🞓🞓🞓🞓         \\
//                                     \\
////////////////////////////////////////\\

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            If1();
            If2();
            If3();
            If4();
            If5();
            If6();
            If7();
            If8();
            If9();
            If10();
            If11();
            If12();
            If13();
            If14();
            If15();
            If16();
            If17();
            If18();
            If19();
            If20();
            If21();
            If22();
            If23();
            If24();
            If25();
            If26();
            If27();
            If28();
            If29();
            If30();
        }

        static void If1()
        {
            int numeric = 200;

            bool positive = numeric > 0;

            if (positive)
            {
                numeric++;
            }

            Console.WriteLine("If1");
            Console.WriteLine(numeric);
        }

        static void If2()
        {
            int numeric = -200;

            bool positive = numeric > 0;

            if (positive)
            {
                numeric++;
            }
            else
            {
                numeric = numeric - 2;
            }

            Console.WriteLine(" ");
            Console.WriteLine("If2");
            Console.WriteLine(numeric);
        }

        static void If3()
        {
            int numeric = 0;

            bool positive = numeric > 0;

            if (positive)
            {
                numeric++;
            }
            else if (numeric < 0)
            {
                numeric = numeric - 2;
            }
            else if (numeric == 0)
            {
                numeric = 10;
            }

            Console.WriteLine(" ");
            Console.WriteLine("If3");
            Console.WriteLine(numeric);
        }

        static void If4()
        {
            int answer = 0;

            int numeric1 = 3;
            int numeric2 = 8;
            int numeric3 = 9;

            if (numeric1 > 0)
            {
                answer++;
            }

            if (numeric2 > 0)
            {
                answer++;
            }

            if (numeric3 > 0)
            {
                answer++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("If4");
            Console.WriteLine(answer);
        }

        static void If5()
        {
            int positive = 0;
            int negative = 0;

            int numeric1 = 3;
            int numeric2 = -8;
            int numeric3 = 9;

            if (numeric1 > 0)
            {
                positive++;
            }
            else
            {
                negative++;
            }

            if (numeric2 > 0)
            {
                positive++;
            }
            else
            {
                negative++;
            }

            if (numeric3 > 0)
            {
                positive++;
            }
            else
            {
                negative++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("If5");
            Console.WriteLine("Позитивних = " + positive);
            Console.WriteLine("Негативних = " + negative);
        }

        static void If6()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If6");

            int A = 3;
            int B = 5;

            if (A > B)
            {
                Console.WriteLine("A бiльша з них");
            }
            else if (B > A)
            {
                Console.WriteLine("B бiльша з них");
            }
            else if (B == A)
            {
                Console.WriteLine("Вони рiвнi");
            }
        }

        static void If7()
        {
            int A = 7;
            int B = 83;

            if (A > B)
            {
                Console.WriteLine("A більше за B");
            }
            else if (B > A)
            {
                Console.WriteLine("B більше за A");
            }
            else
            {
                Console.WriteLine("Вони рівні");
            }
        }

        static void If8()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If8");

            int A = 3;
            int B = 5;

            if (A > B)
            {
                Console.WriteLine(A);
                Console.WriteLine(B);
            }
            else if (B > A)
            {
                Console.WriteLine(B);
                Console.WriteLine(A);
            }
            else if (B == A)
            {
                Console.WriteLine(A + ", " + B);
            }
        }

        static void If9()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If9");

            double A = 66.3;
            double B = 8.2;

            double isTrue = A - 0.1;

            if (A > B)
            {
                A = isTrue;
                return;
            }
            Console.WriteLine(A);
            Console.WriteLine(B);
        }

        static void If10()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If10");

            int A = 3;
            int B = 3;

            int sum = A + B;

            if (A != B)
            {
                A = sum;
                B = sum;
            }
            else if (A == B)
            {
                A = 0;
                B = 0;
            }

            Console.WriteLine(A + ", " + B);
        }

        static void If11()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If10");

            int A = 3;
            int B = 3;

            int sum = A + B;

            if (A != B)
            {
                A = sum;
                B = sum;
            }
            else if (A == B)
            {
                A = 0;
                B = 0;
            }

            Console.WriteLine(A + ", " + B);
        }

        static void If12()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If12");

            int A = 3;
            int B = 5;
            int C = 7;

            if (A < B && A < C)
            {
                Console.WriteLine("A найменше число");
            }
            else if (B < A && B < C)
            {
                Console.WriteLine("B найменше число");
            }
            else if (C < A && C < B)
            {
                Console.WriteLine("C найменше число");
            }
            else
            {
                Console.WriteLine("Вони рiвнi");
            }
        }

        static void If13()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If13");

            int A = 3;
            int B = 5;
            int C = 7;

            if (A > B && A < C || A < B && A > C)
            {
                Console.WriteLine("A середнє");
            }
            else if (B > A && B < C || B < A && B > C)
            {
                Console.WriteLine("B середнє");
            }
            else if (C > A && C < B || C < A && C > B)
            {
                Console.WriteLine("C середнє");
            }
            else
            {
                Console.WriteLine("Вони рiвнi");
            }
        }

        static void If14()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If14");

            int A = 3;
            int B = 5;
            int C = 7;

            if (A > B && A > C)
            {
                if (B > C)
                {
                    Console.WriteLine(C);
                    Console.WriteLine(A);
                }
                if (C > B)
                {
                    Console.WriteLine(B);
                    Console.WriteLine(A);
                }
            }
            else if (B > A && B > C)
            {
                if (A > C)
                {
                    Console.WriteLine(C);
                    Console.WriteLine(B);
                }
                if (C > A)
                {
                    Console.WriteLine(A);
                    Console.WriteLine(B);
                }
            }
            else if (C > A && C > B)
            {
                if (A > B)
                {
                    Console.WriteLine(B);
                    Console.WriteLine(C);
                }
                if (B > A)
                {
                    Console.WriteLine(A);
                    Console.WriteLine(C);
                }
            }
            else
            {
                Console.WriteLine("В завданні присутня рівність");
            }
        }

        static void If15()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If15");

            int A = 3;
            int B = 5;
            int C = 7;

            int sumAB = A + B;
            int sumAC = A + C;
            int sumBC = B + C;

            if (A > B && A > C)
            {
                if (B > C)
                {
                    Console.WriteLine(sumAB);
                }
                if (C > B)
                {
                    Console.WriteLine(sumAC);
                }
            }
            else if (B > A && B > C)
            {
                if (A > C)
                {
                    Console.WriteLine(sumAB);
                }
                if (C > A)
                {
                    Console.WriteLine(sumAC);
                }
            }
            else if (C > A && C > B)
            {
                if (A > B)
                {
                    Console.WriteLine(sumAC);
                }
                if (B > A)
                {
                    Console.WriteLine(sumBC);
                }
            }
            else
            {
                Console.WriteLine("В завданні присутня рівність");
            }
        }

        static void If16()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If16");

            double A = 3.5;
            double B = 7.2;
            double C = 1.3;

            bool growth = A < B && B < C;

            if (growth)
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;
            }

            Console.WriteLine(A + ", " + B + ", " + C);
        }

        static void If17()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If16");

            double A = 3.5;
            double B = 7.2;
            double C = 1.3;

            bool growth = A < B && B < C;
            bool reduction = A > B && B > C;

            if (growth || reduction)
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;
            }

            Console.WriteLine(A + ", " + B + ", " + C);
        }

        static void If18()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If18");

            int A = 3;
            int B = 5;
            int C = 5;

            if (A == B)
            {
                if (B > C)
                {
                    Console.WriteLine("С менше за них");
                }
                if (C > B)
                {
                    Console.WriteLine("С більше за них");
                }
            }
            else if (A == C)
            {
                if (A > B)
                {
                    Console.WriteLine("B менше за них");
                }
                if (B > A)
                {
                    Console.WriteLine("B більше за них");
                }
            }
            else if (B == C)
            {
                if (B > A)
                {
                    Console.WriteLine("A менше за них");
                }
                if (B < A)
                {
                    Console.WriteLine("A більше за них");
                }
            }
            else
            {
                Console.WriteLine("В завданні присутня рівність");
            }
        }

        static void If19()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If19");

            int A = 3;
            int B = 5;
            int C = 5;
            int D = 5;

            if (A == B && A == C)
            {
                if (A > D)
                {
                    Console.WriteLine("D менше за них");
                }
                if (D > A)
                {
                    Console.WriteLine("D більше за них");
                }
            }
            else if (A == C && A == D)
            {
                if (A > B)
                {
                    Console.WriteLine("B менше за них");
                }
                if (B > A)
                {
                    Console.WriteLine("B більше за них");
                }
            }
            else if (B == C && B == D)
            {
                if (B > A)
                {
                    Console.WriteLine("A менше за них");
                }
                if (B < A)
                {
                    Console.WriteLine("A більше за них");
                }
            }
            else if (A == B && A == D)
            {
                if (A > C)
                {
                    Console.WriteLine("C менше за них");
                }
                if (C > A)
                {
                    Console.WriteLine("C більше за них");
                }
            }
            else
            {
                Console.WriteLine("В завданні присутня рівність");
            }
        }


        static void If20()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If20");

            int A = 3;
            int B = 5;
            int C = 6;

            int distanceAB = Math.Abs(A - B);
            int distanceAC = Math.Abs(A - C);

            if (distanceAB > distanceAC)
            {
                Console.WriteLine(B);
                Console.WriteLine(distanceAB);
            }
            else if (distanceAC > distanceAB)
            {
                Console.WriteLine(C);
                Console.WriteLine(distanceAC);
            }
            else if (B == C)
            {
                Console.WriteLine("Вони рiвнi");
            }
        }

        static void If21()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If21");

            int pointX = 7;
            int pointY = 8;

            if (pointX == 0 && pointY == 0)
            {
                Console.WriteLine("0");
            }
            else if (pointX == 0 && pointY != 0 )
            {
                Console.WriteLine("2");
            }
            else if (pointX != 0 && pointY == 0)
            {
                Console.WriteLine("1");
            }
            else if (pointX > 0 && pointY > 0)
            {
                Console.WriteLine("3");
            }
        }

        static void If22()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If22");

            int pointX = -6;
            int pointY = -3;

            if (pointX > 0 && pointY > 0)
            {
                Console.WriteLine("1 четверть");
            }
            else if (pointX < 0 && pointY > 0)
            {
                Console.WriteLine("2 четверть");
            }
            else if (pointX < 0 && pointY < 0)
            {
                Console.WriteLine("3 четверть");
            }
            else if (pointX > 0 && pointY < 0)
            {
                Console.WriteLine("4 четверть");
            }
        }

        static void If23()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If23");

            int Ax = 2;
            int Ay = 1;

            int Bx = 2;
            int By = 7;

            int Cx = 8;
            int Cy = 7;

            int Dx = 0;
            int Dy = 0;

            if (Ax == Bx)
            {
                Dy = Ay;
                Dx = Cx;
            }
            else if (Ay == By)
            {
                Dy = Cy;
                Dx = Ax;
            }
        }

        static void If24()
        {

        }

        static void If25()
        {

        }

        static void If26()
        {

        }

        static void If27()
        {

        }

        static void If28()
        {
            Console.WriteLine(" ");
            Console.WriteLine("If28");

            int year = 1500;

            int isTrue1 = year % 4;
            int isTrue2 = year % 100;
            int isTrue3 = year % 400;

            bool isTrue1a = isTrue1 == 0;
            bool isTrue2a = isTrue2 == 0 && isTrue3 != 0;

            if (isTrue1a)
            {
                if (isTrue2a)
                {
                    Console.WriteLine("Цей рік не є високосним");
                }
                else
                {
                    Console.WriteLine("Цей рік високосний");
                }
            }
        }
        static void If29()
        {
            int numeric = 534;

            bool evenNumber = numeric % 2 == 0;
            bool notEvenNumber = numeric % 2 > 0;

            bool positive = numeric > 0;
            bool negative = numeric < 0;
            bool zero = numeric == 0;

            if (evenNumber)
            {
                if (positive)
                {
                    Console.WriteLine("парне позитивне число");
                }
                else if (negative)
                {
                    Console.WriteLine("парне негативне число");
                }
            }
            else if (notEvenNumber)
            {
                if (positive)
                {
                    Console.WriteLine("непарне позитивне число");
                }
                else if (negative)
                {
                    Console.WriteLine("непарне негативне число");
                }
            }
            else if (zero)
            {
                Console.WriteLine("нульове число");
            }
        }

        static void If30()
        {
            int numeric = 534;

            bool evenNumber = numeric % 2 == 0;
            bool notEvenNumber = numeric % 2 > 0;

            bool unequivocal = numeric % 100 <= 9;
            bool ambiguous = numeric % 1000 <= 99 && numeric % 1000 > 9;
            bool threedigits = numeric % 10000 <= 999 && numeric % 10000 > 99;

            if (evenNumber)
            {
                if (unequivocal)
                {
                    Console.WriteLine("парне однозначне число");
                }
                else if (ambiguous)
                {
                    Console.WriteLine("парне двозначне число");
                }
                else if (threedigits)
                {
                    Console.WriteLine("парне тризначне число");
                }
            }
            else if (notEvenNumber)
            {
                if (unequivocal)
                {
                    Console.WriteLine("непарне однозначне число");
                }
                else if (ambiguous)
                {
                    Console.WriteLine("непарне двозначне число");
                }
                else if (threedigits)
                {
                    Console.WriteLine("непарне тризначне число");
                }
            }
        }
    }
}
