using System.Collections.Generic;
using Android.Content;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace ViewPagerSimple
{
    public class CustomPagerAdapter : PagerAdapter
    {
        private readonly Context _context;
        private readonly List<DataModel> _itemList;
        private LayoutInflater _inflator;


        public CustomPagerAdapter(Context context, List<DataModel> itemList)
        {
            _context = context;
            _itemList = itemList;
            _inflator = (LayoutInflater) context.GetSystemService(Context.LayoutInflaterService);
        }

        public override bool IsViewFromObject(View view, Object @object) => view == @object;


        public override Object InstantiateItem(ViewGroup container, int position)
        {
            // Get the view of the single ViewPager item.
            View itemView = _inflator.Inflate(Resource.Layout.viewpager_item, container, false);

            // Locating the ImageView and TextView
            ImageView imageView = (ImageView) itemView.FindViewById(Resource.Id.imageItem);
            TextView textView = (TextView) itemView.FindViewById(Resource.Id.textViewItem);

            // Get the Data Modal for current Position
            DataModel dataModel = _itemList[position];


            // Set data for Image and Text
            imageView.SetImageResource(dataModel.ImageId);
            textView.Text = dataModel.Title;


            //Add viewpager_item.xml to ViewPager
            container.AddView(itemView);



            return itemView;
        }


        public override int Count => _itemList.Count;

        public override void DestroyItem(ViewGroup container, int position, Object @object)
        {
            container.RemoveView((FrameLayout)@object);

        }
    }
}