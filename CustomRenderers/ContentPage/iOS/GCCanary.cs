using System.Diagnostics;

namespace CustomRenderer.iOS
{
	public class GCCanary
	{
		public GCCanary()
		{
			Debug.WriteLine($">>>>> GCCanary constructor");
		}

		~GCCanary()
		{
			Debug.WriteLine($">>>>> GCCanary finalizer");
		}
	}
}