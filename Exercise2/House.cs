using System;
namespace Exercise2
{
    public class House
    {
        protected int area;
        protected Door door;

        public House(int area)
        {
            this.area = area;
            door = new Door();
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }
        public Door Door
        {
            get { return door; }
            set { door = value; }
        }

        public virtual void ShowDate()
        {
            Console.WriteLine("I'm a house, my area is {0} m2",area);
        }
    }
    public class Door
    {
        protected string color;
        public string Color
        {
            get { return color; }
            set {color=value; }
        }

        public Door()
        {
            color = "Brown";
        }
        public Door(string color)
        {
            this.color = color;
        }
        public void showDate()
        {
            Console.WriteLine("I'm a door, my color is {0}", color);
        }
    }
    public class SmallApartment : House
    {
        public SmallApartment():base(50)
        {

        }
        public override void ShowDate()
        {
            Console.WriteLine("I'm an apartment, my area is "+area+" m2");
        }
    }
    public class Person
    {
        protected string name;
        protected House house;

        public string Name
        {
            get { return name; }
            set{ name = value; }
        }
        public House House
        {
            get { return house; }
            set { house = value; }
        }

        public Person()
        {
            name = "June";
            house = new House(50);
        }

        public Person(string name,House house)
        {
            this.name = name;
            this.house = house;
        }
        public void ShowDate()
        {
            Console.WriteLine("My name is {0}",name);
            house.ShowDate();
            house.Door.showDate();
        }
    }
}
