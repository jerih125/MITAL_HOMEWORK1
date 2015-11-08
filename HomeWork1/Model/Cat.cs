using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;
        private int _health = 5;        
        public CatColor Color { get; set; }

        public Cat(CatColor color, string age)
        {
            Color = color;
            Age = age;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }


        public string Age { get; }


        public void Feed()
        {
            ++_health;
        }

        public void Punish()
        {
            --_health;
        }

        public string CurrentColor
        {
            get 
            {
                return _health< 5 ? Color.SickColor : Color.HealthyColor;
            }
        }
    }
}
