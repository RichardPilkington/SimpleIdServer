﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleIdServer.Uma.Domains
{
    public class UMAPermissionTicketRecord : ICloneable
    {
        public UMAPermissionTicketRecord()
        {
            Scopes = new List<string>();
        }

        public UMAPermissionTicketRecord(string resourceId, ICollection<string> scopes)
        {
            ResourceId = resourceId;
            Scopes = scopes;
        }

        public string ResourceId { get; set; }
        public ICollection<string> Scopes { get; set; }

        public object Clone()
        {
            return new UMAPermissionTicketRecord
            {
                ResourceId = ResourceId,
                Scopes = Scopes.ToList()
            };
        }
    }
}
