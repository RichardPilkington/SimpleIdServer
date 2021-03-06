﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.Jwt.Jws;
using System;
using static SimpleIdServer.Jwt.Constants;

namespace SimpleIdServer.OAuth.Extensions
{
    public static class JwsPayloadExtensions
    {
        public static string GetIssuer(this JwsPayload jwsPayload)
        {
            return jwsPayload.GetClaimValue(OAuthClaims.Issuer);
        }

        public static string[] GetAudiences(this JwsPayload jwsPayload)
        {
            return jwsPayload.GetArrayClaim(OAuthClaims.Audiences);
        }

        public static double GetExpirationTime(this JwsPayload jwsPayload) 
        {
            return jwsPayload.GetDoubleClaim(OAuthClaims.ExpirationTime);
        }

        public static string[] GetScopes(this JwsPayload jwsPayload)
        {
            return jwsPayload.GetArrayClaim(OAuthClaims.Scopes);
        }

        public static string GetAzp(this JwsPayload jwsPayload)
        {
            return jwsPayload.GetClaimValue(OAuthClaims.Azp);
        }

        public static DateTime? GetAuthTime(this JwsPayload jwsPayload)
        {
            var authDateTime = jwsPayload.GetDoubleClaim(OAuthClaims.AuthenticationTime);
            if (authDateTime.Equals(default(double)))
            {
                return null;
            }

            return authDateTime.ConvertFromUnixTimestamp();
        }
    }
}