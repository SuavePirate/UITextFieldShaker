using System;
using UITextFieldShaker;
using UIKit;

namespace Example
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        partial void ShakeButton_TouchUpInside(UIButton sender)
        {
            ShakingField.Shake();
        }
    }
}
