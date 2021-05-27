using System;

namespace T2009M.session4
{
    public class DemoDelegate
    {
        public DemoDelegate()
        {
            Program.ss += ShowMsg;
            Program.ss += SayHello;
        }

        public void SayHello(string s)
        {
            Console.WriteLine(s);
        }
        
        public static void ShowMsg(string msg) // ham tra ve void va tham so la 1 string
        {
            Console.WriteLine("Show msg: "+msg);
        }

        public void ShowInfo(string info) // ham tra ve void va tham so la 1 string
        {
            Console.WriteLine("Info: "+info);
        }
    }
}