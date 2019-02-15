using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFilesDownload.Models
{
    public class FileEntity
    {
        public string fileUrl { get; set; }
        public string fileName { get; set; }
        public string savePath { get; set; }
    }
}
