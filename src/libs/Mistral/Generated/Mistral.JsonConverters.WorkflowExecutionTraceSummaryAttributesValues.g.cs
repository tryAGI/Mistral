#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mistral.JsonConverters
{
    /// <inheritdoc />
    public class WorkflowExecutionTraceSummaryAttributesValuesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mistral.WorkflowExecutionTraceSummaryAttributesValues>
    {
        /// <inheritdoc />
        public override global::Mistral.WorkflowExecutionTraceSummaryAttributesValues Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            var __score4 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            string? workflowExecutionTraceSummaryAttributesValuesVariant1 = default;
            int? workflowExecutionTraceSummaryAttributesValuesVariant2 = default;
            double? workflowExecutionTraceSummaryAttributesValuesVariant3 = default;
            bool? workflowExecutionTraceSummaryAttributesValuesVariant4 = default;
            object? workflowExecutionTraceSummaryAttributesValuesVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        workflowExecutionTraceSummaryAttributesValuesVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        workflowExecutionTraceSummaryAttributesValuesVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<int>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        workflowExecutionTraceSummaryAttributesValuesVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        workflowExecutionTraceSummaryAttributesValuesVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        workflowExecutionTraceSummaryAttributesValuesVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workflowExecutionTraceSummaryAttributesValuesVariant1 == null && workflowExecutionTraceSummaryAttributesValuesVariant2 == null && workflowExecutionTraceSummaryAttributesValuesVariant3 == null && workflowExecutionTraceSummaryAttributesValuesVariant4 == null && workflowExecutionTraceSummaryAttributesValuesVariant5 == null)
            {
                try
                {

                    workflowExecutionTraceSummaryAttributesValuesVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    workflowExecutionTraceSummaryAttributesValuesVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<int>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    workflowExecutionTraceSummaryAttributesValuesVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<double>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    workflowExecutionTraceSummaryAttributesValuesVariant4 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    workflowExecutionTraceSummaryAttributesValuesVariant5 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Mistral.WorkflowExecutionTraceSummaryAttributesValues(
                workflowExecutionTraceSummaryAttributesValuesVariant1,

                workflowExecutionTraceSummaryAttributesValuesVariant2,

                workflowExecutionTraceSummaryAttributesValuesVariant3,

                workflowExecutionTraceSummaryAttributesValuesVariant4,

                workflowExecutionTraceSummaryAttributesValuesVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mistral.WorkflowExecutionTraceSummaryAttributesValues value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsWorkflowExecutionTraceSummaryAttributesValuesVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionTraceSummaryAttributesValuesVariant1, typeof(string), options);
            }
            else if (value.IsWorkflowExecutionTraceSummaryAttributesValuesVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionTraceSummaryAttributesValuesVariant2, typeof(int), options);
            }
            else if (value.IsWorkflowExecutionTraceSummaryAttributesValuesVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionTraceSummaryAttributesValuesVariant3, typeof(double), options);
            }
            else if (value.IsWorkflowExecutionTraceSummaryAttributesValuesVariant4)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionTraceSummaryAttributesValuesVariant4, typeof(bool), options);
            }
            else if (value.IsWorkflowExecutionTraceSummaryAttributesValuesVariant5)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionTraceSummaryAttributesValuesVariant5, typeof(object), options);
            }
        }
    }
}