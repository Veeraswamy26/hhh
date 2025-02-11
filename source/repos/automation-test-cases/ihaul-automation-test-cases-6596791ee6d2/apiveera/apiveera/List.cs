using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiveera
{
    public partial class list
    {

        public long Status { get; set; }
        public string Message { get; set; }
        public List<Datum> Data { get; set; }
    }

    public partial class Datum
    {
        public string Id { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
        public string ReferralCode { get; set; }
        public NotificationSettings NotificationSettings { get; set; }
        public string ProfilePicture { get; set; }
        public string Pin { get; set; }
        public string InviteCode { get; set; }
        public string ResetPassToken { get; set; }
        public string EmailOtp { get; set; }
        public string PhoneNumberOtp { get; set; }
        public string EmailSent { get; set; }
        public string PhoneNumberSent { get; set; }
        public string StripeCusId { get; set; }
        public bool IsDiscountApplicable { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public bool IsApprovedByAdmin { get; set; }
        public bool IsProfileUpdated { get; set; }
        public bool IsVehicleDetailsUpdated { get; set; }
        public bool IsW9FormUpdated { get; set; }
        public string SocketId { get; set; }
        public string StripeAccId { get; set; }
        public string TotalCanceledMove { get; set; }
        public string MoverStatus { get; set; }
        public string MoverType { get; set; }
        public string BusinessTaxId { get; set; }
        public object CheckList { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public DateTimeOffset LastLoginTime { get; set; }
    }

    public partial class NotificationSettings
    {
        public bool NewOfferReceived { get; set; }
        public bool MoveUpdate { get; set; }
    }
}