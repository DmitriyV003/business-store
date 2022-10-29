using System.ComponentModel.DataAnnotations;

namespace BusinessStore.Data.Dto;

public class CreateUnitOfMeasureDto
{
    [Required]
    public string Code;
    
    [Required]
    public string Name;
}