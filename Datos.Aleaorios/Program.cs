e->mes = aleatorio(1, 12);
e->anio = aleatorio(1950, 2022);
sexoAleatorio(e->sexo);
grupoAleatorio(e->grupo);
e->sueldo = (float)(aleatorio(8000, 20000));
e->seguroMedico = aleatorio(0, 1);
}
void imprimirEmpleado(Empleado e)
{
    printf("Datos del empleado:\n");
    printf("Número: %d\n", e.numero);
    printf("Nombre: %s\n", e.nombre);
    printf("Fecha nacimiento: %d de %s de %d\n", e.dia, mesAleatorio(e.mes), e.anio);
    printf("Sexo: %s\n", e.sexo);
    printf("Grupo: %s\n", e.grupo);
    printf("Sueldo: %.2f\n", e.sueldo);
    printf("Seguro médico: %s\n", e.seguroMedico ? "Sí" : "No");
}
int main()
{
    srand(time(NULL));  // Inicializar generador aleatorio
    Empleado empleado;
    generarEmpleadoAleatorio(&empleado);
    imprimirEmpleado(empleado);
    return 0;
}
