using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort.Service
{
	/// <summary>
	/// 快速排序 
	/// 时间复杂度 O(n log n)
	/// 空间复杂度 O(1)
	/// 不是稳定排序算法
	/// </summary>
	public class QuickSortService : ISortAlgorithmService
	{
		public long[] Sort(long[] array)
		{
			QuickSort(array, 0, array.Length - 1);
			return array;
		}

		private void QuickSort(long[] array ,int p,int r)
		{
			if (p >= r) return;
			var q = Partition(array, p, r);
			QuickSort(array, p, q-1);
			QuickSort(array,q+1,r);
		}
		/// <summary>
		/// 分区 取一个值 数组左边小于这个值  右边大于这个值  返回这个值的坐标
		/// </summary>
		/// <param name="array"></param>
		/// <param name="p"></param>
		/// <param name="r"></param>
		/// <returns></returns>
		private int Partition(long[] array,int p,int r)
		{
			var point = array[r];
			var j = p;
			for (int i = p; i < r; i++)
			{
				if (array[i] < point)
				{
					if (i != j)  //按位异或 相同数字=0  
					{
						array[j] ^= array[i];
						array[i] ^= array[j];
						array[j] ^= array[i];
					}
					j++;
				}
			}
			if (j != r)
			{
				array[j] ^= array[r];
				array[r] ^= array[j];
				array[j] ^= array[r];
			}
			return j;
		}


		/// <summary>
		/// 找出数组中   第K大的数字
		/// </summary>
		/// <param name="array"></param>
		/// <param name="k"></param>
		/// <returns></returns>
		public long GetOne(long[] array, int k)
		{
			return QuickSortK(array, 0, array.Length - 1, k);
		}


		private long QuickSortK(long[] array, int p, int r,int k)
		{
			//if (p >= r) return 0;
			var q = Partition(array, p, r);
			if (k == r + 1 - q)
			{
				return array[q];
			}
			if (k > r + 1 - q)
			{
				return QuickSortK(array, p, q - 1, k - (r-q+1));
			}
			else
			{
				 return QuickSortK(array, q + 1, r,k);
			}
		}
	}


}
