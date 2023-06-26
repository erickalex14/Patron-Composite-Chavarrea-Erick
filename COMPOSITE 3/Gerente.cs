//Clase composite, es decir esta clase sera una de las ramas de la estructura de arbol que se toma como referencia
class Gerente : Empleado
{
    //Se genera la lista de hojas que tendra esta rama de la estructura por asi decirlo, se utiliza Empleado, ya que asi podemos usar sus..
    //Clases hijas ya incluidas
    private List <Empleado> subordinados = new List<Empleado>();
    public Gerente(string nombre, decimal salario) : base(nombre, salario)
    {
    }
    //Este metodo funciona para agregra hojas a la rama, se agregan los empleados a la lsita de subordinados antes creada
    public void AgregarSubordinado(Empleado empleado)
    {
        subordinados.Add(empleado);
    }
    //Aqui el metodo cambia, este nos permite por cada subordinado que se tenga sumarle el salario del gerente de esta clase
    public override decimal CalcularSalarioTotal()
    {
        decimal salarioTotal = Salario;

        foreach (var subordinado in subordinados)
        {
            salarioTotal += subordinado.CalcularSalarioTotal();
        }

        return salarioTotal;
    }
}