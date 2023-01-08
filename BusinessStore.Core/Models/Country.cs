using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessStore.Data.Models;

public class Country : BaseModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public long Id { get; set; }
    
    [Column("code")]
    public int Code { get; set; }
    
    [Column("name")]
    public string Name { get; set; }
    
    [Column("full_name")]
    public string FullName { get; set; }
    
    [Column("code_2")]
    public string Code2 { get; set; }
    
    [Column("code_3")]
    public string Code3 { get; set; }
}
