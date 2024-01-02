namespace OnlineRegistrationForm.Models
{
    public class Applicant
    {
            public int Id { get; set; }
            public string FullName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string MobileNo { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string District { get; set; }
            public string State { get; set; }
            public string ImagePath { get; set; }
            public bool HasExperience { get; set; }
            public int? MonthsOfExperience { get; set; }
    }
}