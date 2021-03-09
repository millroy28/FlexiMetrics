using System;
using System.Collections.Generic;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class SchemaStatus
    {
        public SchemaStatus()
        {
            SchemaLogs = new HashSet<SchemaLog>();
        }

        public int SchemaStatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<SchemaLog> SchemaLogs { get; set; }
    }
}
