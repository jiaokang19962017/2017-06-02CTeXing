using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("张三", 16, "男");//构造函数
                                                 /*   p.Name = "张三";
                                                    p.Sex = "男";//属性
                                                    p.Age = 15;*/
            Console.WriteLine(p.Name + "," + p.Sex + "," + p.Age);
            //对象初始化器
            Person p1 = new Person { Name = "王五", Age = 18, Sex = "女" };

            Person[] array = { new Person { Name = "王五", Age = 18, Sex = "女" }, new Person("田七", 25, "女") };

            List<int> list = new List<int> { 5, 9, 10, 12, 6 };
            List<string> listr = new List<string>(new string[] { "1", "2", "3" });
            ArrayList arraylist = new ArrayList();

            List<Person> lsp = new List<Person>();
            lsp.Add(new Person("你好", 15, "男"));
            lsp.Add(new Person { Name = "焦康", Sex = "男", Age = 21 });

            List<Person> lsp1 = new List<Person>
            {
            new Person("张三",21,"女");
            new Person("张八", 21, "女");
            new Person
            {
                Name = "王八",
                Age = 16,
                Sex = "男"
            };
        }
      

    }
}

