﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.WebJobs.Extensions.Kafka.LangEndToEndTests.Common;

/* Represents the app types supported in kafka extension - 
* Single Mode consumes one message at a time
* Batch Mode consumes a batch of message for processing at a time
*/
public enum AppType
{
	SINGLE_EVENT,
	BATCH_EVENT
}