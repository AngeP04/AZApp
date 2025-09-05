using System.ComponentModel.DataAnnotations;

namespace AZapp
{
    public class PCs
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string category { get; set; }
        public string album { get; set; }
        public string absentmember { get; set; }
        public string publisher { get; set; }

        public PCs(){}
    }
}