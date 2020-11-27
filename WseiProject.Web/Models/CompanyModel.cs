using WseiProject.Web.Entities;

namespace WseiProject.Web.Models
{
    public class CompanyModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }
        public bool IsValid()
        {
            bool isNameValid = Name.Length > 0;
            bool isDescriptionValid = Description.Length > 0;
            return isNameValid && isDescriptionValid;
        }
        public CompanyModel()
        {

        }

        public CompanyModel(CompanyEntity entity)
        {
            Name = entity.Name;
            Description = entity.Description;
            IsVisible = entity.IsVisible;
        }
    }

}
