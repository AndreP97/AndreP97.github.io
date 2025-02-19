﻿// Application to test class date
using System;

public class Date
{
    // auto-implemented property Month implicitly creates an
    // instance variable for the month
    public int Month { get; set; }

    // auto-implemented property Day implicitly creates an
    // instance variable for the day
    public int Day { get; set; }

    // auto-implemented property Year implicitly creates an
    // instance variable for the year
    public int Year { get; set; }

    // constructor
    public Date(int monthValue, int dayValue, int yearValue)
    {
        Month = monthValue;
        Day = dayValue;
        Year = yearValue;
    } // end three-parameter constructor

    // display the date
    public void DisplayDate()
    {
        Console.Write("{0}/{1}/{2}", Month, Day, Year);
    } // end method DisplayDate
} // end class Date