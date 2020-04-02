using System.Collections.Generic;

namespace BenjaminCamacho.Services
{
    public interface IEmployyeService
    {
        IEnumerable<BenjaminCamacho.Models.Employee> GetAll();
    }
}