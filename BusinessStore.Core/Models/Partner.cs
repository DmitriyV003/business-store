using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessStore.Data.Models;

public class Partner : BaseModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }
    
    [Column("tin")]
    public string Tin { get; set; }
    
    [Column("abbreviation")]
    public string Abbreviation { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Column("international_name")]
    public string InternationalName { get; set; }
    
    [Column("crtr")]
    public string Crtr { get; set; }
        
    [Column("registration_number")]
    public string RegistrationNumber { get; set; }
        
    [Column("registration_date")]
    public DateTime RegistrationDate { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    [Column("deleted_at")]
    public DateTime DeletedAt { get; set; }
}
