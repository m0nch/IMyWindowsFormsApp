using System;
using System.Collections.Generic;

namespace IMyWindowsFormsApp
{
    class StudentService : IStudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Add(Student model)
        {
            _studentRepository.Add(model);
        }

        public Student Get(Guid id)
        {
            return _studentRepository.Get(id);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public void Remove(Student model)
        {
            _studentRepository.Remove(model);
        }

        public void Update(Student model) 
        {
            var oldStudent = _studentRepository.Get(model.Id);
            var index = _studentRepository.IndexOf(oldStudent);
            _studentRepository.Update(model, index);
        }
    }
}
