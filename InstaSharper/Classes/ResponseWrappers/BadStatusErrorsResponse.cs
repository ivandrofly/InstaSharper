﻿using InstaSharper.Classes.ResponseWrappers.BaseResponse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaSharper.Classes.ResponseWrappers
{
    public class BadStatusErrorsResponse : BaseStatusResponse
    {
        [JsonProperty("message")]
        public MessageErrorsResponse Message { get; set; }
    }

    public class MessageErrorsResponse
    {
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
    }
}
