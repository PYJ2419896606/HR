using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FenYeModel
    {
        public int pageSize { get; set; }
        public string keyName { get; set; }
        public string tableName { get; set; }
        public string where { get; set; }
        public int currentPage { get; set; }
        public int rows { get; set; }
        public int pages { get; set; }
    }
}
