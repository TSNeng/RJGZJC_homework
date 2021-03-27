using System;
using System.Timers;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("请设置闹钟的响铃时间(以hh:mm:ss格式设置");
            string clock_time;
            
            clock_time = Console.ReadLine();
            
            Clock clock = new Clock();
            Alarm alarm = new Alarm(clock);
            Tick tick = new Tick(clock);
            Thread thread_1 = new Thread(clock.On);
            thread_1.Start();
            clock.On2(clock_time);
        }
    }

    delegate void Handler();
    delegate void Handler2(string clock_time);

    class Clock
    {
        public string time = DateTime.Now.ToString("hh:mm:ss");
        public event Handler Func;
        public event Handler2 Func1;
        public void On()
        {
            Func();
        }

        public void On2(string clock_time)
        {
            Func1(clock_time);
        }
    }

    class Tick
    {
        public Tick(Clock clock)
        {
            clock.Func += tick;
        }

        public void tick()
        {
            while (true)
            {
                Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
                Thread.Sleep(1000);
            }
        }
    }
    
    class Alarm
    {
        public Alarm(Clock clock)
        {
            clock.Func1 += alarm;
        }

        public void alarm(string clock_time)
        {
            while (true)
            {
                string time = DateTime.Now.ToString("hh:mm:ss");
                if(time == clock_time)
                {
                    Console.WriteLine($"{0}时间到了",time);
                }
            }
        }
    }
    
}
