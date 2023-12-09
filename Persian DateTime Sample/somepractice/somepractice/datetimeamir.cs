using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace somepractice
{



    internal class datetimeamir
    {
       
        //private const long TicksPerMillisecond = 10000;
        //private const long TicksPerMin = (10000 * 1000) * 60;
        //private const long TicksPerDay = (TicksPerMin*60)*24;
        //private const int Dayper400 = (((365*4+1)*25-1)*4+1);
        //private const int Dayper10000 = Dayper400*25-366;
        //private const long FileTimeOffset = DaysTo1601 * TicksPerDay;
        //private const long KindUtc = 0x4000000000000000;
        //internal const long MinTicks = 0;
        //internal const long MaxTicks = Dayper10000 * TicksPerDay - 1;
        //internal static readonly bool s_isLeapSecondsSupportedSystem = SystemSupportLeapSeconds();
        //[System.Security.SecuritySafeCritical]
        //internal static bool SystemSupportLeapSeconds()
        //{
        //    return IsLeapSecondsSupportedSystem();
        //}
        //[System.Security.SecurityCritical]
        //[ResourceExposure(ResourceScope.None)]
        //[DllImport(StringHandleOnStack.QCall, CharSet = CharSet.Unicode), SuppressUnmanagedCodeSecurity]
        //internal static extern bool IsLeapSecondsSupportedSystem();

        private int _year;
        private int _month;
        private int _day;
        private int _hour;
        private int _minute;
        private int _second;
        //private int _microsecond;
        //private int _nanosecond;
     

        public int Year
        {

            get { return _year; }

            set { _year = value; }
        }
        public int Month
        {

            get { return _month; }

            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                //else
                //    throw new Exception("عدد ماه باید بین 1 تا 12 باشد");

            }
        }
            


        public int Day
        {
            get { return _day; }
            set
            {
                int maxValidDay;
                if (Month >= 1 && Month <= 6)
                {
                    maxValidDay = 31;

                }
                else
                {
                    maxValidDay = 30;

                }
                if (value >= 1 && value <= maxValidDay)
                {

                    _day = value;

                }


            }
        }
        public int Hour 
        {
            get
            {
                return _hour;
            }
            set
            {
                if (value > 0 && value <= 24)
                {
                     _hour = value;
                }
                
            }
            
        }
        public int Minute
        {
            get
            {
                return _minute;
            }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _minute = value;
                }
            }
        }
        public int Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (value >= 0 && value <= 60)
                {
                    _second = value;
                }
            }
        }
        public int Convertmilady()
        {
            if (Year > 622) { 
                if (IsLeapYear == false)
                { 
                    if (Month <= 10)
                    {
                        if (Day <= 10)
                        {
                            int sixtowone = 621;
                            int relyear = Year - sixtowone;
                            Year = relyear;
                            return Year;

                        }
                        else
                        {
                            int sixtowone = 621;

                            int relyear = Year - sixtowone;
                            Year = relyear;
                            return Year;

                        }
                    }
                    else
                    {
                        int relyear = Year - 622;
                        Year = relyear;
                        return Year;

                    }
                }
                else
                {
                    if (Month <= 10)
                    {
                        if (Day <= 11)
                        {
                            int relyear = Year - 621;
                            Year = relyear;
                            return Year;

                        }
                        else
                        {
                            int relyear = Year - 622;
                            Year = relyear;
                            return Year;

                        }
                    }
                    else
                    {
                        int relyear = Year - 622;
                        Year = relyear;
                        return Year;

                    }

                }
           
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        public int ConvertShamsi()
        {

            if (IsLeapYear == false)
            {
                if (Month <= 10)
                {
                    if (Day <= 10)
                    {
                        int sixtowone = 621;
                        int relyear = Year + sixtowone;
                        Year = relyear;
                        return Year;

                    }
                    else
                    {
                        int sixtowone = 621;

                        int relyear = Year + sixtowone;
                        Year = relyear;
                        return Year;

                    }
                }
                else
                {
                    int relyear = Year + 622;
                    Year = relyear;
                    return Year;

                }
            }
            else
            {
                if (Month <= 10)
                {
                    if (Day <= 11)
                    {
                        int relyear = Year + 621;
                        Year = relyear;
                        return Year;

                    }
                    else
                    {
                        int relyear = Year + 622;
                        Year = relyear;
                        return Year;

                    }
                }
                else
                {
                    int relyear = Year + 622;
                    Year = relyear;
                    return Year;

                }

            }

        }
     
        private int year;
        private int month;
        private int day;
        private readonly DateTime _dateTime;
        public datetimeamir()
        {

       

        }
        public datetimeamir(DateTime dateTime)
          : this()
        {
            _dateTime = dateTime;
        }

    
        public datetimeamir(int yearf, int montht, int dayf)
        {

            year = yearf;
            month = montht;
            day = dayf;
            
        }

        public static datetimeamir operator +(datetimeamir a, datetimeamir b)
        {
            int d = a.day + b.day;
            if (a.month <= 6)
            {
                if (d > 31)
                {
                    int day = d % 31;
                    a.day = day;
                    int dayofmonth = d / 31;
                    int m = a.month + dayofmonth;
                    if (a.month > 12)
                    {
                        a.year++;
                    }
                }
            }
            if (a.month > 6)
            {
                if (d > 30)
                {
                    int day = d % 30;
                    a.day = day;
                    int dayofmonth = d / 30;
                    int m = a.month + dayofmonth;
                    if (a.month > 12)
                    {
                        int q = a.month % 12;
                        a.month = q;
                        a.year++;
                    }
                }
            }
            int s = a.month + b.month;
            if (s > 12)
            {
                int w = s % 12;
                a.month = w;
                a.year++;
            }
            int y = a.year + b.year;
            a.year = y;
            return new datetimeamir(a.year, a.month, a.day);
        }
        public static datetimeamir operator -(datetimeamir a, datetimeamir b)
        {
            int d = a.day - b.day;
            if (a.month <= 6)
            {
                if (d <= 0)
                {
                    int m = d + 31;
                    a.month--;
                    a.day = m;
                    if (a.month < 1)
                    {
                        a.year--;
                    }
                }
                if (d > 0)
                {
                    a.day = d;
                }
            }
            if (a.month > 6)
            {
                if (d <= 0)
                {
                    int m = d + 30;
                    a.day = m;
                    a.month--;
                    if (a.month < 1)
                    {
                        a.year--;
                    }
                }
                if (d > 0)
                {
                    a.day = d;
                }
            }
            
            int month = a.month - b.month;
            if (month > 0)
            {
                int realmonth = month % 12;
                a.month = realmonth;
                int yemonth = month / 12;
                int ye = a.year - yemonth;
                a.year = ye;
            }
            int realyear = a.year - b.year;
            a.year = realyear;
            return new datetimeamir(a.year, a.month, a.day);

        }
        public static datetimeamir operator *(datetimeamir a, datetimeamir b)
        {
            int d = a.day * b.day;
            if (a.month <= 6)
            {
                if (d > 31)
                {
                    int realday = d % 31;
                    a.day = realday;
                    int da = d / 31;
                    int dam = a.month + da;
                    a.month = dam;
                    if (a.month > 12)
                    {
                        int mo = a.month / 12;
                        int moy = a.year + mo;
                        a.year = moy;
                        int relmon = a.month % 12;
                        a.month = relmon;
                    }
                }
               // a.day = d;
            }
            if (a.month > 6)
            {
                if (d > 30)
                {
                    int realday = d % 30;
                    a.day = realday;
                    int da = d / 30;
                    int dam = a.month + da;
                    a.month = dam;
                    if (a.month > 12)
                    {
                        int mo = a.month / 12;
                        int moy = a.year + mo;
                        a.year = moy;
                        int relmon = a.month % 12;
                        a.month = relmon;
                    }
                }
              //  a.day = d;
            }
            int month = a.month * b.month;
            if (month > 12)
            {
                int mont = month / 12;
                int monthyea = a.year + mont;
                a.year = monthyea;
                int realmonth = month % 12;
                a.month = realmonth;
            }
          //  a.month = month;
            int year = a.year * b.year;
            a.year = year;
            return new datetimeamir(a.year, a.month, a.day);

        }
        public static datetimeamir operator /(datetimeamir a, datetimeamir b)
        {
            if (b.day < a.day)
            {
                int d = a.day / b.day;
                a.day = d;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            if (a.month > b.month)
            {
                int m = a.month / b.month;
                a.month = m;
            }
            else
            {
                throw new ArgumentOutOfRangeException();

            }
            if (a.year > b.year)
            {
                int y = a.year / b.year;
                a.year = y;
            }
            else
            {
                throw new ArgumentOutOfRangeException();

            }
            return new datetimeamir(a.year, a.month, a.day);
        }
        public static datetimeamir operator <(datetimeamir a, datetimeamir b)
        {
            if (a.year < b.year)
            {
                return new datetimeamir(b.year, b.month, b.day);
            }
            else
            {
                if (a.month < b.month)
                {
                    return new datetimeamir(b.year, b.month, b.day);

                }
                else
                {
                    if (a.day < b.day)
                    {
                        return new datetimeamir(b.year, b.month, b.day);

                    }
                }
            }
            return new datetimeamir(a.year, a.month, a.day);

        }
        public static datetimeamir operator >(datetimeamir a, datetimeamir b)
        {
            if (a.year > b.year)
            {
                return new datetimeamir(a.year, a.month, a.day);

            }
            else
            {
                if (a.month > b.month)
                {
                    return new datetimeamir(a.year, a.month, a.day);

                }
                else
                {
                    if (a.day > b.day)
                    {
                        return new datetimeamir(a.year, a.month, a.day);

                    }
                }
            }
            return new datetimeamir(a.year, a.month, a.day);

        }
        public override string ToString() => $"{year} / {month} / {day}";
        public int AddSecond(int adsec)
        {
            int res = Second + adsec;
            if (res > 60)
            {
                int resa = res / 60;
                int sos = Minute + resa;
                if (sos > 60)
                {
                    int e = sos / 60;
                    int d = Hour + e;
                    if (d > 24)
                    {
                        int g = d / 24;
                        int j = g + Day;
                        Day = j;
                        int y = d % 24;
                        Hour = y;
                        return Hour;
                    }
                    Hour = d;
                    int u = sos % 60;
                    Minute = u;
                    return Minute;
                }
                int q = res % 60;
                Second = q;
            }
            if (res < 60)
            {
                Second = res;
                return Second;
            }
            return res;
        }

        public int AddMinute(int Admin)
        {
            int res = Minute + Admin;
            if (res > 60)
            {
                int resa = res / 60;
                int f = Hour + resa;
                if (f > 24)
                {
                    int sos =( f / 24)+Day;
                    Day = sos;
                }
                Hour = f;
                int real = res % 60;
                Minute = real;
                return Minute;
            }
            if (res < 60)
            {
                Minute = res;
                return Minute;
            }
            return res;
        }
        public int AddHour(int adhour)
        {
            int res = Hour+adhour;
            if (res > 24)
            {
                int resa = res / 24;
                int ss = Day + resa;
                Day = resa;
                int real = res % 24;
                Hour = real;
                return Hour;
            }
            if (res <= 24)
            {
                Hour = res;
                return Hour;
            }
            return res;
        }
        public int Addday()
        {
        
            int result = Day ;
            if (Month <= 6)
            {
                int d=result % 31;
                Day = d;
                int g = result / 32;
                int m = Month + g;
                Month = m;
                if (Month > 12)
                {
                    int y = Month / 12;
                    int yea = Year + y;
                    Year = yea;
                }
            }
   
            if (Year % 33 == 1 || Year % 33 == 5 || Year % 33 == 9 || Year % 33 == 13 || Year % 33 == 17 || Year % 33 == 22 || Year % 33 == 26 || Year % 33 == 30)
            {
                if (Month == 12)
                {
                    int d = result % 30;
                    Day = d;
                }
            }
            if (Month > 6)
            {
                int d = result % 30;
                Day = d;
                int g = result / 31;
                int m = Month + g;
                Month = m;
                if (Month > 12)
                {
                    int y = Month / 12;
                    int yea = Year + y;
                    Year = yea;
                }
            }
            return result;
        }
        public int AddMonth(int month)
        {
          
            int result = Month + month;

            if (result < 12)
            {
                Month = result;
            }
            else
            {
                int formonth = result % 12;
                int Resul = result / 12;
                int ye = Year + Resul;
                Year = ye;
                Month = formonth;
            }
            return result;
        }

        public int Addyear(int year) 
        {
            int res = Year + year;
            Year = res;
            return res;
        }

        public bool IsLeapYear
        {
            get
            {

                if (Year % 33 == 1 || Year % 33 == 5 || Year % 33 == 9 || Year % 33 == 13 || Year % 33 == 17 || Year % 33 == 22 || Year % 33 == 26 || Year % 33 == 30)
                {
                    return true;
                }

                else
                {
                    return false;
                }


            }
        }


        public object equalsday
        {
            get
            {
                int MonthIndex = 0;
                switch (Month)
                {
                    case 1:
                        MonthIndex = 0;
                        break;
                    case 2:
                        MonthIndex = 3;
                        break;
                    case 3:
                        MonthIndex = 3;
                        break;
                    case 4:
                        MonthIndex = 6;
                        break;
                    case 5:
                        MonthIndex = 1;
                        break;
                    case 6:
                        MonthIndex = 4;
                        break;
                    case 7:
                        MonthIndex = 6;
                        break;
                    case 8:
                        MonthIndex = 2;
                        break;
                    case 9:
                        MonthIndex = 5;
                        break;
                    case 10:
                        MonthIndex = 0;
                        break;
                    case 11:
                        MonthIndex = 3;
                        break;
                    case 12:
                        MonthIndex = 5;
                        break;
                }
                int ye = Year;
                double yea = Year;
                int c = ye / 100;
                double q = yea / 100;
                double o = q - c;
                double p = o * 100;
                int yearindex = 0;
                int bagi = (Year - (int)p) % 4;
                switch (bagi)
                {
                    case 0:
                        yearindex = 6;
                        break;
                    case 1:
                        yearindex = 4;
                        break;
                    case 2:
                        yearindex = 2;
                        break;
                    case 3:
                        yearindex = 0;
                        break;
                }

                int year = Year;
                double w = Year;
                int reasul = year / 100;
                double res = w / 100;
                double g = res - reasul;
                double k = g * 100;
                double f = Day + MonthIndex + yearindex + k + (k / 4);
                int Result = (int)f % 7;
                string dayname = "shit";
                switch (Result)
                {
                    case 0:
                        return dayname = "sunday";
                    case 1:
                        return dayname = "monday";
                    case 2:
                        return dayname = "Tuesday";
                    case 3:
                        return dayname = "Wednesday";
                    case 4:
                        return dayname = "Thurthday";
                    case 5:
                        return dayname = "Frieday";
                    case 6:
                        return dayname = "saterday";

                    default:
                        break;
                }
                return dayname;
            }
        }

        public long Ticks
        {
            get
            {
                int d, m, y;
                d = Day * 86400;
                if (Month <= 6)
                {
                    m = Month * 2592000;
                    y = Year * 31622400;
                    int eq = d + m + y;
                    return (eq);
                }
                if (Month > 6)
                {

                    m = Month -6;
                    int mon = 6 * 2592000;
                    int mont = m * 2678400;
                    int realmonth = mon + mont;
                    y = Year * 31622400;
                    int eq = d + realmonth + y;
                    return (eq);

                }
                return Ticks;
            }
            
        }
        public int DayOfYear
        {
            get
            {
                if (Month <= 6)
                {
                    int eq = (Month * 31) + Day;
                    return (eq);
                }
                if (Month > 6)
                {
                    int month = Month - 6;
                    int mo = month * 30;
                    int mon = Month - month;
                    int realmonth = (mon * 31) + mo + Day;
                    return (realmonth);
                }
                return (DayOfYear);
            }
        }
        //public static datetimeamir Now => new datetimeamir(DateTime.Now.Date);
        public string Now
        {
            get
            {
                Year = DateTime.Now.Year;
                Month = DateTime.Now.Month;
                Day = DateTime.Now.Day;
             
                string y = Year.ToString();
                string m = Month.ToString();
                string d = Day.ToString();
                string h = DateTime.Now.Hour.ToString();
                string M = DateTime.Now.Minute.ToString();
                string s = DateTime.Now.Second.ToString();

                return y +"/"+m+"/"+d+" "+h+":"+M+":"+s;
            }


        }
        public string NowDate
        {
            get
            {
                Year = DateTime.Now.Year;
                Month = DateTime.Now.Month;
                Day = DateTime.Now.Day;

                string y = Year.ToString();
                string m = Month.ToString();
                string d = Day.ToString();
             

                return y + "/" + m + "/" + d;
            }
        }
        public string UtcNow
        {
            get
            {
                
                Year = DateTime.Now.Year;
                Month = DateTime.Now.Month;
                Day = DateTime.Now.Day;
                string M = DateTime.Now.Minute.ToString();
                string s = DateTime.Now.Second.ToString();
                int h = DateTime.Now.Hour - 3;
                return Year + "/" + Month + "/" + Day + " " + h + ":" + M + ":" + s;

            }
        }
        //        public static datetimeamir Now
        //        {
        //            get
        //            {
        //                Contract.Ensures(Contract.Result<DateTime>().Kind == DateTimeKind.Local);

        //                DateTime utc = UtcNow;
        //                Boolean isAmbiguousLocalDst = false;
        //                Int64 offset = GetDateTimeNowUtcOffsetFromUtc(utc, out isAmbiguousLocalDst).Ticks;
        //                long tick = utc.Ticks + offset;
        //                if (tick > datetimeamir.MaxTicks)
        //                {
        //                    return new datetimeamir(datetimeamir.MaxTicks, DateTimeKind.Local);
        //                }
        //                if (tick < datetimeamir.MinTicks)
        //                {
        //                    return new datetimeamir(datetimeamir.MinTicks, DateTimeKind.Local);
        //                }
        //                return new datetimeamir((int)tick, (int)DateTimeKind.Local,Convert.ToInt32(isAmbiguousLocalDst));
        //            }
        //        }
        //        public static DateTime UtcNow
        //        {
        //            [System.Security.SecuritySafeCritical]  // auto-generated
        //            get
        //            {
        //                Contract.Ensures(Contract.Result<DateTime>().Kind == DateTimeKind.Utc);
        //                // following code is tuned for speed. Don't change it without running benchmark.
        //                long ticks = 0;

        //                if (s_isLeapSecondsSupportedSystem)
        //                {
        //                    FullSystemTime time = new FullSystemTime();
        //                    GetSystemTimeWithLeapSecondsHandling(ref time);
        //                    return CreateDateTimeFromSystemTime(ref time);
        //                }

        //                ticks = GetSystemTimeAsFileTime();

        //#if FEATURE_LEGACYNETCF
        //            // Windows Phone 7.0/7.1 return the ticks up to millisecond, not up to the 100th nanosecond.
        //            if (CompatibilitySwitches.IsAppEarlierThanWindowsPhone8)
        //            {
        //                long ticksms = ticks / TicksPerMillisecond;
        //                ticks = ticksms * TicksPerMillisecond;
        //            }
        //#endif
        //                return new DateTime(((ticks + FileTimeOffset)) | KindUtc);
        //            }
        //        }
        //        internal struct FullSystemTime
        //        {
        //            internal FullSystemTime(int year, int month, DayOfWeek dayOfWeek, int day, int hour, int minute, int second)
        //            {
        //                wYear = (ushort)year;
        //                wMonth = (ushort)month;
        //                wDayOfWeek = (ushort)dayOfWeek;
        //                wDay = (ushort)day;
        //                wHour = (ushort)hour;
        //                wMinute = (ushort)minute;
        //                wSecond = (ushort)second;
        //                wMillisecond = 0;
        //                hundredNanoSecond = 0;
        //            }

        //            internal FullSystemTime(long ticks)
        //            {
        //                datetimeamir dt = new datetimeamir(ticks);

        //                int year, month, day;
        //                dt.GetDatePart(out year, out month, out day);

        //                wYear = (ushort)year;
        //                wMonth = (ushort)month;
        //                wDayOfWeek = (ushort)dt.equalsday;
        //                wDay = (ushort)day;
        //                wHour = (ushort)dt.Hour;
        //                wMinute = (ushort)dt.Minute;
        //                wSecond = (ushort)dt.Second;
        //                wMillisecond = (ushort)dt.Millisecond;
        //                hundredNanoSecond = 0;
        //            }

        //            internal ushort wYear;
        //            internal ushort wMonth;
        //            internal ushort wDayOfWeek;
        //            internal ushort wDay;
        //            internal ushort wHour;
        //            internal ushort wMinute;
        //            internal ushort wSecond;
        //            internal ushort wMillisecond;
        //            internal long hundredNanoSecond;
        //        };
        //        public DateTime AddHours(double value)
        //        {
        //            return Add(value, MillisPerHour);
        //        }
        //        public DateTime Add(TimeSpan value)
        //        {
        //            return AddTicks(value._ticks);
        //        }
        //        public DateTime AddTicks(long value)
        //        {
        //            long ticks = InternalTicks;
        //            if (value > MaxTicks - ticks || value < MinTicks - ticks)
        //            {
        //                throw new ArgumentOutOfRangeException("value", Environment.GetResourceString("ArgumentOutOfRange_DateArithmetic"));
        //            }
        //            return new DateTime((UInt64)(ticks + value) | InternalKind);
        //        }
        //        [System.Security.SecurityCritical]  // auto-generated
        //        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        //        internal static extern long GetSystemTimeAsFileTime();
        //        [System.Security.SecurityCritical]  // auto-generated
        //        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        //        internal static extern void GetSystemTimeWithLeapSecondsHandling(ref FullSystemTime time);

        //        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        //        internal static DateTime CreateDateTimeFromSystemTime(ref FullSystemTime time)
        //        {
        //            long ticks = DateToTicks(time.wYear, time.wMonth, time.wDay);
        //            ticks += TimeToTicks(time.wHour, time.wMinute, time.wSecond);
        //            ticks += time.wMillisecond * TicksPerMillisecond;
        //            ticks += time.hundredNanoSecond;
        //            return new DateTime(((ticks)) | KindUtc);
        //        }
        //        private static long DateToTicks(int year, int month, int day)
        //        {
        //            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
        //            {
        //                int[] days = IsLeapYear(year) ? DaysToMonth366 : DaysToMonth365;
        //                if (day >= 1 && day <= days[month] - days[month - 1])
        //                {
        //                    int y = year - 1;
        //                    int n = y * 365 + y / 4 - y / 100 + y / 400 + days[month - 1] + day - 1;
        //                    return n * TicksPerDay;
        //                }
        //            }
        //            throw new ArgumentOutOfRangeException(null, GetResourceString("ArgumentOutOfRange_BadYearMonthDay"));
        //        }
        //        private static long TimeToTicks(int hour, int minute, int second)
        //        {
        //            //TimeSpan.TimeToTicks is a family access function which does no error checking, so
        //            //we need to put some error checking out here.
        //            if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60 && second >= 0 && second < 60)
        //            {
        //                return (TimeSpan.TimeToTicks(hour, minute, second));
        //            }
        //            throw new ArgumentOutOfRangeException(null, GetResourceString("ArgumentOutOfRange_BadHourMinuteSecond"));
        //        }
        //        internal Hashtable Table;
        //        private Object GetObjectInternal(String name)
        //        {
        //            if (name == null)
        //                throw new ArgumentNullException("name");
        //            Contract.EndContractBlock();

        //            Hashtable copyOfTable = Table;  // Avoid a race with Dispose

        //            if (copyOfTable == null)
        //                throw new ObjectDisposedException(null, GetResourceString("ObjectDisposed_ResourceSet"));

        //            return copyOfTable[name];
        //        }
        //        public virtual String GetString(String name)
        //        {
        //            Object obj = GetObjectInternal(name);
        //            try
        //            {
        //                return (String)obj;
        //            }
        //            catch (InvalidCastException)
        //            {
        //                throw new InvalidOperationException(GetResourceString("InvalidOperation_ResourceNotString_Name", name));
        //            }
        //        }

        //        public static string GetResourceString(string key, params object[] args)
        //        {
        //            string fmt = GetString(key);
        //            if (fmt != null)
        //                return string.Format(fmt, args);

        //            string sargs = String.Empty;
        //            foreach (var arg in args)
        //            {
        //                if (sargs != String.Empty)
        //                    sargs += ", ";
        //                sargs += arg.ToString();
        //            }

        //            return key + " (" + sargs + ")";
        //        }


        //        static internal TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out Boolean isAmbiguousLocalDst)
        //        {
        //            Boolean isDaylightSavings = false;
        //#if FEATURE_WIN32_REGISTRY
        //            isAmbiguousLocalDst = false;
        //            TimeSpan baseOffset;
        //            int timeYear = time.Year;

        //            OffsetAndRule match = s_cachedData.GetOneYearLocalFromUtc(timeYear);
        //            baseOffset = match.offset;

        //            if (match.rule != null) {
        //                baseOffset = baseOffset + match.rule.BaseUtcOffsetDelta;
        //                if (match.rule.HasDaylightSaving) {
        //                    isDaylightSavings = GetIsDaylightSavingsFromUtc(time, timeYear, match.offset, match.rule, out isAmbiguousLocalDst, TimeZoneInfo.Local);
        //                    baseOffset += (isDaylightSavings ? match.rule.DaylightDelta : TimeSpan.Zero /* FUTURE: rule.StandardDelta */);
        //                }
        //            }                
        //            return baseOffset;          
        //#else
        //            // Use the standard code path for the Macintosh since there isn't a faster way of handling current-year-only time zones
        //            return GetUtcOffsetFromUtc(time, TimeZoneInfo.Local, out isDaylightSavings, out isAmbiguousLocalDst);
        //#endif // FEATURE_WIN32_REGISTRY
        //        }
        //        static internal TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out Boolean isDaylightSavings, out Boolean isAmbiguousLocalDst)
        //        {
        //            isDaylightSavings = false;
        //            isAmbiguousLocalDst = false;
        //            TimeSpan baseOffset = zone.BaseUtcOffset;
        //            Int32 year;
        //            AdjustmentRule rule;

        //            if (time > s_maxDateOnly)
        //            {
        //                rule = zone.GetAdjustmentRuleForTime(DateTime.MaxValue);
        //                year = 9999;
        //            }
        //            else if (time < s_minDateOnly)
        //            {
        //                rule = zone.GetAdjustmentRuleForTime(DateTime.MinValue);
        //                year = 1;
        //            }
        //            else
        //            {
        //                DateTime targetTime = time + baseOffset;

        //                // As we get the associated rule using the adjusted targetTime, we should use the adjusted year (targetTime.Year) too as after adding the baseOffset, 
        //                // sometimes the year value can change if the input datetime was very close to the beginning or the end of the year. Examples of such cases:
        //                //      Libya Standard Time when used with the date 2011-12-31T23:59:59.9999999Z
        //                //      "W. Australia Standard Time" used with date 2005-12-31T23:59:00.0000000Z
        //                year = targetTime.Year;

        //                rule = zone.GetAdjustmentRuleForTime(targetTime);
        //            }

        //            if (rule != null)
        //            {
        //                baseOffset = baseOffset + rule.BaseUtcOffsetDelta;
        //                if (rule.HasDaylightSaving)
        //                {
        //                    isDaylightSavings = GetIsDaylightSavingsFromUtc(time, year, zone.m_baseUtcOffset, rule, out isAmbiguousLocalDst, zone);
        //                    baseOffset += (isDaylightSavings ? rule.DaylightDelta : TimeSpan.Zero /* FUTURE: rule.StandardDelta */);
        //                }
        //            }

        //            return baseOffset;
        //        }
        //        internal void GetDatePart(out int year, out int month, out int day)
        //        {
        //            Int64 ticks = InternalTicks;
        //            // n = number of days since 1/1/0001
        //            int n = (int)(ticks / TicksPerDay);
        //            // y400 = number of whole 400-year periods since 1/1/0001
        //            int y400 = n / DaysPer400Years;
        //            // n = day number within 400-year period
        //            n -= y400 * Dayper400;
        //            // y100 = number of whole 100-year periods within 400-year period
        //            int y100 = n / Dayper400;
        //            // Last 100-year period has an extra day, so decrement result if 4
        //            if (y100 == 4) y100 = 3;
        //            // n = day number within 100-year period
        //            n -= y100 * DaysPer100Years;
        //            // y4 = number of whole 4-year periods within 100-year period
        //            int y4 = n / DaysPer4Years;
        //            // n = day number within 4-year period
        //            n -= y4 * DaysPer4Years;
        //            // y1 = number of whole years within 4-year period
        //            int y1 = n / DaysPerYear;
        //            // Last year has an extra day, so decrement result if 4
        //            if (y1 == 4) y1 = 3;
        //            // compute year
        //            year = y400 * 400 + y100 * 100 + y4 * 4 + y1 + 1;
        //            // n = day number within year
        //            n -= y1 * DaysPerYear;
        //            // dayOfYear = n + 1;
        //            // Leap year calculation looks different from IsLeapYear since y1, y4,
        //            // and y100 are relative to year 1, not year 0
        //            bool leapYear = y1 == 3 && (y4 != 24 || y100 == 3);
        //            int[] days = leapYear ? DaysToMonth366 : DaysToMonth365;
        //            // All months have less than 32 days, so n >> 5 is a good conservative
        //            // estimate for the month
        //            int m = (n >> 5) + 1;
        //            // m = 1-based month number
        //            while (n >= days[m]) m++;
        //            // compute month and day
        //            month = m;
        //            day = n - days[m - 1] + 1;
        //        }
        //public static datetimeamir Now => new datetimeamir(DateTime.Now);
        // public struct equaldate
        // {
        //public static equaldate operator ==(equaldate a, equaldate b)
        //{
        //    if (a.year == b.year)
        //    {
        //        if (a.month == b.month)
        //        {
        //            if (a.day == b.day)
        //            {
        //                  return new equaldate(a.year, a.month, a.day);

        //            }
        //            else
        //            {
        //                throw new Exception();
        //            }
        //        }
        //        else
        //        {
        //            throw new Exception();
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception();
        //    }
        //}
        //public static equaldate operator !=(equaldate a, equaldate b)
        //{
        //    if (a.year != b.year)
        //    {
        //          return new equaldate(a.year, a.month, a.day);
        //    }
        //    else
        //    {

        //        if (a.month != b.month)
        //        {
        //            return new equaldate(a.year, a.month, a.day);

        //        }
        //        else
        //        {
        //            if (a.day != b.day)
        //            {
        //                return new equaldate(a.year, a.month, a.day);

        //            }
        //            else
        //            {
        //                throw new Exception();

        //            }
        //        }
        //    }
        //}


        //switch (Symbol)
        //{
        //    case "-":
        //        int resul = Day - dayformines;

        //        if (Month <= 6)
        //        {
        //            if (resul <= 0)
        //            {
        //                Month--;
        //            }
        //            int realday = resul + 31;
        //            Day = realday;

        //        }
        //        else if (Month > 6)
        //        {
        //            if (resul <= 0)
        //            {
        //                Month--;
        //            }
        //            int realday = resul + 30;
        //            Day = realday;

        //            if (dayformines == 31 && Day == 1 && Month > 6)
        //            {
        //                int realmonth = Month - 2;
        //                Month = realmonth;
        //                if (Month <= 0)
        //                {
        //                    Year--;
        //                    Month = 12;
        //                }
        //            }
        //        }
        //        Day = resul;



        //        // return Day;
        //        int monthresul = Month - monthformines;
        //        if (monthresul <= 0)
        //        {
        //            Year--;
        //            int realmonth = monthresul + 12;
        //            Month = realmonth;
        //            return Month;

        //        }
        //        else
        //        {
        //            Month = monthresul;

        //        }
        //        //return Month;
        //        int yearresult = Year - yearformines;
        //        if (yearresult < 0)
        //        {
        //            return "this year is unvailible";
        //        }
        //        else
        //        {
        //            Year = yearresult;

        //        }
        //        return "don";
        //    case "+":
        //        int resday = Day + dayformines;
        //        if (resday < 31 && Month<7)
        //        {
        //            Day = resday;
        //        }
        //        if (resday < 32 && Month > 6)
        //        {
        //            Day = resday;
        //        }
        //        if (Month <= 6 && resday>=31)
        //        {
        //            int realday = resday % 31;
        //            Day = resday;
        //            Month++;
        //        }
        //        else if(Month>6 && resday >= 30)
        //        {
        //            int realday = resday % 30;
        //            Day = realday;
        //            Month++;
        //            if (Month > 12)
        //            {
        //                Year++;
        //            }
        //        }
        //        else if(Month==6 && Day==31 && dayformines==31)
        //        {
        //            int realday = resday % 30;
        //            Day = resday;
        //            Month= Month + 2;
        //            if (Month > 12)
        //            {
        //                Year++;
        //            }
        //        }
        //        int resmonth = Month + monthformines;
        //        if (resmonth < 13)
        //        {
        //            Month = resmonth;

        //        }
        //        if (resmonth > 12)
        //        {
        //            Month = resmonth % 12;
        //            Year++;
        //        }
        //        else if(Month==12 && monthformines == 12)
        //        {
        //            Month = 12;
        //            Year++;
        //        }
        //        Month = resmonth;
        //        int resyear = Year + yearformines;
        //        Year = resyear;
        //        return "don";
        //    case">":

        //        if (Year > yearformines)
        //        {
        //           return("yes its biger");
        //        }
        //        if (Year == yearformines)
        //        {
        //            if (Month > monthformines)
        //            {
        //                Console.WriteLine("yes its biger");
        //            }
        //        }
        //        if(Year==yearformines && Month == monthformines)
        //        {
        //            if (Day > dayformines)
        //            {
        //                Console.WriteLine("yes its biger");
        //            }
        //        }
        //        if (Year == yearformines && Month == monthformines && Day == dayformines)
        //        {
        //            Console.WriteLine("these are equal");
        //        }
        //        return "don";

        //    case "<":
        //        if (Year < yearformines)
        //        {
        //            return ("yes its biger");
        //        }
        //        if (Year == yearformines)
        //        {
        //            if (Month < monthformines)
        //            {
        //                Console.WriteLine("yes its biger");
        //            }
        //        }
        //        if (Year == yearformines && Month == monthformines)
        //        {
        //            if (Day < dayformines)
        //            {
        //                Console.WriteLine("yes its biger");
        //            }
        //        }
        //        if (Year == yearformines && Month == monthformines && Day == dayformines)
        //        {
        //            Console.WriteLine("these are equal");
        //        }
        //        return "don";
        //    case "=":
        //        if(Year== yearformines && Month==monthformines&& Day == dayformines)
        //        {
        //            Console.WriteLine("yes these date are equal");
        //        }
        //        else
        //        {
        //            Console.WriteLine("no these date are not equal");

        //        }
        //        return "don";

        //    default:
        //        break;
        //}

        // return "don";


        //   }
    }

}
