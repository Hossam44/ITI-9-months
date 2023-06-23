using TrainingCenter.Models;

namespace TrainingCenter.Repositories
{
    public interface ICourseRepoistory
    {
        public List<Course> GetAll();
        public Course GetDetails(int id);
        public void Insert(Course std);
        public void UpdateCourse(int id, Course std);
        public void DeleteCourse(int id);
    }
}
