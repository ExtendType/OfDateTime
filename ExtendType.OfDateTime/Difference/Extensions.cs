﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfDateTime.Difference
{
	public static class Extensions
	{
		/// <summary>
		/// Returns a difference in timespan from one date until another date
		/// </summary>
		public static TimeSpan Until(this DateTime instance, DateTime date)
		{
			return new TimeSpan(date.Ticks - instance.Ticks);
		}
		/// <summary>
		/// Returns a difference in days from one date until another date
		/// </summary>
		public static int DaysUntil(this DateTime instance, DateTime date)
		{
			return Convert.ToInt32(Math.Ceiling(new TimeSpan(date.Ticks - instance.Ticks).TotalDays));
		}
		/// <summary>
		/// Returns a difference in weeks from one date until another date
		/// </summary>
		public static int WeeksUntil(this DateTime instance, DateTime date)
		{
			int result = 0;
			double days = new TimeSpan(date.Ticks - instance.Ticks).TotalDays;
			if (days != 0) result = Convert.ToInt32(Math.Floor(days / 7));
			return result;
		}
		/// <summary>
		/// Returns a difference in months from one date until another date
		/// </summary>
		public static int MonthsUntil(this DateTime instance, DateTime date)
		{
			return ((instance.Year - date.Year) * 12) + (instance.Month - date.Month);
		}
		/// <summary>
		/// Returns a difference in quarters from one date until another date
		/// </summary>
		public static int QuartersUntil(this DateTime instance, DateTime date)
		{
			int result = ((instance.Year - date.Year) * 4);
			int months = (instance.Month - date.Month);
			if(months != 0) result = result + Convert.ToInt32(Math.Floor(Convert.ToDouble((months / 3))));
			return result;
		}
		/// <summary>
		/// Returns a difference in years from one date until another date
		/// </summary>
		public static int YearsUntil(this DateTime instance, DateTime date)
		{
			return (instance.Year - date.Year);
		}
	}
}
