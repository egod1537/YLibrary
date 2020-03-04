using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Events;
using System;

namespace YLibrary
{

    [InitializeOnLoad]
    public class EditorTime
    {

        public class SecondEvent : UnityEvent<int> { }
        public static SecondEvent OnSecond = new SecondEvent();

        public class MinuteEvent : UnityEvent<int> { }
        public static MinuteEvent OnMinute = new MinuteEvent();

        public class HourEvent : UnityEvent<int> { }
        public static HourEvent OnHour = new HourEvent();

        public class DayEvent : UnityEvent<int> { }
        public static DayEvent OnDay = new DayEvent();

        public static int second, minute, hour, day;

        static EditorTime()
        {

            OnSecond.AddListener(
                (int sec) =>
                {
                    second = sec;
                });

            OnMinute.AddListener(
                (int min) =>
                {
                    minute = min;
                });

            OnHour.AddListener(
                (int h) =>
                {
                    hour = h;
                });

            OnDay.AddListener(
                (int d) =>
                {
                    day = d;
                });

            EditorApplication.update += Update;

        }

        static void Update()
        {

            TimeHandler();

        }

        static void TimeHandler()
        {

            SecondHandler();
            MinuteHandler();
            HourHandler();
            DayHandler();

        }

        static int delta_second;

        static void SecondHandler()
        {

            if (delta_second != DateTime.Now.Second)
                OnSecond.Invoke(DateTime.Now.Second);

            delta_second = DateTime.Now.Second;

        }

        static int delta_minute;

        static void MinuteHandler()
        {

            if (delta_minute != DateTime.Now.Minute)
                OnMinute.Invoke(DateTime.Now.Minute);

            delta_minute = DateTime.Now.Minute;

        }

        static int delta_hour;

        static void HourHandler()
        {

            if (delta_hour != DateTime.Now.Hour)
                OnHour.Invoke(DateTime.Now.Hour);

            delta_hour = DateTime.Now.Hour;

        }

        static int delta_day;

        static void DayHandler()
        {

            if (delta_day != DateTime.Now.Day)
                OnDay.Invoke(DateTime.Now.Day);

            delta_day = DateTime.Now.Day;

        }

    }

}
