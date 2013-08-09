using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices.AccountManagement;
using System.ComponentModel;

namespace LocalUsersAndGroupsManagementUtility
{
    public class PrincipalWrapper
    {
        protected Principal _underlyingPrincipal;

        [Category("Common")]
        [Description("The description for this principal.")]
        [DefaultValue("")]
        public string Description
        {
            get
            {
                return _underlyingPrincipal.Description;
            }
            set
            {
                _underlyingPrincipal.Description = value;
            }
        }

        [Category("Common")]
        [DisplayName("Display Name")]
        [Description("The display name for this principal.")]
        [DefaultValue("")]
        public string DisplayName
        {
            get
            {
                return _underlyingPrincipal.DisplayName;
            }
            set
            {
                _underlyingPrincipal.DisplayName = value;
            }
        }

        [Category("Principal Properties")]
        [Description("The distinguished name for this principal.")]
        [DefaultValue("")]
        [DisplayName("Distinguished Name")]
        public string DistinguishedName
        {
            get
            {
                return _underlyingPrincipal.DistinguishedName;
            }
        }

        [Category("Principal Properties")]
        [Description("The GUID associated with this principal.")]
        public Guid? Guid
        {
            get
            {
                return _underlyingPrincipal.Guid;
            }
        }

        [Category("Common")]
        [Description("The name of this principal.")]
        [DefaultValue("")]
        public string Name
        {
            get
            {
                return _underlyingPrincipal.Name;
            }
            set
            {
                _underlyingPrincipal.Name = value;
            }
        }

        [Category("Principal Properties")]
        [DisplayName("SAM Account Name")]
        [Description("The SAM account name of this principal.")]
        [DefaultValue("")]
        public string SamAccountName
        {
            get
            {
                return _underlyingPrincipal.SamAccountName;
            }
            set
            {
                _underlyingPrincipal.SamAccountName = value;
            }
        }

        [Category("Principal Properties")]
        [DisplayName("Security ID")]
        [Description("The security ID (SID) of this principal.")]
        public System.Security.Principal.SecurityIdentifier Sid
        {
            get
            {
                return _underlyingPrincipal.Sid;
            }
        }

        [Category("Principal Properties")]
        [Description("The structural object class directory attribute of this Principal.")]
        public string StructuralObjectClass
        {
            get
            {
                return _underlyingPrincipal.StructuralObjectClass;
            }
        }

        [Category("Principal Properties")]
        [DisplayName("User Principal Name")]
        [Description("The user principal name (UPN) associated with this Principal.")]
        public string UserPrincipalName
        {
            get
            {
                return _underlyingPrincipal.UserPrincipalName;
            }
        }

        public PrincipalWrapper(Principal underlying)
        {
            _underlyingPrincipal = underlying;
        }
    }
}
