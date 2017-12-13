using System;
using Newtonsoft.Json;

namespace Ditch.Steem.Objects
{
    /// <summary>
    /// feed_entry
    /// libraries\plugins\follow\include\steemit\follow\follow_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class FeedEntry
    {
        /// <summary>
        /// API name: author
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("author")]
        public string Author {get; set;}

        /// <summary>
        /// API name: permlink
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("permlink")]
        public string Permlink {get; set;}

        /// <summary>
        /// API name: reblog_by
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("reblog_by")]
        public string[] ReblogBy {get; set;}

        /// <summary>
        /// API name: reblog_on
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("reblog_on")]
        public DateTime ReblogOn {get; set;}

        /// <summary>
        /// API name: entry_id
        /// = 0;
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("entry_id")]
        public UInt32 EntryId {get; set;}
    }
}
