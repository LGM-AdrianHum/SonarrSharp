﻿using System;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Endpoints.Series.Data
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Statistics
    {
        /// <summary>
        /// Gets or sets the previous airing.
        /// </summary>
        /// <value>
        /// The previous airing.
        /// </value>
        [J("previousAiring")] public DateTimeOffset PreviousAiring { get; set; }

        /// <summary>
        /// Gets or sets the episode file count.
        /// </summary>
        /// <value>
        /// The episode file count.
        /// </value>
        [J("episodeFileCount")] public long EpisodeFileCount { get; set; }

        /// <summary>
        /// Gets or sets the episode count.
        /// </summary>
        /// <value>
        /// The episode count.
        /// </value>
        [J("episodeCount")] public long EpisodeCount { get; set; }

        /// <summary>
        /// Gets or sets the total episode count.
        /// </summary>
        /// <value>
        /// The total episode count.
        /// </value>
        [J("totalEpisodeCount")] public long TotalEpisodeCount { get; set; }

        /// <summary>
        /// Gets or sets the size on disk.
        /// </summary>
        /// <value>
        /// The size on disk.
        /// </value>
        [J("sizeOnDisk")] public long SizeOnDisk { get; set; }

        /// <summary>
        /// Gets or sets the percent of episodes.
        /// </summary>
        /// <value>
        /// The percent of episodes.
        /// </value>
        [J("percentOfEpisodes")] public long PercentOfEpisodes { get; set; }
    }
}
