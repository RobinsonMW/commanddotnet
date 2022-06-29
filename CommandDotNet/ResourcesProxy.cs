// this file generated by ResourceGenerators.RegenerateProxyClasses

using System;

namespace CommandDotNet
{
    // this class generated by ResourcesDef.GenerateProxyClass
    public class ResourcesProxy : Resources
    {
        private readonly Func<string, string?> _localize;

        public ResourcesProxy(Func<string, string?> localize)
        {
            _localize = localize ?? throw new ArgumentNullException(nameof(localize));
        }
        public override string ValueSource_EnvVar =>
            _localize(base.ValueSource_EnvVar)
            ?? base.ValueSource_EnvVar;
        public override string ValueSource_AppSetting =>
            _localize(base.ValueSource_AppSetting)
            ?? base.ValueSource_AppSetting;
        public override string Command_version =>
            _localize(base.Command_version)
            ?? base.Command_version;
        public override string Command_version_description =>
            _localize(base.Command_version_description)
            ?? base.Command_version_description;
        public override string CommandLogger_Original_input =>
            _localize(base.CommandLogger_Original_input)
            ?? base.CommandLogger_Original_input;
        public override string CommandLogger_Tool_version =>
            _localize(base.CommandLogger_Tool_version)
            ?? base.CommandLogger_Tool_version;
        public override string CommandLogger_DotNet_version =>
            _localize(base.CommandLogger_DotNet_version)
            ?? base.CommandLogger_DotNet_version;
        public override string CommandLogger_OS_version =>
            _localize(base.CommandLogger_OS_version)
            ?? base.CommandLogger_OS_version;
        public override string CommandLogger_Machine =>
            _localize(base.CommandLogger_Machine)
            ?? base.CommandLogger_Machine;
        public override string CommandLogger_Username =>
            _localize(base.CommandLogger_Username)
            ?? base.CommandLogger_Username;
        public override string Exceptions_Data =>
            _localize(base.Exceptions_Data)
            ?? base.Exceptions_Data;
        public override string Exceptions_Properties =>
            _localize(base.Exceptions_Properties)
            ?? base.Exceptions_Properties;
        public override string Exceptions_StackTrace =>
            _localize(base.Exceptions_StackTrace)
            ?? base.Exceptions_StackTrace;
        public override string Exceptions_StackTrace_at =>
            _localize(base.Exceptions_StackTrace_at)
            ?? base.Exceptions_StackTrace_at;
        public override string ParseReport_root_lc =>
            _localize(base.ParseReport_root_lc)
            ?? base.ParseReport_root_lc;
        public override string ParseDirective_Help_was_requested =>
            _localize(base.ParseDirective_Help_was_requested)
            ?? base.ParseDirective_Help_was_requested;
        public override string ParseDirective_Unable_to_map_tokens_to_arguments =>
            _localize(base.ParseDirective_Unable_to_map_tokens_to_arguments)
            ?? base.ParseDirective_Unable_to_map_tokens_to_arguments;
        public override string ParseDirective_parse_lc =>
            _localize(base.ParseDirective_parse_lc)
            ?? base.ParseDirective_parse_lc;
        public override string ParseDirective_token_transformations_lc =>
            _localize(base.ParseDirective_token_transformations_lc)
            ?? base.ParseDirective_token_transformations_lc;
        public override string ParseDirective_from_shell_lc =>
            _localize(base.ParseDirective_from_shell_lc)
            ?? base.ParseDirective_from_shell_lc;
        public override string Debugger_debug_lc =>
            _localize(base.Debugger_debug_lc)
            ?? base.Debugger_debug_lc;
        public override string Time_time =>
            _localize(base.Time_time)
            ?? base.Time_time;
        public override string Command_help =>
            _localize(base.Command_help)
            ?? base.Command_help;
        public override string Command_help_description =>
            _localize(base.Command_help_description)
            ?? base.Command_help_description;
        public override string Help_Allowed_values =>
            _localize(base.Help_Allowed_values)
            ?? base.Help_Allowed_values;
        public override string Help_arg =>
            _localize(base.Help_arg)
            ?? base.Help_arg;
        public override string Help_Arguments =>
            _localize(base.Help_Arguments)
            ?? base.Help_Arguments;
        public override string Help_Commands =>
            _localize(base.Help_Commands)
            ?? base.Help_Commands;
        public override string Help_for_more_information_about_a_command =>
            _localize(base.Help_for_more_information_about_a_command)
            ?? base.Help_for_more_information_about_a_command;
        public override string Help_Multiple =>
            _localize(base.Help_Multiple)
            ?? base.Help_Multiple;
        public override string Help_Options =>
            _localize(base.Help_Options)
            ?? base.Help_Options;
        public override string Help_Options_also_available_for_subcommands =>
            _localize(base.Help_Options_also_available_for_subcommands)
            ?? base.Help_Options_also_available_for_subcommands;
        public override string Help_Usage =>
            _localize(base.Help_Usage)
            ?? base.Help_Usage;
        public override string Help_usage_lc =>
            _localize(base.Help_usage_lc)
            ?? base.Help_usage_lc;
        public override string Help_Use =>
            _localize(base.Help_Use)
            ?? base.Help_Use;
        public override string Input_inputs_lc =>
            _localize(base.Input_inputs_lc)
            ?? base.Input_inputs_lc;
        public override string Input_stream_lc =>
            _localize(base.Input_stream_lc)
            ?? base.Input_stream_lc;
        public override string Input_piped_lc =>
            _localize(base.Input_piped_lc)
            ?? base.Input_piped_lc;
        public override string Input_prompt_lc =>
            _localize(base.Input_prompt_lc)
            ?? base.Input_prompt_lc;
        public override string Parse_Required_command_was_not_provided =>
            _localize(base.Parse_Required_command_was_not_provided)
            ?? base.Parse_Required_command_was_not_provided;
        public override string Parse_Did_you_mean =>
            _localize(base.Parse_Did_you_mean)
            ?? base.Parse_Did_you_mean;
        public override string Prompt_Enter_once_for_new_value_twice_to_finish =>
            _localize(base.Prompt_Enter_once_for_new_value_twice_to_finish)
            ?? base.Prompt_Enter_once_for_new_value_twice_to_finish;
        public override string Common_default_lc =>
            _localize(base.Common_default_lc)
            ?? base.Common_default_lc;
        public override string Common_from_lc =>
            _localize(base.Common_from_lc)
            ?? base.Common_from_lc;
        public override string Common_key_lc =>
            _localize(base.Common_key_lc)
            ?? base.Common_key_lc;
        public override string Common_value_lc =>
            _localize(base.Common_value_lc)
            ?? base.Common_value_lc;
        public override string Common_source_lc =>
            _localize(base.Common_source_lc)
            ?? base.Common_source_lc;
        public override string Common_command_lc =>
            _localize(base.Common_command_lc)
            ?? base.Common_command_lc;
        public override string Common_argument_lc =>
            _localize(base.Common_argument_lc)
            ?? base.Common_argument_lc;
        public override string Common_option_lc =>
            _localize(base.Common_option_lc)
            ?? base.Common_option_lc;
        public override string Common_Flag =>
            _localize(base.Common_Flag)
            ?? base.Common_Flag;
        public override string Common_commands_lc =>
            _localize(base.Common_commands_lc)
            ?? base.Common_commands_lc;
        public override string Common_arguments_lc =>
            _localize(base.Common_arguments_lc)
            ?? base.Common_arguments_lc;
        public override string Common_options_lc =>
            _localize(base.Common_options_lc)
            ?? base.Common_options_lc;
        public override string Type_Boolean =>
            _localize(base.Type_Boolean)
            ?? base.Type_Boolean;
        public override string Type_Character =>
            _localize(base.Type_Character)
            ?? base.Type_Character;
        public override string Type_Decimal =>
            _localize(base.Type_Decimal)
            ?? base.Type_Decimal;
        public override string Type_Double =>
            _localize(base.Type_Double)
            ?? base.Type_Double;
        public override string Type_Number =>
            _localize(base.Type_Number)
            ?? base.Type_Number;
        public override string Type_Text =>
            _localize(base.Type_Text)
            ?? base.Type_Text;

        public override string ParseReport_Raw_command_line(string commandLine) =>
            _localize(base.ParseReport_Raw_command_line("{0}"))
            ?? base.ParseReport_Raw_command_line(commandLine);
        public override string ParseDirective_Usage(string includeTransformationsArgName, string includeRawCommandLineArgName) =>
            _localize(base.ParseDirective_Usage("{0}", "{1}"))
            ?? base.ParseDirective_Usage(includeTransformationsArgName, includeRawCommandLineArgName);
        public override string ParseDirective_after(string transformationName) =>
            _localize(base.ParseDirective_after("{0}"))
            ?? base.ParseDirective_after(transformationName);
        public override string ParseDirective_after_no_changes(string transformationName) =>
            _localize(base.ParseDirective_after_no_changes("{0}"))
            ?? base.ParseDirective_after_no_changes(transformationName);
        public override string Debugger_Attach_debugger(string processId, string processName) =>
            _localize(base.Debugger_Attach_debugger("{0}", "{1}"))
            ?? base.Debugger_Attach_debugger(processId, processName);
        public override string Arity_is_required(string argumentName) =>
            _localize(base.Arity_is_required("{0}"))
            ?? base.Arity_is_required(argumentName);
        public override string Arity_min_not_reached(string argumentName, string expected, string actual) =>
            _localize(base.Arity_min_not_reached("{0}", "{1}", "{2}"))
            ?? base.Arity_min_not_reached(argumentName, expected, actual);
        public override string Arity_max_exceeded(string argumentName, string expected, string actual) =>
            _localize(base.Arity_max_exceeded("{0}", "{1}", "{2}"))
            ?? base.Arity_max_exceeded(argumentName, expected, actual);
        public override string Parse_ArgumentArity_Expected_single_value(string argumentName) =>
            _localize(base.Parse_ArgumentArity_Expected_single_value("{0}"))
            ?? base.Parse_ArgumentArity_Expected_single_value(argumentName);
        public override string Parse_Assigning_value_to_argument(string? argumentToString, string? defaultValue) =>
            _localize(base.Parse_Assigning_value_to_argument("{0}", "{1}"))
            ?? base.Parse_Assigning_value_to_argument(argumentToString, defaultValue);
        public override string Parse_See_usage(string usage, string helpCommand) =>
            _localize(base.Parse_See_usage("{0}", "{1}"))
            ?? base.Parse_See_usage(usage, helpCommand);
        public override string Parse_Is_not_a_valid(string typeName) =>
            _localize(base.Parse_Is_not_a_valid("{0}"))
            ?? base.Parse_Is_not_a_valid(typeName);
        public override string Parse_Missing_value_for_option(string optionName) =>
            _localize(base.Parse_Missing_value_for_option("{0}"))
            ?? base.Parse_Missing_value_for_option(optionName);
        public override string Parse_Unrecognized_value_for(string token, string argumentType, string argumentName) =>
            _localize(base.Parse_Unrecognized_value_for("{0}", "{1}", "{2}"))
            ?? base.Parse_Unrecognized_value_for(token, argumentType, argumentName);
        public override string Parse_Unexpected_value_for_option(string token, string optionName) =>
            _localize(base.Parse_Unexpected_value_for_option("{0}", "{1}"))
            ?? base.Parse_Unexpected_value_for_option(token, optionName);
        public override string Parse_Intended_command_instead_of_option(string token, string commandName, string suggestion) =>
            _localize(base.Parse_Intended_command_instead_of_option("{0}", "{1}", "{2}"))
            ?? base.Parse_Intended_command_instead_of_option(token, commandName, suggestion);
        public override string Parse_Clubbed_options_with_values_must_be_last_option(string optionShortName, string token) =>
            _localize(base.Parse_Clubbed_options_with_values_must_be_last_option("{0}", "{1}"))
            ?? base.Parse_Clubbed_options_with_values_must_be_last_option(optionShortName, token);
        public override string Parse_Unrecognized_command_or_argument(string token) =>
            _localize(base.Parse_Unrecognized_command_or_argument("{0}"))
            ?? base.Parse_Unrecognized_command_or_argument(token);
        public override string Parse_Unrecognized_option(string optionName) =>
            _localize(base.Parse_Unrecognized_option("{0}"))
            ?? base.Parse_Unrecognized_option(optionName);
        public override string Input_Piped_targetted_multiple_arguments(string argumentNames) =>
            _localize(base.Input_Piped_targetted_multiple_arguments("{0}"))
            ?? base.Input_Piped_targetted_multiple_arguments(argumentNames);
        public override string Error_File_not_found(string fullPath) =>
            _localize(base.Error_File_not_found("{0}"))
            ?? base.Error_File_not_found(fullPath);
        public override string Error_Value_is_not_valid_for_type(string value, string typeDisplayName) =>
            _localize(base.Error_Value_is_not_valid_for_type("{0}", "{1}"))
            ?? base.Error_Value_is_not_valid_for_type(value, typeDisplayName);
        public override string Error_Failed_parsing_value_for_type(string value, string typeDisplayName) =>
            _localize(base.Error_Failed_parsing_value_for_type("{0}", "{1}"))
            ?? base.Error_Failed_parsing_value_for_type(value, typeDisplayName);

    }
}