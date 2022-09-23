/*引用命名空间*/
// 为了区分不同的项目依赖，防止命名冲突
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo
{
    class Program
    {
        //函数 程序主入口
        static void Main(string[] args) { 
            // 打印输出
            Console.WriteLine("hello world");
            // 读取键盘输入 暂停当前程序执行
            Console.ReadKey();
            int a = 3;
            double b = 3.14;
            string name = "jerry";
            char s = 's';
            // char bb = ''; 字符类型不能存储空值
            decimal money = 5000m;
            float fff = 2131.32F;
            // 挖了几个坑就需要填几个坑 多写没效果 少写报错
            Console.WriteLine("hello world {0},{1},{2},{3}",a,b,name,s);
        }
    }
}