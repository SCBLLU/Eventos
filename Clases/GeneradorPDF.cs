using Eventos.Modelos;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.EntityFrameworkCore;
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
                    document.Add(new Paragraph("Reporte de Eventos")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetMarginBottom(20));

                    var eventos = _context.Eventos
                        .Include(e => e.Sala)
                        .Include(e => e.Cliente)
                        .Include(e => e.Paquete)
                        .Include(e => e.Empleado)
                        .ToList();

                    // Crear tabla con anchos de columna ajustados
                    float[] columnWidths = { 2, 1.5f, 1.5f, 3, 1, 1.5f, 2, 1.5f, 2 };
                    Table table = new Table(columnWidths)
                        .UseAllAvailableWidth()
                        .SetMarginTop(10);

                    // Encabezados de la tabla con estilo
                    string[] headers = { "Evento", "Inicio", "Fin", "Descripción", "Estado", "Sala", "Cliente", "Paquete", "Empleado" };
                    foreach (var header in headers)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(header))
                            .SetBold()
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetPadding(5));
                    }

                    // Llenar la tabla con datos de eventos
                    foreach (var evento in eventos)
                    {
                        // Alternar color de fondo en las filas
                        bool isAlternateRow = (eventos.IndexOf(evento) % 2 == 0);
                        var backgroundColor = isAlternateRow ? DeviceGray.WHITE : new DeviceGray(0.9f);

                        table.AddCell(new Cell().Add(new Paragraph(evento.NombreEvento))
                            .SetBackgroundColor(backgroundColor)
                            .SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(evento.FechaInicio.ToString("dd/MM/yyyy")))
                            .SetBackgroundColor(backgroundColor)
                            .SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(evento.FechaFin.ToString("dd/MM/yyyy")))
                            .SetBackgroundColor(backgroundColor)
                            .SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(evento.Descripcion ?? "N/A"))
                            .SetBackgroundColor(backgroundColor)
                            .SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(evento.Estado ?? "N/A"))
                            .SetBackgroundColor(backgroundColor)
                            .SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(evento.Sala?.NombreSala ?? "N/A"))
                            .SetBackgroundColor(backgroundColor)
                            .SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(evento.Cliente != null ? $"{evento.Cliente.Nombre} {evento.Cliente.Apellido}" : "N/A"))
                            .SetBackgroundColor(backgroundColor)
                            .SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(evento.Paquete?.NombrePaquete ?? "N/A"))
                            .SetBackgroundColor(backgroundColor)
                            .SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(evento.Empleado != null ? $"{evento.Empleado.Nombre} {evento.Empleado.Apellido}" : "N/A"))
                            .SetBackgroundColor(backgroundColor)
                            .SetPadding(5));
                    }
                    document.Add(table);
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
                    document.Add(new Paragraph("Reporte de Empleados").SetFontSize(18).SetBold());

                    var empleados = _context.Empleados.ToList();

                    Table table = new Table(4); // Número de columnas

                    // Encabezados de la tabla
                    table.AddHeaderCell("Empleado");
                    table.AddHeaderCell("Puesto");
                    table.AddHeaderCell("Fecha de Contratación");
                    table.AddHeaderCell("Correo");

                    foreach (var empleado in empleados)
                    {
                        table.AddCell($"{empleado.Nombre} {empleado.Apellido}");
                        table.AddCell(empleado.Rol);
                        table.AddCell(empleado.FechaCreacion?.ToString() ?? "N/A");
                        table.AddCell(empleado.Email ?? "N/A");
                    }

                    document.Add(table);
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
                    document.Add(new Paragraph("Reporte de Salas").SetFontSize(18).SetBold());

                    var salas = _context.Salas.ToList();

                    Table table = new Table(3); // Número de columnas

                    // Encabezados de la tabla
                    table.AddHeaderCell("Sala");
                    table.AddHeaderCell("Capacidad");
                    table.AddHeaderCell("Ubicación");

                    foreach (var sala in salas)
                    {
                        table.AddCell(sala.NombreSala);
                        table.AddCell(sala.Capacidad.ToString());
                        table.AddCell(sala.Ubicacion ?? "N/A");
                    }

                    document.Add(table);
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
                    document.Add(new Paragraph("Reporte de Paquetes").SetFontSize(18).SetBold());

                    var paquetes = _context.Paquetes.ToList();

                    Table table = new Table(3); // Número de columnas

                    // Encabezados de la tabla
                    table.AddHeaderCell("Paquete");
                    table.AddHeaderCell("Descripción");
                    table.AddHeaderCell("Contenido");

                    foreach (var paquete in paquetes)
                    {
                        table.AddCell(paquete.NombrePaquete);
                        table.AddCell(paquete.Descripcion ?? "N/A");
                        table.AddCell(paquete.Articulos ?? "N/A");
                    }

                    document.Add(table);
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
                    document.Add(new Paragraph("Reporte de Clientes").SetFontSize(18).SetBold());

                    var clientes = _context.Clientes.ToList();

                    Table table = new Table(5); // Número de columnas

                    // Encabezados de la tabla
                    table.AddHeaderCell("Nombre");
                    table.AddHeaderCell("Apellido");
                    table.AddHeaderCell("Correo");
                    table.AddHeaderCell("Teléfono");
                    table.AddHeaderCell("Dirección");

                    foreach (var cliente in clientes)
                    {
                        table.AddCell(cliente.Nombre);
                        table.AddCell(cliente.Apellido);
                        table.AddCell(cliente.Email ?? "N/A");
                        table.AddCell(cliente.Telefono ?? "N/A");
                        table.AddCell(cliente.Direccion ?? "N/A");
                    }

                    document.Add(table);
                }
            }
        }
    }
}
