using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setup
{
    class Program
    {
        static void Main(string[] args)
        {
            int userPass = 0;
            char u1 = '0';
            while (true)
            {
                Console.WriteLine("安装windows服务请输入 1 ,卸载windows服务请输入 2.");
                userPass = Console.Read();

                  u1 = ((char)userPass);
                  
                if (u1 == '1' || u1 == '2')
                {
                    break ;
                }
            } 

            windowsServer w = new windowsServer();
            w.run(u1);


            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("执行完成,执行结果,请看上面日志.");
            while (true)
            {
                Console.ReadLine();
            }
        }
    }
}
