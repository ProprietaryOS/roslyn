﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CodeFixes
{
    internal static class PredefinedCodeFixProviderNames
    {
        public const string AddAccessibilityModifiers = nameof(AddAccessibilityModifiers);
        public const string AddAnonymousTypeMemberName = nameof(AddAnonymousTypeMemberName);
        public const string AddAsync = nameof(AddAsync);
        public const string AddBraces = nameof(AddBraces);
        public const string AddDocCommentNodes = nameof(AddDocCommentNodes);
        public const string AddExplicitCast = nameof(AddExplicitCast);
        public const string AddInheritdoc = nameof(AddInheritdoc);
        public const string AddImport = nameof(AddImport);
        public const string AddMissingReference = nameof(AddMissingReference);
        public const string AddNew = nameof(AddNew);
        public const string AddObsoleteAttribute = nameof(AddObsoleteAttribute);
        public const string AddOverloads = nameof(AddOverloads);
        public const string AddPackage = nameof(AddPackage);
        public const string AddParameter = nameof(AddParameter);
        public const string AddParenthesesAroundConditionalExpressionInInterpolatedString = nameof(AddParenthesesAroundConditionalExpressionInInterpolatedString);
        public const string AddRequiredParentheses = nameof(AddRequiredParentheses);
        public const string AliasAmbiguousType = nameof(AliasAmbiguousType);
        public const string ApplyNamingStyle = nameof(ApplyNamingStyle);
        public const string ArrowExpressionClausePlacement = nameof(ArrowExpressionClausePlacement);
        public const string AssignOutParametersAboveReturn = nameof(AssignOutParametersAboveReturn);
        public const string AssignOutParametersAtStart = nameof(AssignOutParametersAtStart);
        public const string ChangeNamespaceToMatchFolder = nameof(ChangeNamespaceToMatchFolder);
        public const string ChangeReturnType = nameof(ChangeReturnType);
        public const string ChangeToYield = nameof(ChangeToYield);
        public const string ConditionalExpressionPlacement = nameof(ConditionalExpressionPlacement);
        public const string ConflictMarkerResolution = nameof(ConflictMarkerResolution);
        public const string ConsecutiveBracePlacement = nameof(ConsecutiveBracePlacement);
        public const string ConsecutiveStatementPlacement = nameof(ConsecutiveStatementPlacement);
        public const string ConstructorInitializerPlacement = nameof(ConstructorInitializerPlacement);
        public const string ConvertNamespace = nameof(ConvertNamespace);
        public const string ConvertToProgramMain = nameof(ConvertToProgramMain);
        public const string ConvertSwitchStatementToExpression = nameof(ConvertSwitchStatementToExpression);
        public const string ConvertToAsync = nameof(ConvertToAsync);
        public const string ConvertToIterator = nameof(ConvertToIterator);
        public const string ConvertToRecord = nameof(ConvertToRecord);
        public const string ConvertToTopLevelStatements = nameof(ConvertToTopLevelStatements);
        public const string ConvertTypeOfToNameOf = nameof(ConvertTypeOfToNameOf);
        public const string CorrectNextControlVariable = nameof(CorrectNextControlVariable);
        public const string DeclareAsNullable = nameof(DeclareAsNullable);
        public const string DisambiguateSameVariable = nameof(DisambiguateSameVariable);
        public const string EmbeddedStatementPlacement = nameof(EmbeddedStatementPlacement);
        public const string FileHeader = nameof(FileHeader);
        public const string FixFormatting = nameof(FixFormatting);
        public const string FixIncorrectConstraint = nameof(FixIncorrectConstraint);
        public const string FixIncorrectExitContinue = nameof(FixIncorrectExitContinue);
        public const string FixIncorrectFunctionReturnType = nameof(FixIncorrectFunctionReturnType);
        public const string FixReturnType = nameof(FixReturnType);
        public const string ForEachCast = nameof(ForEachCast);
        public const string FullyQualify = nameof(FullyQualify);
        public const string GenerateConstructor = nameof(GenerateConstructor);
        public const string GenerateConversion = nameof(GenerateConversion);
        public const string GenerateDeconstructMethod = nameof(GenerateDeconstructMethod);
        public const string GenerateDefaultConstructors = nameof(GenerateDefaultConstructors);
        public const string GenerateEndConstruct = nameof(GenerateEndConstruct);
        public const string GenerateEnumMember = nameof(GenerateEnumMember);
        public const string GenerateEvent = nameof(GenerateEvent);
        public const string GenerateMethod = nameof(GenerateMethod);
        public const string GenerateType = nameof(GenerateType);
        public const string GenerateVariable = nameof(GenerateVariable);
        public const string ImplementAbstractClass = nameof(ImplementAbstractClass);
        public const string ImplementInterface = nameof(ImplementInterface);
        public const string InlineDeclaration = nameof(InlineDeclaration);
        public const string InvokeDelegateWithConditionalAccess = nameof(InvokeDelegateWithConditionalAccess);
        public const string JsonDetection = nameof(JsonDetection);
        public const string MakeFieldReadonly = nameof(MakeFieldReadonly);
        public const string MakeLocalFunctionStatic = nameof(MakeLocalFunctionStatic);
        public const string MakeMemberStatic = nameof(MakeMemberStatic);
        public const string MakeMethodSynchronous = nameof(MakeMethodSynchronous);
        public const string MakeRefStruct = nameof(MakeRefStruct);
        public const string MakeStatementAsynchronous = nameof(MakeStatementAsynchronous);
        public const string MakeStructFieldsWritable = nameof(MakeStructFieldsWritable);
        public const string MakeStructReadOnly = nameof(MakeStructReadOnly);
        public const string MakeTypeAbstract = nameof(MakeTypeAbstract);
        public const string MoveMisplacedUsingDirectives = nameof(MoveMisplacedUsingDirectives);
        public const string MoveToTopOfFile = nameof(MoveToTopOfFile);
        public const string OrderModifiers = nameof(OrderModifiers);
        public const string PassInCapturedVariables = nameof(PassInCapturedVariables);
        public const string PopulateSwitch = nameof(PopulateSwitch);
        public const string PopulateSwitchExpression = nameof(PopulateSwitchExpression);
        public const string PreferFrameworkType = nameof(PreferFrameworkType);
        public const string QualifyMemberAccess = nameof(QualifyMemberAccess);
        public const string RemoveAsyncModifier = nameof(RemoveAsyncModifier);
        public const string RemoveBlankLines = nameof(RemoveBlankLines);
        public const string RemoveConfusingSuppression = nameof(RemoveConfusingSuppression);
        public const string RemoveDocCommentNode = nameof(RemoveDocCommentNode);
        public const string RemoveIn = nameof(RemoveIn);
        public const string RemoveNew = nameof(RemoveNew);
        public const string RemoveRedundantEquality = nameof(RemoveRedundantEquality);
        public const string RemoveSharedFromModuleMembers = nameof(RemoveSharedFromModuleMembers);
        public const string RemoveUnnecessaryAttributeSuppressions = nameof(RemoveUnnecessaryAttributeSuppressions);
        public const string RemoveUnnecessaryByVal = nameof(RemoveUnnecessaryByVal);
        public const string RemoveUnnecessaryCast = nameof(RemoveUnnecessaryCast);
        public const string RemoveUnnecessaryDiscardDesignation = nameof(RemoveUnnecessaryDiscardDesignation);
        public const string RemoveUnnecessaryImports = nameof(RemoveUnnecessaryImports);
        public const string RemoveUnnecessaryLambdaExpression = nameof(RemoveUnnecessaryLambdaExpression);
        public const string RemoveUnnecessaryNullableDirective = nameof(RemoveUnnecessaryNullableDirective);
        public const string RemoveUnnecessaryParentheses = nameof(RemoveUnnecessaryParentheses);
        public const string RemoveUnnecessaryPragmaSuppressions = nameof(RemoveUnnecessaryPragmaSuppressions);
        public const string RemoveUnreachableCode = nameof(RemoveUnreachableCode);
        public const string RemoveUnusedLocalFunction = nameof(RemoveUnusedLocalFunction);
        public const string RemoveUnusedMembers = nameof(RemoveUnusedMembers);
        public const string RemoveUnusedValues = nameof(RemoveUnusedValues);
        public const string RemoveUnusedVariable = nameof(RemoveUnusedVariable);
        public const string ReplaceDefaultLiteral = nameof(ReplaceDefaultLiteral);
        public const string SimplifyConditionalExpression = nameof(SimplifyConditionalExpression);
        public const string SimplifyInterpolation = nameof(SimplifyInterpolation);
        public const string SimplifyLinqExpression = nameof(SimplifyLinqExpression);
        public const string SimplifyNames = nameof(SimplifyNames);
        public const string SimplifyObjectCreation = nameof(SimplifyObjectCreation);
        public const string SimplifyPropertyPattern = nameof(SimplifyPropertyPattern);
        public const string SimplifyThisOrMe = nameof(SimplifyThisOrMe);
        public const string SpellCheck = nameof(SpellCheck);
        public const string TransposeRecordKeyword = nameof(TransposeRecordKeyword);
        public const string UnsealClass = nameof(UnsealClass);
        public const string UpdateLegacySuppressions = nameof(UpdateLegacySuppressions);
        public const string UpdateProjectToAllowUnsafe = nameof(UpdateProjectToAllowUnsafe);
        public const string UpgradeProject = nameof(UpgradeProject);
        public const string UseAutoProperty = nameof(UseAutoProperty);
        public const string UseCoalesceExpressionForIfNullStatementCheck = nameof(UseCoalesceExpressionForIfNullStatementCheck);
        public const string UseCoalesceExpressionForTernaryConditionalCheck = nameof(UseCoalesceExpressionForTernaryConditionalCheck);
        public const string UseCoalesceExpressionForNullableTernaryConditionalCheck = nameof(UseCoalesceExpressionForNullableTernaryConditionalCheck);
        public const string UseCollectionInitializer = nameof(UseCollectionInitializer);
        public const string UseCompoundAssignment = nameof(UseCompoundAssignment);
        public const string UseCompoundCoalesceAssignment = nameof(UseCompoundCoalesceAssignment);
        public const string UseConditionalExpressionForAssignment = nameof(UseConditionalExpressionForAssignment);
        public const string UseConditionalExpressionForReturn = nameof(UseConditionalExpressionForReturn);
        public const string UseDeconstruction = nameof(UseDeconstruction);
        public const string UseDefaultLiteral = nameof(UseDefaultLiteral);
        public const string UseExplicitTupleName = nameof(UseExplicitTupleName);
        public const string UseExplicitType = nameof(UseExplicitType);
        public const string UseExplicitTypeForConst = nameof(UseExplicitTypeForConst);
        public const string UseExpressionBody = nameof(UseExpressionBody);
        public const string UseExpressionBodyForLambda = nameof(UseExpressionBodyForLambda);
        public const string UseImplicitObjectCreation = nameof(UseImplicitObjectCreation);
        public const string UseImplicitType = nameof(UseImplicitType);
        public const string UseIndexOperator = nameof(UseIndexOperator);
        public const string UseInferredMemberName = nameof(UseInferredMemberName);
        public const string UseInterpolatedVerbatimString = nameof(UseInterpolatedVerbatimString);
        public const string UseIsNotExpression = nameof(UseIsNotExpression);
        public const string UseIsNullCheck = nameof(UseIsNullCheck);
        public const string UseIsNullCheckForCastAndEqualityOperator = nameof(UseIsNullCheckForCastAndEqualityOperator);
        public const string UseIsNullCheckForReferenceEquals = nameof(UseIsNullCheckForReferenceEquals);
        public const string UseLocalFunction = nameof(UseLocalFunction);
        public const string UseNameofInAttribute = nameof(UseNameofInAttribute);
        public const string UseNotPattern = nameof(UseNotPattern);
        public const string UseNullCheckOverTypeCheck = nameof(UseNullCheckOverTypeCheck);
        public const string UseNullPropagation = nameof(UseNullPropagation);
        public const string UseObjectInitializer = nameof(UseObjectInitializer);
        public const string UsePatternCombinators = nameof(UsePatternCombinators);
        public const string UsePatternMatchingAsAndMemberAccess = nameof(UsePatternMatchingAsAndMemberAccess);
        public const string UsePatternMatchingAsAndNullCheck = nameof(UsePatternMatchingAsAndNullCheck);
        public const string UsePatternMatchingIsAndCastCheck = nameof(UsePatternMatchingIsAndCastCheck);
        public const string UsePatternMatchingIsAndCastCheckWithoutName = nameof(UsePatternMatchingIsAndCastCheckWithoutName);
        public const string UseRangeOperator = nameof(UseRangeOperator);
        public const string UseSimpleUsingStatement = nameof(UseSimpleUsingStatement);
        public const string UseSystemHashCode = nameof(UseSystemHashCode);
        public const string UseThrowExpression = nameof(UseThrowExpression);
        public const string UseTupleSwap = nameof(UseTupleSwap);
        public const string UseUtf8StringLiteral = nameof(UseUtf8StringLiteral);
    }
}
