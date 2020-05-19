using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook
{
    class Program
    {
        

        static void Main(string[] args)
        {
            MyBook myBook = new MyBook();
            myBook.Name = "PHP 프로그래밍 입문";
            myBook.Issue_date = "2013년5월20일";
            myBook.Author = "황재호";
            myBook.Publisher = "김태헌";
            myBook.Publish_place = "한빛이카데이(주)";
            myBook.Dutyedit = "김현용";
            myBook.Plan = "김이화";
            myBook.Edit = "김이화";
            myBook.Design = "여동일";

            Console.WriteLine("이름 : " + myBook.Name);
            Console.WriteLine("초판 발행 : " + myBook.Issue_date);
            Console.WriteLine("지은이 : " + myBook.Author);
            Console.WriteLine("펴낸이 : " + myBook.Publisher);
            Console.WriteLine("펴낸곳 : " + myBook.Publish_place);
            Console.WriteLine("책임편집 : " + myBook.Dutyedit);
            Console.WriteLine("기획 : " + myBook.Plan);
            Console.WriteLine("편집 : " + myBook.Edit);
            Console.WriteLine("디자인 : " + myBook.Design);

        }
    }
}
