using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erMars
{
    internal class Lien
    {
        Noeud left;
        Noeud right;

        public Lien(Noeud left, Noeud right)
        {
            this.left = left;
            this.right = right;
        }

        public Noeud LEFT
        {
            get { return left; }
        }

        public Noeud RIGTH
        {
            get { return right; }
        }
    }
}
