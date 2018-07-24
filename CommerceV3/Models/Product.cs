using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Product
    {
		public string Id { get; set; }
		[Display(Name = "Ad: ")]
		public string Name { get; set; }
		//[Display(Name = "Ad: ")]
		public string Slug { get; set; }
		[Display(Name = "Açıklama: ")]
		public string Description { get; set; }
		[Display(Name = "Eski Fiyatı: ")]
		public decimal OldPrice { get; set; }
		[Display(Name = "Fiyat: ")]
		public decimal Price { get; set; }
		[Display(Name = "Adet: ")]
		public int Quantity { get; set; }
		[Display(Name = "Stokta Var Mı ?: ")]
		public bool IsInStock { get; set; }
		[Display(Name = "Yayınlandı mı ?: ")]
		public bool IsPublished { get; set; }
		[Display(Name = "Yeni mi ?: ")]
		public bool IsNew { get; set; }
		[Display(Name = "Kargo Ücreti(Şehir): ")]
		public decimal ShippingPriceInCityWide { get; set; }
		[Display(Name = "Kargo Ücreti(Ülke): ")]
		public decimal ShippingPriceInCountryWide { get; set; }
		[Display(Name = "Kargo Ücreti(Dünya): ")]
		public decimal ShippingPriceInWorldWide { get; set; }

		public string SupplierId { get; set; }
		[ForeignKey("SupplierId")]
		public Supplier Supplier{ get; set; }

		public string BrandId { get; set; }
		[ForeignKey("BrandId")]
		public Brand Brand { get; set; }

		public virtual ICollection<ProductCategory> ProductCategories { get; set; }

		[Display(Name = "Oluşturan: ")]
		public string CreatedBy { get; set; }
		[Display(Name = "Oluşturulma Tarihi: ")]
		public DateTime CreateDate { get; set; }
		[Display(Name = "Güncelleyen: ")]
		public string UpdatedBy { get; set; }
		[Display(Name = "Güncelleme Tarihi: ")]
		public DateTime UpdateDate { get; set; }

		public virtual ICollection<CartItem> CartItems { get; set; }
	}
}
