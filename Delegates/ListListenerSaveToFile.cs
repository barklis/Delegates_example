using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Delegates
{
    class ListListenerSaveToFile
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
            FileStream file = new FileStream("file.txt", FileMode.Append);
            StreamWriter stream = new StreamWriter(file);

            stream.WriteLine("------BEGIN-----");
            stream.WriteLine("List changed: {0} | {1}", e.t, e.type);
            foreach (object o in e.changes)
            {
                stream.WriteLine("Data: {0}", o.ToString());
            }
            stream.WriteLine("-------END------");

            stream.Flush();
            stream.Close();
            file.Close();

        }
    }
}
