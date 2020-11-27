using System;
using System.Collections.Generic;

namespace API.Dtos
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }
        public String KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; } 
        public String Gender { get; set; }
        public String Introducion { get; set; }
        public String LookingFor { get; set; }
        public String Interests { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }

    }
}