﻿namespace Entities.Options
{
    public sealed class Jwt
    {
        public string Audience { get; set; }
        public string SecretKey { get; set; }
    }
}
