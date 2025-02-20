namespace ADOPrac.API.DTOs.StateDTOs
{
    public class UpdateStateDto
    {
        public int StateId { get; set; }

        public int CountryId { get; set; }

        public string StateName { get; set; }

        public string StateDescription { get; set; }
    }
}
