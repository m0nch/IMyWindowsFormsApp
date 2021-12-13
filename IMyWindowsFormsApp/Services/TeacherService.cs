using System;
using System.Collections.Generic;

namespace IMyWindowsFormsApp
{
    class TeacherService : ITeacherService
    {
        private readonly TeacherRepository _teacherRepository;

        public TeacherService(TeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public void Add(Teacher model)
        {
            _teacherRepository.Add(model);
        }

        public Teacher Get(Guid id)
        {
            return _teacherRepository.Get(id);
        }

        public List<Teacher> GetAll()
        {
            return _teacherRepository.GetAll();
        }

        public void Remove(Teacher model)
        {
            _teacherRepository.Remove(model);
        }

        public void Update(Teacher model) 
        {
            var oldTeacher = _teacherRepository.Get(model.Id);
            var index = _teacherRepository.IndexOf(oldTeacher);
            _teacherRepository.Update(model, index);
        }
    }
}
