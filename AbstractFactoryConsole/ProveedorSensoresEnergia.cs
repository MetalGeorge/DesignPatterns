namespace AbstractFactoryConsole
{
    public class ProveedorSensoresEnergia : AbstractFactoryProveedorSensores
    {
        public ProveedorSensoresEnergia()
        {
            this.CreaProveedor();
        }

        private ProductoAbstractoLecturas proveedor;
        public ProductoAbstractoLecturas CreaProveedor()
        {
            this.proveedor = new ProductoAbstractoLecturasEnergia();
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
