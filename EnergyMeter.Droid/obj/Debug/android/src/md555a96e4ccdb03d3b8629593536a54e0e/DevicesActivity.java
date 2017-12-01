package md555a96e4ccdb03d3b8629593536a54e0e;


public class DevicesActivity
	extends md5fc936d0437bea9abef8ccd10ac2a7b55.ActivityBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EnergyMeter.Droid.Screens.Devices.DevicesActivity, EnergyMeter.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DevicesActivity.class, __md_methods);
	}


	public DevicesActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DevicesActivity.class)
			mono.android.TypeManager.Activate ("EnergyMeter.Droid.Screens.Devices.DevicesActivity, EnergyMeter.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
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
