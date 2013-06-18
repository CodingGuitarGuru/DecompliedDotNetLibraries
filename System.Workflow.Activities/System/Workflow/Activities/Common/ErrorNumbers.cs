﻿namespace System.Workflow.Activities.Common
{
    using System;

    internal static class ErrorNumbers
    {
        public const int Bind_ActivityDataSourceRecursionDetected = 0x12f;
        public const int Bind_DuplicateDataSourceNames = 0x110;
        public const int Error_ActivationActivityInsideLoop = 0x579;
        public const int Error_ActivationActivityNotFirst = 0x568;
        public const int Error_ActivityRefNotResolved = 0x50a;
        public const int Error_ArrayIndexBadRank = 0x19c;
        public const int Error_ArrayIndexBadType = 0x19e;
        public const int Error_AtomicScopeNestedInNonLRT = 0x52e;
        public const int Error_AtomicScopeWithCancellationHandlerActivity = 0x575;
        public const int Error_AtomicScopeWithFaultHandlersActivityDecl = 0x52c;
        public const int Error_BadTypeArgCount = 0x18d;
        public const int Error_BindActivityReference = 0x12a;
        public const int Error_BindBaseTypeNotSpecified = 0x626;
        public const int Error_BindingTypeMissing = 0x546;
        public const int Error_BlackBoxCustomStateNotSupported = 0x623;
        public const int Error_CancelHandlerParentNotScope = 0x573;
        public const int Error_CannotIndexType = 0x19b;
        public const int Error_CannotNestThisActivity = 0x62a;
        public const int Error_CannotResolveActivity = 0x129;
        public const int Error_CannotResolveMember = 0x54a;
        public const int Error_CannotResolveRelativeActivity = 0x128;
        public const int Error_CantHaveContextActivity = 0x60c;
        public const int Error_CantRemoveEventDrivenFromExecutingState = 0x620;
        public const int Error_CantRemoveState = 0x61b;
        public const int Error_CantResolveEventHandler = 0x60f;
        public const int Error_CodeExpressionNotHandled = 0x548;
        public const int Error_CodeWithinNotAllowed = 0x16a;
        public const int Error_CompanionClassNameCanNotBeEmpty = 0x174;
        public const int Error_CompanionTypeDerivationError = 0x176;
        public const int Error_CompensantionParentNotScope = 0x50b;
        public const int Error_CompensateBadNesting = 0x509;
        public const int Error_CompensateBadTargetTX = 0x563;
        public const int Error_CompletedStateCannotContainActivities = 0x5ff;
        public const int Error_CompletedStateMustPointToALeafNodeState = 0x5f8;
        public const int Error_CompletedStateMustPointToAState = 0x5f6;
        public const int Error_ConditionalBranchParentNotConditional = 0x50e;
        public const int Error_ConditionMustBeBoolean = 0x547;
        public const int Error_ConditionNotFound = 0x53e;
        public const int Error_ConfigFileMissingOrInvalid = 0x178;
        public const int Error_CorrelatedSendReceiveAtomicScope = 0x539;
        public const int Error_CorrelationAlreadyInitialized = 0x53a;
        public const int Error_CorrelationAttributeInvalid = 0x150;
        public const int Error_CorrelationInitializerNotDefinied = 0x159;
        public const int Error_CorrelationInvalid = 0x158;
        public const int Error_CorrelationParameterNotFound = 0x153;
        public const int Error_CorrelationTokenInReplicator = 0x618;
        public const int Error_CorrelationTypeNotConsistent = 340;
        public const int Error_CouldNotDetermineMemberType = 0x194;
        public const int Error_CreateValidator = 0x106;
        public const int Error_CustomActivityCantCreate = 0x117;
        public const int Error_CyclicalExpression = 0x179;
        public const int Error_DataSourceInvalidIdentifier = 0x13e;
        public const int Error_DataSourceNameNotSet = 0x13d;
        public const int Error_DataSourceNotExist = 0x131;
        public const int Error_DerivationFromTypeWithLocalDataContext = 0x175;
        public const int Error_DuplicateConditions = 0x53f;
        public const int Error_DuplicateCorrelation = 0x535;
        public const int Error_DuplicateCorrelationAttribute = 0x151;
        public const int Error_DuplicatedActivityID = 0x602;
        public const int Error_DuplicatedParameterName = 0x177;
        public const int Error_DuplicateParameter = 0x503;
        public const int Error_DuplicateWebServiceFaultFound = 0x574;
        public const int Error_DuplicateWebServiceResponseFound = 0x56a;
        public const int Error_DynamicActivity = 260;
        public const int Error_DynamicActivity2 = 0x50f;
        public const int Error_DynamicActivity3 = 0x62f;
        public const int Error_EmptyExpression = 400;
        public const int Error_EventActivityNotValidInStateHandler = 0x603;
        public const int Error_EventDrivenInvalidFirstActivity = 0x512;
        public const int Error_EventDrivenMultipleEventActivity = 0x524;
        public const int Error_EventDrivenNoFirstActivity = 0x511;
        public const int Error_EventDrivenParentNotListen = 0x510;
        public const int Error_EventHandlersDeclParentNotScope = 0x522;
        public const int Error_ExceptionVariableNotAssignable = 0x51b;
        public const int Error_ExecInAtomicScope = 0x502;
        public const int Error_ExecWithActivationReceive = 0x614;
        public const int Error_ExtraCharactersIgnored = 0x191;
        public const int Error_FaultHandlerActivityAllMustBeLast = 0x51c;
        public const int Error_FaultHandlerActivityParentNotFaultHandlersActivity = 0x519;
        public const int Error_FaultHandlerActivityWrongOrder = 0x521;
        public const int Error_FaultHandlersActivityDeclNotAllFaultHandlerActivityDecl = 0x51e;
        public const int Error_FieldNotAccessible = 0x121;
        public const int Error_FieldNotExists = 0x120;
        public const int Error_FieldTypeMismatch = 0x13f;
        public const int Error_FieldTypeNotResolved = 290;
        public const int Error_GeneratorShouldContainSingleActivity = 0x526;
        public const int Error_GenericMethodsNotSupported = 0x155;
        public const int Error_GetCalleeWorkflow = 0x500;
        public const int Error_HandlerReadOnly = 0x133;
        public const int Error_IDNotSetForActivitySource = 0x613;
        public const int Error_IfElseLessThanOneChildren = 0x50c;
        public const int Error_IfElseNotAllIfElseBranchDecl = 0x50d;
        public const int Error_IndexerArgCannotBeRefOrOut = 0x19d;
        public const int Error_IndexerCountMismatch = 0x19f;
        public const int Error_IndexerNotFound = 0x1a0;
        public const int Error_IndexerOverloadNotFound = 0x1a1;
        public const int Error_InitializerFollowerInTxnlScope = 0x62e;
        public const int Error_InitializerInReplicator = 0x62d;
        public const int Error_InitialStateMustBeDifferentThanCompletedState = 0x62c;
        public const int Error_InitialStateMustPointToALeafNodeState = 0x5f7;
        public const int Error_InitialStateMustPointToAState = 0x5f5;
        public const int Error_InsideAtomicScope = 0x100;
        public const int Error_InterfaceTypeNotInterface = 0x570;
        public const int Error_InvalidAssignTarget = 0x17a;
        public const int Error_InvalidCharacter = 0x17b;
        public const int Error_InvalidCompositeStateChild = 0x5f0;
        public const int Error_InvalidConditionExpression = 0x558;
        public const int Error_InvalidConditionName = 0x540;
        public const int Error_InvalidEscapeSequence = 380;
        public const int Error_InvalidExponentDigit = 0x17e;
        public const int Error_InvalidHexDigit = 0x17f;
        public const int Error_InvalidIdentifier = 0x119;
        public const int Error_InvalidIntegerLiteral = 0x192;
        public const int Error_InvalidLeafStateChild = 0x5f1;
        public const int Error_InvalidMemberPath = 300;
        public const int Error_InvalidMemberType = 0x629;
        public const int Error_InvalidRealLiteral = 0x1a7;
        public const int Error_InvalidReferencedAssembly = 0x162;
        public const int Error_InvalidRuleAttributeParameter = 420;
        public const int Error_InvalidRuleSetExpression = 0x577;
        public const int Error_InvalidRuleSetName = 0x578;
        public const int Error_InvalidStateActivityParent = 0x62b;
        public const int Error_InvalidTargetStateInStateInitialization = 0x605;
        public const int Error_InvalidTypeArgument = 0x18e;
        public const int Error_InvalidUpdate = 0x57b;
        public const int Error_InvalidUpdateExpression = 0x181;
        public const int Error_InvalidWildCardInPathQualifier = 0x195;
        public const int Error_InvokeAttrRefersToParameterAttribute = 0x1a5;
        public const int Error_LeftOperandInvalidType = 0x542;
        public const int Error_LeftOperandMissing = 0x541;
        public const int Error_LibraryPath = 0x160;
        public const int Error_ListenLessThanTwoChildren = 0x513;
        public const int Error_ListenNotAllEventDriven = 0x514;
        public const int Error_ListenNotMoreThanOneDelay = 0x516;
        public const int Error_LiteralConversionFailed = 0x13c;
        public const int Error_LRTScopeNestedInNonLRT = 0x52f;
        public const int Error_MethodArgCountMismatch = 0x196;
        public const int Error_MethodArgumentTypeMismatch = 0x198;
        public const int Error_MethodDataSourceWithPath = 0x132;
        public const int Error_MethodDirectionMismatch = 0x197;
        public const int Error_MethodNotAccessible = 0x138;
        public const int Error_MethodNotExists = 0x137;
        public const int Error_MethodOverloadNotFound = 0x199;
        public const int Error_MethodReturnTypeMismatch = 0x139;
        public const int Error_MethodSignatureMismatch = 310;
        public const int Error_MissingAttribute = 0x10b;
        public const int Error_MissingCloseAngleBracket = 0x18f;
        public const int Error_MissingCloseSquareBracket = 410;
        public const int Error_MissingCorrelationParameterAttribute = 0x152;
        public const int Error_MissingDataExchangeServiceAttribute = 0x616;
        public const int Error_MissingDotAfterNamespace = 0x189;
        public const int Error_MissingEventName = 0x617;
        public const int Error_MissingHostInterface = 0x529;
        public const int Error_MissingIdentifierAfterDot = 0x185;
        public const int Error_MissingLparenAfterCommand = 0x180;
        public const int Error_MissingMethodName = 0x528;
        public const int Error_MissingOperand = 0x183;
        public const int Error_MissingRCurlyAfterInitializers = 0x1ab;
        public const int Error_MissingRootActivity = 0x10f;
        public const int Error_MissingRParenAfterArgumentList = 0x182;
        public const int Error_MissingRParenInSubexpression = 0x184;
        public const int Error_MissingRuleCondition = 0x57d;
        public const int Error_MissingTypeArguments = 0x18b;
        public const int Error_ModelingConstructsCanNotContainModelingConstructs = 0x61f;
        public const int Error_MoreThanTwoActivitiesInEventHandlingScope = 0x61e;
        public const int Error_MultipleRootActivityCreator = 0x15d;
        public const int Error_MultipleStateFinalizationActivities = 0x61a;
        public const int Error_MultipleStateInitializationActivities = 0x604;
        public const int Error_NegativeValue = 0x531;
        public const int Error_NestedCompensatableActivity = 0x1a6;
        public const int Error_NestedConstrainedGroupConditions = 0x615;
        public const int Error_NestedPersistOnClose = 0x1a2;
        public const int Error_NoArrayCreationSize = 0x1aa;
        public const int Error_NoEnclosingContext = 0x130;
        public const int Error_NonStaticMember = 0x562;
        public const int Error_NotAGenericType = 0x18c;
        public const int Error_OperandTypesIncompatible = 0x545;
        public const int Error_OutRefParameterNotSupported = 0x157;
        public const int Error_ParallelActivationNoCorrelation = 0x536;
        public const int Error_ParallelLessThanTwoChildren = 0x517;
        public const int Error_ParallelNotAllSequence = 0x518;
        public const int Error_ParameterNotFound = 0x504;
        public const int Error_ParameterNotSet = 0x53d;
        public const int Error_ParameterPropertyNotSet = 0x109;
        public const int Error_ParameterTypeNotExist = 0x10a;
        public const int Error_ParameterTypeNotFound = 0x571;
        public const int Error_ParentDoesNotSupportCompensation = 0x622;
        public const int Error_PathCouldNotBeResolvedToMember = 0x60d;
        public const int Error_PathNotSetForActivitySource = 0x12b;
        public const int Error_PathNotSetForXmlDataSource = 0x148;
        public const int Error_PolicyGetRuleSetNotImplemented = 0x56c;
        public const int Error_PolicyGetRuleSetNull = 0x56d;
        public const int Error_PropertyDefaultIsReference = 0x1a8;
        public const int Error_PropertyDefaultTypeMismatch = 0x1a9;
        public const int Error_PropertyHasIndexParameters = 0x144;
        public const int Error_PropertyNoGetter = 0x142;
        public const int Error_PropertyNoSetter = 0x143;
        public const int Error_PropertyNotAccessible = 0x165;
        public const int Error_PropertyNotExists = 0x164;
        public const int Error_PropertyNotSet = 0x116;
        public const int Error_PropertyReferenceGetterNoAccess = 0x60a;
        public const int Error_PropertyReferenceNoGetter = 360;
        public const int Error_PropertyTypeMismatch = 0x167;
        public const int Error_PropertyTypeNotResolved = 0x166;
        public const int Error_ReadOnlyField = 0x145;
        public const int Error_RecursionDetected = 0x506;
        public const int Error_RefBindCantFindRef = 270;
        public const int Error_RefBindMissingReferenceName = 0x10d;
        public const int Error_ReferencedActivityPropertyNotBind = 0x12e;
        public const int Error_ReferenceInvalidResourceFile = 0x10c;
        public const int Error_RemoveExecutingActivity = 0x11d;
        public const int Error_ReturnTypeNotFound = 0x572;
        public const int Error_ReturnTypeNotVoid = 0x156;
        public const int Error_RightOperandInvalidType = 0x544;
        public const int Error_RightOperandMissing = 0x543;
        public const int Error_RootIsNotEnabled = 0x628;
        public const int Error_RuleSetNotFound = 0x576;
        public const int Error_ScopeDuplicatedNameActivity = 0x111;
        public const int Error_ScopeDuplicateFaultHandlerActivityFor = 0x520;
        public const int Error_ScopeDuplicateFaultHandlerActivityForAll = 0x51f;
        public const int Error_ScopeMoreThanOneCompensationDecl = 0x52b;
        public const int Error_ScopeMoreThanOneEventHandlersDecl = 0x527;
        public const int Error_ScopeMoreThanOneFaultHandlersActivityDecl = 0x52a;
        public const int Error_SerializationError = 0x15b;
        public const int Error_SetStateMustPointToALeafNodeState = 0x5f4;
        public const int Error_SetStateMustPointToAState = 0x5f3;
        public const int Error_SetStateOnlyWorksOnStateMachineWorkflow = 0x5f2;
        public const int Error_StateHandlerParentNotState = 0x606;
        public const int Error_StateMachineWorkflowMustBeARootActivity = 0x621;
        public const int Error_StaticMember = 0x561;
        public const int Error_SuspendInAtomicCallChain = 0x508;
        public const int Error_SuspendInAtomicScope = 0x525;
        public const int Error_SynchronizedNeedsDataContext = 0x608;
        public const int Error_TargetTypeDataSourcePathMismatch = 0x141;
        public const int Error_TargetTypeMismatch = 0x12d;
        public const int Error_TypeIsNotRootActivity = 0x60e;
        public const int Error_TypeLoad = 0x161;
        public const int Error_TypeNotAsseblyQualified = 0x11a;
        public const int Error_TypeNotAuthorized = 0x16b;
        public const int Error_TypeNotDelegate = 0x134;
        public const int Error_TypeNotExist = 0x113;
        public const int Error_TypeNotPrimitive = 0x13b;
        public const int Error_TypeNotPublic = 0x56e;
        public const int Error_TypeNotPublicSerializable = 0x567;
        public const int Error_TypeNotResolvedInFieldName = 0x11f;
        public const int Error_TypeNotResolvedInMethodName = 0x135;
        public const int Error_TypeNotResolvedInPropertyName = 0x163;
        public const int Error_TypePropertyInvalid = 0x619;
        public const int Error_TypeTypeMismatch = 0x51a;
        public const int Error_TypeTypeMismatchAmbiguity = 0x114;
        public const int Error_UnableToResolveType = 0x549;
        public const int Error_UninitializedCorrelation = 0x538;
        public const int Error_UnknownCompilerException = 0x15c;
        public const int Error_UnknownFieldOrProperty = 390;
        public const int Error_UnknownIdentifier = 0x188;
        public const int Error_UnknownLiteral = 0x187;
        public const int Error_UnknownNamespaceMember = 0x18a;
        public const int Error_UnterminatedCharacterLiteral = 0x17d;
        public const int Error_UnterminatedStringLiteral = 0x193;
        public const int Error_UserCodeFilesNotAllowed = 0x169;
        public const int Error_ValidatorThrewException = 0x627;
        public const int Error_WebServiceFaultNotNeeded = 0x57a;
        public const int Error_WebServiceReceiveNotConfigured = 0x566;
        public const int Error_WebServiceReceiveNotFound = 0x55e;
        public const int Error_WebServiceReceiveNotMarkedActivate = 0x569;
        public const int Error_WebServiceReceiveNotValid = 0x564;
        public const int Error_WebServiceResponseNotFound = 0x55d;
        public const int Error_WebServiceResponseNotNeeded = 0x565;
        public const int Error_WhileShouldHaveOneChild = 0x60b;
        public const int Error_XmlDataSourceReadOnly = 0x147;
        public const int Error_XomlWorkflowHasClassName = 0x61c;
        public const int Error_XomlWorkflowHasCode = 0x61d;
        public const int Error_XSDObjectTypeNotSerializable = 0x610;
        public const int SR_InvokeTransactionalFromAtomic = 0x501;
        public const int Warning_AdditionalBindingsFound = 0x630;
        public const int Warning_EmptyBehaviourActivity = 0x1a3;
        public const int Warning_ParameterBinding = 0x624;
        public const int Warning_RuleAttributeNoMatch = 0x56b;
        public const int Warning_UnreachableCode = 0x54c;
        public const int Warning_UnverifiedRecursion = 0x507;
    }
}

