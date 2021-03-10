using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StudentWiseApi;

namespace StudentWiseClient
{
    public partial class GroupDetailedComponent : UserControl
    {
        private Group group;
        private List<User> users;

        public GroupDetailedComponent(Group group, List<User> users)
        {
            this.group = group;
            this.users = users;

            InitializeComponent();
            LoadGroupData();
        }

        private void LoadGroupData()
        {
            lblName.Text = group.Name.UppercaseFirst();
            lblDescription.Text = group.Description.UppercaseFirst();
            lblRules.Text = group.Rules.UppercaseFirst();
            lblDateTime.Text = $"Created on {group.CreatedAt.ToShortDateString()}";

            cbxMembers.Items.AddRange(users.ToArray());
        }

        private void BtnMoveMember_Click(object sender, EventArgs e)
        {
            if (cbxMembers.SelectedIndex == -1)
                throw new Exception("Please, select a user.");

            User user = users[cbxMembers.SelectedIndex];
            user.MoveToGroup(group.Id);

            MessageBox.Show(
                $"Successfully moved {user} to the {group.Name.UppercaseFirst()} group.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void BtnRemoveMember_Click(object sender, EventArgs e)
        {

            if (cbxMembers.SelectedIndex == -1)
                throw new Exception("Please, select a user.");

            User user = users[cbxMembers.SelectedIndex];
            group.RemoveMember(user.Id);

            MessageBox.Show(
                $"Successfully removed {user} from the {group.Name.UppercaseFirst()} group.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
