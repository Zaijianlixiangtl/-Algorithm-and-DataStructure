using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort.Service
{
	public class SelectionSortService : ISortAlgorithmService
	{
		public long[] Sort(long[] array)
		{

			if (array == null || array.Length == 0)
				return array;
			for (int i = 0; i < array.Length-1; i++)
			{
				int j = i + 1;
				long min = array[j];
				long minIndex = j;
				for (; j < array.Length-1; j++)
				{
					if( min > array[j + 1])
					{
						min = array[j + 1];
						minIndex = j + 1;
					}
				}
				if (array[i] > min)
				{
					array[i] ^= array[minIndex];
					array[minIndex] ^= array[i];
					array[i] ^= array[minIndex];
				}
			}
			return array;
		}
	}
}
