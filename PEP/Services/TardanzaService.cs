using System;
using System.Collections.Generic;

namespace RegistroTardanzas.Shared
{
    public static class TardanzaService
    {
        private static List<Tardanza> tardanzas = new();

        public static List<Tardanza> GetAllTardanzas()
        {
            return tardanzas;
        }

        public static void AddTardanza(Tardanza nuevaTardanza)
        {
            tardanzas.Add(nuevaTardanza);
        }
    }
}

