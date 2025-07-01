namespace DEMOMVC.Models
{
    public class EmployeeModel : PersonModel
    {
        public required string EmployeeID { get; set; }
        public string ?Age { get; set; }
    }
}