using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace ViewModelsDemo.Models
{
    public class XmlRepository : IRepository
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

        static XmlRepository()
        {
            PhysicalPath = Path.Combine(
                AppDomain.CurrentDomain.GetData("DataDirectory").ToString(),
                "Products.xml");
        }

        public List<Product> GetProducts()
        {
            return (from product in Document.Descendants("Product")
                    select new Product
                    {
                        ProductId = Guid.Parse(product.Attribute("Id").Value),
                        Name = product.Element("Name").Value,
                        Description = product.Element("Description").Value,
                        Price = Decimal.Parse(product.Element("Price").Value),
                        Supplier = product.Element("Supplier").Value
                    }).OrderBy(p => p.Name).ToList();
        }

        public Product GetProduct(Guid id)
        {
            return (from product in Document.Descendants("Product")
                    where Guid.Parse(product.Attribute("Id").Value).Equals(id)
                    select new Product
                    {
                        ProductId = Guid.Parse(product.Attribute("Id").Value),
                        Name = product.Element("Name").Value,
                        Description = product.Element("Description").Value,
                        Price = Decimal.Parse(product.Element("Price").Value),
                        Supplier = product.Element("Supplier").Value
                    })
              .FirstOrDefault();
        }

        public void AddProduct(Product product)
        {
            var element = new XElement("Product",
                      new XAttribute("Id", product.ProductId.ToString()),
                      new XElement("Name", product.Name),
                      new XElement("Description", product.Description),
                      new XElement("Price", product.Price.ToString()),
                      new XElement("Supplier", product.Supplier));

            Document.Root.Add(element);
        }

        public void UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }

            var element = (from p in Document.Descendants("Product")
                           where Guid.Parse(p.Attribute("Id").Value).Equals(product.ProductId)
                                select p)
                                .FirstOrDefault();

            if (element != null)
            {
                element.Element("Name").Value = product.Name;
                element.Element("Description").Value = product.Description;
                element.Element("Price").Value = product.Price.ToString();
                element.Element("Supplier").Value = product.Supplier;

                Save();
            }
        }

        public void DeleteProduct(Product product)
        {
            var element = (from p in Document.Descendants("Product")
                                where Guid.Parse(p.Attribute("Id").Value).Equals(product.ProductId)
                                select p)
                              .FirstOrDefault();

            if (element != null)
            {
                element.Remove();
                Save();
            }
        }

        public void Save()
        {
            Document.Save(PhysicalPath);
        }

        #region IDisposable

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // här skall resursen tas bort - anropa dispose
                    // XDocument hanterar det själv...
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}

