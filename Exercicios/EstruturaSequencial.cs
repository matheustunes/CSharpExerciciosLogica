using System.Globalization;


namespace ExerciciosLogica.Exercicios
{
    public static class EstruturaSequencial
    {

        public static void CaucularAreaRetangulo()
        {

        }

        public static void ExercicioDois()
        {

        }
        public static void ExercicioTres()
        {

        }

        public static void CalcularIdadeMedia()
        {
            string nome1, nome2, cidade;
            int idade1, idade2;
            //double media;
            string[] vet;

            Console.WriteLine("Nesse programa vamos calcular a idade media de duas pessoas ! ");
            Console.WriteLine("primeiro passo insira o primeiro nome e idade:");
            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);
            Console.WriteLine("Escreva sua cidade:");
            //cidade = vet[2];
            cidade = Console.ReadLine();
            Console.WriteLine("Agora insira o segundo nome e idade !");
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0]; 
            idade2 = int.Parse(vet[1]);

            double media = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " é de "
                + media.ToString("F1", CultureInfo.InvariantCulture) + " anos ");

            string mediaFormatada = media.ToString("F1", CultureInfo.InvariantCulture);
            Console.WriteLine($"A idade media de {nome1} e {nome2} é de {mediaFormatada} anos ");
              

            Console.ReadLine();

        }

    }
}
