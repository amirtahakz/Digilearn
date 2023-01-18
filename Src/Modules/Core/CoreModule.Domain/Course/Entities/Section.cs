using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreModule.Domain.Course.Entities
{
    public class Section : BaseEntity
    {
        public Section(int displayOrder, string title)
        {
            DisplayOrder = displayOrder;
            Title = title;
        }

        public string Title { get; private set; }
        public int DisplayOrder { get; private set; }

        public IEnumerable<Episode> Episodes { get; }
    }
}
