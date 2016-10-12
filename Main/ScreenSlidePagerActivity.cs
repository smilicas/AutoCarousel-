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
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Test.Suitebuilder;
using Android.Text;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace Main
{
    [Activity (MainLauncher = true, Icon = "@drawable/icon")]
    public class ScreenSlidePagerActivity : FragmentActivity, ViewPager.IOnPageChangeListener {

        // number of pages
        private const int NUM = 5;

        // pager wigdet, handles animatin and aloow swiping horizontally
        private ViewPager viewPager;

        //page adapater; provide pages to the ViewPager
        private PagerAdapter pagerAdapter;

        //things for autocarausel
        private LinearLayout dotsLayout;
        private TextView[] dots;
        private Button btnSkip, btnNext;

        protected override void OnCreate (Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);

            // Create your fragment here
            SetContentView (Resource.Layout.activity_screen_slide);
            viewPager = FindViewById<ViewPager> (Resource.Id.view_pager);
            pagerAdapter = new ScreenSlidePageAdapter (SupportFragmentManager);
            viewPager.Adapter = pagerAdapter; //ubaci u ViewPager ovo sto ti dajem!!!

            viewPager.AddOnPageChangeListener(this);

            dotsLayout = FindViewById<LinearLayout> (Resource.Id.layoutDots);
            btnSkip = FindViewById<Button> (Resource.Id.btn_skip);
            btnNext = FindViewById<Button> (Resource.Id.btn_next);

            AddButtomDots (0);
        }

        public void AddButtomDots (int currentPage)
        {
            dots = new TextView[NUM];

            int colorActive = Resources.GetColor (Resource.Color.dot_light_screen3);
            int colorInActive = Resources.GetColor (Resource.Color.dot_dark_screen3);

            dotsLayout.RemoveAllViews (); //proveri zasto je ovo potrebno

            for (int i = 0; i < NUM; i++)
            {
                dots [i] = new TextView (this);
                dots [i].Text = Html.FromHtml ("&#8226;").ToString ();
                dots [i].TextSize = 35;
                dots [i].SetTextColor (Android.Graphics.Color.Black);
                dotsLayout.AddView (dots [i]);
            }

            dots [currentPage].SetTextColor (Android.Graphics.Color.White);

        }

        public override void OnBackPressed ()
        {
            if (viewPager.CurrentItem == 0)
            {
                base.OnBackPressed ();
            }
            else
            {
                viewPager.CurrentItem = viewPager.CurrentItem - 1;
            }

        }

        private class ScreenSlidePageAdapter : FragmentStatePagerAdapter {

            public ScreenSlidePageAdapter (FragmentManager fm) : base (fm)
            {
            }

            public override Fragment GetItem (int position)
            {
               return ScreenSlidePageFragment.Create(position);
               //return new ScreenSlidePageFragment();
            }

            public override int Count {
                get { return NUM; }
            }

        }

        public void OnPageScrollStateChanged (int state)
        {
           
        }

        public void OnPageScrolled (int position, float positionOffset, int positionOffsetPixels)
        {
            
        }

        public void OnPageSelected (int position)
        {
            AddButtomDots (position);

            if (position == NUM - 1)
            {
                btnSkip.Visibility = ViewStates.Gone;
                btnNext.Text = GetString (Resource.String.start);

            }
            else
            {
                btnSkip.Visibility = ViewStates.Visible;
                btnNext.Text = GetString (Resource.String.next);
            }

        }

    }
}