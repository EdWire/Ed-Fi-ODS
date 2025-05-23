-- SPDX-License-Identifier: Apache-2.0
-- Licensed to the Ed-Fi Alliance under one or more agreements.
-- The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
-- See the LICENSE and NOTICES files in the project root for more information.

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.AcademicWeek') AND name = N'UX_AcademicWeek_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_AcademicWeek_Id ON [edfi].[AcademicWeek]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.AccountabilityRating') AND name = N'UX_AccountabilityRating_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_AccountabilityRating_Id ON [edfi].[AccountabilityRating]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Assessment') AND name = N'UX_Assessment_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Assessment_Id ON [edfi].[Assessment]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.AssessmentAdministration') AND name = N'UX_AssessmentAdministration_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_AssessmentAdministration_Id ON [edfi].[AssessmentAdministration]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.AssessmentAdministrationParticipation') AND name = N'UX_AssessmentAdministrationParticipation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_AssessmentAdministrationParticipation_Id ON [edfi].[AssessmentAdministrationParticipation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.AssessmentBatteryPart') AND name = N'UX_AssessmentBatteryPart_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_AssessmentBatteryPart_Id ON [edfi].[AssessmentBatteryPart]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.AssessmentItem') AND name = N'UX_AssessmentItem_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_AssessmentItem_Id ON [edfi].[AssessmentItem]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.AssessmentScoreRangeLearningStandard') AND name = N'UX_AssessmentScoreRangeLearningStandard_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_AssessmentScoreRangeLearningStandard_Id ON [edfi].[AssessmentScoreRangeLearningStandard]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.BalanceSheetDimension') AND name = N'UX_BalanceSheetDimension_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_BalanceSheetDimension_Id ON [edfi].[BalanceSheetDimension]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.BellSchedule') AND name = N'UX_BellSchedule_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_BellSchedule_Id ON [edfi].[BellSchedule]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Calendar') AND name = N'UX_Calendar_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Calendar_Id ON [edfi].[Calendar]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.CalendarDate') AND name = N'UX_CalendarDate_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_CalendarDate_Id ON [edfi].[CalendarDate]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ChartOfAccount') AND name = N'UX_ChartOfAccount_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ChartOfAccount_Id ON [edfi].[ChartOfAccount]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ClassPeriod') AND name = N'UX_ClassPeriod_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ClassPeriod_Id ON [edfi].[ClassPeriod]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Cohort') AND name = N'UX_Cohort_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Cohort_Id ON [edfi].[Cohort]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.CommunityProviderLicense') AND name = N'UX_CommunityProviderLicense_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_CommunityProviderLicense_Id ON [edfi].[CommunityProviderLicense]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.CompetencyObjective') AND name = N'UX_CompetencyObjective_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_CompetencyObjective_Id ON [edfi].[CompetencyObjective]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Contact') AND name = N'UX_Contact_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Contact_Id ON [edfi].[Contact]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Course') AND name = N'UX_Course_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Course_Id ON [edfi].[Course]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.CourseOffering') AND name = N'UX_CourseOffering_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_CourseOffering_Id ON [edfi].[CourseOffering]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.CourseTranscript') AND name = N'UX_CourseTranscript_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_CourseTranscript_Id ON [edfi].[CourseTranscript]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Credential') AND name = N'UX_Credential_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Credential_Id ON [edfi].[Credential]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.CrisisEvent') AND name = N'UX_CrisisEvent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_CrisisEvent_Id ON [edfi].[CrisisEvent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Descriptor') AND name = N'UX_Descriptor_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Descriptor_Id ON [edfi].[Descriptor]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.DescriptorMapping') AND name = N'UX_DescriptorMapping_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_DescriptorMapping_Id ON [edfi].[DescriptorMapping]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.DisciplineAction') AND name = N'UX_DisciplineAction_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_DisciplineAction_Id ON [edfi].[DisciplineAction]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.DisciplineIncident') AND name = N'UX_DisciplineIncident_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_DisciplineIncident_Id ON [edfi].[DisciplineIncident]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.EducationContent') AND name = N'UX_EducationContent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_EducationContent_Id ON [edfi].[EducationContent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.EducationOrganization') AND name = N'UX_EducationOrganization_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_EducationOrganization_Id ON [edfi].[EducationOrganization]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.EducationOrganizationInterventionPrescriptionAssociation') AND name = N'UX_EducationOrganizationInterventionPrescriptionAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_EducationOrganizationInterventionPrescriptionAssociation_Id ON [edfi].[EducationOrganizationInterventionPrescriptionAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.EducationOrganizationNetworkAssociation') AND name = N'UX_EducationOrganizationNetworkAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_EducationOrganizationNetworkAssociation_Id ON [edfi].[EducationOrganizationNetworkAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.EducationOrganizationPeerAssociation') AND name = N'UX_EducationOrganizationPeerAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_EducationOrganizationPeerAssociation_Id ON [edfi].[EducationOrganizationPeerAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.EvaluationRubricDimension') AND name = N'UX_EvaluationRubricDimension_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_EvaluationRubricDimension_Id ON [edfi].[EvaluationRubricDimension]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.FeederSchoolAssociation') AND name = N'UX_FeederSchoolAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_FeederSchoolAssociation_Id ON [edfi].[FeederSchoolAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.FunctionDimension') AND name = N'UX_FunctionDimension_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_FunctionDimension_Id ON [edfi].[FunctionDimension]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.FundDimension') AND name = N'UX_FundDimension_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_FundDimension_Id ON [edfi].[FundDimension]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.GeneralStudentProgramAssociation') AND name = N'UX_GeneralStudentProgramAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_GeneralStudentProgramAssociation_Id ON [edfi].[GeneralStudentProgramAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Grade') AND name = N'UX_Grade_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Grade_Id ON [edfi].[Grade]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.GradebookEntry') AND name = N'UX_GradebookEntry_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_GradebookEntry_Id ON [edfi].[GradebookEntry]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.GradingPeriod') AND name = N'UX_GradingPeriod_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_GradingPeriod_Id ON [edfi].[GradingPeriod]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.GraduationPlan') AND name = N'UX_GraduationPlan_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_GraduationPlan_Id ON [edfi].[GraduationPlan]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Intervention') AND name = N'UX_Intervention_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Intervention_Id ON [edfi].[Intervention]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.InterventionPrescription') AND name = N'UX_InterventionPrescription_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_InterventionPrescription_Id ON [edfi].[InterventionPrescription]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.InterventionStudy') AND name = N'UX_InterventionStudy_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_InterventionStudy_Id ON [edfi].[InterventionStudy]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.LearningStandard') AND name = N'UX_LearningStandard_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_LearningStandard_Id ON [edfi].[LearningStandard]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.LearningStandardEquivalenceAssociation') AND name = N'UX_LearningStandardEquivalenceAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_LearningStandardEquivalenceAssociation_Id ON [edfi].[LearningStandardEquivalenceAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.LocalAccount') AND name = N'UX_LocalAccount_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_LocalAccount_Id ON [edfi].[LocalAccount]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.LocalActual') AND name = N'UX_LocalActual_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_LocalActual_Id ON [edfi].[LocalActual]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.LocalBudget') AND name = N'UX_LocalBudget_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_LocalBudget_Id ON [edfi].[LocalBudget]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.LocalContractedStaff') AND name = N'UX_LocalContractedStaff_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_LocalContractedStaff_Id ON [edfi].[LocalContractedStaff]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.LocalEncumbrance') AND name = N'UX_LocalEncumbrance_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_LocalEncumbrance_Id ON [edfi].[LocalEncumbrance]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.LocalPayroll') AND name = N'UX_LocalPayroll_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_LocalPayroll_Id ON [edfi].[LocalPayroll]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Location') AND name = N'UX_Location_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Location_Id ON [edfi].[Location]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ObjectDimension') AND name = N'UX_ObjectDimension_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ObjectDimension_Id ON [edfi].[ObjectDimension]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ObjectiveAssessment') AND name = N'UX_ObjectiveAssessment_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ObjectiveAssessment_Id ON [edfi].[ObjectiveAssessment]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.OpenStaffPosition') AND name = N'UX_OpenStaffPosition_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_OpenStaffPosition_Id ON [edfi].[OpenStaffPosition]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.OperationalUnitDimension') AND name = N'UX_OperationalUnitDimension_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_OperationalUnitDimension_Id ON [edfi].[OperationalUnitDimension]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Person') AND name = N'UX_Person_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Person_Id ON [edfi].[Person]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.PostSecondaryEvent') AND name = N'UX_PostSecondaryEvent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_PostSecondaryEvent_Id ON [edfi].[PostSecondaryEvent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Program') AND name = N'UX_Program_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Program_Id ON [edfi].[Program]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ProgramDimension') AND name = N'UX_ProgramDimension_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ProgramDimension_Id ON [edfi].[ProgramDimension]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ProgramEvaluation') AND name = N'UX_ProgramEvaluation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ProgramEvaluation_Id ON [edfi].[ProgramEvaluation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ProgramEvaluationElement') AND name = N'UX_ProgramEvaluationElement_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ProgramEvaluationElement_Id ON [edfi].[ProgramEvaluationElement]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ProgramEvaluationObjective') AND name = N'UX_ProgramEvaluationObjective_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ProgramEvaluationObjective_Id ON [edfi].[ProgramEvaluationObjective]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ProjectDimension') AND name = N'UX_ProjectDimension_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ProjectDimension_Id ON [edfi].[ProjectDimension]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.ReportCard') AND name = N'UX_ReportCard_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_ReportCard_Id ON [edfi].[ReportCard]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.RestraintEvent') AND name = N'UX_RestraintEvent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_RestraintEvent_Id ON [edfi].[RestraintEvent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SchoolYearType') AND name = N'UX_SchoolYearType_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SchoolYearType_Id ON [edfi].[SchoolYearType]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 100, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Section') AND name = N'UX_Section_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Section_Id ON [edfi].[Section]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SectionAttendanceTakenEvent') AND name = N'UX_SectionAttendanceTakenEvent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SectionAttendanceTakenEvent_Id ON [edfi].[SectionAttendanceTakenEvent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Session') AND name = N'UX_Session_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Session_Id ON [edfi].[Session]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SourceDimension') AND name = N'UX_SourceDimension_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SourceDimension_Id ON [edfi].[SourceDimension]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Staff') AND name = N'UX_Staff_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Staff_Id ON [edfi].[Staff]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffAbsenceEvent') AND name = N'UX_StaffAbsenceEvent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffAbsenceEvent_Id ON [edfi].[StaffAbsenceEvent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffCohortAssociation') AND name = N'UX_StaffCohortAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffCohortAssociation_Id ON [edfi].[StaffCohortAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffDisciplineIncidentAssociation') AND name = N'UX_StaffDisciplineIncidentAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffDisciplineIncidentAssociation_Id ON [edfi].[StaffDisciplineIncidentAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffEducationOrganizationAssignmentAssociation') AND name = N'UX_StaffEducationOrganizationAssignmentAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffEducationOrganizationAssignmentAssociation_Id ON [edfi].[StaffEducationOrganizationAssignmentAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffEducationOrganizationContactAssociation') AND name = N'UX_StaffEducationOrganizationContactAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffEducationOrganizationContactAssociation_Id ON [edfi].[StaffEducationOrganizationContactAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffEducationOrganizationEmploymentAssociation') AND name = N'UX_StaffEducationOrganizationEmploymentAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffEducationOrganizationEmploymentAssociation_Id ON [edfi].[StaffEducationOrganizationEmploymentAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffLeave') AND name = N'UX_StaffLeave_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffLeave_Id ON [edfi].[StaffLeave]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffProgramAssociation') AND name = N'UX_StaffProgramAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffProgramAssociation_Id ON [edfi].[StaffProgramAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffSchoolAssociation') AND name = N'UX_StaffSchoolAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffSchoolAssociation_Id ON [edfi].[StaffSchoolAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StaffSectionAssociation') AND name = N'UX_StaffSectionAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StaffSectionAssociation_Id ON [edfi].[StaffSectionAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Student') AND name = N'UX_Student_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Student_Id ON [edfi].[Student]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentAcademicRecord') AND name = N'UX_StudentAcademicRecord_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentAcademicRecord_Id ON [edfi].[StudentAcademicRecord]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentAssessment') AND name = N'UX_StudentAssessment_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentAssessment_Id ON [edfi].[StudentAssessment]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentAssessmentEducationOrganizationAssociation') AND name = N'UX_StudentAssessmentEducationOrganizationAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentAssessmentEducationOrganizationAssociation_Id ON [edfi].[StudentAssessmentEducationOrganizationAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentAssessmentRegistration') AND name = N'UX_StudentAssessmentRegistration_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentAssessmentRegistration_Id ON [edfi].[StudentAssessmentRegistration]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentAssessmentRegistrationBatteryPartAssociation') AND name = N'UX_StudentAssessmentRegistrationBatteryPartAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentAssessmentRegistrationBatteryPartAssociation_Id ON [edfi].[StudentAssessmentRegistrationBatteryPartAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentCohortAssociation') AND name = N'UX_StudentCohortAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentCohortAssociation_Id ON [edfi].[StudentCohortAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentCompetencyObjective') AND name = N'UX_StudentCompetencyObjective_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentCompetencyObjective_Id ON [edfi].[StudentCompetencyObjective]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentContactAssociation') AND name = N'UX_StudentContactAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentContactAssociation_Id ON [edfi].[StudentContactAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentDisciplineIncidentBehaviorAssociation') AND name = N'UX_StudentDisciplineIncidentBehaviorAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentDisciplineIncidentBehaviorAssociation_Id ON [edfi].[StudentDisciplineIncidentBehaviorAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentDisciplineIncidentNonOffenderAssociation') AND name = N'UX_StudentDisciplineIncidentNonOffenderAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentDisciplineIncidentNonOffenderAssociation_Id ON [edfi].[StudentDisciplineIncidentNonOffenderAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentEducationOrganizationAssessmentAccommodation') AND name = N'UX_StudentEducationOrganizationAssessmentAccommodation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentEducationOrganizationAssessmentAccommodation_Id ON [edfi].[StudentEducationOrganizationAssessmentAccommodation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentEducationOrganizationAssociation') AND name = N'UX_StudentEducationOrganizationAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentEducationOrganizationAssociation_Id ON [edfi].[StudentEducationOrganizationAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentEducationOrganizationResponsibilityAssociation') AND name = N'UX_StudentEducationOrganizationResponsibilityAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentEducationOrganizationResponsibilityAssociation_Id ON [edfi].[StudentEducationOrganizationResponsibilityAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentGradebookEntry') AND name = N'UX_StudentGradebookEntry_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentGradebookEntry_Id ON [edfi].[StudentGradebookEntry]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentHealth') AND name = N'UX_StudentHealth_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentHealth_Id ON [edfi].[StudentHealth]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentInterventionAssociation') AND name = N'UX_StudentInterventionAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentInterventionAssociation_Id ON [edfi].[StudentInterventionAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentInterventionAttendanceEvent') AND name = N'UX_StudentInterventionAttendanceEvent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentInterventionAttendanceEvent_Id ON [edfi].[StudentInterventionAttendanceEvent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentProgramAttendanceEvent') AND name = N'UX_StudentProgramAttendanceEvent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentProgramAttendanceEvent_Id ON [edfi].[StudentProgramAttendanceEvent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentProgramEvaluation') AND name = N'UX_StudentProgramEvaluation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentProgramEvaluation_Id ON [edfi].[StudentProgramEvaluation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentSchoolAssociation') AND name = N'UX_StudentSchoolAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentSchoolAssociation_Id ON [edfi].[StudentSchoolAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentSchoolAttendanceEvent') AND name = N'UX_StudentSchoolAttendanceEvent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentSchoolAttendanceEvent_Id ON [edfi].[StudentSchoolAttendanceEvent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentSectionAssociation') AND name = N'UX_StudentSectionAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentSectionAssociation_Id ON [edfi].[StudentSectionAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentSectionAttendanceEvent') AND name = N'UX_StudentSectionAttendanceEvent_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentSectionAttendanceEvent_Id ON [edfi].[StudentSectionAttendanceEvent]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentSpecialEducationProgramEligibilityAssociation') AND name = N'UX_StudentSpecialEducationProgramEligibilityAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentSpecialEducationProgramEligibilityAssociation_Id ON [edfi].[StudentSpecialEducationProgramEligibilityAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.StudentTransportation') AND name = N'UX_StudentTransportation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_StudentTransportation_Id ON [edfi].[StudentTransportation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.Survey') AND name = N'UX_Survey_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_Survey_Id ON [edfi].[Survey]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveyCourseAssociation') AND name = N'UX_SurveyCourseAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveyCourseAssociation_Id ON [edfi].[SurveyCourseAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveyProgramAssociation') AND name = N'UX_SurveyProgramAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveyProgramAssociation_Id ON [edfi].[SurveyProgramAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveyQuestion') AND name = N'UX_SurveyQuestion_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveyQuestion_Id ON [edfi].[SurveyQuestion]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveyQuestionResponse') AND name = N'UX_SurveyQuestionResponse_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveyQuestionResponse_Id ON [edfi].[SurveyQuestionResponse]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveyResponse') AND name = N'UX_SurveyResponse_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveyResponse_Id ON [edfi].[SurveyResponse]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveyResponseEducationOrganizationTargetAssociation') AND name = N'UX_SurveyResponseEducationOrganizationTargetAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveyResponseEducationOrganizationTargetAssociation_Id ON [edfi].[SurveyResponseEducationOrganizationTargetAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveyResponseStaffTargetAssociation') AND name = N'UX_SurveyResponseStaffTargetAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveyResponseStaffTargetAssociation_Id ON [edfi].[SurveyResponseStaffTargetAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveySection') AND name = N'UX_SurveySection_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveySection_Id ON [edfi].[SurveySection]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveySectionAssociation') AND name = N'UX_SurveySectionAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveySectionAssociation_Id ON [edfi].[SurveySectionAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveySectionResponse') AND name = N'UX_SurveySectionResponse_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveySectionResponse_Id ON [edfi].[SurveySectionResponse]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveySectionResponseEducationOrganizationTargetAssociation') AND name = N'UX_SurveySectionResponseEducationOrganizationTargetAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveySectionResponseEducationOrganizationTargetAssociation_Id ON [edfi].[SurveySectionResponseEducationOrganizationTargetAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

BEGIN TRANSACTION
    IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'edfi.SurveySectionResponseStaffTargetAssociation') AND name = N'UX_SurveySectionResponseStaffTargetAssociation_Id')
    CREATE UNIQUE NONCLUSTERED INDEX UX_SurveySectionResponseStaffTargetAssociation_Id ON [edfi].[SurveySectionResponseStaffTargetAssociation]
    (Id) WITH (PAD_INDEX = ON, FILLFACTOR = 75, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY]
    GO
COMMIT

