//Desafioentregable1 - Agustin Di Carlo
namespace DesafioEntregable1;

public class Usuario
{
    private int Id;
    private string Contraseña;
    private string NombreUsuario;

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Mail { get; set; }

    public Usuario()
    {
        this.Nombre = "";
        this.Apellido = "";
        this.Mail = "";
    }
}


public class Producto
{
    private int Id;
    private int IdUsuario;

    public string Descripcion { get; set; }
    public double Costo { get; set; }
    public double Precioventa { get; set; }
    public int Stock { get; set; }
}

public class ProductoVendido
{
    private int Id;
    private int IdProducto;
    private int IdVenta;
    public int Stock { get; set; }
}

public class Venta
{
    private int Id;
    public string Comentarios { get; set; }
}