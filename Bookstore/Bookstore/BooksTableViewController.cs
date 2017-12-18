using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace Bookstore
{
    public partial class BooksTableViewController : UITableViewController
    {
        List<Book> BookList;

        public BooksTableViewController (IntPtr handle) : base (handle)
        {
            BookList = new List<Book>();
        }
    }

    public class Book
    {
        public string Name;
        public string Author;
        public string Editor;
        public int Year;

    }

}