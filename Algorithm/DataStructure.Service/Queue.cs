using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructure.Service
{
    public class Queue<T>
    {
        private List<T> _list = new List<T>();

        public Queue()
        {
            PushProcess();
        }

        private event Action<T> publishEvent;

        public void Publish(T item)
        {
            _list.Add(item);

        }

        public void Subscribe(Action<T> action)
        {
            publishEvent += action;
        }


        private void PushProcess()
        {
            Task.Run(()=> {
                while (true)
                {
                    if (publishEvent != null)
                    {
                        var item = _list.FirstOrDefault();
                        if (item != null)
                        {
                            _list.RemoveAt(0);
                            publishEvent.Invoke(item);
                        }
                    }
                    Thread.Sleep(10);
                }
            });
        }
    }
}
