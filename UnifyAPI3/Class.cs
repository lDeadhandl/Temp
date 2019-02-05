using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnifyAPI3
{
    public class School
    {
        private TeacherManager Manager { get; set; }

        public School()
        {
            Manager = new TeacherManager();
        }

        public School(TeacherManager manager)
        {
            Manager = manager;
        }

        public string DoSomeStuffWhereWeAddATeacher()
        {
            var teacher = Manager.GetTeacher("Bo");

            return teacher;
        }
    }

    public class TeacherManager
    {
        public List<string> Teachers { get; set; }

        public TeacherManager()
        {
            Teachers = new List<string>();
        }

        public void AddTeacher(string name)
        {
            Teachers.Add(name);
        }

        public string GetTeacher(string name)
        {
            return Teachers.FirstOrDefault(t => t == name);
        }




    }

    class TestSchool
    {
        public void TestMethod()
        {
            var manager = new TeacherManager();
            manager.AddTeacher("Bo");

            var s = new School(manager);

            var actualResult = s.DoSomeStuffWhereWeAddATeacher();
            var expectedResult = "Bo";

            var assertion = actualResult == expectedResult;
        }
    }
}
