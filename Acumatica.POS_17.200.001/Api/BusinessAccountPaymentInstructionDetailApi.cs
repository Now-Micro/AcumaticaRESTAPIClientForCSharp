using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.POS_17_200_001.Model;

namespace Acumatica.POS_17_200_001.Api
{
	public partial class BusinessAccountPaymentInstructionDetailApi : EntityAPI<BusinessAccountPaymentInstructionDetail>
	{
		public BusinessAccountPaymentInstructionDetailApi(Configuration configuration) : base(configuration)
		{ }
	}
}