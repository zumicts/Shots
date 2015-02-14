﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Shots.Api.Models
{
    public class ShotItem
    {
        private DateTime _time;

        [JsonProperty("react_to")]
        public List<ShotItem> ReactTo { get; set; }

        public Resource Resource { get; set; }

        public DateTime Time
        {
            // Some shots only have the time in the resource
            get { return _time == DateTime.MinValue ? Resource.Time : _time; }
            set { _time = value; }
        }

        public UserInfo User { get; set; }
    }
}