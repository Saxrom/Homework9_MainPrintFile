using System;
namespace homework8_MainPrintFile
{
    class Word : MainPrintFile,IPrintable
    {
        public override void getInfo()
        {
            Console.WriteLine("Word cap edildi");
        }

        public void Print()
        {
            Console.WriteLine("It is a spreadsheet program from Microsoft");
        }
    }
}
