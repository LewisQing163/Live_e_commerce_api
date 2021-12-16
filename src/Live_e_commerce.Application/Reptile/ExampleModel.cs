using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_e_commerce.Reptile
{
    public class ExampleModel
    {
        public string Name { get; set; }
        public string DetailUrl { get; set; }
        public string Category { get; set; }
        public string CategoryUrl { get; set; }
        public string DevLanguage { get; set; }
        public int DownloadCount { get; set; }
        public string DownloadSize { get; set; }
        public string DownloadUrl { get; set; }
        public int HotNum { get; set; }
        public int NeedScore { get; set; }
        public DateTime Pubdate { get; set; }
        public string PubPersion { get; set; }
        public List<string> Tags { get; set; }
    }
}
