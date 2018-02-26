namespace AbstractFactoryConsole
{
    public class Cliente
    {
        private AbstractFactoryProveedorSensores proveedor;

        public Cliente(AbstractFactoryProveedorSensores proveedor)
        {
            this.proveedor = proveedor;
        }

        public string ObtieneNombreProveedor()
        {
            return this.proveedor.ObtieneNombreProveedor();
        }

        public double ObtieneLectura()
        {
          return this.proveedor.ObtieneLectura();
        }

        public string ObtieneUnidad()
        {
            return this.proveedor.ObtieneUnidad();
        }
    }
}
