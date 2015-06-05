﻿// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using Rock.Field.Types;
using Rock.Web.Cache;

namespace Rock.Attribute
{
    /// <summary>
    /// Stored as NoteType.Guid
    /// </summary>
    public class NoteTypeFieldAttribute : FieldAttribute
    {
        private const string ENTITY_TYPE_NAME_KEY = "entityTypeName";
        private const string QUALIFIER_COLUMN_KEY = "qualifierColumn";
        private const string QUALIFIER_VALUE_KEY = "qualifierValue";

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryFieldAttribute" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="allowMultiple">if set to <c>true</c> [allow multiple].</param>
        /// <param name="entityTypeName">Name of the entity type.</param>
        /// <param name="entityTypeQualifierColumn">The entity type qualifier column.</param>
        /// <param name="entityTypeQualifierValue">The entity type qualifier value.</param>
        /// <param name="required">if set to <c>true</c> [required].</param>
        /// <param name="defaultValue">The default value.</param>
        /// <param name="category">The category.</param>
        /// <param name="order">The order.</param>
        /// <param name="key">The key.</param>
        public NoteTypeFieldAttribute( string name, string description = "", bool allowMultiple = false,
             string entityTypeName = "", string entityTypeQualifierColumn = "", string entityTypeQualifierValue = "",
             bool required = true, string defaultValue = "", string category = "", int order = 0, string key = null ) :
            base( name, description, required, defaultValue, category, order, key,
                ( allowMultiple ? typeof( NoteTypesFieldType ).FullName : typeof( NoteTypeFieldType ).FullName ) )
        {
            FieldConfigurationValues.Add( ENTITY_TYPE_NAME_KEY, new Field.ConfigurationValue( entityTypeName ) );
            FieldConfigurationValues.Add( QUALIFIER_COLUMN_KEY, new Field.ConfigurationValue( entityTypeQualifierColumn ) );
            FieldConfigurationValues.Add( QUALIFIER_VALUE_KEY, new Field.ConfigurationValue( entityTypeQualifierValue ) );
        }
    }
}