using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutZebras
{
    class Studbook
    {
        private String name;
        private List<Zebra> zebras;

        /// <summary>
        /// creates a Studbook-object with name equal to the parameter name.
        /// It has an empty collection of zebras.
        /// </summary>
        /// <param name="name"></param>
        public Studbook(String name)
        {//todo
            this.name = name;
            zebras = new List<Zebra>();
        }

        public String Name { get { return this.name; } }

        /// <summary>
        /// returns a list of all zebras
        /// </summary>
        /// <returns></returns>
        public List<Zebra> GetAllZebras() { return this.zebras; }

        /// <summary>
        /// if there is a zebra with identity id, that zebra is returned;
        /// otherwise the returnvalue is null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Zebra GetZebra(int id)
        {
            foreach (Zebra z in this.zebras)
            {
                if (z.Id == id) { return z; }
            }
            return null;
        }

        /// <summary>
        /// if this studbook already has a zebra with the same id as the id of zebra z
        /// then nothing is added and the returnvalue is false;
        /// otherwise z is added to the list of zebras and the returnvalue is true
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        public bool AddZebra(Zebra z)
        {//todo
            if (GetZebra(z.Id) == null)
            {
                zebras.Add(z);
                return true;
            }
            return false;
        }

        /// <summary>
        /// returns a list of all zebras, of which the father-id is equal to idFather
        /// </summary>
        /// <param name="idFather"></param>
        /// <returns></returns>
        public List<Zebra> GetZebrasWithFather(int idFather)
        {//todo
            List<Zebra> fatherZebras = new List<Zebra>();
            foreach (Zebra zebra in zebras)
            {
                if (zebra.FatherId == idFather)
                {
                    fatherZebras.Add(zebra);
                }
            }
            return fatherZebras;
        }

        /// <summary>
        /// for the zebra with identity equal to id, this method returns a list of its ancestors in the mother-line.
        /// So it returns a list of zebras:
        /// the zebra with identity id, the mother of this zebra, the mother of the mother of this zebra, etc..
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Zebra> GetAncestorsInMotherline(int id)
        {//todo
            List<Zebra> motherLineZebras = new List<Zebra>();
            foreach (Zebra zebra in zebras)
            {
                if (zebra.Id == id || id == zebra.Id)
                {
                    motherLineZebras.Add(zebra);
                    motherLineZebras.Add(GetZebra(zebra.MotherId));
                }
            }
            return motherLineZebras;

        }
    }
}
