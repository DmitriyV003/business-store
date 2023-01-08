using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessStore.Data.Models;

public class Product : BaseModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }
    
    [Column("code")]
    public string Code { get; set; }
    
    [Column("work_name")]
    public string WorkName { get; set; }
    
    [Column("full_name")]
    public string FullName { get; set; }
    
    [Column("vat")]
    public int Vat { get; set; }
    
    [Column("price")]
    public long Price { get; set; }
    
    [Column("picture")]
    public string Picture { get; set; }
    
    [Column("description")]
    public string Description { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    [Column("deleted_at")]
    public DateTime DeletedAt { get; set; }
}
