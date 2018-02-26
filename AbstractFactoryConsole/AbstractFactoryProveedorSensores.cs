
namespace AbstractFactoryConsole
{
    public interface AbstractFactoryProveedorSensores
    {
        ProductoAbstractoLecturas CreaProveedor();
        string ObtieneNombreProveedor();
        double ObtieneLectura();
        string ObtieneUnidad();
    }
}
