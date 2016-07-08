using UIKit;

namespace SwipeDemo
{
    internal class MyNavigationController : UINavigationController
    {
        /// <summary>
        /// Constructs a BumblebeeNavigationController with a root view controller.
        /// </summary>
        /// <param name="rootViewController">View controller to set as root.</param>
        public MyNavigationController(UIViewController rootViewController) : base(rootViewController)
        {
            NavigationBar.Translucent = false;
            NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default); // Remove background.
            NavigationBar.BarTintColor = UIColor.Black; // Set clear background color.
            NavigationBar.BarStyle = UIBarStyle.Black; // Set navigation bar style to black, which sets text color to white.
            NavigationBar.TintColor = UIColor.White; // Set text to white.
            NavigationBar.ShadowImage = new UIImage(); // Remove shadow under navigation bar.
        }
    }
}