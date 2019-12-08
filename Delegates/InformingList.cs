using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Delegates 
{
    class InformingList : ArrayList
    {
        public delegate void SecondChangeHandler(object list, ListEventArgs e);

        public event SecondChangeHandler SecondChange;

        protected void OnSecondChange(ListEventArgs e)
        {
            if(SecondChange != null)
            {
                SecondChange(this, e);
            }
        }
        override public int Add(object value)
        {
            ArrayList added = new ArrayList();
            added.Add(value);
            ListEventArgs changes = new ListEventArgs(System.DateTime.Now, "Added", added);
            OnSecondChange(changes);

            return base.Add(value);
        }

        override public void Clear()
        {
            ArrayList removed = (ArrayList) this.Clone();
            ListEventArgs changes = new ListEventArgs(System.DateTime.Now, "Removed", removed);
            OnSecondChange(changes);
            base.Clear();
        }

        override public object this[int index]
        {
            get
            {
                return this[index];
            }
            set
            {
                ArrayList changed = new ArrayList();
                changed.Add(value);
                ListEventArgs changes = new ListEventArgs(System.DateTime.Now, "Modified", changed);
                OnSecondChange(changes);

                this[index] = value;
            }
        }

    }
}
