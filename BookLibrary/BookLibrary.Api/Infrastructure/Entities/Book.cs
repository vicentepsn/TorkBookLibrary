using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Api.Infrastructure.Entities
{
    public class Book : EntityWithIdBase
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public int TotalCopies { get; set; }
        public int CopiesInUse { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
