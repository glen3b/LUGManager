using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DirectoryServices.AccountManagement;
using System.ComponentModel;

namespace LocalUsersAndGroupsManagementUtility
{
    public class GroupPrincipalWrapper : PrincipalWrapper
    {
        private GroupPrincipal principal
        {
            get { return _underlyingPrincipal as GroupPrincipal; }
            set { _underlyingPrincipal = value; }
        }


        public GroupPrincipalWrapper(GroupPrincipal underlying)
            : base(underlying)
        {
        }

        [Category("Common")]
        [DisplayName("Members")]
        [Description("A collection of principal objects that represent the members of this group.")]
        [DefaultValue(true)]
        public PrincipalCollection Members
        {
            get
            {
                return principal.Members;
            }
        }

        [Category("GroupPrincipal Properties")]
        [DisplayName("Security enabled")]
        [Description("A nullable boolean that indicates whether this group is security enabled.")]
        [DefaultValue(true)]
        public bool? IsSecurityGroup
        {
            get
            {
                return principal.IsSecurityGroup;
            }
            set
            {
                principal.IsSecurityGroup = value;
            }
        }

        [Category("GroupPrincipal Properties")]
        [DisplayName("Group Scope")]
        [Description("A nullable GroupScore enumeration that specifies the scope for this group principal.")]
        [DefaultValue(System.DirectoryServices.AccountManagement.GroupScope.Local)]
        public GroupScope? GroupScope
        {
            get
            {
                return principal.GroupScope;
            }
            set
            {
                principal.GroupScope = value;
            }
        }
    }
}
