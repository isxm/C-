namespace MyClasses
{
    public class Group
    {

        // Task 9
        public uint GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public Group(uint groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
    }
}