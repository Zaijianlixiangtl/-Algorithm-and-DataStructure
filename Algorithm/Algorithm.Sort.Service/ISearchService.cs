using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Sort.Service
{
	public interface ISearchService
	{
		bool Exist(long[] array, long value);
	}
}
