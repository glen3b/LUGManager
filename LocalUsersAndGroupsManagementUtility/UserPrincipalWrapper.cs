using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices.AccountManagement;
using System.ComponentModel;

namespace LocalUsersAndGroupsManagementUtility
{
    public class UserPrincipalWrapper : PrincipalWrapper
    {
        private UserPrincipal principal
        {
            get { return _underlyingPrincipal as UserPrincipal; }
            set { _underlyingPrincipal = value; }
        }


        public UserPrincipalWrapper(UserPrincipal underlying)
            : base(underlying)
        {
        }

        [Category("UserPrincipal Properties")]
        [Description("A boolean that specifies whether reversible password encryption is enabled for this account.")]
        [DefaultValue(false)]
        public bool AllowReversiblePasswordEncryption
        {
            get { return principal.AllowReversiblePasswordEncryption; }
            set { principal.AllowReversiblePasswordEncryption = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("A boolean that specifies whether the account may be delegated.")]
        [DefaultValue(true)]
        public bool DelegationPermitted
        {
            get { return principal.DelegationPermitted; }
            set { principal.DelegationPermitted = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The email address for this account.")]
        [DefaultValue("")]
        [DisplayName("Email Address")]
        public string EmailAddress
        {
            get { return principal.EmailAddress; }
            set { principal.EmailAddress = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The employee ID for this account.")]
        [DefaultValue("")]
        [DisplayName("Employee ID")]
        public string EmployeeId
        {
            get { return principal.EmployeeId; }
            set { principal.EmployeeId = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The given name for this user principal.")]
        [DefaultValue("")]
        [DisplayName("Given Name")]
        public string GivenName
        {
            get { return principal.GivenName; }
            set { principal.GivenName = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The home directory for this account.")]
        [DefaultValue("")]
        [DisplayName("Home Directory")]
        public string HomeDirectory
        {
            get { return principal.HomeDirectory; }
            set { principal.HomeDirectory = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The home drive for this account.")]
        [DefaultValue("")]
        [DisplayName("Home Drive")]
        public string HomeDrive
        {
            get { return principal.HomeDrive; }
            set { principal.HomeDrive = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The nullable DateTime that specifies the date and time of the last incorrect password attempt on this account.")]
        [DefaultValue(null)]
        public DateTime? LastBadPasswordAttempt
        {
            get { return principal.LastBadPasswordAttempt; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The nullable DateTime that specifies the date and time of the last logon for this account.")]
        [DisplayName("Last Logon")]
        [DefaultValue(null)]
        public DateTime? LastLogon
        {
            get { return principal.LastLogon; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The middle name for this user principal.")]
        [DefaultValue("")]
        [DisplayName("Middle Name")]
        public string MiddleName
        {
            get { return principal.MiddleName; }
            set { principal.MiddleName = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("A boolean that specifies whether the password expires for this account.")]
        [DefaultValue(true)]
        [DisplayName("Password Never Expires")]
        public bool PasswordNeverExpires
        {
            get { return principal.PasswordNeverExpires; }
            set { principal.PasswordNeverExpires = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("A boolean that specifies whether a password is required for this account.")]
        [DefaultValue(false)]
        [DisplayName("Password Not Required")]
        public bool PasswordNotRequired
        {
            get { return principal.PasswordNotRequired; }
            set { principal.PasswordNotRequired = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The times when the principal can logon.")]
        [DefaultValue(new byte[] { 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 })]
        public byte[] PermittedLogonTimes
        {
            get { return principal.PermittedLogonTimes; }
            set { principal.PermittedLogonTimes = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The list of workstations that the principal is permitted to logon to.")]
        public PrincipalValueCollection<string> PermittedWorkstations
        {
            get { return principal.PermittedWorkstations; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The script path for this account.")]
        [DefaultValue("")]
        public string ScriptPath
        {
            get { return principal.ScriptPath; }
            set { principal.ScriptPath = value;  }
        }

        [Category("UserPrincipal Properties")]
        [Description("Whether a smartcard is required to logon to this account.")]
        [DefaultValue(false)]
        [DisplayName("Smartcard Logon Required")]
        public bool SmartcardLogonRequired
        {
            get { return principal.SmartcardLogonRequired; }
            set { principal.SmartcardLogonRequired = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The surname for the user principal.")]
        [DefaultValue("")]
        public string Surname
        {
            get { return principal.Surname; }
            set { principal.Surname = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("A value that specifies whether the user can change the password for this account.")]
        [DefaultValue(false)]
        public bool UserCannotChangePassword
        {
            get { return principal.UserCannotChangePassword; }
            set { principal.UserCannotChangePassword = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("The voice telephone number for the user principal.")]
        [DefaultValue("")]
        [DisplayName("Voice Telephone Number")]
        public string VoiceTelephoneNumber
        {
            get { return principal.VoiceTelephoneNumber; }
            set { principal.VoiceTelephoneNumber = value; }
        }

        [Category("UserPrincipal Properties")]
        [Description("A nullable DateTime that specifies the date and time that the account expires.")]
        [DefaultValue(null)]
        [DisplayName("Expiration Date")]
        public DateTime? AccountExpirationDate
        {
            get
            {
                return principal.AccountExpirationDate;
            }
            set
            {
                principal.AccountExpirationDate = value;
            }
        }

        [Category("UserPrincipal Properties")]
        [DisplayName("Lockout Time")]
        [Description("A nullable DateTime that specifies the date and time that the account was locked out.")]
        [DefaultValue(null)]
        public DateTime? AccountLockoutTime
        {
            get
            {
                return principal.AccountLockoutTime;
            }
        }

        [Category("Common")]
        [Description("The number of logon attempts using incorrect credentials for this account.")]
        [DefaultValue(0)]
        public int BadLogonCount
        {
            get
            {
                return principal.BadLogonCount;
            }
        }

        [Category("UserPrincipal Properties")]
        [Description("A collection of X5092 certificates for this account.")]
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates
        {
            get
            {
                return principal.Certificates;
            }
        }



        [Category("Common")]
        [Description("A nullable boolean specifying whether or not this account is enabled for authentication.")]
        [DefaultValue(true)]
        public bool? Enabled
        {
            get
            {
                
                return principal.Enabled;
            }
            set
            {
                principal.Enabled = value;
            }
        }
    }
}
