using System;
using System.Collections.Generic;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class ChangeType
    {
        public ChangeType()
        {
            ChangeRequests = new HashSet<ChangeRequest>();
        }

        public int ChangeTypeId { get; set; }
        public string ChangeName { get; set; }

        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
    }
}
