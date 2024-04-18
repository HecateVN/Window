using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;


namespace test.Model
{
    public partial class Job
    {
        [Column(TypeName = "Companyname")]
        public string Companyname { get; set; }
        [Column(TypeName = "Location")]
        public string Location { get; set; }
        [Column(TypeName = "Phone")]
        public int Phone { get; set; }
        [Column(TypeName = "JobPosition")]
        public string JobPosition { get; set; }
        [Column(TypeName = "Salary")]
        public string Salary { get; set; }
        [Column(TypeName = "JobDescription")]
        public string JobDescription { get; set; }

    }
}