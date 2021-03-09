using System;
using System.Collections.Generic;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class UserSchema
    {
        public UserSchema()
        {
            ChangeRequests = new HashSet<ChangeRequest>();
            SchemaLogs = new HashSet<SchemaLog>();
        }

        public int SchemaId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
        public virtual ICollection<SchemaLog> SchemaLogs { get; set; }
    }
}
