
#nullable enable

namespace Mistral
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMistralApiError,
        /// <summary>
        /// 
        /// </summary>
        AgentNotFound,
        /// <summary>
        /// 
        /// </summary>
        AuthForbidden,
        /// <summary>
        /// 
        /// </summary>
        AuthForbiddenNotWorkspaceAdmin,
        /// <summary>
        /// 
        /// </summary>
        AuthForbiddenOrgNotWhitelisted,
        /// <summary>
        /// 
        /// </summary>
        AuthForbiddenRoleNotFound,
        /// <summary>
        /// 
        /// </summary>
        AuthForbiddenWorkspaceNotFound,
        /// <summary>
        /// 
        /// </summary>
        AuthUnauthorized,
        /// <summary>
        /// 
        /// </summary>
        CampaignNotFound,
        /// <summary>
        /// 
        /// </summary>
        CampaignNoMatchingEvents,
        /// <summary>
        /// 
        /// </summary>
        DatabaseError,
        /// <summary>
        /// 
        /// </summary>
        DatabaseQueryError,
        /// <summary>
        /// 
        /// </summary>
        DatabaseTimeout,
        /// <summary>
        /// 
        /// </summary>
        DatabaseUnavailable,
        /// <summary>
        /// 
        /// </summary>
        DatasetNotFound,
        /// <summary>
        /// 
        /// </summary>
        DatasetRecordFormatError,
        /// <summary>
        /// 
        /// </summary>
        DatasetRecordNotFound,
        /// <summary>
        /// 
        /// </summary>
        DatasetTaskNotFound,
        /// <summary>
        /// 
        /// </summary>
        EvaluationCurrentlyRunning,
        /// <summary>
        /// 
        /// </summary>
        EvaluationNotFound,
        /// <summary>
        /// 
        /// </summary>
        EvaluationRecordNotFound,
        /// <summary>
        /// 
        /// </summary>
        EvaluationRunNotFound,
        /// <summary>
        /// 
        /// </summary>
        EvaluationRunTransitionError,
        /// <summary>
        /// 
        /// </summary>
        EvaluationRunTransitionIsInvalid,
        /// <summary>
        /// 
        /// </summary>
        EvaluationRunTransitionIsRunningAlready,
        /// <summary>
        /// 
        /// </summary>
        FeatureNotSupported,
        /// <summary>
        /// 
        /// </summary>
        FieldsBadRequest,
        /// <summary>
        /// 
        /// </summary>
        FieldsNotFound,
        /// <summary>
        /// 
        /// </summary>
        JudgeAlreadyHasNewVersion,
        /// <summary>
        /// 
        /// </summary>
        JudgeConversationFormatError,
        /// <summary>
        /// 
        /// </summary>
        JudgeDidNotChange,
        /// <summary>
        /// 
        /// </summary>
        JudgeMistralApiError,
        /// <summary>
        /// 
        /// </summary>
        JudgeMistralApiTimeout,
        /// <summary>
        /// 
        /// </summary>
        JudgeNameAlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        JudgeNotFound,
        /// <summary>
        /// 
        /// </summary>
        JudgeUsedInCampaignCannotBeUpdated,
        /// <summary>
        /// 
        /// </summary>
        SearchBadRequest,
        /// <summary>
        /// 
        /// </summary>
        SearchFilterToSqlConversionError,
        /// <summary>
        /// 
        /// </summary>
        SearchNotFound,
        /// <summary>
        /// 
        /// </summary>
        SearchServiceUnavailable,
        /// <summary>
        /// 
        /// </summary>
        TemplateSyntaxError,
        /// <summary>
        /// 
        /// </summary>
        UnknownError,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityErrorCode value)
        {
            return value switch
            {
                ObservabilityErrorCode.AgentMistralApiError => "AGENT_MISTRAL_API_ERROR",
                ObservabilityErrorCode.AgentNotFound => "AGENT_NOT_FOUND",
                ObservabilityErrorCode.AuthForbidden => "AUTH_FORBIDDEN",
                ObservabilityErrorCode.AuthForbiddenNotWorkspaceAdmin => "AUTH_FORBIDDEN_NOT_WORKSPACE_ADMIN",
                ObservabilityErrorCode.AuthForbiddenOrgNotWhitelisted => "AUTH_FORBIDDEN_ORG_NOT_WHITELISTED",
                ObservabilityErrorCode.AuthForbiddenRoleNotFound => "AUTH_FORBIDDEN_ROLE_NOT_FOUND",
                ObservabilityErrorCode.AuthForbiddenWorkspaceNotFound => "AUTH_FORBIDDEN_WORKSPACE_NOT_FOUND",
                ObservabilityErrorCode.AuthUnauthorized => "AUTH_UNAUTHORIZED",
                ObservabilityErrorCode.CampaignNotFound => "CAMPAIGN_NOT_FOUND",
                ObservabilityErrorCode.CampaignNoMatchingEvents => "CAMPAIGN_NO_MATCHING_EVENTS",
                ObservabilityErrorCode.DatabaseError => "DATABASE_ERROR",
                ObservabilityErrorCode.DatabaseQueryError => "DATABASE_QUERY_ERROR",
                ObservabilityErrorCode.DatabaseTimeout => "DATABASE_TIMEOUT",
                ObservabilityErrorCode.DatabaseUnavailable => "DATABASE_UNAVAILABLE",
                ObservabilityErrorCode.DatasetNotFound => "DATASET_NOT_FOUND",
                ObservabilityErrorCode.DatasetRecordFormatError => "DATASET_RECORD_FORMAT_ERROR",
                ObservabilityErrorCode.DatasetRecordNotFound => "DATASET_RECORD_NOT_FOUND",
                ObservabilityErrorCode.DatasetTaskNotFound => "DATASET_TASK_NOT_FOUND",
                ObservabilityErrorCode.EvaluationCurrentlyRunning => "EVALUATION_CURRENTLY_RUNNING",
                ObservabilityErrorCode.EvaluationNotFound => "EVALUATION_NOT_FOUND",
                ObservabilityErrorCode.EvaluationRecordNotFound => "EVALUATION_RECORD_NOT_FOUND",
                ObservabilityErrorCode.EvaluationRunNotFound => "EVALUATION_RUN_NOT_FOUND",
                ObservabilityErrorCode.EvaluationRunTransitionError => "EVALUATION_RUN_TRANSITION_ERROR",
                ObservabilityErrorCode.EvaluationRunTransitionIsInvalid => "EVALUATION_RUN_TRANSITION_IS_INVALID",
                ObservabilityErrorCode.EvaluationRunTransitionIsRunningAlready => "EVALUATION_RUN_TRANSITION_IS_RUNNING_ALREADY",
                ObservabilityErrorCode.FeatureNotSupported => "FEATURE_NOT_SUPPORTED",
                ObservabilityErrorCode.FieldsBadRequest => "FIELDS_BAD_REQUEST",
                ObservabilityErrorCode.FieldsNotFound => "FIELDS_NOT_FOUND",
                ObservabilityErrorCode.JudgeAlreadyHasNewVersion => "JUDGE_ALREADY_HAS_NEW_VERSION",
                ObservabilityErrorCode.JudgeConversationFormatError => "JUDGE_CONVERSATION_FORMAT_ERROR",
                ObservabilityErrorCode.JudgeDidNotChange => "JUDGE_DID_NOT_CHANGE",
                ObservabilityErrorCode.JudgeMistralApiError => "JUDGE_MISTRAL_API_ERROR",
                ObservabilityErrorCode.JudgeMistralApiTimeout => "JUDGE_MISTRAL_API_TIMEOUT",
                ObservabilityErrorCode.JudgeNameAlreadyExists => "JUDGE_NAME_ALREADY_EXISTS",
                ObservabilityErrorCode.JudgeNotFound => "JUDGE_NOT_FOUND",
                ObservabilityErrorCode.JudgeUsedInCampaignCannotBeUpdated => "JUDGE_USED_IN_CAMPAIGN_CANNOT_BE_UPDATED",
                ObservabilityErrorCode.SearchBadRequest => "SEARCH_BAD_REQUEST",
                ObservabilityErrorCode.SearchFilterToSqlConversionError => "SEARCH_FILTER_TO_SQL_CONVERSION_ERROR",
                ObservabilityErrorCode.SearchNotFound => "SEARCH_NOT_FOUND",
                ObservabilityErrorCode.SearchServiceUnavailable => "SEARCH_SERVICE_UNAVAILABLE",
                ObservabilityErrorCode.TemplateSyntaxError => "TEMPLATE_SYNTAX_ERROR",
                ObservabilityErrorCode.UnknownError => "UNKNOWN_ERROR",
                ObservabilityErrorCode.ValidationError => "VALIDATION_ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "AGENT_MISTRAL_API_ERROR" => ObservabilityErrorCode.AgentMistralApiError,
                "AGENT_NOT_FOUND" => ObservabilityErrorCode.AgentNotFound,
                "AUTH_FORBIDDEN" => ObservabilityErrorCode.AuthForbidden,
                "AUTH_FORBIDDEN_NOT_WORKSPACE_ADMIN" => ObservabilityErrorCode.AuthForbiddenNotWorkspaceAdmin,
                "AUTH_FORBIDDEN_ORG_NOT_WHITELISTED" => ObservabilityErrorCode.AuthForbiddenOrgNotWhitelisted,
                "AUTH_FORBIDDEN_ROLE_NOT_FOUND" => ObservabilityErrorCode.AuthForbiddenRoleNotFound,
                "AUTH_FORBIDDEN_WORKSPACE_NOT_FOUND" => ObservabilityErrorCode.AuthForbiddenWorkspaceNotFound,
                "AUTH_UNAUTHORIZED" => ObservabilityErrorCode.AuthUnauthorized,
                "CAMPAIGN_NOT_FOUND" => ObservabilityErrorCode.CampaignNotFound,
                "CAMPAIGN_NO_MATCHING_EVENTS" => ObservabilityErrorCode.CampaignNoMatchingEvents,
                "DATABASE_ERROR" => ObservabilityErrorCode.DatabaseError,
                "DATABASE_QUERY_ERROR" => ObservabilityErrorCode.DatabaseQueryError,
                "DATABASE_TIMEOUT" => ObservabilityErrorCode.DatabaseTimeout,
                "DATABASE_UNAVAILABLE" => ObservabilityErrorCode.DatabaseUnavailable,
                "DATASET_NOT_FOUND" => ObservabilityErrorCode.DatasetNotFound,
                "DATASET_RECORD_FORMAT_ERROR" => ObservabilityErrorCode.DatasetRecordFormatError,
                "DATASET_RECORD_NOT_FOUND" => ObservabilityErrorCode.DatasetRecordNotFound,
                "DATASET_TASK_NOT_FOUND" => ObservabilityErrorCode.DatasetTaskNotFound,
                "EVALUATION_CURRENTLY_RUNNING" => ObservabilityErrorCode.EvaluationCurrentlyRunning,
                "EVALUATION_NOT_FOUND" => ObservabilityErrorCode.EvaluationNotFound,
                "EVALUATION_RECORD_NOT_FOUND" => ObservabilityErrorCode.EvaluationRecordNotFound,
                "EVALUATION_RUN_NOT_FOUND" => ObservabilityErrorCode.EvaluationRunNotFound,
                "EVALUATION_RUN_TRANSITION_ERROR" => ObservabilityErrorCode.EvaluationRunTransitionError,
                "EVALUATION_RUN_TRANSITION_IS_INVALID" => ObservabilityErrorCode.EvaluationRunTransitionIsInvalid,
                "EVALUATION_RUN_TRANSITION_IS_RUNNING_ALREADY" => ObservabilityErrorCode.EvaluationRunTransitionIsRunningAlready,
                "FEATURE_NOT_SUPPORTED" => ObservabilityErrorCode.FeatureNotSupported,
                "FIELDS_BAD_REQUEST" => ObservabilityErrorCode.FieldsBadRequest,
                "FIELDS_NOT_FOUND" => ObservabilityErrorCode.FieldsNotFound,
                "JUDGE_ALREADY_HAS_NEW_VERSION" => ObservabilityErrorCode.JudgeAlreadyHasNewVersion,
                "JUDGE_CONVERSATION_FORMAT_ERROR" => ObservabilityErrorCode.JudgeConversationFormatError,
                "JUDGE_DID_NOT_CHANGE" => ObservabilityErrorCode.JudgeDidNotChange,
                "JUDGE_MISTRAL_API_ERROR" => ObservabilityErrorCode.JudgeMistralApiError,
                "JUDGE_MISTRAL_API_TIMEOUT" => ObservabilityErrorCode.JudgeMistralApiTimeout,
                "JUDGE_NAME_ALREADY_EXISTS" => ObservabilityErrorCode.JudgeNameAlreadyExists,
                "JUDGE_NOT_FOUND" => ObservabilityErrorCode.JudgeNotFound,
                "JUDGE_USED_IN_CAMPAIGN_CANNOT_BE_UPDATED" => ObservabilityErrorCode.JudgeUsedInCampaignCannotBeUpdated,
                "SEARCH_BAD_REQUEST" => ObservabilityErrorCode.SearchBadRequest,
                "SEARCH_FILTER_TO_SQL_CONVERSION_ERROR" => ObservabilityErrorCode.SearchFilterToSqlConversionError,
                "SEARCH_NOT_FOUND" => ObservabilityErrorCode.SearchNotFound,
                "SEARCH_SERVICE_UNAVAILABLE" => ObservabilityErrorCode.SearchServiceUnavailable,
                "TEMPLATE_SYNTAX_ERROR" => ObservabilityErrorCode.TemplateSyntaxError,
                "UNKNOWN_ERROR" => ObservabilityErrorCode.UnknownError,
                "VALIDATION_ERROR" => ObservabilityErrorCode.ValidationError,
                _ => null,
            };
        }
    }
}