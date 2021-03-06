﻿using Microsoft.Extensions.Options;
using Orchard.Environment.Extensions;

namespace Orchard.Tests.Stubs
{
    public class StubManifestOptions : IOptions<ManifestOptions>
    {
        private ManifestOption[] _options;
        public StubManifestOptions(params ManifestOption[] options)
        {
            _options = options;
        }

        public ManifestOptions Value
        {
            get
            {
                var options = new ManifestOptions();

                foreach (var option in _options)
                {
                    options.ManifestConfigurations.Add(option);
                }

                return options;
            }
        }
    }
}