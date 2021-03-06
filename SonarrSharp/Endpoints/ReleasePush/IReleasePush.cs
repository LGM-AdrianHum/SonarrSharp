﻿using SonarrSharp.Enum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SonarrSharp.Endpoints.ReleasePush
{
    /// <summary>
    /// ReleasePush endpoint client
    /// </summary>
    public interface IReleasePush
    {
        /// <summary>
        /// No description
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="downloadUrl">The download URL.</param>
        /// <param name="protocol">Download protocol</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        Task<List<Models.ReleasePush>> PushRelease(string title, string downloadUrl, Protocol protocol, DateTime date);
    }
}
