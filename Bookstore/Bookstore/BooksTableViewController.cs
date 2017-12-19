using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace Bookstore
{
    public partial class BooksTableViewController : UITableViewController
    {
        List<Book> bookList;

        public BooksTableViewController (IntPtr handle) : base (handle)
        {
            bookList = new List<Book>();

            bookList.Add(new Book()
            {
                Author = "J.K. Rowling",
                Name = "Harry Potter and the Sorcerer's Stone",
                Publisher = "Bloomsbury",
                Year = 1997,
                    ImagePath = "Image/HPSS.jpg"
            });
            bookList.Add(new Book()
            {
                Author = "J.K Rowling",
                Name = "Harry Potter and the Chamber of Secets",
                Publisher = "Bloomsbury",
                Year = 1998,
                ImagePath = "Image/HPCOS.jpg"
            });

            bookList.Add(new Book()
            {
                Author = "J.K. Rowling",
                Name = "Harry Potter and the Prisoner of Azkaban",
                Publisher = "Bloomsbury",
                Year = 1999,
                ImagePath = "Image/HPPOA.jpg"
            });

        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return bookList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Book") as BookTableViewCell;

            var data = bookList[indexPath.Row];

            cell.BookData = data;

            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetailsSegue")
            {
                var navigationController = segue.DestinationViewController as DetailsViewController;

                if (navigationController != null)
                {
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var selectedData = bookList[rowPath.Row];

                }

            }


            base.PrepareForSegue(segue, sender);
        }
    
        }
       
        }






    public class Book
    {
        public string Name;
        public string Author;
        public string Publisher;
        public int Year;
        public string ImagePath;

    }

