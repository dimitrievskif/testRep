﻿namespace formulate.app.Persistence
{

    // Namespaces.
    using Forms;
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Interface for persistence of forms.
    /// </summary>
    public interface IFormPersistence
    {
        void Persist(Form form);
        void Delete(Guid formId);
        void Delete(string formAlias);
        Form Retrieve(Guid formId);
        Form Retrieve(string formAlias);
        IEnumerable<Form> RetrieveChildren(Guid? parentId);
    }

}