// this file generated by ResourceProxyTests.RegenerateProxyClasses

using System;

namespace CommandDotNet.DataAnnotations
{
    // this class generated by ResourcesDef.GenerateProxyClass
    public class ResourcesProxy : Resources
    {
        private readonly Func<string, string?> _localize;

        public ResourcesProxy(Func<string, string?> localize)
        {
            _localize = localize ?? throw new ArgumentNullException(nameof(localize));
        }

        public override string Error_DataAnnotation_phrases_to_replace_with_argument_name() =>
            _localize(base.Error_DataAnnotation_phrases_to_replace_with_argument_name())
            ?? base.Error_DataAnnotation_phrases_to_replace_with_argument_name();

    }
}