namespace Set2Ex17
{
    internal class Program
    {
        public static (bool,int) VerificareParanteze(int[] secventa)
        {
           int nivelCurent = 0;
           int nivelMax = 0;
            foreach(int paranteza in secventa)
            {
                if (paranteza == 0)
                {
                    nivelCurent++;
                    if (nivelCurent >= nivelMax)
                    {
                        nivelMax = nivelCurent;
                    }
                }
                else if (paranteza == 1)
                {
                    nivelCurent--;
                    if (nivelCurent < 0)
                    {
                        return (false, 0);
                    }
                }
                else
                {
                    return(false, 0);
                }
            }
            return (nivelCurent == 0, nivelMax);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("introdu o seire de parantexe(0 pt paranteza deschisa si 1 pentru inchisa, separate prin spatiu): ");
            string input = Console.ReadLine();
            int[] secventa = Array.ConvertAll(input.Split(' '), int.Parse);

            var(corecta,nivelMaxim) = VerificareParanteze(secventa);

            if (corecta)
            {
                Console.WriteLine("Secvența este corectă.");
                Console.WriteLine("Nivelul maxim de incuibare este: " + nivelMaxim);
            }
            else
            {
                Console.WriteLine("Secvența este incorectă.");
            }
        }
    }
}
