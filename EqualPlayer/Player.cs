using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PClass {get;}
        public string Name {get;}
        public Player (PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ PClass.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Player other)
            {
                return Name == other.Name &&
                    PClass == other.PClass;
            }
            return false;
        }
    }
}