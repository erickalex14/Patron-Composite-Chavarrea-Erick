//Esta clase viene siendo una clase simple u hoja en el esquema de arbol
class EmpleadoSimple:Empleado
{
    public EmpleadoSimple(string nombre, decimal salario) : base(nombre, salario)
    {
    }
    //El metodo solo retorna el salario que tiene el empleado, no hace ningun calculo aun ya que este pertenece a una de las ramas que se veran en siguientes clases.
    public override decimal CalcularSalarioTotal()
    {
        return Salario;
    }
}