using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluege.Model
{
    public class PassList
    {


        List<Passagier> PassListe = new List<Passagier>();

        public PassList() {

            PassListe.Add(new Passagier { PassagierId = 1, Vorname = "Huber", Name = "Huber", PassagierStatus = "da" });
            PassListe.Add(new Passagier { PassagierId = 2, Vorname = "Sepp", Name = "Sepp", PassagierStatus = "da" });
            PassListe.Add(new Passagier { PassagierId = 3, Vorname = "Lusche", Name = "Lusche", PassagierStatus = "da" });
            PassListe.Add(new Passagier { PassagierId = 4, Vorname = "Karl", Name = "Karl", PassagierStatus = "da" });
            PassListe.Add(new Passagier { PassagierId = 5, Vorname = "Holzer", Name = "Holzer", PassagierStatus = "da" });

        }

        public void AddPassagier(Passagier passagier) {

            passagier.PassagierId = PassListe.Max(f => f.PassagierId) + 1;
            PassListe.Add(passagier);
        }
        public List<Passagier> GetPassagierliste() {
            return PassListe;
        }

        public Passagier GetPassagier(string vorname, string name) {
            return PassListe
                   .Where(f => f.Vorname == vorname && f.Name == name)
                   .FirstOrDefault();
        }
        public Passagier GetPassagierById(int id) {
            return PassListe
                   .Where(f => f.PassagierId == id)
                   .FirstOrDefault();
        }




    }
}
