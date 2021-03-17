using System;
using System.Collections.Generic;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class MasterSchema
    {
        public MasterSchema()
        {
            ChangeRequests = new HashSet<ChangeRequest>();
        }

        public int SchemaId { get; set; }
        public string Sqlname { get; set; }
        public string FacingName { get; set; }
        public string Sqltype { get; set; }
        public string FacingType { get; set; }
        public int? ParentSchemaId { get; set; }
        public bool? Active { get; set; }
        public int? PermissionLevel { get; set; }

        public virtual ICollection<ChangeRequest> ChangeRequests { get; set; }
    }
}
