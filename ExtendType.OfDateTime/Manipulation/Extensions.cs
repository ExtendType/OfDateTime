using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfDateTime.Manipulation
{
	public static class Extensions
	{
		/// <summary>
		/// Adds weeks to a supplied date
		/// </summary>
		public static DateTime AddWeeks(this DateTime instance, int value)
		{
			return instance.AddDays(value * 7);
		}
		/// <summary>
		/// Adds quarters to a supplied date
		/// </summary>
		public static DateTime AddQuarters(this DateTime instance, int value)
		{
			return instance.AddMonths(value * 3);
		}
	}
}
