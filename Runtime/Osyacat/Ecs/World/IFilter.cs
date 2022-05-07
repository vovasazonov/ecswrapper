﻿using System.Collections.Generic;
using Osyacat.Ecs.Entity;

namespace Osyacat.Ecs.World
{
    public interface IFilter
    {
        IEnumerator<IEntity> GetEnumerator();
        IEntity[] GetEntities();
        void GetEntities(List<IEntity> buffer);
    }
}