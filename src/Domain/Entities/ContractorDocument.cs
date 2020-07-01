﻿using System;
using System.Collections.Generic;

namespace Pisheyar.Domain.Entities
{
    public partial class ContractorDocument
    {
        public int ContractorDocumentId { get; set; }
        public Guid ContractorDocumentGuid { get; set; }
        public int ContractorId { get; set; }
        public int TitleCodeId { get; set; }
        public int DocumentId { get; set; }
        public bool IsAccept { get; set; }

        public virtual Contractor Contractor { get; set; }
        public virtual Document Document { get; set; }
        public virtual Code TitleCode { get; set; }
    }
}
