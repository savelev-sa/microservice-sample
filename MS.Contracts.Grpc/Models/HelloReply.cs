using System.Runtime.Serialization;

namespace MS.Contracts.Grpc.Models
{
	[DataContract]
	public class HelloReply
	{
		[DataMember(Order = 1)]
		public string Message { get; set; }
	}
}