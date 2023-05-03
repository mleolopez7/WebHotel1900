using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blazor.Pages.MisClientes
{
    public partial class Clientes : ComponentBase
    {

        [Inject] private IClienteServicio clienteServicio { get; set; }

        private IEnumerable<Cliente> lista { get; set; }

        protected override async Task OnInitializedAsync()
        {
            lista = await clienteServicio.GetLista();
        }

    }
}
