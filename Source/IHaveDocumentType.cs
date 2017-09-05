﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) 2008-2017 doLittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace doLittle.Read.CosmosDB.Documents
{
    /// <summary>
    /// Defines an interface representing the property added to all documents for dealing with different document types in a collection
    /// </summary>
    public interface IHaveDocumentType
    {
        /// <summary>
        /// Gets or sets the actual document type
        /// </summary>
        string _DOCUMENT_TYPE { get; set; }
    }
}
