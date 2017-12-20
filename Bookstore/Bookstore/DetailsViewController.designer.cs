// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Bookstore
{
    [Register ("DetailsViewController")]
    partial class DetailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgBookImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelBookName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgBookImage != null) {
                imgBookImage.Dispose ();
                imgBookImage = null;
            }

            if (labelBookName != null) {
                labelBookName.Dispose ();
                labelBookName = null;
            }
        }
    }
}