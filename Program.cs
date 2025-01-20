namespace Set2Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numarul de elemente din secventa: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa (0 pentru paranteza deschisa, 1 pentru paranteza inchisa): ");
            int count = 0; 
            int maxNivel = 0; 

            bool esteCorecta = true;

            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());

                if (element == 0)
                {
                    count++;
                    if (count > maxNivel)
                    {
                        maxNivel = count;
                    }
                }
                else if (element == 1)
                {
                    count--;
                    if (count < 0)
                    {
                        esteCorecta = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Element invalid. Secventa trebuie sa contina doar 0 si 1.");
                    return;
                }
            }

            if (count != 0)
            {
                esteCorecta = false;
            }

            if (esteCorecta)
            {
                Console.WriteLine("Secventa este corecta.");
                Console.WriteLine($"Nivelul maxim de incuibare este {maxNivel}.");
            }
            else
            {
                Console.WriteLine("Secventa NU este corecta.");
            }
        }
    }
}
