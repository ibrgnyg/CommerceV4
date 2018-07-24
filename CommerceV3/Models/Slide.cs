using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceV3.Models
{
    public class Slide
    {
		public String Id { get; set; }
		[Display(Name = "Ad: ")]
		public String Name { get; set; }
		[Display(Name = "Resim: ")]
		public String Image { get; set; }
		[Display(Name = "Url: ")]
		public String Url { get; set; }
		[Display(Name = "Hedef: ")]
		public String Target { get; set; }
		[Display(Name = "Yayınlandı mı ?: ")]
		public bool IsPublished { get; set; }
		[Display(Name = "Pozisyon: ")]
		public int Position { get; set; }
	}
}
