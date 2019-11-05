using System;
using Algorithm.Sort.Service;

namespace Algorithm.Sort.Apps
{
	class Program
	{
		static void Main(string[] args)
		{
			ISortAlgorithmService iSortAlgorithmService = new QuickSortService();
			long[] arrayList = new long[] {19, 11,67,121,90,1,4,5,23,11};
			arrayList = iSortAlgorithmService.Sort(arrayList);
			Printf(arrayList);
			Console.WriteLine("--------");
			Console.WriteLine(a);
			Console.ReadKey();
		}

		static void Printf(long[] array)
		{
			if (array == null || array.Length == 0) return;
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
		}
	}
}
