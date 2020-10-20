using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCommercial
{
    public class Commercial
    {
        private string firstName, lastName;
        private int age, powerCar;
        private char cat;
        private List<NoteDeFrais> myList;

        public List<NoteDeFrais> MyList
        {
            get { return myList; }
            set { myList = value; }
        }

        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int PowerCar
        {
            get { return powerCar; }
            set { powerCar = value; }
        }
        public char Cat
        {
            get { return cat; }
            set { cat = value; }
        }

        public Commercial(string fn, string ln, int a, int p, char c)
        {
            this.firstName = fn;
            this.lastName = ln;
            this.age = a;
            this.powerCar = p;
            this.cat = c;
            this.myList = new List<NoteDeFrais>();
        }
        public void addNote(NoteDeFrais n)
        {
            this.myList.Add(n);
        }

        public override string ToString()
        {
            return $"Nom : {lastName} \nPrénom : {firstName} \nPuissance de voiture {powerCar} \nCatégorie : {cat}";
        }
    }
}