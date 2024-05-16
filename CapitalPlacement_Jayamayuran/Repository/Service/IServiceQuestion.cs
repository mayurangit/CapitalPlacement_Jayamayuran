using CapitalPlacement_Jayamayuran.Data;
using CapitalPlacement_Jayamayuran.DTOs;
using CapitalPlacement_Jayamayuran.Models;
using CapitalPlacement_Jayamayuran.Repository.Interface;

namespace CapitalPlacement_Jayamayuran.Repository.Service
{
    public class IServiceQuestion : InterfaceQuestion
    {
        private readonly CPAppDbContext _db;
        public IServiceQuestion(CPAppDbContext db)
        {
            _db = db;
        }
        public bool Add(DTOQuetion dTOQuetion)
        {
            if(dTOQuetion == null)
            {
                return false;
            }
            var question = new Question
            {
                Type = dTOQuetion.Type,
                Description = dTOQuetion.Description,
                Internal =  dTOQuetion.Internal,
                Hide = dTOQuetion.Hide,
                enable_other = dTOQuetion.enable_other,
                max_choices = dTOQuetion.max_choices,
                Choices = dTOQuetion.Choices,
            };
            try
            {
                _db.Questions.Add(question);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
               
            }
            return true;
        }

        public bool Delete(Guid id)
        {
            var question = _db.Questions.FirstOrDefault(X=>X.Qid == id);
            if (question != null)
            {
                _db.Questions.Remove(question);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public Question Get(Guid id)
        {
            var quest = _db.Questions.FirstOrDefault(x=>x.Qid== id);
            if(quest != null)
            {
                return quest;
            }
            return null;
        }

        public List<Question> GetAll()
        {
            return _db.Questions.ToList();
        }
        public Question update(Guid id, DTOQuetion dTOQuetion)
        {
            var x = _db.Questions.FirstOrDefault(x=>x.Qid==id);
            if (x != null)
            {
                x.Type = dTOQuetion.Type;
                x.Description = dTOQuetion.Description;
                x.Internal  = dTOQuetion.Internal;
                x.Hide = dTOQuetion.Hide;
                x.enable_other = dTOQuetion.enable_other;
                x.max_choices = dTOQuetion.max_choices;
                x.Choices = dTOQuetion.Choices;
                _db.SaveChanges();
                return x;

            }
            return null;
        }
    }
}
