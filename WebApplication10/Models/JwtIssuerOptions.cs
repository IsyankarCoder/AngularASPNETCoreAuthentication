﻿using System;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;


namespace JsonWebTokenWithAngularAspNetCore.Models
{
    public class JwtIssuerOptions
    {
        public string Issuer { get; set; }
        public string Subject { get; set; }
        public string Audience { get; set; }
        public DateTime NotBefore { get; set; } = DateTime.UtcNow;
        public DateTime IssuedAt { get; set; } = DateTime.UtcNow;
        public TimeSpan ValidFor { get; set; } = TimeSpan.FromMinutes(5);

        public DateTime Expiration => IssuedAt.Add(ValidFor);

        /// <summary>
        /// JTI (JWT ID) CLAIM (Deafult Id is a guid)
        /// </summary>
        public Func<Task<string>> JtiGenerator => () => Task.FromResult(Guid.NewGuid().ToString());

        public SigningCredentials SigningCredentials { get; set; }


    }
}
