using BusinessStore.Data.Dto;
using BusinessStore.Data.Exceptions;
using BusinessStore.Data.Models;
using BusinessStore.Data.Repositories;

namespace BusinessStore.Data.Services;

public class UnitOfMeasureService
{
    private readonly IGenericRepository<UnitOfMeasure> _unitOfMeasures;

    public UnitOfMeasureService(IGenericRepository<UnitOfMeasure> unitOfMeasures)
    {
        _unitOfMeasures = unitOfMeasures;
    }

    public async void Create(CreateUnitOfMeasureDto dto)
    {
        var isExists = _unitOfMeasures.IsExists(x => x.Code == dto.Code);
        if (isExists)
        {
            throw new ServiceException($"Unit of Measure with code: {dto.Code} already created");
        }

        var uom = new UnitOfMeasure(dto.Name, dto.Code);
        await _unitOfMeasures.AddAsync(uom);
        await _unitOfMeasures.SaveAsync();
    }

    public async Task<ICollection<UnitOfMeasure>> GetAll()
    {
        return await _unitOfMeasures.GetAllAsync();
    }
}