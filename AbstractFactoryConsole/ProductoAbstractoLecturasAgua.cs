
namespace AbstractFactoryConsole
{
    public class ProductoAbstractoLecturasAgua : ProductoAbstractoLecturas
    {
        public override void ConfiguraProveedor()
        {
            this.SeteaProveedor("ELAPAS");
            // valor de Prueba 
            this.SeteaSensor(99);
            this.SeteaUnidad("Lts/seg");
        }
    }
}
