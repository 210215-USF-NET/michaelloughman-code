using System;
using System.Diagnostics;
/* 
Class members in java:
fields, constructors, methods, getters & setters

in c#, fields, properties, methods, constructors
fields -- characteristics of your object
methods - behaviors of your object
constructors - specialized method that gets called when you create an instance of
an object, 

properties - "smart fields"
    - in java you need to have a field for a getter and setter

POCO - plain old c# object
- class that holds data
*/
namespace ToHModels
{
    /// <summary>
    /// Data structure used for modeling a Hero
    /// </summary>
    
    public class Hero
    {
        private string heroName;

        private int hP;

        public string HeroName { 
            get {return heroName; } 
            set {
                if (value.Equals(null)) { }//TODO: throw exception
                heroName = value;
            } 
            
        }

        public int HP { get; set; }
        public Element ElementType { get; set; }
        public SuperPower SuperPower { get; set; }

    }
}
