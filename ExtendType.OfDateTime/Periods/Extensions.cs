using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExtendType.OfDateTime.Periods
{
	public static class Extensions
	{
		/// <summary>
		/// Returns the start of day from the supplied date
		/// </summary>
		public static DateTime StartOfDay(this DateTime instance)
		{
			return new DateTime(instance.Year, instance.Month, instance.Day, 0, 0, 0, 0);
		}
		/// <summary>
		/// Returns the end of day from the supplied date
		/// </summary>
		public static DateTime EndOfDay(this DateTime instance)
		{
			return new DateTime(instance.Year, instance.Month, instance.Day, 23, 59, 59, 999);
		}
		/// <summary>
		/// Returns the start of month from the supplied date
		/// </summary>
		public static DateTime StartOfMonth(this DateTime instance)
		{
			return new DateTime(instance.Year, instance.Month, 1, 0, 0, 0, 0);
		}
		/// <summary>
		/// Returns the end of month from the supplied date
		/// </summary>
		public static DateTime EndOfMonth(this DateTime instance)
		{
			return new DateTime(instance.Year, instance.Month, DateTime.DaysInMonth(instance.Year, instance.Month), 23, 59, 59, 999);
		}
		/// <summary>
		/// Returns the start of week from the supplied date
		/// </summary>
		public static DateTime StartOfWeek(this DateTime instance, DayOfWeek? on = null)
		{
			DayOfWeek day = on.GetValueOrDefault(DayOfWeek.Sunday);
			int days = instance.DayOfWeek - day;
			if (days < 0) days += 7;
			days = days * -1;
			return new DateTime(instance.Year, instance.Month, instance.Day, 0, 0, 0, 0).AddDays(days);
		}
		/// <summary>
		/// Returns the end of week from the supplied date
		/// </summary>
		public static DateTime EndOfWeek(this DateTime instance, DayOfWeek? on = null)
		{
			DayOfWeek day = on.GetValueOrDefault(DayOfWeek.Saturday);
			int days = day - instance.DayOfWeek;
			if (days < 0) days += 7;
			days = days * -1;
			return new DateTime(instance.Year, instance.Month, instance.Day, 23, 59, 59, 999).AddDays(days);
		}
		/// <summary>
		/// Returns the start of quarter from the supplied date
		/// </summary>
		public static DateTime StartOfQuarter(this DateTime instance)
		{
			int month = instance.Month;
			if (month < 4) month = 1;
			else if (month < 6) month = 4;
			else if (month < 8) month = 6;
			else if (month <= 12) month = 8;
			return new DateTime(instance.Year, month, 1, 0, 0, 0, 0);
		}
		/// <summary>
		/// Returns the end of day from the supplied date
		/// </summary>
		public static DateTime EndOfQuarter(this DateTime instance)
		{
			int month = instance.Month;
			if (month < 4) month = 3;
			else if (month < 6) month = 7;
			else if (month < 8) month = 9;
			else if (month <= 12) month = 12;
			return new DateTime(instance.Year, month, DateTime.DaysInMonth(instance.Year, month), 23, 59, 59, 999);
		}
		/// <summary>
		/// Returns the start of year from the supplied date
		/// </summary>
		public static DateTime StartOfYear(this DateTime instance)
		{
			return new DateTime(instance.Year, 1, 1, 0, 0, 0, 0);
		}
		/// <summary>
		/// Returns the end of year from the supplied date
		/// </summary>
		public static DateTime EndOfYear(this DateTime instance)
		{
			return new DateTime(instance.Year, 12, DateTime.DaysInMonth(instance.Year, 12), 23, 59, 59, 999);
		}
	}
}
