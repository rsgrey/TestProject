using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace TestProject
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]

    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            RecyclerView recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            recyclerView.SetAdapter(new MyAdapter());
        }
    }

    public class MyAdapter : RecyclerView.Adapter
    {
        public override int ItemCount => 10;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return new CustomViewHolder(LayoutInflater.From(parent.Context).Inflate(Resource.Layout.item_content, parent, false));
        }

        public class CustomViewHolder : RecyclerView.ViewHolder
        {
            public CustomViewHolder(View itemView) : base(itemView)
            {
            }
        }
    }
}
