using System;
using System.Collections;

namespace Delegates
{
    public class ListEventArgs : EventArgs
    {
        public readonly System.DateTime t;
        public readonly string type;
        public readonly ArrayList changes;

        public ListEventArgs(DateTime time, string changes_type, ArrayList a)
        {
            this.changes = a;
            this.type = changes_type;
            this.t = time;
        }
    }
}