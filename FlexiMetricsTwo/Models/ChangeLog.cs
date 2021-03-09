using System;
using System.Collections.Generic;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class ChangeLog
    {
        public int? Author { get; set; }
        public int? SchemaId { get; set; }
        public int? ChangeTypeId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public int? OldStatusId { get; set; }
        public int? NewStatusId { get; set; }
        public DateTime? Date { get; set; }

        public virtual ChangeType ChangeType { get; set; }
        public virtual UserSchema Schema { get; set; }
    }
}
