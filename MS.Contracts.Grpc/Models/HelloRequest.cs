﻿using System.Runtime.Serialization;

namespace MS.Contracts.Grpc.Models
{
	[DataContract]
	public class HelloRequest
	{
		[DataMember(Order = 1)]
		public string Name { get; set; }
	}
}