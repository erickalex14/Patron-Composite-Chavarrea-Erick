//Componente de manera abstracta, esta vez no se implementa una interfaz
abstract class Empleado
{
    protected string nombre;
    protected decimal salario;
    public string Nombre 
    {
        set
        {
            nombre = value;    
        }
        get
        {
            return nombre;
        }
    }
    public decimal Salario 
    {
        set
        {
            salario = value;
        }
        get 
        {
            return salario;
        }
    }

    public Empleado(string nombre, decimal salario)
    {
        Nombre = nombre;
        Salario = salario;
    }
    //El metodo abstracto que se utilizara en las clases derivadas
    public abstract decimal CalcularSalarioTotal();
}

//En si esta clase vendria siendo la interfaz que se puede ver en algunos UML antes explicados en la exposicion
//Este método permite calcular el salario total de un empleado, considerando su propio salario y el salario total de sus subordinados en el caso de un gerente.