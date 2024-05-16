using CapitalPlacement_Jayamayuran.DTOs;
using CapitalPlacement_Jayamayuran.Models;

namespace CapitalPlacement_Jayamayuran.Repository.Interface
{
    public interface InterfaceQuestion
    {
        public bool Add(DTOQuetion dTOQuetion);
        public bool Delete(Guid id);

        public Question update(Guid id, DTOQuetion dTOQuetion);

        public Question Get(Guid id);

        //public List<Question> GetAll();
        public List<Question> GetAll();
    }
}
