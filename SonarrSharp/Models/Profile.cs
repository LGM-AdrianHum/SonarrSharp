﻿using System.Collections.Generic;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace SonarrSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Profile
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [J("name")] public string Name { get; set; }

        /// <summary>
        /// Gets or sets the cutoff.
        /// </summary>
        /// <value>
        /// The cutoff.
        /// </value>
        [J("cutoff")] public Cutoff Cutoff { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [J("items")] public List<Item> Items { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [J("id")] public int Id { get; set; }
    }
}
