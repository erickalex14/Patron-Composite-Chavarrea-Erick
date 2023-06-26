internal class Program
{
    public static void Main(string[] args)
    {
        // Crear empleados simples u hojas
        Empleado empleado1 = new EmpleadoSimple("Empleado 1", 1000m);
        Empleado empleado2 = new EmpleadoSimple("Empleado 2", 1500m);

        // Crear gerentes u ramas
        Gerente gerente1 = new Gerente("Gerente 1", 3000m);
        Gerente gerente2 = new Gerente("Gerente 2", 4000m);

        // Agregar subordinados a los gerentes, practicamente encapsular las hojas en cada rama
        gerente1.AgregarSubordinado(empleado1);
        gerente2.AgregarSubordinado(empleado2);

        // Calcular el salario total de la empresa
        decimal salarioTotalEmpresa = gerente1.CalcularSalarioTotal() + gerente2.CalcularSalarioTotal();

        // Mostrar el salario total de la empresa
        Console.WriteLine("Salario total de la empresa: " + salarioTotalEmpresa);
    }
}

//Y asi, se podrian crear clases de podrian decirse dueños o chairmans los cuales encapsulen en si a gerentes con sus respectivos empleados
//Asi dandole la forma de estructura de arbol que se desea simplificando el codigo