using System;
using System.Collections.Generic;

namespace DataStructure.Service
{
    /// <summary>
    /// 双向链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkList<T>
    {
        private Node<T> _head = null;

        private Node<T> _tail = null;

        public int Count { get; private set; } = 0;

        public void Add(T item)
        {
            if (_head == null)
            {
                _head = new Node<T>()
                {
                    data = item
                };
                Count++;
                _tail = _head;
            }
            else
            {
                var node = new Node<T>
                {
                    data = item
                };
                _tail.next = node;
                node.prve = _tail;
                _tail = node;
                Count++;
            }
        }

        public List<T> FindAll()
        {
            var list = new List<T>();
            var node = _head;
            while (node != null)
            {
                list.Add(node.data);
                node = node.next;
            }
            return list;
        }

        public bool DeleteLast()
        {
            if (_tail == null)
                return false;
            _tail = _tail.prve;
            _tail.next = null;
            Count--;
            return true;
        }

        public int Delete(T item)
        {
            if (_head == null)
                return 0;
            var i = 0;
            var node = _head;
            var isHead = 1;
            while (node != null)
            {
                if (node.data.GetHashCode() == item.GetHashCode())
                {
                    i++;
                    if (isHead == 1)
                    {
                        _head = _head.next;
                        _head.prve = null;
                        node = _head;
                    }
                    else
                    {
                        node.prve.next = node.next;
                        node.next.prve = node.prve;
                    }
                }
                else
                {
                    isHead = 0;
                }
                node = node.next;
            }
            return i;
        }

        class Node<T>
        {
            public Node<T> next { get; set; }

            public Node<T> prve { get; set; }

            public T data { get; set; }
        }

    }


}
