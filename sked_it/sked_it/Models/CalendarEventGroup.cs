using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sked_it.Models
{
    /// <summary>
    /// A labeled group of calendar events.
    /// </summary>
    /// <remarks>
    /// This sample groups calendar events by day, so the group title is a formatted date string.
    /// </remarks>
    public class CalendarEventGroup
    {
        /// <summary>
        /// Gets or sets a string to show above the group of events.
        /// </summary>
        [Required]
        public string GroupTitle { get; set; }
        /// <summary>
        /// Gets or sets a sequence of calendar events to show under the group title.
        /// </summary>
        [Required]
        public IEnumerable<Event> Events { get; set; }
    }
}