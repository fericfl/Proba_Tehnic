using System.Runtime.CompilerServices;

namespace Catalog
{
    public class Student
    {
        public Persoana Elev { get; set; }
        public float medie_generala { get; set; }
        public string nume_faculta { get; set; }
        public void Medie(float medie_generala)
        {
            this.medie_generala = medie_generala;
        }
        public void Medie(float[] medii)
        {
            float medie_generala = 0;
            foreach (var medie in medii)
            {
                medie_generala += medie;
            }
            this.medie_generala = medie_generala/medii.Length;
        }
    }
}