using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarksDataSetTableAdapters; 

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void AddItem(BookmarkItem item)
        {
            try
            {
                if (GetItems().Any(a => a.URL == item.URL))
                {
                    if (GetItems().Any(a => a.Title == item.Title))
                    {
                        return; //do not add
                    }
                }

                var adapter = new BookmarksTableAdapter();
                adapter.Insert(item.URL, item.Title);
            }

            catch (Exception ex)
            {
                return;
            }
        }

        public static List<BookmarkItem> GetItems() 
        {
            var adapter = new BookmarksTableAdapter();
            var result = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.ID = row.Id;
                item.URL = row.URL;
                item.Title = row.Title;

                result.Add(item);
            }

            return result;
        }

        public static void DeleteBookmarkItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();

            //created DeleteBookmark method from BookmarkDataSet
            adapter.DeleteBookmark(item.ID);
        }
    }
}
