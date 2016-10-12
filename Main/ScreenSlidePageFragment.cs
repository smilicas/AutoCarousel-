using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;

namespace Main
{
    public class ScreenSlidePageFragment : Fragment
    {
      
        public static String ARG_PAGE = "page";

        public int pageNum;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
            pageNum = Arguments.GetInt (ARG_PAGE);
        }

        public ScreenSlidePageFragment ()
        {
            //pageNum = 1;
        }

        public static ScreenSlidePageFragment Create(int pageNumber)
        {
            ScreenSlidePageFragment fragment = new ScreenSlidePageFragment();
            Bundle args = new Bundle();
            args.PutInt(ARG_PAGE, pageNumber);
            fragment.Arguments = args;
            return fragment;
        }



        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            // Inflate the layout containing a title and body text.
            ViewGroup rootView = (ViewGroup)inflater.Inflate(Resource.Layout.fragment_screen_slide_page, container, false);
            
            ImageView image = rootView.FindViewById<ImageView>(Resource.Id.image_holder);
            TextView title = rootView.FindViewById<TextView>(Resource.Id.text_title_holder);

            if (pageNum == 0)
            {
                title.Text = "Welcome to HipApp";
                image.SetBackgroundResource(Resource.Drawable.ic_hiphop);
            }

            if (pageNum == 1)
            {
                title.Text = "PROBA";
                image.SetBackgroundResource (Resource.Drawable.ic_movie);
            }

            if (pageNum == 2)
            {
                title.Text = "MILICA";
                image.SetBackgroundResource(Resource.Drawable.ic_travel);
            }
            
            return rootView;
        }
    }
}