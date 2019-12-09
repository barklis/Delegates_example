using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class ListListenerDisplayChanges
    {
        public void Subscribe(InformingList i)
        {
            i.SecondChange += new InformingList.SecondChangeHandler(ListChanged);
        }

        public void unSubscribe(InformingList i)
        {
            i.SecondChange -= new InformingList.SecondChangeHandler(ListChanged);
        }

        public void ListChanged(object list, ListEventArgs e)
        {
            Console.WriteLine("------BEGIN-----");
            Console.WriteLine("List changed: {0} | {1}", e.t, e.type);
            foreach(object o in e.changes)
            {
                Console.WriteLine("Data: {0}", o.ToString());
            }
            Console.WriteLine("-------END------");

        }         
    }
}
