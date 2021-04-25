using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    class VinylsCollection : IItemCollection<Vinyl>
    {
        private List<Vinyl> vinyls = new List<Vinyl>();

        public void Add(Vinyl item)
        {
            vinyls.Add(item);
        }

        public Vinyl[] GetAll()
        {
            return vinyls.ToArray();
        }

        public Vinyl GetItemByID(int id)
        {
            foreach (Vinyl v in vinyls)
            {
                if (v.ID == id)
                    return v;
            }

            return null;
        }

        public bool Remove(Vinyl item)
        {
            if (vinyls.Contains(item))
            {
                vinyls.Remove(item);
                return true;
            }

            return false;
        }
    }
}
