using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using EdFi.Common.Extensions;
using EdFi.Ods.Api.Attributes;
using EdFi.Ods.Api.Constants;
using EdFi.Ods.Api.Controllers;
using EdFi.Ods.Api.ExceptionHandling;
using EdFi.Ods.Api.Infrastructure.Pipelines.Factories;
using EdFi.Ods.Common.Infrastructure;
using EdFi.Ods.Common.Logging;
using EdFi.Ods.Common.Models.Requests;
using EdFi.Ods.Common.Models.Queries;
using EdFi.Ods.Common.ProblemDetails;
using EdFi.Ods.Common.Profiles;
using EdFi.Ods.Common.Configuration;
using EdFi.Ods.Common.Context;
using EdFi.Ods.Common.Security.Claims;
using EdFi.Ods.Entities.Common.Sample;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EdFi.Ods.Api.Services.Controllers.Sample.ArtMediumDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Authorize]
    [ApplyOdsRouteRootTemplate, Route($"{RouteConstants.DataManagementRoutePrefix}/sample/artMediumDescriptors")]
    public partial class ArtMediumDescriptorsController : DataManagementControllerBase<
        Api.Common.Models.Resources.ArtMediumDescriptor.Sample.ArtMediumDescriptor,
        Entities.Common.Sample.IArtMediumDescriptor,
        Entities.NHibernate.ArtMediumDescriptorAggregate.Sample.ArtMediumDescriptor,
        Api.Common.Models.Requests.Sample.ArtMediumDescriptors.ArtMediumDescriptorPut,
        Api.Common.Models.Requests.Sample.ArtMediumDescriptors.ArtMediumDescriptorPost,
        Api.Common.Models.Requests.Sample.ArtMediumDescriptors.ArtMediumDescriptorDelete,
        Api.Common.Models.Requests.Sample.ArtMediumDescriptors.ArtMediumDescriptorGetByExample>
    {
        public ArtMediumDescriptorsController(IPipelineFactory pipelineFactory, IEdFiProblemDetailsProvider problemDetailsProvider, IDefaultPageSizeLimitProvider defaultPageSizeLimitProvider, ApiSettings apiSettings, IContextProvider<ProfileContentTypeContext> profileContentTypeContextProvider, IContextProvider<DataManagementResourceContext> dataManagementResourceContextProvider, ILogContextAccessor logContextAccessor)
            : base(pipelineFactory, problemDetailsProvider, defaultPageSizeLimitProvider, apiSettings, profileContentTypeContextProvider, dataManagementResourceContextProvider, logContextAccessor)
        {
        }

        protected override void MapAll(Api.Common.Models.Requests.Sample.ArtMediumDescriptors.ArtMediumDescriptorGetByExample request, Entities.Common.Sample.IArtMediumDescriptor specification)
        {
            // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ArtMediumDescriptorId = request.ArtMediumDescriptorId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EffectiveBeginDate = request.EffectiveBeginDate;
            specification.EffectiveEndDate = request.EffectiveEndDate;
            specification.Id = request.Id;
            specification.Namespace = request.Namespace;
            specification.ShortDescription = request.ShortDescription;
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.Sample.Buses
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Authorize]
    [ApplyOdsRouteRootTemplate, Route($"{RouteConstants.DataManagementRoutePrefix}/sample/buses")]
    public partial class BusesController : DataManagementControllerBase<
        Api.Common.Models.Resources.Bus.Sample.Bus,
        Entities.Common.Sample.IBus,
        Entities.NHibernate.BusAggregate.Sample.Bus,
        Api.Common.Models.Requests.Sample.Buses.BusPut,
        Api.Common.Models.Requests.Sample.Buses.BusPost,
        Api.Common.Models.Requests.Sample.Buses.BusDelete,
        Api.Common.Models.Requests.Sample.Buses.BusGetByExample>
    {
        public BusesController(IPipelineFactory pipelineFactory, IEdFiProblemDetailsProvider problemDetailsProvider, IDefaultPageSizeLimitProvider defaultPageSizeLimitProvider, ApiSettings apiSettings, IContextProvider<ProfileContentTypeContext> profileContentTypeContextProvider, IContextProvider<DataManagementResourceContext> dataManagementResourceContextProvider, ILogContextAccessor logContextAccessor)
            : base(pipelineFactory, problemDetailsProvider, defaultPageSizeLimitProvider, apiSettings, profileContentTypeContextProvider, dataManagementResourceContextProvider, logContextAccessor)
        {
        }

        protected override void MapAll(Api.Common.Models.Requests.Sample.Buses.BusGetByExample request, Entities.Common.Sample.IBus specification)
        {
            // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BusId = request.BusId;
            specification.Id = request.Id;
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.Sample.BusRoutes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Authorize]
    [ApplyOdsRouteRootTemplate, Route($"{RouteConstants.DataManagementRoutePrefix}/sample/busRoutes")]
    public partial class BusRoutesController : DataManagementControllerBase<
        Api.Common.Models.Resources.BusRoute.Sample.BusRoute,
        Entities.Common.Sample.IBusRoute,
        Entities.NHibernate.BusRouteAggregate.Sample.BusRoute,
        Api.Common.Models.Requests.Sample.BusRoutes.BusRoutePut,
        Api.Common.Models.Requests.Sample.BusRoutes.BusRoutePost,
        Api.Common.Models.Requests.Sample.BusRoutes.BusRouteDelete,
        Api.Common.Models.Requests.Sample.BusRoutes.BusRouteGetByExample>
    {
        public BusRoutesController(IPipelineFactory pipelineFactory, IEdFiProblemDetailsProvider problemDetailsProvider, IDefaultPageSizeLimitProvider defaultPageSizeLimitProvider, ApiSettings apiSettings, IContextProvider<ProfileContentTypeContext> profileContentTypeContextProvider, IContextProvider<DataManagementResourceContext> dataManagementResourceContextProvider, ILogContextAccessor logContextAccessor)
            : base(pipelineFactory, problemDetailsProvider, defaultPageSizeLimitProvider, apiSettings, profileContentTypeContextProvider, dataManagementResourceContextProvider, logContextAccessor)
        {
        }

        protected override void MapAll(Api.Common.Models.Requests.Sample.BusRoutes.BusRouteGetByExample request, Entities.Common.Sample.IBusRoute specification)
        {
            // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.BusId = request.BusId;
            specification.BusRouteDirection = request.BusRouteDirection;
            specification.BusRouteDuration = request.BusRouteDuration;
            specification.BusRouteNumber = request.BusRouteNumber;
            specification.Daily = request.Daily;
            specification.DisabilityDescriptor = request.DisabilityDescriptor;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ExpectedTransitTime = request.ExpectedTransitTime;
            specification.HoursPerWeek = request.HoursPerWeek;
            specification.Id = request.Id;
            specification.OperatingCost = request.OperatingCost;
            specification.OptimalCapacity = request.OptimalCapacity;
            specification.StaffClassificationDescriptor = request.StaffClassificationDescriptor;
            specification.StaffUniqueId = request.StaffUniqueId;
            specification.StartDate = request.StartDate;
            specification.WeeklyMileage = request.WeeklyMileage;
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.Sample.FavoriteBookCategoryDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Authorize]
    [ApplyOdsRouteRootTemplate, Route($"{RouteConstants.DataManagementRoutePrefix}/sample/favoriteBookCategoryDescriptors")]
    public partial class FavoriteBookCategoryDescriptorsController : DataManagementControllerBase<
        Api.Common.Models.Resources.FavoriteBookCategoryDescriptor.Sample.FavoriteBookCategoryDescriptor,
        Entities.Common.Sample.IFavoriteBookCategoryDescriptor,
        Entities.NHibernate.FavoriteBookCategoryDescriptorAggregate.Sample.FavoriteBookCategoryDescriptor,
        Api.Common.Models.Requests.Sample.FavoriteBookCategoryDescriptors.FavoriteBookCategoryDescriptorPut,
        Api.Common.Models.Requests.Sample.FavoriteBookCategoryDescriptors.FavoriteBookCategoryDescriptorPost,
        Api.Common.Models.Requests.Sample.FavoriteBookCategoryDescriptors.FavoriteBookCategoryDescriptorDelete,
        Api.Common.Models.Requests.Sample.FavoriteBookCategoryDescriptors.FavoriteBookCategoryDescriptorGetByExample>
    {
        public FavoriteBookCategoryDescriptorsController(IPipelineFactory pipelineFactory, IEdFiProblemDetailsProvider problemDetailsProvider, IDefaultPageSizeLimitProvider defaultPageSizeLimitProvider, ApiSettings apiSettings, IContextProvider<ProfileContentTypeContext> profileContentTypeContextProvider, IContextProvider<DataManagementResourceContext> dataManagementResourceContextProvider, ILogContextAccessor logContextAccessor)
            : base(pipelineFactory, problemDetailsProvider, defaultPageSizeLimitProvider, apiSettings, profileContentTypeContextProvider, dataManagementResourceContextProvider, logContextAccessor)
        {
        }

        protected override void MapAll(Api.Common.Models.Requests.Sample.FavoriteBookCategoryDescriptors.FavoriteBookCategoryDescriptorGetByExample request, Entities.Common.Sample.IFavoriteBookCategoryDescriptor specification)
        {
            // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EffectiveBeginDate = request.EffectiveBeginDate;
            specification.EffectiveEndDate = request.EffectiveEndDate;
            specification.FavoriteBookCategoryDescriptorId = request.FavoriteBookCategoryDescriptorId;
            specification.Id = request.Id;
            specification.Namespace = request.Namespace;
            specification.ShortDescription = request.ShortDescription;
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.Sample.MembershipTypeDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Authorize]
    [ApplyOdsRouteRootTemplate, Route($"{RouteConstants.DataManagementRoutePrefix}/sample/membershipTypeDescriptors")]
    public partial class MembershipTypeDescriptorsController : DataManagementControllerBase<
        Api.Common.Models.Resources.MembershipTypeDescriptor.Sample.MembershipTypeDescriptor,
        Entities.Common.Sample.IMembershipTypeDescriptor,
        Entities.NHibernate.MembershipTypeDescriptorAggregate.Sample.MembershipTypeDescriptor,
        Api.Common.Models.Requests.Sample.MembershipTypeDescriptors.MembershipTypeDescriptorPut,
        Api.Common.Models.Requests.Sample.MembershipTypeDescriptors.MembershipTypeDescriptorPost,
        Api.Common.Models.Requests.Sample.MembershipTypeDescriptors.MembershipTypeDescriptorDelete,
        Api.Common.Models.Requests.Sample.MembershipTypeDescriptors.MembershipTypeDescriptorGetByExample>
    {
        public MembershipTypeDescriptorsController(IPipelineFactory pipelineFactory, IEdFiProblemDetailsProvider problemDetailsProvider, IDefaultPageSizeLimitProvider defaultPageSizeLimitProvider, ApiSettings apiSettings, IContextProvider<ProfileContentTypeContext> profileContentTypeContextProvider, IContextProvider<DataManagementResourceContext> dataManagementResourceContextProvider, ILogContextAccessor logContextAccessor)
            : base(pipelineFactory, problemDetailsProvider, defaultPageSizeLimitProvider, apiSettings, profileContentTypeContextProvider, dataManagementResourceContextProvider, logContextAccessor)
        {
        }

        protected override void MapAll(Api.Common.Models.Requests.Sample.MembershipTypeDescriptors.MembershipTypeDescriptorGetByExample request, Entities.Common.Sample.IMembershipTypeDescriptor specification)
        {
            // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EffectiveBeginDate = request.EffectiveBeginDate;
            specification.EffectiveEndDate = request.EffectiveEndDate;
            specification.Id = request.Id;
            specification.MembershipTypeDescriptorId = request.MembershipTypeDescriptorId;
            specification.Namespace = request.Namespace;
            specification.ShortDescription = request.ShortDescription;
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.Sample.StudentArtProgramAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Authorize]
    [ApplyOdsRouteRootTemplate, Route($"{RouteConstants.DataManagementRoutePrefix}/sample/studentArtProgramAssociations")]
    public partial class StudentArtProgramAssociationsController : DataManagementControllerBase<
        Api.Common.Models.Resources.StudentArtProgramAssociation.Sample.StudentArtProgramAssociation,
        Entities.Common.Sample.IStudentArtProgramAssociation,
        Entities.NHibernate.StudentArtProgramAssociationAggregate.Sample.StudentArtProgramAssociation,
        Api.Common.Models.Requests.Sample.StudentArtProgramAssociations.StudentArtProgramAssociationPut,
        Api.Common.Models.Requests.Sample.StudentArtProgramAssociations.StudentArtProgramAssociationPost,
        Api.Common.Models.Requests.Sample.StudentArtProgramAssociations.StudentArtProgramAssociationDelete,
        Api.Common.Models.Requests.Sample.StudentArtProgramAssociations.StudentArtProgramAssociationGetByExample>
    {
        public StudentArtProgramAssociationsController(IPipelineFactory pipelineFactory, IEdFiProblemDetailsProvider problemDetailsProvider, IDefaultPageSizeLimitProvider defaultPageSizeLimitProvider, ApiSettings apiSettings, IContextProvider<ProfileContentTypeContext> profileContentTypeContextProvider, IContextProvider<DataManagementResourceContext> dataManagementResourceContextProvider, ILogContextAccessor logContextAccessor)
            : base(pipelineFactory, problemDetailsProvider, defaultPageSizeLimitProvider, apiSettings, profileContentTypeContextProvider, dataManagementResourceContextProvider, logContextAccessor)
        {
        }

        protected override void MapAll(Api.Common.Models.Requests.Sample.StudentArtProgramAssociations.StudentArtProgramAssociationGetByExample request, Entities.Common.Sample.IStudentArtProgramAssociation specification)
        {
            // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ArtPieces = request.ArtPieces;
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EndDate = request.EndDate;
            specification.ExhibitDate = request.ExhibitDate;
            specification.HoursPerDay = request.HoursPerDay;
            specification.Id = request.Id;
            specification.IdentificationCode = request.IdentificationCode;
            specification.KilnReservation = request.KilnReservation;
            specification.KilnReservationLength = request.KilnReservationLength;
            specification.MasteredMediums = request.MasteredMediums;
            specification.NumberOfDaysInAttendance = request.NumberOfDaysInAttendance;
            specification.PortfolioPieces = request.PortfolioPieces;
            specification.PrivateArtProgram = request.PrivateArtProgram;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramFees = request.ProgramFees;
            specification.ProgramName = request.ProgramName;
            specification.ProgramTypeDescriptor = request.ProgramTypeDescriptor;
            specification.ReasonExitedDescriptor = request.ReasonExitedDescriptor;
            specification.ServedOutsideOfRegularSession = request.ServedOutsideOfRegularSession;
            specification.StudentUniqueId = request.StudentUniqueId;
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.Sample.StudentGraduationPlanAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ExcludeFromCodeCoverage]
    [ApiController]
    [Authorize]
    [ApplyOdsRouteRootTemplate, Route($"{RouteConstants.DataManagementRoutePrefix}/sample/studentGraduationPlanAssociations")]
    public partial class StudentGraduationPlanAssociationsController : DataManagementControllerBase<
        Api.Common.Models.Resources.StudentGraduationPlanAssociation.Sample.StudentGraduationPlanAssociation,
        Entities.Common.Sample.IStudentGraduationPlanAssociation,
        Entities.NHibernate.StudentGraduationPlanAssociationAggregate.Sample.StudentGraduationPlanAssociation,
        Api.Common.Models.Requests.Sample.StudentGraduationPlanAssociations.StudentGraduationPlanAssociationPut,
        Api.Common.Models.Requests.Sample.StudentGraduationPlanAssociations.StudentGraduationPlanAssociationPost,
        Api.Common.Models.Requests.Sample.StudentGraduationPlanAssociations.StudentGraduationPlanAssociationDelete,
        Api.Common.Models.Requests.Sample.StudentGraduationPlanAssociations.StudentGraduationPlanAssociationGetByExample>
    {
        public StudentGraduationPlanAssociationsController(IPipelineFactory pipelineFactory, IEdFiProblemDetailsProvider problemDetailsProvider, IDefaultPageSizeLimitProvider defaultPageSizeLimitProvider, ApiSettings apiSettings, IContextProvider<ProfileContentTypeContext> profileContentTypeContextProvider, IContextProvider<DataManagementResourceContext> dataManagementResourceContextProvider, ILogContextAccessor logContextAccessor)
            : base(pipelineFactory, problemDetailsProvider, defaultPageSizeLimitProvider, apiSettings, profileContentTypeContextProvider, dataManagementResourceContextProvider, logContextAccessor)
        {
        }

        protected override void MapAll(Api.Common.Models.Requests.Sample.StudentGraduationPlanAssociations.StudentGraduationPlanAssociationGetByExample request, Entities.Common.Sample.IStudentGraduationPlanAssociation specification)
        {
            // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CommencementTime = request.CommencementTime;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EffectiveDate = request.EffectiveDate;
            specification.GraduationFee = request.GraduationFee;
            specification.GraduationPlanTypeDescriptor = request.GraduationPlanTypeDescriptor;
            specification.GraduationSchoolYear = request.GraduationSchoolYear;
            specification.HighSchoolDuration = request.HighSchoolDuration;
            specification.HoursPerWeek = request.HoursPerWeek;
            specification.Id = request.Id;
            specification.IsActivePlan = request.IsActivePlan;
            specification.RequiredAttendance = request.RequiredAttendance;
            specification.StaffUniqueId = request.StaffUniqueId;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TargetGPA = request.TargetGPA;
        }
    }
}
