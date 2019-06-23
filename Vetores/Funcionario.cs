namespace Vetores {
    class Funcionario {

        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public override string ToString() {
            return $"{Id}, {Name} , R$ {Salary}";
        }

        public  Funcionario(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;

        }

        public void increaseSalary(double porcentage) {
            Salary  += (Salary * porcentage)/ 100;
        }




    }
}
