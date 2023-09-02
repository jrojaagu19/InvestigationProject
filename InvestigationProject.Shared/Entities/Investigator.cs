using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationProject.Shared.Entities
{
    public class Investigator
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del investigador es requerido")]
        public string Name { get; set; } = null;

        [Required(ErrorMessage = "La afiliacion institucional es requerida")]
        public string InstitutionalAffiliation { get; set; } = null;

        [Required(ErrorMessage = "La especializacion es requerida")]
        public string Specialization { get; set; } = null;

        [Required(ErrorMessage = "El rol en el proyecto es requerido")]
        public string RoleProject { get; set; } = null;

    }
}
