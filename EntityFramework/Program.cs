using EntityFramework;

using (helloappContext db = new helloappContext())
{
    User artem = new User { Name = "Artem", Surname = "Stryzhakov" , LivePlace = "Tartu" , email = "artem@gmail.com", Age = 18 };
    User georgi = new User { Name = "Georgi", Surname = "Blinov" , LivePlace = "Tallinn" , email ="georg096@gmail.com", Age = 19 };

    // добавляем их в бд
    db.Users.Add(artem);
    db.Users.Add(georgi);
    db.SaveChanges();
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Objektide loend:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name},{u.Surname},{u.LivePlace},{u.email},{u.Age}");
    }
}