using System;
using System.Collections.Generic;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class ChangeRequest
    {
        public int ChangeRequestId { get; set; }
        public int? Author { get; set; }
        public int? SchemaId { get; set; }
        public int? ChangeTypeId { get; set; }
        public string NewValue { get; set; }
        public string ValueType { get; set; }
        public int? ParentId { get; set; }

        public virtual ChangeType ChangeType { get; set; }
        public virtual UserSchema Schema { get; set; }
    }
}
