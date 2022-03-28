using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace databaseconnect.Models
{
    public class Klub
    {
        public int KlubId { get; set; }
        public string KlubName { get; set; }
        public string KlubCityName { get; set; }
        public string KlubCountryName { get; set; }

    }



    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerLastName { get; set; }
        public string KlubName { get; set; }
        public string PlayerPosition { get; set; }

    }
}