using CapitalPlacement_Jayamayuran.DTOs;

namespace CapitalPlacement_Jayamayuran.Repository.Interface
{
    public interface InterfaceProgram 
    {
        public bool Add(DTOProgram dTOProgram);
        public List<DTOProgram> GetAll();
      
    }
}
