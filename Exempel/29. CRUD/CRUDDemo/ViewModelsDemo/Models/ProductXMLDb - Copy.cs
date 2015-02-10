using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.UI;
using System.Xml.Linq;

namespace ViewModelsDemo.Models
{
    public class ProductXmlDb
    {
        private static readonly string PhysicalPath;


        private XDocument _document;

        private XDocument Document
        {
            get
            {
                return _document ?? (_document = XDocument.Load(PhysicalPath));
            }
        }

        static ProductXmlDb()
        {
            PhysicalPath = Path.Combine(
                AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Products.xml");
        }

        public List<Product> GetAll()
        {
            return (from product in Document.Descendants("product")
                    select ToProduct(product))
                    .OrderBy(b => b.Name)
                    .ToList();
        }

        public Product Get(Guid productId)
        {

            return (from product in Document.Descendants("product")
                    where product.Attribute("ID").Value.Equals(productId)
                    select ToProduct(product))
                .FirstOrDefault();
        }

        private Product ToProduct(XElement element)
        {
            var product = new Product
            {
                ProductId = Guid.Parse(element.Attribute("ID").Value),
                Name = element.Element("name").Value
            };

            return product;
        }

        private XElement CreateEmptyProduct()
        {
            var element = new XElement("product",
                new XAttribute("Id", Guid.Empty),
                new XElement("Name", string.Empty));

            return element;

        }

        private void UpdateElement(XElement element, Product product)
        {
            element.Attribute("Id").Value = product.ProductId.ToString();
            element.Element("Name").Value = product.Name;
        }


        public Product Add(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }
            product.ProductId = Guid.NewGuid();

            var element = CreateEmptyProduct();
            UpdateElement(element, product);
            Document.Root.Add(element);
            return product;
        }

        public bool Update(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }

            var savedElement = (from p in Document.Descendants("product")
                                where p.Attribute("ID").Value.Equals(product.ProductId)
                                select p)
                                .FirstOrDefault();

          
            if (savedElement == null)
            {
                return false;
            }

            UpdateElement(savedElement, product);
            return true;
        }
        
        public void Remove(Guid productId)
        {
            var savedElement = (from p in Document.Descendants("product")
                                where p.Attribute("ID").Value.Equals(productId)
                                select p)
                              .FirstOrDefault();


            if (savedElement != null)
            {
                savedElement.Remove();
            }

        }


        public void Save()
        {
            Document.Save(PhysicalPath);
        }

    }
}