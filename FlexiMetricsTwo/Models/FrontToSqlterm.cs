using System;
using System.Collections.Generic;

#nullable disable

namespace FlexiMetricsTwo.Models
{
    public partial class FrontToSqlterm
    {
        public string FrontFacingTerm { get; set; }
        public string Sqlterm { get; set; }
        public int? SqlTermTypeId { get; set; }

        public virtual ChangeType SqlTermType { get; set; }
    }
}
