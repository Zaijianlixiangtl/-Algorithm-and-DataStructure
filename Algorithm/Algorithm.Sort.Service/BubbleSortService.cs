using System;

namespace Algorithm.Sort.Service
{
	/// <summary>
	/// 冒泡排序
	/// 原地排序算法,空间复杂度 O(1)
	/// 时间复杂度 O(n^2)
	/// 稳定排序算法 
	/// </summary>
	public class BubbleSortService : ISortAlgorithmService
	{

		public long[] Sort(long[] array)
		{
			if (array == null || array.Length == 0)
				return array;

			for (int i = 0; i < array.Length; i++)
			{
				var flag = false;
				for (int j =  0; j < array.Length-i-1; j++)
				{
					var a = array[j];
					var b = array[j+1];
					if (a > b)
					{
						array[j] ^= array[j+1];
						array[j+1] ^= array[j];
						array[j] ^= array[j+1];
						flag = true;
					}
				}
				if (!flag) break;   //如果比较一轮，没有位置变换，说明排序已完成 
			}
			return array;
		}
	}
}
