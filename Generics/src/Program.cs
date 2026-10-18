using Generics;

var studentStore = new Store<Student>();

studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
studentStore.Add(new Student { Id = 2, Name = "Mona" });
studentStore.Add(new Student { Id = 3, Name = "Omar" });
studentStore.Add(new Student { Id = 4, Name = "Sara" });
studentStore.Add(new Student { Id = 5, Name = "Ali" });

var student = studentStore.GetById(2);
Console.WriteLine($"Student: {student?.Name ?? "Not found"}");

var courseStore = new Store<Course>();

courseStore.Add(new Course { Id = 101, Title = "C#", Price = 1500m });
courseStore.Add(new Course { Id = 102, Title = ".NET", Price = 2000m });
courseStore.Add(new Course { Id = 103, Title = "SQL", Price = 1200m });

var course = courseStore.GetById(102);
Console.WriteLine($"Course: {course?.Title ?? "Not found"}");

try
{
    studentStore.Add(new Student { Id = 2, Name = "Duplicate" });
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Page 2 of students:");

foreach (var item in studentStore.GetAll().Page(2, 2))
{
    Console.WriteLine($"{item.Id}: {item.Name}");
}

var courseList = new List<Course>
{
    new Course { Id = 201, Title = "ASP.NET", Price = 2500m },
    new Course { Id = 202, Title = "EF Core", Price = 1800m },
    new Course { Id = 203, Title = "LINQ", Price = 1000m }
};

var foundCourse = courseList.FindById(202);
Console.WriteLine($"Found course: {foundCourse?.Title ?? "Not found"}");

// must NOT compile: new Store<string>();