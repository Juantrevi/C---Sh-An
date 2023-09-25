using Class2.Models;

/*Superman superman = new Superman();
superman.Fly();

Batman batman = new Batman();
batman.Fly();*/

Dog dog = new Dog();
Cat cat = new Cat();

List<Animal> animals = new List<Animal>();
animals.Add(dog);
animals.Add(cat);

foreach (Animal animal in animals)
{
    animal.move();
    animal.sound();
}



