using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vetores {
    class Program {
        static void Main(string[] args) {



            Console.WriteLine("How many employees will be registered");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>(numeroFuncionarios);

            for (int i = 0; i < numeroFuncionarios; i++) {

                Console.WriteLine("Employee: #"+(i+1));
                Console.WriteLine("Qual a ID do funcionário?");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do funcionario");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual salario do funcionario");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));

                Console.WriteLine();
                Console.WriteLine("------------");
                Console.WriteLine();

                }
            char resp = 'n';
            do {
                Console.WriteLine("Enter the employee id that will have salary increase");
                int searchId = int.Parse(Console.ReadLine());

                Funcionario emp = list.Find(x => x.Id == searchId);


                if (emp != null) {
                    Console.WriteLine("Qual the percentage?");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.increaseSalary(percentage);
                    resp = 'n';
                } else {
                    Console.WriteLine("This is does not exist");
                    Console.WriteLine("Deseja tentar novamente?(s/n)");
                    resp = char.Parse(Console.ReadLine());

                }
            } while (resp == 's');

            Console.WriteLine("Bom noite");
            Console.WriteLine("Teste");



            Console.WriteLine("Update list of employees");
            Console.WriteLine();
            foreach (Funcionario obj in list) {
                Console.WriteLine(obj);
                

            }

        }
    }

}




