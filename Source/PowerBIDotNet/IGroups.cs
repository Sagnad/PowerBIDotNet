﻿using System.Collections.Generic;

namespace Infrastructure.PowerBI
{
    public interface IGroups
    {
        IEnumerable<Group> GetAll();
    }
}
