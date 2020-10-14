using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Model;
using System.Data;

namespace EmployeeDetails_Swapnil
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {

        EmployeeDetail_Model model = new EmployeeDetail_Model();
        EmployeeDetail_BAL bal = new EmployeeDetail_BAL();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillFirstName();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            model.FirstName = txtFirstName.Text;
            model.LastName = txtLastName.Text;
            model.DOB = Convert.ToDateTime(txtDOB.Text);
            model.Gender = drpGender.SelectedValue;
            model.MaritalStatus = drpMaritalStatus.SelectedValue;
            model.Country = drpCountry.SelectedValue;
            model.State = drpState.SelectedValue;
            model.Address = txtAddress.Text;
            model.Hobbies = txtHobbies.Text;

            int res = bal.SaveEmployeeDetail(model);

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDOB.Text = "";
            drpGender.SelectedValue = "";
            drpMaritalStatus.SelectedValue = "";
            drpCountry.SelectedValue = "";
            drpState.SelectedValue = "";
            txtAddress.Text = "";
            txtHobbies.Text = "";

            if (res > 0)
            {
                Response.Write("<Script>alert('Record saved Successfully......')</Script>");
            }
            else
            {
                Response.Write("<Script>alert('Error Occured while performing Action ......')</Script>");
            }
        }


        public void FillFirstName()
        {
            DataTable dt = new DataTable();
            dt = bal.FillFirstName();

            drpSearch.Items.Clear();
            drpSearch.DataSource = dt;
            drpSearch.DataTextField = "FirstName";
            drpSearch.DataValueField = "EmpId";
            drpSearch.DataBind();
            drpSearch.Items.Insert(0, "Select");
            drpSearch.SelectedIndex = 0;
        
        }

        protected void drpSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int EmpId = Convert.ToInt32(drpSearch.SelectedValue);
            dt = bal.SearchEmployeeDetail(EmpId);

            txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
            txtLastName.Text = dt.Rows[0]["LastName"].ToString();
            txtDOB.Text = dt.Rows[0]["DOB"].ToString();
            drpGender.SelectedValue = dt.Rows[0]["Gender"].ToString();
            drpMaritalStatus.SelectedValue = dt.Rows[0]["MaritalStatus"].ToString();
            drpCountry.SelectedValue = dt.Rows[0]["Country"].ToString();
            drpState.SelectedValue = dt.Rows[0]["State"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            txtHobbies.Text = dt.Rows[0]["Hobbies"].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            
            model.EmpId=Convert.ToInt32(drpSearch.SelectedValue);
            model.FirstName = txtFirstName.Text;
            model.LastName = txtLastName.Text;
            model.DOB = Convert.ToDateTime(txtDOB.Text);
            model.Gender = drpGender.SelectedValue;
            model.MaritalStatus = drpMaritalStatus.SelectedValue;
            model.Country = drpCountry.SelectedValue;
            model.State = drpState.SelectedValue;
            model.Address = txtAddress.Text;
            model.Hobbies = txtHobbies.Text;

            int res = bal.UpdateEmployeeDetail(model);

            if (res > 0)
            {
                Response.Write("<Script>alert('Record Updated Successfully......')</Script>");
            }
            else
            {
                Response.Write("<Script>alert('Error Occured while performing Action ......')</Script>");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            model.EmpId=Convert.ToInt32(drpSearch.SelectedValue);
            model.FirstName = txtFirstName.Text;
            model.LastName = txtLastName.Text;
            model.DOB = Convert.ToDateTime(txtDOB.Text);
            model.Gender = drpGender.SelectedValue;
            model.MaritalStatus = drpMaritalStatus.SelectedValue;
            model.Country = drpCountry.SelectedValue;
            model.State = drpState.SelectedValue;
            model.Address = txtAddress.Text;
            model.Hobbies = txtHobbies.Text;

            int res = bal.DeleteEmployeeDetail(model);

            
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDOB.Text = "";
            drpGender.SelectedValue = "";
            drpMaritalStatus.SelectedValue = "";
            drpCountry.SelectedValue = "";
            drpState.SelectedValue = "";
            txtAddress.Text = "";
            txtHobbies.Text = "";

            if (res > 0)
            {
                Response.Write("<Script>alert('Record Deleted Successfully......')</Script>");
            }
            else
            {
                Response.Write("<Script>alert('Error Occured while performing Action ......')</Script>");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeDetails.aspx");
        }

        }

        }
    

