using System;
using System.Linq;
using MyClasses;

namespace MyExtensions
{
    public static class StudentCollectionExtensions
    {
        // Task 3 First before last
        public static Student[] FirstNameBeforeLastName(this Student[] students)
        {
            var result = students.Where(x => (x.FirstName).CompareTo(x.LastName) < 0).ToArray();
            return result;
        }

        // Task 4 students with age between 18 and 24 finds first name and last name
        public static Student[] AgeBetween18and24(this Student[] students)
        {
            var result = students.Where(x => x.Age >= 18 && x.Age <= 24).ToArray();
            return result;
        }

        // Task 5 Order students
        public static void GroupedByGroupNumber(this Student[] students)
        {
            var group =
                   from student in students
                   group student by student.Group.GroupNumber into newGroup
                   orderby newGroup.Key
                   select newGroup;
            foreach (var nameGroup in group)
            {
                Console.WriteLine("Group: {0}", nameGroup.Key);
                foreach (var student in nameGroup)
                {
                    Console.WriteLine("\t{0}, {1}", student.FirstName, student.LastName);
                }
            }
        }
    }
}