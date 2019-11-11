using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort.Service
{
	/// <summary>
	/// 二分查找   
	/// 时间复杂度 O(log n)
	/// 空间复杂度 O(1)
	/// </summary>
	public class BSearchService : ISearchService
	{
		public bool Exist(long[] array, long value)
		{
			return BSearch(array, value, 0, array.Length - 1);
		}

		private bool BSearch(long[] array,long value,int startIndex,int endIndex)
		{
			if (value == array[startIndex] || value == array[endIndex])
			{
				return true;
			}
			else if (value > array[startIndex] && value < array[endIndex])
			{
				int middleIndex = (endIndex - startIndex) / 2;
				if (array[middleIndex] == value)
				{
					return true;
				}
				else if (value > array[middleIndex])
				{
					return BSearch(array, value, middleIndex + 1, endIndex-1);
				}
				else
				{
					return BSearch(array, value, startIndex + 1, middleIndex - 1);
				}
			}
			else
			{
				return false;
			}
		}

		
	}
}
