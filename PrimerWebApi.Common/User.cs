﻿namespace PrimerWebApi.Common.Users
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string NumberPhone {  get; set; }

        public int Age {  get; set; }

        public bool? Sex {  get; set; }
    }
}
