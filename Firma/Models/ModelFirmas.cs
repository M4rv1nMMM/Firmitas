using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Firma.Models
{
    public class ModelFirmas
    {
        internal object b;

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(70)]
        public string name { get; set; }

        [MaxLength(70)]
        public string description { get; set; }

        public byte[] sign { get; set; }

    }
}
