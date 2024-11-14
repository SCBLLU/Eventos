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

        // Constructor que inicializa el contexto de la base de datos
        public GeneradorPDF(EventosContext context)
        {
            _context = context;
        }

        // Método para generar un reporte de eventos en formato PDF
        public void GenerarReporteEventos(string filePath)
        {
            // Crea el objeto PdfWriter para escribir en el archivo PDF
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                // Crea el documento PDF usando el escritor
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    // Agrega el título del reporte con formato
                    document.Add(new Paragraph("Reporte de Eventos")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetMarginBottom(20));

                    // Consulta la base de datos para obtener la lista de eventos y sus relaciones
                    var eventos = _context.Eventos
                        .Include(e => e.Sala)
                        .Include(e => e.Cliente)
                        .Include(e => e.Paquete)
                        .Include(e => e.Empleado)
                        .ToList();

                    // Define los anchos de columna para la tabla de eventos
                    float[] columnWidths = { 2, 1.5f, 1.5f, 3, 1, 1.5f, 2, 1.5f, 2 };
                    Table table = new Table(columnWidths)
                        .UseAllAvailableWidth()
                        .SetMarginTop(10);

                    // Crea los encabezados de la tabla con estilo
                    string[] headers = { "Evento", "Inicio", "Fin", "Descripción", "Estado", "Sala", "Cliente", "Paquete", "Empleado" };
                    foreach (var header in headers)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(header))
                            .SetBold()
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetPadding(5));
                    }

                    // Llena la tabla con los datos de eventos, alternando colores en las filas para legibilidad
                    foreach (var evento in eventos)
                    {
                        bool isAlternateRow = (eventos.IndexOf(evento) % 2 == 0);
                        var backgroundColor = isAlternateRow ? DeviceGray.WHITE : new DeviceGray(0.9f);

                        // Agrega celdas con los datos del evento, usando un color de fondo según la fila
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
                    // Agrega la tabla al documento
                    document.Add(table);
                }
            }
        }

        // Método para generar un reporte de empleados en formato PDF
        public void GenerarReporteEmpleados(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    // Título del reporte
                    document.Add(new Paragraph("Reporte de Empleados")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetMarginBottom(20));

                    // Obtener la lista de empleados desde la base de datos
                    var empleados = _context.Empleados.ToList();
                    // Definir los anchos de columna
                    float[] columnWidths = { 2, 2, 2, 2 };
                    Table table = new Table(columnWidths).UseAllAvailableWidth().SetMarginTop(10);

                    // Encabezados de la tabla
                    string[] headers = { "Empleado", "Puesto", "Fecha de Contratación", "Correo" };
                    foreach (var header in headers)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(header))
                            .SetBold()
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetPadding(5));
                    }

                    // Llena la tabla con los datos de empleados
                    foreach (var empleado in empleados)
                    {
                        var backgroundColor = (empleados.IndexOf(empleado) % 2 == 0) ? DeviceGray.WHITE : new DeviceGray(0.9f);

                        table.AddCell(new Cell().Add(new Paragraph($"{empleado.Nombre} {empleado.Apellido}"))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(empleado.Rol))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(empleado.FechaCreacion?.ToString("dd/MM/yyyy") ?? "N/A"))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(empleado.Email ?? "N/A"))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                    }

                    // Agrega la tabla al documento
                    document.Add(table);
                }
            }
        }

        // Método para generar un reporte de salas en formato PDF
        public void GenerarReporteSalas(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Salas")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetMarginBottom(20));

                    // Obtener la lista de salas desde la base de datos
                    var salas = _context.Salas.ToList();
                    float[] columnWidths = { 3, 2, 3 };
                    Table table = new Table(columnWidths).UseAllAvailableWidth().SetMarginTop(10);

                    string[] headers = { "Sala", "Capacidad", "Ubicación" };
                    foreach (var header in headers)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(header))
                            .SetBold()
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetPadding(5));
                    }

                    foreach (var sala in salas)
                    {
                        var backgroundColor = (salas.IndexOf(sala) % 2 == 0) ? DeviceGray.WHITE : new DeviceGray(0.9f);

                        table.AddCell(new Cell().Add(new Paragraph(sala.NombreSala))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(sala.Capacidad.ToString()))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(sala.Ubicacion ?? "N/A"))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                    }

                    document.Add(table);
                }
            }
        }

        // Método para generar un reporte de paquetes en formato PDF
        public void GenerarReportePaquetes(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Paquetes")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetMarginBottom(20));

                    var paquetes = _context.Paquetes.ToList();
                    float[] columnWidths = { 2, 4, 4 };
                    Table table = new Table(columnWidths).UseAllAvailableWidth().SetMarginTop(10);

                    string[] headers = { "Paquete", "Descripción", "Contenido" };
                    foreach (var header in headers)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(header))
                            .SetBold()
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetPadding(5));
                    }

                    foreach (var paquete in paquetes)
                    {
                        var backgroundColor = (paquetes.IndexOf(paquete) % 2 == 0) ? DeviceGray.WHITE : new DeviceGray(0.9f);

                        table.AddCell(new Cell().Add(new Paragraph(paquete.NombrePaquete))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(paquete.Descripcion ?? "N/A"))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(paquete.Articulos ?? "N/A"))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                    }

                    document.Add(table);
                }
            }
        }

        // Método para generar un reporte de clientes en formato PDF
        public void GenerarReporteClientes(string filePath)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph("Reporte de Clientes")
                        .SetFontSize(18)
                        .SetBold()
                        .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                        .SetMarginBottom(20));

                    var clientes = _context.Clientes.ToList();
                    float[] columnWidths = { 2, 2, 3, 2, 3 };
                    Table table = new Table(columnWidths).UseAllAvailableWidth().SetMarginTop(10);

                    string[] headers = { "Nombre", "Apellido", "Correo", "Teléfono", "Dirección" };
                    foreach (var header in headers)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(header))
                            .SetBold()
                            .SetBackgroundColor(new DeviceGray(0.75f))
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetPadding(5));
                    }

                    foreach (var cliente in clientes)
                    {
                        var backgroundColor = (clientes.IndexOf(cliente) % 2 == 0) ? DeviceGray.WHITE : new DeviceGray(0.9f);

                        table.AddCell(new Cell().Add(new Paragraph(cliente.Nombre))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(cliente.Apellido))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(cliente.Email ?? "N/A"))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(cliente.Telefono ?? "N/A"))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                        table.AddCell(new Cell().Add(new Paragraph(cliente.Direccion ?? "N/A"))
                            .SetBackgroundColor(backgroundColor).SetPadding(5));
                    }

                    document.Add(table);
                }
            }
        }
    }
}
