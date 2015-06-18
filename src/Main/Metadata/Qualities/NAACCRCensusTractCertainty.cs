using System;
using System.Data;
using USC.GISResearchLab.Census.Core.Configurations.ServerConfigurations;
using USC.GISResearchLab.Common.Addresses.AbstractClasses;

using USC.GISResearchLab.Geocoding.Core.Queries.Parameters;

namespace USC.GISResearchLab.Geocoding.Core.Metadata.Qualities
{

    public enum NAACCRCensusTractCertaintyType
    {
        Unknown,
        ResidenceStreetAddress,
        ResidenceZIPPlus4,
        ResidenceZIPPlus2,
        ResidenceZIP,
        POBoxZIP,
        ResidenceCityOrZIPWithOneCensusTract,
        Missing,
        Unmatchable,
        NotAttempted,
    }
}
