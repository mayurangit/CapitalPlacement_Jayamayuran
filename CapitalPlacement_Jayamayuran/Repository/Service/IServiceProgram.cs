using CapitalPlacement_Jayamayuran.Data;
using CapitalPlacement_Jayamayuran.DTOs;
using CapitalPlacement_Jayamayuran.Repository.Interface;
using CapitalPlacement_Jayamayuran.Models;

namespace CapitalPlacement_Jayamayuran.Repository.Service
{
    public class IServiceProgram : InterfaceProgram
    {
        private readonly CPAppDbContext _db;
        public IServiceProgram(CPAppDbContext db) { 
            _db = db;
        }
        public bool Add(DTOProgram dTOProgram)
        {
            List<Question> questionList = new List<Question>();
            questionList = _db.Questions.ToList();
            foreach (Question question in questionList)
            {
                dTOProgram.Questions.Add(question);
            }
            var pro = new _Programm
            {

                Program_Title = dTOProgram.Program_Title,
                Program_Description = dTOProgram.Program_Description,
                Questions = dTOProgram.Questions,

            };
            try
            {
                _db.Programs.Add(pro);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<DTOProgram> GetAll()
        {
            var pros = _db.Programs.ToList();
            if (pros.Count == 0)
            {
                return null;
            }
            List<DTOProgram> obj = new List<DTOProgram>();
            for (int i = 0;i<pros.Count;i++)
            {
                DTOProgram dt = new DTOProgram
                {

                    Program_Title = pros[i].Program_Title,
                    Program_Description = pros[i].Program_Description,
                    Questions = pros[i].Questions,
                };
                obj.Add(dt);
                
            }
            return obj;
        }


    }
}
