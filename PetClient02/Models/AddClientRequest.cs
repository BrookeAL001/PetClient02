﻿namespace PetClient02.Models
{
    public class AddClientRequest
    {
        public String FullName { get; set; }
        public String Email { get; set; }
        public long Phone { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public DateTime PetBirthday { get; set; }
    }
}
