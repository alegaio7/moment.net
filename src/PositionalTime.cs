﻿using System;

namespace moment.net;

public static class PositionalTime
{
    /// <summary>
    /// Check if date time instance comes before a given date
    /// </summary>
    /// <param name="dateTime">The given date</param>
    /// <param name="dateToCompare">The date to compare against</param>
    /// <returns>A boolean value stating whether the compared date is before this date</returns>
    public static bool IsBefore(this DateTime dateTime, DateTime dateToCompare)
    {
        var normalizedCurrent = dateTime.ToUniversalTime();
        var normalizedComparison = dateToCompare.ToUniversalTime();

        return normalizedCurrent < normalizedComparison;
    }
    
    /// <summary>
    /// Check if date time instance comes after a given date
    /// </summary>
    /// <param name="dateTime">The given date</param>
    /// <param name="dateToCompare">The date to compare against</param>
    /// <returns>A boolean value stating whether the compared date is after this date</returns>
    public static bool IsAfter(this DateTime dateTime, DateTime dateToCompare)
    {
        var normalizedCurrent = dateTime.ToUniversalTime();
        var normalizedComparison = dateToCompare.ToUniversalTime();

        return normalizedCurrent > normalizedComparison;
    }
}