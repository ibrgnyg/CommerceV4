using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class MenuItem
    {
		public String Id { get; set; }
		[Display(Name = "Ad: ")]
		public String Name { get; set; }
		[Display(Name = "Url: ")]
		public String Url { get; set; }
		[Display(Name = "Hedef: ")]
		public String Target { get; set; }
		[Display(Name = "Paylaşılsın mı ?: ")]
		public bool IsPublished { get; set; }
		[Display(Name = "Pozisyon: ")]
		public int Position { get; set; }

		public string ParentMenuItemId { get; set; }
		[ForeignKey("ParentMenuItemId")]
        [Display(Name ="Üst Menu Öğesi")]

        public MenuItem ParentMenuItem { get; set; }
		public virtual ICollection<MenuItem> ChildMenuItems { get; set; }

	}
}
