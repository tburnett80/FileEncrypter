﻿using System;

namespace FrontEnd.Models
{
    public sealed class KeyModel
    {
        public Guid Id { get; set; }

        public Guid AssociatedKey { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Key { get; set; }

        public KeyType KeyType { get; set; }

        public int KeyLength { get; set; }

        public DateTime KeyCreationTimestamp { get; set; }
    }
}
