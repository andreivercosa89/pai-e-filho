using System;

namespace paiefilho
{
    class Program
    {
        static void Main(string[] args)
        {
            Pai pai = new Pai();
            Filho filho = new Filho();

            Console.Write("Informe o nome do filho: ");
            filho.nome = Console.ReadLine(); 

            Console.Write("Informe o nome do Pai: ");
            pai.nome = Console.ReadLine();
            Console.Write("Informe a idade do Pai: ");
            pai.idade =Convert.ToInt32(Console.ReadLine());


            filho.pai = pai;

            Console.Write("{0} filho de {1} que tem {2} anos", filho.nome,filho.pai.nome,filho.pai.idade);
        }
    }
}
