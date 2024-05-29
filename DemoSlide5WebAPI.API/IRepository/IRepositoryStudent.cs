using DemoSlide5WebAPI.API.Model;

namespace DemoSlide5WebAPI.API.IRepository
{
    public interface IRepositoryStudent
    {
        IEnumerable<Student> Students { get; }
        Student this[int id] { get; }
        Student AddStudent(Student student);
        Student UpdateStudent(Student student);
        void DeleteStudent(int id);
    }
}
