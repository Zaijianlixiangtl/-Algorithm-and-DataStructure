using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort.Service
{
	/// <summary>
	/// 插入排序
	/// 原地排序算法,空间复杂度 O(1)
	/// 时间复杂度 O(n^2)
	/// 稳定排序算法 
	/// </summary>
	public class InsertionSortService : ISortAlgorithmService
	{
		public long[] Sort(long[] array)
		{
			if (array == null || array.Length == 0)
				return array;
			for (int i = 1; i < array.Length; i++)
			{
				var value = array[i];
				var j = i-1;
				for (; j >=0; j--)
				{
					if (array[j] > value)
					{
						array[j + 1] = array[j]; //与冒泡排序相比 性能更优  因为少两个赋值
					}
					else
					{
						break;
					}
				}
				array[j + 1] = value; //插入
			}
			return array;
		}
	}
}
