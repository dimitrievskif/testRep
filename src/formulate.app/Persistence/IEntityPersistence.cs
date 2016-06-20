﻿namespace formulate.app.Persistence
{

    // Namespaces.
    using Entities;
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Interface for persistence of entities.
    /// </summary>
    public interface IEntityPersistence
    {
        IEntity Retrieve(Guid formId);
        IEnumerable<IEntity> RetrieveChildren(Guid? parentId);
        IEnumerable<IEntity> RetrieveDescendants(Guid parentId);
        Guid[] MoveEntity(IEntity entity, Guid[] parentPath);
        void DeleteEntity(IEntity entity);
    }

}