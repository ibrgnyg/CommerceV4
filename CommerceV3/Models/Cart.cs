using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Cart
    {
		public Cart()
		{
			IsActive = true;
		}
		public String Id { get; set; }
        [Display(Name ="Sahip")]

        public String Owner { get; set; }
		public virtual ICollection<CartItem> CardItems { get; set; }
        [Display(Name ="Oluşturan Kullanıcı")]

        public String CreatedBy { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Oluşturan Kullanıcı")]
        public String UpdatedBy { get; set; }
        [Display(Name = "Guncelleme Tarihi")]
        public DateTime UpdateDate { get; set; }

		public bool IsActive { get; set; }
	}
}
