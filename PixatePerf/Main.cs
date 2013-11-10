using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PixateFramework;

namespace PixatePerf
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			Pixate.LicenseKeyForUser("Your key", "your email");

			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
