using CoreGraphics;
using Foundation;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace SwipeDemo
{
    class DummyController : UIViewController

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


        private void AddNavigationBarOptions()
        {

            var optionsNavBarButton = new UIBarButtonItem(UIImage.FromBundle("Images"), UIBarButtonItemStyle.Plain, delegate
            {
                var localizedOption = NSBundle.MainBundle.LocalizedString("Options", "Customize your app experience");

            });


            NavigationItem.SetLeftBarButtonItem(optionsNavBarButton, true);
        }

        public override void ViewDidAppear(bool animated)
        {
            AddNavigationBarOptions();
            NavigationItem.Title = "I'm a dumdum";
        }



    }
}
