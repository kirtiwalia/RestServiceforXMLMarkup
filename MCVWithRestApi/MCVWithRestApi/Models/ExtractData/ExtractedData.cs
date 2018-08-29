using System.Collections.Generic;

namespace MCVAppWithRestApi.Models.ExtractData
{
    public class ExtractedData
    {
        public List<ExpenseClaim> ExpenseClaims { get; set; }

        public List<Reservation> Reservations { get; set; }

        public List<string> ErrorsInProcesing { get; set; }
    }
}