using System.ComponentModel.DataAnnotations;

namespace PizzaPan.EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string CustomerName { get; set; }

        [StringLength(60)]
        public string CustomerTitle { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}