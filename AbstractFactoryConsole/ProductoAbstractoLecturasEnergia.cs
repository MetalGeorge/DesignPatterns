
namespace AbstractFactoryConsole
{
    public class ProductoAbstractoLecturasEnergia :ProductoAbstractoLecturas
    {
        public override void ConfiguraProveedor()
        {
            this.SeteaProveedor("CESSA");
            // valor de Prueba 
            this.SeteaSensor(15);
            this.SeteaUnidad("KWh/seg");
        }
    }
}
