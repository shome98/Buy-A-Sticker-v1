using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Web.Mvc;
namespace Sticker_Models.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
