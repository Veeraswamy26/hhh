namespace Api_Testing.Support
{
    public class DataModel
    {
        public class Rootobject
        {

            public long Status { get; set; }
            public string Message { get; set; }
            public List<Datum> Datum { get; set; }
        }

        public  class Datum
        {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public UserType UserType { get; set; }
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
            public MoverStatus MoverStatus { get; set; }
            public MoverType MoverType { get; set; }
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

        public enum MoverStatus { Pending };

        public enum MoverType { Individual };

        public enum UserType { Customer };
    }
}
