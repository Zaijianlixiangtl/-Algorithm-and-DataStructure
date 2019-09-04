using System;
using DataStructure.LinkList.Apps;

namespace DataStructure.LinkList.Apps
{
	class Program
	{
		static void Main(string[] args)
		{
			var link = new LinkList<Student>();
			var s1 = new Student() { Id = 1,Name = "lilei"};
			var s2 = new Student() { Id = 2, Name = "jason" };
			var s3 = new Student() { Id = 3, Name = "lffffff" };
			link.Add(s1);
			link.Add(s2);
			link.Add(s3);
			var aa = link.GetAll();

			Console.Read();
		}
	}
}
