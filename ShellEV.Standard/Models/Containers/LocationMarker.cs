using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace ShellEV.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<LocationMarker>),
        new Type[] {
            typeof(SingleLocationMarkerCase),
            typeof(MultiLocationMarkerCase)
        },
        new string[] {
            "SingleLocation",
            "MultiLocation"
        },
        "markerType",
        true
    )]
    public abstract class LocationMarker
    {
        /// <summary>
        /// This is SingleLocationMarker case.
        /// </summary>
        /// <returns>
        /// The LocationMarker instance, wrapping the provided SingleLocationMarker value.
        /// </returns>
        public static LocationMarker FromSingleLocationMarker(SingleLocationMarker singleLocationMarker)
        {
            return new SingleLocationMarkerCase().Set(singleLocationMarker);
        }

        /// <summary>
        /// This is MultiLocationMarker case.
        /// </summary>
        /// <returns>
        /// The LocationMarker instance, wrapping the provided MultiLocationMarker value.
        /// </returns>
        public static LocationMarker FromMultiLocationMarker(MultiLocationMarker multiLocationMarker)
        {
            return new MultiLocationMarkerCase().Set(multiLocationMarker);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<SingleLocationMarker, T> singleLocationMarker, Func<MultiLocationMarker, T> multiLocationMarker);

        [JsonConverter(typeof(UnionTypeCaseConverter<SingleLocationMarkerCase, SingleLocationMarker>))]
        private sealed class SingleLocationMarkerCase : LocationMarker, ICaseValue<SingleLocationMarkerCase, SingleLocationMarker>
        {
            public SingleLocationMarker _value;

            public override T Match<T>(Func<SingleLocationMarker, T> singleLocationMarker, Func<MultiLocationMarker, T> multiLocationMarker)
            {
                return singleLocationMarker(_value);
            }

            public SingleLocationMarkerCase Set(SingleLocationMarker value)
            {
                _value = value;
                return this;
            }

            public SingleLocationMarker Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MultiLocationMarkerCase, MultiLocationMarker>))]
        private sealed class MultiLocationMarkerCase : LocationMarker, ICaseValue<MultiLocationMarkerCase, MultiLocationMarker>
        {
            public MultiLocationMarker _value;

            public override T Match<T>(Func<SingleLocationMarker, T> singleLocationMarker, Func<MultiLocationMarker, T> multiLocationMarker)
            {
                return multiLocationMarker(_value);
            }

            public MultiLocationMarkerCase Set(MultiLocationMarker value)
            {
                _value = value;
                return this;
            }

            public MultiLocationMarker Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}