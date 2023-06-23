using TrainingCenter.Data;
using TrainingCenter.Models;

namespace TrainingCenter.Repositories
{
    public class TrackRepoServices:ITrackRepoistory
    {
        public ApplicationDbContext Context { get; }

        //request service of type mainDbContext to be injected in Ctor
        public TrackRepoServices(ApplicationDbContext context)
        {
            Context = context;
        }
        public void DeleteTrack(int id)
        {

            Context.Track.Remove(Context.Track.Find(id));
            Context.SaveChanges();
        }

        public List<Track> GetAll()
        {
            return Context.Track.ToList();
        }

        public Track GetDetails(int id)
        {
            return Context.Track.Find(id);
        }

        public void Insert(Track std)
        {
            Context.Track.Add(std);
            Context.SaveChanges();
        }

        public void UpdateTrack(int id, Track Tr)
        {
           Track TrUpdated = Context.Track.Find(id);

            TrUpdated.Name = Tr.Name;
            TrUpdated.Description = Tr.Description;
            


            Context.SaveChanges();
        }

       
    }
}
