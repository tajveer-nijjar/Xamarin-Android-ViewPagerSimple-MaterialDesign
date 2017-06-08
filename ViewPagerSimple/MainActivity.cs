using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;

namespace ViewPagerSimple
{
    [Activity(Label = "ViewPagerSimple", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            List<DataModel> itemList = GetDataList();

            CustomPagerAdapter adapter = new CustomPagerAdapter(this, itemList);
            ViewPager viewPager = (ViewPager) FindViewById(Resource.Id.viewPager);

            viewPager.Adapter = adapter;

        }

        public List<DataModel> GetDataList()
        {
            List<DataModel> itemList = new List<DataModel>();

            int[] imageIds = new[]
            {
                Resource.Drawable.image1,
                Resource.Drawable.image2,
                Resource.Drawable.image3,
                Resource.Drawable.image4,
                Resource.Drawable.image5,
                Resource.Drawable.image6
            };

            string[] titles = new string[]
            {
                "Image 1",
                "Image 2",
                "Image 3",
                "Image 4",
                "Image 5",
                "Image 6"
            };

            int count = imageIds.Length;

            for (int i = 0; i < count; i++)
            {
                itemList.Add(new DataModel(imageIds[i], titles[i]));
                
            }

            return itemList;
        }
    }
}

