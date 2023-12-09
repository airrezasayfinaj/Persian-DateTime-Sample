
using System;
using System.Globalization;

namespace somepractice
{
    class Program
    {
        static void Main(string[] args)
        {


            //DateTime dt = new DateTime(2023, 5, 7);
            //int dayofweek = (int)dt.DayOfWeek;
            //Console.WriteLine(dayofweek);
            //DateTime adduday = dt.AddDays(69);
            //Console.WriteLine(dt);
            //Console.WriteLine(adduday);


            //Console.WriteLine("please enter year");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter month");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter day");
            //int day = int.Parse(Console.ReadLine());
            //var amirdate = new datetimeamir();
            //amirdate.Year = year;
            //amirdate.Month = month;
            //amirdate.Day = day;
            //Console.WriteLine(amirdate.Year + "/" + amirdate.Month + "/" + amirdate.Day);
            //Console.WriteLine(amirdate.equalsday);
            //Console.WriteLine("please add a day!");
            //int adddays = int.Parse(Console.ReadLine());
            //amirdate.Addday(adddays);         //amirdate.Addday(adddays);
            //Console.WriteLine(amirdate.Year + "/" + amirdate.Month + "/" + amirdate.Day);
            //Console.WriteLine("please add a Month!");
            //int addMonth = int.Parse(Console.ReadLine());
            //amirdate.AddMonth(addMonth);
            //Console.WriteLine(amirdate.Year + "/" + amirdate.Month + "/" + amirdate.Day);
            //Console.WriteLine("please add a year!");
            //int addyear = int.Parse(Console.ReadLine());
            //amirdate.Addyear(addyear);
            //Console.WriteLine(amirdate.Year + "/" + amirdate.Month + "/" + amirdate.Day);
            //Console.WriteLine("please enter year");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter month");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter day");
            //int day = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 365; i++)
            //{


            //    var amirdate = new datetimeamir();
            //    amirdate.Year = year;
            //    amirdate.Month = month;
            //    amirdate.Day = day;
            //    amirdate.Addday(i);

            //    Console.WriteLine(day.ToString(), month.ToString(), year.ToString());
            //    Console.WriteLine("//////////////////////////////////////////////////////////////////////");
            //}

            //   var amirdate = new datetimeamir(1400,2,10);

            //var amirdate1 = new datetimeamir(1300, 5, 24);
            //Console.WriteLine("year");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine("month");

            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("day");

            //int day = int.Parse(Console.ReadLine());
            //datetimeamir amir=new datetimeamir(year,month,day);
            //amir.Year = year;
            //amir.Month = month;
            //amir.Day = day;

            //Console.WriteLine(amir.ConvertShamsi());
            //Console.ReadLine();

            /////////////////////////////////////////////////////////////////////////////
            //for (int i = 1; i < 20; i++)
            //{
            //    PersianCalendar pc = new PersianCalendar();
            //    var amirdate = new datetimeamir();
            //    var GregorianDate = DateTime.Now.AddYears(i);
            //    amirdate.Year = pc.GetYear(GregorianDate);
            //    amirdate.Month = pc.GetMonth(GregorianDate);
            //    amirdate.Day = pc.GetDayOfMonth(GregorianDate);
            //    Console.WriteLine(pc.IsLeapYear(i)+"  pers  "+amirdate.Year.ToString()+"///"+ amirdate.IsLeapYear + "amirdate" + amirdate.Year);
            //    Console.WriteLine();
            //}

            //////////////////////////////////////////////////////////////////
            //    for (int i = 0; i < 3650000; i++)
            //    {
            //        PersianCalendar pc = new PersianCalendar();
            //        var GregorianDate = DateTime.Now.AddDays(i);
            //        var amirdate = new datetimeamir();
            //        amirdate.Year = pc.GetYear(GregorianDate);
            //        amirdate.Month = pc.GetMonth(GregorianDate);
            //        amirdate.Day = pc.GetDayOfMonth(GregorianDate);

            // //   if(amirdate>=amirdate2)
            ////  if(string.Format("{0}/{1}/{2}", pc.GetYear(GregorianDate), pc.GetMonth(GregorianDate), pc.GetDayOfMonth(GregorianDate))!= string.Format("{0}/{1}/{2}", amirdate.Year, amirdate.Month, amirdate.Day))
            //     //   Console.WriteLine(string.Format("{0}/{1}/{2} = {3}/{4}/{5}  ", pc.GetYear(GregorianDate), pc.GetMonth(GregorianDate), pc.GetDayOfMonth(GregorianDate),amirdate.Year,amirdate.Month,amirdate.Day));
            //     if(  pc.IsLeapYear(pc.GetYear(GregorianDate)) != amirdate.IsLeapYear)
            //           Console.WriteLine(amirdate.Year);
            //}

            //Console.WriteLine("Done");

            //Console.WriteLine("please enter year");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter month");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter day");
            //int day = int.Parse(Console.ReadLine());
            datetimeamir amirdate = new datetimeamir();
            //amirdate.Year = year;
            //amirdate.Month = month;
            //amirdate.Day = day;

            //amirdate.Second=12;
            //amirdate.AddSecond(39502);
            //Console.WriteLine(amirdate.Year.ToString(),amirdate.Month.ToString(),amirdate.Day.ToString(),amirdate.Ticks);
          //  Console.WriteLine(amirdate.Now);

            Console.WriteLine(amirdate.Second);

            Console.ReadLine();
        }
    }
}
