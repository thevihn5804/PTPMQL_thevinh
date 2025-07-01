namespace DEMOMVC.Models
{
    public class PersonModel
    {
        public required int PersonID { get; set; }
        public string ?FullName { get; set; }
        public string ?Address { get; set; }
    }
}