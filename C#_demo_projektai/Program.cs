namespace C__demo_projektai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 projektas: Studento vardo, pavardes ir grupes ivedimas ir spausdinimas
            string studentName;
            string studentSurname;
            string studentGroup;

            Console.WriteLine("Iveskite studento varda: ");
            studentName = Console.ReadLine();

            Console.WriteLine("Iveskite studento pavarde: ");
            studentSurname = Console.ReadLine();

            Console.WriteLine("Iveskite studento grupe: ");
            studentGroup = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Informacija apie studenta:");
            Console.WriteLine($"Vardas: {studentName}, pavarde: {studentSurname}, grupe: {studentGroup}");
            Console.WriteLine();

            // 2 projektas: Darbuotojo vardo, pavardes ir atlyginimo ivedimas ir spausdinimas

            string employeeName, employeeSurname;
            double employeeWage;

            Console.WriteLine("Iveskite darbuotojo varda: ");
            employeeName = Console.ReadLine();

            Console.WriteLine("Iveskite darbuotojo pavarde: ");
            employeeSurname = Console.ReadLine();

            Console.WriteLine("Iveskite darbuotojo atlyginima, skaiciais: ");
            employeeWage = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Informacija apie darbuotoja:");
            Console.WriteLine("Darbuotojo " + employeeName +" " + employeeSurname + " atlyginimas " + employeeWage + " Eur.");
            Console.WriteLine();
        }
    }
}