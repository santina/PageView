using CoreGraphics;
using UIKit;

namespace SwipeDemo
{
    internal class DummyController : UIViewController

    {
        public DummyController() : base()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Draw a fun shape here.
            View.BackgroundColor = UIColor.White;
            UIView v = new UIImageView(new CGRect(50, 50, 50, 50));
            v.BackgroundColor = UIColor.Purple;
            View.AddSubview(v);
        }

        public override void ViewDidAppear(bool animated)
        {
            NavigationItem.Title = "I'm a dumdum";
        }
    }
}