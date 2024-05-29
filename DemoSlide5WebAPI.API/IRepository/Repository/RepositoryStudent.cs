using DemoSlide5WebAPI.API.Model;

namespace DemoSlide5WebAPI.API.IRepository.Repository
{
    public class RepositoryStudent : IRepositoryStudent
    {
        Dictionary<int, Student> _students;
        public RepositoryStudent()
        {
            _students = new Dictionary<int, Student>();
            new List<Student>()
            {
                new Student() {Id=1,Name="Truong",MaSV="PH43922",Description=""},
                new Student() {Id=2,Name="Hung",MaSV="Ph12983",Description=""}

            }.ForEach(student => AddStudent(student));
        }
        public Student this[int id] => _students.ContainsKey(id) ? _students[id] : null;

        public IEnumerable<Student> Students => _students.Values;

        public Student AddStudent(Student student)
        {
            if (student.Id == 0)
            {
                int key = _students.Count;
                while (_students.ContainsKey(key))
                {
                    key++;
                }
                student.Id = key;
            }
            _students[student.Id] = student;
            return student;
        }

        public void DeleteStudent(int id) => _students.Remove(id);

        public Student UpdateStudent(Student student) => AddStudent(student);
    }
}
