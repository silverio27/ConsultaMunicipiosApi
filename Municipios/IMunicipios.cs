using System.Collections.Generic;
using System.Threading.Tasks;

namespace ibge.Municipios
{
    public interface IMunicipios
    {
        Task<List<Municipio>> Get();
    }

}