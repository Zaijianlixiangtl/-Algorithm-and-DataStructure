using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort.Service
{
	/// <summary>
	/// 基数排序
	/// </summary>
	public class RadixSortService :ISortAlgorithmService
	{
		/// <summary>
		/// 手机号排序
		/// </summary>
		/// <param name="array"></param>
		/// <returns></returns>
		public long[] Sort(long[] array)
		{
			for (int i = 0; i < 10; i++)
			{
				array = SortOne(array, i);
			}
			return array;
		}

		private long[] SortOne(long[] array, int index)
		{
			var j = Math.Pow(10,index);
			int[] c = new int[10];
			long[] r = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				int temp = (int)(array[i]/ j%10);
				c[temp]++;
			}
			for (int i = 1; i < c.Length; i++)
			{
				c[i] += c[i - 1];
			}
			for (int i = array.Length-1; i >= 0; i--)
			{
				int temp = (int)(array[i] / j % 10);
				r[c[temp]-1] = array[i];
				c[temp]-=1;
			}
			return r;
		}
	}
}
