using System;
using System.Collections.Generic;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class SchemaLog
    {
        public int SchemaLogId { get; set; }
        public int? SchemaId { get; set; }
        public int? SchemaStatusId { get; set; }
        public DateTime? Date { get; set; }
        public int? Author { get; set; }

        public virtual UserSchema Schema { get; set; }
        public virtual SchemaStatus SchemaStatus { get; set; }
    }
}
