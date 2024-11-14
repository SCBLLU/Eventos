using Eventos.Modelos;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Clases
{
    internal class GeneradorPDF
    {
        private readonly EventosContext _context;

        public GeneradorPDF(EventosContext context)
        {
            _context = context;
        }

        public void GenerarReporteEventos(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Eventos"));

                    var eventos = _context.Eventos.ToList();
                    foreach (var evento in eventos)
                    {
                        document.Add(new Paragraph($"Evento: {evento.NombreEvento}"));
                        document.Add(new Paragraph($"Fecha Inicio: {evento.FechaInicio}"));
                        document.Add(new Paragraph($"Fecha Fin: {evento.FechaFin}"));
                        document.Add(new Paragraph($"Descripción: {evento.Descripcion}"));
                        document.Add(new Paragraph($"Estado: {evento.Estado}"));
                        document.Add(new Paragraph(" "));
                    }
                }
            }
        }

        public void GenerarReporteEmpleados(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Empleados"));

                    var empleados = _context.Empleados.ToList();
                    foreach (var empleado in empleados)
                    {
                        document.Add(new Paragraph($"Empleado: {empleado.Nombre}"));
                        document.Add(new Paragraph($"Puesto: {empleado.Rol}"));
                        document.Add(new Paragraph($"Fecha de Contratación: {empleado.FechaCreacion}"));
                        document.Add(new Paragraph(" "));
                    }
                }
            }
        }

        public void GenerarReporteSalas(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Salas"));

                    var salas = _context.Salas.ToList();
                    foreach (var sala in salas)
                    {
                        document.Add(new Paragraph($"Sala: {sala.NombreSala}"));
                        document.Add(new Paragraph($"Capacidad: {sala.Capacidad}"));
                        document.Add(new Paragraph($"Ubicación: {sala.Ubicacion}"));
                        document.Add(new Paragraph(" "));
                    }
                }
            }
        }

        public void GenerarReportePaquetes(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Paquetes"));

                    var paquetes = _context.Paquetes.ToList();
                    foreach (var paquete in paquetes)
                    {
                        document.Add(new Paragraph($"Paquete: {paquete.NombrePaquete}"));
                        document.Add(new Paragraph($"Descripción: {paquete.Descripcion}"));
                        document.Add(new Paragraph($"Contenido: {paquete.Articulos}"));
                        document.Add(new Paragraph(" "));
                    }
                }
            }
        }

        public void GenerarReporteClientes(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Clientes"));

                    var clientes = _context.Clientes.ToList();
                    foreach (var cliente in clientes)
                    {
                        document.Add(new Paragraph($"Cliente: {cliente.Nombre}"));
                        document.Add(new Paragraph($"Apellido: {cliente.Apellido}"));
                        document.Add(new Paragraph($"Correo: {cliente.Email}"));
                        document.Add(new Paragraph($"Teléfono: {cliente.Telefono}"));
                        document.Add(new Paragraph($"Dirccion: {cliente.Direccion}"));
                        document.Add(new Paragraph(" "));
                    }
                }
            }
        }
    }
}
