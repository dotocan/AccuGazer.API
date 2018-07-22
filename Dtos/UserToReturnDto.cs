using System.Collections.Generic;

namespace AccuGazer.API.Dtos
{
    public class UserToReturnDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public long DateOfBirth { get; set; }
        public string Email { get; set; }
        public List<TestForSaveDto> tests { get; set; }
    }
}