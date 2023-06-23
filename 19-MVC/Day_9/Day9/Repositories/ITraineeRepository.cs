using TrainingCenter.Models;

namespace TrainingCenter.Repositories
{
    public interface ITraineeRepository
    {
        public List<Trainee> GetAll();
        public Trainee GetDetails(int id);
        public void Insert(Trainee std);
        public void UpdateTr(int id, Trainee std);
        public void DeleteTr(int id);
    }
}
