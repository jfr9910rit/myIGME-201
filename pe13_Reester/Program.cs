using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace pe13_Reester
{
    class Pets
    {
        List<Pet> petList = new List<Pet>();
        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        public int Count
        {
            get { return petList.Count; }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        public void RemoveAt(int nPetEl)
        {
            petList.RemoveAt(nPetEl);
        }

    }

    public abstract class Pet
    {
        public string name;
        public int age;
        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void Eat();

        // Play method
        public abstract void Play();

        // Go to vet method
        public abstract void GotoVet();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    public class Cat : Pet, ICat
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public void Purr()
        {
            Console.WriteLine(name +": PURRRRRRRR");
        }

        public void Scratch()
        {
            Console.WriteLine(name + ": HISSSSSS");
        }

        public override void Eat()
        {
            Console.WriteLine("{0} is eating cat food.", Name);
        }

        public override void Play()
        {
            Console.WriteLine("{0} is playing with a ball of yarn.", Name);
        }

        public override void GotoVet()
        {
            Console.WriteLine("{0} is going to the cat vet.", Name);
        }
    }

    public interface ICat
    {
        void Scratch();
        void Eat();
        void Play();
        void Purr();
    }

    public interface IDog
    {
        void GotoVet();
        void Eat();
        void Play();
        void NeedWalk();
        void Bark();
    }


    public class Dog : Pet, IDog
    {
        public string License { get; set; }

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            License = szLicense;
        }

        public void NeedWalk()
        {
            Console.WriteLine(name + ": grabs the leash");
        }

        public void Bark()
        {
            Console.WriteLine(name + ": WOOF");
        }

        public override void Eat()
        {
            Console.WriteLine("{0} is eating dog food.", Name);
        }

        public override void Play()
        {
            Console.WriteLine("{0} is playing fetch.", Name);
        }

        public override void GotoVet()
        {
            Console.WriteLine("{0} is going to the dog vet.", Name);
        }
    }

    class main
    {
        static public void Main(String[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();
            Random rand = new Random();



            for(int i  = 0; i < 50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        // add a dog
                        Console.WriteLine("You bought a dog!");
                        Console.WriteLine("Dog's Name =>");
                        string stName = Console.ReadLine();
                        Console.WriteLine("Age =>");
                        int nAge = (int)Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("License =>");
                        string stLicense = Console.ReadLine();
                        dog = new Dog(stLicense, stName, nAge);
                        pets.Add(dog);
                    }
                    else
                    {
                        // else add a cat
                        Console.WriteLine("You bought a cat!");
                        Console.WriteLine("Cat's Name =>");
                        string stName = Console.ReadLine();
                        Console.WriteLine("Age =>");
                        int nAge = (int)Convert.ToInt64(Console.ReadLine());

                        cat = new Cat(stName, nAge);
                        pets.Add(cat);
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    thisPet = pets[rand.Next(0, pets.Count)];
                    if (thisPet == null)
                    {
                        continue;
                    }
                    else if (thisPet.GetType() == typeof(Dog))
                    {
                        
                        int action = rand.Next(0,4);
                        iDog = (IDog)thisPet;
                        if(action == 0)
                        {
                            iDog.Eat();
                        }
                        else if(action == 1)
                        {
                            iDog.GotoVet();
                        }
                        else if(action == 2)
                        {
                            iDog.Play();
                        }
                        else if(action == 3)
                        {
                            iDog.Bark();
                        }
                        else if(action == 4)
                        {
                            iDog.NeedWalk();
                        }
                    }
                    else if(thisPet.GetType() == typeof(Cat))
                    {
                        int action = rand.Next(0, 3);
                        iCat = (ICat)thisPet;
                        if (action == 0)
                        {
                            iCat.Eat();
                        }
                        else if (action == 1)
                        {
                            iCat.Play();
                        }
                        else if (action == 2)
                        {
                            iCat.Purr();
                        }
                        else if(action == 3)
                        {
                            iCat.Scratch();
                        }
                    }
                    
                }
            }

        }
    }
}
