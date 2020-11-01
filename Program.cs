using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubledArrow
{
    class Program
    {
        static void Main(string[] args)
        {
            //LeftTopTriangle(13, '+');
            //RightTopTriangle(13, '+');
            LeftRightTopTriangle(13, '+');
            //BottomLeftTriangle(13, '+');
            //BottomRightTriangle(13, '+');
            LeftRightBotTriangle(13, '+');
        }

        static void LeftRightBotTriangle(int numberoflinesprinted, char symbol)
        {
            for (int i = 0; i < numberoflinesprinted; i++)  // "i" einai oi grammes pou ektupwnw (p.x i==0 prwth grammh)

            { if (i == 0 || i == 1 || i == 2)
                {
                          Console.WriteLine(XSpaces(i) + XSymbol(numberoflinesprinted - i, symbol) + "+++++++++++" + XSymbol(numberoflinesprinted - i, symbol) + XSpaces(i));
                }
                else
                {
                    Console.WriteLine(XSpaces(i) + XSymbol(numberoflinesprinted - i, symbol) + "           " + XSymbol(numberoflinesprinted - i, symbol) + XSpaces(i));
                }
                
            }
        }
        static void BottomLeftTriangle(int numberoflinesprinted, char symbol)  // "i" einai oi grammes pou ektupwnw (p.x i==0 prwth grammh)
        {
            for (int i = 1; i <= numberoflinesprinted; i++)
            {
                Console.WriteLine(XSpaces(i) + XSymbol(numberoflinesprinted - i, symbol));
            }
        }

        static void BottomRightTriangle(int numberoflinesprinted, char symbol)  // "i" einai oi grammes pou ektupwnw (p.x i==0 prwth grammh)
        {

            for (int i = 1; i <= numberoflinesprinted; i++)
            {
                Console.WriteLine(XSymbol(numberoflinesprinted - i, symbol) + XSpaces(i));
            }
        }
        static void LeftRightTopTriangle(int numberoflinesprinted, char symbol)  // "i" einai oi grammes pou ektupwnw (p.x i==0 prwth grammh)
        {
            for (int i = 0; i < numberoflinesprinted; i++)
            {
                if (i == numberoflinesprinted - 1 || i == numberoflinesprinted - 2)
                {
                    Console.WriteLine(XSpaces(numberoflinesprinted - i) + XSymbol(i, symbol) + "+++++++++++" + XSymbol(i, symbol) + XSpaces(numberoflinesprinted + i));

                }
                else
                {
                    Console.WriteLine(XSpaces(numberoflinesprinted - i) + XSymbol(i, symbol) + "           " + XSymbol(i, symbol) + XSpaces(numberoflinesprinted + i));
                }
            }
        }
        static void LeftTopTriangle(int numberoflinesprinted, char symbol)  // "i" einai oi grammes pou ektupwnw (p.x i==0 prwth grammh)
        {
 
            for (int i = 1; i <= numberoflinesprinted; i++)
            {
                Console.WriteLine(XSpaces(numberoflinesprinted - i) + XSymbol(i, symbol));
            }
        }
        static void RightTopTriangle(int numberoflinesprinted, char symbol)  // "i" einai oi grammes pou ektupwnw (p.x i==0 prwth grammh)
        {
            
            for (int i = 1; i <= numberoflinesprinted; i++)
            {
                Console.WriteLine(XSymbol(i, symbol)+XSpaces(numberoflinesprinted - i));
            }
        }

        static string XSymbol(int noOfSymbol, char symbol)  // "i" einai oi grammes pou ektupwnw (p.x i==0 prwth grammh)
        {
            string symbols = "";
            for (int i = 0; i < noOfSymbol; i++)
            {
                symbols += symbol;
            }
            return (symbols);
        }

        static string XSpaces(int noOfSpaces)  // "i" einai oi grammes pou ektupwnw (p.x i==0 prwth grammh)
        {
            string spaces = "";
            for (int i = 0; i < noOfSpaces; i++)
            {
                spaces += " ";
            }
            return (spaces);
        }
    }
}
