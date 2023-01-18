using Common.Domain;
using CoreModule.Domain.Course.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace CoreModule.Domain.Course.Entities
{
    public class Course : BaseEntity
    {
        public Guid TeacherId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string VideoName { get; set; }
        public int Price { get; set; }
        public DateTime LastUpdate { get; set; }
        public SeoData SeoData { get; set; }

        public CourseLevel CourseLevel { get; set; }
        public CourseStatus CourseStatus { get; set; }


        public List<Section> Sections { get; set; }

    }
}
