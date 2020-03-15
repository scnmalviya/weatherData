using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GetWeather.Models
{
    public class Weather
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("st")]
        public string st { get; set; }

        [BsonElement("elevation")]
        public int Elevation { get; set; }

        [BsonElement("callLetters")]
        public string CallLetters { get; set; }

        [BsonElement("qualityControlProcess")]
        public string QualityControlProcess { get; set; }

        [BsonElement("dataSource")]
        public string DataSource { get; set; }

        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("ts")]
        public DateTime Ts { get; set; }

        public List<string> sections { get; set; }

        [BsonElement("position")]
        public Position position { get; set; }

        [BsonElement("airTemperature")]
        public AirTemperature airTemperature { get; set; }

        [BsonElement("dewPoint")]
        public DewPoint dewPoint { get; set; }

        [BsonElement("pressure")]
        public Pressure pressure { get; set; }

        [BsonElement("wind")]
        public Wind wind { get; set; }

        [BsonElement("visibility")]
        public visibility visibility { get; set; }

        [BsonElement("skyCondition")]
        public skyCondition skyCondition { get; set; }

        [BsonElement("precipitationEstimatedObservation")]
        public precipitationEstimatedObservation precipitationEstimatedObservation { get; set; }

        [BsonElement("atmosphericPressureChange")]
        public AtmosphericPressureChange AtmosphericPressureChange { get; set; }

        [BsonElement("seaSurfaceTemperature")]
        public seaSurfaceTemperature seaSurfaceTemperature { get; set; }

        [BsonElement("waveMeasurement")]
        public waveMeasurement waveMeasurement { get; set; }

        [BsonElement("pastWeatherObservationManual")]
        public List<pastWeatherObservationManual> pastWeatherObservationManual { get; set; }

        [BsonElement("presentWeatherObservationManual")]
        public List<presentWeatherObservationManual> presentWeatherObservationManual { get; set; }

        [BsonElement("skyConditionObservation")]
        public skyConditionObservation skyConditionObservation { get; set; }

        [BsonElement("atmosphericPressureObservation")]
        public atmosphericPressureObservation atmosphericPressureObservation { get; set; }

        [BsonElement("skyCoverLayer")]
        public List<skyCoverLayer> skyCoverLayer { get; set; }

        [BsonElement("liquidPrecipitation")]
        public List<liquidPrecipitation> liquidPrecipitation { get; set; }

        [BsonElement("extremeAirTemperature")]
        public List<extremeAirTemperature> extremeAirTemperature { get; set; }
    }

    public class extremeAirTemperature
    {
        [BsonElement("period")]
        public double period { get; set; }

        [BsonElement("code")]
        public string code { get; set; }

        [BsonElement("value")]
        public double value { get; set; }

        [BsonElement("quantity")]
        public string quantity { get; set; }
        
    }
    public class liquidPrecipitation
    {
        [BsonElement("period")]
        public int period { get; set; }

        [BsonElement("depth")]
        public Int32 depth { get; set; }

        [BsonElement("condition")]
        public string condition { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }

    }
    public class skyCoverLayer
    {
        [BsonElement("coverage")]
        public coverage coverage { get; set; }

        [BsonElement("baseHeight")]
        public baseHeight baseHeight { get; set; }

        [BsonElement("cloudType")]
        public cloudType cloudType { get; set; }
    }

    public class coverage
    {
        [BsonElement("value")]
        public string value { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class baseHeight
    {
        [BsonElement("value")]
        public double value { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class cloudType
    {
        [BsonElement("value")]
        public string value { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class atmosphericPressureObservation
    {
        [BsonElement("altimeterSetting")]
        public altimeterSetting altimeterSetting
        { get; set; }

        [BsonElement("stationPressure")]
        public stationPressure stationPressure { get; set; }
    }

    public class altimeterSetting
    {
        [BsonElement("value")]
        public double value { get; set; }

        [BsonElement("quality")]
        public int quality { get; set; }
    }

    public class stationPressure
    {
        [BsonElement("value")]
        public double value { get; set; }

        [BsonElement("quality")]
        public int quality { get; set; }
    }
    public class skyConditionObservation
    {
        [BsonElement("totalCoverage")]
        public totalCoverage totalCoverage { get; set; }

        [BsonElement("lowestCloudCoverage")]
        public lowestCloudCoverage lowestCloudCoverage { get; set; }

        [BsonElement("lowCloudGenus")]
        public lowCloudGenus lowCloudGenus { get; set; }

        [BsonElement("lowestCloudBaseHeight")]
        public lowestCloudCoverage lowestCloudBaseHeight { get; set; }

        [BsonElement("midCloudGenus")]
        public midCloudGenus midCloudGenus { get; set; }


        [BsonElement("highCloudGenus")]
        public lowestCloudCoverage highCloudGenus { get; set; }

        
    }

    public class totalCoverage
    {
        [BsonElement("value")]
        public string value { get; set; }

        [BsonElement("opaque")]
        public string opaque { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }

    }

    public class lowestCloudCoverage
    {
        [BsonElement("value")]
        public Int32 value { get; set; }

        [BsonElement("quality")]
        public int quality { get; set; }
    }

    public class lowCloudGenus
    {
        [BsonElement("value")]
        public string value { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class lowestCloudBaseHeight
    {
        [BsonElement("value")]
        public Int32 value { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class midCloudGenus
    {
        [BsonElement("value")]
        public string value { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class highCloudGenus
    {
        [BsonElement("value")]
        public string value { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class presentWeatherObservationManual
    {
        [BsonElement("condition")]
        public string condition { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class pastWeatherObservationManual
    {
        [BsonElement("atmosphericCondition")]
        public atmosphericCondition atmosphericCondition { get; set; }

        [BsonElement("period")]
        public period period { get; set; }

    }

    public class atmosphericCondition
    {
        [BsonElement("value")]
        public string value { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class period
    {
        [BsonElement("value")]
        public Int32 value { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }
    public class Position
    {
        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("coordinates")]
        public List<double> Coordinates { get; set; }
    }

    public class AirTemperature
    {
        [BsonElement("value")]
        public double value { get; set; }
        
        [BsonElement("quality")]
        public string Quality { get; set; }

    }

    public class DewPoint
    {
        [BsonElement("value")]
        public double value { get; set; }
        
        [BsonElement("quality")]
        public string Quality { get; set; }

    }

    public class Pressure
    {
        [BsonElement("value")]
        public double value { get; set; }

        [BsonElement("quality")]
        public string Quality { get; set; }

    }

    public class Wind
    {
        [BsonElement("direction")]
        public Direction direction { get; set; }

        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("speed")]
        public Speed speed { get; set; }
    }

    public class Direction
    {
        [BsonElement("angle")]
        public double Angle { get; set; }

        [BsonElement("quality")]
        public string Quality { get; set; }
    }

    public class Speed
    {
        [BsonElement("rate")]
        public double Rate { get; set; }

        [BsonElement("quality")]
        public string Quality { get; set; }
    }

    public class visibility
    {
        [BsonElement("distance")]
        public Distance distance { get; set; }

        [BsonElement("variability")]
        public Variability variability { get; set; }
    }

    public class Distance
    {
        [BsonElement("value")]
        public Int32 value { get; set; }

        [BsonElement("quality")]
        public string Quality { get; set; }
    }

    public class Variability
    {
        [BsonElement("value")]
        public string value { get; set; }

        [BsonElement("quality")]
        public string Quality { get; set; }
    }
    
    public class skyCondition
    {
        [BsonElement("ceilingHeight")]
        public ceilingHeight ceilingHeight { get; set; }

        [BsonElement("cavok")]
        public string cavok { get; set; }
    }

    public class ceilingHeight
    {
        [BsonElement("value")]
        public double value { get; set; }

        [BsonElement("quality")]
        public string Quality { get; set; }

        [BsonElement("determination")]
        public string determination { get; set; }

    }

    public class precipitationEstimatedObservation
    {
        [BsonElement("discrepancy")]
        public string discrepancy { get; set; }

        [BsonElement("estimatedWaterDepth")]
        public double estimatedWaterDepth { get; set; }
    }

    public class AtmosphericPressureChange
    {
        [BsonElement("tendency")]
        public Tendency tendency { get; set; }

        [BsonElement("quantity3Hours")]
        public quantity3Hours quantity3Hours { get; set; }

        [BsonElement("quantity24Hours")]
        public quantity3Hours quantity24Hours { get; set; }
    }

    public class Tendency
    {
        [BsonElement("code")]
        public string code { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }

    }

    public class quantity3Hours
    {
        [BsonElement("quality")]
        public string quality { get; set; }

        [BsonElement("value")]
        public double value { get; set; }
    }

    public class quantity24Hours
    {
        [BsonElement("quality")]
        public string quality { get; set; }

        [BsonElement("value")]
        public double value { get; set; }
    }

    public class seaSurfaceTemperature
    {
        [BsonElement("quality")]
        public string quality { get; set; }

        [BsonElement("value")]
        public double value { get; set; }
    }

    public class waveMeasurement
    {
        [BsonElement("method")]
        public string method { get; set; }

        [BsonElement("waves")]
        public waves waves { get; set; }

        public seaState seaState { get; set; }
    }

    public class waves
    {
        [BsonElement("period")]
        public int period { get; set; }

        [BsonElement("height")]
        public double height { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }

    public class seaState
    {
        [BsonElement("code")]
        public string code { get; set; }

        [BsonElement("quality")]
        public string quality { get; set; }
    }
}
