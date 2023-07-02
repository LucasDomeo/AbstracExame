namespace aula146_ExercicioAbstratos.Entites.Contributor
{
    sealed class Physical : Base
    {
        public double Helth { get; set; }

        public Physical() 
        { 
        }
        public Physical(string name, double annualIncome, double helth):base(name, annualIncome)
        {
            Helth = helth;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000.00)
            {
                return (AnnualIncome * 0.15) - (Helth * 0.50);
            }
            else
            {
                return (AnnualIncome * 0.25) - (Helth * 0.50);
            }
        }
    }
}
