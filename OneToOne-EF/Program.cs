// See https://aka.ms/new-console-template for more information
using OneToOne_EF;

Console.WriteLine("One To One rlationShip - DATABASE");
MyDbContext Context = new MyDbContext();

List<Students> studentsList = Context.Students.ToList();

foreach (var student in studentsList)
{
    Console.WriteLine($"{student.FirstName.PadRight(10)}{student.LasttName}");
}

Console.WriteLine("\n");

List<Courses> coursesList = Context.Courses.ToList();
for (int i = 0; i < coursesList.Count; i++)
{
    Console.WriteLine(coursesList[i].CourseName.PadRight(15) + coursesList[i].CourseKredit.ToString().PadRight(10) +
        coursesList[i].CourseGrade.ToString().PadRight(10) );
}