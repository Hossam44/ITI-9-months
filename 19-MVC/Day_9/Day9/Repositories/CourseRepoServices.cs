using TrainingCenter.Data;
using TrainingCenter.Models;

namespace TrainingCenter.Repositories
{
    public class CourseRepoServices : ICourseRepoistory
    {
        public ApplicationDbContext Context { get; }

        //request service of type mainDbContext to be injected in Ctor
        public CourseRepoServices(ApplicationDbContext context)
        {
            Context = context;
        }
        public void DeleteCourse(int id)
        {

            Context.Course.Remove(Context.Course.Find(id));
            Context.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return Context.Course.ToList();
        }

        public Course GetDetails(int id)
        {
            return Context.Course.Find(id);
        }

        public void Insert(Course cs)
        {
            Context.Course.Add(cs);
            Context.SaveChanges();
        }

        public void UpdateCourse(int id, Course Cs)
        {
            Course TrUpdated = Context.Course.Find(id);

            TrUpdated.Topic = Cs.Topic;
            TrUpdated.Grade = Cs.Grade;
            

            Context.SaveChanges();
        }

        
    }
}
