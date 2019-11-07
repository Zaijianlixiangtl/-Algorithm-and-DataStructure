using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort.Service
{
	/// <summary>
	/// 计数排序
	/// 属于线性排序  不需要比较  
	/// 稳定排序算法
	/// 时间复杂度  O(n)
	/// </summary>
	public class CountingSortService : ISortAlgorithmService
	{
		public long[] Sort(long[] array)
		{
			long[] c = new long[11];
			long[] r = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				c[array[i]] += 1;
			}
			for (int i = 1; i < c.Length; i++)
			{
				c[i] = c[i - 1] + c[i];
			}
			for (int i = array.Length-1; i >= 0; i--)
			{
				var h = c[array[i]];
				r[h-1] = array[i];
				c[array[i]] -= 1;
			}
			return r;
		}
	}
}
