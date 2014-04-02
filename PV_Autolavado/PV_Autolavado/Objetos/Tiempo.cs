using System;

namespace PV_Autolavado.Objetos
{
    class Tiempo
    {
        public String Hora()
        {
            var hh = DateTime.Now.Hour.ToString();
            var mm = DateTime.Now.Minute.ToString();
            var ss = DateTime.Now.Second.ToString();

            if (hh.Length < 2) { hh = "0" + hh; }
            if (mm.Length < 2) { mm = "0" + mm; }
            if (ss.Length < 2) { ss = "0" + ss; }

            return hh + ":" + mm + ":" + ss;
        }

        public String fechaCorta()
        {
            var DD = DateTime.Now.Day.ToString();
            var MM = DateTime.Now.Month.ToString();
            var YY = DateTime.Now.Year.ToString();

            if (DD.Length < 2) { DD = "0" + DD; }
            if (MM.Length < 2) { MM = "0" + MM; }
            if (YY.Length < 2) { YY = "0" + YY; }

            return YY + "/" + MM + "/" + DD;
        }

        public String convertirAFormatoHoraMySQL(DateTime hora)
        {
            var hh = hora.Hour.ToString();
            var mm = hora.Minute.ToString();
            var ss = hora.Second.ToString();

            if (hh.Length < 2) { hh = "0" + hh; }
            if (mm.Length < 2) { mm = "0" + mm; }
            if (ss.Length < 2) { ss = "0" + ss; }

            return hh + ":" + mm + ":" + ss;
        }

        public String convertirAFormatoFechaMySQL(DateTime fecha)
        {
            var DD = fecha.Day.ToString();
            var MM = fecha.Month.ToString();
            var YY = fecha.Year.ToString();

            if (DD.Length < 2) { DD = "0" + DD; }
            if (MM.Length < 2) { MM = "0" + MM; }
            if (YY.Length < 2) { YY = "0" + YY; }

            return YY + "/" + MM + "/" + DD;
        }

    }
}
