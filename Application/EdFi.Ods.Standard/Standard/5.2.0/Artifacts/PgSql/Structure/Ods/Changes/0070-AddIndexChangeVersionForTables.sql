-- SPDX-License-Identifier: Apache-2.0
-- Licensed to the Ed-Fi Alliance under one or more agreements.
-- The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
-- See the LICENSE and NOTICES files in the project root for more information.

CREATE INDEX IF NOT EXISTS UX_a97956_ChangeVersion ON edfi.AcademicWeek(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_2d3c0c_ChangeVersion ON edfi.AccountabilityRating(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_7808ee_ChangeVersion ON edfi.Assessment(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_c64558_ChangeVersion ON edfi.AssessmentAdministration(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_77818e_ChangeVersion ON edfi.AssessmentAdministrationParticipation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_6e22f2_ChangeVersion ON edfi.AssessmentBatteryPart(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_dc3dcf_ChangeVersion ON edfi.AssessmentItem(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_a20588_ChangeVersion ON edfi.AssessmentScoreRangeLearningStandard(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_e52c9c_ChangeVersion ON edfi.BalanceSheetDimension(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_9bbaf5_ChangeVersion ON edfi.BellSchedule(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_d5d0a3_ChangeVersion ON edfi.Calendar(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_8a9a67_ChangeVersion ON edfi.CalendarDate(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_131e2b_ChangeVersion ON edfi.ChartOfAccount(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_01fe80_ChangeVersion ON edfi.ClassPeriod(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_19c6d6_ChangeVersion ON edfi.Cohort(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_f092ff_ChangeVersion ON edfi.CommunityProviderLicense(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_5e9932_ChangeVersion ON edfi.CompetencyObjective(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_2b5c3d_ChangeVersion ON edfi.Contact(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_2096ce_ChangeVersion ON edfi.Course(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_0325c5_ChangeVersion ON edfi.CourseOffering(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_6acf2b_ChangeVersion ON edfi.CourseTranscript(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_b1c42b_ChangeVersion ON edfi.Credential(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_f1bbb4_ChangeVersion ON edfi.CrisisEvent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_219915_ChangeVersion ON edfi.Descriptor(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_ee9047_ChangeVersion ON edfi.DescriptorMapping(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_eec7b6_ChangeVersion ON edfi.DisciplineAction(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_e45c0b_ChangeVersion ON edfi.DisciplineIncident(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_9965a5_ChangeVersion ON edfi.EducationContent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_4525e6_ChangeVersion ON edfi.EducationOrganization(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_e670ae_ChangeVersion ON edfi.EducationOrganizationInterventionPrescriptionAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_252151_ChangeVersion ON edfi.EducationOrganizationNetworkAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_74e4e5_ChangeVersion ON edfi.EducationOrganizationPeerAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_1b7ccf_ChangeVersion ON edfi.EvaluationRubricDimension(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_11f7b6_ChangeVersion ON edfi.FeederSchoolAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_c4d12e_ChangeVersion ON edfi.FunctionDimension(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_937af8_ChangeVersion ON edfi.FundDimension(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_0516f9_ChangeVersion ON edfi.GeneralStudentProgramAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_839e20_ChangeVersion ON edfi.Grade(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_466cfa_ChangeVersion ON edfi.GradebookEntry(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_5a18f9_ChangeVersion ON edfi.GradingPeriod(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_be1ea4_ChangeVersion ON edfi.GraduationPlan(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_0fae05_ChangeVersion ON edfi.Intervention(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_e93bc3_ChangeVersion ON edfi.InterventionPrescription(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_d92986_ChangeVersion ON edfi.InterventionStudy(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_8ceb4c_ChangeVersion ON edfi.LearningStandard(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_17c02a_ChangeVersion ON edfi.LearningStandardEquivalenceAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_32eddb_ChangeVersion ON edfi.LocalAccount(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_b6310e_ChangeVersion ON edfi.LocalActual(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_000683_ChangeVersion ON edfi.LocalBudget(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_4d9b4a_ChangeVersion ON edfi.LocalContractedStaff(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_ea526f_ChangeVersion ON edfi.LocalEncumbrance(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_46e5c2_ChangeVersion ON edfi.LocalPayroll(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_15b619_ChangeVersion ON edfi.Location(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_4100ee_ChangeVersion ON edfi.ObjectDimension(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_269e10_ChangeVersion ON edfi.ObjectiveAssessment(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_3cc1d4_ChangeVersion ON edfi.OpenStaffPosition(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_28b7c4_ChangeVersion ON edfi.OperationalUnitDimension(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_6007db_ChangeVersion ON edfi.Person(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_b8b6d7_ChangeVersion ON edfi.PostSecondaryEvent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_90920d_ChangeVersion ON edfi.Program(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_a9a613_ChangeVersion ON edfi.ProgramDimension(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_f3a20e_ChangeVersion ON edfi.ProgramEvaluation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_784616_ChangeVersion ON edfi.ProgramEvaluationElement(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_a53c6c_ChangeVersion ON edfi.ProgramEvaluationObjective(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_d16e19_ChangeVersion ON edfi.ProjectDimension(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_ec1992_ChangeVersion ON edfi.ReportCard(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_3800be_ChangeVersion ON edfi.RestraintEvent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_464d7a_ChangeVersion ON edfi.SchoolYearType(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_dfca5d_ChangeVersion ON edfi.Section(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_7bbbe7_ChangeVersion ON edfi.SectionAttendanceTakenEvent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_6959b4_ChangeVersion ON edfi.Session(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_e91a4d_ChangeVersion ON edfi.SourceDimension(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_681927_ChangeVersion ON edfi.Staff(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_b13bbd_ChangeVersion ON edfi.StaffAbsenceEvent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_170747_ChangeVersion ON edfi.StaffCohortAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_af86db_ChangeVersion ON edfi.StaffDisciplineIncidentAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_b9be24_ChangeVersion ON edfi.StaffEducationOrganizationAssignmentAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_735dd8_ChangeVersion ON edfi.StaffEducationOrganizationContactAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_4e79b9_ChangeVersion ON edfi.StaffEducationOrganizationEmploymentAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_debd4f_ChangeVersion ON edfi.StaffLeave(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_a9c0d9_ChangeVersion ON edfi.StaffProgramAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_ce2080_ChangeVersion ON edfi.StaffSchoolAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_515cb5_ChangeVersion ON edfi.StaffSectionAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_2a164d_ChangeVersion ON edfi.Student(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_0ff8d6_ChangeVersion ON edfi.StudentAcademicRecord(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_ee3b2a_ChangeVersion ON edfi.StudentAssessment(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_afb8b8_ChangeVersion ON edfi.StudentAssessmentEducationOrganizationAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_79fd6b_ChangeVersion ON edfi.StudentAssessmentRegistration(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_3bb369_ChangeVersion ON edfi.StudentAssessmentRegistrationBatteryPartAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_369ddc_ChangeVersion ON edfi.StudentCohortAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_395c07_ChangeVersion ON edfi.StudentCompetencyObjective(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_e2733e_ChangeVersion ON edfi.StudentContactAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_f4934f_ChangeVersion ON edfi.StudentDisciplineIncidentBehaviorAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_4b43da_ChangeVersion ON edfi.StudentDisciplineIncidentNonOffenderAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_5f4481_ChangeVersion ON edfi.StudentEducationOrganizationAssessmentAccommodation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_8e1257_ChangeVersion ON edfi.StudentEducationOrganizationAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_42aa64_ChangeVersion ON edfi.StudentEducationOrganizationResponsibilityAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_c2efaa_ChangeVersion ON edfi.StudentGradebookEntry(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_12f7e6_ChangeVersion ON edfi.StudentHealth(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_25cb9c_ChangeVersion ON edfi.StudentInterventionAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_631023_ChangeVersion ON edfi.StudentInterventionAttendanceEvent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_317aeb_ChangeVersion ON edfi.StudentProgramAttendanceEvent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_4b1054_ChangeVersion ON edfi.StudentProgramEvaluation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_857b52_ChangeVersion ON edfi.StudentSchoolAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_78fd7f_ChangeVersion ON edfi.StudentSchoolAttendanceEvent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_39aa3c_ChangeVersion ON edfi.StudentSectionAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_61b087_ChangeVersion ON edfi.StudentSectionAttendanceEvent(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_fcb699_ChangeVersion ON edfi.StudentSpecialEducationProgramEligibilityAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_68afad_ChangeVersion ON edfi.StudentTransportation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_211bb3_ChangeVersion ON edfi.Survey(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_9f1246_ChangeVersion ON edfi.SurveyCourseAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_e3e5a4_ChangeVersion ON edfi.SurveyProgramAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_1bb88c_ChangeVersion ON edfi.SurveyQuestion(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_eddd02_ChangeVersion ON edfi.SurveyQuestionResponse(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_8d6383_ChangeVersion ON edfi.SurveyResponse(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_b2bd0a_ChangeVersion ON edfi.SurveyResponseEducationOrganizationTargetAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_f9457e_ChangeVersion ON edfi.SurveyResponseStaffTargetAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_e5572a_ChangeVersion ON edfi.SurveySection(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_c16804_ChangeVersion ON edfi.SurveySectionAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_2189c3_ChangeVersion ON edfi.SurveySectionResponse(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_730be1_ChangeVersion ON edfi.SurveySectionResponseEducationOrganizationTargetAssociation(ChangeVersion);

CREATE INDEX IF NOT EXISTS UX_39073d_ChangeVersion ON edfi.SurveySectionResponseStaffTargetAssociation(ChangeVersion);

