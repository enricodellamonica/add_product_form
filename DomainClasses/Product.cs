using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses {
   public class Product {
       [Key]
       public int Product_Id { get; set; }
       public string ProductCode { get; set; }
       public string Title { get; set; }
       public string Version { get; set; }
       public string Description { get; set; }
       public string ProductURL { get; set; }
       public string VersionCheckURL { get; set; }
        }
    }
