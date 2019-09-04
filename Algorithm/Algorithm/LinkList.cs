using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataStructure.LinkList.Apps
{
	public class LinkList<T> where T : class, new()
	{
		public Node<T> Head { get; set; }
		public Node<T> Node { get; set; }
		public void Add(T t)
		{
			if (Head == null)
			{
				Head = new Node<T>(t, null);
			}
			else
			{
				Node = Head.NextNode;
				if (Node == null)
				{
					Node = new Node<T>(t, null);
					Head.NextNode = Node;
				}
				else
				{
					while (Node.NextNode != null)
					{
						Node = Node.NextNode;
					}
					Node.NextNode = new Node<T>(t, null);
				}
			}
		}
		public void Update()
		{

		}
		public List<T> GetAll()
		{
			if (Head == null)
			{
				return null;
			}
			Node = Head;
			//Node = JsonConvert.DeserializeObject<Node<T>>(JsonConvert.SerializeObject(Head));
			var list = new List<T>();
			do {
				list.Add(Head.Value);
				Head = Head.NextNode;
			} while (Head != null);
			Head = Node;
			return list;
		}


	}

	public class Node<T> where T : class, new()
	{
		public Node(T value, Node<T> nextNode)
		{
			Value = value;
			NextNode = nextNode;
		}

		public T Value { get; set; }
		public Node<T> NextNode { get; set; }
	}

	public class Student
	{
		public int Id { get; set; }

		public string Name { get; set; }
	}
}
