﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blazor.Pages.MisClientes
{
    public partial class NuevoCliente : ComponentBase
    {
        [Inject] private IClienteServicio clienteServicio { get; set; }
        [Inject] private NavigationManager navigationManager { get; set; }
        private Cliente user = new Cliente();

        [Inject] SweetAlertService Swal { get; set; }
        protected async void Guardar()
        {
            if (string.IsNullOrEmpty(user.Identidad) || string.IsNullOrEmpty(user.Nombre) || string.IsNullOrEmpty(user.Direccion) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Telefono))
            {
                return;
            }
            bool inserto = await clienteServicio.Nuevo(user);

            if (inserto)
            {
                await Swal.FireAsync("Felicidades", "cliente Guardado", SweetAlertIcon.Success);
            }
            else
            {
                await Swal.FireAsync("Error", "No se puede guardar el cliente", SweetAlertIcon.Error);
            }
            navigationManager.NavigateTo("/Clientes");
        }
        protected void Cancelar()
        {
            navigationManager.NavigateTo("/Clientes");
        }
    }
}
