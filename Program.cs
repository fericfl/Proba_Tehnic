using System;

namespace Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cati studenti vrei sa introduci in catalog:");
            int nrStudenti = Int32.Parse(Console.ReadLine());
            Student[] Catalog = new Student[nrStudenti];
            for (int i = 0; i < nrStudenti; i++)
            {
                Student student = new Student();
                Console.WriteLine("Care este numele persoanei?");
                string nume = Console.ReadLine();
                Console.WriteLine("Care este prenumele persoanei?");
                string prenume = Console.ReadLine();
                Console.WriteLine("Care este varsta persoanei?");
                int varsta = Int32.Parse(Console.ReadLine());
                student.Elev = new Persoana(nume, prenume, varsta);
                Console.WriteLine("La ce facultate este studentul?");
                student.nume_faculta = Console.ReadLine();
                Console.WriteLine("Ce medie a obtinut persoana?");
                student.Medie(float.Parse(Console.ReadLine()));
                Catalog[i] = student;
            }

            foreach (var student in Catalog)
            {
                Console.WriteLine($"Studentul {student.Elev.Nume} {student.Elev.Prenume} are {student.Elev.Varsta} ani, " +
                                  $"iar acesta este facultatea {student.nume_faculta}, unde a intrat cu media {student.medie_generala}");
            }
        }
    }
}
