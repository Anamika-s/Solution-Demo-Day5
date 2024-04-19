namespace Project1
{
    struct Student
    {
        int rn;
        string name;
        string batch;
        int marks;
        // def const is there by def, but cannot be defined explictly
        //public Student()
        //{

        //}
        // we can only add 1 const that too shud be fully parameterized
        public Student(int rn, string name, string batch, int marks)
        {
            this.rn = rn;
            this.name = name;
            this.batch = batch;
            this.marks = marks;
        }
        public void Get()
        {

        }
        public void Display()
        {

        }
    }
    // Structures dont support inheritance
    //struct PartTimeStudent : Student
    //{

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
             Student student = new Student();
            student.Get();
            student.Display();
        }
    }
}