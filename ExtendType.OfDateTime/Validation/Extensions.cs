﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfDateTime.Validation
{
	public static class Extensions
	{
		public static bool IsEmpty(this DateTime instance)
		{
			return instance == DateTime.MinValue;
		}
		public static bool IsMin(this DateTime instance)
		{
			return instance == DateTime.MinValue;
		}
		public static bool IsMax(this DateTime instance)
		{
			return instance == DateTime.MinValue;
		}
	}
}
