
namespace AbstractFactoryConsole
{
    public abstract class ProductoAbstractoLecturas
    {
        private string Proveedor { get; set; }
        private double ValorSensor { get; set; }
        private string Unidad { get; set; }

        public void SeteaProveedor(string proveedor)
        {
            this.Proveedor = proveedor;
        }

        public string ObtieneProveedor()
        {
            return this.Proveedor;
        }

        public void SeteaUnidad(string unidad)
        {
            this.Unidad = unidad;
        }

        public string ObtieneUnidad()
        {
            return this.Unidad;
        }

        public void SeteaSensor(double valorSensor)
        {
            this.ValorSensor = valorSensor;
        }

        public double ObtieneValorSensor()
        {
            return this.ValorSensor;
        }


        public abstract void ConfiguraProveedor();
    }
}
