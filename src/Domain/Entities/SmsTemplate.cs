using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pisheyar.Domain.Entities
{
    [Table("SMSTemplate")]
    public partial class SmsTemplate
    {
        public SmsTemplate()
        {
            SmsResponse = new HashSet<SmsResponse>();
        }

        [Key]
        [Column("SMSTemplateID")]
        public int SmsTemplateId { get; set; }
        [Column("SMSTemplateGUID")]
        public Guid SmsTemplateGuid { get; set; }
        [Column("SMSProviderSettingID")]
        public int SmsProviderSettingId { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(SmsProviderSettingId))]
        [InverseProperty("SmsTemplate")]
        public virtual SmsProviderSetting SmsProviderSetting { get; set; }
        [InverseProperty("SmsTemplate")]
        public virtual ICollection<SmsResponse> SmsResponse { get; set; }
    }
}
