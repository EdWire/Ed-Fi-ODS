// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.Ods.Common.Models.Domain;
using EdFi.Ods.Common.Specifications;

namespace EdFi.Ods.Common.Models.Resource
{
    public class Reference : ResourceMemberBase
    {
        private readonly Lazy<IReadOnlyList<ResourceProperty>> _abstractionProperties; 
        private readonly Lazy<IReadOnlyList<ResourceProperty>> _referenceTypeProperties;
        private readonly FullName _referencedResourceFullName;

        public Reference(ResourceClassBase resourceClass, AssociationView association)
            : this(resourceClass, association, association.Name + "Reference")
        {
        }

        public Reference(ResourceClassBase resourceClass, AssociationView association, string displayName)
            : base(resourceClass, displayName)
        {
            Association = association;
            ReferencedResourceName = association.OtherEntity.Name;
            ReferenceTypeName = association.OtherEntity.Name + "Reference";
            _referencedResourceFullName = association.OtherEntity.FullName;

            _abstractionProperties = new Lazy<IReadOnlyList<ResourceProperty>>(
                () => association.ThisProperties
                    .Select(p => new ResourceProperty(this, resourceClass, p))
                    .ToList());

            var otherProperties = resourceClass.ResourceModel.GetResourceByFullName(association.OtherEntity.FullName);

            if (otherProperties == null)
                throw new InvalidOperationException(
                    "Current resource is detached from the resource model.  Unable to obtain the referenced resource.");


            _referenceTypeProperties = new Lazy<IReadOnlyList<ResourceProperty>>(
                () => association.OtherProperties
                    .Join(otherProperties.IdentifyingProperties
                        .Select(rp => new { EntityProperty = rp.EntityProperty, ResourceProperty = rp }),
                        ep => ep.Entity.IsPersonEntity() ? UniqueIdConventions.GetUniqueIdPropertyName(ep.PropertyName) : ep.PropertyName,
                        x => x.EntityProperty.PropertyName,
                        (ep, x) => x.ResourceProperty)
                    .ToList());
        }

        /// <summary>
        /// Gets the name of the referenced resource.
        /// </summary>
        public string ReferencedResourceName { get; private set; }

        /// <summary>
        /// Gets the type name to be used for the reference, based on the associated entity's name.
        /// </summary>
        public string ReferenceTypeName { get; private set; }

        /// <summary>
        /// Gets the properties for the reference type.
        /// </summary>
        public IEnumerable<ResourceProperty> ReferenceTypeProperties
        {
            get { return _referenceTypeProperties.Value; }
        }

        // Implements IHasNameContext
        public override FullName ParentFullName 
        {
            get { return Association.ThisEntity.FullName; }
        }

        /// <summary>
        /// Gets the referenced resource.
        /// </summary>
        public Resource ReferencedResource
        {
            get
            {
                if (ResourceClass.ResourceModel == null)
                    throw new InvalidOperationException(
                        "Current resource is detached from the resource model.  Unable to obtain the referenced resource.");

                return ResourceClass.ResourceModel.GetResourceByFullName(_referencedResourceFullName);
            }
        }

        public AssociationView Association { get; private set; }

        public bool IsRequired
        {
            get { return Association.IsRequiredIncomingAssociation; }
        }

        /// <summary>
        /// Indicates whether the reference is based on a <see cref="Reference"/> inherited from a base entity type.
        /// </summary>
        public bool IsInherited
        {
            get
            {
                if (Association == null)
                    return false;

                return
                    (Parent.Entity.InheritedNonNavigableParents.Contains(Association, ModelComparers.AssociationView));
            }
        }

        /// <summary>
        /// Indicates whether the reference forms part of the identity of the resource.
        /// </summary>
        public bool IsIdentifying
        {
            get
            {
                return Association?.IsIdentifying ?? false;
            }
        }

        /// <summary>
        /// Get the properties for use in the resource-oriented "flattened" entity-level abstraction of the containing resource class.
        /// </summary>
        public IEnumerable<ResourceProperty> AbstractionProperties
        {
            get { return _abstractionProperties.Value; }
        }
    }
}