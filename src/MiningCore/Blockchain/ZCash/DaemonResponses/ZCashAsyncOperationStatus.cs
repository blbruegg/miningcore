﻿using System;
using System.Collections.Generic;
using System.Text;
using MiningCore.JsonRpc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MiningCore.Blockchain.ZCash.DaemonResponses
{
    public class ZOperationStatus
    {
		[JsonProperty("operationid")]
		public string OperationId { get; set; }

	    public string Status { get; set; }
		public JToken Result { get; set; }
	    public JsonRpcException Error { get; set; }
    }
}