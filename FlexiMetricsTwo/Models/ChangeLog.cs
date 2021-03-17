using System;
using System.Collections.Generic;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class ChangeLog
    {
        public int? UserId { get; set; }
        public int? SchemaId { get; set; }
        public int? ChangeTypeId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime? TimeStamp { get; set; }

        public virtual ChangeType ChangeType { get; set; }
        public virtual MasterSchema Schema { get; set; }
    }
}
