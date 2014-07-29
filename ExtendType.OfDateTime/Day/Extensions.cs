using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfDateTime.Day
{
	public static class Extensions
	{
		public static DateTime StartOfDay(this DateTime instance)
		{
			return new DateTime(instance.Year, instance.Month, instance.Day, 0, 0, 0);
		}

		public static DateTime EndOfDay(this DateTime instance)
		{
			return new DateTime(instance.Year, instance.Month, instance.Day, 23, 59, 59, 999);
		}
	}
}
