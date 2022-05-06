using System;

namespace homework8_MainPrintFile
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num;
            do
            {
                Console.WriteLine("1.Excel");
                Console.WriteLine("2.PDF");
                Console.WriteLine("3.Word");
                Console.WriteLine("********************");
                Console.Write("Select:");
                num = Convert.ToByte(Console.ReadLine());
            } while (num>3);


            if (num==1)
            {
                MainPrintFile mainPrintFile = new Excel();

                Excel excel = mainPrintFile as Excel;

                if (mainPrintFile != null)
                {
                    excel.getInfo();
                    excel.Print();
                }
            }

            else if (num==2)
            {
                MainPrintFile mainPrintFile = new PDF();

                PDF pDF = mainPrintFile as PDF ;

                if (mainPrintFile != null)
                {
                    pDF.getInfo();
                }
            }

            else
            {
                MainPrintFile mainPrintFile = new Word();

                Word word = mainPrintFile as Word;

                if (mainPrintFile != null)
                {
                    word.getInfo();
                    word.Print();
                }
            }
        }
    }
}
