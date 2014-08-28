using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses;

namespace DataLayer {
    public class Query {
        readonly InventoryFinanceConverterModel _db = Db.ConnectionString;


        public bool CheckUserAuthetication(string box1, string box2) {


            bool doesUserExist = _db.Users.Any(u => u.Name == box1 && u.Password == box2);

            return doesUserExist;

            }

        
        public void AddProduct(string code, string title, string version, string description, string url, string versionUrl)
        {
            var product = new Product();
            product.ProductCode = code;
            product.Title = title;
            product.Version = version;
            product.Description = description;
            product.ProductURL = url;
            product.VersionCheckURL = versionUrl;
            _db.Products.Add(product);
            _db.SaveChanges();

            }




        }

    }
