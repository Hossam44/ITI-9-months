using TrainingCenter.Models;

namespace TrainingCenter.Repositories
{
    public interface ITrackRepoistory
    {
        public List<Track> GetAll();
        public Track GetDetails(int id);
        public void Insert(Track std);
        public void UpdateTrack(int id, Track std);
        public void DeleteTrack(int id);
    }
}
