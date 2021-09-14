using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Joes_Pizza_Shop.Models
{
    public partial class PizzaItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PizzaItem()
        {
            this.CustomerOrderTables = new HashSet<CustomerOrderTable>();
        }

        [Key]
        public int PID { get; set; }
        public string PizzaName { get; set; }
        public double Price { get; set; }
        public string image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerOrderTable> CustomerOrderTables { get; set; }
    }
}

