using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDbase
{
    public class Hero
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _race;

        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        private string _aspect;

        public string Aspect
        {
            get { return _aspect; }
            set { _aspect = value; }
        }


        public Hero(string name, string race, string aspect)
        {
            _name = name;
            _race = race;
            _aspect = aspect;
        }
    }
}
