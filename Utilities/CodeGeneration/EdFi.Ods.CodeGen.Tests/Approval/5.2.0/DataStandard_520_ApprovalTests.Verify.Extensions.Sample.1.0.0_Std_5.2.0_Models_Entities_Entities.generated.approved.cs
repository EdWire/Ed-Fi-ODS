using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using EdFi.Common.Extensions;
using EdFi.Ods.Api.Caching;
using EdFi.Ods.Api.Attributes;
using EdFi.Ods.Common.Adapters;
using EdFi.Ods.Common.Attributes;
using EdFi.Ods.Common.Caching;
using EdFi.Ods.Common.Dependencies;
using EdFi.Ods.Common.Models.Domain;
using EdFi.Ods.Common.Infrastructure.Extensibility;
using EdFi.Ods.Common;
using EdFi.Ods.Common.Extensions;
using EdFi.Ods.Common.Serialization;
using EdFi.Ods.Entities.Common.EdFi;
using EdFi.Ods.Entities.Common.Sample;
using Newtonsoft.Json;
using MessagePack;
using KeyAttribute = MessagePack.KeyAttribute;

// Aggregate: ArtMediumDescriptor

namespace EdFi.Ods.Entities.NHibernate.ArtMediumDescriptorAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ArtMediumDescriptor table of the ArtMediumDescriptor aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ArtMediumDescriptor : DescriptorAggregate.EdFi.Descriptor,
        Entities.Common.Sample.IArtMediumDescriptor, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap, IEdFiDescriptor
    {

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature]
        [IgnoreMember]
        public virtual int ArtMediumDescriptorId 
        {
            get { return base.DescriptorId; }
            set { base.DescriptorId = value; }
        }
        

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        string IDescriptor.CodeValue
        {
            get { return CodeValue; }
            set { CodeValue = value; }
        }
        string IDescriptor.Description
        {
            get { return Description; }
            set { Description = value; }
        }
        DateTime? IDescriptor.EffectiveBeginDate
        {
            get { return EffectiveBeginDate; }
            set { EffectiveBeginDate = value; }
        }
        DateTime? IDescriptor.EffectiveEndDate
        {
            get { return EffectiveEndDate; }
            set { EffectiveEndDate = value; }
        }
        string IDescriptor.Namespace
        {
            get { return Namespace; }
            set { Namespace = value; }
        }
        string IDescriptor.ShortDescription
        {
            get { return ShortDescription; }
            set { ShortDescription = value; }
        }
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("ArtMediumDescriptorId", ArtMediumDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IArtMediumDescriptor)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IArtMediumDescriptor) target, null);
        }

    }
}
// Aggregate: Bus

namespace EdFi.Ods.Entities.NHibernate.BusAggregate.Sample
{
    /// <summary>
    /// Represents a read-only reference to the <see cref="Bus"/> entity.
    /// </summary>
    [MessagePackObject]
    public class BusReferenceData : IEntityReferenceData
    {
        private bool _trackLookupContext;
    
        // Default constructor (used by NHibernate)
        public BusReferenceData() { }

        // Constructor (used for link support with Serialized Data feature)
        public BusReferenceData(bool trackLookupContext) { _trackLookupContext = trackLookupContext; }

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        private Guid? _id;

        /// <summary>
        /// The id of the referenced entity (used as the resource identifier in the API).
        /// </summary>
        [Key(0)]
        public virtual Guid? Id
        {
            get => _id;
            set
            {
                _id = value;

                if (_trackLookupContext || (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled))
                {
                    // If explicitly setting this to a non-value, it needs to be resolved.
                    if (value == default(Guid) || value == null)
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }

        private string _busId;

        [Key(1)]
        public virtual string BusId
        {
            get => _busId;
            set
            {
                var originalValue = _busId;
                _busId = value;

                if (_trackLookupContext)
                {
                    // If Id is NOT already known then value is being initialized (from mapping or syncing -- not deserialized) and needs resolution 
                    if (_id == default && originalValue == default && value != default && IsFullyDefined())
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                    // If key value is changing (i.e. only via Synchronize)
                    else if (originalValue != default && value != originalValue) 
                    {
                        // Clear the values
                        Id = default;
                        Discriminator = null;
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }

        public virtual bool IsFullyDefined()
        {
            return
                _busId != default
            ;
        }

        /// <summary>
        /// Gets and sets the discriminator value which identifies the concrete sub-type of the referenced entity
        /// when that entity has been derived; otherwise <b>null</b>.
        /// </summary>
        [Key(2)]
        public virtual string Discriminator { get; set; }

        private static FullName _fullName = new FullName("sample", "Bus"); 
        FullName IEntityReferenceData.FullName { get => _fullName; }
    
        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("BusId", BusId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (!entry.Value.Equals(thoseKeys[entry.Key]))
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                hashCode.Add(entry.Value);
            }

            return hashCode.ToHashCode();
        }
        #endregion
    }

// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.Bus table of the Bus aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class Bus : AggregateRootWithCompositeKey,
        Entities.Common.Sample.IBus, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public Bus()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature]
        [Key(6)]
        public virtual string BusId  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("BusId", BusId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IBus)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IBus) target, null);
        }

    }
}
// Aggregate: BusRoute

namespace EdFi.Ods.Entities.NHibernate.BusRouteAggregate.Sample
{
    /// <summary>
    /// Represents a read-only reference to the <see cref="BusRoute"/> entity.
    /// </summary>
    [MessagePackObject]
    public class BusRouteReferenceData : IEntityReferenceData
    {
        private bool _trackLookupContext;
    
        // Default constructor (used by NHibernate)
        public BusRouteReferenceData() { }

        // Constructor (used for link support with Serialized Data feature)
        public BusRouteReferenceData(bool trackLookupContext) { _trackLookupContext = trackLookupContext; }

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        private Guid? _id;

        /// <summary>
        /// The id of the referenced entity (used as the resource identifier in the API).
        /// </summary>
        [Key(0)]
        public virtual Guid? Id
        {
            get => _id;
            set
            {
                _id = value;

                if (_trackLookupContext || (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled))
                {
                    // If explicitly setting this to a non-value, it needs to be resolved.
                    if (value == default(Guid) || value == null)
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }

        private string _busId;

        [Key(1)]
        public virtual string BusId
        {
            get => _busId;
            set
            {
                var originalValue = _busId;
                _busId = value;

                if (_trackLookupContext)
                {
                    // If Id is NOT already known then value is being initialized (from mapping or syncing -- not deserialized) and needs resolution 
                    if (_id == default && originalValue == default && value != default && IsFullyDefined())
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                    // If key value is changing (i.e. only via Synchronize)
                    else if (originalValue != default && value != originalValue) 
                    {
                        // Clear the values
                        Id = default;
                        Discriminator = null;
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }
        private int _busRouteNumber;

        [Key(2)]
        public virtual int BusRouteNumber
        {
            get => _busRouteNumber;
            set
            {
                var originalValue = _busRouteNumber;
                _busRouteNumber = value;

                if (_trackLookupContext)
                {
                    // If Id is NOT already known then value is being initialized (from mapping or syncing -- not deserialized) and needs resolution 
                    if (_id == default && originalValue == default && value != default && IsFullyDefined())
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                    // If key value is changing (i.e. only via Synchronize)
                    else if (originalValue != default && value != originalValue) 
                    {
                        // Clear the values
                        Id = default;
                        Discriminator = null;
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }

        public virtual bool IsFullyDefined()
        {
            return
                _busId != default
                            && _busRouteNumber != default
            ;
        }

        /// <summary>
        /// Gets and sets the discriminator value which identifies the concrete sub-type of the referenced entity
        /// when that entity has been derived; otherwise <b>null</b>.
        /// </summary>
        [Key(3)]
        public virtual string Discriminator { get; set; }

        private static FullName _fullName = new FullName("sample", "BusRoute"); 
        FullName IEntityReferenceData.FullName { get => _fullName; }
    
        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("BusId", BusId);
            keyValues.Add("BusRouteNumber", BusRouteNumber);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (!entry.Value.Equals(thoseKeys[entry.Key]))
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                hashCode.Add(entry.Value);
            }

            return hashCode.ToHashCode();
        }
        #endregion
    }

// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.BusRoute table of the BusRoute aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class BusRoute : AggregateRootWithCompositeKey,
        Entities.Common.Sample.IBusRoute, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public BusRoute()
        {
            BusRouteBusYears = new HashSet<BusRouteBusYear>();
            BusRoutePrograms = new HashSet<BusRouteProgram>();
            BusRouteServiceAreaPostalCodes = new HashSet<BusRouteServiceAreaPostalCode>();
            BusRouteStartTimes = new HashSet<BusRouteStartTime>();
            BusRouteTelephones = new HashSet<BusRouteTelephone>();
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.BusAggregate.Sample.BusReferenceData _busReferenceData;

        private bool BusReferenceDataIsProxied()
        {
            return _busReferenceData != null 
                && _busReferenceData.GetType() != typeof(NHibernate.BusAggregate.Sample.BusReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.BusAggregate.Sample.BusReferenceData BusReferenceData
        {
            get => _busReferenceData;
            set
            {
                _busReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !BusReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(6)]
        public virtual NHibernate.BusAggregate.Sample.BusReferenceData BusSerializedReferenceData { get => _busSerializedReferenceData; set { if (value != null) _busSerializedReferenceData = value; } }
        private NHibernate.BusAggregate.Sample.BusReferenceData _busSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the Bus discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IBusRoute.BusDiscriminator
        {
            get
            {
                return BusReferenceDataIsProxied()
                    ? (BusSerializedReferenceData ?? BusReferenceData)?.Discriminator
                    : (BusReferenceData ?? BusSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the Bus resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IBusRoute.BusResourceId
        {
            get
            {
                return BusReferenceDataIsProxied()
                    ? (BusSerializedReferenceData ?? BusReferenceData)?.Id
                    : (BusReferenceData ?? BusSerializedReferenceData)?.Id;
            }
            set { if (BusSerializedReferenceData?.IsFullyDefined() == true) BusSerializedReferenceData.Id = value; }
        }

        private NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData _staffEducationOrganizationAssignmentAssociationReferenceData;

        private bool StaffEducationOrganizationAssignmentAssociationReferenceDataIsProxied()
        {
            return _staffEducationOrganizationAssignmentAssociationReferenceData != null 
                && _staffEducationOrganizationAssignmentAssociationReferenceData.GetType() != typeof(NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData StaffEducationOrganizationAssignmentAssociationReferenceData
        {
            get => _staffEducationOrganizationAssignmentAssociationReferenceData;
            set
            {
                _staffEducationOrganizationAssignmentAssociationReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !StaffEducationOrganizationAssignmentAssociationReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(7)]
        public virtual NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData StaffEducationOrganizationAssignmentAssociationSerializedReferenceData { get => _staffEducationOrganizationAssignmentAssociationSerializedReferenceData; set { if (value != null) _staffEducationOrganizationAssignmentAssociationSerializedReferenceData = value; } }
        private NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData _staffEducationOrganizationAssignmentAssociationSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the StaffEducationOrganizationAssignmentAssociation discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IBusRoute.StaffEducationOrganizationAssignmentAssociationDiscriminator
        {
            get
            {
                return StaffEducationOrganizationAssignmentAssociationReferenceDataIsProxied()
                    ? (StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ?? StaffEducationOrganizationAssignmentAssociationReferenceData)?.Discriminator
                    : (StaffEducationOrganizationAssignmentAssociationReferenceData ?? StaffEducationOrganizationAssignmentAssociationSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the StaffEducationOrganizationAssignmentAssociation resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IBusRoute.StaffEducationOrganizationAssignmentAssociationResourceId
        {
            get
            {
                return StaffEducationOrganizationAssignmentAssociationReferenceDataIsProxied()
                    ? (StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ?? StaffEducationOrganizationAssignmentAssociationReferenceData)?.Id
                    : (StaffEducationOrganizationAssignmentAssociationReferenceData ?? StaffEducationOrganizationAssignmentAssociationSerializedReferenceData)?.Id;
            }
            set { if (StaffEducationOrganizationAssignmentAssociationSerializedReferenceData?.IsFullyDefined() == true) StaffEducationOrganizationAssignmentAssociationSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature]
        [Key(8)]
        public virtual string BusId 
        {
            get => _busId;
            set
            {
                _busId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    BusSerializedReferenceData ??= new NHibernate.BusAggregate.Sample.BusReferenceData(true);
                    BusSerializedReferenceData.BusId = value;
                }
            }
        }

        private string _busId;

        [DomainSignature]
        [Key(9)]
        public virtual int BusRouteNumber  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(10)]
        public virtual DateTime? BeginDate 
        {
            get { return _beginDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _beginDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _beginDate = new DateTime(given.Year, given.Month, given.Day);
                }

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData(true);
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData.BeginDate = _beginDate ?? default;
                }
            }
        }

        private DateTime? _beginDate;

        [Key(11)]
        public virtual string BusRouteDirection  { get; set; }

        [Key(12)]
        public virtual int? BusRouteDuration  { get; set; }

        [Key(13)]
        public virtual bool? Daily  { get; set; }

        [Key(14)]
        public virtual int? DisabilityDescriptorId 
        {
            get
            {
                if (_disabilityDescriptorId == default(int?))
                {
                    _disabilityDescriptorId = string.IsNullOrWhiteSpace(_disabilityDescriptor) ? default(int?) : GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("DisabilityDescriptor", _disabilityDescriptor);
                }

                return _disabilityDescriptorId;
            } 
            set
            {
                _disabilityDescriptorId = value;
                _disabilityDescriptor = null;
            }
        }

        private int? _disabilityDescriptorId;
        private string _disabilityDescriptor;

        [IgnoreMember]
        public virtual string DisabilityDescriptor
        {
            get
            {
                if (_disabilityDescriptor == null)
                    _disabilityDescriptor = _disabilityDescriptorId == null ? null : GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("DisabilityDescriptor", _disabilityDescriptorId.Value);
                    
                return _disabilityDescriptor;
            }
            set
            {
                _disabilityDescriptor = value;
                _disabilityDescriptorId = default(int?);
            }
        }

        [Key(15)]
        public virtual long? EducationOrganizationId 
        {
            get => _educationOrganizationId;
            set
            {
                _educationOrganizationId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData(true);
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData.EducationOrganizationId = value ?? default;
                }
            }
        }

        private long? _educationOrganizationId;

        [Key(16)]
        public virtual string ExpectedTransitTime  { get; set; }

        [Key(17)]
        public virtual decimal HoursPerWeek  { get; set; }

        [Key(18)]
        public virtual decimal OperatingCost  { get; set; }

        [Key(19)]
        public virtual decimal? OptimalCapacity  { get; set; }

        [Key(20)]
        public virtual int? StaffClassificationDescriptorId 
        {
            get
            {
                if (_staffClassificationDescriptorId == default(int?))
                {
                    _staffClassificationDescriptorId = string.IsNullOrWhiteSpace(_staffClassificationDescriptor) ? default(int?) : GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("StaffClassificationDescriptor", _staffClassificationDescriptor);
                
                    if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                    {
                        StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData(true);
                        StaffEducationOrganizationAssignmentAssociationSerializedReferenceData.StaffClassificationDescriptorId = _staffClassificationDescriptorId ?? default;
                    }
                }

                return _staffClassificationDescriptorId;
            } 
            set
            {
                _staffClassificationDescriptorId = value;
                _staffClassificationDescriptor = null;
        
                if (value != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData(true);
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData.StaffClassificationDescriptorId = value ?? default;
                }
            }
        }

        private int? _staffClassificationDescriptorId;
        private string _staffClassificationDescriptor;

        [IgnoreMember]
        public virtual string StaffClassificationDescriptor
        {
            get
            {
                if (_staffClassificationDescriptor == null)
                    _staffClassificationDescriptor = _staffClassificationDescriptorId == null ? null : GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("StaffClassificationDescriptor", _staffClassificationDescriptorId.Value);
                    
                return _staffClassificationDescriptor;
            }
            set
            {
                _staffClassificationDescriptor = value;
                _staffClassificationDescriptorId = default(int?);

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData(true);
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData.StaffClassificationDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("StaffClassificationDescriptor", _staffClassificationDescriptor);
                }
            }
        }

        [Key(21)]
        public virtual int? StaffUSI 
        {
            get
            {
                if (_staffUSI == default(int?) && _staffUniqueId != null)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Staff", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_staffUniqueId, out var usi))
                    {
                        _staffUSI = usi;

                        if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                        {
                            StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData(true);
                            StaffEducationOrganizationAssignmentAssociationSerializedReferenceData.StaffUSI = _staffUSI ?? default;
                        }
                    }
                }

                return _staffUSI;
            } 
            set
            {
                _staffUSI = value;

                if (value != null)
                {
                    GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().AddLookup("Staff", value.Value);
                }

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData(true);
                    StaffEducationOrganizationAssignmentAssociationSerializedReferenceData.StaffUSI = value ?? default;
                }
            }
        }

        private int? _staffUSI;
        private string _staffUniqueId;

        [IgnoreMember]
        public virtual string StaffUniqueId
        {
            get
            {
                if (_staffUniqueId == null && _staffUSI.HasValue)
                {
                    if (GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().UniqueIdByUsiByPersonType.TryGetValue("Staff", out var uniqueIdByUsi)
                        && uniqueIdByUsi.TryGetValue(_staffUSI.Value, out var uniqueId))
                    {
                        _staffUniqueId = uniqueId;
                    }
                }

                return _staffUniqueId;
            }
            set
            {
                if (_staffUniqueId != value)
                        _staffUSI = default(int?);

                _staffUniqueId = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Staff", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_staffUniqueId, out var usi))
                    {
                        StaffEducationOrganizationAssignmentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.EdFi.StaffEducationOrganizationAssignmentAssociationReferenceData(true);
                        StaffEducationOrganizationAssignmentAssociationSerializedReferenceData.StaffUSI = usi;
                    }
                }
            }
        }

        [Key(22)]
        public virtual DateTime? StartDate 
        {
            get { return _startDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _startDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _startDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _startDate;

        [Key(23)]
        public virtual decimal? WeeklyMileage  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------

        private ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteBusYear> _busRouteBusYears;
        private ICollection<Entities.Common.Sample.IBusRouteBusYear> _busRouteBusYearsCovariant;
        [Key(24)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteBusYear>))]
        public virtual ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteBusYear> BusRouteBusYears
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_busRouteBusYears is DeserializedPersistentGenericSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteBusYear> set)
                {
                    set.Reattach(this, "BusRouteBusYears");
                }
            
                foreach (var item in _busRouteBusYears)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRouteBusYears;
            }
            set
            {
                _busRouteBusYears = value;
                _busRouteBusYearsCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IBusRouteBusYear, Entities.NHibernate.BusRouteAggregate.Sample.BusRouteBusYear>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IBusRouteBusYear> Entities.Common.Sample.IBusRoute.BusRouteBusYears
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _busRouteBusYears)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRouteBusYearsCovariant;
            }
            set
            {
                BusRouteBusYears = new HashSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteBusYear>(value.Cast<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteBusYear>());
            }
        }


        private ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteProgram> _busRoutePrograms;
        private ICollection<Entities.Common.Sample.IBusRouteProgram> _busRouteProgramsCovariant;
        [Key(25)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteProgram>))]
        public virtual ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteProgram> BusRoutePrograms
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_busRoutePrograms is DeserializedPersistentGenericSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteProgram> set)
                {
                    set.Reattach(this, "BusRoutePrograms");
                }
            
                foreach (var item in _busRoutePrograms)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRoutePrograms;
            }
            set
            {
                _busRoutePrograms = value;
                _busRouteProgramsCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IBusRouteProgram, Entities.NHibernate.BusRouteAggregate.Sample.BusRouteProgram>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IBusRouteProgram> Entities.Common.Sample.IBusRoute.BusRoutePrograms
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _busRoutePrograms)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRouteProgramsCovariant;
            }
            set
            {
                BusRoutePrograms = new HashSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteProgram>(value.Cast<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteProgram>());
            }
        }


        private ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteServiceAreaPostalCode> _busRouteServiceAreaPostalCodes;
        private ICollection<Entities.Common.Sample.IBusRouteServiceAreaPostalCode> _busRouteServiceAreaPostalCodesCovariant;
        [Key(26)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteServiceAreaPostalCode>))]
        public virtual ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteServiceAreaPostalCode> BusRouteServiceAreaPostalCodes
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_busRouteServiceAreaPostalCodes is DeserializedPersistentGenericSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteServiceAreaPostalCode> set)
                {
                    set.Reattach(this, "BusRouteServiceAreaPostalCodes");
                }
            
                foreach (var item in _busRouteServiceAreaPostalCodes)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRouteServiceAreaPostalCodes;
            }
            set
            {
                _busRouteServiceAreaPostalCodes = value;
                _busRouteServiceAreaPostalCodesCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IBusRouteServiceAreaPostalCode, Entities.NHibernate.BusRouteAggregate.Sample.BusRouteServiceAreaPostalCode>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IBusRouteServiceAreaPostalCode> Entities.Common.Sample.IBusRoute.BusRouteServiceAreaPostalCodes
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _busRouteServiceAreaPostalCodes)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRouteServiceAreaPostalCodesCovariant;
            }
            set
            {
                BusRouteServiceAreaPostalCodes = new HashSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteServiceAreaPostalCode>(value.Cast<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteServiceAreaPostalCode>());
            }
        }


        private ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteStartTime> _busRouteStartTimes;
        private ICollection<Entities.Common.Sample.IBusRouteStartTime> _busRouteStartTimesCovariant;
        [Key(27)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteStartTime>))]
        public virtual ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteStartTime> BusRouteStartTimes
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_busRouteStartTimes is DeserializedPersistentGenericSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteStartTime> set)
                {
                    set.Reattach(this, "BusRouteStartTimes");
                }
            
                foreach (var item in _busRouteStartTimes)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRouteStartTimes;
            }
            set
            {
                _busRouteStartTimes = value;
                _busRouteStartTimesCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IBusRouteStartTime, Entities.NHibernate.BusRouteAggregate.Sample.BusRouteStartTime>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IBusRouteStartTime> Entities.Common.Sample.IBusRoute.BusRouteStartTimes
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _busRouteStartTimes)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRouteStartTimesCovariant;
            }
            set
            {
                BusRouteStartTimes = new HashSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteStartTime>(value.Cast<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteStartTime>());
            }
        }


        private ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteTelephone> _busRouteTelephones;
        private ICollection<Entities.Common.Sample.IBusRouteTelephone> _busRouteTelephonesCovariant;
        [Key(28)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteTelephone>))]
        public virtual ICollection<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteTelephone> BusRouteTelephones
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_busRouteTelephones is DeserializedPersistentGenericSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteTelephone> set)
                {
                    set.Reattach(this, "BusRouteTelephones");
                }
            
                foreach (var item in _busRouteTelephones)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRouteTelephones;
            }
            set
            {
                _busRouteTelephones = value;
                _busRouteTelephonesCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IBusRouteTelephone, Entities.NHibernate.BusRouteAggregate.Sample.BusRouteTelephone>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IBusRouteTelephone> Entities.Common.Sample.IBusRoute.BusRouteTelephones
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _busRouteTelephones)
                    if (item.BusRoute == null)
                        item.BusRoute = this;
                // -------------------------------------------------------------

                return _busRouteTelephonesCovariant;
            }
            set
            {
                BusRouteTelephones = new HashSet<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteTelephone>(value.Cast<Entities.NHibernate.BusRouteAggregate.Sample.BusRouteTelephone>());
            }
        }

        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "DisabilityDescriptor", new LookupColumnDetails { PropertyName = "DisabilityDescriptorId", LookupTypeName = "DisabilityDescriptor"} },
                { "StaffClassificationDescriptor", new LookupColumnDetails { PropertyName = "StaffClassificationDescriptorId", LookupTypeName = "StaffClassificationDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("BusId", BusId);
            keyValues.Add("BusRouteNumber", BusRouteNumber);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IBusRoute)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IBusRoute) target, null);
        }

    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.BusRouteBusYear table of the BusRoute aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class BusRouteBusYear : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IBusRouteBusYear, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public BusRouteBusYear()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual BusRoute BusRoute { get; set; }

        Entities.Common.Sample.IBusRoute IBusRouteBusYear.BusRoute
        {
            get { return BusRoute; }
            set { BusRoute = (BusRoute) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual short BusYear  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (BusRoute as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("BusYear", BusYear);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IBusRouteBusYear)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IBusRouteBusYear) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            BusRoute = (BusRoute) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.BusRouteProgram table of the BusRoute aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class BusRouteProgram : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IBusRouteProgram, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public BusRouteProgram()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.ProgramAggregate.EdFi.ProgramReferenceData _programReferenceData;

        private bool ProgramReferenceDataIsProxied()
        {
            return _programReferenceData != null 
                && _programReferenceData.GetType() != typeof(NHibernate.ProgramAggregate.EdFi.ProgramReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.ProgramAggregate.EdFi.ProgramReferenceData ProgramReferenceData
        {
            get => _programReferenceData;
            set
            {
                _programReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !ProgramReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(1)]
        public virtual NHibernate.ProgramAggregate.EdFi.ProgramReferenceData ProgramSerializedReferenceData { get => _programSerializedReferenceData; set { if (value != null) _programSerializedReferenceData = value; } }
        private NHibernate.ProgramAggregate.EdFi.ProgramReferenceData _programSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the Program discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IBusRouteProgram.ProgramDiscriminator
        {
            get
            {
                return ProgramReferenceDataIsProxied()
                    ? (ProgramSerializedReferenceData ?? ProgramReferenceData)?.Discriminator
                    : (ProgramReferenceData ?? ProgramSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the Program resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IBusRouteProgram.ProgramResourceId
        {
            get
            {
                return ProgramReferenceDataIsProxied()
                    ? (ProgramSerializedReferenceData ?? ProgramReferenceData)?.Id
                    : (ProgramReferenceData ?? ProgramSerializedReferenceData)?.Id;
            }
            set { if (ProgramSerializedReferenceData?.IsFullyDefined() == true) ProgramSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual BusRoute BusRoute { get; set; }

        Entities.Common.Sample.IBusRoute IBusRouteProgram.BusRoute
        {
            get { return BusRoute; }
            set { BusRoute = (BusRoute) value; }
        }

        [DomainSignature]
        [Key(2)]
        public virtual long EducationOrganizationId 
        {
            get => _educationOrganizationId;
            set
            {
                _educationOrganizationId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    ProgramSerializedReferenceData ??= new NHibernate.ProgramAggregate.EdFi.ProgramReferenceData(true);
                    ProgramSerializedReferenceData.EducationOrganizationId = value;
                }
            }
        }

        private long _educationOrganizationId;

        [DomainSignature]
        [Key(3)]
        public virtual string ProgramName 
        {
            get => _programName;
            set
            {
                _programName = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    ProgramSerializedReferenceData ??= new NHibernate.ProgramAggregate.EdFi.ProgramReferenceData(true);
                    ProgramSerializedReferenceData.ProgramName = value;
                }
            }
        }

        private string _programName;

        [DomainSignature]
        [Key(4)]
        public virtual int ProgramTypeDescriptorId 
        {
            get
            {
                if (_programTypeDescriptorId == default(int))
                {
                    _programTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ProgramTypeDescriptor", _programTypeDescriptor);
                
                    if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                    {
                        ProgramSerializedReferenceData ??= new NHibernate.ProgramAggregate.EdFi.ProgramReferenceData(true);
                        ProgramSerializedReferenceData.ProgramTypeDescriptorId = _programTypeDescriptorId;
                    }
                }

                return _programTypeDescriptorId;
            } 
            set
            {
                _programTypeDescriptorId = value;
                _programTypeDescriptor = null;
        
                if (value != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    ProgramSerializedReferenceData ??= new NHibernate.ProgramAggregate.EdFi.ProgramReferenceData(true);
                    ProgramSerializedReferenceData.ProgramTypeDescriptorId = value;
                }
            }
        }

        private int _programTypeDescriptorId;
        private string _programTypeDescriptor;

        [IgnoreMember]
        public virtual string ProgramTypeDescriptor
        {
            get
            {
                if (_programTypeDescriptor == null)
                    _programTypeDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("ProgramTypeDescriptor", _programTypeDescriptorId);
                    
                return _programTypeDescriptor;
            }
            set
            {
                _programTypeDescriptor = value;
                _programTypeDescriptorId = default(int);

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    ProgramSerializedReferenceData ??= new NHibernate.ProgramAggregate.EdFi.ProgramReferenceData(true);
                    ProgramSerializedReferenceData.ProgramTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ProgramTypeDescriptor", _programTypeDescriptor);
                }
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "ProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "ProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (BusRoute as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("EducationOrganizationId", EducationOrganizationId);
            keyValues.Add("ProgramName", ProgramName);
            keyValues.Add("ProgramTypeDescriptorId", ProgramTypeDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IBusRouteProgram)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IBusRouteProgram) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            BusRoute = (BusRoute) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.BusRouteServiceAreaPostalCode table of the BusRoute aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class BusRouteServiceAreaPostalCode : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IBusRouteServiceAreaPostalCode, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public BusRouteServiceAreaPostalCode()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual BusRoute BusRoute { get; set; }

        Entities.Common.Sample.IBusRoute IBusRouteServiceAreaPostalCode.BusRoute
        {
            get { return BusRoute; }
            set { BusRoute = (BusRoute) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string ServiceAreaPostalCode  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (BusRoute as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("ServiceAreaPostalCode", ServiceAreaPostalCode);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IBusRouteServiceAreaPostalCode)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IBusRouteServiceAreaPostalCode) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            BusRoute = (BusRoute) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.BusRouteStartTime table of the BusRoute aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class BusRouteStartTime : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IBusRouteStartTime, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public BusRouteStartTime()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual BusRoute BusRoute { get; set; }

        Entities.Common.Sample.IBusRoute IBusRouteStartTime.BusRoute
        {
            get { return BusRoute; }
            set { BusRoute = (BusRoute) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual TimeSpan StartTime  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (BusRoute as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("StartTime", StartTime);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IBusRouteStartTime)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IBusRouteStartTime) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            BusRoute = (BusRoute) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.BusRouteTelephone table of the BusRoute aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class BusRouteTelephone : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IBusRouteTelephone, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public BusRouteTelephone()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual BusRoute BusRoute { get; set; }

        Entities.Common.Sample.IBusRoute IBusRouteTelephone.BusRoute
        {
            get { return BusRoute; }
            set { BusRoute = (BusRoute) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string TelephoneNumber  { get; set; }

        [DomainSignature]
        [Key(2)]
        public virtual int TelephoneNumberTypeDescriptorId 
        {
            get
            {
                if (_telephoneNumberTypeDescriptorId == default(int))
                {
                    _telephoneNumberTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("TelephoneNumberTypeDescriptor", _telephoneNumberTypeDescriptor);
                }

                return _telephoneNumberTypeDescriptorId;
            } 
            set
            {
                _telephoneNumberTypeDescriptorId = value;
                _telephoneNumberTypeDescriptor = null;
            }
        }

        private int _telephoneNumberTypeDescriptorId;
        private string _telephoneNumberTypeDescriptor;

        [IgnoreMember]
        public virtual string TelephoneNumberTypeDescriptor
        {
            get
            {
                if (_telephoneNumberTypeDescriptor == null)
                    _telephoneNumberTypeDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("TelephoneNumberTypeDescriptor", _telephoneNumberTypeDescriptorId);
                    
                return _telephoneNumberTypeDescriptor;
            }
            set
            {
                _telephoneNumberTypeDescriptor = value;
                _telephoneNumberTypeDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(3)]
        public virtual bool? DoNotPublishIndicator  { get; set; }

        [Key(4)]
        public virtual int? OrderOfPriority  { get; set; }

        [Key(5)]
        public virtual bool? TextMessageCapabilityIndicator  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "TelephoneNumberTypeDescriptor", new LookupColumnDetails { PropertyName = "TelephoneNumberTypeDescriptorId", LookupTypeName = "TelephoneNumberTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (BusRoute as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("TelephoneNumber", TelephoneNumber);
            keyValues.Add("TelephoneNumberTypeDescriptorId", TelephoneNumberTypeDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IBusRouteTelephone)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IBusRouteTelephone) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            BusRoute = (BusRoute) value;
        }
    }
}
// Aggregate: Contact

namespace EdFi.Ods.Entities.NHibernate.ContactAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactAddressSchoolDistrict table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactAddressSchoolDistrict : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactAddressSchoolDistrict, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactAddressSchoolDistrict()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.ContactAddress ContactAddress { get; set; }

        Entities.Common.Sample.IContactAddressExtension IContactAddressSchoolDistrict.ContactAddressExtension
        {
            get { return (IContactAddressExtension) ContactAddress.Extensions["Sample"]; }
            set { ContactAddress.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string SchoolDistrict  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "AddressTypeDescriptor", new LookupColumnDetails { PropertyName = "AddressTypeDescriptorId", LookupTypeName = "AddressTypeDescriptor"} },
                { "StateAbbreviationDescriptor", new LookupColumnDetails { PropertyName = "StateAbbreviationDescriptorId", LookupTypeName = "StateAbbreviationDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (ContactAddress as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("SchoolDistrict", SchoolDistrict);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactAddressSchoolDistrict)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactAddressSchoolDistrict) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            ContactAddress = (EdFi.ContactAddress) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactAddressTerm table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactAddressTerm : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactAddressTerm, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactAddressTerm()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.ContactAddress ContactAddress { get; set; }

        Entities.Common.Sample.IContactAddressExtension IContactAddressTerm.ContactAddressExtension
        {
            get { return (IContactAddressExtension) ContactAddress.Extensions["Sample"]; }
            set { ContactAddress.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int TermDescriptorId 
        {
            get
            {
                if (_termDescriptorId == default(int))
                {
                    _termDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("TermDescriptor", _termDescriptor);
                }

                return _termDescriptorId;
            } 
            set
            {
                _termDescriptorId = value;
                _termDescriptor = null;
            }
        }

        private int _termDescriptorId;
        private string _termDescriptor;

        [IgnoreMember]
        public virtual string TermDescriptor
        {
            get
            {
                if (_termDescriptor == null)
                    _termDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("TermDescriptor", _termDescriptorId);
                    
                return _termDescriptor;
            }
            set
            {
                _termDescriptor = value;
                _termDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "AddressTypeDescriptor", new LookupColumnDetails { PropertyName = "AddressTypeDescriptorId", LookupTypeName = "AddressTypeDescriptor"} },
                { "StateAbbreviationDescriptor", new LookupColumnDetails { PropertyName = "StateAbbreviationDescriptorId", LookupTypeName = "StateAbbreviationDescriptor"} },
                { "TermDescriptor", new LookupColumnDetails { PropertyName = "TermDescriptorId", LookupTypeName = "TermDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (ContactAddress as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("TermDescriptorId", TermDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactAddressTerm)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactAddressTerm) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            ContactAddress = (EdFi.ContactAddress) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactAuthor table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactAuthor : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactAuthor, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactAuthor()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Contact Contact { get; set; }

        Entities.Common.Sample.IContactExtension IContactAuthor.ContactExtension
        {
            get { return (IContactExtension) Contact.Extensions["Sample"]; }
            set { Contact.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string Author  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Contact as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("Author", Author);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactAuthor)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactAuthor) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Contact = (EdFi.Contact) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactCeilingHeight table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactCeilingHeight : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactCeilingHeight, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactCeilingHeight()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Contact Contact { get; set; }

        Entities.Common.Sample.IContactExtension IContactCeilingHeight.ContactExtension
        {
            get { return (IContactExtension) Contact.Extensions["Sample"]; }
            set { Contact.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual decimal CeilingHeight  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Contact as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("CeilingHeight", CeilingHeight);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactCeilingHeight)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactCeilingHeight) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Contact = (EdFi.Contact) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactCTEProgramService table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactCTEProgramService : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactCTEProgramService, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactCTEProgramService()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Contact Contact { get; set; }

        Entities.Common.Sample.IContactExtension IContactCTEProgramService.ContactExtension
        {
            get { return (IContactExtension) Contact.Extensions["Sample"]; }
            set { Contact.Extensions["Sample"] = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual string CIPCode  { get; set; }

        [Key(2)]
        public virtual int CTEProgramServiceDescriptorId 
        {
            get
            {
                if (_cteProgramServiceDescriptorId == default(int))
                {
                    _cteProgramServiceDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("CTEProgramServiceDescriptor", _cteProgramServiceDescriptor);
                }

                return _cteProgramServiceDescriptorId;
            } 
            set
            {
                _cteProgramServiceDescriptorId = value;
                _cteProgramServiceDescriptor = null;
            }
        }

        private int _cteProgramServiceDescriptorId;
        private string _cteProgramServiceDescriptor;

        [IgnoreMember]
        public virtual string CTEProgramServiceDescriptor
        {
            get
            {
                if (_cteProgramServiceDescriptor == null)
                    _cteProgramServiceDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("CTEProgramServiceDescriptor", _cteProgramServiceDescriptorId);
                    
                return _cteProgramServiceDescriptor;
            }
            set
            {
                _cteProgramServiceDescriptor = value;
                _cteProgramServiceDescriptorId = default(int);
            }
        }

        [Key(3)]
        public virtual bool? PrimaryIndicator  { get; set; }

        [Key(4)]
        public virtual DateTime? ServiceBeginDate 
        {
            get { return _serviceBeginDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _serviceBeginDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _serviceBeginDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _serviceBeginDate;

        [Key(5)]
        public virtual DateTime? ServiceEndDate 
        {
            get { return _serviceEndDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _serviceEndDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _serviceEndDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _serviceEndDate;

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "CTEProgramServiceDescriptor", new LookupColumnDetails { PropertyName = "CTEProgramServiceDescriptorId", LookupTypeName = "CTEProgramServiceDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Contact as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactCTEProgramService)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactCTEProgramService) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Contact = (EdFi.Contact) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactEducationContent table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactEducationContent : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactEducationContent, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactEducationContent()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.EducationContentAggregate.EdFi.EducationContentReferenceData _educationContentReferenceData;

        private bool EducationContentReferenceDataIsProxied()
        {
            return _educationContentReferenceData != null 
                && _educationContentReferenceData.GetType() != typeof(NHibernate.EducationContentAggregate.EdFi.EducationContentReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.EducationContentAggregate.EdFi.EducationContentReferenceData EducationContentReferenceData
        {
            get => _educationContentReferenceData;
            set
            {
                _educationContentReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !EducationContentReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(1)]
        public virtual NHibernate.EducationContentAggregate.EdFi.EducationContentReferenceData EducationContentSerializedReferenceData { get => _educationContentSerializedReferenceData; set { if (value != null) _educationContentSerializedReferenceData = value; } }
        private NHibernate.EducationContentAggregate.EdFi.EducationContentReferenceData _educationContentSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the EducationContent discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IContactEducationContent.EducationContentDiscriminator
        {
            get
            {
                return EducationContentReferenceDataIsProxied()
                    ? (EducationContentSerializedReferenceData ?? EducationContentReferenceData)?.Discriminator
                    : (EducationContentReferenceData ?? EducationContentSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the EducationContent resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IContactEducationContent.EducationContentResourceId
        {
            get
            {
                return EducationContentReferenceDataIsProxied()
                    ? (EducationContentSerializedReferenceData ?? EducationContentReferenceData)?.Id
                    : (EducationContentReferenceData ?? EducationContentSerializedReferenceData)?.Id;
            }
            set { if (EducationContentSerializedReferenceData?.IsFullyDefined() == true) EducationContentSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Contact Contact { get; set; }

        Entities.Common.Sample.IContactExtension IContactEducationContent.ContactExtension
        {
            get { return (IContactExtension) Contact.Extensions["Sample"]; }
            set { Contact.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(2)]
        public virtual string ContentIdentifier 
        {
            get => _contentIdentifier;
            set
            {
                _contentIdentifier = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    EducationContentSerializedReferenceData ??= new NHibernate.EducationContentAggregate.EdFi.EducationContentReferenceData(true);
                    EducationContentSerializedReferenceData.ContentIdentifier = value;
                }
            }
        }

        private string _contentIdentifier;

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Contact as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("ContentIdentifier", ContentIdentifier);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactEducationContent)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactEducationContent) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Contact = (EdFi.Contact) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactFavoriteBookTitle table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactFavoriteBookTitle : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactFavoriteBookTitle, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactFavoriteBookTitle()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Contact Contact { get; set; }

        Entities.Common.Sample.IContactExtension IContactFavoriteBookTitle.ContactExtension
        {
            get { return (IContactExtension) Contact.Extensions["Sample"]; }
            set { Contact.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string FavoriteBookTitle  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Contact as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("FavoriteBookTitle", FavoriteBookTitle);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactFavoriteBookTitle)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactFavoriteBookTitle) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Contact = (EdFi.Contact) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactStudentProgramAssociation table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactStudentProgramAssociation : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactStudentProgramAssociation, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactStudentProgramAssociation()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData _studentProgramAssociationReferenceData;

        private bool StudentProgramAssociationReferenceDataIsProxied()
        {
            return _studentProgramAssociationReferenceData != null 
                && _studentProgramAssociationReferenceData.GetType() != typeof(NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData StudentProgramAssociationReferenceData
        {
            get => _studentProgramAssociationReferenceData;
            set
            {
                _studentProgramAssociationReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !StudentProgramAssociationReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(1)]
        public virtual NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData StudentProgramAssociationSerializedReferenceData { get => _studentProgramAssociationSerializedReferenceData; set { if (value != null) _studentProgramAssociationSerializedReferenceData = value; } }
        private NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData _studentProgramAssociationSerializedReferenceData;

        /// <summary>
        /// A property implementation whose getter allows the StudentProgramAssociation resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IContactStudentProgramAssociation.StudentProgramAssociationResourceId
        {
            get
            {
                return StudentProgramAssociationReferenceDataIsProxied()
                    ? (StudentProgramAssociationSerializedReferenceData ?? StudentProgramAssociationReferenceData)?.Id
                    : (StudentProgramAssociationReferenceData ?? StudentProgramAssociationSerializedReferenceData)?.Id;
            }
            set { if (StudentProgramAssociationSerializedReferenceData?.IsFullyDefined() == true) StudentProgramAssociationSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Contact Contact { get; set; }

        Entities.Common.Sample.IContactExtension IContactStudentProgramAssociation.ContactExtension
        {
            get { return (IContactExtension) Contact.Extensions["Sample"]; }
            set { Contact.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(2)]
        public virtual DateTime BeginDate 
        {
            get { return _beginDate; }
            //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
            set
            {
                _beginDate = new DateTime(value.Year, value.Month, value.Day);

                if (_beginDate != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    StudentProgramAssociationSerializedReferenceData.BeginDate = _beginDate;
                }
            }
        }

        private DateTime _beginDate;

        [DomainSignature]
        [Key(3)]
        public virtual long EducationOrganizationId 
        {
            get => _educationOrganizationId;
            set
            {
                _educationOrganizationId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    StudentProgramAssociationSerializedReferenceData.EducationOrganizationId = value;
                }
            }
        }

        private long _educationOrganizationId;

        [DomainSignature]
        [Key(4)]
        public virtual long ProgramEducationOrganizationId 
        {
            get => _programEducationOrganizationId;
            set
            {
                _programEducationOrganizationId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    StudentProgramAssociationSerializedReferenceData.ProgramEducationOrganizationId = value;
                }
            }
        }

        private long _programEducationOrganizationId;

        [DomainSignature]
        [Key(5)]
        public virtual string ProgramName 
        {
            get => _programName;
            set
            {
                _programName = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    StudentProgramAssociationSerializedReferenceData.ProgramName = value;
                }
            }
        }

        private string _programName;

        [DomainSignature]
        [Key(6)]
        public virtual int ProgramTypeDescriptorId 
        {
            get
            {
                if (_programTypeDescriptorId == default(int))
                {
                    _programTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ProgramTypeDescriptor", _programTypeDescriptor);
                
                    if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                    {
                        StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                        StudentProgramAssociationSerializedReferenceData.ProgramTypeDescriptorId = _programTypeDescriptorId;
                    }
                }

                return _programTypeDescriptorId;
            } 
            set
            {
                _programTypeDescriptorId = value;
                _programTypeDescriptor = null;
        
                if (value != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    StudentProgramAssociationSerializedReferenceData.ProgramTypeDescriptorId = value;
                }
            }
        }

        private int _programTypeDescriptorId;
        private string _programTypeDescriptor;

        [IgnoreMember]
        public virtual string ProgramTypeDescriptor
        {
            get
            {
                if (_programTypeDescriptor == null)
                    _programTypeDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("ProgramTypeDescriptor", _programTypeDescriptorId);
                    
                return _programTypeDescriptor;
            }
            set
            {
                _programTypeDescriptor = value;
                _programTypeDescriptorId = default(int);

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    StudentProgramAssociationSerializedReferenceData.ProgramTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ProgramTypeDescriptor", _programTypeDescriptor);
                }
            }
        }

        [Display(Name="StudentUniqueId")][DomainSignature]
        [Key(7)]
        public virtual int StudentUSI 
        {
            get
            {
                if (_studentUSI == default(int) && _studentUniqueId != null)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Student", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_studentUniqueId, out var usi))
                    {
                        _studentUSI = usi;

                        if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                        {
                            StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                            StudentProgramAssociationSerializedReferenceData.StudentUSI = _studentUSI;
                        }
                    }
                }

                return _studentUSI;
            } 
            set
            {
                _studentUSI = value;
                GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().AddLookup("Student", value);

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    StudentProgramAssociationSerializedReferenceData.StudentUSI = value;
                }
            }
        }

        private int _studentUSI;
        private string _studentUniqueId;

        [IgnoreMember]
        public virtual string StudentUniqueId
        {
            get
            {
                if (_studentUniqueId == null)
                {
                    if (GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().UniqueIdByUsiByPersonType.TryGetValue("Student", out var uniqueIdByUsi)
                        && uniqueIdByUsi.TryGetValue(_studentUSI, out var uniqueId))
                    {
                        _studentUniqueId = uniqueId;
                    }
                }

                return _studentUniqueId;
            }
            set
            {
                if (_studentUniqueId != value)
                        _studentUSI = default(int);

                _studentUniqueId = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Student", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_studentUniqueId, out var usi))
                    {
                        StudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                        StudentProgramAssociationSerializedReferenceData.StudentUSI = usi;
                    }
                }
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "ProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "ProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Contact as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("BeginDate", BeginDate);
            keyValues.Add("EducationOrganizationId", EducationOrganizationId);
            keyValues.Add("ProgramEducationOrganizationId", ProgramEducationOrganizationId);
            keyValues.Add("ProgramName", ProgramName);
            keyValues.Add("ProgramTypeDescriptorId", ProgramTypeDescriptorId);
            keyValues.Add("StudentUSI", StudentUSI);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactStudentProgramAssociation)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactStudentProgramAssociation) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Contact = (EdFi.Contact) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactTeacherConference table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactTeacherConference : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactTeacherConference, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactTeacherConference()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Contact Contact { get; set; }

        Entities.Common.Sample.IContactExtension IContactTeacherConference.ContactExtension
        {
            get { return (IContactExtension) Contact.Extensions["Sample"]; }
            set { Contact.Extensions["Sample"] = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual string DayOfWeek  { get; set; }

        [Key(2)]
        public virtual TimeSpan EndTime  { get; set; }

        [Key(3)]
        public virtual TimeSpan StartTime  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Contact as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactTeacherConference)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactTeacherConference) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Contact = (EdFi.Contact) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactExtension table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactExtension : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactExtension, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactExtension()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Contact Contact { get; set; }

        Entities.Common.EdFi.IContact IContactExtension.Contact
        {
            get { return Contact; }
            set { Contact = (EdFi.Contact) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual string AverageCarLineWait  { get; set; }

        [Key(2)]
        public virtual short? BecameParent  { get; set; }

        [Key(3)]
        public virtual decimal? CoffeeSpend  { get; set; }

        [Key(4)]
        public virtual int? CredentialFieldDescriptorId 
        {
            get
            {
                if (_credentialFieldDescriptorId == default(int?))
                {
                    _credentialFieldDescriptorId = string.IsNullOrWhiteSpace(_credentialFieldDescriptor) ? default(int?) : GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("CredentialFieldDescriptor", _credentialFieldDescriptor);
                }

                return _credentialFieldDescriptorId;
            } 
            set
            {
                _credentialFieldDescriptorId = value;
                _credentialFieldDescriptor = null;
            }
        }

        private int? _credentialFieldDescriptorId;
        private string _credentialFieldDescriptor;

        [IgnoreMember]
        public virtual string CredentialFieldDescriptor
        {
            get
            {
                if (_credentialFieldDescriptor == null)
                    _credentialFieldDescriptor = _credentialFieldDescriptorId == null ? null : GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("CredentialFieldDescriptor", _credentialFieldDescriptorId.Value);
                    
                return _credentialFieldDescriptor;
            }
            set
            {
                _credentialFieldDescriptor = value;
                _credentialFieldDescriptorId = default(int?);
            }
        }

        [Key(5)]
        public virtual int? Duration  { get; set; }

        [Key(6)]
        public virtual decimal? GPA  { get; set; }

        [Key(7)]
        public virtual DateTime? GraduationDate 
        {
            get { return _graduationDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _graduationDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _graduationDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _graduationDate;

        [Key(8)]
        public virtual bool IsSportsFan  { get; set; }

        [Key(9)]
        public virtual int? LuckyNumber  { get; set; }

        [Key(10)]
        public virtual TimeSpan? PreferredWakeUpTime  { get; set; }

        [Key(11)]
        public virtual decimal? RainCertainty  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        [IgnoreMember]
        // This property implementation exists to provide the mapper with reflection-based access to the target instance's .NET type (for creating new instances)
        public Entities.NHibernate.ContactAggregate.Sample.ContactCTEProgramService ContactCTEProgramService
        {
            get { return (Entities.NHibernate.ContactAggregate.Sample.ContactCTEProgramService) (this as Entities.Common.Sample.IContactExtension).ContactCTEProgramService;  }
            set { (this as Entities.Common.Sample.IContactExtension).ContactCTEProgramService = value;  }
        }

        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        Entities.Common.Sample.IContactCTEProgramService Entities.Common.Sample.IContactExtension.ContactCTEProgramService
        {
            get
            {
                var list = (IList) Contact.AggregateExtensions["Sample_ContactCTEProgramService"];

                if (list != null && list.Count > 0)
                    return (Entities.Common.Sample.IContactCTEProgramService) list[0];

                return null;
            }
            set
            {
                // Delete the existing object
                var list = (IList) Contact.AggregateExtensions["Sample_ContactCTEProgramService"] ?? new List<object>();
                list.Clear();

                // If we're setting a value, add it to the list now
                if (value != null)
                {
                    list.Add(value);

                    // Set the parent reference
                    (value as IChildEntity).SetParent(Contact);
                }
            }
        }
        [IgnoreMember]
        // This property implementation exists to provide the mapper with reflection-based access to the target instance's .NET type (for creating new instances)
        public Entities.NHibernate.ContactAggregate.Sample.ContactTeacherConference ContactTeacherConference
        {
            get { return (Entities.NHibernate.ContactAggregate.Sample.ContactTeacherConference) (this as Entities.Common.Sample.IContactExtension).ContactTeacherConference;  }
            set { (this as Entities.Common.Sample.IContactExtension).ContactTeacherConference = value;  }
        }

        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        Entities.Common.Sample.IContactTeacherConference Entities.Common.Sample.IContactExtension.ContactTeacherConference
        {
            get
            {
                var list = (IList) Contact.AggregateExtensions["Sample_ContactTeacherConference"];

                if (list != null && list.Count > 0)
                    return (Entities.Common.Sample.IContactTeacherConference) list[0];

                return null;
            }
            set
            {
                // Delete the existing object
                var list = (IList) Contact.AggregateExtensions["Sample_ContactTeacherConference"] ?? new List<object>();
                list.Clear();

                // If we're setting a value, add it to the list now
                if (value != null)
                {
                    list.Add(value);

                    // Set the parent reference
                    (value as IChildEntity).SetParent(Contact);
                }
            }
        }
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        private ICollection<Entities.Common.Sample.IContactAuthor> _contactAuthors;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IContactAuthor> IContactExtension.ContactAuthors
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, ContactAuthor>((IList<object>) Contact.AggregateExtensions["Sample_ContactAuthors"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (ContactAuthor item in sourceList)
                    if (item.Contact == null)
                        item.Contact = this.Contact;
                // -------------------------------------------------------------

                if (_contactAuthors == null)
                    _contactAuthors = new CovariantCollectionAdapter<Entities.Common.Sample.IContactAuthor, ContactAuthor>(sourceList);

                return _contactAuthors;
            }
            set
            {
                Contact.AggregateExtensions["Sample_ContactAuthors"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IContactCeilingHeight> _contactCeilingHeights;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IContactCeilingHeight> IContactExtension.ContactCeilingHeights
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, ContactCeilingHeight>((IList<object>) Contact.AggregateExtensions["Sample_ContactCeilingHeights"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (ContactCeilingHeight item in sourceList)
                    if (item.Contact == null)
                        item.Contact = this.Contact;
                // -------------------------------------------------------------

                if (_contactCeilingHeights == null)
                    _contactCeilingHeights = new CovariantCollectionAdapter<Entities.Common.Sample.IContactCeilingHeight, ContactCeilingHeight>(sourceList);

                return _contactCeilingHeights;
            }
            set
            {
                Contact.AggregateExtensions["Sample_ContactCeilingHeights"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IContactEducationContent> _contactEducationContents;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IContactEducationContent> IContactExtension.ContactEducationContents
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, ContactEducationContent>((IList<object>) Contact.AggregateExtensions["Sample_ContactEducationContents"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (ContactEducationContent item in sourceList)
                    if (item.Contact == null)
                        item.Contact = this.Contact;
                // -------------------------------------------------------------

                if (_contactEducationContents == null)
                    _contactEducationContents = new CovariantCollectionAdapter<Entities.Common.Sample.IContactEducationContent, ContactEducationContent>(sourceList);

                return _contactEducationContents;
            }
            set
            {
                Contact.AggregateExtensions["Sample_ContactEducationContents"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IContactFavoriteBookTitle> _contactFavoriteBookTitles;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IContactFavoriteBookTitle> IContactExtension.ContactFavoriteBookTitles
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, ContactFavoriteBookTitle>((IList<object>) Contact.AggregateExtensions["Sample_ContactFavoriteBookTitles"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (ContactFavoriteBookTitle item in sourceList)
                    if (item.Contact == null)
                        item.Contact = this.Contact;
                // -------------------------------------------------------------

                if (_contactFavoriteBookTitles == null)
                    _contactFavoriteBookTitles = new CovariantCollectionAdapter<Entities.Common.Sample.IContactFavoriteBookTitle, ContactFavoriteBookTitle>(sourceList);

                return _contactFavoriteBookTitles;
            }
            set
            {
                Contact.AggregateExtensions["Sample_ContactFavoriteBookTitles"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IContactStudentProgramAssociation> _contactStudentProgramAssociations;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IContactStudentProgramAssociation> IContactExtension.ContactStudentProgramAssociations
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, ContactStudentProgramAssociation>((IList<object>) Contact.AggregateExtensions["Sample_ContactStudentProgramAssociations"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (ContactStudentProgramAssociation item in sourceList)
                    if (item.Contact == null)
                        item.Contact = this.Contact;
                // -------------------------------------------------------------

                if (_contactStudentProgramAssociations == null)
                    _contactStudentProgramAssociations = new CovariantCollectionAdapter<Entities.Common.Sample.IContactStudentProgramAssociation, ContactStudentProgramAssociation>(sourceList);

                return _contactStudentProgramAssociations;
            }
            set
            {
                Contact.AggregateExtensions["Sample_ContactStudentProgramAssociations"] = value;
            }
        }
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "CredentialFieldDescriptor", new LookupColumnDetails { PropertyName = "CredentialFieldDescriptorId", LookupTypeName = "CredentialFieldDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Contact as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactExtension)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactExtension) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Contact = (EdFi.Contact) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.ContactAddressExtension table of the Contact aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class ContactAddressExtension : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IContactAddressExtension, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public ContactAddressExtension()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.ContactAddress ContactAddress { get; set; }

        Entities.Common.EdFi.IContactAddress IContactAddressExtension.ContactAddress
        {
            get { return ContactAddress; }
            set { ContactAddress = (EdFi.ContactAddress) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual string Complex  { get; set; }

        [Key(2)]
        public virtual bool OnBusRoute  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        private ICollection<Entities.Common.Sample.IContactAddressSchoolDistrict> _contactAddressSchoolDistricts;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IContactAddressSchoolDistrict> IContactAddressExtension.ContactAddressSchoolDistricts
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, ContactAddressSchoolDistrict>((IList<object>) ContactAddress.AggregateExtensions["Sample_ContactAddressSchoolDistricts"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (ContactAddressSchoolDistrict item in sourceList)
                    if (item.ContactAddress == null)
                        item.ContactAddress = this.ContactAddress;
                // -------------------------------------------------------------

                if (_contactAddressSchoolDistricts == null)
                    _contactAddressSchoolDistricts = new CovariantCollectionAdapter<Entities.Common.Sample.IContactAddressSchoolDistrict, ContactAddressSchoolDistrict>(sourceList);

                return _contactAddressSchoolDistricts;
            }
            set
            {
                ContactAddress.AggregateExtensions["Sample_ContactAddressSchoolDistricts"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IContactAddressTerm> _contactAddressTerms;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IContactAddressTerm> IContactAddressExtension.ContactAddressTerms
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, ContactAddressTerm>((IList<object>) ContactAddress.AggregateExtensions["Sample_ContactAddressTerms"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (ContactAddressTerm item in sourceList)
                    if (item.ContactAddress == null)
                        item.ContactAddress = this.ContactAddress;
                // -------------------------------------------------------------

                if (_contactAddressTerms == null)
                    _contactAddressTerms = new CovariantCollectionAdapter<Entities.Common.Sample.IContactAddressTerm, ContactAddressTerm>(sourceList);

                return _contactAddressTerms;
            }
            set
            {
                ContactAddress.AggregateExtensions["Sample_ContactAddressTerms"] = value;
            }
        }
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (ContactAddress as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IContactAddressExtension)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IContactAddressExtension) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            ContactAddress = (EdFi.ContactAddress) value;
        }
    }
}
// Aggregate: FavoriteBookCategoryDescriptor

namespace EdFi.Ods.Entities.NHibernate.FavoriteBookCategoryDescriptorAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.FavoriteBookCategoryDescriptor table of the FavoriteBookCategoryDescriptor aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class FavoriteBookCategoryDescriptor : DescriptorAggregate.EdFi.Descriptor,
        Entities.Common.Sample.IFavoriteBookCategoryDescriptor, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap, IEdFiDescriptor
    {

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature]
        [IgnoreMember]
        public virtual int FavoriteBookCategoryDescriptorId 
        {
            get { return base.DescriptorId; }
            set { base.DescriptorId = value; }
        }
        

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        string IDescriptor.CodeValue
        {
            get { return CodeValue; }
            set { CodeValue = value; }
        }
        string IDescriptor.Description
        {
            get { return Description; }
            set { Description = value; }
        }
        DateTime? IDescriptor.EffectiveBeginDate
        {
            get { return EffectiveBeginDate; }
            set { EffectiveBeginDate = value; }
        }
        DateTime? IDescriptor.EffectiveEndDate
        {
            get { return EffectiveEndDate; }
            set { EffectiveEndDate = value; }
        }
        string IDescriptor.Namespace
        {
            get { return Namespace; }
            set { Namespace = value; }
        }
        string IDescriptor.ShortDescription
        {
            get { return ShortDescription; }
            set { ShortDescription = value; }
        }
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("FavoriteBookCategoryDescriptorId", FavoriteBookCategoryDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IFavoriteBookCategoryDescriptor)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IFavoriteBookCategoryDescriptor) target, null);
        }

    }
}
// Aggregate: MembershipTypeDescriptor

namespace EdFi.Ods.Entities.NHibernate.MembershipTypeDescriptorAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.MembershipTypeDescriptor table of the MembershipTypeDescriptor aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class MembershipTypeDescriptor : DescriptorAggregate.EdFi.Descriptor,
        Entities.Common.Sample.IMembershipTypeDescriptor, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap, IEdFiDescriptor
    {

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature]
        [IgnoreMember]
        public virtual int MembershipTypeDescriptorId 
        {
            get { return base.DescriptorId; }
            set { base.DescriptorId = value; }
        }
        

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        string IDescriptor.CodeValue
        {
            get { return CodeValue; }
            set { CodeValue = value; }
        }
        string IDescriptor.Description
        {
            get { return Description; }
            set { Description = value; }
        }
        DateTime? IDescriptor.EffectiveBeginDate
        {
            get { return EffectiveBeginDate; }
            set { EffectiveBeginDate = value; }
        }
        DateTime? IDescriptor.EffectiveEndDate
        {
            get { return EffectiveEndDate; }
            set { EffectiveEndDate = value; }
        }
        string IDescriptor.Namespace
        {
            get { return Namespace; }
            set { Namespace = value; }
        }
        string IDescriptor.ShortDescription
        {
            get { return ShortDescription; }
            set { ShortDescription = value; }
        }
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("MembershipTypeDescriptorId", MembershipTypeDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IMembershipTypeDescriptor)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IMembershipTypeDescriptor) target, null);
        }

    }
}
// Aggregate: School

namespace EdFi.Ods.Entities.NHibernate.SchoolAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.SchoolCTEProgramService table of the School aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class SchoolCTEProgramService : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.ISchoolCTEProgramService, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public SchoolCTEProgramService()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.School School { get; set; }

        Entities.Common.Sample.ISchoolExtension ISchoolCTEProgramService.SchoolExtension
        {
            get { return (ISchoolExtension) School.Extensions["Sample"]; }
            set { School.Extensions["Sample"] = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual string CIPCode  { get; set; }

        [Key(2)]
        public virtual int CTEProgramServiceDescriptorId 
        {
            get
            {
                if (_cteProgramServiceDescriptorId == default(int))
                {
                    _cteProgramServiceDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("CTEProgramServiceDescriptor", _cteProgramServiceDescriptor);
                }

                return _cteProgramServiceDescriptorId;
            } 
            set
            {
                _cteProgramServiceDescriptorId = value;
                _cteProgramServiceDescriptor = null;
            }
        }

        private int _cteProgramServiceDescriptorId;
        private string _cteProgramServiceDescriptor;

        [IgnoreMember]
        public virtual string CTEProgramServiceDescriptor
        {
            get
            {
                if (_cteProgramServiceDescriptor == null)
                    _cteProgramServiceDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("CTEProgramServiceDescriptor", _cteProgramServiceDescriptorId);
                    
                return _cteProgramServiceDescriptor;
            }
            set
            {
                _cteProgramServiceDescriptor = value;
                _cteProgramServiceDescriptorId = default(int);
            }
        }

        [Key(3)]
        public virtual bool? PrimaryIndicator  { get; set; }

        [Key(4)]
        public virtual DateTime? ServiceBeginDate 
        {
            get { return _serviceBeginDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _serviceBeginDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _serviceBeginDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _serviceBeginDate;

        [Key(5)]
        public virtual DateTime? ServiceEndDate 
        {
            get { return _serviceEndDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _serviceEndDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _serviceEndDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _serviceEndDate;

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "CTEProgramServiceDescriptor", new LookupColumnDetails { PropertyName = "CTEProgramServiceDescriptorId", LookupTypeName = "CTEProgramServiceDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (School as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.ISchoolCTEProgramService)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.ISchoolCTEProgramService) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            School = (EdFi.School) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.SchoolDirectlyOwnedBus table of the School aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class SchoolDirectlyOwnedBus : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.ISchoolDirectlyOwnedBus, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public SchoolDirectlyOwnedBus()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.BusAggregate.Sample.BusReferenceData _directlyOwnedBusReferenceData;

        private bool DirectlyOwnedBusReferenceDataIsProxied()
        {
            return _directlyOwnedBusReferenceData != null 
                && _directlyOwnedBusReferenceData.GetType() != typeof(NHibernate.BusAggregate.Sample.BusReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.BusAggregate.Sample.BusReferenceData DirectlyOwnedBusReferenceData
        {
            get => _directlyOwnedBusReferenceData;
            set
            {
                _directlyOwnedBusReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !DirectlyOwnedBusReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(1)]
        public virtual NHibernate.BusAggregate.Sample.BusReferenceData DirectlyOwnedBusSerializedReferenceData { get => _directlyOwnedBusSerializedReferenceData; set { if (value != null) _directlyOwnedBusSerializedReferenceData = value; } }
        private NHibernate.BusAggregate.Sample.BusReferenceData _directlyOwnedBusSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the DirectlyOwnedBus discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.ISchoolDirectlyOwnedBus.DirectlyOwnedBusDiscriminator
        {
            get
            {
                return DirectlyOwnedBusReferenceDataIsProxied()
                    ? (DirectlyOwnedBusSerializedReferenceData ?? DirectlyOwnedBusReferenceData)?.Discriminator
                    : (DirectlyOwnedBusReferenceData ?? DirectlyOwnedBusSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the DirectlyOwnedBus resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.ISchoolDirectlyOwnedBus.DirectlyOwnedBusResourceId
        {
            get
            {
                return DirectlyOwnedBusReferenceDataIsProxied()
                    ? (DirectlyOwnedBusSerializedReferenceData ?? DirectlyOwnedBusReferenceData)?.Id
                    : (DirectlyOwnedBusReferenceData ?? DirectlyOwnedBusSerializedReferenceData)?.Id;
            }
            set { if (DirectlyOwnedBusSerializedReferenceData?.IsFullyDefined() == true) DirectlyOwnedBusSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.School School { get; set; }

        Entities.Common.Sample.ISchoolExtension ISchoolDirectlyOwnedBus.SchoolExtension
        {
            get { return (ISchoolExtension) School.Extensions["Sample"]; }
            set { School.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(2)]
        public virtual string DirectlyOwnedBusId 
        {
            get => _directlyOwnedBusId;
            set
            {
                _directlyOwnedBusId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    DirectlyOwnedBusSerializedReferenceData ??= new NHibernate.BusAggregate.Sample.BusReferenceData(true);
                    DirectlyOwnedBusSerializedReferenceData.BusId = value;
                }
            }
        }

        private string _directlyOwnedBusId;

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (School as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("DirectlyOwnedBusId", DirectlyOwnedBusId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.ISchoolDirectlyOwnedBus)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.ISchoolDirectlyOwnedBus) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            School = (EdFi.School) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.SchoolExtension table of the School aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class SchoolExtension : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.ISchoolExtension, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public SchoolExtension()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.School School { get; set; }

        Entities.Common.EdFi.ISchool ISchoolExtension.School
        {
            get { return School; }
            set { School = (EdFi.School) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual bool? IsExemplary  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        [IgnoreMember]
        // This property implementation exists to provide the mapper with reflection-based access to the target instance's .NET type (for creating new instances)
        public Entities.NHibernate.SchoolAggregate.Sample.SchoolCTEProgramService SchoolCTEProgramService
        {
            get { return (Entities.NHibernate.SchoolAggregate.Sample.SchoolCTEProgramService) (this as Entities.Common.Sample.ISchoolExtension).SchoolCTEProgramService;  }
            set { (this as Entities.Common.Sample.ISchoolExtension).SchoolCTEProgramService = value;  }
        }

        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        Entities.Common.Sample.ISchoolCTEProgramService Entities.Common.Sample.ISchoolExtension.SchoolCTEProgramService
        {
            get
            {
                var list = (IList) School.AggregateExtensions["Sample_SchoolCTEProgramService"];

                if (list != null && list.Count > 0)
                    return (Entities.Common.Sample.ISchoolCTEProgramService) list[0];

                return null;
            }
            set
            {
                // Delete the existing object
                var list = (IList) School.AggregateExtensions["Sample_SchoolCTEProgramService"] ?? new List<object>();
                list.Clear();

                // If we're setting a value, add it to the list now
                if (value != null)
                {
                    list.Add(value);

                    // Set the parent reference
                    (value as IChildEntity).SetParent(School);
                }
            }
        }
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        private ICollection<Entities.Common.Sample.ISchoolDirectlyOwnedBus> _schoolDirectlyOwnedBuses;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.ISchoolDirectlyOwnedBus> ISchoolExtension.SchoolDirectlyOwnedBuses
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, SchoolDirectlyOwnedBus>((IList<object>) School.AggregateExtensions["Sample_SchoolDirectlyOwnedBuses"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (SchoolDirectlyOwnedBus item in sourceList)
                    if (item.School == null)
                        item.School = this.School;
                // -------------------------------------------------------------

                if (_schoolDirectlyOwnedBuses == null)
                    _schoolDirectlyOwnedBuses = new CovariantCollectionAdapter<Entities.Common.Sample.ISchoolDirectlyOwnedBus, SchoolDirectlyOwnedBus>(sourceList);

                return _schoolDirectlyOwnedBuses;
            }
            set
            {
                School.AggregateExtensions["Sample_SchoolDirectlyOwnedBuses"] = value;
            }
        }
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (School as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.ISchoolExtension)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.ISchoolExtension) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            School = (EdFi.School) value;
        }
    }
}
// Aggregate: Staff

namespace EdFi.Ods.Entities.NHibernate.StaffAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StaffPet table of the Staff aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StaffPet : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStaffPet, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StaffPet()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Staff Staff { get; set; }

        Entities.Common.Sample.IStaffExtension IStaffPet.StaffExtension
        {
            get { return (IStaffExtension) Staff.Extensions["Sample"]; }
            set { Staff.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string PetName  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(2)]
        public virtual bool? IsFixed  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Staff as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("PetName", PetName);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStaffPet)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStaffPet) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Staff = (EdFi.Staff) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StaffPetPreference table of the Staff aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StaffPetPreference : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStaffPetPreference, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StaffPetPreference()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Staff Staff { get; set; }

        Entities.Common.Sample.IStaffExtension IStaffPetPreference.StaffExtension
        {
            get { return (IStaffExtension) Staff.Extensions["Sample"]; }
            set { Staff.Extensions["Sample"] = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual int MaximumWeight  { get; set; }

        [Key(2)]
        public virtual int MinimumWeight  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Staff as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStaffPetPreference)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStaffPetPreference) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Staff = (EdFi.Staff) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StaffExtension table of the Staff aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StaffExtension : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStaffExtension, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StaffExtension()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Staff Staff { get; set; }

        Entities.Common.EdFi.IStaff IStaffExtension.Staff
        {
            get { return Staff; }
            set { Staff = (EdFi.Staff) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual DateTime? FirstPetOwnedDate 
        {
            get { return _firstPetOwnedDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _firstPetOwnedDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _firstPetOwnedDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _firstPetOwnedDate;

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        [IgnoreMember]
        // This property implementation exists to provide the mapper with reflection-based access to the target instance's .NET type (for creating new instances)
        public Entities.NHibernate.StaffAggregate.Sample.StaffPetPreference StaffPetPreference
        {
            get { return (Entities.NHibernate.StaffAggregate.Sample.StaffPetPreference) (this as Entities.Common.Sample.IStaffExtension).StaffPetPreference;  }
            set { (this as Entities.Common.Sample.IStaffExtension).StaffPetPreference = value;  }
        }

        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        Entities.Common.Sample.IStaffPetPreference Entities.Common.Sample.IStaffExtension.StaffPetPreference
        {
            get
            {
                var list = (IList) Staff.AggregateExtensions["Sample_StaffPetPreference"];

                if (list != null && list.Count > 0)
                    return (Entities.Common.Sample.IStaffPetPreference) list[0];

                return null;
            }
            set
            {
                // Delete the existing object
                var list = (IList) Staff.AggregateExtensions["Sample_StaffPetPreference"] ?? new List<object>();
                list.Clear();

                // If we're setting a value, add it to the list now
                if (value != null)
                {
                    list.Add(value);

                    // Set the parent reference
                    (value as IChildEntity).SetParent(Staff);
                }
            }
        }
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        private ICollection<Entities.Common.Sample.IStaffPet> _staffPets;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IStaffPet> IStaffExtension.StaffPets
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StaffPet>((IList<object>) Staff.AggregateExtensions["Sample_StaffPets"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StaffPet item in sourceList)
                    if (item.Staff == null)
                        item.Staff = this.Staff;
                // -------------------------------------------------------------

                if (_staffPets == null)
                    _staffPets = new CovariantCollectionAdapter<Entities.Common.Sample.IStaffPet, StaffPet>(sourceList);

                return _staffPets;
            }
            set
            {
                Staff.AggregateExtensions["Sample_StaffPets"] = value;
            }
        }
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Staff as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStaffExtension)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStaffExtension) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Staff = (EdFi.Staff) value;
        }
    }
}
// Aggregate: Student

namespace EdFi.Ods.Entities.NHibernate.StudentAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentAquaticPet table of the Student aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentAquaticPet : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentAquaticPet, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentAquaticPet()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Student Student { get; set; }

        Entities.Common.Sample.IStudentExtension IStudentAquaticPet.StudentExtension
        {
            get { return (IStudentExtension) Student.Extensions["Sample"]; }
            set { Student.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int MimimumTankVolume  { get; set; }

        [DomainSignature]
        [Key(2)]
        public virtual string PetName  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(3)]
        public virtual bool? IsFixed  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Student as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("MimimumTankVolume", MimimumTankVolume);
            keyValues.Add("PetName", PetName);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentAquaticPet)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentAquaticPet) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Student = (EdFi.Student) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentFavoriteBook table of the Student aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentFavoriteBook : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentFavoriteBook, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentFavoriteBook()
        {
            StudentFavoriteBookArtMedia = new HashSet<StudentFavoriteBookArtMedium>();
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Student Student { get; set; }

        Entities.Common.Sample.IStudentExtension IStudentFavoriteBook.StudentExtension
        {
            get { return (IStudentExtension) Student.Extensions["Sample"]; }
            set { Student.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int FavoriteBookCategoryDescriptorId 
        {
            get
            {
                if (_favoriteBookCategoryDescriptorId == default(int))
                {
                    _favoriteBookCategoryDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("FavoriteBookCategoryDescriptor", _favoriteBookCategoryDescriptor);
                }

                return _favoriteBookCategoryDescriptorId;
            } 
            set
            {
                _favoriteBookCategoryDescriptorId = value;
                _favoriteBookCategoryDescriptor = null;
            }
        }

        private int _favoriteBookCategoryDescriptorId;
        private string _favoriteBookCategoryDescriptor;

        [IgnoreMember]
        public virtual string FavoriteBookCategoryDescriptor
        {
            get
            {
                if (_favoriteBookCategoryDescriptor == null)
                    _favoriteBookCategoryDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("FavoriteBookCategoryDescriptor", _favoriteBookCategoryDescriptorId);
                    
                return _favoriteBookCategoryDescriptor;
            }
            set
            {
                _favoriteBookCategoryDescriptor = value;
                _favoriteBookCategoryDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(2)]
        public virtual string BookTitle  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------

        private ICollection<Entities.NHibernate.StudentAggregate.Sample.StudentFavoriteBookArtMedium> _studentFavoriteBookArtMedia;
        private ICollection<Entities.Common.Sample.IStudentFavoriteBookArtMedium> _studentFavoriteBookArtMediaCovariant;
        [Key(3)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentAggregate.Sample.StudentFavoriteBookArtMedium>))]
        public virtual ICollection<Entities.NHibernate.StudentAggregate.Sample.StudentFavoriteBookArtMedium> StudentFavoriteBookArtMedia
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentFavoriteBookArtMedia is DeserializedPersistentGenericSet<Entities.NHibernate.StudentAggregate.Sample.StudentFavoriteBookArtMedium> set)
                {
                    set.Reattach(this, "StudentFavoriteBookArtMedia");
                }
            
                foreach (var item in _studentFavoriteBookArtMedia)
                    if (item.StudentFavoriteBook == null)
                        item.StudentFavoriteBook = this;
                // -------------------------------------------------------------

                return _studentFavoriteBookArtMedia;
            }
            set
            {
                _studentFavoriteBookArtMedia = value;
                _studentFavoriteBookArtMediaCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentFavoriteBookArtMedium, Entities.NHibernate.StudentAggregate.Sample.StudentFavoriteBookArtMedium>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentFavoriteBookArtMedium> Entities.Common.Sample.IStudentFavoriteBook.StudentFavoriteBookArtMedia
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentFavoriteBookArtMedia)
                    if (item.StudentFavoriteBook == null)
                        item.StudentFavoriteBook = this;
                // -------------------------------------------------------------

                return _studentFavoriteBookArtMediaCovariant;
            }
            set
            {
                StudentFavoriteBookArtMedia = new HashSet<Entities.NHibernate.StudentAggregate.Sample.StudentFavoriteBookArtMedium>(value.Cast<Entities.NHibernate.StudentAggregate.Sample.StudentFavoriteBookArtMedium>());
            }
        }

        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "FavoriteBookCategoryDescriptor", new LookupColumnDetails { PropertyName = "FavoriteBookCategoryDescriptorId", LookupTypeName = "FavoriteBookCategoryDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Student as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("FavoriteBookCategoryDescriptorId", FavoriteBookCategoryDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentFavoriteBook)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentFavoriteBook) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Student = (EdFi.Student) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentFavoriteBookArtMedium table of the Student aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentFavoriteBookArtMedium : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentFavoriteBookArtMedium, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentFavoriteBookArtMedium()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentFavoriteBook StudentFavoriteBook { get; set; }

        Entities.Common.Sample.IStudentFavoriteBook IStudentFavoriteBookArtMedium.StudentFavoriteBook
        {
            get { return StudentFavoriteBook; }
            set { StudentFavoriteBook = (StudentFavoriteBook) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int ArtMediumDescriptorId 
        {
            get
            {
                if (_artMediumDescriptorId == default(int))
                {
                    _artMediumDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ArtMediumDescriptor", _artMediumDescriptor);
                }

                return _artMediumDescriptorId;
            } 
            set
            {
                _artMediumDescriptorId = value;
                _artMediumDescriptor = null;
            }
        }

        private int _artMediumDescriptorId;
        private string _artMediumDescriptor;

        [IgnoreMember]
        public virtual string ArtMediumDescriptor
        {
            get
            {
                if (_artMediumDescriptor == null)
                    _artMediumDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("ArtMediumDescriptor", _artMediumDescriptorId);
                    
                return _artMediumDescriptor;
            }
            set
            {
                _artMediumDescriptor = value;
                _artMediumDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(2)]
        public virtual int? ArtPieces  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "ArtMediumDescriptor", new LookupColumnDetails { PropertyName = "ArtMediumDescriptorId", LookupTypeName = "ArtMediumDescriptor"} },
                { "FavoriteBookCategoryDescriptor", new LookupColumnDetails { PropertyName = "FavoriteBookCategoryDescriptorId", LookupTypeName = "FavoriteBookCategoryDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentFavoriteBook as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("ArtMediumDescriptorId", ArtMediumDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentFavoriteBookArtMedium)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentFavoriteBookArtMedium) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentFavoriteBook = (StudentFavoriteBook) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentPet table of the Student aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentPet : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentPet, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentPet()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Student Student { get; set; }

        Entities.Common.Sample.IStudentExtension IStudentPet.StudentExtension
        {
            get { return (IStudentExtension) Student.Extensions["Sample"]; }
            set { Student.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string PetName  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(2)]
        public virtual bool? IsFixed  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Student as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("PetName", PetName);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentPet)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentPet) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Student = (EdFi.Student) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentPetPreference table of the Student aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentPetPreference : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentPetPreference, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentPetPreference()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.Student Student { get; set; }

        Entities.Common.Sample.IStudentExtension IStudentPetPreference.StudentExtension
        {
            get { return (IStudentExtension) Student.Extensions["Sample"]; }
            set { Student.Extensions["Sample"] = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual int MaximumWeight  { get; set; }

        [Key(2)]
        public virtual int MinimumWeight  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (Student as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentPetPreference)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentPetPreference) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            Student = (EdFi.Student) value;
        }
    }

    /// <summary>
    /// An implicitly created entity extension class to enable entity mapping and sychronization behavior for the Student entity's aggregate extensions.
    /// </summary>
    [ExcludeFromCodeCoverage][MessagePackObject]
    public class StudentExtension : IStudentExtension, IChildEntity, IImplicitEntityExtension, IHasPrimaryKeyValues
    {
        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        private EdFi.Student _student;

        Common.EdFi.IStudent IStudentExtension.Student
        {
            get { return _student; }
            set { _student = (EdFi.Student) value; }
        }

        private EdFi.Student Student
        {
            get { return (this as IStudentExtension).Student as EdFi.Student; }
        }

        bool IImplicitEntityExtension.IsEmpty()
        {
            return (true
                && StudentPetPreference == null
                && ((IList<object>) _student.AggregateExtensions["Sample_StudentAquaticPets"]).Count == 0
                && ((IList<object>) _student.AggregateExtensions["Sample_StudentFavoriteBooks"]).Count == 0
                && ((IList<object>) _student.AggregateExtensions["Sample_StudentPets"]).Count == 0
            );
        }

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // This property implementation exists to provide the mapper with reflection-based access to the target instance's .NET type (for creating new instances)
        [IgnoreMember]
        public StudentPetPreference StudentPetPreference
        {
            get { return (StudentPetPreference) (this as IStudentExtension).StudentPetPreference;  }
            set { (this as IStudentExtension).StudentPetPreference = value;  }
        }

        IStudentPetPreference IStudentExtension.StudentPetPreference
        {
            get
            {
                var list = (IList) _student.AggregateExtensions["Sample_StudentPetPreference"];

                if (list != null && list.Count > 0)
                    return (IStudentPetPreference) list[0];

                return null;
            }
            set
            {
                // Delete the existing object
                var list = (IList) _student.AggregateExtensions["Sample_StudentPetPreference"];
                list.Clear();

                // If we're setting a value, add it to the list now
                if (value != null)
                {
                    list.Add(value);

                    // Set the parent reference
                    (value as IChildEntity).SetParent(_student);
                }
            }
        }
        // -------------------------------------------------------------

        // =============================================================
        //                          Collections
        // -------------------------------------------------------------
        ICollection<IStudentAquaticPet> IStudentExtension.StudentAquaticPets
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentAquaticPet>((IList<object>) _student.AggregateExtensions["Sample_StudentAquaticPets"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentAquaticPet item in sourceList)
                    if (item.Student == null)
                        item.Student = this.Student;
                // -------------------------------------------------------------

                var adaptedList = new CovariantCollectionAdapter<IStudentAquaticPet, StudentAquaticPet>(sourceList);

                return adaptedList;
            }
            set
            {
                _student.AggregateExtensions["Sample_StudentAquaticPets"] = value;
            }
        }
        ICollection<IStudentFavoriteBook> IStudentExtension.StudentFavoriteBooks
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentFavoriteBook>((IList<object>) _student.AggregateExtensions["Sample_StudentFavoriteBooks"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentFavoriteBook item in sourceList)
                    if (item.Student == null)
                        item.Student = this.Student;
                // -------------------------------------------------------------

                var adaptedList = new CovariantCollectionAdapter<IStudentFavoriteBook, StudentFavoriteBook>(sourceList);

                return adaptedList;
            }
            set
            {
                _student.AggregateExtensions["Sample_StudentFavoriteBooks"] = value;
            }
        }
        ICollection<IStudentPet> IStudentExtension.StudentPets
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentPet>((IList<object>) _student.AggregateExtensions["Sample_StudentPets"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentPet item in sourceList)
                    if (item.Student == null)
                        item.Student = this.Student;
                // -------------------------------------------------------------

                var adaptedList = new CovariantCollectionAdapter<IStudentPet, StudentPet>(sourceList);

                return adaptedList;
            }
            set
            {
                _student.AggregateExtensions["Sample_StudentPets"] = value;
            }
        }
        // -------------------------------------------------------------

        void IMappable.Map(object target)
        {
            this.MapTo((IStudentExtension) target, null);
        }

        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((IStudentExtension) target);
        }

        void IChildEntity.SetParent(object value)
        {
            _student = (EdFi.Student)value;
        }

        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            return (_student as IHasPrimaryKeyValues).GetPrimaryKeyValues();
        }

        void IGetByExample.SuspendReferenceAssignmentCheck() { }
    }
}
// Aggregate: StudentArtProgramAssociation

namespace EdFi.Ods.Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentArtProgramAssociation table of the StudentArtProgramAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentArtProgramAssociation : GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociation,
        Entities.Common.Sample.IStudentArtProgramAssociation, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public StudentArtProgramAssociation()
        {
           StudentArtProgramAssociationFavoriteBookPersistentList = new HashSet<StudentArtProgramAssociationFavoriteBook>();
            StudentArtProgramAssociationArtMedia = new HashSet<StudentArtProgramAssociationArtMedium>();
            StudentArtProgramAssociationPortfolioYears = new HashSet<StudentArtProgramAssociationPortfolioYears>();
            StudentArtProgramAssociationServices = new HashSet<StudentArtProgramAssociationService>();
            StudentArtProgramAssociationStyles = new HashSet<StudentArtProgramAssociationStyle>();
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature]
        [IgnoreMember]
        public override DateTime BeginDate  { get; set; }

        [DomainSignature]
        [IgnoreMember]
        public override long EducationOrganizationId  { get; set; }

        [DomainSignature]
        [IgnoreMember]
        public override long ProgramEducationOrganizationId  { get; set; }

        [DomainSignature]
        [IgnoreMember]
        public override string ProgramName  { get; set; }

        [DomainSignature]
        [IgnoreMember]
        public override int ProgramTypeDescriptorId 
        {
            get
            {
                if (_programTypeDescriptorId == default(int))
                {
                    _programTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ProgramTypeDescriptor", _programTypeDescriptor);
                }

                return _programTypeDescriptorId;
            } 
            set
            {
                _programTypeDescriptorId = value;
                _programTypeDescriptor = null;
            }
        }

        private int _programTypeDescriptorId;
        private string _programTypeDescriptor;

        [IgnoreMember]
        public override string ProgramTypeDescriptor
        {
            get
            {
                if (_programTypeDescriptor == null)
                    _programTypeDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("ProgramTypeDescriptor", _programTypeDescriptorId);
                    
                return _programTypeDescriptor;
            }
            set
            {
                _programTypeDescriptor = value;
                _programTypeDescriptorId = default(int);
            }
        }

        [Display(Name="StudentUniqueId")][DomainSignature]
        [IgnoreMember]
        public override int StudentUSI 
        {
            get
            {
                if (_studentUSI == default(int) && _studentUniqueId != null)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Student", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_studentUniqueId, out var usi))
                    {
                        _studentUSI = usi;
                    }
                }

                return _studentUSI;
            } 
            set
            {
                _studentUSI = value;
                GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().AddLookup("Student", value);
            }
        }

        private int _studentUSI;
        private string _studentUniqueId;

        [IgnoreMember]
        public override string StudentUniqueId
        {
            get
            {
                if (_studentUniqueId == null)
                {
                    if (GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().UniqueIdByUsiByPersonType.TryGetValue("Student", out var uniqueIdByUsi)
                        && uniqueIdByUsi.TryGetValue(_studentUSI, out var uniqueId))
                    {
                        _studentUniqueId = uniqueId;
                    }
                }

                return _studentUniqueId;
            }
            set
            {
                if (_studentUniqueId != value)
                        _studentUSI = default(int);

                _studentUniqueId = value;
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        DateTime? IGeneralStudentProgramAssociation.EndDate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }
        string IGeneralStudentProgramAssociation.ReasonExitedDescriptor
        {
            get { return ReasonExitedDescriptor; }
            set { ReasonExitedDescriptor = value; }
        }
        bool? IGeneralStudentProgramAssociation.ServedOutsideOfRegularSession
        {
            get { return ServedOutsideOfRegularSession; }
            set { ServedOutsideOfRegularSession = value; }
        }
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(19)]
        public virtual int? ArtPieces  { get; set; }

        [Key(20)]
        public virtual DateTime? ExhibitDate 
        {
            get { return _exhibitDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _exhibitDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _exhibitDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _exhibitDate;

        [Key(21)]
        public virtual decimal? HoursPerDay  { get; set; }

        [Key(22)]
        public virtual string IdentificationCode  { get; set; }

        [Key(23)]
        public virtual TimeSpan? KilnReservation  { get; set; }

        [Key(24)]
        public virtual string KilnReservationLength  { get; set; }

        [Key(25)]
        public virtual decimal? MasteredMediums  { get; set; }

        [Key(26)]
        public virtual decimal? NumberOfDaysInAttendance  { get; set; }

        [Key(27)]
        public virtual int? PortfolioPieces  { get; set; }

        [Key(28)]
        public virtual bool PrivateArtProgram  { get; set; }

        [Key(29)]
        public virtual decimal? ProgramFees  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        [IgnoreMember]
        public virtual Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBook StudentArtProgramAssociationFavoriteBook
        {
            get
            {
                // Return the item in the list, if one exists
                if (StudentArtProgramAssociationFavoriteBookPersistentList.Any())
                    return StudentArtProgramAssociationFavoriteBookPersistentList.First();

                // No reference is present
                return null;
            }
            set
            {
                // Delete the existing object
                if (StudentArtProgramAssociationFavoriteBookPersistentList.Any())
                    StudentArtProgramAssociationFavoriteBookPersistentList.Clear();

                // If we're setting a value, add it to the list now
                if (value != null)
                {
                    // Set the back-reference to the parent
                    value.StudentArtProgramAssociation = this;

                    StudentArtProgramAssociationFavoriteBookPersistentList.Add(value);
                }
            }
        }

        Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBook Entities.Common.Sample.IStudentArtProgramAssociation.StudentArtProgramAssociationFavoriteBook
        {
            get { return StudentArtProgramAssociationFavoriteBook; }
            set { StudentArtProgramAssociationFavoriteBook = (Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBook) value; }
        }

        private ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBook> _studentArtProgramAssociationFavoriteBookPersistentList;

        [Key(30)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBook>))]
        public virtual ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBook> StudentArtProgramAssociationFavoriteBookPersistentList
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentArtProgramAssociationFavoriteBookPersistentList is DeserializedPersistentGenericSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBook> set)
                {
                    set.Reattach(this, "StudentArtProgramAssociationFavoriteBook");
                }

                foreach (var item in _studentArtProgramAssociationFavoriteBookPersistentList)
                    if (item.StudentArtProgramAssociation == null)
                        item.StudentArtProgramAssociation = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationFavoriteBookPersistentList;
            }
            set
            {
                _studentArtProgramAssociationFavoriteBookPersistentList = value;
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------

        private ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationArtMedium> _studentArtProgramAssociationArtMedia;
        private ICollection<Entities.Common.Sample.IStudentArtProgramAssociationArtMedium> _studentArtProgramAssociationArtMediaCovariant;
        [Key(31)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationArtMedium>))]
        public virtual ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationArtMedium> StudentArtProgramAssociationArtMedia
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentArtProgramAssociationArtMedia is DeserializedPersistentGenericSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationArtMedium> set)
                {
                    set.Reattach(this, "StudentArtProgramAssociationArtMedia");
                }
            
                foreach (var item in _studentArtProgramAssociationArtMedia)
                    if (item.StudentArtProgramAssociation == null)
                        item.StudentArtProgramAssociation = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationArtMedia;
            }
            set
            {
                _studentArtProgramAssociationArtMedia = value;
                _studentArtProgramAssociationArtMediaCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentArtProgramAssociationArtMedium, Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationArtMedium>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentArtProgramAssociationArtMedium> Entities.Common.Sample.IStudentArtProgramAssociation.StudentArtProgramAssociationArtMedia
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentArtProgramAssociationArtMedia)
                    if (item.StudentArtProgramAssociation == null)
                        item.StudentArtProgramAssociation = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationArtMediaCovariant;
            }
            set
            {
                StudentArtProgramAssociationArtMedia = new HashSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationArtMedium>(value.Cast<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationArtMedium>());
            }
        }


        private ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationPortfolioYears> _studentArtProgramAssociationPortfolioYears;
        private ICollection<Entities.Common.Sample.IStudentArtProgramAssociationPortfolioYears> _studentArtProgramAssociationPortfolioYearsCovariant;
        [Key(32)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationPortfolioYears>))]
        public virtual ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationPortfolioYears> StudentArtProgramAssociationPortfolioYears
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentArtProgramAssociationPortfolioYears is DeserializedPersistentGenericSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationPortfolioYears> set)
                {
                    set.Reattach(this, "StudentArtProgramAssociationPortfolioYears");
                }
            
                foreach (var item in _studentArtProgramAssociationPortfolioYears)
                    if (item.StudentArtProgramAssociation == null)
                        item.StudentArtProgramAssociation = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationPortfolioYears;
            }
            set
            {
                _studentArtProgramAssociationPortfolioYears = value;
                _studentArtProgramAssociationPortfolioYearsCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentArtProgramAssociationPortfolioYears, Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationPortfolioYears>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentArtProgramAssociationPortfolioYears> Entities.Common.Sample.IStudentArtProgramAssociation.StudentArtProgramAssociationPortfolioYears
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentArtProgramAssociationPortfolioYears)
                    if (item.StudentArtProgramAssociation == null)
                        item.StudentArtProgramAssociation = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationPortfolioYearsCovariant;
            }
            set
            {
                StudentArtProgramAssociationPortfolioYears = new HashSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationPortfolioYears>(value.Cast<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationPortfolioYears>());
            }
        }


        private ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationService> _studentArtProgramAssociationServices;
        private ICollection<Entities.Common.Sample.IStudentArtProgramAssociationService> _studentArtProgramAssociationServicesCovariant;
        [Key(33)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationService>))]
        public virtual ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationService> StudentArtProgramAssociationServices
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentArtProgramAssociationServices is DeserializedPersistentGenericSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationService> set)
                {
                    set.Reattach(this, "StudentArtProgramAssociationServices");
                }
            
                foreach (var item in _studentArtProgramAssociationServices)
                    if (item.StudentArtProgramAssociation == null)
                        item.StudentArtProgramAssociation = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationServices;
            }
            set
            {
                _studentArtProgramAssociationServices = value;
                _studentArtProgramAssociationServicesCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentArtProgramAssociationService, Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationService>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentArtProgramAssociationService> Entities.Common.Sample.IStudentArtProgramAssociation.StudentArtProgramAssociationServices
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentArtProgramAssociationServices)
                    if (item.StudentArtProgramAssociation == null)
                        item.StudentArtProgramAssociation = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationServicesCovariant;
            }
            set
            {
                StudentArtProgramAssociationServices = new HashSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationService>(value.Cast<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationService>());
            }
        }


        private ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationStyle> _studentArtProgramAssociationStyles;
        private ICollection<Entities.Common.Sample.IStudentArtProgramAssociationStyle> _studentArtProgramAssociationStylesCovariant;
        [Key(34)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationStyle>))]
        public virtual ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationStyle> StudentArtProgramAssociationStyles
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentArtProgramAssociationStyles is DeserializedPersistentGenericSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationStyle> set)
                {
                    set.Reattach(this, "StudentArtProgramAssociationStyles");
                }
            
                foreach (var item in _studentArtProgramAssociationStyles)
                    if (item.StudentArtProgramAssociation == null)
                        item.StudentArtProgramAssociation = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationStyles;
            }
            set
            {
                _studentArtProgramAssociationStyles = value;
                _studentArtProgramAssociationStylesCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentArtProgramAssociationStyle, Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationStyle>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentArtProgramAssociationStyle> Entities.Common.Sample.IStudentArtProgramAssociation.StudentArtProgramAssociationStyles
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentArtProgramAssociationStyles)
                    if (item.StudentArtProgramAssociation == null)
                        item.StudentArtProgramAssociation = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationStylesCovariant;
            }
            set
            {
                StudentArtProgramAssociationStyles = new HashSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationStyle>(value.Cast<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationStyle>());
            }
        }

        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "ProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "ProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
                { "ReasonExitedDescriptor", new LookupColumnDetails { PropertyName = "ReasonExitedDescriptorId", LookupTypeName = "ReasonExitedDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("BeginDate", BeginDate);
            keyValues.Add("EducationOrganizationId", EducationOrganizationId);
            keyValues.Add("ProgramEducationOrganizationId", ProgramEducationOrganizationId);
            keyValues.Add("ProgramName", ProgramName);
            keyValues.Add("ProgramTypeDescriptorId", ProgramTypeDescriptorId);
            keyValues.Add("StudentUSI", StudentUSI);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentArtProgramAssociation)target);
        }

        void IMappable.Map(object target)
        {
            this.MapDerivedTo((Entities.Common.Sample.IStudentArtProgramAssociation) target, null);
        }

    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentArtProgramAssociationArtMedium table of the StudentArtProgramAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentArtProgramAssociationArtMedium : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentArtProgramAssociationArtMedium, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentArtProgramAssociationArtMedium()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentArtProgramAssociation StudentArtProgramAssociation { get; set; }

        Entities.Common.Sample.IStudentArtProgramAssociation IStudentArtProgramAssociationArtMedium.StudentArtProgramAssociation
        {
            get { return StudentArtProgramAssociation; }
            set { StudentArtProgramAssociation = (StudentArtProgramAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int ArtMediumDescriptorId 
        {
            get
            {
                if (_artMediumDescriptorId == default(int))
                {
                    _artMediumDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ArtMediumDescriptor", _artMediumDescriptor);
                }

                return _artMediumDescriptorId;
            } 
            set
            {
                _artMediumDescriptorId = value;
                _artMediumDescriptor = null;
            }
        }

        private int _artMediumDescriptorId;
        private string _artMediumDescriptor;

        [IgnoreMember]
        public virtual string ArtMediumDescriptor
        {
            get
            {
                if (_artMediumDescriptor == null)
                    _artMediumDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("ArtMediumDescriptor", _artMediumDescriptorId);
                    
                return _artMediumDescriptor;
            }
            set
            {
                _artMediumDescriptor = value;
                _artMediumDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "ArtMediumDescriptor", new LookupColumnDetails { PropertyName = "ArtMediumDescriptorId", LookupTypeName = "ArtMediumDescriptor"} },
                { "ProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "ProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentArtProgramAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("ArtMediumDescriptorId", ArtMediumDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentArtProgramAssociationArtMedium)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentArtProgramAssociationArtMedium) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentArtProgramAssociation = (StudentArtProgramAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentArtProgramAssociationFavoriteBook table of the StudentArtProgramAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentArtProgramAssociationFavoriteBook : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBook, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentArtProgramAssociationFavoriteBook()
        {
            StudentArtProgramAssociationFavoriteBookArtMedia = new HashSet<StudentArtProgramAssociationFavoriteBookArtMedium>();
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentArtProgramAssociation StudentArtProgramAssociation { get; set; }

        Entities.Common.Sample.IStudentArtProgramAssociation IStudentArtProgramAssociationFavoriteBook.StudentArtProgramAssociation
        {
            get { return StudentArtProgramAssociation; }
            set { StudentArtProgramAssociation = (StudentArtProgramAssociation) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual string BookTitle  { get; set; }

        [Key(2)]
        public virtual int FavoriteBookCategoryDescriptorId 
        {
            get
            {
                if (_favoriteBookCategoryDescriptorId == default(int))
                {
                    _favoriteBookCategoryDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("FavoriteBookCategoryDescriptor", _favoriteBookCategoryDescriptor);
                }

                return _favoriteBookCategoryDescriptorId;
            } 
            set
            {
                _favoriteBookCategoryDescriptorId = value;
                _favoriteBookCategoryDescriptor = null;
            }
        }

        private int _favoriteBookCategoryDescriptorId;
        private string _favoriteBookCategoryDescriptor;

        [IgnoreMember]
        public virtual string FavoriteBookCategoryDescriptor
        {
            get
            {
                if (_favoriteBookCategoryDescriptor == null)
                    _favoriteBookCategoryDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("FavoriteBookCategoryDescriptor", _favoriteBookCategoryDescriptorId);
                    
                return _favoriteBookCategoryDescriptor;
            }
            set
            {
                _favoriteBookCategoryDescriptor = value;
                _favoriteBookCategoryDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------

        private ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBookArtMedium> _studentArtProgramAssociationFavoriteBookArtMedia;
        private ICollection<Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBookArtMedium> _studentArtProgramAssociationFavoriteBookArtMediaCovariant;
        [Key(3)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBookArtMedium>))]
        public virtual ICollection<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBookArtMedium> StudentArtProgramAssociationFavoriteBookArtMedia
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentArtProgramAssociationFavoriteBookArtMedia is DeserializedPersistentGenericSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBookArtMedium> set)
                {
                    set.Reattach(this, "StudentArtProgramAssociationFavoriteBookArtMedia");
                }
            
                foreach (var item in _studentArtProgramAssociationFavoriteBookArtMedia)
                    if (item.StudentArtProgramAssociationFavoriteBook == null)
                        item.StudentArtProgramAssociationFavoriteBook = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationFavoriteBookArtMedia;
            }
            set
            {
                _studentArtProgramAssociationFavoriteBookArtMedia = value;
                _studentArtProgramAssociationFavoriteBookArtMediaCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBookArtMedium, Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBookArtMedium>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBookArtMedium> Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBook.StudentArtProgramAssociationFavoriteBookArtMedia
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentArtProgramAssociationFavoriteBookArtMedia)
                    if (item.StudentArtProgramAssociationFavoriteBook == null)
                        item.StudentArtProgramAssociationFavoriteBook = this;
                // -------------------------------------------------------------

                return _studentArtProgramAssociationFavoriteBookArtMediaCovariant;
            }
            set
            {
                StudentArtProgramAssociationFavoriteBookArtMedia = new HashSet<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBookArtMedium>(value.Cast<Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociationFavoriteBookArtMedium>());
            }
        }

        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "FavoriteBookCategoryDescriptor", new LookupColumnDetails { PropertyName = "FavoriteBookCategoryDescriptorId", LookupTypeName = "FavoriteBookCategoryDescriptor"} },
                { "ProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "ProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentArtProgramAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBook)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBook) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentArtProgramAssociation = (StudentArtProgramAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentArtProgramAssociationFavoriteBookArtMedium table of the StudentArtProgramAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentArtProgramAssociationFavoriteBookArtMedium : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBookArtMedium, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentArtProgramAssociationFavoriteBookArtMedium()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentArtProgramAssociationFavoriteBook StudentArtProgramAssociationFavoriteBook { get; set; }

        Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBook IStudentArtProgramAssociationFavoriteBookArtMedium.StudentArtProgramAssociationFavoriteBook
        {
            get { return StudentArtProgramAssociationFavoriteBook; }
            set { StudentArtProgramAssociationFavoriteBook = (StudentArtProgramAssociationFavoriteBook) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int ArtMediumDescriptorId 
        {
            get
            {
                if (_artMediumDescriptorId == default(int))
                {
                    _artMediumDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ArtMediumDescriptor", _artMediumDescriptor);
                }

                return _artMediumDescriptorId;
            } 
            set
            {
                _artMediumDescriptorId = value;
                _artMediumDescriptor = null;
            }
        }

        private int _artMediumDescriptorId;
        private string _artMediumDescriptor;

        [IgnoreMember]
        public virtual string ArtMediumDescriptor
        {
            get
            {
                if (_artMediumDescriptor == null)
                    _artMediumDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("ArtMediumDescriptor", _artMediumDescriptorId);
                    
                return _artMediumDescriptor;
            }
            set
            {
                _artMediumDescriptor = value;
                _artMediumDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(2)]
        public virtual int? ArtPieces  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "ArtMediumDescriptor", new LookupColumnDetails { PropertyName = "ArtMediumDescriptorId", LookupTypeName = "ArtMediumDescriptor"} },
                { "ProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "ProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentArtProgramAssociationFavoriteBook as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("ArtMediumDescriptorId", ArtMediumDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBookArtMedium)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentArtProgramAssociationFavoriteBookArtMedium) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentArtProgramAssociationFavoriteBook = (StudentArtProgramAssociationFavoriteBook) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentArtProgramAssociationPortfolioYears table of the StudentArtProgramAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentArtProgramAssociationPortfolioYears : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentArtProgramAssociationPortfolioYears, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentArtProgramAssociationPortfolioYears()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentArtProgramAssociation StudentArtProgramAssociation { get; set; }

        Entities.Common.Sample.IStudentArtProgramAssociation IStudentArtProgramAssociationPortfolioYears.StudentArtProgramAssociation
        {
            get { return StudentArtProgramAssociation; }
            set { StudentArtProgramAssociation = (StudentArtProgramAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual short PortfolioYears  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "ProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "ProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentArtProgramAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("PortfolioYears", PortfolioYears);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentArtProgramAssociationPortfolioYears)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentArtProgramAssociationPortfolioYears) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentArtProgramAssociation = (StudentArtProgramAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentArtProgramAssociationService table of the StudentArtProgramAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentArtProgramAssociationService : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentArtProgramAssociationService, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentArtProgramAssociationService()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentArtProgramAssociation StudentArtProgramAssociation { get; set; }

        Entities.Common.Sample.IStudentArtProgramAssociation IStudentArtProgramAssociationService.StudentArtProgramAssociation
        {
            get { return StudentArtProgramAssociation; }
            set { StudentArtProgramAssociation = (StudentArtProgramAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int ServiceDescriptorId 
        {
            get
            {
                if (_serviceDescriptorId == default(int))
                {
                    _serviceDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ServiceDescriptor", _serviceDescriptor);
                }

                return _serviceDescriptorId;
            } 
            set
            {
                _serviceDescriptorId = value;
                _serviceDescriptor = null;
            }
        }

        private int _serviceDescriptorId;
        private string _serviceDescriptor;

        [IgnoreMember]
        public virtual string ServiceDescriptor
        {
            get
            {
                if (_serviceDescriptor == null)
                    _serviceDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("ServiceDescriptor", _serviceDescriptorId);
                    
                return _serviceDescriptor;
            }
            set
            {
                _serviceDescriptor = value;
                _serviceDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(2)]
        public virtual bool? PrimaryIndicator  { get; set; }

        [Key(3)]
        public virtual DateTime? ServiceBeginDate 
        {
            get { return _serviceBeginDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _serviceBeginDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _serviceBeginDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _serviceBeginDate;

        [Key(4)]
        public virtual DateTime? ServiceEndDate 
        {
            get { return _serviceEndDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _serviceEndDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _serviceEndDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _serviceEndDate;

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "ProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "ProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
                { "ServiceDescriptor", new LookupColumnDetails { PropertyName = "ServiceDescriptorId", LookupTypeName = "ServiceDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentArtProgramAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("ServiceDescriptorId", ServiceDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentArtProgramAssociationService)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentArtProgramAssociationService) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentArtProgramAssociation = (StudentArtProgramAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentArtProgramAssociationStyle table of the StudentArtProgramAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentArtProgramAssociationStyle : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentArtProgramAssociationStyle, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentArtProgramAssociationStyle()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentArtProgramAssociation StudentArtProgramAssociation { get; set; }

        Entities.Common.Sample.IStudentArtProgramAssociation IStudentArtProgramAssociationStyle.StudentArtProgramAssociation
        {
            get { return StudentArtProgramAssociation; }
            set { StudentArtProgramAssociation = (StudentArtProgramAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string Style  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "ProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "ProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentArtProgramAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("Style", Style);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentArtProgramAssociationStyle)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentArtProgramAssociationStyle) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentArtProgramAssociation = (StudentArtProgramAssociation) value;
        }
    }
}
// Aggregate: StudentContactAssociation

namespace EdFi.Ods.Entities.NHibernate.StudentContactAssociationAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentContactAssociationDiscipline table of the StudentContactAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentContactAssociationDiscipline : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentContactAssociationDiscipline, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentContactAssociationDiscipline()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentContactAssociation StudentContactAssociation { get; set; }

        Entities.Common.Sample.IStudentContactAssociationExtension IStudentContactAssociationDiscipline.StudentContactAssociationExtension
        {
            get { return (IStudentContactAssociationExtension) StudentContactAssociation.Extensions["Sample"]; }
            set { StudentContactAssociation.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int DisciplineDescriptorId 
        {
            get
            {
                if (_disciplineDescriptorId == default(int))
                {
                    _disciplineDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("DisciplineDescriptor", _disciplineDescriptor);
                }

                return _disciplineDescriptorId;
            } 
            set
            {
                _disciplineDescriptorId = value;
                _disciplineDescriptor = null;
            }
        }

        private int _disciplineDescriptorId;
        private string _disciplineDescriptor;

        [IgnoreMember]
        public virtual string DisciplineDescriptor
        {
            get
            {
                if (_disciplineDescriptor == null)
                    _disciplineDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("DisciplineDescriptor", _disciplineDescriptorId);
                    
                return _disciplineDescriptor;
            }
            set
            {
                _disciplineDescriptor = value;
                _disciplineDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "DisciplineDescriptor", new LookupColumnDetails { PropertyName = "DisciplineDescriptorId", LookupTypeName = "DisciplineDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentContactAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("DisciplineDescriptorId", DisciplineDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentContactAssociationDiscipline)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentContactAssociationDiscipline) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentContactAssociation = (EdFi.StudentContactAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentContactAssociationFavoriteBookTitle table of the StudentContactAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentContactAssociationFavoriteBookTitle : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentContactAssociationFavoriteBookTitle, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentContactAssociationFavoriteBookTitle()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentContactAssociation StudentContactAssociation { get; set; }

        Entities.Common.Sample.IStudentContactAssociationExtension IStudentContactAssociationFavoriteBookTitle.StudentContactAssociationExtension
        {
            get { return (IStudentContactAssociationExtension) StudentContactAssociation.Extensions["Sample"]; }
            set { StudentContactAssociation.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string FavoriteBookTitle  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentContactAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("FavoriteBookTitle", FavoriteBookTitle);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentContactAssociationFavoriteBookTitle)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentContactAssociationFavoriteBookTitle) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentContactAssociation = (EdFi.StudentContactAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentContactAssociationHoursPerWeek table of the StudentContactAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentContactAssociationHoursPerWeek : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentContactAssociationHoursPerWeek, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentContactAssociationHoursPerWeek()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentContactAssociation StudentContactAssociation { get; set; }

        Entities.Common.Sample.IStudentContactAssociationExtension IStudentContactAssociationHoursPerWeek.StudentContactAssociationExtension
        {
            get { return (IStudentContactAssociationExtension) StudentContactAssociation.Extensions["Sample"]; }
            set { StudentContactAssociation.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual decimal HoursPerWeek  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentContactAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("HoursPerWeek", HoursPerWeek);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentContactAssociationHoursPerWeek)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentContactAssociationHoursPerWeek) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentContactAssociation = (EdFi.StudentContactAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentContactAssociationPagesRead table of the StudentContactAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentContactAssociationPagesRead : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentContactAssociationPagesRead, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentContactAssociationPagesRead()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentContactAssociation StudentContactAssociation { get; set; }

        Entities.Common.Sample.IStudentContactAssociationExtension IStudentContactAssociationPagesRead.StudentContactAssociationExtension
        {
            get { return (IStudentContactAssociationExtension) StudentContactAssociation.Extensions["Sample"]; }
            set { StudentContactAssociation.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual decimal PagesRead  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentContactAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("PagesRead", PagesRead);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentContactAssociationPagesRead)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentContactAssociationPagesRead) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentContactAssociation = (EdFi.StudentContactAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentContactAssociationStaffEducationOrganizationEmploymentAssociation table of the StudentContactAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentContactAssociationStaffEducationOrganizationEmploymentAssociation : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentContactAssociationStaffEducationOrganizationEmploymentAssociation, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentContactAssociationStaffEducationOrganizationEmploymentAssociation()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData _staffEducationOrganizationEmploymentAssociationReferenceData;

        private bool StaffEducationOrganizationEmploymentAssociationReferenceDataIsProxied()
        {
            return _staffEducationOrganizationEmploymentAssociationReferenceData != null 
                && _staffEducationOrganizationEmploymentAssociationReferenceData.GetType() != typeof(NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData StaffEducationOrganizationEmploymentAssociationReferenceData
        {
            get => _staffEducationOrganizationEmploymentAssociationReferenceData;
            set
            {
                _staffEducationOrganizationEmploymentAssociationReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !StaffEducationOrganizationEmploymentAssociationReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(1)]
        public virtual NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData StaffEducationOrganizationEmploymentAssociationSerializedReferenceData { get => _staffEducationOrganizationEmploymentAssociationSerializedReferenceData; set { if (value != null) _staffEducationOrganizationEmploymentAssociationSerializedReferenceData = value; } }
        private NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData _staffEducationOrganizationEmploymentAssociationSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the StaffEducationOrganizationEmploymentAssociation discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IStudentContactAssociationStaffEducationOrganizationEmploymentAssociation.StaffEducationOrganizationEmploymentAssociationDiscriminator
        {
            get
            {
                return StaffEducationOrganizationEmploymentAssociationReferenceDataIsProxied()
                    ? (StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ?? StaffEducationOrganizationEmploymentAssociationReferenceData)?.Discriminator
                    : (StaffEducationOrganizationEmploymentAssociationReferenceData ?? StaffEducationOrganizationEmploymentAssociationSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the StaffEducationOrganizationEmploymentAssociation resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IStudentContactAssociationStaffEducationOrganizationEmploymentAssociation.StaffEducationOrganizationEmploymentAssociationResourceId
        {
            get
            {
                return StaffEducationOrganizationEmploymentAssociationReferenceDataIsProxied()
                    ? (StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ?? StaffEducationOrganizationEmploymentAssociationReferenceData)?.Id
                    : (StaffEducationOrganizationEmploymentAssociationReferenceData ?? StaffEducationOrganizationEmploymentAssociationSerializedReferenceData)?.Id;
            }
            set { if (StaffEducationOrganizationEmploymentAssociationSerializedReferenceData?.IsFullyDefined() == true) StaffEducationOrganizationEmploymentAssociationSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentContactAssociation StudentContactAssociation { get; set; }

        Entities.Common.Sample.IStudentContactAssociationExtension IStudentContactAssociationStaffEducationOrganizationEmploymentAssociation.StudentContactAssociationExtension
        {
            get { return (IStudentContactAssociationExtension) StudentContactAssociation.Extensions["Sample"]; }
            set { StudentContactAssociation.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(2)]
        public virtual long EducationOrganizationId 
        {
            get => _educationOrganizationId;
            set
            {
                _educationOrganizationId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData(true);
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData.EducationOrganizationId = value;
                }
            }
        }

        private long _educationOrganizationId;

        [DomainSignature]
        [Key(3)]
        public virtual int EmploymentStatusDescriptorId 
        {
            get
            {
                if (_employmentStatusDescriptorId == default(int))
                {
                    _employmentStatusDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("EmploymentStatusDescriptor", _employmentStatusDescriptor);
                
                    if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                    {
                        StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData(true);
                        StaffEducationOrganizationEmploymentAssociationSerializedReferenceData.EmploymentStatusDescriptorId = _employmentStatusDescriptorId;
                    }
                }

                return _employmentStatusDescriptorId;
            } 
            set
            {
                _employmentStatusDescriptorId = value;
                _employmentStatusDescriptor = null;
        
                if (value != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData(true);
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData.EmploymentStatusDescriptorId = value;
                }
            }
        }

        private int _employmentStatusDescriptorId;
        private string _employmentStatusDescriptor;

        [IgnoreMember]
        public virtual string EmploymentStatusDescriptor
        {
            get
            {
                if (_employmentStatusDescriptor == null)
                    _employmentStatusDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("EmploymentStatusDescriptor", _employmentStatusDescriptorId);
                    
                return _employmentStatusDescriptor;
            }
            set
            {
                _employmentStatusDescriptor = value;
                _employmentStatusDescriptorId = default(int);

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData(true);
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData.EmploymentStatusDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("EmploymentStatusDescriptor", _employmentStatusDescriptor);
                }
            }
        }

        [DomainSignature]
        [Key(4)]
        public virtual DateTime HireDate 
        {
            get { return _hireDate; }
            //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
            set
            {
                _hireDate = new DateTime(value.Year, value.Month, value.Day);

                if (_hireDate != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData(true);
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData.HireDate = _hireDate;
                }
            }
        }

        private DateTime _hireDate;

        [Display(Name="StaffUniqueId")][DomainSignature]
        [Key(5)]
        public virtual int StaffUSI 
        {
            get
            {
                if (_staffUSI == default(int) && _staffUniqueId != null)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Staff", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_staffUniqueId, out var usi))
                    {
                        _staffUSI = usi;

                        if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                        {
                            StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData(true);
                            StaffEducationOrganizationEmploymentAssociationSerializedReferenceData.StaffUSI = _staffUSI;
                        }
                    }
                }

                return _staffUSI;
            } 
            set
            {
                _staffUSI = value;
                GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().AddLookup("Staff", value);

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData(true);
                    StaffEducationOrganizationEmploymentAssociationSerializedReferenceData.StaffUSI = value;
                }
            }
        }

        private int _staffUSI;
        private string _staffUniqueId;

        [IgnoreMember]
        public virtual string StaffUniqueId
        {
            get
            {
                if (_staffUniqueId == null)
                {
                    if (GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().UniqueIdByUsiByPersonType.TryGetValue("Staff", out var uniqueIdByUsi)
                        && uniqueIdByUsi.TryGetValue(_staffUSI, out var uniqueId))
                    {
                        _staffUniqueId = uniqueId;
                    }
                }

                return _staffUniqueId;
            }
            set
            {
                if (_staffUniqueId != value)
                        _staffUSI = default(int);

                _staffUniqueId = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Staff", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_staffUniqueId, out var usi))
                    {
                        StaffEducationOrganizationEmploymentAssociationSerializedReferenceData ??= new NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.EdFi.StaffEducationOrganizationEmploymentAssociationReferenceData(true);
                        StaffEducationOrganizationEmploymentAssociationSerializedReferenceData.StaffUSI = usi;
                    }
                }
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "EmploymentStatusDescriptor", new LookupColumnDetails { PropertyName = "EmploymentStatusDescriptorId", LookupTypeName = "EmploymentStatusDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentContactAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("EducationOrganizationId", EducationOrganizationId);
            keyValues.Add("EmploymentStatusDescriptorId", EmploymentStatusDescriptorId);
            keyValues.Add("HireDate", HireDate);
            keyValues.Add("StaffUSI", StaffUSI);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentContactAssociationStaffEducationOrganizationEmploymentAssociation)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentContactAssociationStaffEducationOrganizationEmploymentAssociation) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentContactAssociation = (EdFi.StudentContactAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentContactAssociationTelephone table of the StudentContactAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentContactAssociationTelephone : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentContactAssociationTelephone, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentContactAssociationTelephone()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentContactAssociation StudentContactAssociation { get; set; }

        Entities.Common.Sample.IStudentContactAssociationExtension IStudentContactAssociationTelephone.StudentContactAssociationExtension
        {
            get { return (IStudentContactAssociationExtension) StudentContactAssociation.Extensions["Sample"]; }
            set { StudentContactAssociation.Extensions["Sample"] = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual bool? DoNotPublishIndicator  { get; set; }

        [Key(2)]
        public virtual int? OrderOfPriority  { get; set; }

        [Key(3)]
        public virtual string TelephoneNumber  { get; set; }

        [Key(4)]
        public virtual int TelephoneNumberTypeDescriptorId 
        {
            get
            {
                if (_telephoneNumberTypeDescriptorId == default(int))
                {
                    _telephoneNumberTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("TelephoneNumberTypeDescriptor", _telephoneNumberTypeDescriptor);
                }

                return _telephoneNumberTypeDescriptorId;
            } 
            set
            {
                _telephoneNumberTypeDescriptorId = value;
                _telephoneNumberTypeDescriptor = null;
            }
        }

        private int _telephoneNumberTypeDescriptorId;
        private string _telephoneNumberTypeDescriptor;

        [IgnoreMember]
        public virtual string TelephoneNumberTypeDescriptor
        {
            get
            {
                if (_telephoneNumberTypeDescriptor == null)
                    _telephoneNumberTypeDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("TelephoneNumberTypeDescriptor", _telephoneNumberTypeDescriptorId);
                    
                return _telephoneNumberTypeDescriptor;
            }
            set
            {
                _telephoneNumberTypeDescriptor = value;
                _telephoneNumberTypeDescriptorId = default(int);
            }
        }

        [Key(5)]
        public virtual bool? TextMessageCapabilityIndicator  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "TelephoneNumberTypeDescriptor", new LookupColumnDetails { PropertyName = "TelephoneNumberTypeDescriptorId", LookupTypeName = "TelephoneNumberTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentContactAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentContactAssociationTelephone)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentContactAssociationTelephone) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentContactAssociation = (EdFi.StudentContactAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentContactAssociationExtension table of the StudentContactAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentContactAssociationExtension : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentContactAssociationExtension, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentContactAssociationExtension()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.InterventionStudyAggregate.EdFi.InterventionStudyReferenceData _interventionStudyReferenceData;

        private bool InterventionStudyReferenceDataIsProxied()
        {
            return _interventionStudyReferenceData != null 
                && _interventionStudyReferenceData.GetType() != typeof(NHibernate.InterventionStudyAggregate.EdFi.InterventionStudyReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.InterventionStudyAggregate.EdFi.InterventionStudyReferenceData InterventionStudyReferenceData
        {
            get => _interventionStudyReferenceData;
            set
            {
                _interventionStudyReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !InterventionStudyReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(1)]
        public virtual NHibernate.InterventionStudyAggregate.EdFi.InterventionStudyReferenceData InterventionStudySerializedReferenceData { get => _interventionStudySerializedReferenceData; set { if (value != null) _interventionStudySerializedReferenceData = value; } }
        private NHibernate.InterventionStudyAggregate.EdFi.InterventionStudyReferenceData _interventionStudySerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the InterventionStudy discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IStudentContactAssociationExtension.InterventionStudyDiscriminator
        {
            get
            {
                return InterventionStudyReferenceDataIsProxied()
                    ? (InterventionStudySerializedReferenceData ?? InterventionStudyReferenceData)?.Discriminator
                    : (InterventionStudyReferenceData ?? InterventionStudySerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the InterventionStudy resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IStudentContactAssociationExtension.InterventionStudyResourceId
        {
            get
            {
                return InterventionStudyReferenceDataIsProxied()
                    ? (InterventionStudySerializedReferenceData ?? InterventionStudyReferenceData)?.Id
                    : (InterventionStudyReferenceData ?? InterventionStudySerializedReferenceData)?.Id;
            }
            set { if (InterventionStudySerializedReferenceData?.IsFullyDefined() == true) InterventionStudySerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentContactAssociation StudentContactAssociation { get; set; }

        Entities.Common.EdFi.IStudentContactAssociation IStudentContactAssociationExtension.StudentContactAssociation
        {
            get { return StudentContactAssociation; }
            set { StudentContactAssociation = (EdFi.StudentContactAssociation) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(2)]
        public virtual bool BedtimeReader  { get; set; }

        [Key(3)]
        public virtual decimal? BedtimeReadingRate  { get; set; }

        [Key(4)]
        public virtual decimal? BookBudget  { get; set; }

        [Key(5)]
        public virtual int? BooksBorrowed  { get; set; }

        [Key(6)]
        public virtual long? EducationOrganizationId 
        {
            get => _educationOrganizationId;
            set
            {
                _educationOrganizationId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    InterventionStudySerializedReferenceData ??= new NHibernate.InterventionStudyAggregate.EdFi.InterventionStudyReferenceData(true);
                    InterventionStudySerializedReferenceData.EducationOrganizationId = value ?? default;
                }
            }
        }

        private long? _educationOrganizationId;

        [Key(7)]
        public virtual string InterventionStudyIdentificationCode 
        {
            get => _interventionStudyIdentificationCode;
            set
            {
                _interventionStudyIdentificationCode = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    InterventionStudySerializedReferenceData ??= new NHibernate.InterventionStudyAggregate.EdFi.InterventionStudyReferenceData(true);
                    InterventionStudySerializedReferenceData.InterventionStudyIdentificationCode = value ?? default;
                }
            }
        }

        private string _interventionStudyIdentificationCode;

        [Key(8)]
        public virtual int? LibraryDuration  { get; set; }

        [Key(9)]
        public virtual TimeSpan? LibraryTime  { get; set; }

        [Key(10)]
        public virtual short? LibraryVisits  { get; set; }

        [Key(11)]
        public virtual string PriorContactRestrictions  { get; set; }

        [Key(12)]
        public virtual DateTime? ReadGreenEggsAndHamDate 
        {
            get { return _readGreenEggsAndHamDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _readGreenEggsAndHamDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _readGreenEggsAndHamDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _readGreenEggsAndHamDate;

        [Key(13)]
        public virtual string ReadingTimeSpent  { get; set; }

        [Key(14)]
        public virtual short? StudentRead  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        [IgnoreMember]
        // This property implementation exists to provide the mapper with reflection-based access to the target instance's .NET type (for creating new instances)
        public Entities.NHibernate.StudentContactAssociationAggregate.Sample.StudentContactAssociationTelephone StudentContactAssociationTelephone
        {
            get { return (Entities.NHibernate.StudentContactAssociationAggregate.Sample.StudentContactAssociationTelephone) (this as Entities.Common.Sample.IStudentContactAssociationExtension).StudentContactAssociationTelephone;  }
            set { (this as Entities.Common.Sample.IStudentContactAssociationExtension).StudentContactAssociationTelephone = value;  }
        }

        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        Entities.Common.Sample.IStudentContactAssociationTelephone Entities.Common.Sample.IStudentContactAssociationExtension.StudentContactAssociationTelephone
        {
            get
            {
                var list = (IList) StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationTelephone"];

                if (list != null && list.Count > 0)
                    return (Entities.Common.Sample.IStudentContactAssociationTelephone) list[0];

                return null;
            }
            set
            {
                // Delete the existing object
                var list = (IList) StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationTelephone"] ?? new List<object>();
                list.Clear();

                // If we're setting a value, add it to the list now
                if (value != null)
                {
                    list.Add(value);

                    // Set the parent reference
                    (value as IChildEntity).SetParent(StudentContactAssociation);
                }
            }
        }
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        private ICollection<Entities.Common.Sample.IStudentContactAssociationDiscipline> _studentContactAssociationDisciplines;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IStudentContactAssociationDiscipline> IStudentContactAssociationExtension.StudentContactAssociationDisciplines
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentContactAssociationDiscipline>((IList<object>) StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationDisciplines"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentContactAssociationDiscipline item in sourceList)
                    if (item.StudentContactAssociation == null)
                        item.StudentContactAssociation = this.StudentContactAssociation;
                // -------------------------------------------------------------

                if (_studentContactAssociationDisciplines == null)
                    _studentContactAssociationDisciplines = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentContactAssociationDiscipline, StudentContactAssociationDiscipline>(sourceList);

                return _studentContactAssociationDisciplines;
            }
            set
            {
                StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationDisciplines"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IStudentContactAssociationFavoriteBookTitle> _studentContactAssociationFavoriteBookTitles;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IStudentContactAssociationFavoriteBookTitle> IStudentContactAssociationExtension.StudentContactAssociationFavoriteBookTitles
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentContactAssociationFavoriteBookTitle>((IList<object>) StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationFavoriteBookTitles"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentContactAssociationFavoriteBookTitle item in sourceList)
                    if (item.StudentContactAssociation == null)
                        item.StudentContactAssociation = this.StudentContactAssociation;
                // -------------------------------------------------------------

                if (_studentContactAssociationFavoriteBookTitles == null)
                    _studentContactAssociationFavoriteBookTitles = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentContactAssociationFavoriteBookTitle, StudentContactAssociationFavoriteBookTitle>(sourceList);

                return _studentContactAssociationFavoriteBookTitles;
            }
            set
            {
                StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationFavoriteBookTitles"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IStudentContactAssociationHoursPerWeek> _studentContactAssociationHoursPerWeeks;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IStudentContactAssociationHoursPerWeek> IStudentContactAssociationExtension.StudentContactAssociationHoursPerWeeks
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentContactAssociationHoursPerWeek>((IList<object>) StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationHoursPerWeeks"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentContactAssociationHoursPerWeek item in sourceList)
                    if (item.StudentContactAssociation == null)
                        item.StudentContactAssociation = this.StudentContactAssociation;
                // -------------------------------------------------------------

                if (_studentContactAssociationHoursPerWeeks == null)
                    _studentContactAssociationHoursPerWeeks = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentContactAssociationHoursPerWeek, StudentContactAssociationHoursPerWeek>(sourceList);

                return _studentContactAssociationHoursPerWeeks;
            }
            set
            {
                StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationHoursPerWeeks"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IStudentContactAssociationPagesRead> _studentContactAssociationPagesReads;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IStudentContactAssociationPagesRead> IStudentContactAssociationExtension.StudentContactAssociationPagesReads
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentContactAssociationPagesRead>((IList<object>) StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationPagesReads"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentContactAssociationPagesRead item in sourceList)
                    if (item.StudentContactAssociation == null)
                        item.StudentContactAssociation = this.StudentContactAssociation;
                // -------------------------------------------------------------

                if (_studentContactAssociationPagesReads == null)
                    _studentContactAssociationPagesReads = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentContactAssociationPagesRead, StudentContactAssociationPagesRead>(sourceList);

                return _studentContactAssociationPagesReads;
            }
            set
            {
                StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationPagesReads"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IStudentContactAssociationStaffEducationOrganizationEmploymentAssociation> _studentContactAssociationStaffEducationOrganizationEmploymentAssociations;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IStudentContactAssociationStaffEducationOrganizationEmploymentAssociation> IStudentContactAssociationExtension.StudentContactAssociationStaffEducationOrganizationEmploymentAssociations
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentContactAssociationStaffEducationOrganizationEmploymentAssociation>((IList<object>) StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationStaffEducationOrganizationEmploymentAssociations"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentContactAssociationStaffEducationOrganizationEmploymentAssociation item in sourceList)
                    if (item.StudentContactAssociation == null)
                        item.StudentContactAssociation = this.StudentContactAssociation;
                // -------------------------------------------------------------

                if (_studentContactAssociationStaffEducationOrganizationEmploymentAssociations == null)
                    _studentContactAssociationStaffEducationOrganizationEmploymentAssociations = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentContactAssociationStaffEducationOrganizationEmploymentAssociation, StudentContactAssociationStaffEducationOrganizationEmploymentAssociation>(sourceList);

                return _studentContactAssociationStaffEducationOrganizationEmploymentAssociations;
            }
            set
            {
                StudentContactAssociation.AggregateExtensions["Sample_StudentContactAssociationStaffEducationOrganizationEmploymentAssociations"] = value;
            }
        }
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentContactAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentContactAssociationExtension)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentContactAssociationExtension) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentContactAssociation = (EdFi.StudentContactAssociation) value;
        }
    }
}
// Aggregate: StudentCTEProgramAssociation

namespace EdFi.Ods.Entities.NHibernate.StudentCTEProgramAssociationAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentCTEProgramAssociationExtension table of the StudentCTEProgramAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentCTEProgramAssociationExtension : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentCTEProgramAssociationExtension, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentCTEProgramAssociationExtension()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentCTEProgramAssociation StudentCTEProgramAssociation { get; set; }

        Entities.Common.EdFi.IStudentCTEProgramAssociation IStudentCTEProgramAssociationExtension.StudentCTEProgramAssociation
        {
            get { return StudentCTEProgramAssociation; }
            set { StudentCTEProgramAssociation = (EdFi.StudentCTEProgramAssociation) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual bool? AnalysisCompleted  { get; set; }

        [Key(2)]
        public virtual DateTime? AnalysisDate 
        {
            get { return _analysisDate; }
            set
            {
                // This is only stored as a UTC DateTime in the DB and NHibernate will retrieve it back as the (UTC) DateTime.Kind.
                // Note ToUniversal will work differently based on DateTime.Kind
                // See https://docs.microsoft.com/en-us/dotnet/api/system.datetime.touniversaltime?view=netframework-4.5#System_DateTime_ToUniversalTime
                // Utc - No conversion is performed.
                // Local - The current DateTime object is converted to UTC.
                // Unspecified - The current DateTime object is assumed to be a local time, and the conversion is performed as if Kind were Local.
                if (value.HasValue && value.Value != (DateTime)typeof(DateTime).GetDefaultValue())
                    _analysisDate = value?.ToUniversalTime();
            }
        }

        private DateTime? _analysisDate;

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentCTEProgramAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentCTEProgramAssociationExtension)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentCTEProgramAssociationExtension) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentCTEProgramAssociation = (EdFi.StudentCTEProgramAssociation) value;
        }
    }
}
// Aggregate: StudentEducationOrganizationAssociation

namespace EdFi.Ods.Entities.NHibernate.StudentEducationOrganizationAssociationAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentEducationOrganizationAssociationAddressSchoolDistrict table of the StudentEducationOrganizationAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentEducationOrganizationAssociationAddressSchoolDistrict : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressSchoolDistrict, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentEducationOrganizationAssociationAddressSchoolDistrict()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentEducationOrganizationAssociationAddress StudentEducationOrganizationAssociationAddress { get; set; }

        Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressExtension IStudentEducationOrganizationAssociationAddressSchoolDistrict.StudentEducationOrganizationAssociationAddressExtension
        {
            get { return (IStudentEducationOrganizationAssociationAddressExtension) StudentEducationOrganizationAssociationAddress.Extensions["Sample"]; }
            set { StudentEducationOrganizationAssociationAddress.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string SchoolDistrict  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "AddressTypeDescriptor", new LookupColumnDetails { PropertyName = "AddressTypeDescriptorId", LookupTypeName = "AddressTypeDescriptor"} },
                { "StateAbbreviationDescriptor", new LookupColumnDetails { PropertyName = "StateAbbreviationDescriptorId", LookupTypeName = "StateAbbreviationDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentEducationOrganizationAssociationAddress as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("SchoolDistrict", SchoolDistrict);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressSchoolDistrict)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressSchoolDistrict) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentEducationOrganizationAssociationAddress = (EdFi.StudentEducationOrganizationAssociationAddress) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentEducationOrganizationAssociationAddressTerm table of the StudentEducationOrganizationAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentEducationOrganizationAssociationAddressTerm : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressTerm, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentEducationOrganizationAssociationAddressTerm()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentEducationOrganizationAssociationAddress StudentEducationOrganizationAssociationAddress { get; set; }

        Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressExtension IStudentEducationOrganizationAssociationAddressTerm.StudentEducationOrganizationAssociationAddressExtension
        {
            get { return (IStudentEducationOrganizationAssociationAddressExtension) StudentEducationOrganizationAssociationAddress.Extensions["Sample"]; }
            set { StudentEducationOrganizationAssociationAddress.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int TermDescriptorId 
        {
            get
            {
                if (_termDescriptorId == default(int))
                {
                    _termDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("TermDescriptor", _termDescriptor);
                }

                return _termDescriptorId;
            } 
            set
            {
                _termDescriptorId = value;
                _termDescriptor = null;
            }
        }

        private int _termDescriptorId;
        private string _termDescriptor;

        [IgnoreMember]
        public virtual string TermDescriptor
        {
            get
            {
                if (_termDescriptor == null)
                    _termDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("TermDescriptor", _termDescriptorId);
                    
                return _termDescriptor;
            }
            set
            {
                _termDescriptor = value;
                _termDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "AddressTypeDescriptor", new LookupColumnDetails { PropertyName = "AddressTypeDescriptorId", LookupTypeName = "AddressTypeDescriptor"} },
                { "StateAbbreviationDescriptor", new LookupColumnDetails { PropertyName = "StateAbbreviationDescriptorId", LookupTypeName = "StateAbbreviationDescriptor"} },
                { "TermDescriptor", new LookupColumnDetails { PropertyName = "TermDescriptorId", LookupTypeName = "TermDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentEducationOrganizationAssociationAddress as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("TermDescriptorId", TermDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressTerm)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressTerm) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentEducationOrganizationAssociationAddress = (EdFi.StudentEducationOrganizationAssociationAddress) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentEducationOrganizationAssociationStudentCharacteristicStudentNeed table of the StudentEducationOrganizationAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentEducationOrganizationAssociationStudentCharacteristicStudentNeed : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentEducationOrganizationAssociationStudentCharacteristicStudentNeed()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentEducationOrganizationAssociationStudentCharacteristic StudentEducationOrganizationAssociationStudentCharacteristic { get; set; }

        Entities.Common.Sample.IStudentEducationOrganizationAssociationStudentCharacteristicExtension IStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed.StudentEducationOrganizationAssociationStudentCharacteristicExtension
        {
            get { return (IStudentEducationOrganizationAssociationStudentCharacteristicExtension) StudentEducationOrganizationAssociationStudentCharacteristic.Extensions["Sample"]; }
            set { StudentEducationOrganizationAssociationStudentCharacteristic.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual DateTime BeginDate 
        {
            get { return _beginDate; }
            //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
            set { _beginDate = new DateTime(value.Year, value.Month, value.Day); }
        }

        private DateTime _beginDate;

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(2)]
        public virtual DateTime? EndDate 
        {
            get { return _endDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _endDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _endDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _endDate;

        [Key(3)]
        public virtual bool? PrimaryStudentNeedIndicator  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "StudentCharacteristicDescriptor", new LookupColumnDetails { PropertyName = "StudentCharacteristicDescriptorId", LookupTypeName = "StudentCharacteristicDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentEducationOrganizationAssociationStudentCharacteristic as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("BeginDate", BeginDate);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentEducationOrganizationAssociationStudentCharacteristic = (EdFi.StudentEducationOrganizationAssociationStudentCharacteristic) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentEducationOrganizationAssociationExtension table of the StudentEducationOrganizationAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentEducationOrganizationAssociationExtension : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentEducationOrganizationAssociationExtension, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentEducationOrganizationAssociationExtension()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.ProgramAggregate.EdFi.ProgramReferenceData _favoriteProgramReferenceData;

        private bool FavoriteProgramReferenceDataIsProxied()
        {
            return _favoriteProgramReferenceData != null 
                && _favoriteProgramReferenceData.GetType() != typeof(NHibernate.ProgramAggregate.EdFi.ProgramReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.ProgramAggregate.EdFi.ProgramReferenceData FavoriteProgramReferenceData
        {
            get => _favoriteProgramReferenceData;
            set
            {
                _favoriteProgramReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !FavoriteProgramReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(1)]
        public virtual NHibernate.ProgramAggregate.EdFi.ProgramReferenceData FavoriteProgramSerializedReferenceData { get => _favoriteProgramSerializedReferenceData; set { if (value != null) _favoriteProgramSerializedReferenceData = value; } }
        private NHibernate.ProgramAggregate.EdFi.ProgramReferenceData _favoriteProgramSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the FavoriteProgram discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IStudentEducationOrganizationAssociationExtension.FavoriteProgramDiscriminator
        {
            get
            {
                return FavoriteProgramReferenceDataIsProxied()
                    ? (FavoriteProgramSerializedReferenceData ?? FavoriteProgramReferenceData)?.Discriminator
                    : (FavoriteProgramReferenceData ?? FavoriteProgramSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the FavoriteProgram resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IStudentEducationOrganizationAssociationExtension.FavoriteProgramResourceId
        {
            get
            {
                return FavoriteProgramReferenceDataIsProxied()
                    ? (FavoriteProgramSerializedReferenceData ?? FavoriteProgramReferenceData)?.Id
                    : (FavoriteProgramReferenceData ?? FavoriteProgramSerializedReferenceData)?.Id;
            }
            set { if (FavoriteProgramSerializedReferenceData?.IsFullyDefined() == true) FavoriteProgramSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentEducationOrganizationAssociation StudentEducationOrganizationAssociation { get; set; }

        Entities.Common.EdFi.IStudentEducationOrganizationAssociation IStudentEducationOrganizationAssociationExtension.StudentEducationOrganizationAssociation
        {
            get { return StudentEducationOrganizationAssociation; }
            set { StudentEducationOrganizationAssociation = (EdFi.StudentEducationOrganizationAssociation) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(2)]
        public virtual string FavoriteProgramName 
        {
            get => _favoriteProgramName;
            set
            {
                _favoriteProgramName = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    FavoriteProgramSerializedReferenceData ??= new NHibernate.ProgramAggregate.EdFi.ProgramReferenceData(true);
                    FavoriteProgramSerializedReferenceData.ProgramName = value ?? default;
                }
            }
        }

        private string _favoriteProgramName;

        [Key(3)]
        public virtual int? FavoriteProgramTypeDescriptorId 
        {
            get
            {
                if (_favoriteProgramTypeDescriptorId == default(int?))
                {
                    _favoriteProgramTypeDescriptorId = string.IsNullOrWhiteSpace(_favoriteProgramTypeDescriptor) ? default(int?) : GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ProgramTypeDescriptor", _favoriteProgramTypeDescriptor);
                
                    if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                    {
                        FavoriteProgramSerializedReferenceData ??= new NHibernate.ProgramAggregate.EdFi.ProgramReferenceData(true);
                        FavoriteProgramSerializedReferenceData.ProgramTypeDescriptorId = _favoriteProgramTypeDescriptorId ?? default;
                    }
                }

                return _favoriteProgramTypeDescriptorId;
            } 
            set
            {
                _favoriteProgramTypeDescriptorId = value;
                _favoriteProgramTypeDescriptor = null;
        
                if (value != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    FavoriteProgramSerializedReferenceData ??= new NHibernate.ProgramAggregate.EdFi.ProgramReferenceData(true);
                    FavoriteProgramSerializedReferenceData.ProgramTypeDescriptorId = value ?? default;
                }
            }
        }

        private int? _favoriteProgramTypeDescriptorId;
        private string _favoriteProgramTypeDescriptor;

        [IgnoreMember]
        public virtual string FavoriteProgramTypeDescriptor
        {
            get
            {
                if (_favoriteProgramTypeDescriptor == null)
                    _favoriteProgramTypeDescriptor = _favoriteProgramTypeDescriptorId == null ? null : GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("ProgramTypeDescriptor", _favoriteProgramTypeDescriptorId.Value);
                    
                return _favoriteProgramTypeDescriptor;
            }
            set
            {
                _favoriteProgramTypeDescriptor = value;
                _favoriteProgramTypeDescriptorId = default(int?);

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    FavoriteProgramSerializedReferenceData ??= new NHibernate.ProgramAggregate.EdFi.ProgramReferenceData(true);
                    FavoriteProgramSerializedReferenceData.ProgramTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ProgramTypeDescriptor", _favoriteProgramTypeDescriptor);
                }
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "FavoriteProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "FavoriteProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentEducationOrganizationAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationExtension)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationExtension) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentEducationOrganizationAssociation = (EdFi.StudentEducationOrganizationAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentEducationOrganizationAssociationAddressExtension table of the StudentEducationOrganizationAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentEducationOrganizationAssociationAddressExtension : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressExtension, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentEducationOrganizationAssociationAddressExtension()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentEducationOrganizationAssociationAddress StudentEducationOrganizationAssociationAddress { get; set; }

        Entities.Common.EdFi.IStudentEducationOrganizationAssociationAddress IStudentEducationOrganizationAssociationAddressExtension.StudentEducationOrganizationAssociationAddress
        {
            get { return StudentEducationOrganizationAssociationAddress; }
            set { StudentEducationOrganizationAssociationAddress = (EdFi.StudentEducationOrganizationAssociationAddress) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual string Complex  { get; set; }

        [Key(2)]
        public virtual bool OnBusRoute  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        private ICollection<Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressSchoolDistrict> _studentEducationOrganizationAssociationAddressSchoolDistricts;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressSchoolDistrict> IStudentEducationOrganizationAssociationAddressExtension.StudentEducationOrganizationAssociationAddressSchoolDistricts
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentEducationOrganizationAssociationAddressSchoolDistrict>((IList<object>) StudentEducationOrganizationAssociationAddress.AggregateExtensions["Sample_StudentEducationOrganizationAssociationAddressSchoolDistricts"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentEducationOrganizationAssociationAddressSchoolDistrict item in sourceList)
                    if (item.StudentEducationOrganizationAssociationAddress == null)
                        item.StudentEducationOrganizationAssociationAddress = this.StudentEducationOrganizationAssociationAddress;
                // -------------------------------------------------------------

                if (_studentEducationOrganizationAssociationAddressSchoolDistricts == null)
                    _studentEducationOrganizationAssociationAddressSchoolDistricts = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressSchoolDistrict, StudentEducationOrganizationAssociationAddressSchoolDistrict>(sourceList);

                return _studentEducationOrganizationAssociationAddressSchoolDistricts;
            }
            set
            {
                StudentEducationOrganizationAssociationAddress.AggregateExtensions["Sample_StudentEducationOrganizationAssociationAddressSchoolDistricts"] = value;
            }
        }
        private ICollection<Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressTerm> _studentEducationOrganizationAssociationAddressTerms;
        // Aggregate extension explicit implementation to redirect model abstraction to the persistent entity location
        ICollection<Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressTerm> IStudentEducationOrganizationAssociationAddressExtension.StudentEducationOrganizationAssociationAddressTerms
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentEducationOrganizationAssociationAddressTerm>((IList<object>) StudentEducationOrganizationAssociationAddress.AggregateExtensions["Sample_StudentEducationOrganizationAssociationAddressTerms"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentEducationOrganizationAssociationAddressTerm item in sourceList)
                    if (item.StudentEducationOrganizationAssociationAddress == null)
                        item.StudentEducationOrganizationAssociationAddress = this.StudentEducationOrganizationAssociationAddress;
                // -------------------------------------------------------------

                if (_studentEducationOrganizationAssociationAddressTerms == null)
                    _studentEducationOrganizationAssociationAddressTerms = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressTerm, StudentEducationOrganizationAssociationAddressTerm>(sourceList);

                return _studentEducationOrganizationAssociationAddressTerms;
            }
            set
            {
                StudentEducationOrganizationAssociationAddress.AggregateExtensions["Sample_StudentEducationOrganizationAssociationAddressTerms"] = value;
            }
        }
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentEducationOrganizationAssociationAddress as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressExtension)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentEducationOrganizationAssociationAddressExtension) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentEducationOrganizationAssociationAddress = (EdFi.StudentEducationOrganizationAssociationAddress) value;
        }
    }

    /// <summary>
    /// An implicitly created entity extension class to enable entity mapping and sychronization behavior for the StudentEducationOrganizationAssociationStudentCharacteristic entity's aggregate extensions.
    /// </summary>
    [ExcludeFromCodeCoverage][MessagePackObject]
    public class StudentEducationOrganizationAssociationStudentCharacteristicExtension : IStudentEducationOrganizationAssociationStudentCharacteristicExtension, IChildEntity, IImplicitEntityExtension, IHasPrimaryKeyValues
    {
        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        private EdFi.StudentEducationOrganizationAssociationStudentCharacteristic _studentEducationOrganizationAssociationStudentCharacteristic;

        Common.EdFi.IStudentEducationOrganizationAssociationStudentCharacteristic IStudentEducationOrganizationAssociationStudentCharacteristicExtension.StudentEducationOrganizationAssociationStudentCharacteristic
        {
            get { return _studentEducationOrganizationAssociationStudentCharacteristic; }
            set { _studentEducationOrganizationAssociationStudentCharacteristic = (EdFi.StudentEducationOrganizationAssociationStudentCharacteristic) value; }
        }

        private EdFi.StudentEducationOrganizationAssociationStudentCharacteristic StudentEducationOrganizationAssociationStudentCharacteristic
        {
            get { return (this as IStudentEducationOrganizationAssociationStudentCharacteristicExtension).StudentEducationOrganizationAssociationStudentCharacteristic as EdFi.StudentEducationOrganizationAssociationStudentCharacteristic; }
        }

        bool IImplicitEntityExtension.IsEmpty()
        {
            return (true
                && ((IList<object>) _studentEducationOrganizationAssociationStudentCharacteristic.AggregateExtensions["Sample_StudentEducationOrganizationAssociationStudentCharacteristicStudentNeeds"]).Count == 0
            );
        }

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Collections
        // -------------------------------------------------------------
        ICollection<IStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed> IStudentEducationOrganizationAssociationStudentCharacteristicExtension.StudentEducationOrganizationAssociationStudentCharacteristicStudentNeeds
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentEducationOrganizationAssociationStudentCharacteristicStudentNeed>((IList<object>) _studentEducationOrganizationAssociationStudentCharacteristic.AggregateExtensions["Sample_StudentEducationOrganizationAssociationStudentCharacteristicStudentNeeds"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentEducationOrganizationAssociationStudentCharacteristicStudentNeed item in sourceList)
                    if (item.StudentEducationOrganizationAssociationStudentCharacteristic == null)
                        item.StudentEducationOrganizationAssociationStudentCharacteristic = this.StudentEducationOrganizationAssociationStudentCharacteristic;
                // -------------------------------------------------------------

                var adaptedList = new CovariantCollectionAdapter<IStudentEducationOrganizationAssociationStudentCharacteristicStudentNeed, StudentEducationOrganizationAssociationStudentCharacteristicStudentNeed>(sourceList);

                return adaptedList;
            }
            set
            {
                _studentEducationOrganizationAssociationStudentCharacteristic.AggregateExtensions["Sample_StudentEducationOrganizationAssociationStudentCharacteristicStudentNeeds"] = value;
            }
        }
        // -------------------------------------------------------------

        void IMappable.Map(object target)
        {
            this.MapTo((IStudentEducationOrganizationAssociationStudentCharacteristicExtension) target, null);
        }

        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((IStudentEducationOrganizationAssociationStudentCharacteristicExtension) target);
        }

        void IChildEntity.SetParent(object value)
        {
            _studentEducationOrganizationAssociationStudentCharacteristic = (EdFi.StudentEducationOrganizationAssociationStudentCharacteristic)value;
        }

        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            return (_studentEducationOrganizationAssociationStudentCharacteristic as IHasPrimaryKeyValues).GetPrimaryKeyValues();
        }

        void IGetByExample.SuspendReferenceAssignmentCheck() { }
    }
}
// Aggregate: StudentGraduationPlanAssociation

namespace EdFi.Ods.Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample
{
    /// <summary>
    /// Represents a read-only reference to the <see cref="StudentGraduationPlanAssociation"/> entity.
    /// </summary>
    [MessagePackObject]
    public class StudentGraduationPlanAssociationReferenceData : IEntityReferenceData
    {
        private bool _trackLookupContext;
    
        // Default constructor (used by NHibernate)
        public StudentGraduationPlanAssociationReferenceData() { }

        // Constructor (used for link support with Serialized Data feature)
        public StudentGraduationPlanAssociationReferenceData(bool trackLookupContext) { _trackLookupContext = trackLookupContext; }

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        private Guid? _id;

        /// <summary>
        /// The id of the referenced entity (used as the resource identifier in the API).
        /// </summary>
        [Key(0)]
        public virtual Guid? Id
        {
            get => _id;
            set
            {
                _id = value;

                if (_trackLookupContext || (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled))
                {
                    // If explicitly setting this to a non-value, it needs to be resolved.
                    if (value == default(Guid) || value == null)
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }

        private long _educationOrganizationId;

        [Key(1)]
        public virtual long EducationOrganizationId
        {
            get => _educationOrganizationId;
            set
            {
                var originalValue = _educationOrganizationId;
                _educationOrganizationId = value;

                if (_trackLookupContext)
                {
                    // If Id is NOT already known then value is being initialized (from mapping or syncing -- not deserialized) and needs resolution 
                    if (_id == default && originalValue == default && value != default && IsFullyDefined())
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                    // If key value is changing (i.e. only via Synchronize)
                    else if (originalValue != default && value != originalValue) 
                    {
                        // Clear the values
                        Id = default;
                        Discriminator = null;
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }
        private int _graduationPlanTypeDescriptorId;

        [Key(2)]
        public virtual int GraduationPlanTypeDescriptorId
        {
            get => _graduationPlanTypeDescriptorId;
            set
            {
                var originalValue = _graduationPlanTypeDescriptorId;
                _graduationPlanTypeDescriptorId = value;

                if (_trackLookupContext)
                {
                    // If Id is NOT already known then value is being initialized (from mapping or syncing -- not deserialized) and needs resolution 
                    if (_id == default && originalValue == default && value != default && IsFullyDefined())
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                    // If key value is changing (i.e. only via Synchronize)
                    else if (originalValue != default && value != originalValue) 
                    {
                        // Clear the values
                        Id = default;
                        Discriminator = null;
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }
        private short _graduationSchoolYear;

        [Key(3)]
        public virtual short GraduationSchoolYear
        {
            get => _graduationSchoolYear;
            set
            {
                var originalValue = _graduationSchoolYear;
                _graduationSchoolYear = value;

                if (_trackLookupContext)
                {
                    // If Id is NOT already known then value is being initialized (from mapping or syncing -- not deserialized) and needs resolution 
                    if (_id == default && originalValue == default && value != default && IsFullyDefined())
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                    // If key value is changing (i.e. only via Synchronize)
                    else if (originalValue != default && value != originalValue) 
                    {
                        // Clear the values
                        Id = default;
                        Discriminator = null;
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }
        private int _studentUSI;

        [Key(4)]
        public virtual int StudentUSI
        {
            get => _studentUSI;
            set
            {
                var originalValue = _studentUSI;
                _studentUSI = value;

                if (_trackLookupContext)
                {
                    // If Id is NOT already known then value is being initialized (from mapping or syncing -- not deserialized) and needs resolution 
                    if (_id == default && originalValue == default && value != default && IsFullyDefined())
                    {
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                    // If key value is changing (i.e. only via Synchronize)
                    else if (originalValue != default && value != originalValue) 
                    {
                        // Clear the values
                        Id = default;
                        Discriminator = null;
                        GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Add(this);
                    }
                }
            }
        }

        public virtual bool IsFullyDefined()
        {
            return
                _educationOrganizationId != default
                            && _graduationPlanTypeDescriptorId != default
                            && _graduationSchoolYear != default
                            && _studentUSI != default
            ;
        }

        /// <summary>
        /// Gets and sets the discriminator value which identifies the concrete sub-type of the referenced entity
        /// when that entity has been derived; otherwise <b>null</b>.
        /// </summary>
        [Key(5)]
        public virtual string Discriminator { get; set; }

        private static FullName _fullName = new FullName("sample", "StudentGraduationPlanAssociation"); 
        FullName IEntityReferenceData.FullName { get => _fullName; }
    
        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("EducationOrganizationId", EducationOrganizationId);
            keyValues.Add("GraduationPlanTypeDescriptorId", GraduationPlanTypeDescriptorId);
            keyValues.Add("GraduationSchoolYear", GraduationSchoolYear);
            keyValues.Add("StudentUSI", StudentUSI);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (!entry.Value.Equals(thoseKeys[entry.Key]))
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                hashCode.Add(entry.Value);
            }

            return hashCode.ToHashCode();
        }
        #endregion
    }

// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentGraduationPlanAssociation table of the StudentGraduationPlanAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentGraduationPlanAssociation : AggregateRootWithCompositeKey,
        Entities.Common.Sample.IStudentGraduationPlanAssociation, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentGraduationPlanAssociation()
        {
           StudentGraduationPlanAssociationCTEProgramServicePersistentList = new HashSet<StudentGraduationPlanAssociationCTEProgramService>();
            StudentGraduationPlanAssociationAcademicSubjects = new HashSet<StudentGraduationPlanAssociationAcademicSubject>();
            StudentGraduationPlanAssociationCareerPathwayCodes = new HashSet<StudentGraduationPlanAssociationCareerPathwayCode>();
            StudentGraduationPlanAssociationDescriptions = new HashSet<StudentGraduationPlanAssociationDescription>();
            StudentGraduationPlanAssociationDesignatedBies = new HashSet<StudentGraduationPlanAssociationDesignatedBy>();
            StudentGraduationPlanAssociationIndustryCredentials = new HashSet<StudentGraduationPlanAssociationIndustryCredential>();
            StudentGraduationPlanAssociationStudentContactAssociations = new HashSet<StudentGraduationPlanAssociationStudentContactAssociation>();
            StudentGraduationPlanAssociationYearsAttendeds = new HashSet<StudentGraduationPlanAssociationYearsAttended>();
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData _graduationPlanReferenceData;

        private bool GraduationPlanReferenceDataIsProxied()
        {
            return _graduationPlanReferenceData != null 
                && _graduationPlanReferenceData.GetType() != typeof(NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData GraduationPlanReferenceData
        {
            get => _graduationPlanReferenceData;
            set
            {
                _graduationPlanReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !GraduationPlanReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(6)]
        public virtual NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData GraduationPlanSerializedReferenceData { get => _graduationPlanSerializedReferenceData; set { if (value != null) _graduationPlanSerializedReferenceData = value; } }
        private NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData _graduationPlanSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the GraduationPlan discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IStudentGraduationPlanAssociation.GraduationPlanDiscriminator
        {
            get
            {
                return GraduationPlanReferenceDataIsProxied()
                    ? (GraduationPlanSerializedReferenceData ?? GraduationPlanReferenceData)?.Discriminator
                    : (GraduationPlanReferenceData ?? GraduationPlanSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the GraduationPlan resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IStudentGraduationPlanAssociation.GraduationPlanResourceId
        {
            get
            {
                return GraduationPlanReferenceDataIsProxied()
                    ? (GraduationPlanSerializedReferenceData ?? GraduationPlanReferenceData)?.Id
                    : (GraduationPlanReferenceData ?? GraduationPlanSerializedReferenceData)?.Id;
            }
            set { if (GraduationPlanSerializedReferenceData?.IsFullyDefined() == true) GraduationPlanSerializedReferenceData.Id = value; }
        }

        private NHibernate.StaffAggregate.EdFi.StaffReferenceData _staffReferenceData;

        private bool StaffReferenceDataIsProxied()
        {
            return _staffReferenceData != null 
                && _staffReferenceData.GetType() != typeof(NHibernate.StaffAggregate.EdFi.StaffReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.StaffAggregate.EdFi.StaffReferenceData StaffReferenceData
        {
            get => _staffReferenceData;
            set
            {
                _staffReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !StaffReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(7)]
        public virtual NHibernate.StaffAggregate.EdFi.StaffReferenceData StaffSerializedReferenceData { get => _staffSerializedReferenceData; set { if (value != null) _staffSerializedReferenceData = value; } }
        private NHibernate.StaffAggregate.EdFi.StaffReferenceData _staffSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the Staff discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IStudentGraduationPlanAssociation.StaffDiscriminator
        {
            get
            {
                return StaffReferenceDataIsProxied()
                    ? (StaffSerializedReferenceData ?? StaffReferenceData)?.Discriminator
                    : (StaffReferenceData ?? StaffSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the Staff resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IStudentGraduationPlanAssociation.StaffResourceId
        {
            get
            {
                return StaffReferenceDataIsProxied()
                    ? (StaffSerializedReferenceData ?? StaffReferenceData)?.Id
                    : (StaffReferenceData ?? StaffSerializedReferenceData)?.Id;
            }
            set { if (StaffSerializedReferenceData?.IsFullyDefined() == true) StaffSerializedReferenceData.Id = value; }
        }

        private NHibernate.StudentAggregate.EdFi.StudentReferenceData _studentReferenceData;

        private bool StudentReferenceDataIsProxied()
        {
            return _studentReferenceData != null 
                && _studentReferenceData.GetType() != typeof(NHibernate.StudentAggregate.EdFi.StudentReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.StudentAggregate.EdFi.StudentReferenceData StudentReferenceData
        {
            get => _studentReferenceData;
            set
            {
                _studentReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !StudentReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(8)]
        public virtual NHibernate.StudentAggregate.EdFi.StudentReferenceData StudentSerializedReferenceData { get => _studentSerializedReferenceData; set { if (value != null) _studentSerializedReferenceData = value; } }
        private NHibernate.StudentAggregate.EdFi.StudentReferenceData _studentSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the Student discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentDiscriminator
        {
            get
            {
                return StudentReferenceDataIsProxied()
                    ? (StudentSerializedReferenceData ?? StudentReferenceData)?.Discriminator
                    : (StudentReferenceData ?? StudentSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the Student resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentResourceId
        {
            get
            {
                return StudentReferenceDataIsProxied()
                    ? (StudentSerializedReferenceData ?? StudentReferenceData)?.Id
                    : (StudentReferenceData ?? StudentSerializedReferenceData)?.Id;
            }
            set { if (StudentSerializedReferenceData?.IsFullyDefined() == true) StudentSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature]
        [Key(9)]
        public virtual long EducationOrganizationId 
        {
            get => _educationOrganizationId;
            set
            {
                _educationOrganizationId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    GraduationPlanSerializedReferenceData ??= new NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData(true);
                    GraduationPlanSerializedReferenceData.EducationOrganizationId = value;
                }
            }
        }

        private long _educationOrganizationId;

        [DomainSignature]
        [Key(10)]
        public virtual int GraduationPlanTypeDescriptorId 
        {
            get
            {
                if (_graduationPlanTypeDescriptorId == default(int))
                {
                    _graduationPlanTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("GraduationPlanTypeDescriptor", _graduationPlanTypeDescriptor);
                
                    if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                    {
                        GraduationPlanSerializedReferenceData ??= new NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData(true);
                        GraduationPlanSerializedReferenceData.GraduationPlanTypeDescriptorId = _graduationPlanTypeDescriptorId;
                    }
                }

                return _graduationPlanTypeDescriptorId;
            } 
            set
            {
                _graduationPlanTypeDescriptorId = value;
                _graduationPlanTypeDescriptor = null;
        
                if (value != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    GraduationPlanSerializedReferenceData ??= new NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData(true);
                    GraduationPlanSerializedReferenceData.GraduationPlanTypeDescriptorId = value;
                }
            }
        }

        private int _graduationPlanTypeDescriptorId;
        private string _graduationPlanTypeDescriptor;

        [IgnoreMember]
        public virtual string GraduationPlanTypeDescriptor
        {
            get
            {
                if (_graduationPlanTypeDescriptor == null)
                    _graduationPlanTypeDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("GraduationPlanTypeDescriptor", _graduationPlanTypeDescriptorId);
                    
                return _graduationPlanTypeDescriptor;
            }
            set
            {
                _graduationPlanTypeDescriptor = value;
                _graduationPlanTypeDescriptorId = default(int);

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    GraduationPlanSerializedReferenceData ??= new NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData(true);
                    GraduationPlanSerializedReferenceData.GraduationPlanTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("GraduationPlanTypeDescriptor", _graduationPlanTypeDescriptor);
                }
            }
        }

        [DomainSignature]
        [Key(11)]
        public virtual short GraduationSchoolYear 
        {
            get => _graduationSchoolYear;
            set
            {
                _graduationSchoolYear = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    GraduationPlanSerializedReferenceData ??= new NHibernate.GraduationPlanAggregate.EdFi.GraduationPlanReferenceData(true);
                    GraduationPlanSerializedReferenceData.GraduationSchoolYear = value;
                }
            }
        }

        private short _graduationSchoolYear;

        [Display(Name="StudentUniqueId")][DomainSignature]
        [Key(12)]
        public virtual int StudentUSI 
        {
            get
            {
                if (_studentUSI == default(int) && _studentUniqueId != null)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Student", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_studentUniqueId, out var usi))
                    {
                        _studentUSI = usi;

                        if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                        {
                            StudentSerializedReferenceData ??= new NHibernate.StudentAggregate.EdFi.StudentReferenceData(true);
                            StudentSerializedReferenceData.StudentUSI = _studentUSI;
                        }
                    }
                }

                return _studentUSI;
            } 
            set
            {
                _studentUSI = value;
                GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().AddLookup("Student", value);

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StudentSerializedReferenceData ??= new NHibernate.StudentAggregate.EdFi.StudentReferenceData(true);
                    StudentSerializedReferenceData.StudentUSI = value;
                }
            }
        }

        private int _studentUSI;
        private string _studentUniqueId;

        [IgnoreMember]
        public virtual string StudentUniqueId
        {
            get
            {
                if (_studentUniqueId == null)
                {
                    if (GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().UniqueIdByUsiByPersonType.TryGetValue("Student", out var uniqueIdByUsi)
                        && uniqueIdByUsi.TryGetValue(_studentUSI, out var uniqueId))
                    {
                        _studentUniqueId = uniqueId;
                    }
                }

                return _studentUniqueId;
            }
            set
            {
                if (_studentUniqueId != value)
                        _studentUSI = default(int);

                _studentUniqueId = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Student", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_studentUniqueId, out var usi))
                    {
                        StudentSerializedReferenceData ??= new NHibernate.StudentAggregate.EdFi.StudentReferenceData(true);
                        StudentSerializedReferenceData.StudentUSI = usi;
                    }
                }
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(13)]
        public virtual TimeSpan? CommencementTime  { get; set; }

        [Key(14)]
        public virtual DateTime EffectiveDate 
        {
            get { return _effectiveDate; }
            //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
            set { _effectiveDate = new DateTime(value.Year, value.Month, value.Day); }
        }

        private DateTime _effectiveDate;

        [Key(15)]
        public virtual decimal? GraduationFee  { get; set; }

        [Key(16)]
        public virtual string HighSchoolDuration  { get; set; }

        [Key(17)]
        public virtual decimal HoursPerWeek  { get; set; }

        [Key(18)]
        public virtual bool? IsActivePlan  { get; set; }

        [Key(19)]
        public virtual decimal? RequiredAttendance  { get; set; }

        [Key(20)]
        public virtual int? StaffUSI 
        {
            get
            {
                if (_staffUSI == default(int?) && _staffUniqueId != null)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Staff", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_staffUniqueId, out var usi))
                    {
                        _staffUSI = usi;

                        if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                        {
                            StaffSerializedReferenceData ??= new NHibernate.StaffAggregate.EdFi.StaffReferenceData(true);
                            StaffSerializedReferenceData.StaffUSI = _staffUSI ?? default;
                        }
                    }
                }

                return _staffUSI;
            } 
            set
            {
                _staffUSI = value;

                if (value != null)
                {
                    GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().AddLookup("Staff", value.Value);
                }

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StaffSerializedReferenceData ??= new NHibernate.StaffAggregate.EdFi.StaffReferenceData(true);
                    StaffSerializedReferenceData.StaffUSI = value ?? default;
                }
            }
        }

        private int? _staffUSI;
        private string _staffUniqueId;

        [IgnoreMember]
        public virtual string StaffUniqueId
        {
            get
            {
                if (_staffUniqueId == null && _staffUSI.HasValue)
                {
                    if (GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().UniqueIdByUsiByPersonType.TryGetValue("Staff", out var uniqueIdByUsi)
                        && uniqueIdByUsi.TryGetValue(_staffUSI.Value, out var uniqueId))
                    {
                        _staffUniqueId = uniqueId;
                    }
                }

                return _staffUniqueId;
            }
            set
            {
                if (_staffUniqueId != value)
                        _staffUSI = default(int?);

                _staffUniqueId = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Staff", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_staffUniqueId, out var usi))
                    {
                        StaffSerializedReferenceData ??= new NHibernate.StaffAggregate.EdFi.StaffReferenceData(true);
                        StaffSerializedReferenceData.StaffUSI = usi;
                    }
                }
            }
        }

        [Key(21)]
        public virtual decimal TargetGPA  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        [IgnoreMember]
        public virtual Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCTEProgramService StudentGraduationPlanAssociationCTEProgramService
        {
            get
            {
                // Return the item in the list, if one exists
                if (StudentGraduationPlanAssociationCTEProgramServicePersistentList.Any())
                    return StudentGraduationPlanAssociationCTEProgramServicePersistentList.First();

                // No reference is present
                return null;
            }
            set
            {
                // Delete the existing object
                if (StudentGraduationPlanAssociationCTEProgramServicePersistentList.Any())
                    StudentGraduationPlanAssociationCTEProgramServicePersistentList.Clear();

                // If we're setting a value, add it to the list now
                if (value != null)
                {
                    // Set the back-reference to the parent
                    value.StudentGraduationPlanAssociation = this;

                    StudentGraduationPlanAssociationCTEProgramServicePersistentList.Add(value);
                }
            }
        }

        Entities.Common.Sample.IStudentGraduationPlanAssociationCTEProgramService Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentGraduationPlanAssociationCTEProgramService
        {
            get { return StudentGraduationPlanAssociationCTEProgramService; }
            set { StudentGraduationPlanAssociationCTEProgramService = (Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCTEProgramService) value; }
        }

        private ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCTEProgramService> _studentGraduationPlanAssociationCTEProgramServicePersistentList;

        [Key(22)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCTEProgramService>))]
        public virtual ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCTEProgramService> StudentGraduationPlanAssociationCTEProgramServicePersistentList
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentGraduationPlanAssociationCTEProgramServicePersistentList is DeserializedPersistentGenericSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCTEProgramService> set)
                {
                    set.Reattach(this, "StudentGraduationPlanAssociationCTEProgramService");
                }

                foreach (var item in _studentGraduationPlanAssociationCTEProgramServicePersistentList)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationCTEProgramServicePersistentList;
            }
            set
            {
                _studentGraduationPlanAssociationCTEProgramServicePersistentList = value;
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------

        private ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationAcademicSubject> _studentGraduationPlanAssociationAcademicSubjects;
        private ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationAcademicSubject> _studentGraduationPlanAssociationAcademicSubjectsCovariant;
        [Key(23)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationAcademicSubject>))]
        public virtual ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationAcademicSubject> StudentGraduationPlanAssociationAcademicSubjects
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentGraduationPlanAssociationAcademicSubjects is DeserializedPersistentGenericSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationAcademicSubject> set)
                {
                    set.Reattach(this, "StudentGraduationPlanAssociationAcademicSubjects");
                }
            
                foreach (var item in _studentGraduationPlanAssociationAcademicSubjects)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationAcademicSubjects;
            }
            set
            {
                _studentGraduationPlanAssociationAcademicSubjects = value;
                _studentGraduationPlanAssociationAcademicSubjectsCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentGraduationPlanAssociationAcademicSubject, Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationAcademicSubject>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationAcademicSubject> Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentGraduationPlanAssociationAcademicSubjects
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentGraduationPlanAssociationAcademicSubjects)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationAcademicSubjectsCovariant;
            }
            set
            {
                StudentGraduationPlanAssociationAcademicSubjects = new HashSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationAcademicSubject>(value.Cast<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationAcademicSubject>());
            }
        }


        private ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCareerPathwayCode> _studentGraduationPlanAssociationCareerPathwayCodes;
        private ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationCareerPathwayCode> _studentGraduationPlanAssociationCareerPathwayCodesCovariant;
        [Key(24)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCareerPathwayCode>))]
        public virtual ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCareerPathwayCode> StudentGraduationPlanAssociationCareerPathwayCodes
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentGraduationPlanAssociationCareerPathwayCodes is DeserializedPersistentGenericSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCareerPathwayCode> set)
                {
                    set.Reattach(this, "StudentGraduationPlanAssociationCareerPathwayCodes");
                }
            
                foreach (var item in _studentGraduationPlanAssociationCareerPathwayCodes)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationCareerPathwayCodes;
            }
            set
            {
                _studentGraduationPlanAssociationCareerPathwayCodes = value;
                _studentGraduationPlanAssociationCareerPathwayCodesCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentGraduationPlanAssociationCareerPathwayCode, Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCareerPathwayCode>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationCareerPathwayCode> Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentGraduationPlanAssociationCareerPathwayCodes
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentGraduationPlanAssociationCareerPathwayCodes)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationCareerPathwayCodesCovariant;
            }
            set
            {
                StudentGraduationPlanAssociationCareerPathwayCodes = new HashSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCareerPathwayCode>(value.Cast<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationCareerPathwayCode>());
            }
        }


        private ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDescription> _studentGraduationPlanAssociationDescriptions;
        private ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationDescription> _studentGraduationPlanAssociationDescriptionsCovariant;
        [Key(25)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDescription>))]
        public virtual ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDescription> StudentGraduationPlanAssociationDescriptions
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentGraduationPlanAssociationDescriptions is DeserializedPersistentGenericSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDescription> set)
                {
                    set.Reattach(this, "StudentGraduationPlanAssociationDescriptions");
                }
            
                foreach (var item in _studentGraduationPlanAssociationDescriptions)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationDescriptions;
            }
            set
            {
                _studentGraduationPlanAssociationDescriptions = value;
                _studentGraduationPlanAssociationDescriptionsCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentGraduationPlanAssociationDescription, Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDescription>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationDescription> Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentGraduationPlanAssociationDescriptions
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentGraduationPlanAssociationDescriptions)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationDescriptionsCovariant;
            }
            set
            {
                StudentGraduationPlanAssociationDescriptions = new HashSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDescription>(value.Cast<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDescription>());
            }
        }


        private ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDesignatedBy> _studentGraduationPlanAssociationDesignatedBies;
        private ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationDesignatedBy> _studentGraduationPlanAssociationDesignatedBiesCovariant;
        [Key(26)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDesignatedBy>))]
        public virtual ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDesignatedBy> StudentGraduationPlanAssociationDesignatedBies
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentGraduationPlanAssociationDesignatedBies is DeserializedPersistentGenericSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDesignatedBy> set)
                {
                    set.Reattach(this, "StudentGraduationPlanAssociationDesignatedBies");
                }
            
                foreach (var item in _studentGraduationPlanAssociationDesignatedBies)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationDesignatedBies;
            }
            set
            {
                _studentGraduationPlanAssociationDesignatedBies = value;
                _studentGraduationPlanAssociationDesignatedBiesCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentGraduationPlanAssociationDesignatedBy, Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDesignatedBy>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationDesignatedBy> Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentGraduationPlanAssociationDesignatedBies
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentGraduationPlanAssociationDesignatedBies)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationDesignatedBiesCovariant;
            }
            set
            {
                StudentGraduationPlanAssociationDesignatedBies = new HashSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDesignatedBy>(value.Cast<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationDesignatedBy>());
            }
        }


        private ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationIndustryCredential> _studentGraduationPlanAssociationIndustryCredentials;
        private ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationIndustryCredential> _studentGraduationPlanAssociationIndustryCredentialsCovariant;
        [Key(27)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationIndustryCredential>))]
        public virtual ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationIndustryCredential> StudentGraduationPlanAssociationIndustryCredentials
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentGraduationPlanAssociationIndustryCredentials is DeserializedPersistentGenericSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationIndustryCredential> set)
                {
                    set.Reattach(this, "StudentGraduationPlanAssociationIndustryCredentials");
                }
            
                foreach (var item in _studentGraduationPlanAssociationIndustryCredentials)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationIndustryCredentials;
            }
            set
            {
                _studentGraduationPlanAssociationIndustryCredentials = value;
                _studentGraduationPlanAssociationIndustryCredentialsCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentGraduationPlanAssociationIndustryCredential, Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationIndustryCredential>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationIndustryCredential> Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentGraduationPlanAssociationIndustryCredentials
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentGraduationPlanAssociationIndustryCredentials)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationIndustryCredentialsCovariant;
            }
            set
            {
                StudentGraduationPlanAssociationIndustryCredentials = new HashSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationIndustryCredential>(value.Cast<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationIndustryCredential>());
            }
        }


        private ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationStudentContactAssociation> _studentGraduationPlanAssociationStudentContactAssociations;
        private ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationStudentContactAssociation> _studentGraduationPlanAssociationStudentContactAssociationsCovariant;
        [Key(28)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationStudentContactAssociation>))]
        public virtual ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationStudentContactAssociation> StudentGraduationPlanAssociationStudentContactAssociations
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentGraduationPlanAssociationStudentContactAssociations is DeserializedPersistentGenericSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationStudentContactAssociation> set)
                {
                    set.Reattach(this, "StudentGraduationPlanAssociationStudentContactAssociations");
                }
            
                foreach (var item in _studentGraduationPlanAssociationStudentContactAssociations)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationStudentContactAssociations;
            }
            set
            {
                _studentGraduationPlanAssociationStudentContactAssociations = value;
                _studentGraduationPlanAssociationStudentContactAssociationsCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentGraduationPlanAssociationStudentContactAssociation, Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationStudentContactAssociation>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationStudentContactAssociation> Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentGraduationPlanAssociationStudentContactAssociations
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentGraduationPlanAssociationStudentContactAssociations)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationStudentContactAssociationsCovariant;
            }
            set
            {
                StudentGraduationPlanAssociationStudentContactAssociations = new HashSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationStudentContactAssociation>(value.Cast<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationStudentContactAssociation>());
            }
        }


        private ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationYearsAttended> _studentGraduationPlanAssociationYearsAttendeds;
        private ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationYearsAttended> _studentGraduationPlanAssociationYearsAttendedsCovariant;
        [Key(29)]
        [MessagePackFormatter(typeof(PersistentCollectionFormatter<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationYearsAttended>))]
        public virtual ICollection<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationYearsAttended> StudentGraduationPlanAssociationYearsAttendeds
        {
            get
            {
                // -------------------------------------------------------------
                // On-demand deserialization logic to attach reverse reference of children
                // due to ServiceStack's lack of [OnDeserialized] attribute support.
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                if (_studentGraduationPlanAssociationYearsAttendeds is DeserializedPersistentGenericSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationYearsAttended> set)
                {
                    set.Reattach(this, "StudentGraduationPlanAssociationYearsAttendeds");
                }
            
                foreach (var item in _studentGraduationPlanAssociationYearsAttendeds)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationYearsAttendeds;
            }
            set
            {
                _studentGraduationPlanAssociationYearsAttendeds = value;
                _studentGraduationPlanAssociationYearsAttendedsCovariant = new CovariantCollectionAdapter<Entities.Common.Sample.IStudentGraduationPlanAssociationYearsAttended, Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationYearsAttended>(value);
            }
        }

        // Covariant version, visible only on the interface
        ICollection<Entities.Common.Sample.IStudentGraduationPlanAssociationYearsAttended> Entities.Common.Sample.IStudentGraduationPlanAssociation.StudentGraduationPlanAssociationYearsAttendeds
        {
            get
            {
                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (var item in _studentGraduationPlanAssociationYearsAttendeds)
                    if (item.StudentGraduationPlanAssociation == null)
                        item.StudentGraduationPlanAssociation = this;
                // -------------------------------------------------------------

                return _studentGraduationPlanAssociationYearsAttendedsCovariant;
            }
            set
            {
                StudentGraduationPlanAssociationYearsAttendeds = new HashSet<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationYearsAttended>(value.Cast<Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociationYearsAttended>());
            }
        }

        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "GraduationPlanTypeDescriptor", new LookupColumnDetails { PropertyName = "GraduationPlanTypeDescriptorId", LookupTypeName = "GraduationPlanTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Initialize a new dictionary to hold the key values
            var keyValues = new OrderedDictionary();

            // Add current key values
            keyValues.Add("EducationOrganizationId", EducationOrganizationId);
            keyValues.Add("GraduationPlanTypeDescriptorId", GraduationPlanTypeDescriptorId);
            keyValues.Add("GraduationSchoolYear", GraduationSchoolYear);
            keyValues.Add("StudentUSI", StudentUSI);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentGraduationPlanAssociation)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentGraduationPlanAssociation) target, null);
        }

    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentGraduationPlanAssociationAcademicSubject table of the StudentGraduationPlanAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentGraduationPlanAssociationAcademicSubject : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentGraduationPlanAssociationAcademicSubject, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentGraduationPlanAssociationAcademicSubject()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentGraduationPlanAssociation StudentGraduationPlanAssociation { get; set; }

        Entities.Common.Sample.IStudentGraduationPlanAssociation IStudentGraduationPlanAssociationAcademicSubject.StudentGraduationPlanAssociation
        {
            get { return StudentGraduationPlanAssociation; }
            set { StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int AcademicSubjectDescriptorId 
        {
            get
            {
                if (_academicSubjectDescriptorId == default(int))
                {
                    _academicSubjectDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("AcademicSubjectDescriptor", _academicSubjectDescriptor);
                }

                return _academicSubjectDescriptorId;
            } 
            set
            {
                _academicSubjectDescriptorId = value;
                _academicSubjectDescriptor = null;
            }
        }

        private int _academicSubjectDescriptorId;
        private string _academicSubjectDescriptor;

        [IgnoreMember]
        public virtual string AcademicSubjectDescriptor
        {
            get
            {
                if (_academicSubjectDescriptor == null)
                    _academicSubjectDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("AcademicSubjectDescriptor", _academicSubjectDescriptorId);
                    
                return _academicSubjectDescriptor;
            }
            set
            {
                _academicSubjectDescriptor = value;
                _academicSubjectDescriptorId = default(int);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "AcademicSubjectDescriptor", new LookupColumnDetails { PropertyName = "AcademicSubjectDescriptorId", LookupTypeName = "AcademicSubjectDescriptor"} },
                { "GraduationPlanTypeDescriptor", new LookupColumnDetails { PropertyName = "GraduationPlanTypeDescriptorId", LookupTypeName = "GraduationPlanTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentGraduationPlanAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("AcademicSubjectDescriptorId", AcademicSubjectDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentGraduationPlanAssociationAcademicSubject)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentGraduationPlanAssociationAcademicSubject) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentGraduationPlanAssociationCareerPathwayCode table of the StudentGraduationPlanAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentGraduationPlanAssociationCareerPathwayCode : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentGraduationPlanAssociationCareerPathwayCode, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentGraduationPlanAssociationCareerPathwayCode()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentGraduationPlanAssociation StudentGraduationPlanAssociation { get; set; }

        Entities.Common.Sample.IStudentGraduationPlanAssociation IStudentGraduationPlanAssociationCareerPathwayCode.StudentGraduationPlanAssociation
        {
            get { return StudentGraduationPlanAssociation; }
            set { StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual int CareerPathwayCode  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "GraduationPlanTypeDescriptor", new LookupColumnDetails { PropertyName = "GraduationPlanTypeDescriptorId", LookupTypeName = "GraduationPlanTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentGraduationPlanAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("CareerPathwayCode", CareerPathwayCode);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentGraduationPlanAssociationCareerPathwayCode)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentGraduationPlanAssociationCareerPathwayCode) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentGraduationPlanAssociationCTEProgramService table of the StudentGraduationPlanAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentGraduationPlanAssociationCTEProgramService : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentGraduationPlanAssociationCTEProgramService, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentGraduationPlanAssociationCTEProgramService()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentGraduationPlanAssociation StudentGraduationPlanAssociation { get; set; }

        Entities.Common.Sample.IStudentGraduationPlanAssociation IStudentGraduationPlanAssociationCTEProgramService.StudentGraduationPlanAssociation
        {
            get { return StudentGraduationPlanAssociation; }
            set { StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual string CIPCode  { get; set; }

        [Key(2)]
        public virtual int CTEProgramServiceDescriptorId 
        {
            get
            {
                if (_cteProgramServiceDescriptorId == default(int))
                {
                    _cteProgramServiceDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("CTEProgramServiceDescriptor", _cteProgramServiceDescriptor);
                }

                return _cteProgramServiceDescriptorId;
            } 
            set
            {
                _cteProgramServiceDescriptorId = value;
                _cteProgramServiceDescriptor = null;
            }
        }

        private int _cteProgramServiceDescriptorId;
        private string _cteProgramServiceDescriptor;

        [IgnoreMember]
        public virtual string CTEProgramServiceDescriptor
        {
            get
            {
                if (_cteProgramServiceDescriptor == null)
                    _cteProgramServiceDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("CTEProgramServiceDescriptor", _cteProgramServiceDescriptorId);
                    
                return _cteProgramServiceDescriptor;
            }
            set
            {
                _cteProgramServiceDescriptor = value;
                _cteProgramServiceDescriptorId = default(int);
            }
        }

        [Key(3)]
        public virtual bool? PrimaryIndicator  { get; set; }

        [Key(4)]
        public virtual DateTime? ServiceBeginDate 
        {
            get { return _serviceBeginDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _serviceBeginDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _serviceBeginDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _serviceBeginDate;

        [Key(5)]
        public virtual DateTime? ServiceEndDate 
        {
            get { return _serviceEndDate; }
            set 
            { 
                //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
                if(value == null)
                {
                    _serviceEndDate = null;
                } else
                {
                    var given = (DateTime) value;
                    _serviceEndDate = new DateTime(given.Year, given.Month, given.Day);
                }
            }
        }

        private DateTime? _serviceEndDate;

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "CTEProgramServiceDescriptor", new LookupColumnDetails { PropertyName = "CTEProgramServiceDescriptorId", LookupTypeName = "CTEProgramServiceDescriptor"} },
                { "GraduationPlanTypeDescriptor", new LookupColumnDetails { PropertyName = "GraduationPlanTypeDescriptorId", LookupTypeName = "GraduationPlanTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentGraduationPlanAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentGraduationPlanAssociationCTEProgramService)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentGraduationPlanAssociationCTEProgramService) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentGraduationPlanAssociationDescription table of the StudentGraduationPlanAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentGraduationPlanAssociationDescription : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentGraduationPlanAssociationDescription, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentGraduationPlanAssociationDescription()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentGraduationPlanAssociation StudentGraduationPlanAssociation { get; set; }

        Entities.Common.Sample.IStudentGraduationPlanAssociation IStudentGraduationPlanAssociationDescription.StudentGraduationPlanAssociation
        {
            get { return StudentGraduationPlanAssociation; }
            set { StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string Description  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "GraduationPlanTypeDescriptor", new LookupColumnDetails { PropertyName = "GraduationPlanTypeDescriptorId", LookupTypeName = "GraduationPlanTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentGraduationPlanAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("Description", Description);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentGraduationPlanAssociationDescription)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentGraduationPlanAssociationDescription) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentGraduationPlanAssociationDesignatedBy table of the StudentGraduationPlanAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentGraduationPlanAssociationDesignatedBy : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentGraduationPlanAssociationDesignatedBy, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentGraduationPlanAssociationDesignatedBy()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentGraduationPlanAssociation StudentGraduationPlanAssociation { get; set; }

        Entities.Common.Sample.IStudentGraduationPlanAssociation IStudentGraduationPlanAssociationDesignatedBy.StudentGraduationPlanAssociation
        {
            get { return StudentGraduationPlanAssociation; }
            set { StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string DesignatedBy  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "GraduationPlanTypeDescriptor", new LookupColumnDetails { PropertyName = "GraduationPlanTypeDescriptorId", LookupTypeName = "GraduationPlanTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentGraduationPlanAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("DesignatedBy", DesignatedBy);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentGraduationPlanAssociationDesignatedBy)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentGraduationPlanAssociationDesignatedBy) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentGraduationPlanAssociationIndustryCredential table of the StudentGraduationPlanAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentGraduationPlanAssociationIndustryCredential : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentGraduationPlanAssociationIndustryCredential, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentGraduationPlanAssociationIndustryCredential()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentGraduationPlanAssociation StudentGraduationPlanAssociation { get; set; }

        Entities.Common.Sample.IStudentGraduationPlanAssociation IStudentGraduationPlanAssociationIndustryCredential.StudentGraduationPlanAssociation
        {
            get { return StudentGraduationPlanAssociation; }
            set { StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual string IndustryCredential  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "GraduationPlanTypeDescriptor", new LookupColumnDetails { PropertyName = "GraduationPlanTypeDescriptorId", LookupTypeName = "GraduationPlanTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentGraduationPlanAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("IndustryCredential", IndustryCredential);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentGraduationPlanAssociationIndustryCredential)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentGraduationPlanAssociationIndustryCredential) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentGraduationPlanAssociationStudentContactAssociation table of the StudentGraduationPlanAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentGraduationPlanAssociationStudentContactAssociation : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentGraduationPlanAssociationStudentContactAssociation, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentGraduationPlanAssociationStudentContactAssociation()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.StudentContactAssociationAggregate.EdFi.StudentContactAssociationReferenceData _studentContactAssociationReferenceData;

        private bool StudentContactAssociationReferenceDataIsProxied()
        {
            return _studentContactAssociationReferenceData != null 
                && _studentContactAssociationReferenceData.GetType() != typeof(NHibernate.StudentContactAssociationAggregate.EdFi.StudentContactAssociationReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.StudentContactAssociationAggregate.EdFi.StudentContactAssociationReferenceData StudentContactAssociationReferenceData
        {
            get => _studentContactAssociationReferenceData;
            set
            {
                _studentContactAssociationReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !StudentContactAssociationReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(1)]
        public virtual NHibernate.StudentContactAssociationAggregate.EdFi.StudentContactAssociationReferenceData StudentContactAssociationSerializedReferenceData { get => _studentContactAssociationSerializedReferenceData; set { if (value != null) _studentContactAssociationSerializedReferenceData = value; } }
        private NHibernate.StudentContactAssociationAggregate.EdFi.StudentContactAssociationReferenceData _studentContactAssociationSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the StudentContactAssociation discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IStudentGraduationPlanAssociationStudentContactAssociation.StudentContactAssociationDiscriminator
        {
            get
            {
                return StudentContactAssociationReferenceDataIsProxied()
                    ? (StudentContactAssociationSerializedReferenceData ?? StudentContactAssociationReferenceData)?.Discriminator
                    : (StudentContactAssociationReferenceData ?? StudentContactAssociationSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the StudentContactAssociation resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IStudentGraduationPlanAssociationStudentContactAssociation.StudentContactAssociationResourceId
        {
            get
            {
                return StudentContactAssociationReferenceDataIsProxied()
                    ? (StudentContactAssociationSerializedReferenceData ?? StudentContactAssociationReferenceData)?.Id
                    : (StudentContactAssociationReferenceData ?? StudentContactAssociationSerializedReferenceData)?.Id;
            }
            set { if (StudentContactAssociationSerializedReferenceData?.IsFullyDefined() == true) StudentContactAssociationSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentGraduationPlanAssociation StudentGraduationPlanAssociation { get; set; }

        Entities.Common.Sample.IStudentGraduationPlanAssociation IStudentGraduationPlanAssociationStudentContactAssociation.StudentGraduationPlanAssociation
        {
            get { return StudentGraduationPlanAssociation; }
            set { StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value; }
        }

        [Display(Name="ContactUniqueId")][DomainSignature]
        [Key(2)]
        public virtual int ContactUSI 
        {
            get
            {
                if (_contactUSI == default(int) && _contactUniqueId != null)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Contact", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_contactUniqueId, out var usi))
                    {
                        _contactUSI = usi;

                        if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                        {
                            StudentContactAssociationSerializedReferenceData ??= new NHibernate.StudentContactAssociationAggregate.EdFi.StudentContactAssociationReferenceData(true);
                            StudentContactAssociationSerializedReferenceData.ContactUSI = _contactUSI;
                        }
                    }
                }

                return _contactUSI;
            } 
            set
            {
                _contactUSI = value;
                GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().AddLookup("Contact", value);

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    StudentContactAssociationSerializedReferenceData ??= new NHibernate.StudentContactAssociationAggregate.EdFi.StudentContactAssociationReferenceData(true);
                    StudentContactAssociationSerializedReferenceData.ContactUSI = value;
                }
            }
        }

        private int _contactUSI;
        private string _contactUniqueId;

        [IgnoreMember]
        public virtual string ContactUniqueId
        {
            get
            {
                if (_contactUniqueId == null)
                {
                    if (GeneratedArtifactStaticDependencies.UniqueIdLookupsByUsiContextProvider.Get().UniqueIdByUsiByPersonType.TryGetValue("Contact", out var uniqueIdByUsi)
                        && uniqueIdByUsi.TryGetValue(_contactUSI, out var uniqueId))
                    {
                        _contactUniqueId = uniqueId;
                    }
                }

                return _contactUniqueId;
            }
            set
            {
                if (_contactUniqueId != value)
                        _contactUSI = default(int);

                _contactUniqueId = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    if (GeneratedArtifactStaticDependencies.UsiLookupsByUniqueIdContextProvider.Get().UsiByUniqueIdByPersonType.TryGetValue("Contact", out var usiByUniqueId)
                        && usiByUniqueId.TryGetValue(_contactUniqueId, out var usi))
                    {
                        StudentContactAssociationSerializedReferenceData ??= new NHibernate.StudentContactAssociationAggregate.EdFi.StudentContactAssociationReferenceData(true);
                        StudentContactAssociationSerializedReferenceData.ContactUSI = usi;
                    }
                }
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "GraduationPlanTypeDescriptor", new LookupColumnDetails { PropertyName = "GraduationPlanTypeDescriptorId", LookupTypeName = "GraduationPlanTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentGraduationPlanAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("ContactUSI", ContactUSI);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentGraduationPlanAssociationStudentContactAssociation)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentGraduationPlanAssociationStudentContactAssociation) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value;
        }
    }
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentGraduationPlanAssociationYearsAttended table of the StudentGraduationPlanAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentGraduationPlanAssociationYearsAttended : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentGraduationPlanAssociationYearsAttended, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentGraduationPlanAssociationYearsAttended()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual StudentGraduationPlanAssociation StudentGraduationPlanAssociation { get; set; }

        Entities.Common.Sample.IStudentGraduationPlanAssociation IStudentGraduationPlanAssociationYearsAttended.StudentGraduationPlanAssociation
        {
            get { return StudentGraduationPlanAssociation; }
            set { StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value; }
        }

        [DomainSignature]
        [Key(1)]
        public virtual short YearsAttended  { get; set; }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "GraduationPlanTypeDescriptor", new LookupColumnDetails { PropertyName = "GraduationPlanTypeDescriptorId", LookupTypeName = "GraduationPlanTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentGraduationPlanAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("YearsAttended", YearsAttended);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentGraduationPlanAssociationYearsAttended)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentGraduationPlanAssociationYearsAttended) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentGraduationPlanAssociation = (StudentGraduationPlanAssociation) value;
        }
    }
}
// Aggregate: StudentSchoolAssociation

namespace EdFi.Ods.Entities.NHibernate.StudentSchoolAssociationAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentSchoolAssociationExtension table of the StudentSchoolAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentSchoolAssociationExtension : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentSchoolAssociationExtension, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentSchoolAssociationExtension()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentSchoolAssociation StudentSchoolAssociation { get; set; }

        Entities.Common.EdFi.IStudentSchoolAssociation IStudentSchoolAssociationExtension.StudentSchoolAssociation
        {
            get { return StudentSchoolAssociation; }
            set { StudentSchoolAssociation = (EdFi.StudentSchoolAssociation) value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        [Key(1)]
        public virtual int? MembershipTypeDescriptorId 
        {
            get
            {
                if (_membershipTypeDescriptorId == default(int?))
                {
                    _membershipTypeDescriptorId = string.IsNullOrWhiteSpace(_membershipTypeDescriptor) ? default(int?) : GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("MembershipTypeDescriptor", _membershipTypeDescriptor);
                }

                return _membershipTypeDescriptorId;
            } 
            set
            {
                _membershipTypeDescriptorId = value;
                _membershipTypeDescriptor = null;
            }
        }

        private int? _membershipTypeDescriptorId;
        private string _membershipTypeDescriptor;

        [IgnoreMember]
        public virtual string MembershipTypeDescriptor
        {
            get
            {
                if (_membershipTypeDescriptor == null)
                    _membershipTypeDescriptor = _membershipTypeDescriptorId == null ? null : GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("MembershipTypeDescriptor", _membershipTypeDescriptorId.Value);
                    
                return _membershipTypeDescriptor;
            }
            set
            {
                _membershipTypeDescriptor = value;
                _membershipTypeDescriptorId = default(int?);
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "MembershipTypeDescriptor", new LookupColumnDetails { PropertyName = "MembershipTypeDescriptorId", LookupTypeName = "MembershipTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentSchoolAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentSchoolAssociationExtension)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentSchoolAssociationExtension) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentSchoolAssociation = (EdFi.StudentSchoolAssociation) value;
        }
    }
}
// Aggregate: StudentSectionAssociation

namespace EdFi.Ods.Entities.NHibernate.StudentSectionAssociationAggregate.Sample
{
// disable warnings for inheritance from classes marked Obsolete within this generated code only
#pragma warning disable 612, 618

    /// <summary>
    /// A class which represents the sample.StudentSectionAssociationRelatedGeneralStudentProgramAssociation table of the StudentSectionAssociation aggregate in the ODS database.
    /// </summary>
    [Schema("sample")]
    [ExcludeFromCodeCoverage]
    [MessagePackObject]
    public class StudentSectionAssociationRelatedGeneralStudentProgramAssociation : EntityWithCompositeKey, IChildEntity,
        Entities.Common.Sample.IStudentSectionAssociationRelatedGeneralStudentProgramAssociation, IHasPrimaryKeyValues, IHasLookupColumnPropertyMap
    {
        public virtual void SuspendReferenceAssignmentCheck() { }

        public StudentSectionAssociationRelatedGeneralStudentProgramAssociation()
        {
        }
// restore warnings for inheritance from classes marked Obsolete
#pragma warning restore 612, 618

        // =============================================================
        //                     Reference Data
        // -------------------------------------------------------------
        private NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData _relatedGeneralStudentProgramAssociationReferenceData;

        private bool RelatedGeneralStudentProgramAssociationReferenceDataIsProxied()
        {
            return _relatedGeneralStudentProgramAssociationReferenceData != null 
                && _relatedGeneralStudentProgramAssociationReferenceData.GetType() != typeof(NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData);
        }

        [IgnoreMember]
        public virtual NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData RelatedGeneralStudentProgramAssociationReferenceData
        {
            get => _relatedGeneralStudentProgramAssociationReferenceData;
            set
            {
                _relatedGeneralStudentProgramAssociationReferenceData = value;

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled
                    // NHibernate will proxy this object reference if it is not hydrated through an outer join in the query
                    && !RelatedGeneralStudentProgramAssociationReferenceDataIsProxied())
                {
                    // We've encountered an NHibernate hydrated reference data meaning we've already got all reference data needed
                    GeneratedArtifactStaticDependencies.ReferenceDataLookupContextProvider.Get()?.Suppress();
                }
            }
        }

        [Key(1)]
        public virtual NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData RelatedGeneralStudentProgramAssociationSerializedReferenceData { get => _relatedGeneralStudentProgramAssociationSerializedReferenceData; set { if (value != null) _relatedGeneralStudentProgramAssociationSerializedReferenceData = value; } }
        private NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData _relatedGeneralStudentProgramAssociationSerializedReferenceData;

        /// <summary>
        /// A read-only property implementation that allows the RelatedGeneralStudentProgramAssociation discriminator value to be mapped to the resource reference.
        /// </summary>
        string Entities.Common.Sample.IStudentSectionAssociationRelatedGeneralStudentProgramAssociation.RelatedGeneralStudentProgramAssociationDiscriminator
        {
            get
            {
                return RelatedGeneralStudentProgramAssociationReferenceDataIsProxied()
                    ? (RelatedGeneralStudentProgramAssociationSerializedReferenceData ?? RelatedGeneralStudentProgramAssociationReferenceData)?.Discriminator
                    : (RelatedGeneralStudentProgramAssociationReferenceData ?? RelatedGeneralStudentProgramAssociationSerializedReferenceData)?.Discriminator;
            }
            set { }
        }

        /// <summary>
        /// A property implementation whose getter allows the RelatedGeneralStudentProgramAssociation resource identifier value to be mapped to the resource reference,
        /// and whose setter is used with serialized data and links features to signal need to resolve reference data from the ODS.
        /// </summary>
        Guid? Entities.Common.Sample.IStudentSectionAssociationRelatedGeneralStudentProgramAssociation.RelatedGeneralStudentProgramAssociationResourceId
        {
            get
            {
                return RelatedGeneralStudentProgramAssociationReferenceDataIsProxied()
                    ? (RelatedGeneralStudentProgramAssociationSerializedReferenceData ?? RelatedGeneralStudentProgramAssociationReferenceData)?.Id
                    : (RelatedGeneralStudentProgramAssociationReferenceData ?? RelatedGeneralStudentProgramAssociationSerializedReferenceData)?.Id;
            }
            set { if (RelatedGeneralStudentProgramAssociationSerializedReferenceData?.IsFullyDefined() == true) RelatedGeneralStudentProgramAssociationSerializedReferenceData.Id = value; }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        [DomainSignature, IgnoreMember]
        public virtual EdFi.StudentSectionAssociation StudentSectionAssociation { get; set; }

        Entities.Common.Sample.IStudentSectionAssociationExtension IStudentSectionAssociationRelatedGeneralStudentProgramAssociation.StudentSectionAssociationExtension
        {
            get { return (IStudentSectionAssociationExtension) StudentSectionAssociation.Extensions["Sample"]; }
            set { StudentSectionAssociation.Extensions["Sample"] = value; }
        }

        [DomainSignature]
        [Key(2)]
        public virtual DateTime RelatedBeginDate 
        {
            get { return _relatedBeginDate; }
            //This is only stored as a Date in the DB and NHibernate will retrieve it using the default (local) DateTime.Kind.  We must ensure it is set consistently for any equality/change evaluation.
            set
            {
                _relatedBeginDate = new DateTime(value.Year, value.Month, value.Day);

                if (_relatedBeginDate != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData.BeginDate = _relatedBeginDate;
                }
            }
        }

        private DateTime _relatedBeginDate;

        [DomainSignature]
        [Key(3)]
        public virtual long RelatedEducationOrganizationId 
        {
            get => _relatedEducationOrganizationId;
            set
            {
                _relatedEducationOrganizationId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData.EducationOrganizationId = value;
                }
            }
        }

        private long _relatedEducationOrganizationId;

        [DomainSignature]
        [Key(4)]
        public virtual long RelatedProgramEducationOrganizationId 
        {
            get => _relatedProgramEducationOrganizationId;
            set
            {
                _relatedProgramEducationOrganizationId = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData.ProgramEducationOrganizationId = value;
                }
            }
        }

        private long _relatedProgramEducationOrganizationId;

        [DomainSignature]
        [Key(5)]
        public virtual string RelatedProgramName 
        {
            get => _relatedProgramName;
            set
            {
                _relatedProgramName = value;

                if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData.ProgramName = value;
                }
            }
        }

        private string _relatedProgramName;

        [DomainSignature]
        [Key(6)]
        public virtual int RelatedProgramTypeDescriptorId 
        {
            get
            {
                if (_relatedProgramTypeDescriptorId == default(int))
                {
                    _relatedProgramTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ProgramTypeDescriptor", _relatedProgramTypeDescriptor);
                
                    if (GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                    {
                        RelatedGeneralStudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                        RelatedGeneralStudentProgramAssociationSerializedReferenceData.ProgramTypeDescriptorId = _relatedProgramTypeDescriptorId;
                    }
                }

                return _relatedProgramTypeDescriptorId;
            } 
            set
            {
                _relatedProgramTypeDescriptorId = value;
                _relatedProgramTypeDescriptor = null;
        
                if (value != default && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData.ProgramTypeDescriptorId = value;
                }
            }
        }

        private int _relatedProgramTypeDescriptorId;
        private string _relatedProgramTypeDescriptor;

        [IgnoreMember]
        public virtual string RelatedProgramTypeDescriptor
        {
            get
            {
                if (_relatedProgramTypeDescriptor == null)
                    _relatedProgramTypeDescriptor = GeneratedArtifactStaticDependencies.DescriptorResolver.GetUri("ProgramTypeDescriptor", _relatedProgramTypeDescriptorId);
                    
                return _relatedProgramTypeDescriptor;
            }
            set
            {
                _relatedProgramTypeDescriptor = value;
                _relatedProgramTypeDescriptorId = default(int);

                if (value != null && GeneratedArtifactStaticDependencies.SerializedDataEnabled && GeneratedArtifactStaticDependencies.ResourceLinksEnabled)
                {
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData ??= new NHibernate.GeneralStudentProgramAssociationAggregate.EdFi.GeneralStudentProgramAssociationReferenceData(true);
                    RelatedGeneralStudentProgramAssociationSerializedReferenceData.ProgramTypeDescriptorId = GeneratedArtifactStaticDependencies.DescriptorResolver.GetDescriptorId("ProgramTypeDescriptor", _relatedProgramTypeDescriptor);
                }
            }
        }

        // -------------------------------------------------------------

        // =============================================================
        //                      Inherited Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Properties
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Extensions
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        //=============================================================
        //                          Collections
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // Provide lookup property map
        private static readonly Dictionary<string, LookupColumnDetails> _idPropertyByLookupProperty = new Dictionary<string, LookupColumnDetails>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "RelatedProgramTypeDescriptor", new LookupColumnDetails { PropertyName = "RelatedProgramTypeDescriptorId", LookupTypeName = "ProgramTypeDescriptor"} },
            };

        Dictionary<string, LookupColumnDetails> IHasLookupColumnPropertyMap.IdPropertyByLookupProperty
        {
            get { return _idPropertyByLookupProperty; }
        }

        // Provide primary key information
        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            // Get parent key values
            var keyValues = (StudentSectionAssociation as IHasPrimaryKeyValues)?.GetPrimaryKeyValues() ?? new OrderedDictionary();

            // Add current key values
            keyValues.Add("RelatedBeginDate", RelatedBeginDate);
            keyValues.Add("RelatedEducationOrganizationId", RelatedEducationOrganizationId);
            keyValues.Add("RelatedProgramEducationOrganizationId", RelatedProgramEducationOrganizationId);
            keyValues.Add("RelatedProgramName", RelatedProgramName);
            keyValues.Add("RelatedProgramTypeDescriptorId", RelatedProgramTypeDescriptorId);

            return keyValues;
        }

        #region Overrides for Equals() and GetHashCode()
        public override bool Equals(object obj)
        {
            var compareTo = obj as IHasPrimaryKeyValues;

            if (ReferenceEquals(this, compareTo))
                return true;

            if (compareTo == null)
                return false;

            var theseKeys = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();
            var thoseKeys = compareTo.GetPrimaryKeyValues();

            foreach (DictionaryEntry entry in theseKeys)
            {
                if (entry.Value is string)
                {
                    if (!GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer.Equals((string) entry.Value, (string) thoseKeys[entry.Key]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!entry.Value.Equals(thoseKeys[entry.Key]))
                        return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var keyValues = (this as IHasPrimaryKeyValues).GetPrimaryKeyValues();

            if (keyValues.Count == 0)
                return base.GetHashCode();

            var hashCode = new HashCode();

            foreach (DictionaryEntry entry in keyValues)
            {
                if (entry.Value is string)
                {
                    hashCode.Add(entry.Value as string, GeneratedArtifactStaticDependencies.DatabaseEngineSpecificStringComparer);
                }
                else
                {
                    hashCode.Add(entry.Value);
                }
            }

            return hashCode.ToHashCode();
        }
        #endregion
        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((Entities.Common.Sample.IStudentSectionAssociationRelatedGeneralStudentProgramAssociation)target);
        }

        void IMappable.Map(object target)
        {
            this.MapTo((Entities.Common.Sample.IStudentSectionAssociationRelatedGeneralStudentProgramAssociation) target, null);
        }

        void IChildEntity.SetParent(object value)
        {
            StudentSectionAssociation = (EdFi.StudentSectionAssociation) value;
        }
    }

    /// <summary>
    /// An implicitly created entity extension class to enable entity mapping and sychronization behavior for the StudentSectionAssociation entity's aggregate extensions.
    /// </summary>
    [ExcludeFromCodeCoverage][MessagePackObject]
    public class StudentSectionAssociationExtension : IStudentSectionAssociationExtension, IChildEntity, IImplicitEntityExtension, IHasPrimaryKeyValues
    {
        // =============================================================
        //                         Primary Key
        // -------------------------------------------------------------
        private EdFi.StudentSectionAssociation _studentSectionAssociation;

        Common.EdFi.IStudentSectionAssociation IStudentSectionAssociationExtension.StudentSectionAssociation
        {
            get { return _studentSectionAssociation; }
            set { _studentSectionAssociation = (EdFi.StudentSectionAssociation) value; }
        }

        private EdFi.StudentSectionAssociation StudentSectionAssociation
        {
            get { return (this as IStudentSectionAssociationExtension).StudentSectionAssociation as EdFi.StudentSectionAssociation; }
        }

        bool IImplicitEntityExtension.IsEmpty()
        {
            return (true
                && ((IList<object>) _studentSectionAssociation.AggregateExtensions["Sample_StudentSectionAssociationRelatedGeneralStudentProgramAssociations"]).Count == 0
            );
        }

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        // -------------------------------------------------------------

        // =============================================================
        //                          Collections
        // -------------------------------------------------------------
        ICollection<IStudentSectionAssociationRelatedGeneralStudentProgramAssociation> IStudentSectionAssociationExtension.StudentSectionAssociationRelatedGeneralStudentProgramAssociations
        {
            get
            {
                var sourceList =  new ContravariantCollectionAdapter<object, StudentSectionAssociationRelatedGeneralStudentProgramAssociation>((IList<object>) _studentSectionAssociation.AggregateExtensions["Sample_StudentSectionAssociationRelatedGeneralStudentProgramAssociations"]);

                // -------------------------------------------------------------
                // Back-reference is required by NHibernate for persistence.
                // -------------------------------------------------------------
                foreach (StudentSectionAssociationRelatedGeneralStudentProgramAssociation item in sourceList)
                    if (item.StudentSectionAssociation == null)
                        item.StudentSectionAssociation = this.StudentSectionAssociation;
                // -------------------------------------------------------------

                var adaptedList = new CovariantCollectionAdapter<IStudentSectionAssociationRelatedGeneralStudentProgramAssociation, StudentSectionAssociationRelatedGeneralStudentProgramAssociation>(sourceList);

                return adaptedList;
            }
            set
            {
                _studentSectionAssociation.AggregateExtensions["Sample_StudentSectionAssociationRelatedGeneralStudentProgramAssociations"] = value;
            }
        }
        // -------------------------------------------------------------

        void IMappable.Map(object target)
        {
            this.MapTo((IStudentSectionAssociationExtension) target, null);
        }

        bool ISynchronizable.Synchronize(object target)
        {
            return this.SynchronizeTo((IStudentSectionAssociationExtension) target);
        }

        void IChildEntity.SetParent(object value)
        {
            _studentSectionAssociation = (EdFi.StudentSectionAssociation)value;
        }

        OrderedDictionary IHasPrimaryKeyValues.GetPrimaryKeyValues()
        {
            return (_studentSectionAssociation as IHasPrimaryKeyValues).GetPrimaryKeyValues();
        }

        void IGetByExample.SuspendReferenceAssignmentCheck() { }
    }
}
