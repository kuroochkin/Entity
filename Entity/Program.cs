using Entity;

using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    Student st1 = new Student {Surname = "Курочкин", Name = "Владислав", Age = 19, Group = "ПИН-21" };
    Student st2 = new Student { Surname = "Горбатых", Name = "Александр", Age = 18, Group = "ПИН-21" };
    Student st3 = new Student { Surname = "Келин", Name = "Кирилл", Age = 19, Group = "ПИН-21" };
    Student st4 = new Student { Surname = "Ярочевский", Name = "Максим", Age = 18, Group = "ПИН-21" };
    Student st5 = new Student { Surname = "Трусова", Name = "Полина", Age = 19, Group = "ПИН-21" };



    // добавляем их в бд
    db.Students.Add(st3);
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");

    // получаем объекты из бд и выводим на консоль
    var students = db.Students.ToList();
    Console.WriteLine("Список объектов:");
    foreach (Student u in students)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}