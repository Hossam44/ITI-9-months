using TrainingCenter.Data;
using TrainingCenter.Models;

namespace TrainingCenter.Repositories
{
    public class TraineeRepoService : ITraineeRepository
    {
        public ApplicationDbContext Context { get; }

        //request service of type mainDbContext to be injected in Ctor
        public TraineeRepoService(ApplicationDbContext context)
        {
            Context = context;
        }
        public void DeleteTr(int id)
        {

            Context.Trainee.Remove(Context.Trainee.Find(id));
            Context.SaveChanges();
        }

        public List<Trainee> GetAll()
        {
            return Context.Trainee.ToList();
        }

        public Trainee GetDetails(int id)
        {
            return Context.Trainee.Find(id);
        }

        public void Insert(Trainee std)
        {
            Context.Trainee.Add(std);
            Context.SaveChanges();
        }

        public void UpdateTr(int id, Trainee Tr)
        {
           Trainee TrUpdated = Context.Trainee.Find(id);

            TrUpdated.Name = Tr.Name;
            TrUpdated.Email = Tr.Email;
            TrUpdated.Gender = Tr.Gender;
            TrUpdated.MobileNo = Tr.MobileNo;
            TrUpdated.track = Tr.track;
            
            
            Context.SaveChanges();
        }
    }
}
