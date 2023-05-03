namespace Blazor.Servicios
{
    public class ClienteServicio
    {
        private readonly Config _configuracion;
        private IClienteRepositorio clienteRepositorio;

        public ClienteServicio(Config config)
        {
            _configuracion = config;
            clienteRepositorio = new ClienteRepositorio(config.CadenaConexion);
        }
        public async Task<bool> Actualizar(Cliente cliente)
        {
            return await clienteRepositorio.Actualizar(cliente);
        }
        public async Task<bool> Eliminar(string identidad)
        {
            return await clienteRepositorio.Eliminar(identidad);
        }
        public async Task<IEnumerable<Cliente>> GetLista()
        {
            return await clienteRepositorio.GetLista();
        }
        public async Task<Cliente> GetPorCodigo(string identidad)
        {
            return await clienteRepositorio.GetPorCodigo(identidad);
        }
        public async Task<bool> Nuevo(Cliente cliente)
        {
            return await clienteRepositorio.Nuevo(cliente);
        }
    }
}
