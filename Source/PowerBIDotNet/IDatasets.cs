﻿using System.Collections.Generic;

namespace Infrastructure.PowerBI
{
    public interface IDatasets
    {
        IEnumerable<Dataset> GetAll();
        IEnumerable<Dataset> GetFor(Group group);
        Dataset GetByName(string v);

        Dataset Create(string name, params TableSchema[] tables);
    }
}