package md5aab1eae5a23215e87b7ffc7728e5b85b;


public class ScreenSlidePagerActivity_ScreenSlidePageAdapter
	extends android.support.v4.app.FragmentStatePagerAdapter
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getItem:(I)Landroid/support/v4/app/Fragment;:GetGetItem_IHandler\n" +
			"n_getCount:()I:GetGetCountHandler\n" +
			"";
		mono.android.Runtime.register ("Main.ScreenSlidePagerActivity+ScreenSlidePageAdapter, Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ScreenSlidePagerActivity_ScreenSlidePageAdapter.class, __md_methods);
	}


	public ScreenSlidePagerActivity_ScreenSlidePageAdapter (android.support.v4.app.FragmentManager p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ScreenSlidePagerActivity_ScreenSlidePageAdapter.class)
			mono.android.TypeManager.Activate ("Main.ScreenSlidePagerActivity+ScreenSlidePageAdapter, Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Support.V4.App.FragmentManager, Xamarin.Android.Support.v4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=71f3e3261ac778b5", this, new java.lang.Object[] { p0 });
	}


	public android.support.v4.app.Fragment getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native android.support.v4.app.Fragment n_getItem (int p0);


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
