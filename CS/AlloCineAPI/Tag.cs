﻿using System.Runtime.Serialization;

namespace AlloCine
{
    [DataContract]
    public class Tag
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "INVALID_MEMBER_NAME")]
        public string Value { get; set; }
    }
}
