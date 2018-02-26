namespace AbstractFactoryConsole
{
    public class ProveedorSensorAgua : AbstractFactoryProveedorSensores
    {
        public ProveedorSensorAgua()
        {
            this.CreaProveedor();
        }

        private ProductoAbstractoLecturas proveedor;
        public ProductoAbstractoLecturas CreaProveedor()
        {
            this.proveedor = new ProductoAbstractoLecturasAgua();
            this.proveedor.ConfiguraProveedor();
            return this.proveedor;
        }
        public string ObtieneNombreProveedor()
        {
            return this.proveedor.ObtieneProveedor();
        }
        public string ObtieneUnidad()
        {
            return this.proveedor.ObtieneUnidad();
        }
        public double ObtieneLectura()
        {
            // simula obtener el valor del sensor
            return this.proveedor.ObtieneValorSensor();
        }
    }
}
