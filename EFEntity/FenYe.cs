using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class FenYe
    {
        public int pageSize { get; set; }//
        public string keyName { get; set; }
        public string tableName { get; set; }
        public string where { get; set; }
        public int currentPage { get; set; }//当前页
        public int rows { get; set; }
        public int pages { get; set; }
    }
}
