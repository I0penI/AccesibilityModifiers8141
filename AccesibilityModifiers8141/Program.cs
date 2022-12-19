using System.Security.AccessControl;
using System.Xml.Serialization;

namespace AccesibilityModifiers8141
{
    // private -> protected -> internal -> public
    internal class Program
    {
        static void Main(string[] args)
        {
            object person1 = new Person();
            var person2 = (Person)person1;

            Animal animal = new Animal();

            Arac arac = new Arac();
            arac.id1internal = 1;
            arac.Id2internal = 2;
            arac.Sur();

            Firma firma = new Firma();
            firma.adi = "BubbleSOFT";
            firma.Sektoru = "Bilişim";
            firma.ZenginOl();
        }
    }
    class Person
    {
        private int id1private;
        int id2private; // default private

        private int Id3private { get; set; }
        private void Sleep()
        {
            id1private = 1;
            id2private = 2;
            Id3private = 3;
            int id4local = 4; // local, bu metoda ait
        }
        void Wake()
        {
            Sleep();
        }

        class Student : Person
        {
            void Study();
        }

        
    }
    class Animal
    {
        protected int id1protected;
        protected int Id2Protected { get; set; }
        protected void Breathe()
        {
            id1protected = 1;
            Id2Protected = 2;
        }
        void Live()
        {
            Breathe();
        }
    }
    class Dog : Animal
    {
        void Bark()
        {
            id1protected = 11;
            Id2Protected = 22;
        }
    }
    class Arac // default: internal
    {
        internal int id1internal;
        internal int Id2internal { get; set; }

        internal void Sur()
        {
            id1internal = 1;
            Id2internal = 2;
        }
    }
    class Araba : Arac
    {
        internal void Hizlan()
        {
            id1internal = 11;
            Id2internal = 22;
            Sur();
        }
    }
}