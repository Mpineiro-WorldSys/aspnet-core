﻿using System.ComponentModel.DataAnnotations;

namespace Worldsys.LDI.Friendships.Dto
{
    public class BlockUserInput 
    {
        [Range(1, long.MaxValue)]
        public long UserId { get; set; }

        public int? TenantId { get; set; }
    }
}