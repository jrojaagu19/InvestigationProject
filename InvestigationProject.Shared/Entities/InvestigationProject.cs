using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject.Shared.Entities
{
    public class Investigationproject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del proyecto es requerido")]
        public string NameProject { get; set; } = null;

        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "El nombre del lider de proyecto es requerido")]
        public string LeaderName { get; set; } = null;

        [Required(ErrorMessage = "La descripcion del proyecto es requerido")]
        public string DescriptionProject { get; set; } = null;

        [Required(ErrorMessage = "El area de investigacion es requerida")]
        public string InvestigationArea { get; set; } = null;
    }
}
