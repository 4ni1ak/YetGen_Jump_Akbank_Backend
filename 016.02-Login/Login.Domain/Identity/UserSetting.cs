﻿using Login.Domain.Entities;

namespace Login.Domain.Identity
{
    public class UserSetting:EntityBase<Guid>
    {

        public Guid UserId { get; set; }
        public User User { get; set; }
        public Int16 TimeZone{ get; set; }
        public string LanguageCode { get; set; }

    }
}
