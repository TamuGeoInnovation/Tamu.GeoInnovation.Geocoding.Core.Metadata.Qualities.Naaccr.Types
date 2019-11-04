namespace USC.GISResearchLab.Geocoding.Core.Metadata.Qualities
{

    public enum NAACCRGISCoordinateQualityType
    {
        Unknown,
        AddressPoint,
        GPS,
        Parcel,
        StreetSegmentInterpolation,
        StreetIntersection,
        StreetCentroid,
        AddressZIPPlus4Centroid,
        AddressZIPPlus2Centroid,
        ManualLookup,
        AddressZIPCentroid,
        POBoxZIPCentroid,
        CityCentroid,
        CountyCentroid,
        Unmatchable,
        Missing
    }
}
