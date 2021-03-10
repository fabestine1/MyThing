using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StudentWiseApi
{
    /// <summary>
    /// A generic class to hold parsed JSON and access its members.
    /// </summary>
    internal class ParsedJson
    {
        [JsonExtensionData]
        public Dictionary<string, JsonElement> Members { get; set; }
        internal const string invalid_data_msg = "Unexpected data format encountered.";

        public int GetInt(string name)
        {
            if (Members.TryGetValue(name, out JsonElement result) &&
                result.ValueKind == JsonValueKind.Number)
                    return result.GetInt32();

            throw new Exception(invalid_data_msg);
        }

        public string GetString(string name)
        {
            if (Members.TryGetValue(name, out JsonElement result))
                switch (result.ValueKind)
                {
                    case JsonValueKind.String:
                        return result.GetString();
                    case JsonValueKind.Null:
                        return null;
                    default:
                        throw new Exception(invalid_data_msg);
                }

            return null;
        }

        public bool GetBool(string name)
        {
            if (Members.TryGetValue(name, out JsonElement result))
                switch (result.ValueKind)
                {
                    case JsonValueKind.True:
                    case JsonValueKind.False:
                        return result.GetBoolean();
                }

            throw new Exception(invalid_data_msg);
        }

        public decimal GetDecimal(string name)
        {
            if (Members.TryGetValue(name, out JsonElement result) &&
                result.ValueKind == JsonValueKind.String)
                try
                {
                    return Convert.ToDecimal(result.GetString(), CultureInfo.InvariantCulture);
                }
                catch (FormatException e)
                {
                    throw new Exception(invalid_data_msg, e);
                }

            throw new Exception(invalid_data_msg);
        }

        public DateTime? GetDateTime(string name, bool allow_null)
        {
            if (Members.TryGetValue(name, out JsonElement result))
            {
                if (allow_null && result.ValueKind == JsonValueKind.Null)
                    return null;

                if (result.ValueKind == JsonValueKind.String)
                    try
                    {
                        return result.GetDateTime().ToLocalTime();
                    }
                    catch (FormatException e)
                    {
                        throw new Exception(invalid_data_msg, e);
                    }

            }

            if (allow_null)
                return null;

            throw new Exception(invalid_data_msg);
        }

        public TEnum GetEnum<TEnum>(string name) where TEnum : struct
        {
            if (Members.TryGetValue(name, out JsonElement element))
            {
                if (element.ValueKind == JsonValueKind.String &&
                    Enum.TryParse(element.GetString(), true, out TEnum result))
                    return result;
            }

            throw new Exception(invalid_data_msg);
        }

        public ParsedJson GetObject(string name)
        {
            if (Members.TryGetValue(name, out JsonElement result) && result.ValueKind == JsonValueKind.Object)
                return Parse(result.GetRawText());

            throw new Exception(invalid_data_msg);
        }

        public List<ParsedJson> GetArray(string name)
        {
            if (Members.TryGetValue(name, out JsonElement result) && result.ValueKind == JsonValueKind.Array)
                return ParseArray(result.GetRawText());

            throw new Exception(invalid_data_msg);
        }

        public static ParsedJson Parse(string json, JsonSerializerOptions options = null)
        {
            try
            {
                return JsonSerializer.Deserialize<ParsedJson>(json, options);
            }
            catch (JsonException e)
            {
                throw new Exception(invalid_data_msg, e);
            }
        }

        public static List<ParsedJson> ParseArray(string json, JsonSerializerOptions options = null)
        {
            try
            {
                var root = JsonDocument.Parse(json).RootElement;

                if (root.ValueKind != JsonValueKind.Array)
                    throw new Exception(invalid_data_msg + Environment.NewLine + "Array type expected.");

                var result = new List<ParsedJson>(root.GetArrayLength());

                foreach (JsonElement element in root.EnumerateArray())
                {
                    result.Add(Parse(element.GetRawText(), options));
                }
                return result;
            }
            catch (JsonException e)
            {
                throw new Exception(invalid_data_msg, e);
            }            
        }
    }
}
