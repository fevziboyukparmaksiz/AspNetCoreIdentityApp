using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AspNetCoreIdentityApp.Web.Areas.Admin.Models
{
    public class RoleUpdateViewModel
    {
        public string Id { get; set; } = null!;

        [Required(ErrorMessage = "Role ismi boş bırakılamaz")]
        [Display(Name = "Rol ismi: ")]
        public string Name { get; set; } = null!;
    }
}
