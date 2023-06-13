using Onique.EStore.SqlDataLayer.Dto;
using Onique.EStore.SqlDataLayer.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onique.EStore.SqlDataLayer.Repositoties
{
    public class ProductRepository
    {
        public List<ProductDto> Search(int? productId, string productName, string categoryName)
        {
            AppDbContext db = new AppDbContext();
            var query = from p in db.Products.AsNoTracking()
                        join c in db.Categories.AsNoTracking()
                        on p.ProductCategoryId equals c.CategoryId
                        join s in db.Suppliers.AsNoTracking()
                        on p.SupplierId equals s.SupplierId
                        select new ProductDto
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            ProductCategoryName = c.CategoryName,
                            Price = (int)p.Price,
                            Description = p.Description,
                            SupplierId = s.SupplierName,
                            AddedTime = p.AddedTime,
                            ShelfTime = p.ShelfTime,
                        };
            if (productId.HasValue)
            {
                query = query.Where(c => c.ProductId == productId);
            }
            if (!string.IsNullOrEmpty(productName))
            {
                query = query.Where(x => x.ProductName.Contains(productName));
            }
            if (!string.IsNullOrEmpty(categoryName))
            {
                query = query.Where(x => x.ProductCategoryName == categoryName);
            }
            return query.ToList();
        }
        public List<SizeDto> CreateSize(string SizeName)
        {
            AppDbContext db = new AppDbContext();
            var query = from ps in db.ProductSizes.AsNoTracking()
                        select new SizeDto
                        {
                            SizeId = ps.SizeId,
                            SizeName = ps.SizeName,
                        };
            if (!string.IsNullOrEmpty(SizeName))
            {
                query = query.Where(ps => ps.SizeName == SizeName);
            }
            return query.ToList();
        }

        public List<ColorDto> CreateColor()
        {
            AppDbContext db = new AppDbContext();
            var query = from pc in db.ProductColors.AsNoTracking()
                        select new ColorDto
                        {
                            ColorId = pc.ColorId,
                            ColorName = pc.ColorName,
                        };
            
            return query.ToList();
        }

        public ProductDto EditCategory(int productId)
        {
            AppDbContext db = new AppDbContext();
            var query = from p in db.Products.AsNoTracking()
                        join c in db.Categories.AsNoTracking()
                        on p.ProductCategoryId equals c.CategoryId
                        join s in db.Suppliers.AsNoTracking()
                        on p.SupplierId equals s.SupplierId
                        where (p.ProductId == productId)
                        select new ProductDto
                        {
                            ProductName = p.ProductName,
                            ProductCategoryName = c.CategoryName,
                            Price = (int)p.Price,
                            Description = p.Description,
                            SupplierId = s.SupplierName,
                            AddedTime = p.AddedTime,
                            ShelfTime = p.ShelfTime,
                        };

            return query.FirstOrDefault();
        }

        public ProductDto AddCategry()
        {
            AppDbContext db = new AppDbContext();
            var query = from p in db.Products.AsNoTracking()
                        join c in db.Categories.AsNoTracking()
                        on p.ProductCategoryId equals c.CategoryId
                        join s in db.Suppliers.AsNoTracking()
                        on p.SupplierId equals s.SupplierId
                        join psd in db.ProductStockDetails.AsNoTracking()
                        on p.ProductId equals psd.ProductId
                        join ps in db.ProductSizes.AsNoTracking()
                        on psd.SizeId equals ps.SizeId
                        join pc in db.ProductColors.AsNoTracking()
                        on psd.ColorId equals pc.ColorId
                        select new ProductDto
                        {
                            ProductName = p.ProductName,
                            ProductCategoryName = c.CategoryName,
                            Price = (int)p.Price,
                            Description = p.Description,
                            SupplierId = s.SupplierName,
                            AddedTime = p.AddedTime,
                            ShelfTime = p.ShelfTime,
                            SizeName = ps.SizeName,
                            ColorName = pc.ColorName
                        };
            return query.FirstOrDefault();
        }

        public List<string> AllMothed()
        {
            var db = new AppDbContext();
            var query = db.Categories
                .AsNoTracking()
                .Select(c => c.CategoryName.ToString());
            return query.ToList();
        }
        public List<string> Allsupplier()
        {
            var db = new AppDbContext();
            var query = db.Suppliers
                .AsNoTracking()
                .Select(c => c.SupplierName.ToString());
            return query.ToList();
        }
        public List<string> allSize()
        {
            var db = new AppDbContext();
            var query = db.ProductSizes.Where(ps => ps.SizeId == ps.SizeId).Select(ps => ps.SizeName);
            return query.ToArray().ToList();
        }
        public List<string> allColor()
        {
            var db = new AppDbContext();
            var query = db.ProductColors.Where(pc => pc.ColorId == pc.ColorId).Select(pc => pc.ColorName);
            return query.ToArray().ToList();
        }
    }
}
