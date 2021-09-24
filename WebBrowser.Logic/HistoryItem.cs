using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        public int ID { get; set; } //////added per shaffer video 1:20
        public string URL { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}
