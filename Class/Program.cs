using Class;

Person person = new Person("Tom", 33);

(_, int age) = person;
    // Tom
Console.WriteLine(age);     // 33