using System.ComponentModel.DataAnnotations;

namespace ins_mvr_his_california.Models
{
    public class QueryPayload
    {
        [Required]
        [StringLength(238, MinimumLength = 238, ErrorMessage = "The query must be exactly 238 characters long.")]
        public string Query { get; set; }
    }
}
