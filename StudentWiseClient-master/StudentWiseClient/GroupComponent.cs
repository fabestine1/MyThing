using System.Windows.Forms;
using StudentWiseApi;

namespace StudentWiseClient
{
    public partial class GroupComponent : UserControl
    {
        public GroupComponent(Group group)
        {
            InitializeComponent();
            LoadGroupData(group);
        }

        private void LoadGroupData(Group group)
        {
            lblName.Text = group.Name.UppercaseFirst();
            lblDescription.Text = group.Description.UppercaseFirst();
            lblRules.Text = group.Rules.UppercaseFirst();
        }
    }
}
