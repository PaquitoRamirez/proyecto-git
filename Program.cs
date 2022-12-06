using System;
using System.Collections.Generic;
using System.Linq;

namespace CadenasToNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
      
        List<SfcEstados> estados = new List<SfcEstados>();
             estados.Add(new SfcEstados() { CveEstado = 1,  DesEstadoFact = "Documentación Solicitada Proveedor"  });
             estados.Add(new SfcEstados() { CveEstado = 2,  DesEstadoFact = "Documentación en Revisión Proveedor" });
             estados.Add(new SfcEstados() { CveEstado = 3,  DesEstadoFact = "Documentación enviada para revisión CSA"});
             estados.Add(new SfcEstados() { CveEstado = 10, DesEstadoFact = "En revisión Acta Entrega Recepción  CSA"});
             estados.Add(new SfcEstados() { CveEstado = 13, DesEstadoFact = "VoBo CSA "});
             estados.Add(new SfcEstados() { CveEstado = 18, DesEstadoFact = "Of Doc Entregada al proveedor/Estatus final"});

        List<SftFacturas> sftFactura = new List<SftFacturas>();
             sftFactura.Add(new SftFacturas() { CveFactura = "21",  CveEstado = 2,  NumFacturaProveedor = "131231313" });
             sftFactura.Add(new SftFacturas() { CveFactura = "13",  CveEstado = 2,  NumFacturaProveedor = "folio392223" });
             sftFactura.Add(new SftFacturas() { CveFactura = "150", CveEstado = 12, NumFacturaProveedor = "folio392223" });
             sftFactura.Add(new SftFacturas() { CveFactura = "12",  CveEstado = 2,  NumFacturaProveedor = "1nhb102220-4" });
             sftFactura.Add(new SftFacturas() { CveFactura = "119", CveEstado = 4,  NumFacturaProveedor = "6789"});
             sftFactura.Add(new SftFacturas() { CveFactura = "131", CveEstado = 11, NumFacturaProveedor = "6456456"});
             sftFactura.Add(new SftFacturas() { CveFactura = "115", CveEstado = 13, NumFacturaProveedor = "12345"});
             sftFactura.Add(new SftFacturas() { CveFactura = "157", CveEstado = 12, NumFacturaProveedor = "folio392223"});
             sftFactura.Add(new SftFacturas() { CveFactura = "214", CveEstado = 11, NumFacturaProveedor = "folio39222"});
             sftFactura.Add(new SftFacturas() { CveFactura = "127", CveEstado = 11, NumFacturaProveedor = "6456456"});
             sftFactura.Add(new SftFacturas() { CveFactura = "136", CveEstado = 4,  NumFacturaProveedor = "folio392223"});
             sftFactura.Add(new SftFacturas() { CveFactura = "158", CveEstado = 2,  NumFacturaProveedor = "folio392223"});
             sftFactura.Add(new SftFacturas() { CveFactura = "315", CveEstado = 9,  NumFacturaProveedor = "4546"});
             sftFactura.Add(new SftFacturas() { CveFactura = "1",   CveEstado = 11, NumFacturaProveedor = ""});
             sftFactura.Add(new SftFacturas() { CveFactura = "22",  CveEstado = 11, NumFacturaProveedor = ""});
             sftFactura.Add(new SftFacturas() { CveFactura = "40",  CveEstado = 4,  NumFacturaProveedor = ""});
             sftFactura.Add(new SftFacturas() { CveFactura = "23",  CveEstado = 2,  NumFacturaProveedor = ""});
             sftFactura.Add(new SftFacturas() { CveFactura = "191",  CveEstado = 9,  NumFacturaProveedor = ""});             

            string split = "0,2,4,6,9,11";
            List<string> list = new List<string>();
            list = split.Split(',').ToList();

            string idnumfactura = "1";
            int limite = 50;
            var resultado = sftFactura
                            .Where(t => t.CveFactura.ToUpper().Contains(idnumfactura.ToUpper()) && list.Contains(t.CveEstado.ToString()))
                            .Take(limite)
                            .ToList();

            var  resultado2 = sftFactura
                            .Where(t => t.NumFacturaProveedor.ToUpper().Contains(idnumfactura.ToUpper()) && list.Contains(t.CveEstado.ToString()))
                            .Take(limite)
                            .ToList();

            var resultado3 =  resultado.Concat(resultado2);

            Console.WriteLine ("Resultado 1 ...");
            foreach (var item in resultado)
                Console.WriteLine(item.CveFactura);
            Console.WriteLine ();

            Console.WriteLine ("Resultado 2 ...");
            foreach (var item in resultado2)
                Console.WriteLine(item.CveFactura);
            Console.WriteLine ();

            Console.WriteLine ("Resultado 3 ...");
            foreach (var item in resultado3)
                Console.WriteLine(item.CveFactura);

            Console.WriteLine("Termina Programa ...");
        }
    }


}
