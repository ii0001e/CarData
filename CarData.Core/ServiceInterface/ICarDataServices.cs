using CarData.Core.Dto;
using CarData.Core.Domain;

namespace CarData.Core.ServiceInterface
{
    public interface ICarDataServices
    {
        Task<CarData> Create(CarDataDto dto);
        Task<CarData> GetAsync(Guid id);

        Task<CarData> Update(CarDataDto dto);

        Task<CarData> Delete(Guid id);
    }
}
