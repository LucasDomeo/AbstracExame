namespace aula146_ExercicioAbstratos.Entites.Contributor
{
    abstract class Base
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Base()
        {
        }
        public Base(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
