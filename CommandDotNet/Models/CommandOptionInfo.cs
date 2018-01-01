﻿using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;
using CommandDotNet.Attributes;
using CommandDotNet.Exceptions;
using CommandDotNet.MicrosoftCommandLineUtils;

namespace CommandDotNet.Models
{
    public class CommandOptionInfo : ArgumentInfo
    {
        public CommandOptionInfo(AppSettings settings) : base(settings)
        {
        }

        public CommandOptionInfo(ParameterInfo parameterInfo, AppSettings settings) : base(parameterInfo, settings)
        {
            BooleanMode = GetBooleanMode();
            CommandOptionType = GetCommandOptionType();
            
            ShortName = GetShortName();
            LongName = GetLongName();
            
            Template = GetTemplate();
            
            TypeDisplayName = GetTypeDisplayName();
            AnnotatedDescription = GetAnnotatedDescription();
            Details = GetDetails();
            EffectiveDescription = GetEffectiveDescription();
        }
        
        public CommandOptionType CommandOptionType { get; set; }
        
        public string Template { get; set; }
        
        public BooleanMode BooleanMode { get; set; }
        
        public string LongName { get; }
        
        public string ShortName { get; }
        
        private string GetShortName()
        {
            string attributeShortName = ParameterInfo.GetCustomAttribute<OptionAttribute>()?.ShortName;
    
            if (!string.IsNullOrEmpty(attributeShortName)) //provided by user
                return attributeShortName;
    
            //use parameter name as short name 
            return ParameterInfo.Name.Length == 1 ? ParameterInfo.Name.ChangeCase(Settings.Case) : null;
        }

        private string GetLongName()
        {
            string attributeLongName = ParameterInfo.GetCustomAttribute<OptionAttribute>()?.LongName;
    
            if (!string.IsNullOrEmpty(attributeLongName)) //long name attribute provided by user
                return attributeLongName;

            //short name is not present, 
            if(string.IsNullOrEmpty(ShortName) && ParameterInfo.Name.Length > 1)
                return ParameterInfo.Name.ChangeCase(Settings.Case); //return parameter name as long name
    
            //there is no long name
            return null;
        }
        
        private BooleanMode GetBooleanMode()
        {
            OptionAttribute attribute = ParameterInfo.GetCustomAttribute<OptionAttribute>();

            if (attribute == null || attribute.BooleanMode == BooleanMode.Unknown)
                return Settings.BooleanMode;

            if (Type == typeof(bool) || Type == typeof(bool?))
            {
                return attribute.BooleanMode;
            }

            throw new AppRunnerException(
                $"BooleanMode property is set to `{attribute.BooleanMode}` for a non boolean parameter type. " +
                $"Property name: {ParameterInfo.Name} " +
                $"Type : {Type.Name}");
        }
        
        private string GetTemplate()
        {
            StringBuilder sb = new StringBuilder();
    
            bool longNameAdded = false;
            bool shortNameAdded = false;
    
            if (!string.IsNullOrWhiteSpace(LongName))
            {
                sb.Append($"--{LongName}");
                longNameAdded = true;
            }

            if (!string.IsNullOrWhiteSpace(ShortName))
            {
                if (longNameAdded)
                {
                    sb.Append(" | ");
                }

                sb.Append($"-{ShortName}");
                shortNameAdded = true;
            }

            if (!longNameAdded & !shortNameAdded)
            {
                throw new Exception("something went wrong: !longNameAdded & !shortNameAdded");
            }
                
            //if(CommandOptionType != CommandOptionType.NoValue) sb.Append($" <{ValueName}>");
    
            return sb.ToString();
        }
        
        private CommandOptionType GetCommandOptionType()
        {
            if (typeof(IEnumerable).IsAssignableFrom(Type) && Type != typeof(string))
            {
                return CommandOptionType.MultipleValue;
            }

            if ((Type == typeof(bool) || Type == typeof(bool?)) && BooleanMode == BooleanMode.Implicit)
            {
                return CommandOptionType.NoValue;
            }
            
            return CommandOptionType.SingleValue;
        }

        protected override string GetDetails()
        {
            return
                $"{GetTypeDisplayName()}{(DefaultValue != DBNull.Value ? " | Default value: " + DefaultValue : null)}";
        }

        protected override string GetTypeDisplayName()
        {
            if (Type.Name == "String") return Type.Name;

            if (BooleanMode == BooleanMode.Implicit && (Type == typeof(bool) || Type == typeof(bool?)))
            {
                return "Flag";
            }

            if (typeof(IEnumerable).IsAssignableFrom(Type))
            {
                return $"{Type.GetGenericArguments().FirstOrDefault()?.Name} (Multiple)";
            }

            return Nullable.GetUnderlyingType(Type)?.Name ?? Type.Name;
        }
        
        protected override string GetAnnotatedDescription()
        {
            OptionAttribute descriptionAttribute = ParameterInfo.GetCustomAttribute<OptionAttribute>();
            return descriptionAttribute?.Description;
        }
        
        public override string ToString()
        {
            return $"{ParameterInfo.Name} | '{ValueInfo?.Value ?? "null"}' | {Details} | {Template}";
        }
    }
}