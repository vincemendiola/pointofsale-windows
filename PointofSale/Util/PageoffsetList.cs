using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointofSale.Util
{
    public class PageOffsetList : IListSource
    {
        private long totalRecords;
        private int pageSize;

        public bool ContainsListCollection { get; protected set; }

        public PageOffsetList(long totalRecords, int pageSize)
        {
            this.totalRecords = totalRecords;
            this.pageSize = pageSize;
        }

        public IList GetList()
        {
            // Return a list of page offsets based on "totalRecords" and "pageSize"
            var pageOffsets = new List<int>();

            for (int offset = 0; offset < this.totalRecords; offset += this.pageSize)
            {
                pageOffsets.Add(offset);
            }

            return pageOffsets;
        }
    }
}
