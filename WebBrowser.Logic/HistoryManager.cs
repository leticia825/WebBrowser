using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddItem(HistoryItem item)
        {
            try
            {
                if ((GetItem().Count > 0) )
                {
                    if (GetItem().Last().URL == item.URL &&
                        GetItem().Last().Title == item.Title)
                    {
                        return;
                    }
                }

                var adapter = new HistoryTableAdapter();
                adapter.Insert(item.URL, item.Title, item.Date);
            }
            catch (Exception ex)
            { 
                return; 
            }
        }

        public static List<HistoryItem> GetItem()
        {
            var adapter = new HistoryTableAdapter();
            var result = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach(var row in rows) 
            {
                var item = new HistoryItem();
                item.ID = row.Id;
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;

                result.Add(item);
            }

            return result;
        }

        public static void DeleteHistoryItem(HistoryItem item) 
        {
            var adapter = new HistoryTableAdapter();
            
            //created DeleteHistory method from HistoryDataSet
            adapter.DeleteHistory(item.ID);
        }

    } //end class
}
