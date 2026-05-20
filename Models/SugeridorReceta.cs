public class SugeridorReceta
{
    public string nombre { get; set; }
    public DateTime fechaNacimiento { get; set; }
    public string tipoComida { get; set; }
    public int presupuesto { get; set; }
    public int cantidadComensales { get; set; }


public int CalcularEdad()
{
 int edad = DateTime.Today.Year - fechaNacimiento.Year;
 if(DateTime.Today.Month < fechaNacimiento.Month)
 {
    edad-=1;
 }
 else if(DateTime.Today.Month == fechaNacimiento.Month && DateTime.Today.Day < fechaNacimiento.Day)
 {
    edad-=1;
 }
 return edad;
}
public string DeterminarPlato()
{
    string platoSugerido="";
    if(tipoComida == "Caliente" && presupuesto < 3000)
    {
        platoSugerido = "Fideos con manteca";
    }
    else if(tipoComida == "Caliente" && presupuesto < 7000)
    {
        platoSugerido = "Arroz con verduras salteadas";
    }
    else if(tipoComida == "Caliente" && presupuesto > 7000)
    {
        platoSugerido = "Pollo al horno con guarnición";
    }
    else if(tipoComida == "Frío" && presupuesto < 3000)
    {
        platoSugerido = "Ensalada simple";
    }
    else if(tipoComida == "Frío" && presupuesto < 7000)
    {
        platoSugerido = "Ensalada completa con proteína";
    }
    else if(tipoComida == "Frío" && presupuesto > 7000)
    {
        platoSugerido = "Tabla de fiambres y quesos";
    }
    return platoSugerido;
}
public int calcularTiempo()
{
    int tiempo=0;
    if( cantidadComensales < 2 && tipoComida == "Caliente" || cantidadComensales > 1 && cantidadComensales <4 && tipoComida == "Caliente")
    {
        tiempo = 20;
    }
    else if(cantidadComensales > 3 && cantidadComensales < 8 && tipoComida == "Caliente")
    {
        tiempo = 40;
    }
    else if(cantidadComensales >= 8 && tipoComida == "Caliente")
    {
        tiempo = 80;
    }
    else if(cantidadComensales > 0 && cantidadComensales < 4 && tipoComida == "Frío")
    {
        tiempo = 10;
    }
    else if(cantidadComensales > 3 && cantidadComensales < 8 && tipoComida == "Frío")
    {
        tiempo = 20;
    }
    else if(cantidadComensales >= 8 && tipoComida == "Frío")
    {
        tiempo = 40;
           return tiempo;
    }
    return tiempo;
}
public string DeterminarDificultad()
{
    string dificultad = "";
    if(cantidadComensales <= 3 && presupuesto < 3000)
    {
        dificultad = "Principiante";
    }
    else if(cantidadComensales < 7 && presupuesto < 3000 || cantidadComensales <= 3 && presupuesto < 7000 || cantidadComensales <= 7 && presupuesto > 7000)
    {
        dificultad = "Intermedio";
    }
    else if(cantidadComensales >= 8)
    {
        dificultad = "Avanzado";
    }
    return dificultad;
}
}