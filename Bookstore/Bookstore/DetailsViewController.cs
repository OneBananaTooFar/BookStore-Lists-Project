using Foundation;
using System;
using UIKit;

namespace Bookstore
{
    public partial class DetailsViewController : UIViewController
    {

        public Book selectedBook;

        public DetailsViewController (IntPtr handle) : base (handle)
        {
        }
    
        public override void ViewWillAppear(bool animated)
        {
            labelBookName.Text = selectedBook.Name;
            imgBookImage.Image = UIImage.FromFile(selectedBook.ImagePath); 

        
        }
    
    
    }

}