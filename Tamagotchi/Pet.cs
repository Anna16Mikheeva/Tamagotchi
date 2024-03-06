using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Pet
    {
        private string _name;
        private int _health = 10;
        private int _hungry = 10;
        private int _fatigue = 10;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }

        public int Hungry
        {
            get
            {
                return _hungry;
            }
            set
            {
                _hungry = value;
            }
        }

        public int Fatigue
        {
            get
            {
                return _fatigue;
            }
            set
            {
                _fatigue = value;
            }
        }
    }
}
