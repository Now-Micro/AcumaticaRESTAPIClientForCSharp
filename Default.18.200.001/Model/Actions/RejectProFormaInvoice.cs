
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
[DataContract]
 public partial class RejectProFormaInvoice : EntityAction<ProFormaInvoice>
    {
 public RejectProFormaInvoice(ProFormaInvoice entity) : base(entity)
        { }

[DataMember(Name = "entity", EmitDefaultValue = false)]
        public ProFormaInvoice Entity
        {
            get
            {
                return _Entity;
            }
            set
            {
                _Entity = value;
            }
        }
    }
}