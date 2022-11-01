using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Principal
    {
        List<Cliente> ListaClientes = new List<Cliente>();
        public void AltaCliente(int dni, string nombreApellido, int telefono, string correo, int idCliente)
        {
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.dni = dni;
            nuevoCliente.nombreApellido = nombreApellido;
            nuevoCliente.correo = correo;
            nuevoCliente.telefono = telefono;
            nuevoCliente.idCliente = idCliente;
            ListaClientes.Add(nuevoCliente);
        }
        public void BajaCliente( int idCliente)
        {
            Cliente nuevoCliente = new Cliente();
            var clienteEliminado = ListaClientes.Find(x => idCliente == x.idCliente);
            ListaClientes.Remove(clienteEliminado);
        }
        public void ModificarCliente(int dni, string nombreApelilido, string correo, int telefono, int idCliente)
        {
            var clienteModificado = new ListaClientes.Find(x => idCliente == xidCliente);
            clienteModificado.dni = dni;
            clienteModificado.nombreApellido = nombreApelilido;
            clienteModificado.correo = correo;
            clienteModificado.telefono = telefono;
            clienteModificado.idCliente = idCliente;
            var clienteEliminado = ListaClientes.Find(x => idCliente == x.idCliente);
            ListaClientes.Remove(clienteModificado);
            ListaClientes.Add(clienteModificado);
        }

        List<Producto> ListaProducto = new List<Producto>();
        public void BajaProducto(int idProduct )
        {
            Producto nuevoProducto = new Producto();
            var productoEliminado = ListaProducto.Find(x => idProduct == x.idProduct );
            ListaProducto.Remove(nuevoProducto);
        }
        public void AltaProducto(int precio, string descripcion, int cantidadTotal , int idProduct)
        {
            Producto nuevoProducto = new Producto();
            nuevoProducto.precio = precio;
            nuevoProducto.descripcion = descripcion;
            nuevoProducto.cantidadTotal = cantidadTotal;
            nuevoProducto.idProduct = idProduct;
            ListaProducto.Add(nuevoProducto);
        }

        public void ModificarProducto(int precio, string descripcion, int cantidadTotal, int idProduct)
        {
            var productoModificado = new ListaProducto.Find(x => idProduct == xidProduct);
            productoModificado.precio = precio;
            productoModificado.descripcion = descripcion;
            productoModificado.cantidadTotal = cantidadTotal;
            productoModificado.idProduct = idProduct;
            var productoEliminado = ListaProducto.Find(x => idProduct == x.idProduct);
            ListaProducto.Remove(productoModificado);
            ListaProducto.Add(productoModificado);
        }

        List<proveedor> ListaProveedor = new List<proveedor>();
        public void AltaProveedor(string nombreApellido, int idProveedor, int telefono, string correo, Direccion direccion)
        {
            proveedor nuevoProveedor = new proveedor();
            nuevoProveedor.idProveedor = idProveedor;
            nuevoProveedor.nombreApellido = nombreApellido;
            nuevoProveedor.telefono = telefono;
            nuevoProveedor.correo = correo;
            nuevoProveedor.direccion = direccion;
            ListaProveedor.Add(nuevoProveedor);

        }
        public void BajaProveedor (int idProveedor)
        {
            proveedor nuevoProveedor = new proveedor();
            var proveedorEliminado = ListaProveedor.Find(x => idProveedor == x.idProveedor);
            ListaProveedor.Remove(nuevoProveedor);
        }
        public void ModificarProveedor(int idProveedor, string nombreApellido, int telefono, string correo, string direccion)
        {
            var proveedorModificado = new ListaProveedor.Find(x => idProveedor == xidProveedor);
            proveedorModificado.idProveedor = idProveedor;
            proveedorModificado.nombreApellido = nombreApellido;
            proveedorModificado.telefono = telefono;
            proveedorModificado.correo = correo;
            proveedorModificado.direccion = direccion;
            var proveedorEliminado = ListaProveedor.Find(x => idProveedor == x.idProveedor);
            ListaProducto.Remove(proveedorModificado);
            ListaProducto.Add(proveedorModificado);
        }
            List<Empleado> ListaEmpleado = new List<Empleado>();
        public void AltaEmpleado(string nombreApellido, int idEmpleado, int telefono, string correo, Direccion direccion, float salario)
        {
            Empleado nuevoEmpleado = new Empleado();
            nuevoEmpleado.nombreApellido = nombreApellido;
            nuevoEmpleado.idEmpleado = idEmpleado;
            nuevoEmpleado.telefono = telefono;
            nuevoEmpleado.correo = correo;
            nuevoEmpleado.direccion = direccion;
            nuevoEmpleado.salario = salario;
            ListaEmpleado.Add(nuevoEmpleado);
        }
        public void BajaEmpleado (int idEmpleado)
        {
            Empleado nuevoEmpleado = new Empleado ();
            var empleadoEliminado = ListaEmpleado.Find(x => idEmpleado == x.idEmpleado);
            ListaEmpleado.Remove(nuevoEmpleado);
        }
        public void ModificarEmpleado(int idEmpleado, string nombreApellido, int telefono, string correo, string direccion, float salario)
        {
            var empleadoModificado = new ListaEmpleado.Find(x => idEmpleado == xidEmpleado);
            empleadoModificado.idEmpleado = idEmpleado;
            empleadoModificado.nombreApellido = nombreApellido;
            empleadoModificado.telefono = telefono;
            empleadoModificado.correo = correo;
            empleadoModificado.direccion = direccion;
            empleadoModificado.salario = salario;
            var empleadoEliminado = ListaEmpleado.Find(x => idEmpleado == x.idEmpleado);
            ListaEmpleado.Remove(empleadoModificado);
            ListaEmpleado.Add(empleadoModificado);
        }
        List<Ventas> ListaVentas = new List<Ventas>();
        public void AltaVentas (int idVentas, float ganancias,string formaPago,float recargo, DateTime fecha, Cliente idCliente , int idHistoricoVentas, int cantidad, descripcionArticulo descripcion)
        {
            Ventas nuevaVenta = new Ventas();
            nuevaVenta.idVentas = idVentas;
            nuevaVenta.ganancias = ganancias;
            nuevaVenta.formaPago = formaPago;
            nuevaVenta.recargo = recargo;
            nuevaVenta.fecha = fecha;
            nuevaVenta.idCliente = idCliente;
            nuevaVenta.idHistoricoVentas = idHistoricoVentas;
            nuevaVenta.cantidad = cantidad;
            nuevaVenta.descripcion = descripcion;
            ListaVentas.Add(nuevaVenta);


        }

        public void BajaVentas(int idVentas)
        {
            Ventas nuevoVenta = new Ventas();
            var ventaEliminado = ListaVentas.Find(x => idVentas == x.idVentas);
            ListaVentas.Remove(nuevoVenta);
        }
        public void ModificarVenta(int idVentas, float ganancias, string formaPago, float recargo, DateTime fecha, int idCliente , int idHistoricoVentas , int cantidad, string descripcion)
        {
            var ventaModificado = new ListaVentas.Find(x => idVentas == xidVentas);
            ventaModificado.idVentas = idVentas;
            ventaModificado.ganancias = ganancias;
            ventaModificado.formaPago = formaPago;
            ventaModificado.recargo = recargo;
            ventaModificado.fecha = fecha;
            ventaModificado.idCliente = idCliente;
            ventaModificado.idHistoricoVentas = idHistoricoVentas;
            ventaModificado.cantidad = cantidad;
            ventaModificado.descripcion = descripcion;
            var ventaEliminado = ListaVentas.Find(x => idVentas == x.idVentas);
            ListaVentas.Remove(ventaModificado);
            ListaVentas.Add(ventaModificado);
        }
    }   
    }
        


