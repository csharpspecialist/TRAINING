using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListView1
{
    class MyListViewAdapter: BaseAdapter<string>
    {
        private List<string> nItems;
        private Context nContext;

        public MyListViewAdapter(Context context, List<string> items  )
        {
            nItems = items;
            nContext = context;
        }
        public override int Count
        {
            get
            {
              return nItems.Count();
            }
        }

        public override long GetItemId(int position)
        {
            return position;

        }


        public override string this[int position]
        {
            get
            {
                return nItems[position];
            }
         
           
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(nContext).Inflate(Resource.Layout.listView_row, null, false);
            }
            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtName.Text = nItems[position];

        }


    }
}