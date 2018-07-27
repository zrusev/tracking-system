﻿namespace Metrics_Track.Infrastructure.Mapping
{
    using AutoMapper;
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(profile =>
            {
                profile.AddProfile<AutoMapperProfile>();
            });

            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
