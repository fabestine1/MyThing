using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class ApproveManagerRequests : Form
    {
        List<RequestControl> controls;
        List<FiringRequests> firingRequests;
        List<HiringRequests> hiringRequests;
        public ApproveManagerRequests()
        {
            InitializeComponent();
            controls = new List<RequestControl>();
            UpdateGUI();
        }

        public void UpdateGUI()
        {
            firingRequests = null;
            controls.Clear();
            flpRequests.Controls.Clear();
            firingRequests = FiringRequests.GetAllFiringRequests();
            hiringRequests = HiringRequests.GetAllHiringRequests();

            foreach (FiringRequests fr in firingRequests)
            {
                controls.Add(new RequestControl(fr.PersonId, fr.CreatedById, fr.DepartmentId, fr.Description, fr.FirstName, fr.LastName, fr.Username, this));
            }

            foreach(HiringRequests hr in hiringRequests)
            {
                controls.Add(new RequestControl(hr.PersonId, hr.CreatedById, hr.Username, hr.FirstName, hr.LastName, hr.HourlyWage, hr.DepartmentId, hr.ContractStartDate, hr.PhoneNumber, hr.Email, this));
            }

            foreach (RequestControl request in controls)
            {
                flpRequests.Controls.Add(request);
            }
        }
    }
}
