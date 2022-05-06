using System;
namespace homework8_MainPrintFile
{
    class Excel : MainPrintFile,IPrintable
    {
        public override void getInfo()
        {
            Console.WriteLine("Excel cap edildi");
        }

        public void Print()
        {
            Console.WriteLine("It is a spreadsheet program from Microsoft");
        }
    }
}
