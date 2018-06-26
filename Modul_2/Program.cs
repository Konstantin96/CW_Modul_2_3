using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modul_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nz;
            do
            {
                Console.Write("Введите номер задания(666 exit): ");
                nz = Int32.Parse(Console.ReadLine());
                if (nz == 1)
                    task1();
                else if (nz == 2)
                    task2();
                else if (nz == 3)
                    task3();
                else if (nz == 4)
                    task4();
                else if (nz == 5)
                    task5();
                else if (nz == 6)
                    task6();
                else if (nz == 7)
                    task7();
                else if (nz == 666)
                    Console.WriteLine("Bye");
                else
                {
                    Console.WriteLine("Такого задания нет!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            } while (nz != 666);
        }
        static void task1()
        {
            /*13.	Дано натуральное число n (1<= n <= 1188), определяющее возраст человека (в месяцах).
            *  Выразить возраст в годах и месяцах, например, 21 год 10 месяцев, 52 года 1 месяц, 46 лет ровно и т. п*/
            Console.Clear();
            int y = 0;
            Console.Write("Введите год рождения: ");
            while (!int.TryParse(Console.ReadLine(), out y))
                Console.Write("Введите корректный год рождения: ");
            int m = 0;
            Console.Write("Введите месяц рождения: ");
            while (!int.TryParse(Console.ReadLine(), out m))
                Console.Write("Введите корректный месяц рождения: ");
            int d = 0;
            Console.Write("Введите день рождения: ");
            while (!int.TryParse(Console.ReadLine(), out d))
                Console.Write("Введите корректный день рождения: ");
            DateTime dob = new DateTime(y, m, d);
            DateTime now = DateTime.Now;

            double difY = (now.Year - dob.Year);
            double difM = (now.Month - dob.Month);
            double difD = (now.Day - dob.Day);

            Console.WriteLine("{0} год {1} месяцев {2} дней", difY, difM, difD);

            Console.Write("Ввелдите кол-во месяцев: ");
            int cm = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddMonths(-cm));
        }

        static void task2()
        {
            /*9.	Дата некоторого дня характеризуется двумя натуральными числами: m (порядковый номер месяца) и n (число). По заданным n и m определить:
a.	дату предыдущего дня (принять, что n и m не характеризуют 1 января);
b.	дату следующего дня (принять, что n и m не характеризуют 31 декабря).*/
            int m = 1;
            Console.Write("Введите порядковый номер месяца: ");
            while (!int.TryParse(Console.ReadLine(), out m))
                Console.Write("Введите корректный порядковый номер месяца: ");
            int n = 1;
            Console.Write("Введите число: ");
            while (!int.TryParse(Console.ReadLine(), out n))
                Console.Write("Введите корректное число: ");
            DateTime D = new DateTime(DateTime.Now.Year, m, n);
            Console.WriteLine("Предыдущий день " + D.AddDays(-1));
            Console.WriteLine("Следующий день " + D.AddDays(1));
        }

        static void task3(int n = 1)
        {
            /*8.	С начала 1990 года по некоторый день прошло n месяцев и 2 дня. Определить название месяца (январь, февраль и т. п.) этого дня*/
            DateTime D = new DateTime(1990, 1, 1);
            D = D.AddDays(2).AddMonths(n);
            Console.WriteLine(D);
        }

        enum Weight
        {
            Light = 0,
            Pre_normal,
            normal
        }

        static void task4()
        {
            /*6.	Известен вес боксера-любителя. Известно, что вес таков, что боксер может быть отнесен к одной из трех весовых категорий: 
a.	легкий вес — до 60 кг; 
b.	первый полусредний вес — до 64 кг; 
c.	полусредний вес — до 69 кг. 
Определить, в какой категории будет выступать данный боксер*/
            Console.Write("Введите вес боксера: ");
            int ves = 0;
            while (!int.TryParse(Console.ReadLine(), out ves))
                Console.Write("Введите корректный вес боксера: ");
            if (ves <= 60)
            {
                Console.WriteLine((Weight)0);
            }
            else if (64 >= ves)
            {
                Console.WriteLine((Weight)1);
            }
            else if (69 >= ves)
            {
                Console.WriteLine((Weight)2);
            }
            else
            {
                Console.WriteLine("VERY HARD Weight !!!");
            }
        }

        static void task5()
        {
            string str = "test1";
            string str1 = string.Concat("1", "2", str);
            Console.WriteLine(str);
            if (str == "test")
            {

            }
            else if (str.CompareTo("fdf") == 0)
            {

            }
            else if (string.CompareOrdinal(str, "test") == 0)
            {

            }

        }

        static void task6()
        {
            string st = "8005-2694";

            int stpos = st.LastIndexOf("-");
            string[] strAR = st.Split('-');
            Console.WriteLine(strAR[0]);

        }

        static void task7()
        {
            string str = "{'Details':[{'GroupId':-479,'PriceGroup':5,'MakeLogo':'94','MakeName':'autoSFEC','DetailNum':'AK001876','NewDetailNum':null,'DetailNameRus':'Опора  амортизатора','PriceLogo':'LONS','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':50,'DDPercent':42.0,'ADDays':11,'DeliverTimeGuaranteed':11,'ResultPrice':456.070000},"
              + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'*Ч','MakeName':'Profit','DetailNum':'23140021','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТ. AUDI 100 AVANT 90-94 FRONT (L/R) БЕЗ','PriceLogo':'SMAR','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':2,'DDPercent':98.0,'ADDays':6,'DeliverTimeGuaranteed':6,'ResultPrice':474.360000},"
              + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'FB','MakeName':'FEBI','DetailNum':'01876','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'SMAR','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':3,'DDPercent':98.0,'ADDays':6,'DeliverTimeGuaranteed':6,'ResultPrice':484.390000},"
              + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'RU','MakeName':'Ruville','DetailNum':'825711','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'AMTS','DestinationLogo':'AFL','PriceCountry':'Москва','LotQuantity':1,'Quantity':1,'DDPercent':91.0,'ADDays':11,'DeliverTimeGuaranteed':11,'ResultPrice':1166.430000},"
              + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'RU','MakeName':'Ruville','DetailNum':'825711','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':85.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1319.830000},"
              + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'FB','MakeName':'FEBI','DetailNum':'01366','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':75.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1702.740000},"
              + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'18','MakeName':'Vaico','DetailNum':'101209','NewDetailNum':null,'DetailNameRus':'Опора стойки амортизатора','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':85.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':564.630000},"
              + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'ML','MakeName':'Meyle','DetailNum':'1004120007','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':29.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1204.780000},"
              + "{'GroupId':-479,'PriceGroup':5,'MakeLogo':'09','MakeName':'SWAG','DetailNum':'30540009','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':85.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1102.120000},"
              + "{'GroupId':-1220,'PriceGroup':5,'MakeLogo':'ML','MakeName':'Meyle','DetailNum':'1004120007','NewDetailNum':null,'DetailNameRus':'ОПОРА АМОРТИЗАТОРА','PriceLogo':'NALG','DestinationLogo':'CRG','PriceCountry':'Эмираты','LotQuantity':1,'Quantity':0,'DDPercent':29.0,'ADDays':109,'DeliverTimeGuaranteed':109,'ResultPrice':1204.780000}"
              + "],'IsSuccess':true,'ErrorMessage':null,'BlockDateEnd':null}";
            str = str.Substring(str.IndexOf('[') + 1, str.IndexOf(']') - str.IndexOf('[') - 1);
            Console.Write("Введите номер детали: ");
            string numdetail = Console.ReadLine();
            string[] Data = str.TrimEnd('}').Split('}');
            for (int i = 0; i < Data.Length; i++)
            {
                string[] Data2 = Data[i].Split(',');
                Console.WriteLine(Data2[4].Trim('\'').Replace("':'",":"));
            }
        


        }
    }
}
